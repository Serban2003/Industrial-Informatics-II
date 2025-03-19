namespace Exercise2
{
    public partial class ListSelector : Form
    {
        public ListSelector()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "list_items.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    InitialList.Items.Add(line);
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (InitialList.SelectedItem != null)
            {
                String item = InitialList.GetItemText(InitialList.SelectedItem);
                OtherList.Items.Add(item);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OtherList.SelectedItem != null)
            {
                OtherList.Items.Remove(OtherList.SelectedItem);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
