using System.Text;

namespace CommB1;

public class ReadOnlyMemberRoleData
{
	private MemberRoleData mData;

	private ReadOnlyWearEquipList _EquipList;

	public ReadOnlyWearEquipList EquipList
	{
		get
		{
			if (_EquipList == null)
			{
				_EquipList = new ReadOnlyWearEquipList(mData.EquipList);
			}
			return _EquipList;
		}
	}

	public int Level => mData.Level;

	public string MemberName => mData.MemberName;

	public ReadOnlyMemberRoleData(MemberRoleData data)
	{
		mData = data;
	}

	public ReadOnlyMemberRoleData Clone()
	{
		return new ReadOnlyMemberRoleData(mData.Clone());
	}

	public MemberRoleData ForceGetRef()
	{
		return mData;
	}

	public MemberRoleData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMemberRoleData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("EquipList=[\n");
		for (int i = 0; i < EquipList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			EquipList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Level={0},\n", Level);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MemberName={0},\n", MemberName);
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
