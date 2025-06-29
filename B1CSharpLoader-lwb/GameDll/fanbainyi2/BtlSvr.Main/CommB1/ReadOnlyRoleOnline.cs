using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleOnline
{
	private RoleOnline mData;

	private ReadOnlyInt32List _MapFragmentList;

	public ReadOnlyInt32List MapFragmentList
	{
		get
		{
			if (_MapFragmentList == null)
			{
				_MapFragmentList = new ReadOnlyInt32List(mData.MapFragmentList);
			}
			return _MapFragmentList;
		}
	}

	public ReadOnlyRoleOnline(RoleOnline data)
	{
		mData = data;
	}

	public ReadOnlyRoleOnline Clone()
	{
		return new ReadOnlyRoleOnline(mData.Clone());
	}

	public RoleOnline ForceGetRef()
	{
		return mData;
	}

	public RoleOnline CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleOnline>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MapFragmentList=[\n");
		for (int i = 0; i < MapFragmentList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", MapFragmentList[i]);
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
