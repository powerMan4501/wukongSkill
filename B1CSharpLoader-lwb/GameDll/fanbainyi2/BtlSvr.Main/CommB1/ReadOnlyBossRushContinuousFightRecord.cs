using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushContinuousFightRecord
{
	private BossRushContinuousFightRecord mData;

	private ReadOnlyBossRushBattleData _BattleData;

	public ulong BattleId => mData.BattleId;

	public ReadOnlyBossRushBattleData BattleData
	{
		get
		{
			if (_BattleData == null && mData.BattleData != null)
			{
				_BattleData = new ReadOnlyBossRushBattleData(mData.BattleData);
			}
			return _BattleData;
		}
	}

	public ReadOnlyBossRushContinuousFightRecord(BossRushContinuousFightRecord data)
	{
		mData = data;
	}

	public ReadOnlyBossRushContinuousFightRecord Clone()
	{
		return new ReadOnlyBossRushContinuousFightRecord(mData.Clone());
	}

	public BossRushContinuousFightRecord ForceGetRef()
	{
		return mData;
	}

	public BossRushContinuousFightRecord CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushContinuousFightRecord>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("BattleId={0},\n", BattleId);
		if (BattleData != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BattleData=");
			BattleData.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BattleData=null,\n");
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
