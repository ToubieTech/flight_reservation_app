
namespace flight_reservation_app
{
    partial class view_customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_customers));
            this.mainPanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenuBtn2 = new System.Windows.Forms.Button();
            this.mainPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel2
            // 
            this.mainPanel2.BackColor = System.Drawing.Color.Azure;
            this.mainPanel2.Controls.Add(this.mainMenuBtn2);
            this.mainPanel2.Controls.Add(this.dataGridView1);
            this.mainPanel2.Controls.Add(this.panel2);
            this.mainPanel2.Controls.Add(this.panel1);
            this.mainPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel2.Location = new System.Drawing.Point(0, 0);
            this.mainPanel2.Name = "mainPanel2";
            this.mainPanel2.Size = new System.Drawing.Size(1164, 681);
            this.mainPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 100);
            this.panel1.TabIndex = 0;
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
            this.introLabel2.Location = new System.Drawing.Point(409, 19);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(411, 45);
            this.introLabel2.TabIndex = 2;
            this.introLabel2.Text = "VIEW CUSTOMERS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 264);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mainMenuBtn2
            // 
            this.mainMenuBtn2.BackColor = System.Drawing.Color.DarkCyan;
            this.mainMenuBtn2.FlatAppearance.BorderSize = 0;
            this.mainMenuBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn2.ForeColor = System.Drawing.Color.Azure;
            this.mainMenuBtn2.Location = new System.Drawing.Point(417, 531);
            this.mainMenuBtn2.Name = "mainMenuBtn2";
            this.mainMenuBtn2.Size = new System.Drawing.Size(264, 40);
            this.mainMenuBtn2.TabIndex = 8;
            this.mainMenuBtn2.Text = "BACK TO MAIN MENU";
            this.mainMenuBtn2.UseVisualStyleBackColor = false;
            this.mainMenuBtn2.Click += new System.EventHandler(this.mainMenuBtn2_Click);
            // 
            // view_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.mainPanel2);
            this.Name = "view_customers";
            this.Text = "View Customers";
            this.Load += new System.EventHandler(this.view_customers_Load);
            this.mainPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mainMenuBtn2;
    }
}