﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GisSelector
{
    public class PlaceHolderTextBox : TextBox
    {
        private string placeHolderText;

        private bool isPlaceHolder = true;

        public PlaceHolderTextBox()
        {
            GotFocus += (sender, args) => RemovePlaceHolder();
            LostFocus += (sender, args) => SetPlaceholder();
        }

        public string PlaceHolderText
        {
            get { return placeHolderText; }
            set
            {
                placeHolderText = value;
                SetPlaceholder();
            }
        }

        //when the control loses focus, the placeholder is shown
        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = PlaceHolderText;
                ForeColor = Color.Gray;
                Font = new Font(Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void RemovePlaceHolder()
        {
            if (isPlaceHolder)
            {
                Text = "";
                ForeColor = SystemColors.WindowText;
                Font = new Font(Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
    }
}