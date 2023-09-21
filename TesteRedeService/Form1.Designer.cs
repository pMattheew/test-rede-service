namespace TesteRedeService
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			displayInput = new Label();
			numericUpDown1 = new NumericUpDown();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			label2 = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 19);
			label1.Name = "label1";
			label1.Size = new Size(346, 15);
			label1.TabIndex = 1;
			label1.Text = "Insira um número entre 0 e 1000. Pressione Enter para confirmar.";
			// 
			// displayInput
			// 
			displayInput.AutoSize = true;
			displayInput.Location = new Point(12, 63);
			displayInput.Name = "displayInput";
			displayInput.Size = new Size(0, 15);
			displayInput.TabIndex = 2;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(12, 37);
			numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 23);
			numericUpDown1.TabIndex = 3;
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 105);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(274, 395);
			dataGridView1.TabIndex = 4;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(292, 105);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(412, 287);
			dataGridView2.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 87);
			label2.Name = "label2";
			label2.Size = new Size(99, 15);
			label2.TabIndex = 6;
			label2.Text = "Lista de 'clsTeste':";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(292, 87);
			label3.Name = "label3";
			label3.Size = new Size(91, 15);
			label3.TabIndex = 7;
			label3.Text = "Lista de bancos:";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.LightSteelBlue;
			pictureBox1.Location = new Point(462, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(242, 80);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			pictureBox1.WaitOnLoad = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1184, 450);
			Controls.Add(pictureBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dataGridView2);
			Controls.Add(dataGridView1);
			Controls.Add(numericUpDown1);
			Controls.Add(displayInput);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private Label displayInput;
		private NumericUpDown numericUpDown1;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
		private Label label2;
		private Label label3;
		private PictureBox pictureBox1;
	}
}