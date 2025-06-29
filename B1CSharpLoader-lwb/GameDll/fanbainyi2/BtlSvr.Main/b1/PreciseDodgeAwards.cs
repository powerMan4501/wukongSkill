using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.PreciseDodgeAwards")]
public struct PreciseDodgeAwards
{
	[DisplayName("添加Buff列表")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PreciseDodgeAwards:AddBuffIds")]
	public List<FGSBuffInfo> AddBuffIds;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移除Buff列表")]
	[USharpPath("/Script/b1-Managed.PreciseDodgeAwards:RemoveBuffIds")]
	public List<int> RemoveBuffIds;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发的SkillEffect列表")]
	[USharpPath("/Script/b1-Managed.PreciseDodgeAwards:SkillEffectIds")]
	public List<int> SkillEffectIds;

	[DisplayName("最大可奖励次数")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PreciseDodgeAwards:MaxAwardCount")]
	public int MaxAwardCount;

	private static int PreciseDodgeAwards_StructSize;

	private static int PreciseDodgeAwards_IsValid;

	private static bool AddBuffIds_IsValid;

	private static int AddBuffIds_Offset;

	private static FFieldAddress AddBuffIds_PropertyAddress;

	private static bool RemoveBuffIds_IsValid;

	private static int RemoveBuffIds_Offset;

	private static FFieldAddress RemoveBuffIds_PropertyAddress;

	private static bool SkillEffectIds_IsValid;

	private static int SkillEffectIds_Offset;

	private static FFieldAddress SkillEffectIds_PropertyAddress;

	private static bool MaxAwardCount_IsValid;

	private static int MaxAwardCount_Offset;

	public PreciseDodgeAwards Copy()
	{
		PreciseDodgeAwards result = this;
		if (AddBuffIds != null)
		{
			result.AddBuffIds = new List<FGSBuffInfo>(AddBuffIds);
		}
		if (RemoveBuffIds != null)
		{
			result.RemoveBuffIds = new List<int>(RemoveBuffIds);
		}
		if (SkillEffectIds != null)
		{
			result.SkillEffectIds = new List<int>(SkillEffectIds);
		}
		return result;
	}

	public static PreciseDodgeAwards FromNative(IntPtr nativeBuffer)
	{
		return new PreciseDodgeAwards(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, PreciseDodgeAwards value)
	{
		value.ToNative(nativeBuffer);
	}

	public static PreciseDodgeAwards FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new PreciseDodgeAwards(IntPtr.Add(nativeBuffer, arrayIndex * PreciseDodgeAwards_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, PreciseDodgeAwards value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PreciseDodgeAwards_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PreciseDodgeAwards_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PreciseDodgeAwards");
			return;
		}
		new TArrayCopyMarshaler<FGSBuffInfo>(1, AddBuffIds_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AddBuffIds_Offset), AddBuffIds);
		new TArrayCopyMarshaler<int>(1, RemoveBuffIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemoveBuffIds_Offset), RemoveBuffIds);
		new TArrayCopyMarshaler<int>(1, SkillEffectIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillEffectIds_Offset), SkillEffectIds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxAwardCount_Offset), MaxAwardCount);
	}

	public PreciseDodgeAwards(IntPtr nativeStruct)
	{
		if (PreciseDodgeAwards_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PreciseDodgeAwards");
			AddBuffIds = null;
			RemoveBuffIds = null;
			SkillEffectIds = null;
			MaxAwardCount = 0;
		}
		else
		{
			AddBuffIds = new TArrayCopyMarshaler<FGSBuffInfo>(1, AddBuffIds_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AddBuffIds_Offset));
			RemoveBuffIds = new TArrayCopyMarshaler<int>(1, RemoveBuffIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemoveBuffIds_Offset));
			SkillEffectIds = new TArrayCopyMarshaler<int>(1, SkillEffectIds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillEffectIds_Offset));
			MaxAwardCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxAwardCount_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PreciseDodgeAwards");
		PreciseDodgeAwards_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AddBuffIds_PropertyAddress, intPtr, "AddBuffIds");
		AddBuffIds_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddBuffIds");
		AddBuffIds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddBuffIds", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RemoveBuffIds_PropertyAddress, intPtr, "RemoveBuffIds");
		RemoveBuffIds_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveBuffIds");
		RemoveBuffIds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveBuffIds", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillEffectIds_PropertyAddress, intPtr, "SkillEffectIds");
		SkillEffectIds_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectIds");
		SkillEffectIds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectIds", Classes.FArrayProperty);
		MaxAwardCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxAwardCount");
		MaxAwardCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxAwardCount", Classes.FIntProperty);
		PreciseDodgeAwards_IsValid = ((intPtr != IntPtr.Zero && AddBuffIds_IsValid && RemoveBuffIds_IsValid && SkillEffectIds_IsValid && MaxAwardCount_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PreciseDodgeAwards", (byte)PreciseDodgeAwards_IsValid != 0);
	}

	static PreciseDodgeAwards()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PreciseDodgeAwards)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PreciseDodgeAwards));
	}
}
