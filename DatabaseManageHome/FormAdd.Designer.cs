namespace DataBaseManageHome
{
    partial class FormAdd
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
            label1 = new Label();
            buttonAddNewOwner = new Button();
            buttonAddNewBuilding = new Button();
            buttonAddNewTenant = new Button();
            linkContact = new LinkLabel();
            linkAboutUs = new LinkLabel();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 39);
            label1.Name = "label1";
            label1.Size = new Size(551, 43);
            label1.TabIndex = 3;
            label1.Text = "Management System Building";
            // 
            // buttonAddNewOwner
            // 
            buttonAddNewOwner.Location = new Point(539, 116);
            buttonAddNewOwner.Name = "buttonAddNewOwner";
            buttonAddNewOwner.Size = new Size(207, 29);
            buttonAddNewOwner.TabIndex = 6;
            buttonAddNewOwner.Text = "Add New Owner of Building";
            buttonAddNewOwner.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewBuilding
            // 
            buttonAddNewBuilding.Location = new Point(26, 116);
            buttonAddNewBuilding.Name = "buttonAddNewBuilding";
            buttonAddNewBuilding.Size = new Size(207, 29);
            buttonAddNewBuilding.TabIndex = 7;
            buttonAddNewBuilding.Text = "Add New Building in System";
            buttonAddNewBuilding.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewTenant
            // 
            buttonAddNewTenant.Location = new Point(282, 116);
            buttonAddNewTenant.Name = "buttonAddNewTenant";
            buttonAddNewTenant.Size = new Size(207, 29);
            buttonAddNewTenant.TabIndex = 8;
            buttonAddNewTenant.Text = "Add New Tenant in System";
            buttonAddNewTenant.UseVisualStyleBackColor = true;
            // 
            // linkContact
            // 
            linkContact.AutoSize = true;
            linkContact.LinkColor = Color.Black;
            linkContact.Location = new Point(196, 402);
            linkContact.Name = "linkContact";
            linkContact.Size = new Size(60, 20);
            linkContact.TabIndex = 9;
            linkContact.TabStop = true;
            linkContact.Text = "Contact";
            // 
            // linkAboutUs
            // 
            linkAboutUs.AutoSize = true;
            linkAboutUs.LinkColor = Color.Black;
            linkAboutUs.Location = new Point(498, 402);
            linkAboutUs.Name = "linkAboutUs";
            linkAboutUs.Size = new Size(68, 20);
            linkAboutUs.TabIndex = 10;
            linkAboutUs.TabStop = true;
            linkAboutUs.Text = "About us";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Location = new Point(84, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 205);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(linkAboutUs);
            Controls.Add(linkContact);
            Controls.Add(buttonAddNewTenant);
            Controls.Add(buttonAddNewBuilding);
            Controls.Add(buttonAddNewOwner);
            Controls.Add(label1);
            Name = "FormAdd";
            Text = "FormAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddNewOwner;
        private Button buttonAddNewBuilding;
        private Button buttonAddNewTenant;
        private LinkLabel linkContact;
        private LinkLabel linkAboutUs;
        private GroupBox groupBox1;
    }
}