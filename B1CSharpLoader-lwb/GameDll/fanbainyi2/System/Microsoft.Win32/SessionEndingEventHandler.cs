using System.Security.Permissions;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public delegate void SessionEndingEventHandler(object sender, SessionEndingEventArgs e);
