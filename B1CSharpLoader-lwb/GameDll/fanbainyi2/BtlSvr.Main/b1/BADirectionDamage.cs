using System;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BADirectionDamage")]
internal class BADirectionDamage : b1.BasicActionBase
{
	private static bool ReqDirDamage_IsValid;

	private static int ReqDirDamage_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BADirectionDamage:ReqDirDamage")]
	private AIReqDirDamage ReqDirDamage
	{
		get
		{
			CheckDestroyed();
			if (!ReqDirDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BADirectionDamage:ReqDirDamage");
				return null;
			}
			return UObjectMarshaler<AIReqDirDamage>.FromNative(IntPtr.Add(base.Address, ReqDirDamage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReqDirDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BADirectionDamage:ReqDirDamage");
			}
			else
			{
				UObjectMarshaler<AIReqDirDamage>.ToNative(IntPtr.Add(base.Address, ReqDirDamage_Offset), value);
			}
		}
	}

	public override void StartExecute(ACharacter Character, AIRequestBase AIRequest)
	{
		base.StartExecute(Character, AIRequest);
		base.AIBasicActionType = EAIBasicActionType.DirectionDamage;
		ReqDirDamage = AIRequest as AIReqDirDamage;
		if (ReqDirDamage == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.ErrorRequestType);
			return;
		}
		BAMsg = AIFuncLibForCS.GetBaseActionMsg(base.OwnCharacter, base.AIBasicActionType, BGUFuncLibActorTransformCS.BGUGetActorLocation(ReqDirDamage.FeatureActor));
		if (BAMsg == null)
		{
			AIRequestManageData.SetLastActionState(EAIBasicActionState.SkillNotFound);
		}
		else if (StartExecuteBySkill(BAMsg))
		{
			UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo(ReqDirDamage.FeatureActor, ETargetSourceType.None, ELockTargetWayType.Auto);
			BUS_EventCollectionCS.Get(base.OwnCharacter).Evt_ClearTargetInfo.Invoke();
			if (unitLockTargetInfo.LockTargetEntity != Entity.Null)
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(!UGSE_EngineFuncLib.IsStandAlone(base.OwnCharacter.World), base.OwnCharacter, unitLockTargetInfo);
			}
			BGUFuncLibActorTransformCS.BGUSetActorRotation(base.OwnCharacter, MathLib.MakeRotFromX((BGUFuncLibActorTransformCS.BGUGetActorLocation(ReqDirDamage.FeatureActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(base.OwnCharacter)).GetSafeNormal2D()), bTeleportPhysics: false);
		}
	}

	public override void ExecuteTick(float DeltaTime)
	{
		base.ExecuteTick(DeltaTime);
		if (ExecuteTickBySkill())
		{
			ReqDirDamage.LeftDamage -= BAMsg.Damage;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BADirectionDamage");
		ReqDirDamage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReqDirDamage");
		ReqDirDamage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReqDirDamage", Classes.FObjectProperty);
	}

	static BADirectionDamage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BADirectionDamage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BADirectionDamage));
	}
}
