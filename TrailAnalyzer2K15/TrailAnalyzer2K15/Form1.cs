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
        #region Variables
        bool amDigitizing = false;
        bool firstPoint = true;
        bool AnalysisComplete = true;
        List<Coordinate> drawPointsList = new List<Coordinate>();
        string name;
        MapLineLayer linelyr;
        private IMapRasterLayer MyRasterLayer;
        private IMapFeatureLayer MySampleLine;
        //private MapRasterLayer MyRasterLayer;
        //private MapLineLayer MySampleLine;
        private List<Coordinate> MyExtractedPoints = new List<Coordinate>();
        #endregion

        public frmBikeAnalyzer2K15()
        {
            InitializeComponent();
            appManager1.LoadExtensions();
        }

        //program for analyzing the trail, at least trying
        private void AnalyzeTrailHardness(IMapRasterLayer InputRas, IMapFeatureLayer InputShp)
        {

            if (InputShp != null & InputRas != null)
            {
                #region FindTrailElevations
                // Creating a temporary coordinate object to us in our loop below
                Coordinate TempCord;
                MyExtractedPoints.Clear(); // Needs to clear each time so we don't keep the previous graph

                // Get the number of points in our polyline
                int NumberOfPoints = InputShp.DataSet.Features[0].NumPoints;

                //Make some temporary variables for the vertex x and y values
                double x1 = 0, y1 = 0, x2 = 0, y2 = 0, dx, dy, newx, newy, newz, slope;
                double cellwidth = InputRas.DataSet.CellWidth;

                // Stepping through all the vertices in the polyline
                for (int i = 0; i < NumberOfPoints; i++)
                {
                    if (i == 0)
                    {
                        // This is for the first vertex in the polyline
                        x2 = InputShp.DataSet.Features[0].Coordinates[i].X;
                        y2 = InputShp.DataSet.Features[0].Coordinates[i].Y;
                    }
                    else
                    {
                        // Set the current start vertex to be the last end vertex.
                        x1 = x2;
                        y1 = y2;

                        // Reset the current x and y = x2 and y2
                        x2 = InputShp.DataSet.Features[0].Coordinates[i].X;
                        y2 = InputShp.DataSet.Features[0].Coordinates[i].Y;

                        //Get the distance between x1 y1 x2 and y2
                        dx = x2 - x1;
                        dy = y2 - y1;
                        slope = dy / dx;

                        //walk along the line segment from point 1 to point 2 at 1 grid cell width at a time
                        TempCord = new Coordinate();
                        newx = x1;
                        newy = y1;
                        while (newx < x2)
                        {
                            //at each step along the line segment, get the x, y, and z values.
                            newx += cellwidth;
                            newy += cellwidth * slope;
                            newz = RasterExt.GetNearestValue(InputRas.DataSet, newx, newy);

                            //now set up a coordinate that has these values
                            TempCord = new Coordinate();
                            TempCord.X = newx;
                            TempCord.Y = newy;
                            TempCord.Z = newz;
                            MyExtractedPoints.Add(TempCord);
                        }
                        //End While
                    }
                    //end first IF ELSE
                }
                //end first loop
                #endregion

                #region CalculatingPlots
                //now we need to analyze the list of elevations and coordinates
                //loop through MyExtractedPoints to find distance and slope of each point

                // Get the number of points in our coordinate list
                int NumPointsCoordinates = MyExtractedPoints.Count;

                // Need a list of hypotenues, elevation differences, etc...
                double[] plotX = new double[NumPointsCoordinates];
                double[] plotY = new double[NumPointsCoordinates];
                double[] ElevSlope = new double[NumPointsCoordinates];
                double x3 = 0, y3 = 0, x4 = 0, y4 = 0, dx34 = 0, dy34 = 0;
                double z3 = 0, z4 = 0, dz34 = 0;
                double hyp = 0, TotalLength = 0;
                double TempElevSlope = 0;
                double UphillDistance = 0, UphillTotalClimb = 0, ElevationDifference = 0, MaxUphillSlope = 0;
                double DownhillDistance = 0, MaxDownhillSlope = 0;
                string difficultyLevel = "";

                //show progress bar
                toolStripProgressBar1.Visible = true;
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Analyzing Trail: " + InputShp.LegendText;
                toolStripProgressBar1.Maximum = NumPointsCoordinates;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Step = 1;

                // Stepping through all the vertices in the polyline
                for (int j = 0; j < NumPointsCoordinates; j++)
                {
                    toolStripProgressBar1.Value++;
                    // For the first loop, only set some parameters up
                    if (j == 0)
                    {
                        x4 = MyExtractedPoints[j].X;
                        y4 = MyExtractedPoints[j].Y;
                        z4 = MyExtractedPoints[j].Z;
                        plotX[j] = TotalLength;
                        plotY[j] = z4;
                    }
                    // For the rest of the loop, we can do some calculations!
                    else
                    {
                        // Set the new '3' to the previous coordinate
                        x3 = x4;
                        y3 = y4;
                        z3 = z4;
                        // Find the next coordinate for the '4'
                        x4 = MyExtractedPoints[j].X;
                        y4 = MyExtractedPoints[j].Y;
                        z4 = MyExtractedPoints[j].Z;
                        // Now find the relative distances and elevation slope
                        dx34 = Math.Abs(x3 - x4);
                        dy34 = Math.Abs(y3 - y4);
                        dz34 = z4 - z3; //order matters here, going from 3 to 4, so if elevation is up (+) then we need to do z4-z3 :)
                        // Find hyp and add to plot x for plotting on the ZedGraph
                        hyp = Math.Sqrt(Math.Pow(dx34, 2) + Math.Pow(dy34, 2));
                        TotalLength = TotalLength + hyp;
                        plotX[j] = TotalLength;
                        // Find elev and add to plot y for plotting on the ZedGraph
                        plotY[j] = z4;
                        // Calculating TempElevSlope and add to the list ElevSlope
                        TempElevSlope = dz34 / hyp;
                        ElevSlope[j] = TempElevSlope;
                        // Find Total Distance Uphill and Climb Uphill if dz34 is postive, else it's downhill and find that total
                        if (dz34 >= 0)
                        {
                            UphillDistance = UphillDistance + hyp;
                            UphillTotalClimb = UphillTotalClimb + dz34;
                        }
                        else
                        {
                            DownhillDistance = DownhillDistance + hyp;
                        }
                        //end ifstatement
                    }
                    //End if statement
                }
                // End for loop for plotx,ploty,andElevSlope lists

                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Analysis Complete";
                //toolStripStatusLabel1.Visible = false;

                // Time to finish up our calculations
                ElevationDifference = plotY.Max() - plotY.Min();
                MaxUphillSlope = ElevSlope.Max();
                MaxDownhillSlope = ElevSlope.Min();
                #endregion

                #region PlotZedGraphCurve
                // Now we need to plot to the ZedGraph
                // GraphPane object holds one or more Curve objects (or plots)
                GraphPane myPane1 = zedGraphElevationPlot.GraphPane;
                // Need a pointpair list to hold the plot values
                PointPairList XandY = new PointPairList(plotX, plotY);
                // Add curves to myPane1 object
                LineItem myCurve = myPane1.AddCurve("Cross Section", XandY, Color.ForestGreen, ZedGraph.SymbolType.None);
                myCurve.Line.Fill = new Fill(Color.LightBlue, Color.Blue, Color.Navy);
                myCurve.Line.Width = 3.0F;
                //End of editing ZedGraph here, finish it somewhere else
                #endregion

                #region Algorithm
                //algorithm Variables
                int slopeA = 0; int slopeB = 0; int slopeC = 0; int slopeD = 0; int slopeE = 0;
                double percentSlopeA = 0;
                double percentSlopeB = 0;
                double percentSlopeC = 0;
                double percentSlopeD = 0;
                double percentSlopeE = 0;

                int elevClimb = 0;
                int distance = 0;
                int maxSlope = 0;
                int slopeD_weight = 0;
                int slopeE_weight = 0;

                int totalDifficulty = 0;

                //count how many sections are in each slope range
                foreach (double slope1 in ElevSlope)
                {
                    if (slope1 < 0)
                    {
                        slopeA += 1;
                    }
                    else if (slope1 >= 0 & slope1 < 0.1)
                    {
                        slopeB += 1;
                    }
                    else if (slope1 >= 0.1 & slope1 < 0.3)
                    {
                        slopeC += 1;
                    }
                    else if (slope1 >= 0.3 & slope1 < 0.4)
                    {
                        slopeD += 1;
                    }
                    else if (slope1 >= 0.4)
                    {
                        slopeE += 1;
                    }

                }

                int numSlopePoints = slopeA + slopeB + slopeC + slopeD + slopeE;
                //calculate the percentage that each slope occurs
                percentSlopeA = (double)slopeA / (double)numSlopePoints * 100;
                percentSlopeB = (double)slopeB / (double)numSlopePoints * 100;
                percentSlopeC = (double)slopeC / (double)numSlopePoints * 100;
                percentSlopeD = (double)slopeD / (double)numSlopePoints * 100;
                percentSlopeE = (double)slopeE / (double)numSlopePoints * 100;



                if (percentSlopeD > 1)
                {
                    slopeD_weight += 1;
                    if (percentSlopeD > 4)
                    {
                        slopeD_weight += 1;
                        if (percentSlopeD > 7)
                        {
                            slopeD_weight += 1;
                            if (percentSlopeD > 10)
                            { slopeD_weight += 1; }
                        }
                    }
                }

                if (percentSlopeE > 1)
                {
                    slopeE_weight += 1;
                    if (percentSlopeE > 3)
                    {
                        slopeE_weight += 2;
                        if (percentSlopeE > 5)
                        {
                            slopeE_weight += 2;
                            if (percentSlopeE > 7)
                            { slopeE_weight += 1; }
                        }
                    }
                }

                if (MaxUphillSlope > 0)
                {
                    maxSlope += 1;
                    if (MaxUphillSlope > .2)
                    {
                        maxSlope += 1;
                        if (MaxUphillSlope > .4)
                        {
                            maxSlope += 1;
                            if (MaxUphillSlope > .5)
                            { maxSlope += 1; }
                        }
                    }
                }

                if (TotalLength > 4000)
                {
                    distance += 1;
                    if (TotalLength > 5500)
                    {
                        distance += 1;
                        if (TotalLength > 7500)
                        {
                            distance += 1;
                            if (TotalLength > 10000)
                            { distance += 1; }
                        }
                    }
                }

                if (UphillTotalClimb > 100)
                {
                    elevClimb += 1;
                    if (UphillTotalClimb > 250)
                    {
                        elevClimb += 1;
                        if (UphillTotalClimb > 450)
                        {
                            elevClimb += 1;
                            if (UphillTotalClimb > 700)
                            { elevClimb += 2; }
                        }
                    }
                }
                //sum each factor of difficulty
                totalDifficulty = elevClimb + distance + maxSlope + slopeD_weight + slopeE_weight;

                //determine difficulty level
                if (totalDifficulty <= 7)
                {
                    difficultyLevel = "Easy";
                }
                if (totalDifficulty > 7 & totalDifficulty <= 14)
                {
                    difficultyLevel = "Moderate";
                }
                if (totalDifficulty > 14 & totalDifficulty <= 21)
                {
                    difficultyLevel = "Difficult";
                }
                if (totalDifficulty > 21)
                {
                    difficultyLevel = "Extreme";
                }
                #endregion

                #region DialogRatingLabels
                //Fill out the Dialog Rating Labels
                lblRating.Text = "Physical Difficulty: " + difficultyLevel;
                lblTotalDistance.Text = "Distance: " + Convert.ToString(Math.Round(TotalLength, 0)) + " m";
                lblDistanceUp.Text = "Distance (Uphill): " + Convert.ToString(Math.Round(UphillDistance, 0)) + " m";
                lblDistanceDown.Text = "Distance (Downhill): " + Convert.ToString(Math.Round(DownhillDistance, 0)) + " m";
                lblMaxUpSlope.Text = "Max Uphill Slope: " + Convert.ToString(Math.Round(MaxUphillSlope, 2));
                lblElevationClimb.Text = "Cummulative Elevation Climb: " + Convert.ToString(Math.Round(UphillTotalClimb, 0)) + " m";
                lblElevationDifference.Text = "Max Elevation Difference: " + Convert.ToString(Math.Round(ElevationDifference, 0)) + " m";
                lblMaxDownSlope.Text = "Max Downhill Slope: " + Convert.ToString(Math.Round(MaxDownhillSlope, 2));
                #endregion
                AnalysisComplete = true;
            }
            else
            {
                MessageBox.Show("Please import a DEM or draw/import a trail before running the analysis.");
                AnalysisComplete = false;
                return;
            }

        }

       


        private void frmBikeAnalyzer2K15_Load(object sender, EventArgs e)
        {
            resizeForm();
        }
        private void resizeForm()
        {
            sptInterface_Map.SplitterDistance = 171;
            sptButtons_Legend.SplitterDistance = 207;
        }

        //Button controls for interacting with the map
        #region Click Events

        #region Map Navigation Click Events
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
        #endregion

        #region Custom Trail Buttons

        private void btnDrawTrail_Click_1(object sender, EventArgs e)
        {

            if (MyRasterLayer != null)
            {              
                amDigitizing = true;
                tabControl1.SelectedIndex = 0;
                mapMain.Cursor = Cursors.Cross;
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Click on map to draw line. Double-click to finish.";

                if (MySampleLine != null)
                {
                    mapMain.Layers.Remove(MySampleLine);
                }
            }
            else
            {
                MessageBox.Show("Import a DEM before drawing a line");
            }


        }

        private void mapMain_MouseClick(object sender, MouseEventArgs e)
        {
            //digitizing polyline
            if (amDigitizing == true)
            {
                if (firstPoint == true)
                {
                    drawPointsList.Clear();
                    firstPoint = false;
                }

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
                        firstPoint = true;
                    }
                }

                amDigitizing = false;
                firstPoint = true;

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


                //create new polyline layer
                Feature f = new Feature(FeatureType.Line, drawPointsList);
                FeatureSet fs = new FeatureSet();
                fs.Projection = mapMain.Projection;
                fs.AddFeature(f);

                //clears list for next line
                //drawPointsList.Clear();

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

                    MySampleLine = linelyr;


                }

                mapMain.Invalidate();
                mapMain.Cursor = Cursors.Arrow;
                toolStripStatusLabel1.Visible = false;
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {

            //Make users see their whole trail and raster
            mapMain.ZoomToMaxExtent();

            #region AnalyzeAndZedGraph
            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();

            // Here we will need to do a sample analysis of the data
            AnalyzeTrailHardness(MyRasterLayer, MySampleLine);

            if (AnalysisComplete == true)
            {
                // End of Adding Data to plot

                // GraphPane object holds one or more Curve objects (or plots)
                GraphPane myPane = zedGraphElevationPlot.GraphPane;

                // Change the title, x-axis, and y-axis text for the Expert sample data
                myPane.Title = MySampleLine.LegendText;
                myPane.XAxis.Title = "Total Distance [m]";
                myPane.YAxis.Title = "Elevation [m]";

                // Refreshing the plot
                zedGraphElevationPlot.AxisChange();
                zedGraphElevationPlot.Invalidate();
                zedGraphElevationPlot.Refresh();
                lblTitle.Text = MySampleLine.LegendText;


                // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
                tabControl1.SelectedIndex = 1;
            }
            #endregion

        }

        private void btnAddRaster_Click(object sender, EventArgs e)
        {
            #region TryCatchDeletePreviousData
            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MyRasterLayer);
            }
            catch
            {
                // Do Nothing
            }
            #endregion
            MyRasterLayer = mapMain.AddRasterLayer();
            MyRasterLayer.LegendText = Microsoft.VisualBasic.Interaction.InputBox("What would you like to call your Raster/DEM/NED?", "Add and Name Raster/DEM/NED", MyRasterLayer.LegendText);
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            #region TryCatchDeletePreviousData
            // Delete Previous Layers if already there, using a try-catch reference
            try
            {
                mapMain.Layers.Remove(MySampleLine);
            }
            catch
            {
                // Do Nothing
            }
            #endregion
            try
            {
                MySampleLine = mapMain.AddFeatureLayer();
                MySampleLine.LegendText = Microsoft.VisualBasic.Interaction.InputBox("What is your trail's name?", "Add and Name Trail", MySampleLine.LegendText);
            }
            catch { }

        }
        #endregion

        #region Sample Data Buttons
        private void btnSampleEasier_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Easier" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            #region TryCatchDeletePreviousSampleData
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
            #endregion

            #region AddNewSampleData
            // Load in the sample data, background data first
            // 1) Load in raster first           
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Easier\\ned_easier\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Easier_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Easier\\SampleTrail_Easier.shp"));
            MySampleLine.LegendText = "SampleTrail_Easier";
            // End Analysis of sample data, Add data to Plot
            #endregion

            #region AnalyzeAndZedGraph
            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphElevationPlot.GraphPane;

            // This is to remove all plots
            try
            {
                myPane.CurveList.Clear();
            }
            catch { }

            // Here we will need to do a sample analysis of the data
            AnalyzeTrailHardness(MyRasterLayer, MySampleLine);
            // End of Adding Data to plot

            // Change the title, x-axis, and y-axis text for the easier sample data
            myPane.Title = "Sample: Easier Trail";
            myPane.XAxis.Title = "Total Distance [m]";
            myPane.YAxis.Title = "Elevation [m]";
            lblTitle.Text = "Easier Trail";

            // Refreshing the plot
            zedGraphElevationPlot.AxisChange();
            zedGraphElevationPlot.Invalidate();
            zedGraphElevationPlot.Refresh();
            #endregion

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)

            tabControl1.SelectedIndex = 1;

        }

        private void btnSampleModerate_Click(object sender, EventArgs e)
        {
            /* 
             * The purpose of this button is to show the user how a real trail
             * rated as "Moderate" would look like for when they decide to load
             * in or draw a trail and import a raster for analysis.
             */

            #region TryCatchDeletePreviousSampleData
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
            #endregion

            #region AddNewSampleData
            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Moderate\\ned_moderate\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Moderate_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Moderate\\SampleTrail_Moderate.shp"));
            MySampleLine.LegendText = "SampleTrail_Moderate";
            // End Analysis of sample data, Add data to Plot
            #endregion

            #region AnalyzeAndZedGraph
            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();

            // Here we will need to do a sample analysis of the data
            AnalyzeTrailHardness(MyRasterLayer, MySampleLine);

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
            lblTitle.Text = "Moderate Trail";
            #endregion

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

            #region TryCatchPreviousSampleData
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
            #endregion

            #region AddNewSampleData
            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Expert\\ned_expert\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Expert_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Expert\\SampleTrail_Expert.shp"));
            MySampleLine.LegendText = "SampleTrail_Expert";
            // End Analysis of sample data, Add data to Plot
            #endregion

            #region AnalyzeAndZedGraph
            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();

            // Here we will need to do a sample analysis of the data
            AnalyzeTrailHardness(MyRasterLayer, MySampleLine);

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
            lblTitle.Text = "Expert Trail";
            #endregion

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

            #region TryCatchPreviousSampleData
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
            #endregion

            #region AddNewSampleData
            // Load in the sample data, background data first
            // 1) Load in raster first
            MyRasterLayer = mapMain.Layers.Add(Raster.Open("..\\data\\Sample_Extreme\\ned_extreme\\prj.adf"));
            MyRasterLayer.LegendText = "NED10_Extreme_Raster";
            mapMain.ZoomToMaxExtent();
            // 2) Load in shapefile after, so that it is seen above the raster in the map and legend
            MySampleLine = mapMain.Layers.Add(Shapefile.Open("..\\data\\Sample_Extreme\\SampleTrail_Extreme.shp"));
            MySampleLine.LegendText = "SampleTrail_Extreme";
            // End Analysis of sample data, Add data to Plot
            #endregion

            #region AnalyzeAndZedGraph
            // This is to remove all plots
            zedGraphElevationPlot.GraphPane.CurveList.Clear();

            // Here we will need to do a sample analysis of the data
            AnalyzeTrailHardness(MyRasterLayer, MySampleLine);

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
            #endregion

            // Show the graph now by changing the tab index from 0 (Map) to 1 (Graph)
            tabControl1.SelectedIndex = 1;
        }
        #endregion


        #endregion

        private void frmBikeAnalyzer2K15_SizeChanged(object sender, EventArgs e)
        {
            resizeForm();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                toolStripStatusLabel1.Visible = false;
            }
        }
    }
}
