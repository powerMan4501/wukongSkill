using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIC_BossRushBattleData : IBIC_BossRushBattleData
{
	private readonly TStrongObjectPtr<BGWDataAsset_BossRushLevelConfig> DAConfigPtr = new TStrongObjectPtr<BGWDataAsset_BossRushLevelConfig>();

	private TStrongObjectPtr<UCurveFloat> _timeDilationCurve = new TStrongObjectPtr<UCurveFloat>();

	private EBossRushBattlePhase _battlePhase;

	public int BossRushID { get; set; }

	public EBossRushBattlePhase BattlePhase
	{
		get
		{
			return _battlePhase;
		}
		set
		{
			if (_battlePhase != value)
			{
				_battlePhase = value;
			}
		}
	}

	public bool bPlayerInBattle { get; set; }

	public PsmInstance CurrentInstance { get; set; }

	public FTransform PlayerStartForSingle { get; set; }

	public FTransform PlayerStartForGroup { get; set; }

	public string TargetPersistentLevelName { get; set; }

	public BGWDataAsset_BossRushLevelConfig DAConfig
	{
		get
		{
			return DAConfigPtr.Get();
		}
		set
		{
			DAConfigPtr.Set(value);
		}
	}

	public Dictionary<string, FBossRushTamerPropertyOverride> TamerPropertyOverrideList { get; } = new Dictionary<string, FBossRushTamerPropertyOverride>();

	public Dictionary<int, FBossRushServantPropertyOverride> ServantPropertyOverrideList { get; } = new Dictionary<int, FBossRushServantPropertyOverride>();

	public FBossRushModifyTableCollection ModifyTableCollection { get; } = new FBossRushModifyTableCollection();

	public Dictionary<string, EBossRushLevelLoadState> LevelLoadConfigFromDA { get; } = new Dictionary<string, EBossRushLevelLoadState>();

	public Dictionary<string, EBossRushLevelLoadState> LevelLoadConfigFromGraph { get; } = new Dictionary<string, EBossRushLevelLoadState>();

	public UCurveFloat TimeDilationCurve
	{
		get
		{
			return _timeDilationCurve.Get();
		}
		set
		{
			_timeDilationCurve.Set(value);
		}
	}

	public float TotalSlowTime { get; set; }

	public float CurrentSlowTime { get; set; }

	public float AdditionalHPMaxMul { get; set; }

	public float AdditionalAtkMul { get; set; }

	public FBossRoom BossRushRoom { get; set; }

	public bool IsInSlowTime()
	{
		return CurrentSlowTime > 0f;
	}

	public IDictionary<string, EBossRushLevelLoadState> GetFinalLevelLoadConfig()
	{
		Dictionary<string, EBossRushLevelLoadState> dictionary = new Dictionary<string, EBossRushLevelLoadState>();
		foreach (KeyValuePair<string, EBossRushLevelLoadState> levelLoadConfigFromDum in LevelLoadConfigFromDA)
		{
			if (LevelLoadConfigFromGraph.TryGetValue(levelLoadConfigFromDum.Key, out var value))
			{
				dictionary[levelLoadConfigFromDum.Key] = value;
			}
			else
			{
				dictionary[levelLoadConfigFromDum.Key] = levelLoadConfigFromDum.Value;
			}
		}
		return dictionary;
	}

	public List<string> GetGraphManagedLevels()
	{
		List<string> list = new List<string>();
		if (CurrentInstance != null)
		{
			foreach (KeyValuePair<Guid, PsmParameterInstance> parameterInstance in CurrentInstance.ParameterInstances)
			{
				PsmParameterInstance value = parameterInstance.Value;
				if (value.ParamType == EGsManagedParamType.StreamingLevel)
				{
					string[] array = value.ParamValueStr.Split('.');
					if (array.Length == 2)
					{
						string item = array[1];
						list.Add(item);
					}
				}
			}
		}
		return list;
	}

	public void ClearData()
	{
		BossRushID = 0;
		CurrentInstance = null;
		PlayerStartForSingle = FTransform.Identity;
		PlayerStartForGroup = FTransform.Identity;
		TargetPersistentLevelName = "";
		TamerPropertyOverrideList.Clear();
		ServantPropertyOverrideList.Clear();
		LevelLoadConfigFromDA.Clear();
		LevelLoadConfigFromGraph.Clear();
		ModifyTableCollection.Clean();
		TotalSlowTime = -1f;
		CurrentSlowTime = -1f;
		TimeDilationCurve = null;
		AdditionalAtkMul = 0f;
		AdditionalHPMaxMul = 0f;
		BossRushRoom = null;
		bPlayerInBattle = false;
		BattlePhase = EBossRushBattlePhase.NotBegin;
	}
}
