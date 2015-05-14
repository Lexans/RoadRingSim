namespace RoadRingSim.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.менеджерАккаунтовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossRoadBindingSourceCr = new System.Windows.Forms.BindingSource(this.components);
            this.crossRoadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesRingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesVerticalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesHorisontalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribustionCarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributionHumansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLightsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lightsTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossRoadBindingSourceCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossRoadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менеджерАккаунтовToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.руководствоПользователяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1,
            this.обАвтореToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(264, 24);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.обАвтореToolStripMenuItem.Text = "Об авторах";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.linesRingDataGridViewTextBoxColumn,
            this.linesVerticalDataGridViewTextBoxColumn,
            this.linesHorisontalDataGridViewTextBoxColumn,
            this.distribustionCarsDataGridViewTextBoxColumn,
            this.distributionHumansDataGridViewTextBoxColumn,
            this.isLightsDataGridViewCheckBoxColumn,
            this.lightsTimeDataGridViewTextBoxColumn,
            this.priorityTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crossRoadBindingSourceCr;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 607);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRun,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1267, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(176, 24);
            this.toolStripButtonRun.Text = "Запуск моделирования";
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(82, 24);
            this.toolStripButtonEdit.Text = "Изменить";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(69, 24);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // менеджерАккаунтовToolStripMenuItem
            // 
            this.менеджерАккаунтовToolStripMenuItem.Name = "менеджерАккаунтовToolStripMenuItem";
            this.менеджерАккаунтовToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.менеджерАккаунтовToolStripMenuItem.Text = "Управление пользователями";
            this.менеджерАккаунтовToolStripMenuItem.Click += new System.EventHandler(this.менеджерАккаунтовToolStripMenuItem_Click);
            // 
            // crossRoadBindingSourceCr
            // 
            this.crossRoadBindingSourceCr.DataSource = typeof(RoadRingSim.Core.Domains.CrossRoad);
            // 
            // crossRoadBindingSource
            // 
            this.crossRoadBindingSource.DataSource = typeof(RoadRingSim.Core.Domains.CrossRoad);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 97;
            // 
            // linesRingDataGridViewTextBoxColumn
            // 
            this.linesRingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.linesRingDataGridViewTextBoxColumn.DataPropertyName = "LinesRing";
            this.linesRingDataGridViewTextBoxColumn.HeaderText = "Полос кольца";
            this.linesRingDataGridViewTextBoxColumn.Name = "linesRingDataGridViewTextBoxColumn";
            this.linesRingDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesRingDataGridViewTextBoxColumn.Width = 124;
            // 
            // linesVerticalDataGridViewTextBoxColumn
            // 
            this.linesVerticalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.linesVerticalDataGridViewTextBoxColumn.DataPropertyName = "LinesVertical";
            this.linesVerticalDataGridViewTextBoxColumn.HeaderText = "Полос вертикальной улицы";
            this.linesVerticalDataGridViewTextBoxColumn.Name = "linesVerticalDataGridViewTextBoxColumn";
            this.linesVerticalDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesVerticalDataGridViewTextBoxColumn.Width = 195;
            // 
            // linesHorisontalDataGridViewTextBoxColumn
            // 
            this.linesHorisontalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.linesHorisontalDataGridViewTextBoxColumn.DataPropertyName = "LinesHorisontal";
            this.linesHorisontalDataGridViewTextBoxColumn.HeaderText = "Полос горизонтальной улицы";
            this.linesHorisontalDataGridViewTextBoxColumn.Name = "linesHorisontalDataGridViewTextBoxColumn";
            this.linesHorisontalDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesHorisontalDataGridViewTextBoxColumn.Width = 208;
            // 
            // distribustionCarsDataGridViewTextBoxColumn
            // 
            this.distribustionCarsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.distribustionCarsDataGridViewTextBoxColumn.DataPropertyName = "DistribustionCars";
            this.distribustionCarsDataGridViewTextBoxColumn.HeaderText = "Распределение машин";
            this.distribustionCarsDataGridViewTextBoxColumn.Name = "distribustionCarsDataGridViewTextBoxColumn";
            this.distribustionCarsDataGridViewTextBoxColumn.ReadOnly = true;
            this.distribustionCarsDataGridViewTextBoxColumn.Width = 168;
            // 
            // distributionHumansDataGridViewTextBoxColumn
            // 
            this.distributionHumansDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.distributionHumansDataGridViewTextBoxColumn.DataPropertyName = "DistributionHumans";
            this.distributionHumansDataGridViewTextBoxColumn.HeaderText = "Распределение пешеходов";
            this.distributionHumansDataGridViewTextBoxColumn.Name = "distributionHumansDataGridViewTextBoxColumn";
            this.distributionHumansDataGridViewTextBoxColumn.ReadOnly = true;
            this.distributionHumansDataGridViewTextBoxColumn.Width = 194;
            // 
            // isLightsDataGridViewCheckBoxColumn
            // 
            this.isLightsDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isLightsDataGridViewCheckBoxColumn.DataPropertyName = "IsLights";
            this.isLightsDataGridViewCheckBoxColumn.HeaderText = "Наличие светофора";
            this.isLightsDataGridViewCheckBoxColumn.Name = "isLightsDataGridViewCheckBoxColumn";
            this.isLightsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isLightsDataGridViewCheckBoxColumn.Width = 133;
            // 
            // lightsTimeDataGridViewTextBoxColumn
            // 
            this.lightsTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lightsTimeDataGridViewTextBoxColumn.DataPropertyName = "LightsTime";
            this.lightsTimeDataGridViewTextBoxColumn.HeaderText = "Время переключения светофора";
            this.lightsTimeDataGridViewTextBoxColumn.Name = "lightsTimeDataGridViewTextBoxColumn";
            this.lightsTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lightsTimeDataGridViewTextBoxColumn.Width = 229;
            // 
            // priorityTypeDataGridViewTextBoxColumn
            // 
            this.priorityTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.priorityTypeDataGridViewTextBoxColumn.DataPropertyName = "PriorityType";
            this.priorityTypeDataGridViewTextBoxColumn.HeaderText = "Тип приоритетов";
            this.priorityTypeDataGridViewTextBoxColumn.Name = "priorityTypeDataGridViewTextBoxColumn";
            this.priorityTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityTypeDataGridViewTextBoxColumn.Width = 134;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 662);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование кругового движения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossRoadBindingSourceCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossRoadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource crossRoadBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.BindingSource crossRoadBindingSourceCr;
        private System.Windows.Forms.ToolStripButton toolStripButtonRun;
        private System.Windows.Forms.ToolStripMenuItem менеджерАккаунтовToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesRingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesVerticalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesHorisontalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distribustionCarsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionHumansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLightsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lightsTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityTypeDataGridViewTextBoxColumn;

    }
}