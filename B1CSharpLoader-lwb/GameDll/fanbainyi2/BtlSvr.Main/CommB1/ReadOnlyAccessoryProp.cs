using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyAccessoryProp
{
	private AccessoryProp mData;

	public int Id => mData.Id;

	public ulong Uid => mData.Uid;

	public int Pos => mData.Pos;

	public ReadOnlyAccessoryProp(AccessoryProp data)
	{
		mData = data;
	}

	public ReadOnlyAccessoryProp Clone()
	{
		return new ReadOnlyAccessoryProp(mData.Clone());
	}

	public AccessoryProp ForceGetRef()
	{
		return mData;
	}

	public AccessoryProp CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAccessoryProp>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Uid={0},\n", Uid);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Pos={0},\n", Pos);
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
