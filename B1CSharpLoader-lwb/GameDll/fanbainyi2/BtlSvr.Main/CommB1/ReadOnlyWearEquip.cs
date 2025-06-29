using System.Text;
using ArchiveB1;
using BtlB1;

namespace CommB1;

public class ReadOnlyWearEquip
{
	private WearEquip mData;

	public int Id => mData.Id;

	public EquipPosition Position => mData.Position;

	public ulong Uid => mData.Uid;

	public ReadOnlyWearEquip(WearEquip data)
	{
		mData = data;
	}

	public ReadOnlyWearEquip Clone()
	{
		return new ReadOnlyWearEquip(mData.Clone());
	}

	public WearEquip ForceGetRef()
	{
		return mData;
	}

	public WearEquip CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyWearEquip>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Position={0},\n", Position);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Uid={0},\n", Uid);
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
