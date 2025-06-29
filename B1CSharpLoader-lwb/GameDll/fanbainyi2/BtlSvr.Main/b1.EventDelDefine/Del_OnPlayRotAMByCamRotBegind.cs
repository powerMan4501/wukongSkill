using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_OnPlayRotAMByCamRotBegind(UAnimMontage TurnR_AM, UAnimMontage TurnL_AM, float BlendInTime, float BlendOutTime, float AngleThreshold, float TurnSpd, float RotateWithCamSpeed, ERotTypeInSmallAngle RotTypeInSmallAngle, ERotTypeInLargeAngle RotTypeInLargeAngle);
