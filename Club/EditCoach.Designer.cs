namespace Club
{
    partial class EditCoach
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
            System.Windows.Forms.Label clubLabel;
            System.Windows.Forms.Label specializationLabel;
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.coachTableAdapter = new Club.RunningClubDataSetTableAdapters.CoachTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noSpecializationCheckBox = new System.Windows.Forms.CheckBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Club.RunningClubDataSetTableAdapters.TableAdapterManager();
            this.clubComboBox = new System.Windows.Forms.ComboBox();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubTableAdapter = new Club.RunningClubDataSetTableAdapters.ClubTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            clubLabel = new System.Windows.Forms.Label();
            specializationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
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
            // clubLabel
            // 
            clubLabel.AutoSize = true;
            clubLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clubLabel.Location = new System.Drawing.Point(12, 67);
            clubLabel.Name = "clubLabel";
            clubLabel.Size = new System.Drawing.Size(47, 14);
            clubLabel.TabIndex = 5;
            clubLabel.Text = "Club:";
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specializationLabel.Location = new System.Drawing.Point(12, 93);
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new System.Drawing.Size(127, 14);
            specializationLabel.TabIndex = 7;
            specializationLabel.Text = "Specialization:";
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(156, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(162, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.Location = new System.Drawing.Point(156, 90);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(162, 20);
            this.specializationTextBox.TabIndex = 12;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(12, 147);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(199, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // noSpecializationCheckBox
            // 
            this.noSpecializationCheckBox.AutoSize = true;
            this.noSpecializationCheckBox.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSpecializationCheckBox.Location = new System.Drawing.Point(156, 116);
            this.noSpecializationCheckBox.Name = "noSpecializationCheckBox";
            this.noSpecializationCheckBox.Size = new System.Drawing.Size(139, 16);
            this.noSpecializationCheckBox.TabIndex = 16;
            this.noSpecializationCheckBox.Text = "No specialization";
            this.noSpecializationCheckBox.UseVisualStyleBackColor = true;
            this.noSpecializationCheckBox.CheckedChanged += new System.EventHandler(this.noSpecializationCheckBox_CheckedChanged);
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.runningClubDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.EventDistancesTableAdapter = null;
            this.tableAdapterManager.EventHeatsTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.HeatParticipantsTableAdapter = null;
            this.tableAdapterManager.HeatTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SponsorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Club.RunningClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clubComboBox
            // 
            this.clubComboBox.DataSource = this.clubBindingSource;
            this.clubComboBox.DisplayMember = "Name";
            this.clubComboBox.FormattingEnabled = true;
            this.clubComboBox.Location = new System.Drawing.Point(156, 63);
            this.clubComboBox.Name = "clubComboBox";
            this.clubComboBox.Size = new System.Drawing.Size(162, 21);
            this.clubComboBox.TabIndex = 17;
            this.clubComboBox.ValueMember = "Id";
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.runningClubDataSet;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // EditCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 209);
            this.Controls.Add(this.clubComboBox);
            this.Controls.Add(this.noSpecializationCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(clubLabel);
            this.Controls.Add(specializationLabel);
            this.Name = "EditCoach";
            this.Text = "EditCoach";
            this.Load += new System.EventHandler(this.EditCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private RunningClubDataSetTableAdapters.CoachTableAdapter coachTableAdapter;
        private RunningClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox noSpecializationCheckBox;
        private System.Windows.Forms.ComboBox clubComboBox;
        private RunningClubDataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private System.Windows.Forms.BindingSource clubBindingSource;
    }
}