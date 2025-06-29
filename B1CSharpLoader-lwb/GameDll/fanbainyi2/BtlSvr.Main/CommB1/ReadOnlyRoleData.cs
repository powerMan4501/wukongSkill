using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleData
{
	private RoleData mData;

	private ReadOnlyRoleDataCS _RoleCs;

	private ReadOnlyRoleDataClient _RoleClient;

	public ReadOnlyRoleDataCS RoleCs
	{
		get
		{
			if (_RoleCs == null && mData.RoleCs != null)
			{
				_RoleCs = new ReadOnlyRoleDataCS(mData.RoleCs);
			}
			return _RoleCs;
		}
	}

	public ReadOnlyRoleDataClient RoleClient
	{
		get
		{
			if (_RoleClient == null && mData.RoleClient != null)
			{
				_RoleClient = new ReadOnlyRoleDataClient(mData.RoleClient);
			}
			return _RoleClient;
		}
	}

	public ReadOnlyRoleData(RoleData data)
	{
		mData = data;
	}

	public ReadOnlyRoleData Clone()
	{
		return new ReadOnlyRoleData(mData.Clone());
	}

	public RoleData ForceGetRef()
	{
		return mData;
	}

	public RoleData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleData>{\n");
		if (RoleCs != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleCs=");
			RoleCs.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleCs=null,\n");
		}
		if (RoleClient != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleClient=");
			RoleClient.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RoleClient=null,\n");
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
