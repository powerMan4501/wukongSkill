using System.Text;
using ArchiveB1;
using ResB1;

namespace CommB1;

public class ReadOnlyRoleAchievement
{
	private RoleAchievement mData;

	private ReadOnlyAchievementOneList _Achievements;

	public ReadOnlyAchievementOneList Achievements
	{
		get
		{
			if (_Achievements == null)
			{
				_Achievements = new ReadOnlyAchievementOneList(mData.Achievements);
			}
			return _Achievements;
		}
	}

	public AchievementVersion AchievementVersion => mData.AchievementVersion;

	public ReadOnlyRoleAchievement(RoleAchievement data)
	{
		mData = data;
	}

	public ReadOnlyRoleAchievement Clone()
	{
		return new ReadOnlyRoleAchievement(mData.Clone());
	}

	public RoleAchievement ForceGetRef()
	{
		return mData;
	}

	public RoleAchievement CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleAchievement>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Achievements=[\n");
		for (int i = 0; i < Achievements.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Achievements[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AchievementVersion={0},\n", AchievementVersion);
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
