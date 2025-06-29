using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_CutDeathComp : UActorCompBaseCS
{
	private b1.BUC_CutDeathData CutDeathData;

	private BUC_ABPPoseSnapshotData AnimHumanoidPoseSnapshotData;

	private int TickCountForPhysics;

	private bool bStartTickForPhysics;

	private bool bUseBoomForce;

	public override void OnAttach()
	{
		CutDeathData = RequireWritableData<b1.BUC_CutDeathData>();
		AnimHumanoidPoseSnapshotData = RequireWritableData<BUC_ABPPoseSnapshotData>();
		base.BUSEventCollection.Evt_OnPerformCutDeath += new Del_PerformCutDeath(OnPerformCutDeath);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		FName effectAttackSocket = (GetOwner() as BGUCutDeathActor).EffectAttackSocket;
		if (!effectAttackSocket.PlainName.Equals("None") && effectAttackSocket.PlainName.Length > 0)
		{
			BUS_DispLibEventCollection.Get(this).Evt_AddOrChangeInterfaceSocket(B1GlobalFNames.body_center, effectAttackSocket);
		}
		else
		{
			BUS_DispLibEventCollection.Get(this).Evt_AddOrChangeInterfaceSocket(B1GlobalFNames.body_center, B1GlobalFNames.spine_01);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (bStartTickForPhysics)
		{
			TickCountForPhysics++;
			if (TickCountForPhysics > 1)
			{
				EnablePhysics();
				bStartTickForPhysics = false;
			}
		}
		UpdateDelayDisplayTimer(DeltaTime);
	}

	private void OnPerformCutDeath(ACharacter OriginalChar, float DelayClearArmorTime, float DelayDestroyActorTime, float StiffLevelCauseDead, FVector KillerLocation, bool UseBoomForce)
	{
		if (OriginalChar == null)
		{
			return;
		}
		CutDeathData.DelayDestroyActorTime = DelayClearArmorTime;
		CutDeathData.DelayDestroyActorTime = DelayDestroyActorTime;
		CutDeathData.StiffLevelCauseDead = StiffLevelCauseDead;
		CutDeathData.KillerLocation = KillerLocation;
		USkeletalMeshComponent mesh = OriginalChar.Mesh;
		FPoseSnapshot Snapshot = default(FPoseSnapshot);
		mesh.SnapshotPose(ref Snapshot);
		base.BUSEventCollection?.Evt_OnToggleSnapshotPose.Invoke(bEnable: true, Snapshot);
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			(item as USkeletalMeshComponent).SetRelativeLocation(OriginalChar.Mesh.RelativeLocation, bSweep: false, out var _, bTeleport: true);
		}
		bStartTickForPhysics = true;
		bUseBoomForce = UseBoomForce;
	}

	private void EnablePhysics()
	{
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			USkeletalMeshComponent obj = item as USkeletalMeshComponent;
			obj.PauseAnims = true;
			obj.SetSimulatePhysics(bSimulate: true);
			UForceCinfigComp uForceCinfigComp = obj.GetChildComponent(0) as UForceCinfigComp;
			float num = 0f;
			FVector a;
			if (uForceCinfigComp != null)
			{
				FVector fVector = new FVector(FMath.RandRange(uForceCinfigComp.ForceRandomBiasMin.X, uForceCinfigComp.ForceRandomBiasMax.X), FMath.RandRange(uForceCinfigComp.ForceRandomBiasMin.Y, uForceCinfigComp.ForceRandomBiasMax.Y), FMath.RandRange(uForceCinfigComp.ForceRandomBiasMin.Z, uForceCinfigComp.ForceRandomBiasMax.Z));
				FVector fVector2 = (CutDeathData.KillerLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Normal();
				a = ((!uForceCinfigComp.DontRotateToAtker && !fVector2.IsZero()) ? UMathLibrary.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), CutDeathData.KillerLocation).RotateVector(uForceCinfigComp.RelativeRotation.GetForwardVector() + fVector) : (uForceCinfigComp.GetWorldRotation().GetForwardVector() + fVector));
			}
			else
			{
				a = UMathLibrary.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), CutDeathData.KillerLocation).RotateVector(-FVector.ForwardVector);
			}
			obj.SetAllPhysicsLinearVelocity(a.Normal() * num);
			obj.SetAllPhysicsAngularVelocityInDegrees(FVector.ZeroVector);
		}
	}

	private void UpdateDelayDisplayTimer(float DeltaTime)
	{
		if (CutDeathData.DelayDestroyActorTime > 0f)
		{
			CutDeathData.DelayDestroyActorTime -= DeltaTime;
			if (CutDeathData.DelayDestroyActorTime <= 0f)
			{
				BUS_DispLibEventCollection.Get(this).Evt_DispLibPreDestroy();
				BGU_UnrealWorldUtil.DestroyActor(GetOwner());
			}
		}
	}
}
