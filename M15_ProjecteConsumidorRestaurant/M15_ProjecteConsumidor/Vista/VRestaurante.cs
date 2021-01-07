using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace M15_ProjecteConsumidor.Vista
{
    public partial class VRestaurante : Form
    {
        double lat { get; set; }
        double lon { get; set; }

        public VRestaurante(double Glat, double Glon)
        {
            lat = Glat;
            lon = Glon;
            InitializeComponent();
            setGMap();
        }

        #region GMAP No he conseguido que el plugin actue en el Controlador del programa, se ve que no es compatible o no he encontrado la forma de usarlo en el MVC...
        public void setGMap()
        {

            GMarkerGoogle marker;
            GMapOverlay markerOverlay;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(this.lat, this.lon);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(this.lat, this.lon), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Latitud:{0}\n Longitud:{1}", this.lat, this.lon);

            //ahora agregamos el mapa y el marcador al control map

            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }
        #endregion

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Restaurante_Load(object sender, EventArgs e)
        {

        }

        private void RES_Title3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RES_Title4_Click(object sender, EventArgs e)
        {

        }

        private void RES_ListBoxDeTipoCocina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RES_Title3_Click_1(object sender, EventArgs e)
        {

        }

        private void RES_Direccion_Click(object sender, EventArgs e)
        {

        }

        private void RES_TipoMoneda_Click(object sender, EventArgs e)
        {

        }

        private void RES_Horas_Click(object sender, EventArgs e)
        {

        }

        private void RES_Telefon_Click(object sender, EventArgs e)
        {

        }

        private void RES_Title1_Click(object sender, EventArgs e)
        {

        }

        private void RES_Nom_ID_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RES_LastMod_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RES_BT_ShowMenu_Click(object sender, EventArgs e)
        {

        }

        private void RES_Title2_Click(object sender, EventArgs e)
        {

        }

        private void RES_GMAP_Load(object sender, EventArgs e)
        {

        }

        private void RES_DGV_Menus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {

        }

        private void trackZoom_Scroll(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
