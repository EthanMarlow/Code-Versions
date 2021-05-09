
namespace MasterCode_V._0
{
    partial class SortingAlgorithmPage
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
            this.ExitSortAlg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitSortAlg
            // 
            this.ExitSortAlg.Location = new System.Drawing.Point(559, 380);
            this.ExitSortAlg.Name = "ExitSortAlg";
            this.ExitSortAlg.Size = new System.Drawing.Size(229, 58);
            this.ExitSortAlg.TabIndex = 0;
            this.ExitSortAlg.Text = "Main Menu";
            this.ExitSortAlg.UseVisualStyleBackColor = true;
            this.ExitSortAlg.Click += new System.EventHandler(this.ExitSortAlg_Click);
            // 
            // SortingAlgorithmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitSortAlg);
            this.Name = "SortingAlgorithmPage";
            this.Text = "SortingAlgorithmPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitSortAlg;
    }
}