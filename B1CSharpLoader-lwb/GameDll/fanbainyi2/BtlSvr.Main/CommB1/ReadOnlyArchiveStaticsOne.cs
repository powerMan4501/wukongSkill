using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyArchiveStaticsOne
{
	private ArchiveStaticsOne mData;

	public int GamePlusId => mData.GamePlusId;

	public float GameTotalTime => mData.GameTotalTime;

	public ReadOnlyArchiveStaticsOne(ArchiveStaticsOne data)
	{
		mData = data;
	}

	public ReadOnlyArchiveStaticsOne Clone()
	{
		return new ReadOnlyArchiveStaticsOne(mData.Clone());
	}

	public ArchiveStaticsOne ForceGetRef()
	{
		return mData;
	}

	public ArchiveStaticsOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyArchiveStaticsOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GamePlusId={0},\n", GamePlusId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GameTotalTime={0},\n", GameTotalTime);
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
