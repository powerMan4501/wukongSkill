using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PoleDrinkStateBegin(UAnimMontage SuccessAM, UAnimMontage FailedAM, TMapReadWrite<int, UAnimMontage> UseItemAMMapping);
