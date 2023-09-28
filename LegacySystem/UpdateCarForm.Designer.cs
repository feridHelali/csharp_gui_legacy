namespace LegacySystem
{
    partial class UpdateCarForm
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
            InsertCarFormLabel = new Label();
            label1 = new Label();
            carNameTextBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            IdtextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            priceTextBox = new TextBox();
            label2 = new Label();
            descriptionTextBox = new TextBox();
            btnSearch = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSaveCar = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // InsertCarFormLabel
            // 
            InsertCarFormLabel.AutoSize = true;
            InsertCarFormLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            InsertCarFormLabel.Location = new Point(3, 0);
            InsertCarFormLabel.Name = "InsertCarFormLabel";
            InsertCarFormLabel.Size = new Size(171, 45);
            InsertCarFormLabel.TabIndex = 0;
            InsertCarFormLabel.Text = "UpdateCar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(3, 116);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 0;
            label1.Text = "Car Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // carNameTextBox
            // 
            carNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carNameTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            carNameTextBox.Location = new Point(345, 119);
            carNameTextBox.Name = "carNameTextBox";
            carNameTextBox.Size = new Size(336, 50);
            carNameTextBox.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(InsertCarFormLabel);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Controls.Add(IdtextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(priceTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(carNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.83626F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.1637421F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new Size(797, 284);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // IdtextBox
            // 
            IdtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdtextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            IdtextBox.Location = new Point(345, 3);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.Size = new Size(336, 50);
            IdtextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopRight;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 45);
            label4.TabIndex = 6;
            label4.Text = "Id";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(3, 224);
            label3.Name = "label3";
            label3.Size = new Size(89, 45);
            label3.TabIndex = 2;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            priceTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(345, 227);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(336, 50);
            priceTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(3, 171);
            label2.Name = "label2";
            label2.Size = new Size(182, 45);
            label2.TabIndex = 1;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(345, 174);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(336, 50);
            descriptionTextBox.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(687, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Controls.Add(btnSaveCar);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 338);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(797, 100);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(376, 57);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveCar
            // 
            btnSaveCar.Anchor = AnchorStyles.Right;
            btnSaveCar.FlatStyle = FlatStyle.System;
            btnSaveCar.Location = new Point(385, 3);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(376, 57);
            btnSaveCar.TabIndex = 1;
            btnSaveCar.Text = "Save";
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += btnSaveCar_Click;
            // 
            // UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "UpdateCarForm";
            Text = "UpdateCarForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label InsertCarFormLabel;
        private Label label1;
        private TextBox carNameTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private TextBox descriptionTextBox;
        private TextBox priceTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnCancel;
        private Button btnSaveCar;
        private TextBox IdtextBox;
        private Label label4;
        private Button btnSearch;
    }
}