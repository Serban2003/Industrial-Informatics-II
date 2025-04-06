using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityTracker
{
    public partial class UploadActivityForm : Form
    {
        public UploadActivityForm()
        {
            InitializeComponent();

            Text = "Upload Activity";
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.ButtonTextColor;
            Font = GeneralValues.BodyFontSmall;

            uploadSourceTabControl = new TabControl();
            uploadSourceTabControl.Dock = DockStyle.Fill;
    
            Controls.Add(uploadSourceTabControl);

            fileUploadTabPage = new FileUploadTabPage();
            manualUploadTabPage = new ManualUploadTabPage();
            uploadSourceTabControl.TabPages.Add(fileUploadTabPage);
            uploadSourceTabControl.TabPages.Add(manualUploadTabPage);
        }
    }
}
