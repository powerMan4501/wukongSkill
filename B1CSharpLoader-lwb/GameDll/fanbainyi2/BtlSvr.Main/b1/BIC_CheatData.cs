using System.Collections.Generic;
using Diana.Common;
using Diana.Server.Common;

namespace b1;

public class BIC_CheatData : IBIC_CheatData
{
	public NetServer Server { get; set; }

	public string CurrentSendMonsterGuid { get; set; }

	public List<EDianaControlCommand> DianaCommandList { get; } = new List<EDianaControlCommand>();

	public bool bRefreshLevelPoints { get; set; }

	public FDownloadInfo_LevelInfo LevelInfo { get; set; }

	public EDianaActorType NeedRefreshActorInfoType { get; set; }

	public List<string> RealTimeActors { get; } = new List<string>();

	public List<string> RefreshOnceActors { get; } = new List<string>();

	public bool bLockAllMonsterHP { get; set; }

	public bool bCancelAllMonsterSkillCD { get; set; }

	public bool bPauseAllMonsterAI { get; set; }

	public FMonsterStateParamCollection MonsterDetails { get; } = new FMonsterStateParamCollection();

	public FPlayerStateParamCollection PlayerDetails { get; } = new FPlayerStateParamCollection();

	public bool CanSendData()
	{
		if (Server != null)
		{
			return Server.CanSendData();
		}
		return false;
	}
}
