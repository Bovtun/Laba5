namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddInterface = new System.Windows.Forms.Button();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.BoxIP = new System.Windows.Forms.TextBox();
            this.BoxGateway = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridInterface = new System.Windows.Forms.DataGridView();
            this.dataGridRoute = new System.Windows.Forms.DataGridView();
            this.BoxIPNotation = new System.Windows.Forms.TextBox();
            this.BoxMask = new System.Windows.Forms.TextBox();
            this.BoxInterface = new System.Windows.Forms.TextBox();
            this.BoxMetric = new System.Windows.Forms.TextBox();
            this.AddNotation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resint = new System.Windows.Forms.Label();
            this.resroute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // AddInterface
            // 
            this.AddInterface.Location = new System.Drawing.Point(252, 322);
            this.AddInterface.Name = "AddInterface";
            this.AddInterface.Size = new System.Drawing.Size(111, 20);
            this.AddInterface.TabIndex = 0;
            this.AddInterface.Text = "Добавить";
            this.AddInterface.UseVisualStyleBackColor = true;
            this.AddInterface.Click += new System.EventHandler(this.AddInterface_Click);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(12, 299);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(100, 20);
            this.BoxName.TabIndex = 1;
            this.BoxName.Text = "eth0";
            // 
            // BoxIP
            // 
            this.BoxIP.Location = new System.Drawing.Point(118, 299);
            this.BoxIP.Name = "BoxIP";
            this.BoxIP.Size = new System.Drawing.Size(128, 20);
            this.BoxIP.TabIndex = 2;
            this.BoxIP.Text = "1.1.1.1";
            // 
            // BoxGateway
            // 
            this.BoxGateway.Location = new System.Drawing.Point(252, 299);
            this.BoxGateway.Name = "BoxGateway";
            this.BoxGateway.Size = new System.Drawing.Size(111, 20);
            this.BoxGateway.TabIndex = 3;
            this.BoxGateway.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя интерфейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP адрес";
            // 
            // dataGridInterface
            // 
            this.dataGridInterface.AllowDrop = true;
            this.dataGridInterface.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInterface.Location = new System.Drawing.Point(12, 13);
            this.dataGridInterface.Name = "dataGridInterface";
            this.dataGridInterface.ReadOnly = true;
            this.dataGridInterface.Size = new System.Drawing.Size(351, 258);
            this.dataGridInterface.TabIndex = 6;
            // 
            // dataGridRoute
            // 
            this.dataGridRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoute.Location = new System.Drawing.Point(420, 12);
            this.dataGridRoute.Name = "dataGridRoute";
            this.dataGridRoute.Size = new System.Drawing.Size(430, 259);
            this.dataGridRoute.TabIndex = 7;
            // 
            // BoxIPNotation
            // 
            this.BoxIPNotation.Location = new System.Drawing.Point(420, 299);
            this.BoxIPNotation.Name = "BoxIPNotation";
            this.BoxIPNotation.Size = new System.Drawing.Size(112, 20);
            this.BoxIPNotation.TabIndex = 8;
            this.BoxIPNotation.Text = "1.1.1.1";
            // 
            // BoxMask
            // 
            this.BoxMask.Location = new System.Drawing.Point(538, 299);
            this.BoxMask.Name = "BoxMask";
            this.BoxMask.Size = new System.Drawing.Size(100, 20);
            this.BoxMask.TabIndex = 9;
            this.BoxMask.Text = "255.255.255.255";
            // 
            // BoxInterface
            // 
            this.BoxInterface.Location = new System.Drawing.Point(644, 299);
            this.BoxInterface.Name = "BoxInterface";
            this.BoxInterface.Size = new System.Drawing.Size(100, 20);
            this.BoxInterface.TabIndex = 10;
            this.BoxInterface.Text = "eth0";
            // 
            // BoxMetric
            // 
            this.BoxMetric.Location = new System.Drawing.Point(750, 299);
            this.BoxMetric.Name = "BoxMetric";
            this.BoxMetric.Size = new System.Drawing.Size(100, 20);
            this.BoxMetric.TabIndex = 11;
            // 
            // AddNotation
            // 
            this.AddNotation.Location = new System.Drawing.Point(750, 325);
            this.AddNotation.Name = "AddNotation";
            this.AddNotation.Size = new System.Drawing.Size(100, 23);
            this.AddNotation.TabIndex = 12;
            this.AddNotation.Text = "Добавить";
            this.AddNotation.UseVisualStyleBackColor = true;
            this.AddNotation.Click += new System.EventHandler(this.AddNotation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Шлюз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Маска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Интерфейс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Метрика";
            // 
            // resint
            // 
            this.resint.AutoSize = true;
            this.resint.Location = new System.Drawing.Point(12, 328);
            this.resint.Name = "resint";
            this.resint.Size = new System.Drawing.Size(44, 13);
            this.resint.TabIndex = 18;
            this.resint.Text = "Статус:";
            // 
            // resroute
            // 
            this.resroute.AutoSize = true;
            this.resroute.Location = new System.Drawing.Point(420, 328);
            this.resroute.Name = "resroute";
            this.resroute.Size = new System.Drawing.Size(44, 13);
            this.resroute.TabIndex = 19;
            this.resroute.Text = "Статус:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 354);
            this.Controls.Add(this.resroute);
            this.Controls.Add(this.resint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddNotation);
            this.Controls.Add(this.BoxMetric);
            this.Controls.Add(this.BoxInterface);
            this.Controls.Add(this.BoxMask);
            this.Controls.Add(this.BoxIPNotation);
            this.Controls.Add(this.dataGridRoute);
            this.Controls.Add(this.dataGridInterface);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxGateway);
            this.Controls.Add(this.BoxIP);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.AddInterface);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddInterface;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox BoxIP;
        private System.Windows.Forms.TextBox BoxGateway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridInterface;
        public System.Windows.Forms.DataGridView dataGridRoute;
        private System.Windows.Forms.TextBox BoxIPNotation;
        private System.Windows.Forms.TextBox BoxMask;
        private System.Windows.Forms.TextBox BoxInterface;
        private System.Windows.Forms.TextBox BoxMetric;
        private System.Windows.Forms.Button AddNotation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resint;
        private System.Windows.Forms.Label resroute;
    }
}

