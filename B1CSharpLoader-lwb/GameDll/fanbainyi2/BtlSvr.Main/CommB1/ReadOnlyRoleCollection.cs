using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleCollection
{
	private RoleCollection mData;

	private ReadOnlyMonsterCollectionList _MonsterCollectionList;

	public ReadOnlyMonsterCollectionList MonsterCollectionList
	{
		get
		{
			if (_MonsterCollectionList == null)
			{
				_MonsterCollectionList = new ReadOnlyMonsterCollectionList(mData.MonsterCollectionList);
			}
			return _MonsterCollectionList;
		}
	}

	public ReadOnlyRoleCollection(RoleCollection data)
	{
		mData = data;
	}

	public ReadOnlyRoleCollection Clone()
	{
		return new ReadOnlyRoleCollection(mData.Clone());
	}

	public RoleCollection ForceGetRef()
	{
		return mData;
	}

	public RoleCollection CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleCollection>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MonsterCollectionList=[\n");
		for (int i = 0; i < MonsterCollectionList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			MonsterCollectionList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
