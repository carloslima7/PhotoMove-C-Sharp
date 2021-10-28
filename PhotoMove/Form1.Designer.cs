namespace PhotoMove
{
    partial class PhotoMove
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
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.fonte = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Destino = new System.Windows.Forms.TextBox();
            this.excel = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Origem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Selecionar});
            this.data.Location = new System.Drawing.Point(12, 123);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(544, 319);
            this.data.TabIndex = 1;
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagem.Width = 400;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fonte
            // 
            this.fonte.Location = new System.Drawing.Point(12, 12);
            this.fonte.Name = "fonte";
            this.fonte.ReadOnly = true;
            this.fonte.Size = new System.Drawing.Size(439, 20);
            this.fonte.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Destino";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(12, 38);
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Size = new System.Drawing.Size(439, 20);
            this.Destino.TabIndex = 5;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(12, 68);
            this.excel.Name = "excel";
            this.excel.ReadOnly = true;
            this.excel.Size = new System.Drawing.Size(439, 20);
            this.excel.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(481, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 454);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fonte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "PhotoMove";
            this.Text = "Photo Move";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fonte;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.TextBox excel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

