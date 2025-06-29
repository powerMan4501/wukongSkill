using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCScenePhysicalInteractorInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_ScenePhysicalInteractor SourceRequest { get; set; }

	public DBCScenePhysicalInteractorInfo(float CurTime, BUC_DispLibDBC_ScenePhysicalInteractor _Request, USceneComponent _SourceDispOwnerComp)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		SourceRequest = _Request;
		PlayAtTime = CurTime + _Request.Delay;
		PausePriority = SourceRequest.PausePriority;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}
