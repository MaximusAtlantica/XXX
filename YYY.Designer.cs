namespace XXX
{
    partial class YYY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YYY));
            this.btn_exit = new System.Windows.Forms.Button();
            this.num_delay = new System.Windows.Forms.NumericUpDown();
            this.lbl_ms = new System.Windows.Forms.Label();
            this.panel_utama = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.check_pick = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).BeginInit();
            this.panel_utama.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(130, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(20, 20);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // num_delay
            // 
            this.num_delay.DecimalPlaces = 1;
            this.num_delay.Enabled = false;
            this.num_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Location = new System.Drawing.Point(0, 0);
            this.num_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_delay.Name = "num_delay";
            this.num_delay.Size = new System.Drawing.Size(38, 20);
            this.num_delay.TabIndex = 1;
            this.num_delay.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_delay.ValueChanged += new System.EventHandler(this.num_delay_ValueChanged);
            //this.num_delay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_utama_MouseDown);
            // 
            // lbl_ms
            // 
            this.lbl_ms.AutoSize = true;
            this.lbl_ms.Enabled = false;
            this.lbl_ms.Location = new System.Drawing.Point(37, 3);
            this.lbl_ms.Name = "lbl_ms";
            this.lbl_ms.Size = new System.Drawing.Size(25, 13);
            this.lbl_ms.TabIndex = 1;
            this.lbl_ms.Text = "dtk";
            //this.lbl_ms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_utama_MouseDown);
            // 
            // panel_utama
            // 
            this.panel_utama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_utama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_utama.Controls.Add(this.check_pick);
            this.panel_utama.Controls.Add(this.num_delay);
            this.panel_utama.Controls.Add(this.btn_exit);
            this.panel_utama.Controls.Add(this.btn_help);
            this.panel_utama.Controls.Add(this.lbl_ms);
            this.panel_utama.Location = new System.Drawing.Point(0, 0);
            this.panel_utama.Name = "panel_utama";
            this.panel_utama.Size = new System.Drawing.Size(150, 20);
            this.panel_utama.TabIndex = 5;
            this.panel_utama.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_utama_MouseDown);
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(112, -1);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(20, 20);
            this.btn_help.TabIndex = 3;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // check_pick
            // 
            this.check_pick.AutoSize = true;
            this.check_pick.Enabled = false;
            this.check_pick.Location = new System.Drawing.Point(63, 2);
            this.check_pick.Name = "check_pick";
            this.check_pick.Size = new System.Drawing.Size(50, 17);
            this.check_pick.TabIndex = 6;
            this.check_pick.Text = "Pick";
            this.check_pick.UseVisualStyleBackColor = true;
            // 
            // YYY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(150, 23);
            this.ControlBox = false;
            this.Controls.Add(this.panel_utama);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YYY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YYY";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.YYY_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).EndInit();
            this.panel_utama.ResumeLayout(false);
            this.panel_utama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NumericUpDown num_delay;
        private System.Windows.Forms.Label lbl_ms;
        private System.Windows.Forms.Panel panel_utama;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.CheckBox check_pick;

    }
}