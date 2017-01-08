namespace Club
{
    partial class FillResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.eventName = new System.Windows.Forms.Label();
            this.heatId = new System.Windows.Forms.Label();
            this.participantId = new System.Windows.Forms.Label();
            this.heatTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatTableAdapter();
            this.eventTableAdapter1 = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.participantName = new System.Windows.Forms.Label();
            this.participantTableAdapter1 = new Club.RunningClubDataSetTableAdapters.ParticipantTableAdapter();
            this.heatParticipantTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter();
            this.runningClubDataSet1 = new Club.RunningClubDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participant";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(19, 121);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(122, 121);
            this.maskedTextBox2.Mask = "00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seconds";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(225, 121);
            this.maskedTextBox3.Mask = "00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBox3.TabIndex = 8;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(19, 163);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 19;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(153, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(78, 8);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(35, 13);
            this.eventName.TabIndex = 21;
            this.eventName.Text = "label7";
            // 
            // heatId
            // 
            this.heatId.AutoSize = true;
            this.heatId.Location = new System.Drawing.Point(78, 36);
            this.heatId.Name = "heatId";
            this.heatId.Size = new System.Drawing.Size(35, 13);
            this.heatId.TabIndex = 22;
            this.heatId.Text = "label8";
            // 
            // participantId
            // 
            this.participantId.AutoSize = true;
            this.participantId.Location = new System.Drawing.Point(78, 65);
            this.participantId.Name = "participantId";
            this.participantId.Size = new System.Drawing.Size(35, 13);
            this.participantId.TabIndex = 23;
            this.participantId.Text = "label9";
            // 
            // heatTableAdapter1
            // 
            this.heatTableAdapter1.ClearBeforeFill = true;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // participantName
            // 
            this.participantName.AutoSize = true;
            this.participantName.Location = new System.Drawing.Point(120, 65);
            this.participantName.Name = "participantName";
            this.participantName.Size = new System.Drawing.Size(35, 13);
            this.participantName.TabIndex = 24;
            this.participantName.Text = "label7";
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // heatParticipantTableAdapter1
            // 
            this.heatParticipantTableAdapter1.ClearBeforeFill = true;
            // 
            // runningClubDataSet1
            // 
            this.runningClubDataSet1.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FillResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.participantName);
            this.Controls.Add(this.participantId);
            this.Controls.Add(this.heatId);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FillResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillResult";
            this.Load += new System.EventHandler(this.FillResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label heatId;
        private System.Windows.Forms.Label participantId;
        private RunningClubDataSetTableAdapters.HeatTableAdapter heatTableAdapter1;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
        private System.Windows.Forms.Label participantName;
        private RunningClubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter1;
        private RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter heatParticipantTableAdapter1;
        private RunningClubDataSet runningClubDataSet1;
    }
}