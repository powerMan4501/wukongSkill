using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyMeditationOne
{
	private MeditationOne mData;

	public int Id => mData.Id;

	public ReadOnlyMeditationOne(MeditationOne data)
	{
		mData = data;
	}

	public ReadOnlyMeditationOne Clone()
	{
		return new ReadOnlyMeditationOne(mData.Clone());
	}

	public MeditationOne ForceGetRef()
	{
		return mData;
	}

	public MeditationOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMeditationOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
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
