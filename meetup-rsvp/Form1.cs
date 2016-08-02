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
        private  string dateTimeServerUrl = "http://www.timeanddate.com/worldclock/uk/london";
        private  bool compareTimes = false; // compares local time with event time
        private  bool updateTADTime = false;
        private DigiClock clockTAD; // clock for timeanddate.com
        public Form1()
        {
            InitializeComponent();
        }

        // EVENT HANDLERS
        private void Form1_Load(object sender, EventArgs e)
        {
            FetchTAD(); // TAD - time and date.com
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbCurlCommand.Focus();
            tmrLocalDateTime.Start();
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = false;
            btnCancel.Enabled = true;
            compareTimes = true;
            txbCurlCommand.Enabled = false;
            DateTime eventDate = dtpEventDate.Value;
            DateTime eventTime = dtpEventTime.Value;
            dtpEventDate.Enabled = false;
            dtpEventTime.Enabled = false;

            //Debug.WriteLine(eventDate.ToShortDateString());
            //Debug.WriteLine(eventTime.ToLongTimeString());
            UpdateAppStatus("Request set for url: " + txbCurlCommand.Text.Trim());
            UpdateAppStatus("----------------------------------");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            txbCurlCommand.Enabled = true;
            dtpEventDate.Enabled = true;
            dtpEventTime.Enabled = true;
            compareTimes = false;
            btnSet.Enabled = true;
            UpdateAppStatus("Request cancelled for url: " + txbCurlCommand.Text.Trim());
            UpdateAppStatus("----------------------------------");
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbStatus.Clear();
        }


        private void tmrLocalDateTime_Tick(object sender, EventArgs e)
        {
            UpdateLocalTimeLabels();
            // Update TAD time locally only if fetch was succcessful when app started.
            if (updateTADTime)
                UpdateTADLocally();
            CheckEventTimeReached();
        }

        // METHODS CALLED FROM EVENT HANDLERS OR OTHER METHODS

        /// <summary>
        /// takes a url and returns a string of response after making a get request.
        /// make sure you call ValidateUrl first
        /// </summary>
        /// <param name="url">http or https url</param>
        /// <returns></returns>
        ///
        // google make http request c# 
        // derived from msdn
        
        // from msdn 
        // https://support.microsoft.com/en-in/kb/307023
        // How to make a GET request by using Visual C#
        // and you added a catch and a string to return when an error.

            // ctrl KK, KP, KN.  view..bookmark window

            // top right drop down to get to a function

        private string GetResponse(string url)
        {
            string allData="";
            
            try
            {
                Stream streamedData;
                WebRequest request = WebRequest.Create(url);
                // why is response a stream rather than a string?
                // might be big.

                // The GET
                streamedData = request.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(streamedData);
                string line = "";
                // StringBuilder is much more efficient than str+=".." 
                // because strings are immutable.


                // http://stackoverflow.com/questions/17801761/converting-stream-to-string-and-back-what-are-we-missing
                // ReadToEnd()
                // readToEnd is not recommended for a large amount.
                // hmm who knows maybe it uses buffers, why wouldn't it?
                // e.g. throw an exception on taking too long
               
                // StringBuilder is recommended for a large amount? yes. stringbuilder with streamreader and in this case, Stream.
                // i'm not contrasting += with stringbuilder. we agree stringbuilder is better.
                // i'm contrasting stringbuilder with readtoend. clearly both have the whole string.
                // you say then it's almsot equal. that's my point. And less code.

                // ok so the += is expensive..
                // but string can take a large amount then and is used to here.
                

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

        private string ExecuteCurl(string args)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
//            ProcessStartInfo pinfo = new ProcessStartInfo(@"C:\Installed\curl740\curl.exe", args);
            ProcessStartInfo pinfo = new ProcessStartInfo("curl.exe", args);

            pinfo.UseShellExecute = false;
            pinfo.RedirectStandardOutput = true;
            pinfo.CreateNoWindow = true;
            try
            {
                Process pCurl = Process.Start(pinfo);
                while (!pCurl.StandardOutput.EndOfStream)
                {
                    sb.Append(pCurl.StandardOutput.ReadLine());
                }
                result = sb.ToString();
            }
            catch
            {
                UpdateAppStatus("curl not found in PATH");
            }
            
            return result;
        }

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

        
        private void FetchTAD()
        {
            
            UpdateAppStatus("Fetching data from timeanddate.com");
            bool isValidTimeServer = ValidateUrl(dateTimeServerUrl);
            if (isValidTimeServer)
            {
                string strTime;
                string strDate;

                // Get Responds is something you wrote derived from msdn site
                string response = GetResponse(dateTimeServerUrl);
                if (response == string.Empty || response == "Service Error")
                {
                    UpdateAppStatus("Shit! that failed :( ");
                    return;
                }

                // for date and time,
                // no need for a regex..
                // just everything in between a specific thing.
                // for time, 8 char after the opening tag
                // for date, you used two substrings to get between two tags.
                // the second substring has 0 as first parameter and index of ending tag as last parameter.

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
                updateTADTime = true;
                clockTAD = new DigiClock(strTime);
            }
            else
            {
                MessageBox.Show("Invalid Remote Date Time Server: " + dateTimeServerUrl);
            }
        }

        /* Midnight fetch test:
          
         int nth = 0;
         nth++;
            if (nth == 10)
                currentTime = "00:00:00"; 
         */
        private void UpdateTADLocally()
        {
            
            string currentTime = clockTAD.tick();
            lblTADtime.Text = currentTime;
            if (currentTime == "00:00:00")
            {
                updateTADTime = false;
                FetchTAD();
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
                   
                        //Debug.WriteLine("KABOOM");
                        UpdateAppStatus("Firing request for scheduled event");
                        UpdateAppStatus("URL: " + txbCurlCommand.Text);
                        UpdateAppStatus("Date and Time: " + dtpEventDate.Value.ToShortDateString() + "  " + dtpEventTime.Value.ToLongTimeString());
                        //string response = GetResponse(txbCurlCommand.Text.Trim());
                        string response = ExecuteCurl(txbCurlCommand.Text.Trim());

                        UpdateAppStatus("Response Received:");
                        UpdateAppStatus("----");
                        UpdateAppStatus(response);
                        UpdateAppStatus("----");
                }
            }
        }


    } // form ends
} // namespace ends
// POST tester : http://www.hashemian.com/tools/form-post-tester.php -d "abc=123"