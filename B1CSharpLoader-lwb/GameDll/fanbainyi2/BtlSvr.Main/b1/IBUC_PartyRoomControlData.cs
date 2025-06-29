using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_PartyRoomControlData
{
	Dictionary<string, AActor> PlayerAIDict { get; }

	string SelfMemberId { get; }
}
