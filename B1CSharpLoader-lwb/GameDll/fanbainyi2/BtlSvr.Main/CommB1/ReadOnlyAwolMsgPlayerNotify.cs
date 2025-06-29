using System.Text;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerNotify
{
	private AwolMsgPlayerNotify mData;

	public uint Id => mData.Id;

	public ReadOnlyAwolMsgPlayerNotify(AwolMsgPlayerNotify data)
	{
		mData = data;
	}

	public ReadOnlyAwolMsgPlayerNotify Clone()
	{
		return new ReadOnlyAwolMsgPlayerNotify(mData.Clone());
	}

	public AwolMsgPlayerNotify ForceGetRef()
	{
		return mData;
	}

	public AwolMsgPlayerNotify CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwolMsgPlayerNotify>{\n");
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
