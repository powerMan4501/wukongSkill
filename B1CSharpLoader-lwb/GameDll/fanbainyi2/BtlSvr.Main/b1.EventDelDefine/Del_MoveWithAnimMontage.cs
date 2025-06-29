using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_MoveWithAnimMontage(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default);
