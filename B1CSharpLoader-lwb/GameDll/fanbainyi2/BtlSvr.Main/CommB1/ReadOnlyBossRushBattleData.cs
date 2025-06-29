using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushBattleData
{
	private BossRushBattleData mData;

	private ReadOnlyInt32List _DebuffList;

	private ReadOnlyBossRushRoleBase _RoleBase;

	private ReadOnlyBossRushBattleStyle _BattleStyleInfo;

	private ReadOnlyBossRushDamageInfo _DamageInfo;

	public float TotalTime => mData.TotalTime;

	public int Score => mData.Score;

	public ReadOnlyInt32List DebuffList
	{
		get
		{
			if (_DebuffList == null)
			{
				_DebuffList = new ReadOnlyInt32List(mData.DebuffList);
			}
			return _DebuffList;
		}
	}

	public int TargetId => mData.TargetId;

	public ulong ArchiveTime => mData.ArchiveTime;

	public ReadOnlyBossRushRoleBase RoleBase
	{
		get
		{
			if (_RoleBase == null && mData.RoleBase != null)
			{
				_RoleBase = new ReadOnlyBossRushRoleBase(mData.RoleBase);
			}
			return _RoleBase;
		}
	}

	public ReadOnlyBossRushBattleStyle BattleStyleInfo
	{
		get
		{
			if (_BattleStyleInfo == null && mData.BattleStyleInfo != null)
			{
				_BattleStyleInfo = new ReadOnlyBossRushBattleStyle(mData.BattleStyleInfo);
			}
			return _BattleStyleInfo;
		}
	}

	public ReadOnlyBossRushDamageInfo DamageInfo
	{
		get
		{
			if (_DamageInfo == null && mData.DamageInfo != null)
			{
				_DamageInfo = new ReadOnlyBossRushDamageInfo(mData.DamageInfo);
			}
			return _DamageInfo;
		}
	}

	public ReadOnlyBossRushBattleData(BossRushBattleData data)
	{
		mData = data;
	}

	public ReadOnlyBossRushBattleData Clone()
	{
		return new ReadOnlyBossRushBattleData(mData.Clone());
	}

	public BossRushBattleData ForceGetRef()
	{
		return mData;
	}

	public BossRushBattleData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushBattleData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TotalTime={0},\n", TotalTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Score={0},\n", Score);
		builder.Append(' ', cur_indent + indent);
		builder.Append("DebuffList=[\n");
		for (int i = 0; i < DebuffList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", DebuffList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TargetId={0},\n", TargetId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ArchiveTime={0},\n", ArchiveTime);
		if (RoleBase != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleBase=");
			RoleBase.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleBase=null,\n");
		}
		if (BattleStyleInfo != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BattleStyleInfo=");
			BattleStyleInfo.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BattleStyleInfo=null,\n");
		}
		if (DamageInfo != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("DamageInfo=");
			DamageInfo.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("DamageInfo=null,\n");
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
