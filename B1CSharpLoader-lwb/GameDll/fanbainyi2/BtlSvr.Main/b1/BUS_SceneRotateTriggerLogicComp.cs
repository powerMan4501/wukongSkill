using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SceneRotateTriggerLogicComp : UActorCompBaseCS
{
	private b1.BUC_SceneRotateTriggerData SceneRotateData;

	public override void OnAttach()
	{
		SceneRotateData = RequireWritableData<b1.BUC_SceneRotateTriggerData>();
		Deactivate();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool flag = true;
		if (SceneRotateData.bIsActive && SceneRotateData.SkeletalMeshActor.Value != null)
		{
			USkeletalMeshComponent componentByClass = SceneRotateData.SkeletalMeshActor.Value.GetComponentByClass<USkeletalMeshComponent>();
			if (componentByClass != null && componentByClass.IsPlaying())
			{
				FTransform socketTransform = componentByClass.GetSocketTransform(SceneRotateData.AttachPoint);
				if (socketTransform.IsValid())
				{
					flag = false;
					ResetLevelTransforms();
					float position = componentByClass.GetPosition();
					FTransform other = BGUFunctionLibraryCS.GetAnimBoneTransformFromLastTick(SceneRotateData.AnimSequence, position, 0f, SceneRotateData.AttachPoint, SceneRotateData.LocationCurve, SceneRotateData.MultiplierCurveL, SceneRotateData.RotationCurve, SceneRotateData.MultiplierCurveR) * socketTransform;
					foreach (FName affectedLevel in SceneRotateData.AffectedLevels)
					{
						FTransform levelStreamingLevelTransformByName = UBGUFunctionLibrary.GetLevelStreamingLevelTransformByName(Owner, affectedLevel);
						FTransform other2 = levelStreamingLevelTransformByName.GetRelativeTransform(other) * socketTransform;
						FTransform relativeTransform = levelStreamingLevelTransformByName.GetRelativeTransform(other2);
						SceneRotateData.LevelTransforms[affectedLevel] = relativeTransform;
						UBGUFunctionLibrary.ApplyLevelTransform(Owner, affectedLevel, relativeTransform);
					}
					FTransform relativeTransform2 = FTransform.Default.GetRelativeTransform(FTransform.Default.GetRelativeTransform(other) * socketTransform);
					foreach (TStrongObjectPtr<UNiagaraParameterCollectionInstance> item in SceneRotateData.AffectedNiagaraNPC)
					{
						item.Get()?.SetQuatParameter("GB_MeshOrientation", relativeTransform2.GetRotation());
					}
					SceneRotateData.AnimLastPos = position;
				}
			}
		}
		if (flag)
		{
			ResetSceneRotate();
		}
	}

	private void ResetLevelTransforms()
	{
		foreach (FName affectedLevel in SceneRotateData.AffectedLevels)
		{
			if (SceneRotateData.LevelTransforms.TryGetValue(affectedLevel, out var value))
			{
				FTransform levelTransform = value.Inverse();
				UBGUFunctionLibrary.ApplyLevelTransform(Owner, affectedLevel, levelTransform);
			}
			SceneRotateData.LevelTransforms[affectedLevel] = FTransform.Identity;
		}
	}

	private void ResetSceneRotate()
	{
		ResetLevelTransforms();
		SceneRotateData.LevelTransforms.Clear();
		SceneRotateData.AnimLastPos = 0f;
		foreach (TStrongObjectPtr<UNiagaraParameterCollectionInstance> item in SceneRotateData.AffectedNiagaraNPC)
		{
			item.Get()?.SetQuatParameter("GB_MeshOrientation", FQuat.Identity);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		ResetSceneRotate();
		base.OnEndPlay(EndPlayReason);
	}

	public void Activate()
	{
		SceneRotateData.bIsActive = true;
		SetCanTick(Val: true);
	}

	public void Deactivate()
	{
		SceneRotateData.bIsActive = false;
		ResetSceneRotate();
		SetCanTick(Val: false);
	}

	public void OnActorEnter(AActor OtherActor)
	{
		Activate();
	}

	public void OnActorLeave(AActor OtherActor)
	{
		Deactivate();
	}
}
