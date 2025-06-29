using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyChapterStaticsDataOne
{
	private ChapterStaticsDataOne mData;

	public int ChapterId => mData.ChapterId;

	public float PlayTime => mData.PlayTime;

	public ReadOnlyChapterStaticsDataOne(ChapterStaticsDataOne data)
	{
		mData = data;
	}

	public ReadOnlyChapterStaticsDataOne Clone()
	{
		return new ReadOnlyChapterStaticsDataOne(mData.Clone());
	}

	public ChapterStaticsDataOne ForceGetRef()
	{
		return mData;
	}

	public ChapterStaticsDataOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyChapterStaticsDataOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ChapterId={0},\n", ChapterId);
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
