
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
            this.BUTTONS_PANEL = new System.Windows.Forms.Panel();
            this.FOOTHER_BUTTONS_PANEL = new System.Windows.Forms.FlowLayoutPanel();
            this.BT_SHOW_RESTAURANTS = new System.Windows.Forms.Button();
            this.BT_SHOW_MENUS = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.HEADER_BUTTONS_PANELS = new System.Windows.Forms.Panel();
            this.AUTORS_PROJECTE = new System.Windows.Forms.Label();
            this.NOM_API = new System.Windows.Forms.Label();
            this.PANEL_MENU_BT = new System.Windows.Forms.Button();
            this.PANEL_REST_Title = new System.Windows.Forms.Label();
            this.PANEL_REST_BT = new System.Windows.Forms.Button();
            this.PANEL_INICI = new System.Windows.Forms.Panel();
            this.PANEL_MENU = new System.Windows.Forms.Panel();
            this.PANEL_MENU_TB_MENUID = new System.Windows.Forms.TextBox();
            this.PANEL_MENU_TITLE = new System.Windows.Forms.Label();
            this.PANEL_REST = new System.Windows.Forms.Panel();
            this.PANEL_REST_TB_RESTID = new System.Windows.Forms.TextBox();
            this.BUTTONS_PANEL.SuspendLayout();
            this.FOOTHER_BUTTONS_PANEL.SuspendLayout();
            this.HEADER_BUTTONS_PANELS.SuspendLayout();
            this.PANEL_MENU.SuspendLayout();
            this.PANEL_REST.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUTTONS_PANEL
            // 
            this.BUTTONS_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BUTTONS_PANEL.Controls.Add(this.FOOTHER_BUTTONS_PANEL);
            this.BUTTONS_PANEL.Controls.Add(this.HEADER_BUTTONS_PANELS);
            this.BUTTONS_PANEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.BUTTONS_PANEL.Location = new System.Drawing.Point(0, 0);
            this.BUTTONS_PANEL.Name = "BUTTONS_PANEL";
            this.BUTTONS_PANEL.Size = new System.Drawing.Size(226, 340);
            this.BUTTONS_PANEL.TabIndex = 2;
            this.BUTTONS_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.BUTTONS_PANEL_Paint);
            // 
            // FOOTHER_BUTTONS_PANEL
            // 
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_RESTAURANTS);
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_MENUS);
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_EXIT);
            this.FOOTHER_BUTTONS_PANEL.Location = new System.Drawing.Point(0, 76);
            this.FOOTHER_BUTTONS_PANEL.Name = "FOOTHER_BUTTONS_PANEL";
            this.FOOTHER_BUTTONS_PANEL.Size = new System.Drawing.Size(226, 363);
            this.FOOTHER_BUTTONS_PANEL.TabIndex = 4;
            this.FOOTHER_BUTTONS_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.FOOTHER_BUTTONS_PANEL_Paint);
            // 
            // BT_SHOW_RESTAURANTS
            // 
            this.BT_SHOW_RESTAURANTS.AllowDrop = true;
            this.BT_SHOW_RESTAURANTS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_SHOW_RESTAURANTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_RESTAURANTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_RESTAURANTS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_RESTAURANTS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_RESTAURANTS.Location = new System.Drawing.Point(3, 3);
            this.BT_SHOW_RESTAURANTS.Name = "BT_SHOW_RESTAURANTS";
            this.BT_SHOW_RESTAURANTS.Size = new System.Drawing.Size(221, 36);
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
            this.BT_SHOW_MENUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_MENUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_MENUS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_MENUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_MENUS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_MENUS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_MENUS.Location = new System.Drawing.Point(3, 45);
            this.BT_SHOW_MENUS.Name = "BT_SHOW_MENUS";
            this.BT_SHOW_MENUS.Size = new System.Drawing.Size(221, 36);
            this.BT_SHOW_MENUS.TabIndex = 5;
            this.BT_SHOW_MENUS.Text = "Menús";
            this.BT_SHOW_MENUS.UseVisualStyleBackColor = false;
            this.BT_SHOW_MENUS.Click += new System.EventHandler(this.BT_SHOW_MENUS_Click);
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
            this.BT_EXIT.Location = new System.Drawing.Point(3, 87);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(221, 36);
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
            this.HEADER_BUTTONS_PANELS.Name = "HEADER_BUTTONS_PANELS";
            this.HEADER_BUTTONS_PANELS.Size = new System.Drawing.Size(226, 76);
            this.HEADER_BUTTONS_PANELS.TabIndex = 0;
            this.HEADER_BUTTONS_PANELS.Paint += new System.Windows.Forms.PaintEventHandler(this.HEADER_BUTTONS_PANELS_Paint);
            // 
            // AUTORS_PROJECTE
            // 
            this.AUTORS_PROJECTE.AutoSize = true;
            this.AUTORS_PROJECTE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTORS_PROJECTE.ForeColor = System.Drawing.Color.White;
            this.AUTORS_PROJECTE.Location = new System.Drawing.Point(11, 42);
            this.AUTORS_PROJECTE.Name = "AUTORS_PROJECTE";
            this.AUTORS_PROJECTE.Size = new System.Drawing.Size(208, 14);
            this.AUTORS_PROJECTE.TabIndex = 1;
            this.AUTORS_PROJECTE.Text = "by Antonio Hernández y Kevin Luque";
            this.AUTORS_PROJECTE.Click += new System.EventHandler(this.AUTORS_PROJECTE_Click);
            // 
            // NOM_API
            // 
            this.NOM_API.AutoSize = true;
            this.NOM_API.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_API.ForeColor = System.Drawing.Color.White;
            this.NOM_API.Location = new System.Drawing.Point(17, 13);
            this.NOM_API.Name = "NOM_API";
            this.NOM_API.Size = new System.Drawing.Size(200, 29);
            this.NOM_API.TabIndex = 0;
            this.NOM_API.Text = "API DOCUMENU";
            this.NOM_API.Click += new System.EventHandler(this.NOM_API_Click);
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
            this.PANEL_MENU_BT.Location = new System.Drawing.Point(34, 141);
            this.PANEL_MENU_BT.Name = "PANEL_MENU_BT";
            this.PANEL_MENU_BT.Size = new System.Drawing.Size(220, 36);
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
            this.PANEL_REST_Title.Location = new System.Drawing.Point(58, 41);
            this.PANEL_REST_Title.Name = "PANEL_REST_Title";
            this.PANEL_REST_Title.Size = new System.Drawing.Size(170, 29);
            this.PANEL_REST_Title.TabIndex = 10;
            this.PANEL_REST_Title.Text = "Restaurantes:";
            this.PANEL_REST_Title.Click += new System.EventHandler(this.PANEL_REST_Title_Click);
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
            this.PANEL_REST_BT.Location = new System.Drawing.Point(31, 141);
            this.PANEL_REST_BT.Name = "PANEL_REST_BT";
            this.PANEL_REST_BT.Size = new System.Drawing.Size(224, 36);
            this.PANEL_REST_BT.TabIndex = 8;
            this.PANEL_REST_BT.Text = "Abrir Restaurante";
            this.PANEL_REST_BT.UseVisualStyleBackColor = false;
            this.PANEL_REST_BT.Click += new System.EventHandler(this.PANEL_REST_BT_Click);
            // 
            // PANEL_INICI
            // 
            this.PANEL_INICI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_INICI.Location = new System.Drawing.Point(238, 38);
            this.PANEL_INICI.Name = "PANEL_INICI";
            this.PANEL_INICI.Size = new System.Drawing.Size(290, 287);
            this.PANEL_INICI.TabIndex = 4;
            this.PANEL_INICI.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_INICI_Paint);
            // 
            // PANEL_MENU
            // 
            this.PANEL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_TB_MENUID);
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_TITLE);
            this.PANEL_MENU.Controls.Add(this.PANEL_MENU_BT);
            this.PANEL_MENU.Location = new System.Drawing.Point(239, 38);
            this.PANEL_MENU.Name = "PANEL_MENU";
            this.PANEL_MENU.Size = new System.Drawing.Size(289, 287);
            this.PANEL_MENU.TabIndex = 5;
            this.PANEL_MENU.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_MENU_Paint);
            // 
            // PANEL_MENU_TB_MENUID
            // 
            this.PANEL_MENU_TB_MENUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_MENU_TB_MENUID.Location = new System.Drawing.Point(34, 86);
            this.PANEL_MENU_TB_MENUID.Name = "PANEL_MENU_TB_MENUID";
            this.PANEL_MENU_TB_MENUID.Size = new System.Drawing.Size(220, 35);
            this.PANEL_MENU_TB_MENUID.TabIndex = 15;
            this.PANEL_MENU_TB_MENUID.TextChanged += new System.EventHandler(this.PANEL_MENU_TB_MENUID_TextChanged);
            // 
            // PANEL_MENU_TITLE
            // 
            this.PANEL_MENU_TITLE.AutoSize = true;
            this.PANEL_MENU_TITLE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MENU_TITLE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_MENU_TITLE.ForeColor = System.Drawing.Color.Black;
            this.PANEL_MENU_TITLE.Location = new System.Drawing.Point(73, 41);
            this.PANEL_MENU_TITLE.Name = "PANEL_MENU_TITLE";
            this.PANEL_MENU_TITLE.Size = new System.Drawing.Size(128, 29);
            this.PANEL_MENU_TITLE.TabIndex = 14;
            this.PANEL_MENU_TITLE.Text = "Menus ID:";
            this.PANEL_MENU_TITLE.Click += new System.EventHandler(this.PANEL_MENU_TITLE_Click_1);
            // 
            // PANEL_REST
            // 
            this.PANEL_REST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_REST.Controls.Add(this.PANEL_REST_TB_RESTID);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_Title);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_BT);
            this.PANEL_REST.Location = new System.Drawing.Point(238, 38);
            this.PANEL_REST.Name = "PANEL_REST";
            this.PANEL_REST.Size = new System.Drawing.Size(290, 287);
            this.PANEL_REST.TabIndex = 3;
            this.PANEL_REST.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_REST_Paint);
            // 
            // PANEL_REST_TB_RESTID
            // 
            this.PANEL_REST_TB_RESTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_REST_TB_RESTID.Location = new System.Drawing.Point(35, 86);
            this.PANEL_REST_TB_RESTID.Name = "PANEL_REST_TB_RESTID";
            this.PANEL_REST_TB_RESTID.Size = new System.Drawing.Size(220, 35);
            this.PANEL_REST_TB_RESTID.TabIndex = 16;
            this.PANEL_REST_TB_RESTID.TextChanged += new System.EventHandler(this.PANEL_REST_TB_RESTID_TextChanged);
            // 
            // VInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.PANEL_INICI);
            this.Controls.Add(this.PANEL_MENU);
            this.Controls.Add(this.BUTTONS_PANEL);
            this.Controls.Add(this.PANEL_REST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VInici";
            this.Text = "Inici";
            this.Load += new System.EventHandler(this.VInici_Load);
            this.BUTTONS_PANEL.ResumeLayout(false);
            this.FOOTHER_BUTTONS_PANEL.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.PerformLayout();
            this.PANEL_MENU.ResumeLayout(false);
            this.PANEL_MENU.PerformLayout();
            this.PANEL_REST.ResumeLayout(false);
            this.PANEL_REST.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel BUTTONS_PANEL;
        public System.Windows.Forms.FlowLayoutPanel FOOTHER_BUTTONS_PANEL;
        public System.Windows.Forms.Button BT_SHOW_RESTAURANTS;
        public System.Windows.Forms.Button BT_SHOW_MENUS;
        public System.Windows.Forms.Button BT_EXIT;
        public System.Windows.Forms.Panel HEADER_BUTTONS_PANELS;
        public System.Windows.Forms.Label AUTORS_PROJECTE;
        public System.Windows.Forms.Label NOM_API;
        public System.Windows.Forms.Button PANEL_MENU_BT;
        public System.Windows.Forms.Label PANEL_REST_Title;
        public System.Windows.Forms.Button PANEL_REST_BT;
        public System.Windows.Forms.Panel PANEL_INICI;
        public System.Windows.Forms.Panel PANEL_MENU;
        public System.Windows.Forms.Panel PANEL_REST;
        public System.Windows.Forms.TextBox PANEL_MENU_TB_MENUID;
        public System.Windows.Forms.Label PANEL_MENU_TITLE;
        public System.Windows.Forms.TextBox PANEL_REST_TB_RESTID;
    }
}