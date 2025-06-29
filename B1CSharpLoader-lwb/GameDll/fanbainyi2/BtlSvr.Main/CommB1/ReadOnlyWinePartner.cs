using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyWinePartner
{
	private WinePartner mData;

	public int Pos => mData.Pos;

	public int ItemId => mData.ItemId;

	public ReadOnlyWinePartner(WinePartner data)
	{
		mData = data;
	}

	public ReadOnlyWinePartner Clone()
	{
		return new ReadOnlyWinePartner(mData.Clone());
	}

	public WinePartner ForceGetRef()
	{
		return mData;
	}

	public WinePartner CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyWinePartner>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Pos={0},\n", Pos);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ItemId={0},\n", ItemId);
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
