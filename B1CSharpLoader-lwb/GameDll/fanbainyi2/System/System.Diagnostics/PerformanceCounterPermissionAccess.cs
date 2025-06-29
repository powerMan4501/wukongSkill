namespace System.Diagnostics;

[Flags]
public enum PerformanceCounterPermissionAccess
{
	[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Read instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	Browse = 1,
	[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Write instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	Instrument = 3,
	None = 0,
	Read = 1,
	Write = 2,
	Administer = 7
}
