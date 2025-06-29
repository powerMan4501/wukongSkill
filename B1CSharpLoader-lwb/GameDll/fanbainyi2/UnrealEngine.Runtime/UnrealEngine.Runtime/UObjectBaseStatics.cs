using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class UObjectBaseStatics
{
	public static void UObjectForceRegistration(UObject obj)
	{
		Native_UObjectBase.UObjectForceRegistration(obj.Address);
	}

	public static void ProcessNewlyLoadedUObjects()
	{
		Native_UObjectBase.ProcessNewlyLoadedUObjects();
	}
}
