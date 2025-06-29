using System;
using System.Linq;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UMetaPath("/Script/Engine.Blueprint", "Engine", UnrealModuleType.Engine)]
public class UBlueprint : UBlueprintCore
{
	public static UBlueprint GetBlueprintFromClass(UClass inClass)
	{
		return GCHelper.Find<UBlueprint>(Native_UBlueprint.GetBlueprintFromClass((inClass == null) ? IntPtr.Zero : inClass.Address));
	}

	public static bool GetBlueprintHierarchyFromClass(UClass inClass, UBlueprint[] outBlueprintParents)
	{
		using TArrayUnsafe<UBlueprint> tArrayUnsafe = new TArrayUnsafe<UBlueprint>();
		bool result = Native_UBlueprint.GetBlueprintHierarchyFromClass((inClass == null) ? IntPtr.Zero : inClass.Address, tArrayUnsafe.Address);
		outBlueprintParents = tArrayUnsafe.ToArray();
		return result;
	}
}
