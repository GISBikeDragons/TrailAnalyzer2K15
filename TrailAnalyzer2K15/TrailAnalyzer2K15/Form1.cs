using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;   //added for creating shapefiles with DotSpatial
using DotSpatial.Data;       //added for creating shapefiles with DotSpatial
using DotSpatial.Symbology;  //added for creating shapefiles with DotSpatial
using DotSpatial.Topology;   //added for creating shapefiles with DotSpatial

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

            //Declare the following class level variables
            #region Polyline_Shapefile class level variables

                MapLineLayer linelayer = default(MapLineLayer);
                
                //the line feature set
                FeatureSet lineF = new FeatureSet(FeatureType.Line);

                int lineID = 0;

                //boolean variable for first time mouse click
                bool firstClick = false;

                //It controls the drawing the polyline after the polyline saved operation
                bool linemouseClick = false;

            #endregion

            //Write the following code into CreatePolylineShapeFileToolStripMenuItem_Click event
            private void CreatePolylineShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
                {
                //change the mouse cursor
                mapMain.Cursor = Cursors.Cross;

                //set shape type
                ShapeType = "line";

                //set projection
                LineF.Projection = mapMain.Projection;

                //initialize the featureSet attribute table
                DataColumn column = new DataColumn("LineID");

                if (!LineF.DataTable.Columns.Contains("LineID");
                {
                    LineF.DataTable.Columns.Add(column);
                }

                //add the featureSet as map layer
                lineLayer = (MapLineLayer)mapMain.Layers.Add(lineF);

                //Set the symbolizer to the line feature
                LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
                lineLayer.symbology = symbol
                lineLayer.LegendText = "line";

                firstClick = true

                linemouseClick = true

                //COntinue code from "DotSpatial_Tutorial_4", a Word *.docx from online...
    }
}
