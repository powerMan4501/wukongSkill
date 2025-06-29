using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void CancelEventHandler(object sender, CancelEventArgs e);
