using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct FDashHitWallInfo
{
	public UAnimMontage HitWallStiffAM;

	public List<EObjectTypeQuery> ObjectTypeList;

	public List<FUStCheckShape> CheckShapeList;

	public FName ValidTag;
}
