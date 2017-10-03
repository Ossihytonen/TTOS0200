using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Lab05
    {
        public class Radio
        {
            private readonly int Virta = 1;
            private readonly int Maxvolume = 9;
            private readonly int Minvolume = 0;

            private readonly double MaxFrequency = 26000.0;
            private readonly double MinFrequency = 2000.0;

            private double frequency;
            private int volume;
            private int virta;

            public bool KäynnistäLaite(int virtaa)
            {
                if (virtaa == Virta)
                {
                    virta = virtaa;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool Äänenvoimakkuus(int arvo)
            {
                if (arvo <= Maxvolume && arvo >= Minvolume)
                {
                    volume = arvo;
                    return true;
                }
                else
                {

                    return false;
                }
            }
            public bool Taajuus(double hertsit)
            {
                if (hertsit <= MaxFrequency && hertsit >= MinFrequency)
                {
                    frequency = hertsit;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int Volume
            {
                get
                {
                    return volume;
                }
                set
                {

                }
            }
            public double Frequency
            {
                get
                {
                    return frequency;
                }
                set
                {

                }
            }


        }

    }
}
