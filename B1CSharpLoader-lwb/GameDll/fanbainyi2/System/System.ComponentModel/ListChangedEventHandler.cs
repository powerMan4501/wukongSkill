using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void ListChangedEventHandler(object sender, ListChangedEventArgs e);
