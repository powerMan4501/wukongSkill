namespace System.Runtime.InteropServices;

[Serializable]
[Flags]
[ComVisible(true)]
public enum TypeLibImporterFlags
{
	None = 0,
	PrimaryInteropAssembly = 1,
	UnsafeInterfaces = 2,
	SafeArrayAsSystemArray = 4,
	TransformDispRetVals = 8,
	PreventClassMembers = 0x10,
	SerializableValueClasses = 0x20,
	ImportAsX86 = 0x100,
	ImportAsX64 = 0x200,
	ImportAsItanium = 0x400,
	ImportAsAgnostic = 0x800,
	ReflectionOnlyLoading = 0x1000,
	NoDefineVersionResource = 0x2000,
	ImportAsArm = 0x4000
}
