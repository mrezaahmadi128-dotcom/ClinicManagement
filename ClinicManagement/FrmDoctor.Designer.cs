namespace ClinicManagement
{
    partial class FrmDoctor
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicalCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " :نام دکتر";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(240, 114);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(187, 34);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(240, 191);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(187, 34);
            this.txtLast.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = " :نام خانوادگی";
            // 
            // txtMedicalCode
            // 
            this.txtMedicalCode.Location = new System.Drawing.Point(240, 281);
            this.txtMedicalCode.Name = "txtMedicalCode";
            this.txtMedicalCode.Size = new System.Drawing.Size(187, 34);
            this.txtMedicalCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ":کد نطام پزشکی ";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(240, 368);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(187, 34);
            this.txtSpecialty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = " :تخصص";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 536);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicalCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoctor";
            this.Text = "FrmDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}