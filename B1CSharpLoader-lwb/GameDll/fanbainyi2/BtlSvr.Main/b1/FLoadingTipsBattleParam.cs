using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResB1;

namespace b1;

public class FLoadingTipsBattleParam
{
	public List<int> AbnormalStates = new List<int>();

	public int CastPlayerDeadSkillId;

	public int CastPlayerDeadBuffId;

	public int CastPlayerDeadUnitResId;

	public int AttackerRemainedHp;

	public int PlayerRemainedMp;

	public bool IsInSuperArmorState;

	public bool IsFallOrDeadZoneDead;

	public int LevelId;

	public int AttackerNumWithinRadius;

	public int RebirthPointId;

	public ELoadingTipsType LoadingTipsType;

	public TipsTriggerType TriggerType => ConvertToTipsTriggerType(LoadingTipsType);

	public void Reset()
	{
		AbnormalStates.Clear();
		CastPlayerDeadSkillId = 0;
		CastPlayerDeadBuffId = 0;
		CastPlayerDeadUnitResId = 0;
		AttackerRemainedHp = 0;
		PlayerRemainedMp = 0;
		IsInSuperArmorState = false;
		IsFallOrDeadZoneDead = false;
		LevelId = 0;
		AttackerNumWithinRadius = 0;
		RebirthPointId = 0;
		LoadingTipsType = ELoadingTipsType.None;
	}

	public static TipsTriggerType ConvertToTipsTriggerType(ELoadingTipsType LoadingTipsType)
	{
		switch (LoadingTipsType)
		{
		case ELoadingTipsType.None:
			return TipsTriggerType.None;
		case ELoadingTipsType.Death:
			return TipsTriggerType.Death;
		case ELoadingTipsType.BattleTeleport:
			return TipsTriggerType.Teleport;
		case ELoadingTipsType.StartUpTeleport:
		case ELoadingTipsType.PartyTeleport:
		case ELoadingTipsType.DisconnectTeleport:
			return TipsTriggerType.None;
		default:
			return TipsTriggerType.None;
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("AbnormalStates: " + string.Join(", ", AbnormalStates.OrderBy((int item) => item)));
		stringBuilder.AppendLine($"CastPlayerDeadSkillId: {CastPlayerDeadSkillId}");
		stringBuilder.AppendLine($"CastPlayerDeadBuffId: {CastPlayerDeadBuffId}");
		stringBuilder.AppendLine($"CastPlayerDeadUnitResId: {CastPlayerDeadUnitResId}");
		stringBuilder.AppendLine($"AttackerRemainedHp: {AttackerRemainedHp}");
		stringBuilder.AppendLine($"PlayerRemainedMp: {PlayerRemainedMp}");
		stringBuilder.AppendLine($"IsInSuperArmorState: {IsInSuperArmorState}");
		stringBuilder.AppendLine($"IsFallOrDeadZoneDead: {IsFallOrDeadZoneDead}");
		stringBuilder.AppendLine($"LevelId: {LevelId}");
		stringBuilder.AppendLine($"AttackerNumWithinRadius: {AttackerNumWithinRadius}");
		stringBuilder.AppendLine($"RebirthPointId: {RebirthPointId}");
		stringBuilder.AppendLine($"TriggerType: {TriggerType}");
		stringBuilder.AppendLine($"LoadingTipsType: {LoadingTipsType}");
		return stringBuilder.ToString();
	}
}
