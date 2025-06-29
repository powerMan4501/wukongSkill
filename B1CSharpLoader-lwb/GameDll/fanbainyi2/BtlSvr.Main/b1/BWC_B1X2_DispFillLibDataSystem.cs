using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BWC_B1X2_DispFillLibDataSystem : BWS_DispLibCompBase
{
	private BWC_DispLibCameraData DispLibCameraData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		base.OnAttach();
		DispLibCameraData = BGU_DataUtil.GetReadOnlyData<BWC_DispLibCameraData>(DispLibDispWorld.GetInstance(GetOwner()));
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DispLibCameraData.CameraComp.Set(null);
		DispLibCameraData.CameraActor.Set(null);
		DispLibCameraData.SceneCaptureComp2D.Set(null);
		if (DispLibCameraData.PlayerCameraManager.Get().IsNullOrDestroyed())
		{
			DispLibCameraData.PlayerCameraManager.Set(UGSE_EngineFuncLib.GetLocalPlayerCameraManager(GetOwner()));
		}
		if (DispLibCameraData.PlayerController.Get().IsNullOrDestroyed())
		{
			DispLibCameraData.PlayerController.Set(UnrealGameplayData.GetFirstLocalPlayerController());
		}
		if (DispLibCameraData.PlayerController.IsValid())
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = DispLibCameraData.PlayerController.Get().GetViewTarget() as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null)
			{
				DispLibCameraData.CameraComp.Set(bGUPlayerCharacterCS.GetFollowCamera());
				DispLibCameraData.CameraActor.Set(bGUPlayerCharacterCS);
			}
		}
	}
}
