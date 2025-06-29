using b1;
using b1.BGW;
using UnrealEngine.Engine;

namespace GSDispLib;

internal class BWS_DispLibDynamicEnvSystem : BWS_DispLibCompBase
{
	public float TickVolumeInterval = 1f;

	private float TimeOfDay;

	private UBWS_DispLibEnvSystemConf EnvSystemConf;

	private const string ENV_CONF_PATH = "/Game/GSMobileMatLib/Env/DayNight/Conf/DA_EnvSystemConf.DA_EnvSystemConf";

	private const string ENV_MGR_PATH = "/Game/GSMobileMatLib/Env/DayNight/BP_DispLibDynamicEnvManager.BP_DispLibDynamicEnvManager";

	private ABWC_DispLibDynamicEnvManager EnvManager;

	private bool HasWeather;

	public float CurrentTimeZoneDuration;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		AActor owner = GetOwner();
		EnvSystemConf = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UBWS_DispLibEnvSystemConf>("/Game/GSMobileMatLib/Env/DayNight/Conf/DA_EnvSystemConf.DA_EnvSystemConf", ELoadResourceType.SyncLoadAndCache);
		EnvManager = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<ABWC_DispLibDynamicEnvManager>("/Game/GSMobileMatLib/Env/DayNight/BP_DispLibDynamicEnvManager.BP_DispLibDynamicEnvManager", ELoadResourceType.SyncLoadAndCache);
		_ = EnvManager != null;
	}
}
