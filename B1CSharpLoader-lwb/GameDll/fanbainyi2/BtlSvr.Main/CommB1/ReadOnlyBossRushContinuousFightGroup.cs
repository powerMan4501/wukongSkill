using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushContinuousFightGroup
{
	private BossRushContinuousFightGroup mData;

	private ReadOnlyInt32List _LastDebuffList;

	private ReadOnlyBossRushContinuousFightRecordList _BestRecords;

	public int BossGroupId => mData.BossGroupId;

	public bool IsPassed => mData.IsPassed;

	public ReadOnlyInt32List LastDebuffList
	{
		get
		{
			if (_LastDebuffList == null)
			{
				_LastDebuffList = new ReadOnlyInt32List(mData.LastDebuffList);
			}
			return _LastDebuffList;
		}
	}

	public ReadOnlyBossRushContinuousFightRecordList BestRecords
	{
		get
		{
			if (_BestRecords == null)
			{
				_BestRecords = new ReadOnlyBossRushContinuousFightRecordList(mData.BestRecords);
			}
			return _BestRecords;
		}
	}

	public int EncounterBossIndex => mData.EncounterBossIndex;

	public uint BattleCount => mData.BattleCount;

	public ReadOnlyBossRushContinuousFightGroup(BossRushContinuousFightGroup data)
	{
		mData = data;
	}

	public ReadOnlyBossRushContinuousFightGroup Clone()
	{
		return new ReadOnlyBossRushContinuousFightGroup(mData.Clone());
	}

	public BossRushContinuousFightGroup ForceGetRef()
	{
		return mData;
	}

	public BossRushContinuousFightGroup CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushContinuousFightGroup>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BossGroupId={0},\n", BossGroupId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsPassed={0},\n", IsPassed);
		builder.Append(' ', cur_indent + indent);
		builder.Append("LastDebuffList=[\n");
		for (int i = 0; i < LastDebuffList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", LastDebuffList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("BestRecords=[\n");
		for (int j = 0; j < BestRecords.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			BestRecords[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("EncounterBossIndex={0},\n", EncounterBossIndex);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BattleCount={0},\n", BattleCount);
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
