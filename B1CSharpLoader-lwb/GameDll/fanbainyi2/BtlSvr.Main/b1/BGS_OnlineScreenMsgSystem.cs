using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Localization;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_OnlineScreenMsgSystem : GameModeSystemBase
{
	private float Ticktime = 0.1f;

	private BGC_DSDebugData DSDebugData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		DSDebugData = RequireWritableData<BGC_DSDebugData>();
		GetGameEventCollection().Evt_BGS_PlayerDeadScreenMsg += new Del_Void_String(OnPlayerDead);
		GetGameEventCollection().Evt_BGS_LevelEventScreenMsg += new Del_Void_Int(OnLevelEventScreenMsg);
		GetGameEventCollection().Evt_BGS_UseItemScreenMsg += new Del_Void_UseItemScreenMsg(OnUseItemScreenMsg);
		GetGameEventCollection().Evt_BGS_OnPlayerLogOut += new Del_OnPlayerLogOut(OnPlayerLogOut);
		GetGameEventCollection().Evt_BGS_OnPlayerPostLogin += new Del_OnPlayerPostLogin(OnPlayerPostLogin);
		GetGameEventCollection().Evt_BGS_GMCGTest += new Del_Void_Int(OnGMGCTest);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DebugConfig.PlayerDebugDraw)
		{
			if (Ticktime > 0f)
			{
				Ticktime -= DeltaTime;
			}
			else
			{
				APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World)?.GetControlledPawn();
				UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(Owner.World, aPawn.GetActorLocation(), 100f, 15f, FColor.Red);
				Ticktime = 0.1f;
			}
		}
		TickGMGCTest(DeltaTime);
	}

	private void OnPlayerDead(string PlayerName)
	{
		List<string> list = new List<string>();
		list.Add(PlayerName);
		int TipsDuration;
		string screenMsg = GetScreenMsg(EScreenMsgType.PlayerDead, list, out TipsDuration);
		SendScreenMsg(EScreenMsgType.PlayerDead, screenMsg, TipsDuration);
	}

	private void OnLevelEventScreenMsg(int EventId)
	{
		FUStOnlineScreenMsgConfDesc onlineScreenMsgConfDescById = BGW_GameDB.GetOnlineScreenMsgConfDescById(EventId);
		if (onlineScreenMsgConfDescById != null && onlineScreenMsgConfDescById.ScreenMsgType == EScreenMsgType.TriggerLevelEvent)
		{
			SendScreenMsg(EScreenMsgType.TriggerLevelEvent, onlineScreenMsgConfDescById.TipsWord, onlineScreenMsgConfDescById.TipsDuration);
		}
	}

	private void OnUseItemScreenMsg(string PlayerName, int ItemID)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
		if (itemDesc != null && itemDesc.IsLevelItem == YesNoType.Yes)
		{
			List<string> list = new List<string>();
			list.Add(PlayerName);
			list.Add(itemDesc.Name.ToFTextRemoveRich().ToString());
			int TipsDuration;
			string screenMsg = GetScreenMsg(EScreenMsgType.UseLevelItem, list, out TipsDuration);
			SendScreenMsg(EScreenMsgType.UseLevelItem, screenMsg, TipsDuration);
		}
	}

	private void OnPlayerLogOut(AController PlayerController)
	{
		List<string> list = new List<string>();
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(PlayerController);
		if (readOnlyData != null && readOnlyData.RoleData != null)
		{
			list.Add(readOnlyData.RoleData.RoleCs.Base.Name);
		}
		int TipsDuration;
		string screenMsg = GetScreenMsg(EScreenMsgType.TeamerDisconnected, list, out TipsDuration);
		SendScreenMsg(EScreenMsgType.TeamerDisconnected, screenMsg, TipsDuration);
	}

	private void OnPlayerPostLogin(APlayerController PlayerController)
	{
		List<string> list = new List<string>();
		int TipsDuration;
		string screenMsg = GetScreenMsg(EScreenMsgType.TeamerJoin, list, out TipsDuration);
		SendScreenMsg(EScreenMsgType.TeamerJoin, screenMsg, TipsDuration);
	}

	private string GetScreenMsg(EScreenMsgType ScreenMsgType, List<string> Params, out int TipsDuration)
	{
		string text = "";
		TipsDuration = 0;
		FUStOnlineScreenMsgConfDesc onlineScreenMsgConfDescByType = BGW_GameDB.GetOnlineScreenMsgConfDescByType(ScreenMsgType);
		if (onlineScreenMsgConfDescByType == null)
		{
			return text;
		}
		TipsDuration = onlineScreenMsgConfDescByType.TipsDuration;
		if (Params == null || Params.Count == 0)
		{
			return onlineScreenMsgConfDescByType.TipsWord;
		}
		string tipsWord = onlineScreenMsgConfDescByType.TipsWord;
		if (tipsWord.Contains("{}"))
		{
			string[] array = tipsWord.Split(new string[1] { "{}" }, StringSplitOptions.None);
			if (array.Length == Params.Count + 1)
			{
				for (int i = 0; i < Params.Count; i++)
				{
					text = text + array[i] + Params[i];
				}
				text += array[Params.Count];
			}
			else
			{
				BGW_LogUtil.LogDbgMigge($"表格OnlineScreenMsgConfDesc配置错误: {onlineScreenMsgConfDescByType.ID}");
			}
		}
		else
		{
			BGW_LogUtil.LogDbgMigge($"表格OnlineScreenMsgConfDesc配置错误: {onlineScreenMsgConfDescByType.ID}");
		}
		return text;
	}

	private void SendScreenMsg(EScreenMsgType MsgType, string Msg, int TipsDuration)
	{
		GetGameEventCollection().Evt_BGS_SendOnlineScreenMsg.Invoke(MsgType, Msg, TipsDuration);
	}

	private void OnGMGCTest(int Time)
	{
		DSDebugData.GCTestTime = Time;
	}

	private void TriggerGMGC()
	{
		UObject.CollectGarbage();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
	}

	private void TickGMGCTest(float DeltaTime)
	{
		if (DSDebugData != null && DSDebugData.GCTestTime > 0)
		{
			DSDebugData.FrameDelay++;
			if (DSDebugData.FrameDelay >= DSDebugData.GCTestTime)
			{
				DSDebugData.FrameDelay = 0;
				TriggerGMGC();
			}
		}
	}
}
