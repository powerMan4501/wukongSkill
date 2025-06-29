using System;
using System.Collections.Generic;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup")]
public struct FAutoTestPlayerCastSkillConditionGroup
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup:Describe")]
	public string Describe;

	[Tooltip("条件列表内所有条件都同时满足才通过")]
	[DisplayName("与条件列表")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup:ConditionConfigs")]
	public List<FAutoTestPlayerConditionConfig> ConditionConfigs;

	private static int AutoTestPlayerCastSkillConditionGroup_StructSize;

	private static int AutoTestPlayerCastSkillConditionGroup_IsValid;

	private static bool Describe_IsValid;

	private static int Describe_Offset;

	private static bool ConditionConfigs_IsValid;

	private static int ConditionConfigs_Offset;

	private static FFieldAddress ConditionConfigs_PropertyAddress;

	public QuestCustom_PlayerCastSkillConditionGroup ToCustomData()
	{
		QuestCustom_PlayerCastSkillConditionGroup questCustom_PlayerCastSkillConditionGroup = new QuestCustom_PlayerCastSkillConditionGroup();
		questCustom_PlayerCastSkillConditionGroup.Describe = Describe;
		if (ConditionConfigs != null)
		{
			foreach (FAutoTestPlayerConditionConfig conditionConfig in ConditionConfigs)
			{
				questCustom_PlayerCastSkillConditionGroup.ConditionConfigs.Add(conditionConfig.ToCustomData());
			}
		}
		return questCustom_PlayerCastSkillConditionGroup;
	}

	public FAutoTestPlayerCastSkillConditionGroup Copy()
	{
		FAutoTestPlayerCastSkillConditionGroup result = this;
		if (ConditionConfigs != null)
		{
			result.ConditionConfigs = new List<FAutoTestPlayerConditionConfig>(ConditionConfigs);
		}
		return result;
	}

	public static FAutoTestPlayerCastSkillConditionGroup FromNative(IntPtr nativeBuffer)
	{
		return new FAutoTestPlayerCastSkillConditionGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutoTestPlayerCastSkillConditionGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutoTestPlayerCastSkillConditionGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutoTestPlayerCastSkillConditionGroup(IntPtr.Add(nativeBuffer, arrayIndex * AutoTestPlayerCastSkillConditionGroup_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutoTestPlayerCastSkillConditionGroup value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AutoTestPlayerCastSkillConditionGroup_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AutoTestPlayerCastSkillConditionGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Describe_Offset), Describe);
		new TArrayCopyMarshaler<FAutoTestPlayerConditionConfig>(1, ConditionConfigs_PropertyAddress, CachedMarshalingDelegates<FAutoTestPlayerConditionConfig, FAutoTestPlayerConditionConfig>.FromNative, CachedMarshalingDelegates<FAutoTestPlayerConditionConfig, FAutoTestPlayerConditionConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, ConditionConfigs_Offset), ConditionConfigs);
	}

	public FAutoTestPlayerCastSkillConditionGroup(IntPtr nativeStruct)
	{
		if (AutoTestPlayerCastSkillConditionGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup");
			Describe = null;
			ConditionConfigs = null;
		}
		else
		{
			Describe = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Describe_Offset));
			ConditionConfigs = new TArrayCopyMarshaler<FAutoTestPlayerConditionConfig>(1, ConditionConfigs_PropertyAddress, CachedMarshalingDelegates<FAutoTestPlayerConditionConfig, FAutoTestPlayerConditionConfig>.FromNative, CachedMarshalingDelegates<FAutoTestPlayerConditionConfig, FAutoTestPlayerConditionConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, ConditionConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup");
		AutoTestPlayerCastSkillConditionGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		Describe_Offset = NativeReflection.GetPropertyOffset(intPtr, "Describe");
		Describe_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Describe", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ConditionConfigs_PropertyAddress, intPtr, "ConditionConfigs");
		ConditionConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionConfigs");
		ConditionConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionConfigs", Classes.FArrayProperty);
		AutoTestPlayerCastSkillConditionGroup_IsValid = ((intPtr != IntPtr.Zero && Describe_IsValid && ConditionConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AutoTestPlayerCastSkillConditionGroup", (byte)AutoTestPlayerCastSkillConditionGroup_IsValid != 0);
	}

	static FAutoTestPlayerCastSkillConditionGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAutoTestPlayerCastSkillConditionGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutoTestPlayerCastSkillConditionGroup));
	}
}
