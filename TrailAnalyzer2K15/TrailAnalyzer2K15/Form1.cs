using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using DotSpatial;
using DotSpatial.Data;
using DotSpatial.Controls;
using DotSpatial.Topology;


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
        private void btnDrawTrail_Click(object sender, EventArgs e)
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

        private void frmBikeAnalyzer2K15_Load(object sender, EventArgs e)
        {
            //mapMain.AddRasterLayer();
        }

        private void btnSampleEasier_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Easier" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // Change the title text to Easier Sample Data
            myPane.Title = "Sample: Easier Trail";



        }
    }
}
