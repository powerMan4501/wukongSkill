using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void AddingNewEventHandler(object sender, AddingNewEventArgs e);
