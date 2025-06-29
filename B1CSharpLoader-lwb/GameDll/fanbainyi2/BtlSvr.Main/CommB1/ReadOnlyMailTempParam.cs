using System.Text;

namespace CommB1;

public class ReadOnlyMailTempParam
{
	private MailTempParam mData;

	public int IntParam1 => mData.IntParam1;

	public int IntParam2 => mData.IntParam2;

	public ReadOnlyMailTempParam(MailTempParam data)
	{
		mData = data;
	}

	public ReadOnlyMailTempParam Clone()
	{
		return new ReadOnlyMailTempParam(mData.Clone());
	}

	public MailTempParam ForceGetRef()
	{
		return mData;
	}

	public MailTempParam CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMailTempParam>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IntParam1={0},\n", IntParam1);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IntParam2={0},\n", IntParam2);
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
