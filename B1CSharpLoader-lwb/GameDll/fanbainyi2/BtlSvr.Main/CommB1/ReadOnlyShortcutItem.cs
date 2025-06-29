using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyShortcutItem
{
	private ShortcutItem mData;

	public int ItemId => mData.ItemId;

	public int Position => mData.Position;

	public ReadOnlyShortcutItem(ShortcutItem data)
	{
		mData = data;
	}

	public ReadOnlyShortcutItem Clone()
	{
		return new ReadOnlyShortcutItem(mData.Clone());
	}

	public ShortcutItem ForceGetRef()
	{
		return mData;
	}

	public ShortcutItem CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyShortcutItem>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ItemId={0},\n", ItemId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Position={0},\n", Position);
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
