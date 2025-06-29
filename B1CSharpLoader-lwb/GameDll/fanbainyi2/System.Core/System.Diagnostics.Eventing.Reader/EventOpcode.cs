using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventOpcode
{
	private int value;

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

	public int Value => value;

	public string DisplayName
	{
		get
		{
			PrepareData();
			return displayName;
		}
	}

	internal EventOpcode(int value, ProviderMetadata pmReference)
	{
		this.value = value;
		this.pmReference = pmReference;
		syncObject = new object();
	}

	internal EventOpcode(string name, int value, string displayName)
	{
		this.value = value;
		this.name = name;
		this.displayName = displayName;
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
			IEnumerable<EventOpcode> opcodes = pmReference.Opcodes;
			name = null;
			displayName = null;
			dataReady = true;
			foreach (EventOpcode item in opcodes)
			{
				if (item.Value == value)
				{
					name = item.Name;
					displayName = item.DisplayName;
					dataReady = true;
					break;
				}
			}
		}
	}
}
