namespace HomeApplianceTuto
{
    partial class Location
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_city = new System.Windows.Forms.ComboBox();
            this.txt_state = new System.Windows.Forms.ComboBox();
            this.Search_data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_med = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_city);
            this.splitContainer1.Panel1.Controls.Add(this.txt_state);
            this.splitContainer1.Panel1.Controls.Add(this.Search_data);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_med);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(633, 397);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_city
            // 
            this.txt_city.FormattingEnabled = true;
            this.txt_city.Items.AddRange(new object[] {
            "Fergana",
            "Namangan",
            "Andijan",
            "Tashkent",
            "Jizzakh",
            "Samarkand",
            "Sirdaryo",
            "Navoi",
            "Bukhara",
            "Xorezm",
            "Qarshi",
            "Surkhondarya",
            "Karakalpakistan"});
            this.txt_city.Location = new System.Drawing.Point(76, 85);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(121, 32);
            this.txt_city.TabIndex = 10;
            // 
            // txt_state
            // 
            this.txt_state.FormattingEnabled = true;
            this.txt_state.Items.AddRange(new object[] {
            "Uzbekistan"});
            this.txt_state.Location = new System.Drawing.Point(76, 121);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(121, 32);
            this.txt_state.TabIndex = 9;
            // 
            // Search_data
            // 
            this.Search_data.BackColor = System.Drawing.Color.Orange;
            this.Search_data.FlatAppearance.BorderSize = 2;
            this.Search_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_data.Location = new System.Drawing.Point(76, 206);
            this.Search_data.Name = "Search_data";
            this.Search_data.Size = new System.Drawing.Size(118, 37);
            this.Search_data.TabIndex = 8;
            this.Search_data.Text = "Search";
            this.Search_data.UseVisualStyleBackColor = false;
            this.Search_data.Click += new System.EventHandler(this.Search_data_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medic";
            // 
            // txt_med
            // 
            this.txt_med.Location = new System.Drawing.Point(76, 50);
            this.txt_med.Name = "txt_med";
            this.txt_med.Size = new System.Drawing.Size(121, 29);
            this.txt_med.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(418, 397);
            this.webBrowser1.TabIndex = 0;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 397);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_med;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_data;
        private System.Windows.Forms.ComboBox txt_city;
        private System.Windows.Forms.ComboBox txt_state;
    }
}