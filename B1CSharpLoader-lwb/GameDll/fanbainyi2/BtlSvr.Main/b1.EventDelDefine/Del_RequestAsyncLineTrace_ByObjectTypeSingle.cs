using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_RequestAsyncLineTrace_ByObjectTypeSingle(int ReqID, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false);
