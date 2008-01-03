﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    LionEditor is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LionEditor is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LionEditor.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class ItemAttributeEditor : UserControl
    {
        private bool ignoreChanges = false;
        private NumericUpDown[] spinners;
        private ItemAttributes attributes;
        public ItemAttributes ItemAttributes
        {
            get { return attributes; }
            set
            {
                if( value == null )
                {
                    this.Enabled = false;
                    this.attributes = null;
                }
                else if( value != attributes )
                {
                    attributes = value;
                    this.Enabled = true;
                    UpdateView();
                }
            }
        }

        private void UpdateView()
        {
            this.ignoreChanges = true;
            SuspendLayout();
            statusImmunityEditor.SuspendLayout();
            startingStatusesEditor.SuspendLayout();
            permanentStatusesEditor.SuspendLayout();
            strongElementsEditor.SuspendLayout();
            weakElementsEditor.SuspendLayout();
            halfElementsEditor.SuspendLayout();
            absorbElementsEditor.SuspendLayout();
            cancelElementsEditor.SuspendLayout();

            foreach( NumericUpDown spinner in spinners )
            {
                spinner.Value = Utilities.GetFieldOrProperty<byte>( attributes, spinner.Tag.ToString() );
            }
            statusImmunityEditor.Statuses = attributes.StatusImmunity;
            startingStatusesEditor.Statuses = attributes.StartingStatuses;
            permanentStatusesEditor.Statuses = attributes.PermanentStatuses;
            strongElementsEditor.Elements = attributes.Strong;
            weakElementsEditor.Elements = attributes.Weak;
            halfElementsEditor.Elements = attributes.Half;
            absorbElementsEditor.Elements = attributes.Absorb;
            cancelElementsEditor.Elements = attributes.Cancel;

            cancelElementsEditor.ResumeLayout();
            absorbElementsEditor.ResumeLayout();
            halfElementsEditor.ResumeLayout();
            weakElementsEditor.ResumeLayout();
            strongElementsEditor.ResumeLayout();
            permanentStatusesEditor.ResumeLayout();
            startingStatusesEditor.ResumeLayout();
            statusImmunityEditor.ResumeLayout();
            ResumeLayout();
            this.ignoreChanges = false;
        }

        public ItemAttributeEditor()
        {
            InitializeComponent();
            spinners = new NumericUpDown[] { maSpinner, paSpinner, speedSpinner, moveSpinner, jumpSpinner };
            foreach( NumericUpDown spinner in spinners )
            {
                spinner.ValueChanged += spinner_ValueChanged;
            }
        }

        private void spinner_ValueChanged( object sender, EventArgs e )
        {
            if( !ignoreChanges )
            {
                NumericUpDown spinner = sender as NumericUpDown;
                Utilities.SetFieldOrProperty( attributes, spinner.Tag.ToString(), (byte)spinner.Value );
            }
        }
    }
}