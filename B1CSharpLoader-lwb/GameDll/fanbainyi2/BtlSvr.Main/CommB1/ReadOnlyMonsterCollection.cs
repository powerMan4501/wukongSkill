using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyMonsterCollection
{
	private MonsterCollection mData;

	private ReadOnlyCardStoryStatus _StoryStatus;

	private ReadOnlyCardPortraitStatus _PortraitStatus;

	public int Id => mData.Id;

	public ReadOnlyCardStoryStatus StoryStatus
	{
		get
		{
			if (_StoryStatus == null && mData.StoryStatus != null)
			{
				_StoryStatus = new ReadOnlyCardStoryStatus(mData.StoryStatus);
			}
			return _StoryStatus;
		}
	}

	public ReadOnlyCardPortraitStatus PortraitStatus
	{
		get
		{
			if (_PortraitStatus == null && mData.PortraitStatus != null)
			{
				_PortraitStatus = new ReadOnlyCardPortraitStatus(mData.PortraitStatus);
			}
			return _PortraitStatus;
		}
	}

	public ReadOnlyMonsterCollection(MonsterCollection data)
	{
		mData = data;
	}

	public ReadOnlyMonsterCollection Clone()
	{
		return new ReadOnlyMonsterCollection(mData.Clone());
	}

	public MonsterCollection ForceGetRef()
	{
		return mData;
	}

	public MonsterCollection CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMonsterCollection>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		if (StoryStatus != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("StoryStatus=");
			StoryStatus.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("StoryStatus=null,\n");
		}
		if (PortraitStatus != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("PortraitStatus=");
			PortraitStatus.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("PortraitStatus=null,\n");
		}
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
