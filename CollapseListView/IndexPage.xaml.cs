using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CollapseListView
{
	public partial class IndexPage : ContentPage
	{
		public IndexPage ()
		{
			InitializeComponent ();
			var nativeListView2 = new ExtendedListView (); 
			// REQUIRED: To share a scrollable view with other views in a StackLayout, it should have a VerticalOptions of FillAndExpand.
			nativeListView2.VerticalOptions = LayoutOptions.FillAndExpand; 

			nativeListView2.Items = DSource.GetList ();
			
			// The root page of your application
			Content = new StackLayout {
				Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0),
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = Device.OnPlatform ("Custom renderer iOS", "Custom renderer Droid", "Custom renderer WinPhone")
					},
					nativeListView2
				}
			};
		}
	}

	public class DSource
	{
		public DSource ()
		{			
		}

		public static List<EntityClass> GetList ()
		{
			var items = new List<EntityClass> ();
			items.Add (new EntityClass () {
				Id = 0,
				Title = "Parent Without Child",
				IsSelected = true,
				//SelectedStateIcon = "switch_on.png",
				//DeselectedStateIcon = "switch_off.png",
			});

			items.Add (new EntityClass () { 
				Id = 1,
				Title = "Parent 1",
				IsSelected = false,
				//SelectedStateIcon = "arrow_up.png",
				//DeselectedStateIcon = "arrow_down.png",
				ChildItems = new List<EntityClass> () {
					new EntityClass () { 
						Id = 0, 
						Title = "Child 1 ", 
						IsSelected = true, 
						OnClickListener = new Action<EntityClass> ((s) => Application.Current.MainPage.DisplayAlert ("Alert", "message", "cancel"))
					},
					new EntityClass () { 
						Id = 1, 
						Title = "Child 2 ", 
						IsSelected = true, 
					
					},
					new EntityClass () { 
						Id = 2, 
						Title = "Child 3 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 3, 
						Title = "Child 4 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 4, 
						Title = "Child 5 ", 
						IsSelected = true, 

					},
				}
			});					
			items.Add (new EntityClass () { 
				Id = 1,
				Title = "Parent 2",
				IsSelected = false,
				ChildItems = new List<EntityClass> () {
					new EntityClass () { 
						Id = 0, 
						Title = "Child 1 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 1, 
						Title = "Child 2 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 2, 
						Title = "Child 3 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 3, 
						Title = "Child 4 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 4, 
						Title = "Child 5 ", 
						IsSelected = true, 

					},
				}
			});	
			items.Add (new EntityClass () { 
				Id = 1,
				Title = "Parent 3",
				IsSelected = false,
				ChildItems = new List<EntityClass> () {
					new EntityClass () { 
						Id = 0, 
						Title = "Child 1 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 1, 
						Title = "Child 2 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 2, 
						Title = "Child 3 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 3, 
						Title = "Child 4 ", 
						IsSelected = true, 

					},
					new EntityClass () { 
						Id = 4, 
						Title = "Child 5 ", 
						IsSelected = true,
					},
				}
			});					
			return items;
		}
	}
}