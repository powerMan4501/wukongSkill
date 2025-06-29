using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushRoleBase
{
	private BossRushRoleBase mData;

	public int Level => mData.Level;

	public float Atk => mData.Atk;

	public float HpMax => mData.HpMax;

	public float StaminaMax => mData.StaminaMax;

	public float MpMax => mData.MpMax;

	public ReadOnlyBossRushRoleBase(BossRushRoleBase data)
	{
		mData = data;
	}

	public ReadOnlyBossRushRoleBase Clone()
	{
		return new ReadOnlyBossRushRoleBase(mData.Clone());
	}

	public BossRushRoleBase ForceGetRef()
	{
		return mData;
	}

	public BossRushRoleBase CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushRoleBase>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Level={0},\n", Level);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Atk={0},\n", Atk);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HpMax={0},\n", HpMax);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("StaminaMax={0},\n", StaminaMax);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MpMax={0},\n", MpMax);
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
