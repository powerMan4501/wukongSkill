using System.Collections;

namespace System.Net.Mail;

internal static class SmtpAuthenticationManager
{
	private static ArrayList modules;

	static SmtpAuthenticationManager()
	{
		modules = new ArrayList();
		Register(new SmtpNegotiateAuthenticationModule());
		Register(new SmtpNtlmAuthenticationModule());
		Register(new SmtpDigestAuthenticationModule());
		Register(new SmtpLoginAuthenticationModule());
	}

	internal static void Register(ISmtpAuthenticationModule module)
	{
		if (module == null)
		{
			throw new ArgumentNullException("module");
		}
		lock (modules)
		{
			modules.Add(module);
		}
	}

	internal static ISmtpAuthenticationModule[] GetModules()
	{
		lock (modules)
		{
			ISmtpAuthenticationModule[] array = new ISmtpAuthenticationModule[modules.Count];
			modules.CopyTo(0, array, 0, modules.Count);
			return array;
		}
	}
}
