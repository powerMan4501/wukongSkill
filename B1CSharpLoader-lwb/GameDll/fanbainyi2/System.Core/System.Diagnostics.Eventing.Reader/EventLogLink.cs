using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventLogLink
{
	private string channelName;

	private bool isImported;

	private string displayName;

	private uint channelId;

	private bool dataReady;

	private ProviderMetadata pmReference;

	private object syncObject;

	public string LogName
	{
		get
		{
			PrepareData();
			return channelName;
		}
	}

	public bool IsImported
	{
		get
		{
			PrepareData();
			return isImported;
		}
	}

	public string DisplayName
	{
		get
		{
			PrepareData();
			return displayName;
		}
	}

	internal uint ChannelId => channelId;

	internal EventLogLink(uint channelId, ProviderMetadata pmReference)
	{
		this.channelId = channelId;
		this.pmReference = pmReference;
		syncObject = new object();
	}

	internal EventLogLink(string channelName, bool isImported, string displayName, uint channelId)
	{
		this.channelName = channelName;
		this.isImported = isImported;
		this.displayName = displayName;
		this.channelId = channelId;
		dataReady = true;
		syncObject = new object();
	}

	private void PrepareData()
	{
		if (dataReady)
		{
			return;
		}
		lock (syncObject)
		{
			if (dataReady)
			{
				return;
			}
			IEnumerable<EventLogLink> logLinks = pmReference.LogLinks;
			channelName = null;
			isImported = false;
			displayName = null;
			dataReady = true;
			foreach (EventLogLink item in logLinks)
			{
				if (item.ChannelId == channelId)
				{
					channelName = item.LogName;
					isImported = item.IsImported;
					displayName = item.DisplayName;
					dataReady = true;
					break;
				}
			}
		}
	}
}
