using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSLeisureConfig")]
public struct FGSLeisureConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSLeisureConfig:LeisureAnim")]
	public UAnimMontage LeisureAnim;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("GUID同步组Leisure动画")]
	[USharpPath("/Script/b1-Managed.FGSLeisureConfig:bGroupSyncLeisure")]
	public bool bGroupSyncLeisure;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSLeisureConfig:bRandomStartTime")]
	public bool bRandomStartTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSLeisureConfig:RandomConfig")]
	public List<FGSLeisureRandomConfig> RandomConfig;

	private static int FGSLeisureConfig_StructSize;

	private static int FGSLeisureConfig_IsValid;

	private static bool LeisureAnim_IsValid;

	private static int LeisureAnim_Offset;

	private static bool bGroupSyncLeisure_IsValid;

	private static int bGroupSyncLeisure_Offset;

	private static FFieldAddress bGroupSyncLeisure_PropertyAddress;

	private static bool bRandomStartTime_IsValid;

	private static int bRandomStartTime_Offset;

	private static FFieldAddress bRandomStartTime_PropertyAddress;

	private static bool RandomConfig_IsValid;

	private static int RandomConfig_Offset;

	private static FFieldAddress RandomConfig_PropertyAddress;

	public FGSLeisureConfig Copy()
	{
		FGSLeisureConfig result = this;
		if (RandomConfig != null)
		{
			result.RandomConfig = new List<FGSLeisureRandomConfig>(RandomConfig);
		}
		return result;
	}

	public static FGSLeisureConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSLeisureConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSLeisureConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSLeisureConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSLeisureConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSLeisureConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSLeisureConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSLeisureConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureConfig");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, LeisureAnim_Offset), LeisureAnim);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bGroupSyncLeisure_Offset), 0, bGroupSyncLeisure_PropertyAddress.Address, bGroupSyncLeisure);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bRandomStartTime_Offset), 0, bRandomStartTime_PropertyAddress.Address, bRandomStartTime);
		new TArrayCopyMarshaler<FGSLeisureRandomConfig>(1, RandomConfig_PropertyAddress, CachedMarshalingDelegates<FGSLeisureRandomConfig, FGSLeisureRandomConfig>.FromNative, CachedMarshalingDelegates<FGSLeisureRandomConfig, FGSLeisureRandomConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, RandomConfig_Offset), RandomConfig);
	}

	public FGSLeisureConfig(IntPtr nativeStruct)
	{
		if (FGSLeisureConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSLeisureConfig");
			LeisureAnim = null;
			bGroupSyncLeisure = false;
			bRandomStartTime = false;
			RandomConfig = null;
		}
		else
		{
			LeisureAnim = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, LeisureAnim_Offset));
			bGroupSyncLeisure = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bGroupSyncLeisure_Offset), 0, bGroupSyncLeisure_PropertyAddress.Address);
			bRandomStartTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bRandomStartTime_Offset), 0, bRandomStartTime_PropertyAddress.Address);
			RandomConfig = new TArrayCopyMarshaler<FGSLeisureRandomConfig>(1, RandomConfig_PropertyAddress, CachedMarshalingDelegates<FGSLeisureRandomConfig, FGSLeisureRandomConfig>.FromNative, CachedMarshalingDelegates<FGSLeisureRandomConfig, FGSLeisureRandomConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, RandomConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSLeisureConfig");
		FGSLeisureConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		LeisureAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeisureAnim");
		LeisureAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeisureAnim", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bGroupSyncLeisure_PropertyAddress, intPtr, "bGroupSyncLeisure");
		bGroupSyncLeisure_Offset = NativeReflection.GetPropertyOffset(intPtr, "bGroupSyncLeisure");
		bGroupSyncLeisure_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bGroupSyncLeisure", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRandomStartTime_PropertyAddress, intPtr, "bRandomStartTime");
		bRandomStartTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRandomStartTime");
		bRandomStartTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRandomStartTime", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RandomConfig_PropertyAddress, intPtr, "RandomConfig");
		RandomConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomConfig");
		RandomConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomConfig", Classes.FArrayProperty);
		FGSLeisureConfig_IsValid = ((intPtr != IntPtr.Zero && LeisureAnim_IsValid && bGroupSyncLeisure_IsValid && bRandomStartTime_IsValid && RandomConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSLeisureConfig", (byte)FGSLeisureConfig_IsValid != 0);
	}

	static FGSLeisureConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSLeisureConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSLeisureConfig));
	}
}
