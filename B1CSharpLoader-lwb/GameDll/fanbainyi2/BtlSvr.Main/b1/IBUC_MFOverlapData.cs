using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_MFOverlapData
{
	EMagicFieldOverlapType OverlapType { get; }

	bool bNeedAvoid { get; }

	UPrimitiveComponent OverlapComp { get; }

	List<FFieldBuffInfo> FieldBuffList { get; }

	HashSet<AActor> InnerActorList_AlreadyTriggerOverlapBegin { get; }

	List<MFEventForData> GetEnterEvents();

	List<MFEventForData> GetExitEvents();

	bool IsActorInnerRange(AActor InActor);
}
