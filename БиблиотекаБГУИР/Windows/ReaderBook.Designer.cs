﻿
namespace БиблиотекаБГУИР
{
    partial class ReaderBook
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label наименовниеLabel;
            this.GetDateText = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.NextItem = new System.Windows.Forms.Button();
            this.PriviousItem = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.наименовниеTextBox = new System.Windows.Forms.TextBox();
            this.BackdateTimePicker = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            наименовниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(490, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 13);
            label2.TabIndex = 128;
            label2.Text = "Дата возврата:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(490, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 126;
            label1.Text = "Дата получения:";
            // 
            // наименовниеLabel
            // 
            наименовниеLabel.AutoSize = true;
            наименовниеLabel.Location = new System.Drawing.Point(490, 12);
            наименовниеLabel.Name = "наименовниеLabel";
            наименовниеLabel.Size = new System.Drawing.Size(40, 13);
            наименовниеLabel.TabIndex = 116;
            наименовниеLabel.Text = "Книга:";
            // 
            // GetDateText
            // 
            this.GetDateText.Location = new System.Drawing.Point(587, 35);
            this.GetDateText.Name = "GetDateText";
            this.GetDateText.Size = new System.Drawing.Size(189, 20);
            this.GetDateText.TabIndex = 127;
            this.GetDateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(395, 180);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(89, 23);
            this.Delete_Button.TabIndex = 125;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Поиск по имени";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 123;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(300, 180);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 23);
            this.AddButton.TabIndex = 122;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(205, 180);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(89, 23);
            this.SaveChanges.TabIndex = 121;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // NextItem
            // 
            this.NextItem.Location = new System.Drawing.Point(110, 181);
            this.NextItem.Name = "NextItem";
            this.NextItem.Size = new System.Drawing.Size(89, 23);
            this.NextItem.TabIndex = 120;
            this.NextItem.Text = "Следующий";
            this.NextItem.UseVisualStyleBackColor = true;
            // 
            // PriviousItem
            // 
            this.PriviousItem.Location = new System.Drawing.Point(15, 181);
            this.PriviousItem.Name = "PriviousItem";
            this.PriviousItem.Size = new System.Drawing.Size(89, 23);
            this.PriviousItem.TabIndex = 119;
            this.PriviousItem.Text = "Предыдущий";
            this.PriviousItem.UseVisualStyleBackColor = true;
            // 
            // booksGrid
            // 
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(12, 12);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(472, 162);
            this.booksGrid.TabIndex = 118;
            // 
            // наименовниеTextBox
            // 
            this.наименовниеTextBox.Location = new System.Drawing.Point(587, 12);
            this.наименовниеTextBox.Name = "наименовниеTextBox";
            this.наименовниеTextBox.Size = new System.Drawing.Size(189, 20);
            this.наименовниеTextBox.TabIndex = 117;
            this.наименовниеTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.наименовниеTextBox.Click += new System.EventHandler(this.наименовниеTextBox_Click);
            // 
            // BackdateTimePicker
            // 
            this.BackdateTimePicker.Location = new System.Drawing.Point(587, 66);
            this.BackdateTimePicker.Name = "BackdateTimePicker";
            this.BackdateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.BackdateTimePicker.TabIndex = 131;
            // 
            // ReaderBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 217);
            this.Controls.Add(this.BackdateTimePicker);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.GetDateText);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.NextItem);
            this.Controls.Add(this.PriviousItem);
            this.Controls.Add(this.booksGrid);
            this.Controls.Add(наименовниеLabel);
            this.Controls.Add(this.наименовниеTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReaderBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReaderBook";
            this.Load += new System.EventHandler(this.ReaderBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GetDateText;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button NextItem;
        private System.Windows.Forms.Button PriviousItem;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.TextBox наименовниеTextBox;
        private System.Windows.Forms.DateTimePicker BackdateTimePicker;
    }
}