namespace Club
{
    partial class TrainingPlan
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.participantTableAdapter1 = new Club.RunningClubDataSetTableAdapters.ParticipantTableAdapter();
            this.runningClubDataSet1 = new Club.RunningClubDataSet();
            this.coachTableAdapter1 = new Club.RunningClubDataSetTableAdapters.CoachTableAdapter();
            this.heatTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatTableAdapter();
            this.eventTableAdapter1 = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your \r\nParticipant ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(17, 79);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(153, 62);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // runningClubDataSet1
            // 
            this.runningClubDataSet1.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachTableAdapter1
            // 
            this.coachTableAdapter1.ClearBeforeFill = true;
            // 
            // heatTableAdapter1
            // 
            this.heatTableAdapter1.ClearBeforeFill = true;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // TrainingPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TrainingPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingPlan";
            this.Load += new System.EventHandler(this.TrainingPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button confirmButton;
        private RunningClubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter1;
        private RunningClubDataSet runningClubDataSet1;
        private RunningClubDataSetTableAdapters.CoachTableAdapter coachTableAdapter1;
        private RunningClubDataSetTableAdapters.HeatTableAdapter heatTableAdapter1;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
    }
}