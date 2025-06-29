using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_PlayerControllerB1")]
public class BGP_PlayerControllerB1 : BGP_PlayerControllerCS
{
	private static bool OnRep_PawnCS_IsValid;

	private static IntPtr OnRep_PawnCS_FunctionAddress;

	private static int OnRep_PawnCS_ParamsSize;

	private BGP_PlayerStateB1 PlayerStateB1 => base.PlayerState as BGP_PlayerStateB1;

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BPS_PlayerControllerDataCompB1>(this, B1GlobalFNames.PlayerControllerDataCompB1);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BPS_InputSystem(), 17);
		base.ActorCompContainerCS.AddComp(new BPS_OnlineActivitySystem());
		base.ActorCompContainerCS.AddComp(new BPS_ListenerMgrSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_RoleBaseInfoMangeSystem(), 2);
		base.ActorCompContainerCS.AddComp(new BPS_TransSystem(), 1);
		base.ActorCompContainerCS.AddComp(new BPS_TransSystemServer(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_RideSystem(), 1);
		base.ActorCompContainerCS.AddComp(new BPS_ServerPredictionKeyCacheSystem(), 4);
		base.ActorCompContainerCS.AddComp(new BPS_PlayerTagSystem());
		base.ActorCompContainerCS.AddComp(new BPS_IndeDropItemSystem(), 1);
		base.ActorCompContainerCS.AddComp(new BPS_PlayerAttrSystem(), 1);
		base.ActorCompContainerCS.AddComp(new BPS_OSSReportSystem());
		base.ActorCompContainerCS.AddComp(new BPS_PlayerTeleportSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_PlayerInteractComp(), 1);
		if (!B1Global.GIsBossRushMode)
		{
			base.ActorCompContainerCS.AddComp(new BPS_NavigationSystem(), 16);
		}
		base.ActorCompContainerCS.AddComp(new BPS_TamerStatSyncSystemClient(), 8, 4096);
		base.ActorCompContainerCS.AddComp(new BPS_TamerStatSyncSystemRemoteControl(), 1024, 4096);
		base.ActorCompContainerCS.AddComp(new BPS_PlayerPerformSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_RebirthPointSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_BattleMainInfoComp(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_FoliageCameraFadeSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_TransactionHoldSystem(), 128);
		base.ActorCompContainerCS.AddComp(new BPS_TransactionTaskExcuteSystem(), 144);
		base.ActorCompContainerCS.AddComp(new BPS_NetCloseSystem(), 8);
		base.ActorCompContainerCS.AddComp(new BPS_MapSymbolSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_GeoInfoSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_PostProcessMatComp(), 16);
		base.ActorCompContainerCS.AddComp(new b1.BPS_CameraSystem(), 16);
		base.ActorCompContainerCS.AddComp(new BPS_LiftTimeSystem());
		base.ActorCompContainerCS.AddComp(new BPS_MapAreaSystem());
		base.ActorCompContainerCS.AddComp(new BPS_MultiTargetProjectileCtrComp());
	}

	[USharpPath("/Script/b1-Managed.BGP_PlayerControllerB1:OnRep_PawnCS")]
	protected override void OnRep_PawnCS_Implementation()
	{
		base.OnRep_PawnCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_PlayerControllerB1:OnRep_PawnCS")]
	private static void OnRep_PawnCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_PlayerControllerB1 bGP_PlayerControllerB = GCHelper.Find<BGP_PlayerControllerB1>(obj);
		bGP_PlayerControllerB.OnRep_PawnCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGP_PlayerControllerB1");
		OnRep_PawnCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRep_PawnCS");
		OnRep_PawnCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PawnCS_FunctionAddress);
		OnRep_PawnCS_IsValid = OnRep_PawnCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_PlayerControllerB1:OnRep_PawnCS", OnRep_PawnCS_IsValid);
	}

	static BGP_PlayerControllerB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_PlayerControllerB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_PlayerControllerB1));
	}
}
