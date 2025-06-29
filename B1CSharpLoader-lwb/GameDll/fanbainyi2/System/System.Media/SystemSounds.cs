using System.Security.Permissions;

namespace System.Media;

[HostProtection(SecurityAction.LinkDemand, UI = true)]
public sealed class SystemSounds
{
	private class NativeMethods
	{
		internal const int MB_ICONHAND = 16;

		internal const int MB_ICONQUESTION = 32;

		internal const int MB_ICONEXCLAMATION = 48;

		internal const int MB_ICONASTERISK = 64;

		private NativeMethods()
		{
		}
	}

	private static volatile SystemSound asterisk;

	private static volatile SystemSound beep;

	private static volatile SystemSound exclamation;

	private static volatile SystemSound hand;

	private static volatile SystemSound question;

	public static SystemSound Asterisk
	{
		get
		{
			if (asterisk == null)
			{
				asterisk = new SystemSound(64);
			}
			return asterisk;
		}
	}

	public static SystemSound Beep
	{
		get
		{
			if (beep == null)
			{
				beep = new SystemSound(0);
			}
			return beep;
		}
	}

	public static SystemSound Exclamation
	{
		get
		{
			if (exclamation == null)
			{
				exclamation = new SystemSound(48);
			}
			return exclamation;
		}
	}

	public static SystemSound Hand
	{
		get
		{
			if (hand == null)
			{
				hand = new SystemSound(16);
			}
			return hand;
		}
	}

	public static SystemSound Question
	{
		get
		{
			if (question == null)
			{
				question = new SystemSound(32);
			}
			return question;
		}
	}

	private SystemSounds()
	{
	}
}
