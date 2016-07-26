using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace meetup_rsvp
{
    public partial class Form1 : Form
    {
        private static string dateTimeServerUrl = "http://www.timeanddate.com/worldclock/uk/london";
        private static bool compareTimes = false; // compares local time with event time
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Shown(object sender, EventArgs e)
        {
            txbUrl.Focus();
            tmrLocalDateTime.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchAndShowDateNTime();
        }
        private void tmrLocalDateTime_Tick(object sender, EventArgs e)
        {
            UpdateLocalTimeLabels();
            CheckEventTimeReached();
        }

        
        /// <summary>
        /// takes a url and returns a string of response after making a get request.
        /// make sure you call ValidateUrl first
        /// </summary>
        /// <param name="url">http or https url</param>
        /// <returns></returns>
        private string GetResponse(string url)
        {
            string allData="";
            
            try
            {
                Stream streamedData;
                WebRequest request = WebRequest.Create(url);
                streamedData = request.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(streamedData);
                string line = "";
                StringBuilder allText = new StringBuilder();
                while (line != null)
                {
                    if (line.Length > 0)
                        allText.Append(line);

                    line = sr.ReadLine();
                }
                allData = allText.ToString();
            }
            catch (Exception ex)
            {
                allData = "Service Error";
                Debug.WriteLine("Error Message:" + ex.Message);
                Debug.WriteLine("Stack Trace:" + ex.StackTrace);
            }
            return allData;
        } // GetResponse() ends

        /// <summary>
        /// Validates an http or https url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private bool ValidateUrl(string url)
        {
            if (url == string.Empty)
                return false;

            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) 
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        } // validateUrl() ends

        private void FetchAndShowDateNTime()
        {
            
            UpdateAppStatus("Fetching data from timeanddate.com");
            bool isValidTimeServer = ValidateUrl(dateTimeServerUrl);
            if (isValidTimeServer)
            {
                string strTime;
                string strDate;

                string response = GetResponse(dateTimeServerUrl);
                if (response == string.Empty || response == "Service Error")
                {
                    UpdateAppStatus("Shit! that failed :( ");
                    return;
                }
                string srchTime = "<span id=ct class=h1>";
                string srchDate = "<span id=ctdat>";

                int startIndex = response.IndexOf(srchTime) + srchTime.Length;
                strTime = response.Substring(startIndex, 8);

                startIndex = response.IndexOf(srchDate) + srchDate.Length;
                strDate = response.Substring(startIndex, 100);
                strDate = strDate.Substring(0, strDate.IndexOf("</span>"));

                lblTADdate.Text = strDate;
                lblTADtime.Text = strTime;
                UpdateAppStatus("timeanddate.com data fetched successfully");
                UpdateAppStatus("-----------------------------------------");
            }
            else
            {
                MessageBox.Show("Invalid Remote Date Time Server: " + dateTimeServerUrl);
            }
        }

        private void UpdateAppStatus(string message)
        {
            txbStatus.Text += Environment.NewLine + message;
        }



        private void UpdateLocalTimeLabels()
        {
            this.lblLocalDate.Text = DateTime.Now.ToShortDateString();
            this.lblLocalTime.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void CheckEventTimeReached()
        {
            if (compareTimes)
            {
                if (lblLocalDate.Text == dtpEventDate.Value.ToShortDateString()
                    && lblLocalTime.Text == dtpEventTime.Value.ToLongTimeString())
                {
                    if (ValidateUrl(txbUrl.Text.Trim()))
                    {
                        //Debug.WriteLine("KABOOM");
                        UpdateAppStatus("Firing request for scheduled event");
                        UpdateAppStatus("URL: " + txbUrl.Text);
                        UpdateAppStatus("Date and Time: " + dtpEventDate.Value.ToShortDateString() + "  " + dtpEventTime.Value.ToLongTimeString());
                        string response = GetResponse(txbUrl.Text.Trim());
                        UpdateAppStatus("Response Received:");
                        UpdateAppStatus("----");
                        UpdateAppStatus(response);
                        UpdateAppStatus("----");

                    }
                    else
                    {
                        UpdateAppStatus("Invalid Request URL");
                    }
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = false;
            btnCancel.Enabled = true;
            compareTimes = true;
            txbUrl.Enabled = false;
            DateTime eventDate = dtpEventDate.Value;
            DateTime eventTime = dtpEventTime.Value;
            dtpEventDate.Enabled = false;
            dtpEventTime.Enabled = false;

            //Debug.WriteLine(eventDate.ToShortDateString());
            //Debug.WriteLine(eventTime.ToLongTimeString());
            UpdateAppStatus("Request set for url: " + txbUrl.Text.Trim());
            UpdateAppStatus("----------------------------------");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            txbUrl.Enabled = true;
            dtpEventDate.Enabled = true;
            dtpEventTime.Enabled = true;
            compareTimes = false;
            btnSet.Enabled = true;
            UpdateAppStatus("Request cancelled for url: " + txbUrl.Text.Trim());
            UpdateAppStatus("----------------------------------");
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbStatus.Clear();
        }

        


    }
}
