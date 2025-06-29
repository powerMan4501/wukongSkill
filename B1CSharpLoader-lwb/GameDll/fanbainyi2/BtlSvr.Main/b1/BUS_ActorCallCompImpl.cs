using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ActorCallCompImpl : BUS_StateMachineCompBase
{
	public class NotCalledState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.ActorCallerTag.State_NotCalled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.ActorCallerTag.Event_Call, BGW_FlowUtils.ActorCallerTag.State_Called);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.ActorCallerTag.State_Called);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_ActorCallCompImpl bUS_ActorCallCompImpl && !(bUS_ActorCallCompImpl.CalledActor != null))
			{
				AActor owner = bUS_ActorCallCompImpl.GetOwner();
				FVector Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				FRotator Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
				FVector actorScale3D = owner.GetActorScale3D();
				UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
				bUS_ActorCallCompImpl.CalledActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(actorStreamingLevelWorld, bUS_ActorCallCompImpl.ActorCallData.CallActorCls.GetClass(), in Location, in Rotation);
				if (bUS_ActorCallCompImpl.CalledActor != null)
				{
					bUS_ActorCallCompImpl.CalledActor.SetActorScale3D(actorScale3D);
				}
			}
		}
	}

	public class CalledState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.ActorCallerTag.State_Called;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.ActorCallerTag.Event_Reset, BGW_FlowUtils.ActorCallerTag.State_NotCalled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is b1.BUS_ActorCallCompImpl bUS_ActorCallCompImpl) || bUS_ActorCallCompImpl.CalledActor == null)
			{
				return;
			}
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(bUS_ActorCallCompImpl.CalledActor);
			for (int i = 0; i < num; i++)
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(bUS_ActorCallCompImpl.CalledActor, i);
				if (aActor != null)
				{
					BGU_UnrealWorldUtil.DestroyActor(aActor);
				}
			}
			BGU_UnrealWorldUtil.DestroyActor(bUS_ActorCallCompImpl.CalledActor);
			bUS_ActorCallCompImpl.CalledActor = null;
		}
	}

	private TStrongObjectPtr<AActor> mCalledActor = new TStrongObjectPtr<AActor>();

	private b1.IBUC_ActorCallData ActorCallData { get; set; }

	private AActor CalledActor
	{
		get
		{
			return mCalledActor.Get();
		}
		set
		{
			mCalledActor.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		ActorCallData = RequireReadOnlyData<b1.IBUC_ActorCallData, b1.BUC_ActorCallData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.ActorCaller;
		AddState(typeof(CalledState), 1);
		base.InitialState = AddState(typeof(NotCalledState), 0);
	}
}
