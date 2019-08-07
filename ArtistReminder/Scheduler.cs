using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistReminder
{
    public class Scheduler
    {
        private static Scheduler firstInstance = null;

        /// <summary>
        /// Singleton of Scheduler class
        /// </summary>
        /// <returns></returns>
        public static Scheduler GetFirstInstance()
        {
            if (firstInstance == null)
            {
                firstInstance = new Scheduler();
            }

            return firstInstance;
        }

        private static Scheduler secondInstance = null;

        private static object syncSecondInstance = new object();

        /// <summary>
        /// Singleton of Scheduler class, thread safe
        /// </summary>
        /// <returns></returns>
        public static Scheduler GetSecondInstance()
        {
            if (secondInstance == null)
            {
                lock(syncSecondInstance)
                {
                    if (secondInstance == null)
                    {
                        secondInstance = new Scheduler();
                    }
                }
            }

            return secondInstance;
        }


        private static readonly Scheduler thirdInstance = new Scheduler();

        /// <summary>
        /// Singleton of Scheduler class, thread safe too
        /// </summary>
        /// <returns></returns>
        public static Scheduler GetThirdInstance()
        {
            return thirdInstance;
        }

        public IEnumerable<Meeting> Today()
        {
            return new List<Meeting>();
        }
    }
}
