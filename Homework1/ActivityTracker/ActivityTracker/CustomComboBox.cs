﻿namespace ActivityTracker
{
    internal class CustomComboBox : ComboBox
    {
        public Color HighlightColor { get; set; }

        public CustomComboBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            HighlightColor = GeneralValues.AccentColor;
            DrawItem += new DrawItemEventHandler(CustomDrawItem);
        }

        void CustomDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(HighlightColor),
                                            e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                            e.Bounds);

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                    new SolidBrush(combo.ForeColor),
                                    new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }
    }
}
