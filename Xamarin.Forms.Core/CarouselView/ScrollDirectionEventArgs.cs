﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms
{
	public class ScrollDirectionEventArgs : EventArgs
	{
		public double NewValue { get; set; }
		public ScrollDirection Direction { get; set; }
	}
}