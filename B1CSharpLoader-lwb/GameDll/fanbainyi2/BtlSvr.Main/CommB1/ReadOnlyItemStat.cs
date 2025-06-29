using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyItemStat
{
	private ItemStat mData;

	public int Id => mData.Id;

	public int Num => mData.Num;

	public ReadOnlyItemStat(ItemStat data)
	{
		mData = data;
	}

	public ReadOnlyItemStat Clone()
	{
		return new ReadOnlyItemStat(mData.Clone());
	}

	public ItemStat ForceGetRef()
	{
		return mData;
	}

	public ItemStat CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyItemStat>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Num={0},\n", Num);
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
