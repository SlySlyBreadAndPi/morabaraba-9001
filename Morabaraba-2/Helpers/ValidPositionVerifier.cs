﻿using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Morabaraba_2.Classes;
namespace Morabaraba_2.Helpers
{
    /// <summary>
    ///Responsible for Verifying if a specific 
    ///Position on the board is safe to be played or not
    ///This will prevent a user from playing at an already occupied position
    /// </summary>
    public class ValidPositionVerifier
    {
        public ValidPositionVerifier()
        {

        }
        /// <summary>
        /// The main guy 
        /// Uses the opponents color to determine whether a position is valid
        /// or not
        /// </summary>
        /// <param name="board">Actual Human readable Board</param>
        /// <param name="cow">The Proposed position to be played in</param>
        /// <param name="opponent">The Other Player</param>
        /// <returns></returns>
        public bool Verify(Ellipse cow, Board board)
        {
            bool valid = false;
            EllipseColorConverter converter = new EllipseColorConverter();
            for(int i = 0; i < board.GetNodes().Count; i++)
            {
                var EmptySpot = converter.GetActualEllipseColor(ColorType.Colour.Empty);
                if (cow.Fill == EmptySpot)
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }
    }
}