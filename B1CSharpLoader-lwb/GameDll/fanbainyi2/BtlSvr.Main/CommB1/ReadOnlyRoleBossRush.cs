using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleBossRush
{
	private RoleBossRush mData;

	private ReadOnlyBossRushRefight _Refight;

	private ReadOnlyBossRushContinuousFight _ContinuousFight;

	public ReadOnlyBossRushRefight Refight
	{
		get
		{
			if (_Refight == null && mData.Refight != null)
			{
				_Refight = new ReadOnlyBossRushRefight(mData.Refight);
			}
			return _Refight;
		}
	}

	public ReadOnlyBossRushContinuousFight ContinuousFight
	{
		get
		{
			if (_ContinuousFight == null && mData.ContinuousFight != null)
			{
				_ContinuousFight = new ReadOnlyBossRushContinuousFight(mData.ContinuousFight);
			}
			return _ContinuousFight;
		}
	}

	public ulong BattleCount => mData.BattleCount;

	public ReadOnlyRoleBossRush(RoleBossRush data)
	{
		mData = data;
	}

	public ReadOnlyRoleBossRush Clone()
	{
		return new ReadOnlyRoleBossRush(mData.Clone());
	}

	public RoleBossRush ForceGetRef()
	{
		return mData;
	}

	public RoleBossRush CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleBossRush>{\n");
		if (Refight != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Refight=");
			Refight.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Refight=null,\n");
		}
		if (ContinuousFight != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("ContinuousFight=");
			ContinuousFight.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("ContinuousFight=null,\n");
		}
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
