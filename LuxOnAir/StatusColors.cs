﻿namespace LuxOnAir
{
    /// <summary>
    /// User color settings for defined statuses
    /// </summary>
    internal class StatusColors
    {
        /// <summary>
        /// Color to use when microphone is in use
        /// </summary>
        public int MicInUse;
        /// <summary>
        /// Color to use when microphone is not in use
        /// </summary>
        public int MicNotInUse;
        /// <summary>
        /// Color to use when session is locked
        /// </summary>
        public int SessionLocked;

        /// <summary>
        /// Sets the mic in use status to blink when active
        /// </summary>
        public bool BlinkMicInUse;
        //public bool BlinkMicNotInUse;
        //public bool BlinkSessionLocked;

        public StatusColors()
        {
            // Set default colors
            MicInUse = System.Drawing.Color.Red.ToArgb();
            MicNotInUse = System.Drawing.Color.FromArgb(0, 190, 0).ToArgb();
            SessionLocked = System.Drawing.Color.Yellow.ToArgb();

            BlinkMicInUse = false;
        }

    }
}
