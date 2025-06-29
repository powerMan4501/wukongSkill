using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAMoveSkill")]
internal class BAMoveSkill : b1.BasicActionBase
{
	private static bool ReqMoveSkill_IsValid;

	private static int ReqMoveSkill_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAMoveSkill:ReqMoveSkill")]
	private AIReqMoveSkill ReqMoveSkill
	{
		get
		{
			CheckDestroyed();
			if (!ReqMoveSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAMoveSkill:ReqMoveSkill");
				return null;
			}
			return UObjectMarshaler<AIReqMoveSkill>.FromNative(IntPtr.Add(base.Address, ReqMoveSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReqMoveSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAMoveSkill:ReqMoveSkill");
			}
			else
			{
				UObjectMarshaler<AIReqMoveSkill>.ToNative(IntPtr.Add(base.Address, ReqMoveSkill_Offset), value);
			}
		}
	}

	public override void StartExecute(ACharacter Character, AIRequestBase AIRequest)
	{
		base.StartExecute(Character, AIRequest);
		base.AIBasicActionType = EAIBasicActionType.MoveSkill;
		ReqMoveSkill = AIRequest as AIReqMoveSkill;
		if (ReqMoveSkill == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.ErrorRequestType);
			return;
		}
		BAMsg = AIFuncLibForCS.GetBaseActionMsg(base.OwnCharacter, base.AIBasicActionType, BGUFuncLibActorTransformCS.BGUGetActorLocation(ReqMoveSkill.FeatureActor));
		if (BAMsg == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
		}
		else if (StartExecuteBySkill(BAMsg))
		{
			FVector selectedPoint = ReqMoveSkill.SelectedPoint;
			if (!BGUFuncLibForMove.BeginMoveToPos(base.OwnCharacter, selectedPoint, 50f, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _))
			{
				AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
			}
		}
	}

	public override void ExecuteTick(float DeltaTime)
	{
		base.ExecuteTick(DeltaTime);
		if (ExecuteTickBySkill())
		{
			ReqMoveSkill.LeftDamage -= BAMsg.Damage;
			BGUFuncLibForMove.CancelMove(base.OwnCharacter);
		}
		else
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(base.OwnCharacter, MathLib.MakeRotFromX((BGUFuncLibActorTransformCS.BGUGetActorLocation(ReqMoveSkill.FeatureActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter)).GetSafeNormal2D()), bTeleportPhysics: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAMoveSkill");
		ReqMoveSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReqMoveSkill");
		ReqMoveSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReqMoveSkill", Classes.FObjectProperty);
	}

	static BAMoveSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAMoveSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAMoveSkill));
	}
}
