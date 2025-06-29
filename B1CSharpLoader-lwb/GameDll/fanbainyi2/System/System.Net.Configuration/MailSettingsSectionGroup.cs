using System.Configuration;

namespace System.Net.Configuration;

public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup
{
	public SmtpSection Smtp => (SmtpSection)base.Sections["smtp"];
}
