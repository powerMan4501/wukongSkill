using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp")]
public class BUS_ManualSplineMoveVolumeComp : UActorEditCompBase
{
	private static bool ForwardSplineAnimConfig_IsValid;

	private static int ForwardSplineAnimConfig_Offset;

	private static bool ReverseSplineAnimConfig_IsValid;

	private static int ReverseSplineAnimConfig_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ForwardSplineAnimConfig")]
	public BGWDataAsset_ManualSplineMoveAnimConfig ForwardSplineAnimConfig
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSplineAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ForwardSplineAnimConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_ManualSplineMoveAnimConfig>.FromNative(IntPtr.Add(base.Address, ForwardSplineAnimConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSplineAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ForwardSplineAnimConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_ManualSplineMoveAnimConfig>.ToNative(IntPtr.Add(base.Address, ForwardSplineAnimConfig_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ReverseSplineAnimConfig")]
	public BGWDataAsset_ManualSplineMoveAnimConfig ReverseSplineAnimConfig
	{
		get
		{
			CheckDestroyed();
			if (!ReverseSplineAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ReverseSplineAnimConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_ManualSplineMoveAnimConfig>.FromNative(IntPtr.Add(base.Address, ReverseSplineAnimConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReverseSplineAnimConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp:ReverseSplineAnimConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_ManualSplineMoveAnimConfig>.ToNative(IntPtr.Add(base.Address, ReverseSplineAnimConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ManualSplineMoveVolumeData bUC_ManualSplineMoveVolumeData = RequireWritableData<BUC_ManualSplineMoveVolumeData>();
		bUC_ManualSplineMoveVolumeData.ForwardSplineAnimConfig = ForwardSplineAnimConfig;
		bUC_ManualSplineMoveVolumeData.ReverseSplineAnimConfig = ReverseSplineAnimConfig;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ManualSplineMoveVolumeComp");
		ForwardSplineAnimConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardSplineAnimConfig");
		ForwardSplineAnimConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardSplineAnimConfig", Classes.FObjectProperty);
		ReverseSplineAnimConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReverseSplineAnimConfig");
		ReverseSplineAnimConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReverseSplineAnimConfig", Classes.FObjectProperty);
	}

	static BUS_ManualSplineMoveVolumeComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ManualSplineMoveVolumeComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ManualSplineMoveVolumeComp));
	}
}
