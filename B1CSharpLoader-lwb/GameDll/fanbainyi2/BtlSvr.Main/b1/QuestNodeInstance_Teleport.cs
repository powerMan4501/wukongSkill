using b1.Plugins.AsyncLoadingScreen;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_Teleport : QuestNodeInstance
{
	private bool bTeleportToOtherLevel { get; set; }

	private int TargetLevelID { get; set; }

	private bool bSaveArchiveAfterTeleport { get; set; }

	private string ScheduleLabel { get; set; }

	private string PointNameStr { get; set; }

	private bool bDropTeleportPoint { get; set; }

	private string DroppedTeleportPointId { get; set; }

	private int TargetRebirthPointId { get; set; }

	private bool bDontResetPlayerState { get; set; }

	private EGSLoadingScreenType LoadingScreenType { get; set; }

	private TStrongObjectPtr<UAnimMontage> BeforeTeleportMontage { get; } = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> AfterTeleportMontage { get; } = new TStrongObjectPtr<UAnimMontage>();

	private BGW_EventCollection BGWEventCollection { get; set; }

	private QuestCustom_Teleport CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_Teleport();
		CustomData.MergeFrom(base.Node.NodeData);
		PointNameStr = CustomData.PointName;
		bDropTeleportPoint = CustomData.IsDropTeleportPoint;
		DroppedTeleportPointId = CustomData.DroppedTeleportPointId;
		BeforeTeleportMontage.Set(ConvertSoftObjPath2Obj(CustomData.BeforeTeleportMontagePath) as UAnimMontage);
		AfterTeleportMontage.Set(ConvertSoftObjPath2Obj(CustomData.AfterTeleportMontagePath) as UAnimMontage);
		bTeleportToOtherLevel = CustomData.IsTeleportToOtherLevel;
		TargetLevelID = CustomData.TargetLevelId;
		bSaveArchiveAfterTeleport = CustomData.IsSaveArchiveAfterTeleport;
		ScheduleLabel = CustomData.ArchiveLabel;
		TargetRebirthPointId = CustomData.TargetRebirthPointId;
		bDontResetPlayerState = CustomData.DontResetPlayerState;
		LoadingScreenType = (EGSLoadingScreenType)CustomData.LoadingScreenType;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		Finish();
		BGWEventCollection = BGW_EventCollection.Get(base.Owner);
		if (BGWEventCollection != null)
		{
			FDreamTeleportInfo obj = new FDreamTeleportInfo
			{
				bTeleportToOtherLevel = bTeleportToOtherLevel,
				TargetLevelID = TargetLevelID
			};
			UAnimMontage uAnimMontage = BeforeTeleportMontage.Get();
			object beforeTeleportMontagePath;
			if ((object)uAnimMontage == null)
			{
				beforeTeleportMontagePath = null;
			}
			else
			{
				string pathName = uAnimMontage.PathName;
				beforeTeleportMontagePath = ((pathName != null) ? BGW_StringExtensions.ConvertLongPathNameToAssetPath(pathName) : null);
			}
			obj.BeforeTeleportMontagePath = (string)beforeTeleportMontagePath;
			UAnimMontage uAnimMontage2 = AfterTeleportMontage.Get();
			object afterTeleportMontagePath;
			if ((object)uAnimMontage2 == null)
			{
				afterTeleportMontagePath = null;
			}
			else
			{
				string pathName2 = uAnimMontage2.PathName;
				afterTeleportMontagePath = ((pathName2 != null) ? BGW_StringExtensions.ConvertLongPathNameToAssetPath(pathName2) : null);
			}
			obj.AfterTeleportMontagePath = (string)afterTeleportMontagePath;
			obj.TeleportName = PointNameStr;
			obj.bDropTeleportPoint = bDropTeleportPoint;
			obj.DroppedTeleportPointId = DroppedTeleportPointId;
			obj.bSaveArchiveAfterTeleport = bSaveArchiveAfterTeleport;
			obj.ScheduleLabel = ScheduleLabel;
			obj.TargetRebirthPointId = TargetRebirthPointId;
			obj.DontResetPlayerState = bDontResetPlayerState;
			obj.LoadingScreenType = LoadingScreenType;
			FDreamTeleportInfo dreamTeleportInfo = obj;
			BGWEventCollection.Evt_RequestDreamTeleport(dreamTeleportInfo);
		}
	}

	public override void Shutdown()
	{
		BeforeTeleportMontage.Set(null);
		AfterTeleportMontage.Set(null);
		Finish();
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		Finish();
	}
}
