using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void HandledEventHandler(object sender, HandledEventArgs e);
