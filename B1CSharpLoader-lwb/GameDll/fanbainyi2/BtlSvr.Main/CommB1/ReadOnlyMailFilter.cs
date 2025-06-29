using System.Text;

namespace CommB1;

public class ReadOnlyMailFilter
{
	private MailFilter mData;

	public uint MinLv => mData.MinLv;

	public uint MaxLv => mData.MaxLv;

	public uint LtRegisTime => mData.LtRegisTime;

	public uint GtRegisTime => mData.GtRegisTime;

	public uint World => mData.World;

	public ReadOnlyMailFilter(MailFilter data)
	{
		mData = data;
	}

	public ReadOnlyMailFilter Clone()
	{
		return new ReadOnlyMailFilter(mData.Clone());
	}

	public MailFilter ForceGetRef()
	{
		return mData;
	}

	public MailFilter CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMailFilter>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MinLv={0},\n", MinLv);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MaxLv={0},\n", MaxLv);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LtRegisTime={0},\n", LtRegisTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GtRegisTime={0},\n", GtRegisTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("World={0},\n", World);
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
