using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32;

[Serializable]
[ComVisible(true)]
public enum RegistryHive
{
	ClassesRoot = int.MinValue,
	CurrentUser,
	LocalMachine,
	Users,
	PerformanceData,
	CurrentConfig,
	DynData
}
