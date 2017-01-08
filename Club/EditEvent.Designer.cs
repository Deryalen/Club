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
            this.runningClubDataSet = new Club.RunningClubDataSet();
            this.eventTableAdapter = new Club.RunningClubDataSetTableAdapters.EventTableAdapter();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.heatParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Club.RunningClubDataSetTableAdapters.TableAdapterManager();
            this.heatTableAdapter1 = new Club.RunningClubDataSetTableAdapters.HeatTableAdapter();
            this.heatParticipantTableAdapter = new Club.RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter1 = new Club.RunningClubDataSetTableAdapters.DataTable2TableAdapter();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // runningClubDataSet
            // 
            this.runningClubDataSet.DataSetName = "RunningClubDataSet";
            this.runningClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(134, 58);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(294, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.runningClubDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(134, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(294, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(294, 20);
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
            this.levelComboBox.Location = new System.Drawing.Point(134, 84);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(294, 21);
            this.levelComboBox.TabIndex = 15;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Кубок",
            "Чемпионат",
            "Пробег"});
            this.typeComboBox.Location = new System.Drawing.Point(134, 110);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(294, 21);
            this.typeComboBox.TabIndex = 16;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(15, 137);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(119, 50);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(309, 137);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 50);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // heatParticipantsBindingSource
            // 
            this.heatParticipantsBindingSource.DataMember = "HeatParticipants";
            this.heatParticipantsBindingSource.DataSource = this.runningClubDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClubTableAdapter = null;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DistanceTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.HeatParticipantsTableAdapter = null;
            this.tableAdapterManager.HeatTableAdapter = null;
            this.tableAdapterManager.ParticipantTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Club.RunningClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // heatTableAdapter1
            // 
            this.heatTableAdapter1.ClearBeforeFill = true;
            // 
            // heatParticipantTableAdapter
            // 
            this.heatParticipantTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter1
            // 
            this.dataTable2TableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.runningClubDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatDataGridViewTextBoxColumn,
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(415, 226);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // heatDataGridViewTextBoxColumn
            // 
            this.heatDataGridViewTextBoxColumn.DataPropertyName = "Heat";
            this.heatDataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.heatDataGridViewTextBoxColumn.HeaderText = "Heat";
            this.heatDataGridViewTextBoxColumn.Name = "heatDataGridViewTextBoxColumn";
            this.heatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.FillWeight = 65.65144F;
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
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
            this.Name = "EditEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEvent";
            this.Load += new System.EventHandler(this.EditEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource sponsorBindingSource;
        private RunningClubDataSetTableAdapters.HeatTableAdapter heatTableAdapter1;
        private RunningClubDataSetTableAdapters.HeatParticipantsTableAdapter heatParticipantTableAdapter;
        private System.Windows.Forms.BindingSource heatParticipantsBindingSource;
        private RunningClubDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}