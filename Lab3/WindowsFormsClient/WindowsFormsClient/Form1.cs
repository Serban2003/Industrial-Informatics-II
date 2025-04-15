using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormClient : Form
    {
        ServiceReference.WebServiceSoapClient service;
        public FormClient()
        {
            service = new ServiceReference.WebServiceSoapClient();
            InitializeComponent();
            dateTimeLabel.Text = service.GetDateTime().ToString();
            timer.Start();
        }

        private void convertCToFButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Double celsiusTemp = Double.Parse(CTempTextBox.Text);
                FTempTextBox.Text = service.ConvertTemperature(celsiusTemp, "CToF").ToString();
            }
            catch{
                MessageBox.Show("Could not convert temperature!");
            }
        }
        private void convertFToCButton_Click(object sender, EventArgs e)
        {
            try
            {
                Double fahrenheitTemp = Double.Parse(FTempTextBox.Text);
                CTempTextBox.Text = service.ConvertTemperature(fahrenheitTemp, "FToC").ToString();
            }
            catch
            {
                MessageBox.Show("Could not convert temperature!");
            }
        }

        private void convertCurrencyButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Double ronCurrency = Double.Parse(ronTextBox.Text);
                euroTextBox.Text = service.ConvertRonToEuro(ronCurrency).ToString();
            }
            catch
            {
                MessageBox.Show("Could not convert currency!");
            }
        }

        private void addListButton_Click(object sender, System.EventArgs e)
        {
            List<String> list = service.GetListItems();
            
            foreach(String item in list)
                listBox.Items.Add(item);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = service.GetDateTime().ToString();
        }
    }
}
