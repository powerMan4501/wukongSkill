using System.Text;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerChat
{
	private AwolMsgPlayerChat mData;

	public uint Id => mData.Id;

	public ReadOnlyAwolMsgPlayerChat(AwolMsgPlayerChat data)
	{
		mData = data;
	}

	public ReadOnlyAwolMsgPlayerChat Clone()
	{
		return new ReadOnlyAwolMsgPlayerChat(mData.Clone());
	}

	public AwolMsgPlayerChat ForceGetRef()
	{
		return mData;
	}

	public AwolMsgPlayerChat CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwolMsgPlayerChat>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
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
