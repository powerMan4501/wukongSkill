using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.HiAltFxAnimalRotInfo")]
public struct FHiAltFxAnimalRotInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalRotInfo:RotType")]
	public EHitAltFxAnimalRotType RotType;

	[DisplayName("周围点偏移")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("偏移空间为相机的Trans, eg:填(1000,0,0),即为玩家位置+相机正朝向*1000")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "RotType == EHitAltFxAnimalRotType::RotToPlayerSurround")]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalRotInfo:SurroundOffset")]
	public FVector SurroundOffset;

	private static int HiAltFxAnimalRotInfo_StructSize;

	private static int HiAltFxAnimalRotInfo_IsValid;

	private static bool RotType_IsValid;

	private static int RotType_Offset;

	private static FFieldAddress RotType_PropertyAddress;

	private static bool SurroundOffset_IsValid;

	private static int SurroundOffset_Offset;

	public FHiAltFxAnimalRotInfo Copy()
	{
		return this;
	}

	public static FHiAltFxAnimalRotInfo FromNative(IntPtr nativeBuffer)
	{
		return new FHiAltFxAnimalRotInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHiAltFxAnimalRotInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHiAltFxAnimalRotInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHiAltFxAnimalRotInfo(IntPtr.Add(nativeBuffer, arrayIndex * HiAltFxAnimalRotInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHiAltFxAnimalRotInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HiAltFxAnimalRotInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HiAltFxAnimalRotInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HiAltFxAnimalRotInfo");
			return;
		}
		EnumMarshaler<EHitAltFxAnimalRotType>.ToNative(IntPtr.Add(nativeStruct, RotType_Offset), 0, RotType_PropertyAddress.Address, RotType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SurroundOffset_Offset), SurroundOffset);
	}

	public FHiAltFxAnimalRotInfo(IntPtr nativeStruct)
	{
		if (HiAltFxAnimalRotInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HiAltFxAnimalRotInfo");
			RotType = EHitAltFxAnimalRotType.CamDir_Fwd;
			SurroundOffset = default(FVector);
		}
		else
		{
			RotType = EnumMarshaler<EHitAltFxAnimalRotType>.FromNative(IntPtr.Add(nativeStruct, RotType_Offset), 0, RotType_PropertyAddress.Address);
			SurroundOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SurroundOffset_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HiAltFxAnimalRotInfo");
		HiAltFxAnimalRotInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref RotType_PropertyAddress, intPtr, "RotType");
		RotType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotType");
		RotType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotType", Classes.FEnumProperty);
		SurroundOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurroundOffset");
		SurroundOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurroundOffset", Classes.FStructProperty);
		HiAltFxAnimalRotInfo_IsValid = ((intPtr != IntPtr.Zero && RotType_IsValid && SurroundOffset_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HiAltFxAnimalRotInfo", (byte)HiAltFxAnimalRotInfo_IsValid != 0);
	}

	static FHiAltFxAnimalRotInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHiAltFxAnimalRotInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHiAltFxAnimalRotInfo));
	}
}
