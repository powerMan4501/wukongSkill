using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventKeyword
{
	private long value;

	private string name;

	private string displayName;

	private bool dataReady;

	private ProviderMetadata pmReference;

	private object syncObject;

	public string Name
	{
		get
		{
			PrepareData();
			return name;
		}
	}

	public long Value => value;

	public string DisplayName
	{
		get
		{
			PrepareData();
			return displayName;
		}
	}

	internal EventKeyword(long value, ProviderMetadata pmReference)
	{
		this.value = value;
		this.pmReference = pmReference;
		syncObject = new object();
	}

	internal EventKeyword(string name, long value, string displayName)
	{
		this.value = value;
		this.name = name;
		this.displayName = displayName;
		dataReady = true;
		syncObject = new object();
	}

	internal void PrepareData()
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
			IEnumerable<EventKeyword> keywords = pmReference.Keywords;
			name = null;
			displayName = null;
			dataReady = true;
			foreach (EventKeyword item in keywords)
			{
				if (item.Value == value)
				{
					name = item.Name;
					displayName = item.DisplayName;
					break;
				}
			}
		}
	}
}
