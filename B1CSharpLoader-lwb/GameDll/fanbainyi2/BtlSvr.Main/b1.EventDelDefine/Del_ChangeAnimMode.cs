using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_ChangeAnimMode(EAnimationMode AnimMode, TSubclassOf<UAnimInstance> ABPClass = default(TSubclassOf<UAnimInstance>));
