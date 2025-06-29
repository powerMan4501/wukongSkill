namespace System.Runtime.InteropServices.ComTypes;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum FUNCFLAGS : short
{
	[__DynamicallyInvokable]
	FUNCFLAG_FRESTRICTED = 1,
	[__DynamicallyInvokable]
	FUNCFLAG_FSOURCE = 2,
	[__DynamicallyInvokable]
	FUNCFLAG_FBINDABLE = 4,
	[__DynamicallyInvokable]
	FUNCFLAG_FREQUESTEDIT = 8,
	[__DynamicallyInvokable]
	FUNCFLAG_FDISPLAYBIND = 0x10,
	[__DynamicallyInvokable]
	FUNCFLAG_FDEFAULTBIND = 0x20,
	[__DynamicallyInvokable]
	FUNCFLAG_FHIDDEN = 0x40,
	[__DynamicallyInvokable]
	FUNCFLAG_FUSESGETLASTERROR = 0x80,
	[__DynamicallyInvokable]
	FUNCFLAG_FDEFAULTCOLLELEM = 0x100,
	[__DynamicallyInvokable]
	FUNCFLAG_FUIDEFAULT = 0x200,
	[__DynamicallyInvokable]
	FUNCFLAG_FNONBROWSABLE = 0x400,
	[__DynamicallyInvokable]
	FUNCFLAG_FREPLACEABLE = 0x800,
	[__DynamicallyInvokable]
	FUNCFLAG_FIMMEDIATEBIND = 0x1000
}
