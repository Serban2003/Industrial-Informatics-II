using System.Windows.Forms;

namespace Exercise4
{
    public partial class Exercise4 : Form
    {
        String[] list = { "Car", "Orange", "Banana", "Airplane" };
        public Exercise4()
        {
            InitializeComponent();
            ItemList.Items.AddRange(list);
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemList.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = "https://www.stratstone.com/-/media/stratstone/blog/2024/top-10-best-supercars-of-2024/mclaren-750s-driving-dynamic-hero-1920x774px.ashx";
            }
            else if (ItemList.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = "https://as2.ftcdn.net/v2/jpg/04/20/70/97/1000_F_420709714_6WRLa14NhZ9gKE1UAjJJsxDld5WOMliJ.jpg";
            }
            else if (ItemList.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "https://s.iw.ro/gateway/g/ZmlsZVNvdXJjZT1odHRwJTNBJTJGJTJG/c3RvcmFnZTA2dHJhbnNjb2Rlci5yY3Mt/cmRzLnJvJTJGc3RvcmFnZSUyRjIwMTkl/MkYxMiUyRjA1JTJGMTE0MDI5M18xMTQw/MjkzX0dldHR5SW1hZ2VzLTExNDI4MzUz/OTkuanBnJnc9NzgwJmg9NDQwJmhhc2g9/MDhhYmQ0MTkwNzNlZmRlNzViOGIzNTY4YjkzZDYwMzc=.thumb.jpg";
            }
            else if (ItemList.SelectedIndex == 3)
            {
                pictureBox1.ImageLocation = "https://media.gettyimages.com/id/1147868750/photo/airplane-isolated-on-sky-3d-rendering.jpg?s=2048x2048&w=gi&k=20&c=zxH6zba0L0mscsmWXJkPTghLvf4tTqD-L2eY_h9J9dc=";
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void displayResult()
        {
            String option1 = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            String option2 = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            Console.WriteLine(option1);
            ResultTextBox.Text = option1 + " " + option2;
        }
    }
}
