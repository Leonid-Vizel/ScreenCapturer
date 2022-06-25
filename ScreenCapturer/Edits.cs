using System.Collections.Generic;
using ZBitmap;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenCapturer
{
    public class Edits
    {
        public Size Size { get; set; }
        public List<TextOverlay> TextOverlays { get; set; }
        public List<BitmapOverlay> BitmapOverlays { get; set; }

        public Edits()
        {
            Size = new Size();
            TextOverlays = new List<TextOverlay>();
            BitmapOverlays = new List<BitmapOverlay>();
        }

        public void ApplyOverlay(PictureBox source)
        {
            Bitmap initial = source.Image as Bitmap;
            if (!initial.Size.Equals(Size))
            {
                initial = Transformations.Resize(initial, Size);
            }
            Transformations.PasteTexts(initial, TextOverlays.ToArray());
            Transformations.PasteBitmaps(initial, BitmapOverlays.ToArray());
            source.Image = initial;
        }
    }
}
