using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_OnlineTeammateData : IBGC_OnlineTeammateData, IPersistentECSData
{
	public const int MaxPlayerCount = 4;

	public bool NeedUpdateTransition;

	public List<PlayerMapTransformInfo> PlayerMapTransformInfoList = new List<PlayerMapTransformInfo>();

	public Dictionary<int, TeamPlayerInfo> PlayerInfoDict { get; set; } = new Dictionary<int, TeamPlayerInfo>();

	public BGC_OnlineTeammateData()
	{
		for (int i = 1; i <= 4; i++)
		{
			PlayerInfoDict.Add(i, new TeamPlayerInfo(i));
		}
	}

	public void PlayerJoin(ABGPPlayerState PlayerState)
	{
		if (PlayerState == null)
		{
			return;
		}
		foreach (KeyValuePair<int, TeamPlayerInfo> item in PlayerInfoDict)
		{
			if (item.Value.PlayerState.Value == PlayerState)
			{
				BGW_LogUtil.LogError("Try Add Same PlayerState !!");
				return;
			}
		}
		for (int i = 1; i <= 4; i++)
		{
			if (!PlayerInfoDict[i].IsValid())
			{
				PlayerInfoDict[i].SetPlayerState(PlayerState);
				break;
			}
		}
	}

	public void PlayerLogOut(ABGPPlayerState PlayerState)
	{
		if (PlayerState == null)
		{
			return;
		}
		foreach (KeyValuePair<int, TeamPlayerInfo> item in PlayerInfoDict)
		{
			if (item.Value.PlayerState.Value == PlayerState)
			{
				item.Value.SetPlayerState(null);
				item.Value.SetPlayerActor(null);
				break;
			}
		}
	}

	public void PlayerActorUpdate(ABGPPlayerState PlayerState)
	{
		if (PlayerState == null)
		{
			return;
		}
		foreach (KeyValuePair<int, TeamPlayerInfo> item in PlayerInfoDict)
		{
			if (item.Value.PlayerState.Value == PlayerState)
			{
				item.Value.SetPlayerActor(PlayerState.GetPawn());
				break;
			}
		}
	}

	public void UpdatePlayerMapTransformInfoList(int Index, PlayerMapTransformInfo PlayerMapTransformInfo)
	{
		if (Index >= 0)
		{
			if (Index < PlayerMapTransformInfoList.Count)
			{
				PlayerMapTransformInfoList[Index] = PlayerMapTransformInfo;
			}
			else if (Index == PlayerMapTransformInfoList.Count)
			{
				PlayerMapTransformInfoList.Add(PlayerMapTransformInfo);
			}
		}
	}

	public List<PlayerMapTransformInfo> GetPlayerTranstion()
	{
		if (NeedUpdateTransition)
		{
			UpdatePlayerTranstion();
		}
		return PlayerMapTransformInfoList;
	}

	private void UpdatePlayerTranstion()
	{
		if (!NeedUpdateTransition)
		{
			return;
		}
		NeedUpdateTransition = false;
		foreach (KeyValuePair<int, TeamPlayerInfo> item in PlayerInfoDict)
		{
			if (item.Value.IsValid())
			{
				PlayerMapTransformInfo playerMapTransformInfo = new PlayerMapTransformInfo();
				ABGUCharacter aBGUCharacter = item.Value.PlayerState.Value.GetPawn() as ABGUCharacter;
				if (aBGUCharacter != null)
				{
					playerMapTransformInfo.Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter);
					playerMapTransformInfo.Rotation = aBGUCharacter.GetActorRotation();
				}
				playerMapTransformInfo.PlayerIndex = item.Key;
				UpdatePlayerMapTransformInfoList(item.Key - 1, playerMapTransformInfo);
			}
		}
	}
}
