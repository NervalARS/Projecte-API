
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
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.HEADER_BUTTONS_PANELS = new System.Windows.Forms.Panel();
            this.AUTORS_PROJECTE = new System.Windows.Forms.Label();
            this.NOM_API = new System.Windows.Forms.Label();
            this.PANEL_REST_Title = new System.Windows.Forms.Label();
            this.PANEL_REST_BT = new System.Windows.Forms.Button();
            this.PANEL_Login = new System.Windows.Forms.Panel();
            this.PANEL_INI_BTRegist = new System.Windows.Forms.Button();
            this.PANEL_INIC_BTLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PANEL_INIC_TBPass = new System.Windows.Forms.TextBox();
            this.PANEL_INIC_TBUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_REST = new System.Windows.Forms.Panel();
            this.PANEL_REST_TB_RESTID = new System.Windows.Forms.TextBox();
            this.PANEL_Registrar = new System.Windows.Forms.Panel();
            this.PANEL_REG_BT_Volver = new System.Windows.Forms.Button();
            this.PANEL_REG_BT_Registrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PANEL_REG_PASS = new System.Windows.Forms.TextBox();
            this.PANEL_REG_USR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PANEL_REG_AlertaINSUSER = new System.Windows.Forms.Label();
            this.BUTTONS_PANEL.SuspendLayout();
            this.FOOTHER_BUTTONS_PANEL.SuspendLayout();
            this.HEADER_BUTTONS_PANELS.SuspendLayout();
            this.PANEL_Login.SuspendLayout();
            this.PANEL_REST.SuspendLayout();
            this.PANEL_Registrar.SuspendLayout();
            this.SuspendLayout();
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
            this.BUTTONS_PANEL.Size = new System.Drawing.Size(339, 523);
            this.BUTTONS_PANEL.TabIndex = 2;
            this.BUTTONS_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.BUTTONS_PANEL_Paint);
            // 
            // FOOTHER_BUTTONS_PANEL
            // 
            this.FOOTHER_BUTTONS_PANEL.Controls.Add(this.BT_SHOW_RESTAURANTS);
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
            this.BT_SHOW_RESTAURANTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_RESTAURANTS.Enabled = false;
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.BT_SHOW_RESTAURANTS.FlatAppearance.BorderSize = 0;
            this.BT_SHOW_RESTAURANTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SHOW_RESTAURANTS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BT_SHOW_RESTAURANTS.ForeColor = System.Drawing.Color.White;
            this.BT_SHOW_RESTAURANTS.Location = new System.Drawing.Point(4, 5);
            this.BT_SHOW_RESTAURANTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_SHOW_RESTAURANTS.Name = "BT_SHOW_RESTAURANTS";
            this.BT_SHOW_RESTAURANTS.Size = new System.Drawing.Size(332, 55);
            this.BT_SHOW_RESTAURANTS.TabIndex = 6;
            this.BT_SHOW_RESTAURANTS.Text = "Restaurantes";
            this.BT_SHOW_RESTAURANTS.UseVisualStyleBackColor = false;
            this.BT_SHOW_RESTAURANTS.Click += new System.EventHandler(this.BT_SHOW_RESTAURANTS_Click);
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
            this.BT_EXIT.Location = new System.Drawing.Point(4, 70);
            this.BT_EXIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(332, 55);
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
            this.AUTORS_PROJECTE.Location = new System.Drawing.Point(16, 65);
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
            this.NOM_API.Location = new System.Drawing.Point(26, 20);
            this.NOM_API.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOM_API.Name = "NOM_API";
            this.NOM_API.Size = new System.Drawing.Size(298, 43);
            this.NOM_API.TabIndex = 0;
            this.NOM_API.Text = "API DOCUMENU";
            this.NOM_API.Click += new System.EventHandler(this.NOM_API_Click);
            // 
            // PANEL_REST_Title
            // 
            this.PANEL_REST_Title.AutoSize = true;
            this.PANEL_REST_Title.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_REST_Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_REST_Title.ForeColor = System.Drawing.Color.Black;
            this.PANEL_REST_Title.Location = new System.Drawing.Point(87, 63);
            this.PANEL_REST_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PANEL_REST_Title.Name = "PANEL_REST_Title";
            this.PANEL_REST_Title.Size = new System.Drawing.Size(258, 43);
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
            this.PANEL_REST_BT.Location = new System.Drawing.Point(46, 217);
            this.PANEL_REST_BT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST_BT.Name = "PANEL_REST_BT";
            this.PANEL_REST_BT.Size = new System.Drawing.Size(336, 55);
            this.PANEL_REST_BT.TabIndex = 8;
            this.PANEL_REST_BT.Text = "Abrir Restaurante";
            this.PANEL_REST_BT.UseVisualStyleBackColor = false;
            this.PANEL_REST_BT.Click += new System.EventHandler(this.PANEL_REST_BT_Click);
            // 
            // PANEL_Login
            // 
            this.PANEL_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_Login.Controls.Add(this.PANEL_INI_BTRegist);
            this.PANEL_Login.Controls.Add(this.PANEL_INIC_BTLogin);
            this.PANEL_Login.Controls.Add(this.label3);
            this.PANEL_Login.Controls.Add(this.label2);
            this.PANEL_Login.Controls.Add(this.PANEL_INIC_TBPass);
            this.PANEL_Login.Controls.Add(this.PANEL_INIC_TBUser);
            this.PANEL_Login.Controls.Add(this.label1);
            this.PANEL_Login.Location = new System.Drawing.Point(357, 58);
            this.PANEL_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_Login.Name = "PANEL_Login";
            this.PANEL_Login.Size = new System.Drawing.Size(435, 442);
            this.PANEL_Login.TabIndex = 4;
            this.PANEL_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_INICI_Paint);
            // 
            // PANEL_INI_BTRegist
            // 
            this.PANEL_INI_BTRegist.AllowDrop = true;
            this.PANEL_INI_BTRegist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_INI_BTRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_INI_BTRegist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_INI_BTRegist.FlatAppearance.BorderSize = 0;
            this.PANEL_INI_BTRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PANEL_INI_BTRegist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_INI_BTRegist.ForeColor = System.Drawing.Color.White;
            this.PANEL_INI_BTRegist.Location = new System.Drawing.Point(264, 282);
            this.PANEL_INI_BTRegist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_INI_BTRegist.Name = "PANEL_INI_BTRegist";
            this.PANEL_INI_BTRegist.Size = new System.Drawing.Size(120, 43);
            this.PANEL_INI_BTRegist.TabIndex = 8;
            this.PANEL_INI_BTRegist.Text = "Registrar";
            this.PANEL_INI_BTRegist.UseVisualStyleBackColor = false;
            // 
            // PANEL_INIC_BTLogin
            // 
            this.PANEL_INIC_BTLogin.AllowDrop = true;
            this.PANEL_INIC_BTLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_INIC_BTLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_INIC_BTLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_INIC_BTLogin.FlatAppearance.BorderSize = 0;
            this.PANEL_INIC_BTLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PANEL_INIC_BTLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_INIC_BTLogin.ForeColor = System.Drawing.Color.White;
            this.PANEL_INIC_BTLogin.Location = new System.Drawing.Point(52, 282);
            this.PANEL_INIC_BTLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_INIC_BTLogin.Name = "PANEL_INIC_BTLogin";
            this.PANEL_INIC_BTLogin.Size = new System.Drawing.Size(175, 43);
            this.PANEL_INIC_BTLogin.TabIndex = 7;
            this.PANEL_INIC_BTLogin.Text = "Iniciar Session";
            this.PANEL_INIC_BTLogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // PANEL_INIC_TBPass
            // 
            this.PANEL_INIC_TBPass.Location = new System.Drawing.Point(52, 217);
            this.PANEL_INIC_TBPass.Name = "PANEL_INIC_TBPass";
            this.PANEL_INIC_TBPass.Size = new System.Drawing.Size(332, 26);
            this.PANEL_INIC_TBPass.TabIndex = 2;
            // 
            // PANEL_INIC_TBUser
            // 
            this.PANEL_INIC_TBUser.Location = new System.Drawing.Point(52, 129);
            this.PANEL_INIC_TBUser.Name = "PANEL_INIC_TBUser";
            this.PANEL_INIC_TBUser.Size = new System.Drawing.Size(332, 26);
            this.PANEL_INIC_TBUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicia Sesion:";
            // 
            // PANEL_REST
            // 
            this.PANEL_REST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_REST.Controls.Add(this.PANEL_REST_TB_RESTID);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_Title);
            this.PANEL_REST.Controls.Add(this.PANEL_REST_BT);
            this.PANEL_REST.Location = new System.Drawing.Point(357, 58);
            this.PANEL_REST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST.Name = "PANEL_REST";
            this.PANEL_REST.Size = new System.Drawing.Size(435, 442);
            this.PANEL_REST.TabIndex = 3;
            this.PANEL_REST.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_REST_Paint);
            // 
            // PANEL_REST_TB_RESTID
            // 
            this.PANEL_REST_TB_RESTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_REST_TB_RESTID.Location = new System.Drawing.Point(52, 132);
            this.PANEL_REST_TB_RESTID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REST_TB_RESTID.Name = "PANEL_REST_TB_RESTID";
            this.PANEL_REST_TB_RESTID.Size = new System.Drawing.Size(328, 48);
            this.PANEL_REST_TB_RESTID.TabIndex = 16;
            this.PANEL_REST_TB_RESTID.TextChanged += new System.EventHandler(this.PANEL_REST_TB_RESTID_TextChanged);
            // 
            // PANEL_Registrar
            // 
            this.PANEL_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.PANEL_Registrar.Controls.Add(this.PANEL_REG_AlertaINSUSER);
            this.PANEL_Registrar.Controls.Add(this.PANEL_REG_BT_Volver);
            this.PANEL_Registrar.Controls.Add(this.PANEL_REG_BT_Registrar);
            this.PANEL_Registrar.Controls.Add(this.label4);
            this.PANEL_Registrar.Controls.Add(this.label5);
            this.PANEL_Registrar.Controls.Add(this.PANEL_REG_PASS);
            this.PANEL_Registrar.Controls.Add(this.PANEL_REG_USR);
            this.PANEL_Registrar.Controls.Add(this.label6);
            this.PANEL_Registrar.Location = new System.Drawing.Point(357, 58);
            this.PANEL_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_Registrar.Name = "PANEL_Registrar";
            this.PANEL_Registrar.Size = new System.Drawing.Size(435, 442);
            this.PANEL_Registrar.TabIndex = 5;
            // 
            // PANEL_REG_BT_Volver
            // 
            this.PANEL_REG_BT_Volver.AllowDrop = true;
            this.PANEL_REG_BT_Volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_REG_BT_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REG_BT_Volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REG_BT_Volver.FlatAppearance.BorderSize = 0;
            this.PANEL_REG_BT_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PANEL_REG_BT_Volver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_REG_BT_Volver.ForeColor = System.Drawing.Color.White;
            this.PANEL_REG_BT_Volver.Location = new System.Drawing.Point(264, 282);
            this.PANEL_REG_BT_Volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REG_BT_Volver.Name = "PANEL_REG_BT_Volver";
            this.PANEL_REG_BT_Volver.Size = new System.Drawing.Size(120, 43);
            this.PANEL_REG_BT_Volver.TabIndex = 8;
            this.PANEL_REG_BT_Volver.Text = "Volver";
            this.PANEL_REG_BT_Volver.UseVisualStyleBackColor = false;
            // 
            // PANEL_REG_BT_Registrar
            // 
            this.PANEL_REG_BT_Registrar.AllowDrop = true;
            this.PANEL_REG_BT_Registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_REG_BT_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REG_BT_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.PANEL_REG_BT_Registrar.FlatAppearance.BorderSize = 0;
            this.PANEL_REG_BT_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PANEL_REG_BT_Registrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PANEL_REG_BT_Registrar.ForeColor = System.Drawing.Color.White;
            this.PANEL_REG_BT_Registrar.Location = new System.Drawing.Point(52, 282);
            this.PANEL_REG_BT_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PANEL_REG_BT_Registrar.Name = "PANEL_REG_BT_Registrar";
            this.PANEL_REG_BT_Registrar.Size = new System.Drawing.Size(175, 43);
            this.PANEL_REG_BT_Registrar.TabIndex = 7;
            this.PANEL_REG_BT_Registrar.Text = "Registrarme";
            this.PANEL_REG_BT_Registrar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Usuario:";
            // 
            // PANEL_REG_PASS
            // 
            this.PANEL_REG_PASS.Location = new System.Drawing.Point(52, 217);
            this.PANEL_REG_PASS.Name = "PANEL_REG_PASS";
            this.PANEL_REG_PASS.Size = new System.Drawing.Size(332, 26);
            this.PANEL_REG_PASS.TabIndex = 2;
            // 
            // PANEL_REG_USR
            // 
            this.PANEL_REG_USR.Location = new System.Drawing.Point(52, 129);
            this.PANEL_REG_USR.Name = "PANEL_REG_USR";
            this.PANEL_REG_USR.Size = new System.Drawing.Size(332, 26);
            this.PANEL_REG_USR.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "Registrar Usuario:";
            // 
            // PANEL_REG_AlertaINSUSER
            // 
            this.PANEL_REG_AlertaINSUSER.AutoSize = true;
            this.PANEL_REG_AlertaINSUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_REG_AlertaINSUSER.ForeColor = System.Drawing.Color.Red;
            this.PANEL_REG_AlertaINSUSER.Location = new System.Drawing.Point(47, 354);
            this.PANEL_REG_AlertaINSUSER.Name = "PANEL_REG_AlertaINSUSER";
            this.PANEL_REG_AlertaINSUSER.Size = new System.Drawing.Size(120, 25);
            this.PANEL_REG_AlertaINSUSER.TabIndex = 10;
            this.PANEL_REG_AlertaINSUSER.Text = "Contraseña:";
            // 
            // VInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(807, 523);
            this.Controls.Add(this.PANEL_Login);
            this.Controls.Add(this.BUTTONS_PANEL);
            this.Controls.Add(this.PANEL_REST);
            this.Controls.Add(this.PANEL_Registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VInici";
            this.Text = "Inici";
            this.Load += new System.EventHandler(this.VInici_Load);
            this.BUTTONS_PANEL.ResumeLayout(false);
            this.FOOTHER_BUTTONS_PANEL.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.ResumeLayout(false);
            this.HEADER_BUTTONS_PANELS.PerformLayout();
            this.PANEL_Login.ResumeLayout(false);
            this.PANEL_Login.PerformLayout();
            this.PANEL_REST.ResumeLayout(false);
            this.PANEL_REST.PerformLayout();
            this.PANEL_Registrar.ResumeLayout(false);
            this.PANEL_Registrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel BUTTONS_PANEL;
        public System.Windows.Forms.FlowLayoutPanel FOOTHER_BUTTONS_PANEL;
        public System.Windows.Forms.Button BT_SHOW_RESTAURANTS;
        public System.Windows.Forms.Button BT_EXIT;
        public System.Windows.Forms.Panel HEADER_BUTTONS_PANELS;
        public System.Windows.Forms.Label AUTORS_PROJECTE;
        public System.Windows.Forms.Label NOM_API;
        public System.Windows.Forms.Label PANEL_REST_Title;
        public System.Windows.Forms.Button PANEL_REST_BT;
        public System.Windows.Forms.Panel PANEL_Login;
        public System.Windows.Forms.Panel PANEL_REST;
        public System.Windows.Forms.TextBox PANEL_REST_TB_RESTID;
        public System.Windows.Forms.Button PANEL_INIC_BTLogin;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PANEL_INIC_TBPass;
        public System.Windows.Forms.TextBox PANEL_INIC_TBUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel PANEL_Registrar;
        public System.Windows.Forms.Button PANEL_REG_BT_Registrar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PANEL_REG_PASS;
        public System.Windows.Forms.TextBox PANEL_REG_USR;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button PANEL_INI_BTRegist;
        public System.Windows.Forms.Button PANEL_REG_BT_Volver;
        public System.Windows.Forms.Label PANEL_REG_AlertaINSUSER;
    }
}