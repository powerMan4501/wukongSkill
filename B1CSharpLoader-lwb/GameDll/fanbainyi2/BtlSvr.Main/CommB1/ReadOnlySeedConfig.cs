using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlySeedConfig
{
	private SeedConfig mData;

	public int SeedId => mData.SeedId;

	public int OutputItemId => mData.OutputItemId;

	public int OutputInterval => mData.OutputInterval;

	public int OutputMaxCount => mData.OutputMaxCount;

	public ReadOnlySeedConfig(SeedConfig data)
	{
		mData = data;
	}

	public ReadOnlySeedConfig Clone()
	{
		return new ReadOnlySeedConfig(mData.Clone());
	}

	public SeedConfig ForceGetRef()
	{
		return mData;
	}

	public SeedConfig CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlySeedConfig>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SeedId={0},\n", SeedId);
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
