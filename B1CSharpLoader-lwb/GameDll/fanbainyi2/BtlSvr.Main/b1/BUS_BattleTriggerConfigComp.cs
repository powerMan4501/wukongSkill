using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BattleTriggerConfigComp")]
public class BUS_BattleTriggerConfigComp : UActorEditCompBase
{
	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	private static bool BattleTriggerConfig_IsValid;

	private static int BattleTriggerConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("混战配置")]
	[DisplayName("是否默认开启")]
	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_BattleTriggerConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BattleTriggerConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BattleTriggerConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("混战配置")]
	[DisplayName("混战配置列表")]
	[Tooltip("混战配置列表")]
	[USharpPath("/Script/b1-Managed.BUS_BattleTriggerConfigComp:BattleTriggerConfig")]
	public FBattleTriggerConfig BattleTriggerConfig
	{
		get
		{
			CheckDestroyed();
			if (!BattleTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BattleTriggerConfigComp:BattleTriggerConfig");
				return default(FBattleTriggerConfig);
			}
			return FBattleTriggerConfig.FromNative(IntPtr.Add(base.Address, BattleTriggerConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_BattleTriggerConfigComp:BattleTriggerConfig");
			}
			else
			{
				FBattleTriggerConfig.ToNative(IntPtr.Add(base.Address, BattleTriggerConfig_Offset), value);
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
		b1.BUC_BattleTriggerData bUC_BattleTriggerData = RequireWritableData<b1.BUC_BattleTriggerData>();
		bUC_BattleTriggerData.bAutoEnableOverlap = AutoEnable;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (FBattleTriggerUnitConfig battleUnitConfig in BattleTriggerConfig.BattleUnitConfigs)
		{
			bUC_BattleTriggerData.BattleUnitConfigInfos.Add(battleUnitConfig.Unit.ActorGuid, new FBattleTriggerUnitConfigInfo(battleUnitConfig));
			dictionary.Add(battleUnitConfig.Unit.ActorGuid, battleUnitConfig.Unit.ActorGuid);
		}
		foreach (KeyValuePair<string, FBattleTriggerUnitConfigInfo> battleUnitConfigInfo in bUC_BattleTriggerData.BattleUnitConfigInfos)
		{
			foreach (string item in battleUnitConfigInfo.Value.TargetUnitGuid)
			{
				if (FindGroupHead(battleUnitConfigInfo.Key, dictionary, out var GroupHeadGuid) && FindGroupHead(item, dictionary, out var GroupHeadGuid2) && GroupHeadGuid != GroupHeadGuid2)
				{
					dictionary[GroupHeadGuid2] = GroupHeadGuid;
				}
			}
		}
		foreach (KeyValuePair<string, string> item2 in dictionary)
		{
			if (bUC_BattleTriggerData.UnitBattleGroupInfo.ContainsKey(item2.Key) || !FindGroupHead(item2.Key, dictionary, out var GroupHeadGuid3))
			{
				continue;
			}
			if (bUC_BattleTriggerData.UnitBattleGroupInfo.TryGetValue(GroupHeadGuid3, out var value))
			{
				value.Add(item2.Key);
				bUC_BattleTriggerData.UnitBattleGroupInfo.Add(item2.Key, value);
				continue;
			}
			List<string> list = new List<string> { item2.Key };
			bUC_BattleTriggerData.UnitBattleGroupInfo.Add(item2.Key, list);
			if (item2.Key != GroupHeadGuid3)
			{
				list.Add(GroupHeadGuid3);
				bUC_BattleTriggerData.UnitBattleGroupInfo.Add(GroupHeadGuid3, list);
			}
			bUC_BattleTriggerData.BattleGroups.Add(list);
		}
	}

	public bool FindGroupHead(string UnitGuid, Dictionary<string, string> UnionFindUnitSet, out string GroupHeadGuid)
	{
		GroupHeadGuid = UnitGuid;
		if (!UnionFindUnitSet.ContainsKey(UnitGuid))
		{
			return false;
		}
		while (UnionFindUnitSet[GroupHeadGuid] != GroupHeadGuid)
		{
			GroupHeadGuid = UnionFindUnitSet[GroupHeadGuid];
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_BattleTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
		BattleTriggerConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleTriggerConfig");
		BattleTriggerConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleTriggerConfig", Classes.FStructProperty);
	}

	static BUS_BattleTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BattleTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BattleTriggerConfigComp));
	}
}
