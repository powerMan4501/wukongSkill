using System.Collections.Generic;
using b1.CppExport;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_RequestAsyncLineTrace_ByChannelSingle_Batch(in AsyncLineTraceReqRef ReqRef, ECollisionChannel CollisionChannel, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false);
