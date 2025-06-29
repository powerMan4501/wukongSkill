using CommB1;

namespace b1;

public class BPS_RoleBaseInfoMangeSystem : PlayerControllerSystemBase
{
	private BPC_RoleBaseData RoleBaseData;

	public override void OnAttach()
	{
		RoleBaseData = RequireWritableControledPlayerStateData<BPC_RoleBaseData>();
		RoleBaseData.RoleName = "";
		RoleBaseData.RoleId = 0uL;
		ReadOnlyRoleData readOnlyRoleData = RequireWritableData<BPC_PlayerRoleData>()?.RoleData;
		if (readOnlyRoleData == null)
		{
			return;
		}
		ReadOnlyRoleDataCS roleCs = readOnlyRoleData.RoleCs;
		if (roleCs == null)
		{
			return;
		}
		RoleBaseData.RoleName = roleCs.Base.Name;
		RoleBaseData.RoleId = roleCs.Base.Roleid;
		RoleBaseData.SoulSkillID = roleCs.Actor.Wear.WearSoulSkill.SoulSkillId;
		foreach (ReadOnlyWearEquip equip in roleCs.Actor.Wear.EquipList)
		{
			if (equip.Id != 0)
			{
				RoleBaseData.EquipList[equip.Position] = equip.Id;
			}
		}
		foreach (ReadOnlyTalentOne talen in roleCs.Actor.Progress.TalenList)
		{
			if (!RoleBaseData.TalenList.ContainsKey(talen.Id))
			{
				RoleBaseData.TalenList.Add(talen.Id, talen.Level);
			}
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}
}
