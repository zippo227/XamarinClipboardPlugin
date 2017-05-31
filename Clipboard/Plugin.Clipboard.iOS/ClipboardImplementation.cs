using Plugin.Clipboard.Abstractions;
using System;
using UIKit;
using Foundation;
using System.Diagnostics;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Clipboard
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public string GetText()
        {
            UIPasteboard clipboard = UIPasteboard.General;
            return clipboard.String;
        }

        public void SetText(string data)
        {
            UIPasteboard clipboard = UIPasteboard.General;
            clipboard.String = data;
        }

		public void SetImage(byte[] imageBytes)
		{
			if (imageBytes == null)
			{
				Debug.WriteLine("unable to use null imageBytes");
				return;
			}

			UIPasteboard clipboard = UIPasteboard.General;

			NSData imgData = NSData.FromArray(imageBytes);
			UIImage image = UIImage.LoadFromData(imgData);

			clipboard.Image = image;
		}
    }
}