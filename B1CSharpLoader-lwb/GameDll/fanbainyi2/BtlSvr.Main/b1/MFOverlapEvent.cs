using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MFOverlapEvent")]
public struct MFOverlapEvent
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("事件类型")]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:OverlapEventType")]
	public MFOverlapEventType OverlapEventType;

	[Tooltip("1:自己, 2：队友, 4:敌人")]
	[DisplayName("对象阵营筛选")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:TargetTeamFilter")]
	public int TargetTeamFilter;

	[UProperty]
	[EditAnywhere]
	[DisplayName("对象类型筛选")]
	[Tooltip("1:角色, 2：子弹, 4:法术场")]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:TargetTypeFilter")]
	public int TargetTypeFilter;

	[DisplayName("Buff列表")]
	[UMeta(MDProp.EditCondition, "OverlapEventType == MFOverlapEventType::AddBuff || OverlapEventType == MFOverlapEventType::RemoveBuffWithTriggerRemove || OverlapEventType == MFOverlapEventType::RemoveBuffWithoutTriggerRemove")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:BuffList")]
	public List<FGSBuffInfo> BuffList;

	[DisplayName("SkillEffect列表")]
	[UMeta(MDProp.EditCondition, "OverlapEventType == MFOverlapEventType::TriggerSkillEffect")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:SkillEffectList")]
	public List<int> SkillEffectList;

	[DisplayName("备注")]
	[Tooltip("无用,仅供策划备注")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFOverlapEvent:note")]
	public string note;

	private static int MFOverlapEvent_StructSize;

	private static int MFOverlapEvent_IsValid;

	private static bool OverlapEventType_IsValid;

	private static int OverlapEventType_Offset;

	private static FFieldAddress OverlapEventType_PropertyAddress;

	private static bool TargetTeamFilter_IsValid;

	private static int TargetTeamFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool BuffList_IsValid;

	private static int BuffList_Offset;

	private static FFieldAddress BuffList_PropertyAddress;

	private static bool SkillEffectList_IsValid;

	private static int SkillEffectList_Offset;

	private static FFieldAddress SkillEffectList_PropertyAddress;

	private static bool note_IsValid;

	private static int note_Offset;

	public MFOverlapEvent Copy()
	{
		MFOverlapEvent result = this;
		if (BuffList != null)
		{
			result.BuffList = new List<FGSBuffInfo>(BuffList);
		}
		if (SkillEffectList != null)
		{
			result.SkillEffectList = new List<int>(SkillEffectList);
		}
		return result;
	}

	public static MFOverlapEvent FromNative(IntPtr nativeBuffer)
	{
		return new MFOverlapEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MFOverlapEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MFOverlapEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MFOverlapEvent(IntPtr.Add(nativeBuffer, arrayIndex * MFOverlapEvent_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MFOverlapEvent value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MFOverlapEvent_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MFOverlapEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFOverlapEvent");
			return;
		}
		EnumMarshaler<MFOverlapEventType>.ToNative(IntPtr.Add(nativeStruct, OverlapEventType_Offset), 0, OverlapEventType_PropertyAddress.Address, OverlapEventType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset), TargetTeamFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset), TargetTypeFilter);
		new TArrayCopyMarshaler<FGSBuffInfo>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffList_Offset), BuffList);
		new TArrayCopyMarshaler<int>(1, SkillEffectList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillEffectList_Offset), SkillEffectList);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, note_Offset), note);
	}

	public MFOverlapEvent(IntPtr nativeStruct)
	{
		if (MFOverlapEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFOverlapEvent");
			OverlapEventType = MFOverlapEventType.AddBuff;
			TargetTeamFilter = 0;
			TargetTypeFilter = 0;
			BuffList = null;
			SkillEffectList = null;
			note = null;
		}
		else
		{
			OverlapEventType = EnumMarshaler<MFOverlapEventType>.FromNative(IntPtr.Add(nativeStruct, OverlapEventType_Offset), 0, OverlapEventType_PropertyAddress.Address);
			TargetTeamFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset));
			TargetTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset));
			BuffList = new TArrayCopyMarshaler<FGSBuffInfo>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffList_Offset));
			SkillEffectList = new TArrayCopyMarshaler<int>(1, SkillEffectList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillEffectList_Offset));
			note = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, note_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MFOverlapEvent");
		MFOverlapEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref OverlapEventType_PropertyAddress, intPtr, "OverlapEventType");
		OverlapEventType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlapEventType");
		OverlapEventType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlapEventType", Classes.FEnumProperty);
		TargetTeamFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTeamFilter");
		TargetTeamFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTeamFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTypeFilter", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BuffList_PropertyAddress, intPtr, "BuffList");
		BuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffList");
		BuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillEffectList_PropertyAddress, intPtr, "SkillEffectList");
		SkillEffectList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectList");
		SkillEffectList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectList", Classes.FArrayProperty);
		note_Offset = NativeReflection.GetPropertyOffset(intPtr, "note");
		note_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "note", Classes.FStrProperty);
		MFOverlapEvent_IsValid = ((intPtr != IntPtr.Zero && OverlapEventType_IsValid && TargetTeamFilter_IsValid && TargetTypeFilter_IsValid && BuffList_IsValid && SkillEffectList_IsValid && note_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MFOverlapEvent", (byte)MFOverlapEvent_IsValid != 0);
	}

	static MFOverlapEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MFOverlapEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MFOverlapEvent));
	}
}
