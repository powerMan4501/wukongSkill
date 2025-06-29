using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleBag
{
	private RoleBag mData;

	private ReadOnlyRoleMoneyList _MoneyList;

	private ReadOnlyRoleItemList _ItemList;

	private ReadOnlyRoleEquipList _EquipList;

	private ReadOnlyAttrItemList _AttrList;

	private ReadOnlyRoleWineList _WineList;

	private ReadOnlyRoleBagInfo _Info;

	private ReadOnlyRoleSoulSkillList _SoulSkillList;

	public ReadOnlyRoleMoneyList MoneyList
	{
		get
		{
			if (_MoneyList == null)
			{
				_MoneyList = new ReadOnlyRoleMoneyList(mData.MoneyList);
			}
			return _MoneyList;
		}
	}

	public ReadOnlyRoleItemList ItemList
	{
		get
		{
			if (_ItemList == null)
			{
				_ItemList = new ReadOnlyRoleItemList(mData.ItemList);
			}
			return _ItemList;
		}
	}

	public ReadOnlyRoleEquipList EquipList
	{
		get
		{
			if (_EquipList == null)
			{
				_EquipList = new ReadOnlyRoleEquipList(mData.EquipList);
			}
			return _EquipList;
		}
	}

	public ReadOnlyAttrItemList AttrList
	{
		get
		{
			if (_AttrList == null)
			{
				_AttrList = new ReadOnlyAttrItemList(mData.AttrList);
			}
			return _AttrList;
		}
	}

	public ReadOnlyRoleWineList WineList
	{
		get
		{
			if (_WineList == null)
			{
				_WineList = new ReadOnlyRoleWineList(mData.WineList);
			}
			return _WineList;
		}
	}

	public ReadOnlyRoleBagInfo Info
	{
		get
		{
			if (_Info == null && mData.Info != null)
			{
				_Info = new ReadOnlyRoleBagInfo(mData.Info);
			}
			return _Info;
		}
	}

	public ReadOnlyRoleSoulSkillList SoulSkillList
	{
		get
		{
			if (_SoulSkillList == null)
			{
				_SoulSkillList = new ReadOnlyRoleSoulSkillList(mData.SoulSkillList);
			}
			return _SoulSkillList;
		}
	}

	public ReadOnlyRoleBag(RoleBag data)
	{
		mData = data;
	}

	public ReadOnlyRoleBag Clone()
	{
		return new ReadOnlyRoleBag(mData.Clone());
	}

	public RoleBag ForceGetRef()
	{
		return mData;
	}

	public RoleBag CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleBag>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MoneyList=[\n");
		for (int i = 0; i < MoneyList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			MoneyList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ItemList=[\n");
		for (int j = 0; j < ItemList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ItemList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("EquipList=[\n");
		for (int k = 0; k < EquipList.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			EquipList[k].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("AttrList=[\n");
		for (int l = 0; l < AttrList.Count; l++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			AttrList[l].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("WineList=[\n");
		for (int m = 0; m < WineList.Count; m++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			WineList[m].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (Info != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Info=");
			Info.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Info=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("SoulSkillList=[\n");
		for (int n = 0; n < SoulSkillList.Count; n++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			SoulSkillList[n].DumpAsString(builder, indent, cur_indent + indent + indent);
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
