using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_OnFightTriggerConfigComp")]
public class BUS_OnFightTriggerConfigComp : UActorEditCompBase
{
	private static bool TargetUnit_IsValid;

	private static int TargetUnit_Offset;

	private static bool OnFightSkillID_IsValid;

	private static int OnFightSkillID_Offset;

	[EditAnywhere]
	[UProperty]
	[Category("OnFight Trigger Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:TargetUnit")]
	public BGUCharacterCS TargetUnit
	{
		get
		{
			CheckDestroyed();
			if (!TargetUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:TargetUnit");
				return null;
			}
			return UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, TargetUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:TargetUnit");
			}
			else
			{
				UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, TargetUnit_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("OnFight Trigger Config")]
	[USharpPath("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:OnFightSkillID")]
	public int OnFightSkillID
	{
		get
		{
			CheckDestroyed();
			if (!OnFightSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:OnFightSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OnFightSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_OnFightTriggerConfigComp:OnFightSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OnFightSkillID_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_OnFightTriggerConfigData bUC_OnFightTriggerConfigData = RequireWritableData<b1.BUC_OnFightTriggerConfigData>();
		bUC_OnFightTriggerConfigData.TargetUnit = TargetUnit;
		bUC_OnFightTriggerConfigData.OnFightSkillID = OnFightSkillID;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_OnFightTriggerConfigComp");
		TargetUnit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetUnit");
		TargetUnit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetUnit", Classes.FObjectProperty);
		OnFightSkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnFightSkillID");
		OnFightSkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnFightSkillID", Classes.FIntProperty);
	}

	static BUS_OnFightTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_OnFightTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_OnFightTriggerConfigComp));
	}
}
