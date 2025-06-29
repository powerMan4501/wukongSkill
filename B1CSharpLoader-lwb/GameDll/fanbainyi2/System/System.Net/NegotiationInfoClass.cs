using System.Runtime.InteropServices;

namespace System.Net;

internal class NegotiationInfoClass
{
	internal const string NTLM = "NTLM";

	internal const string Kerberos = "Kerberos";

	internal const string WDigest = "WDigest";

	internal const string Negotiate = "Negotiate";

	internal string AuthenticationPackage;

	internal NegotiationInfoClass(SafeHandle safeHandle, int negotiationState)
	{
		if (safeHandle.IsInvalid)
		{
			return;
		}
		IntPtr ptr = safeHandle.DangerousGetHandle();
		if (negotiationState == 0 || negotiationState == 1)
		{
			IntPtr intPtr = Marshal.ReadIntPtr(ptr, SecurityPackageInfo.NameOffest);
			string text = null;
			if (intPtr != IntPtr.Zero)
			{
				text = Marshal.PtrToStringUni(intPtr);
			}
			if (string.Compare(text, "Kerberos", StringComparison.OrdinalIgnoreCase) == 0)
			{
				AuthenticationPackage = "Kerberos";
			}
			else if (string.Compare(text, "NTLM", StringComparison.OrdinalIgnoreCase) == 0)
			{
				AuthenticationPackage = "NTLM";
			}
			else if (string.Compare(text, "WDigest", StringComparison.OrdinalIgnoreCase) == 0)
			{
				AuthenticationPackage = "WDigest";
			}
			else
			{
				AuthenticationPackage = text;
			}
		}
	}
}
