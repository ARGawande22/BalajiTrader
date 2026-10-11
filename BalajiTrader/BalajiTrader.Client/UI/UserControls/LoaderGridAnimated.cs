using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Client.UI.UserControls
{
    public static class LoaderGridAnimated
    {
        private static Panel overlayPanel;
        private static PictureBox spinner;
        private static GlowLabel loadingLabel;
        private static System.Windows.Forms.Timer glowTimer;
        private static int glowPulse = 0;
        private static bool glowIncreasing = true;
        private static Control _parentControl; // Track parent control

        public static void Show(Control parentControl, string message = "Loading...", Color? glowColor = null)
        {
            try
            {
                // Always hide previous loader before showing new one
                Hide(parentControl);

                _parentControl = parentControl;

                overlayPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    Visible = true
                };

                spinner = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BackColor = Color.Transparent,
                    Image = Properties.Resources.spinner
                };

                loadingLabel = new GlowLabel
                {
                    Text = message,
                    GlowColor = glowColor ?? Color.DeepSkyBlue,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                overlayPanel.Controls.Add(spinner);
                overlayPanel.Controls.Add(loadingLabel);
                overlayPanel.Resize += (s, e) => CenterControls();

                parentControl.Controls.Add(overlayPanel);
                overlayPanel.BringToFront();
                CenterControls();

                // Reset pulse state for fresh animation
                glowPulse = 0;
                glowIncreasing = true;

                glowTimer = new System.Windows.Forms.Timer { Interval = 60 };
                glowTimer.Tick += GlowTimer_Tick;
                glowTimer.Start();
            }
            catch (Exception ex)
            {
                // log.Error("LoaderGridAnimated.Show error: " + ex.Message);
            }
        }

        // Extracted tick handler — easier to unsubscribe
        private static void GlowTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Check if label is disposed or parent is disposed before updating
                if (loadingLabel == null || loadingLabel.IsDisposed)
                {
                    StopTimer();
                    return;
                }

                if (_parentControl == null || _parentControl.IsDisposed)
                {
                    StopTimer();
                    return;
                }

                if (glowIncreasing)
                {
                    glowPulse++;
                    if (glowPulse >= 20) glowIncreasing = false;
                }
                else
                {
                    glowPulse--;
                    if (glowPulse <= 0) glowIncreasing = true;
                }

                // Marshal to UI thread safely
                if (loadingLabel.InvokeRequired)
                {
                    loadingLabel.Invoke(new Action(() =>
                    {
                        if (!loadingLabel.IsDisposed)
                        {
                            loadingLabel.GlowIntensity = glowPulse;
                            loadingLabel.Invalidate();
                        }
                    }));
                }
                else
                {
                    loadingLabel.GlowIntensity = glowPulse;
                    loadingLabel.Invalidate();
                }
            }
            catch (ObjectDisposedException)
            {
                // Control was disposed — stop timer silently
                StopTimer();
            }
            catch (Exception ex)
            {
                StopTimer();
                // log.Error("Glow timer error: " + ex.Message);
            }
        }

        // Centralized timer stop logic
        private static void StopTimer()
        {
            try
            {
                if (glowTimer != null)
                {
                    glowTimer.Stop();
                    glowTimer.Tick -= GlowTimer_Tick; // Unsubscribe to prevent memory leak
                    glowTimer.Dispose();
                    glowTimer = null;
                }
            }
            catch { }
        }

        public static void Hide(Control parentControl)
        {
            try
            {
                // Stop timer FIRST before disposing controls
                StopTimer();

                if (overlayPanel != null)
                {
                    if (parentControl != null
                        && !parentControl.IsDisposed
                        && parentControl.Controls.Contains(overlayPanel))
                    {
                        parentControl.Controls.Remove(overlayPanel);
                    }

                    overlayPanel.Dispose();
                    overlayPanel = null;
                }

                if (loadingLabel != null)
                {
                    if (!loadingLabel.IsDisposed)
                        loadingLabel.Dispose();
                    loadingLabel = null;
                }

                if (spinner != null)
                {
                    if (!spinner.IsDisposed)
                        spinner.Dispose();
                    spinner = null;
                }

                _parentControl = null;
            }
            catch (Exception ex)
            {
                // log.Error("LoaderGridAnimated.Hide error: " + ex.Message);
            }
        }

        private static void CenterControls()
        {
            try
            {
                if (overlayPanel == null || overlayPanel.IsDisposed) return;
                if (spinner == null || loadingLabel == null) return;

                int totalHeight = spinner.Height + 10 + loadingLabel.Height;
                int startY = (overlayPanel.Height - totalHeight) / 2;

                spinner.Left = (overlayPanel.Width - spinner.Width) / 2;
                spinner.Top = startY;

                loadingLabel.Left = (overlayPanel.Width - loadingLabel.Width) / 2;
                loadingLabel.Top = startY + spinner.Height + 10;
            }
            catch { }
        }

        public static void UpdateMessage(string message = "Loading...")
        {
            try
            {
                if (loadingLabel == null || loadingLabel.IsDisposed) return;

                // Thread-safe message update
                if (loadingLabel.InvokeRequired)
                    loadingLabel.Invoke(new Action(() =>
                    {
                        if (!loadingLabel.IsDisposed)
                            loadingLabel.Text = message;
                    }));
                else
                    loadingLabel.Text = message;
            }
            catch (ObjectDisposedException) { }
            catch (Exception ex)
            {
                // log.Error("UpdateMessage error: " + ex.Message);
            }
        }

        // Custom glowing label with adjustable intensity
        private class GlowLabel : Label
        {
            public Color GlowColor { get; set; } = Color.Lime;
            public int GlowIntensity { get; set; } = 10;

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddString(
                        Text,
                        Font.FontFamily,
                        (int)Font.Style,
                        e.Graphics.DpiY * Font.Size / 72,
                        new Point(0, 0),
                        StringFormat.GenericDefault);

                    // Multiple blurred layers create glow effect
                    for (int i = GlowIntensity; i >= 1; i--)
                    {
                        using (Pen p = new Pen(Color.FromArgb(15, GlowColor), i))
                        {
                            p.LineJoin = LineJoin.Round;
                            e.Graphics.DrawPath(p, path);
                        }
                    }

                    // Foreground text
                    using (SolidBrush brush = new SolidBrush(ForeColor))
                        e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
