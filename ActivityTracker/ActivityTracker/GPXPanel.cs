using System.Drawing.Drawing2D;
using System.Globalization;
using System.Xml;

namespace ActivityTracker
{
    internal class GPXPanel : PictureBox
    {
        List<(Double lat, Double lon)> coordinates;
        XmlDocument gpxDoc;
        XmlNamespaceManager nsmgr;

        public GPXPanel(String gpxFile): base(){
            BackColor = GeneralValues.SecondaryBackgroundColor;
            Width = 200;
            Height = 200;

            try
            {
                coordinates = new List<(Double, Double)>();
                gpxDoc = new XmlDocument();
                gpxDoc.Load(gpxFile);

                nsmgr = new XmlNamespaceManager(gpxDoc.NameTable);
                nsmgr.AddNamespace("gpx", "http://www.topografix.com/GPX/1/1");

                foreach (XmlNode node in gpxDoc.SelectNodes("//gpx:trkpt", nsmgr))
                {
                    Double lat = Double.Parse(node.Attributes["lat"].Value, CultureInfo.InvariantCulture);
                    Double lon = Double.Parse(node.Attributes["lon"].Value, CultureInfo.InvariantCulture);
                    coordinates.Add((lat, lon));
                }
            }
            catch {
                MessageBox.Show("Couldn't load GPX data!");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (coordinates.Count == 0) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            rect.Inflate(-1, -1);
            using (GraphicsPath path = GeneralValues.GetRoundedRectanglePath(rect, GeneralValues.CornerRadius))
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, GeneralValues.GradientColor1, GeneralValues.GradientColor2, LinearGradientMode.ForwardDiagonal))
            using (Pen borderPen = new Pen(GeneralValues.BorderColor, 1))
            {
                g.FillPath(gradientBrush, path);
                g.DrawPath(borderPen, path);
            }

            Pen pen = new Pen(GeneralValues.AccentColor, 2);
            Brush brush = new SolidBrush(GeneralValues.AccentColor);

            // Normalize coordinates to fit inside the PictureBox
            Double minLat = Double.MaxValue, maxLat = Double.MinValue;
            Double minLon = Double.MaxValue, maxLon = Double.MinValue;

            foreach (var (lat, lon) in coordinates)
            {
                if (lat < minLat) minLat = lat;
                if (lat > maxLat) maxLat = lat;
                if (lon < minLon) minLon = lon;
                if (lon > maxLon) maxLon = lon;
            }

            Int32 width = Width - 20;
            Int32 height = Height - 20;
            Double scaleX = width / (Double)(maxLon - minLon);
            Double scaleY = height / (Double)(maxLat - minLat);

            PointF[] points = new PointF[coordinates.Count];
            for (int i = 0; i < coordinates.Count; i++)
            {
                float x = (float)((coordinates[i].lon - minLon) * scaleX + 10);
                float y = (float)((maxLat - coordinates[i].lat) * scaleY + 10);
                points[i] = new PointF(x, y);
            }

            if (points.Length > 1)
            {
                g.DrawLines(pen, points);
            }
            foreach (var pt in points)
            {
                g.FillEllipse(brush, pt.X - 2, pt.Y - 2, 4, 4);
            }
        }
    }
}
