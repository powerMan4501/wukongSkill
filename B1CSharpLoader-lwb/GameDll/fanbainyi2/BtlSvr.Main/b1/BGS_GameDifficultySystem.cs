using b1.EventDelDefine;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BGS_GameDifficultySystem : GameModeSystemBase
{
	private int MaxPlayerNum = 4;

	private int MinPlayerNum = 1;

	private BGC_LevelBattleData LevelBattleData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		LevelBattleData = RequireWritableGameStateData<BGC_LevelBattleData>();
		GetGameEventCollection().Evt_BGS_OnPlayerLogOut += new Del_OnPlayerLogOut(OnPlayerLogOut);
		GetGameEventCollection().Evt_BGS_OnPlayerPostLogin += new Del_OnPlayerPostLogin(OnPlayerPostLogin);
	}

	private void OnPlayerLogOut(AController Exitting)
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			LevelBattleData.GamePlayerNum--;
			OnPlayerNumChange();
		}
	}

	private void OnPlayerPostLogin(APlayerController NewPlayer)
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			LevelBattleData.GamePlayerNum++;
			OnPlayerNumChange();
		}
	}

	private void OnPlayerNumChange()
	{
		LevelBattleData.DifficultBuffId = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.OnelineDifficultBuffId);
		DoAddBuffLogicByPlayerNum();
	}

	private void DoAddBuffLogicByPlayerNum()
	{
		int difficultBuffId = LevelBattleData.DifficultBuffId;
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(GetOwner());
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player);
			if (!(Player != null) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(Player, bGUCharacterCS))
			{
				continue;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection == null)
			{
				break;
			}
			BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(bGUCharacterCS);
			if (readOnlyData == null)
			{
				continue;
			}
			int num = readOnlyData.GetBuffLayer(difficultBuffId) + 1;
			if (num >= LevelBattleData.GamePlayerNum)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(difficultBuffId, EBuffEffectTriggerType.None, num - LevelBattleData.GamePlayerNum);
			}
			else if (num < LevelBattleData.GamePlayerNum)
			{
				for (int j = 0; j < LevelBattleData.GamePlayerNum - num; j++)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(difficultBuffId, bGUCharacterCS, bGUCharacterCS, -1f);
				}
			}
		}
	}
}
