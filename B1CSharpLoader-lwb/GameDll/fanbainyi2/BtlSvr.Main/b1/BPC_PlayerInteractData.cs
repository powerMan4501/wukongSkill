using System;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_PlayerInteractData : IBPC_PlayerInteractData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	public EntitySharedRefList InteractiveActors = new EntitySharedRefList();

	public int CantbreakBuffID = 306;

	public InteractStepBase _CurrentStep;

	public bool TmpIsSpDrop { get; set; }

	public EntitySharedRef BestInteractEntityRef { get; set; }

	public Entity CurrentInteractingEntityRef { get; set; }

	public USkeletalMeshComponent MatchingPointDummyMesh { get; set; }

	public FName MatchingPointDummyMeshSocket { get; set; }

	public FTransform MatchingPosTargetTransform { get; set; }

	public bool bUsingInteractiveUnitViewTarget { get; set; }

	public bool bUsingInteractSkill { get; set; }

	public FUStInteractionMappingDesc InteractActionDesc { get; set; }

	public float StartInteractTime { get; set; }

	public bool bIsInNewInputContext { get; set; }

	public bool bIsModifyDueCantBreak { get; set; }

	public InteractStepBase CurrentStep
	{
		get
		{
			return _CurrentStep;
		}
		set
		{
			if (_CurrentStep != null && value == null)
			{
				this.OnPlayerInteractStateReset(_CurrentStep.StateName);
			}
			_CurrentStep = value;
		}
	}

	public event Action<PlayerInteractState> OnPlayerInteractStateReset;

	public void OnUnPersistentDestroy()
	{
		InteractiveActors.Clear();
		BestInteractEntityRef = null;
		CurrentInteractingEntityRef = Entity.Null;
	}

	public bool IsInInteraction()
	{
		return CurrentStep != null;
	}

	public bool IsToolInteraction()
	{
		if (!IsInInteraction() || InteractActionDesc == null)
		{
			return false;
		}
		if (InteractActionDesc.InteractAction == EInteractAction.ToolNpc || InteractActionDesc.InteractAction == EInteractAction.RebirthPoint)
		{
			return true;
		}
		return false;
	}
}
