using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpawnCollectionComp")]
public class BUS_SpawnCollectionComp : UActorEditCompBase
{
	private static bool SpawnGroup_IsValid;

	private static int SpawnGroup_Offset;

	public override EActorEditCompDataConvertTiming DataConvertTiming => EActorEditCompDataConvertTiming.Init;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("SpawnCollection")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnCollectionComp:SpawnGroup")]
	public FGSSpawnProbabilityGroup SpawnGroup
	{
		get
		{
			CheckDestroyed();
			if (!SpawnGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnCollectionComp:SpawnGroup");
				return default(FGSSpawnProbabilityGroup);
			}
			return FGSSpawnProbabilityGroup.FromNative(IntPtr.Add(base.Address, SpawnGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnCollectionComp:SpawnGroup");
			}
			else
			{
				FGSSpawnProbabilityGroup.ToNative(IntPtr.Add(base.Address, SpawnGroup_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpawnCollectionComp");
		SpawnGroup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnGroup");
		SpawnGroup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnGroup", Classes.FStructProperty);
	}

	static BUS_SpawnCollectionComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpawnCollectionComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpawnCollectionComp));
	}
}
