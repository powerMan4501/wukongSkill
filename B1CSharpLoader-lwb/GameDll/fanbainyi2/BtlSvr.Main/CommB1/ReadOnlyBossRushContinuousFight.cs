using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushContinuousFight
{
	private BossRushContinuousFight mData;

	private ReadOnlyBossRushContinuousFightGroupList _BossGroups;

	public ReadOnlyBossRushContinuousFightGroupList BossGroups
	{
		get
		{
			if (_BossGroups == null)
			{
				_BossGroups = new ReadOnlyBossRushContinuousFightGroupList(mData.BossGroups);
			}
			return _BossGroups;
		}
	}

	public ReadOnlyBossRushContinuousFight(BossRushContinuousFight data)
	{
		mData = data;
	}

	public ReadOnlyBossRushContinuousFight Clone()
	{
		return new ReadOnlyBossRushContinuousFight(mData.Clone());
	}

	public BossRushContinuousFight ForceGetRef()
	{
		return mData;
	}

	public BossRushContinuousFight CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushContinuousFight>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("BossGroups=[\n");
		for (int i = 0; i < BossGroups.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			BossGroups[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
