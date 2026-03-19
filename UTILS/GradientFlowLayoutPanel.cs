using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;


namespace MyM26.UTILS
{
    public class GradientFlowLayoutPanel: FlowLayoutPanel
    {
        public GradientFlowLayoutPanel()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // No llamar a base.OnPaintBackground para evitar repintado doble
            Rectangle rect = this.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(240, 74, 129, 185), // 6881FF
                Color.FromArgb(240, 74, 129, 185),  // 894EFE
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

    }
}
