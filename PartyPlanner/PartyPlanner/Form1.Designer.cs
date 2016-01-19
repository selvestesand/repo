namespace PartyPlanner
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dinnerNumUpDwn = new System.Windows.Forms.NumericUpDown();
            this.dinnerFancyDecoCheckBox = new System.Windows.Forms.CheckBox();
            this.healthOpCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dinnerCostTxtBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dinnerTab = new System.Windows.Forms.TabPage();
            this.birthdayTab = new System.Windows.Forms.TabPage();
            this.birthdayCostTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cakeWritingTxtBox = new System.Windows.Forms.TextBox();
            this.cakeWritingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayNumUpDwn = new System.Windows.Forms.NumericUpDown();
            this.birthdayFancyDecoCheckBox = new System.Windows.Forms.CheckBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerNumUpDwn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.dinnerTab.SuspendLayout();
            this.birthdayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayNumUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // dinnerNumUpDwn
            // 
            this.dinnerNumUpDwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerNumUpDwn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dinnerNumUpDwn.Location = new System.Drawing.Point(22, 34);
            this.dinnerNumUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dinnerNumUpDwn.Name = "dinnerNumUpDwn";
            this.dinnerNumUpDwn.Size = new System.Drawing.Size(114, 22);
            this.dinnerNumUpDwn.TabIndex = 1;
            this.dinnerNumUpDwn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dinnerNumUpDwn.ValueChanged += new System.EventHandler(this.dinnerNumUpDwn_ValueChanged);
            // 
            // dinnerFancyDecoCheckBox
            // 
            this.dinnerFancyDecoCheckBox.AutoSize = true;
            this.dinnerFancyDecoCheckBox.Checked = true;
            this.dinnerFancyDecoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dinnerFancyDecoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerFancyDecoCheckBox.Location = new System.Drawing.Point(22, 62);
            this.dinnerFancyDecoCheckBox.Name = "dinnerFancyDecoCheckBox";
            this.dinnerFancyDecoCheckBox.Size = new System.Drawing.Size(140, 20);
            this.dinnerFancyDecoCheckBox.TabIndex = 2;
            this.dinnerFancyDecoCheckBox.Text = "Fancy Decorations";
            this.dinnerFancyDecoCheckBox.UseVisualStyleBackColor = true;
            this.dinnerFancyDecoCheckBox.CheckedChanged += new System.EventHandler(this.dinnerFancyOpChanged);
            // 
            // healthOpCheckBox
            // 
            this.healthOpCheckBox.AutoSize = true;
            this.healthOpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthOpCheckBox.Location = new System.Drawing.Point(22, 88);
            this.healthOpCheckBox.Name = "healthOpCheckBox";
            this.healthOpCheckBox.Size = new System.Drawing.Size(115, 20);
            this.healthOpCheckBox.TabIndex = 3;
            this.healthOpCheckBox.Text = "Healthy Option";
            this.healthOpCheckBox.UseVisualStyleBackColor = true;
            this.healthOpCheckBox.CheckedChanged += new System.EventHandler(this.HealthyOpChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // dinnerCostTxtBox
            // 
            this.dinnerCostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerCostTxtBox.Location = new System.Drawing.Point(67, 122);
            this.dinnerCostTxtBox.Name = "dinnerCostTxtBox";
            this.dinnerCostTxtBox.ReadOnly = true;
            this.dinnerCostTxtBox.Size = new System.Drawing.Size(82, 22);
            this.dinnerCostTxtBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dinnerTab);
            this.tabControl1.Controls.Add(this.birthdayTab);
            this.tabControl1.Location = new System.Drawing.Point(-3, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(204, 210);
            this.tabControl1.TabIndex = 6;
            // 
            // dinnerTab
            // 
            this.dinnerTab.Controls.Add(this.label1);
            this.dinnerTab.Controls.Add(this.dinnerCostTxtBox);
            this.dinnerTab.Controls.Add(this.dinnerNumUpDwn);
            this.dinnerTab.Controls.Add(this.label2);
            this.dinnerTab.Controls.Add(this.dinnerFancyDecoCheckBox);
            this.dinnerTab.Controls.Add(this.healthOpCheckBox);
            this.dinnerTab.Location = new System.Drawing.Point(4, 22);
            this.dinnerTab.Name = "dinnerTab";
            this.dinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerTab.Size = new System.Drawing.Size(196, 184);
            this.dinnerTab.TabIndex = 0;
            this.dinnerTab.Text = "Dinner";
            this.dinnerTab.UseVisualStyleBackColor = true;
            // 
            // birthdayTab
            // 
            this.birthdayTab.Controls.Add(this.tooLongLabel);
            this.birthdayTab.Controls.Add(this.birthdayCostTxtBox);
            this.birthdayTab.Controls.Add(this.label4);
            this.birthdayTab.Controls.Add(this.cakeWritingTxtBox);
            this.birthdayTab.Controls.Add(this.cakeWritingLabel);
            this.birthdayTab.Controls.Add(this.label3);
            this.birthdayTab.Controls.Add(this.birthdayNumUpDwn);
            this.birthdayTab.Controls.Add(this.birthdayFancyDecoCheckBox);
            this.birthdayTab.Location = new System.Drawing.Point(4, 22);
            this.birthdayTab.Name = "birthdayTab";
            this.birthdayTab.Padding = new System.Windows.Forms.Padding(3);
            this.birthdayTab.Size = new System.Drawing.Size(196, 184);
            this.birthdayTab.TabIndex = 1;
            this.birthdayTab.Text = "Birthday";
            this.birthdayTab.UseVisualStyleBackColor = true;
            // 
            // birthdayCostTxtBox
            // 
            this.birthdayCostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCostTxtBox.Location = new System.Drawing.Point(79, 144);
            this.birthdayCostTxtBox.Name = "birthdayCostTxtBox";
            this.birthdayCostTxtBox.ReadOnly = true;
            this.birthdayCostTxtBox.Size = new System.Drawing.Size(95, 22);
            this.birthdayCostTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost";
            // 
            // cakeWritingTxtBox
            // 
            this.cakeWritingTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeWritingTxtBox.Location = new System.Drawing.Point(22, 108);
            this.cakeWritingTxtBox.Name = "cakeWritingTxtBox";
            this.cakeWritingTxtBox.Size = new System.Drawing.Size(152, 22);
            this.cakeWritingTxtBox.TabIndex = 7;
            this.cakeWritingTxtBox.TextChanged += new System.EventHandler(this.cakeWritingTxtBox_TextChanged);
            // 
            // cakeWritingLabel
            // 
            this.cakeWritingLabel.AutoSize = true;
            this.cakeWritingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeWritingLabel.Location = new System.Drawing.Point(19, 89);
            this.cakeWritingLabel.Name = "cakeWritingLabel";
            this.cakeWritingLabel.Size = new System.Drawing.Size(80, 16);
            this.cakeWritingLabel.TabIndex = 6;
            this.cakeWritingLabel.Text = "Cake writing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of People";
            // 
            // birthdayNumUpDwn
            // 
            this.birthdayNumUpDwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayNumUpDwn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.birthdayNumUpDwn.Location = new System.Drawing.Point(22, 34);
            this.birthdayNumUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayNumUpDwn.Name = "birthdayNumUpDwn";
            this.birthdayNumUpDwn.Size = new System.Drawing.Size(114, 22);
            this.birthdayNumUpDwn.TabIndex = 4;
            this.birthdayNumUpDwn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.birthdayNumUpDwn.ValueChanged += new System.EventHandler(this.birthdayNumUpDwn_ValueChanged);
            // 
            // birthdayFancyDecoCheckBox
            // 
            this.birthdayFancyDecoCheckBox.AutoSize = true;
            this.birthdayFancyDecoCheckBox.Checked = true;
            this.birthdayFancyDecoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.birthdayFancyDecoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayFancyDecoCheckBox.Location = new System.Drawing.Point(22, 62);
            this.birthdayFancyDecoCheckBox.Name = "birthdayFancyDecoCheckBox";
            this.birthdayFancyDecoCheckBox.Size = new System.Drawing.Size(140, 20);
            this.birthdayFancyDecoCheckBox.TabIndex = 5;
            this.birthdayFancyDecoCheckBox.Text = "Fancy Decorations";
            this.birthdayFancyDecoCheckBox.UseVisualStyleBackColor = true;
            this.birthdayFancyDecoCheckBox.CheckedChanged += new System.EventHandler(this.birthdayFancyDecoCheckBox_CheckedChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooLongLabel.Location = new System.Drawing.Point(97, 89);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(77, 16);
            this.tooLongLabel.TabIndex = 9;
            this.tooLongLabel.Text = "TOO LONG";
            this.tooLongLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 202);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.dinnerNumUpDwn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.dinnerTab.ResumeLayout(false);
            this.dinnerTab.PerformLayout();
            this.birthdayTab.ResumeLayout(false);
            this.birthdayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayNumUpDwn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dinnerNumUpDwn;
        private System.Windows.Forms.CheckBox dinnerFancyDecoCheckBox;
        private System.Windows.Forms.CheckBox healthOpCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dinnerCostTxtBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dinnerTab;
        private System.Windows.Forms.TabPage birthdayTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown birthdayNumUpDwn;
        private System.Windows.Forms.CheckBox birthdayFancyDecoCheckBox;
        private System.Windows.Forms.TextBox cakeWritingTxtBox;
        private System.Windows.Forms.Label cakeWritingLabel;
        private System.Windows.Forms.TextBox birthdayCostTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tooLongLabel;
    }
}

