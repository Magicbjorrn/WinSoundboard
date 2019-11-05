namespace Soundboard
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
            this.btn_AddSound = new System.Windows.Forms.Button();
            this.pnl_SoundPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_AddSound
            // 
            this.btn_AddSound.Location = new System.Drawing.Point(10, 10);
            this.btn_AddSound.Name = "btn_AddSound";
            this.btn_AddSound.Size = new System.Drawing.Size(100, 30);
            this.btn_AddSound.TabIndex = 0;
            this.btn_AddSound.Text = "Add A sound";
            this.btn_AddSound.UseVisualStyleBackColor = true;
            this.btn_AddSound.Click += new System.EventHandler(this.btn_AddSound_Click);
            // 
            // pnl_SoundPanel
            // 
            this.pnl_SoundPanel.Location = new System.Drawing.Point(10, 50);
            this.pnl_SoundPanel.Name = "pnl_SoundPanel";
            this.pnl_SoundPanel.Size = new System.Drawing.Size(650, 430);
            this.pnl_SoundPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 491);
            this.Controls.Add(this.pnl_SoundPanel);
            this.Controls.Add(this.btn_AddSound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddSound;
        private System.Windows.Forms.Panel pnl_SoundPanel;
    }
}

