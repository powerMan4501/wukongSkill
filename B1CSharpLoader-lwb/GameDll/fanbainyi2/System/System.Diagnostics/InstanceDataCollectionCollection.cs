using System.Collections;
using System.Globalization;

namespace System.Diagnostics;

public class InstanceDataCollectionCollection : DictionaryBase
{
	public InstanceDataCollection this[string counterName]
	{
		get
		{
			if (counterName == null)
			{
				throw new ArgumentNullException("counterName");
			}
			object key = counterName.ToLower(CultureInfo.InvariantCulture);
			return (InstanceDataCollection)base.Dictionary[key];
		}
	}

	public ICollection Keys => base.Dictionary.Keys;

	public ICollection Values => base.Dictionary.Values;

	[Obsolete("This constructor has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.ReadCategory() to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public InstanceDataCollectionCollection()
	{
	}

	internal void Add(string counterName, InstanceDataCollection value)
	{
		object key = counterName.ToLower(CultureInfo.InvariantCulture);
		base.Dictionary.Add(key, value);
	}

	public bool Contains(string counterName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("counterName");
		}
		object key = counterName.ToLower(CultureInfo.InvariantCulture);
		return base.Dictionary.Contains(key);
	}

	public void CopyTo(InstanceDataCollection[] counters, int index)
	{
		base.Dictionary.Values.CopyTo(counters, index);
	}
}
