namespace System.Runtime.InteropServices.ComTypes;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum VARFLAGS : short
{
	[__DynamicallyInvokable]
	VARFLAG_FREADONLY = 1,
	[__DynamicallyInvokable]
	VARFLAG_FSOURCE = 2,
	[__DynamicallyInvokable]
	VARFLAG_FBINDABLE = 4,
	[__DynamicallyInvokable]
	VARFLAG_FREQUESTEDIT = 8,
	[__DynamicallyInvokable]
	VARFLAG_FDISPLAYBIND = 0x10,
	[__DynamicallyInvokable]
	VARFLAG_FDEFAULTBIND = 0x20,
	[__DynamicallyInvokable]
	VARFLAG_FHIDDEN = 0x40,
	[__DynamicallyInvokable]
	VARFLAG_FRESTRICTED = 0x80,
	[__DynamicallyInvokable]
	VARFLAG_FDEFAULTCOLLELEM = 0x100,
	[__DynamicallyInvokable]
	VARFLAG_FUIDEFAULT = 0x200,
	[__DynamicallyInvokable]
	VARFLAG_FNONBROWSABLE = 0x400,
	[__DynamicallyInvokable]
	VARFLAG_FREPLACEABLE = 0x800,
	[__DynamicallyInvokable]
	VARFLAG_FIMMEDIATEBIND = 0x1000
}
