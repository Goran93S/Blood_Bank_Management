namespace BloodBankManagement
{
    partial class Form1
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
            this.dataGridViewDonors = new System.Windows.Forms.DataGridView();
            this.donorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodBankDataSet = new BloodBankManagement.BloodBankDataSet();
            this.donorTableAdapter = new BloodBankManagement.BloodBankDataSetTableAdapters.DonorTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByBloodGroupAndRHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendInviteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllDonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDonors
            // 
            this.dataGridViewDonors.AllowDrop = true;
            this.dataGridViewDonors.AllowUserToOrderColumns = true;
            this.dataGridViewDonors.AutoGenerateColumns = false;
            this.dataGridViewDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.rHDataGridViewTextBoxColumn,
            this.mailAdressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridViewDonors.DataSource = this.donorBindingSource;
            this.dataGridViewDonors.Location = new System.Drawing.Point(1, 27);
            this.dataGridViewDonors.Name = "dataGridViewDonors";
            this.dataGridViewDonors.Size = new System.Drawing.Size(674, 444);
            this.dataGridViewDonors.TabIndex = 0;
            this.dataGridViewDonors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonors_CellContentClick);
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            this.donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.HeaderText = "DonorId";
            this.donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            this.donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorIdDataGridViewTextBoxColumn.Width = 55;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 75;
            // 
            // rHDataGridViewTextBoxColumn
            // 
            this.rHDataGridViewTextBoxColumn.DataPropertyName = "RH";
            this.rHDataGridViewTextBoxColumn.HeaderText = "RH";
            this.rHDataGridViewTextBoxColumn.Name = "rHDataGridViewTextBoxColumn";
            this.rHDataGridViewTextBoxColumn.Width = 45;
            // 
            // mailAdressDataGridViewTextBoxColumn
            // 
            this.mailAdressDataGridViewTextBoxColumn.DataPropertyName = "MailAdress";
            this.mailAdressDataGridViewTextBoxColumn.HeaderText = "MailAdress";
            this.mailAdressDataGridViewTextBoxColumn.Name = "mailAdressDataGridViewTextBoxColumn";
            this.mailAdressDataGridViewTextBoxColumn.Width = 160;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 145;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "Donor";
            this.donorBindingSource.DataSource = this.bloodBankDataSet;
            // 
            // bloodBankDataSet
            // 
            this.bloodBankDataSet.DataSetName = "BloodBankDataSet";
            this.bloodBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonorToolStripMenuItem,
            this.updateDonorToolStripMenuItem,
            this.deleteDonorToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.sendInviteToolStripMenuItem,
            this.listAllDonorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDonorToolStripMenuItem
            // 
            this.addDonorToolStripMenuItem.Name = "addDonorToolStripMenuItem";
            this.addDonorToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.addDonorToolStripMenuItem.Text = "Add Donor";
            this.addDonorToolStripMenuItem.Click += new System.EventHandler(this.addDonorToolStripMenuItem_Click);
            // 
            // updateDonorToolStripMenuItem
            // 
            this.updateDonorToolStripMenuItem.Name = "updateDonorToolStripMenuItem";
            this.updateDonorToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.updateDonorToolStripMenuItem.Text = "Update Donor";
            this.updateDonorToolStripMenuItem.Click += new System.EventHandler(this.updateDonorToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.deleteDonorToolStripMenuItem.Text = "Delete Donor";
            this.deleteDonorToolStripMenuItem.Click += new System.EventHandler(this.deleteDonorToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByNameToolStripMenuItem,
            this.searchByBloodGroupAndRHToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchByNameToolStripMenuItem
            // 
            this.searchByNameToolStripMenuItem.Name = "searchByNameToolStripMenuItem";
            this.searchByNameToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.searchByNameToolStripMenuItem.Text = "Search by Name";
            this.searchByNameToolStripMenuItem.Click += new System.EventHandler(this.searchByNameToolStripMenuItem_Click);
            // 
            // searchByBloodGroupAndRHToolStripMenuItem
            // 
            this.searchByBloodGroupAndRHToolStripMenuItem.Name = "searchByBloodGroupAndRHToolStripMenuItem";
            this.searchByBloodGroupAndRHToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.searchByBloodGroupAndRHToolStripMenuItem.Text = "Search by Blood Group and RH";
            this.searchByBloodGroupAndRHToolStripMenuItem.Click += new System.EventHandler(this.searchByBloodGroupAndRHToolStripMenuItem_Click);
            // 
            // sendInviteToolStripMenuItem
            // 
            this.sendInviteToolStripMenuItem.Name = "sendInviteToolStripMenuItem";
            this.sendInviteToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.sendInviteToolStripMenuItem.Text = "Send Invite";
            this.sendInviteToolStripMenuItem.Click += new System.EventHandler(this.sendInviteToolStripMenuItem_Click);
            // 
            // listAllDonorsToolStripMenuItem
            // 
            this.listAllDonorsToolStripMenuItem.Name = "listAllDonorsToolStripMenuItem";
            this.listAllDonorsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listAllDonorsToolStripMenuItem.Text = "List All Donors";
            this.listAllDonorsToolStripMenuItem.Click += new System.EventHandler(this.listAllDonorsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.dataGridViewDonors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Blood Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BloodBankDataSet bloodBankDataSet;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private BloodBankDataSetTableAdapters.DonorTableAdapter donorTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByBloodGroupAndRHToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewDonors;
        private System.Windows.Forms.ToolStripMenuItem updateDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendInviteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem listAllDonorsToolStripMenuItem;
    }
}

