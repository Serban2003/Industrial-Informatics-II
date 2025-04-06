namespace ActivityTracker
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
        Label activityDurationDescriptionLabel;
        Label activityCaloriesLabel;
        Label activityCaloriesDescriptionLabel;
        Label activityAvgHRLabel;
        Label activityAvgHRDescriptionLabel;
        Label activityNumberOfSetsLabel;
        Label activityElevationLabel;
        Label activityElevationDescriptionLabel;
        Label activityDistanceLabel;
        Label activityAvgSpeedLabel;
        Label activityAvgSpeedDescriptionLabel;
        Label activityAvgPaceLabel;
        Label activityAvgPaceDescriptionLabel;
        Label activityGpxFileLabel;
        Label acitivityGpxFileDescriptionLabel;
        TextBox activityTitleTextBox;
        TextBox activityDescriptionTextBox;
        ComboBox activityTypeComboBox;
        DateTimePicker activityDatePicker;
        DateTimePicker activityTimePicker;
        DateTimePicker activityDurationPicker;
        NumericUpDown activityCaloriesNumericUpDown;
        NumericUpDown activityAvgHRNumericUpDown;
        NumericUpDown activityNumberOfSetsNumericUpDown;
        NumericUpDown activityElevationNumericUpDown;
        NumericUpDown activityDurationNumericUpDown;
        NumericUpDown activityAvgSpeedNumericUpDown;
        DateTimePicker activityAvgPacePicker;
        Button activityGpxFileButton;
        OpenFileDialog openFileDialog;
        Button addActivityButton;
        FileInfo fileInfo;

        public ManualUploadTabPage()
        {
            Text = "Manual Upload";
            Padding = new Padding(GeneralValues.PaddingValue);
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;

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

            // activityTypeComboBox
            activityTypeComboBox = new ComboBox();
            activityTypeComboBox.AutoSize = true;
            activityTypeComboBox.Font = GeneralValues.SubtitleFont;

            foreach (Activity.ActivityType type in Enum.GetValues(typeof(Activity.ActivityType)))
                activityTypeComboBox.Items.Add(type);

            activityTypeComboBox.SelectedIndex = 0;
            activityTypeComboBox.SelectedIndexChanged += ChangeControls;
            mainTableLayoutPanel.Controls.Add(activityTypeComboBox, 1, 3);

            // activityDateLabel
            activityDateLabel = new Label();
            activityDateLabel.Text = "Date: ";
            activityDateLabel.AutoSize = true;
            activityDateLabel.Font = GeneralValues.SubtitleFont;
            activityDateLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityDateLabel, 0, 4);

            FlowLayoutPanel activityDateTimeLayoutPanel = new FlowLayoutPanel();
            activityDateTimeLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            activityDateTimeLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(activityDateTimeLayoutPanel, 1, 4);

            // activityDatePicker
            activityDatePicker = new DateTimePicker();
            activityDatePicker.AutoSize = true;
            activityDatePicker.Font = GeneralValues.SubtitleFont;
            activityDatePicker.Format = DateTimePickerFormat.Short;
            activityDatePicker.Value = DateTime.Now;
            activityDateTimeLayoutPanel.Controls.Add(activityDatePicker);

            // activityTimePicker
            activityTimePicker = new DateTimePicker();
            activityTimePicker.AutoSize = true;
            activityTimePicker.Font = GeneralValues.SubtitleFont;
            activityTimePicker.Format = DateTimePickerFormat.Time;
            activityTimePicker.ShowUpDown = true;
            activityTimePicker.Value = DateTime.Now;
            activityDateTimeLayoutPanel.Controls.Add(activityTimePicker);

            // activityDurationLabel
            activityDurationLabel = new Label();
            activityDurationLabel.Text = "Duration: ";
            activityDurationLabel.AutoSize = true;
            activityDurationLabel.Font = GeneralValues.SubtitleFont;
            activityDurationLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityDurationLabel, 0, 5);

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
            activityDurationDescriptionLabel = new Label();
            activityDurationDescriptionLabel.Text = "(hours:minutes:seconds)";
            activityDurationDescriptionLabel.AutoSize = true;
            activityDurationDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityDurationDescriptionLabel.Anchor = AnchorStyles.Left;
            durationFlowLayoutPanel.Controls.Add(activityDurationDescriptionLabel);

            // activityCaloriesLabel
            activityCaloriesLabel = new Label();
            activityCaloriesLabel.Text = "Calories: ";
            activityCaloriesLabel.AutoSize = true;
            activityCaloriesLabel.Font = GeneralValues.SubtitleFont;
            activityCaloriesLabel.Anchor = AnchorStyles.Left;
            mainTableLayoutPanel.Controls.Add(activityCaloriesLabel, 0, 6);

            FlowLayoutPanel caloriesFlowLayoutPanel = new FlowLayoutPanel();
            caloriesFlowLayoutPanel.AutoSize = true;
            caloriesFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            mainTableLayoutPanel.Controls.Add(caloriesFlowLayoutPanel, 1, 6);

            // activityCaloriesTextBox
            activityCaloriesNumericUpDown = new CustomNumericUpDown();
            activityCaloriesNumericUpDown.Font = GeneralValues.SubtitleFont;
            activityCaloriesNumericUpDown.AutoSize = true;
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

            FlowLayoutPanel avgHRFlowLayoutPanel = new FlowLayoutPanel();
            avgHRFlowLayoutPanel.AutoSize = true;
            avgHRFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            mainTableLayoutPanel.Controls.Add(avgHRFlowLayoutPanel, 1, 7);

            // activityAvgHRTextBox
            activityAvgHRNumericUpDown = new CustomNumericUpDown();
            activityAvgHRNumericUpDown.Font = GeneralValues.SubtitleFont;
            activityAvgHRNumericUpDown.AutoSize = true;
            avgHRFlowLayoutPanel.Controls.Add(activityAvgHRNumericUpDown);

            // activityAvgHRDescriptionLabel
            activityAvgHRDescriptionLabel = new Label();
            activityAvgHRDescriptionLabel.Text = "BPM";
            activityAvgHRDescriptionLabel.AutoSize = true;
            activityAvgHRDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityAvgHRDescriptionLabel.Anchor = AnchorStyles.Left;
            avgHRFlowLayoutPanel.Controls.Add(activityAvgHRDescriptionLabel);

            mainTableLayoutPanel.RowCount = 8;

            ChangeControls(null, null);
        }

        private void ChangeControls(Object sender, EventArgs e)
        {
            for(int i = 0; i <= mainTableLayoutPanel.RowCount - 8; i++)
            {
                RemoveRow(mainTableLayoutPanel, mainTableLayoutPanel.RowCount - i);
            }
            
            if (activityTypeComboBox.SelectedIndex == (int)Activity.ActivityType.Workout)
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
                activityElevationNumericUpDown.Maximum = 100.0M;
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

                FlowLayoutPanel durationLayoutPanel = new FlowLayoutPanel();
                durationLayoutPanel.AutoSize = true;
                durationLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                mainTableLayoutPanel.Controls.Add(durationLayoutPanel, 1, 10);

                // activityDurationNumericUpDown
                activityDurationNumericUpDown = new CustomNumericUpDown();
                activityDurationNumericUpDown.AutoSize = true;
                activityDurationNumericUpDown.Font = GeneralValues.SubtitleFont;
                activityDurationNumericUpDown.Anchor = AnchorStyles.Left;
                activityDurationNumericUpDown.DecimalPlaces = 2;
                activityDurationNumericUpDown.Increment = 0.1M;
                activityDurationNumericUpDown.Minimum = 0.0M;
                activityDurationNumericUpDown.Maximum = 100.0M;
                activityDurationNumericUpDown.Value = 0.0M;
                durationLayoutPanel.Controls.Add(activityDurationNumericUpDown);

                // activityDurationDescriptionLabel
                activityDurationDescriptionLabel = new Label();
                activityDurationDescriptionLabel.Text = "Km";
                activityDurationDescriptionLabel.AutoSize = true;
                activityDurationDescriptionLabel.Font = GeneralValues.SubtitleFont;
                activityDurationDescriptionLabel.Anchor = AnchorStyles.Left;
                durationLayoutPanel.Controls.Add(activityDurationDescriptionLabel);

                // activityAvgSpeedLabel
                activityAvgSpeedLabel = new Label();
                activityAvgSpeedLabel.Text = "Avg. Speed: ";
                activityAvgSpeedLabel.AutoSize = true;
                activityAvgSpeedLabel.Font = GeneralValues.SubtitleFont;
                activityAvgSpeedLabel.Anchor = AnchorStyles.Left;
                mainTableLayoutPanel.Controls.Add(activityAvgSpeedLabel, 0, 11);

                FlowLayoutPanel avgSpeedLayoutPanel = new FlowLayoutPanel();
                avgSpeedLayoutPanel.AutoSize = true;
                avgSpeedLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                mainTableLayoutPanel.Controls.Add(avgSpeedLayoutPanel, 1, 11);

                // activityAvgSpeedNumericUpDown
                activityAvgSpeedNumericUpDown = new CustomNumericUpDown();
                activityAvgSpeedNumericUpDown.AutoSize = true;
                activityAvgSpeedNumericUpDown.Font = GeneralValues.SubtitleFont;
                activityAvgSpeedNumericUpDown.Anchor = AnchorStyles.Left;
                activityAvgSpeedNumericUpDown.DecimalPlaces = 2;
                activityAvgSpeedNumericUpDown.Increment = 0.1M;
                activityAvgSpeedNumericUpDown.Minimum = 0.0M;
                activityAvgSpeedNumericUpDown.Maximum = 100.0M;
                activityAvgSpeedNumericUpDown.Value = 0.0M;
                avgSpeedLayoutPanel.Controls.Add(activityAvgSpeedNumericUpDown);

                // activityAvgSpeedDescriptionLabel
                activityAvgSpeedDescriptionLabel = new Label();
                activityAvgSpeedDescriptionLabel.Text = "Km/H";
                activityAvgSpeedDescriptionLabel.AutoSize = true;
                activityAvgSpeedDescriptionLabel.Font = GeneralValues.SubtitleFont;
                activityAvgSpeedDescriptionLabel.Anchor = AnchorStyles.Left;
                avgSpeedLayoutPanel.Controls.Add(activityAvgSpeedDescriptionLabel);

                mainTableLayoutPanel.RowCount = 12;

                if (activityTypeComboBox.SelectedIndex != (int)Activity.ActivityType.Bike_Ride)
                {
                    // activityAvgPaceLabel
                    activityAvgPaceLabel = new Label();
                    activityAvgPaceLabel.Text = "Avg. Pace: ";
                    activityAvgPaceLabel.AutoSize = true;
                    activityAvgPaceLabel.Font = GeneralValues.SubtitleFont;
                    activityAvgPaceLabel.Anchor = AnchorStyles.Left;
                    mainTableLayoutPanel.Controls.Add(activityAvgPaceLabel, 0, 12);

                    FlowLayoutPanel avgPaceLayoutPanel = new FlowLayoutPanel();
                    avgPaceLayoutPanel.AutoSize = true;
                    avgPaceLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                    mainTableLayoutPanel.Controls.Add(avgPaceLayoutPanel, 1, 12);

                    // activityAvgPacePicker
                    activityAvgPacePicker = new DateTimePicker();
                    activityAvgPacePicker.AutoSize = true;
                    activityAvgPacePicker.Font = GeneralValues.SubtitleFont;
                    activityAvgPacePicker.Anchor = AnchorStyles.Left;
                    activityAvgPacePicker.Format = DateTimePickerFormat.Custom;
                    activityAvgPacePicker.CustomFormat = " mm:ss";
                    activityAvgPacePicker.Value = DateTime.Today;
                    activityAvgPacePicker.ShowUpDown = true;
                    avgPaceLayoutPanel.Controls.Add(activityAvgPacePicker);

                    // activityAvgPaceDescriptionLabel
                    activityAvgPaceDescriptionLabel = new Label();
                    activityAvgPaceDescriptionLabel.Text = "min/Km";
                    activityAvgPaceDescriptionLabel.AutoSize = true;
                    activityAvgPaceDescriptionLabel.Font = GeneralValues.SubtitleFont;
                    activityAvgPaceDescriptionLabel.Anchor = AnchorStyles.Left;
                    avgPaceLayoutPanel.Controls.Add(activityAvgPaceDescriptionLabel);
                    
                    mainTableLayoutPanel.RowCount = 13;
                }
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
                    MessageBox.Show("ERROR! Couldn't parse activity!");
                }
            }
        }

        private void CreateActivity(Object sender, EventArgs e)
        {
            Activity activity = null;
            
            String title = activityTitleTextBox.Text;
            String description = activityDescriptionTextBox.Text;
            Activity.ActivityType type = (Activity.ActivityType)Enum.GetValues(typeof(Activity.ActivityType)).GetValue(activityTypeComboBox.SelectedIndex);
            DateTime date = DateTime.Parse(activityDatePicker.Text);
            DateTime duration = DateTime.Parse(activityDurationPicker.Text);
            Int32 calories = Int32.Parse(activityCaloriesNumericUpDown.Text);
            Int32 avgHR = Int32.Parse(activityAvgHRNumericUpDown.Text);
            String gpxFile = fileInfo.FullName;

       
            switch(activityTypeComboBox.SelectedIndex)
            {
                case (int)Activity.ActivityType.Workout:
                    {
                        Int32 numberOfSets = Int32.Parse(activityNumberOfSetsNumericUpDown.Text);
                        activity = new WorkoutActivity(title, description, date, duration, calories, avgHR, numberOfSets);
                        break;
                    }
                case (int)Activity.ActivityType.Hike:
                    {
                        Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                        Double distance = Double.Parse(activityDurationNumericUpDown.Text);
                        DateTime avgPace = DateTime.Parse(activityAvgPacePicker.Text);
                        Double avgSpeed = Double.Parse(activityAvgSpeedNumericUpDown.Text);
                        activity = new HikeActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgPace, avgSpeed, gpxFile);
                        break;
                    }
                case (int)Activity.ActivityType.Run:
                    {
                        Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                        Double distance = Double.Parse(activityDurationNumericUpDown.Text);
                        DateTime avgPace = DateTime.Parse("00:" + activityAvgPacePicker.Text);
                        Double avgSpeed = Double.Parse(activityAvgSpeedNumericUpDown.Text);
                        activity = new RunActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgPace, avgSpeed, gpxFile);
                        break;
                    }
                case (int)Activity.ActivityType.Bike_Ride:
                    {
                        Double elevation = Double.Parse(activityElevationNumericUpDown.Text);
                        Double distance = Double.Parse(activityDurationNumericUpDown.Text);
                        Double avgSpeed = Double.Parse(activityAvgSpeedNumericUpDown.Text);
                        activity = new BikeRideActivity(title, description, date, duration, calories, avgHR, elevation, distance, avgSpeed, gpxFile);
                        break;
                    }
            }

            Activity.AddActivity(activity);
        }

        void RemoveRow(TableLayoutPanel panel, int rowIndex)
        {
            if (rowIndex >= panel.RowCount) return;

            // Remove controls in the target row
            for (int col = 0; col < panel.ColumnCount; col++)
            {
                var control = panel.GetControlFromPosition(col, rowIndex);
                if (control != null)
                {
                    panel.Controls.Remove(control);
                    control.Dispose(); // Optional cleanup
                }
            }

            // Move controls up from rows below
            for (int row = rowIndex + 1; row < panel.RowCount; row++)
            {
                for (int col = 0; col < panel.ColumnCount; col++)
                {
                    var control = panel.GetControlFromPosition(col, row);
                    if (control != null)
                        panel.SetRow(control, row - 1);
                }
            }

            // Remove the last RowStyle
            if (panel.RowStyles.Count > 0)
                panel.RowStyles.RemoveAt(panel.RowStyles.Count - 1);
        }
    }

}
