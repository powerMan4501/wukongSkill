using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleDataClient
{
	private RoleDataClient mData;

	private ReadOnlyRoleStaticsData _StaticsData;

	public ReadOnlyRoleStaticsData StaticsData
	{
		get
		{
			if (_StaticsData == null && mData.StaticsData != null)
			{
				_StaticsData = new ReadOnlyRoleStaticsData(mData.StaticsData);
			}
			return _StaticsData;
		}
	}

	public ReadOnlyRoleDataClient(RoleDataClient data)
	{
		mData = data;
	}

	public ReadOnlyRoleDataClient Clone()
	{
		return new ReadOnlyRoleDataClient(mData.Clone());
	}

	public RoleDataClient ForceGetRef()
	{
		return mData;
	}

	public RoleDataClient CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleDataClient>{\n");
		if (StaticsData != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("StaticsData=");
			StaticsData.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("StaticsData=null,\n");
		}
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
