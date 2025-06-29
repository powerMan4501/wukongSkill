using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRefightStatistics
{
	private RefightStatistics mData;

	public EReChallengeLevel ChallengeLevel => mData.ChallengeLevel;

	public uint BattleCount => mData.BattleCount;

	public ReadOnlyRefightStatistics(RefightStatistics data)
	{
		mData = data;
	}

	public ReadOnlyRefightStatistics Clone()
	{
		return new ReadOnlyRefightStatistics(mData.Clone());
	}

	public RefightStatistics ForceGetRef()
	{
		return mData;
	}

	public RefightStatistics CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRefightStatistics>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ChallengeLevel={0},\n", ChallengeLevel);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BattleCount={0},\n", BattleCount);
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
