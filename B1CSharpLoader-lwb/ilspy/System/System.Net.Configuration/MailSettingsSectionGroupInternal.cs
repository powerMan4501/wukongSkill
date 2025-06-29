namespace System.Net.Configuration;

internal sealed class MailSettingsSectionGroupInternal
{
	private SmtpSectionInternal smtp;

	internal SmtpSectionInternal Smtp => smtp;

	internal MailSettingsSectionGroupInternal()
	{
		smtp = SmtpSectionInternal.GetSection();
	}

	internal static MailSettingsSectionGroupInternal GetSection()
	{
		return new MailSettingsSectionGroupInternal();
	}
}
