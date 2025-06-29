using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyBossRushDamageInfo
{
	private BossRushDamageInfo mData;

	public float TotalDamage => mData.TotalDamage;

	public float HightestDamage => mData.HightestDamage;

	public float CriticalDmgRate => mData.CriticalDmgRate;

	public float TotalBeDamaged => mData.TotalBeDamaged;

	public float CriticalDmgTotal => mData.CriticalDmgTotal;

	public float ElemDotDmgTotal => mData.ElemDotDmgTotal;

	public float ElemDotDmgRate => mData.ElemDotDmgRate;

	public ReadOnlyBossRushDamageInfo(BossRushDamageInfo data)
	{
		mData = data;
	}

	public ReadOnlyBossRushDamageInfo Clone()
	{
		return new ReadOnlyBossRushDamageInfo(mData.Clone());
	}

	public BossRushDamageInfo ForceGetRef()
	{
		return mData;
	}

	public BossRushDamageInfo CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyBossRushDamageInfo>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TotalDamage={0},\n", TotalDamage);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HightestDamage={0},\n", HightestDamage);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CriticalDmgRate={0},\n", CriticalDmgRate);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TotalBeDamaged={0},\n", TotalBeDamaged);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CriticalDmgTotal={0},\n", CriticalDmgTotal);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ElemDotDmgTotal={0},\n", ElemDotDmgTotal);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ElemDotDmgRate={0},\n", ElemDotDmgRate);
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
