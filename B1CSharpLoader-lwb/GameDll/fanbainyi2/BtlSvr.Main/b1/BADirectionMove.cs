using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BADirectionMove")]
internal class BADirectionMove : b1.BasicActionBase
{
	private float SpeedDelta;

	private float LowSpeedTime;

	private FVector LastOwnLoc;

	private static bool ReqMoveToLoc_IsValid;

	private static int ReqMoveToLoc_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BADirectionMove:ReqMoveToLoc")]
	private AIReqMoveToLoc ReqMoveToLoc
	{
		get
		{
			CheckDestroyed();
			if (!ReqMoveToLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BADirectionMove:ReqMoveToLoc");
				return null;
			}
			return UObjectMarshaler<AIReqMoveToLoc>.FromNative(IntPtr.Add(base.Address, ReqMoveToLoc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReqMoveToLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BADirectionMove:ReqMoveToLoc");
			}
			else
			{
				UObjectMarshaler<AIReqMoveToLoc>.ToNative(IntPtr.Add(base.Address, ReqMoveToLoc_Offset), value);
			}
		}
	}

	public override void StartExecute(ACharacter Character, AIRequestBase AIRequest)
	{
		base.StartExecute(Character, AIRequest);
		base.AIBasicActionType = EAIBasicActionType.DirectionMove;
		ReqMoveToLoc = AIRequest as AIReqMoveToLoc;
		if (ReqMoveToLoc == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.ErrorRequestType);
			return;
		}
		FVector selectedPoint = ReqMoveToLoc.SelectedPoint;
		if (!BGUFuncLibForMove.BeginMoveToPos(base.OwnCharacter, selectedPoint, 50f, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _))
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
			USystemLibrary.PrintString(base.OwnCharacter, "DirectionMove AIBasicAction Failed", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
		}
		else
		{
			LastOwnLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter);
			LowSpeedTime = 0f;
		}
	}

	public override void ExecuteTick(float DeltaTime)
	{
		base.ExecuteTick(DeltaTime);
		ReqMoveToLoc.LeftDis = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter), ReqMoveToLoc.SelectedPoint);
		SpeedDelta = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter), LastOwnLoc);
		LastOwnLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter);
		if (SpeedDelta < 0.1f)
		{
			LowSpeedTime += DeltaTime;
		}
		if (LowSpeedTime > 0.2f)
		{
			ReqMoveToLoc.LeftDis = 0f;
			BGUFuncLibForMove.CancelMove(base.OwnCharacter);
			AIRequestManageData.SetLastActionState(EAIBasicActionState.Finish);
		}
		else if (!BGUFuncLibForMove.IsMoveActive(base.OwnCharacter))
		{
			ReqMoveToLoc.LeftDis = 0f;
			AIRequestManageData.SetLastActionState(EAIBasicActionState.Finish);
		}
	}

	public override void ExecuteAbort()
	{
		BGUFuncLibForMove.CancelMove(base.OwnCharacter);
		ReqMoveToLoc.LeftDis = 0f;
		AIRequestManageData.SetLastActionState(EAIBasicActionState.Aborted);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BADirectionMove");
		ReqMoveToLoc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReqMoveToLoc");
		ReqMoveToLoc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReqMoveToLoc", Classes.FObjectProperty);
	}

	static BADirectionMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BADirectionMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BADirectionMove));
	}
}
