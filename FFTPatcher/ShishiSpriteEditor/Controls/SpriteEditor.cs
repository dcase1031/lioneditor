﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FFTPatcher.SpriteEditor
{
    public partial class SpriteEditor : UserControl
    {
        public Sprite Sprite { get; private set;}

        public AbstractSprite AbstractSprite { get; private set; }
        bool ignoreChanges = true;

        private Stream iso;
        public void BindTo(Sprite sprite, Stream iso)
        {
            ignoreChanges = true;
            this.iso = iso;
            Sprite = sprite;
            ReloadSprite();
            Enabled = true;
            ignoreChanges = false;
        }

        public void ReloadSprite()
        {
            bool oldIgnoreChanges = ignoreChanges;
            ignoreChanges = true;
            AbstractSprite = Sprite.GetAbstractSpriteFromPsxIso( iso );
            spriteViewer1.Sprite = AbstractSprite;
            shpComboBox.SelectedItem = Sprite.SHP;
            seqComboBox.SelectedItem = Sprite.SEQ;
            flyingCheckbox.Checked = Sprite.Flying;
            flagsCheckedListBox.BeginUpdate();
            flagsCheckedListBox.SetItemChecked( 0, Sprite.Flag1 );
            flagsCheckedListBox.SetItemChecked( 1, Sprite.Flag2 );
            flagsCheckedListBox.SetItemChecked( 2, Sprite.Flag3 );
            flagsCheckedListBox.SetItemChecked( 3, Sprite.Flag4 );
            flagsCheckedListBox.SetItemChecked( 4, Sprite.Flag5 );
            flagsCheckedListBox.SetItemChecked( 5, Sprite.Flag6 );
            flagsCheckedListBox.SetItemChecked( 6, Sprite.Flag7 );
            flagsCheckedListBox.SetItemChecked( 7, Sprite.Flag8 );
            flagsCheckedListBox.EndUpdate();
            UpdateShapes();
            ignoreChanges = oldIgnoreChanges;
        }

        private Shape currentShape;
        private void UpdateShapes()
        {
            bool oldIgnoreChanges = ignoreChanges;
            ignoreChanges = true;
            if ( Shape.Shapes.ContainsKey( Sprite.SHP ) )
            {
                numericUpDown1.Enabled = true;
                pictureBox1.Enabled = true;

                currentShape = Shape.Shapes[Sprite.SHP];
                numericUpDown1.Value = 1;
                numericUpDown1.Maximum = currentShape.Frames.Count - 1;
            }
            else
            {
                numericUpDown1.Enabled = false;
                pictureBox1.Enabled = false;
                currentShape = null;
            }
            UpdatePictureBox();

            ignoreChanges = oldIgnoreChanges;
        }

        public SpriteEditor()
        {
            InitializeComponent();
            var s = new List<SpriteType>( (SpriteType[])Enum.GetValues( typeof( SpriteType ) ) );
            s.Remove(SpriteType.RUKA);

            shpComboBox.DataSource = s.ToArray();
            seqComboBox.DataSource = Enum.GetValues(typeof(SpriteType));
            paletteSelector.SelectedIndex = 0;
        }

        private void PaletteChanged(object sender, EventArgs e)
        {
            if (!ignoreChanges)
                spriteViewer1.SetPalette(paletteSelector.SelectedIndex, portraitCheckbox.Checked ? (paletteSelector.SelectedIndex % 8 + 8) : paletteSelector.SelectedIndex);
        }

        private void shpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( !ignoreChanges )
            {
                Sprite.SetSHP( iso, (SpriteType)shpComboBox.SelectedItem );
                UpdateShapes();
            }
        }

        private void seqComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ignoreChanges)
                Sprite.SetSEQ(iso, (SpriteType)seqComboBox.SelectedItem);
        }

        private void flyingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ignoreChanges)
                Sprite.SetFlying(iso, flyingCheckbox.Checked);
        }

        private void flagsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!ignoreChanges)
                Sprite.SetFlag(iso, e.Index, e.NewValue == CheckState.Checked);
        }

        private void UpdatePictureBox()
        {
            Image i = pictureBox1.Image;

            if (currentShape != null)
            {
                Frame currentFrame = currentShape.Frames[(int)numericUpDown1.Value];
                pictureBox1.Image = currentFrame.GetFrame(Sprite.GetAbstractSpriteFromPsxIso(iso));
                spriteViewer1.HighlightTiles(currentFrame.Tiles);
            }
            else
            {
                pictureBox1.Image = null;
            }

            if (i != null)
            {
                i.Dispose();
            }
        }
        private void numericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            if ( !ignoreChanges && currentShape != null )
            {
                UpdatePictureBox();
            }
        }

    }
}