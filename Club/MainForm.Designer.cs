namespace Club
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sponsorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFilterTab = new System.Windows.Forms.TabPage();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DBTabs = new System.Windows.Forms.TabControl();
            this.updateSelected = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.runningClubDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.clubTableAdapter1 = new Club.RunningClubDataSetTableAdapters.ClubTableAdapter();
            this.coachTableAdapter1 = new Club.RunningClubDataSetTableAdapters.CoachTableAdapter();
            this.distanceTableAdapter1 = new Club.RunningClubDataSetTableAdapters.DistanceTableAdapter();
            this.eventTableAdapter1 = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.sponsorTableAdapter1 = new Club.RunningClubDataSetTableAdapters.SponsorTableAdapter();
            this.participantTableAdapter1 = new Club.RunningClubDataSetTableAdapters.ParticipantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            this.ViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DBTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "Participant";
            this.participantBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.databasesToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.participantsToolStripMenuItem,
            this.coachesToolStripMenuItem,
            this.clubsToolStripMenuItem,
            this.sponsorsToolStripMenuItem,
            this.distancesToolStripMenuItem});
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.participantsToolStripMenuItem.Text = "Participants";
            this.participantsToolStripMenuItem.Click += new System.EventHandler(this.participantsToolStripMenuItem_Click);
            // 
            // coachesToolStripMenuItem
            // 
            this.coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            this.coachesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.coachesToolStripMenuItem.Text = "Coaches";
            this.coachesToolStripMenuItem.Click += new System.EventHandler(this.coachesToolStripMenuItem_Click);
            // 
            // clubsToolStripMenuItem
            // 
            this.clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            this.clubsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clubsToolStripMenuItem.Text = "Clubs";
            this.clubsToolStripMenuItem.Click += new System.EventHandler(this.clubsToolStripMenuItem_Click);
            // 
            // sponsorsToolStripMenuItem
            // 
            this.sponsorsToolStripMenuItem.Name = "sponsorsToolStripMenuItem";
            this.sponsorsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sponsorsToolStripMenuItem.Text = "Sponsors";
            this.sponsorsToolStripMenuItem.Click += new System.EventHandler(this.sponsorsToolStripMenuItem_Click);
            // 
            // distancesToolStripMenuItem
            // 
            this.distancesToolStripMenuItem.Name = "distancesToolStripMenuItem";
            this.distancesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.distancesToolStripMenuItem.Text = "Distances";
            this.distancesToolStripMenuItem.Click += new System.EventHandler(this.distancesToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStatsToolStripMenuItem,
            this.getToolStripMenuItem});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // getStatsToolStripMenuItem
            // 
            this.getStatsToolStripMenuItem.Name = "getStatsToolStripMenuItem";
            this.getStatsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.getStatsToolStripMenuItem.Text = "Get stats";
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.getToolStripMenuItem.Text = "Get report";
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // distanceBindingSource
            // 
            this.distanceBindingSource.DataMember = "Distance";
            this.distanceBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.runningClubDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 3;
            // 
            // SearchFilterTab
            // 
            this.SearchFilterTab.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFilterTab.Location = new System.Drawing.Point(4, 26);
            this.SearchFilterTab.Name = "SearchFilterTab";
            this.SearchFilterTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchFilterTab.Size = new System.Drawing.Size(960, 511);
            this.SearchFilterTab.TabIndex = 1;
            this.SearchFilterTab.Text = "Search and Filter";
            this.SearchFilterTab.UseVisualStyleBackColor = true;
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.dataGridView1);
            this.ViewTab.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewTab.Location = new System.Drawing.Point(4, 26);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(960, 511);
            this.ViewTab.TabIndex = 0;
            this.ViewTab.Text = "View";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // DBTabs
            // 
            this.DBTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBTabs.Controls.Add(this.ViewTab);
            this.DBTabs.Controls.Add(this.SearchFilterTab);
            this.DBTabs.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBTabs.Location = new System.Drawing.Point(12, 57);
            this.DBTabs.Name = "DBTabs";
            this.DBTabs.SelectedIndex = 0;
            this.DBTabs.Size = new System.Drawing.Size(968, 541);
            this.DBTabs.TabIndex = 4;
            // 
            // updateSelected
            // 
            this.updateSelected.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSelected.Location = new System.Drawing.Point(729, 27);
            this.updateSelected.Name = "updateSelected";
            this.updateSelected.Size = new System.Drawing.Size(119, 50);
            this.updateSelected.TabIndex = 5;
            this.updateSelected.Text = "Update Selected";
            this.updateSelected.UseVisualStyleBackColor = true;
            this.updateSelected.Click += new System.EventHandler(this.updateSelected_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelected.Location = new System.Drawing.Point(854, 27);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(119, 50);
            this.deleteSelected.TabIndex = 6;
            this.deleteSelected.Text = "Delete Selected";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // runningClubDataSetBindingSource
            // 
            this.runningClubDataSetBindingSource.DataSource = this.runningClubDataSet;
            this.runningClubDataSetBindingSource.Position = 0;
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubTableAdapter1
            // 
            this.clubTableAdapter1.ClearBeforeFill = true;
            // 
            // coachTableAdapter1
            // 
            this.coachTableAdapter1.ClearBeforeFill = true;
            // 
            // distanceTableAdapter1
            // 
            this.distanceTableAdapter1.ClearBeforeFill = true;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // sponsorTableAdapter1
            // 
            this.sponsorTableAdapter1.ClearBeforeFill = true;
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 610);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.updateSelected);
            this.Controls.Add(this.DBTabs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            this.ViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DBTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource runningClubDataSetBindingSource;
        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sponsorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distancesToolStripMenuItem;
        private RunningClubDataSetTableAdapters.ClubTableAdapter clubTableAdapter1;
        private RunningClubDataSetTableAdapters.CoachTableAdapter coachTableAdapter1;
        private RunningClubDataSetTableAdapters.DistanceTableAdapter distanceTableAdapter1;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
        private RunningClubDataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter1;
        private System.Windows.Forms.BindingSource sponsorBindingSource;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private System.Windows.Forms.BindingSource distanceBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage SearchFilterTab;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl DBTabs;
        private System.Windows.Forms.Button updateSelected;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private RunningClubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter1;
    }
}

