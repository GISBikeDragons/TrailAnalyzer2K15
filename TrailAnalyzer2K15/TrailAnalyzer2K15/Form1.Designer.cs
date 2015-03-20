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
            this.menLayoutMenuStrip = new DotSpatial.Controls.LayoutMenuStrip();
            this.sptInterface_Map = new System.Windows.Forms.SplitContainer();
            this.sptButtons_Legend = new System.Windows.Forms.SplitContainer();
            this.btnAddLayer = new System.Windows.Forms.Button();
            this.btnDrawTrail = new System.Windows.Forms.Button();
            this.lgdMapLegend = new DotSpatial.Controls.Legend();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.mapMain = new DotSpatial.Controls.Map();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menLayoutMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptInterface_Map)).BeginInit();
            this.sptInterface_Map.Panel1.SuspendLayout();
            this.sptInterface_Map.Panel2.SuspendLayout();
            this.sptInterface_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptButtons_Legend)).BeginInit();
            this.sptButtons_Legend.Panel1.SuspendLayout();
            this.sptButtons_Legend.Panel2.SuspendLayout();
            this.sptButtons_Legend.SuspendLayout();
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
            this.menLayoutMenuStrip.Size = new System.Drawing.Size(763, 24);
            this.menLayoutMenuStrip.TabIndex = 0;
            this.menLayoutMenuStrip.Text = "layoutMenuStrip1";
            // 
            // sptInterface_Map
            // 
            this.sptInterface_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptInterface_Map.Location = new System.Drawing.Point(0, 24);
            this.sptInterface_Map.Name = "sptInterface_Map";
            // 
            // sptInterface_Map.Panel1
            // 
            this.sptInterface_Map.Panel1.Controls.Add(this.sptButtons_Legend);
            // 
            // sptInterface_Map.Panel2
            // 
            this.sptInterface_Map.Panel2.Controls.Add(this.btnSelect);
            this.sptInterface_Map.Panel2.Controls.Add(this.btnPan);
            this.sptInterface_Map.Panel2.Controls.Add(this.btnZoomOut);
            this.sptInterface_Map.Panel2.Controls.Add(this.btnZoomIn);
            this.sptInterface_Map.Panel2.Controls.Add(this.mapMain);
            this.sptInterface_Map.Size = new System.Drawing.Size(763, 584);
            this.sptInterface_Map.SplitterDistance = 254;
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
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnDrawTrail);
            this.sptButtons_Legend.Panel1.Controls.Add(this.btnAddLayer);
            // 
            // sptButtons_Legend.Panel2
            // 
            this.sptButtons_Legend.Panel2.Controls.Add(this.lgdMapLegend);
            this.sptButtons_Legend.Size = new System.Drawing.Size(254, 584);
            this.sptButtons_Legend.SplitterDistance = 280;
            this.sptButtons_Legend.TabIndex = 0;
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Location = new System.Drawing.Point(88, 93);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddLayer.TabIndex = 0;
            this.btnAddLayer.Text = "Add Trail";
            this.btnAddLayer.UseVisualStyleBackColor = true;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnDrawTrail
            // 
            this.btnDrawTrail.Location = new System.Drawing.Point(88, 134);
            this.btnDrawTrail.Name = "btnDrawTrail";
            this.btnDrawTrail.Size = new System.Drawing.Size(75, 23);
            this.btnDrawTrail.TabIndex = 1;
            this.btnDrawTrail.Text = "Draw Trail";
            this.btnDrawTrail.UseVisualStyleBackColor = true;
            // 
            // lgdMapLegend
            // 
            this.lgdMapLegend.BackColor = System.Drawing.Color.White;
            this.lgdMapLegend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 254, 300);
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
            this.lgdMapLegend.Size = new System.Drawing.Size(254, 300);
            this.lgdMapLegend.TabIndex = 0;
            this.lgdMapLegend.Text = "Map Legend";
            this.lgdMapLegend.VerticalScrollEnabled = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(15, 105);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPan
            // 
            this.btnPan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPan.Location = new System.Drawing.Point(15, 75);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(75, 23);
            this.btnPan.TabIndex = 8;
            this.btnPan.Text = "Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZoomOut.Location = new System.Drawing.Point(15, 45);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZoomIn.Location = new System.Drawing.Point(15, 15);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "Zoom In";
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
            this.mapMain.Legend = null;
            this.mapMain.Location = new System.Drawing.Point(0, 0);
            this.mapMain.Name = "mapMain";
            this.mapMain.ProgressHandler = null;
            this.mapMain.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.RedrawLayersWhileResizing = false;
            this.mapMain.SelectionEnabled = true;
            this.mapMain.Size = new System.Drawing.Size(505, 584);
            this.mapMain.TabIndex = 10;
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
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLayerToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // addLayerToolStripMenuItem
            // 
            this.addLayerToolStripMenuItem.Name = "addLayerToolStripMenuItem";
            this.addLayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addLayerToolStripMenuItem.Text = "Add Layer";
            // 
            // deleteLayerToolStripMenuItem
            // 
            this.deleteLayerToolStripMenuItem.Name = "deleteLayerToolStripMenuItem";
            this.deleteLayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteLayerToolStripMenuItem.Text = "Delete Layer";
            // 
            // manageLayerToolStripMenuItem
            // 
            this.manageLayerToolStripMenuItem.Name = "manageLayerToolStripMenuItem";
            this.manageLayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageLayerToolStripMenuItem.Text = "Manage Layer";
            // 
            // frmBikeAnalyzer2K15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 608);
            this.Controls.Add(this.sptInterface_Map);
            this.Controls.Add(this.menLayoutMenuStrip);
            this.MainMenuStrip = this.menLayoutMenuStrip;
            this.Name = "frmBikeAnalyzer2K15";
            this.Text = "Bike Analyzer 2K15";
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
    }
}

