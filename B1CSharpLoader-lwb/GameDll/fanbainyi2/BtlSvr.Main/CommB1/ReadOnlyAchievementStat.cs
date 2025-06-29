using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAchievementStat
{
	private AchievementStat mData;

	private ReadOnlyInt32List _EquipIdList;

	private ReadOnlyInt32List _SpellIdList;

	private ReadOnlyItemStatList _ItemList;

	public ReadOnlyInt32List EquipIdList
	{
		get
		{
			if (_EquipIdList == null)
			{
				_EquipIdList = new ReadOnlyInt32List(mData.EquipIdList);
			}
			return _EquipIdList;
		}
	}

	public ReadOnlyInt32List SpellIdList
	{
		get
		{
			if (_SpellIdList == null)
			{
				_SpellIdList = new ReadOnlyInt32List(mData.SpellIdList);
			}
			return _SpellIdList;
		}
	}

	public ReadOnlyItemStatList ItemList
	{
		get
		{
			if (_ItemList == null)
			{
				_ItemList = new ReadOnlyItemStatList(mData.ItemList);
			}
			return _ItemList;
		}
	}

	public ReadOnlyAchievementStat(AchievementStat data)
	{
		mData = data;
	}

	public ReadOnlyAchievementStat Clone()
	{
		return new ReadOnlyAchievementStat(mData.Clone());
	}

	public AchievementStat ForceGetRef()
	{
		return mData;
	}

	public AchievementStat CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAchievementStat>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("EquipIdList=[\n");
		for (int i = 0; i < EquipIdList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", EquipIdList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SpellIdList=[\n");
		for (int j = 0; j < SpellIdList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SpellIdList[j]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ItemList=[\n");
		for (int k = 0; k < ItemList.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ItemList[k].DumpAsString(builder, indent, cur_indent + indent + indent);
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
