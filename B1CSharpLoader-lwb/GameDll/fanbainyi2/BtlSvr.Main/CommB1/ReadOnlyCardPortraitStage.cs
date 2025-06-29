using System.Text;
using ArchiveB1;
using BtlShare;

namespace CommB1;

public class ReadOnlyCardPortraitStage
{
	private CardPortraitStage mData;

	public bool IsRead => mData.IsRead;

	public ECollectionPortraitStage PortraitStage => mData.PortraitStage;

	public ReadOnlyCardPortraitStage(CardPortraitStage data)
	{
		mData = data;
	}

	public ReadOnlyCardPortraitStage Clone()
	{
		return new ReadOnlyCardPortraitStage(mData.Clone());
	}

	public CardPortraitStage ForceGetRef()
	{
		return mData;
	}

	public CardPortraitStage CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCardPortraitStage>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsRead={0},\n", IsRead);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PortraitStage={0},\n", PortraitStage);
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
