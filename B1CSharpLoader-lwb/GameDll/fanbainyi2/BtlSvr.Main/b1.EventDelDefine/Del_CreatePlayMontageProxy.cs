using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate bool Del_CreatePlayMontageProxy(EMontageBindReason Reason, USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPaly, float PlayRate, float StartingPosition, FName StartingSection);
