namespace LabText
{
    partial class SearchPriceUI
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
            this.components = new System.ComponentModel.Container();
            this.priceFromFieldTextBox = new System.Windows.Forms.TextBox();
            this.priceToFieldTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceSearchButton = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priceFromFieldTextBox
            // 
            this.priceFromFieldTextBox.Location = new System.Drawing.Point(160, 44);
            this.priceFromFieldTextBox.Name = "priceFromFieldTextBox";
            this.priceFromFieldTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceFromFieldTextBox.TabIndex = 0;
            // 
            // priceToFieldTextBox
            // 
            this.priceToFieldTextBox.Location = new System.Drawing.Point(340, 44);
            this.priceToFieldTextBox.Name = "priceToFieldTextBox";
            this.priceToFieldTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceToFieldTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price Between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "And";
            // 
            // priceSearchButton
            // 
            this.priceSearchButton.Location = new System.Drawing.Point(470, 41);
            this.priceSearchButton.Name = "priceSearchButton";
            this.priceSearchButton.Size = new System.Drawing.Size(75, 23);
            this.priceSearchButton.TabIndex = 4;
            this.priceSearchButton.Text = "Search";
            this.priceSearchButton.UseVisualStyleBackColor = true;
            this.priceSearchButton.Click += new System.EventHandler(this.priceSearchButton_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AutoGenerateColumns = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.priceFromDataGridViewTextBoxColumn,
            this.priceToDataGridViewTextBoxColumn});
            this.resultDataGridView.DataSource = this.mobileBindingSource;
            this.resultDataGridView.Location = new System.Drawing.Point(83, 97);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(444, 110);
            this.resultDataGridView.TabIndex = 5;
            this.resultDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.resultDataGridView_RowPostPaint);
            // 
            // mobileBindingSource
            // 
            this.mobileBindingSource.DataSource = typeof(LabText.Model.Mobile);
            // 
            // Sl
            // 
            this.Sl.DataPropertyName = "Id";
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iMEIDataGridViewTextBoxColumn
            // 
            this.iMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.Name = "iMEIDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // priceFromDataGridViewTextBoxColumn
            // 
            this.priceFromDataGridViewTextBoxColumn.DataPropertyName = "PriceFrom";
            this.priceFromDataGridViewTextBoxColumn.HeaderText = "PriceFrom";
            this.priceFromDataGridViewTextBoxColumn.Name = "priceFromDataGridViewTextBoxColumn";
            this.priceFromDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceToDataGridViewTextBoxColumn
            // 
            this.priceToDataGridViewTextBoxColumn.DataPropertyName = "PriceTo";
            this.priceToDataGridViewTextBoxColumn.HeaderText = "PriceTo";
            this.priceToDataGridViewTextBoxColumn.Name = "priceToDataGridViewTextBoxColumn";
            this.priceToDataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchPriceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 259);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.priceSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceToFieldTextBox);
            this.Controls.Add(this.priceFromFieldTextBox);
            this.Name = "SearchPriceUI";
            this.Text = "SearchPriceUI";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceFromFieldTextBox;
        private System.Windows.Forms.TextBox priceToFieldTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button priceSearchButton;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.BindingSource mobileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceToDataGridViewTextBoxColumn;
    }
}