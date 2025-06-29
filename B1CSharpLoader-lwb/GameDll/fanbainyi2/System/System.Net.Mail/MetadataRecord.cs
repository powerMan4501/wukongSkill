using System.Runtime.InteropServices;

namespace System.Net.Mail;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
internal struct MetadataRecord
{
	internal uint Identifier;

	internal uint Attributes;

	internal uint UserType;

	internal uint DataType;

	internal uint DataLen;

	internal IntPtr DataBuf;

	internal uint DataTag;
}
