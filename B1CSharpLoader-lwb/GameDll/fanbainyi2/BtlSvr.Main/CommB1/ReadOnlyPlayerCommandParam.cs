using System.Text;

namespace CommB1;

public class ReadOnlyPlayerCommandParam
{
	private PlayerCommandParam mData;

	public ulong Id => mData.Id;

	public ulong Iparam1 => mData.Iparam1;

	public ulong Iparam2 => mData.Iparam2;

	public ReadOnlyPlayerCommandParam(PlayerCommandParam data)
	{
		mData = data;
	}

	public ReadOnlyPlayerCommandParam Clone()
	{
		return new ReadOnlyPlayerCommandParam(mData.Clone());
	}

	public PlayerCommandParam ForceGetRef()
	{
		return mData;
	}

	public PlayerCommandParam CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPlayerCommandParam>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Iparam1={0},\n", Iparam1);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Iparam2={0},\n", Iparam2);
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
