
namespace MegaDesk_Sulav
{
    partial class AddQuote
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
            this.exitAddQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDrawer = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.ComboBox();
            this.getQuote = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // exitAddQuote
            // 
            this.exitAddQuote.Location = new System.Drawing.Point(729, 594);
            this.exitAddQuote.Name = "exitAddQuote";
            this.exitAddQuote.Size = new System.Drawing.Size(257, 83);
            this.exitAddQuote.TabIndex = 0;
            this.exitAddQuote.Text = "Cancel";
            this.exitAddQuote.UseVisualStyleBackColor = true;
            this.exitAddQuote.Click += new System.EventHandler(this.exitAddQuote_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Quote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(37, 133);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(296, 50);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Customer Name :";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(349, 133);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(520, 50);
            this.inputName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericDepth);
            this.groupBox1.Controls.Add(this.numericWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(83, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Size ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "Depth :";
            // 
            // numericWidth
            // 
            this.numericWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericWidth.Location = new System.Drawing.Point(149, 76);
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(244, 47);
            this.numericWidth.TabIndex = 2;
            this.numericWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericDepth
            // 
            this.numericDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDepth.Location = new System.Drawing.Point(149, 154);
            this.numericDepth.Name = "numericDepth";
            this.numericDepth.Size = new System.Drawing.Size(244, 47);
            this.numericDepth.TabIndex = 3;
            this.numericDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Drawers: ";
            // 
            // numericDrawer
            // 
            this.numericDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDrawer.Location = new System.Drawing.Point(933, 264);
            this.numericDrawer.Name = "numericDrawer";
            this.numericDrawer.Size = new System.Drawing.Size(143, 47);
            this.numericDrawer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 47);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surface Material: ";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate ",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterial.Location = new System.Drawing.Point(875, 352);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(295, 47);
            this.surfaceMaterial.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 47);
            this.label6.TabIndex = 9;
            this.label6.Text = "Delivery: ";
            // 
            // shipping
            // 
            this.shipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipping.FormattingEnabled = true;
            this.shipping.Items.AddRange(new object[] {
            "3 Day ",
            "5 Day ",
            "7 Day ",
            "No Rush "});
            this.shipping.Location = new System.Drawing.Point(875, 441);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(295, 47);
            this.shipping.TabIndex = 10;
            // 
            // getQuote
            // 
            this.getQuote.Location = new System.Drawing.Point(349, 594);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(257, 83);
            this.getQuote.TabIndex = 11;
            this.getQuote.Text = "Get Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 872);
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDrawer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitAddQuote);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitAddQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDepth;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDrawer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox shipping;
        private System.Windows.Forms.Button getQuote;
    }
}