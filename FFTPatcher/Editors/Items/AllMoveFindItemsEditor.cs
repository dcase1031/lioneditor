/*
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

using System;
using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class AllMoveFindItemsEditor : UserControl
    {
		#region Constructors (1) 

        public AllMoveFindItemsEditor()
        {
            InitializeComponent();
            mapMoveFindItemEditor1.DataChanged += new EventHandler( mapMoveFindItemEditor1_DataChanged );
        }

		#endregion Constructors 

		#region Public Methods (1) 

        public void UpdateView( AllMoveFindItems items )
        {
            mapListBox.SelectedIndexChanged -= mapListBox_SelectedIndexChanged;
            mapListBox.DataSource = items.MoveFindItems;
            mapListBox.SelectedIndexChanged += mapListBox_SelectedIndexChanged;
            mapListBox.SelectedIndex = 0;
            mapMoveFindItemEditor1.MapMoveFindItems = mapListBox.SelectedItem as MapMoveFindItems;
        }

		#endregion Public Methods 

		#region Private Methods (2) 

        void mapListBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            MapMoveFindItems map = mapListBox.SelectedItem as MapMoveFindItems;
            mapMoveFindItemEditor1.MapMoveFindItems = map;
        }

        void mapMoveFindItemEditor1_DataChanged( object sender, EventArgs e )
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[mapListBox.DataSource];
            cm.Refresh();
        }

		#endregion Private Methods 
    }
}
