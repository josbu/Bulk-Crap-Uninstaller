﻿namespace BulkCrapUninstaller.Controls
{
    partial class UninstallationSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UninstallationSettings));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxManualNoCollisionProtection = new System.Windows.Forms.CheckBox();
            this.checkBoxConcurrentOneLoud = new System.Windows.Forms.CheckBox();
            this.checkBoxConcurrent = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxConcurrent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxShutdown = new System.Windows.Forms.CheckBox();
            this.checkBoxBatchSortQuiet = new System.Windows.Forms.CheckBox();
            this.checkBoxDiisableProtection = new System.Windows.Forms.CheckBox();
            this.checkBoxSimulate = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxConcurrent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.checkBoxManualNoCollisionProtection);
            this.groupBox3.Controls.Add(this.checkBoxConcurrentOneLoud);
            this.groupBox3.Controls.Add(this.checkBoxConcurrent);
            this.groupBox3.Controls.Add(this.numericUpDownMaxConcurrent);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // checkBoxManualNoCollisionProtection
            // 
            resources.ApplyResources(this.checkBoxManualNoCollisionProtection, "checkBoxManualNoCollisionProtection");
            this.checkBoxManualNoCollisionProtection.Name = "checkBoxManualNoCollisionProtection";
            this.checkBoxManualNoCollisionProtection.UseVisualStyleBackColor = true;
            // 
            // checkBoxConcurrentOneLoud
            // 
            resources.ApplyResources(this.checkBoxConcurrentOneLoud, "checkBoxConcurrentOneLoud");
            this.checkBoxConcurrentOneLoud.Name = "checkBoxConcurrentOneLoud";
            this.checkBoxConcurrentOneLoud.UseVisualStyleBackColor = true;
            // 
            // checkBoxConcurrent
            // 
            resources.ApplyResources(this.checkBoxConcurrent, "checkBoxConcurrent");
            this.checkBoxConcurrent.Name = "checkBoxConcurrent";
            this.checkBoxConcurrent.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxConcurrent
            // 
            resources.ApplyResources(this.numericUpDownMaxConcurrent, "numericUpDownMaxConcurrent");
            this.numericUpDownMaxConcurrent.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxConcurrent.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMaxConcurrent.Name = "numericUpDownMaxConcurrent";
            this.numericUpDownMaxConcurrent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.checkBoxShutdown);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxBatchSortQuiet);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxDiisableProtection);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxSimulate);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // checkBoxShutdown
            // 
            resources.ApplyResources(this.checkBoxShutdown, "checkBoxShutdown");
            this.checkBoxShutdown.Name = "checkBoxShutdown";
            this.checkBoxShutdown.UseVisualStyleBackColor = true;
            // 
            // checkBoxBatchSortQuiet
            // 
            resources.ApplyResources(this.checkBoxBatchSortQuiet, "checkBoxBatchSortQuiet");
            this.checkBoxBatchSortQuiet.Name = "checkBoxBatchSortQuiet";
            this.checkBoxBatchSortQuiet.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiisableProtection
            // 
            resources.ApplyResources(this.checkBoxDiisableProtection, "checkBoxDiisableProtection");
            this.checkBoxDiisableProtection.Name = "checkBoxDiisableProtection";
            this.checkBoxDiisableProtection.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimulate
            // 
            resources.ApplyResources(this.checkBoxSimulate, "checkBoxSimulate");
            this.checkBoxSimulate.Name = "checkBoxSimulate";
            this.checkBoxSimulate.UseVisualStyleBackColor = true;
            // 
            // UninstallationSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UninstallationSettings";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxConcurrent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxConcurrentOneLoud;
        private System.Windows.Forms.CheckBox checkBoxConcurrent;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxConcurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxShutdown;
        private System.Windows.Forms.CheckBox checkBoxManualNoCollisionProtection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBoxBatchSortQuiet;
        private System.Windows.Forms.CheckBox checkBoxDiisableProtection;
        private System.Windows.Forms.CheckBox checkBoxSimulate;
    }
}
