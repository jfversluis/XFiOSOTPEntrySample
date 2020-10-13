using System;
using iOSOTPEntrySample;
using iOSOTPEntrySample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(OtpEntry), typeof(OtpEntryRenderer))]
namespace iOSOTPEntrySample.iOS
{
    public class OtpEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (UIDevice.CurrentDevice.CheckSystemVersion(12, 0) && Control != null)
            {
                Control.TextContentType = UITextContentType.OneTimeCode;
            }
        }
    }
}
