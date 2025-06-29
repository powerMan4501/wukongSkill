using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.CustomLightSystem;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_EnvCtrlData : b1.IBUC_EnvCtrlData, IPersistentECSData
{
	private TStrongObjectPtr<ACLSCommandManager> mCLSCmdMng = new TStrongObjectPtr<ACLSCommandManager>();

	public ACLSCommandManager CLSCmdMng
	{
		get
		{
			return mCLSCmdMng.Get();
		}
		set
		{
			mCLSCmdMng.Set(value);
		}
	}

	public bool bCLSCmdOpen { get; set; }

	public Dictionary<int, FEnvChangeConfig> LeveleSequenceMap { get; set; }

	public BUC_EnvCtrlData()
	{
		bCLSCmdOpen = false;
		LeveleSequenceMap = new Dictionary<int, FEnvChangeConfig>();
	}

	public float GetEnvSwitchSchedule(int EntityHash)
	{
		if (!LeveleSequenceMap.ContainsKey(EntityHash))
		{
			return 0f;
		}
		if (LeveleSequenceMap[EntityHash].FinalTargetALTime != 0f)
		{
			return UBGUFunctionLibraryForCS.BGUGetLevelSequenceCurTime(LeveleSequenceMap[EntityHash].EnvLevelSequencePlayer) / LeveleSequenceMap[EntityHash].FinalTargetALTime;
		}
		return 0f;
	}
}
