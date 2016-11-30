namespace Club
{
    partial class EditClub
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
            System.Windows.Forms.Label foundationDateLabel;
            System.Windows.Forms.Label cityLabel;
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubTableAdapter = new Club.RunningClubDataSetTableAdapters.ClubTableAdapter();
            this.tableAdapterManager = new Club.RunningClubDataSetTableAdapters.TableAdapterManager();
            this.foundationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            foundationDateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = this.clubTableAdapter;
            this.tableAdapterManager.CoachTableAdapter = null;
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(31, 14);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(12, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 14);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // foundationDateLabel
            // 
            foundationDateLabel.AutoSize = true;
            foundationDateLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foundationDateLabel.Location = new System.Drawing.Point(12, 62);
            foundationDateLabel.Name = "foundationDateLabel";
            foundationDateLabel.Size = new System.Drawing.Size(131, 14);
            foundationDateLabel.TabIndex = 5;
            foundationDateLabel.Text = "Foundation Date:";
            // 
            // foundationDateDateTimePicker
            // 
            this.foundationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clubBindingSource, "FoundationDate", true));
            this.foundationDateDateTimePicker.Location = new System.Drawing.Point(156, 58);
            this.foundationDateDateTimePicker.Name = "foundationDateDateTimePicker";
            this.foundationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.foundationDateDateTimePicker.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(12, 87);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(47, 14);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(156, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(156, 84);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 11;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(12, 118);
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
            this.cancelButton.Location = new System.Drawing.Point(237, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 179);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(foundationDateLabel);
            this.Controls.Add(this.foundationDateDateTimePicker);
            this.Controls.Add(cityLabel);
            this.Name = "EditClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditClub";
            this.Load += new System.EventHandler(this.EditClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private RunningClubDataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private RunningClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker foundationDateDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}