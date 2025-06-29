namespace System.Runtime.InteropServices;

[Serializable]
[Obsolete("Use System.Runtime.InteropServices.ComTypes.LIBFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
[Flags]
public enum LIBFLAGS : short
{
	LIBFLAG_FRESTRICTED = 1,
	LIBFLAG_FCONTROL = 2,
	LIBFLAG_FHIDDEN = 4,
	LIBFLAG_FHASDISKIMAGE = 8
}
