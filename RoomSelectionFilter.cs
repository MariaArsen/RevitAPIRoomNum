﻿using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI.Selection;

namespace RevitAPIRoomNum_Total_
{
    public class RoomSelectionFilter : ISelectionFilter
    {

        public bool AllowElement(Autodesk.Revit.DB.Element elem)
        {
            if (elem is Room)
            {
                return true;
            }
            return false;
        }

        public bool AllowReference(Autodesk.Revit.DB.Reference reference, Autodesk.Revit.DB.XYZ position)
        {
            return false;
        }
    }
}