using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_ReplayPlayerController")]
public class BGP_ReplayPlayerController : BGP_PlayerControllerCS
{
	private static bool OnRep_PawnCS_IsValid;

	private static IntPtr OnRep_PawnCS_FunctionAddress;

	private static int OnRep_PawnCS_ParamsSize;

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BPS_ReplayPlayerControllerDataComp>(this, B1GlobalFNames.ReplayPlayerControllerDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	[USharpPath("/Script/b1-Managed.BGP_ReplayPlayerController:OnRep_PawnCS")]
	protected override void OnRep_PawnCS_Implementation()
	{
		base.OnRep_PawnCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGP_ReplayPlayerController:OnRep_PawnCS")]
	private static void OnRep_PawnCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGP_ReplayPlayerController bGP_ReplayPlayerController = GCHelper.Find<BGP_ReplayPlayerController>(obj);
		bGP_ReplayPlayerController.OnRep_PawnCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGP_ReplayPlayerController");
		OnRep_PawnCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRep_PawnCS");
		OnRep_PawnCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PawnCS_FunctionAddress);
		OnRep_PawnCS_IsValid = OnRep_PawnCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGP_ReplayPlayerController:OnRep_PawnCS", OnRep_PawnCS_IsValid);
	}

	static BGP_ReplayPlayerController()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_ReplayPlayerController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_ReplayPlayerController));
	}
}
