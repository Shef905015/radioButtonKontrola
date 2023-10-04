namespace radioButtonKontrola1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radBtnAvion = new System.Windows.Forms.RadioButton();
            this.radBtnAutobus = new System.Windows.Forms.RadioButton();
            this.radBtnVlastitiPrijevoz = new System.Windows.Forms.RadioButton();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(115, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite vrstu prijevoza:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnVlastitiPrijevoz);
            this.groupBox1.Controls.Add(this.radBtnAutobus);
            this.groupBox1.Controls.Add(this.radBtnAvion);
            this.groupBox1.Location = new System.Drawing.Point(133, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(45, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radBtnAvion
            // 
            this.radBtnAvion.AutoSize = true;
            this.radBtnAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radBtnAvion.Location = new System.Drawing.Point(26, 37);
            this.radBtnAvion.Name = "radBtnAvion";
            this.radBtnAvion.Size = new System.Drawing.Size(59, 20);
            this.radBtnAvion.TabIndex = 0;
            this.radBtnAvion.TabStop = true;
            this.radBtnAvion.Text = "Avion";
            this.radBtnAvion.UseVisualStyleBackColor = true;
            // 
            // radBtnAutobus
            // 
            this.radBtnAutobus.AutoSize = true;
            this.radBtnAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radBtnAutobus.Location = new System.Drawing.Point(26, 74);
            this.radBtnAutobus.Name = "radBtnAutobus";
            this.radBtnAutobus.Size = new System.Drawing.Size(74, 20);
            this.radBtnAutobus.TabIndex = 1;
            this.radBtnAutobus.TabStop = true;
            this.radBtnAutobus.Text = "Autobus";
            this.radBtnAutobus.UseVisualStyleBackColor = true;
            // 
            // radBtnVlastitiPrijevoz
            // 
            this.radBtnVlastitiPrijevoz.AutoSize = true;
            this.radBtnVlastitiPrijevoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radBtnVlastitiPrijevoz.Location = new System.Drawing.Point(26, 109);
            this.radBtnVlastitiPrijevoz.Name = "radBtnVlastitiPrijevoz";
            this.radBtnVlastitiPrijevoz.Size = new System.Drawing.Size(115, 20);
            this.radBtnVlastitiPrijevoz.TabIndex = 2;
            this.radBtnVlastitiPrijevoz.TabStop = true;
            this.radBtnVlastitiPrijevoz.Text = "Vlastiti Prijevoz";
            this.radBtnVlastitiPrijevoz.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezerviraj.Location = new System.Drawing.Point(139, 246);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(149, 42);
            this.btnRezerviraj.TabIndex = 3;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 373);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnVlastitiPrijevoz;
        private System.Windows.Forms.RadioButton radBtnAutobus;
        private System.Windows.Forms.RadioButton radBtnAvion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRezerviraj;
    }
}

