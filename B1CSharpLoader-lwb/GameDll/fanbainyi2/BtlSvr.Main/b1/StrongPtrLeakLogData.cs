using UnrealEngine.Runtime;

namespace b1;

public class StrongPtrLeakLogData : LeakLogData
{
	public string FullName;

	public string Type;

	public string CacheName;

	public StrongPtrLeakLogData(TStrongObjectPtrBase StrongPtr)
	{
		if (StrongPtr != null)
		{
			UObject uObject = StrongPtr.GetUObject();
			if (!uObject.IsNullOrDestroyed())
			{
				FullName = uObject.GetFullName();
			}
			else
			{
				FullName = StrongPtr.ToString();
			}
			Type = StrongPtr.GetType().ToString();
			CacheName = StrongPtr.GetCacheName();
		}
		else
		{
			FullName = "None";
			Type = "Unkown";
			CacheName = "None";
		}
	}
}
