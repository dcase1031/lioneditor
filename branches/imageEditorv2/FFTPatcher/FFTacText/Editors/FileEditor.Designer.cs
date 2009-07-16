﻿namespace FFTPatcher.TextEditor.Editors
{
    partial class FileEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label sectionNotesLabel;
            System.Windows.Forms.Label fileCommentsLabel;
            this.commentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.fileNotesTextBox = new System.Windows.Forms.TextBox();
            this.sectionNotesTextbox = new System.Windows.Forms.TextBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stringListEditor1 = new FFTPatcher.TextEditor.StringListEditor();
            sectionNotesLabel = new System.Windows.Forms.Label();
            fileCommentsLabel = new System.Windows.Forms.Label();
            this.commentsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionNotesLabel
            // 
            sectionNotesLabel.AutoSize = true;
            sectionNotesLabel.Location = new System.Drawing.Point( 425, 0 );
            sectionNotesLabel.Name = "sectionNotesLabel";
            sectionNotesLabel.Size = new System.Drawing.Size( 75, 13 );
            sectionNotesLabel.TabIndex = 7;
            sectionNotesLabel.Text = "Section notes:";
            // 
            // fileCommentsLabel
            // 
            fileCommentsLabel.AutoSize = true;
            fileCommentsLabel.Location = new System.Drawing.Point( 3, 0 );
            fileCommentsLabel.Name = "fileCommentsLabel";
            fileCommentsLabel.Size = new System.Drawing.Size( 55, 13 );
            fileCommentsLabel.TabIndex = 6;
            fileCommentsLabel.Text = "File notes:";
            // 
            // commentsTable
            // 
            this.commentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsTable.ColumnCount = 2;
            this.commentsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.commentsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.commentsTable.Controls.Add( sectionNotesLabel, 1, 0 );
            this.commentsTable.Controls.Add( this.fileNotesTextBox, 0, 1 );
            this.commentsTable.Controls.Add( this.sectionNotesTextbox, 1, 1 );
            this.commentsTable.Controls.Add( fileCommentsLabel, 0, 0 );
            this.commentsTable.Enabled = false;
            this.commentsTable.Location = new System.Drawing.Point( 3, 31 );
            this.commentsTable.Name = "commentsTable";
            this.commentsTable.RowCount = 2;
            this.commentsTable.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.commentsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.commentsTable.Size = new System.Drawing.Size( 844, 58 );
            this.commentsTable.TabIndex = 6;
            // 
            // fileNotesTextBox
            // 
            this.fileNotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNotesTextBox.Location = new System.Drawing.Point( 3, 16 );
            this.fileNotesTextBox.Multiline = true;
            this.fileNotesTextBox.Name = "fileNotesTextBox";
            this.fileNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileNotesTextBox.Size = new System.Drawing.Size( 416, 39 );
            this.fileNotesTextBox.TabIndex = 4;
            this.fileNotesTextBox.TextChanged += new System.EventHandler( this.fileNotesTextBox_TextChanged );
            // 
            // sectionNotesTextbox
            // 
            this.sectionNotesTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionNotesTextbox.Location = new System.Drawing.Point( 425, 16 );
            this.sectionNotesTextbox.Multiline = true;
            this.sectionNotesTextbox.Name = "sectionNotesTextbox";
            this.sectionNotesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sectionNotesTextbox.Size = new System.Drawing.Size( 416, 39 );
            this.sectionNotesTextbox.TabIndex = 5;
            this.sectionNotesTextbox.TextChanged += new System.EventHandler( this.sectionNotesTextbox_TextChanged );
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.Location = new System.Drawing.Point( 745, 601 );
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size( 102, 23 );
            this.restoreButton.TabIndex = 3;
            this.restoreButton.Tag = "";
            this.restoreButton.Text = "Restore...";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler( this.restoreButton_Click );
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionComboBox.Enabled = false;
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point( 4, 4 );
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size( 843, 21 );
            this.sectionComboBox.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.Location = new System.Drawing.Point( 4, 594 );
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size( 843, 33 );
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stringListEditor1
            // 
            this.stringListEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stringListEditor1.Location = new System.Drawing.Point( 3, 92 );
            this.stringListEditor1.Name = "stringListEditor1";
            this.stringListEditor1.Size = new System.Drawing.Size( 844, 503 );
            this.stringListEditor1.TabIndex = 0;
            // 
            // FileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.commentsTable );
            this.Controls.Add( this.restoreButton );
            this.Controls.Add( this.errorLabel );
            this.Controls.Add( this.sectionComboBox );
            this.Controls.Add( this.stringListEditor1 );
            this.Name = "FileEditor";
            this.Size = new System.Drawing.Size( 850, 627 );
            this.commentsTable.ResumeLayout( false );
            this.commentsTable.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private StringListEditor stringListEditor1;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.TextBox fileNotesTextBox;
        private System.Windows.Forms.TextBox sectionNotesTextbox;
        private System.Windows.Forms.TableLayoutPanel commentsTable;
    }
}