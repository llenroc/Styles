﻿using System;
using UIKit;

namespace Styles.Text
{
    [Foundation.Preserve(AllMembers = true)]
    public class LabelStyle : ManagedStyleBase
    {
        public UILabel Target { get; private set; }

        public LabelStyle(ITextStyle instance, UILabel target, string styleID, string text, bool updateConstraints)
        {
            styleInstance = instance as TextStyle;
            _updateConstraints = updateConstraints;
            Target = target;

            StyleID = styleID;
            Text = !string.IsNullOrEmpty(text) ? text : Target.Text;
        }

        override public void UpdateFrame()
        {
            // Offset the frame if needed
            if (_updateConstraints && Style.LineHeight < 0f)
            {
                var heightOffset = Style.GetLineHeightOffset();
                var targetFrame = Target.Frame;
                targetFrame.Height = (nfloat)Math.Ceiling(targetFrame.Height) + heightOffset;

                if (Target.Constraints.Length > 0)
                {
                    foreach (var constraint in Target.Constraints)
                    {
                        if (constraint.FirstAttribute == NSLayoutAttribute.Height)
                        {
                            constraint.Constant = targetFrame.Height;
                            break;
                        }
                    }
                }
                else
                {
                    Target.Frame = targetFrame;
                }
            }
        }

        override public void UpdateDisplay()
        {
            if (IsDirty)
            {
                styleInstance.Style(Target, StyleID, Text, CustomTags, true);
                _isDirty = false;
            }
            else
                Target.AttributedText = AttributedValue;
        }

        override public void Dispose()
        {
            EnableHtmlEditing = false;
            Target = null;
        }
    }
}

