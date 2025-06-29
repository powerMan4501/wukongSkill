using System;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UIControlSystemV2")]
internal class BUS_UIControlSystemV2 : UActorCompBaseUObj
{
	private BUC_AttrContainer AttrContainerData;

	private IBPC_PlayerTagData PlayerTagData;

	private BUC_UIControlData UIControlData;

	private BGW_UIEventCollection UIEC;

	private BUS_GSEventCollection BEC;

	private BPC_TransData BPCTransData;

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		AttrContainerData = RequireWritableData<BUC_AttrContainer>();
		UIControlData = RequireWritableData<BUC_UIControlData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		BPCTransData = RequireWritableControledPlayerStateData<BPC_TransData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UIEC = BGW_UIEventCollection.Get(this);
		BEC = BUS_EventCollectionCS.Get(this);
		BEC.Evt_DisplayDamageNumUIV2 += new Del_DisplayDamageNumUIV2(OnDisplayDamageNumUI);
		if (GetOwner() as BGUPlayerCharacterCS != null)
		{
			BEC.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
			BEC.Evt_UnitRebirthFinished += new Del_Void(OnUnitRebirthFinished);
			BEC.Evt_ScreenDebugDraw += new Del_ScreenDebugDraw(OnScreenDebugDraw);
			BEC.Evt_ResetScreenDebugDraw += new Del_Void(OnResetScreenDebugDraw);
			base.BGSEventCollection.Evt_BGS_GMInitTeam += new Del_BGS_Void(InitTeamPlayer);
		}
	}

	public override void PreBeginPlay()
	{
		base.OnBeginPlay();
		InitUIConytolData();
	}

	private void InitUIConytolData()
	{
		if (Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.OnlyShowByPlayer).Count >= 1)
		{
			UIControlData.SetOnlyShowByPlayer(NewValue: true);
		}
	}

	private void OnScreenDebugDraw(FVector2D Point, FLinearColor Color, float Size)
	{
		UIEC?.Evt_UI_ScreenDebugDraw(Point, Color, Size);
	}

	private void OnResetScreenDebugDraw()
	{
		UIEC?.Evt_UI_ResetScreenDebugDraw();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_GMInitTeam -= new Del_BGS_Void(InitTeamPlayer);
	}

	private void InitTeamPlayer()
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			GetIsLocalPlayer(out var IsPlayer, out var IsLocal);
			if (IsPlayer && !IsLocal)
			{
				UIEC?.Evt_UI_InitTopBarUI(ECSExtension.ToEntity(Owner));
			}
		}
	}

	private void GetIsLocalPlayer(out bool IsPlayer, out bool IsLocal)
	{
		IsPlayer = false;
		IsLocal = false;
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
		{
			IsPlayer = bGUPlayerCharacterCS.IsPlayerControlled();
			IsLocal = bGUPlayerCharacterCS.IsLocallyControlled();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateTransState();
	}

	public override void LateBeginPlay()
	{
		InitTeamPlayer();
	}

	private void UpdateTransState()
	{
		if (UIControlData == null || UIControlData.HasLateBeginPlay)
		{
			return;
		}
		if (GetOwner() is BGUPlayerCharacterCS bGUPlayerCharacterCS)
		{
			UIControlData.HasLateBeginPlay = bGUPlayerCharacterCS.ActorCompContainerCS.HasLateBeginPlay;
		}
		if (UIControlData.HasLateBeginPlay)
		{
			GetIsLocalPlayer(out var IsPlayer, out var IsLocal);
			if (IsPlayer && IsLocal && PlayerTagData != null && BPCTransData != null)
			{
				BPCTransData.IsTrans = PlayerTagData.HasTag(EBGPPlayerTag.Transforming);
				UIEC?.Evt_UI_TransStateChange();
			}
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (DeadReason == EDeadReason.OnlyDestroyUnit || DeadReason == EDeadReason.PlayerTrans)
		{
			return;
		}
		AActor owner = GetOwner();
		if (owner != null)
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = owner as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null && UGSE_EngineFuncLib.IsStandAlone(bGUPlayerCharacterCS.World))
			{
				UIControlData.SetActiveDeathUI(NewValue: true);
				UIEC?.Evt_UI_ActiveDeathUI(B1: true);
			}
		}
	}

	private void OnUnitRebirthFinished()
	{
		AActor owner = GetOwner();
		if (owner != null)
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = owner as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null && UGSE_EngineFuncLib.IsStandAlone(bGUPlayerCharacterCS.World))
			{
				UIControlData.SetActiveDeathUI(NewValue: false);
				UIEC?.Evt_UI_ActiveDeathUI(B1: false);
			}
		}
	}

	private void OnDisplayDamageNumUI(DamageNumParam Param)
	{
		UIEC?.Evt_UI_ShowHPChangeNum(Param);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_UIControlSystemV2");
	}

	static BUS_UIControlSystemV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_UIControlSystemV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_UIControlSystemV2));
	}
}
