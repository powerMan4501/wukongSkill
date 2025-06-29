using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_PocessEventByContentIDList(string SourceLog, AActor Caster, List<int> ConversationContentIDList, uint ConversationChain_RootID = 0u);
