using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Net;

internal class SecurityPackageInfoClass
{
	internal int Capabilities;

	internal short Version;

	internal short RPCID;

	internal int MaxToken;

	internal string Name;

	internal string Comment;

	internal SecurityPackageInfoClass(SafeHandle safeHandle, int index)
	{
		if (!safeHandle.IsInvalid)
		{
			IntPtr ptr = IntPtrHelper.Add(safeHandle.DangerousGetHandle(), SecurityPackageInfo.Size * index);
			Capabilities = Marshal.ReadInt32(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "Capabilities"));
			Version = Marshal.ReadInt16(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "Version"));
			RPCID = Marshal.ReadInt16(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "RPCID"));
			MaxToken = Marshal.ReadInt32(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "MaxToken"));
			IntPtr intPtr = Marshal.ReadIntPtr(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "Name"));
			if (intPtr != IntPtr.Zero)
			{
				Name = Marshal.PtrToStringUni(intPtr);
			}
			intPtr = Marshal.ReadIntPtr(ptr, (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "Comment"));
			if (intPtr != IntPtr.Zero)
			{
				Comment = Marshal.PtrToStringUni(intPtr);
			}
		}
	}

	public override string ToString()
	{
		return "Capabilities:" + string.Format(CultureInfo.InvariantCulture, "0x{0:x}", new object[1] { Capabilities }) + " Version:" + Version.ToString(NumberFormatInfo.InvariantInfo) + " RPCID:" + RPCID.ToString(NumberFormatInfo.InvariantInfo) + " MaxToken:" + MaxToken.ToString(NumberFormatInfo.InvariantInfo) + " Name:" + ((Name == null) ? "(null)" : Name) + " Comment:" + ((Comment == null) ? "(null)" : Comment);
	}
}
