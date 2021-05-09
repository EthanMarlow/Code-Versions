
namespace MasterCode_V._0
{
    partial class MainMenu
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
            this.SortAlgButton = new System.Windows.Forms.Button();
            this.SearchAlg1 = new System.Windows.Forms.Button();
            this.ExitMainMen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortAlgButton
            // 
            this.SortAlgButton.Location = new System.Drawing.Point(13, 13);
            this.SortAlgButton.Name = "SortAlgButton";
            this.SortAlgButton.Size = new System.Drawing.Size(205, 67);
            this.SortAlgButton.TabIndex = 0;
            this.SortAlgButton.Text = "Sorting Algorithm";
            this.SortAlgButton.UseVisualStyleBackColor = true;
            this.SortAlgButton.Click += new System.EventHandler(this.SortAlgButton_Click);
            // 
            // SearchAlg1
            // 
            this.SearchAlg1.Location = new System.Drawing.Point(13, 86);
            this.SearchAlg1.Name = "SearchAlg1";
            this.SearchAlg1.Size = new System.Drawing.Size(205, 67);
            this.SearchAlg1.TabIndex = 1;
            this.SearchAlg1.Text = "Searching Algortihm";
            this.SearchAlg1.UseVisualStyleBackColor = true;
            // 
            // ExitMainMen
            // 
            this.ExitMainMen.Location = new System.Drawing.Point(13, 159);
            this.ExitMainMen.Name = "ExitMainMen";
            this.ExitMainMen.Size = new System.Drawing.Size(205, 67);
            this.ExitMainMen.TabIndex = 2;
            this.ExitMainMen.Text = "Exit";
            this.ExitMainMen.UseVisualStyleBackColor = true;
            this.ExitMainMen.Click += new System.EventHandler(this.ExitMainMen_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 242);
            this.Controls.Add(this.ExitMainMen);
            this.Controls.Add(this.SearchAlg1);
            this.Controls.Add(this.SortAlgButton);
            this.Name = "MainMenu";
            this.Text = "Searching Algortihm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortAlgButton;
        private System.Windows.Forms.Button SearchAlg1;
        private System.Windows.Forms.Button ExitMainMen;
    }
}

