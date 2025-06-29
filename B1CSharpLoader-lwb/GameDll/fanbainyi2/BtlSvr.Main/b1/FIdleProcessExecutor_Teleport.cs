using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_Teleport : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.Teleport;

	private bool bTeleportToOtherLevel { get; set; }

	private int TargetLevelID { get; set; }

	private string PointName { get; set; }

	private string BeforeTeleportMontage { get; set; }

	private string AfterTeleportMontage { get; set; }

	private bool bSaveArchiveAfterTeleport { get; set; }

	private string ArchiveLabel { get; set; }

	private string DropItemManageGuid { get; set; }

	private bool bDontResetPlayerState { get; set; }

	private EGSLoadingScreenType LoadingScreenType { get; set; }

	private List<int> TeleportLoadingTips { get; set; }

	private bool bTeleporting { get; set; }

	private BGW_EventCollection BGWEventCollection { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		bTeleportToOtherLevel = InIdleProcessAction.IsTeleportToOtherLevel;
		bDontResetPlayerState = InIdleProcessAction.IsDontResetPlayerState;
		LoadingScreenType = (EGSLoadingScreenType)InIdleProcessAction.LoadingScreenType;
		TeleportLoadingTips = InIdleProcessAction.TeleportLoadingTips.ToList();
		TargetLevelID = InIdleProcessAction.TargetLevelId;
		PointName = InIdleProcessAction.PointName;
		BeforeTeleportMontage = InIdleProcessAction.BeforeTeleportMontage;
		AfterTeleportMontage = InIdleProcessAction.AfterTeleportMontage;
		bSaveArchiveAfterTeleport = InIdleProcessAction.IsSaveArchiveAfterTeleport;
		ArchiveLabel = InIdleProcessAction.ArchiveLabel;
		DropItemManageGuid = InIdleProcessAction.DropItemManageGuid;
	}

	public override void Run(UObject InWorldContext)
	{
		BGWEventCollection = BGW_EventCollection.Get(InWorldContext);
		if (BGWEventCollection != null)
		{
			FDreamTeleportInfo dreamTeleportInfo = new FDreamTeleportInfo
			{
				bTeleportToOtherLevel = bTeleportToOtherLevel,
				TargetLevelID = TargetLevelID,
				BeforeTeleportMontagePath = BGW_StringExtensions.ConvertLongPathNameToAssetPath(BeforeTeleportMontage),
				AfterTeleportMontagePath = BGW_StringExtensions.ConvertLongPathNameToAssetPath(AfterTeleportMontage),
				TeleportName = PointName,
				bDropTeleportPoint = !string.IsNullOrEmpty(DropItemManageGuid),
				DroppedTeleportPointId = DropItemManageGuid,
				bSaveArchiveAfterTeleport = bSaveArchiveAfterTeleport,
				ScheduleLabel = ArchiveLabel,
				TargetRebirthPointId = 0,
				DontResetPlayerState = bDontResetPlayerState,
				LoadingScreenType = LoadingScreenType,
				TeleportLoadingTips = TeleportLoadingTips
			};
			BGW_EventCollection bGWEventCollection = BGWEventCollection;
			bGWEventCollection.Evt_DreamTeleportFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_DreamTeleportFinished, new Del_Void(ODreamTeleportFinished));
			bTeleporting = true;
			BGWEventCollection.Evt_RequestDreamTeleport(dreamTeleportInfo);
		}
	}

	public override void ResetRun(UObject InWorldContext)
	{
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
