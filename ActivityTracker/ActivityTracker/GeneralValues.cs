using System.Drawing.Drawing2D;

namespace ActivityTracker
{
    internal static class GeneralValues
    {
        internal static Color PrimaryBackgroundColor = Color.FromArgb(255, 255, 255, 255);
        internal static Color SecondaryBackgroundColor = Color.FromArgb(255, 247, 247, 249);
        internal static Color GradientColor1 = Color.FromArgb(255, 250, 250, 252);
        internal static Color GradientColor2 = Color.FromArgb(255, 237, 238, 242);
        internal static Color AccentColor = Color.FromArgb(255, 255, 91, 0);
        internal static Color AccentColorHover = Color.FromArgb(255, 230, 81, 0);
        internal static Color AccentColorPressed = Color.FromArgb(255, 204, 71, 0);
        internal static Color BorderColor = Color.FromArgb(255, 220, 220, 220);
        internal static Color ButtonTextColor = Color.White;
        internal static Color PrimaryTextColor = Color.FromArgb(255, 33, 33, 33);
        internal static Color SecondaryTextColor = Color.FromArgb(255, 85, 85, 85);

        internal static Font TitleFont = new Font("Outfit", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        internal static Font SubtitleFont = new Font("Outfit", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        internal static Font BodyFont = new Font("Outfit", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        internal static Font BodyFontSmall = new Font("Outfit", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        internal static Int32 PaddingValue = 15;
        internal static Int32 CornerRadius = 5;

        internal static Int32 AnimationTransitionSpeed = 10;

        internal static string AppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ActivityTracker");
        internal static string ActivitiesDatabase = Path.Combine(AppFolder, "activitiesDatabase.csv");
    
        public static GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // Top-left corner
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90); // Top-right corner
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); // Bottom-left
            path.CloseFigure();
            return path;
        }
    }

    class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        public MenuStripRenderer() : base(new MenuStripColors()) { }
    }

    class MenuStripColors() : ProfessionalColorTable 
    {
        public override Color MenuItemSelected
        {
            get { return GeneralValues.SecondaryBackgroundColor; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return GeneralValues.SecondaryBackgroundColor; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return GeneralValues.SecondaryBackgroundColor; }
        }
        public override Color MenuItemBorder
        {
            get { return GeneralValues.BorderColor; }
        }
    }
}
