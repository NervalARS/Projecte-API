namespace M15_ProjecteConsumidor_APIGenius
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.tb_idArtist = new System.Windows.Forms.TextBox();
            this.lb_filter = new System.Windows.Forms.Label();
            this.lb_idArtist = new System.Windows.Forms.Label();
            this.btn_idArtist = new System.Windows.Forms.Button();
            this.lb_songs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(456, 58);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(272, 20);
            this.tb_filter.TabIndex = 1;
            // 
            // tb_idArtist
            // 
            this.tb_idArtist.Location = new System.Drawing.Point(687, 107);
            this.tb_idArtist.Name = "tb_idArtist";
            this.tb_idArtist.Size = new System.Drawing.Size(41, 20);
            this.tb_idArtist.TabIndex = 2;
            // 
            // lb_filter
            // 
            this.lb_filter.AutoSize = true;
            this.lb_filter.Location = new System.Drawing.Point(421, 61);
            this.lb_filter.Name = "lb_filter";
            this.lb_filter.Size = new System.Drawing.Size(29, 13);
            this.lb_filter.TabIndex = 3;
            this.lb_filter.Text = "Filtro";
            this.lb_filter.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_idArtist
            // 
            this.lb_idArtist.AutoSize = true;
            this.lb_idArtist.Location = new System.Drawing.Point(633, 110);
            this.lb_idArtist.Name = "lb_idArtist";
            this.lb_idArtist.Size = new System.Drawing.Size(48, 13);
            this.lb_idArtist.TabIndex = 4;
            this.lb_idArtist.Text = "Id Artista";
            // 
            // btn_idArtist
            // 
            this.btn_idArtist.Location = new System.Drawing.Point(653, 133);
            this.btn_idArtist.Name = "btn_idArtist";
            this.btn_idArtist.Size = new System.Drawing.Size(75, 23);
            this.btn_idArtist.TabIndex = 5;
            this.btn_idArtist.Text = "Buscar";
            this.btn_idArtist.UseVisualStyleBackColor = true;
            this.btn_idArtist.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_songs
            // 
            this.lb_songs.AutoSize = true;
            this.lb_songs.Location = new System.Drawing.Point(31, 39);
            this.lb_songs.Name = "lb_songs";
            this.lb_songs.Size = new System.Drawing.Size(97, 13);
            this.lb_songs.TabIndex = 6;
            this.lb_songs.Text = "Lista de Canciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_songs);
            this.Controls.Add(this.btn_idArtist);
            this.Controls.Add(this.lb_idArtist);
            this.Controls.Add(this.lb_filter);
            this.Controls.Add(this.tb_idArtist);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.TextBox tb_idArtist;
        private System.Windows.Forms.Label lb_filter;
        private System.Windows.Forms.Label lb_idArtist;
        private System.Windows.Forms.Button btn_idArtist;
        private System.Windows.Forms.Label lb_songs;
    }
}

