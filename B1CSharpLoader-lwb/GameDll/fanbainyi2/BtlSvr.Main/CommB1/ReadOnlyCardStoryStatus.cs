using System.Text;
using ArchiveB1;
using BtlShare;

namespace CommB1;

public class ReadOnlyCardStoryStatus
{
	private CardStoryStatus mData;

	public ECollectionStage CollectionStage => mData.CollectionStage;

	public bool IsRead => mData.IsRead;

	public ReadOnlyCardStoryStatus(CardStoryStatus data)
	{
		mData = data;
	}

	public ReadOnlyCardStoryStatus Clone()
	{
		return new ReadOnlyCardStoryStatus(mData.Clone());
	}

	public CardStoryStatus ForceGetRef()
	{
		return mData;
	}

	public CardStoryStatus CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCardStoryStatus>{\n");
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
