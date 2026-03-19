using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;


namespace MyM26.UTILS
{
    public class GradientTableLayoutPanel: TableLayoutPanel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // No llamar a base.OnPaintBackground para evitar repintado doble
            Rectangle rect = this.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 104, 129, 255), // 6881FF
                Color.FromArgb(255, 126, 61, 255),  // 894EFE
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }


    }
}
