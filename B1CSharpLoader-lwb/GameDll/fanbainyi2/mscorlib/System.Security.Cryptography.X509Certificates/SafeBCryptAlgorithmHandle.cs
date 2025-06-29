using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

[SecurityCritical]
[SuppressUnmanagedCodeSecurity]
internal sealed class SafeBCryptAlgorithmHandle : SafeHandle
{
	public override bool IsInvalid
	{
		[SecurityCritical]
		get
		{
			return handle == IntPtr.Zero;
		}
	}

	[DllImport("bcrypt.dll")]
	[SecurityCritical]
	private static extern int BCryptCloseAlgorithmProvider([In] IntPtr hAlgorithm, [In] uint dwFlags);

	[SecurityCritical]
	public SafeBCryptAlgorithmHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected sealed override bool ReleaseHandle()
	{
		int num = BCryptCloseAlgorithmProvider(handle, 0u);
		return num == 0;
	}
}
