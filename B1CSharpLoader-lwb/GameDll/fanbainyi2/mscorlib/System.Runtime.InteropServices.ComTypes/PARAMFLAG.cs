namespace System.Runtime.InteropServices.ComTypes;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum PARAMFLAG : short
{
	[__DynamicallyInvokable]
	PARAMFLAG_NONE = 0,
	[__DynamicallyInvokable]
	PARAMFLAG_FIN = 1,
	[__DynamicallyInvokable]
	PARAMFLAG_FOUT = 2,
	[__DynamicallyInvokable]
	PARAMFLAG_FLCID = 4,
	[__DynamicallyInvokable]
	PARAMFLAG_FRETVAL = 8,
	[__DynamicallyInvokable]
	PARAMFLAG_FOPT = 0x10,
	[__DynamicallyInvokable]
	PARAMFLAG_FHASDEFAULT = 0x20,
	[__DynamicallyInvokable]
	PARAMFLAG_FHASCUSTDATA = 0x40
}
