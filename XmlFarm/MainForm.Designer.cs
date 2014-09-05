namespace XmlFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.goButton = new System.Windows.Forms.Button();
            this.xmlBox = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Location = new System.Drawing.Point(12, 425);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(113, 36);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Deserialize";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // xmlBox
            // 
            this.xmlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlBox.Location = new System.Drawing.Point(12, 12);
            this.xmlBox.Multiline = true;
            this.xmlBox.Name = "xmlBox";
            this.xmlBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xmlBox.Size = new System.Drawing.Size(541, 407);
            this.xmlBox.TabIndex = 1;
            this.xmlBox.Text = resources.GetString("xmlBox.Text");
            this.xmlBox.WordWrap = false;
            // 
            // resultsBox
            // 
            this.resultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.Location = new System.Drawing.Point(559, 12);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsBox.Size = new System.Drawing.Size(335, 407);
            this.resultsBox.TabIndex = 2;
            this.resultsBox.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.xmlBox);
            this.Controls.Add(this.goButton);
            this.Name = "MainForm";
            this.Text = "Farm XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox xmlBox;
        private System.Windows.Forms.TextBox resultsBox;
    }
}

