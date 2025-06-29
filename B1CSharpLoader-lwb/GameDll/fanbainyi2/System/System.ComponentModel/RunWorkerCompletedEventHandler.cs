using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public delegate void RunWorkerCompletedEventHandler(object sender, RunWorkerCompletedEventArgs e);
