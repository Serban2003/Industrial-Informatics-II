﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    internal class ManualUploadTabPage : TabPage
    {
        TableLayoutPanel mainTableLayoutPanel;
        Label titleLabel;
        Label activityTitleLabel;
        Label activityDescriptionLabel;
        Label activityTypeLabel;
        Label activityDateLabel;
        Label activityDurationLabel;
        Label activityDistanceDescriptionLabel;
        Label activityCaloriesLabel;
        Label activityCaloriesDescriptionLabel;
        Label activityAvgHRLabel;
        Label activityAvgHRDescriptionLabel;
        Label activityNumberOfSetsLabel;
        Label activityElevationLabel;
        Label activityElevationDescriptionLabel;
        Label activityDistanceLabel;
        Label activityGpxFileLabel;
        Label acitivityGpxFileDescriptionLabel;
        TextBox activityTitleTextBox;
        TextBox activityDescriptionTextBox;
        FlowLayoutPanel activityTypeFlowLayoutPanel;
        RadioButton activityTypeRadioBox_Workout;
        RadioButton activityTypeRadioBox_Run;
        RadioButton activityTypeRadioBox_Hike;
        RadioButton activityTypeRadioBox_BikeRide;
        DateTimePicker activityDatePicker;
        DateTimePicker activityTimePicker;
        DateTimePicker activityDurationPicker;
        NumericUpDown activityCaloriesNumericUpDown;
        NumericUpDown activityAvgHRNumericUpDown;
        NumericUpDown activityNumberOfSetsNumericUpDown;
        NumericUpDown activityElevationNumericUpDown;
        NumericUpDown activityDistanceNumericUpDown;
        Button activityGpxFileButton;
        OpenFileDialog openFileDialog;
        Button addActivityButton;
        FileInfo fileInfo;

        public ManualUploadTabPage()
        {
            // ManualUploadTabPage
            Text = "Manual Upload";
            Padding = new Padding(GeneralValues.PaddingValue);
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;

            // mainTableLayoutPanel
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.AutoScroll = true;
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            Controls.Add(mainTableLayoutPanel);

            // titleLabel
            titleLabel = new Label();
            titleLabel.Text = "Manual upload activity";
            titleLabel.AutoSize = true;
            titleLabel.Font = GeneralValues.TitleFont;
            titleLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(titleLabel, 0, 0);
            mainTableLayoutPanel.SetColumnSpan(titleLabel, 2);

            // activityTitleLabel
            activityTitleLabel = new Label();
            activityTitleLabel.Text = "Title: ";
            activityTitleLabel.AutoSize = true;
            activityTitleLabel.Font = GeneralValues.SubtitleFont;
            activityTitleLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityTitleLabel, 0, 1);

            // activityTitleTextBox
            activityTitleTextBox = new TextBox();
            activityTitleTextBox.Font = GeneralValues.SubtitleFont;
            activityTitleTextBox.Width = 200;
            mainTableLayoutPanel.Controls.Add(activityTitleTextBox, 1, 1);

            // activityDescriptionLabel
            activityDescriptionLabel = new Label();
            activityDescriptionLabel.Text = "Description: ";
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityDescriptionLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityDescriptionLabel, 0, 2);

            // activityDescriptionTextBox
            activityDescriptionTextBox = new TextBox();
            activityDescriptionTextBox.Font = GeneralValues.SubtitleFont;
            activityDescriptionTextBox.Width = 300;
            mainTableLayoutPanel.Controls.Add(activityDescriptionTextBox, 1, 2);

            // activityTypeLabel
            activityTypeLabel = new Label();
            activityTypeLabel.Text = "Type: ";
            activityTypeLabel.AutoSize = true;
            activityTypeLabel.Font = GeneralValues.SubtitleFont;
            activityTypeLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityTypeLabel, 0, 3);

            // activityTypeFlowLayoutPanel
            activityTypeFlowLayoutPanel = new FlowLayoutPanel();
            activityTypeFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            activityTypeFlowLayoutPanel.AutoSize = true;
            activityTypeFlowLayoutPanel.Font = GeneralValues.SubtitleFont;
            mainTableLayoutPanel.Controls.Add(activityTypeFlowLayoutPanel, 1, 3);

            // activityTypeRadioBox_Workout
            activityTypeRadioBox_Workout = new CustomRadioButton();
            activityTypeRadioBox_Workout.AutoSize = true;
            activityTypeRadioBox_Workout.Text = "Workout";
            activityTypeRadioBox_Workout.Checked = true;
            activityTypeRadioBox_Workout.CheckedChanged += ChangeControls;
            activityTypeFlowLayoutPanel.Controls.Add(activityTypeRadioBox_Workout);

            // activityTypeRadioBox_Run
            activityTypeRadioBox_Run = new CustomRadioButton();
            activityTypeRadioBox_Run.AutoSize = true;
            activityTypeRadioBox_Run.Text = "Run";
            activityTypeRadioBox_Run.CheckedChanged += ChangeControls;
            activityTypeFlowLayoutPanel.Controls.Add(activityTypeRadioBox_Run);

            // activityTypeRadioBox_Hike
            activityTypeRadioBox_Hike = new CustomRadioButton();
            activityTypeRadioBox_Hike.AutoSize = true;
            activityTypeRadioBox_Hike.Text = "Hike";
            activityTypeRadioBox_Hike.CheckedChanged += ChangeControls;
            activityTypeFlowLayoutPanel.Controls.Add(activityTypeRadioBox_Hike);

            // activityTypeRadioBox_BikeRide
            activityTypeRadioBox_BikeRide = new CustomRadioButton();
            activityTypeRadioBox_BikeRide.AutoSize = true;
            activityTypeRadioBox_BikeRide.Text = "Bike Run";
            activityTypeRadioBox_BikeRide.CheckedChanged += ChangeControls;
            activityTypeFlowLayoutPanel.Controls.Add(activityTypeRadioBox_BikeRide);

            // activityDateLabel
            activityDateLabel = new Label();
            activityDateLabel.Text = "Date: ";
            activityDateLabel.AutoSize = true;
            activityDateLabel.Font = GeneralValues.SubtitleFont;
            activityDateLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityDateLabel, 0, 4);

            // activityDateTimeLayoutPanel
            FlowLayoutPanel activityDateTimeFlayoutLayoutPanel = new FlowLayoutPanel();
            activityDateTimeFlayoutLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            activityDateTimeFlayoutLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(activityDateTimeFlayoutLayoutPanel, 1, 4);

            // activityDatePicker
            activityDatePicker = new DateTimePicker();
            activityDatePicker.AutoSize = true;
            activityDatePicker.Font = GeneralValues.SubtitleFont;
            activityDatePicker.Format = DateTimePickerFormat.Short;
            activityDatePicker.Value = DateTime.Now;
            activityDateTimeFlayoutLayoutPanel.Controls.Add(activityDatePicker);

            // activityTimePicker
            activityTimePicker = new DateTimePicker();
            activityTimePicker.AutoSize = true;
            activityTimePicker.Font = GeneralValues.SubtitleFont;
            activityTimePicker.Format = DateTimePickerFormat.Time;
            activityTimePicker.ShowUpDown = true;
            activityTimePicker.Value = DateTime.Now;
            activityDateTimeFlayoutLayoutPanel.Controls.Add(activityTimePicker);

            // activityDurationLabel
            activityDurationLabel = new Label();
            activityDurationLabel.Text = "Duration: ";
            activityDurationLabel.AutoSize = true;
            activityDurationLabel.Font = GeneralValues.SubtitleFont;
            activityDurationLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityDurationLabel, 0, 5);

            // durationFlowLayoutPanel
            FlowLayoutPanel durationFlowLayoutPanel = new FlowLayoutPanel();
            durationFlowLayoutPanel.AutoSize = true;
            durationFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            mainTableLayoutPanel.Controls.Add(durationFlowLayoutPanel, 1, 5);

            // activityDurationPicker
            activityDurationPicker = new DateTimePicker();
            activityDurationPicker.AutoSize = true;
            activityDurationPicker.Font = GeneralValues.SubtitleFont;
            activityDurationPicker.Format = DateTimePickerFormat.Custom;
            activityDurationPicker.CustomFormat = " HH:mm:ss";
            activityDurationPicker.ShowUpDown = true;
            activityDurationPicker.Value = DateTime.Today.Date;
            durationFlowLayoutPanel.Controls.Add(activityDurationPicker);

            // activityDurationDescriptionLabel
            activityDistanceDescriptionLabel = new Label();
            activityDistanceDescriptionLabel.Text = "(hours:minutes:seconds)";
            activityDistanceDescriptionLabel.AutoSize = true;
            activityDistanceDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityDistanceDescriptionLabel.Anchor = AnchorStyles.Left;
            durationFlowLayoutPanel.Controls.Add(activityDistanceDescriptionLabel);

            // activityCaloriesLabel
            activityCaloriesLabel = new Label();
            activityCaloriesLabel.Text = "Calories: ";
            activityCaloriesLabel.AutoSize = true;
            activityCaloriesLabel.Font = GeneralValues.SubtitleFont;
            activityCaloriesLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityCaloriesLabel, 0, 6);

            // caloriesFlowLayoutPanel
            FlowLayoutPanel caloriesFlowLayoutPanel = new FlowLayoutPanel();
            caloriesFlowLayoutPanel.AutoSize = true;
            caloriesFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            mainTableLayoutPanel.Controls.Add(caloriesFlowLayoutPanel, 1, 6);

            // activityCaloriesTextBox
            activityCaloriesNumericUpDown = new CustomNumericUpDown();
            activityCaloriesNumericUpDown.Font = GeneralValues.SubtitleFont;
            activityCaloriesNumericUpDown.AutoSize = true;
            activityCaloriesNumericUpDown.Increment = 1M;
            activityCaloriesNumericUpDown.Minimum = 0M;
            activityCaloriesNumericUpDown.Maximum = 9000M;
            activityCaloriesNumericUpDown.Value = 0M;
            caloriesFlowLayoutPanel.Controls.Add(activityCaloriesNumericUpDown);

            // activityCaloriesDescriptionLabel
            activityCaloriesDescriptionLabel = new Label();
            activityCaloriesDescriptionLabel.Text = "Cal";
            activityCaloriesDescriptionLabel.AutoSize = true;
            activityCaloriesDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityCaloriesDescriptionLabel.Anchor = AnchorStyles.Left;
            caloriesFlowLayoutPanel.Controls.Add(activityCaloriesDescriptionLabel);

            // activityAvgHRLabel
            activityAvgHRLabel = new Label();
            activityAvgHRLabel.Text = "Avg HR: ";
            activityAvgHRLabel.AutoSize = true;
            activityAvgHRLabel.Font = GeneralValues.SubtitleFont;
            activityAvgHRLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityAvgHRLabel, 0, 7);

            // avgHRFlowLayoutPanel
            FlowLayoutPanel avgHRFlowLayoutPanel = new FlowLayoutPanel();
            avgHRFlowLayoutPanel.AutoSize = true;
            avgHRFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            mainTableLayoutPanel.Controls.Add(avgHRFlowLayoutPanel, 1, 7);

            // activityAvgHRTextBox
            activityAvgHRNumericUpDown = new CustomNumericUpDown();
            activityAvgHRNumericUpDown.Font = GeneralValues.SubtitleFont;
            activityAvgHRNumericUpDown.AutoSize = true;
            activityAvgHRNumericUpDown.Increment = 1M;
            activityAvgHRNumericUpDown.Minimum = 0M;
            activityAvgHRNumericUpDown.Maximum = 9000M;
            activityAvgHRNumericUpDown.Value = 0M;
            avgHRFlowLayoutPanel.Controls.Add(activityAvgHRNumericUpDown);

            // activityAvgHRDescriptionLabel
            activityAvgHRDescriptionLabel = new Label();
            activityAvgHRDescriptionLabel.Text = "BPM";
            activityAvgHRDescriptionLabel.AutoSize = true;
            activityAvgHRDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityAvgHRDescriptionLabel.Anchor = AnchorStyles.Left;
            avgHRFlowLayoutPanel.Controls.Add(activityAvgHRDescriptionLabel);

            mainTableLayoutPanel.RowCount = 8;

            ChangeControls(activityTypeRadioBox_Workout, null);
        }

        private void ChangeControls(Object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            for (int i = 0; i <= mainTableLayoutPanel.RowCount - 8; i++)
            {
                RemoveRow(mainTableLayoutPanel, mainTableLayoutPanel.RowCount - i);
            }
            
            if (activityTypeRadioBox_Workout.Checked)
            {
                // activityNumberOfSetsLabel
                activityNumberOfSetsLabel = new Label();
                activityNumberOfSetsLabel.Text = "No. of sets: ";
                activityNumberOfSetsLabel.AutoSize = true;
                activityNumberOfSetsLabel.Font = GeneralValues.SubtitleFont;
                activityNumberOfSetsLabel.Anchor = AnchorStyles.Left;
                mainTableLayoutPanel.Controls.Add(activityNumberOfSetsLabel, 0, 8);

                // activityNumberOfSetsNumericUpDown
                activityNumberOfSetsNumericUpDown = new CustomNumericUpDown();
                activityNumberOfSetsNumericUpDown.AutoSize = true;
                activityNumberOfSetsNumericUpDown.Font = GeneralValues.SubtitleFont;
                activityNumberOfSetsNumericUpDown.Anchor = AnchorStyles.Left;
                mainTableLayoutPanel.Controls.Add(activityNumberOfSetsNumericUpDown, 1, 8);
                mainTableLayoutPanel.RowCount = 9;
            }
            else
            {
                // activityElevationLabel
                activityElevationLabel = new Label();
                activityElevationLabel.Text = "Elevation: ";
                activityElevationLabel.AutoSize = true;
                activityElevationLabel.Font = GeneralValues.SubtitleFont;
                activityElevationLabel.Anchor = AnchorStyles.Left;
                mainTableLayoutPanel.Controls.Add(activityElevationLabel, 0, 9);

                // elevationLayoutPanel
                FlowLayoutPanel elevationLayoutPanel = new FlowLayoutPanel();
                elevationLayoutPanel.AutoSize = true;
                elevationLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                mainTableLayoutPanel.Controls.Add(elevationLayoutPanel, 1, 9);

                // activityElevationNumericUpDown
                activityElevationNumericUpDown = new CustomNumericUpDown();
                activityElevationNumericUpDown.AutoSize = true;
                activityElevationNumericUpDown.Font = GeneralValues.SubtitleFont;
                activityElevationNumericUpDown.Anchor = AnchorStyles.Left;
                activityElevationNumericUpDown.DecimalPlaces = 2;
                activityElevationNumericUpDown.Increment = 0.1M;
                activityElevationNumericUpDown.Minimum = 0.0M;
                activityElevationNumericUpDown.Maximum = 9000.0M;
                activityElevationNumericUpDown.Value = 0.0M;
                elevationLayoutPanel.Controls.Add(activityElevationNumericUpDown);

                // activityElevationDescriptionLabel
                activityElevationDescriptionLabel = new Label();
                activityElevationDescriptionLabel.Text = "meters";
                activityElevationDescriptionLabel.AutoSize = true;
                activityElevationDescriptionLabel.Font = GeneralValues.SubtitleFont;
                activityElevationDescriptionLabel.Anchor = AnchorStyles.Left;
                elevationLayoutPanel.Controls.Add(activityElevationDescriptionLabel);
                        
                // activityDistanceLabel
                activityDistanceLabel = new Label();
                activityDistanceLabel.Text = "Distance: ";
                activityDistanceLabel.AutoSize = true;
                activityDistanceLabel.Font = GeneralValues.SubtitleFont;
                activityDistanceLabel.Anchor = AnchorStyles.Left;
                mainTableLayoutPanel.Controls.Add(activityDistanceLabel, 0, 10);

                // durationLayoutPanel
                FlowLayoutPanel distanceLayoutPanel = new FlowLayoutPanel();
                distanceLayoutPanel.AutoSize = true;
                distanceLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                mainTableLayoutPanel.Controls.Add(distanceLayoutPanel, 1, 10);

                // activityDurationNumericUpDown
                activityDistanceNumericUpDown = new CustomNumericUpDown();
                activityDistanceNumericUpDown.AutoSize = true;
                activityDistanceNumericUpDown.Font = GeneralValues.SubtitleFont;
                activityDistanceNumericUpDown.Anchor = AnchorStyles.Left;
                activityDistanceNumericUpDown.DecimalPlaces = 2;
                activityDistanceNumericUpDown.Increment = 0.1M;
                activityDistanceNumericUpDown.Minimum = 0.0M;
                activityDistanceNumericUpDown.Maximum = 9000.0M;
                activityDistanceNumericUpDown.Value = 0.0M;
                distanceLayoutPanel.Controls.Add(activityDistanceNumericUpDown);

                // activityDurationDescriptionLabel
                activityDistanceDescriptionLabel = new Label();
                activityDistanceDescriptionLabel.Text = "Km";
                activityDistanceDescriptionLabel.AutoSize = true;
                activityDistanceDescriptionLabel.Font = GeneralValues.SubtitleFont;
                activityDistanceDescriptionLabel.Anchor = AnchorStyles.Left;
                distanceLayoutPanel.Controls.Add(activityDistanceDescriptionLabel);


                mainTableLayoutPanel.RowCount = 11;
            }
            // activityGpxFileLabel
            activityGpxFileLabel = new Label();
            activityGpxFileLabel.Text = "GPX File: ";
            activityGpxFileLabel.AutoSize = true;
            activityGpxFileLabel.Font = GeneralValues.SubtitleFont;
            activityGpxFileLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityGpxFileLabel, 0, mainTableLayoutPanel.RowCount);

            // fileDialogFlowLayoutPanel
            FlowLayoutPanel fileDialogFlowLayoutPanel = new FlowLayoutPanel();
            fileDialogFlowLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(fileDialogFlowLayoutPanel, 1, mainTableLayoutPanel.RowCount);

            // selectFileButton
            activityGpxFileButton = new CustomStyleButton();
            activityGpxFileButton.Text = "Select file";
            activityGpxFileButton.AutoSize = true;
            activityGpxFileButton.Click += new EventHandler(ShowFileDialog);
            fileDialogFlowLayoutPanel.Controls.Add(activityGpxFileButton);

            // fileNameLabel
            acitivityGpxFileDescriptionLabel = new Label();
            acitivityGpxFileDescriptionLabel.AutoSize = true;
            acitivityGpxFileDescriptionLabel.Font = GeneralValues.BodyFontSmall;
            acitivityGpxFileDescriptionLabel.Anchor = AnchorStyles.None;
            fileDialogFlowLayoutPanel.Controls.Add(acitivityGpxFileDescriptionLabel);
            
            mainTableLayoutPanel.RowCount++;

            // addActivityButton
            addActivityButton = new CustomStyleButton();
            addActivityButton.Text = "Add Activity";
            addActivityButton.AutoSize = true;
            addActivityButton.Click += new EventHandler(CreateActivity);
            mainTableLayoutPanel.Controls.Add(addActivityButton, 0, mainTableLayoutPanel.RowCount);
            mainTableLayoutPanel.SetRowSpan(addActivityButton, 2);

            mainTableLayoutPanel.RowCount++;
        }
        private void ShowFileDialog(Object sender, EventArgs e)
        {
            // fileDialog
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "GPX Files (*.gpx)|*.gpx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileInfo = new FileInfo(openFileDialog.FileName);
                    acitivityGpxFileDescriptionLabel.Text = fileInfo.Name;

                    if (acitivityGpxFileDescriptionLabel.Width > 300)
                    {
                        Int32 height = acitivityGpxFileDescriptionLabel.Height;
                        acitivityGpxFileDescriptionLabel.AutoSize = false;
                        acitivityGpxFileDescriptionLabel.Size = new Size(300, height);
                        acitivityGpxFileDescriptionLabel.AutoEllipsis = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Couldn't parse activity!");
                }
            }
        }

        private void CreateActivity(Object sender, EventArgs e)
        {
            Activity activity = null;
            
            String title = activityTitleTextBox.Text;
            String description = activityDescriptionTextBox.Text;
            DateTime date = DateTime.Parse(activityDatePicker.Text);
            TimeSpan duration = TimeSpan.Parse(activityDurationPicker.Text);
            Int32 calories = Int32.Parse(activityCaloriesNumericUpDown.Text);
            Int32 avgHR = Int32.Parse(activityAvgHRNumericUpDown.Text);
            String gpxFile = "";

            if (fileInfo != null) gpxFile = fileInfo.FullName;
           

            if (activityTypeRadioBox_Workout.Checked)
            {
                Int32 numberOfSets = Int32.Parse(activityNumberOfSetsNumericUpDown.Text);
                activity = new Activity(0, title, description, Activity.ActivityType.Workout, date, duration, calories, avgHR, gpxFile, numberOfSets, 0, 0);
            }
            else if (activityTypeRadioBox_Hike.Checked)
            {
                Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                Double distance = Double.Parse(activityDistanceNumericUpDown.Text);
                activity = new Activity(0, title, description, Activity.ActivityType.Hike, date, duration, calories, avgHR, gpxFile, 0, elevation, distance);
            }
            else if (activityTypeRadioBox_Run.Checked)
            {
                Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                Double distance = Double.Parse(activityDistanceNumericUpDown.Text);
                activity = new Activity(0, title, description, Activity.ActivityType.Run, date, duration, calories, avgHR, gpxFile, 0, elevation, distance);
            }
            else if (activityTypeRadioBox_BikeRide.Checked)
            {
                Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                Double distance = Double.Parse(activityDistanceNumericUpDown.Text);
                activity = new Activity(0, title, description, Activity.ActivityType.Bike_Ride, date, duration, calories, avgHR, gpxFile, 0, elevation, distance);
            }

            UploadActivityForm.AddActivity(activity);
            this.FindForm().Close();
        }

        void RemoveRow(TableLayoutPanel panel, int rowIndex)
        {
            if (rowIndex >= panel.RowCount) return;

            for (int col = 0; col < panel.ColumnCount; col++)
            {
                var control = panel.GetControlFromPosition(col, rowIndex);
                if (control != null)
                {
                    panel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            for (int row = rowIndex + 1; row < panel.RowCount; row++)
            {
                for (int col = 0; col < panel.ColumnCount; col++)
                {
                    var control = panel.GetControlFromPosition(col, row);
                    if (control != null)
                        panel.SetRow(control, row - 1);
                }
            }

            if (panel.RowStyles.Count > 0)
                panel.RowStyles.RemoveAt(panel.RowStyles.Count - 1);
        }
    }

}
