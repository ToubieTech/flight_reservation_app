
namespace flight_reservation_app
{
    partial class add_customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.formPanel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainMenuBtn1 = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.cusPhone = new System.Windows.Forms.MaskedTextBox();
            this.cusPhoneLbl = new System.Windows.Forms.Label();
            this.cusLname = new System.Windows.Forms.TextBox();
            this.cusLnameLbl = new System.Windows.Forms.Label();
            this.cusFname = new System.Windows.Forms.TextBox();
            this.cusFnameLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftPanel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.logoPanel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.formPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.formPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.leftPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logoPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 681);
            this.panel1.TabIndex = 0;
            // 
            // formPanel1
            // 
            this.formPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.formPanel1.Controls.Add(this.panel4);
            this.formPanel1.Controls.Add(this.mainMenuBtn1);
            this.formPanel1.Controls.Add(this.addCustomerBtn);
            this.formPanel1.Controls.Add(this.cusPhone);
            this.formPanel1.Controls.Add(this.cusPhoneLbl);
            this.formPanel1.Controls.Add(this.cusLname);
            this.formPanel1.Controls.Add(this.cusLnameLbl);
            this.formPanel1.Controls.Add(this.cusFname);
            this.formPanel1.Controls.Add(this.cusFnameLbl);
            this.formPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel1.Location = new System.Drawing.Point(390, 182);
            this.formPanel1.Name = "formPanel1";
            this.formPanel1.Padding = new System.Windows.Forms.Padding(35);
            this.formPanel1.Size = new System.Drawing.Size(384, 499);
            this.formPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Location = new System.Drawing.Point(-390, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1164, 66);
            this.panel4.TabIndex = 0;
            // 
            // mainMenuBtn1
            // 
            this.mainMenuBtn1.BackColor = System.Drawing.Color.Azure;
            this.mainMenuBtn1.FlatAppearance.BorderSize = 0;
            this.mainMenuBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn1.ForeColor = System.Drawing.Color.DarkCyan;
            this.mainMenuBtn1.Location = new System.Drawing.Point(62, 373);
            this.mainMenuBtn1.Name = "mainMenuBtn1";
            this.mainMenuBtn1.Size = new System.Drawing.Size(264, 40);
            this.mainMenuBtn1.TabIndex = 7;
            this.mainMenuBtn1.Text = "BACK TO MAIN MENU";
            this.mainMenuBtn1.UseVisualStyleBackColor = false;
            this.mainMenuBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.Azure;
            this.addCustomerBtn.FlatAppearance.BorderSize = 0;
            this.addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.addCustomerBtn.Location = new System.Drawing.Point(129, 300);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(120, 40);
            this.addCustomerBtn.TabIndex = 6;
            this.addCustomerBtn.Text = "Submit";
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // cusPhone
            // 
            this.cusPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhone.Location = new System.Drawing.Point(35, 207);
            this.cusPhone.Mask = "(999) 000-0000";
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(314, 31);
            this.cusPhone.TabIndex = 5;
            this.cusPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cusPhoneLbl
            // 
            this.cusPhoneLbl.AutoSize = true;
            this.cusPhoneLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusPhoneLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneLbl.ForeColor = System.Drawing.Color.Azure;
            this.cusPhoneLbl.Location = new System.Drawing.Point(35, 167);
            this.cusPhoneLbl.Name = "cusPhoneLbl";
            this.cusPhoneLbl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cusPhoneLbl.Size = new System.Drawing.Size(204, 40);
            this.cusPhoneLbl.TabIndex = 4;
            this.cusPhoneLbl.Text = "Customer\'s Phone Number*";
            this.cusPhoneLbl.Click += new System.EventHandler(this.cusPhoneLbl_Click);
            // 
            // cusLname
            // 
            this.cusLname.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusLname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusLname.Location = new System.Drawing.Point(35, 136);
            this.cusLname.Name = "cusLname";
            this.cusLname.Size = new System.Drawing.Size(314, 31);
            this.cusLname.TabIndex = 3;
            this.cusLname.TextChanged += new System.EventHandler(this.cusLname_TextChanged);
            // 
            // cusLnameLbl
            // 
            this.cusLnameLbl.AutoSize = true;
            this.cusLnameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusLnameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusLnameLbl.ForeColor = System.Drawing.Color.Azure;
            this.cusLnameLbl.Location = new System.Drawing.Point(35, 96);
            this.cusLnameLbl.Name = "cusLnameLbl";
            this.cusLnameLbl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cusLnameLbl.Size = new System.Drawing.Size(173, 40);
            this.cusLnameLbl.TabIndex = 2;
            this.cusLnameLbl.Text = "Customer\'s Last Name*";
            this.cusLnameLbl.Click += new System.EventHandler(this.cusLnameLbl_Click);
            // 
            // cusFname
            // 
            this.cusFname.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusFname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusFname.Location = new System.Drawing.Point(35, 65);
            this.cusFname.Name = "cusFname";
            this.cusFname.Size = new System.Drawing.Size(314, 31);
            this.cusFname.TabIndex = 1;
            this.cusFname.TextChanged += new System.EventHandler(this.cusFname_TextChanged);
            // 
            // cusFnameLbl
            // 
            this.cusFnameLbl.AutoSize = true;
            this.cusFnameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusFnameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusFnameLbl.ForeColor = System.Drawing.Color.Azure;
            this.cusFnameLbl.Location = new System.Drawing.Point(35, 35);
            this.cusFnameLbl.Name = "cusFnameLbl";
            this.cusFnameLbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cusFnameLbl.Size = new System.Drawing.Size(175, 30);
            this.cusFnameLbl.TabIndex = 0;
            this.cusFnameLbl.Text = "Customer\'s First Name*";
            this.cusFnameLbl.Click += new System.EventHandler(this.cusFnameLbl_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(774, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 499);
            this.panel3.TabIndex = 3;
            // 
            // leftPanel1
            // 
            this.leftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel1.Location = new System.Drawing.Point(0, 182);
            this.leftPanel1.Name = "leftPanel1";
            this.leftPanel1.Size = new System.Drawing.Size(390, 499);
            this.leftPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.introLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 82);
            this.panel2.TabIndex = 1;
            // 
            // introLabel2
            // 
            this.introLabel2.AutoSize = true;
            this.introLabel2.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.introLabel2.Location = new System.Drawing.Point(393, 16);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(367, 45);
            this.introLabel2.TabIndex = 0;
            this.introLabel2.Text = "ADD CUSTOMER";
            // 
            // logoPanel2
            // 
            this.logoPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel2.BackgroundImage")));
            this.logoPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel2.Location = new System.Drawing.Point(0, 0);
            this.logoPanel2.Name = "logoPanel2";
            this.logoPanel2.Size = new System.Drawing.Size(1164, 100);
            this.logoPanel2.TabIndex = 0;
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.panel1);
            this.Name = "add_customer";
            this.Text = "Travella | Customer";
            this.Load += new System.EventHandler(this.add_customer_Load);
            this.panel1.ResumeLayout(false);
            this.formPanel1.ResumeLayout(false);
            this.formPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logoPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel leftPanel1;
        private System.Windows.Forms.Panel formPanel1;
        private System.Windows.Forms.TextBox cusFname;
        private System.Windows.Forms.Label cusFnameLbl;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.MaskedTextBox cusPhone;
        private System.Windows.Forms.Label cusPhoneLbl;
        private System.Windows.Forms.TextBox cusLname;
        private System.Windows.Forms.Label cusLnameLbl;
        private System.Windows.Forms.Button mainMenuBtn1;
        private System.Windows.Forms.Panel panel4;
    }
}