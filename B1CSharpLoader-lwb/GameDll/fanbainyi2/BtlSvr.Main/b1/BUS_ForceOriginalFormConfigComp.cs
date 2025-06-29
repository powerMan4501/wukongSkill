using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp")]
public class BUS_ForceOriginalFormConfigComp : UActorEditCompBase
{
	private static bool OverrideSkills_IsValid;

	private static int OverrideSkills_Offset;

	private static FFieldAddress OverrideSkills_PropertyAddress;

	private TMapReadWriteMarshaler<int, int> OverrideSkills_Marshaler;

	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[Tooltip("Key为ResID，Value为SkillID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp:OverrideSkills")]
	public TMapReadWrite<int, int> OverrideSkills
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp:OverrideSkills");
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
	[USharpPath("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp:AutoEnable");
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
		BUC_ForceOriginalFormData bUC_ForceOriginalFormData = RequireWritableData<BUC_ForceOriginalFormData>();
		bUC_ForceOriginalFormData.OverrideSkillIDs = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> overrideSkill in OverrideSkills)
		{
			bUC_ForceOriginalFormData.OverrideSkillIDs.Add(overrideSkill.Key, overrideSkill.Value);
		}
		RequireWritableData<BUC_QuestOverlapData>().bAutoEnableOverlap = AutoEnable;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ForceOriginalFormConfigComp");
		NativeReflection.GetPropertyRef(ref OverrideSkills_PropertyAddress, unrealStruct, "OverrideSkills");
		OverrideSkills_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideSkills");
		OverrideSkills_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideSkills", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
	}

	static BUS_ForceOriginalFormConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ForceOriginalFormConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ForceOriginalFormConfigComp));
	}
}
