
namespace flight_reservation_app
{
    partial class view_bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_bookings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPanel5 = new System.Windows.Forms.Panel();
            this.introPanel9 = new System.Windows.Forms.Panel();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mainMenuBtn11 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.introPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.mainMenuBtn11);
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Controls.Add(this.introPanel9);
            this.panel1.Controls.Add(this.logoPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 681);
            this.panel1.TabIndex = 0;
            // 
            // logoPanel5
            // 
            this.logoPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel5.BackgroundImage")));
            this.logoPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel5.Location = new System.Drawing.Point(0, 0);
            this.logoPanel5.Name = "logoPanel5";
            this.logoPanel5.Size = new System.Drawing.Size(1164, 100);
            this.logoPanel5.TabIndex = 0;
            this.logoPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPanel5_Paint);
            // 
            // introPanel9
            // 
            this.introPanel9.Controls.Add(this.introLabel2);
            this.introPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.introPanel9.Location = new System.Drawing.Point(0, 100);
            this.introPanel9.Name = "introPanel9";
            this.introPanel9.Size = new System.Drawing.Size(1164, 100);
            this.introPanel9.TabIndex = 1;
            // 
            // introLabel2
            // 
            this.introLabel2.AutoSize = true;
            this.introLabel2.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.introLabel2.Location = new System.Drawing.Point(375, 29);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(374, 45);
            this.introLabel2.TabIndex = 4;
            this.introLabel2.Text = "VIEW BOOKINGS";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(154, 242);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(867, 264);
            this.dataGridView4.TabIndex = 5;
            // 
            // mainMenuBtn11
            // 
            this.mainMenuBtn11.BackColor = System.Drawing.Color.DarkCyan;
            this.mainMenuBtn11.FlatAppearance.BorderSize = 0;
            this.mainMenuBtn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn11.ForeColor = System.Drawing.Color.Azure;
            this.mainMenuBtn11.Location = new System.Drawing.Point(460, 555);
            this.mainMenuBtn11.Name = "mainMenuBtn11";
            this.mainMenuBtn11.Size = new System.Drawing.Size(264, 40);
            this.mainMenuBtn11.TabIndex = 10;
            this.mainMenuBtn11.Text = "BACK TO MAIN MENU";
            this.mainMenuBtn11.UseVisualStyleBackColor = false;
            this.mainMenuBtn11.Click += new System.EventHandler(this.mainMenuBtn11_Click);
            // 
            // view_bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.panel1);
            this.Name = "view_bookings";
            this.Text = "Travella | Bookings";
            this.Load += new System.EventHandler(this.view_bookings_Load);
            this.panel1.ResumeLayout(false);
            this.introPanel9.ResumeLayout(false);
            this.introPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logoPanel5;
        private System.Windows.Forms.Panel introPanel9;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button mainMenuBtn11;
    }
}