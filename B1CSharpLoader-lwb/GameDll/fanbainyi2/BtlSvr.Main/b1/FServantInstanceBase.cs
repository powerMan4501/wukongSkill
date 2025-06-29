using System.Collections.Generic;
using b1.Plugins.Calliope;
using BtlB1;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public abstract class FServantInstanceBase
{
	[InstanceFactory]
	public abstract class FServantPhaseProcessorBase
	{
		[FactoryKey]
		public abstract EServantPhase ProcessorPhase { get; }

		public void NotifyEnterPhase(FServantInstanceBase ServantInstance)
		{
			ServantInstance.bEnableTickInPhaseProcessor = true;
			EnterPhase(ServantInstance);
		}

		public void NotifyExitPhase(FServantInstanceBase ServantInstance)
		{
			ServantInstance.bEnableTickInPhaseProcessor = false;
			ExitPhase(ServantInstance);
		}

		public void NotifyTickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
			if (ServantInstance.bEnableTickInPhaseProcessor)
			{
				TickPhase(ServantInstance, InDeltaTime);
			}
		}

		protected virtual void EnterPhase(FServantInstanceBase ServantInstance)
		{
		}

		protected virtual void ExitPhase(FServantInstanceBase ServantInstance)
		{
		}

		protected virtual void TickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
		}

		protected void NextPhase(FServantInstanceBase ServantInstance)
		{
			NotifyExitPhase(ServantInstance);
			ServantInstance.ExpectPhase = ProcessorPhase + 1;
		}
	}

	public class FServantPhaseProcessor_Tamer : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.Tamer;

		protected override void EnterPhase(FServantInstanceBase ServantInstance)
		{
			ServantInstance.CurrentDelayTime = 0f;
		}

		protected override void TickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
			ServantInstance.CurrentDelayTime += InDeltaTime;
			if (ServantInstance.CurrentDelayTime >= ServantInstance.ServantReq.DelaySummonTime)
			{
				NextPhase(ServantInstance);
			}
		}
	}

	public class FServantPhaseProcessor_BeginSpawnActor : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.BeginSpawnActor;

		protected override void EnterPhase(FServantInstanceBase ServantInstance)
		{
			ServantInstance.CurrentDelayTime = 0f;
		}

		protected override void TickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
			ServantInstance.CurrentDelayTime += InDeltaTime;
			if (ServantInstance.CurrentDelayTime >= ServantInstance.ServantReq.DelayEffectTime)
			{
				NextPhase(ServantInstance);
			}
		}
	}

	public class FServantPhaseProcessor_ECSPreBeginPlayFinished : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.ECSPreBeginPlayFinished;

		protected override void EnterPhase(FServantInstanceBase ServantInstance)
		{
			if (ServantInstance.ServantReq.DelayBornTime > 0f)
			{
				ServantInstance.CurrentDelayTime = 0f;
			}
			else
			{
				NextPhase(ServantInstance);
			}
		}

		protected override void TickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
			ServantInstance.CurrentDelayTime += InDeltaTime;
			if (ServantInstance.CurrentDelayTime >= ServantInstance.ServantReq.DelayBornTime)
			{
				NextPhase(ServantInstance);
			}
		}
	}

	public class FServantPhaseProcessor_Unit : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.Unit;

		protected override void EnterPhase(FServantInstanceBase ServantInstance)
		{
			ServantInstance.CurrentAliveTime = 0f;
			ServantInstance.NotifyAfterUnitBeginPlay();
		}

		protected override void TickPhase(FServantInstanceBase ServantInstance, float InDeltaTime)
		{
			if (!ServantInstance.bPausedAliveTime)
			{
				ServantInstance.CurrentAliveTime += InDeltaTime;
			}
			if (!ServantInstance.bCantAliveTimeOver && ServantInstance.AliveTime >= 0f && ServantInstance.CurrentAliveTime >= ServantInstance.AliveTime)
			{
				NextPhase(ServantInstance);
			}
		}
	}

	public class FServantPhaseProcessor_LifeOver : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.LifeOver;
	}

	public class FServantPhaseProcessor_Dead : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.Dead;

		protected override void EnterPhase(FServantInstanceBase ServantInstance)
		{
		}

		protected override void ExitPhase(FServantInstanceBase ServantInstance)
		{
		}
	}

	public class FServantPhaseProcessor_Destroyed : FServantPhaseProcessorBase
	{
		public override EServantPhase ProcessorPhase => EServantPhase.Destroyed;
	}

	private EServantPhase _actualPhase;

	protected FServantReq ServantReq;

	public FCalliopeGuid SummonInstanceID;

	public EServantPhase ExpectPhase { get; private set; }

	public EServantPhase ActualPhase
	{
		get
		{
			return _actualPhase;
		}
		set
		{
			if (_actualPhase != value)
			{
				_actualPhase = value;
				FServantPhaseProcessorFactory.GetInstance(value).NotifyEnterPhase(this);
			}
		}
	}

	private float CurrentDelayTime { get; set; }

	private float CurrentAliveTime { get; set; }

	private bool bEnableTickInPhaseProcessor { get; set; }

	public bool bPausedAliveTime { get; set; }

	public bool bCantAliveTimeOver { get; set; }

	public float AliveTime { get; set; }

	public AActor Owner { get; set; }

	public FTamerRef ServantTamerRef { get; set; }

	public int ServantResId => ServantTamerRef?.ResID ?? 0;

	protected TWeakObject<BGUCharacterCS> ServantUnitPtr { get; set; }

	protected BUS_GSEventCollection ServantEventCollection { get; set; }

	protected AActor MasterActor { get; set; }

	protected bool bCanCastCopySkill { get; set; }

	public void NotifyTickPhase(float InDeltaTime)
	{
		if (ActualPhase != EServantPhase.None)
		{
			FServantPhaseProcessorFactory.GetInstance(ActualPhase).NotifyTickPhase(this, InDeltaTime);
		}
	}

	private void TriggerLifeOver()
	{
		ExpectPhase = EServantPhase.LifeOver;
	}

	public FServantInstanceBase(FServantReq InReq)
	{
		ServantReq = InReq;
		AliveTime = ServantReq.AliveTime;
		bCanCastCopySkill = false;
	}

	public virtual void DestroyServantTamer()
	{
		ServantTamerRef.DestroyTamer();
	}

	private void NotifyAfterUnitBeginPlay()
	{
		if (ServantTamerRef == null)
		{
			return;
		}
		ServantUnitPtr = ServantTamerRef.MonsterInstancePtr;
		if (ServantUnitPtr.IsValid())
		{
			ServantEventCollection = BUS_EventCollectionCS.Get(ServantUnitPtr.Get());
			if (!(ServantEventCollection == null))
			{
				AfterUnitBeginPlay();
			}
		}
	}

	protected virtual void AfterUnitBeginPlay()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		DisplayBornEffect();
		ServantEventCollection.Evt_MarkAsServant.Invoke(this);
		MasterActor = ServantReq.MasterActor;
		if (MasterActor is BGUCharacterCS)
		{
			ServantEventCollection.Evt_SetMaster.Invoke(MasterActor);
		}
		if (MasterActor is BGUCollectionBase actor)
		{
			ServantEventCollection.Evt_SetCollectionMaster.Invoke(actor);
		}
		BGUCharacterCS bGUCharacterCS = ServantUnitPtr.Get();
		foreach (int birthBuffID in ServantReq.BirthBuffIDs)
		{
			ServantEventCollection.Evt_BuffAdd.Invoke(birthBuffID, bGUCharacterCS, bGUCharacterCS, 0f, EBuffSourceType.SummonDesc);
		}
		if (ServantReq.bFaceToPlayer)
		{
			FRotator newRotation = MathLib.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(ServantUnitPtr.Get()), BGUFuncLibActorTransformCS.BGUGetActorLocation(firstLocalPlayerController));
			newRotation.Roll = 0f;
			newRotation.Pitch = 0f;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(bGUCharacterCS, newRotation, bTeleportPhysics: false);
		}
		if (ServantReq.InitSpeed > 0f)
		{
			UPawnMovementComponent movementComponent = ServantUnitPtr.Get().GetMovementComponent();
			if (movementComponent != null)
			{
				movementComponent.Velocity = ServantUnitPtr.Get().GetActorForwardVector() * ServantReq.InitSpeed;
			}
		}
		EFsmSolverType newSolverType = EFsmSolverType.SummonAi;
		switch (ServantReq.ServantType)
		{
		case EServantType.MonsterSpawn:
			newSolverType = EFsmSolverType.Normal;
			break;
		case EServantType.NeutralAnimSpawn:
			newSolverType = EFsmSolverType.NeutralAnimalBattle;
			break;
		}
		ServantEventCollection.Evt_SwitchFsmSolver.Invoke(newSolverType);
		ServantEventCollection.Evt_TryRunDefaultCBG.Invoke();
		ServantEventCollection.Evt_TryRunDefaultBT.Invoke();
	}

	public void AddLifeTime(float IncreaseLifeTime)
	{
		AliveTime += IncreaseLifeTime;
	}

	public void CatSkill(int SkillID)
	{
		if (ActualPhase == EServantPhase.Unit)
		{
			ServantEventCollection.Evt_CallSummonUseSkill.Invoke(SkillID);
		}
	}

	public void Recall()
	{
		TriggerLifeOver();
	}

	public void Destroy()
	{
		TriggerLifeOver();
	}

	public void CastCopySkill(UAnimMontage CopyAnim, FTransform TeleportTransform)
	{
		if (ActualPhase == EServantPhase.Unit && bCanCastCopySkill)
		{
			TeleportTransform.Translation.Z += ServantUnitPtr.Get().CapsuleComponent.GetScaledCapsuleHalfHeight() + 10f;
			ServantEventCollection.Evt_CopySkillSummonBehavior.Invoke(CopyAnim, in TeleportTransform);
		}
	}

	private void DisplayBornEffect()
	{
		if (ServantReq.BornDBC != null)
		{
			FTransform spawnTransform = default(FTransform);
			spawnTransform.SetLocation(ServantReq.BornTransform.GetLocation());
			spawnTransform.SetRotation(FQuat.Identity);
			spawnTransform.SetScale3D(FVector.OneVector);
			ServantEventCollection?.Evt_RequestSpawnFXByDispConfigDA.Invoke(ServantReq.BornDBC, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
		}
		if (ServantReq.BornNiagara != null)
		{
			UNiagaraFunctionLibrary.SpawnSystemAtLocation(Owner, ServantReq.BornNiagara, ServantReq.BornTransform.GetLocation(), FRotator.ZeroRotator, new FVector(1f), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: true);
		}
		if (ServantReq.BornParticle != null)
		{
			UGameplayStatics.SpawnEmitterAtLocation(Owner.World, ServantReq.BornParticle, ServantReq.BornTransform.GetLocation(), FRotator.ZeroRotator, new FVector(1f), bAutoDestroy: true, EPSCPoolMethod.None, bAutoActivateSystem: true);
		}
	}

	public AActor GetMonsterActor()
	{
		return ServantUnitPtr.Get();
	}

	public void GetSummonDisappearInfo(out List<string> MontagePathList, out float DestroyDelayTime)
	{
		DestroyDelayTime = ServantReq.DestroyDelayTime;
		MontagePathList = new List<string>();
		MontagePathList.AddRange(ServantReq.DisappearMontagePathList);
	}
}
