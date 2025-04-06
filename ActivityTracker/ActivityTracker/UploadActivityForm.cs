namespace ActivityTracker
{
    public partial class UploadActivityForm : Form
    {
        public UploadActivityForm()
        {
            InitializeComponent();

            // UploadActivityForm
            Text = "Upload Activity";
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.ButtonTextColor;
            Font = GeneralValues.BodyFontSmall;

            // uploadSourceTabControl
            uploadSourceTabControl = new TabControl();
            uploadSourceTabControl.Dock = DockStyle.Fill;
            Controls.Add(uploadSourceTabControl);

            // fileUploadTabPage
            fileUploadTabPage = new FileUploadTabPage();
            uploadSourceTabControl.TabPages.Add(fileUploadTabPage);

            // manualUploadTabPage
            manualUploadTabPage = new ManualUploadTabPage();
            uploadSourceTabControl.TabPages.Add(manualUploadTabPage);
        }
    }
}
