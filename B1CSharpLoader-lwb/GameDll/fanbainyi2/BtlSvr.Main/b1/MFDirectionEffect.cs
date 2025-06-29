using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MFDirectionEffect")]
public struct MFDirectionEffect
{
	[EditAnywhere]
	[DisplayName("效果触发时机")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:TriggerEvent")]
	public EMagicFieldEffectTriggerEvent TriggerEvent;

	[UProperty]
	[EditAnywhere]
	[DisplayName("忽略类型筛选")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:bIgnoreTypeFilter")]
	public bool bIgnoreTypeFilter;

	[UProperty]
	[DisplayName("对象阵营筛选")]
	[Tooltip("1:自己, 2：队友, 4:敌人")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:TargetTeamFilter")]
	public int TargetTeamFilter;

	[UProperty]
	[EditAnywhere]
	[Tooltip("1:角色, 2：子弹, 4:法术场")]
	[DisplayName("对象类型筛选")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:TargetTypeFilter")]
	public int TargetTypeFilter;

	[EditAnywhere]
	[Category("Magic Field Direction Config")]
	[DisplayName("目标受影响方向类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:EffectDirectionType")]
	public EMagicFieldEffectDirectionType EffectDirectionType;

	[Tooltip("正前方为中心的对称夹角")]
	[DisplayName("前方受影响角度")]
	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:ForwardAngle")]
	public float ForwardAngle;

	[UProperty]
	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[DisplayName("后方受影响角度")]
	[Tooltip("正后方为中心的对称夹角")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:BackwardAngle")]
	public float BackwardAngle;

	[Tooltip("正左侧为中心的对称夹角")]
	[DisplayName("左侧受影响角度")]
	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:LeftSideAngle")]
	public float LeftSideAngle;

	[DisplayName("右侧受影响角度")]
	[EditAnywhere]
	[Category("Magic Field Direction Config")]
	[Tooltip("正右侧为中心的对称夹角")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:RightSideAngle")]
	public float RightSideAngle;

	[UProperty]
	[EditAnywhere]
	[DisplayName("前方效果列表")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:ForwardEffects")]
	public List<MFEffect> ForwardEffects;

	[UProperty]
	[EditAnywhere]
	[DisplayName("后方效果列表")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:BackwardEffects")]
	public List<MFEffect> BackwardEffects;

	[DisplayName("左侧效果列表")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:LeftSideEffects")]
	public List<MFEffect> LeftSideEffects;

	[UProperty]
	[EditAnywhere]
	[DisplayName("右侧效果列表")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:RightSideEffects")]
	public List<MFEffect> RightSideEffects;

	[UProperty]
	[EditAnywhere]
	[DisplayName("备注")]
	[Tooltip("无用,仅供策划备注")]
	[USharpPath("/Script/b1-Managed.MFDirectionEffect:DisplayNote")]
	public string DisplayNote;

	private static int MFDirectionEffect_StructSize;

	private static int MFDirectionEffect_IsValid;

	private static bool TriggerEvent_IsValid;

	private static int TriggerEvent_Offset;

	private static FFieldAddress TriggerEvent_PropertyAddress;

	private static bool bIgnoreTypeFilter_IsValid;

	private static int bIgnoreTypeFilter_Offset;

	private static FFieldAddress bIgnoreTypeFilter_PropertyAddress;

	private static bool TargetTeamFilter_IsValid;

	private static int TargetTeamFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool EffectDirectionType_IsValid;

	private static int EffectDirectionType_Offset;

	private static FFieldAddress EffectDirectionType_PropertyAddress;

	private static bool ForwardAngle_IsValid;

	private static int ForwardAngle_Offset;

	private static bool BackwardAngle_IsValid;

	private static int BackwardAngle_Offset;

	private static bool LeftSideAngle_IsValid;

	private static int LeftSideAngle_Offset;

	private static bool RightSideAngle_IsValid;

	private static int RightSideAngle_Offset;

	private static bool ForwardEffects_IsValid;

	private static int ForwardEffects_Offset;

	private static FFieldAddress ForwardEffects_PropertyAddress;

	private static bool BackwardEffects_IsValid;

	private static int BackwardEffects_Offset;

	private static FFieldAddress BackwardEffects_PropertyAddress;

	private static bool LeftSideEffects_IsValid;

	private static int LeftSideEffects_Offset;

	private static FFieldAddress LeftSideEffects_PropertyAddress;

	private static bool RightSideEffects_IsValid;

	private static int RightSideEffects_Offset;

	private static FFieldAddress RightSideEffects_PropertyAddress;

	private static bool DisplayNote_IsValid;

	private static int DisplayNote_Offset;

	public MFDirectionEffect Copy()
	{
		MFDirectionEffect result = this;
		if (ForwardEffects != null)
		{
			result.ForwardEffects = new List<MFEffect>(ForwardEffects);
		}
		if (BackwardEffects != null)
		{
			result.BackwardEffects = new List<MFEffect>(BackwardEffects);
		}
		if (LeftSideEffects != null)
		{
			result.LeftSideEffects = new List<MFEffect>(LeftSideEffects);
		}
		if (RightSideEffects != null)
		{
			result.RightSideEffects = new List<MFEffect>(RightSideEffects);
		}
		return result;
	}

	public static MFDirectionEffect FromNative(IntPtr nativeBuffer)
	{
		return new MFDirectionEffect(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MFDirectionEffect value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MFDirectionEffect FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MFDirectionEffect(IntPtr.Add(nativeBuffer, arrayIndex * MFDirectionEffect_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MFDirectionEffect value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MFDirectionEffect_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MFDirectionEffect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFDirectionEffect");
			return;
		}
		EnumMarshaler<EMagicFieldEffectTriggerEvent>.ToNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address, TriggerEvent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address, bIgnoreTypeFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset), TargetTeamFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset), TargetTypeFilter);
		EnumMarshaler<EMagicFieldEffectDirectionType>.ToNative(IntPtr.Add(nativeStruct, EffectDirectionType_Offset), 0, EffectDirectionType_PropertyAddress.Address, EffectDirectionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ForwardAngle_Offset), ForwardAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BackwardAngle_Offset), BackwardAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeftSideAngle_Offset), LeftSideAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RightSideAngle_Offset), RightSideAngle);
		new TArrayCopyMarshaler<MFEffect>(1, ForwardEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).ToNative(IntPtr.Add(nativeStruct, ForwardEffects_Offset), ForwardEffects);
		new TArrayCopyMarshaler<MFEffect>(1, BackwardEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).ToNative(IntPtr.Add(nativeStruct, BackwardEffects_Offset), BackwardEffects);
		new TArrayCopyMarshaler<MFEffect>(1, LeftSideEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).ToNative(IntPtr.Add(nativeStruct, LeftSideEffects_Offset), LeftSideEffects);
		new TArrayCopyMarshaler<MFEffect>(1, RightSideEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).ToNative(IntPtr.Add(nativeStruct, RightSideEffects_Offset), RightSideEffects);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayNote_Offset), DisplayNote);
	}

	public MFDirectionEffect(IntPtr nativeStruct)
	{
		if (MFDirectionEffect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFDirectionEffect");
			TriggerEvent = EMagicFieldEffectTriggerEvent.OnBorn;
			bIgnoreTypeFilter = false;
			TargetTeamFilter = 0;
			TargetTypeFilter = 0;
			EffectDirectionType = EMagicFieldEffectDirectionType.FrontBack;
			ForwardAngle = 0f;
			BackwardAngle = 0f;
			LeftSideAngle = 0f;
			RightSideAngle = 0f;
			ForwardEffects = null;
			BackwardEffects = null;
			LeftSideEffects = null;
			RightSideEffects = null;
			DisplayNote = null;
		}
		else
		{
			TriggerEvent = EnumMarshaler<EMagicFieldEffectTriggerEvent>.FromNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address);
			bIgnoreTypeFilter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address);
			TargetTeamFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset));
			TargetTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset));
			EffectDirectionType = EnumMarshaler<EMagicFieldEffectDirectionType>.FromNative(IntPtr.Add(nativeStruct, EffectDirectionType_Offset), 0, EffectDirectionType_PropertyAddress.Address);
			ForwardAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ForwardAngle_Offset));
			BackwardAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BackwardAngle_Offset));
			LeftSideAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeftSideAngle_Offset));
			RightSideAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RightSideAngle_Offset));
			ForwardEffects = new TArrayCopyMarshaler<MFEffect>(1, ForwardEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).FromNative(IntPtr.Add(nativeStruct, ForwardEffects_Offset));
			BackwardEffects = new TArrayCopyMarshaler<MFEffect>(1, BackwardEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).FromNative(IntPtr.Add(nativeStruct, BackwardEffects_Offset));
			LeftSideEffects = new TArrayCopyMarshaler<MFEffect>(1, LeftSideEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).FromNative(IntPtr.Add(nativeStruct, LeftSideEffects_Offset));
			RightSideEffects = new TArrayCopyMarshaler<MFEffect>(1, RightSideEffects_PropertyAddress, CachedMarshalingDelegates<MFEffect, MFEffect>.FromNative, CachedMarshalingDelegates<MFEffect, MFEffect>.ToNative).FromNative(IntPtr.Add(nativeStruct, RightSideEffects_Offset));
			DisplayNote = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayNote_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MFDirectionEffect");
		MFDirectionEffect_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TriggerEvent_PropertyAddress, intPtr, "TriggerEvent");
		TriggerEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEvent");
		TriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEvent", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bIgnoreTypeFilter_PropertyAddress, intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIgnoreTypeFilter", Classes.FBoolProperty);
		TargetTeamFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTeamFilter");
		TargetTeamFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTeamFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTypeFilter", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EffectDirectionType_PropertyAddress, intPtr, "EffectDirectionType");
		EffectDirectionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectDirectionType");
		EffectDirectionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectDirectionType", Classes.FEnumProperty);
		ForwardAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardAngle");
		ForwardAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardAngle", Classes.FFloatProperty);
		BackwardAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackwardAngle");
		BackwardAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackwardAngle", Classes.FFloatProperty);
		LeftSideAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSideAngle");
		LeftSideAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSideAngle", Classes.FFloatProperty);
		RightSideAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSideAngle");
		RightSideAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSideAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ForwardEffects_PropertyAddress, intPtr, "ForwardEffects");
		ForwardEffects_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardEffects");
		ForwardEffects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardEffects", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BackwardEffects_PropertyAddress, intPtr, "BackwardEffects");
		BackwardEffects_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackwardEffects");
		BackwardEffects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackwardEffects", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LeftSideEffects_PropertyAddress, intPtr, "LeftSideEffects");
		LeftSideEffects_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSideEffects");
		LeftSideEffects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSideEffects", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RightSideEffects_PropertyAddress, intPtr, "RightSideEffects");
		RightSideEffects_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSideEffects");
		RightSideEffects_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSideEffects", Classes.FArrayProperty);
		DisplayNote_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayNote");
		DisplayNote_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayNote", Classes.FStrProperty);
		MFDirectionEffect_IsValid = ((intPtr != IntPtr.Zero && TriggerEvent_IsValid && bIgnoreTypeFilter_IsValid && TargetTeamFilter_IsValid && TargetTypeFilter_IsValid && EffectDirectionType_IsValid && ForwardAngle_IsValid && BackwardAngle_IsValid && LeftSideAngle_IsValid && RightSideAngle_IsValid && ForwardEffects_IsValid && BackwardEffects_IsValid && LeftSideEffects_IsValid && RightSideEffects_IsValid && DisplayNote_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MFDirectionEffect", (byte)MFDirectionEffect_IsValid != 0);
	}

	static MFDirectionEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MFDirectionEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MFDirectionEffect));
	}
}
