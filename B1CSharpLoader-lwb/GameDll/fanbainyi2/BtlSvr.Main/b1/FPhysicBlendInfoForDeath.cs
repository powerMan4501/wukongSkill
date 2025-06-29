using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.PhysicBlendInfoForDeath")]
public struct FPhysicBlendInfoForDeath
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfoForDeath:BoneName")]
	public FName BoneName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfoForDeath:PhysicBlendInType")]
	public EPhysicBlendInType PhysicBlendInType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMax, "1")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfoForDeath:BlendFinalValue")]
	public float BlendFinalValue;

	private static int PhysicBlendInfoForDeath_StructSize;

	private static int PhysicBlendInfoForDeath_IsValid;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	private static bool PhysicBlendInType_IsValid;

	private static int PhysicBlendInType_Offset;

	private static FFieldAddress PhysicBlendInType_PropertyAddress;

	private static bool BlendFinalValue_IsValid;

	private static int BlendFinalValue_Offset;

	public FPhysicBlendInfoForDeath Copy()
	{
		return this;
	}

	public static FPhysicBlendInfoForDeath FromNative(IntPtr nativeBuffer)
	{
		return new FPhysicBlendInfoForDeath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPhysicBlendInfoForDeath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPhysicBlendInfoForDeath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPhysicBlendInfoForDeath(IntPtr.Add(nativeBuffer, arrayIndex * PhysicBlendInfoForDeath_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPhysicBlendInfoForDeath value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PhysicBlendInfoForDeath_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PhysicBlendInfoForDeath_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PhysicBlendInfoForDeath");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		EnumMarshaler<EPhysicBlendInType>.ToNative(IntPtr.Add(nativeStruct, PhysicBlendInType_Offset), 0, PhysicBlendInType_PropertyAddress.Address, PhysicBlendInType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendFinalValue_Offset), BlendFinalValue);
	}

	public FPhysicBlendInfoForDeath(IntPtr nativeStruct)
	{
		if (PhysicBlendInfoForDeath_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PhysicBlendInfoForDeath");
			BoneName = default(FName);
			PhysicBlendInType = EPhysicBlendInType.Immediately;
			BlendFinalValue = 0f;
		}
		else
		{
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			PhysicBlendInType = EnumMarshaler<EPhysicBlendInType>.FromNative(IntPtr.Add(nativeStruct, PhysicBlendInType_Offset), 0, PhysicBlendInType_PropertyAddress.Address);
			BlendFinalValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendFinalValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PhysicBlendInfoForDeath");
		PhysicBlendInfoForDeath_StructSize = NativeReflection.GetStructSize(intPtr);
		BoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref PhysicBlendInType_PropertyAddress, intPtr, "PhysicBlendInType");
		PhysicBlendInType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendInType");
		PhysicBlendInType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendInType", Classes.FEnumProperty);
		BlendFinalValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendFinalValue");
		BlendFinalValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendFinalValue", Classes.FFloatProperty);
		PhysicBlendInfoForDeath_IsValid = ((intPtr != IntPtr.Zero && BoneName_IsValid && PhysicBlendInType_IsValid && BlendFinalValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PhysicBlendInfoForDeath", (byte)PhysicBlendInfoForDeath_IsValid != 0);
	}

	static FPhysicBlendInfoForDeath()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPhysicBlendInfoForDeath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPhysicBlendInfoForDeath));
	}
}
