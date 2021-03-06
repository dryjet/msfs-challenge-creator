﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NHotkey.WindowsForms;

namespace LandingChallengeCreator
{
    public partial class Form1 : Form
    {
        public string GenericFilename { get; set; }
        public string WeatherFilename { get; set; }
        public List<Mission> Missions { get; set; }
        public bool IsInitialized { get; set; }

        public Form1()
        {
            // Initialize designer components
            InitializeComponent();

            // Initialize components - custom code
            this.dtFlight.Format = DateTimePickerFormat.Custom;
            this.dtFlight.CustomFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;

            // Check if we must select the package folder first
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PackageFolder))
            {
                // Just call the menu item handler
                this.setPackageFolderToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else
            {
                // Got it, cache the filenames to write
                this.CacheFilenames();
            }

            // Check if any data is stored for the user
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.Approaches))
            {
                // Seed and save
                Properties.Settings.Default.Approaches = JsonConvert.SerializeObject(Extensions.GetSeededData());
                Properties.Settings.Default.Save();
            }

            // Set the missions
            this.Missions = JsonConvert.DeserializeObject<List<Mission>>(Properties.Settings.Default.Approaches);

            // Populate the list box
            foreach (var mission in this.Missions)
            {
                this.listBox1.Items.Add(mission);
            }

            // Set the selected index
            this.cmbWeatherTemplate.SelectedIndex = 0;
            this.listBox1.SelectedIndex = Math.Min(Properties.Settings.Default.SelectedApproach, this.listBox1.Items.Count - 1);
            this.IsInitialized = true;
            this.toolStripStatusLabel1.Visible = false;

            // Register hotkey
            HotkeyManager.Current.AddOrReplace("SaveChanges", Keys.Control | Keys.S, (sender, args) => btnSave_Click(this, EventArgs.Empty));
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            var tpl = File.ReadAllText("Templates/Template.FLT", Encoding.GetEncoding(1252));
            if (this.listBox1.SelectedItem is Mission mission)
            {
                if (string.IsNullOrWhiteSpace(mission.ICAO))
                {
                    this.toolStripStatusLabel1.Visible = true;
                    this.toolStripStatusLabel1.Text = $"The approach {mission.Approach} could not be deployed (no ICAO set)!";
                    return;
                }

                var flt = mission.Replace(tpl);
                File.WriteAllText(this.GenericFilename, flt, Encoding.GetEncoding(1252));

                var weatherTemplate = "ClearSky";
                if (File.Exists($"Templates/{this.cmbWeatherTemplate.Text}.WPR"))
                    weatherTemplate = this.cmbWeatherTemplate.Text;

                var weather = File.ReadAllText($"Templates/{weatherTemplate}.WPR", Encoding.GetEncoding(1252));
                weather = weather.Replace("${dir}", this.numWindFrom.Value.ToString());
                weather = weather.Replace("${speed}", this.numWindKnots.Value.ToString());
                File.WriteAllText(this.WeatherFilename, weather, Encoding.GetEncoding(1252));

                this.toolStripStatusLabel1.Visible = true;
                this.toolStripStatusLabel1.Text = $"The approach {mission.Approach} was deployed!";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Visible = true;
            this.toolStripStatusLabel1.Text = "Approaches successfully saved!";

            Properties.Settings.Default.SelectedApproach = this.listBox1.SelectedIndex;
            Properties.Settings.Default.Approaches = JsonConvert.SerializeObject(this.Missions);
            Properties.Settings.Default.Save();
            this.SetDirtyText(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Visible = false;

            Properties.Settings.Default.SelectedApproach = this.listBox1.SelectedIndex;
            Properties.Settings.Default.Save();

            if (this.listBox1.SelectedItem is Mission mission)
            {
                this.IsInitialized = false;
                this.txtName.Text = mission.Approach;
                this.txtIcao.Text = mission.ICAO;
                this.txtHeading.Text = mission.Heading;
                this.txtAltitude.Text = mission.Altitude;
                this.txtLatitude.Text = mission.Latitude;
                this.txtLongitude.Text = mission.Longitude;
                this.txtRunway.Text = mission.RunwayNumber.ToString();
                this.cmbRunwayDesignator.Text = mission.RunwayDesignator;
                this.numWindFrom.Value = mission.WindDirection;
                this.numWindKnots.Value = mission.WindSpeed;
                this.txtAirspeed.Text = mission.Airspeed;
                this.cmbWeatherTemplate.Text = mission.WeatherTemplate;
                this.cmbAirplane.Text = mission.Plane;
                this.dtFlight.Value = mission.DateOfFlight;
                this.txtFlaps.Text = mission.Flaps;
                this.IsInitialized = true;
            }
        }

        private void btnNewApproach_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Visible = false;
            var newMission = new Mission();
            this.Missions.Add(newMission);
            var idx = this.listBox1.Items.Add(newMission);
            this.listBox1.SelectedIndex = idx;
            this.SetDirtyText(true);
        }

        private void WriteCurrentApproach()
        {
            this.toolStripStatusLabel1.Visible = false;
            if (this.listBox1.SelectedItem is Mission mission && this.IsInitialized)
            {
                mission.Approach = this.txtName.Text;
                mission.ICAO = this.txtIcao.Text;
                mission.Heading = this.txtHeading.Text;
                mission.Altitude = this.txtAltitude.Text;
                mission.Latitude = this.txtLatitude.Text;
                mission.Longitude = this.txtLongitude.Text;
                mission.RunwayNumber = this.txtRunway.Text;
                mission.RunwayDesignator = this.cmbRunwayDesignator.Text;
                mission.WindDirection = (int)this.numWindFrom.Value;
                mission.WindSpeed = (int)this.numWindKnots.Value;
                mission.Airspeed = this.txtAirspeed.Text;
                mission.WeatherTemplate = this.cmbWeatherTemplate.Text;
                mission.Plane = this.cmbAirplane.Text;
                mission.DateOfFlight = this.dtFlight.Value;
                mission.Flaps = this.txtFlaps.Text;

                this.listBox1.Items[this.listBox1.SelectedIndex] = this.listBox1.SelectedItem;
                this.SetDirtyText(true);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void cmbRunwayDesignator_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtRunway_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void cmbRunwayDesignator_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtIcao_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void dtFlight_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtLatitude_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtLongitude_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtHeading_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtAltitude_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtAirspeed_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void cmbAirplane_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void txtFlaps_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void numWindFrom_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void numWindKnots_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void cmbWeatherTemplate_Validated(object sender, EventArgs e)
        {
            this.WriteCurrentApproach();
        }

        private void setPackageFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Visible = false;
            this.folderBrowserDialog1.SelectedPath = Properties.Settings.Default.PackageFolder;
            var ret = this.folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                // Check if there are Community and Official folders
                var communityFolder = Path.Combine(this.folderBrowserDialog1.SelectedPath, "Community");
                var officialFolder = Path.Combine(this.folderBrowserDialog1.SelectedPath, "Official");
                if (!Directory.Exists(communityFolder) || !Directory.Exists(officialFolder))
                {
                    MessageBox.Show(
                        "Please select the package folder that contains the directories Community and Official. Restart the application to try again.", "Invalid directory selected.");
                    Application.Exit();
                }

                // Save the settings
                Properties.Settings.Default.PackageFolder = this.folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                // Cache the filenames
                this.CacheFilenames();

                // Extract and overwrite the package
                try
                {
                    ZipFile.ExtractToDirectory("Templates/package.zip", folderBrowserDialog1.SelectedPath);
                }
                catch (Exception)
                {
                    // Ignore exception, if the files already exists we can continue
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void CacheFilenames()
        {
            this.GenericFilename = Path.Combine(
                Properties.Settings.Default.PackageFolder,
                "Community",
                "dryjet-landingchallenge-created",
                "Missions",
                "Asobo",
                "LandingChallenges",
                "Generic",
                "Generic.FLT"
            );
            this.WeatherFilename = Path.Combine(
                Properties.Settings.Default.PackageFolder,
                "Community",
                "dryjet-landingchallenge-created",
                "Missions",
                "Asobo",
                "LandingChallenges",
                "Generic",
                "Weather.WPR"
            );
        }

        private void SetDirtyText(bool isDirty)
        {
            this.btnSave.Text = isDirty ? "Save changes *" : "Save changes";
            this.Text = isDirty ? "Landing Challenge Creator *" : "Landing Challenge Creator";
        }
    }
}
