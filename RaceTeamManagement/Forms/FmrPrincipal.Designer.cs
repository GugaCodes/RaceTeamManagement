namespace RaceTeamManagement
{
    partial class FmrPrincipal
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
            this.btn_GerenciaEquipe = new System.Windows.Forms.Button();
            this.btn_gerenciarPilotos = new System.Windows.Forms.Button();
            this.btn_GerenciaCarro = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GerenciaEquipe
            // 
            this.btn_GerenciaEquipe.BackColor = System.Drawing.Color.Transparent;
            this.btn_GerenciaEquipe.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_GerenciaEquipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_GerenciaEquipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GerenciaEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerenciaEquipe.ForeColor = System.Drawing.Color.Transparent;
            this.btn_GerenciaEquipe.Location = new System.Drawing.Point(118, 354);
            this.btn_GerenciaEquipe.Name = "btn_GerenciaEquipe";
            this.btn_GerenciaEquipe.Size = new System.Drawing.Size(635, 105);
            this.btn_GerenciaEquipe.TabIndex = 0;
            this.btn_GerenciaEquipe.UseVisualStyleBackColor = false;
            this.btn_GerenciaEquipe.Click += new System.EventHandler(this.btn_GerenciaEquipe_Click);
            // 
            // btn_gerenciarPilotos
            // 
            this.btn_gerenciarPilotos.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerenciarPilotos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_gerenciarPilotos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_gerenciarPilotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_gerenciarPilotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarPilotos.Location = new System.Drawing.Point(118, 474);
            this.btn_gerenciarPilotos.Name = "btn_gerenciarPilotos";
            this.btn_gerenciarPilotos.Size = new System.Drawing.Size(635, 105);
            this.btn_gerenciarPilotos.TabIndex = 1;
            this.btn_gerenciarPilotos.UseVisualStyleBackColor = false;
            // 
            // btn_GerenciaCarro
            // 
            this.btn_GerenciaCarro.BackColor = System.Drawing.Color.Transparent;
            this.btn_GerenciaCarro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_GerenciaCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_GerenciaCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GerenciaCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerenciaCarro.Location = new System.Drawing.Point(118, 590);
            this.btn_GerenciaCarro.Name = "btn_GerenciaCarro";
            this.btn_GerenciaCarro.Size = new System.Drawing.Size(635, 105);
            this.btn_GerenciaCarro.TabIndex = 2;
            this.btn_GerenciaCarro.UseVisualStyleBackColor = false;
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btn_DashBoard.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_DashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DashBoard.Location = new System.Drawing.Point(118, 711);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(635, 105);
            this.btn_DashBoard.TabIndex = 3;
            this.btn_DashBoard.UseVisualStyleBackColor = false;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Location = new System.Drawing.Point(118, 833);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(635, 105);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaceTeamManagement.Properties.Resources.Tela_Inicial;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_DashBoard);
            this.Controls.Add(this.btn_GerenciaCarro);
            this.Controls.Add(this.btn_gerenciarPilotos);
            this.Controls.Add(this.btn_GerenciaEquipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaceTeamManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GerenciaEquipe;
        private System.Windows.Forms.Button btn_gerenciarPilotos;
        private System.Windows.Forms.Button btn_GerenciaCarro;
        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.Button btn_Sair;
    }
}

