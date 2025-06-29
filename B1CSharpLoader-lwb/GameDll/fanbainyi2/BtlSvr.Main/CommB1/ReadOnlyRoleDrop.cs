using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleDrop
{
	private RoleDrop mData;

	private ReadOnlyDropRecordList _DropRecordList;

	private ReadOnlySoulSkillDropRecordList _SoulSkillDropList;

	public ReadOnlyDropRecordList DropRecordList
	{
		get
		{
			if (_DropRecordList == null)
			{
				_DropRecordList = new ReadOnlyDropRecordList(mData.DropRecordList);
			}
			return _DropRecordList;
		}
	}

	public ReadOnlySoulSkillDropRecordList SoulSkillDropList
	{
		get
		{
			if (_SoulSkillDropList == null)
			{
				_SoulSkillDropList = new ReadOnlySoulSkillDropRecordList(mData.SoulSkillDropList);
			}
			return _SoulSkillDropList;
		}
	}

	public ReadOnlyRoleDrop(RoleDrop data)
	{
		mData = data;
	}

	public ReadOnlyRoleDrop Clone()
	{
		return new ReadOnlyRoleDrop(mData.Clone());
	}

	public RoleDrop ForceGetRef()
	{
		return mData;
	}

	public RoleDrop CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleDrop>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("DropRecordList=[\n");
		for (int i = 0; i < DropRecordList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			DropRecordList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SoulSkillDropList=[\n");
		for (int j = 0; j < SoulSkillDropList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			SoulSkillDropList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
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
