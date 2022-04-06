namespace Searching
{
    partial class SearchingForm
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
            this.ListViewColours = new System.Windows.Forms.ListView();
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButonBinarySearch = new System.Windows.Forms.Button();
            this.TextBoxTarget = new System.Windows.Forms.TextBox();
            this.ButtonJumpSearch = new System.Windows.Forms.Button();
            this.LabelSearchTarget = new System.Windows.Forms.Label();
            this.ButtonLinearSeach = new System.Windows.Forms.Button();
            this.ButtonTernarySearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewColours
            // 
            this.ListViewColours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colour});
            this.ListViewColours.HideSelection = false;
            this.ListViewColours.Location = new System.Drawing.Point(12, 12);
            this.ListViewColours.Name = "ListViewColours";
            this.ListViewColours.Size = new System.Drawing.Size(121, 290);
            this.ListViewColours.TabIndex = 0;
            this.ListViewColours.UseCompatibleStateImageBehavior = false;
            this.ListViewColours.View = System.Windows.Forms.View.Details;
            // 
            // Colour
            // 
            this.Colour.Text = "My Colours";
            this.Colour.Width = 109;
            // 
            // ButonBinarySearch
            // 
            this.ButonBinarySearch.Location = new System.Drawing.Point(155, 65);
            this.ButonBinarySearch.Name = "ButonBinarySearch";
            this.ButonBinarySearch.Size = new System.Drawing.Size(100, 23);
            this.ButonBinarySearch.TabIndex = 1;
            this.ButonBinarySearch.Text = "Binary Search";
            this.ButonBinarySearch.UseVisualStyleBackColor = true;
            this.ButonBinarySearch.Click += new System.EventHandler(this.ButonBinarySearch_Click);
            // 
            // TextBoxTarget
            // 
            this.TextBoxTarget.Location = new System.Drawing.Point(155, 39);
            this.TextBoxTarget.Name = "TextBoxTarget";
            this.TextBoxTarget.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTarget.TabIndex = 2;
            // 
            // ButtonJumpSearch
            // 
            this.ButtonJumpSearch.Location = new System.Drawing.Point(155, 94);
            this.ButtonJumpSearch.Name = "ButtonJumpSearch";
            this.ButtonJumpSearch.Size = new System.Drawing.Size(100, 23);
            this.ButtonJumpSearch.TabIndex = 3;
            this.ButtonJumpSearch.Text = "Jump Search";
            this.ButtonJumpSearch.UseVisualStyleBackColor = true;
            this.ButtonJumpSearch.Click += new System.EventHandler(this.ButtonJumpSearch_Click);
            // 
            // LabelSearchTarget
            // 
            this.LabelSearchTarget.AutoSize = true;
            this.LabelSearchTarget.Location = new System.Drawing.Point(152, 23);
            this.LabelSearchTarget.Name = "LabelSearchTarget";
            this.LabelSearchTarget.Size = new System.Drawing.Size(75, 13);
            this.LabelSearchTarget.TabIndex = 4;
            this.LabelSearchTarget.Text = "Search Target";
            // 
            // ButtonLinearSeach
            // 
            this.ButtonLinearSeach.Location = new System.Drawing.Point(155, 123);
            this.ButtonLinearSeach.Name = "ButtonLinearSeach";
            this.ButtonLinearSeach.Size = new System.Drawing.Size(100, 23);
            this.ButtonLinearSeach.TabIndex = 5;
            this.ButtonLinearSeach.Text = "Linear Search";
            this.ButtonLinearSeach.UseVisualStyleBackColor = true;
            this.ButtonLinearSeach.Click += new System.EventHandler(this.ButtonLinearSeach_Click);
            // 
            // ButtonTernarySearch
            // 
            this.ButtonTernarySearch.Location = new System.Drawing.Point(155, 152);
            this.ButtonTernarySearch.Name = "ButtonTernarySearch";
            this.ButtonTernarySearch.Size = new System.Drawing.Size(100, 23);
            this.ButtonTernarySearch.TabIndex = 6;
            this.ButtonTernarySearch.Text = "Ternary Search";
            this.ButtonTernarySearch.UseVisualStyleBackColor = true;
            this.ButtonTernarySearch.Click += new System.EventHandler(this.ButtonTernarySearch_Click);
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 337);
            this.Controls.Add(this.ButtonTernarySearch);
            this.Controls.Add(this.ButtonLinearSeach);
            this.Controls.Add(this.LabelSearchTarget);
            this.Controls.Add(this.ButtonJumpSearch);
            this.Controls.Add(this.TextBoxTarget);
            this.Controls.Add(this.ButonBinarySearch);
            this.Controls.Add(this.ListViewColours);
            this.Name = "SearchingForm";
            this.Text = "My Searching Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewColours;
        private System.Windows.Forms.Button ButonBinarySearch;
        private System.Windows.Forms.TextBox TextBoxTarget;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.Button ButtonJumpSearch;
        private System.Windows.Forms.Label LabelSearchTarget;
        private System.Windows.Forms.Button ButtonLinearSeach;
        private System.Windows.Forms.Button ButtonTernarySearch;
    }
}

