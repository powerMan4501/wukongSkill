using System.Runtime.InteropServices;

namespace System.Net;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
internal struct AuthIdentity
{
	internal string UserName;

	internal int UserNameLength;

	internal string Domain;

	internal int DomainLength;

	internal string Password;

	internal int PasswordLength;

	internal int Flags;

	internal AuthIdentity(string userName, string password, string domain)
	{
		UserName = userName;
		UserNameLength = userName?.Length ?? 0;
		Password = password;
		PasswordLength = password?.Length ?? 0;
		Domain = domain;
		DomainLength = domain?.Length ?? 0;
		Flags = 2;
	}

	public override string ToString()
	{
		return ValidationHelper.ToString(Domain) + "\\" + ValidationHelper.ToString(UserName);
	}
}
