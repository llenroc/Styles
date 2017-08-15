//
//  IconGraphics.cs
//  TextStyleDemonstration
//
//  Created by Clinton Francis on 5/08/2015.
//  Copyright (c) 2015 Occur. All rights reserved.
//
//  Generated by PaintCode (www.paintcodeapp.com)
//



using System;
using System.Drawing;
using Foundation;
using UIKit;
using CoreGraphics;

namespace TextStyleDemo.iOS
{
	[Register ("IconGraphics")]
	public class IconGraphics : NSObject
	{

		//// Initialization

		static IconGraphics ()
		{
		}

		//// Drawing Methods

		public static void DrawRefreshIcon (UIColor strokeColor)
		{

			//// Group 2
			{
				//// Bezier Drawing
				UIBezierPath bezierPath = new UIBezierPath ();
				bezierPath.MoveTo (new CGPoint (22.65f, 2.0f));
				bezierPath.AddCurveToPoint (new CGPoint (36.33f, 7.67f), new CGPoint (27.6f, 2.0f), new CGPoint (32.55f, 3.89f));
				bezierPath.AddCurveToPoint (new CGPoint (38.13f, 32.97f), new CGPoint (43.23f, 14.57f), new CGPoint (43.83f, 25.39f));
				bezierPath.AddLineTo (new CGPoint (34.26f, 36.84f));
				strokeColor.SetStroke ();
				bezierPath.LineWidth = 1.0f;
				bezierPath.Stroke ();


				//// Bezier 2 Drawing
				UIBezierPath bezier2Path = new UIBezierPath ();
				bezier2Path.MoveTo (new CGPoint (21.35f, 42.0f));
				bezier2Path.AddCurveToPoint (new CGPoint (7.67f, 36.33f), new CGPoint (16.4f, 42.0f), new CGPoint (11.45f, 40.11f));
				bezier2Path.AddCurveToPoint (new CGPoint (5.87f, 11.03f), new CGPoint (0.77f, 29.43f), new CGPoint (0.17f, 18.61f));
				bezier2Path.AddLineTo (new CGPoint (9.74f, 7.16f));
				strokeColor.SetStroke ();
				bezier2Path.LineWidth = 1.0f;
				bezier2Path.Stroke ();


				//// Bezier 3 Drawing
				UIBezierPath bezier3Path = new UIBezierPath ();
				bezier3Path.MoveTo (new CGPoint (34.26f, 29.74f));
				bezier3Path.AddLineTo (new CGPoint (34.26f, 36.84f));
				bezier3Path.AddLineTo (new CGPoint (41.35f, 36.84f));
				bezier3Path.LineJoinStyle = CGLineJoin.Bevel;

				strokeColor.SetStroke ();
				bezier3Path.LineWidth = 1.0f;
				bezier3Path.Stroke ();


				//// Bezier 4 Drawing
				UIBezierPath bezier4Path = new UIBezierPath ();
				bezier4Path.MoveTo (new CGPoint (9.74f, 14.26f));
				bezier4Path.AddLineTo (new CGPoint (9.74f, 7.16f));
				bezier4Path.AddLineTo (new CGPoint (2.65f, 7.16f));
				bezier4Path.LineJoinStyle = CGLineJoin.Bevel;

				strokeColor.SetStroke ();
				bezier4Path.LineWidth = 1.0f;
				bezier4Path.Stroke ();
			}
		}

		public static void DrawArrowIcon (UIColor strokeColor)
		{

			//// Group
			{
				//// Oval Drawing
				var ovalPath = UIBezierPath.FromOval (new CGRect (2.0f, 2.0f, 40.0f, 40.0f));
				strokeColor.SetStroke ();
				ovalPath.LineWidth = 1.0f;
				ovalPath.Stroke ();


				//// Bezier Drawing
				UIBezierPath bezierPath = new UIBezierPath ();
				bezierPath.MoveTo (new CGPoint (18.77f, 11.03f));
				bezierPath.AddLineTo (new CGPoint (29.74f, 22.0f));
				bezierPath.AddLineTo (new CGPoint (18.77f, 32.97f));
				bezierPath.LineJoinStyle = CGLineJoin.Bevel;

				strokeColor.SetStroke ();
				bezierPath.LineWidth = 1.0f;
				bezierPath.Stroke ();
			}
		}

		//// Generated Images

		public static UIImage ImageOfRefreshIcon (UIColor strokeColor)
		{
			UIGraphics.BeginImageContextWithOptions (new CGSize (44.0f, 44.0f), false, 0);
			IconGraphics.DrawRefreshIcon (strokeColor);

			var imageOfRefreshIcon = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();

			return imageOfRefreshIcon;
		}

		public static UIImage ImageOfArrowIcon (UIColor strokeColor)
		{
			UIGraphics.BeginImageContextWithOptions (new CGSize (44.0f, 44.0f), false, 0);
			IconGraphics.DrawArrowIcon (strokeColor);

			var imageOfArrowIcon = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();

			return imageOfArrowIcon;
		}

	}
}
