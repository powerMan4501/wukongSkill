using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MFEffect")]
public struct MFEffect
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("事件类型")]
	[USharpPath("/Script/b1-Managed.MFEffect:OverlapEventType")]
	public MFOverlapEventType OverlapEventType;

	[UProperty]
	[DisplayName("Buff列表")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MFEffect:BuffList")]
	public List<FGSBuffInfo> BuffList;

	[UProperty]
	[EditAnywhere]
	[DisplayName("SkillEffect列表")]
	[USharpPath("/Script/b1-Managed.MFEffect:SkillEffectList")]
	public List<int> SkillEffectList;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDEnum.BitmaskEnum, "ProjectileSpecificFlags")]
	[UMeta(MDEnum.Bitmask)]
	[USharpPath("/Script/b1-Managed.MFEffect:SpecificFlags")]
	public int SpecificFlags;

	[Tooltip("无用,仅供策划备注")]
	[DisplayName("备注")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MFEffect:DisplayNote")]
	public string DisplayNote;

	private static int MFEffect_StructSize;

	private static int MFEffect_IsValid;

	private static bool OverlapEventType_IsValid;

	private static int OverlapEventType_Offset;

	private static FFieldAddress OverlapEventType_PropertyAddress;

	private static bool BuffList_IsValid;

	private static int BuffList_Offset;

	private static FFieldAddress BuffList_PropertyAddress;

	private static bool SkillEffectList_IsValid;

	private static int SkillEffectList_Offset;

	private static FFieldAddress SkillEffectList_PropertyAddress;

	private static bool SpecificFlags_IsValid;

	private static int SpecificFlags_Offset;

	private static bool DisplayNote_IsValid;

	private static int DisplayNote_Offset;

	public MFEffect Copy()
	{
		MFEffect result = this;
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

	public static MFEffect FromNative(IntPtr nativeBuffer)
	{
		return new MFEffect(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MFEffect value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MFEffect FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MFEffect(IntPtr.Add(nativeBuffer, arrayIndex * MFEffect_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MFEffect value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MFEffect_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MFEffect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFEffect");
			return;
		}
		EnumMarshaler<MFOverlapEventType>.ToNative(IntPtr.Add(nativeStruct, OverlapEventType_Offset), 0, OverlapEventType_PropertyAddress.Address, OverlapEventType);
		new TArrayCopyMarshaler<FGSBuffInfo>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffList_Offset), BuffList);
		new TArrayCopyMarshaler<int>(1, SkillEffectList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillEffectList_Offset), SkillEffectList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpecificFlags_Offset), SpecificFlags);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayNote_Offset), DisplayNote);
	}

	public MFEffect(IntPtr nativeStruct)
	{
		if (MFEffect_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MFEffect");
			OverlapEventType = MFOverlapEventType.AddBuff;
			BuffList = null;
			SkillEffectList = null;
			SpecificFlags = 0;
			DisplayNote = null;
		}
		else
		{
			OverlapEventType = EnumMarshaler<MFOverlapEventType>.FromNative(IntPtr.Add(nativeStruct, OverlapEventType_Offset), 0, OverlapEventType_PropertyAddress.Address);
			BuffList = new TArrayCopyMarshaler<FGSBuffInfo>(1, BuffList_PropertyAddress, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.FromNative, CachedMarshalingDelegates<FGSBuffInfo, BlittableTypeMarshaler<FGSBuffInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffList_Offset));
			SkillEffectList = new TArrayCopyMarshaler<int>(1, SkillEffectList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillEffectList_Offset));
			SpecificFlags = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpecificFlags_Offset));
			DisplayNote = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayNote_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MFEffect");
		MFEffect_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref OverlapEventType_PropertyAddress, intPtr, "OverlapEventType");
		OverlapEventType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlapEventType");
		OverlapEventType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlapEventType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BuffList_PropertyAddress, intPtr, "BuffList");
		BuffList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffList");
		BuffList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillEffectList_PropertyAddress, intPtr, "SkillEffectList");
		SkillEffectList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectList");
		SkillEffectList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectList", Classes.FArrayProperty);
		SpecificFlags_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecificFlags");
		SpecificFlags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecificFlags", Classes.FIntProperty);
		DisplayNote_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisplayNote");
		DisplayNote_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisplayNote", Classes.FStrProperty);
		MFEffect_IsValid = ((intPtr != IntPtr.Zero && OverlapEventType_IsValid && BuffList_IsValid && SkillEffectList_IsValid && SpecificFlags_IsValid && DisplayNote_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MFEffect", (byte)MFEffect_IsValid != 0);
	}

	static MFEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MFEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MFEffect));
	}
}
