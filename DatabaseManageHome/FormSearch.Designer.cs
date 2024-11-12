namespace DataBaseManageHome
{
    partial class FormSearch
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
            buttonSearchOwner = new Button();
            buttonSearchTenant = new Button();
            linkContact = new LinkLabel();
            linkAboutUs = new LinkLabel();
            groupBox1 = new GroupBox();
            textBoxName = new TextBox();
            textBoxVorname = new TextBox();
            buttonFind = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 31);
            label1.Name = "label1";
            label1.Size = new Size(551, 43);
            label1.TabIndex = 3;
            label1.Text = "Management System Building";
            // 
            // buttonSearchOwner
            // 
            buttonSearchOwner.Location = new Point(135, 123);
            buttonSearchOwner.Name = "buttonSearchOwner";
            buttonSearchOwner.Size = new Size(207, 29);
            buttonSearchOwner.TabIndex = 5;
            buttonSearchOwner.Text = "Search Owner of Building";
            buttonSearchOwner.UseVisualStyleBackColor = true;
            // 
            // buttonSearchTenant
            // 
            buttonSearchTenant.Location = new Point(482, 123);
            buttonSearchTenant.Name = "buttonSearchTenant";
            buttonSearchTenant.Size = new Size(135, 29);
            buttonSearchTenant.TabIndex = 6;
            buttonSearchTenant.Text = "Search Tenant";
            buttonSearchTenant.UseVisualStyleBackColor = true;
            // 
            // linkContact
            // 
            linkContact.AutoSize = true;
            linkContact.LinkColor = Color.Black;
            linkContact.Location = new Point(214, 394);
            linkContact.Name = "linkContact";
            linkContact.Size = new Size(60, 20);
            linkContact.TabIndex = 7;
            linkContact.TabStop = true;
            linkContact.Text = "Contact";
            // 
            // linkAboutUs
            // 
            linkAboutUs.AutoSize = true;
            linkAboutUs.LinkColor = Color.Black;
            linkAboutUs.Location = new Point(482, 394);
            linkAboutUs.Name = "linkAboutUs";
            linkAboutUs.Size = new Size(68, 20);
            linkAboutUs.TabIndex = 8;
            linkAboutUs.TabStop = true;
            linkAboutUs.Text = "About us";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonFind);
            groupBox1.Controls.Add(textBoxVorname);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(135, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 205);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(199, 26);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(216, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxVorname
            // 
            textBoxVorname.Location = new Point(199, 86);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(216, 27);
            textBoxVorname.TabIndex = 1;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(248, 135);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(86, 35);
            buttonFind.TabIndex = 2;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 89);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "Vorname:";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(linkAboutUs);
            Controls.Add(linkContact);
            Controls.Add(buttonSearchTenant);
            Controls.Add(buttonSearchOwner);
            Controls.Add(label1);
            Name = "FormSearch";
            Text = "FormSearch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSearchOwner;
        private Button buttonSearchTenant;
        private LinkLabel linkContact;
        private LinkLabel linkAboutUs;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button buttonFind;
        private TextBox textBoxVorname;
        private TextBox textBoxName;
    }
}