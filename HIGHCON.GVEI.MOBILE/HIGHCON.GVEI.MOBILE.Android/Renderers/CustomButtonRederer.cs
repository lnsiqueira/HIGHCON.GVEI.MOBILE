using System;

using Android.Content;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.FastRenderers;
using HIGHCON.GVEI.MOBILE.Controls;
using HIGHCON.GVEI.MOBILE.Droid.Renderers;
using ButtonRenderer = Xamarin.Forms.Platform.Android.FastRenderers.ButtonRenderer;

namespace HIGHCON.GVEI.MOBILE.Droid.Renderers
{
    public class CustomButtonRederer : ButtonRenderer
    {
        public CustomButtonRederer(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetAllCaps(false);
            }
        }
    }
}