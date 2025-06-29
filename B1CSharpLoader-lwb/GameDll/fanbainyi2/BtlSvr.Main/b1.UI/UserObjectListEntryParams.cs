using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.UserObjectListEntryParams")]
public class UserObjectListEntryParams : UObject
{
	public object DataStore;

	public void Init(object InDataStore)
	{
		DataStore = InDataStore;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.UserObjectListEntryParams");
	}

	static UserObjectListEntryParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UserObjectListEntryParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UserObjectListEntryParams));
	}
}
