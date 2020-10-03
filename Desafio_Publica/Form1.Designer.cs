namespace Desafio_Publica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPontos = new System.Windows.Forms.ListView();
            this.columnJogos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlacar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecordeMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecordeMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtplacar = new System.Windows.Forms.TextBox();
            this.txtJogo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_minTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maxTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabela de Pontos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewPontos
            // 
            this.listViewPontos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnJogos,
            this.columnPlacar,
            this.columnTemp,
            this.columnMax,
            this.columnRecordeMin,
            this.columnRecordeMax});
            this.listViewPontos.FullRowSelect = true;
            this.listViewPontos.GridLines = true;
            this.listViewPontos.HideSelection = false;
            this.listViewPontos.Location = new System.Drawing.Point(13, 184);
            this.listViewPontos.Name = "listViewPontos";
            this.listViewPontos.Size = new System.Drawing.Size(802, 350);
            this.listViewPontos.TabIndex = 3;
            this.listViewPontos.UseCompatibleStateImageBehavior = false;
            this.listViewPontos.View = System.Windows.Forms.View.Details;
            // 
            // columnJogos
            // 
            this.columnJogos.Text = "Jogos";
            this.columnJogos.Width = 80;
            // 
            // columnPlacar
            // 
            this.columnPlacar.Text = "Placar";
            this.columnPlacar.Width = 65;
            // 
            // columnTemp
            // 
            this.columnTemp.Text = "Mínimo da temp";
            this.columnTemp.Width = 125;
            // 
            // columnMax
            // 
            this.columnMax.Text = "Máximo da Temp";
            this.columnMax.Width = 141;
            // 
            // columnRecordeMin
            // 
            this.columnRecordeMin.Text = "Quebra de Recorde Mín.";
            this.columnRecordeMin.Width = 217;
            // 
            // columnRecordeMax
            // 
            this.columnRecordeMax.Text = "Quebra Recorde Máx.";
            this.columnRecordeMax.Width = 191;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(826, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jogo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(821, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placar:";
            // 
            // txtplacar
            // 
            this.txtplacar.Location = new System.Drawing.Point(826, 297);
            this.txtplacar.Name = "txtplacar";
            this.txtplacar.Size = new System.Drawing.Size(182, 26);
            this.txtplacar.TabIndex = 7;
            // 
            // txtJogo
            // 
            this.txtJogo.Location = new System.Drawing.Point(826, 189);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(182, 26);
            this.txtJogo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(802, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mínimo da Temporada:";
            // 
            // txt_minTemp
            // 
            this.txt_minTemp.Location = new System.Drawing.Point(826, 396);
            this.txt_minTemp.Name = "txt_minTemp";
            this.txt_minTemp.Size = new System.Drawing.Size(182, 26);
            this.txt_minTemp.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Máximo da Temporada:";
            // 
            // txt_maxTemp
            // 
            this.txt_maxTemp.Location = new System.Drawing.Point(827, 485);
            this.txt_maxTemp.Name = "txt_maxTemp";
            this.txt_maxTemp.Size = new System.Drawing.Size(181, 26);
            this.txt_maxTemp.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 583);
            this.Controls.Add(this.txt_maxTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_minTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.txtplacar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPontos;
        private System.Windows.Forms.ColumnHeader columnJogos;
        private System.Windows.Forms.ColumnHeader columnPlacar;
        private System.Windows.Forms.ColumnHeader columnTemp;
        private System.Windows.Forms.ColumnHeader columnMax;
        private System.Windows.Forms.ColumnHeader columnRecordeMin;
        private System.Windows.Forms.ColumnHeader columnRecordeMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtplacar;
        private System.Windows.Forms.TextBox txtJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_minTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maxTemp;
    }
}

