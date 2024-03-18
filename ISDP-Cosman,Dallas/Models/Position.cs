using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDP_Cosman_Dallas.Models
{
    public class Position
    {
        private int positionID;
        public int PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }

        private string permissionLevel;
        public string PermissionLevel
        {
            get { return permissionLevel; }
            set { permissionLevel = value; }
        }

        public Position(int positionID, string permissionLevel)
        {
            PositionID = positionID;
            PermissionLevel = permissionLevel;
        }

        public Position() { }
    }
}
