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
using DotSpatial.Projections;


namespace TrailAnalyzer2K15
{
    public partial class frmBikeAnalyzer2K15 : Form
    {

        bool amDigitizing = false;
        List<Coordinate> drawPointsList = new List<Coordinate>();
        string name;
        MapLineLayer linelyr;
        private IMapRasterLayer MyRasterLayer;
        private IMapFeatureLayer MySampleLine; 

        public frmBikeAnalyzer2K15()
        {
            InitializeComponent();
            appManager1.LoadExtensions();
        }

        //program for analyzing the trail, at least trying
        private void AnalyzeTrailHardness(MapRasterLayer InputRas, MapLineLayer InputShp)
        {
            // Creating a temporary coordinate object to us in our loop below
            Coordinate TempCord;

            // Get the number of points in our polyline
            int NumberOfPoints = InputShp.DataSet.Features[1].NumPoints;

            //Make some temporary variables for the vertex x and y values
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, dx, dy, newx, newy, newz, slope;
            double cellwidth = InputRas.DataSet.CellWidth;

            // Stepping through all the vertices in the polyline
            for (int i = 0; i < NumberOfPoints; i++)
            {
                if (i == 0) 
                {
                    //this is for the first vertex in the polyline
                    //x2 = linelyr.DataSet.
                }
            }
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

            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MyRasterLayer);
                mapMain.Layers.Remove(MySampleLine);
            }
            catch 
            {
                // Do Nothing
            }

            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Easier\\ned_easier\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Easier_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Easier\\SampleTrail_Easier.shp"));
            MySampleLine.LegendText = "SampleTrail_Easier";
            
            // Here we will need to do a sample analysis of the data

                /* */

            // End Analysis of sample data, Add data to Plot

            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();
                /* */

            // End of Adding Data to plot

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // Change the title, x-axis, and y-axis text for the easier sample data
            myPane.Title = "Sample: Easier Trail";
            myPane.XAxis.Title = "Total Distance [m]";
            myPane.YAxis.Title = "Elevation [m]";

            // Refreshing the plot
            zedGraphElevationPlot.AxisChange();
            zedGraphElevationPlot.Invalidate();
            zedGraphElevationPlot.Refresh();

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
            tabControl1.SelectedIndex = 1;

        }

        private void mapMain_MouseClick(object sender, MouseEventArgs e)
        {
            //digitizing polyline
            if (amDigitizing == true)
            {
                Coordinate c = new Coordinate();
                System.Drawing.Point p = new System.Drawing.Point();
                p.X = e.X;
                p.Y = e.Y;
                c = mapMain.PixelToProj(p);

                drawPointsList.Add(c);

            }
        }

        private void mapMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //finish drawing polyline
            if (amDigitizing == true)
            {
                Coordinate c = new Coordinate();
                System.Drawing.Point p = new System.Drawing.Point();
                p.X = e.X;
                p.Y = e.Y;
                c = mapMain.PixelToProj(p);

                foreach (Coordinate c1 in drawPointsList)
                {
                    if ((c.X / c1.X) < 0.05)   //ensures an intentional double click
                    {
                        drawPointsList.Add(c);
                    }
                }

                amDigitizing = false;

                //show the line being drawn by user in the legend
                var list = mapMain.Layers.Where(item => item.LegendText == "Drawing Trail");
                IMapLineLayer l1 = null;
                foreach (var item in list)
                {
                    Console.WriteLine(item.LegendText.ToString());
                    l1 = (IMapLineLayer)item;
                }

                //delete "drawing trail" when user is done digitizing
                mapMain.Layers.Remove(l1);
                mapMain.FunctionMode = FunctionMode.Select;

                //create new polyline layer
                Feature f = new Feature(FeatureType.Line, drawPointsList);
                FeatureSet fs = new FeatureSet();
                fs.Projection = mapMain.Projection;
                fs.AddFeature(f);

                //allow user to save shapefile
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "shapefiles (*shp|";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IFeature fe = (Feature)fs.Features[0];

                    IList<Coordinate> loadPointList = fe.BasicGeometry.Coordinates;

                    if (!saveFileDialog1.FileName.ToLower().Contains(".shp"))
                    {
                        saveFileDialog1.FileName += ".shp";
                    }
                    fs.SaveAs(saveFileDialog1.FileName, true);
                    linelyr = (MapLineLayer)mapMain.AddLayer(saveFileDialog1.FileName);
                    name = linelyr.DataSet.Name;

                    //plot on zedgraph
                    //zedGraphThatLine(loadPointList, name);
                }

                mapMain.Invalidate();

            }
        }

        private void btnDrawTrail_Click_1(object sender, EventArgs e)
        {
            amDigitizing = true;
        }

        private void btnSampleModerate_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Moderate" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MyRasterLayer);
                mapMain.Layers.Remove(MySampleLine);
            }
            catch
            {
                // Do Nothing
            }

            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Moderate\\ned_moderate\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Moderate_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Moderate\\SampleTrail_Moderate.shp"));
            MySampleLine.LegendText = "SampleTrail_Moderate";

            // Here we will need to do a sample analysis of the data

            /* */

            // End Analysis of sample data, Add data to Plot

            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();
            /* */

            // End of Adding Data to plot

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // Change the title, x-axis, and y-axis text for the Moderate sample data
            myPane.Title = "Sample: Moderate Trail";
            myPane.XAxis.Title = "Total Distance [m]";
            myPane.YAxis.Title = "Elevation [m]";

            // Refreshing the plot
            zedGraphElevationPlot.AxisChange();
            zedGraphElevationPlot.Invalidate();
            zedGraphElevationPlot.Refresh();

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
            tabControl1.SelectedIndex = 1;
        }

        private void btnSampleExpert_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Expert" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MyRasterLayer);
                mapMain.Layers.Remove(MySampleLine);
            }
            catch
            {
                // Do Nothing
            }

            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Expert\\ned_expert\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Expert_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Expert\\SampleTrail_Expert.shp"));
            MySampleLine.LegendText = "SampleTrail_Expert";

            // Here we will need to do a sample analysis of the data

            /* */

            // End Analysis of sample data, Add data to Plot

            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();
            /* */

            // End of Adding Data to plot

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // Change the title, x-axis, and y-axis text for the Expert sample data
            myPane.Title = "Sample: Expert Trail";
            myPane.XAxis.Title = "Total Distance [m]";
            myPane.YAxis.Title = "Elevation [m]";

            // Refreshing the plot
            zedGraphElevationPlot.AxisChange();
            zedGraphElevationPlot.Invalidate();
            zedGraphElevationPlot.Refresh();

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
            tabControl1.SelectedIndex = 1;
        }

        private void btnSampleExtreme_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Extreme" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MyRasterLayer);
                mapMain.Layers.Remove(MySampleLine);
            }
            catch
            {
                // Do Nothing
            }

            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Extreme\\ned_extreme\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Extreme_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Extreme\\SampleTrail_Extreme.shp"));
            MySampleLine.LegendText = "SampleTrail_Extreme";

            // Here we will need to do a sample analysis of the data

            /* */

            // End Analysis of sample data, Add data to Plot

            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();
            /* */

            // End of Adding Data to plot

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // Change the title, x-axis, and y-axis text for the Extreme sample data
            myPane.Title = "Sample: Extreme Trail";
            myPane.XAxis.Title = "Total Distance [m]";
            myPane.YAxis.Title = "Elevation [m]";

            // Refreshing the plot
            zedGraphElevationPlot.AxisChange();
            zedGraphElevationPlot.Invalidate();
            zedGraphElevationPlot.Refresh();

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
            tabControl1.SelectedIndex = 1;
        }
    }
}
