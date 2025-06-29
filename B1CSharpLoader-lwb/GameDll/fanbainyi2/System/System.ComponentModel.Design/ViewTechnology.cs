using System.Runtime.InteropServices;

namespace System.ComponentModel.Design;

[ComVisible(true)]
public enum ViewTechnology
{
	[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	Passthrough,
	[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	WindowsForms,
	Default
}
