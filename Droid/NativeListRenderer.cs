using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CollapseListView;
using CollapseListView.Droid;

[assembly: ExportRenderer (typeof(ExtendedListView), typeof(NativeExpanderRenderer))]
namespace CollapseListView.Droid
{
	public class NativeExpanderRenderer : ViewRenderer<ExtendedListView, global::Android.Widget.ExpandableListView>
	{
		protected override void OnElementChanged (ElementChangedEventArgs<ExtendedListView> e)
		{
			base.OnElementChanged (e);

			if (Control == null) {
				SetNativeControl (new global::Android.Widget.ExpandableListView (Forms.Context));
			}
			if (e.OldElement != null) {
				// unsubscribe
			}
			if (e.NewElement != null) {
				// subscribe
				Control.SetAdapter (new DataAdopter (Forms.Context as Android.App.Activity, e.NewElement.Items));
				Control.SetGroupIndicator (null);
			}
		}
	}
}