using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BGS_AddCameraShakeWithControl(UMatineeCameraShake CamShakeInst, UCurveFloat CamShakeScaleByDistCurve, FVector EpicenterLoc, float Override_Duration = -1f, bool EpicenterIsAttach = false, FName SocketName = default(FName), AActor EpicenterOwner = null, int ReqID = -1);
