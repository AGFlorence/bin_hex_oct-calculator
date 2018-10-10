namespace doubleDiceSimulator
{
    partial class Form1
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
            this.BTN_RD = new System.Windows.Forms.Button();
            this.LBL_StNo = new System.Windows.Forms.Label();
            this.LBL_NoR = new System.Windows.Forms.Label();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_XF = new System.Windows.Forms.Button();
            this.LBL_DS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_RD
            // 
            this.BTN_RD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_RD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RD.ForeColor = System.Drawing.Color.Black;
            this.BTN_RD.Location = new System.Drawing.Point(50, 50);
            this.BTN_RD.Name = "BTN_RD";
            this.BTN_RD.Size = new System.Drawing.Size(200, 70);
            this.BTN_RD.TabIndex = 0;
            this.BTN_RD.Text = "Roll Dice";
            this.BTN_RD.UseVisualStyleBackColor = false;
            this.BTN_RD.Click += new System.EventHandler(this.BTN_RD_Click);
            // 
            // LBL_StNo
            // 
            this.LBL_StNo.AutoSize = true;
            this.LBL_StNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_StNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_StNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_StNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_StNo.Location = new System.Drawing.Point(800, 100);
            this.LBL_StNo.Name = "LBL_StNo";
            this.LBL_StNo.Size = new System.Drawing.Size(58, 46);
            this.LBL_StNo.TabIndex = 2;
            this.LBL_StNo.Text = "...";
            this.LBL_StNo.TextChanged += new System.EventHandler(this.LBL_StNo_TextChanged);
            // 
            // LBL_NoR
            // 
            this.LBL_NoR.AutoSize = true;
            this.LBL_NoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NoR.Location = new System.Drawing.Point(300, 300);
            this.LBL_NoR.Name = "LBL_NoR";
            this.LBL_NoR.Size = new System.Drawing.Size(42, 32);
            this.LBL_NoR.TabIndex = 3;
            this.LBL_NoR.Text = "...";
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reset.ForeColor = System.Drawing.Color.Black;
            this.BTN_Reset.Location = new System.Drawing.Point(50, 550);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(200, 70);
            this.BTN_Reset.TabIndex = 4;
            this.BTN_Reset.Text = "RESET";
            this.BTN_Reset.UseVisualStyleBackColor = false;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_XF
            // 
            this.BTN_XF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_XF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_XF.ForeColor = System.Drawing.Color.Black;
            this.BTN_XF.Location = new System.Drawing.Point(750, 550);
            this.BTN_XF.Name = "BTN_XF";
            this.BTN_XF.Size = new System.Drawing.Size(200, 70);
            this.BTN_XF.TabIndex = 5;
            this.BTN_XF.Text = "Exit Form";
            this.BTN_XF.UseVisualStyleBackColor = false;
            this.BTN_XF.Click += new System.EventHandler(this.BTN_XF_Click);
            // 
            // LBL_DS
            // 
            this.LBL_DS.AutoSize = true;
            this.LBL_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_DS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_DS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_DS.Location = new System.Drawing.Point(500, 100);
            this.LBL_DS.Name = "LBL_DS";
            this.LBL_DS.Size = new System.Drawing.Size(58, 46);
            this.LBL_DS.TabIndex = 6;
            this.LBL_DS.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(6)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.LBL_DS);
            this.Controls.Add(this.BTN_XF);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.LBL_NoR);
            this.Controls.Add(this.LBL_StNo);
            this.Controls.Add(this.BTN_RD);
            this.Name = "Form1";
            this.Text = "dice simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_RD;
        private System.Windows.Forms.Label LBL_StNo;
        private System.Windows.Forms.Label LBL_NoR;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_XF;
        private System.Windows.Forms.Label LBL_DS;
    }
}

