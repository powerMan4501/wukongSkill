using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp")]
internal class BUS_AIRequestManageComp : UActorCompBaseUObj
{
	private BUC_AIRequestManageData AIRequestManageData;

	private b1.BasicActionBase ActiveBATemplate;

	private static bool DirectionMove_IsValid;

	private static int DirectionMove_Offset;

	private static bool RootMotionMove_IsValid;

	private static int RootMotionMove_Offset;

	private static bool DirectionDamage_IsValid;

	private static int DirectionDamage_Offset;

	private static bool TraceMove_IsValid;

	private static int TraceMove_Offset;

	private static bool MoveSkill_IsValid;

	private static int MoveSkill_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionMove")]
	private b1.BADirectionMove DirectionMove
	{
		get
		{
			CheckDestroyed();
			if (!DirectionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionMove");
				return null;
			}
			return UObjectMarshaler<b1.BADirectionMove>.FromNative(IntPtr.Add(base.Address, DirectionMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionMove");
			}
			else
			{
				UObjectMarshaler<b1.BADirectionMove>.ToNative(IntPtr.Add(base.Address, DirectionMove_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp:RootMotionMove")]
	private b1.BARootMotionMove RootMotionMove
	{
		get
		{
			CheckDestroyed();
			if (!RootMotionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:RootMotionMove");
				return null;
			}
			return UObjectMarshaler<b1.BARootMotionMove>.FromNative(IntPtr.Add(base.Address, RootMotionMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootMotionMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:RootMotionMove");
			}
			else
			{
				UObjectMarshaler<b1.BARootMotionMove>.ToNative(IntPtr.Add(base.Address, RootMotionMove_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionDamage")]
	private b1.BADirectionDamage DirectionDamage
	{
		get
		{
			CheckDestroyed();
			if (!DirectionDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionDamage");
				return null;
			}
			return UObjectMarshaler<b1.BADirectionDamage>.FromNative(IntPtr.Add(base.Address, DirectionDamage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:DirectionDamage");
			}
			else
			{
				UObjectMarshaler<b1.BADirectionDamage>.ToNative(IntPtr.Add(base.Address, DirectionDamage_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp:TraceMove")]
	private b1.BATraceMove TraceMove
	{
		get
		{
			CheckDestroyed();
			if (!TraceMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:TraceMove");
				return null;
			}
			return UObjectMarshaler<b1.BATraceMove>.FromNative(IntPtr.Add(base.Address, TraceMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:TraceMove");
			}
			else
			{
				UObjectMarshaler<b1.BATraceMove>.ToNative(IntPtr.Add(base.Address, TraceMove_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AIRequestManageComp:MoveSkill")]
	private b1.BAMoveSkill MoveSkill
	{
		get
		{
			CheckDestroyed();
			if (!MoveSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:MoveSkill");
				return null;
			}
			return UObjectMarshaler<b1.BAMoveSkill>.FromNative(IntPtr.Add(base.Address, MoveSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AIRequestManageComp:MoveSkill");
			}
			else
			{
				UObjectMarshaler<b1.BAMoveSkill>.ToNative(IntPtr.Add(base.Address, MoveSkill_Offset), value);
			}
		}
	}

	public override void OnAttach()
	{
		AIRequestManageData = RequireWritableData<BUC_AIRequestManageData>();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		bUS_GSEventCollection.Evt_OnExecuteBaseAction += new Del_OnExecuteBaseAction(ExecuteBasicAction);
		bUS_GSEventCollection.Evt_OnCreateRequest += new Del_OnCreateRequest(AddCachedAIRequest);
		bUS_GSEventCollection.Evt_OnExitThink += new Del_Void(OnExitThink);
		bUS_GSEventCollection.Evt_OnActiveCurThink += new Del_Void(OnActiveCurThink);
		bUS_GSEventCollection.Evt_OnBasicActionFinish += new Del_OnBasicActionFinish(OnBasicActionFinish);
		bUS_GSEventCollection.Evt_OnBasicActionFailed += new Del_OnBasicActionFailed(OnBasicActionFailed);
		bUS_GSEventCollection.Evt_OnInitThink += new Del_OnInitThink(OnInitThink);
		bUS_GSEventCollection.Evt_OnExitActiveThink += new Del_Void(OnExitActiveThink);
		bUS_GSEventCollection.Evt_OnBasicActionAborted += new Del_Void(OnBasicActionAborted);
	}

	public override void PreBeginPlay()
	{
		AIRequestManageData.Init();
		AIRequestManageData.SetLastActionState(EAIBasicActionState.None);
		DirectionMove = UObject.NewObject<b1.BADirectionMove>();
		RootMotionMove = UObject.NewObject<b1.BARootMotionMove>();
		DirectionDamage = UObject.NewObject<b1.BADirectionDamage>();
		TraceMove = UObject.NewObject<b1.BATraceMove>();
		MoveSkill = UObject.NewObject<b1.BAMoveSkill>();
	}

	private void OnBasicActionAborted()
	{
		ActiveBATemplate.ExecuteAbort();
	}

	private void OnActiveCurThink()
	{
		AIRequestManageData.AIRequestList.Clear();
		foreach (TStrongObjectPtr<AIRequestBase> cachedRequest in AIRequestManageData.CachedRequestList)
		{
			AIRequestManageData.AIRequestList.Add(cachedRequest);
		}
	}

	private void OnExitActiveThink()
	{
		ActiveBATemplate = null;
		SetLastActionState(EAIBasicActionState.None);
		ClearReqList();
	}

	private void OnExitThink()
	{
	}

	private void OnInitThink(string ThinkName, int BAToTestNum)
	{
		ClearCachedReqList();
	}

	private void OnBasicActionFinish(EAIBasicActionState BasicActionState)
	{
		ActiveBATemplate = null;
		UpdateReqList();
		SetLastActionState(BasicActionState);
	}

	private void OnBasicActionFailed(EAIBasicActionState BasicActionState)
	{
		ActiveBATemplate = null;
		SetLastActionState(BasicActionState);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public void DrawRequestDebug()
	{
		if (AIRequestManageData.AIRequestList.Count != 0)
		{
			AIRequestBase aIRequestBase = AIRequestManageData.AIRequestList[0].Get();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			if (!aIRequestBase.FeatureActor.IsNullOrDestroyed())
			{
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aIRequestBase.FeatureActor);
				USystemLibrary.DrawDebugArrow(this, fVector, fVector2, FVector.Dist(fVector, fVector2), FLinearColor.Green);
			}
			if (!aIRequestBase.SelectedPoint.IsZero())
			{
				USystemLibrary.DrawDebugArrow(this, fVector, aIRequestBase.SelectedPoint, FVector.Dist(fVector, aIRequestBase.SelectedPoint), FLinearColor.Blue);
			}
		}
	}

	public void TestCurRequestList()
	{
		if (AIRequestManageData.AIRequestList.Count == 0)
		{
			return;
		}
		AIRequestBase aIRequestBase = AIRequestManageData.AIRequestList[0].Get();
		if (!aIRequestBase.FeatureActor.IsNullOrDestroyed())
		{
			AActor SelectedActor;
			ERequestTestResult eRequestTestResult = AIFuncLibForCS.RequestFeatureTest(aIRequestBase, GetOwner(), out SelectedActor);
			if (eRequestTestResult == ERequestTestResult.FeatureNotFound || eRequestTestResult == ERequestTestResult.SelectFaild)
			{
				TryAbortCurThink();
			}
			if (eRequestTestResult == ERequestTestResult.SelectSuccess && SelectedActor != aIRequestBase.FeatureActor)
			{
				TryAbortCurThink();
			}
		}
		if (!aIRequestBase.SelectedPoint.IsZero() && AIFuncLibForCS.CheckPointsByTests(new List<FVector> { aIRequestBase.SelectedPoint }, null, aIRequestBase.PointTestInfo, GetOwner(), aIRequestBase.FeatureActor, aIRequestBase.AIRequestType).Count == 0)
		{
			TryAbortCurThink();
		}
	}

	public void TryAbortCurThink()
	{
		AIRequestManageData.LastActionState = EAIBasicActionState.WaitingAbort;
	}

	public void UpdateReqList()
	{
		if (AIRequestManageData.AIRequestList[0].Get().IsFinish())
		{
			AIRequestManageData.AIRequestList.RemoveAt(0);
		}
		if (AIRequestManageData.AIRequestList.Count == 0)
		{
			IBUC_AIAttentionData iBUC_AIAttentionData = RequireReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
			bUS_GSEventCollection.Evt_OnExitThink.Invoke();
			if (iBUC_AIAttentionData.GetCurThinkInfo().ActiveThinkName == iBUC_AIAttentionData.GetCurThinkInfo().CurThinkName)
			{
				bUS_GSEventCollection.Evt_OnExitActiveThink.Invoke();
			}
		}
	}

	private void SetLastActionState(EAIBasicActionState BAState)
	{
		AIRequestManageData.SetLastActionState(BAState);
	}

	private void ExecuteBasicAction(EAIBasicActionType BasicActionType)
	{
		if (AIRequestManageData.LastActionState == EAIBasicActionState.WaitingAbort)
		{
			SetLastActionState(EAIBasicActionState.Aborted);
			return;
		}
		FCurThinkInfo curThinkInfo = RequireReadOnlyData<IBUC_AIAttentionData, BUC_AIAttentionData>().GetCurThinkInfo();
		AIRequestBase aIRequestBase;
		bool flag;
		if (curThinkInfo.ActiveThinkName == curThinkInfo.CurThinkName)
		{
			aIRequestBase = AIRequestManageData.GetActiveAIRequest();
			flag = false;
		}
		else
		{
			aIRequestBase = AIRequestManageData.GetCachedAIRequest();
			flag = true;
		}
		if (aIRequestBase == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.RequestNoFound);
			return;
		}
		ACharacter character = GetOwner() as ACharacter;
		switch (BasicActionType)
		{
		case EAIBasicActionType.DirectionMove:
			ActiveBATemplate = DirectionMove;
			break;
		case EAIBasicActionType.RootMotionMove:
			ActiveBATemplate = RootMotionMove;
			break;
		case EAIBasicActionType.DirectionDamage:
			ActiveBATemplate = DirectionDamage;
			break;
		case EAIBasicActionType.TraceMove:
			ActiveBATemplate = TraceMove;
			break;
		case EAIBasicActionType.MoveSkill:
			ActiveBATemplate = MoveSkill;
			break;
		}
		ActiveBATemplate.StartExecute(character, aIRequestBase);
		if (AIRequestManageData.GetLastActionState() == EAIBasicActionState.Executing && flag)
		{
			BUS_EventCollectionCS.Get(this).Evt_OnActiveCurThink.Invoke();
		}
	}

	private void AddCachedAIRequest(AIRequestBase Request)
	{
		AIRequestManageData.CachedRequestList.Add(new TStrongObjectPtr<AIRequestBase>(Request));
	}

	private void ClearCachedReqList()
	{
		AIRequestManageData.CachedRequestList.Clear();
	}

	private void ClearReqList()
	{
		AIRequestManageData.AIRequestList.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AIRequestManageComp");
		DirectionMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionMove");
		DirectionMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionMove", Classes.FObjectProperty);
		RootMotionMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RootMotionMove");
		RootMotionMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RootMotionMove", Classes.FObjectProperty);
		DirectionDamage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionDamage");
		DirectionDamage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionDamage", Classes.FObjectProperty);
		TraceMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceMove");
		TraceMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceMove", Classes.FObjectProperty);
		MoveSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSkill");
		MoveSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSkill", Classes.FObjectProperty);
	}

	static BUS_AIRequestManageComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AIRequestManageComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AIRequestManageComp));
	}
}
