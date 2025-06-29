using System.Collections;
using System.Globalization;

namespace System.Diagnostics;

public class InstanceDataCollection : DictionaryBase
{
	private string counterName;

	public string CounterName => counterName;

	public ICollection Keys => base.Dictionary.Keys;

	public ICollection Values => base.Dictionary.Values;

	public InstanceData this[string instanceName]
	{
		get
		{
			if (instanceName == null)
			{
				throw new ArgumentNullException("instanceName");
			}
			if (instanceName.Length == 0)
			{
				instanceName = "systemdiagnosticsperfcounterlibsingleinstance";
			}
			object key = instanceName.ToLower(CultureInfo.InvariantCulture);
			return (InstanceData)base.Dictionary[key];
		}
	}

	[Obsolete("This constructor has been deprecated.  Please use System.Diagnostics.InstanceDataCollectionCollection.get_Item to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public InstanceDataCollection(string counterName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("counterName");
		}
		this.counterName = counterName;
	}

	internal void Add(string instanceName, InstanceData value)
	{
		object key = instanceName.ToLower(CultureInfo.InvariantCulture);
		base.Dictionary.Add(key, value);
	}

	public bool Contains(string instanceName)
	{
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		object key = instanceName.ToLower(CultureInfo.InvariantCulture);
		return base.Dictionary.Contains(key);
	}

	public void CopyTo(InstanceData[] instances, int index)
	{
		base.Dictionary.Values.CopyTo(instances, index);
	}
}
