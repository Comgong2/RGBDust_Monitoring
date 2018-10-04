namespace RGBDust_Monitoring
{
    partial class RGBDust
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBDust));
            this.Serial_Box = new System.Windows.Forms.GroupBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Port_Box = new System.Windows.Forms.ComboBox();
            this.COM_Port_label = new System.Windows.Forms.Label();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.Sensor_Monitor = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tem_Value = new System.Windows.Forms.TextBox();
            this.Tem_label = new System.Windows.Forms.Label();
            this.Dust_Value = new System.Windows.Forms.TextBox();
            this.Dust_label = new System.Windows.Forms.Label();
            this.Serial_Box.SuspendLayout();
            this.Sensor_Monitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial_Box
            // 
            this.Serial_Box.Controls.Add(this.Connect_Button);
            this.Serial_Box.Controls.Add(this.Port_Box);
            this.Serial_Box.Controls.Add(this.COM_Port_label);
            this.Serial_Box.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Serial_Box.Location = new System.Drawing.Point(12, 12);
            this.Serial_Box.Name = "Serial_Box";
            this.Serial_Box.Size = new System.Drawing.Size(264, 125);
            this.Serial_Box.TabIndex = 0;
            this.Serial_Box.TabStop = false;
            this.Serial_Box.Text = "Serial Connect";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Connect_Button.Location = new System.Drawing.Point(17, 59);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(229, 49);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connecting";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Port_Box
            // 
            this.Port_Box.FormattingEnabled = true;
            this.Port_Box.Location = new System.Drawing.Point(114, 24);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(121, 20);
            this.Port_Box.TabIndex = 1;
            // 
            // COM_Port_label
            // 
            this.COM_Port_label.AutoSize = true;
            this.COM_Port_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.COM_Port_label.Location = new System.Drawing.Point(23, 29);
            this.COM_Port_label.Name = "COM_Port_label";
            this.COM_Port_label.Size = new System.Drawing.Size(60, 12);
            this.COM_Port_label.TabIndex = 0;
            this.COM_Port_label.Text = "COM Port";
            // 
            // Serial
            // 
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // Sensor_Monitor
            // 
            this.Sensor_Monitor.Controls.Add(this.richTextBox1);
            this.Sensor_Monitor.Controls.Add(this.textBox1);
            this.Sensor_Monitor.Controls.Add(this.label1);
            this.Sensor_Monitor.Controls.Add(this.Tem_Value);
            this.Sensor_Monitor.Controls.Add(this.Tem_label);
            this.Sensor_Monitor.Controls.Add(this.Dust_Value);
            this.Sensor_Monitor.Controls.Add(this.Dust_label);
            this.Sensor_Monitor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sensor_Monitor.Location = new System.Drawing.Point(12, 144);
            this.Sensor_Monitor.Name = "Sensor_Monitor";
            this.Sensor_Monitor.Size = new System.Drawing.Size(264, 294);
            this.Sensor_Monitor.TabIndex = 1;
            this.Sensor_Monitor.TabStop = false;
            this.Sensor_Monitor.Text = "Sensor Monitor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(251, 169);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Humidity";
            // 
            // Tem_Value
            // 
            this.Tem_Value.Location = new System.Drawing.Point(114, 57);
            this.Tem_Value.Name = "Tem_Value";
            this.Tem_Value.ReadOnly = true;
            this.Tem_Value.Size = new System.Drawing.Size(121, 21);
            this.Tem_Value.TabIndex = 3;
            // 
            // Tem_label
            // 
            this.Tem_label.AutoSize = true;
            this.Tem_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tem_label.Location = new System.Drawing.Point(23, 62);
            this.Tem_label.Name = "Tem_label";
            this.Tem_label.Size = new System.Drawing.Size(77, 12);
            this.Tem_label.TabIndex = 2;
            this.Tem_label.Text = "Temperature";
            // 
            // Dust_Value
            // 
            this.Dust_Value.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dust_Value.Location = new System.Drawing.Point(114, 25);
            this.Dust_Value.Name = "Dust_Value";
            this.Dust_Value.ReadOnly = true;
            this.Dust_Value.Size = new System.Drawing.Size(121, 21);
            this.Dust_Value.TabIndex = 1;
            // 
            // Dust_label
            // 
            this.Dust_label.AutoSize = true;
            this.Dust_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dust_label.Location = new System.Drawing.Point(25, 32);
            this.Dust_label.Name = "Dust_label";
            this.Dust_label.Size = new System.Drawing.Size(30, 12);
            this.Dust_label.TabIndex = 0;
            this.Dust_label.Text = "Dust";
            // 
            // RGBDust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 447);
            this.Controls.Add(this.Sensor_Monitor);
            this.Controls.Add(this.Serial_Box);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGBDust";
            this.Text = "RGBDust Monitoring Program";
            this.Load += new System.EventHandler(this.RGBDust_Load);
            this.Serial_Box.ResumeLayout(false);
            this.Serial_Box.PerformLayout();
            this.Sensor_Monitor.ResumeLayout(false);
            this.Sensor_Monitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Serial_Box;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox Port_Box;
        private System.Windows.Forms.Label COM_Port_label;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox Sensor_Monitor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tem_Value;
        private System.Windows.Forms.Label Tem_label;
        private System.Windows.Forms.TextBox Dust_Value;
        private System.Windows.Forms.Label Dust_label;
    }
}

