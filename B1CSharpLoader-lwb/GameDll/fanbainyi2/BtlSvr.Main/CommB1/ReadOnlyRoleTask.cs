using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleTask
{
	private RoleTask mData;

	private ReadOnlyQuestStageOneList _QuestList;

	public ReadOnlyQuestStageOneList QuestList
	{
		get
		{
			if (_QuestList == null)
			{
				_QuestList = new ReadOnlyQuestStageOneList(mData.QuestList);
			}
			return _QuestList;
		}
	}

	public ReadOnlyRoleTask(RoleTask data)
	{
		mData = data;
	}

	public ReadOnlyRoleTask Clone()
	{
		return new ReadOnlyRoleTask(mData.Clone());
	}

	public RoleTask ForceGetRef()
	{
		return mData;
	}

	public RoleTask CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleTask>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("QuestList=[\n");
		for (int i = 0; i < QuestList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			QuestList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
