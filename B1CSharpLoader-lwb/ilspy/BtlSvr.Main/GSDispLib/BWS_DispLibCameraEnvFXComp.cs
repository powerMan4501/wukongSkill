namespace GSDispLib;

public class BWS_DispLibCameraEnvFXComp : BWS_DispLibCompBase
{
	private BUC_DispLibDBCBaseData DBCBaseData;

	private BWC_DispLibCameraData DispLibCameraData;

	private BWC_DispLibDispWorldGlobalData GlobalData;

	public override void OnAttach()
	{
		DBCBaseData = RequireWritableData<BUC_DispLibDBCBaseData>();
		DispLibCameraData = RequireWritableData<BWC_DispLibCameraData>();
		GlobalData = RequireWritableData<BWC_DispLibDispWorldGlobalData>();
	}
}
