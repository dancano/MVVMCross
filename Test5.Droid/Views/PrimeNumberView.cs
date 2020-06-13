using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using Test5.Core.ViewModels;

namespace Test5.Droid.Views
{
    [Activity(Label = "@string/app_name")]
    public class PrimeNumberView : MvxActivity<PrimeNumberViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.PrimeNumberPage);
		}
	}
}