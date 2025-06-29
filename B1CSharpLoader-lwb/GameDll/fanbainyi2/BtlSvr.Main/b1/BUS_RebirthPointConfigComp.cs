using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_RebirthPointConfigComp")]
public class BUS_RebirthPointConfigComp : UActorEditCompBase
{
	private static bool RebirthPointConfig_IsValid;

	private static int RebirthPointConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("RebirthPointConfig")]
	[USharpPath("/Script/b1-Managed.BUS_RebirthPointConfigComp:RebirthPointConfig")]
	public FRebirthPointConfig RebirthPointConfig
	{
		get
		{
			CheckDestroyed();
			if (!RebirthPointConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_RebirthPointConfigComp:RebirthPointConfig");
				return default(FRebirthPointConfig);
			}
			return FRebirthPointConfig.FromNative(IntPtr.Add(base.Address, RebirthPointConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthPointConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_RebirthPointConfigComp:RebirthPointConfig");
			}
			else
			{
				FRebirthPointConfig.ToNative(IntPtr.Add(base.Address, RebirthPointConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_RebirthPointData bUC_RebirthPointData = RequireWritableData<BUC_RebirthPointData>();
		bUC_RebirthPointData.RebirthPointConfigID = RebirthPointConfig.RebirthPointID;
		bUC_RebirthPointData.ActiveSetCurrentRebirthPoint = RebirthPointConfig.bActiveSetCurrentRebirthPoint;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_RebirthPointConfigComp");
		RebirthPointConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthPointConfig");
		RebirthPointConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthPointConfig", Classes.FStructProperty);
	}

	static BUS_RebirthPointConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_RebirthPointConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_RebirthPointConfigComp));
	}
}
