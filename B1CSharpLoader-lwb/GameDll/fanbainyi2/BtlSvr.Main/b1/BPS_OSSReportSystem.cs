using b1.EventDelDefine;
using OssB1;

namespace b1;

public class BPS_OSSReportSystem : PlayerControllerSystemBase
{
	private BPC_PlayerRoleData PlayerRoleData;

	private IBPC_RoleBaseData PlayerRoleBaseData;

	public override void OnAttach()
	{
		PlayerRoleData = RequireWritableLocalPlayerControlData<BPC_PlayerRoleData>();
		PlayerRoleBaseData = RequireReadOnlyPlayerStateData<IBPC_RoleBaseData, BPC_RoleBaseData>();
		GetPlayerEventCollection().Evt_SetOSSSlevelLeaveData += new Del_Void_IntInt(OnSetOSSSlevelLeaveData);
		GetPlayerEventCollection().Evt_SetOSSRebirthPointData += new Del_OSSRebirthPoint(OnSetOSSRebirthPointData);
		GetPlayerEventCollection().Evt_SetOSSSceneWidgetData += new Del_Void_Int_Str(OnSetOSSSceneWidgetData);
	}

	private void OnSetOSSSlevelLeaveData(int OldMapId, int OldMapAreaId)
	{
		ReportEventSlevelLeave reportEventSlevelLeave = new ReportEventSlevelLeave();
		reportEventSlevelLeave.RoleId = PlayerRoleBaseData.RoleId;
		reportEventSlevelLeave.StayTime = PlayerRoleData.GetGameTotalTime() - PlayerRoleData.BeginAreaStayTime;
		reportEventSlevelLeave.LevelAreaId = OldMapAreaId;
		reportEventSlevelLeave.LevelMapId = OldMapId;
		EventReporter.GetInstance(Owner).SlevelLeave(reportEventSlevelLeave);
	}

	private void OnSetOSSRebirthPointData(int RebirthPointConfigId, bool bActiveState)
	{
		ReportEventInteract reportEventInteract = new ReportEventInteract();
		reportEventInteract.RoleId = PlayerRoleBaseData.RoleId;
		reportEventInteract.IsFirst = ((!bActiveState) ? 1 : 0);
		reportEventInteract.LastDur = PlayerRoleData.GetGameTotalTime() - PlayerRoleData.LastRebirthPointTime;
		PlayerRoleData.LastRebirthPointTime = PlayerRoleData.GetGameTotalTime();
		reportEventInteract.Type = InteractType.RevivePoint;
		reportEventInteract.InteractId = RebirthPointConfigId;
		EventReporter.GetInstance(Owner).Interact(reportEventInteract);
	}

	private void OnSetOSSSceneWidgetData(int InteractId, string Guid)
	{
		if (Guid != null)
		{
			ReportEventInteract reportEventInteract = new ReportEventInteract();
			reportEventInteract.RoleId = PlayerRoleBaseData.RoleId;
			reportEventInteract.LastDur = PlayerRoleData.GetGameTotalTime() - PlayerRoleData.LastRebirthPointTime;
			reportEventInteract.Type = InteractType.SceneWidget;
			reportEventInteract.InteractId = InteractId;
			reportEventInteract.Guid = Guid;
			EventReporter.GetInstance(Owner).Interact(reportEventInteract);
		}
	}
}
