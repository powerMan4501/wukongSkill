using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_InputSystem : PlayerControllerSystemBase
{
	private AActor Player;

	private BPC_InputData InputData;

	public override void OnAttach()
	{
		base.OnAttach();
		InputData = RequireWritableLocalPlayerControlData<BPC_InputData>();
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_BPS_BeginCinematicIgnoreMode += new Del_Void_BoolBoolBool(BeginCinematicIgnoreMode);
			playerEventCollection.Evt_BPS_EndCinematicIgnoreMode += new Del_Void(EndCinematicIgnoreMode);
			playerEventCollection.Evt_BPS_SetInputDrawDebug += new Del_Void_Bool(OnSetInputDrawDebug);
		}
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnPossessed);
	}

	public override void PreBeginPlay()
	{
		InputData.Init(UGameplayStatics.GetGameInstance(Owner) as BGWGameInstanceCS);
	}

	public override void OnBeginPlay()
	{
		BGW_EnhancedInputMgrV2 bGW_EnhancedInputMgrV = BGW_EnhancedInputMgrV2.Get(Owner);
		foreach (FUStEnhancedInputActionDesc value in BGW_GameDB.GetAllEnhancedInputActionDesc().Values)
		{
			bGW_EnhancedInputMgrV.BindBattleAction(value.ActionName, value.EnhancedTriggerEvent);
		}
		BGW_EventCollection.Get(Owner).Evt_RegisterBattleCallback(TriggerInputAction);
		BGUCharacterCS bGUCharacterCS = (GetOwner() as BGP_PlayerControllerB1)?.GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			Player = bGUCharacterCS;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_OnUnitTransited -= new Del_BGS_OnUnitTransited(OnPossessed);
	}

	private void OnPossessed(AActor OldActor, AActor CurActor)
	{
		if (CurActor != null)
		{
			Player = CurActor;
		}
	}

	private void TriggerInputAction(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		if (!Player.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(Player)?.Evt_TriggerInputActionImpl.Invoke(ActionName, TriggerEvent, Value);
		}
	}

	private void BeginCinematicIgnoreMode(bool bDisableMovementInput, bool bDisableLookAtInput, bool bDisableInteractInput)
	{
		BGW_EventCollection.Get(Owner).Evt_BeginBlockCinematicInput(bDisableMovementInput, bDisableLookAtInput, bDisableInteractInput);
	}

	private void EndCinematicIgnoreMode()
	{
		BGW_EventCollection.Get(Owner).Evt_EndBlockCinematicInput();
	}

	private void OnSetInputDrawDebug(bool bEnableDebug)
	{
		InputData.DebugDraw = bEnableDebug;
	}
}
