using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_FoliageCameraFadeSystem : PlayerControllerSystemBase
{
	private const string MPC_PATH = "MaterialParameterCollection'/Game/00Main/GlobalMat/MatLibrary/MaterialParameterCollections/MPC_GlobalFoliageActor.MPC_GlobalFoliageActor'";

	private static FName FOLIAGE_CAM_FADE_DISTANCE = new FName("FoliageCameraFadeDistance");

	private BPS_GSEventCollection BPE;

	private BPC_FoliageCameraFadeData FoliageCameraFadeData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		FoliageCameraFadeData = RequireWritableControledPlayerStateData<BPC_FoliageCameraFadeData>();
		BPE = GetPlayerEventCollection();
		if (BPE != null)
		{
			BPE.Evt_BPS_EnableCameraFoliageFade += new Del_Void_Bool(OnEnableCameraFoliageFade);
			BPE.Evt_BPS_SetCameraFoliageFadeValue += new Del_Void_Float(SetCameraFoliageFadeValue);
		}
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		FoliageCameraFadeData.bEnableFoliageFade = true;
		FoliageCameraFadeData.CurrentFoliageFadeDistance = 0f;
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		FoliageCameraFadeData.FoliageFadeMPC = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UMaterialParameterCollection>("MaterialParameterCollection'/Game/00Main/GlobalMat/MatLibrary/MaterialParameterCollections/MPC_GlobalFoliageActor.MPC_GlobalFoliageActor'", ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, AsyncLoadFinishCallBack);
	}

	public override int GetTickGroupMask()
	{
		return 2;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GSGameplayCVar.CVar_FoliageFadeDebug.GetValueInGameThread() == 1 && FoliageCameraFadeData.FoliageFadeMPC != null)
		{
			UMaterialLibrary.GetScalarParameterValue(Owner, FoliageCameraFadeData.FoliageFadeMPC, FOLIAGE_CAM_FADE_DISTANCE);
		}
	}

	private void OnEnableCameraFoliageFade(bool Enable)
	{
		FoliageCameraFadeData.bEnableFoliageFade = Enable;
		if (!FoliageCameraFadeData.bEnableFoliageFade)
		{
			FoliageCameraFadeData.CurrentFoliageFadeDistance = 0f;
		}
		SetCameraFoliageFadeValueInternal(FoliageCameraFadeData.CurrentFoliageFadeDistance);
	}

	private void SetCameraFoliageFadeValue(float Value)
	{
		FoliageCameraFadeData.CurrentFoliageFadeDistance = Value;
		if (FoliageCameraFadeData.bEnableFoliageFade && FoliageCameraFadeData.FoliageFadeMPC != null)
		{
			SetCameraFoliageFadeValueInternal(Value);
		}
	}

	private void SetCameraFoliageFadeValueInternal(float Value)
	{
		UMaterialLibrary.SetScalarParameterValue(Owner, FoliageCameraFadeData.FoliageFadeMPC, FOLIAGE_CAM_FADE_DISTANCE, FoliageCameraFadeData.CurrentFoliageFadeDistance);
	}

	private void AsyncLoadFinishCallBack(int ReqID, UObject Obj)
	{
		if (Obj is UMaterialParameterCollection foliageFadeMPC)
		{
			FoliageCameraFadeData.FoliageFadeMPC = foliageFadeMPC;
			SetCameraFoliageFadeValueInternal(FoliageCameraFadeData.CurrentFoliageFadeDistance);
		}
	}
}
