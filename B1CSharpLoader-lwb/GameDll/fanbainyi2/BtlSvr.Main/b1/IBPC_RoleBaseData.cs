using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_RoleBaseData
{
	string RoleName { get; }

	ulong RoleId { get; }

	int RoleLevel { get; }

	int SoulSkillID { get; }

	BindDictEquipPosition_Int EquipList { get; }

	BindDictInt_Int TalenList { get; }
}
