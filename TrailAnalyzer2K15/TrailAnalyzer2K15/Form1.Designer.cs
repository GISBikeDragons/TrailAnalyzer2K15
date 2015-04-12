namespace TrailAnalyzer2K15
{
    partial class frmBikeAnalyzer2K15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBikeAnalyzer2K15));
            this.menLayoutMenuStrip = new DotSpatial.Controls.LayoutMenuStrip();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sptInterface_Map = new System.Windows.Forms.SplitContainer();
            this.sptButtons_Legend = new System.Windows.Forms.SplitContainer();
            this.btnAddRaster = new System.Windows.Forms.Button();
            this.grpboxSampleData = new System.Windows.Forms.GroupBox();
            this.btnSampleModerate = new System.Windows.Forms.Button();
            this.btnSampleEasier = new System.Windows.Forms.Button();
            this.btnSampleExtreme = new System.Windows.Forms.Button();
            this.btnSampleExpert = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnDrawTrail = new System.Windows.Forms.Button();
            this.btnAddLayer = new System.Windows.Forms.Button();
            this.lgdMapLegend = new DotSpatial.Controls.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.mapMain = new DotSpatial.Controls.Map();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.sptGraphDialog = new System.Windows.Forms.SplitContainer();
            this.zedGraphElevationPlot = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTotalDistance = new System.Windows.Forms.Label();
            this.lblDistanceUp = new System.Windows.Forms.Label();
            this.lblElevationClimb = new System.Windows.Forms.Label();
            this.lblMaxUpSlope = new System.Windows.Forms.Label();
            this.lblElevationDifference = new System.Windows.Forms.Label();
            this.lblMaxDownSlope = new System.Windows.Forms.Label();
            this.lblDistanceDown = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menLayoutMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptInterface_Map)).BeginInit();
            this.sptInterface_Map.Panel1.SuspendLayout();
            this.sptInterface_Map.Panel2.SuspendLayout();
            this.sptInterface_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptButtons_Legend)).BeginInit();
            this.sptButtons_Legend.Panel1.SuspendLayout();
            this.sptButtons_Legend.Panel2.SuspendLayout();
            this.sptButtons_Legend.SuspendLayout();
            this.grpboxSampleData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptGraphDialog)).BeginInit();
            this.sptGraphDialog.Panel1.SuspendLayout();
            this.sptGraphDialog.Panel2.SuspendLayout();
            this.sptGraphDialog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).BeginInit();
            this.spatialStatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menLayoutMenuStrip
            // 
            this.menLayoutMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layersToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.menLayoutMenuStrip.LayoutControl = null;
            this.menLayoutMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menLayoutMenuStrip.Name = "menLayoutMenuStrip";
            this.menLayoutMenuStrip.Size = new System.Drawing.Size(755, 24);
            this.menLayoutMenuStrip.TabIndex = 0;
            this.menLayoutMenuStrip.Text = "layoutMenuStrip1";
            // 
            // layersToolStripMenuItem
            // 
            this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLayerToolStripMenuItem,
            this.deleteLayerToolStripMenuItem});
            this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
            this.layersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.layersToolStripMenuItem.Text = "Layers";
            // 
            // addLayerToolStripMenuItem
            // 
            this.addLayerToolStripMenuItem.Name = "addLayerToolStripMenuItem";
            this.addLayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addLayerToolStripMenuItem.Text = "Add Layer";
            // 
            // deleteLayerToolStripMenuItem
            // 
            this.deleteLayerToolStripMenuItem.Name = "deleteLayerToolStripMenuItem";
            this.deleteLayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteLayerToolStripMenuItem.Text = "Delete Layer";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLayerToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // manageLayerToolStripMenuItem
            // 
            this.manageLayerToolStripMenuItem.Name = "manageLayerToolStripMenuItem";
            this.manageLayerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manageLayerToolStripMenuItem.Text = "Manage Layer";
            // 
            // sptInterface_Map
            // 
            this.sptInterface_Map.BackColor = System.Drawing.Color.Gainsboro;
            this.sptInterface_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptInterface_Map.Location = new System.Drawing.Point(3, 3);
            this.sptInterface_Map.Name = "sptInterface_Map";
            // 
            // sptInterface_Map.Panel1
            // 
            this.sptInterface_Map.Panel1.Controls.Add(this.sptButtons_Legend);
            // 
            // sptInterface_Map.Panel2
            // 
            this.sptInterface_Map.Panel2.Controls.Add(this.tabControl1);
            this.sptInterface_Map.Size = new System.Drawing.Size(741, 493);
            this.sptInterface_Map.SplitterDistance = 162;
            this.sptInterface_Map.TabIndex = 1;
            // 
            // sptButtons_Legend
            // 
            this.sptButtons_Legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptButtons_Legend.Location = new System.Drawing.Point(0, 0);
            this.sptButtons_Legend.Name = "sptButtons_Legend";
            this.sptButtons_Legend.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptButtons_Legend.Panel1
            // 
            this.sptButtons_Legend.Panel1.BackColor = System.Drawing.Color.White;
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnAddRaster);
            this.sptButtons_Legend.Panel1.Controls.Add(this.grpboxSampleData);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnGraph);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnDrawTrail);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnAddLayer);
            this.sptButtons_Legend.Panel1.Margin = new System.Windows.Forms.Padding(1);
            // 
            // sptButtons_Legend.Panel2
            // 
            this.sptButtons_Legend.Panel2.Controls.Add(this.lgdMapLegend);
            this.sptButtons_Legend.Size = new System.Drawing.Size(162, 493);
            this.sptButtons_Legend.SplitterDistance = 225;
            this.sptButtons_Legend.TabIndex = 0;
            // 
            // btnAddRaster
            // 
            this.btnAddRaster.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddRaster.Location = new System.Drawing.Point(84, 9);
            this.btnAddRaster.Name = "btnAddRaster";
            this.btnAddRaster.Size = new System.Drawing.Size(67, 63);
            this.btnAddRaster.TabIndex = 8;
            this.btnAddRaster.Text = "Add Raster";
            this.btnAddRaster.UseVisualStyleBackColor = false;
            this.btnAddRaster.Click += new System.EventHandler(this.btnAddRaster_Click);
            // 
            // grpboxSampleData
            // 
            this.grpboxSampleData.Controls.Add(this.btnSampleModerate);
            this.grpboxSampleData.Controls.Add(this.btnSampleEasier);
            this.grpboxSampleData.Controls.Add(this.btnSampleExtreme);
            this.grpboxSampleData.Controls.Add(this.btnSampleExpert);
            this.grpboxSampleData.Location = new System.Drawing.Point(5, 106);
            this.grpboxSampleData.Name = "grpboxSampleData";
            this.grpboxSampleData.Size = new System.Drawing.Size(154, 108);
            this.grpboxSampleData.TabIndex = 7;
            this.grpboxSampleData.TabStop = false;
            this.grpboxSampleData.Text = "Sample Trail Data";
            // 
            // btnSampleModerate
            // 
            this.btnSampleModerate.BackColor = System.Drawing.Color.Blue;
            this.btnSampleModerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSampleModerate.Location = new System.Drawing.Point(79, 22);
            this.btnSampleModerate.Name = "btnSampleModerate";
            this.btnSampleModerate.Size = new System.Drawing.Size(67, 35);
            this.btnSampleModerate.TabIndex = 4;
            this.btnSampleModerate.Text = "Moderate";
            this.btnSampleModerate.UseVisualStyleBackColor = false;
            this.btnSampleModerate.Click += new System.EventHandler(this.btnSampleModerate_Click);
            // 
            // btnSampleEasier
            // 
            this.btnSampleEasier.BackColor = System.Drawing.Color.Lime;
            this.btnSampleEasier.Location = new System.Drawing.Point(6, 22);
            this.btnSampleEasier.Name = "btnSampleEasier";
            this.btnSampleEasier.Size = new System.Drawing.Size(67, 35);
            this.btnSampleEasier.TabIndex = 3;
            this.btnSampleEasier.Text = "Easy";
            this.btnSampleEasier.UseVisualStyleBackColor = false;
            this.btnSampleEasier.Click += new System.EventHandler(this.btnSampleEasier_Click);
            // 
            // btnSampleExtreme
            // 
            this.btnSampleExtreme.BackColor = System.Drawing.Color.Red;
            this.btnSampleExtreme.Location = new System.Drawing.Point(79, 64);
            this.btnSampleExtreme.Name = "btnSampleExtreme";
            this.btnSampleExtreme.Size = new System.Drawing.Size(67, 35);
            this.btnSampleExtreme.TabIndex = 6;
            this.btnSampleExtreme.Text = "Extreme";
            this.btnSampleExtreme.UseVisualStyleBackColor = false;
            this.btnSampleExtreme.Click += new System.EventHandler(this.btnSampleExtreme_Click);
            // 
            // btnSampleExpert
            // 
            this.btnSampleExpert.BackColor = System.Drawing.Color.Yellow;
            this.btnSampleExpert.Location = new System.Drawing.Point(6, 64);
            this.btnSampleExpert.Name = "btnSampleExpert";
            this.btnSampleExpert.Size = new System.Drawing.Size(67, 35);
            this.btnSampleExpert.TabIndex = 5;
            this.btnSampleExpert.Text = "Expert";
            this.btnSampleExpert.UseVisualStyleBackColor = false;
            this.btnSampleExpert.Click += new System.EventHandler(this.btnSampleExpert_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.Plum;
            this.btnGraph.Location = new System.Drawing.Point(11, 78);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(140, 23);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "Graph and Analyze";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnDrawTrail
            // 
            this.btnDrawTrail.BackColor = System.Drawing.Color.Gold;
            this.btnDrawTrail.Location = new System.Drawing.Point(11, 49);
            this.btnDrawTrail.Name = "btnDrawTrail";
            this.btnDrawTrail.Size = new System.Drawing.Size(67, 23);
            this.btnDrawTrail.TabIndex = 1;
            this.btnDrawTrail.Text = "Draw Trail";
            this.btnDrawTrail.UseVisualStyleBackColor = false;
            this.btnDrawTrail.Click += new System.EventHandler(this.btnDrawTrail_Click_1);
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.BackColor = System.Drawing.Color.Gold;
            this.btnAddLayer.Location = new System.Drawing.Point(11, 9);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(67, 35);
            this.btnAddLayer.TabIndex = 0;
            this.btnAddLayer.Text = "Add Shapefile";
            this.btnAddLayer.UseVisualStyleBackColor = false;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // lgdMapLegend
            // 
            this.lgdMapLegend.BackColor = System.Drawing.Color.White;
            this.lgdMapLegend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 162, 264);
            this.lgdMapLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lgdMapLegend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.lgdMapLegend.HorizontalScrollEnabled = true;
            this.lgdMapLegend.Indentation = 30;
            this.lgdMapLegend.IsInitialized = false;
            this.lgdMapLegend.Location = new System.Drawing.Point(0, 0);
            this.lgdMapLegend.MinimumSize = new System.Drawing.Size(5, 5);
            this.lgdMapLegend.Name = "lgdMapLegend";
            this.lgdMapLegend.ProgressHandler = null;
            this.lgdMapLegend.ResetOnResize = false;
            this.lgdMapLegend.SelectionFontColor = System.Drawing.Color.Black;
            this.lgdMapLegend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lgdMapLegend.Size = new System.Drawing.Size(162, 264);
            this.lgdMapLegend.TabIndex = 0;
            this.lgdMapLegend.Text = "Map Legend";
            this.lgdMapLegend.VerticalScrollEnabled = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.btnSelect);
            this.tabPageMap.Controls.Add(this.btnPan);
            this.tabPageMap.Controls.Add(this.btnZoomOut);
            this.tabPageMap.Controls.Add(this.btnZoomIn);
            this.tabPageMap.Controls.Add(this.mapMain);
            this.tabPageMap.Location = new System.Drawing.Point(4, 4);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(567, 467);
            this.tabPageMap.TabIndex = 0;
            this.tabPageMap.Text = "Map";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::TrailAnalyzer2K15.Properties.Resources.SelectHand;
            this.btnSelect.Location = new System.Drawing.Point(2, 66);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(28, 28);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPan
            // 
            this.btnPan.Image = global::TrailAnalyzer2K15.Properties.Resources.PanHand;
            this.btnPan.Location = new System.Drawing.Point(2, 98);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(28, 28);
            this.btnPan.TabIndex = 8;
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::TrailAnalyzer2K15.Properties.Resources.ZoomOut;
            this.btnZoomOut.Location = new System.Drawing.Point(2, 34);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 28);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::TrailAnalyzer2K15.Properties.Resources.ZoomIn;
            this.btnZoomIn.Location = new System.Drawing.Point(2, 2);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(28, 28);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // mapMain
            // 
            this.mapMain.AllowDrop = true;
            this.mapMain.BackColor = System.Drawing.Color.White;
            this.mapMain.CollectAfterDraw = false;
            this.mapMain.CollisionDetection = false;
            this.mapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapMain.ExtendBuffer = false;
            this.mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.mapMain.IsBusy = false;
            this.mapMain.IsZoomedToMaxExtent = false;
            this.mapMain.Legend = this.lgdMapLegend;
            this.mapMain.Location = new System.Drawing.Point(3, 3);
            this.mapMain.Name = "mapMain";
            this.mapMain.ProgressHandler = null;
            this.mapMain.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.RedrawLayersWhileResizing = false;
            this.mapMain.SelectionEnabled = true;
            this.mapMain.Size = new System.Drawing.Size(561, 461);
            this.mapMain.TabIndex = 10;
            this.mapMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapMain_MouseClick);
            this.mapMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapMain_MouseDoubleClick);
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.sptGraphDialog);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 4);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(567, 467);
            this.tabPageGraph.TabIndex = 1;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // sptGraphDialog
            // 
            this.sptGraphDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptGraphDialog.Location = new System.Drawing.Point(3, 3);
            this.sptGraphDialog.Name = "sptGraphDialog";
            this.sptGraphDialog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptGraphDialog.Panel1
            // 
            this.sptGraphDialog.Panel1.Controls.Add(this.zedGraphElevationPlot);
            // 
            // sptGraphDialog.Panel2
            // 
            this.sptGraphDialog.Panel2.Controls.Add(this.groupBox1);
            this.sptGraphDialog.Size = new System.Drawing.Size(561, 461);
            this.sptGraphDialog.SplitterDistance = 248;
            this.sptGraphDialog.TabIndex = 1;
            // 
            // zedGraphElevationPlot
            // 
            this.zedGraphElevationPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphElevationPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphElevationPlot.IsShowPointValues = false;
            this.zedGraphElevationPlot.Location = new System.Drawing.Point(0, 0);
            this.zedGraphElevationPlot.Name = "zedGraphElevationPlot";
            this.zedGraphElevationPlot.PointValueFormat = "G";
            this.zedGraphElevationPlot.Size = new System.Drawing.Size(561, 248);
            this.zedGraphElevationPlot.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRating);
            this.groupBox1.Controls.Add(this.lblTotalDistance);
            this.groupBox1.Controls.Add(this.lblDistanceUp);
            this.groupBox1.Controls.Add(this.lblElevationClimb);
            this.groupBox1.Controls.Add(this.lblMaxUpSlope);
            this.groupBox1.Controls.Add(this.lblElevationDifference);
            this.groupBox1.Controls.Add(this.lblMaxDownSlope);
            this.groupBox1.Controls.Add(this.lblDistanceDown);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(34, 68);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating";
            // 
            // lblTotalDistance
            // 
            this.lblTotalDistance.AutoSize = true;
            this.lblTotalDistance.Location = new System.Drawing.Point(34, 96);
            this.lblTotalDistance.Name = "lblTotalDistance";
            this.lblTotalDistance.Size = new System.Drawing.Size(76, 13);
            this.lblTotalDistance.TabIndex = 2;
            this.lblTotalDistance.Text = "Total Distance";
            // 
            // lblDistanceUp
            // 
            this.lblDistanceUp.AutoSize = true;
            this.lblDistanceUp.Location = new System.Drawing.Point(34, 152);
            this.lblDistanceUp.Name = "lblDistanceUp";
            this.lblDistanceUp.Size = new System.Drawing.Size(111, 13);
            this.lblDistanceUp.TabIndex = 3;
            this.lblDistanceUp.Text = "Total Distance (Uphill)";
            // 
            // lblElevationClimb
            // 
            this.lblElevationClimb.AutoSize = true;
            this.lblElevationClimb.Location = new System.Drawing.Point(301, 124);
            this.lblElevationClimb.Name = "lblElevationClimb";
            this.lblElevationClimb.Size = new System.Drawing.Size(106, 13);
            this.lblElevationClimb.TabIndex = 4;
            this.lblElevationClimb.Text = "Total Elevation Climb";
            // 
            // lblMaxUpSlope
            // 
            this.lblMaxUpSlope.AutoSize = true;
            this.lblMaxUpSlope.Location = new System.Drawing.Point(301, 68);
            this.lblMaxUpSlope.Name = "lblMaxUpSlope";
            this.lblMaxUpSlope.Size = new System.Drawing.Size(86, 13);
            this.lblMaxUpSlope.TabIndex = 5;
            this.lblMaxUpSlope.Text = "Max Uphill Slope";
            // 
            // lblElevationDifference
            // 
            this.lblElevationDifference.AutoSize = true;
            this.lblElevationDifference.Location = new System.Drawing.Point(301, 152);
            this.lblElevationDifference.Name = "lblElevationDifference";
            this.lblElevationDifference.Size = new System.Drawing.Size(130, 13);
            this.lblElevationDifference.TabIndex = 7;
            this.lblElevationDifference.Text = "Total Elevation Difference";
            // 
            // lblMaxDownSlope
            // 
            this.lblMaxDownSlope.AutoSize = true;
            this.lblMaxDownSlope.Location = new System.Drawing.Point(301, 95);
            this.lblMaxDownSlope.Name = "lblMaxDownSlope";
            this.lblMaxDownSlope.Size = new System.Drawing.Size(35, 13);
            this.lblMaxDownSlope.TabIndex = 8;
            this.lblMaxDownSlope.Text = "label1";
            // 
            // lblDistanceDown
            // 
            this.lblDistanceDown.AutoSize = true;
            this.lblDistanceDown.Location = new System.Drawing.Point(34, 124);
            this.lblDistanceDown.Name = "lblDistanceDown";
            this.lblDistanceDown.Size = new System.Drawing.Size(125, 13);
            this.lblDistanceDown.TabIndex = 6;
            this.lblDistanceDown.Text = "Total Distance (Downhill)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Name of the Trail";
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMain.Controls.Add(this.tabMap);
            this.tabMain.Controls.Add(this.tabGraph);
            this.tabMain.Controls.Add(this.tabTables);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(755, 525);
            this.tabMain.TabIndex = 2;
            // 
            // tabMap
            // 
            this.tabMap.BackColor = System.Drawing.Color.Gainsboro;
            this.tabMap.Controls.Add(this.sptInterface_Map);
            this.tabMap.Location = new System.Drawing.Point(4, 4);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(747, 499);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Map";
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.zedGraph);
            this.tabGraph.Location = new System.Drawing.Point(4, 4);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(747, 499);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graphs";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph.IsShowPointValues = false;
            this.zedGraph.Location = new System.Drawing.Point(3, 3);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.PointValueFormat = "G";
            this.zedGraph.Size = new System.Drawing.Size(741, 493);
            this.zedGraph.TabIndex = 0;
            // 
            // tabTables
            // 
            this.tabTables.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTables.Location = new System.Drawing.Point(4, 4);
            this.tabTables.Name = "tabTables";
            this.tabTables.Size = new System.Drawing.Size(747, 499);
            this.tabTables.TabIndex = 2;
            this.tabTables.Text = "Tables";
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = this.spatialDockManager1;
            this.appManager1.HeaderControl = this.spatialHeaderControl1;
            this.appManager1.Legend = this.lgdMapLegend;
            this.appManager1.Map = this.mapMain;
            this.appManager1.ProgressHandler = this.spatialStatusStrip1;
            this.appManager1.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spatialDockManager1.Location = new System.Drawing.Point(0, 24);
            this.spatialDockManager1.Name = "spatialDockManager1";
            this.spatialDockManager1.Size = new System.Drawing.Size(755, 525);
            this.spatialDockManager1.SplitterDistance = 251;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 3;
            // 
            // spatialHeaderControl1
            // 
            this.spatialHeaderControl1.ApplicationManager = null;
            this.spatialHeaderControl1.MenuStrip = null;
            this.spatialHeaderControl1.ToolbarsContainer = null;
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 527);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = this.toolStripProgressBar1;
            this.spatialStatusStrip1.ProgressLabel = this.toolStripStatusLabel1;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(755, 22);
            this.spatialStatusStrip1.TabIndex = 4;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // frmBikeAnalyzer2K15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.menLayoutMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menLayoutMenuStrip;
            this.Name = "frmBikeAnalyzer2K15";
            this.Text = "Trail Analyzer 2K15";
            this.Load += new System.EventHandler(this.frmBikeAnalyzer2K15_Load);
            this.menLayoutMenuStrip.ResumeLayout(false);
            this.menLayoutMenuStrip.PerformLayout();
            this.sptInterface_Map.Panel1.ResumeLayout(false);
            this.sptInterface_Map.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptInterface_Map)).EndInit();
            this.sptInterface_Map.ResumeLayout(false);
            this.sptButtons_Legend.Panel1.ResumeLayout(false);
            this.sptButtons_Legend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptButtons_Legend)).EndInit();
            this.sptButtons_Legend.ResumeLayout(false);
            this.grpboxSampleData.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            this.sptGraphDialog.Panel1.ResumeLayout(false);
            this.sptGraphDialog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptGraphDialog)).EndInit();
            this.sptGraphDialog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).EndInit();
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.LayoutMenuStrip menLayoutMenuStrip;
        private System.Windows.Forms.SplitContainer sptInterface_Map;
        private System.Windows.Forms.SplitContainer sptButtons_Legend;
        private System.Windows.Forms.Button btnDrawTrail;
        private System.Windows.Forms.Button btnAddLayer;
        private DotSpatial.Controls.Legend lgdMapLegend;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private DotSpatial.Controls.Map mapMain;
        private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLayerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabTables;
        private ZedGraph.ZedGraphControl zedGraph;
        private DotSpatial.Controls.AppManager appManager1;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl1;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPageGraph;
        private ZedGraph.ZedGraphControl zedGraphElevationPlot;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnSampleExtreme;
        private System.Windows.Forms.Button btnSampleExpert;
        private System.Windows.Forms.Button btnSampleModerate;
        private System.Windows.Forms.Button btnSampleEasier;
        private System.Windows.Forms.SplitContainer sptGraphDialog;
        private System.Windows.Forms.Label lblDistanceDown;
        private System.Windows.Forms.Label lblMaxUpSlope;
        private System.Windows.Forms.Label lblElevationClimb;
        private System.Windows.Forms.Label lblDistanceUp;
        private System.Windows.Forms.Label lblTotalDistance;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblElevationDifference;
        private System.Windows.Forms.Label lblMaxDownSlope;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxSampleData;
        private System.Windows.Forms.Button btnAddRaster;
    }
}

