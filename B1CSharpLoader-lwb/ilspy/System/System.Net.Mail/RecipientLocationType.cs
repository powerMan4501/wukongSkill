namespace System.Net.Mail;

internal enum RecipientLocationType
{
	Local,
	Unknown,
	NotLocal,
	WillForward,
	Ambiguous
}
