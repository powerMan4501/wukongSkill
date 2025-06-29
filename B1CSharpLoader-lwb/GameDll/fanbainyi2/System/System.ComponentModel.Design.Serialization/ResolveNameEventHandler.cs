using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void ResolveNameEventHandler(object sender, ResolveNameEventArgs e);
