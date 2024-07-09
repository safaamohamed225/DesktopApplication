namespace Clinic_Management_System_Desktop_application
{
    partial class Medicien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameValid = new System.Windows.Forms.Label();
            this.TypeValid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.btnCnacle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgPrescriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrescriptionNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.NameValid);
            this.panel1.Controls.Add(this.TypeValid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.btnCnacle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 487);
            this.panel1.TabIndex = 14;
            // 
            // NameValid
            // 
            this.NameValid.AutoSize = true;
            this.NameValid.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameValid.ForeColor = System.Drawing.Color.Red;
            this.NameValid.Location = new System.Drawing.Point(38, 72);
            this.NameValid.Name = "NameValid";
            this.NameValid.Size = new System.Drawing.Size(121, 15);
            this.NameValid.TabIndex = 13;
            this.NameValid.Text = "Enter Medicien Name";
            // 
            // TypeValid
            // 
            this.TypeValid.AutoSize = true;
            this.TypeValid.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeValid.ForeColor = System.Drawing.Color.Red;
            this.TypeValid.Location = new System.Drawing.Point(38, 130);
            this.TypeValid.Name = "TypeValid";
            this.TypeValid.Size = new System.Drawing.Size(119, 15);
            this.TypeValid.TabIndex = 12;
            this.TypeValid.Text = "Select Medicien Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(32, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Logout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logout.Location = new System.Drawing.Point(85, 435);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(64, 21);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "syrup",
            "Tablet",
            "Ointment"});
            this.txtType.Location = new System.Drawing.Point(8, 106);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(189, 21);
            this.txtType.TabIndex = 9;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            // 
            // btnCnacle
            // 
            this.btnCnacle.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCnacle.Location = new System.Drawing.Point(7, 354);
            this.btnCnacle.Name = "btnCnacle";
            this.btnCnacle.Size = new System.Drawing.Size(181, 36);
            this.btnCnacle.TabIndex = 2;
            this.btnCnacle.Text = "Cancle";
            this.btnCnacle.UseVisualStyleBackColor = true;
            this.btnCnacle.Click += new System.EventHandler(this.btnCnacle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 169);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(189, 82);
            this.txtNote.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(7, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(713, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(824, 29);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(134, 35);
            this.searchTextBox.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPrescriptionId,
            this.dgPrescriptionName,
            this.dgPrescriptionType,
            this.dgPrescriptionNotes});
            this.dataGridView.Location = new System.Drawing.Point(206, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(752, 394);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // dgPrescriptionId
            // 
            this.dgPrescriptionId.DataPropertyName = "PrescriptionId";
            this.dgPrescriptionId.HeaderText = "PrescriptionID";
            this.dgPrescriptionId.Name = "dgPrescriptionId";
            this.dgPrescriptionId.ReadOnly = true;
            this.dgPrescriptionId.Visible = false;
            // 
            // dgPrescriptionName
            // 
            this.dgPrescriptionName.DataPropertyName = "PrescriptionName";
            this.dgPrescriptionName.HeaderText = "Prescription Name";
            this.dgPrescriptionName.Name = "dgPrescriptionName";
            this.dgPrescriptionName.ReadOnly = true;
            // 
            // dgPrescriptionType
            // 
            this.dgPrescriptionType.DataPropertyName = "PrescriptionType";
            this.dgPrescriptionType.HeaderText = "Prescription Type";
            this.dgPrescriptionType.Name = "dgPrescriptionType";
            this.dgPrescriptionType.ReadOnly = true;
            // 
            // dgPrescriptionNotes
            // 
            this.dgPrescriptionNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPrescriptionNotes.DataPropertyName = "PrescriptionNotes";
            this.dgPrescriptionNotes.HeaderText = "Prescription Notes";
            this.dgPrescriptionNotes.Name = "dgPrescriptionNotes";
            this.dgPrescriptionNotes.ReadOnly = true;
            // 
            // Medicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "Medicien";
            this.Text = "Medicien";
            this.Load += new System.EventHandler(this.Medicien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Button btnCnacle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrescriptionNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label NameValid;
        private System.Windows.Forms.Label TypeValid;
    }
}