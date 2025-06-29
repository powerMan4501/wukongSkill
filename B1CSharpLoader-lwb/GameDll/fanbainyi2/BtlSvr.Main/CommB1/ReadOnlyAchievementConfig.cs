using System.Text;
using ArchiveB1;
using ResB1;

namespace CommB1;

public class ReadOnlyAchievementConfig
{
	private AchievementConfig mData;

	public int AchievementId => mData.AchievementId;

	public AchievementUnlockRequirement RequirementType => mData.RequirementType;

	public int RequirementCount => mData.RequirementCount;

	public bool IsProgress => mData.IsProgress;

	public bool IsResetOnGameplus => mData.IsResetOnGameplus;

	public ReadOnlyAchievementConfig(AchievementConfig data)
	{
		mData = data;
	}

	public ReadOnlyAchievementConfig Clone()
	{
		return new ReadOnlyAchievementConfig(mData.Clone());
	}

	public AchievementConfig ForceGetRef()
	{
		return mData;
	}

	public AchievementConfig CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAchievementConfig>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AchievementId={0},\n", AchievementId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("RequirementType={0},\n", RequirementType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("RequirementCount={0},\n", RequirementCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsProgress={0},\n", IsProgress);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsResetOnGameplus={0},\n", IsResetOnGameplus);
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
