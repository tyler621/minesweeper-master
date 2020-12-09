﻿namespace Minesweeper
{
    partial class HighscoresForm
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
            this.highscoresListView = new System.Windows.Forms.ListView();
            this.nickHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boardSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // highscoresListView
            // 
            this.highscoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickHeader,
            this.timeHeader,
            this.boardSizeHeader});
            this.highscoresListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highscoresListView.GridLines = true;
            this.highscoresListView.HideSelection = false;
            this.highscoresListView.Location = new System.Drawing.Point(0, 0);
            this.highscoresListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highscoresListView.Name = "highscoresListView";
            this.highscoresListView.Size = new System.Drawing.Size(699, 614);
            this.highscoresListView.TabIndex = 0;
            this.highscoresListView.UseCompatibleStateImageBehavior = false;
            this.highscoresListView.View = System.Windows.Forms.View.Details;
            // 
            // nickHeader
            // 
            this.nickHeader.Text = "Name";
            this.nickHeader.Width = 136;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time in [sec]";
            this.timeHeader.Width = 110;
            // 
            // boardSizeHeader
            // 
            this.boardSizeHeader.Text = "Board Size";
            this.boardSizeHeader.Width = 209;
            // 
            // HighscoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 614);
            this.Controls.Add(this.highscoresListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighscoresForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView highscoresListView;
        private System.Windows.Forms.ColumnHeader nickHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader boardSizeHeader;
    }
}