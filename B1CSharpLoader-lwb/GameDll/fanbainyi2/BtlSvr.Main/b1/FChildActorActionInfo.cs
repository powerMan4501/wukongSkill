using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ChildActorActionInfo")]
public struct FChildActorActionInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("行为")]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:ActionType")]
	public EChildActorActionType ActionType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("技能ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:SkillId")]
	public int SkillId;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否需要检测能否释放")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:NeedCheckSkillCanCast")]
	public bool NeedCheckSkillCanCast;

	[UMeta(MDFunc.AdvancedDisplay)]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("播放起始位置")]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:MontageStartSectionName")]
	public FName MontageStartSectionName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:BuffId")]
	public int BuffId;

	[UMeta(MDProp.ClampMin, "1")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:BuffLayer")]
	public int BuffLayer;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Buff持续时间(毫秒)")]
	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:BuffDuration")]
	public int BuffDuration;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否触发移除效果")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ChildActorActionInfo:TriggerRemoveEffect")]
	public bool TriggerRemoveEffect;

	private static int ChildActorActionInfo_StructSize;

	private static int ChildActorActionInfo_IsValid;

	private static bool ActionType_IsValid;

	private static int ActionType_Offset;

	private static FFieldAddress ActionType_PropertyAddress;

	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool NeedCheckSkillCanCast_IsValid;

	private static int NeedCheckSkillCanCast_Offset;

	private static FFieldAddress NeedCheckSkillCanCast_PropertyAddress;

	private static bool MontageStartSectionName_IsValid;

	private static int MontageStartSectionName_Offset;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

	private static bool TriggerRemoveEffect_IsValid;

	private static int TriggerRemoveEffect_Offset;

	private static FFieldAddress TriggerRemoveEffect_PropertyAddress;

	public static void RegisterCustomizeChildren()
	{
		RegisterPropertyTypeCustomizationDetails(EChildActorActionType.CastSkill, new List<string> { "SkillId", "NeedCheckSkillCanCast", "MontageStartSectionName" });
		RegisterPropertyTypeCustomizationDetails(EChildActorActionType.AddBuff, new List<string> { "BuffId", "BuffLayer", "BuffDuration" });
		RegisterPropertyTypeCustomizationDetails(EChildActorActionType.RemoveBuff, new List<string> { "BuffId", "BuffLayer", "TriggerRemoveEffect" });
		RegisterPropertyTypeCustomizationDetails(EChildActorActionType.SpawnSocketAttachTamer, new List<string>());
	}

	private static void RegisterPropertyTypeCustomizationDetails(EChildActorActionType Type, List<string> Objects)
	{
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FChildActorActionInfo", (int)Type, Objects.Select((string item) => new FName(item)).ToList());
	}

	public FChildActorActionInfo Copy()
	{
		return this;
	}

	public static FChildActorActionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FChildActorActionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChildActorActionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChildActorActionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChildActorActionInfo(IntPtr.Add(nativeBuffer, arrayIndex * ChildActorActionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChildActorActionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ChildActorActionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ChildActorActionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChildActorActionInfo");
			return;
		}
		EnumMarshaler<EChildActorActionType>.ToNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address, ActionType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillId_Offset), SkillId);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address, NeedCheckSkillCanCast);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset), MontageStartSectionName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffId_Offset), BuffId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffLayer_Offset), BuffLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffDuration_Offset), BuffDuration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TriggerRemoveEffect_Offset), 0, TriggerRemoveEffect_PropertyAddress.Address, TriggerRemoveEffect);
	}

	public FChildActorActionInfo(IntPtr nativeStruct)
	{
		if (ChildActorActionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ChildActorActionInfo");
			ActionType = EChildActorActionType.CastSkill;
			SkillId = 0;
			NeedCheckSkillCanCast = false;
			MontageStartSectionName = default(FName);
			BuffId = 0;
			BuffLayer = 0;
			BuffDuration = 0;
			TriggerRemoveEffect = false;
		}
		else
		{
			ActionType = EnumMarshaler<EChildActorActionType>.FromNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address);
			SkillId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillId_Offset));
			NeedCheckSkillCanCast = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address);
			MontageStartSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset));
			BuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffId_Offset));
			BuffLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffLayer_Offset));
			BuffDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffDuration_Offset));
			TriggerRemoveEffect = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TriggerRemoveEffect_Offset), 0, TriggerRemoveEffect_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ChildActorActionInfo");
		ChildActorActionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ActionType_PropertyAddress, intPtr, "ActionType");
		ActionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionType");
		ActionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionType", Classes.FEnumProperty);
		SkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedCheckSkillCanCast_PropertyAddress, intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedCheckSkillCanCast", Classes.FBoolProperty);
		MontageStartSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontageStartSectionName");
		MontageStartSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontageStartSectionName", Classes.FNameProperty);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffDuration", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TriggerRemoveEffect_PropertyAddress, intPtr, "TriggerRemoveEffect");
		TriggerRemoveEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerRemoveEffect");
		TriggerRemoveEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerRemoveEffect", Classes.FBoolProperty);
		ChildActorActionInfo_IsValid = ((intPtr != IntPtr.Zero && ActionType_IsValid && SkillId_IsValid && NeedCheckSkillCanCast_IsValid && MontageStartSectionName_IsValid && BuffId_IsValid && BuffLayer_IsValid && BuffDuration_IsValid && TriggerRemoveEffect_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ChildActorActionInfo", (byte)ChildActorActionInfo_IsValid != 0);
	}

	static FChildActorActionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FChildActorActionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChildActorActionInfo));
	}
}
