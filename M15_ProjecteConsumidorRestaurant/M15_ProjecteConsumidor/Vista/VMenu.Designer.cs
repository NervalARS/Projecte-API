
namespace M15_ProjecteConsumidor.Vista
{
    partial class VMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.MEN_Nom = new System.Windows.Forms.Label();
            this.RES_Title1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.BT_EXIT);
            this.panel1.Controls.Add(this.MEN_Nom);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 53);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.AllowDrop = true;
            this.BT_EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(120)))), ((int)(((byte)(101)))));
            this.BT_EXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_EXIT.FlatAppearance.BorderSize = 0;
            this.BT_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EXIT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_EXIT.ForeColor = System.Drawing.Color.White;
            this.BT_EXIT.Location = new System.Drawing.Point(488, 9);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(221, 36);
            this.BT_EXIT.TabIndex = 48;
            this.BT_EXIT.Text = "Volver a Inicio";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            // 
            // MEN_Nom
            // 
            this.MEN_Nom.AutoSize = true;
            this.MEN_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEN_Nom.ForeColor = System.Drawing.Color.White;
            this.MEN_Nom.Location = new System.Drawing.Point(13, 15);
            this.MEN_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MEN_Nom.Name = "MEN_Nom";
            this.MEN_Nom.Size = new System.Drawing.Size(95, 31);
            this.MEN_Nom.TabIndex = 0;
            this.MEN_Nom.Text = "Menus";
            this.MEN_Nom.Click += new System.EventHandler(this.MEN_Nom_Click);
            // 
            // RES_Title1
            // 
            this.RES_Title1.AutoSize = true;
            this.RES_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Title1.Location = new System.Drawing.Point(13, 13);
            this.RES_Title1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RES_Title1.Name = "RES_Title1";
            this.RES_Title1.Size = new System.Drawing.Size(195, 25);
            this.RES_Title1.TabIndex = 37;
            this.RES_Title1.Text = "Elementos del menu:";
            this.RES_Title1.Click += new System.EventHandler(this.RES_Title1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.RES_Title1);
            this.panel3.Location = new System.Drawing.Point(-1, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 458);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 194);
            this.panel2.TabIndex = 45;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(417, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(246, 87);
            this.label4.TabIndex = 47;
            this.label4.Text = "0.00€";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MaximumSize = new System.Drawing.Size(200, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Descripción:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.VMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label MEN_Nom;
        public System.Windows.Forms.Label RES_Title1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BT_EXIT;
    }
}