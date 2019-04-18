namespace Game
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.G_Profile = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.G_Date = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.G_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Steps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Barriers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_Profile,
            this.G_Date,
            this.G_Duration,
            this.G_Steps,
            this.G_Barriers});
            this.Grid1.Location = new System.Drawing.Point(97, 27);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(543, 85);
            this.Grid1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.homePageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentProfileToolStripMenuItem,
            this.newProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // currentProfileToolStripMenuItem
            // 
            this.currentProfileToolStripMenuItem.Name = "currentProfileToolStripMenuItem";
            this.currentProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.currentProfileToolStripMenuItem.Text = "Current Profile";
            this.currentProfileToolStripMenuItem.Click += new System.EventHandler(this.currentProfileToolStripMenuItem_Click);
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newProfileToolStripMenuItem.Text = "New Profile";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Grid2
            // 
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.step,
            this.Direction});
            this.Grid2.Location = new System.Drawing.Point(137, 118);
            this.Grid2.Name = "Grid2";
            this.Grid2.Size = new System.Drawing.Size(387, 150);
            this.Grid2.TabIndex = 3;
            // 
            // step
            // 
            this.step.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.step.HeaderText = "step";
            this.step.Name = "step";
            this.step.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direction.HeaderText = "Direction";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Select.BackgroundImage")));
            this.Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Select.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Select.Location = new System.Drawing.Point(684, 380);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 58);
            this.Select.TabIndex = 19;
            this.Select.Text = "Select Player";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // G_Profile
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.G_Profile.DefaultCellStyle = dataGridViewCellStyle1;
            this.G_Profile.HeaderText = "Profile";
            this.G_Profile.Name = "G_Profile";
            // 
            // G_Date
            // 
            this.G_Date.HeaderText = "Date";
            this.G_Date.Name = "G_Date";
            this.G_Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.G_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // G_Duration
            // 
            this.G_Duration.HeaderText = "Duration";
            this.G_Duration.Name = "G_Duration";
            // 
            // G_Steps
            // 
            this.G_Steps.HeaderText = "# Steps";
            this.G_Steps.Name = "G_Steps";
            // 
            // G_Barriers
            // 
            this.G_Barriers.HeaderText = "#barriers";
            this.G_Barriers.Name = "G_Barriers";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grid1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "History";
            this.Text = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn G_Profile;
        private System.Windows.Forms.DataGridViewComboBoxColumn G_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Steps;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Barriers;
    }
}