using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BlockInfoWarp_BeAttacked")]
public struct FBlockInfoWarp_BeAttacked
{
	[Tooltip("按HitWeight区分；如果某个HitWeight为空，则会用HitWeight为-1的配置；如果既没有对应HitWeight，又没有等级为-1的配置，则不扣值。")]
	[DisplayName("普通受击格挡值削减规则(HitWeight)")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_BeAttacked:BeAttackedBlockDamageInfo")]
	public List<FBeAttackedBlockDamageInfo> BeAttackedBlockDamageInfo;

	[Tooltip("按StiffLevel区分；如果某个StiffLevel为空，则会用StiffLevel为-1的配置；如果既没有对应StiffLevel，又没有等级为-1的配置，则不扣值。")]
	[DisplayName("普通受击格挡值削减规则(StiffLevel)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BlockInfoWarp_BeAttacked:BeAttackedBlockDamageInfoByStiffLevel")]
	public List<FBeAttackedBlockDamageInfo> BeAttackedBlockDamageInfoByStiffLevel;

	private static int BlockInfoWarp_BeAttacked_StructSize;

	private static int BlockInfoWarp_BeAttacked_IsValid;

	private static bool BeAttackedBlockDamageInfo_IsValid;

	private static int BeAttackedBlockDamageInfo_Offset;

	private static FFieldAddress BeAttackedBlockDamageInfo_PropertyAddress;

	private static bool BeAttackedBlockDamageInfoByStiffLevel_IsValid;

	private static int BeAttackedBlockDamageInfoByStiffLevel_Offset;

	private static FFieldAddress BeAttackedBlockDamageInfoByStiffLevel_PropertyAddress;

	public FBlockInfoWarp_BeAttacked Copy()
	{
		FBlockInfoWarp_BeAttacked result = this;
		if (BeAttackedBlockDamageInfo != null)
		{
			result.BeAttackedBlockDamageInfo = new List<FBeAttackedBlockDamageInfo>(BeAttackedBlockDamageInfo);
		}
		if (BeAttackedBlockDamageInfoByStiffLevel != null)
		{
			result.BeAttackedBlockDamageInfoByStiffLevel = new List<FBeAttackedBlockDamageInfo>(BeAttackedBlockDamageInfoByStiffLevel);
		}
		return result;
	}

	public static FBlockInfoWarp_BeAttacked FromNative(IntPtr nativeBuffer)
	{
		return new FBlockInfoWarp_BeAttacked(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlockInfoWarp_BeAttacked value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlockInfoWarp_BeAttacked FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlockInfoWarp_BeAttacked(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_BeAttacked_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlockInfoWarp_BeAttacked value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BlockInfoWarp_BeAttacked_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_BeAttacked_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_BeAttacked");
			return;
		}
		new TArrayCopyMarshaler<FBeAttackedBlockDamageInfo>(1, BeAttackedBlockDamageInfo_PropertyAddress, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BeAttackedBlockDamageInfo_Offset), BeAttackedBlockDamageInfo);
		new TArrayCopyMarshaler<FBeAttackedBlockDamageInfo>(1, BeAttackedBlockDamageInfoByStiffLevel_PropertyAddress, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BeAttackedBlockDamageInfoByStiffLevel_Offset), BeAttackedBlockDamageInfoByStiffLevel);
	}

	public FBlockInfoWarp_BeAttacked(IntPtr nativeStruct)
	{
		if (BlockInfoWarp_BeAttacked_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BlockInfoWarp_BeAttacked");
			BeAttackedBlockDamageInfo = null;
			BeAttackedBlockDamageInfoByStiffLevel = null;
		}
		else
		{
			BeAttackedBlockDamageInfo = new TArrayCopyMarshaler<FBeAttackedBlockDamageInfo>(1, BeAttackedBlockDamageInfo_PropertyAddress, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BeAttackedBlockDamageInfo_Offset));
			BeAttackedBlockDamageInfoByStiffLevel = new TArrayCopyMarshaler<FBeAttackedBlockDamageInfo>(1, BeAttackedBlockDamageInfoByStiffLevel_PropertyAddress, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.FromNative, CachedMarshalingDelegates<FBeAttackedBlockDamageInfo, BlittableTypeMarshaler<FBeAttackedBlockDamageInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BeAttackedBlockDamageInfoByStiffLevel_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BlockInfoWarp_BeAttacked");
		BlockInfoWarp_BeAttacked_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BeAttackedBlockDamageInfo_PropertyAddress, intPtr, "BeAttackedBlockDamageInfo");
		BeAttackedBlockDamageInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedBlockDamageInfo");
		BeAttackedBlockDamageInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedBlockDamageInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BeAttackedBlockDamageInfoByStiffLevel_PropertyAddress, intPtr, "BeAttackedBlockDamageInfoByStiffLevel");
		BeAttackedBlockDamageInfoByStiffLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeAttackedBlockDamageInfoByStiffLevel");
		BeAttackedBlockDamageInfoByStiffLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeAttackedBlockDamageInfoByStiffLevel", Classes.FArrayProperty);
		BlockInfoWarp_BeAttacked_IsValid = ((intPtr != IntPtr.Zero && BeAttackedBlockDamageInfo_IsValid && BeAttackedBlockDamageInfoByStiffLevel_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BlockInfoWarp_BeAttacked", (byte)BlockInfoWarp_BeAttacked_IsValid != 0);
	}

	static FBlockInfoWarp_BeAttacked()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBlockInfoWarp_BeAttacked)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlockInfoWarp_BeAttacked));
	}
}
