namespace System {
    using System;

    // The base class for all event classes.
    public class EventArgs {
        public static readonly EventArgs Empty = new EventArgs();

        public EventArgs() 
        {
        }
    }
}
