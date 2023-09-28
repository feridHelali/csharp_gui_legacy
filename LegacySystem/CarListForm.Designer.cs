namespace LegacySystem
{
    partial class CarListForm
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
            TextBox SearchBox;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CarGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Title = new Label();
            btnFilter = new Button();
            btnClose = new Button();
            SearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CarGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Dock = DockStyle.Fill;
            SearchBox.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.Location = new Point(192, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(655, 57);
            SearchBox.TabIndex = 1;
            // 
            // CarGridView
            // 
            CarGridView.AllowUserToAddRows = false;
            CarGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            CarGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CarGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarGridView.Dock = DockStyle.Fill;
            CarGridView.Location = new Point(3, 91);
            CarGridView.Name = "CarGridView";
            CarGridView.ReadOnly = true;
            CarGridView.RowTemplate.Height = 25;
            CarGridView.Size = new Size(931, 328);
            CarGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(CarGridView);
            flowLayoutPanel1.Controls.Add(btnClose);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ImeMode = ImeMode.NoControl;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(934, 507);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Title);
            flowLayoutPanel2.Controls.Add(SearchBox);
            flowLayoutPanel2.Controls.Add(btnFilter);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(931, 82);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(3, 0);
            Title.Name = "Title";
            Title.Size = new Size(183, 65);
            Title.TabIndex = 0;
            Title.Text = "Car List";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFilter.AutoSize = true;
            btnFilter.Location = new Point(853, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 59);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(3, 425);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CarListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 507);
            Controls.Add(flowLayoutPanel1);
            Name = "CarListForm";
            Text = "CarListForm";
            ((System.ComponentModel.ISupportInitialize)CarGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CarGridView;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label Title;
        private Button btnFilter;
        private Button btnClose;
    }
}