using System;

namespace ArtistReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            // singelton patternt
            var scheduler = Scheduler.GetFirstInstance();

            // facade pattern
            scheduler.Add(new Meeting()
            {
                DateOn = DateTime.Now.AddDays(7),
                Name = "Casting on Game of Thrones",
                Description = "Talk about royalty"
            });
        }
    }
}
