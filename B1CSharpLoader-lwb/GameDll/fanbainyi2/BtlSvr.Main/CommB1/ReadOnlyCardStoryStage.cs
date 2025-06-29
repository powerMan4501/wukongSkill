using System.Text;
using ArchiveB1;
using BtlShare;

namespace CommB1;

public class ReadOnlyCardStoryStage
{
	private CardStoryStage mData;

	public ECollectionStage CollectionStage => mData.CollectionStage;

	public bool IsRead => mData.IsRead;

	public ReadOnlyCardStoryStage(CardStoryStage data)
	{
		mData = data;
	}

	public ReadOnlyCardStoryStage Clone()
	{
		return new ReadOnlyCardStoryStage(mData.Clone());
	}

	public CardStoryStage ForceGetRef()
	{
		return mData;
	}

	public CardStoryStage CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCardStoryStage>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CollectionStage={0},\n", CollectionStage);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsRead={0},\n", IsRead);
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
