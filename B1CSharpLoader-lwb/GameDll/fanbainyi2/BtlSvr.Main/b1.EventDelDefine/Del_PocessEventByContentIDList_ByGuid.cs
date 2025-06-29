using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_PocessEventByContentIDList_ByGuid(string SourceLog, string UnitGuid, List<int> ConversationContentIDList, uint ConversationChain_RootID = 0u);
