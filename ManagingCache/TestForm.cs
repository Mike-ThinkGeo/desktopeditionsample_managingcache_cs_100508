using System;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using ThinkGeo.MapSuite.Core;
using ThinkGeo.MapSuite.DesktopEdition;


namespace  ManagingCache
{
    public partial class TestForm : Form
    {
        //Will generate the tiles for cache in the "TestDataCache" directory in "C:\temp".
        FileBitmapTileCache fileBitmapTileCache = new FileBitmapTileCache(@"C:\temp", "TestDataCache"); 

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            winformsMap1.MapUnit = GeographyUnit.DecimalDegree;
            winformsMap1.CurrentExtent = new RectangleShape(-125, 47, -67, 25);
            winformsMap1.BackgroundOverlay.BackgroundBrush = new GeoSolidBrush(GeoColor.FromArgb(255, 198, 255, 255));

            ShapeFileFeatureLayer worldLayer = new ShapeFileFeatureLayer(@"..\..\Data\Countries02.shp"); 
            worldLayer.ZoomLevelSet.ZoomLevel01.DefaultAreaStyle = AreaStyles.Country1;
            worldLayer.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20;

            ShapeFileFeatureLayer capitalLayer = new ShapeFileFeatureLayer(@"..\..\Data\WorldCapitals.shp"); 
            // We can customize our own Style. Here we passed in a color and a size.
            capitalLayer.ZoomLevelSet.ZoomLevel01.DefaultPointStyle = PointStyles.CreateSimpleCircleStyle(GeoColor.StandardColors.White, 7, GeoColor.StandardColors.Brown);
            // The Style we set here is available from ZoomLevel01 to ZoomLevel05. That means if we zoom in a bit more, the appearance we set here will not be visible anymore.
            capitalLayer.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level05;

            capitalLayer.ZoomLevelSet.ZoomLevel06.DefaultPointStyle = PointStyles.Capital3;
            // The Style we set here is available from ZoomLevel06 to ZoomLevel20. That means if we zoom out a bit more, the appearance we set here will not be visible any more.
            capitalLayer.ZoomLevelSet.ZoomLevel06.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20;

            ShapeFileFeatureLayer capitalLabelLayer = new ShapeFileFeatureLayer(@"..\..\Data\WorldCapitals.shp");
            // We can customize our own TextStyle. Here we passed in the font, the size, the style and the color.
            capitalLabelLayer.ZoomLevelSet.ZoomLevel01.DefaultTextStyle = TextStyles.CreateSimpleTextStyle("CITY_NAME", "Arial", 8, DrawingFontStyles.Italic, GeoColor.StandardColors.Black, 3, 3);
            // The TextStyle we set here is available from ZoomLevel01 to ZoomLevel05. 
            capitalLabelLayer.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level05;

            capitalLabelLayer.ZoomLevelSet.ZoomLevel06.DefaultTextStyle = TextStyles.Capital3("CITY_NAME");
            // The TextStyle we set here is available from ZoomLevel06 to ZoomLevel20. 
            capitalLabelLayer.ZoomLevelSet.ZoomLevel06.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20;
            // As the map is drawn by tiles, it needs to draw on the margin to make sure the text is complete after the tiles are joined together.
            // Change the number to another one (for example 0) and you can see the difference expecially when panning.
            capitalLabelLayer.DrawingMarginPercentage = 50;

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(worldLayer);
            layerOverlay.Layers.Add(capitalLayer);
            layerOverlay.Layers.Add(capitalLabelLayer);

            //Sets the zoom snapping mode to snap up.
            winformsMap1.ZoomLevelSnapping = ZoomLevelSnappingMode.SnapUp;
            //Sets the tilecache when in Snap Up mode for zoom snapping.
            layerOverlay.TileCache = fileBitmapTileCache;

            winformsMap1.Overlays.Add(layerOverlay);

            winformsMap1.Refresh();
        }

        private void radioButtonSnapUp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSnapUp.Checked == true)
            {
                winformsMap1.ZoomLevelSnapping = ZoomLevelSnappingMode.SnapUp;
                LayerOverlay layerOverlay = (LayerOverlay)winformsMap1.Overlays[0];
                //Sets the TileCache when in Snap Up mode for zoom snapping.
                layerOverlay.TileCache = fileBitmapTileCache;
                winformsMap1.Refresh();
            }
        }

        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked == true)
            {
                winformsMap1.ZoomLevelSnapping = ZoomLevelSnappingMode.None;
                LayerOverlay layerOverlay = (LayerOverlay)winformsMap1.Overlays[0];
                //Sets thge TileCache to null when zoom snapping is none to avoid generating almost never ending cache imaging 
                //for all the intermediate zoom levels.
                layerOverlay.TileCache = null;
                winformsMap1.Refresh();
            }
        }

      
        private void winformsMap1_MouseMove(object sender, MouseEventArgs e)
        {
            //Displays the X and Y in screen coordinates.
            statusStrip1.Items["toolStripStatusLabelScreen"].Text = "X:" + e.X + " Y:" + e.Y;

            //Gets the PointShape in world coordinates from screen coordinates.
            PointShape pointShape = ExtentHelper.ToWorldCoordinate(winformsMap1.CurrentExtent, new ScreenPointF(e.X, e.Y), winformsMap1.Width, winformsMap1.Height);

            //Displays world coordinates.
            statusStrip1.Items["toolStripStatusLabelWorld"].Text = "(world) X:" + Math.Round(pointShape.X, 4) + " Y:" + Math.Round(pointShape.Y, 4);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
