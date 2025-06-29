using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;

namespace b1;

public class BPS_LevelStreamingSystem : PlayerControllerSystemBase
{
	public override void OnAttach()
	{
		base.OnAttach();
		ClientSetBlockOnAsyncLoading();
	}

	public void ClientSetBlockOnAsyncLoading()
	{
		if (UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			UGSE_LoadingUtilFuncLib.ClientSetBlockOnAsyncLoading(Owner as APlayerController);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (BGWGameInstanceCS.Get(Owner).GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			UGSE_LoadingUtilFuncLib.ClientSetBlockOnAsyncLoading(Owner as APlayerController);
		}
	}
}
