namespace System {
    using System;

    public delegate void EventHandler(Object sender, EventArgs e);

    public delegate void EventHandler<TEventArgs>(Object sender, TEventArgs e);
}
