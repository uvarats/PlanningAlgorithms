namespace Task5_OS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cyclicTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.executingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pauseExecuting = new System.Windows.Forms.Button();
            this.startExecuting = new System.Windows.Forms.Button();
            this.addProcess = new System.Windows.Forms.Button();
            this.executionTime = new System.Windows.Forms.NumericUpDown();
            this.queueGrid = new System.Windows.Forms.DataGridView();
            this.priorityTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.processPriority = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.priorityProcessId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityPause = new System.Windows.Forms.Button();
            this.priorityStart = new System.Windows.Forms.Button();
            this.priorityAdd = new System.Windows.Forms.Button();
            this.priorityTime = new System.Windows.Forms.NumericUpDown();
            this.priorityGrid = new System.Windows.Forms.DataGridView();
            this.priorityLogger = new System.Windows.Forms.ListBox();
            this.cyclicLogger = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.cyclicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).BeginInit();
            this.priorityTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cyclicTab);
            this.tabControl.Controls.Add(this.priorityTab);
            this.tabControl.Location = new System.Drawing.Point(-3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1026, 507);
            this.tabControl.TabIndex = 8;
            // 
            // cyclicTab
            // 
            this.cyclicTab.Controls.Add(this.cyclicLogger);
            this.cyclicTab.Controls.Add(this.label2);
            this.cyclicTab.Controls.Add(this.executingLabel);
            this.cyclicTab.Controls.Add(this.label1);
            this.cyclicTab.Controls.Add(this.pauseExecuting);
            this.cyclicTab.Controls.Add(this.startExecuting);
            this.cyclicTab.Controls.Add(this.addProcess);
            this.cyclicTab.Controls.Add(this.executionTime);
            this.cyclicTab.Controls.Add(this.queueGrid);
            this.cyclicTab.Location = new System.Drawing.Point(4, 29);
            this.cyclicTab.Name = "cyclicTab";
            this.cyclicTab.Padding = new System.Windows.Forms.Padding(3);
            this.cyclicTab.Size = new System.Drawing.Size(1018, 474);
            this.cyclicTab.TabIndex = 0;
            this.cyclicTab.Text = "Циклическое планирование";
            this.cyclicTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Время выполнения";
            // 
            // executingLabel
            // 
            this.executingLabel.AutoSize = true;
            this.executingLabel.Location = new System.Drawing.Point(790, 20);
            this.executingLabel.Name = "executingLabel";
            this.executingLabel.Size = new System.Drawing.Size(17, 20);
            this.executingLabel.TabIndex = 14;
            this.executingLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "В данный момент выполняется процесс (ID):";
            // 
            // pauseExecuting
            // 
            this.pauseExecuting.Location = new System.Drawing.Point(246, 437);
            this.pauseExecuting.Name = "pauseExecuting";
            this.pauseExecuting.Size = new System.Drawing.Size(238, 29);
            this.pauseExecuting.TabIndex = 12;
            this.pauseExecuting.Text = "Приостановить выполнение";
            this.pauseExecuting.UseVisualStyleBackColor = true;
            // 
            // startExecuting
            // 
            this.startExecuting.Location = new System.Drawing.Point(11, 437);
            this.startExecuting.Name = "startExecuting";
            this.startExecuting.Size = new System.Drawing.Size(217, 29);
            this.startExecuting.TabIndex = 11;
            this.startExecuting.Text = "Запустить выполнение";
            this.startExecuting.UseVisualStyleBackColor = true;
            // 
            // addProcess
            // 
            this.addProcess.Location = new System.Drawing.Point(604, 95);
            this.addProcess.Name = "addProcess";
            this.addProcess.Size = new System.Drawing.Size(203, 29);
            this.addProcess.TabIndex = 10;
            this.addProcess.Text = "Добавить процесс";
            this.addProcess.UseVisualStyleBackColor = true;
            // 
            // executionTime
            // 
            this.executionTime.Location = new System.Drawing.Point(604, 62);
            this.executionTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.executionTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.executionTime.Name = "executionTime";
            this.executionTime.Size = new System.Drawing.Size(203, 27);
            this.executionTime.TabIndex = 9;
            this.executionTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // queueGrid
            // 
            this.queueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queueGrid.Location = new System.Drawing.Point(11, 6);
            this.queueGrid.Name = "queueGrid";
            this.queueGrid.RowHeadersWidth = 51;
            this.queueGrid.RowTemplate.Height = 29;
            this.queueGrid.Size = new System.Drawing.Size(435, 415);
            this.queueGrid.TabIndex = 8;
            // 
            // priorityTab
            // 
            this.priorityTab.Controls.Add(this.priorityLogger);
            this.priorityTab.Controls.Add(this.label4);
            this.priorityTab.Controls.Add(this.processPriority);
            this.priorityTab.Controls.Add(this.label3);
            this.priorityTab.Controls.Add(this.priorityProcessId);
            this.priorityTab.Controls.Add(this.label5);
            this.priorityTab.Controls.Add(this.priorityPause);
            this.priorityTab.Controls.Add(this.priorityStart);
            this.priorityTab.Controls.Add(this.priorityAdd);
            this.priorityTab.Controls.Add(this.priorityTime);
            this.priorityTab.Controls.Add(this.priorityGrid);
            this.priorityTab.Location = new System.Drawing.Point(4, 29);
            this.priorityTab.Name = "priorityTab";
            this.priorityTab.Padding = new System.Windows.Forms.Padding(3);
            this.priorityTab.Size = new System.Drawing.Size(1018, 474);
            this.priorityTab.TabIndex = 1;
            this.priorityTab.Text = "Приоритетное планирование";
            this.priorityTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Приоритет";
            // 
            // processPriority
            // 
            this.processPriority.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.processPriority.Location = new System.Drawing.Point(604, 93);
            this.processPriority.Name = "processPriority";
            this.processPriority.Size = new System.Drawing.Size(203, 27);
            this.processPriority.TabIndex = 24;
            this.processPriority.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Время выполнения";
            // 
            // priorityProcessId
            // 
            this.priorityProcessId.AutoSize = true;
            this.priorityProcessId.Location = new System.Drawing.Point(781, 20);
            this.priorityProcessId.Name = "priorityProcessId";
            this.priorityProcessId.Size = new System.Drawing.Size(17, 20);
            this.priorityProcessId.TabIndex = 22;
            this.priorityProcessId.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "В данный момент выполняется процесс (ID):";
            // 
            // priorityPause
            // 
            this.priorityPause.Location = new System.Drawing.Point(246, 437);
            this.priorityPause.Name = "priorityPause";
            this.priorityPause.Size = new System.Drawing.Size(238, 29);
            this.priorityPause.TabIndex = 20;
            this.priorityPause.Text = "Приостановить выполнение";
            this.priorityPause.UseVisualStyleBackColor = true;
            this.priorityPause.Click += new System.EventHandler(this.priorityPause_Click);
            // 
            // priorityStart
            // 
            this.priorityStart.Location = new System.Drawing.Point(11, 437);
            this.priorityStart.Name = "priorityStart";
            this.priorityStart.Size = new System.Drawing.Size(217, 29);
            this.priorityStart.TabIndex = 19;
            this.priorityStart.Text = "Запустить выполнение";
            this.priorityStart.UseVisualStyleBackColor = true;
            this.priorityStart.Click += new System.EventHandler(this.priorityStart_Click);
            // 
            // priorityAdd
            // 
            this.priorityAdd.Location = new System.Drawing.Point(604, 126);
            this.priorityAdd.Name = "priorityAdd";
            this.priorityAdd.Size = new System.Drawing.Size(203, 29);
            this.priorityAdd.TabIndex = 18;
            this.priorityAdd.Text = "Добавить процесс";
            this.priorityAdd.UseVisualStyleBackColor = true;
            this.priorityAdd.Click += new System.EventHandler(this.priorityAdd_Click);
            // 
            // priorityTime
            // 
            this.priorityTime.Location = new System.Drawing.Point(604, 62);
            this.priorityTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.priorityTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.priorityTime.Name = "priorityTime";
            this.priorityTime.Size = new System.Drawing.Size(203, 27);
            this.priorityTime.TabIndex = 17;
            this.priorityTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // priorityGrid
            // 
            this.priorityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priorityGrid.Location = new System.Drawing.Point(11, 6);
            this.priorityGrid.Name = "priorityGrid";
            this.priorityGrid.RowHeadersWidth = 51;
            this.priorityGrid.RowTemplate.Height = 29;
            this.priorityGrid.Size = new System.Drawing.Size(435, 415);
            this.priorityGrid.TabIndex = 16;
            // 
            // priorityLogger
            // 
            this.priorityLogger.FormattingEnabled = true;
            this.priorityLogger.ItemHeight = 20;
            this.priorityLogger.Location = new System.Drawing.Point(452, 192);
            this.priorityLogger.Name = "priorityLogger";
            this.priorityLogger.Size = new System.Drawing.Size(543, 224);
            this.priorityLogger.TabIndex = 26;
            // 
            // cyclicLogger
            // 
            this.cyclicLogger.FormattingEnabled = true;
            this.cyclicLogger.ItemHeight = 20;
            this.cyclicLogger.Location = new System.Drawing.Point(452, 197);
            this.cyclicLogger.Name = "cyclicLogger";
            this.cyclicLogger.Size = new System.Drawing.Size(543, 224);
            this.cyclicLogger.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 513);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Алгоритмы планирования";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.cyclicTab.ResumeLayout(false);
            this.cyclicTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).EndInit();
            this.priorityTab.ResumeLayout(false);
            this.priorityTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cyclicTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label executingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseExecuting;
        private System.Windows.Forms.Button startExecuting;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.NumericUpDown executionTime;
        private System.Windows.Forms.DataGridView queueGrid;
        private System.Windows.Forms.TabPage priorityTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown processPriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priorityProcessId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button priorityPause;
        private System.Windows.Forms.Button priorityStart;
        private System.Windows.Forms.Button priorityAdd;
        private System.Windows.Forms.NumericUpDown priorityTime;
        private System.Windows.Forms.DataGridView priorityGrid;
        private System.Windows.Forms.ListBox priorityLogger;
        private System.Windows.Forms.ListBox cyclicLogger;
    }
}
