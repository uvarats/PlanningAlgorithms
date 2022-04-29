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
            this.tabControl.SuspendLayout();
            this.cyclicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.executionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueGrid)).BeginInit();
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
            this.priorityTab.Location = new System.Drawing.Point(4, 29);
            this.priorityTab.Name = "priorityTab";
            this.priorityTab.Padding = new System.Windows.Forms.Padding(3);
            this.priorityTab.Size = new System.Drawing.Size(1018, 474);
            this.priorityTab.TabIndex = 1;
            this.priorityTab.Text = "Приоритетное планирование";
            this.priorityTab.UseVisualStyleBackColor = true;
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
    }
}
