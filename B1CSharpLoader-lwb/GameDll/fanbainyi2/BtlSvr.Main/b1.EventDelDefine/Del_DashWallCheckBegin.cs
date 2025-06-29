using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_DashWallCheckBegin(int NotifyID, TArrayReadWrite<FUStCheckShape> _CheckShapeList, TArrayReadWrite<EObjectTypeQuery> _ObjectTypeList, UAnimMontage HitWallStiffAM, string ValidTag);
