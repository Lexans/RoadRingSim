namespace RoadRingSim.Forms
{
    partial class FormModeling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModeling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.buttonSetCars = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCarParam2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCarParam1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCarLaw = new System.Windows.Forms.ComboBox();
            this.groupBoxHuman = new System.Windows.Forms.GroupBox();
            this.buttonSetHums = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownHumParam2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHumParam1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxHuman = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarParam1)).BeginInit();
            this.groupBoxHuman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumParam1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(651, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 651);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPause);
            this.groupBox1.Controls.Add(this.buttonPlay);
            this.groupBox1.Controls.Add(this.trackBarSpeed);
            this.groupBox1.Location = new System.Drawing.Point(678, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(243, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ход моделирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скорость";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(133, 110);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(79, 30);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "❚❚";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(19, 110);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(77, 30);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "▶";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlayClick);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(5, 47);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarSpeed.Maximum = 999;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(229, 56);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.Value = 890;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCar.Controls.Add(this.buttonSetCars);
            this.groupBoxCar.Controls.Add(this.label4);
            this.groupBoxCar.Controls.Add(this.label3);
            this.groupBoxCar.Controls.Add(this.label2);
            this.groupBoxCar.Controls.Add(this.numericUpDownCarParam2);
            this.groupBoxCar.Controls.Add(this.numericUpDownCarParam1);
            this.groupBoxCar.Controls.Add(this.comboBoxCarLaw);
            this.groupBoxCar.Location = new System.Drawing.Point(678, 182);
            this.groupBoxCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCar.Size = new System.Drawing.Size(243, 239);
            this.groupBoxCar.TabIndex = 3;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Закон распределения машин";
            // 
            // buttonSetCars
            // 
            this.buttonSetCars.Location = new System.Drawing.Point(13, 203);
            this.buttonSetCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetCars.Name = "buttonSetCars";
            this.buttonSetCars.Size = new System.Drawing.Size(79, 25);
            this.buttonSetCars.TabIndex = 6;
            this.buttonSetCars.Text = "Задать";
            this.buttonSetCars.UseVisualStyleBackColor = true;
            this.buttonSetCars.Click += new System.EventHandler(this.buttonSetCars_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вид закона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Параметр 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Параметр 1";
            // 
            // numericUpDownCarParam2
            // 
            this.numericUpDownCarParam2.DecimalPlaces = 2;
            this.numericUpDownCarParam2.Location = new System.Drawing.Point(19, 175);
            this.numericUpDownCarParam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCarParam2.Name = "numericUpDownCarParam2";
            this.numericUpDownCarParam2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCarParam2.TabIndex = 2;
            // 
            // numericUpDownCarParam1
            // 
            this.numericUpDownCarParam1.DecimalPlaces = 2;
            this.numericUpDownCarParam1.Location = new System.Drawing.Point(19, 117);
            this.numericUpDownCarParam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCarParam1.Name = "numericUpDownCarParam1";
            this.numericUpDownCarParam1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCarParam1.TabIndex = 1;
            // 
            // comboBoxCarLaw
            // 
            this.comboBoxCarLaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarLaw.FormattingEnabled = true;
            this.comboBoxCarLaw.Items.AddRange(new object[] {
            "Нормальный",
            "Экпоненциальный",
            "Равномерный"});
            this.comboBoxCarLaw.Location = new System.Drawing.Point(19, 58);
            this.comboBoxCarLaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCarLaw.Name = "comboBoxCarLaw";
            this.comboBoxCarLaw.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCarLaw.TabIndex = 0;
            // 
            // groupBoxHuman
            // 
            this.groupBoxHuman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHuman.Controls.Add(this.buttonSetHums);
            this.groupBoxHuman.Controls.Add(this.label5);
            this.groupBoxHuman.Controls.Add(this.label6);
            this.groupBoxHuman.Controls.Add(this.label7);
            this.groupBoxHuman.Controls.Add(this.numericUpDownHumParam2);
            this.groupBoxHuman.Controls.Add(this.numericUpDownHumParam1);
            this.groupBoxHuman.Controls.Add(this.comboBoxHuman);
            this.groupBoxHuman.Location = new System.Drawing.Point(678, 430);
            this.groupBoxHuman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxHuman.Name = "groupBoxHuman";
            this.groupBoxHuman.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxHuman.Size = new System.Drawing.Size(243, 231);
            this.groupBoxHuman.TabIndex = 4;
            this.groupBoxHuman.TabStop = false;
            this.groupBoxHuman.Text = "Закон распределения пешеходов";
            // 
            // buttonSetHums
            // 
            this.buttonSetHums.Location = new System.Drawing.Point(13, 199);
            this.buttonSetHums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetHums.Name = "buttonSetHums";
            this.buttonSetHums.Size = new System.Drawing.Size(79, 25);
            this.buttonSetHums.TabIndex = 7;
            this.buttonSetHums.Text = "Задать";
            this.buttonSetHums.UseVisualStyleBackColor = true;
            this.buttonSetHums.Click += new System.EventHandler(this.buttonSetHums_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вид закона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Параметр 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Параметр 1";
            // 
            // numericUpDownHumParam2
            // 
            this.numericUpDownHumParam2.DecimalPlaces = 2;
            this.numericUpDownHumParam2.Location = new System.Drawing.Point(19, 175);
            this.numericUpDownHumParam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownHumParam2.Name = "numericUpDownHumParam2";
            this.numericUpDownHumParam2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHumParam2.TabIndex = 2;
            // 
            // numericUpDownHumParam1
            // 
            this.numericUpDownHumParam1.DecimalPlaces = 2;
            this.numericUpDownHumParam1.Location = new System.Drawing.Point(19, 117);
            this.numericUpDownHumParam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownHumParam1.Name = "numericUpDownHumParam1";
            this.numericUpDownHumParam1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHumParam1.TabIndex = 1;
            // 
            // comboBoxHuman
            // 
            this.comboBoxHuman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHuman.FormattingEnabled = true;
            this.comboBoxHuman.Items.AddRange(new object[] {
            "Нормальный",
            "Экпоненциальный",
            "Равномерный"});
            this.comboBoxHuman.Location = new System.Drawing.Point(17, 70);
            this.comboBoxHuman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHuman.Name = "comboBoxHuman";
            this.comboBoxHuman.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHuman.TabIndex = 0;
            // 
            // FormModeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 678);
            this.Controls.Add(this.groupBoxHuman);
            this.Controls.Add(this.groupBoxCar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModeling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование кругового движения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModeling_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarParam1)).EndInit();
            this.groupBoxHuman.ResumeLayout(false);
            this.groupBoxHuman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumParam1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.ComboBox comboBoxCarLaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCarParam2;
        private System.Windows.Forms.NumericUpDown numericUpDownCarParam1;
        private System.Windows.Forms.GroupBox groupBoxHuman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownHumParam2;
        private System.Windows.Forms.NumericUpDown numericUpDownHumParam1;
        private System.Windows.Forms.ComboBox comboBoxHuman;
        private System.Windows.Forms.Button buttonSetCars;
        private System.Windows.Forms.Button buttonSetHums;
    }
}