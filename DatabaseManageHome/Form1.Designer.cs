namespace DataBaseManageHome
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonListBuilding = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonListOwner = new Button();
            buttonSearchTenant = new Button();
            linkContact = new LinkLabel();
            linkAboutUs = new LinkLabel();
            buttonAdd = new Button();
            buttonListTenant = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonListBuilding
            // 
            buttonListBuilding.Location = new Point(40, 130);
            buttonListBuilding.Name = "buttonListBuilding";
            buttonListBuilding.Size = new Size(184, 29);
            buttonListBuilding.TabIndex = 0;
            buttonListBuilding.Text = "Load List of Buildings";
            buttonListBuilding.UseVisualStyleBackColor = true;
            buttonListBuilding.Click += buttonListBuilding_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(419, 203);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 36);
            label1.Name = "label1";
            label1.Size = new Size(551, 43);
            label1.TabIndex = 2;
            label1.Text = "Management System Building";
            // 
            // buttonListOwner
            // 
            buttonListOwner.Location = new Point(249, 130);
            buttonListOwner.Name = "buttonListOwner";
            buttonListOwner.Size = new Size(184, 29);
            buttonListOwner.TabIndex = 3;
            buttonListOwner.Text = "Load List of Owner";
            buttonListOwner.UseVisualStyleBackColor = true;
            // 
            // buttonSearchTenant
            // 
            buttonSearchTenant.Location = new Point(622, 213);
            buttonSearchTenant.Name = "buttonSearchTenant";
            buttonSearchTenant.Size = new Size(135, 29);
            buttonSearchTenant.TabIndex = 4;
            buttonSearchTenant.Text = "Search";
            buttonSearchTenant.UseVisualStyleBackColor = true;
            // 
            // linkContact
            // 
            linkContact.AutoSize = true;
            linkContact.LinkColor = Color.Black;
            linkContact.Location = new Point(222, 469);
            linkContact.Name = "linkContact";
            linkContact.Size = new Size(60, 20);
            linkContact.TabIndex = 5;
            linkContact.TabStop = true;
            linkContact.Text = "Contact";
            // 
            // linkAboutUs
            // 
            linkAboutUs.AutoSize = true;
            linkAboutUs.LinkColor = Color.Black;
            linkAboutUs.Location = new Point(515, 469);
            linkAboutUs.Name = "linkAboutUs";
            linkAboutUs.Size = new Size(68, 20);
            linkAboutUs.TabIndex = 6;
            linkAboutUs.TabStop = true;
            linkAboutUs.Text = "About us";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(622, 276);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 29);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonListTenant
            // 
            buttonListTenant.Location = new Point(458, 130);
            buttonListTenant.Name = "buttonListTenant";
            buttonListTenant.Size = new Size(184, 29);
            buttonListTenant.TabIndex = 8;
            buttonListTenant.Text = "Load List of Tenant";
            buttonListTenant.UseVisualStyleBackColor = true;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(buttonListTenant);
            Controls.Add(buttonAdd);
            Controls.Add(linkAboutUs);
            Controls.Add(linkContact);
            Controls.Add(buttonSearchTenant);
            Controls.Add(buttonListOwner);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonListBuilding);
            Name = "homeForm";
            Text = "Management System Building";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonListBuilding;
        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonListOwner;
        private Button buttonSearchTenant;
        private LinkLabel linkContact;
        private LinkLabel linkAboutUs;
        private Button buttonAdd;
        private Button buttonListTenant;
    }
}
