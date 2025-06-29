using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushRefightBoss
{
	private BossRushRefightBoss mData;

	private ReadOnlyBossRushRefightRecordList _BestRecords;

	private ReadOnlyRefightStatisticsList _RefightStatisticsList;

	public int BossId => mData.BossId;

	public EReChallengeLevel PassedMaxLevel => mData.PassedMaxLevel;

	public EReChallengeLevel LastChallengeLevel => mData.LastChallengeLevel;

	public ReadOnlyBossRushRefightRecordList BestRecords
	{
		get
		{
			if (_BestRecords == null)
			{
				_BestRecords = new ReadOnlyBossRushRefightRecordList(mData.BestRecords);
			}
			return _BestRecords;
		}
	}

	public ECooperativeStatus CooperativeStatus => mData.CooperativeStatus;

	public ReadOnlyRefightStatisticsList RefightStatisticsList
	{
		get
		{
			if (_RefightStatisticsList == null)
			{
				_RefightStatisticsList = new ReadOnlyRefightStatisticsList(mData.RefightStatisticsList);
			}
			return _RefightStatisticsList;
		}
	}

	public ReadOnlyBossRushRefightBoss(BossRushRefightBoss data)
	{
		mData = data;
	}

	public ReadOnlyBossRushRefightBoss Clone()
	{
		return new ReadOnlyBossRushRefightBoss(mData.Clone());
	}

	public BossRushRefightBoss ForceGetRef()
	{
		return mData;
	}

	public BossRushRefightBoss CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushRefightBoss>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BossId={0},\n", BossId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("PassedMaxLevel={0},\n", PassedMaxLevel);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastChallengeLevel={0},\n", LastChallengeLevel);
		builder.Append(' ', cur_indent + indent);
		builder.Append("BestRecords=[\n");
		for (int i = 0; i < BestRecords.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			BestRecords[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CooperativeStatus={0},\n", CooperativeStatus);
		builder.Append(' ', cur_indent + indent);
		builder.Append("RefightStatisticsList=[\n");
		for (int j = 0; j < RefightStatisticsList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			RefightStatisticsList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
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
