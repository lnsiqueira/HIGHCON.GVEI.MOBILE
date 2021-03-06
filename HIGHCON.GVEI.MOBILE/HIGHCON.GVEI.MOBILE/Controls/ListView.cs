﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HIGHCON.GVEI.MOBILE.Controls
{
   public class ListView : Xamarin.Forms.ListView
    {
        public static readonly BindableProperty ItemTappedCommandProperty =
            BindableProperty.Create(
                nameof(ItemTappedCommand),
                typeof(ICommand),
                typeof(ListView),
                null
            );

        public ICommand ItemTappedCommand
        {
            get { return (ICommand)GetValue(ItemTappedCommandProperty); }
            set { SetValue(ItemTappedCommandProperty, value); }
        }

        public ListView()
        {
            ItemTapped += ListView_ItemTapped;
        }

        ~ListView()
        {
            ItemTapped -= ListView_ItemTapped;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (ItemTappedCommand != null && ItemTappedCommand.CanExecute(null))
                ItemTappedCommand.Execute(e.Item);

            SelectedItem = null;
        }
    }
}
