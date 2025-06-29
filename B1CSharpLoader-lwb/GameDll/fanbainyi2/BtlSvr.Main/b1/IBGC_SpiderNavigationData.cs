using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_SpiderNavigationData
{
	List<FSpiderNavPointInfo> TryFindPath(FVector StartPos, ESpiderNavPositionType StartPosType, FVector TargetPos, FVector TargetPosNormal, ESpiderNavPositionType TargetPosType);
}
