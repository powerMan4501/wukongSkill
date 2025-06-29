using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PhysicBlendInfo")]
public struct FPhysicBlendInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfo:BoneName")]
	public FName BoneName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfo:PhysicBlendInType")]
	public EPhysicBlendInType PhysicBlendInType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfo:BlendInTime")]
	public float BlendInTime;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfo:PhysicBlendOutType")]
	public EPhysicBlendOutType PhysicBlendOutType;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PhysicBlendInfo:BlendOutTime")]
	public float BlendOutTime;

	private static int PhysicBlendInfo_StructSize;

	private static int PhysicBlendInfo_IsValid;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	private static bool PhysicBlendInType_IsValid;

	private static int PhysicBlendInType_Offset;

	private static FFieldAddress PhysicBlendInType_PropertyAddress;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool PhysicBlendOutType_IsValid;

	private static int PhysicBlendOutType_Offset;

	private static FFieldAddress PhysicBlendOutType_PropertyAddress;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	public FPhysicBlendInfo Copy()
	{
		return this;
	}

	public static FPhysicBlendInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPhysicBlendInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPhysicBlendInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPhysicBlendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPhysicBlendInfo(IntPtr.Add(nativeBuffer, arrayIndex * PhysicBlendInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPhysicBlendInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PhysicBlendInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PhysicBlendInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PhysicBlendInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		EnumMarshaler<EPhysicBlendInType>.ToNative(IntPtr.Add(nativeStruct, PhysicBlendInType_Offset), 0, PhysicBlendInType_PropertyAddress.Address, PhysicBlendInType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendInTime_Offset), BlendInTime);
		EnumMarshaler<EPhysicBlendOutType>.ToNative(IntPtr.Add(nativeStruct, PhysicBlendOutType_Offset), 0, PhysicBlendOutType_PropertyAddress.Address, PhysicBlendOutType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset), BlendOutTime);
	}

	public FPhysicBlendInfo(IntPtr nativeStruct)
	{
		if (PhysicBlendInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PhysicBlendInfo");
			BoneName = default(FName);
			PhysicBlendInType = EPhysicBlendInType.Immediately;
			BlendInTime = 0f;
			PhysicBlendOutType = EPhysicBlendOutType.Immediately;
			BlendOutTime = 0f;
		}
		else
		{
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			PhysicBlendInType = EnumMarshaler<EPhysicBlendInType>.FromNative(IntPtr.Add(nativeStruct, PhysicBlendInType_Offset), 0, PhysicBlendInType_PropertyAddress.Address);
			BlendInTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendInTime_Offset));
			PhysicBlendOutType = EnumMarshaler<EPhysicBlendOutType>.FromNative(IntPtr.Add(nativeStruct, PhysicBlendOutType_Offset), 0, PhysicBlendOutType_PropertyAddress.Address);
			BlendOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PhysicBlendInfo");
		PhysicBlendInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		BoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref PhysicBlendInType_PropertyAddress, intPtr, "PhysicBlendInType");
		PhysicBlendInType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendInType");
		PhysicBlendInType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendInType", Classes.FEnumProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PhysicBlendOutType_PropertyAddress, intPtr, "PhysicBlendOutType");
		PhysicBlendOutType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendOutType");
		PhysicBlendOutType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendOutType", Classes.FEnumProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		PhysicBlendInfo_IsValid = ((intPtr != IntPtr.Zero && BoneName_IsValid && PhysicBlendInType_IsValid && BlendInTime_IsValid && PhysicBlendOutType_IsValid && BlendOutTime_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PhysicBlendInfo", (byte)PhysicBlendInfo_IsValid != 0);
	}

	static FPhysicBlendInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPhysicBlendInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPhysicBlendInfo));
	}
}
