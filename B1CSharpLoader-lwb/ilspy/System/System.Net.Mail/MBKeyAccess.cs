namespace System.Net.Mail;

[Flags]
internal enum MBKeyAccess : uint
{
	Read = 1u,
	Write = 2u
}
