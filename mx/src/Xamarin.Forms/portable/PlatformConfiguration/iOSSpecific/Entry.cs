﻿using System;

namespace Xamarin.Forms.PlatformConfiguration.iOSSpecific
{
	using FormsElement = Xamarin.Forms.Entry;

	public static class Entry
	{
		public static readonly BindableProperty AdjustsFontSizeToFitWidthProperty =
			BindableProperty.Create("AdjustsFontSizeToFitWidthEnabled", typeof(bool),
			typeof(Entry), false);

		public static bool GetAdjustsFontSizeToFitWidth(BindableObject element)
		{
			return (bool)element.GetValue(AdjustsFontSizeToFitWidthProperty);
		}

		public static void SetAdjustsFontSizeToFitWidth(BindableObject element, bool value)
		{
			element.SetValue(AdjustsFontSizeToFitWidthProperty, value);
		}

		public static bool IsAdjustsFontSizeToFitWidthEnabled(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			return GetAdjustsFontSizeToFitWidth(config.Element);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetAdjustsFontSizeToFitWidthEnabled(this IPlatformElementConfiguration<iOS, FormsElement> config, bool value)
		{
			SetAdjustsFontSizeToFitWidth(config.Element, value);
			return config;
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> EnableAdjustsFontSizeToFitWidth(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			SetAdjustsFontSizeToFitWidth(config.Element, true);
			return config;
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> DisableAdjustsFontSizeToFitWidth(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			SetAdjustsFontSizeToFitWidth(config.Element, false);
			return config;
		}
	}
}
