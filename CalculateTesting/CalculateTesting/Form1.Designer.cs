namespace CalculateTesting
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(88, 49);
            this.trackBarSpeed.Maximum = 240;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(445, 45);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.TrackBarSpeed_ValueChanged);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMin.Location = new System.Drawing.Point(12, 49);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(70, 25);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "label1";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMax.Location = new System.Drawing.Point(548, 49);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(70, 25);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "label2";
            // 
            // labelValue
            // 
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValue.Location = new System.Drawing.Point(12, 97);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(606, 42);
            this.labelValue.TabIndex = 3;
            this.labelValue.Text = "label1";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(12, 273);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(606, 73);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label1";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 87);
            this.label1.TabIndex = 5;
            this.label1.Text = "↓";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.trackBarSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
    }
}

