using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void DoWorkEventHandler(object sender, DoWorkEventArgs e);
