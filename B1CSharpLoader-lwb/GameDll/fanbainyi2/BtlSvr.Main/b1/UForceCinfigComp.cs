using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.ForceCinfigComp")]
public class UForceCinfigComp : USceneComponent
{
	private static bool ForceRandomBiasMin_IsValid;

	private static int ForceRandomBiasMin_Offset;

	private static bool ForceRandomBiasMax_IsValid;

	private static int ForceRandomBiasMax_Offset;

	private static bool DontRotateToAtker_IsValid;

	private static int DontRotateToAtker_Offset;

	private static FFieldAddress DontRotateToAtker_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("随机扰动最小值")]
	[USharpPath("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMin")]
	public FVector ForceRandomBiasMin
	{
		get
		{
			CheckDestroyed();
			if (!ForceRandomBiasMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ForceRandomBiasMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceRandomBiasMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ForceRandomBiasMin_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("随机扰动最大值")]
	[USharpPath("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMax")]
	public FVector ForceRandomBiasMax
	{
		get
		{
			CheckDestroyed();
			if (!ForceRandomBiasMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ForceRandomBiasMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceRandomBiasMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:ForceRandomBiasMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ForceRandomBiasMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("不根据攻击者校准位置")]
	[USharpPath("/Script/b1-Managed.ForceCinfigComp:DontRotateToAtker")]
	public bool DontRotateToAtker
	{
		get
		{
			CheckDestroyed();
			if (!DontRotateToAtker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:DontRotateToAtker");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DontRotateToAtker_Offset), 0, DontRotateToAtker_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DontRotateToAtker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ForceCinfigComp:DontRotateToAtker");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DontRotateToAtker_Offset), 0, DontRotateToAtker_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.ForceCinfigComp");
		ForceRandomBiasMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceRandomBiasMin");
		ForceRandomBiasMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceRandomBiasMin", Classes.FStructProperty);
		ForceRandomBiasMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceRandomBiasMax");
		ForceRandomBiasMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceRandomBiasMax", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DontRotateToAtker_PropertyAddress, unrealStruct, "DontRotateToAtker");
		DontRotateToAtker_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DontRotateToAtker");
		DontRotateToAtker_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DontRotateToAtker", Classes.FBoolProperty);
	}

	static UForceCinfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UForceCinfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UForceCinfigComp));
	}
}
