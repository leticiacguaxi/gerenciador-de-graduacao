namespace Biblioteca0._1
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
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.tbDisciplina = new System.Windows.Forms.TextBox();
            this.tbUnidade = new System.Windows.Forms.TextBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.tbAula = new System.Windows.Forms.TextBox();
            this.btCriarPastas = new System.Windows.Forms.Button();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(45, 43);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 5;
            this.lblSemestre.Text = "Semestre";
            this.lblSemestre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(44, 72);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 6;
            this.lblDisciplina.Text = "Disciplina";
            this.lblDisciplina.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(44, 100);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 7;
            this.lblUnidade.Text = "Unidade";
            // 
            // tbDisciplina
            // 
            this.tbDisciplina.Location = new System.Drawing.Point(102, 65);
            this.tbDisciplina.Name = "tbDisciplina";
            this.tbDisciplina.Size = new System.Drawing.Size(262, 20);
            this.tbDisciplina.TabIndex = 1;
            this.tbDisciplina.TextChanged += new System.EventHandler(this.tbDisciplina_TextChanged);
            // 
            // tbUnidade
            // 
            this.tbUnidade.Location = new System.Drawing.Point(102, 93);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.Size = new System.Drawing.Size(262, 20);
            this.tbUnidade.TabIndex = 2;
            this.tbUnidade.TextChanged += new System.EventHandler(this.tbUnidade_TextChanged);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(44, 129);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(28, 13);
            this.lblAula.TabIndex = 8;
            this.lblAula.Text = "Aula";
            // 
            // tbAula
            // 
            this.tbAula.Location = new System.Drawing.Point(102, 122);
            this.tbAula.Name = "tbAula";
            this.tbAula.Size = new System.Drawing.Size(262, 20);
            this.tbAula.TabIndex = 3;
            this.tbAula.TextChanged += new System.EventHandler(this.tbAula_TextChanged);
            // 
            // btCriarPastas
            // 
            this.btCriarPastas.Location = new System.Drawing.Point(164, 164);
            this.btCriarPastas.Name = "btCriarPastas";
            this.btCriarPastas.Size = new System.Drawing.Size(75, 23);
            this.btCriarPastas.TabIndex = 4;
            this.btCriarPastas.Text = "Criar Pastas";
            this.btCriarPastas.UseVisualStyleBackColor = true;
            this.btCriarPastas.Click += new System.EventHandler(this.btCriarPastas_Click);
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1º Semestre",
            "2º Semestre",
            "3º Semestre",
            "4º Semestre",
            "5º Semestre",
            "Extra"});
            this.cbSemestre.Location = new System.Drawing.Point(102, 35);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cbSemestre.TabIndex = 0;
            this.cbSemestre.SelectedIndexChanged += new System.EventHandler(this.cbSemestre_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.btCriarPastas);
            this.Controls.Add(this.tbAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.tbUnidade);
            this.Controls.Add(this.tbDisciplina);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblSemestre);
            this.MaximumSize = new System.Drawing.Size(450, 250);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador da Graduação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox tbDisciplina;
        private System.Windows.Forms.TextBox tbUnidade;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox tbAula;
        private System.Windows.Forms.Button btCriarPastas;
        private System.Windows.Forms.ComboBox cbSemestre;
    }
}

