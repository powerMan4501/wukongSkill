using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetCurveMoveInfo(UCurveFloat MoveCurveXAxis, UCurveFloat MoveCurveZAxis, EBGUMoveCurveType MoveCurveType, FVector CurveMoveDirInfo, float CurveMoveTotalTime, bool bAutoResetMovementMode, bool EnableCurveMove = true, bool bShouldClearVelocityOnEnd = false);
