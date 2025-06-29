using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PrepareCameraSequenceActor(FGSCameraSequenceData CameraSequenceData, ref FTransform StartTransform, bool IsSeqAttachToActor = false);
