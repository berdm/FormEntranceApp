namespace FormApp_16122020
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdCircle = new System.Windows.Forms.RadioButton();
            this.rdCylinder = new System.Windows.Forms.RadioButton();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdCircle
            // 
            this.rdCircle.AutoSize = true;
            this.rdCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdCircle.ForeColor = System.Drawing.Color.DarkRed;
            this.rdCircle.Location = new System.Drawing.Point(87, 50);
            this.rdCircle.Name = "rdCircle";
            this.rdCircle.Size = new System.Drawing.Size(57, 17);
            this.rdCircle.TabIndex = 0;
            this.rdCircle.TabStop = true;
            this.rdCircle.Text = "Circle";
            this.rdCircle.UseVisualStyleBackColor = true;
            this.rdCircle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rdCircle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdCircle_MouseClick);
            // 
            // rdCylinder
            // 
            this.rdCylinder.AutoSize = true;
            this.rdCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdCylinder.ForeColor = System.Drawing.Color.DarkRed;
            this.rdCylinder.Location = new System.Drawing.Point(220, 50);
            this.rdCylinder.Name = "rdCylinder";
            this.rdCylinder.Size = new System.Drawing.Size(70, 17);
            this.rdCylinder.TabIndex = 1;
            this.rdCylinder.TabStop = true;
            this.rdCylinder.Text = "Cylinder";
            this.rdCylinder.UseVisualStyleBackColor = true;
            this.rdCylinder.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rdCylinder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdCylinder_MouseClick);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(87, 73);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(203, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(87, 110);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(203, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.Location = new System.Drawing.Point(87, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "C A L C U L A T E";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(84, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "lblUsername";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 282);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.rdCylinder);
            this.Controls.Add(this.rdCircle);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alan Hesaplama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCircle;
        private System.Windows.Forms.RadioButton rdCylinder;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
    }
}

