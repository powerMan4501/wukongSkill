using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp")]
public class BUS_ForceOriginalFormAreaConfigComp : UActorEditCompBase
{
	private static bool OverrideSkills_IsValid;

	private static int OverrideSkills_Offset;

	private static FFieldAddress OverrideSkills_PropertyAddress;

	private TMapReadWriteMarshaler<int, int> OverrideSkills_Marshaler;

	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("Key为ResID，Value为SkillID")]
	[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp:OverrideSkills")]
	public TMapReadWrite<int, int> OverrideSkills
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp:OverrideSkills");
				return null;
			}
			if (OverrideSkills_Marshaler == null)
			{
				OverrideSkills_Marshaler = new TMapReadWriteMarshaler<int, int>(1, OverrideSkills_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return OverrideSkills_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideSkills_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否默认开启")]
	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AutoEnable = true;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ForceOriginalFormAreaLogicData bUC_ForceOriginalFormAreaLogicData = RequireWritableData<BUC_ForceOriginalFormAreaLogicData>();
		bUC_ForceOriginalFormAreaLogicData.OverrideSkillIDs = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> overrideSkill in OverrideSkills)
		{
			bUC_ForceOriginalFormAreaLogicData.OverrideSkillIDs.Add(overrideSkill.Key, overrideSkill.Value);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceOriginalFormAreaConfigComp");
		NativeReflection.GetPropertyRef(ref OverrideSkills_PropertyAddress, unrealStruct, "OverrideSkills");
		OverrideSkills_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideSkills");
		OverrideSkills_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideSkills", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
	}

	static BUS_ForceOriginalFormAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceOriginalFormAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceOriginalFormAreaConfigComp));
	}
}
