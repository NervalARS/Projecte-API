
namespace M15_ProjecteConsumidor.Vista
{
    partial class VInici
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
            this.PANEL_FAV_BT = new System.Windows.Forms.Button();
            this.BUTTONS_PANEL = new System.Windows.Forms.Panel();
            this.FOOTHER_BUTTONS_PANEL = new System.Windows.Forms.FlowLayoutPanel();
            this.BT_SHOW_RESTAURANTS = new System.Windows.Forms.Button();
            this.BT_SHOW_MENUS = new System.Windows.Forms.Button();
            this.BT_SHOW_FAV_RESTAURANTS = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.HEADER_BUTTONS_PANELS = new System.Windows.Forms.Panel();
            this.AUTORS_PROJECTE = new System.Windows.Forms.Label();
            this.NOM_API = new System.Windows.Forms.Label();
            this.PANEL_FAV_Title = new System.Windows.Forms.Label();
            this.PANEL_MENU_Title = new System.Windows.Forms.Label();
            this.PANEL_MENU_DGV = new System.Windows.Forms.DataGridView();
            this.PANEL_MENU_BT = new System.Windows.Forms.Button();
            this.PANEL_REST_Title = new System.Windows.Forms.Label();
            this.PANEL_REST_DGV = new System.Windows.Forms.DataGridView();
            this.PANEL_REST_BT = new System.Windows.Forms.Button();
            this.PANEL_FAV_DGV = new System.Windows.Forms.DataGridView();
            this.PANEL_INICI = new System.Windows.Forms.Panel();
            this.PANEL_MENU = new System.Windows.Forms.Panel();
            this.PANEL_FAV = new System.Windows.Forms.Panel();
            this.PANEL_REST = new System.Windows.Forms.Panel();
            this.BUTTONS_PANEL.SuspendLayout();
            this.FOOTHER_BUTTONS_PANEL.SuspendLayout();
            this.HEADER_BUTTONS_PANELS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_MENU_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_REST_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_FAV_DGV)).BeginInit();
            this.PANEL_MENU.SuspendLayout();
            this.PANEL_FAV.SuspendLayout();
            this.PANEL_REST.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_FAV_BT
            // 
            this.PANEL_FAV_BT.AllowDrop = true;
            this.PANEL_FAV_BT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_FAV_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_FAV_BT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_FAV_BT.FlatAppearance.BorderSize = 0;
            this.PANEL_FAV_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PANEL_FAV_BT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_FAV_BT.ForeColor = System.Drawing.Color.White;
            this.PANEL_FAV_BT.Location = new System.Drawing.Point(723, 532);
            this.PANEL_FAV_BT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_FAV_BT.Name = "PANEL_FAV_BT";
            this.PANEL_FAV_BT.Size = new System.Drawing.Size(330, 55);
            this.PANEL_FAV_BT.TabIndex = 11;
            this.PANEL_FAV_BT.Text = "Abrir Restaurante Favorito";
            this.PANEL_FAV_BT.UseVisualStyleBackColor = false;
            this.PANEL_FAV_BT.Click += new System.EventHandler(this.PANEL_FAV_BT_Click);
            // 
            // BUTTONS_PANEL
            // 
            this.BUTTONS_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BUTTONS_PANEL.Controls.Add(this.FOOTHER_BUTTONS_PANEL);
            this.BUTTONS_PANEL.Controls.Add(this.HEADER_BUTTONS_PANELS);
            this.BUTTONS_PANEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.BUTTONS_PANEL.Location = new System.Drawing.Point(0, 0);
            this.BUTTONS_PANEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BUTTONS_PANEL.Name = "BUTTONS_PANEL";
            this.BUTTONS_PANEL.Size = new System.Drawing.Size(339, 675);
            this.BUTTONS_PANEL.TabIndex = 2;
            this.BUTTONS_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.BUTTONS_PANEL_Paint);
            // 
            // FOOTHER_BUTTONS_PANEL
            // 
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_RESTAURANTS);
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_MENUS);
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_FAV_RESTAURANTS);
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_EXIT);
            this.FOOTHER_BUTTONS_PANEL.Location = new System.Drawing.Point(0, 117);
            this.FOOTHER_BUTTONS_PANEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FOOTHER_BUTTONS_PANEL.Name = "FOOTHER_BUTTONS_PANEL";
            this.FOOTHER_BUTTONS_PANEL.Size = new System.Drawing.Size(339, 558);
            this.FOOTHER_BUTTONS_PANEL.TabIndex = 4;
            this.FOOTHER_BUTTONS_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.FOOTHER_BUTTONS_PANEL_Paint);
            // 
            // BT_SHOW_RESTAURANTS
            // 
            this.BT_SHOW_RESTAURANTS.AllowDrop = true;
            this.BT_SHOW_RESTAURANTS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_SHOW_RESTAURANTS.BackColor = System.Drawing.Color.Transparent;
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_RESTAURANTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_RESTAURANTS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_RESTAURANTS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_RESTAURANTS.Location = new System.Drawing.Point(4, 5);
            this.BT_SHOW_RESTAURANTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_SHOW_RESTAURANTS.Name = "BT_SHOW_RESTAURANTS";
            this.BT_SHOW_RESTAURANTS.Size = new System.Drawing.Size(331, 55);
            this.BT_SHOW_RESTAURANTS.TabIndex = 6;
            this.BT_SHOW_RESTAURANTS.Text = "Restaurantes";
            this.BT_SHOW_RESTAURANTS.UseVisualStyleBackColor = false;
            this.BT_SHOW_RESTAURANTS.Click += new System.EventHandler(this.BT_SHOW_RESTAURANTS_Click);
            // 
            // BT_SHOW_MENUS
            // 
            this.BT_SHOW_MENUS.AllowDrop = true;
            this.BT_SHOW_MENUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SHOW_MENUS.BackColor = System.Drawing.Color.Transparent;
            this.BT_SHOW_MENUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_MENUS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_MENUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_MENUS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_MENUS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_MENUS.Location = new System.Drawing.Point(4, 70);
            this.BT_SHOW_MENUS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_SHOW_MENUS.Name = "BT_SHOW_MENUS";
            this.BT_SHOW_MENUS.Size = new System.Drawing.Size(331, 55);
            this.BT_SHOW_MENUS.TabIndex = 5;
            this.BT_SHOW_MENUS.Text = "Menús";
            this.BT_SHOW_MENUS.UseVisualStyleBackColor = false;
            this.BT_SHOW_MENUS.Click += new System.EventHandler(this.BT_SHOW_MENUS_Click);
            // 
            // BT_SHOW_FAV_RESTAURANTS
            // 
            this.BT_SHOW_FAV_RESTAURANTS.AllowDrop = true;
            this.BT_SHOW_FAV_RESTAURANTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SHOW_FAV_RESTAURANTS.BackColor = System.Drawing.Color.Transparent;
            this.BT_SHOW_FAV_RESTAURANTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_FAV_RESTAURANTS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_FAV_RESTAURANTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_FAV_RESTAURANTS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_FAV_RESTAURANTS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_FAV_RESTAURANTS.Location = new System.Drawing.Point(4, 135);
            this.BT_SHOW_FAV_RESTAURANTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_SHOW_FAV_RESTAURANTS.Name = "BT_SHOW_FAV_RESTAURANTS";
            this.BT_SHOW_FAV_RESTAURANTS.Size = new System.Drawing.Size(331, 55);
            this.BT_SHOW_FAV_RESTAURANTS.TabIndex = 4;
            this.BT_SHOW_FAV_RESTAURANTS.Text = "Favoritos";
            this.BT_SHOW_FAV_RESTAURANTS.UseVisualStyleBackColor = false;
            this.BT_SHOW_FAV_RESTAURANTS.Click += new System.EventHandler(this.BT_SHOW_FAV_RESTAURANTS_Click);
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
            this.BT_EXIT.Location = new System.Drawing.Point(4, 200);
            this.BT_EXIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(331, 55);
            this.BT_EXIT.TabIndex = 7;
            this.BT_EXIT.Text = "Cerrar Aplicacion";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // HEADER_BUTTONS_PANELS
            // 
            this.HEADER_BUTTONS_PANELS.Controls.Add(this.AUTORS_PROJECTE);
            this.HEADER_BUTTONS_PANELS.Controls.Add(this.NOM_API);
            this.HEADER_BUTTONS_PANELS.Dock = System.Windows.Forms.DockStyle.Top;
            this.HEADER_BUTTONS_PANELS.Location = new System.Drawing.Point(0, 0);
            this.HEADER_BUTTONS_PANELS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HEADER_BUTTONS_PANELS.Name = "HEADER_BUTTONS_PANELS";
            this.HEADER_BUTTONS_PANELS.Size = new System.Drawing.Size(339, 117);
            this.HEADER_BUTTONS_PANELS.TabIndex = 0;
            this.HEADER_BUTTONS_PANELS.Paint += new System.Windows.Forms.PaintEventHandler(this.HEADER_BUTTONS_PANELS_Paint);
            // 
            // AUTORS_PROJECTE
            // 
            this.AUTORS_PROJECTE.AutoSize = true;
            this.AUTORS_PROJECTE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTORS_PROJECTE.ForeColor = System.Drawing.Color.White;
            this.AUTORS_PROJECTE.Location = new System.Drawing.Point(17, 64);
            this.AUTORS_PROJECTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AUTORS_PROJECTE.Name = "AUTORS_PROJECTE";
            this.AUTORS_PROJECTE.Size = new System.Drawing.Size(300, 19);
            this.AUTORS_PROJECTE.TabIndex = 1;
            this.AUTORS_PROJECTE.Text = "by Antonio Hernández y Kevin Luque";
            this.AUTORS_PROJECTE.Click += new System.EventHandler(this.AUTORS_PROJECTE_Click);
            // 
            // NOM_API
            // 
            this.NOM_API.AutoSize = true;
            this.NOM_API.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_API.ForeColor = System.Drawing.Color.White;
            this.NOM_API.Location = new System.Drawing.Point(25, 20);
            this.NOM_API.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOM_API.Name = "NOM_API";
            this.NOM_API.Size = new System.Drawing.Size(298, 43);
            this.NOM_API.TabIndex = 0;
            this.NOM_API.Text = "API DOCUMENU";
            this.NOM_API.Click += new System.EventHandler(this.NOM_API_Click);
            // 
            // PANEL_FAV_Title
            // 
            this.PANEL_FAV_Title.AutoSize = true;
            this.PANEL_FAV_Title.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_FAV_Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_FAV_Title.ForeColor = System.Drawing.Color.Black;
            this.PANEL_FAV_Title.Location = new System.Drawing.Point(8, 15);
            this.PANEL_FAV_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PANEL_FAV_Title.Name = "PANEL_FAV_Title";
            this.PANEL_FAV_Title.Size = new System.Drawing.Size(428, 43);
            this.PANEL_FAV_Title.TabIndex = 13;
            this.PANEL_FAV_Title.Text = "Restaurantes Favoritos:";
            this.PANEL_FAV_Title.Click += new System.EventHandler(this.PANEL_FAV_Title_Click);
            // 
            // PANEL_MENU_Title
            // 
            this.PANEL_MENU_Title.AutoSize = true;
            this.PANEL_MENU_Title.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MENU_Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_MENU_Title.ForeColor = System.Drawing.Color.Black;
            this.PANEL_MENU_Title.Location = new System.Drawing.Point(8, 15);
            this.PANEL_MENU_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PANEL_MENU_Title.Name = "PANEL_MENU_Title";
            this.PANEL_MENU_Title.Size = new System.Drawing.Size(142, 43);
            this.PANEL_MENU_Title.TabIndex = 13;
            this.PANEL_MENU_Title.Text = "Menus:";
            this.PANEL_MENU_Title.Click += new System.EventHandler(this.PANEL_MENU_Title_Click);
            // 
            // PANEL_MENU_DGV
            // 
            this.PANEL_MENU_DGV.BackgroundColor = System.Drawing.Color.White;
            this.PANEL_MENU_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PANEL_MENU_DGV.Location = new System.Drawing.Point(12, 69);
            this.PANEL_MENU_DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_MENU_DGV.Name = "PANEL_MENU_DGV";
            this.PANEL_MENU_DGV.RowHeadersWidth = 62;
            this.PANEL_MENU_DGV.Size = new System.Drawing.Size(1041, 454);
            this.PANEL_MENU_DGV.TabIndex = 12;
            this.PANEL_MENU_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PANEL_MENU_DGV_CellContentClick);
            // 
            // PANEL_MENU_BT
            // 
            this.PANEL_MENU_BT.AllowDrop = true;
            this.PANEL_MENU_BT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_MENU_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_MENU_BT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_MENU_BT.FlatAppearance.BorderSize = 0;
            this.PANEL_MENU_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PANEL_MENU_BT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_MENU_BT.ForeColor = System.Drawing.Color.White;
            this.PANEL_MENU_BT.Location = new System.Drawing.Point(723, 532);
            this.PANEL_MENU_BT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_MENU_BT.Name = "PANEL_MENU_BT";
            this.PANEL_MENU_BT.Size = new System.Drawing.Size(330, 55);
            this.PANEL_MENU_BT.TabIndex = 11;
            this.PANEL_MENU_BT.Text = "Abrir Menu";
            this.PANEL_MENU_BT.UseVisualStyleBackColor = false;
            this.PANEL_MENU_BT.Click += new System.EventHandler(this.PANEL_MENU_BT_Click);
            // 
            // PANEL_REST_Title
            // 
            this.PANEL_REST_Title.AutoSize = true;
            this.PANEL_REST_Title.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_REST_Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_REST_Title.ForeColor = System.Drawing.Color.Black;
            this.PANEL_REST_Title.Location = new System.Drawing.Point(4, 14);
            this.PANEL_REST_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PANEL_REST_Title.Name = "PANEL_REST_Title";
            this.PANEL_REST_Title.Size = new System.Drawing.Size(258, 43);
            this.PANEL_REST_Title.TabIndex = 10;
            this.PANEL_REST_Title.Text = "Restaurantes:";
            this.PANEL_REST_Title.Click += new System.EventHandler(this.PANEL_REST_Title_Click);
            // 
            // PANEL_REST_DGV
            // 
            this.PANEL_REST_DGV.BackgroundColor = System.Drawing.Color.White;
            this.PANEL_REST_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PANEL_REST_DGV.Location = new System.Drawing.Point(9, 68);
            this.PANEL_REST_DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST_DGV.Name = "PANEL_REST_DGV";
            this.PANEL_REST_DGV.RowHeadersWidth = 62;
            this.PANEL_REST_DGV.Size = new System.Drawing.Size(1041, 454);
            this.PANEL_REST_DGV.TabIndex = 9;
            this.PANEL_REST_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PANEL_REST_DGV_CellContentClick);
            // 
            // PANEL_REST_BT
            // 
            this.PANEL_REST_BT.AllowDrop = true;
            this.PANEL_REST_BT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_REST_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REST_BT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REST_BT.FlatAppearance.BorderSize = 0;
            this.PANEL_REST_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PANEL_REST_BT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_REST_BT.ForeColor = System.Drawing.Color.White;
            this.PANEL_REST_BT.Location = new System.Drawing.Point(720, 531);
            this.PANEL_REST_BT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST_BT.Name = "PANEL_REST_BT";
            this.PANEL_REST_BT.Size = new System.Drawing.Size(330, 55);
            this.PANEL_REST_BT.TabIndex = 8;
            this.PANEL_REST_BT.Text = "Abrir Restaurante";
            this.PANEL_REST_BT.UseVisualStyleBackColor = false;
            this.PANEL_REST_BT.Click += new System.EventHandler(this.PANEL_REST_BT_Click);
            // 
            // PANEL_FAV_DGV
            // 
            this.PANEL_FAV_DGV.BackgroundColor = System.Drawing.Color.White;
            this.PANEL_FAV_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PANEL_FAV_DGV.Location = new System.Drawing.Point(12, 69);
            this.PANEL_FAV_DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_FAV_DGV.Name = "PANEL_FAV_DGV";
            this.PANEL_FAV_DGV.RowHeadersWidth = 62;
            this.PANEL_FAV_DGV.Size = new System.Drawing.Size(1041, 454);
            this.PANEL_FAV_DGV.TabIndex = 12;
            this.PANEL_FAV_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PANEL_FAV_DGV_CellContentClick);
            // 
            // PANEL_INICI
            // 
            this.PANEL_INICI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_INICI.Location = new System.Drawing.Point(357, 58);
            this.PANEL_INICI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_INICI.Name = "PANEL_INICI";
            this.PANEL_INICI.Size = new System.Drawing.Size(1060, 605);
            this.PANEL_INICI.TabIndex = 4;
            this.PANEL_INICI.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_INICI_Paint);
            // 
            // PANEL_MENU
            // 
            this.PANEL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_Title);
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_DGV);
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_BT);
            this.PANEL_MENU.Location = new System.Drawing.Point(357, 58);
            this.PANEL_MENU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_MENU.Name = "PANEL_MENU";
            this.PANEL_MENU.Size = new System.Drawing.Size(1060, 605);
            this.PANEL_MENU.TabIndex = 5;
            this.PANEL_MENU.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_MENU_Paint);
            // 
            // PANEL_FAV
            // 
            this.PANEL_FAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_FAV.Controls.Add(this.PANEL_FAV_Title);
            this.PANEL_FAV.Controls.Add(this.PANEL_FAV_DGV);
            this.PANEL_FAV.Controls.Add(this.PANEL_FAV_BT);
            this.PANEL_FAV.Location = new System.Drawing.Point(357, 58);
            this.PANEL_FAV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_FAV.Name = "PANEL_FAV";
            this.PANEL_FAV.Size = new System.Drawing.Size(1060, 605);
            this.PANEL_FAV.TabIndex = 6;
            this.PANEL_FAV.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_FAV_Paint);
            // 
            // PANEL_REST
            // 
            this.PANEL_REST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_REST.Controls.Add(this.PANEL_REST_Title);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_DGV);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_BT);
            this.PANEL_REST.Location = new System.Drawing.Point(357, 58);
            this.PANEL_REST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST.Name = "PANEL_REST";
            this.PANEL_REST.Size = new System.Drawing.Size(1060, 605);
            this.PANEL_REST.TabIndex = 3;
            this.PANEL_REST.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_REST_Paint);
            // 
            // VInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1426, 675);
            this.Controls.Add(this.BUTTONS_PANEL);
            this.Controls.Add(this.PANEL_INICI);
            this.Controls.Add(this.PANEL_MENU);
            this.Controls.Add(this.PANEL_FAV);
            this.Controls.Add(this.PANEL_REST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VInici";
            this.Text = "Inici";
            this.BUTTONS_PANEL.ResumeLayout(false);
            this.FOOTHER_BUTTONS_PANEL.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_MENU_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_REST_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PANEL_FAV_DGV)).EndInit();
            this.PANEL_MENU.ResumeLayout(false);
            this.PANEL_MENU.PerformLayout();
            this.PANEL_FAV.ResumeLayout(false);
            this.PANEL_FAV.PerformLayout();
            this.PANEL_REST.ResumeLayout(false);
            this.PANEL_REST.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button PANEL_FAV_BT;
        public System.Windows.Forms.Panel BUTTONS_PANEL;
        public System.Windows.Forms.FlowLayoutPanel FOOTHER_BUTTONS_PANEL;
        public System.Windows.Forms.Button BT_SHOW_RESTAURANTS;
        public System.Windows.Forms.Button BT_SHOW_MENUS;
        public System.Windows.Forms.Button BT_SHOW_FAV_RESTAURANTS;
        public System.Windows.Forms.Button BT_EXIT;
        public System.Windows.Forms.Panel HEADER_BUTTONS_PANELS;
        public System.Windows.Forms.Label AUTORS_PROJECTE;
        public System.Windows.Forms.Label NOM_API;
        public System.Windows.Forms.Label PANEL_FAV_Title;
        public System.Windows.Forms.Label PANEL_MENU_Title;
        public System.Windows.Forms.DataGridView PANEL_MENU_DGV;
        public System.Windows.Forms.Button PANEL_MENU_BT;
        public System.Windows.Forms.Label PANEL_REST_Title;
        public System.Windows.Forms.DataGridView PANEL_REST_DGV;
        public System.Windows.Forms.Button PANEL_REST_BT;
        public System.Windows.Forms.DataGridView PANEL_FAV_DGV;
        public System.Windows.Forms.Panel PANEL_INICI;
        public System.Windows.Forms.Panel PANEL_MENU;
        public System.Windows.Forms.Panel PANEL_FAV;
        public System.Windows.Forms.Panel PANEL_REST;
    }
}