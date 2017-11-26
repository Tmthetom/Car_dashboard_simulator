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
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.trackBarFuel = new System.Windows.Forms.TrackBar();
            this.trackBarRevolutions = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.isConnected = new System.Windows.Forms.Timer(this.components);
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRevolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelSpeedValue);
            this.groupBoxControl.Controls.Add(this.label4);
            this.groupBoxControl.Controls.Add(this.label3);
            this.groupBoxControl.Controls.Add(this.label2);
            this.groupBoxControl.Controls.Add(this.label1);
            this.groupBoxControl.Controls.Add(this.trackBarTemperature);
            this.groupBoxControl.Controls.Add(this.trackBarFuel);
            this.groupBoxControl.Controls.Add(this.trackBarRevolutions);
            this.groupBoxControl.Controls.Add(this.trackBarSpeed);
            this.groupBoxControl.Enabled = false;
            this.groupBoxControl.Location = new System.Drawing.Point(12, 118);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(622, 231);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Ovládání";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teplota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Palivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Otáčky:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rychlost:";
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.Location = new System.Drawing.Point(98, 180);
            this.trackBarTemperature.Maximum = 100;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(461, 45);
            this.trackBarTemperature.TabIndex = 3;
            this.trackBarTemperature.ValueChanged += new System.EventHandler(this.TrackBarTemperature_ValueChanged);
            // 
            // trackBarFuel
            // 
            this.trackBarFuel.Location = new System.Drawing.Point(98, 129);
            this.trackBarFuel.Maximum = 100;
            this.trackBarFuel.Name = "trackBarFuel";
            this.trackBarFuel.Size = new System.Drawing.Size(461, 45);
            this.trackBarFuel.TabIndex = 2;
            this.trackBarFuel.ValueChanged += new System.EventHandler(this.TrackBarFuel_ValueChanged);
            // 
            // trackBarRevolutions
            // 
            this.trackBarRevolutions.Location = new System.Drawing.Point(98, 78);
            this.trackBarRevolutions.Maximum = 7000;
            this.trackBarRevolutions.Name = "trackBarRevolutions";
            this.trackBarRevolutions.Size = new System.Drawing.Size(461, 45);
            this.trackBarRevolutions.TabIndex = 1;
            this.trackBarRevolutions.TickFrequency = 100;
            this.trackBarRevolutions.ValueChanged += new System.EventHandler(this.TrackBarRevolutions_ValueChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(98, 27);
            this.trackBarSpeed.Maximum = 240;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(461, 45);
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
            // labelSpeedValue
            // 
            this.labelSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpeedValue.Location = new System.Drawing.Point(565, 31);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(51, 23);
            this.labelSpeedValue.TabIndex = 8;
            this.labelSpeedValue.Text = "0";
            this.labelSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 361);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Car dashboard simulator";
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRevolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.TrackBar trackBarFuel;
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
    }
}

