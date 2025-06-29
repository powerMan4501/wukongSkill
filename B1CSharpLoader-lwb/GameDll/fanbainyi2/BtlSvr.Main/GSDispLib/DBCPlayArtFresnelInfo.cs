using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayArtFresnelInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_PlayArtFresnel SourceRequest;

	public uint UAFID;

	public bool HasSpawn;

	public DispLibDBCEndMode EndMode;

	public DBCPlayArtFresnelInfo(float CurTime, uint _IdentityID, BUC_DispLibDBC_PlayArtFresnel _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		PlayAtTime = CurTime + SourceRequest.Delay;
		PausePriority = SourceRequest.PausePriority;
		EndMode = SourceRequest.EndMode;
		float num = ((SourceRequest.OverrideTime > 0f) ? SourceRequest.OverrideTime : SourceRequest.CustomUAFDataAsset.Time);
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
		{
			EndAtTime = PlayAtTime + num;
		}
		else
		{
			EndAtTime = -1f;
		}
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}
