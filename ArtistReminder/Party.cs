using System;

namespace ArtistReminder
{
    internal class Party
    {
        private Agency agency;

        public Party(Agency agency)
        {
            this.agency = agency;
        }

        internal void DoIt()
        {
            agency.FindPlace();

            agency.MeetGuests();

            agency.MakeDrinks();
        }

        internal Profit GetProfit()
        {
            return new Profit();
        }
    }
}
