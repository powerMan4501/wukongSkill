using System;
using System.Collections.Generic;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayerBlendPosition")]
public class MovieNodeInstance_PlayerBlendPosition : MovieNodeInstance
{
	private FTimerHandle BlendTimerHandle;

	private static bool OnBlendPositionTimeout_IsValid;

	private static IntPtr OnBlendPositionTimeout_FunctionAddress;

	private static int OnBlendPositionTimeout_ParamsSize;

	private List<FTransform> AlternativeTransforms { get; } = new List<FTransform>();

	private BGUCharacterCS Player { get; set; }

	private FTransform TargetTransform { get; set; }

	private MovieCustom_PlayerBlendPosition CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PlayerBlendPosition();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (CalliopeCustom_Transform alternativeTransform in CustomData.AlternativeTransforms)
		{
			FTransform item = new FTransform(new FRotator(alternativeTransform.TransformPitch, alternativeTransform.TransformYaw, alternativeTransform.TransformRoll), new FVector(alternativeTransform.TransformX, alternativeTransform.TransformY, alternativeTransform.TransformZ), new FVector(alternativeTransform.TransformSx, alternativeTransform.TransformSy, alternativeTransform.TransformSz));
			AlternativeTransforms.Add(item);
		}
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
		{
			Player = allPlayerActor;
			PlayerBlendPosition();
		}
	}

	private void PlayerBlendPosition()
	{
		if (Player != null)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Player);
			float num = float.MaxValue;
			foreach (FTransform alternativeTransform in AlternativeTransforms)
			{
				float num2 = (alternativeTransform.GetLocation() - fVector).Size();
				if (num2 < num)
				{
					num = num2;
					TargetTransform = alternativeTransform;
				}
			}
			if ((TargetTransform.GetLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Player)).Size() > CustomData.TeleportDistance)
			{
				Player.SetActorTransform(TargetTransform, bSweep: false, out var _, bTeleport: false);
				TriggerFirstOutput();
				return;
			}
			FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
			BlendTimerHandle = fTimerManager.SetTimer(this, "OnBlendPositionTimeout", CustomData.BlendMaxTime);
			FMatchingPositionMoveParam Param = new FMatchingPositionMoveParam
			{
				MatchingPosType = EMatchingPosType.InterpolationLiner,
				TargetTrans = TargetTransform,
				MoveSpeedType = (EAIMoveSpeedType)CustomData.MoveSpeedType,
				bIncludeSelfRadius = false,
				AcceptableRadius = CustomData.BlendPositionAcceptRadius,
				InterpMoveTime = CustomData.BlendPositionInterpTime,
				InterpMoveCallbackFunc = OnBlendPositionFinish
			};
			BUS_EventCollectionCS.Get(Player).Evt_MatchingPositionMove.Invoke(in Param);
		}
		else
		{
			LogError("MovieNodeInstance_PlayerBlendPosition: 未找到主角");
			TriggerFirstOutput();
		}
	}

	private void OnBlendPositionFinish(bool bSuccess)
	{
		(FTimerManager.PIEWorld ?? FTimerManager.GameInstance).ClearTimer(ref BlendTimerHandle);
		BUS_EventCollectionCS.Get(Player).Evt_SetForceMMToIdle.Invoke(P1: true);
		BUS_EventCollectionCS.Get(Player).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputRun, -1f);
		TriggerFirstOutput();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayerBlendPosition:OnBlendPositionTimeout")]
	private void OnBlendPositionTimeout()
	{
		BUS_EventCollectionCS.Get(Player).Evt_SetForceMMToIdle.Invoke(P1: true);
		BUS_EventCollectionCS.Get(Player).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputRun, -1f);
		TriggerFirstOutput();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieNodeInstance_PlayerBlendPosition:OnBlendPositionTimeout")]
	private static void OnBlendPositionTimeout__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieNodeInstance_PlayerBlendPosition movieNodeInstance_PlayerBlendPosition = GCHelper.Find<MovieNodeInstance_PlayerBlendPosition>(obj);
		movieNodeInstance_PlayerBlendPosition.OnBlendPositionTimeout();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PlayerBlendPosition");
		OnBlendPositionTimeout_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBlendPositionTimeout");
		OnBlendPositionTimeout_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBlendPositionTimeout_FunctionAddress);
		OnBlendPositionTimeout_IsValid = OnBlendPositionTimeout_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieNodeInstance_PlayerBlendPosition:OnBlendPositionTimeout", OnBlendPositionTimeout_IsValid);
	}

	static MovieNodeInstance_PlayerBlendPosition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PlayerBlendPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PlayerBlendPosition));
	}
}
