using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PartyRoomControlData : b1.IBUC_PartyRoomControlData, IPersistentECSData
{
	public Dictionary<string, AActor> PlayerAIDict { get; set; }

	public string SelfMemberId { get; set; }

	public float MsgDelay { get; set; }

	public BUC_PartyRoomControlData()
	{
		PlayerAIDict = new Dictionary<string, AActor>();
		SelfMemberId = "";
	}

	public void ReSet()
	{
		PlayerAIDict = new Dictionary<string, AActor>();
		SelfMemberId = "";
	}

	public BGP_AIPlayerControllerCS GetControllerByUniqueNetId(string UniqueNetId)
	{
		PlayerAIDict.TryGetValue(UniqueNetId, out var value);
		if (value != null)
		{
			ABGUCharacter obj = value as ABGUCharacter;
			AController instigatorController = value.GetInstigatorController();
			obj.GetController();
			return instigatorController as BGP_AIPlayerControllerCS;
		}
		return null;
	}

	public AActor GetActorByUniqueNetId(string UniqueNetId)
	{
		PlayerAIDict.TryGetValue(UniqueNetId, out var value);
		if (value != null)
		{
			return value;
		}
		return null;
	}

	public void SetPlayerAIDict(Dictionary<string, AActor> _PlayerAIDict)
	{
		PlayerAIDict = _PlayerAIDict;
	}
}
