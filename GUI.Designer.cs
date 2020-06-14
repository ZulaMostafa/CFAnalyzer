namespace CFAnalyzer
{
    partial class GUI
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
            this.ContestIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.APISecretTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.APIKeyTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TopTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContestIDTB
            // 
            this.ContestIDTB.Location = new System.Drawing.Point(90, 100);
            this.ContestIDTB.Name = "ContestIDTB";
            this.ContestIDTB.Size = new System.Drawing.Size(477, 22);
            this.ContestIDTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ContestID";
            // 
            // APISecretTB
            // 
            this.APISecretTB.Location = new System.Drawing.Point(90, 54);
            this.APISecretTB.Name = "APISecretTB";
            this.APISecretTB.Size = new System.Drawing.Size(477, 22);
            this.APISecretTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "APISecret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "APIKey";
            // 
            // APIKeyTB
            // 
            this.APIKeyTB.Location = new System.Drawing.Point(90, 12);
            this.APIKeyTB.Name = "APIKeyTB";
            this.APIKeyTB.Size = new System.Drawing.Size(477, 22);
            this.APIKeyTB.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load Special Awards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(90, 185);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(477, 200);
            this.ResultTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Top:";
            // 
            // TopTB
            // 
            this.TopTB.Location = new System.Drawing.Point(90, 140);
            this.TopTB.Name = "TopTB";
            this.TopTB.Size = new System.Drawing.Size(477, 22);
            this.TopTB.TabIndex = 17;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 440);
            this.Controls.Add(this.TopTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContestIDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.APISecretTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIKeyTB);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContestIDTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APISecretTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox APIKeyTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TopTB;
    }
}