namespace Nomayin
{
    partial class Payments
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
            this.T_lbl = new System.Windows.Forms.Label();
            this.Name_tbt = new System.Windows.Forms.TextBox();
            this.salary_tbt = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.salary_lbl = new System.Windows.Forms.Label();
            this.hours_tbt = new System.Windows.Forms.TextBox();
            this.hours_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.overtime_btn = new System.Windows.Forms.RadioButton();
            this.normal_btn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.display_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_lbl
            // 
            this.T_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_lbl.Location = new System.Drawing.Point(135, 37);
            this.T_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_lbl.Name = "T_lbl";
            this.T_lbl.Size = new System.Drawing.Size(291, 33);
            this.T_lbl.TabIndex = 0;
            this.T_lbl.Text = "Employee information";
            // 
            // Name_tbt
            // 
            this.Name_tbt.Location = new System.Drawing.Point(183, 63);
            this.Name_tbt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_tbt.Name = "Name_tbt";
            this.Name_tbt.Size = new System.Drawing.Size(227, 22);
            this.Name_tbt.TabIndex = 1;
            this.Name_tbt.TextChanged += new System.EventHandler(this.Name_tbt_TextChanged);
            // 
            // salary_tbt
            // 
            this.salary_tbt.Location = new System.Drawing.Point(183, 134);
            this.salary_tbt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salary_tbt.Name = "salary_tbt";
            this.salary_tbt.Size = new System.Drawing.Size(227, 22);
            this.salary_tbt.TabIndex = 2;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Location = new System.Drawing.Point(15, 63);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(147, 25);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Employee Name";
            // 
            // salary_lbl
            // 
            this.salary_lbl.Location = new System.Drawing.Point(12, 134);
            this.salary_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salary_lbl.Name = "salary_lbl";
            this.salary_lbl.Size = new System.Drawing.Size(149, 25);
            this.salary_lbl.TabIndex = 4;
            this.salary_lbl.Text = "Employee salary";
            // 
            // hours_tbt
            // 
            this.hours_tbt.Location = new System.Drawing.Point(183, 270);
            this.hours_tbt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hours_tbt.Name = "hours_tbt";
            this.hours_tbt.Size = new System.Drawing.Size(227, 22);
            this.hours_tbt.TabIndex = 5;
            // 
            // hours_lbl
            // 
            this.hours_lbl.Location = new System.Drawing.Point(12, 270);
            this.hours_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hours_lbl.Name = "hours_lbl";
            this.hours_lbl.Size = new System.Drawing.Size(99, 25);
            this.hours_lbl.TabIndex = 6;
            this.hours_lbl.Text = "Hours worked";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(137, 346);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(179, 47);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Print Receipt";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // overtime_btn
            // 
            this.overtime_btn.AutoSize = true;
            this.overtime_btn.Location = new System.Drawing.Point(183, 210);
            this.overtime_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overtime_btn.Name = "overtime_btn";
            this.overtime_btn.Size = new System.Drawing.Size(94, 20);
            this.overtime_btn.TabIndex = 8;
            this.overtime_btn.TabStop = true;
            this.overtime_btn.Text = "Overtime";
            this.overtime_btn.UseVisualStyleBackColor = true;
            this.overtime_btn.CheckedChanged += new System.EventHandler(this.overtime_btn_CheckedChanged);
            // 
            // normal_btn
            // 
            this.normal_btn.AutoSize = true;
            this.normal_btn.Location = new System.Drawing.Point(305, 210);
            this.normal_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normal_btn.Name = "normal_btn";
            this.normal_btn.Size = new System.Drawing.Size(78, 20);
            this.normal_btn.TabIndex = 9;
            this.normal_btn.TabStop = true;
            this.normal_btn.Text = "Normal";
            this.normal_btn.UseVisualStyleBackColor = true;
            this.normal_btn.CheckedChanged += new System.EventHandler(this.normal_btn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "over/Normal time";
            // 
            // display_lbl
            // 
            this.display_lbl.Location = new System.Drawing.Point(16, 484);
            this.display_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.display_lbl.Name = "display_lbl";
            this.display_lbl.Size = new System.Drawing.Size(257, 78);
            this.display_lbl.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "+ overtime";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Name_tbt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.salary_tbt);
            this.groupBox1.Controls.Add(this.Name_lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.salary_lbl);
            this.groupBox1.Controls.Add(this.normal_btn);
            this.groupBox1.Controls.Add(this.hours_tbt);
            this.groupBox1.Controls.Add(this.overtime_btn);
            this.groupBox1.Controls.Add(this.hours_lbl);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Location = new System.Drawing.Point(539, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(435, 459);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nomayin.Properties.Resources.house_icon;
            this.pictureBox2.Location = new System.Drawing.Point(140, 294);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomayin.Properties.Resources.OIP__1_;
            this.pictureBox1.Location = new System.Drawing.Point(140, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(997, 574);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.display_lbl);
            this.Controls.Add(this.T_lbl);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label T_lbl;
        private System.Windows.Forms.TextBox Name_tbt;
        private System.Windows.Forms.TextBox salary_tbt;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label salary_lbl;
        private System.Windows.Forms.TextBox hours_tbt;
        private System.Windows.Forms.Label hours_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.RadioButton overtime_btn;
        private System.Windows.Forms.RadioButton normal_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label display_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}