using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MontageSectionCtrlComp : UActorCompBaseCS
{
	private BUC_MontageSectionCtrlData MontageSectionCtrlData;

	private IBUC_UnitStateData UnitStateData;

	public override void OnAttach()
	{
		MontageSectionCtrlData = RequireWritableData<BUC_MontageSectionCtrlData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		base.BUSEventCollection.Evt_MontageJumpToSection += new Del_MontageSection(OnMontageJumpToSection);
		base.BUSEventCollection.Evt_MontageSetNextSection += new Del_MontageSection(OnMontageSetNextSection);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (MontageSectionCtrlData.TimeBeforeNextSection > 0f)
		{
			MontageSectionCtrlData.TimeBeforeNextSection -= DeltaTime;
			if (MontageSectionCtrlData.TimeBeforeNextSection <= 0f)
			{
				OnNextSectionBegin();
			}
		}
	}

	private void OnMontageJumpToSection(FName SectionName)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			MontageSectionCtrlData.NextSectionName = SectionName;
			bGUCharacterCS.Mesh.GetAnimInstance().Montage_JumpToSection(SectionName, bGUCharacterCS.GetCurrentMontage());
			OnNextSectionBegin();
		}
	}

	private void OnMontageSetNextSection(FName SectionName)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			MontageSectionCtrlData.NextSectionName = SectionName;
			UAnimInstance animInstance = bGUCharacterCS.Mesh.GetAnimInstance();
			UAnimMontage currentMontage = bGUCharacterCS.GetCurrentMontage();
			animInstance.Montage_SetNextSection(animInstance.Montage_GetCurrentSection(currentMontage), SectionName, currentMontage);
			float position = animInstance.Montage_GetPosition(currentMontage);
			MontageSectionCtrlData.TimeBeforeNextSection = UBGUFunctionLibrary.BGUGetMontageSectionTimeLeftFromPos(bGUCharacterCS, currentMontage, position);
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, MontageSectionCtrlData.TimeBeforeNextSection);
			}
		}
	}

	private void OnNextSectionBegin()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			UBGUFunctionLibraryForCS.CallSectionManuallyChangeOnCrossSectionNotifies(bGUCharacterCS, MontageSectionCtrlData.NextSectionName);
		}
	}
}
