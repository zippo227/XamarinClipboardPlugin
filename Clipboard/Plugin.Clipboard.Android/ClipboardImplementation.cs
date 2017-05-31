using Android.App;
using Android.Content;
using Plugin.Clipboard.Abstractions;
using System;
using Android.Graphics;
using System.Diagnostics;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public string GetText()
        {
            var clipboardManager = (ClipboardManager) Application.Context.GetSystemService(Context.ClipboardService);
            return clipboardManager.Text;
        }

        public void SetText(string data)
        {
            var clipboardManager = (ClipboardManager)Application.Context.GetSystemService(Context.ClipboardService);
            clipboardManager.Text = data;
        }

		public void SetImage(byte[] imageBytes)
		{
            if(imageBytes == null)
            {
                Debug.WriteLine("unable to use null imageBytes");
                return;
            }

            var clipboardManager = (ClipboardManager)Application.Context.GetSystemService(Context.ClipboardService);


            Bitmap bitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
            //ClipData clip = new ClipData()
            //clipboardManager.PrimaryClip = bitmap;
		}
    }
}