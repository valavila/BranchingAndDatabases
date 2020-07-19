using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndDatabasePractice
{
    /// <summary>
    /// Equiment represents a single piece of computer equipment
    /// </summary>
    class Equipment
    {
        /// <summary>
        /// Primary key of the equipment
        /// </summary>
        public int EquipmentId { get; set; }

        /// <summary>
        /// Name of equipment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Retail price of the equipment
        /// </summary>
        public double Price { get; set; }
    }

}
