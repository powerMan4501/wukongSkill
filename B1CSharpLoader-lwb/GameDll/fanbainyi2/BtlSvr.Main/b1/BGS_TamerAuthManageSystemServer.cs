using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_TamerAuthManageSystemServer : GameModeSystemBase
{
	private BGC_ServerTamerAuthData TamerAuthData;

	private BGC_TamerData TamerData;

	private static EServerTamerAuthState[] INVALID_AUTH_SWITCH_STATE = new EServerTamerAuthState[4]
	{
		EServerTamerAuthState.ClientFirstAuth,
		EServerTamerAuthState.AuthSwitchWaitingOldAuthChannelCleanUp,
		EServerTamerAuthState.AuthSwitchWaitingOldSimulateChannelCleanUp,
		EServerTamerAuthState.ClientAuthWaitingNewChannelReady
	};

	public override void OnAttach()
	{
		base.OnAttach();
		TamerAuthData = RequireWritableData<BGC_ServerTamerAuthData>();
		TamerData = RequireWritableGameStateData<BGC_TamerData>();
		GetGameEventCollection().Evt_BGS_OnPlayerLogOut += new Del_OnPlayerLogOut(OnPlayerLogOut);
		GetGameEventCollection().Evt_BGS_ActorChannelCleanUp += new Del_ActorChannelCleanUp(OnActorChannelCleanUp);
		GetGameEventCollection().Evt_BGS_ActorChannelOpen += new Del_ActorChannelOpen(OnActorChannelOpen);
		GetGameEventCollection().Evt_BGS_RegisterTamerAuthInfo += new Del_RegisterTamerAuthInfo(RegisterTamerAuthInfo);
		GetGameEventCollection().Evt_BGS_UnRegisterTamerAuthInfo += new Del_UnRegisterTamerAuthInfo(UnRegisterTamerAuthInfo);
		GetGameEventCollection().Evt_BGS_PreBGUCharacterDeadDestroy += new Del_Void_Actor(OnBGUCharacterDeadDestroy);
	}

	private void OnBGUCharacterDeadDestroy(AActor Actor)
	{
	}

	private void OnActorChannelOpen(AActor Actor, APlayerController PlayerController)
	{
		BGU_CharacterAI bGU_CharacterAI = Actor as BGU_CharacterAI;
		if (!(bGU_CharacterAI != null))
		{
			return;
		}
		BUTamerActor bUTamerActor = bGU_CharacterAI.GetTamerOwner() as BUTamerActor;
		if (!(bUTamerActor != null))
		{
			return;
		}
		long objNetGuid = UGSE_OnlineFuncLib.GetObjNetGuid(bGU_CharacterAI);
		if (!TamerAuthData.ActiveTamerAuthInfoNetGuidMap.TryGetValue(objNetGuid, out var value))
		{
			string finalGuid = bUTamerActor.GetFinalGuid();
			GSEUtil.Check(TamerAuthData.ActiveTamerAuthInfoTamerGuidMap.TryGetValue(finalGuid, out value));
			GSEUtil.Check(value.AuthState == EServerTamerAuthState.ClientFirstAuth);
			value.MonsterNetGUID = objNetGuid;
			TamerAuthData.ActiveTamerAuthInfoNetGuidMap.Add(objNetGuid, value);
			bGU_CharacterAI.FreshNetRole(HasAuthority: false);
		}
		if (value != null && value.AuthPlayer == PlayerController)
		{
			GSEUtil.Check(value.AuthState == EServerTamerAuthState.ClientAuthWaitingNewChannelReady || value.AuthState == EServerTamerAuthState.ClientFirstAuth, $"OnActorChannelOpenFinish AuthInfo.AuthState:{value.AuthState} UnExpected!!!");
			GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(value.TamerGUID, out var value2), "OnActorChannelCleanUp GUID:" + value.TamerGUID + " TamerRef Not Found!!!");
			if (value.AuthState == EServerTamerAuthState.ClientAuthWaitingNewChannelReady)
			{
				value.AuthState = EServerTamerAuthState.ClientAuthConfirmed;
				value2.ClientAuthChannelOpenedOnServer();
			}
			else
			{
				ClientAuthCloseOldSimulateChannel(value);
			}
		}
	}

	private void OnActorChannelCleanUp(long ActorNetGUID, APlayerController PlayerController, EChannelCloseReason CloseReason)
	{
		if (!TamerAuthData.ActiveTamerAuthInfoNetGuidMap.TryGetValue(ActorNetGUID, out var value))
		{
			return;
		}
		if (value.AuthPlayer == PlayerController)
		{
			if (value.AuthState == EServerTamerAuthState.AuthSwitchWaitingOldSimulateChannelCleanUp)
			{
				ClientAuthCreateClientAuthChannel(value);
			}
			else if (value.AuthState == EServerTamerAuthState.ClientAuthUnRegisterWaitingChannelClose)
			{
				APlayerController authPlayer = value.AuthPlayer;
				value.AuthPlayer = null;
				UpdateAuthPlayer(value, FromUnRegister: true);
				UpdateTamerStrategy(value, authPlayer);
				if (value.AuthPlayer == null)
				{
					ClearTamerAuthInfo(value);
				}
			}
		}
		else if (value.AuthState == EServerTamerAuthState.AuthSwitchWaitingOldAuthChannelCleanUp && value.LastAuthPlayerWaitingChannelCleanUp == PlayerController)
		{
			ClientAuthCloseOldSimulateChannel(value);
			value.LastAuthPlayerWaitingChannelCleanUp = null;
		}
	}

	private void ClientAuthCreateClientAuthChannel(ServerTamerAuthInfo AuthInfo)
	{
		AuthInfo.AuthState = EServerTamerAuthState.ClientAuthWaitingNewChannelReady;
		UB1NetReplicationGraphConnection replicationGraphConnectionByPC = (UGSE_OnlineFuncLib.GetReplicationGraph(GetOwner()) as B1ReplicationGraphCS).GetReplicationGraphConnectionByPC(AuthInfo.AuthPlayer);
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(AuthInfo.TamerGUID, out var value), "OnActorChannelCleanUp GUID:" + AuthInfo.TamerGUID + " TamerRef Not Found!!!");
		replicationGraphConnectionByPC.GSAddB1ActorChannel(value.MonsterInstancePtr.Get());
	}

	private void ClientAuthCloseOldSimulateChannel(ServerTamerAuthInfo AuthInfo)
	{
		AuthInfo.AuthState = EServerTamerAuthState.AuthSwitchWaitingOldSimulateChannelCleanUp;
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(AuthInfo.TamerGUID, out var value), "ClientAuthCloseOldSimulateChannel TamerGUID:" + AuthInfo.TamerGUID + " TamerRef Not Found!!!");
		if (UGSE_OnlineFuncLib.ActorChannelOpenAcked(value.MonsterInstancePtr.Get(), AuthInfo.AuthPlayer))
		{
			CloseAuthPlayerOldSimulateChannel(value.MonsterInstancePtr.Get(), AuthInfo);
		}
		else
		{
			TamerAuthData.ChannelToCloseWaitingOpenAcked.Add(AuthInfo);
		}
	}

	private void CloseAuthPlayerOldSimulateChannel(BGUCharacterCS Character, ServerTamerAuthInfo AuthInfo)
	{
		UGSE_OnlineFuncLib.ServerReplicateOneActorToPlayer(Character, AuthInfo.AuthPlayer);
		GSEUtil.Check(UGSE_OnlineFuncLib.CloseActorChannelByActorAndPlayerController(Character, AuthInfo.AuthPlayer, 6), "ClientAuthCloseOldSimulateChannel TamerGUID:" + AuthInfo.TamerGUID + " Old Channel Not Found!!!");
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int num = TamerAuthData.ChannelToCloseWaitingOpenAcked.Count - 1; num >= 0; num--)
		{
			ServerTamerAuthInfo serverTamerAuthInfo = TamerAuthData.ChannelToCloseWaitingOpenAcked[num];
			if (TamerData.UnitGuid2Tamer.TryGetValue(serverTamerAuthInfo.TamerGUID, out var value) && (serverTamerAuthInfo.AuthPlayer == null || UGSE_OnlineFuncLib.ActorChannelOpenAcked(value.MonsterInstancePtr.Get(), serverTamerAuthInfo.AuthPlayer)))
			{
				TamerAuthData.ChannelToCloseWaitingOpenAcked.RemoveAt(num);
				CloseAuthPlayerOldSimulateChannel(value.MonsterInstancePtr.Get(), serverTamerAuthInfo);
			}
		}
	}

	private void UpdateTamerStrategy(ServerTamerAuthInfo AuthInfo, APlayerController OldAuthPlayer)
	{
		if (AuthInfo.AuthPlayer == OldAuthPlayer || AuthInfo.AuthPlayer == null)
		{
			return;
		}
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(AuthInfo.TamerGUID, out var value));
		if (value == null)
		{
			return;
		}
		GSEUtil.Check(TamerData.TamerStrategyMap.TryGetValue(value.TamerType, out var value2));
		if (value2 == null)
		{
			return;
		}
		if (OldAuthPlayer != null && !OldAuthPlayer.IsLocalPlayerController())
		{
			TamerData.GetRemotePlayerTamerStrategy(OldAuthPlayer.GetFullName())?.RemoveTamerWithoutPostRemoveTamer(value);
		}
		else if (AuthInfo.AuthPlayer != null)
		{
			value2.RemoveTamerWithoutPostRemoveTamer(value);
		}
		bool hasAuthority = true;
		if (AuthInfo.AuthPlayer != null)
		{
			if (!AuthInfo.AuthPlayer.IsLocalPlayerController())
			{
				TamerData.GetRemotePlayerTamerStrategy(AuthInfo.AuthPlayer.GetFullName()).AddTamer(value);
				hasAuthority = false;
			}
			else
			{
				value2.AddTamer(value);
			}
		}
		else if (!value2.ContainsTamer(value))
		{
			value2.AddTamer(value);
		}
		if (value.MonsterInstancePtr.IsValid() && value.Phase > ETamerPhase.Visible)
		{
			value.MonsterInstancePtr.Get().FreshNetRole(hasAuthority);
		}
	}

	private void RegisterTamerAuthInfo(string TamerGUID, APlayerController PlayerController)
	{
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(TamerGUID, out var value));
		TamerAuthData.GetOrAllocActiveTamersInServer(PlayerController.GetName()).Add(value);
		if (!TamerAuthData.ActiveTamerAuthInfoTamerGuidMap.TryGetValue(TamerGUID, out var value2))
		{
			value2 = new ServerTamerAuthInfo();
			value2.AuthPlayer = PlayerController;
			value2.TamerGUID = TamerGUID;
			if (value.Phase != ETamerPhase.Loaded && value.Phase != ETamerPhase.UnLoaded)
			{
				long key = (value2.MonsterNetGUID = UGSE_OnlineFuncLib.GetObjNetGuid(value.MonsterInstancePtr.Get()));
				TamerAuthData.ActiveTamerAuthInfoNetGuidMap.Add(key, value2);
			}
			UpdateTamerStrategy(value2, null);
			TamerAuthData.ActiveTamerAuthInfoTamerGuidMap.Add(TamerGUID, value2);
			if (PlayerController.IsLocalPlayerController())
			{
				value2.AuthState = EServerTamerAuthState.ServerAuthConfirmed;
				return;
			}
			GSEUtil.Check(value.Phase == ETamerPhase.Loaded);
			value2.AuthState = EServerTamerAuthState.ClientFirstAuth;
		}
		else if (!value2.SimulatePlayers.Contains(PlayerController))
		{
			value2.SimulatePlayers.Add(PlayerController);
		}
	}

	private bool UnRegisterTamerAuthInfo(string TamerGuid, APlayerController PlayerController)
	{
		if (!TamerAuthData.ActiveTamerAuthInfoTamerGuidMap.TryGetValue(TamerGuid, out var value))
		{
			return false;
		}
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(TamerGuid, out var value2));
		TamerAuthData.GetOrAllocActiveTamersInServer(PlayerController.GetName()).Remove(value2);
		value.SimulatePlayers.Remove(PlayerController);
		if (value.AuthPlayer == PlayerController)
		{
			TamerAuthData.ChannelToCloseWaitingOpenAcked.Remove(value);
			if (!PlayerController.IsLocalController())
			{
				UGSE_OnlineFuncLib.CloseActorChannelByActorAndPlayerController(value2.MonsterInstancePtr.Get(), PlayerController, 3);
				value.AuthState = EServerTamerAuthState.ClientAuthUnRegisterWaitingChannelClose;
			}
			else
			{
				APlayerController authPlayer = value.AuthPlayer;
				value.AuthPlayer = null;
				UpdateAuthPlayer(value, FromUnRegister: true);
				UpdateTamerStrategy(value, authPlayer);
				if (value.AuthPlayer == null)
				{
					ClearTamerAuthInfo(value);
				}
			}
		}
		else
		{
			value.SimulatePlayers.Remove(PlayerController);
		}
		return value.AuthPlayer != null;
	}

	private void ClearTamerAuthInfo(ServerTamerAuthInfo AuthInfo)
	{
		TamerAuthData.ActiveTamerAuthInfoNetGuidMap.Remove(AuthInfo.MonsterNetGUID);
		TamerAuthData.ActiveTamerAuthInfoTamerGuidMap.Remove(AuthInfo.TamerGUID);
	}

	private void UpdateAuthPlayer(ServerTamerAuthInfo AuthInfo, bool FromUnRegister)
	{
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(AuthInfo.TamerGUID, out var value), "OnSwitchAuthPlayer TamerGUID:" + AuthInfo.TamerGUID + " TamerRef Not Found!!!");
		if (!FromUnRegister && (value.Phase != ETamerPhase.Spawned || INVALID_AUTH_SWITCH_STATE.Contains(AuthInfo.AuthState)))
		{
			return;
		}
		APlayerController authPlayer = AuthInfo.AuthPlayer;
		AuthInfo.AuthPlayer = ReSelectBestAuthPlayer(AuthInfo, value.MonsterInstancePtr.Get());
		if (!FromUnRegister)
		{
			UpdateTamerStrategy(AuthInfo, authPlayer);
		}
		if (AuthInfo.AuthPlayer != authPlayer)
		{
			AuthInfo.SimulatePlayers.Remove(AuthInfo.AuthPlayer);
			if (authPlayer != null)
			{
				AuthInfo.SimulatePlayers.Add(authPlayer);
			}
			if (authPlayer != null && !authPlayer.IsLocalController())
			{
				UGSE_OnlineFuncLib.CloseActorChannelByActorAndPlayerController(value.MonsterInstancePtr.Get(), authPlayer, 5);
				AuthInfo.LastAuthPlayerWaitingChannelCleanUp = authPlayer;
				AuthInfo.AuthState = EServerTamerAuthState.AuthSwitchWaitingOldAuthChannelCleanUp;
			}
			else if (!AuthInfo.AuthPlayer.IsLocalController())
			{
				ClientAuthCloseOldSimulateChannel(AuthInfo);
			}
			else
			{
				AuthInfo.AuthState = EServerTamerAuthState.ServerAuthConfirmed;
			}
		}
	}

	private APlayerController ReSelectBestAuthPlayer(ServerTamerAuthInfo AuthInfo, BGUCharacterCS Monster)
	{
		FVector actorLocation = Monster.GetActorLocation();
		APlayerController aPlayerController = AuthInfo.AuthPlayer;
		double num = double.MaxValue;
		if (aPlayerController != null)
		{
			num = aPlayerController.GetControlledPawn().GetActorLocation().Vector_Distance2DSquared(actorLocation);
		}
		for (int i = 0; i < AuthInfo.SimulatePlayers.Count; i++)
		{
			double num2 = AuthInfo.SimulatePlayers[i].GetControlledPawn().GetActorLocation().Vector_Distance2DSquared(actorLocation);
			if (num2 < num)
			{
				num = num2;
				aPlayerController = AuthInfo.SimulatePlayers[i];
			}
		}
		return aPlayerController;
	}

	private void OnPlayerLogOut(AController PlayerController)
	{
		HashSet<FTamerRef> orAllocActiveTamersInServer = TamerAuthData.GetOrAllocActiveTamersInServer(PlayerController.GetName());
		int count = orAllocActiveTamersInServer.Count;
		while (orAllocActiveTamersInServer.Count > 0)
		{
			UnRegisterTamerAuthInfo(orAllocActiveTamersInServer.First().TamerGuid, PlayerController as APlayerController);
			GSEUtil.Check(count > orAllocActiveTamersInServer.Count);
			count = orAllocActiveTamersInServer.Count;
		}
	}
}
