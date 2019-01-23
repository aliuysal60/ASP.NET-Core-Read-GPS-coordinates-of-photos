using ExifLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadGPSData
{
    public static class ExifLibExtensions
    {
        public static double? GetLatitude(this ExifReader reader)
        {
            return reader.GetCoordinate(ExifTags.GPSLatitude);
        }

        public static double? GetLongitude(this ExifReader reader)
        {
            return reader.GetCoordinate(ExifTags.GPSLongitude);
        }

        private static double? GetCoordinate(this ExifReader reader, ExifTags type)
        {
            if (reader.GetTagValue(type, out double[] coordinates))
            {
                return ToDoubleCoordinates(coordinates);
            }

            return null;
        }

        private static double ToDoubleCoordinates(double[] coordinates)
        {
            return coordinates[0] + coordinates[1] / 60f + coordinates[2] / 3600f;
        }
    }
}
