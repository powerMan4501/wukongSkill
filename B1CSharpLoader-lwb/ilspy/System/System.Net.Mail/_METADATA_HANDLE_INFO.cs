using System.Runtime.InteropServices;

namespace System.Net.Mail;

[StructLayout(LayoutKind.Sequential)]
internal class _METADATA_HANDLE_INFO
{
	internal int dwMDPermissions;

	internal int dwMDSystemChangeNumber;

	private _METADATA_HANDLE_INFO()
	{
		dwMDPermissions = 0;
		dwMDSystemChangeNumber = 0;
	}
}
