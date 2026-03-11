namespace Quiz_Modul3_103082400039
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
            this.lblSoal = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoal
            // 
            this.lblSoal.AutoSize = true;
            this.lblSoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoal.Location = new System.Drawing.Point(238, 116);
            this.lblSoal.Name = "lblSoal";
            this.lblSoal.Size = new System.Drawing.Size(389, 26);
            this.lblSoal.TabIndex = 0;
            this.lblSoal.Text = "Apa fungsi utama dari GUI Builder?";
            this.lblSoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoal.Click += new System.EventHandler(this.lblSoal_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 187);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(398, 73);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = " A. Membuat GUI secara visual";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(466, 187);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(398, 73);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B. Menjalankan database";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(12, 266);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(398, 73);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C. Mengedit video";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(466, 266);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(398, 73);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = " D. Membuat jaringan komputer";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(383, 384);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 25);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Hasil";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 559);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.lblSoal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuis Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoal;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label lblOutput;
    }
}

