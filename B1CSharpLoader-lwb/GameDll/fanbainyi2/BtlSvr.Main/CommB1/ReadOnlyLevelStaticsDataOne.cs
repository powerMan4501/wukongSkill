using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyLevelStaticsDataOne
{
	private LevelStaticsDataOne mData;

	public int LevelId => mData.LevelId;

	public float PlayTime => mData.PlayTime;

	public ReadOnlyLevelStaticsDataOne(LevelStaticsDataOne data)
	{
		mData = data;
	}

	public ReadOnlyLevelStaticsDataOne Clone()
	{
		return new ReadOnlyLevelStaticsDataOne(mData.Clone());
	}

	public LevelStaticsDataOne ForceGetRef()
	{
		return mData;
	}

	public LevelStaticsDataOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyLevelStaticsDataOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LevelId={0},\n", LevelId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PlayTime={0},\n", PlayTime);
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
