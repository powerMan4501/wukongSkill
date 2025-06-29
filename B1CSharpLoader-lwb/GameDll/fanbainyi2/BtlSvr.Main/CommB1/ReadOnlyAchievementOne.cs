using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAchievementOne
{
	private AchievementOne mData;

	private ReadOnlyAchievementConfig _Config;

	private ReadOnlyInt32List _CompleteRequirementList;

	private ReadOnlyStringList _CompleteRequirementGuidList;

	public ReadOnlyAchievementConfig Config
	{
		get
		{
			if (_Config == null && mData.Config != null)
			{
				_Config = new ReadOnlyAchievementConfig(mData.Config);
			}
			return _Config;
		}
	}

	public ReadOnlyInt32List CompleteRequirementList
	{
		get
		{
			if (_CompleteRequirementList == null)
			{
				_CompleteRequirementList = new ReadOnlyInt32List(mData.CompleteRequirementList);
			}
			return _CompleteRequirementList;
		}
	}

	public bool IsComplete => mData.IsComplete;

	public ReadOnlyStringList CompleteRequirementGuidList
	{
		get
		{
			if (_CompleteRequirementGuidList == null)
			{
				_CompleteRequirementGuidList = new ReadOnlyStringList(mData.CompleteRequirementGuidList);
			}
			return _CompleteRequirementGuidList;
		}
	}

	public ReadOnlyAchievementOne(AchievementOne data)
	{
		mData = data;
	}

	public ReadOnlyAchievementOne Clone()
	{
		return new ReadOnlyAchievementOne(mData.Clone());
	}

	public AchievementOne ForceGetRef()
	{
		return mData;
	}

	public AchievementOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAchievementOne>{\n");
		if (Config != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Config=");
			Config.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Config=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("CompleteRequirementList=[\n");
		for (int i = 0; i < CompleteRequirementList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CompleteRequirementList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsComplete={0},\n", IsComplete);
		builder.Append(' ', cur_indent + indent);
		builder.Append("CompleteRequirementGuidList=[\n");
		for (int j = 0; j < CompleteRequirementGuidList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", CompleteRequirementGuidList[j]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
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
