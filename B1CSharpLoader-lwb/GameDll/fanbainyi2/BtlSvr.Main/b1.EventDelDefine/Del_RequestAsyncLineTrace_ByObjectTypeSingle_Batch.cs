using System.Collections.Generic;
using b1.CppExport;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch(in AsyncLineTraceReqRef ReqRef, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false);
