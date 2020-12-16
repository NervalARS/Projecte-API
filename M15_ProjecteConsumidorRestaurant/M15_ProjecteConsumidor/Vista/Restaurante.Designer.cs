
namespace M15_ProjecteConsumidor.Vista
{
    partial class Restaurante
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
            this.RES_LastMod = new System.Windows.Forms.Label();
            this.RES_Nom_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RES_BT_ShowMenu = new System.Windows.Forms.Button();
            this.RES_Title2 = new System.Windows.Forms.Label();
            this.RES_GMAP = new GMap.NET.WindowsForms.GMapControl();
            this.RES_DGV_Menus = new System.Windows.Forms.DataGridView();
            this.RES_BT_VolverInicio = new System.Windows.Forms.Button();
            this.RES_BT_AddFav = new System.Windows.Forms.Button();
            this.RES_Title4 = new System.Windows.Forms.Label();
            this.RES_Title3 = new System.Windows.Forms.Label();
            this.RES_Horas = new System.Windows.Forms.Label();
            this.RES_TipoMoneda = new System.Windows.Forms.Label();
            this.RES_Direccion = new System.Windows.Forms.Label();
            this.RES_Telefon = new System.Windows.Forms.Label();
            this.RES_ListBoxDeTipoCocina = new System.Windows.Forms.ListBox();
            this.RES_Title1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RES_DGV_Menus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.RES_LastMod);
            this.panel1.Controls.Add(this.RES_Nom_ID);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 62);
            this.panel1.TabIndex = 0;
            // 
            // RES_LastMod
            // 
            this.RES_LastMod.AutoSize = true;
            this.RES_LastMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_LastMod.ForeColor = System.Drawing.Color.White;
            this.RES_LastMod.Location = new System.Drawing.Point(885, 20);
            this.RES_LastMod.Name = "RES_LastMod";
            this.RES_LastMod.Size = new System.Drawing.Size(182, 20);
            this.RES_LastMod.TabIndex = 13;
            this.RES_LastMod.Text = "<<Ultima modificacion>>";
            // 
            // RES_Nom_ID
            // 
            this.RES_Nom_ID.AutoSize = true;
            this.RES_Nom_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Nom_ID.ForeColor = System.Drawing.Color.White;
            this.RES_Nom_ID.Location = new System.Drawing.Point(9, 8);
            this.RES_Nom_ID.Name = "RES_Nom_ID";
            this.RES_Nom_ID.Size = new System.Drawing.Size(321, 46);
            this.RES_Nom_ID.TabIndex = 0;
            this.RES_Nom_ID.Text = "Nom Restaurant:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.RES_Title1);
            this.panel2.Controls.Add(this.RES_BT_ShowMenu);
            this.panel2.Controls.Add(this.RES_ListBoxDeTipoCocina);
            this.panel2.Controls.Add(this.RES_Telefon);
            this.panel2.Controls.Add(this.RES_Title2);
            this.panel2.Controls.Add(this.RES_Direccion);
            this.panel2.Controls.Add(this.RES_GMAP);
            this.panel2.Controls.Add(this.RES_TipoMoneda);
            this.panel2.Controls.Add(this.RES_DGV_Menus);
            this.panel2.Controls.Add(this.RES_Horas);
            this.panel2.Controls.Add(this.RES_BT_VolverInicio);
            this.panel2.Controls.Add(this.RES_BT_AddFav);
            this.panel2.Controls.Add(this.RES_Title3);
            this.panel2.Controls.Add(this.RES_Title4);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 1012);
            this.panel2.TabIndex = 1;
            // 
            // RES_BT_ShowMenu
            // 
            this.RES_BT_ShowMenu.AllowDrop = true;
            this.RES_BT_ShowMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RES_BT_ShowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_ShowMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_ShowMenu.FlatAppearance.BorderSize = 0;
            this.RES_BT_ShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RES_BT_ShowMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RES_BT_ShowMenu.ForeColor = System.Drawing.Color.White;
            this.RES_BT_ShowMenu.Location = new System.Drawing.Point(602, 369);
            this.RES_BT_ShowMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RES_BT_ShowMenu.Name = "RES_BT_ShowMenu";
            this.RES_BT_ShowMenu.Size = new System.Drawing.Size(447, 55);
            this.RES_BT_ShowMenu.TabIndex = 40;
            this.RES_BT_ShowMenu.Text = "Abrir Menu";
            this.RES_BT_ShowMenu.UseVisualStyleBackColor = false;
            // 
            // RES_Title2
            // 
            this.RES_Title2.AutoSize = true;
            this.RES_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Title2.ForeColor = System.Drawing.Color.Black;
            this.RES_Title2.Location = new System.Drawing.Point(594, 29);
            this.RES_Title2.Name = "RES_Title2";
            this.RES_Title2.Size = new System.Drawing.Size(90, 36);
            this.RES_Title2.TabIndex = 39;
            this.RES_Title2.Text = "Menu";
            // 
            // RES_GMAP
            // 
            this.RES_GMAP.Bearing = 0F;
            this.RES_GMAP.CanDragMap = true;
            this.RES_GMAP.EmptyTileColor = System.Drawing.Color.Navy;
            this.RES_GMAP.GrayScaleMode = false;
            this.RES_GMAP.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.RES_GMAP.LevelsKeepInMemory = 5;
            this.RES_GMAP.Location = new System.Drawing.Point(32, 525);
            this.RES_GMAP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RES_GMAP.MarkersEnabled = true;
            this.RES_GMAP.MaxZoom = 2;
            this.RES_GMAP.MinZoom = 2;
            this.RES_GMAP.MouseWheelZoomEnabled = true;
            this.RES_GMAP.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.RES_GMAP.Name = "RES_GMAP";
            this.RES_GMAP.NegativeMode = false;
            this.RES_GMAP.PolygonsEnabled = true;
            this.RES_GMAP.RetryLoadTile = 0;
            this.RES_GMAP.RoutesEnabled = true;
            this.RES_GMAP.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.RES_GMAP.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.RES_GMAP.ShowTileGridLines = false;
            this.RES_GMAP.Size = new System.Drawing.Size(1017, 397);
            this.RES_GMAP.TabIndex = 39;
            this.RES_GMAP.Zoom = 0D;
            // 
            // RES_DGV_Menus
            // 
            this.RES_DGV_Menus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.RES_DGV_Menus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RES_DGV_Menus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RES_DGV_Menus.Location = new System.Drawing.Point(602, 71);
            this.RES_DGV_Menus.Name = "RES_DGV_Menus";
            this.RES_DGV_Menus.RowHeadersWidth = 62;
            this.RES_DGV_Menus.RowTemplate.Height = 28;
            this.RES_DGV_Menus.Size = new System.Drawing.Size(447, 291);
            this.RES_DGV_Menus.TabIndex = 38;
            // 
            // RES_BT_VolverInicio
            // 
            this.RES_BT_VolverInicio.AllowDrop = true;
            this.RES_BT_VolverInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RES_BT_VolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_VolverInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_VolverInicio.FlatAppearance.BorderSize = 0;
            this.RES_BT_VolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RES_BT_VolverInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RES_BT_VolverInicio.ForeColor = System.Drawing.Color.White;
            this.RES_BT_VolverInicio.Location = new System.Drawing.Point(822, 931);
            this.RES_BT_VolverInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RES_BT_VolverInicio.Name = "RES_BT_VolverInicio";
            this.RES_BT_VolverInicio.Size = new System.Drawing.Size(226, 55);
            this.RES_BT_VolverInicio.TabIndex = 29;
            this.RES_BT_VolverInicio.Text = "Volver a Inicio";
            this.RES_BT_VolverInicio.UseVisualStyleBackColor = false;
            this.RES_BT_VolverInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // RES_BT_AddFav
            // 
            this.RES_BT_AddFav.AllowDrop = true;
            this.RES_BT_AddFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RES_BT_AddFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_AddFav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.RES_BT_AddFav.FlatAppearance.BorderSize = 0;
            this.RES_BT_AddFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RES_BT_AddFav.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RES_BT_AddFav.ForeColor = System.Drawing.Color.White;
            this.RES_BT_AddFav.Location = new System.Drawing.Point(32, 931);
            this.RES_BT_AddFav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RES_BT_AddFav.Name = "RES_BT_AddFav";
            this.RES_BT_AddFav.Size = new System.Drawing.Size(348, 55);
            this.RES_BT_AddFav.TabIndex = 38;
            this.RES_BT_AddFav.Text = "Añadir Restaurante a Favoritos";
            this.RES_BT_AddFav.UseVisualStyleBackColor = false;
            this.RES_BT_AddFav.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RES_Title4
            // 
            this.RES_Title4.AutoSize = true;
            this.RES_Title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Title4.Location = new System.Drawing.Point(24, 482);
            this.RES_Title4.Name = "RES_Title4";
            this.RES_Title4.Size = new System.Drawing.Size(189, 36);
            this.RES_Title4.TabIndex = 26;
            this.RES_Title4.Text = "Localizacion:";
            this.RES_Title4.Click += new System.EventHandler(this.RES_Title4_Click);
            // 
            // RES_Title3
            // 
            this.RES_Title3.AutoSize = true;
            this.RES_Title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Title3.ForeColor = System.Drawing.Color.Black;
            this.RES_Title3.Location = new System.Drawing.Point(31, 243);
            this.RES_Title3.Name = "RES_Title3";
            this.RES_Title3.Size = new System.Drawing.Size(218, 36);
            this.RES_Title3.TabIndex = 45;
            this.RES_Title3.Text = "Tipo de cocina:";
            this.RES_Title3.Click += new System.EventHandler(this.RES_Title3_Click_1);
            // 
            // RES_Horas
            // 
            this.RES_Horas.AutoSize = true;
            this.RES_Horas.BackColor = System.Drawing.Color.Transparent;
            this.RES_Horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Horas.ForeColor = System.Drawing.Color.Black;
            this.RES_Horas.Location = new System.Drawing.Point(61, 111);
            this.RES_Horas.Name = "RES_Horas";
            this.RES_Horas.Size = new System.Drawing.Size(64, 25);
            this.RES_Horas.TabIndex = 43;
            this.RES_Horas.Text = "Horas";
            this.RES_Horas.Click += new System.EventHandler(this.RES_Horas_Click);
            // 
            // RES_TipoMoneda
            // 
            this.RES_TipoMoneda.AutoSize = true;
            this.RES_TipoMoneda.BackColor = System.Drawing.Color.Transparent;
            this.RES_TipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_TipoMoneda.ForeColor = System.Drawing.Color.Black;
            this.RES_TipoMoneda.Location = new System.Drawing.Point(60, 137);
            this.RES_TipoMoneda.Name = "RES_TipoMoneda";
            this.RES_TipoMoneda.Size = new System.Drawing.Size(164, 25);
            this.RES_TipoMoneda.TabIndex = 42;
            this.RES_TipoMoneda.Text = "Tipus de moneda";
            this.RES_TipoMoneda.Click += new System.EventHandler(this.RES_TipoMoneda_Click);
            // 
            // RES_Direccion
            // 
            this.RES_Direccion.AutoSize = true;
            this.RES_Direccion.BackColor = System.Drawing.Color.Transparent;
            this.RES_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Direccion.ForeColor = System.Drawing.Color.Black;
            this.RES_Direccion.Location = new System.Drawing.Point(60, 163);
            this.RES_Direccion.Name = "RES_Direccion";
            this.RES_Direccion.Size = new System.Drawing.Size(93, 25);
            this.RES_Direccion.TabIndex = 46;
            this.RES_Direccion.Text = "Direccion";
            this.RES_Direccion.Click += new System.EventHandler(this.RES_Direccion_Click);
            // 
            // RES_Telefon
            // 
            this.RES_Telefon.AutoSize = true;
            this.RES_Telefon.BackColor = System.Drawing.Color.Transparent;
            this.RES_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Telefon.ForeColor = System.Drawing.Color.Black;
            this.RES_Telefon.Location = new System.Drawing.Point(60, 83);
            this.RES_Telefon.Name = "RES_Telefon";
            this.RES_Telefon.Size = new System.Drawing.Size(78, 25);
            this.RES_Telefon.TabIndex = 41;
            this.RES_Telefon.Text = "Telefon";
            this.RES_Telefon.Click += new System.EventHandler(this.RES_Telefon_Click);
            // 
            // RES_ListBoxDeTipoCocina
            // 
            this.RES_ListBoxDeTipoCocina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.RES_ListBoxDeTipoCocina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RES_ListBoxDeTipoCocina.FormattingEnabled = true;
            this.RES_ListBoxDeTipoCocina.ItemHeight = 20;
            this.RES_ListBoxDeTipoCocina.Location = new System.Drawing.Point(65, 286);
            this.RES_ListBoxDeTipoCocina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RES_ListBoxDeTipoCocina.Name = "RES_ListBoxDeTipoCocina";
            this.RES_ListBoxDeTipoCocina.Size = new System.Drawing.Size(447, 160);
            this.RES_ListBoxDeTipoCocina.TabIndex = 47;
            this.RES_ListBoxDeTipoCocina.SelectedIndexChanged += new System.EventHandler(this.RES_ListBoxDeTipoCocina_SelectedIndexChanged);
            // 
            // RES_Title1
            // 
            this.RES_Title1.AutoSize = true;
            this.RES_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RES_Title1.ForeColor = System.Drawing.Color.Black;
            this.RES_Title1.Location = new System.Drawing.Point(31, 42);
            this.RES_Title1.Name = "RES_Title1";
            this.RES_Title1.Size = new System.Drawing.Size(213, 36);
            this.RES_Title1.TabIndex = 48;
            this.RES_Title1.Text = "Datos Básicos:";
            this.RES_Title1.Click += new System.EventHandler(this.RES_Title1_Click);
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 1065);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Restaurante";
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Restaurante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RES_DGV_Menus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RES_Nom_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RES_LastMod;
        private System.Windows.Forms.Button RES_BT_VolverInicio;
        private System.Windows.Forms.Button RES_BT_AddFav;
        private System.Windows.Forms.Label RES_Title4;
        private GMap.NET.WindowsForms.GMapControl RES_GMAP;
        private System.Windows.Forms.Button RES_BT_ShowMenu;
        private System.Windows.Forms.Label RES_Title2;
        private System.Windows.Forms.DataGridView RES_DGV_Menus;
        private System.Windows.Forms.Label RES_Title1;
        private System.Windows.Forms.ListBox RES_ListBoxDeTipoCocina;
        private System.Windows.Forms.Label RES_Telefon;
        private System.Windows.Forms.Label RES_Direccion;
        private System.Windows.Forms.Label RES_TipoMoneda;
        private System.Windows.Forms.Label RES_Horas;
        private System.Windows.Forms.Label RES_Title3;
    }
}