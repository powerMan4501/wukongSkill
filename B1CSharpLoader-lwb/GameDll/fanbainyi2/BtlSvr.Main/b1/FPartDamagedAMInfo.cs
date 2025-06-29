using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PartDamagedAMInfo")]
public struct FPartDamagedAMInfo
{
	[DisplayName("攻击者在前方部位破损动画")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PartDamagedAMInfo:DamagedAMPathForward")]
	public UAnimMontage DamagedAMPathForward;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击者在后方部位破损动画")]
	[USharpPath("/Script/b1-Managed.PartDamagedAMInfo:DamagedAMPathBackward")]
	public UAnimMontage DamagedAMPathBackward;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击者在左方部位破损动画")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PartDamagedAMInfo:DamagedAMPathLeftSide")]
	public UAnimMontage DamagedAMPathLeftSide;

	[UProperty]
	[EditAnywhere]
	[DisplayName("攻击者在右方部位破损动画")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PartDamagedAMInfo:DamagedAMPathRightSide")]
	public UAnimMontage DamagedAMPathRightSide;

	private static int PartDamagedAMInfo_StructSize;

	private static int PartDamagedAMInfo_IsValid;

	private static bool DamagedAMPathForward_IsValid;

	private static int DamagedAMPathForward_Offset;

	private static bool DamagedAMPathBackward_IsValid;

	private static int DamagedAMPathBackward_Offset;

	private static bool DamagedAMPathLeftSide_IsValid;

	private static int DamagedAMPathLeftSide_Offset;

	private static bool DamagedAMPathRightSide_IsValid;

	private static int DamagedAMPathRightSide_Offset;

	public FPartDamagedAMInfo Copy()
	{
		return this;
	}

	public static FPartDamagedAMInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPartDamagedAMInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPartDamagedAMInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPartDamagedAMInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPartDamagedAMInfo(IntPtr.Add(nativeBuffer, arrayIndex * PartDamagedAMInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPartDamagedAMInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PartDamagedAMInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PartDamagedAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PartDamagedAMInfo");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, DamagedAMPathForward_Offset), DamagedAMPathForward);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, DamagedAMPathBackward_Offset), DamagedAMPathBackward);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, DamagedAMPathLeftSide_Offset), DamagedAMPathLeftSide);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, DamagedAMPathRightSide_Offset), DamagedAMPathRightSide);
	}

	public FPartDamagedAMInfo(IntPtr nativeStruct)
	{
		if (PartDamagedAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PartDamagedAMInfo");
			DamagedAMPathForward = null;
			DamagedAMPathBackward = null;
			DamagedAMPathLeftSide = null;
			DamagedAMPathRightSide = null;
		}
		else
		{
			DamagedAMPathForward = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, DamagedAMPathForward_Offset));
			DamagedAMPathBackward = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, DamagedAMPathBackward_Offset));
			DamagedAMPathLeftSide = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, DamagedAMPathLeftSide_Offset));
			DamagedAMPathRightSide = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, DamagedAMPathRightSide_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PartDamagedAMInfo");
		PartDamagedAMInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DamagedAMPathForward_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamagedAMPathForward");
		DamagedAMPathForward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamagedAMPathForward", Classes.FObjectProperty);
		DamagedAMPathBackward_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamagedAMPathBackward");
		DamagedAMPathBackward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamagedAMPathBackward", Classes.FObjectProperty);
		DamagedAMPathLeftSide_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamagedAMPathLeftSide");
		DamagedAMPathLeftSide_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamagedAMPathLeftSide", Classes.FObjectProperty);
		DamagedAMPathRightSide_Offset = NativeReflection.GetPropertyOffset(intPtr, "DamagedAMPathRightSide");
		DamagedAMPathRightSide_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DamagedAMPathRightSide", Classes.FObjectProperty);
		PartDamagedAMInfo_IsValid = ((intPtr != IntPtr.Zero && DamagedAMPathForward_IsValid && DamagedAMPathBackward_IsValid && DamagedAMPathLeftSide_IsValid && DamagedAMPathRightSide_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PartDamagedAMInfo", (byte)PartDamagedAMInfo_IsValid != 0);
	}

	static FPartDamagedAMInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPartDamagedAMInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPartDamagedAMInfo));
	}
}
