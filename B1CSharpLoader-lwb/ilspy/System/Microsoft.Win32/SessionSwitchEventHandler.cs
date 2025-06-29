using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public delegate void SessionSwitchEventHandler(object sender, SessionSwitchEventArgs e);
