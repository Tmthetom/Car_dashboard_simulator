namespace Car_dashboard_simulator
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxSpeed = new System.Windows.Forms.GroupBox();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.trackBarRevolutions = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.isConnected = new System.Windows.Forms.Timer(this.components);
            this.groupBoxRevolutions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSpeedConvertedValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRevolutionsValue = new System.Windows.Forms.Label();
            this.labelRevolutionsConvertedValue = new System.Windows.Forms.Label();
            this.groupBoxSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRevolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxRevolutions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSpeed
            // 
            this.groupBoxSpeed.Controls.Add(this.labelSpeedConvertedValue);
            this.groupBoxSpeed.Controls.Add(this.label1);
            this.groupBoxSpeed.Controls.Add(this.labelSpeedValue);
            this.groupBoxSpeed.Controls.Add(this.trackBarSpeed);
            this.groupBoxSpeed.Enabled = false;
            this.groupBoxSpeed.Location = new System.Drawing.Point(12, 118);
            this.groupBoxSpeed.Name = "groupBoxSpeed";
            this.groupBoxSpeed.Size = new System.Drawing.Size(301, 231);
            this.groupBoxSpeed.TabIndex = 0;
            this.groupBoxSpeed.TabStop = false;
            this.groupBoxSpeed.Text = "Rychlost";
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpeedValue.Location = new System.Drawing.Point(6, 67);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(289, 39);
            this.labelSpeedValue.TabIndex = 8;
            this.labelSpeedValue.Text = "0";
            this.labelSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarRevolutions
            // 
            this.trackBarRevolutions.Location = new System.Drawing.Point(6, 19);
            this.trackBarRevolutions.Maximum = 7000;
            this.trackBarRevolutions.Name = "trackBarRevolutions";
            this.trackBarRevolutions.Size = new System.Drawing.Size(303, 45);
            this.trackBarRevolutions.TabIndex = 1;
            this.trackBarRevolutions.TickFrequency = 250;
            this.trackBarRevolutions.ValueChanged += new System.EventHandler(this.TrackBarRevolutions_ValueChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 19);
            this.trackBarSpeed.Maximum = 240;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(289, 45);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.TrackBarSpeed_ValueChanged);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.buttonConnection);
            this.groupBoxConnection.Controls.Add(this.comboBoxPorts);
            this.groupBoxConnection.Controls.Add(this.label6);
            this.groupBoxConnection.Controls.Add(this.label5);
            this.groupBoxConnection.Controls.Add(this.textBoxDeviceName);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(622, 100);
            this.groupBoxConnection.TabIndex = 1;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Připojení k Arduinu";
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConnection.Location = new System.Drawing.Point(334, 32);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(269, 52);
            this.buttonConnection.TabIndex = 4;
            this.buttonConnection.Text = "PŘIPOJIT";
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.ButtonConnection_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(116, 63);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(195, 21);
            this.comboBoxPorts.TabIndex = 3;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPorts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dostupné porty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jméno zařízení:";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.Location = new System.Drawing.Point(116, 32);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.ReadOnly = true;
            this.textBoxDeviceName.Size = new System.Drawing.Size(195, 20);
            this.textBoxDeviceName.TabIndex = 0;
            // 
            // isConnected
            // 
            this.isConnected.Enabled = true;
            this.isConnected.Interval = 1000;
            this.isConnected.Tick += new System.EventHandler(this.IsConnected_Tick);
            // 
            // groupBoxRevolutions
            // 
            this.groupBoxRevolutions.Controls.Add(this.labelRevolutionsConvertedValue);
            this.groupBoxRevolutions.Controls.Add(this.labelRevolutionsValue);
            this.groupBoxRevolutions.Controls.Add(this.label2);
            this.groupBoxRevolutions.Controls.Add(this.trackBarRevolutions);
            this.groupBoxRevolutions.Enabled = false;
            this.groupBoxRevolutions.Location = new System.Drawing.Point(319, 118);
            this.groupBoxRevolutions.Name = "groupBoxRevolutions";
            this.groupBoxRevolutions.Size = new System.Drawing.Size(315, 231);
            this.groupBoxRevolutions.TabIndex = 1;
            this.groupBoxRevolutions.TabStop = false;
            this.groupBoxRevolutions.Text = "Otáčky";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "↓";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpeedConvertedValue
            // 
            this.labelSpeedConvertedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpeedConvertedValue.Location = new System.Drawing.Point(6, 165);
            this.labelSpeedConvertedValue.Name = "labelSpeedConvertedValue";
            this.labelSpeedConvertedValue.Size = new System.Drawing.Size(289, 39);
            this.labelSpeedConvertedValue.TabIndex = 10;
            this.labelSpeedConvertedValue.Text = "0";
            this.labelSpeedConvertedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "↓";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevolutionsValue
            // 
            this.labelRevolutionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRevolutionsValue.Location = new System.Drawing.Point(6, 67);
            this.labelRevolutionsValue.Name = "labelRevolutionsValue";
            this.labelRevolutionsValue.Size = new System.Drawing.Size(303, 39);
            this.labelRevolutionsValue.TabIndex = 11;
            this.labelRevolutionsValue.Text = "0";
            this.labelRevolutionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevolutionsConvertedValue
            // 
            this.labelRevolutionsConvertedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRevolutionsConvertedValue.Location = new System.Drawing.Point(7, 165);
            this.labelRevolutionsConvertedValue.Name = "labelRevolutionsConvertedValue";
            this.labelRevolutionsConvertedValue.Size = new System.Drawing.Size(302, 39);
            this.labelRevolutionsConvertedValue.TabIndex = 11;
            this.labelRevolutionsConvertedValue.Text = "0";
            this.labelRevolutionsConvertedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 361);
            this.Controls.Add(this.groupBoxRevolutions);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Car dashboard simulator";
            this.groupBoxSpeed.ResumeLayout(false);
            this.groupBoxSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRevolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxRevolutions.ResumeLayout(false);
            this.groupBoxRevolutions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSpeed;
        private System.Windows.Forms.TrackBar trackBarRevolutions;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Timer isConnected;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.GroupBox groupBoxRevolutions;
        private System.Windows.Forms.Label labelSpeedConvertedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRevolutionsConvertedValue;
        private System.Windows.Forms.Label labelRevolutionsValue;
        private System.Windows.Forms.Label label2;
    }
}

