namespace EverythingConverter
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblConvertResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSource.Location = new System.Drawing.Point(12, 43);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(659, 29);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "10 usd in uah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что конвертируем? Например, «2 доллара США в гривны» ";
            // 
            // btnConvert
            // 
            this.btnConvert.AccessibleDescription = "Вперед!";
            this.btnConvert.Image = global::EverythingConverter.Properties.Resources.go;
            this.btnConvert.Location = new System.Drawing.Point(476, 111);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(195, 138);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtDest
            // 
            this.txtDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDest.Location = new System.Drawing.Point(15, 111);
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(455, 138);
            this.txtDest.TabIndex = 3;
            // 
            // lblConvertResult
            // 
            this.lblConvertResult.AutoSize = true;
            this.lblConvertResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConvertResult.Location = new System.Drawing.Point(11, 77);
            this.lblConvertResult.Name = "lblConvertResult";
            this.lblConvertResult.Size = new System.Drawing.Size(158, 24);
            this.lblConvertResult.TabIndex = 4;
            this.lblConvertResult.Text = "Пока что все ОК";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 261);
            this.Controls.Add(this.lblConvertResult);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Всё Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lblConvertResult;
    }
}

