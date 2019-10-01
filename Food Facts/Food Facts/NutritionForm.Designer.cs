namespace Food_Facts
{
    partial class NutritionForm
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodLabel.Location = new System.Drawing.Point(161, 19);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(100, 23);
            this.foodLabel.TabIndex = 0;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caloriesLabel.Location = new System.Drawing.Point(161, 67);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.caloriesLabel.TabIndex = 1;
            // 
            // fatLabel
            // 
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fatLabel.Location = new System.Drawing.Point(161, 111);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(100, 23);
            this.fatLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calories";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fat Grams";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Carb Grams";
            // 
            // carbLabel
            // 
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carbLabel.Location = new System.Drawing.Point(161, 153);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(100, 23);
            this.carbLabel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(124, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.foodLabel);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.Load += new System.EventHandler(this.NutritionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Button closeButton;
    }
}