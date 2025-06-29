using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleItem
{
	private RoleItem mData;

	public int ItemId => mData.ItemId;

	public int Num => mData.Num;

	public int StoreNum => mData.StoreNum;

	public ReadOnlyRoleItem(RoleItem data)
	{
		mData = data;
	}

	public ReadOnlyRoleItem Clone()
	{
		return new ReadOnlyRoleItem(mData.Clone());
	}

	public RoleItem ForceGetRef()
	{
		return mData;
	}

	public RoleItem CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleItem>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ItemId={0},\n", ItemId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Num={0},\n", Num);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("StoreNum={0},\n", StoreNum);
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
