using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        // stores list of locations
        private List<Location> _locations = new List<Location>();

        // Add a location to the world
        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);

        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }

            }
            // Location not found
            return null;

        }

    }

}
