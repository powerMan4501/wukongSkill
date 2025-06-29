using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BARootMotionMove")]
internal class BARootMotionMove : b1.BasicActionBase
{
	private static bool ReqMoveToLoc_IsValid;

	private static int ReqMoveToLoc_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BARootMotionMove:ReqMoveToLoc")]
	private AIReqMoveToLoc ReqMoveToLoc
	{
		get
		{
			CheckDestroyed();
			if (!ReqMoveToLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BARootMotionMove:ReqMoveToLoc");
				return null;
			}
			return UObjectMarshaler<AIReqMoveToLoc>.FromNative(IntPtr.Add(base.Address, ReqMoveToLoc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReqMoveToLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BARootMotionMove:ReqMoveToLoc");
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
		base.AIBasicActionType = EAIBasicActionType.RootMotionMove;
		ReqMoveToLoc = AIRequest as AIReqMoveToLoc;
		if (ReqMoveToLoc == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.ErrorRequestType);
			return;
		}
		BAMsg = AIFuncLibForCS.GetBaseActionMsg(base.OwnCharacter, base.AIBasicActionType);
		if (BAMsg == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
		}
		else if (StartExecuteBySkill(BAMsg))
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(base.OwnCharacter, MathLib.MakeRotFromX((ReqMoveToLoc.SelectedPoint - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter)).GetSafeNormal2D()), bTeleportPhysics: false);
		}
	}

	public override void ExecuteTick(float DeltaTime)
	{
		base.ExecuteTick(DeltaTime);
		if (ExecuteTickBySkill())
		{
			ReqMoveToLoc.LeftDis -= BAMsg.MoveDis;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BARootMotionMove");
		ReqMoveToLoc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReqMoveToLoc");
		ReqMoveToLoc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReqMoveToLoc", Classes.FObjectProperty);
	}

	static BARootMotionMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BARootMotionMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BARootMotionMove));
	}
}
