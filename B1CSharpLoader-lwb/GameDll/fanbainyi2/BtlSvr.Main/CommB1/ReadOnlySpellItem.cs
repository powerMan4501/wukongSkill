using System.Text;
using ArchiveB1;
using BtlB1;

namespace CommB1;

public class ReadOnlySpellItem
{
	private SpellItem mData;

	public SpellType Type => mData.Type;

	public int SpellId => mData.SpellId;

	public ReadOnlySpellItem(SpellItem data)
	{
		mData = data;
	}

	public ReadOnlySpellItem Clone()
	{
		return new ReadOnlySpellItem(mData.Clone());
	}

	public SpellItem ForceGetRef()
	{
		return mData;
	}

	public SpellItem CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlySpellItem>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Type={0},\n", Type);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SpellId={0},\n", SpellId);
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
