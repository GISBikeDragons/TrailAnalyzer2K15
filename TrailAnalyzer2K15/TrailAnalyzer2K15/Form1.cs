using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailAnalyzer2K15
{
    public partial class frmBikeAnalyzer2K15 : Form
    {
        public frmBikeAnalyzer2K15()
        {
            InitializeComponent();
            appManager1.LoadExtensions();
        }

        //Button controls for interacting with the map
        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            //delete any shapefile currently on map
            mapMain.AddLayer();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
        }

        private void btnDrawTrail_Click_1(object sender, EventArgs e)
        {
            //delete any shapefile currently on map
            //code to draw a shapefile goes here.
            //this will require more stuff
            /*
             * use pixel to coordinate conversion to find coordinates
             * create a list of click events
             * use a draw function to draw the lines using list of coordinates
             * use double click or right click for user to be done (maybe both)
             */
        }
    }
}
