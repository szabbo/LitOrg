﻿namespace LitOrg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxNmbrOfPages = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxBinding = new System.Windows.Forms.TextBox();
            this.txtboxPublisher = new System.Windows.Forms.TextBox();
            this.txtboxYearOI = new System.Windows.Forms.TextBox();
            this.txtboxISBN = new System.Windows.Forms.TextBox();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxAuthor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtnAsc = new System.Windows.Forms.RadioButton();
            this.rbtnDsc = new System.Windows.Forms.RadioButton();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtboxNmbrOfPages);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtboxBinding);
            this.panel1.Controls.Add(this.txtboxPublisher);
            this.panel1.Controls.Add(this.txtboxYearOI);
            this.panel1.Controls.Add(this.txtboxISBN);
            this.panel1.Controls.Add(this.txtboxTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxAuthor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 183);
            this.panel1.TabIndex = 0;
            // 
            // txtboxNmbrOfPages
            // 
            this.txtboxNmbrOfPages.Location = new System.Drawing.Point(114, 159);
            this.txtboxNmbrOfPages.Name = "txtboxNmbrOfPages";
            this.txtboxNmbrOfPages.Size = new System.Drawing.Size(231, 20);
            this.txtboxNmbrOfPages.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number of Pages";
            // 
            // txtboxBinding
            // 
            this.txtboxBinding.Location = new System.Drawing.Point(114, 133);
            this.txtboxBinding.Name = "txtboxBinding";
            this.txtboxBinding.Size = new System.Drawing.Size(231, 20);
            this.txtboxBinding.TabIndex = 10;
            // 
            // txtboxPublisher
            // 
            this.txtboxPublisher.Location = new System.Drawing.Point(114, 107);
            this.txtboxPublisher.Name = "txtboxPublisher";
            this.txtboxPublisher.Size = new System.Drawing.Size(231, 20);
            this.txtboxPublisher.TabIndex = 9;
            // 
            // txtboxYearOI
            // 
            this.txtboxYearOI.Location = new System.Drawing.Point(114, 81);
            this.txtboxYearOI.Name = "txtboxYearOI";
            this.txtboxYearOI.Size = new System.Drawing.Size(231, 20);
            this.txtboxYearOI.TabIndex = 8;
            // 
            // txtboxISBN
            // 
            this.txtboxISBN.Location = new System.Drawing.Point(114, 55);
            this.txtboxISBN.Name = "txtboxISBN";
            this.txtboxISBN.Size = new System.Drawing.Size(231, 20);
            this.txtboxISBN.TabIndex = 7;
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(114, 29);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(231, 20);
            this.txtboxTitle.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Binding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year of Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // txtboxAuthor
            // 
            this.txtboxAuthor.Location = new System.Drawing.Point(114, 3);
            this.txtboxAuthor.Name = "txtboxAuthor";
            this.txtboxAuthor.Size = new System.Drawing.Size(231, 20);
            this.txtboxAuthor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Location = new System.Drawing.Point(368, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 64);
            this.panel2.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(3, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(84, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 237);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Controls.Add(this.rbtnDsc);
            this.panel4.Controls.Add(this.rbtnAsc);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbFilters);
            this.panel4.Location = new System.Drawing.Point(368, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 112);
            this.panel4.TabIndex = 3;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(3, 49);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(156, 21);
            this.cbFilters.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Filter by";
            // 
            // rbtnAsc
            // 
            this.rbtnAsc.AutoSize = true;
            this.rbtnAsc.Location = new System.Drawing.Point(6, 26);
            this.rbtnAsc.Name = "rbtnAsc";
            this.rbtnAsc.Size = new System.Drawing.Size(46, 17);
            this.rbtnAsc.TabIndex = 2;
            this.rbtnAsc.TabStop = true;
            this.rbtnAsc.Text = "ASC";
            this.rbtnAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnDsc
            // 
            this.rbtnDsc.AutoSize = true;
            this.rbtnDsc.Location = new System.Drawing.Point(77, 26);
            this.rbtnDsc.Name = "rbtnDsc";
            this.rbtnDsc.Size = new System.Drawing.Size(47, 17);
            this.rbtnDsc.TabIndex = 3;
            this.rbtnDsc.TabStop = true;
            this.rbtnDsc.Text = "DSC";
            this.rbtnDsc.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(49, 81);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxNmbrOfPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxBinding;
        private System.Windows.Forms.TextBox txtboxPublisher;
        private System.Windows.Forms.TextBox txtboxYearOI;
        private System.Windows.Forms.TextBox txtboxISBN;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxAuthor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.RadioButton rbtnDsc;
        private System.Windows.Forms.RadioButton rbtnAsc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFilters;
    }
}

