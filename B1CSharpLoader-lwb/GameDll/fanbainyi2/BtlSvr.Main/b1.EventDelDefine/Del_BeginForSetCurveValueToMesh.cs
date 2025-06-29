using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BeginForSetCurveValueToMesh(int NotifyInstID, TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList, bool NotApplyToChrMesh, TArrayReadWrite<int> MatIndexList, bool BothWeapons, TArrayReadWrite<int> WeaponIndexList, TArrayReadWrite<int> WeaponMatIndexList, bool BothChildSkeltalMeshes, TArrayReadWrite<FName> ChildSKMeshTagList, TArrayReadWrite<int> ChildSKMatIndexList, bool BothChildActor, TArrayReadWrite<int> ChildActorMeshMatIndexList, float TotalDuration, bool bFitRealTime);
