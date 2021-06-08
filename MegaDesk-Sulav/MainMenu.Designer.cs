
namespace MegaDesk_Sulav
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Location = new System.Drawing.Point(49, 56);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(375, 105);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(49, 460);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(375, 105);
            this.searchQuotes.TabIndex = 1;
            this.searchQuotes.Text = "SearchQuotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(49, 258);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(375, 105);
            this.viewQuotes.TabIndex = 2;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 662);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(375, 105);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 829);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainMenu";
            this.Text = "MegaDesk | Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

