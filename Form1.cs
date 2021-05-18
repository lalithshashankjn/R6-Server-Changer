using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace R6_Server_Changer
{
    public partial class Form1 : Form
    {
        string myGamesPath= "";
        DataGridViewComboBoxCell dgvDataCenterHintCombo = new DataGridViewComboBoxCell();
        List<string> ids;
        string[] dataCenters = {"default",
                                   "eastus",
                                   "centralus",
                                   "southcentralus",
                                   "westus",
                                   "brazilsouth",
                                   "northeurope",
                                   "westeurope",
                                   "southafricanorth",
                                   "eastasia",
                                   "southeastasia",
                                   "australiaeast",
                                   "australiasoutheast",
                                   "japanwest" };
        Dictionary<string, string> r6ServerURLs = new Dictionary<string, string>();
        Dictionary<string, string> profileIDData = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var gamesPath = System.IO.Path.Combine(path, "My Games");
            gamesPath = System.IO.Path.Combine(gamesPath, "Rainbow Six - Siege");
            myGamesPath = gamesPath;
            populateLists();
            if (profileIDData.Count > 0)
            {
                updateDataGrid();
            }
            
        }

        //supporting functions
        #region
        private void generateConfig()
        {
            profileIDData.Clear();
            for (int i = 0; i < ids.Count; i++)
            {
                string xpath = ids[i] + "\\GameSettings.ini";
                if (File.Exists(ids[i] + "\\GameSettings.ini"))
                {
                    //DataCenterHint = southeastasia
                    StreamReader file = new StreamReader(xpath);
                    string line = "";
                    string currentDatacenter = "";
                    string userName = "";
                    string profileID = ids[i].Replace(myGamesPath + "\\", "");

                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains("DataCenterHint="))
                        {
                            try
                            {                                
                                currentDatacenter = line.Split('=')[1];
                                userName = GetUsername(profileID);
                                
                                profileIDData.Add(profileID, userName);
                                
                            }
                            catch (Exception exp)
                            {
                                lblToolStatus.Text = "Error Generating Config Dictionary";
                                profileIDData.Add(profileID, "Invalid User");
                            }
                        }
                    }
                }                
            }
            //txtboxSteamPath.Text = myGamesPath + "\\ToolConfig.ini";
            lblToolStatus.Text = myGamesPath + "\\ToolConfig.ini";
            using (StreamWriter sw = new StreamWriter(myGamesPath + "\\ToolConfig.ini"))
            {                
                foreach (string keyName in profileIDData.Keys)
                {
                    sw.WriteLine(keyName.Trim() + ":"+ profileIDData[keyName].Trim());
                }
                sw.Close();
            }
            if (File.Exists(myGamesPath + "\\ToolConfig.ini"))
            {
                string str = File.ReadAllText(myGamesPath + "\\ToolConfig.ini");
                if (!str.Contains(txtboxSteamPath.Text))
                {
                    File.AppendAllText(myGamesPath + "\\ToolConfig.ini", txtboxSteamPath.Text + Environment.NewLine);
                }
            }
        }

        private void updateDataGrid()
        {
            if (profileIDData.Count > 0)
            {
                dgvAccounts.Rows.Clear();
                for (int i = 0; i < ids.Count; i++)
                {
                    string xpath = ids[i] + "\\GameSettings.ini";
                    if (File.Exists(ids[i] + "\\GameSettings.ini"))
                    {
                        //DataCenterHint = southeastasia
                        StreamReader file = new StreamReader(xpath);
                        string line = "";
                        string currentDatacenter = "";
                        string userName = "";
                        string profileID = ids[i].Replace(myGamesPath + "\\", "");

                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains("DataCenterHint="))
                            {
                                try
                                {
                                    DataGridViewRow dgvRow = new DataGridViewRow();                                    
                                    currentDatacenter = line.Split('=')[1];
                                    userName = profileIDData[profileID];
                                    //DataGridViewRow dgvRow = new DataGridViewRow();
                                    dgvAccounts.Rows[i].Cells[0].Value = profileID;
                                    dgvAccounts.Rows[i].Cells[1].Value = userName;
                                    dgvAccounts.Rows[i].Cells[2].Value = currentDatacenter;
                                    dgvDataCenterHintCombo = (dgvAccounts.Rows[i].Cells[3] as DataGridViewComboBoxCell);
                                    dgvDataCenterHintCombo.Items.AddRange(dataCenters);
                                    dgvAccounts.Rows[i].Cells[3].Value = dgvDataCenterHintCombo.Items[0];
                                    DataGridViewButtonCell dgvUpdateButton = (dgvAccounts.Rows[i].Cells[4] as DataGridViewButtonCell);
                                    dgvUpdateButton.Value = "Update!";
                                }
                                catch (Exception exp)
                                {

                                }
                            }
                        }
                        file.Close();
                    }
                }
            }
            lblToolStatus.Text = "Updated current status of the files";
        }

        private string  GetUsername(string userID)
        {
            WebClient x = new WebClient();

            string url = r6ServerURLs[comboR6DB.SelectedItem.ToString()] + userID;
            string userName = "";
            try
            {
                string source = x.DownloadString(url);
                string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;

                if (comboR6DB.SelectedIndex == 0)
                {
                    userName = title.Split('-')[1];
                }
                else if (comboR6DB.SelectedIndex == 1)
                {
                    userName = title.Split('|')[1];
                    userName = userName.Split(new string[] { "'" }, StringSplitOptions.None)[0];
                }
            }
            catch 
            {

            }
            
            return userName;


        }

        private void updateGameSettingsFile(string profileID, string oldDataCenter, string newDataCenter)
        {
            string xpath = myGamesPath +"\\"+ profileID + "\\GameSettings.ini";
            if(File.Exists(xpath))
            {
                string str = File.ReadAllText(xpath);
                str = str.Replace("DataCenterHint="+oldDataCenter, "DataCenterHint=" +newDataCenter);
                File.WriteAllText(xpath, str);
            }
            updateDataGrid();
        }

        private void populateLists()
        {
            if (myGamesPath != "")
            {
                ids = Directory.GetDirectories(myGamesPath).ToList<string>();
            }
            //dgvDataCenterHintCombo.Items.AddRange(dataCenters);            

            string[] r6ServersChoices = { "R6 Tracker", "R6 DB" };

            comboR6DB.Items.AddRange(r6ServersChoices);
            comboR6DB.SelectedIndex = 0;
            
            string[] r6ServersChoiceURLs = { "https://r6.tracker.network/profile/id/", "https://r6db.net/player/" };

            for (int i=0; i < r6ServersChoices.Length;i++ )
            {
                r6ServerURLs.Add(r6ServersChoices[i], r6ServersChoiceURLs[i]);
            }

            if (File.Exists(myGamesPath + "\\ToolConfig.ini"))
            {
                profileIDData.Clear();
                try
                {
                    foreach (string line in File.ReadLines(myGamesPath + "\\ToolConfig.ini"))
                    {
                        if (File.Exists(line))
                        {
                            if (line.Contains("steam.exe"))
                            {
                                txtboxSteamPath.Text = line;
                            }
                            else
                            {
                                txtboxSteamPath.Text = "Steam path doesn't exist in config. Regenerate config";
                            }
                        }
                        else
                        {
                            if (line.Split(':').Length == 2)
                            {
                                profileIDData.Add(line.Split(':')[0].Trim(), line.Split(':')[1].Trim());
                            }
                        }
                    }
                    lblToolStatus.Text = myGamesPath + "\\ToolConfig.ini";
                }
                catch (Exception exp)
                {
                    lblToolStatus.Text = "Regenerate the config file by pressing Generate config file button";
                    File.Delete(myGamesPath + "\\ToolConfig.ini");
                }
            }
            else
            {
                lblToolStatus.Text = "FIRST RUN USER: Generate the config file";
                txtboxSteamPath.Text = "C:\\Program Files (x86)\\Steam\\steam.exe";
                btnUpdateDataAndConfig.Text = "Press here to Generate Config file and update table";
                return;
            }

        }
        #endregion

        //event handlers
        #region
        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&  e.RowIndex >= 0)
            {

                if (dgvAccounts[3, e.RowIndex].Value.ToString().Trim() != null)
                {
                    updateGameSettingsFile(dgvAccounts[0, e.RowIndex].Value.ToString().Trim(),
                                            dgvAccounts[2, e.RowIndex].Value.ToString().Trim(),
                                            dgvAccounts[3, e.RowIndex].Value.ToString().Trim());
                }               
                
            }
        }

        private void btnUpdateDataGrid_Click(object sender, EventArgs e)
        {
            File.Delete(myGamesPath + "\\ToolConfig.ini");
            generateConfig();
            updateDataGrid();
        }

        private void btnOpenTaskManager_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            System.Diagnostics.ProcessStartInfo startSteam = new System.Diagnostics.ProcessStartInfo();
            startSteam.FileName = Path.GetFullPath(txtboxSteamPath.Text);
            startSteam.Arguments = " -applaunch 359550";
            startSteam.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startSteam.CreateNoWindow = true;
            System.Diagnostics.Process.Start(startSteam);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(myGamesPath + "\\ToolConfig.ini"))
            {
                string str = File.ReadAllText(myGamesPath + "\\ToolConfig.ini");
                if (File.Exists(txtboxSteamPath.Text))
                {
                    if (!str.Contains(txtboxSteamPath.Text))
                    {

                        File.AppendAllText(myGamesPath + "\\ToolConfig.ini", txtboxSteamPath.Text + Environment.NewLine);
                    }                    
                }
                else
                {
                    MessageBox.Show("Steam path isn't valid, not saving in config");
                }
            }
        }

        private void btnUpdateDataAndConfig_MouseEnter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
