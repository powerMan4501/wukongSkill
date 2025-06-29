using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAchievementStatus
{
	private AchievementStatus mData;

	public int Id => mData.Id;

	public double Progress => mData.Progress;

	public ReadOnlyAchievementStatus(AchievementStatus data)
	{
		mData = data;
	}

	public ReadOnlyAchievementStatus Clone()
	{
		return new ReadOnlyAchievementStatus(mData.Clone());
	}

	public AchievementStatus ForceGetRef()
	{
		return mData;
	}

	public AchievementStatus CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAchievementStatus>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Progress={0},\n", Progress);
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
