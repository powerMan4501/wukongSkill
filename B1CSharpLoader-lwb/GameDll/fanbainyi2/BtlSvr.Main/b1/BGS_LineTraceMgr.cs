using System.Collections.Generic;
using b1.CppExport;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_LineTraceMgr : GameStateSystemBase
{
	private Dictionary<int, Del_OnAsyncLineTraceFinish> CallBackMap = new Dictionary<int, Del_OnAsyncLineTraceFinish>();

	private TStrongObjectPtr<UBGUAsyncLineTraceObject> mAsyncLineTraceObject { get; set; }

	private UBGUAsyncLineTraceObject AsyncLineTraceObject
	{
		get
		{
			return mAsyncLineTraceObject.Get();
		}
		set
		{
			mAsyncLineTraceObject.Set(value);
		}
	}

	private static int UniqueRequestID_Sync { get; set; }

	private static int UniqueRequestID_ASync { get; set; }

	private static object syncObj { get; } = new object();

	public static int RequestNewUniqueID_Async()
	{
		lock (syncObj)
		{
			if (UniqueRequestID_ASync == int.MinValue)
			{
				UniqueRequestID_ASync = -1;
			}
			else
			{
				UniqueRequestID_ASync--;
			}
			return UniqueRequestID_ASync;
		}
	}

	public static int RequestNewUniqueID_Sync()
	{
		if (UniqueRequestID_Sync == int.MaxValue)
		{
			UniqueRequestID_Sync = 1;
		}
		else
		{
			UniqueRequestID_Sync++;
		}
		return UniqueRequestID_Sync;
	}

	public override void OnAttach()
	{
		mAsyncLineTraceObject = new TStrongObjectPtr<UBGUAsyncLineTraceObject>();
		AsyncLineTraceObject = UObject.NewObject<UBGUAsyncLineTraceObject>(Owner);
		base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByObjectTypeSingle += new Del_RequestAsyncLineTrace_ByObjectTypeSingle(RequestAsyncLineTrace_ByObjectTypeSingle);
		base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByChannelSingle += new Del_RequestAsyncLineTrace_ByChannelSingle(RequestAsyncLineTrace_ByChannelSingle);
		base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByObjectTypeSingle_Batch += new Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch(RequestAsyncLineTrace_ByObjectTypeSingle_Batch);
		base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByChannelSingle_Batch += new Del_RequestAsyncLineTrace_ByChannelSingle_Batch(RequestAsyncLineTrace_ByChannelSingle_Batch);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (AsyncLineTraceObject.GetAndCleanLineTraceResults(out var OutAsyncLineTraceResults) <= 0)
		{
			return;
		}
		foreach (FAsyncLineTraceSingleResult item in OutAsyncLineTraceResults)
		{
			int reqID = item.ReqID;
			List<FHitResult> hitResults = item.HitResults;
			if (reqID != 0 && CallBackMap.TryGetValue(reqID, out var value))
			{
				Result_LineTrace result = new Result_LineTrace(reqID, hitResults);
				value?.Invoke(result);
				CallBackMap.Remove(reqID);
			}
		}
	}

	private void RequestAsyncLineTrace_ByObjectTypeSingle(int ReqID, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		if (!(AsyncLineTraceObject == null))
		{
			LineTraceFuncLib.RequestAsyncLineTraceByObjectTypeSingle(AsyncLineTraceObject, ReqID, Start, End, ObjectTypes, Ingnores, bTraceComplex, bDebug);
			CallBackMap.Add(ReqID, _OnLineTraceFinishCallBack);
		}
	}

	private void RequestAsyncLineTrace_ByChannelSingle(int ReqID, FVector Start, FVector End, ECollisionChannel CollisionChannel, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		if (!(AsyncLineTraceObject == null))
		{
			LineTraceFuncLib.RequestAsyncLineTraceByChannelSingle(AsyncLineTraceObject, ReqID, Start, End, CollisionChannel, Ingnores, bTraceComplex, bDebug);
			CallBackMap.Add(ReqID, _OnLineTraceFinishCallBack);
		}
	}

	private void RequestAsyncLineTrace_ByObjectTypeSingle_Batch(in AsyncLineTraceReqRef ReqRef, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		if (AsyncLineTraceObject == null)
		{
			return;
		}
		foreach (int item in ReqRef.GetAllReqID())
		{
			CallBackMap[item] = _OnLineTraceFinishCallBack;
		}
		LineTraceFuncLib.RequestAsyncLineTraceByObjectTypeSingle_Batch(AsyncLineTraceObject, ReqRef.GetPtr(), ObjectTypes, Ingnores, bTraceComplex, bDebug);
	}

	private void RequestAsyncLineTrace_ByChannelSingle_Batch(in AsyncLineTraceReqRef ReqRef, ECollisionChannel CollisionChannel, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		if (AsyncLineTraceObject == null)
		{
			return;
		}
		foreach (int item in ReqRef)
		{
			CallBackMap[item] = _OnLineTraceFinishCallBack;
		}
		LineTraceFuncLib.RequestAsyncLineTraceByChannelSingle_Batch(AsyncLineTraceObject, ReqRef.GetPtr(), CollisionChannel, Ingnores, bTraceComplex, bDebug);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		AsyncLineTraceObject = null;
	}
}
