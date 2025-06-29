using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAwardItem
{
	private AwardItem mData;

	public int Id => mData.Id;

	public int Num => mData.Num;

	public ReadOnlyAwardItem(AwardItem data)
	{
		mData = data;
	}

	public ReadOnlyAwardItem Clone()
	{
		return new ReadOnlyAwardItem(mData.Clone());
	}

	public AwardItem ForceGetRef()
	{
		return mData;
	}

	public AwardItem CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwardItem>{\n");
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
