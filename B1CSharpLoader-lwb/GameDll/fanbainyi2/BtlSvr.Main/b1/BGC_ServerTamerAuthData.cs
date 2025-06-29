using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BGC_ServerTamerAuthData : IBGC_ServerTamerAuthData, IPersistentECSData
{
	public Dictionary<long, ServerTamerAuthInfo> ActiveTamerAuthInfoNetGuidMap = new Dictionary<long, ServerTamerAuthInfo>();

	public Dictionary<string, ServerTamerAuthInfo> ActiveTamerAuthInfoTamerGuidMap = new Dictionary<string, ServerTamerAuthInfo>();

	public List<ServerTamerAuthInfo> ChannelToCloseWaitingOpenAcked = new List<ServerTamerAuthInfo>();

	protected Dictionary<string, HashSet<FTamerRef>> ActiveTamersInServer = new Dictionary<string, HashSet<FTamerRef>>();

	public HashSet<FTamerRef> GetOrAllocActiveTamersInServer(string PlayerName)
	{
		if (!ActiveTamersInServer.TryGetValue(PlayerName, out var value))
		{
			value = new HashSet<FTamerRef>();
			ActiveTamersInServer[PlayerName] = value;
		}
		return value;
	}

	public EServerTamerAuthState GetServerTamerAuthState(string TamerGuid)
	{
		if (ActiveTamerAuthInfoTamerGuidMap.TryGetValue(TamerGuid, out var value))
		{
			return value.AuthState;
		}
		return EServerTamerAuthState.UnKnow;
	}

	public APlayerController GetServerTamerAuthPlayer(string TamerGuid)
	{
		if (ActiveTamerAuthInfoTamerGuidMap.TryGetValue(TamerGuid, out var value))
		{
			return value.AuthPlayer;
		}
		return null;
	}
}
