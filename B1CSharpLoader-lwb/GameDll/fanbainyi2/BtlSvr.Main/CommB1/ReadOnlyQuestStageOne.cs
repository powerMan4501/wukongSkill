using System.Text;
using ArchiveB1;
using ResB1;

namespace CommB1;

public class ReadOnlyQuestStageOne
{
	private QuestStageOne mData;

	public int Id => mData.Id;

	public QuestStage Stage => mData.Stage;

	public ReadOnlyQuestStageOne(QuestStageOne data)
	{
		mData = data;
	}

	public ReadOnlyQuestStageOne Clone()
	{
		return new ReadOnlyQuestStageOne(mData.Clone());
	}

	public QuestStageOne ForceGetRef()
	{
		return mData;
	}

	public QuestStageOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyQuestStageOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Stage={0},\n", Stage);
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
