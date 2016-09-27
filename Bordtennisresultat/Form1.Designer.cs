namespace Bordtennisresultat
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
            this.p1Points = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p2Points = new System.Windows.Forms.Label();
            this.p1Set = new System.Windows.Forms.Label();
            this.p2Set = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1Points
            // 
            this.p1Points.AutoSize = true;
            this.p1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Points.Location = new System.Drawing.Point(27, 9);
            this.p1Points.Name = "p1Points";
            this.p1Points.Size = new System.Drawing.Size(44, 31);
            this.p1Points.TabIndex = 0;
            this.p1Points.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ge poäng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ge poäng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // p2Points
            // 
            this.p2Points.AutoSize = true;
            this.p2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Points.Location = new System.Drawing.Point(137, 9);
            this.p2Points.Name = "p2Points";
            this.p2Points.Size = new System.Drawing.Size(44, 31);
            this.p2Points.TabIndex = 3;
            this.p2Points.Text = "00";
            // 
            // p1Set
            // 
            this.p1Set.AutoSize = true;
            this.p1Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Set.Location = new System.Drawing.Point(77, 9);
            this.p1Set.Name = "p1Set";
            this.p1Set.Size = new System.Drawing.Size(16, 17);
            this.p1Set.TabIndex = 4;
            this.p1Set.Text = "0";
            // 
            // p2Set
            // 
            this.p2Set.AutoSize = true;
            this.p2Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Set.Location = new System.Drawing.Point(115, 9);
            this.p2Set.Name = "p2Set";
            this.p2Set.Size = new System.Drawing.Size(16, 17);
            this.p2Set.TabIndex = 5;
            this.p2Set.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 87);
            this.Controls.Add(this.p2Set);
            this.Controls.Add(this.p1Set);
            this.Controls.Add(this.p2Points);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p1Points);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1Points;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label p2Points;
        private System.Windows.Forms.Label p1Set;
        private System.Windows.Forms.Label p2Set;
    }
}

