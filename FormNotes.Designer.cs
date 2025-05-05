namespace WindowsFormsApp2
{
    partial class FormNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.noteContentTextBox = new System.Windows.Forms.TextBox();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.updateNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.notesDataGridView = new System.Windows.Forms.DataGridView();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.noteContentLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.noteContentTextBox.BackColor = System.Drawing.Color.White;
            this.noteContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteContentTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noteContentTextBox.Location = new System.Drawing.Point(30, 100);
            this.noteContentTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.noteContentTextBox.Multiline = true;
            this.noteContentTextBox.Name = "textBoxNote";
            this.noteContentTextBox.Size = new System.Drawing.Size(300, 240);
            this.noteContentTextBox.TabIndex = 1;
            // 
            // btnAddNote
            // 
            this.addNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNoteButton.FlatAppearance.BorderSize = 0;
            this.addNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.addNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNoteButton.ForeColor = System.Drawing.Color.White;
            this.addNoteButton.Location = new System.Drawing.Point(15, 350);
            this.addNoteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addNoteButton.Name = "btnAddNote";
            this.addNoteButton.Size = new System.Drawing.Size(100, 40);
            this.addNoteButton.TabIndex = 2;
            this.addNoteButton.Text = "Ekle";
            this.addNoteButton.UseVisualStyleBackColor = false;
            this.addNoteButton.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnUpdateNote
            // 
            this.updateNoteButton.BackColor = System.Drawing.Color.LimeGreen;
            this.updateNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateNoteButton.FlatAppearance.BorderSize = 0;
            this.updateNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.updateNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateNoteButton.ForeColor = System.Drawing.Color.White;
            this.updateNoteButton.Location = new System.Drawing.Point(118, 350);
            this.updateNoteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.updateNoteButton.Name = "btnUpdateNote";
            this.updateNoteButton.Size = new System.Drawing.Size(110, 40);
            this.updateNoteButton.TabIndex = 3;
            this.updateNoteButton.Text = "Güncelle";
            this.updateNoteButton.UseVisualStyleBackColor = false;
            this.updateNoteButton.Click += new System.EventHandler(this.btnUpdateNote_Click);
            // 
            // btnDelete
            // 
            this.deleteNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteNoteButton.FlatAppearance.BorderSize = 0;
            this.deleteNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteNoteButton.ForeColor = System.Drawing.Color.White;
            this.deleteNoteButton.Location = new System.Drawing.Point(230, 350);
            this.deleteNoteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteNoteButton.Name = "btnDelete";
            this.deleteNoteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteNoteButton.TabIndex = 4;
            this.deleteNoteButton.Text = "Sil";
            this.deleteNoteButton.UseVisualStyleBackColor = false;
            this.deleteNoteButton.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelTop
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.backButton);
            this.headerPanel.Controls.Add(this.btnAlt);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "panelTop";
            this.headerPanel.Size = new System.Drawing.Size(650, 40);
            this.headerPanel.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(45, 10);
            this.titleLabel.Name = "lblTitle";
            this.titleLabel.Size = new System.Drawing.Size(73, 28);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Notlar";
            // 
            // btnBack
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "btnBack";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlt.ForeColor = System.Drawing.Color.White;
            this.btnAlt.Location = new System.Drawing.Point(570, 0);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(40, 40);
            this.btnAlt.TabIndex = 12;
            this.btnAlt.Text = "−";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnClose
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(610, 0);
            this.closeButton.Name = "btnClose";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.notesDataGridView.AllowUserToAddRows = false;
            this.notesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.notesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.notesDataGridView.ColumnHeadersHeight = 35;
            this.notesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.notesDataGridView.EnableHeadersVisualStyles = false;
            this.notesDataGridView.Location = new System.Drawing.Point(350, 100);
            this.notesDataGridView.Name = "dataGridView1";
            this.notesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.notesDataGridView.RowHeadersVisible = false;
            this.notesDataGridView.RowHeadersWidth = 62;
            this.notesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesDataGridView.Size = new System.Drawing.Size(270, 290);
            this.notesDataGridView.TabIndex = 13;
            this.notesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNotesTitle
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.formTitleLabel.Location = new System.Drawing.Point(350, 75);
            this.formTitleLabel.Name = "lblNotesTitle";
            this.formTitleLabel.Size = new System.Drawing.Size(157, 28);
            this.formTitleLabel.TabIndex = 16;
            this.formTitleLabel.Text = "Not Koleksiyon";
            // 
            // lblNoteContent
            // 
            this.noteContentLabel.AutoSize = true;
            this.noteContentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noteContentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.noteContentLabel.Location = new System.Drawing.Point(30, 75);
            this.noteContentLabel.Name = "lblNoteContent";
            this.noteContentLabel.Size = new System.Drawing.Size(113, 28);
            this.noteContentLabel.TabIndex = 17;
            this.noteContentLabel.Text = "Not İçeriği";
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 420);
            this.Controls.Add(this.noteContentLabel);
            this.Controls.Add(this.formTitleLabel);
            this.Controls.Add(this.notesDataGridView);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.updateNoteButton);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.noteContentTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox noteContentTextBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button updateNoteButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView notesDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Label noteContentLabel;
    }
}