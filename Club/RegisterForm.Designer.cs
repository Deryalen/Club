namespace Club
{
    partial class RegisterForm
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
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.eventTableAdapter = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.distanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distanceTableAdapter = new Club.RunningClubDataSetTableAdapters.DistanceTableAdapter();
            this.heatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heatTableAdapter = new Club.RunningClubDataSetTableAdapters.HeatTableAdapter();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantTableAdapter = new Club.RunningClubDataSetTableAdapters.ParticipantTableAdapter();
            this.heatParticipantTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.heatComboBox = new System.Windows.Forms.ComboBox();
            this.participantComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.runningClubDataSet;
            // 
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // distanceBindingSource
            // 
            this.distanceBindingSource.DataMember = "Distance";
            this.distanceBindingSource.DataSource = this.runningClubDataSet;
            // 
            // distanceTableAdapter
            // 
            this.distanceTableAdapter.ClearBeforeFill = true;
            // 
            // heatBindingSource
            // 
            this.heatBindingSource.DataMember = "Heat";
            this.heatBindingSource.DataSource = this.runningClubDataSet;
            // 
            // heatTableAdapter
            // 
            this.heatTableAdapter.ClearBeforeFill = true;
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "Participant";
            this.participantBindingSource.DataSource = this.runningClubDataSet;
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // heatParticipantTableAdapter1
            // 
            this.heatParticipantTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participant:";
            // 
            // eventComboBox
            // 
            this.eventComboBox.DataSource = this.eventBindingSource;
            this.eventComboBox.DisplayMember = "Name";
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(116, 10);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(237, 21);
            this.eventComboBox.TabIndex = 3;
            this.eventComboBox.ValueMember = "Id";
            this.eventComboBox.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // heatComboBox
            // 
            this.heatComboBox.DataSource = this.heatBindingSource;
            this.heatComboBox.DisplayMember = "Id";
            this.heatComboBox.FormattingEnabled = true;
            this.heatComboBox.Location = new System.Drawing.Point(116, 40);
            this.heatComboBox.Name = "heatComboBox";
            this.heatComboBox.Size = new System.Drawing.Size(237, 21);
            this.heatComboBox.TabIndex = 4;
            this.heatComboBox.ValueMember = "Id";
            // 
            // participantComboBox
            // 
            this.participantComboBox.DataSource = this.participantBindingSource;
            this.participantComboBox.DisplayMember = "Name";
            this.participantComboBox.FormattingEnabled = true;
            this.participantComboBox.Location = new System.Drawing.Point(116, 70);
            this.participantComboBox.Name = "participantComboBox";
            this.participantComboBox.Size = new System.Drawing.Size(237, 21);
            this.participantComboBox.TabIndex = 5;
            this.participantComboBox.ValueMember = "Id";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(12, 135);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(234, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 197);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.participantComboBox);
            this.Controls.Add(this.heatComboBox);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource distanceBindingSource;
        private RunningClubDataSetTableAdapters.DistanceTableAdapter distanceTableAdapter;
        private System.Windows.Forms.BindingSource heatBindingSource;
        private RunningClubDataSetTableAdapters.HeatTableAdapter heatTableAdapter;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private RunningClubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
        private RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter heatParticipantTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.ComboBox heatComboBox;
        private System.Windows.Forms.ComboBox participantComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}