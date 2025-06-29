namespace System.Runtime.InteropServices;

[Serializable]
[Flags]
[ComVisible(true)]
public enum TypeLibExporterFlags
{
	None = 0,
	OnlyReferenceRegistered = 1,
	CallerResolvedReferences = 2,
	OldNames = 4,
	ExportAs32Bit = 0x10,
	ExportAs64Bit = 0x20
}
