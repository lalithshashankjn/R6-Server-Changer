namespace R6_Server_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnChangeDataCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCurrentServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComboNewServer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startGame = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tlpConfiguration = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateDataAndConfig = new System.Windows.Forms.Button();
            this.lblSteamStatus = new System.Windows.Forms.Label();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.lblSteamStatusResult = new System.Windows.Forms.Label();
            this.comboR6DB = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtboxSteamPath = new System.Windows.Forms.TextBox();
            this.lblSteamLocation = new System.Windows.Forms.Label();
            this.lblToolStatus = new System.Windows.Forms.Label();
            this.lblUPlay = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tlpConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.dgvAccounts, 0, 1);
            this.tlpMain.Controls.Add(this.btnStartGame, 0, 2);
            this.tlpMain.Controls.Add(this.tlpConfiguration, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(800, 320);
            this.tlpMain.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnChangeDataCenter,
            this.userName,
            this.dgvCurrentServer,
            this.dgvComboNewServer,
            this.startGame});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 126);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.Size = new System.Drawing.Size(795, 150);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // btnChangeDataCenter
            // 
            this.btnChangeDataCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnChangeDataCenter.HeaderText = "Profile ID";
            this.btnChangeDataCenter.Name = "btnChangeDataCenter";
            this.btnChangeDataCenter.ReadOnly = true;
            this.btnChangeDataCenter.Width = 69;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 78;
            // 
            // dgvCurrentServer
            // 
            this.dgvCurrentServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCurrentServer.HeaderText = "Current Server";
            this.dgvCurrentServer.Name = "dgvCurrentServer";
            this.dgvCurrentServer.ReadOnly = true;
            this.dgvCurrentServer.Width = 92;
            // 
            // dgvComboNewServer
            // 
            this.dgvComboNewServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvComboNewServer.HeaderText = "Choose New Server";
            this.dgvComboNewServer.Name = "dgvComboNewServer";
            // 
            // startGame
            // 
            this.startGame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startGame.HeaderText = "Update game settings file";
            this.startGame.Name = "startGame";
            this.startGame.Text = "Update";
            // 
            // btnStartGame
            // 
            this.btnStartGame.AutoSize = true;
            this.btnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(3, 282);
            this.btnStartGame.MaximumSize = new System.Drawing.Size(0, 30);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(795, 30);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tlpConfiguration
            // 
            this.tlpConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.tlpConfiguration.ColumnCount = 2;
            this.tlpConfiguration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfiguration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfiguration.Controls.Add(this.btnUpdateDataAndConfig, 1, 4);
            this.tlpConfiguration.Controls.Add(this.lblSteamStatus, 0, 0);
            this.tlpConfiguration.Controls.Add(this.btnTaskManager, 0, 4);
            this.tlpConfiguration.Controls.Add(this.lblSteamStatusResult, 1, 0);
            this.tlpConfiguration.Controls.Add(this.comboR6DB, 1, 3);
            this.tlpConfiguration.Controls.Add(this.lblDatabase, 0, 3);
            this.tlpConfiguration.Controls.Add(this.txtboxSteamPath, 1, 2);
            this.tlpConfiguration.Controls.Add(this.lblSteamLocation, 0, 2);
            this.tlpConfiguration.Controls.Add(this.lblToolStatus, 1, 1);
            this.tlpConfiguration.Controls.Add(this.lblUPlay, 0, 1);
            this.tlpConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConfiguration.Location = new System.Drawing.Point(3, 3);
            this.tlpConfiguration.Name = "tlpConfiguration";
            this.tlpConfiguration.RowCount = 5;
            this.tlpConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfiguration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfiguration.Size = new System.Drawing.Size(795, 117);
            this.tlpConfiguration.TabIndex = 3;
            // 
            // btnUpdateDataAndConfig
            // 
            this.btnUpdateDataAndConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDataAndConfig.Location = new System.Drawing.Point(400, 82);
            this.btnUpdateDataAndConfig.Name = "btnUpdateDataAndConfig";
            this.btnUpdateDataAndConfig.Size = new System.Drawing.Size(392, 32);
            this.btnUpdateDataAndConfig.TabIndex = 7;
            this.btnUpdateDataAndConfig.Text = "Update Data with account names";
            this.btnUpdateDataAndConfig.UseVisualStyleBackColor = true;
            this.btnUpdateDataAndConfig.Click += new System.EventHandler(this.btnUpdateDataGrid_Click);
            this.btnUpdateDataAndConfig.MouseEnter += new System.EventHandler(this.btnUpdateDataAndConfig_MouseEnter);
            // 
            // lblSteamStatus
            // 
            this.lblSteamStatus.AutoSize = true;
            this.lblSteamStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteamStatus.Location = new System.Drawing.Point(3, 0);
            this.lblSteamStatus.Name = "lblSteamStatus";
            this.lblSteamStatus.Size = new System.Drawing.Size(391, 13);
            this.lblSteamStatus.TabIndex = 0;
            this.lblSteamStatus.Text = "Steam Status (Double Click to Refresh)";
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaskManager.Location = new System.Drawing.Point(3, 82);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(391, 32);
            this.btnTaskManager.TabIndex = 6;
            this.btnTaskManager.Text = "Open Task Manager";
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.btnOpenTaskManager_Click);
            // 
            // lblSteamStatusResult
            // 
            this.lblSteamStatusResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSteamStatusResult.AutoSize = true;
            this.lblSteamStatusResult.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamStatusResult.Location = new System.Drawing.Point(400, 0);
            this.lblSteamStatusResult.Name = "lblSteamStatusResult";
            this.lblSteamStatusResult.Size = new System.Drawing.Size(53, 13);
            this.lblSteamStatusResult.TabIndex = 1;
            this.lblSteamStatusResult.Text = "Unknown";
            // 
            // comboR6DB
            // 
            this.comboR6DB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboR6DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboR6DB.FormattingEnabled = true;
            this.comboR6DB.Location = new System.Drawing.Point(400, 55);
            this.comboR6DB.Name = "comboR6DB";
            this.comboR6DB.Size = new System.Drawing.Size(392, 21);
            this.comboR6DB.TabIndex = 9;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabase.Location = new System.Drawing.Point(3, 52);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(391, 27);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Choose R6 Database";
            // 
            // txtboxSteamPath
            // 
            this.txtboxSteamPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxSteamPath.Location = new System.Drawing.Point(400, 29);
            this.txtboxSteamPath.Name = "txtboxSteamPath";
            this.txtboxSteamPath.Size = new System.Drawing.Size(392, 20);
            this.txtboxSteamPath.TabIndex = 5;
            this.txtboxSteamPath.Text = "C:\\Program Files (x86)\\Steam\\steam.exe";
            // 
            // lblSteamLocation
            // 
            this.lblSteamLocation.AutoSize = true;
            this.lblSteamLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteamLocation.Location = new System.Drawing.Point(3, 26);
            this.lblSteamLocation.Name = "lblSteamLocation";
            this.lblSteamLocation.Size = new System.Drawing.Size(391, 26);
            this.lblSteamLocation.TabIndex = 4;
            this.lblSteamLocation.Text = "Steam Location";
            // 
            // lblToolStatus
            // 
            this.lblToolStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolStatus.AutoSize = true;
            this.lblToolStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblToolStatus.Location = new System.Drawing.Point(400, 13);
            this.lblToolStatus.Name = "lblToolStatus";
            this.lblToolStatus.Size = new System.Drawing.Size(53, 13);
            this.lblToolStatus.TabIndex = 3;
            this.lblToolStatus.Text = "Unknown";
            // 
            // lblUPlay
            // 
            this.lblUPlay.AutoSize = true;
            this.lblUPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblUPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUPlay.Location = new System.Drawing.Point(3, 13);
            this.lblUPlay.Name = "lblUPlay";
            this.lblUPlay.Size = new System.Drawing.Size(391, 13);
            this.lblUPlay.TabIndex = 2;
            this.lblUPlay.Text = "Tool Status/ Messages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "R6 Server Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tlpConfiguration.ResumeLayout(false);
            this.tlpConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TableLayoutPanel tlpConfiguration;
        private System.Windows.Forms.Button btnUpdateDataAndConfig;
        private System.Windows.Forms.Label lblSteamStatus;
        private System.Windows.Forms.Button btnTaskManager;
        private System.Windows.Forms.Label lblSteamStatusResult;
        private System.Windows.Forms.ComboBox comboR6DB;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtboxSteamPath;
        private System.Windows.Forms.Label lblSteamLocation;
        private System.Windows.Forms.Label lblToolStatus;
        private System.Windows.Forms.Label lblUPlay;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnChangeDataCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCurrentServer;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvComboNewServer;
        private System.Windows.Forms.DataGridViewButtonColumn startGame;
    }
}

