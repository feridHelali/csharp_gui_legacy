namespace LegacySystem
{
    partial class InsertCarForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            InsertCarFormLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            carNameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            priceTextBox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSaveCar = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            flowLayoutPanel1.TabIndex = 1;
            // 
            // InsertCarFormLabel
            // 
            InsertCarFormLabel.AutoSize = true;
            InsertCarFormLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            InsertCarFormLabel.Location = new Point(3, 0);
            InsertCarFormLabel.Name = "InsertCarFormLabel";
            InsertCarFormLabel.Size = new Size(368, 45);
            InsertCarFormLabel.TabIndex = 0;
            InsertCarFormLabel.Text = "Add New Car To Catalog";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(carNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(descriptionTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(priceTextBox, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.875F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Size = new Size(797, 284);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(3, 92);
            label2.Name = "label2";
            label2.Size = new Size(182, 45);
            label2.TabIndex = 1;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(3, 219);
            label3.Name = "label3";
            label3.Size = new Size(89, 45);
            label3.TabIndex = 2;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(3, 0);
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
            carNameTextBox.Location = new Point(401, 3);
            carNameTextBox.Name = "carNameTextBox";
            carNameTextBox.Size = new Size(393, 50);
            carNameTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(401, 95);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(393, 50);
            descriptionTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            priceTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(401, 222);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(393, 50);
            priceTextBox.TabIndex = 5;
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
            btnCancel.Click += btnCancel_Click;
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
            // InsertCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Location = new Point(100, 100);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "InsertCarForm";
            Text = "InsertCarForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label InsertCarFormLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnCancel;
        private Button btnSaveCar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox carNameTextBox;
        private TextBox descriptionTextBox;
        private TextBox priceTextBox;
    }
}