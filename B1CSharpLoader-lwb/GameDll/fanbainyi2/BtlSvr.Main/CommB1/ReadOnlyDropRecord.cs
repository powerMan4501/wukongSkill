using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyDropRecord
{
	private DropRecord mData;

	public int DropId => mData.DropId;

	public uint DropCount => mData.DropCount;

	public uint GuaranteeDropCount => mData.GuaranteeDropCount;

	public ReadOnlyDropRecord(DropRecord data)
	{
		mData = data;
	}

	public ReadOnlyDropRecord Clone()
	{
		return new ReadOnlyDropRecord(mData.Clone());
	}

	public DropRecord ForceGetRef()
	{
		return mData;
	}

	public DropRecord CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyDropRecord>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("DropId={0},\n", DropId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("DropCount={0},\n", DropCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GuaranteeDropCount={0},\n", GuaranteeDropCount);
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
