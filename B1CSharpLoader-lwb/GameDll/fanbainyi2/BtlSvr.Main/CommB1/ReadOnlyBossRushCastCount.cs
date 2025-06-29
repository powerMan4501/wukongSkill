using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushCastCount
{
	private BossRushCastCount mData;

	public int CastId => mData.CastId;

	public int CastCount => mData.CastCount;

	public ReadOnlyBossRushCastCount(BossRushCastCount data)
	{
		mData = data;
	}

	public ReadOnlyBossRushCastCount Clone()
	{
		return new ReadOnlyBossRushCastCount(mData.Clone());
	}

	public BossRushCastCount ForceGetRef()
	{
		return mData;
	}

	public BossRushCastCount CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushCastCount>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CastId={0},\n", CastId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CastCount={0},\n", CastCount);
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
