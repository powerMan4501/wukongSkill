using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleEquip
{
	private RoleEquip mData;

	private ReadOnlyInt32List _HistoryIdList;

	public int EquipId => mData.EquipId;

	public ulong Uid => mData.Uid;

	public ReadOnlyInt32List HistoryIdList
	{
		get
		{
			if (_HistoryIdList == null)
			{
				_HistoryIdList = new ReadOnlyInt32List(mData.HistoryIdList);
			}
			return _HistoryIdList;
		}
	}

	public ReadOnlyRoleEquip(RoleEquip data)
	{
		mData = data;
	}

	public ReadOnlyRoleEquip Clone()
	{
		return new ReadOnlyRoleEquip(mData.Clone());
	}

	public RoleEquip ForceGetRef()
	{
		return mData;
	}

	public RoleEquip CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleEquip>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("EquipId={0},\n", EquipId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Uid={0},\n", Uid);
		builder.Append(' ', cur_indent + indent);
		builder.Append("HistoryIdList=[\n");
		for (int i = 0; i < HistoryIdList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", HistoryIdList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
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
