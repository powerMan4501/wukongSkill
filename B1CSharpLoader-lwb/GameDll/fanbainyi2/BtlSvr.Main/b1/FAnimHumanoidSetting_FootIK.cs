using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FootIK")]
public struct FAnimHumanoidSetting_FootIK
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FootIK:bEnableIK")]
	public bool bEnableIK;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FootIK:bEnableForefootIK")]
	public bool bEnableForefootIK;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FootIK:bEnableQuadrupedIK")]
	public bool bEnableQuadrupedIK;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FootIK:bFootUseFBIK")]
	public bool bFootUseFBIK;

	private static int AnimHumanoidSetting_FootIK_StructSize;

	private static int AnimHumanoidSetting_FootIK_IsValid;

	private static bool bEnableIK_IsValid;

	private static int bEnableIK_Offset;

	private static FFieldAddress bEnableIK_PropertyAddress;

	private static bool bEnableForefootIK_IsValid;

	private static int bEnableForefootIK_Offset;

	private static FFieldAddress bEnableForefootIK_PropertyAddress;

	private static bool bEnableQuadrupedIK_IsValid;

	private static int bEnableQuadrupedIK_Offset;

	private static FFieldAddress bEnableQuadrupedIK_PropertyAddress;

	private static bool bFootUseFBIK_IsValid;

	private static int bFootUseFBIK_Offset;

	private static FFieldAddress bFootUseFBIK_PropertyAddress;

	public FAnimHumanoidSetting_FootIK Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_FootIK FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_FootIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_FootIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_FootIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_FootIK(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_FootIK_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_FootIK value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_FootIK_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_FootIK_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_FootIK");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address, bEnableIK);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address, bEnableForefootIK);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableQuadrupedIK_Offset), 0, bEnableQuadrupedIK_PropertyAddress.Address, bEnableQuadrupedIK);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFootUseFBIK_Offset), 0, bFootUseFBIK_PropertyAddress.Address, bFootUseFBIK);
	}

	public FAnimHumanoidSetting_FootIK(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_FootIK_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_FootIK");
			bEnableIK = false;
			bEnableForefootIK = false;
			bEnableQuadrupedIK = false;
			bFootUseFBIK = false;
		}
		else
		{
			bEnableIK = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address);
			bEnableForefootIK = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address);
			bEnableQuadrupedIK = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableQuadrupedIK_Offset), 0, bEnableQuadrupedIK_PropertyAddress.Address);
			bFootUseFBIK = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFootUseFBIK_Offset), 0, bFootUseFBIK_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_FootIK");
		AnimHumanoidSetting_FootIK_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bEnableIK_PropertyAddress, intPtr, "bEnableIK");
		bEnableIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableIK");
		bEnableIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableForefootIK_PropertyAddress, intPtr, "bEnableForefootIK");
		bEnableForefootIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableForefootIK");
		bEnableForefootIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableForefootIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableQuadrupedIK_PropertyAddress, intPtr, "bEnableQuadrupedIK");
		bEnableQuadrupedIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableQuadrupedIK");
		bEnableQuadrupedIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableQuadrupedIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFootUseFBIK_PropertyAddress, intPtr, "bFootUseFBIK");
		bFootUseFBIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFootUseFBIK");
		bFootUseFBIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFootUseFBIK", Classes.FBoolProperty);
		AnimHumanoidSetting_FootIK_IsValid = ((intPtr != IntPtr.Zero && bEnableIK_IsValid && bEnableForefootIK_IsValid && bEnableQuadrupedIK_IsValid && bFootUseFBIK_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_FootIK", (byte)AnimHumanoidSetting_FootIK_IsValid != 0);
	}

	static FAnimHumanoidSetting_FootIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_FootIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_FootIK));
	}
}
