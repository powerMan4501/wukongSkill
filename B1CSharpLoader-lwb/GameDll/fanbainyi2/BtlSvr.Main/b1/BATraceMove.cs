using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BATraceMove")]
internal class BATraceMove : b1.BasicActionBase
{
	private static bool ReqMoveToActor_IsValid;

	private static int ReqMoveToActor_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BATraceMove:ReqMoveToActor")]
	private AIReqMoveToActor ReqMoveToActor
	{
		get
		{
			CheckDestroyed();
			if (!ReqMoveToActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BATraceMove:ReqMoveToActor");
				return null;
			}
			return UObjectMarshaler<AIReqMoveToActor>.FromNative(IntPtr.Add(base.Address, ReqMoveToActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReqMoveToActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BATraceMove:ReqMoveToActor");
			}
			else
			{
				UObjectMarshaler<AIReqMoveToActor>.ToNative(IntPtr.Add(base.Address, ReqMoveToActor_Offset), value);
			}
		}
	}

	public override void StartExecute(ACharacter Character, AIRequestBase AIRequest)
	{
		base.StartExecute(Character, AIRequest);
		base.AIBasicActionType = EAIBasicActionType.TraceMove;
		ReqMoveToActor = AIRequest as AIReqMoveToActor;
		int RequestIdx;
		if (ReqMoveToActor == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.ErrorRequestType);
		}
		else if (!BGUFuncLibForMove.BeginMoveToTarget(base.OwnCharacter, ReqMoveToActor.FeatureActor, 30f, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false, out RequestIdx))
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
			USystemLibrary.PrintString(base.OwnCharacter, "DirectionMove AIBasicAction Failed", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
		}
	}

	public override void ExecuteTick(float DeltaTime)
	{
		base.ExecuteTick(DeltaTime);
		ReqMoveToActor.LeftDis = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter), BGUFuncLibActorTransformCS.BGUGetActorLocation(ReqMoveToActor.FeatureActor));
		if (!BGUFuncLibForMove.IsMoveActive(base.OwnCharacter))
		{
			ReqMoveToActor.LeftDis = 0f;
			AIRequestManageData.SetLastActionState(EAIBasicActionState.Finish);
		}
	}

	public override void ExecuteAbort()
	{
		BGUFuncLibForMove.CancelMove(base.OwnCharacter);
		ReqMoveToActor.LeftDis = 0f;
		AIRequestManageData.SetLastActionState(EAIBasicActionState.Aborted);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BATraceMove");
		ReqMoveToActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReqMoveToActor");
		ReqMoveToActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReqMoveToActor", Classes.FObjectProperty);
	}

	static BATraceMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BATraceMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BATraceMove));
	}
}
