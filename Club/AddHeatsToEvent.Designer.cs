namespace Club
{
    partial class AddHeatsToEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.numberOfHeats = new System.Windows.Forms.MaskedTextBox();
            this.eventTableAdapter1 = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.distanceTableAdapter1 = new Club.RunningClubDataSetTableAdapters.DistanceTableAdapter();
            this.distanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.heatTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of heats\r\n for specific distance:";
            // 
            // eventComboBox
            // 
            this.eventComboBox.DataSource = this.eventBindingSource;
            this.eventComboBox.DisplayMember = "Name";
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(124, 10);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(252, 21);
            this.eventComboBox.TabIndex = 3;
            this.eventComboBox.ValueMember = "Id";
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
            // numberOfHeats
            // 
            this.numberOfHeats.Location = new System.Drawing.Point(239, 48);
            this.numberOfHeats.Mask = "00";
            this.numberOfHeats.Name = "numberOfHeats";
            this.numberOfHeats.Size = new System.Drawing.Size(137, 20);
            this.numberOfHeats.TabIndex = 5;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // distanceTableAdapter1
            // 
            this.distanceTableAdapter1.ClearBeforeFill = true;
            // 
            // distanceBindingSource
            // 
            this.distanceBindingSource.DataMember = "Distance";
            this.distanceBindingSource.DataSource = this.runningClubDataSet;
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.DataSource = this.distanceBindingSource;
            this.distanceComboBox.DisplayMember = "Length";
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(68, 48);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(52, 21);
            this.distanceComboBox.TabIndex = 4;
            this.distanceComboBox.ValueMember = "Length";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 50);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add and continue";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(256, 74);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // heatTableAdapter1
            // 
            this.heatTableAdapter1.ClearBeforeFill = true;
            // 
            // AddHeatsToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 133);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberOfHeats);
            this.Controls.Add(this.distanceComboBox);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHeatsToEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHeatsToEvent";
            this.Load += new System.EventHandler(this.AddHeatsToEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.MaskedTextBox numberOfHeats;
        private RunningClubDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private RunningClubDataSet runningClubDataSet;
        private System.Windows.Forms.BindingSource distanceBindingSource;
        private RunningClubDataSetTableAdapters.DistanceTableAdapter distanceTableAdapter1;
        private System.Windows.Forms.ComboBox distanceComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private RunningClubDataSetTableAdapters.HeatTableAdapter heatTableAdapter1;
    }
}