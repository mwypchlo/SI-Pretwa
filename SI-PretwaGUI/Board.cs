using System;
using System.Collections.Generic;

namespace SI_PretwaGUI
{

    public enum Space { None, Empty, Player1, Player2, Horizontal, Vertical, DiagonalLeft, DiagonalRight }

        public class Board
        {
            public static Space[,] StartingBoard = new Space[13, 13] {
            {    Space.Player1,     Space.Horizontal,       Space.Horizontal,   Space.Horizontal,    Space.Horizontal,  Space.Horizontal,       Space.Player1,    Space.Horizontal,     Space.Horizontal,   Space.Horizontal,   Space.Horizontal,      Space.Horizontal,   Space.Player1},
            {    Space.Vertical,    Space.DiagonalLeft,     Space.None,         Space.None,          Space.None,        Space.None,             Space.Vertical,   Space.None,           Space.None,         Space.None,         Space.None,            Space.DiagonalRight,Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Player1,      Space.None,          Space.None,        Space.None,             Space.Player1,    Space.None,           Space.None,         Space.None,         Space.Player1,         Space.None,         Space.Vertical },
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.DiagonalLeft,  Space.None,        Space.None,             Space.Vertical,   Space.None,           Space.None,         Space.DiagonalRight,Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.None,          Space.Player1,     Space.None,             Space.Player1,    Space.None,           Space.Player1,      Space.None,         Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.None,          Space.Vertical,    Space.DiagonalLeft,     Space.Vertical,   Space.DiagonalRight,  Space.Vertical,     Space.None,         Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.None,          Space.Vertical,    Space.None,             Space.Empty,      Space.None,           Space.Vertical,     Space.None,         Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.None,          Space.Vertical,    Space.DiagonalRight,    Space.Vertical,   Space.DiagonalLeft,   Space.Vertical,     Space.None,         Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.None,          Space.Player2,     Space.None,             Space.Player2,    Space.None,           Space.Player2,      Space.None,         Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Vertical,     Space.DiagonalRight, Space.None,        Space.None,             Space.Vertical,   Space.None,           Space.None,         Space.DiagonalLeft, Space.Vertical,        Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.None,             Space.Player2,      Space.None,          Space.None,        Space.None,             Space.Player2,    Space.None,           Space.None,         Space.None,         Space.Player2,         Space.None,         Space.Vertical},
            {    Space.Vertical,    Space.DiagonalRight,    Space.None,         Space.None,          Space.None,        Space.None,             Space.Vertical,   Space.None,           Space.None,         Space.None,         Space.None,            Space.DiagonalLeft, Space.Vertical},
            {    Space.Player2,     Space.Horizontal,       Space.Horizontal,   Space.Horizontal,    Space.Horizontal,  Space.Horizontal,       Space.Player2,    Space.Horizontal,     Space.Horizontal,   Space.Horizontal,   Space.Horizontal,      Space.Horizontal,   Space.Player2},
        };
        
   

}
}
