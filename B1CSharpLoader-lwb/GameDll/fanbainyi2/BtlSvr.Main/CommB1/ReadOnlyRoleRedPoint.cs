using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleRedPoint
{
	private RoleRedPoint mData;

	private ReadOnlyInt32List _ItemList;

	private ReadOnlyInt32List _EquipList;

	private ReadOnlyInt32List _SpellList;

	private ReadOnlyInt32List _AttrList;

	private ReadOnlyInt32List _ShopItemList;

	private ReadOnlyInt32List _CollectionList;

	private ReadOnlyInt32List _LegacyList;

	private ReadOnlyInt32List _LegacyTalentList;

	private ReadOnlyInt32List _MeditationList;

	private ReadOnlyInt32List _CardStoryList;

	private ReadOnlyInt32List _SoulSkillList;

	private ReadOnlyInt32List _CanActivateEquipList;

	private ReadOnlyInt32List _RecipeList;

	private ReadOnlyInt32List _NewLegacyList;

	private ReadOnlyInt32List _LegacyTalentPointList;

	private ReadOnlyInt32List _CanBuildWeaponList;

	private ReadOnlyInt32List _ShrineSpellList;

	private ReadOnlyInt32List _InteractionFuncList;

	private ReadOnlyInt32List _RefightIdList;

	private ReadOnlyInt32List _ContinuousFightIdList;

	private ReadOnlyInt32List _RefightRecordIdList;

	private ReadOnlyInt32List _ContinuousFightRecordIdList;

	public ReadOnlyInt32List ItemList
	{
		get
		{
			if (_ItemList == null)
			{
				_ItemList = new ReadOnlyInt32List(mData.ItemList);
			}
			return _ItemList;
		}
	}

	public ReadOnlyInt32List EquipList
	{
		get
		{
			if (_EquipList == null)
			{
				_EquipList = new ReadOnlyInt32List(mData.EquipList);
			}
			return _EquipList;
		}
	}

	public ReadOnlyInt32List SpellList
	{
		get
		{
			if (_SpellList == null)
			{
				_SpellList = new ReadOnlyInt32List(mData.SpellList);
			}
			return _SpellList;
		}
	}

	public ReadOnlyInt32List AttrList
	{
		get
		{
			if (_AttrList == null)
			{
				_AttrList = new ReadOnlyInt32List(mData.AttrList);
			}
			return _AttrList;
		}
	}

	public ReadOnlyInt32List ShopItemList
	{
		get
		{
			if (_ShopItemList == null)
			{
				_ShopItemList = new ReadOnlyInt32List(mData.ShopItemList);
			}
			return _ShopItemList;
		}
	}

	public ReadOnlyInt32List CollectionList
	{
		get
		{
			if (_CollectionList == null)
			{
				_CollectionList = new ReadOnlyInt32List(mData.CollectionList);
			}
			return _CollectionList;
		}
	}

	public ReadOnlyInt32List LegacyList
	{
		get
		{
			if (_LegacyList == null)
			{
				_LegacyList = new ReadOnlyInt32List(mData.LegacyList);
			}
			return _LegacyList;
		}
	}

	public ReadOnlyInt32List LegacyTalentList
	{
		get
		{
			if (_LegacyTalentList == null)
			{
				_LegacyTalentList = new ReadOnlyInt32List(mData.LegacyTalentList);
			}
			return _LegacyTalentList;
		}
	}

	public ReadOnlyInt32List MeditationList
	{
		get
		{
			if (_MeditationList == null)
			{
				_MeditationList = new ReadOnlyInt32List(mData.MeditationList);
			}
			return _MeditationList;
		}
	}

	public ReadOnlyInt32List CardStoryList
	{
		get
		{
			if (_CardStoryList == null)
			{
				_CardStoryList = new ReadOnlyInt32List(mData.CardStoryList);
			}
			return _CardStoryList;
		}
	}

	public ReadOnlyInt32List SoulSkillList
	{
		get
		{
			if (_SoulSkillList == null)
			{
				_SoulSkillList = new ReadOnlyInt32List(mData.SoulSkillList);
			}
			return _SoulSkillList;
		}
	}

	public ReadOnlyInt32List CanActivateEquipList
	{
		get
		{
			if (_CanActivateEquipList == null)
			{
				_CanActivateEquipList = new ReadOnlyInt32List(mData.CanActivateEquipList);
			}
			return _CanActivateEquipList;
		}
	}

	public ReadOnlyInt32List RecipeList
	{
		get
		{
			if (_RecipeList == null)
			{
				_RecipeList = new ReadOnlyInt32List(mData.RecipeList);
			}
			return _RecipeList;
		}
	}

	public ReadOnlyInt32List NewLegacyList
	{
		get
		{
			if (_NewLegacyList == null)
			{
				_NewLegacyList = new ReadOnlyInt32List(mData.NewLegacyList);
			}
			return _NewLegacyList;
		}
	}

	public ReadOnlyInt32List LegacyTalentPointList
	{
		get
		{
			if (_LegacyTalentPointList == null)
			{
				_LegacyTalentPointList = new ReadOnlyInt32List(mData.LegacyTalentPointList);
			}
			return _LegacyTalentPointList;
		}
	}

	public ReadOnlyInt32List CanBuildWeaponList
	{
		get
		{
			if (_CanBuildWeaponList == null)
			{
				_CanBuildWeaponList = new ReadOnlyInt32List(mData.CanBuildWeaponList);
			}
			return _CanBuildWeaponList;
		}
	}

	public ReadOnlyInt32List ShrineSpellList
	{
		get
		{
			if (_ShrineSpellList == null)
			{
				_ShrineSpellList = new ReadOnlyInt32List(mData.ShrineSpellList);
			}
			return _ShrineSpellList;
		}
	}

	public ReadOnlyInt32List InteractionFuncList
	{
		get
		{
			if (_InteractionFuncList == null)
			{
				_InteractionFuncList = new ReadOnlyInt32List(mData.InteractionFuncList);
			}
			return _InteractionFuncList;
		}
	}

	public ReadOnlyInt32List RefightIdList
	{
		get
		{
			if (_RefightIdList == null)
			{
				_RefightIdList = new ReadOnlyInt32List(mData.RefightIdList);
			}
			return _RefightIdList;
		}
	}

	public ReadOnlyInt32List ContinuousFightIdList
	{
		get
		{
			if (_ContinuousFightIdList == null)
			{
				_ContinuousFightIdList = new ReadOnlyInt32List(mData.ContinuousFightIdList);
			}
			return _ContinuousFightIdList;
		}
	}

	public ReadOnlyInt32List RefightRecordIdList
	{
		get
		{
			if (_RefightRecordIdList == null)
			{
				_RefightRecordIdList = new ReadOnlyInt32List(mData.RefightRecordIdList);
			}
			return _RefightRecordIdList;
		}
	}

	public ReadOnlyInt32List ContinuousFightRecordIdList
	{
		get
		{
			if (_ContinuousFightRecordIdList == null)
			{
				_ContinuousFightRecordIdList = new ReadOnlyInt32List(mData.ContinuousFightRecordIdList);
			}
			return _ContinuousFightRecordIdList;
		}
	}

	public ReadOnlyRoleRedPoint(RoleRedPoint data)
	{
		mData = data;
	}

	public ReadOnlyRoleRedPoint Clone()
	{
		return new ReadOnlyRoleRedPoint(mData.Clone());
	}

	public RoleRedPoint ForceGetRef()
	{
		return mData;
	}

	public RoleRedPoint CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleRedPoint>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ItemList=[\n");
		for (int i = 0; i < ItemList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ItemList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("EquipList=[\n");
		for (int j = 0; j < EquipList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", EquipList[j]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SpellList=[\n");
		for (int k = 0; k < SpellList.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SpellList[k]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("AttrList=[\n");
		for (int l = 0; l < AttrList.Count; l++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", AttrList[l]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ShopItemList=[\n");
		for (int m = 0; m < ShopItemList.Count; m++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ShopItemList[m]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("CollectionList=[\n");
		for (int n = 0; n < CollectionList.Count; n++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CollectionList[n]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("LegacyList=[\n");
		for (int num = 0; num < LegacyList.Count; num++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", LegacyList[num]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("LegacyTalentList=[\n");
		for (int num2 = 0; num2 < LegacyTalentList.Count; num2++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", LegacyTalentList[num2]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MeditationList=[\n");
		for (int num3 = 0; num3 < MeditationList.Count; num3++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", MeditationList[num3]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("CardStoryList=[\n");
		for (int num4 = 0; num4 < CardStoryList.Count; num4++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CardStoryList[num4]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SoulSkillList=[\n");
		for (int num5 = 0; num5 < SoulSkillList.Count; num5++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SoulSkillList[num5]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("CanActivateEquipList=[\n");
		for (int num6 = 0; num6 < CanActivateEquipList.Count; num6++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CanActivateEquipList[num6]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("RecipeList=[\n");
		for (int num7 = 0; num7 < RecipeList.Count; num7++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", RecipeList[num7]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("NewLegacyList=[\n");
		for (int num8 = 0; num8 < NewLegacyList.Count; num8++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", NewLegacyList[num8]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("LegacyTalentPointList=[\n");
		for (int num9 = 0; num9 < LegacyTalentPointList.Count; num9++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", LegacyTalentPointList[num9]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("CanBuildWeaponList=[\n");
		for (int num10 = 0; num10 < CanBuildWeaponList.Count; num10++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CanBuildWeaponList[num10]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ShrineSpellList=[\n");
		for (int num11 = 0; num11 < ShrineSpellList.Count; num11++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ShrineSpellList[num11]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("InteractionFuncList=[\n");
		for (int num12 = 0; num12 < InteractionFuncList.Count; num12++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", InteractionFuncList[num12]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("RefightIdList=[\n");
		for (int num13 = 0; num13 < RefightIdList.Count; num13++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", RefightIdList[num13]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ContinuousFightIdList=[\n");
		for (int num14 = 0; num14 < ContinuousFightIdList.Count; num14++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ContinuousFightIdList[num14]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("RefightRecordIdList=[\n");
		for (int num15 = 0; num15 < RefightRecordIdList.Count; num15++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", RefightRecordIdList[num15]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ContinuousFightRecordIdList=[\n");
		for (int num16 = 0; num16 < ContinuousFightRecordIdList.Count; num16++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ContinuousFightRecordIdList[num16]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent);
		builder.Append("},\n");
	}

	public string GSToString(int indent = 4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		DumpAsString(stringBuilder, indent, 0);
		stringBuilder.Insert(0, "\n", 1);
		return stringBuilder.ToString();
	}
}
