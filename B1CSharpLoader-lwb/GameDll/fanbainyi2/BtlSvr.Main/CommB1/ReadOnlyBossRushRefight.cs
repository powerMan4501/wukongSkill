using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushRefight
{
	private BossRushRefight mData;

	private ReadOnlyBossRushRefightBossList _BossList;

	public ReadOnlyBossRushRefightBossList BossList
	{
		get
		{
			if (_BossList == null)
			{
				_BossList = new ReadOnlyBossRushRefightBossList(mData.BossList);
			}
			return _BossList;
		}
	}

	public ReadOnlyBossRushRefight(BossRushRefight data)
	{
		mData = data;
	}

	public ReadOnlyBossRushRefight Clone()
	{
		return new ReadOnlyBossRushRefight(mData.Clone());
	}

	public BossRushRefight ForceGetRef()
	{
		return mData;
	}

	public BossRushRefight CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushRefight>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("BossList=[\n");
		for (int i = 0; i < BossList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			BossList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
