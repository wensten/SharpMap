namespace Txt2Shp4Sharp
{
	partial class ConvertProjectionAndCoordinatesForm
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
			this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.ConvertFromHeader = new System.Windows.Forms.Label();
			this.ConvertToHeader = new System.Windows.Forms.Label();
			this.ConvertToList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FromEllipsoidGroup = new System.Windows.Forms.GroupBox();
			this.ToEllipsoidGroup = new System.Windows.Forms.GroupBox();
			this.FromEllipsoidNameLabel = new System.Windows.Forms.Label();
			this.ToEllipsoidNameLabel = new System.Windows.Forms.Label();
			this.FromEllipsoidNameTextBox = new System.Windows.Forms.TextBox();
			this.ToEllipsoidNameComboBox = new System.Windows.Forms.ComboBox();
			this.FromSemiMajorAxisLabel = new System.Windows.Forms.Label();
			this.FromSemiMajorTextBox = new System.Windows.Forms.TextBox();
			this.FromInverseFlatteningLabel = new System.Windows.Forms.Label();
			this.FromInverseFlattening = new System.Windows.Forms.TextBox();
			this.ToInverseFlattening = new System.Windows.Forms.TextBox();
			this.ToInverseFlatteningLabel = new System.Windows.Forms.Label();
			this.ToSemiMajorTextBox = new System.Windows.Forms.TextBox();
			this.ToSemiMajorAxisLabel = new System.Windows.Forms.Label();
			this.FromGeographicCoordsGroup = new System.Windows.Forms.GroupBox();
			this.ToGeographicCoordsGroup = new System.Windows.Forms.GroupBox();
			this.FromProjectionGroupBox = new System.Windows.Forms.GroupBox();
			this.ToProjectionGroupBox = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ParameterNameColumn = new System.Windows.Forms.DataGridViewLinkColumn();
			this.ParameterValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			this.FromEllipsoidGroup.SuspendLayout();
			this.ToEllipsoidGroup.SuspendLayout();
			this.FromGeographicCoordsGroup.SuspendLayout();
			this.ToGeographicCoordsGroup.SuspendLayout();
			this.FromProjectionGroupBox.SuspendLayout();
			this.ToProjectionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// MainSplitContainer
			// 
			this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.MainSplitContainer.IsSplitterFixed = true;
			this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.MainSplitContainer.Name = "MainSplitContainer";
			// 
			// MainSplitContainer.Panel1
			// 
			this.MainSplitContainer.Panel1.Controls.Add(this.FromProjectionGroupBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.FromGeographicCoordsGroup);
			this.MainSplitContainer.Panel1.Controls.Add(this.FromEllipsoidGroup);
			this.MainSplitContainer.Panel1.Controls.Add(this.label1);
			this.MainSplitContainer.Panel1.Controls.Add(this.ConvertFromHeader);
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.Controls.Add(this.ToProjectionGroupBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.ToGeographicCoordsGroup);
			this.MainSplitContainer.Panel2.Controls.Add(this.ToEllipsoidGroup);
			this.MainSplitContainer.Panel2.Controls.Add(this.ConvertToList);
			this.MainSplitContainer.Panel2.Controls.Add(this.ConvertToHeader);
			this.MainSplitContainer.Size = new System.Drawing.Size(640, 511);
			this.MainSplitContainer.SplitterDistance = 250;
			this.MainSplitContainer.SplitterWidth = 140;
			this.MainSplitContainer.TabIndex = 0;
			// 
			// ConvertFromHeader
			// 
			this.ConvertFromHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ConvertFromHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConvertFromHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertFromHeader.Location = new System.Drawing.Point(0, 0);
			this.ConvertFromHeader.Name = "ConvertFromHeader";
			this.ConvertFromHeader.Size = new System.Drawing.Size(250, 23);
			this.ConvertFromHeader.TabIndex = 0;
			this.ConvertFromHeader.Text = "Convert From";
			this.ConvertFromHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ConvertToHeader
			// 
			this.ConvertToHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ConvertToHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConvertToHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertToHeader.Location = new System.Drawing.Point(0, 0);
			this.ConvertToHeader.Name = "ConvertToHeader";
			this.ConvertToHeader.Size = new System.Drawing.Size(250, 23);
			this.ConvertToHeader.TabIndex = 1;
			this.ConvertToHeader.Text = "Convert To";
			this.ConvertToHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ConvertToList
			// 
			this.ConvertToList.Dock = System.Windows.Forms.DockStyle.Top;
			this.ConvertToList.FormattingEnabled = true;
			this.ConvertToList.Location = new System.Drawing.Point(0, 23);
			this.ConvertToList.Name = "ConvertToList";
			this.ConvertToList.Size = new System.Drawing.Size(250, 21);
			this.ConvertToList.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 21);
			this.label1.TabIndex = 1;
			// 
			// FromEllipsoidGroup
			// 
			this.FromEllipsoidGroup.Controls.Add(this.FromInverseFlattening);
			this.FromEllipsoidGroup.Controls.Add(this.FromInverseFlatteningLabel);
			this.FromEllipsoidGroup.Controls.Add(this.FromSemiMajorTextBox);
			this.FromEllipsoidGroup.Controls.Add(this.FromSemiMajorAxisLabel);
			this.FromEllipsoidGroup.Controls.Add(this.FromEllipsoidNameTextBox);
			this.FromEllipsoidGroup.Controls.Add(this.FromEllipsoidNameLabel);
			this.FromEllipsoidGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.FromEllipsoidGroup.Location = new System.Drawing.Point(0, 44);
			this.FromEllipsoidGroup.Name = "FromEllipsoidGroup";
			this.FromEllipsoidGroup.Size = new System.Drawing.Size(250, 91);
			this.FromEllipsoidGroup.TabIndex = 2;
			this.FromEllipsoidGroup.TabStop = false;
			this.FromEllipsoidGroup.Text = "Geodetic Ellipsoid";
			// 
			// ToEllipsoidGroup
			// 
			this.ToEllipsoidGroup.Controls.Add(this.ToInverseFlattening);
			this.ToEllipsoidGroup.Controls.Add(this.ToInverseFlatteningLabel);
			this.ToEllipsoidGroup.Controls.Add(this.ToSemiMajorTextBox);
			this.ToEllipsoidGroup.Controls.Add(this.ToSemiMajorAxisLabel);
			this.ToEllipsoidGroup.Controls.Add(this.ToEllipsoidNameComboBox);
			this.ToEllipsoidGroup.Controls.Add(this.ToEllipsoidNameLabel);
			this.ToEllipsoidGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.ToEllipsoidGroup.Location = new System.Drawing.Point(0, 44);
			this.ToEllipsoidGroup.Name = "ToEllipsoidGroup";
			this.ToEllipsoidGroup.Size = new System.Drawing.Size(250, 91);
			this.ToEllipsoidGroup.TabIndex = 3;
			this.ToEllipsoidGroup.TabStop = false;
			this.ToEllipsoidGroup.Text = "Geodetic Ellipsoid";
			// 
			// FromEllipsoidNameLabel
			// 
			this.FromEllipsoidNameLabel.Location = new System.Drawing.Point(6, 17);
			this.FromEllipsoidNameLabel.Name = "FromEllipsoidNameLabel";
			this.FromEllipsoidNameLabel.Size = new System.Drawing.Size(100, 16);
			this.FromEllipsoidNameLabel.TabIndex = 0;
			this.FromEllipsoidNameLabel.Text = "Name:";
			this.FromEllipsoidNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ToEllipsoidNameLabel
			// 
			this.ToEllipsoidNameLabel.Location = new System.Drawing.Point(6, 17);
			this.ToEllipsoidNameLabel.Name = "ToEllipsoidNameLabel";
			this.ToEllipsoidNameLabel.Size = new System.Drawing.Size(97, 13);
			this.ToEllipsoidNameLabel.TabIndex = 1;
			this.ToEllipsoidNameLabel.Text = "Name:";
			this.ToEllipsoidNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FromEllipsoidNameTextBox
			// 
			this.FromEllipsoidNameTextBox.Enabled = false;
			this.FromEllipsoidNameTextBox.Location = new System.Drawing.Point(106, 14);
			this.FromEllipsoidNameTextBox.Name = "FromEllipsoidNameTextBox";
			this.FromEllipsoidNameTextBox.Size = new System.Drawing.Size(137, 20);
			this.FromEllipsoidNameTextBox.TabIndex = 1;
			// 
			// ToEllipsoidNameComboBox
			// 
			this.ToEllipsoidNameComboBox.FormattingEnabled = true;
			this.ToEllipsoidNameComboBox.Location = new System.Drawing.Point(106, 13);
			this.ToEllipsoidNameComboBox.Name = "ToEllipsoidNameComboBox";
			this.ToEllipsoidNameComboBox.Size = new System.Drawing.Size(137, 21);
			this.ToEllipsoidNameComboBox.TabIndex = 2;
			// 
			// FromSemiMajorAxisLabel
			// 
			this.FromSemiMajorAxisLabel.Location = new System.Drawing.Point(6, 39);
			this.FromSemiMajorAxisLabel.Name = "FromSemiMajorAxisLabel";
			this.FromSemiMajorAxisLabel.Size = new System.Drawing.Size(100, 13);
			this.FromSemiMajorAxisLabel.TabIndex = 2;
			this.FromSemiMajorAxisLabel.Text = "Semi-major Axis:";
			this.FromSemiMajorAxisLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FromSemiMajorTextBox
			// 
			this.FromSemiMajorTextBox.Enabled = false;
			this.FromSemiMajorTextBox.Location = new System.Drawing.Point(106, 36);
			this.FromSemiMajorTextBox.Name = "FromSemiMajorTextBox";
			this.FromSemiMajorTextBox.Size = new System.Drawing.Size(137, 20);
			this.FromSemiMajorTextBox.TabIndex = 3;
			// 
			// FromInverseFlatteningLabel
			// 
			this.FromInverseFlatteningLabel.Location = new System.Drawing.Point(6, 61);
			this.FromInverseFlatteningLabel.Name = "FromInverseFlatteningLabel";
			this.FromInverseFlatteningLabel.Size = new System.Drawing.Size(100, 13);
			this.FromInverseFlatteningLabel.TabIndex = 4;
			this.FromInverseFlatteningLabel.Text = "Inverse Flattening:";
			this.FromInverseFlatteningLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FromInverseFlattening
			// 
			this.FromInverseFlattening.Enabled = false;
			this.FromInverseFlattening.Location = new System.Drawing.Point(106, 58);
			this.FromInverseFlattening.Name = "FromInverseFlattening";
			this.FromInverseFlattening.Size = new System.Drawing.Size(137, 20);
			this.FromInverseFlattening.TabIndex = 5;
			// 
			// ToInverseFlattening
			// 
			this.ToInverseFlattening.Enabled = false;
			this.ToInverseFlattening.Location = new System.Drawing.Point(106, 58);
			this.ToInverseFlattening.Name = "ToInverseFlattening";
			this.ToInverseFlattening.Size = new System.Drawing.Size(137, 20);
			this.ToInverseFlattening.TabIndex = 9;
			// 
			// ToInverseFlatteningLabel
			// 
			this.ToInverseFlatteningLabel.Location = new System.Drawing.Point(6, 61);
			this.ToInverseFlatteningLabel.Name = "ToInverseFlatteningLabel";
			this.ToInverseFlatteningLabel.Size = new System.Drawing.Size(100, 13);
			this.ToInverseFlatteningLabel.TabIndex = 8;
			this.ToInverseFlatteningLabel.Text = "Inverse Flattening:";
			this.ToInverseFlatteningLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ToSemiMajorTextBox
			// 
			this.ToSemiMajorTextBox.Enabled = false;
			this.ToSemiMajorTextBox.Location = new System.Drawing.Point(106, 36);
			this.ToSemiMajorTextBox.Name = "ToSemiMajorTextBox";
			this.ToSemiMajorTextBox.Size = new System.Drawing.Size(137, 20);
			this.ToSemiMajorTextBox.TabIndex = 7;
			// 
			// ToSemiMajorAxisLabel
			// 
			this.ToSemiMajorAxisLabel.Location = new System.Drawing.Point(6, 39);
			this.ToSemiMajorAxisLabel.Name = "ToSemiMajorAxisLabel";
			this.ToSemiMajorAxisLabel.Size = new System.Drawing.Size(100, 13);
			this.ToSemiMajorAxisLabel.TabIndex = 6;
			this.ToSemiMajorAxisLabel.Text = "Semi-major Axis:";
			this.ToSemiMajorAxisLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FromGeographicCoordsGroup
			// 
			this.FromGeographicCoordsGroup.Controls.Add(this.textBox6);
			this.FromGeographicCoordsGroup.Controls.Add(this.label7);
			this.FromGeographicCoordsGroup.Controls.Add(this.textBox2);
			this.FromGeographicCoordsGroup.Controls.Add(this.label3);
			this.FromGeographicCoordsGroup.Controls.Add(this.textBox3);
			this.FromGeographicCoordsGroup.Controls.Add(this.label4);
			this.FromGeographicCoordsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.FromGeographicCoordsGroup.Location = new System.Drawing.Point(0, 135);
			this.FromGeographicCoordsGroup.Name = "FromGeographicCoordsGroup";
			this.FromGeographicCoordsGroup.Size = new System.Drawing.Size(250, 92);
			this.FromGeographicCoordsGroup.TabIndex = 3;
			this.FromGeographicCoordsGroup.TabStop = false;
			this.FromGeographicCoordsGroup.Text = "Geographic Coordinates";
			// 
			// ToGeographicCoordsGroup
			// 
			this.ToGeographicCoordsGroup.Controls.Add(this.textBox10);
			this.ToGeographicCoordsGroup.Controls.Add(this.label11);
			this.ToGeographicCoordsGroup.Controls.Add(this.textBox1);
			this.ToGeographicCoordsGroup.Controls.Add(this.label2);
			this.ToGeographicCoordsGroup.Controls.Add(this.textBox4);
			this.ToGeographicCoordsGroup.Controls.Add(this.label5);
			this.ToGeographicCoordsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.ToGeographicCoordsGroup.Location = new System.Drawing.Point(0, 135);
			this.ToGeographicCoordsGroup.Name = "ToGeographicCoordsGroup";
			this.ToGeographicCoordsGroup.Size = new System.Drawing.Size(250, 92);
			this.ToGeographicCoordsGroup.TabIndex = 4;
			this.ToGeographicCoordsGroup.TabStop = false;
			this.ToGeographicCoordsGroup.Text = "Geographic Coordinates";
			// 
			// FromProjectionGroupBox
			// 
			this.FromProjectionGroupBox.Controls.Add(this.dataGridView1);
			this.FromProjectionGroupBox.Controls.Add(this.textBox9);
			this.FromProjectionGroupBox.Controls.Add(this.label10);
			this.FromProjectionGroupBox.Controls.Add(this.textBox5);
			this.FromProjectionGroupBox.Controls.Add(this.label6);
			this.FromProjectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FromProjectionGroupBox.Location = new System.Drawing.Point(0, 227);
			this.FromProjectionGroupBox.Name = "FromProjectionGroupBox";
			this.FromProjectionGroupBox.Size = new System.Drawing.Size(250, 284);
			this.FromProjectionGroupBox.TabIndex = 4;
			this.FromProjectionGroupBox.TabStop = false;
			this.FromProjectionGroupBox.Text = "Projection";
			// 
			// ToProjectionGroupBox
			// 
			this.ToProjectionGroupBox.Controls.Add(this.dataGridView2);
			this.ToProjectionGroupBox.Controls.Add(this.textBox7);
			this.ToProjectionGroupBox.Controls.Add(this.label8);
			this.ToProjectionGroupBox.Controls.Add(this.textBox8);
			this.ToProjectionGroupBox.Controls.Add(this.label9);
			this.ToProjectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToProjectionGroupBox.Location = new System.Drawing.Point(0, 227);
			this.ToProjectionGroupBox.Name = "ToProjectionGroupBox";
			this.ToProjectionGroupBox.Size = new System.Drawing.Size(250, 284);
			this.ToProjectionGroupBox.TabIndex = 5;
			this.ToProjectionGroupBox.TabStop = false;
			this.ToProjectionGroupBox.Text = "Projection";
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(107, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(137, 20);
			this.textBox2.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Prime Meridian:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(107, 18);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(137, 20);
			this.textBox3.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Angular Unit:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(107, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(137, 20);
			this.textBox1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Prime Meridian:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(107, 18);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(137, 20);
			this.textBox4.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Angular Unit:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox5
			// 
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(106, 41);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(137, 20);
			this.textBox5.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Coord Transform:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox9
			// 
			this.textBox9.Enabled = false;
			this.textBox9.Location = new System.Drawing.Point(106, 19);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(137, 20);
			this.textBox9.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Linear Unit:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox6
			// 
			this.textBox6.Enabled = false;
			this.textBox6.Location = new System.Drawing.Point(107, 62);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(137, 20);
			this.textBox6.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Origin Latitude:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterNameColumn,
            this.ParameterValueColumn});
			this.dataGridView1.Location = new System.Drawing.Point(4, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(239, 205);
			this.dataGridView1.TabIndex = 18;
			// 
			// textBox7
			// 
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(110, 18);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(137, 20);
			this.textBox7.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 21;
			this.label8.Text = "Linear Unit:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox8
			// 
			this.textBox8.Enabled = false;
			this.textBox8.Location = new System.Drawing.Point(110, 40);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(137, 20);
			this.textBox8.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 19;
			this.label9.Text = "Coord Transform:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ParameterNameColumn
			// 
			this.ParameterNameColumn.HeaderText = "Parameter Name";
			this.ParameterNameColumn.Name = "ParameterNameColumn";
			this.ParameterNameColumn.ReadOnly = true;
			this.ParameterNameColumn.Width = 110;
			// 
			// ParameterValueColumn
			// 
			this.ParameterValueColumn.HeaderText = "Parameter Value";
			this.ParameterValueColumn.Name = "ParameterValueColumn";
			this.ParameterValueColumn.ReadOnly = true;
			this.ParameterValueColumn.Width = 124;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1,
            this.dataGridViewTextBoxColumn1});
			this.dataGridView2.Location = new System.Drawing.Point(8, 67);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.Size = new System.Drawing.Size(239, 205);
			this.dataGridView2.TabIndex = 23;
			// 
			// dataGridViewLinkColumn1
			// 
			this.dataGridViewLinkColumn1.HeaderText = "Parameter Name";
			this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
			this.dataGridViewLinkColumn1.ReadOnly = true;
			this.dataGridViewLinkColumn1.Width = 110;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Parameter Value";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 124;
			// 
			// textBox10
			// 
			this.textBox10.Enabled = false;
			this.textBox10.Location = new System.Drawing.Point(107, 62);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(137, 20);
			this.textBox10.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 65);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 14;
			this.label11.Text = "Origin Latitude:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ConvertProjectionAndCoordinatesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 511);
			this.Controls.Add(this.MainSplitContainer);
			this.MaximumSize = new System.Drawing.Size(648, 10000);
			this.MinimumSize = new System.Drawing.Size(648, 0);
			this.Name = "ConvertProjectionAndCoordinatesForm";
			this.Text = "Projection Conversion";
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			this.MainSplitContainer.ResumeLayout(false);
			this.FromEllipsoidGroup.ResumeLayout(false);
			this.FromEllipsoidGroup.PerformLayout();
			this.ToEllipsoidGroup.ResumeLayout(false);
			this.ToEllipsoidGroup.PerformLayout();
			this.FromGeographicCoordsGroup.ResumeLayout(false);
			this.FromGeographicCoordsGroup.PerformLayout();
			this.ToGeographicCoordsGroup.ResumeLayout(false);
			this.ToGeographicCoordsGroup.PerformLayout();
			this.FromProjectionGroupBox.ResumeLayout(false);
			this.FromProjectionGroupBox.PerformLayout();
			this.ToProjectionGroupBox.ResumeLayout(false);
			this.ToProjectionGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer MainSplitContainer;
		private System.Windows.Forms.Label ConvertFromHeader;
		private System.Windows.Forms.Label ConvertToHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ConvertToList;
		private System.Windows.Forms.GroupBox FromEllipsoidGroup;
		private System.Windows.Forms.GroupBox ToEllipsoidGroup;
		private System.Windows.Forms.Label FromEllipsoidNameLabel;
		private System.Windows.Forms.Label ToEllipsoidNameLabel;
		private System.Windows.Forms.TextBox FromEllipsoidNameTextBox;
		private System.Windows.Forms.ComboBox ToEllipsoidNameComboBox;
		private System.Windows.Forms.TextBox FromInverseFlattening;
		private System.Windows.Forms.Label FromInverseFlatteningLabel;
		private System.Windows.Forms.TextBox FromSemiMajorTextBox;
		private System.Windows.Forms.Label FromSemiMajorAxisLabel;
		private System.Windows.Forms.TextBox ToInverseFlattening;
		private System.Windows.Forms.Label ToInverseFlatteningLabel;
		private System.Windows.Forms.TextBox ToSemiMajorTextBox;
		private System.Windows.Forms.Label ToSemiMajorAxisLabel;
		private System.Windows.Forms.GroupBox FromGeographicCoordsGroup;
		private System.Windows.Forms.GroupBox FromProjectionGroupBox;
		private System.Windows.Forms.GroupBox ToGeographicCoordsGroup;
		private System.Windows.Forms.GroupBox ToProjectionGroupBox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewLinkColumn ParameterNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ParameterValueColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label11;

	}
}