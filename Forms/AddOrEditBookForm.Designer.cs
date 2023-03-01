namespace ExaminationApp.Forms
{
    partial class AddOrEditBookForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.numericPagesCount = new System.Windows.Forms.NumericUpDown();
            this.lblPagesCount = new System.Windows.Forms.Label();
            this.numericYearPublished = new System.Windows.Forms.NumericUpDown();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPublisher = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPagesCount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorYearPublished = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYearPublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(89, 4);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(372, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTitle_Validating);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(10, 32);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 15);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(89, 29);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(372, 23);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAuthor_Validating);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(89, 54);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(372, 23);
            this.txtPublisher.TabIndex = 4;
            this.txtPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPublisher_Validating);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(10, 56);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(60, 15);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "Издатель:";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(89, 79);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(372, 23);
            this.cmbGenre.TabIndex = 6;
            this.cmbGenre.Validating += new System.ComponentModel.CancelEventHandler(this.CmbGenre_Validating);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(10, 81);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 15);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Жанр:";
            // 
            // numericPagesCount
            // 
            this.numericPagesCount.Location = new System.Drawing.Point(122, 104);
            this.numericPagesCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPagesCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPagesCount.Name = "numericPagesCount";
            this.numericPagesCount.Size = new System.Drawing.Size(131, 23);
            this.numericPagesCount.TabIndex = 8;
            this.numericPagesCount.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPagesCount_Validating);
            // 
            // lblPagesCount
            // 
            this.lblPagesCount.AutoSize = true;
            this.lblPagesCount.Location = new System.Drawing.Point(10, 106);
            this.lblPagesCount.Name = "lblPagesCount";
            this.lblPagesCount.Size = new System.Drawing.Size(97, 15);
            this.lblPagesCount.TabIndex = 9;
            this.lblPagesCount.Text = "Кол-во страниц:";
            // 
            // numericYearPublished
            // 
            this.numericYearPublished.Location = new System.Drawing.Point(122, 129);
            this.numericYearPublished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericYearPublished.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericYearPublished.Name = "numericYearPublished";
            this.numericYearPublished.Size = new System.Drawing.Size(131, 23);
            this.numericYearPublished.TabIndex = 10;
            this.numericYearPublished.Validating += new System.ComponentModel.CancelEventHandler(this.NumericYearPublished_Validating);
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(10, 130);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(76, 15);
            this.lblYearPublished.TabIndex = 11;
            this.lblYearPublished.Text = "Год издания:";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(122, 154);
            this.numericPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(131, 23);
            this.numericPrice.TabIndex = 12;
            this.numericPrice.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPrice_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 15);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Цена: ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 179);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 22);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(379, 178);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorTitle
            // 
            this.errorTitle.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTitle.ContainerControl = this;
            // 
            // errorAuthor
            // 
            this.errorAuthor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAuthor.ContainerControl = this;
            // 
            // errorPublisher
            // 
            this.errorPublisher.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPublisher.ContainerControl = this;
            // 
            // errorGenre
            // 
            this.errorGenre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorGenre.ContainerControl = this;
            // 
            // errorPagesCount
            // 
            this.errorPagesCount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPagesCount.ContainerControl = this;
            // 
            // errorYearPublished
            // 
            this.errorYearPublished.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPrice.ContainerControl = this;
            // 
            // AddOrEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(497, 210);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.lblYearPublished);
            this.Controls.Add(this.numericYearPublished);
            this.Controls.Add(this.lblPagesCount);
            this.Controls.Add(this.numericPagesCount);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrEditBookForm";
            this.Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)(this.numericPagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYearPublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private Label lblPublisher;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private NumericUpDown numericPagesCount;
        private Label lblPagesCount;
        private NumericUpDown numericYearPublished;
        private Label lblYearPublished;
        private NumericUpDown numericPrice;
        private Label lblPrice;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorTitle;
        private ErrorProvider errorAuthor;
        private ErrorProvider errorPublisher;
        private ErrorProvider errorGenre;
        private ErrorProvider errorPagesCount;
        private ErrorProvider errorYearPublished;
        private ErrorProvider errorPrice;
    }
}