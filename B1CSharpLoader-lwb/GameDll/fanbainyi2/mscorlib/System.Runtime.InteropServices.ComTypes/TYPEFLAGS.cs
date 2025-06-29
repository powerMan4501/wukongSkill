namespace System.Runtime.InteropServices.ComTypes;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum TYPEFLAGS : short
{
	[__DynamicallyInvokable]
	TYPEFLAG_FAPPOBJECT = 1,
	[__DynamicallyInvokable]
	TYPEFLAG_FCANCREATE = 2,
	[__DynamicallyInvokable]
	TYPEFLAG_FLICENSED = 4,
	[__DynamicallyInvokable]
	TYPEFLAG_FPREDECLID = 8,
	[__DynamicallyInvokable]
	TYPEFLAG_FHIDDEN = 0x10,
	[__DynamicallyInvokable]
	TYPEFLAG_FCONTROL = 0x20,
	[__DynamicallyInvokable]
	TYPEFLAG_FDUAL = 0x40,
	[__DynamicallyInvokable]
	TYPEFLAG_FNONEXTENSIBLE = 0x80,
	[__DynamicallyInvokable]
	TYPEFLAG_FOLEAUTOMATION = 0x100,
	[__DynamicallyInvokable]
	TYPEFLAG_FRESTRICTED = 0x200,
	[__DynamicallyInvokable]
	TYPEFLAG_FAGGREGATABLE = 0x400,
	[__DynamicallyInvokable]
	TYPEFLAG_FREPLACEABLE = 0x800,
	[__DynamicallyInvokable]
	TYPEFLAG_FDISPATCHABLE = 0x1000,
	[__DynamicallyInvokable]
	TYPEFLAG_FREVERSEBIND = 0x2000,
	[__DynamicallyInvokable]
	TYPEFLAG_FPROXY = 0x4000
}
