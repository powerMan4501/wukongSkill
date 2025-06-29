using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventTask
{
	private int value;

	private string name;

	private string displayName;

	private Guid guid;

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

	public int Value => value;

	public string DisplayName
	{
		get
		{
			PrepareData();
			return displayName;
		}
	}

	public Guid EventGuid
	{
		get
		{
			PrepareData();
			return guid;
		}
	}

	internal EventTask(int value, ProviderMetadata pmReference)
	{
		this.value = value;
		this.pmReference = pmReference;
		syncObject = new object();
	}

	internal EventTask(string name, int value, string displayName, Guid guid)
	{
		this.value = value;
		this.name = name;
		this.displayName = displayName;
		this.guid = guid;
		dataReady = true;
		syncObject = new object();
	}

	internal void PrepareData()
	{
		lock (syncObject)
		{
			if (dataReady)
			{
				return;
			}
			IEnumerable<EventTask> tasks = pmReference.Tasks;
			name = null;
			displayName = null;
			guid = Guid.Empty;
			dataReady = true;
			foreach (EventTask item in tasks)
			{
				if (item.Value == value)
				{
					name = item.Name;
					displayName = item.DisplayName;
					guid = item.EventGuid;
					dataReady = true;
					break;
				}
			}
		}
	}
}
