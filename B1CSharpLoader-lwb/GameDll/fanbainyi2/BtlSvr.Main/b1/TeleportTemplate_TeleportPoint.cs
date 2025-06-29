using b1.BGU.BUActor;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_TeleportPoint : TeleportTemplateBase
{
	private TeleportParam_TeleportNamedPoint TeleportParam => (TeleportParam_TeleportNamedPoint)(object)UserData;

	public override int GetTargetLevelId()
	{
		return TeleportParam.LevelId;
	}

	public override FTransform ChoosePlayerTeleportTransform()
	{
		BGWTeleportNamedPoint[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGWTeleportNamedPoint>(GameInst);
		foreach (BGWTeleportNamedPoint bGWTeleportNamedPoint in allActorsOfClass)
		{
			if (bGWTeleportNamedPoint.GetGSActorLablel() == TeleportParam.TeleportPointName.ToString() || bGWTeleportNamedPoint.TeleportID == TeleportParam.TeleportPointName)
			{
				return bGWTeleportNamedPoint.GetActorTransform();
			}
		}
		BGW_LogUtil.LogError("TeleportTemplate_TeleportPoint ChoosePlayerTeleportTransform Not Found Use Default PlayerStart Instead!!!");
		return base.ChoosePlayerTeleportTransform();
	}
}
