using System.Collections.Generic;
using b1.ECS;
using OssB1;

namespace b1;

public class BGC_OSSCollectionData : IPersistentECSData
{
	public int PlayerNum_LastFrame;

	public int CurPlayerNum;

	public int BeginFightTime_Last = -1;

	public int LeaveFightTime_Last;

	public List<BattleMonster> AiPartnerList;

	public List<BattleMonster> BattleMonsterList;

	public List<BattlePlayer> UnitTransList;

	public Dictionary<ulong, BattlePlayer> BattlePlayerDic;

	public int BattleBeginFightTime;

	public BGC_OSSCollectionData()
	{
		AiPartnerList = new List<BattleMonster>();
		BattleMonsterList = new List<BattleMonster>();
		UnitTransList = new List<BattlePlayer>();
		BattlePlayerDic = new Dictionary<ulong, BattlePlayer>();
	}

	public void ClearData()
	{
		AiPartnerList = new List<BattleMonster>();
		BattleMonsterList = new List<BattleMonster>();
		UnitTransList = new List<BattlePlayer>();
		BattlePlayerDic = new Dictionary<ulong, BattlePlayer>();
	}
}
