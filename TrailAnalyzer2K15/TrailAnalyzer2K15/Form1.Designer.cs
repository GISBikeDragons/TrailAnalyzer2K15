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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnDrawTrail = new System.Windows.Forms.Button();
            this.btnAddLayer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lgdMapLegend = new DotSpatial.Controls.Legend();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.mapMain = new DotSpatial.Controls.Map();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.menLayoutMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptInterface_Map)).BeginInit();
            this.sptInterface_Map.Panel1.SuspendLayout();
            this.sptInterface_Map.Panel2.SuspendLayout();
            this.sptInterface_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptButtons_Legend)).BeginInit();
            this.sptButtons_Legend.Panel1.SuspendLayout();
            this.sptButtons_Legend.Panel2.SuspendLayout();
            this.sptButtons_Legend.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
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
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnGraph);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnDrawTrail);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnAddLayer);
            this.sptButtons_Legend.Panel1.Margin = new System.Windows.Forms.Padding(1);
            // 
            // sptButtons_Legend.Panel2
            // 
            this.sptButtons_Legend.Panel2.Controls.Add(this.lgdMapLegend);
            this.sptButtons_Legend.Size = new System.Drawing.Size(162, 493);
            this.sptButtons_Legend.SplitterDistance = 235;
            this.sptButtons_Legend.TabIndex = 0;
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(5, 66);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "Graph Trail";
            this.btnGraph.UseVisualStyleBackColor = true;
            // 
            // btnDrawTrail
            // 
            this.btnDrawTrail.Location = new System.Drawing.Point(5, 37);
            this.btnDrawTrail.Name = "btnDrawTrail";
            this.btnDrawTrail.Size = new System.Drawing.Size(75, 23);
            this.btnDrawTrail.TabIndex = 1;
            this.btnDrawTrail.Text = "Draw Trail";
            this.btnDrawTrail.UseVisualStyleBackColor = true;
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Location = new System.Drawing.Point(5, 7);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddLayer.TabIndex = 0;
            this.btnAddLayer.Text = "Add Trail";
            this.btnAddLayer.UseVisualStyleBackColor = true;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
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
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.zedGraphControl1);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 4);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(567, 467);
            this.tabPageGraph.TabIndex = 1;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
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
            // lgdMapLegend
            // 
            this.lgdMapLegend.BackColor = System.Drawing.Color.White;
            this.lgdMapLegend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 162, 254);
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
            this.lgdMapLegend.Size = new System.Drawing.Size(162, 254);
            this.lgdMapLegend.TabIndex = 0;
            this.lgdMapLegend.Text = "Map Legend";
            this.lgdMapLegend.VerticalScrollEnabled = true;
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
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(561, 461);
            this.zedGraphControl1.TabIndex = 0;
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
            this.Text = "Bike Analyzer 2K15";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
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
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnGraph;
    }
}

