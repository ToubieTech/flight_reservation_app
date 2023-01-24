
namespace flight_reservation_app
{
    partial class view_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_flight));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.introLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewFlight = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mainMenuBtn8 = new System.Windows.Forms.Button();
            this.viewFlightBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1164, 62);
            this.panel2.TabIndex = 1;
            // 
            // introLabel2
            // 
            this.introLabel2.AutoSize = true;
            this.introLabel2.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.introLabel2.Location = new System.Drawing.Point(291, 3);
            this.introLabel2.Name = "introLabel2";
            this.introLabel2.Size = new System.Drawing.Size(650, 45);
            this.introLabel2.TabIndex = 4;
            this.introLabel2.Text = "VIEW A PARTICULAR  FLIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(488, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Number*";
            // 
            // viewFlight
            // 
            this.viewFlight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFlight.Location = new System.Drawing.Point(329, 226);
            this.viewFlight.Name = "viewFlight";
            this.viewFlight.Size = new System.Drawing.Size(471, 34);
            this.viewFlight.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(132, 351);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(867, 307);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.Visible = false;
            // 
            // mainMenuBtn8
            // 
            this.mainMenuBtn8.BackColor = System.Drawing.Color.DarkCyan;
            this.mainMenuBtn8.FlatAppearance.BorderSize = 0;
            this.mainMenuBtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn8.ForeColor = System.Drawing.Color.Azure;
            this.mainMenuBtn8.Location = new System.Drawing.Point(593, 276);
            this.mainMenuBtn8.Name = "mainMenuBtn8";
            this.mainMenuBtn8.Size = new System.Drawing.Size(264, 40);
            this.mainMenuBtn8.TabIndex = 11;
            this.mainMenuBtn8.Text = "BACK TO MAIN MENU";
            this.mainMenuBtn8.UseVisualStyleBackColor = false;
            this.mainMenuBtn8.Click += new System.EventHandler(this.mainMenuBtn8_Click);
            // 
            // viewFlightBtn
            // 
            this.viewFlightBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.viewFlightBtn.FlatAppearance.BorderSize = 0;
            this.viewFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFlightBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFlightBtn.ForeColor = System.Drawing.Color.Azure;
            this.viewFlightBtn.Location = new System.Drawing.Point(299, 276);
            this.viewFlightBtn.Name = "viewFlightBtn";
            this.viewFlightBtn.Size = new System.Drawing.Size(120, 40);
            this.viewFlightBtn.TabIndex = 10;
            this.viewFlightBtn.Text = "View Flight";
            this.viewFlightBtn.UseVisualStyleBackColor = false;
            this.viewFlightBtn.Click += new System.EventHandler(this.viewFlightBtn_Click);
            // 
            // view_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.mainMenuBtn8);
            this.Controls.Add(this.viewFlightBtn);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.viewFlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "view_flight";
            this.Text = "Travella | Flights";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label introLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewFlight;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button mainMenuBtn8;
        private System.Windows.Forms.Button viewFlightBtn;
    }
}