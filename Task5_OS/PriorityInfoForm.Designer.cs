namespace Task5_OS
{
    partial class PriorityInfoForm
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
            this.processCount = new System.Windows.Forms.NumericUpDown();
            this.prioritiesCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritiesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // processCount
            // 
            this.processCount.Location = new System.Drawing.Point(164, 51);
            this.processCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.processCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.processCount.Name = "processCount";
            this.processCount.Size = new System.Drawing.Size(114, 27);
            this.processCount.TabIndex = 0;
            this.processCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // prioritiesCount
            // 
            this.prioritiesCount.Location = new System.Drawing.Point(180, 117);
            this.prioritiesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.prioritiesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.prioritiesCount.Name = "prioritiesCount";
            this.prioritiesCount.Size = new System.Drawing.Size(98, 27);
            this.prioritiesCount.TabIndex = 1;
            this.prioritiesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во процессов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во приоритетов";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(108, 186);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PriorityInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prioritiesCount);
            this.Controls.Add(this.processCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PriorityInfoForm";
            this.Text = "PriorityInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.processCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritiesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown processCount;
        private System.Windows.Forms.NumericUpDown prioritiesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
    }
}