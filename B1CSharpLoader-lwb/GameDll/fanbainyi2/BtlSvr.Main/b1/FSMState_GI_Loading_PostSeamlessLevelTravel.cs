using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_PostSeamlessLevelTravel : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		BWC_DispLibDispWorldGlobalData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BWC_DispLibDispWorldGlobalData>(DispLibDispWorld.GetInstance(Context.OwnerUObj));
		unPersistentReadOnlyData.Init(Context.OwnerUObj, unPersistentReadOnlyData.WEFMLod);
		BGU_DataUtil.GetGameStateReadonlyData<BGC_UnrealGameplayData>(Context.OwnerUObj).Init(UGameplayStatics.GetGameState(Context.OwnerUObj) as ABGWGameState);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context.OwnerUObj);
		firstLocalPlayerController.SetViewTargetWithBlend(firstLocalPlayerController.GetControlledPawn());
		BUC_PlayerCameraData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(firstLocalPlayerController.GetControlledPawn());
		BUS_ExtendConfigComp componentByClass = firstLocalPlayerController.GetControlledPawn().GetComponentByClass<BUS_ExtendConfigComp>();
		GSCameraGraph cameraGraph = UObject.NewObject<GSCameraGraph>(Context.OwnerUObj, componentByClass.CameraGraphClass.Value, default(FName), EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
		unPersistentReadOnlyData2.CameraGraph = cameraGraph;
		BGW_EventCollection.Get(Context.OwnerUObj).Evt_PostSeamlessTravel();
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
