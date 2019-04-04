﻿using System;

namespace Hello_Events_lect
{
    // The delegate for the bird's events
    internal delegate void BirdEventsHandler(object sender, BirdEventsArgs e);

    internal delegate void BirdEventsHandler_std(object sender, Birds_EventArgs e);

    internal class Bird
    {
        // Bird publisher

        #region Bird_base

        public int FlySpeed { get; set; }
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        //Bird flew away, isn't it?
        private bool BirdFlewAway;
        public int crit_diff;

        public Bird()
        {
            FlySpeed = 35;
            crit_diff = 3;
            Nick = "Titmouse";
        }

        public Bird(string name, int extrim_speed, int speed, int diff)
        {
            NormalSpeed = speed;
            FlySpeed = extrim_speed;
            Nick = name;
            crit_diff = diff;
        }

        #endregion

        #region Opr

        // The bird states
        public event BirdEventsHandler Startle;
        public event BirdEventsHandler_std NotSeeing;

        protected virtual void OnNotSeeing(Birds_EventArgs e)
        {
            if (NotSeeing != null)
            {
                NotSeeing(this, e);
            }
        }

        public void FlyAway(int incrmnt)
        {
            if (BirdFlewAway)
            {
                if (NotSeeing != null)
                {
                    var ev = new Birds_EventArgs();
                    ev.BirdFlewAway = BirdFlewAway;
                    ev.TimeReached = DateTime.Now;
                    OnNotSeeing(ev);
                }
            }
            else
            {
                NormalSpeed += incrmnt;
                if (crit_diff >= FlySpeed - NormalSpeed && Startle != null)
                {
                    Startle(this, new BirdEventsArgs(Nick + " panic ..."));
                }

                if (NormalSpeed >= FlySpeed)
                {
                    BirdFlewAway = true;
                }
                else
                {
                    Console.WriteLine("... flying close with the speed = {0}", NormalSpeed);
                }
            }
        }

        #endregion
    }
}