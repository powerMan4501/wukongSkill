using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class WarningException : SystemException
{
	private readonly string helpUrl;

	private readonly string helpTopic;

	public string HelpUrl => helpUrl;

	public string HelpTopic => helpTopic;

	public WarningException()
		: this(null, null, null)
	{
	}

	public WarningException(string message)
		: this(message, null, null)
	{
	}

	public WarningException(string message, string helpUrl)
		: this(message, helpUrl, null)
	{
	}

	public WarningException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public WarningException(string message, string helpUrl, string helpTopic)
		: base(message)
	{
		this.helpUrl = helpUrl;
		this.helpTopic = helpTopic;
	}

	protected WarningException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		helpUrl = (string)info.GetValue("helpUrl", typeof(string));
		helpTopic = (string)info.GetValue("helpTopic", typeof(string));
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("helpUrl", helpUrl);
		info.AddValue("helpTopic", helpTopic);
		base.GetObjectData(info, context);
	}
}
