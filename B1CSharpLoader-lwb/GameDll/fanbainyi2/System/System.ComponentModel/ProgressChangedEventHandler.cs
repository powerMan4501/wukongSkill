using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void ProgressChangedEventHandler(object sender, ProgressChangedEventArgs e);
