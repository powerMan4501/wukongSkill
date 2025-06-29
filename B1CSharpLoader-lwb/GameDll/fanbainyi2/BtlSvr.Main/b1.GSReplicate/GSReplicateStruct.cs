using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;

namespace b1.GSReplicate;

public class GSReplicateStruct
{
	private static List<object> StructDefs = new List<object>();

	public static void GenDefs()
	{
		StructDefs.Add(new GSBindDictionary<EBGUAttrFloat, float>());
		StructDefs.Add(new GSBindList<float>());
		StructDefs.Add(new GSBindList<bool>());
		StructDefs.Add(new GSBindDictionary<int, bool>());
		StructDefs.Add(new GSBindList<Entity>());
		StructDefs.Add(new GSBindListWithNetRole<Entity>());
		StructDefs.Add(new GSBindDictionary<int, Entity>());
		StructDefs.Add(new GSBindDictionary<EBGUSimpleState, int>());
		StructDefs.Add(new GSBindListWithNetRole<float>());
		StructDefs.Add(new GSBindList<int>());
		StructDefs.Add(new GSBindDictionary<EquipPosition, int>());
		StructDefs.Add(new GSBindDictionary<int, int>());
		StructDefs.Add(new GSBindList<GSBindList<Entity>>());
		StructDefs.Add(new GSBindDictionary<int, GSBindList<GSBindList<Entity>>>());
		StructDefs.Add(new GSBindListWithNetRole<GSBindList<int>>());
		StructDefs.Add(new GSBindList<UnitLockTargetInfo>());
		StructDefs.Add(new GSBindList<GSBindList<UnitLockTargetInfo>>());
		StructDefs.Add(new GSBindList<FRepInnerClass>());
		StructDefs.Add(new GSBindDictionary<string, string>());
		StructDefs.Add(new GSBindDictionary<SpellType, int>());
		StructDefs.Add(new GSBindList<string>());
		StructDefs.Add(new GSBindDictionary<string, GSBindList<string>>());
		StructDefs.Add(new GSBindDictionary<int, ChallengeInfo>());
		StructDefs.Add(new GSBindDictionary<int, EChallengeState>());
		StructDefs.Add(new GSBindList<UnitHatredTargetInfo>());
		StructDefs.Add(new GSBindDictionary<int, BuffInstData>());
		StructDefs.Add(new GSBindDictionary<EPropType, uint>());
		StructDefs.Add(new GSBindDictionary<string, int>());
		StructDefs.Add(new GSBindDictionary<int, CollectionGroupDataInfo>());
		StructDefs.Add(new GSBindList<PlayerPersistentAttr>());
		StructDefs.Add(new GSBindList<PlayerMagicSkillCd>());
		StructDefs.Add(new GSBindListWithNetRole<int>());
		StructDefs.Add(new GSBindDictionary<string, bool>());
		StructDefs.Add(new GSBindDictionary<string, FCrusadeUnitInfo>());
		StructDefs.Add(new GSBindList<PlayerTransactionBase>());
		StructDefs.Add(new GSBindList<PlayerTransactionTaskBase>());
		StructDefs.Add(new GSBindDictionary<string, EMapSymbolState>());
		StructDefs.Add(new GSBindDictionary<string, EMapSymbolActiveState>());
		StructDefs.Add(new GSBindDictionary<int, GSUnitBookData>());
		StructDefs.Add(new GSBindList<GeoInfoAreaData>());
		StructDefs.Add(new GSBindList<GeoInfoCustomData>());
	}
}
