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

// amending it so don't have to count down every second
// The check every second is updating label..in timer's tick.. we have to have that.
// but checking whether the date time picker time match the current time..

// amending it so can do any command. DONE
// implement GET command

    // won't be using windows time server &/ windows ntp server.
     

    // can copy a line without selecting it just doing ctrl-c
    // colons in labels so when nothing in them you can see them on the form to select them


    // some weird bug one time.


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
            try
            {
                FetchTAD(); // TAD - time and date.com
            }
            catch(Exception  ee)
            {
                Debug.WriteLine(ee.ToString());
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbCommand.Focus();
            tmrLocalDateTime.Start();
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = false;
            btnCancel.Enabled = true;
            compareTimes = true;
            txbCommand.Enabled = false;
            DateTime eventDate = dtpEventDate.Value;  // maybe not used
            DateTime eventTime = dtpEventTime.Value;  // maybe not used
            dtpEventDate.Enabled = false;
            dtpEventTime.Enabled = false;

            //Debug.WriteLine(eventDate.ToShortDateString());
            //Debug.WriteLine(eventTime.ToLongTimeString());
            UpdateAppStatus("Command scheduled " + txbCommand.Text+ " on Date and Time: " + dtpEventDate.Value.ToShortDateString() + "  " + dtpEventTime.Value.ToLongTimeString());
            UpdateAppStatus("----------------------------------"); //B

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            txbCommand.Enabled = true;
            dtpEventDate.Enabled = true;
            dtpEventTime.Enabled = true;
            compareTimes = false;
            btnSet.Enabled = true;
            UpdateAppStatus("Cancelled: " + txbCommand.Text.Trim());
            UpdateAppStatus("----------------------------------"); // A
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbStatus.Clear();
        }


        private void tmrLocalDateTime_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateLocalTimeLabels();
                // Update TAD time locally only if fetch was succcessful when app started.
                if (updateTADTime)
                    UpdateTADLocally();
                CheckEventTimeReached();
            }
            catch(Exception ee)
            {
                Debug.WriteLine(ee.ToString());
            }
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

            if(url.StartsWith("https://"))
            {
                UpdateAppStatus("can't do get https://  gotta be http:// or just get [domain], or use curl (can do that in this program)");
                return "Service Error"; // gotta be one of those responses.. "Service Error", "", .. 
            }

            if (!url.ToLower().StartsWith("http://")) url = "http://" + url;
           // if (!url.ToLower().StartsWith("https://")) url = "https://" + url;

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

        private string ExecuteCommand(string args)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();

            //string[] parts = args.Split(new char[] { ' ' });
            //string[] parts = args.Split(' ');

            string nameofcommandrun;
            string argumentstocommand="";

            args = args.Trim();
            if (args.IndexOf(' ') != -1)
            {
                nameofcommandrun = args.Substring(0, args.IndexOf(' '));
                Debug.WriteLine(nameofcommandrun + nameofcommandrun.Length);
                argumentstocommand = args.Substring(nameofcommandrun.Length + 1);
                Debug.WriteLine(argumentstocommand + argumentstocommand.Length);
            }
            else
                nameofcommandrun = args;

            //            ProcessStartInfo pinfo = new ProcessStartInfo(@"C:\Installed\curl740\curl.exe", args);

            // seems like it doesn't work when no url is given, which is very strange.
            ProcessStartInfo pinfo = new ProcessStartInfo(nameofcommandrun, args);

            pinfo.UseShellExecute = false;
            pinfo.RedirectStandardOutput = true;
            pinfo.RedirectStandardError = true;

            pinfo.CreateNoWindow = true;
            try
            {
                Process pCurl = Process.Start(pinfo);

                sb.Append("showing stdout:" + Environment.NewLine);

                while (!pCurl.StandardOutput.EndOfStream)                
                    sb.Append(pCurl.StandardOutput.ReadLine());

                sb.Append("showing stderr:" + Environment.NewLine);
                
                while (!pCurl.StandardError.EndOfStream)
                    sb.Append(pCurl.StandardError.ReadLine());

                result = sb.ToString();
            }
            catch
            {
                UpdateAppStatus(nameofcommandrun + " not found in PATH");
            }
            
            return result;
        }

        /// <summary>
        /// Validates an http or https url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// http://stackoverflow.com/questions/7578857/how-to-check-whether-a-string-is-a-valid-http-url
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
                UpdateAppStatus("-----------------------------------");
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

                    // only when the time matches

                        txbCommand.Text = txbCommand.Text.Trim(); 
                        //Debug.WriteLine("KABOOM");
                        UpdateAppStatus("Firing request for scheduled event "+ txbCommand.Text+"\r\n"+"on Date and Time: " + dtpEventDate.Value.ToShortDateString() + "  " + dtpEventTime.Value.ToLongTimeString());
                        //UpdateAppStatus("URL: " + txbCommand.Text);
                    //string response = GetResponse(txbCurlCommand.Text.Trim());

                    string response;

                    if (txbCommand.Text.ToLower() == "get")
                        response = "specify parameter to get";
                    else if(txbCommand.Text.ToLower().StartsWith("get ")) { //implies something after space because already trimmed
                        response = GetResponse(txbCommand.Text.Substring(4)); //startindex 4, to end. The cas ein most languages. startindex and length. To start from beginning do 0,
                    }
                    else
                        response = ExecuteCommand(txbCommand.Text.Trim());

                        UpdateAppStatus("Response:"); 
                   //     UpdateAppStatus("----");
                        UpdateAppStatus(response);
                        UpdateAppStatus("----");
                }
            }
        }


    } // form ends
} // namespace ends
// POST tester : http://www.hashemian.com/tools/form-post-tester.php -d "abc=123"