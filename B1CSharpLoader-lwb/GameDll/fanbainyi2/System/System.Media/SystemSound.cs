using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Media;

[HostProtection(SecurityAction.LinkDemand, UI = true)]
public class SystemSound
{
	private class SafeNativeMethods
	{
		private SafeNativeMethods()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		internal static extern bool MessageBeep(int type);
	}

	private int soundType;

	internal SystemSound(int soundType)
	{
		this.soundType = soundType;
	}

	public void Play()
	{
		IntSecurity.UnmanagedCode.Assert();
		try
		{
			SafeNativeMethods.MessageBeep(soundType);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}
}
