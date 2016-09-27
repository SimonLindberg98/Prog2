namespace Tidpunkt
{
    partial class TidpunktTest
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
            this.components = new System.ComponentModel.Container();
            this.displayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sekTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sättButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(12, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(178, 40);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "--:--:--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tim";
            // 
            // timTextBox
            // 
            this.timTextBox.Location = new System.Drawing.Point(12, 78);
            this.timTextBox.Name = "timTextBox";
            this.timTextBox.Size = new System.Drawing.Size(23, 20);
            this.timTextBox.TabIndex = 2;
            this.timTextBox.Text = "00";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(41, 78);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(23, 20);
            this.minTextBox.TabIndex = 4;
            this.minTextBox.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "min";
            // 
            // sekTextBox
            // 
            this.sekTextBox.Location = new System.Drawing.Point(70, 78);
            this.sekTextBox.Name = "sekTextBox";
            this.sekTextBox.Size = new System.Drawing.Size(23, 20);
            this.sekTextBox.TabIndex = 6;
            this.sekTextBox.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sek";
            // 
            // sättButton
            // 
            this.sättButton.Location = new System.Drawing.Point(115, 75);
            this.sättButton.Name = "sättButton";
            this.sättButton.Size = new System.Drawing.Size(75, 23);
            this.sättButton.TabIndex = 7;
            this.sättButton.Text = "Sätt";
            this.sättButton.UseVisualStyleBackColor = true;
            this.sättButton.Click += new System.EventHandler(this.sättButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 138);
            this.Controls.Add(this.sättButton);
            this.Controls.Add(this.sekTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tidpunkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sekTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sättButton;
        private System.Windows.Forms.Timer timer1;
    }
}

