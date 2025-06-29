using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP")]
public struct FGSArmorSettingInBP
{
	[DisplayName("是否开启硬直反击")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("硬直反击")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:Armor_Enable")]
	public bool Armor_Enable;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("硬直反击")]
	[DisplayName("硬直反击技能是否随机取Top分数技能")]
	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:IsGetTopRandomSkill")]
	public bool IsGetTopRandomSkill;

	[UMeta(MDProp.ClampMax, "10000")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("如填写了1000，就是取前10%的技能")]
	[UMeta(MDProp.EditCondition, "Armor_Enable && IsGetTopRandomSkill")]
	[Category("硬直反击")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Top分数区间(万分比)")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:TopRandomSkillPercent")]
	public int TopRandomSkillPercent;

	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[DisplayName("硬直反击技能列表")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("硬直反击")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:Armor_SkillID")]
	public List<int> Armor_SkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("硬直反击")]
	[DisplayName("硬直反击计时")]
	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:Armor_Timer")]
	public float Armor_Timer;

	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[DisplayName("硬直反击计数类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("硬直反击")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:BeHitCountType")]
	public EFightBackCountType BeHitCountType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("硬直反击")]
	[DisplayName("默认硬直反击最小受击数")]
	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:OriBeHitNum_Min")]
	public int OriBeHitNum_Min;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("硬直反击")]
	[DisplayName("默认硬直反击最大受击数")]
	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:OriBeHitNum_Max")]
	public int OriBeHitNum_Max;

	[DisplayName("硬直反击血量条件")]
	[EditAnywhere]
	[Category("硬直反击")]
	[UMeta(MDProp.EditCondition, "Armor_Enable")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:CounterWithBloodConfig")]
	public List<FGSArmorCounterWithBlood> CounterWithBloodConfig;

	[UProperty]
	[Tooltip("累计格挡次数达最大后会进入CD")]
	[DisplayName("最大格挡次数")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("格挡")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:MaxBlockTimes")]
	public int MaxBlockTimes;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("格挡")]
	[DisplayName("完美格挡触发次数")]
	[Tooltip("累计格挡次数等于该数值后会触发完美格挡")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:PerfectBlockTimes")]
	public int PerfectBlockTimes;

	[Tooltip("单位：秒；在格挡次数打满/格挡崩防or崩防虚弱恢复后，进入CD，不再触发格挡")]
	[Category("格挡")]
	[DisplayName("格挡冷却CD")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:BlockCoolDownTime")]
	public float BlockCoolDownTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("格挡")]
	[DisplayName("格挡计数器重置计时")]
	[Tooltip("单位：秒；填0等于无效；每次触发完格挡后进入倒计时，如果倒计时结束后还没触发下一次格挡，整个格挡计数重置")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:ResetBlockCounterTime")]
	public float ResetBlockCounterTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡默认DataAsset")]
	[Category("格挡")]
	[USharpPath("/Script/b1-Managed.FGSArmorSettingInBP:DefaultBlockInfoConfig")]
	public BGWDataAsset_BlockInfoConfig DefaultBlockInfoConfig;

	private static int FGSArmorSettingInBP_StructSize;

	private static int FGSArmorSettingInBP_IsValid;

	private static bool Armor_Enable_IsValid;

	private static int Armor_Enable_Offset;

	private static FFieldAddress Armor_Enable_PropertyAddress;

	private static bool IsGetTopRandomSkill_IsValid;

	private static int IsGetTopRandomSkill_Offset;

	private static FFieldAddress IsGetTopRandomSkill_PropertyAddress;

	private static bool TopRandomSkillPercent_IsValid;

	private static int TopRandomSkillPercent_Offset;

	private static bool Armor_SkillID_IsValid;

	private static int Armor_SkillID_Offset;

	private static FFieldAddress Armor_SkillID_PropertyAddress;

	private static bool Armor_Timer_IsValid;

	private static int Armor_Timer_Offset;

	private static bool BeHitCountType_IsValid;

	private static int BeHitCountType_Offset;

	private static FFieldAddress BeHitCountType_PropertyAddress;

	private static bool OriBeHitNum_Min_IsValid;

	private static int OriBeHitNum_Min_Offset;

	private static bool OriBeHitNum_Max_IsValid;

	private static int OriBeHitNum_Max_Offset;

	private static bool CounterWithBloodConfig_IsValid;

	private static int CounterWithBloodConfig_Offset;

	private static FFieldAddress CounterWithBloodConfig_PropertyAddress;

	private static bool MaxBlockTimes_IsValid;

	private static int MaxBlockTimes_Offset;

	private static bool PerfectBlockTimes_IsValid;

	private static int PerfectBlockTimes_Offset;

	private static bool BlockCoolDownTime_IsValid;

	private static int BlockCoolDownTime_Offset;

	private static bool ResetBlockCounterTime_IsValid;

	private static int ResetBlockCounterTime_Offset;

	private static bool DefaultBlockInfoConfig_IsValid;

	private static int DefaultBlockInfoConfig_Offset;

	public FGSArmorSettingInBP Copy()
	{
		FGSArmorSettingInBP result = this;
		if (Armor_SkillID != null)
		{
			result.Armor_SkillID = new List<int>(Armor_SkillID);
		}
		if (CounterWithBloodConfig != null)
		{
			result.CounterWithBloodConfig = new List<FGSArmorCounterWithBlood>(CounterWithBloodConfig);
		}
		return result;
	}

	public static FGSArmorSettingInBP FromNative(IntPtr nativeBuffer)
	{
		return new FGSArmorSettingInBP(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSArmorSettingInBP value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSArmorSettingInBP FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSArmorSettingInBP(IntPtr.Add(nativeBuffer, arrayIndex * FGSArmorSettingInBP_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSArmorSettingInBP value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSArmorSettingInBP_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSArmorSettingInBP_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSArmorSettingInBP");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Armor_Enable_Offset), 0, Armor_Enable_PropertyAddress.Address, Armor_Enable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address, IsGetTopRandomSkill);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TopRandomSkillPercent_Offset), TopRandomSkillPercent);
		new TArrayCopyMarshaler<int>(1, Armor_SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Armor_SkillID_Offset), Armor_SkillID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Armor_Timer_Offset), Armor_Timer);
		EnumMarshaler<EFightBackCountType>.ToNative(IntPtr.Add(nativeStruct, BeHitCountType_Offset), 0, BeHitCountType_PropertyAddress.Address, BeHitCountType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OriBeHitNum_Min_Offset), OriBeHitNum_Min);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OriBeHitNum_Max_Offset), OriBeHitNum_Max);
		new TArrayCopyMarshaler<FGSArmorCounterWithBlood>(1, CounterWithBloodConfig_PropertyAddress, CachedMarshalingDelegates<FGSArmorCounterWithBlood, BlittableTypeMarshaler<FGSArmorCounterWithBlood>>.FromNative, CachedMarshalingDelegates<FGSArmorCounterWithBlood, BlittableTypeMarshaler<FGSArmorCounterWithBlood>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CounterWithBloodConfig_Offset), CounterWithBloodConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxBlockTimes_Offset), MaxBlockTimes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PerfectBlockTimes_Offset), PerfectBlockTimes);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlockCoolDownTime_Offset), BlockCoolDownTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ResetBlockCounterTime_Offset), ResetBlockCounterTime);
		UObjectMarshaler<BGWDataAsset_BlockInfoConfig>.ToNative(IntPtr.Add(nativeStruct, DefaultBlockInfoConfig_Offset), DefaultBlockInfoConfig);
	}

	public FGSArmorSettingInBP(IntPtr nativeStruct)
	{
		if (FGSArmorSettingInBP_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSArmorSettingInBP");
			Armor_Enable = false;
			IsGetTopRandomSkill = false;
			TopRandomSkillPercent = 0;
			Armor_SkillID = null;
			Armor_Timer = 0f;
			BeHitCountType = EFightBackCountType.BeHitCount;
			OriBeHitNum_Min = 0;
			OriBeHitNum_Max = 0;
			CounterWithBloodConfig = null;
			MaxBlockTimes = 0;
			PerfectBlockTimes = 0;
			BlockCoolDownTime = 0f;
			ResetBlockCounterTime = 0f;
			DefaultBlockInfoConfig = null;
		}
		else
		{
			Armor_Enable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Armor_Enable_Offset), 0, Armor_Enable_PropertyAddress.Address);
			IsGetTopRandomSkill = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address);
			TopRandomSkillPercent = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TopRandomSkillPercent_Offset));
			Armor_SkillID = new TArrayCopyMarshaler<int>(1, Armor_SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Armor_SkillID_Offset));
			Armor_Timer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Armor_Timer_Offset));
			BeHitCountType = EnumMarshaler<EFightBackCountType>.FromNative(IntPtr.Add(nativeStruct, BeHitCountType_Offset), 0, BeHitCountType_PropertyAddress.Address);
			OriBeHitNum_Min = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OriBeHitNum_Min_Offset));
			OriBeHitNum_Max = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OriBeHitNum_Max_Offset));
			CounterWithBloodConfig = new TArrayCopyMarshaler<FGSArmorCounterWithBlood>(1, CounterWithBloodConfig_PropertyAddress, CachedMarshalingDelegates<FGSArmorCounterWithBlood, BlittableTypeMarshaler<FGSArmorCounterWithBlood>>.FromNative, CachedMarshalingDelegates<FGSArmorCounterWithBlood, BlittableTypeMarshaler<FGSArmorCounterWithBlood>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CounterWithBloodConfig_Offset));
			MaxBlockTimes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxBlockTimes_Offset));
			PerfectBlockTimes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PerfectBlockTimes_Offset));
			BlockCoolDownTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlockCoolDownTime_Offset));
			ResetBlockCounterTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ResetBlockCounterTime_Offset));
			DefaultBlockInfoConfig = UObjectMarshaler<BGWDataAsset_BlockInfoConfig>.FromNative(IntPtr.Add(nativeStruct, DefaultBlockInfoConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSArmorSettingInBP");
		FGSArmorSettingInBP_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Armor_Enable_PropertyAddress, intPtr, "Armor_Enable");
		Armor_Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Armor_Enable");
		Armor_Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Armor_Enable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsGetTopRandomSkill_PropertyAddress, intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsGetTopRandomSkill", Classes.FBoolProperty);
		TopRandomSkillPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "TopRandomSkillPercent");
		TopRandomSkillPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TopRandomSkillPercent", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Armor_SkillID_PropertyAddress, intPtr, "Armor_SkillID");
		Armor_SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "Armor_SkillID");
		Armor_SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Armor_SkillID", Classes.FArrayProperty);
		Armor_Timer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Armor_Timer");
		Armor_Timer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Armor_Timer", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BeHitCountType_PropertyAddress, intPtr, "BeHitCountType");
		BeHitCountType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeHitCountType");
		BeHitCountType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeHitCountType", Classes.FEnumProperty);
		OriBeHitNum_Min_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriBeHitNum_Min");
		OriBeHitNum_Min_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriBeHitNum_Min", Classes.FIntProperty);
		OriBeHitNum_Max_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriBeHitNum_Max");
		OriBeHitNum_Max_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriBeHitNum_Max", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CounterWithBloodConfig_PropertyAddress, intPtr, "CounterWithBloodConfig");
		CounterWithBloodConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "CounterWithBloodConfig");
		CounterWithBloodConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CounterWithBloodConfig", Classes.FArrayProperty);
		MaxBlockTimes_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxBlockTimes");
		MaxBlockTimes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxBlockTimes", Classes.FIntProperty);
		PerfectBlockTimes_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerfectBlockTimes");
		PerfectBlockTimes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerfectBlockTimes", Classes.FIntProperty);
		BlockCoolDownTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockCoolDownTime");
		BlockCoolDownTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockCoolDownTime", Classes.FFloatProperty);
		ResetBlockCounterTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResetBlockCounterTime");
		ResetBlockCounterTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResetBlockCounterTime", Classes.FFloatProperty);
		DefaultBlockInfoConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultBlockInfoConfig");
		DefaultBlockInfoConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultBlockInfoConfig", Classes.FObjectProperty);
		FGSArmorSettingInBP_IsValid = ((intPtr != IntPtr.Zero && Armor_Enable_IsValid && IsGetTopRandomSkill_IsValid && TopRandomSkillPercent_IsValid && Armor_SkillID_IsValid && Armor_Timer_IsValid && BeHitCountType_IsValid && OriBeHitNum_Min_IsValid && OriBeHitNum_Max_IsValid && CounterWithBloodConfig_IsValid && MaxBlockTimes_IsValid && PerfectBlockTimes_IsValid && BlockCoolDownTime_IsValid && ResetBlockCounterTime_IsValid && DefaultBlockInfoConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSArmorSettingInBP", (byte)FGSArmorSettingInBP_IsValid != 0);
	}

	static FGSArmorSettingInBP()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSArmorSettingInBP)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSArmorSettingInBP));
	}
}
