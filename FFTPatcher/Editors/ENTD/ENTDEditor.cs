﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    FFTPatcher is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FFTPatcher is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FFTPatcher.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class ENTDEditor : UserControl
    {

		#region Constructors (1) 

        public ENTDEditor()
        {
            InitializeComponent();
            eventEditor1.DataChanged += new System.EventHandler( eventEditor1_DataChanged );
            eventListBox.ContextMenu = new ContextMenu(
                new MenuItem[] { new MenuItem( "Clone", CopyClickEventHandler ), new MenuItem( "Paste clone", PasteClickEventHandler ) } );
            eventListBox.ContextMenu.MenuItems[1].Enabled = false;
        }

		#endregion Constructors 

		#region Methods (3) 

        public Event ClipBoardEvent { get; private set; }

        private void CopyClickEventHandler( object sender, System.EventArgs args )
        {
            eventListBox.ContextMenu.MenuItems[1].Enabled = true;
            ClipBoardEvent = eventListBox.SelectedItem as Event;
        }

        private void PasteClickEventHandler( object sender, System.EventArgs args )
        {
            if( ClipBoardEvent != null )
            {
                ClipBoardEvent.CopyTo( eventListBox.SelectedItem as Event );
                eventEditor1.Event = eventListBox.SelectedItem as Event;
                eventEditor1.UpdateView();
                eventEditor1_DataChanged( eventEditor1, System.EventArgs.Empty );
            }
        }


        private void eventEditor1_DataChanged( object sender, System.EventArgs e )
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[eventListBox.DataSource];
            cm.Refresh();
        }

        private void eventListBox_SelectedIndexChanged( object sender, System.EventArgs e )
        {
            eventEditor1.Event = eventListBox.SelectedItem as Event;
        }

        private Context ourContext = Context.Default;
        public void UpdateView( AllENTDs entds )
        {
            if( ourContext != FFTPatch.Context )
            {
                ourContext = FFTPatch.Context;
                ClipBoardEvent = null;
                eventListBox.ContextMenu.MenuItems[1].Enabled = false;
            }

            eventListBox.SelectedIndexChanged -= eventListBox_SelectedIndexChanged;
            eventListBox.DataSource = entds.Events;
            eventListBox.SelectedIndex = 0;
            eventEditor1.Event = eventListBox.SelectedItem as Event;
            eventListBox.SelectedIndexChanged += eventListBox_SelectedIndexChanged;
        }


		#endregion Methods 

    }
}
