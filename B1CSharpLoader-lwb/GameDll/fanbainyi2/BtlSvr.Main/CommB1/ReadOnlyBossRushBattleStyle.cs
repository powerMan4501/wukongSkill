using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushBattleStyle
{
	private BossRushBattleStyle mData;

	private ReadOnlyBossRushCastCountList _SpellList;

	private ReadOnlyBossRushCastCount _FabaoInfo;

	private ReadOnlyBossRushCastCount _SoulInfo;

	public ReadOnlyBossRushCastCountList SpellList
	{
		get
		{
			if (_SpellList == null)
			{
				_SpellList = new ReadOnlyBossRushCastCountList(mData.SpellList);
			}
			return _SpellList;
		}
	}

	public ReadOnlyBossRushCastCount FabaoInfo
	{
		get
		{
			if (_FabaoInfo == null && mData.FabaoInfo != null)
			{
				_FabaoInfo = new ReadOnlyBossRushCastCount(mData.FabaoInfo);
			}
			return _FabaoInfo;
		}
	}

	public ReadOnlyBossRushCastCount SoulInfo
	{
		get
		{
			if (_SoulInfo == null && mData.SoulInfo != null)
			{
				_SoulInfo = new ReadOnlyBossRushCastCount(mData.SoulInfo);
			}
			return _SoulInfo;
		}
	}

	public int ItemCount => mData.ItemCount;

	public int WineCount => mData.WineCount;

	public int RollCount => mData.RollCount;

	public int DefuseCount => mData.DefuseCount;

	public int FourPeCount => mData.FourPeCount;

	public ReadOnlyBossRushBattleStyle(BossRushBattleStyle data)
	{
		mData = data;
	}

	public ReadOnlyBossRushBattleStyle Clone()
	{
		return new ReadOnlyBossRushBattleStyle(mData.Clone());
	}

	public BossRushBattleStyle ForceGetRef()
	{
		return mData;
	}

	public BossRushBattleStyle CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushBattleStyle>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SpellList=[\n");
		for (int i = 0; i < SpellList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			SpellList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (FabaoInfo != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("FabaoInfo=");
			FabaoInfo.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("FabaoInfo=null,\n");
		}
		if (SoulInfo != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("SoulInfo=");
			SoulInfo.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("SoulInfo=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ItemCount={0},\n", ItemCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("WineCount={0},\n", WineCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("RollCount={0},\n", RollCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("DefuseCount={0},\n", DefuseCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("FourPeCount={0},\n", FourPeCount);
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
