using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventMetadata
{
	private long id;

	private byte version;

	private byte channelId;

	private byte level;

	private short opcode;

	private int task;

	private long keywords;

	private string template;

	private string description;

	private ProviderMetadata pmReference;

	public long Id => id;

	public byte Version => version;

	public EventLogLink LogLink => new EventLogLink(channelId, pmReference);

	public EventLevel Level => new EventLevel(level, pmReference);

	public EventOpcode Opcode => new EventOpcode(opcode, pmReference);

	public EventTask Task => new EventTask(task, pmReference);

	public IEnumerable<EventKeyword> Keywords
	{
		get
		{
			List<EventKeyword> list = new List<EventKeyword>();
			ulong num = (ulong)keywords;
			ulong num2 = 9223372036854775808uL;
			for (int i = 0; i < 64; i++)
			{
				if ((num & num2) != 0)
				{
					list.Add(new EventKeyword((long)num2, pmReference));
				}
				num2 >>= 1;
			}
			return list;
		}
	}

	public string Template => template;

	public string Description => description;

	internal EventMetadata(uint id, byte version, byte channelId, byte level, byte opcode, short task, long keywords, string template, string description, ProviderMetadata pmReference)
	{
		this.id = id;
		this.version = version;
		this.channelId = channelId;
		this.level = level;
		this.opcode = opcode;
		this.task = task;
		this.keywords = keywords;
		this.template = template;
		this.description = description;
		this.pmReference = pmReference;
	}
}
