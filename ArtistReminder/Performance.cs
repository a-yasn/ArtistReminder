using System;

namespace ArtistReminder
{
    /// <summary>
    /// decorator
    /// </summary>
    public class Performance : Meeting
    {
        public string Makeup { get; set; }

        public string Dress { get; set; }

        public double Gonorare { get; set; }
    }
}
