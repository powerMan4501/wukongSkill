using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class PlayerSelectUnitLogic
{
	private readonly FName GroundSock = B1GlobalFNames.GroundSock;

	private b1.BUC_PlayerSelectUnitData SelectUnitData;

	public void InitSelectUnitData(b1.BUC_PlayerSelectUnitData ParentData, AActor Owner)
	{
		SelectUnitData = ParentData;
		SelectUnitData.SelectedUnitActorClass = null;
		SelectUnitData.Owner = Owner;
	}

	public void Tick(float DeltaTime)
	{
		DoTicking(DeltaTime);
	}

	private void DoTicking(float DeltaTime)
	{
		ACharacter aCharacter = BGUFunctionLibraryCS.BGUGetTarget(SelectUnitData.Owner) as ACharacter;
		if (!aCharacter.IsNullOrDestroyed())
		{
			bool flag = BGUFunctionLibraryCS.BGUHasUnitState(aCharacter, EBGUUnitState.Dead);
			OnSetTarget(flag ? null : aCharacter);
			FVector Location = aCharacter.Mesh.GetSocketLocation(GroundSock);
			if (SelectUnitData.SelectedUnitActorInst == null && SelectUnitData.SelectedUnitActorClass != null)
			{
				SelectUnitData.SelectedUnitActorInst = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(SelectUnitData.Owner.World, SelectUnitData.SelectedUnitActorClass, in Location, in FRotator.ZeroRotator);
			}
			if (SelectUnitData.SelectedUnitActorInst != null)
			{
				SetSelectedVisibility(IsVisible: true);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(SelectUnitData.SelectedUnitActorInst, Location, bSweep: false, bTeleport: true);
				UpdateSelectedVisibility(flag || aCharacter.IsPendingKill);
			}
		}
		else
		{
			OnSetTarget(null);
			SetSelectedVisibility(IsVisible: false);
			UpdateSelectedVisibility(ShouldHide: true);
		}
	}

	private void OnSetTarget(ACharacter TargetCharacter)
	{
		if (SelectUnitData.CurTarget != TargetCharacter)
		{
			if (!SelectUnitData.CurTarget.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(SelectUnitData.CurTarget)?.Evt_ActorGlowRequest.Invoke(P1: false);
			}
			if (!TargetCharacter.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(TargetCharacter)?.Evt_ActorGlowRequest.Invoke(P1: true);
			}
			SelectUnitData.CurTarget = TargetCharacter;
		}
	}

	private void UpdateSelectedVisibility(bool ShouldHide)
	{
		if (!SelectUnitData.SelectedUnitActorInst.IsNullOrDestroyed())
		{
			if (ShouldHide && !SelectUnitData.SelectedUnitActorInst.Hidden)
			{
				SelectUnitData.SelectedUnitActorInst.SetActorHiddenInGame(bNewHidden: true);
			}
			else if (!ShouldHide && SelectUnitData.SelectedUnitActorInst.Hidden)
			{
				SelectUnitData.SelectedUnitActorInst.SetActorHiddenInGame(bNewHidden: false);
			}
		}
	}

	private void SetSelectedVisibility(bool IsVisible)
	{
	}
}
