using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBattlePaceSpawnPointActor")]
public class BGUBattlePaceSpawnPointActor : AActor
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUBattlePaceSpawnPointActor");
	}

	static BGUBattlePaceSpawnPointActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBattlePaceSpawnPointActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBattlePaceSpawnPointActor));
	}
}
