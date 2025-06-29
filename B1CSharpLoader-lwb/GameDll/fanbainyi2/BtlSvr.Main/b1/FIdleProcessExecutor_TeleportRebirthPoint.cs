using System;
using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_TeleportRebirthPoint : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.TeleportRebirthPoint;

	private string BeforeTeleportMontage { get; set; }

	private string AfterTeleportMontage { get; set; }

	private bool bSaveArchiveAfterTeleport { get; set; }

	private string ArchiveLabel { get; set; }

	private string DropItemManageGuid { get; set; }

	private bool bDontResetPlayerState { get; set; }

	private int RebirthPointID { get; set; }

	private bool bTeleporting { get; set; }

	private BGW_EventCollection BGWEventCollection { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		bDontResetPlayerState = InIdleProcessAction.IsDontResetPlayerState;
		BeforeTeleportMontage = InIdleProcessAction.BeforeTeleportMontage;
		AfterTeleportMontage = InIdleProcessAction.AfterTeleportMontage;
		bSaveArchiveAfterTeleport = InIdleProcessAction.IsSaveArchiveAfterTeleport;
		ArchiveLabel = InIdleProcessAction.ArchiveLabel;
		DropItemManageGuid = InIdleProcessAction.DropItemManageGuid;
		RebirthPointID = InIdleProcessAction.RebirthPointId;
	}

	public override void Run(UObject InWorldContext)
	{
		BGWEventCollection = BGW_EventCollection.Get(InWorldContext);
		if (BGWEventCollection != null)
		{
			FDreamTeleportInfo dreamTeleportInfo = new FDreamTeleportInfo
			{
				bTeleportToOtherLevel = true,
				TargetLevelID = 0,
				BeforeTeleportMontagePath = BGW_StringExtensions.ConvertLongPathNameToAssetPath(BeforeTeleportMontage),
				AfterTeleportMontagePath = BGW_StringExtensions.ConvertLongPathNameToAssetPath(AfterTeleportMontage),
				TeleportName = "",
				bDropTeleportPoint = !string.IsNullOrEmpty(DropItemManageGuid),
				DroppedTeleportPointId = DropItemManageGuid,
				bSaveArchiveAfterTeleport = bSaveArchiveAfterTeleport,
				ScheduleLabel = ArchiveLabel,
				TargetRebirthPointId = RebirthPointID,
				DontResetPlayerState = bDontResetPlayerState
			};
			BGW_EventCollection bGWEventCollection = BGWEventCollection;
			bGWEventCollection.Evt_DreamTeleportFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_DreamTeleportFinished, new Del_Void(ODreamTeleportFinished));
			bTeleporting = true;
			BGWEventCollection.Evt_RequestDreamTeleport(dreamTeleportInfo);
		}
	}

	private void ODreamTeleportFinished()
	{
		bTeleporting = false;
		if (BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = BGWEventCollection;
			bGWEventCollection.Evt_DreamTeleportFinished = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_DreamTeleportFinished, new Del_Void(ODreamTeleportFinished));
		}
	}

	public override bool IsFinished()
	{
		return !bTeleporting;
	}

	public override void Shutdown(UObject InWorldContext)
	{
		if (bTeleporting)
		{
			ODreamTeleportFinished();
		}
	}
}
