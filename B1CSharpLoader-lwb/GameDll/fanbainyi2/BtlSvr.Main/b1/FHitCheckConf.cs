using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.HitCheckConf")]
public struct FHitCheckConf
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HitCheckConf:HitActionDir")]
	public EHitActionDir HitActionDir;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HitCheckConf:ResultFilterType")]
	public ESweepCheckHitFilterType ResultFilterType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HitCheckConf:IsRenderDebugShape")]
	public bool IsRenderDebugShape;

	private static int HitCheckConf_StructSize;

	private static int HitCheckConf_IsValid;

	private static bool HitActionDir_IsValid;

	private static int HitActionDir_Offset;

	private static FFieldAddress HitActionDir_PropertyAddress;

	private static bool ResultFilterType_IsValid;

	private static int ResultFilterType_Offset;

	private static FFieldAddress ResultFilterType_PropertyAddress;

	private static bool IsRenderDebugShape_IsValid;

	private static int IsRenderDebugShape_Offset;

	private static FFieldAddress IsRenderDebugShape_PropertyAddress;

	public FHitCheckConf(EHitActionDir HitActionDir, ESweepCheckHitFilterType ResultFilterType, bool IsRenderDebugShape)
	{
		this.HitActionDir = HitActionDir;
		this.ResultFilterType = ResultFilterType;
		this.IsRenderDebugShape = IsRenderDebugShape;
	}

	public FHitCheckConf Copy()
	{
		return this;
	}

	public static FHitCheckConf FromNative(IntPtr nativeBuffer)
	{
		return new FHitCheckConf(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHitCheckConf value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHitCheckConf FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHitCheckConf(IntPtr.Add(nativeBuffer, arrayIndex * HitCheckConf_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHitCheckConf value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HitCheckConf_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HitCheckConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitCheckConf");
			return;
		}
		EnumMarshaler<EHitActionDir>.ToNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address, HitActionDir);
		EnumMarshaler<ESweepCheckHitFilterType>.ToNative(IntPtr.Add(nativeStruct, ResultFilterType_Offset), 0, ResultFilterType_PropertyAddress.Address, ResultFilterType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address, IsRenderDebugShape);
	}

	public FHitCheckConf(IntPtr nativeStruct)
	{
		if (HitCheckConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitCheckConf");
			HitActionDir = EHitActionDir.Default;
			ResultFilterType = ESweepCheckHitFilterType.Zero;
			IsRenderDebugShape = false;
		}
		else
		{
			HitActionDir = EnumMarshaler<EHitActionDir>.FromNative(IntPtr.Add(nativeStruct, HitActionDir_Offset), 0, HitActionDir_PropertyAddress.Address);
			ResultFilterType = EnumMarshaler<ESweepCheckHitFilterType>.FromNative(IntPtr.Add(nativeStruct, ResultFilterType_Offset), 0, ResultFilterType_PropertyAddress.Address);
			IsRenderDebugShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRenderDebugShape_Offset), 0, IsRenderDebugShape_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HitCheckConf");
		HitCheckConf_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref HitActionDir_PropertyAddress, intPtr, "HitActionDir");
		HitActionDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitActionDir");
		HitActionDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitActionDir", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ResultFilterType_PropertyAddress, intPtr, "ResultFilterType");
		ResultFilterType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResultFilterType");
		ResultFilterType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResultFilterType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRenderDebugShape_PropertyAddress, intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRenderDebugShape");
		IsRenderDebugShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRenderDebugShape", Classes.FBoolProperty);
		HitCheckConf_IsValid = ((intPtr != IntPtr.Zero && HitActionDir_IsValid && ResultFilterType_IsValid && IsRenderDebugShape_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HitCheckConf", (byte)HitCheckConf_IsValid != 0);
	}

	static FHitCheckConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHitCheckConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHitCheckConf));
	}
}
