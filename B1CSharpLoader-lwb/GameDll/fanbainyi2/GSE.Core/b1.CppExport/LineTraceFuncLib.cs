using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public static class LineTraceFuncLib
{
	private static GSE_LineTraceFuncs.Del_RequestAsyncLineTraceByChannelSingleStatic RequestAsyncLineTraceByChannelSingleStaticFunc;

	private static GSE_LineTraceFuncs.Del_RequestAsyncLineTraceByObjectTypeSingleStatic RequestAsyncLineTraceByObjectTypeSingleStaticFunc;

	private static GSE_LineTraceFuncs.Del_RequestAsyncLineTraceByChannelSingleStatic_Batch RequestAsyncLineTraceByChannelSingleStaticBatchFunc;

	private static GSE_LineTraceFuncs.Del_RequestAsyncLineTraceByObjectTypeSingleStatic_Batch RequestAsyncLineTraceByObjectTypeSingleStaticBatchFunc;

	static LineTraceFuncLib()
	{
		new GSE_LineTraceFuncs();
	}

	public static void RequestAsyncLineTraceByObjectTypeSingle(UBGUAsyncLineTraceObject InLineTraceObject, int ReqID, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ignores, bool bTraceComplex, bool bDebug)
	{
		if (Ignores != null && Ignores.Count != 0)
		{
			foreach (AActor Ignore in Ignores)
			{
				InLineTraceObject.IgnoreActors.Add(Ignore);
			}
		}
		RequestAsyncLineTraceByObjectTypeSingleStaticFunc(InLineTraceObject.Address, ReqID, Start, End, ObjectTypes.ToArray(), bTraceComplex, bDebug);
	}

	public static void RequestAsyncLineTraceByChannelSingle(UBGUAsyncLineTraceObject InLineTraceObject, int ReqID, FVector Start, FVector End, ECollisionChannel TraceChannel, List<AActor> Ignores, bool bTraceComplex, bool bDebug)
	{
		if (Ignores != null && Ignores.Count != 0)
		{
			foreach (AActor Ignore in Ignores)
			{
				InLineTraceObject.IgnoreActors.Add(Ignore);
			}
		}
		RequestAsyncLineTraceByChannelSingleStaticFunc(InLineTraceObject.Address, ReqID, Start, End, TraceChannel, bTraceComplex, bDebug);
	}

	public static void RequestAsyncLineTraceByObjectTypeSingle_Batch(UBGUAsyncLineTraceObject InLineTraceObject, IntPtr ReqList, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ignores, bool bTraceComplex, bool bDebug)
	{
		if (Ignores != null && Ignores.Count != 0)
		{
			foreach (AActor Ignore in Ignores)
			{
				InLineTraceObject.IgnoreActors.Add(Ignore);
			}
		}
		RequestAsyncLineTraceByObjectTypeSingleStaticBatchFunc(InLineTraceObject.Address, ReqList, ObjectTypes.ToArray(), bTraceComplex, bDebug);
	}

	public static void RequestAsyncLineTraceByChannelSingle_Batch(UBGUAsyncLineTraceObject InLineTraceObject, IntPtr ReqList, ECollisionChannel TraceChannel, List<AActor> Ignores, bool bTraceComplex, bool bDebug)
	{
		if (Ignores != null && Ignores.Count != 0)
		{
			foreach (AActor Ignore in Ignores)
			{
				InLineTraceObject.IgnoreActors.Add(Ignore);
			}
		}
		RequestAsyncLineTraceByChannelSingleStaticBatchFunc(InLineTraceObject.Address, ReqList, TraceChannel, bTraceComplex, bDebug);
	}
}
