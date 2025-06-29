using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MFEvent")]
public struct MFEvent
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("忽略类型筛选")]
	[USharpPath("/Script/b1-Managed.MFEvent:bIgnoreTypeFilter")]
	public bool bIgnoreTypeFilter;

	[Tooltip("1:自己, 2：队友, 4:敌人")]
	[DisplayName("对象阵营筛选")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MFEvent:TargetTeamFilter")]
	public int TargetTeamFilter;

	[DisplayName("对象类型筛选")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("1:角色, 2：子弹, 4:法术场")]
	[USharpPath("/Script/b1-Managed.MFEvent:TargetTypeFilter")]
	public int TargetTypeFilter;

	[EditAnywhere]
	[UProperty]
	[DisplayName("效果列表")]
	[USharpPath("/Script/b1-Managed.MFEvent:MFEffectList")]
	public List<MFEffect> MFEffectList;

	[EditAnywhere]
	[Tooltip("无用,仅供策划备注")]
	[UProperty]
	[DisplayName("备注")]
	[USharpPath("/Script/b1-Managed.MFEvent:DisplayNote")]
	public string DisplayNote;

	private static int MFEvent_StructSize;

	private static int MFEvent_IsValid;

	private static bool bIgnoreTypeFilter_IsValid;

	private static int bIgnoreTypeFilter_Offset;

	private static FFieldAddress bIgnoreTypeFilter_PropertyAddress;

	private static bool TargetTeamFilter_IsValid;

	private static int TargetTeamFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool MFEffectList_IsValid;

	private static int MFEffectList_Offset;

	private static FFieldAddress MFEffectList_PropertyAddress;

	private static bool DisplayNote_IsValid;

	private static int DisplayNote_Offset;

	public MFEvent Copy()
	{
		MFEvent result = this;
		if (MFEffectList != null)
		{
			result.MFEffectList = new List<MFEffect>(MFEffectList);
		}
		return result;
	}

	public static MFEvent FromNative(IntPtr nativeBuffer)
	{
		return new MFEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MFEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MFEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MFEvent(IntPtr.Add(nativeBuffer, arrayIndex * MFEvent_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MFEvent value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MFEvent_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MFEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFEvent");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address, bIgnoreTypeFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset), TargetTeamFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset), TargetTypeFilter);
		new TArrayCopyMarshaler<MFEffect>(1, MFEffectList_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).ToNative(IntPtr.Add(nativeStruct, MFEffectList_Offset), MFEffectList);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayNote_Offset), DisplayNote);
	}

	public MFEvent(IntPtr nativeStruct)
	{
		if (MFEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFEvent");
			bIgnoreTypeFilter = false;
			TargetTeamFilter = 0;
			TargetTypeFilter = 0;
			MFEffectList = null;
			DisplayNote = null;
		}
		else
		{
			bIgnoreTypeFilter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address);
			TargetTeamFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset));
			TargetTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset));
			MFEffectList = new TArrayCopyMarshaler<MFEffect>(1, MFEffectList_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).FromNative(IntPtr.Add(nativeStruct, MFEffectList_Offset));
			DisplayNote = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayNote_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MFEvent");
		MFEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bIgnoreTypeFilter_PropertyAddress, intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIgnoreTypeFilter", Classes.FBoolProperty);
		TargetTeamFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTeamFilter");
		TargetTeamFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTeamFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTypeFilter", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref MFEffectList_PropertyAddress, intPtr, "MFEffectList");
		MFEffectList_Offset = NativeReflection.GetPropertyOffset(intPtr, "MFEffectList");
		MFEffectList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MFEffectList", Classes.FArrayProperty);
		DisplayNote_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayNote");
		DisplayNote_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayNote", Classes.FStrProperty);
		MFEvent_IsValid = ((intPtr != IntPtr.Zero && bIgnoreTypeFilter_IsValid && TargetTeamFilter_IsValid && TargetTypeFilter_IsValid && MFEffectList_IsValid && DisplayNote_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MFEvent", (byte)MFEvent_IsValid != 0);
	}

	static MFEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MFEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MFEvent));
	}
}
