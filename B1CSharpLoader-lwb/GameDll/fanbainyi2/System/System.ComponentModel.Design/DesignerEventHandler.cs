using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void DesignerEventHandler(object sender, DesignerEventArgs e);
