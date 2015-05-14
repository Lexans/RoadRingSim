namespace RoadRingSim.Forms
{
    partial class FormCrossRoadAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownNumVertical = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumHorisontal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumRing = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxIsLight = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTimeLightSwitch = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCarLaw = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxHumanLaw = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownCarLawParam1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCarLawParam2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownHumanLawParam2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHumanLawParam1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumHorisontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLightSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarLawParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarLawParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumanLawParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumanLawParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(75, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(473, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // numericUpDownNumVertical
            // 
            this.numericUpDownNumVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumVertical.Location = new System.Drawing.Point(203, 38);
            this.numericUpDownNumVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumVertical.Name = "numericUpDownNumVertical";
            this.numericUpDownNumVertical.Size = new System.Drawing.Size(345, 20);
            this.numericUpDownNumVertical.TabIndex = 2;
            this.numericUpDownNumVertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNumHorisontal
            // 
            this.numericUpDownNumHorisontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumHorisontal.Location = new System.Drawing.Point(203, 64);
            this.numericUpDownNumHorisontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumHorisontal.Name = "numericUpDownNumHorisontal";
            this.numericUpDownNumHorisontal.Size = new System.Drawing.Size(345, 20);
            this.numericUpDownNumHorisontal.TabIndex = 3;
            this.numericUpDownNumHorisontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNumRing
            // 
            this.numericUpDownNumRing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumRing.Location = new System.Drawing.Point(203, 90);
            this.numericUpDownNumRing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumRing.Name = "numericUpDownNumRing";
            this.numericUpDownNumRing.Size = new System.Drawing.Size(345, 20);
            this.numericUpDownNumRing.TabIndex = 4;
            this.numericUpDownNumRing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество вертикальных полос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество горизонтальных полос";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество полос кольца";
            // 
            // checkBoxIsLight
            // 
            this.checkBoxIsLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsLight.AutoSize = true;
            this.checkBoxIsLight.Checked = true;
            this.checkBoxIsLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsLight.Location = new System.Drawing.Point(468, 116);
            this.checkBoxIsLight.Name = "checkBoxIsLight";
            this.checkBoxIsLight.Size = new System.Drawing.Size(76, 17);
            this.checkBoxIsLight.TabIndex = 8;
            this.checkBoxIsLight.Text = "Светофор";
            this.checkBoxIsLight.UseVisualStyleBackColor = true;
            this.checkBoxIsLight.CheckedChanged += new System.EventHandler(this.checkBoxIsLight_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время переключения светофора";
            // 
            // numericUpDownTimeLightSwitch
            // 
            this.numericUpDownTimeLightSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTimeLightSwitch.Location = new System.Drawing.Point(203, 116);
            this.numericUpDownTimeLightSwitch.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTimeLightSwitch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimeLightSwitch.Name = "numericUpDownTimeLightSwitch";
            this.numericUpDownTimeLightSwitch.Size = new System.Drawing.Size(259, 20);
            this.numericUpDownTimeLightSwitch.TabIndex = 10;
            this.numericUpDownTimeLightSwitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxCarLaw
            // 
            this.comboBoxCarLaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCarLaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarLaw.FormattingEnabled = true;
            this.comboBoxCarLaw.Items.AddRange(new object[] {
            "Нормальный",
            "Экспоненциальный",
            "Равномерный"});
            this.comboBoxCarLaw.Location = new System.Drawing.Point(203, 142);
            this.comboBoxCarLaw.Name = "comboBoxCarLaw";
            this.comboBoxCarLaw.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCarLaw.TabIndex = 11;
            this.comboBoxCarLaw.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarLaw_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Закон распределения машин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Закон распределения пешеходов";
            // 
            // comboBoxHumanLaw
            // 
            this.comboBoxHumanLaw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHumanLaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHumanLaw.FormattingEnabled = true;
            this.comboBoxHumanLaw.Items.AddRange(new object[] {
            "Нормальный",
            "Экспоненциальный",
            "Равномерный"});
            this.comboBoxHumanLaw.Location = new System.Drawing.Point(203, 169);
            this.comboBoxHumanLaw.Name = "comboBoxHumanLaw";
            this.comboBoxHumanLaw.Size = new System.Drawing.Size(144, 21);
            this.comboBoxHumanLaw.TabIndex = 14;
            this.comboBoxHumanLaw.SelectedIndexChanged += new System.EventHandler(this.comboBoxHumanLaw_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "с параметрами (";
            // 
            // numericUpDownCarLawParam1
            // 
            this.numericUpDownCarLawParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCarLawParam1.DecimalPlaces = 1;
            this.numericUpDownCarLawParam1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCarLawParam1.Location = new System.Drawing.Point(450, 143);
            this.numericUpDownCarLawParam1.Name = "numericUpDownCarLawParam1";
            this.numericUpDownCarLawParam1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownCarLawParam1.TabIndex = 16;
            // 
            // numericUpDownCarLawParam2
            // 
            this.numericUpDownCarLawParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCarLawParam2.DecimalPlaces = 1;
            this.numericUpDownCarLawParam2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCarLawParam2.Location = new System.Drawing.Point(494, 143);
            this.numericUpDownCarLawParam2.Name = "numericUpDownCarLawParam2";
            this.numericUpDownCarLawParam2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownCarLawParam2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = ")";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = ")";
            // 
            // numericUpDownHumanLawParam2
            // 
            this.numericUpDownHumanLawParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownHumanLawParam2.DecimalPlaces = 1;
            this.numericUpDownHumanLawParam2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHumanLawParam2.Location = new System.Drawing.Point(494, 170);
            this.numericUpDownHumanLawParam2.Name = "numericUpDownHumanLawParam2";
            this.numericUpDownHumanLawParam2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHumanLawParam2.TabIndex = 21;
            // 
            // numericUpDownHumanLawParam1
            // 
            this.numericUpDownHumanLawParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownHumanLawParam1.DecimalPlaces = 1;
            this.numericUpDownHumanLawParam1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHumanLawParam1.Location = new System.Drawing.Point(450, 170);
            this.numericUpDownHumanLawParam1.Name = "numericUpDownHumanLawParam1";
            this.numericUpDownHumanLawParam1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHumanLawParam1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "с параметрами (";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Тип приоритетов";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Кольцо главное",
            "Кольцо второстепенное",
            "Главная улица горизонтальная",
            "Главная улица вертикальная"});
            this.comboBoxPriority.Location = new System.Drawing.Point(203, 196);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(345, 21);
            this.comboBoxPriority.TabIndex = 24;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(392, 233);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 25;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(473, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCrossRoadAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 268);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownHumanLawParam2);
            this.Controls.Add(this.numericUpDownHumanLawParam1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownCarLawParam2);
            this.Controls.Add(this.numericUpDownCarLawParam1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxHumanLaw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCarLaw);
            this.Controls.Add(this.numericUpDownTimeLightSwitch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxIsLight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNumRing);
            this.Controls.Add(this.numericUpDownNumHorisontal);
            this.Controls.Add(this.numericUpDownNumVertical);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrossRoadAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление перекрестка";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumHorisontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLightSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarLawParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarLawParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumanLawParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHumanLawParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownNumVertical;
        private System.Windows.Forms.NumericUpDown numericUpDownNumHorisontal;
        private System.Windows.Forms.NumericUpDown numericUpDownNumRing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsLight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeLightSwitch;
        private System.Windows.Forms.ComboBox comboBoxCarLaw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxHumanLaw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownCarLawParam1;
        private System.Windows.Forms.NumericUpDown numericUpDownCarLawParam2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownHumanLawParam2;
        private System.Windows.Forms.NumericUpDown numericUpDownHumanLawParam1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}