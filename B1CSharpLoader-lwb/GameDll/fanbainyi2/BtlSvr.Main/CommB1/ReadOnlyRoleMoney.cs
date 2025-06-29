using System.Text;
using ArchiveB1;
using ResB1;

namespace CommB1;

public class ReadOnlyRoleMoney
{
	private RoleMoney mData;

	public MoneyType MoneyType => mData.MoneyType;

	public long MoneyValue => mData.MoneyValue;

	public ReadOnlyRoleMoney(RoleMoney data)
	{
		mData = data;
	}

	public ReadOnlyRoleMoney Clone()
	{
		return new ReadOnlyRoleMoney(mData.Clone());
	}

	public RoleMoney ForceGetRef()
	{
		return mData;
	}

	public RoleMoney CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleMoney>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MoneyType={0},\n", MoneyType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MoneyValue={0},\n", MoneyValue);
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
