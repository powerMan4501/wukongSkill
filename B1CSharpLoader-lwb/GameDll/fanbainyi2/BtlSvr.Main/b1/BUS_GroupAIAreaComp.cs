using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaComp")]
public class BUS_GroupAIAreaComp : UActorEditCompBase
{
	private static bool GroupAIMgrConfigDA_IsValid;

	private static int GroupAIMgrConfigDA_Offset;

	private static bool GroupAIBattleHotZoneConfigDA_IsValid;

	private static int GroupAIBattleHotZoneConfigDA_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIMgrConfigDA")]
	public BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!GroupAIMgrConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIMgrConfigDA");
				return null;
			}
			return UObjectMarshaler<BGWGroupAIMgrConfigDataAsset>.FromNative(IntPtr.Add(base.Address, GroupAIMgrConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupAIMgrConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIMgrConfigDA");
			}
			else
			{
				UObjectMarshaler<BGWGroupAIMgrConfigDataAsset>.ToNative(IntPtr.Add(base.Address, GroupAIMgrConfigDA_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIBattleHotZoneConfigDA")]
	public BGWGroupAIBattleHotZoneConfigDataAsset GroupAIBattleHotZoneConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!GroupAIBattleHotZoneConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIBattleHotZoneConfigDA");
				return null;
			}
			return UObjectMarshaler<BGWGroupAIBattleHotZoneConfigDataAsset>.FromNative(IntPtr.Add(base.Address, GroupAIBattleHotZoneConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupAIBattleHotZoneConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GroupAIAreaComp:GroupAIBattleHotZoneConfigDA");
			}
			else
			{
				UObjectMarshaler<BGWGroupAIBattleHotZoneConfigDataAsset>.ToNative(IntPtr.Add(base.Address, GroupAIBattleHotZoneConfigDA_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_GroupAIAreaData bUC_GroupAIAreaData = RequireWritableData<b1.BUC_GroupAIAreaData>();
		bUC_GroupAIAreaData.GroupAIMgrConfigDA = GroupAIMgrConfigDA;
		bUC_GroupAIAreaData.GroupAIBattleHotZoneConfigDA = GroupAIBattleHotZoneConfigDA;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_GroupAIAreaComp");
		GroupAIMgrConfigDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupAIMgrConfigDA");
		GroupAIMgrConfigDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupAIMgrConfigDA", Classes.FObjectProperty);
		GroupAIBattleHotZoneConfigDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupAIBattleHotZoneConfigDA");
		GroupAIBattleHotZoneConfigDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupAIBattleHotZoneConfigDA", Classes.FObjectProperty);
	}

	static BUS_GroupAIAreaComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GroupAIAreaComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GroupAIAreaComp));
	}
}
