namespace LibraryManagment
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
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.AddBookBTN = new System.Windows.Forms.Button();
            this.CollectionLB = new System.Windows.Forms.ListBox();
            this.DeleteBookBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BookNameTB = new System.Windows.Forms.TextBox();
            this.BookPriceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookIDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(82, 61);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(129, 20);
            this.AuthorTB.TabIndex = 0;
            // 
            // AddBookBTN
            // 
            this.AddBookBTN.Location = new System.Drawing.Point(103, 167);
            this.AddBookBTN.Name = "AddBookBTN";
            this.AddBookBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBookBTN.TabIndex = 1;
            this.AddBookBTN.Text = "Add book";
            this.AddBookBTN.UseVisualStyleBackColor = true;
            this.AddBookBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // CollectionLB
            // 
            this.CollectionLB.FormattingEnabled = true;
            this.CollectionLB.Location = new System.Drawing.Point(836, 87);
            this.CollectionLB.Name = "CollectionLB";
            this.CollectionLB.Size = new System.Drawing.Size(325, 368);
            this.CollectionLB.TabIndex = 2;
            this.CollectionLB.SelectedIndexChanged += new System.EventHandler(this.CollectionLB_SelectedIndexChanged);
            // 
            // DeleteBookBTN
            // 
            this.DeleteBookBTN.Location = new System.Drawing.Point(968, 461);
            this.DeleteBookBTN.Name = "DeleteBookBTN";
            this.DeleteBookBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBookBTN.TabIndex = 3;
            this.DeleteBookBTN.Text = "Delete Book";
            this.DeleteBookBTN.UseVisualStyleBackColor = true;
            this.DeleteBookBTN.Click += new System.EventHandler(this.DeleteBookBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Library:";
            // 
            // BookNameTB
            // 
            this.BookNameTB.Location = new System.Drawing.Point(82, 87);
            this.BookNameTB.Name = "BookNameTB";
            this.BookNameTB.Size = new System.Drawing.Size(129, 20);
            this.BookNameTB.TabIndex = 6;
            // 
            // BookPriceTB
            // 
            this.BookPriceTB.Location = new System.Drawing.Point(82, 114);
            this.BookPriceTB.Name = "BookPriceTB";
            this.BookPriceTB.Size = new System.Drawing.Size(129, 20);
            this.BookPriceTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Book name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Book price:";
            // 
            // BookIDTB
            // 
            this.BookIDTB.Location = new System.Drawing.Point(82, 141);
            this.BookIDTB.Name = "BookIDTB";
            this.BookIDTB.Size = new System.Drawing.Size(129, 20);
            this.BookIDTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Book ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookPriceTB);
            this.Controls.Add(this.BookNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBookBTN);
            this.Controls.Add(this.CollectionLB);
            this.Controls.Add(this.AddBookBTN);
            this.Controls.Add(this.AuthorTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.Button AddBookBTN;
        private System.Windows.Forms.ListBox CollectionLB;
        private System.Windows.Forms.Button DeleteBookBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookNameTB;
        private System.Windows.Forms.TextBox BookPriceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookIDTB;
        private System.Windows.Forms.Label label5;
    }
}

