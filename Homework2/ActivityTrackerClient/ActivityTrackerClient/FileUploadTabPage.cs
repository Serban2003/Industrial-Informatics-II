using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    internal class FileUploadTabPage : TabPage
    {
        Label titleLabel;
        Button selectFileButton;
        OpenFileDialog openFileDialog;
        Label fileNameLabel;
        TableLayoutPanel mainTableLayoutPanel;
        TableLayoutPanel activitiesListTableLayoutPanel;
        TableLayoutPanel activityInfoTableLayoutPanel;
        FlowLayoutPanel fileDialogFlowLayoutPanel;
        Label activityTitleLabel;
        Label activityTitleValueLabel;
        Label activityTypeLabel;
        Label activityTypeValueLabel;
        Label activityDurationLabel;
        Label activityDurationValueLabel;
        Label activityGpxFileLabel;
        Label activityGpxFileValueLabel;
        Button addActivityButton;

        public FileUploadTabPage()
        {
            // FileUploadTabPage
            Text = "File Upload";
            Padding = new Padding(GeneralValues.PaddingValue);
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;

            // mainTableLayoutPanel
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.ColumnCount = 1;
            Controls.Add(mainTableLayoutPanel);

            // titleLabel
            titleLabel = new Label();
            titleLabel.Text = "Upload activity by file:";
            titleLabel.Font = GeneralValues.SubtitleFont;
            titleLabel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(titleLabel, 0, 0);

            // fileDialogFlowLayoutPanel
            fileDialogFlowLayoutPanel = new FlowLayoutPanel();
            fileDialogFlowLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(fileDialogFlowLayoutPanel, 0 , 1);

            // selectFileButton
            selectFileButton = new CustomStyleButton();
            selectFileButton.Text = "Select file";
            selectFileButton.AutoSize = true;
            selectFileButton.Click += new EventHandler(ShowFileDialog);
            fileDialogFlowLayoutPanel.Controls.Add(selectFileButton);

            // fileNameLabel
            fileNameLabel = new Label();
            fileNameLabel.AutoSize = true;
            fileNameLabel.Font = GeneralValues.BodyFontSmall;
            fileNameLabel.Anchor = AnchorStyles.None;
            fileDialogFlowLayoutPanel.Controls.Add(fileNameLabel);

            // activitiesListTableLayoutPanel
            activitiesListTableLayoutPanel = new TableLayoutPanel();
            activitiesListTableLayoutPanel.Dock = DockStyle.Fill;
            activitiesListTableLayoutPanel.AutoScroll = true;
            activitiesListTableLayoutPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            activitiesListTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.Controls.Add(activitiesListTableLayoutPanel, 0, 2);
        }

        private void ShowFileDialog(Object sender, EventArgs e)
        {
            // fileDialog
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                activitiesListTableLayoutPanel.Controls.Clear();
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    fileNameLabel.Text = fileInfo.Name;

                    List<Activity> activities = Activity.parseActivityFile(fileInfo.FullName);
                    ShowActivityDetails(activities);

                    if(fileNameLabel.Width > 300)
                    {
                        Int32 height = fileNameLabel.Height;
                        fileNameLabel.AutoSize = false;
                        fileNameLabel.Size = new Size(300, height);
                        fileNameLabel.AutoEllipsis = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Couldn't parse activity!");
                }
            }
        }

        private void ShowActivityDetails(List<Activity> activitiesList)
        {
            Int32 index = 0;
            foreach (Activity activity in activitiesList) {
                // activityInformationTableLayoutPanel
                activityInfoTableLayoutPanel = new TableLayoutPanel();
                activityInfoTableLayoutPanel.AutoSize = true;
                activityInfoTableLayoutPanel.ColumnCount = 2;
                activityInfoTableLayoutPanel.RowCount = 4;
                activityInfoTableLayoutPanel.Font = GeneralValues.BodyFont;
                activitiesListTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                activitiesListTableLayoutPanel.Controls.Add(activityInfoTableLayoutPanel, 0, index);

                // activityTitleLabel
                activityTitleLabel = new Label();
                activityTitleLabel.AutoSize = true;
                activityTitleLabel.Text = "Title: ";
                activityInfoTableLayoutPanel.Controls.Add(activityTitleLabel, 0, 0);

                // activityTitleValueLabel
                activityTitleValueLabel = new Label();
                activityTitleValueLabel.AutoSize = true;
                activityTitleValueLabel.Text = activity.Title;
                activityInfoTableLayoutPanel.Controls.Add(activityTitleValueLabel, 1, 0);

                // activityTypeLabel
                activityTypeLabel = new Label();
                activityTypeLabel.AutoSize = true;
                activityTypeLabel.Text = "Type: ";
                activityInfoTableLayoutPanel.Controls.Add(activityTypeLabel, 0, 1);

                // activityTypeValueLabel
                activityTypeValueLabel = new Label();
                activityTypeValueLabel.AutoSize = true;
                activityTypeValueLabel.Text = activity.Type.ToString();
                activityInfoTableLayoutPanel.Controls.Add(activityTypeValueLabel, 1, 1);

                // activityDurationLabel
                activityDurationLabel = new Label();
                activityDurationLabel.AutoSize = true;
                activityDurationLabel.Text = "Duration: ";
                activityInfoTableLayoutPanel.Controls.Add(activityDurationLabel, 0, 2);

                // activityDurationValueLabel
                activityDurationValueLabel = new Label();
                activityDurationValueLabel.AutoSize = true;
                activityDurationValueLabel.Text = activity.Duration.ToString();
                activityInfoTableLayoutPanel.Controls.Add(activityDurationValueLabel, 1, 2);

                // activityGpxFileLabel
                activityGpxFileLabel = new Label();
                activityGpxFileLabel.AutoSize = true;
                activityGpxFileLabel.Text = "GPX File: ";
                activityInfoTableLayoutPanel.Controls.Add(activityGpxFileLabel, 0, 3);

                // activityGpxFileValueLabel
                activityGpxFileValueLabel = new Label();
                activityGpxFileValueLabel.AutoSize = true;
                activityGpxFileValueLabel.Text = activity.GpxFile;
                activityInfoTableLayoutPanel.Controls.Add(activityGpxFileValueLabel, 1, 3);

                // addActivityButton
                addActivityButton = new CustomStyleButton();
                addActivityButton.AutoSize = true;
                addActivityButton.Text = "Add Activity";
                addActivityButton.Click += (s,e) => UploadActivityForm.AddActivity(activity);
                activityInfoTableLayoutPanel.Controls.Add(addActivityButton, 0, 4);

                index++;
            }
        } 
    }
    
}
