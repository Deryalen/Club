namespace Club
{
    partial class EditEvent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label sponsorLabel;
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new Club.RunningClubDataSetTableAdapters.TableAdapterManager();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.sponsorComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noSponsorCheckBox = new System.Windows.Forms.CheckBox();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorTableAdapter = new Club.RunningClubDataSetTableAdapters.SponsorTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            sponsorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.runningClubDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.EventDistancesTableAdapter = null;
            this.tableAdapterManager.EventHeatsTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.HeatParticipantsTableAdapter = null;
            this.tableAdapterManager.HeatTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = this.sponsorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Club.RunningClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 62);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(94, 58);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(12, 87);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(36, 13);
            levelLabel.TabIndex = 7;
            levelLabel.Text = "Level:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 113);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 9;
            typeLabel.Text = "Type:";
            // 
            // sponsorLabel
            // 
            sponsorLabel.AutoSize = true;
            sponsorLabel.Location = new System.Drawing.Point(12, 139);
            sponsorLabel.Name = "sponsorLabel";
            sponsorLabel.Size = new System.Drawing.Size(49, 13);
            sponsorLabel.TabIndex = 11;
            sponsorLabel.Text = "Sponsor:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(94, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.levelComboBox.Location = new System.Drawing.Point(94, 84);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(200, 21);
            this.levelComboBox.TabIndex = 15;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Кубок",
            "Чемпионат",
            "Пробег"});
            this.typeComboBox.Location = new System.Drawing.Point(94, 110);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 21);
            this.typeComboBox.TabIndex = 16;
            // 
            // sponsorComboBox
            // 
            this.sponsorComboBox.DataSource = this.sponsorBindingSource;
            this.sponsorComboBox.DisplayMember = "Name";
            this.sponsorComboBox.FormattingEnabled = true;
            this.sponsorComboBox.Location = new System.Drawing.Point(94, 136);
            this.sponsorComboBox.Name = "sponsorComboBox";
            this.sponsorComboBox.Size = new System.Drawing.Size(200, 21);
            this.sponsorComboBox.TabIndex = 17;
            this.sponsorComboBox.ValueMember = "Id";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(12, 199);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(175, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // noSponsorCheckBox
            // 
            this.noSponsorCheckBox.AutoSize = true;
            this.noSponsorCheckBox.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSponsorCheckBox.Location = new System.Drawing.Point(94, 163);
            this.noSponsorCheckBox.Name = "noSponsorCheckBox";
            this.noSponsorCheckBox.Size = new System.Drawing.Size(90, 16);
            this.noSponsorCheckBox.TabIndex = 20;
            this.noSponsorCheckBox.Text = "No sponsor";
            this.noSponsorCheckBox.UseVisualStyleBackColor = true;
            this.noSponsorCheckBox.CheckedChanged += new System.EventHandler(this.noSponsorCheckBox_CheckedChanged);
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.runningClubDataSet;
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.noSponsorCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.sponsorComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(levelLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(sponsorLabel);
            this.Name = "EditEvent";
            this.Text = "EditEvent";
            this.Load += new System.EventHandler(this.EditEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private RunningClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox sponsorComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox noSponsorCheckBox;
        private RunningClubDataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private System.Windows.Forms.BindingSource sponsorBindingSource;
    }
}