using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public delegate void EventHandler(object sender, EventArgs e);
[Serializable]
[__DynamicallyInvokable]
public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
