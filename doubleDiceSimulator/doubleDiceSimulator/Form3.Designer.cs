namespace doubleDiceSimulator
{
    partial class Form3
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
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.BTN_DS = new System.Windows.Forms.Button();
            this.BTN_SM = new System.Windows.Forms.Button();
            this.BTN_BHOC = new System.Windows.Forms.Button();
            this.BTN_SL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.Location = new System.Drawing.Point(750, 550);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(200, 70);
            this.BTN_Exit.TabIndex = 0;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // BTN_DS
            // 
            this.BTN_DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_DS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DS.Location = new System.Drawing.Point(50, 50);
            this.BTN_DS.Name = "BTN_DS";
            this.BTN_DS.Size = new System.Drawing.Size(200, 70);
            this.BTN_DS.TabIndex = 1;
            this.BTN_DS.Text = "Dice Simulator";
            this.BTN_DS.UseVisualStyleBackColor = false;
            this.BTN_DS.Click += new System.EventHandler(this.BTN_DS_Click);
            // 
            // BTN_SM
            // 
            this.BTN_SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_SM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SM.Location = new System.Drawing.Point(275, 50);
            this.BTN_SM.Name = "BTN_SM";
            this.BTN_SM.Size = new System.Drawing.Size(200, 70);
            this.BTN_SM.TabIndex = 2;
            this.BTN_SM.Text = "Slot Machine";
            this.BTN_SM.UseVisualStyleBackColor = false;
            this.BTN_SM.Click += new System.EventHandler(this.BTN_SM_Click);
            // 
            // BTN_BHOC
            // 
            this.BTN_BHOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_BHOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BHOC.Location = new System.Drawing.Point(500, 50);
            this.BTN_BHOC.Name = "BTN_BHOC";
            this.BTN_BHOC.Size = new System.Drawing.Size(200, 70);
            this.BTN_BHOC.TabIndex = 3;
            this.BTN_BHOC.Text = "Bin, Hex, Octane Calculator";
            this.BTN_BHOC.UseVisualStyleBackColor = false;
            this.BTN_BHOC.Click += new System.EventHandler(this.BTN_BHOC_Click_1);
            // 
            // BTN_SL
            // 
            this.BTN_SL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(172)))));
            this.BTN_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SL.Location = new System.Drawing.Point(725, 50);
            this.BTN_SL.Name = "BTN_SL";
            this.BTN_SL.Size = new System.Drawing.Size(200, 70);
            this.BTN_SL.TabIndex = 4;
            this.BTN_SL.Text = "Snakes and\r\nLadders";
            this.BTN_SL.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(6)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.BTN_SL);
            this.Controls.Add(this.BTN_BHOC);
            this.Controls.Add(this.BTN_SM);
            this.Controls.Add(this.BTN_DS);
            this.Controls.Add(this.BTN_Exit);
            this.Name = "Form3";
            this.Text = "Application Centre:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Button BTN_DS;
        private System.Windows.Forms.Button BTN_SM;
        private System.Windows.Forms.Button BTN_BHOC;
        private System.Windows.Forms.Button BTN_SL;
    }
}