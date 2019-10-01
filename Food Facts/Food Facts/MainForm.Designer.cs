namespace Food_Facts
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
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(59, 32);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.bananaRadioButton.TabIndex = 0;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 Banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Location = new System.Drawing.Point(59, 59);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(145, 17);
            this.popcornRadioButton.TabIndex = 1;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1 cup of pooped popcorn";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(59, 88);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(138, 17);
            this.muffinRadioButton.TabIndex = 2;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 Large blueberry muffin";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(25, 154);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(80, 23);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display Facts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(153, 154);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 199);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.muffinRadioButton);
            this.Controls.Add(this.popcornRadioButton);
            this.Controls.Add(this.bananaRadioButton);
            this.Name = "MainForm";
            this.Text = "Food Facts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

