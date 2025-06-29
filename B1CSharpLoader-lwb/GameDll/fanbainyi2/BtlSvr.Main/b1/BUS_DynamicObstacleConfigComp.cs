using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DynamicObstacleConfigComp")]
internal class BUS_DynamicObstacleConfigComp : UActorEditCompBase
{
	private b1.BUC_DynamicObstacleConfigData ConfigData;

	private static bool bDefaultEnable_IsValid;

	private static int bDefaultEnable_Offset;

	private static FFieldAddress bDefaultEnable_PropertyAddress;

	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DynamicObstacleConfigComp:bDefaultEnable")]
	public bool bDefaultEnable
	{
		get
		{
			CheckDestroyed();
			if (!bDefaultEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DynamicObstacleConfigComp:bDefaultEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDefaultEnable_Offset), 0, bDefaultEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDefaultEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DynamicObstacleConfigComp:bDefaultEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDefaultEnable_Offset), 0, bDefaultEnable_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<b1.BUC_DynamicObstacleConfigData>().bDefaultEnable = bDefaultEnable;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DynamicObstacleConfigComp");
		NativeReflection.GetPropertyRef(ref bDefaultEnable_PropertyAddress, unrealStruct, "bDefaultEnable");
		bDefaultEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDefaultEnable");
		bDefaultEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDefaultEnable", Classes.FBoolProperty);
	}

	static BUS_DynamicObstacleConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_DynamicObstacleConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_DynamicObstacleConfigComp));
	}
}
