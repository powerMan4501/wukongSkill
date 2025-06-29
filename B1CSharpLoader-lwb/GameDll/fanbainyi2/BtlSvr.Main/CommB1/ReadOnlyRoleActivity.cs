using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleActivity
{
	private RoleActivity mData;

	private ReadOnlyPS5ActivityList _ActivityList;

	public ReadOnlyPS5ActivityList ActivityList
	{
		get
		{
			if (_ActivityList == null)
			{
				_ActivityList = new ReadOnlyPS5ActivityList(mData.ActivityList);
			}
			return _ActivityList;
		}
	}

	public ReadOnlyRoleActivity(RoleActivity data)
	{
		mData = data;
	}

	public ReadOnlyRoleActivity Clone()
	{
		return new ReadOnlyRoleActivity(mData.Clone());
	}

	public RoleActivity ForceGetRef()
	{
		return mData;
	}

	public RoleActivity CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleActivity>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ActivityList=[\n");
		for (int i = 0; i < ActivityList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ActivityList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
