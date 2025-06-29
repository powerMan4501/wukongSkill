using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.GroupAIBPConfig")]
public struct FGroupAIBPConfig
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否强制关闭群体AI")]
	[Tooltip("无视表里数据和Effect/Buff触发")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:IsForceDisableGroupAI")]
	public bool IsForceDisableGroupAI;

	[Tooltip("具体加分数值参考GroupAI表")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否为头领单位")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:IsBossUnit")]
	public bool IsBossUnit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否只会释放一次见面礼")]
	[Tooltip("勾选后，只会在第一次接受到AttackToken的时候释放见面礼")]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:OnlyUseOnceOnFightSkill")]
	public bool OnlyUseOnceOnFightSkill;

	[Tooltip("在接受到攻击Token后才会尝试释放，且见面礼技能不会要求走到热区")]
	[BlueprintReadWrite]
	[DisplayName("群体AI见面礼技能List")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:GroupAIOnFightSkillList")]
	public List<int> GroupAIOnFightSkillList;

	[Tooltip("勾选后，只会在第一次接受Token后触发添加Buff")]
	[DisplayName("是否只会触发一次添加Buff当接受Token时")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:OnlyTriggerOnceAddBuffWhenReceiveToken")]
	public bool OnlyTriggerOnceAddBuffWhenReceiveToken;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("接受Token后添加BuffList")]
	[Tooltip("在接受到Token后才会添加")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:BuffListWhenReceiveToken")]
	public List<int> BuffListWhenReceiveToken;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否只会触发一次添加Buff当失去Token时")]
	[Tooltip("勾选后，只会在第一次失去Token后触发添加Buff")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:OnlyTriggerOnceAddBuffWhenLostToken")]
	public bool OnlyTriggerOnceAddBuffWhenLostToken;

	[Tooltip("在接受到Token后才会尝试添加")]
	[DisplayName("失去Token后添加BuffList")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GroupAIBPConfig:BuffListWhenLostToken")]
	public List<int> BuffListWhenLostToken;

	private static int GroupAIBPConfig_StructSize;

	private static int GroupAIBPConfig_IsValid;

	private static bool IsForceDisableGroupAI_IsValid;

	private static int IsForceDisableGroupAI_Offset;

	private static FFieldAddress IsForceDisableGroupAI_PropertyAddress;

	private static bool IsBossUnit_IsValid;

	private static int IsBossUnit_Offset;

	private static FFieldAddress IsBossUnit_PropertyAddress;

	private static bool OnlyUseOnceOnFightSkill_IsValid;

	private static int OnlyUseOnceOnFightSkill_Offset;

	private static FFieldAddress OnlyUseOnceOnFightSkill_PropertyAddress;

	private static bool GroupAIOnFightSkillList_IsValid;

	private static int GroupAIOnFightSkillList_Offset;

	private static FFieldAddress GroupAIOnFightSkillList_PropertyAddress;

	private static bool OnlyTriggerOnceAddBuffWhenReceiveToken_IsValid;

	private static int OnlyTriggerOnceAddBuffWhenReceiveToken_Offset;

	private static FFieldAddress OnlyTriggerOnceAddBuffWhenReceiveToken_PropertyAddress;

	private static bool BuffListWhenReceiveToken_IsValid;

	private static int BuffListWhenReceiveToken_Offset;

	private static FFieldAddress BuffListWhenReceiveToken_PropertyAddress;

	private static bool OnlyTriggerOnceAddBuffWhenLostToken_IsValid;

	private static int OnlyTriggerOnceAddBuffWhenLostToken_Offset;

	private static FFieldAddress OnlyTriggerOnceAddBuffWhenLostToken_PropertyAddress;

	private static bool BuffListWhenLostToken_IsValid;

	private static int BuffListWhenLostToken_Offset;

	private static FFieldAddress BuffListWhenLostToken_PropertyAddress;

	public FGroupAIBPConfig Copy()
	{
		FGroupAIBPConfig result = this;
		if (GroupAIOnFightSkillList != null)
		{
			result.GroupAIOnFightSkillList = new List<int>(GroupAIOnFightSkillList);
		}
		if (BuffListWhenReceiveToken != null)
		{
			result.BuffListWhenReceiveToken = new List<int>(BuffListWhenReceiveToken);
		}
		if (BuffListWhenLostToken != null)
		{
			result.BuffListWhenLostToken = new List<int>(BuffListWhenLostToken);
		}
		return result;
	}

	public static FGroupAIBPConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGroupAIBPConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroupAIBPConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroupAIBPConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroupAIBPConfig(IntPtr.Add(nativeBuffer, arrayIndex * GroupAIBPConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroupAIBPConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GroupAIBPConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GroupAIBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GroupAIBPConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsForceDisableGroupAI_Offset), 0, IsForceDisableGroupAI_PropertyAddress.Address, IsForceDisableGroupAI);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsBossUnit_Offset), 0, IsBossUnit_PropertyAddress.Address, IsBossUnit);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OnlyUseOnceOnFightSkill_Offset), 0, OnlyUseOnceOnFightSkill_PropertyAddress.Address, OnlyUseOnceOnFightSkill);
		new TArrayCopyMarshaler<int>(1, GroupAIOnFightSkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupAIOnFightSkillList_Offset), GroupAIOnFightSkillList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OnlyTriggerOnceAddBuffWhenReceiveToken_Offset), 0, OnlyTriggerOnceAddBuffWhenReceiveToken_PropertyAddress.Address, OnlyTriggerOnceAddBuffWhenReceiveToken);
		new TArrayCopyMarshaler<int>(1, BuffListWhenReceiveToken_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffListWhenReceiveToken_Offset), BuffListWhenReceiveToken);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OnlyTriggerOnceAddBuffWhenLostToken_Offset), 0, OnlyTriggerOnceAddBuffWhenLostToken_PropertyAddress.Address, OnlyTriggerOnceAddBuffWhenLostToken);
		new TArrayCopyMarshaler<int>(1, BuffListWhenLostToken_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffListWhenLostToken_Offset), BuffListWhenLostToken);
	}

	public FGroupAIBPConfig(IntPtr nativeStruct)
	{
		if (GroupAIBPConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GroupAIBPConfig");
			IsForceDisableGroupAI = false;
			IsBossUnit = false;
			OnlyUseOnceOnFightSkill = false;
			GroupAIOnFightSkillList = null;
			OnlyTriggerOnceAddBuffWhenReceiveToken = false;
			BuffListWhenReceiveToken = null;
			OnlyTriggerOnceAddBuffWhenLostToken = false;
			BuffListWhenLostToken = null;
		}
		else
		{
			IsForceDisableGroupAI = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsForceDisableGroupAI_Offset), 0, IsForceDisableGroupAI_PropertyAddress.Address);
			IsBossUnit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsBossUnit_Offset), 0, IsBossUnit_PropertyAddress.Address);
			OnlyUseOnceOnFightSkill = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OnlyUseOnceOnFightSkill_Offset), 0, OnlyUseOnceOnFightSkill_PropertyAddress.Address);
			GroupAIOnFightSkillList = new TArrayCopyMarshaler<int>(1, GroupAIOnFightSkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupAIOnFightSkillList_Offset));
			OnlyTriggerOnceAddBuffWhenReceiveToken = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OnlyTriggerOnceAddBuffWhenReceiveToken_Offset), 0, OnlyTriggerOnceAddBuffWhenReceiveToken_PropertyAddress.Address);
			BuffListWhenReceiveToken = new TArrayCopyMarshaler<int>(1, BuffListWhenReceiveToken_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffListWhenReceiveToken_Offset));
			OnlyTriggerOnceAddBuffWhenLostToken = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OnlyTriggerOnceAddBuffWhenLostToken_Offset), 0, OnlyTriggerOnceAddBuffWhenLostToken_PropertyAddress.Address);
			BuffListWhenLostToken = new TArrayCopyMarshaler<int>(1, BuffListWhenLostToken_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffListWhenLostToken_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GroupAIBPConfig");
		GroupAIBPConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref IsForceDisableGroupAI_PropertyAddress, intPtr, "IsForceDisableGroupAI");
		IsForceDisableGroupAI_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsForceDisableGroupAI");
		IsForceDisableGroupAI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsForceDisableGroupAI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsBossUnit_PropertyAddress, intPtr, "IsBossUnit");
		IsBossUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsBossUnit");
		IsBossUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsBossUnit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnlyUseOnceOnFightSkill_PropertyAddress, intPtr, "OnlyUseOnceOnFightSkill");
		OnlyUseOnceOnFightSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnlyUseOnceOnFightSkill");
		OnlyUseOnceOnFightSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnlyUseOnceOnFightSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GroupAIOnFightSkillList_PropertyAddress, intPtr, "GroupAIOnFightSkillList");
		GroupAIOnFightSkillList_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupAIOnFightSkillList");
		GroupAIOnFightSkillList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupAIOnFightSkillList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OnlyTriggerOnceAddBuffWhenReceiveToken_PropertyAddress, intPtr, "OnlyTriggerOnceAddBuffWhenReceiveToken");
		OnlyTriggerOnceAddBuffWhenReceiveToken_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnlyTriggerOnceAddBuffWhenReceiveToken");
		OnlyTriggerOnceAddBuffWhenReceiveToken_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnlyTriggerOnceAddBuffWhenReceiveToken", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BuffListWhenReceiveToken_PropertyAddress, intPtr, "BuffListWhenReceiveToken");
		BuffListWhenReceiveToken_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffListWhenReceiveToken");
		BuffListWhenReceiveToken_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffListWhenReceiveToken", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OnlyTriggerOnceAddBuffWhenLostToken_PropertyAddress, intPtr, "OnlyTriggerOnceAddBuffWhenLostToken");
		OnlyTriggerOnceAddBuffWhenLostToken_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnlyTriggerOnceAddBuffWhenLostToken");
		OnlyTriggerOnceAddBuffWhenLostToken_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnlyTriggerOnceAddBuffWhenLostToken", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BuffListWhenLostToken_PropertyAddress, intPtr, "BuffListWhenLostToken");
		BuffListWhenLostToken_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffListWhenLostToken");
		BuffListWhenLostToken_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffListWhenLostToken", Classes.FArrayProperty);
		GroupAIBPConfig_IsValid = ((intPtr != IntPtr.Zero && IsForceDisableGroupAI_IsValid && IsBossUnit_IsValid && OnlyUseOnceOnFightSkill_IsValid && GroupAIOnFightSkillList_IsValid && OnlyTriggerOnceAddBuffWhenReceiveToken_IsValid && BuffListWhenReceiveToken_IsValid && OnlyTriggerOnceAddBuffWhenLostToken_IsValid && BuffListWhenLostToken_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GroupAIBPConfig", (byte)GroupAIBPConfig_IsValid != 0);
	}

	static FGroupAIBPConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGroupAIBPConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroupAIBPConfig));
	}
}
