using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyOutputConfig
{
	private OutputConfig mData;

	public int OutputItemId => mData.OutputItemId;

	public int OutputInterval => mData.OutputInterval;

	public int OutputMaxCount => mData.OutputMaxCount;

	public ReadOnlyOutputConfig(OutputConfig data)
	{
		mData = data;
	}

	public ReadOnlyOutputConfig Clone()
	{
		return new ReadOnlyOutputConfig(mData.Clone());
	}

	public OutputConfig ForceGetRef()
	{
		return mData;
	}

	public OutputConfig CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyOutputConfig>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OutputItemId={0},\n", OutputItemId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OutputInterval={0},\n", OutputInterval);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OutputMaxCount={0},\n", OutputMaxCount);
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
