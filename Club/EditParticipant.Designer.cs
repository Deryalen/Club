namespace Club
{
    partial class EditParticipant
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
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label coachLabel;
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantTableAdapter = new Club.RunningClubDataSetTableAdapters.ParticipantTableAdapter();
            this.tableAdapterManager = new Club.RunningClubDataSetTableAdapters.TableAdapterManager();
            this.coachTableAdapter = new Club.RunningClubDataSetTableAdapters.CoachTableAdapter();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.coachComboBox = new System.Windows.Forms.ComboBox();
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noCoachCheckBox = new System.Windows.Forms.CheckBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            coachLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(12, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(31, 14);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(12, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 14);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(12, 67);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(63, 14);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.Location = new System.Drawing.Point(12, 94);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(111, 14);
            dateOfBirthLabel.TabIndex = 7;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // coachLabel
            // 
            coachLabel.AutoSize = true;
            coachLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coachLabel.Location = new System.Drawing.Point(12, 119);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new System.Drawing.Size(55, 14);
            coachLabel.TabIndex = 9;
            coachLabel.Text = "Coach:";
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = this.coachTableAdapter;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.EventDistancesTableAdapter = null;
            this.tableAdapterManager.EventHeatsTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.HeatParticipantsTableAdapter = null;
            this.tableAdapterManager.HeatTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = this.participantTableAdapter;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Club.RunningClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.genderComboBox.Location = new System.Drawing.Point(129, 63);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderComboBox.TabIndex = 11;
            // 
            // coachComboBox
            // 
            this.coachComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.coachComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.coachComboBox.DataSource = this.coachBindingSource;
            this.coachComboBox.DisplayMember = "Name";
            this.coachComboBox.FormattingEnabled = true;
            this.coachComboBox.Location = new System.Drawing.Point(129, 116);
            this.coachComboBox.Name = "coachComboBox";
            this.coachComboBox.Size = new System.Drawing.Size(200, 21);
            this.coachComboBox.TabIndex = 12;
            this.coachComboBox.ValueMember = "Id";
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(12, 165);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(210, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // noCoachCheckBox
            // 
            this.noCoachCheckBox.AutoSize = true;
            this.noCoachCheckBox.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCoachCheckBox.Location = new System.Drawing.Point(129, 143);
            this.noCoachCheckBox.Name = "noCoachCheckBox";
            this.noCoachCheckBox.Size = new System.Drawing.Size(76, 16);
            this.noCoachCheckBox.TabIndex = 15;
            this.noCoachCheckBox.Text = "No coach";
            this.noCoachCheckBox.UseVisualStyleBackColor = true;
            this.noCoachCheckBox.CheckedChanged += new System.EventHandler(this.noCoachCheckBox_CheckedChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(129, 8);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(129, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(129, 87);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 19;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.runningClubDataSet;
            // 
            // EditParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 221);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.noCoachCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.coachComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(coachLabel);
            this.Name = "EditParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditParticipant";
            this.Load += new System.EventHandler(this.EditParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource participantBindingSource;
        private RunningClubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
        private RunningClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox genderComboBox;
        private RunningClubDataSetTableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.ComboBox coachComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox noCoachCheckBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource coachBindingSource;
    }
}