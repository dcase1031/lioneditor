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
    along with FFTPatcher.  If not, see <http:,www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace FFTPatcher.TextEditor.Files.PSP
{
    /// <summary>
    /// Text for the BOOT.BIN file at location 0x326F24.
    /// </summary>
    public class BOOT326F24 : AbstractDelimitedFile, IBootBin
    {

		#region Fields (1) 

        private static Dictionary<int, long> locations;

		#endregion Fields 

		#region Constructors (2) 

        /// <summary>
        /// Initializes a new instance of the <see cref="BOOT326F24"/> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        public BOOT326F24( IList<byte> bytes )
            : base( bytes, 0x0000, 0x04C4, 0x0AD0, 0x1EB4, 0x2504, 0x359C, 0x5194, 0x51F8, 0x5540 )
        {
        }

        private BOOT326F24()
        {
        }

		#endregion Constructors 

		#region Properties (5) 

        /// <summary>
        /// Gets the character map that is used for this file.
        /// </summary>
        public override GenericCharMap CharMap
        {
            get { return TextUtilities.PSPMap; }
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        public override string Filename
        {
            get { return "BOOT.BIN[0x326F24]"; }
        }

        /// <summary>
        /// Gets the filenames and locations for this file.
        /// </summary>
        ICollection<long> IBootBin.Locations
        {
            get { return ( this as AbstractStringSectioned ).Locations.Values; }
        }

        /// <summary>
        /// Gets the filenames and locations for this file.
        /// </summary>
        public override IDictionary<int, long> Locations
        {
            get
            {
                if ( locations == null )
                {
                    locations = new Dictionary<int, long>();
                    locations.Add( 0, 0x326F24 );
                }
                return locations;
            }
        }

        /// <summary>
        /// Gets the maximum length of this file as a byte array.
        /// </summary>
        public override int MaxLength
        {
            get { return 0x6441; }
        }

		#endregion Properties 

		#region Methods (1) 


		// Public Methods (1) 

        /// <summary>
        /// Gets other patches necessary to make modifications to this file functional.
        /// </summary>
        public override IList<PatchedByteArray> GetOtherPatches()
        {
            List<PatchedByteArray> result = new List<PatchedByteArray>( base.GetOtherPatches() );
            return result;
        }


		#endregion Methods 

    }

}
