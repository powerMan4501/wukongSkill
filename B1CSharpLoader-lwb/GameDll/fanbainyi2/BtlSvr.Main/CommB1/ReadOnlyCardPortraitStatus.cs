using System.Text;
using ArchiveB1;
using BtlShare;

namespace CommB1;

public class ReadOnlyCardPortraitStatus
{
	private CardPortraitStatus mData;

	public ECollectionPortraitStage PortraitStage => mData.PortraitStage;

	public bool IsRead => mData.IsRead;

	public ReadOnlyCardPortraitStatus(CardPortraitStatus data)
	{
		mData = data;
	}

	public ReadOnlyCardPortraitStatus Clone()
	{
		return new ReadOnlyCardPortraitStatus(mData.Clone());
	}

	public CardPortraitStatus ForceGetRef()
	{
		return mData;
	}

	public CardPortraitStatus CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCardPortraitStatus>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PortraitStage={0},\n", PortraitStage);
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
