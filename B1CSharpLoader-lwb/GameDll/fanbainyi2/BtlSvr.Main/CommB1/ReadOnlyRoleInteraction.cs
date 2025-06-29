using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleInteraction
{
	private RoleInteraction mData;

	private ReadOnlyInt32List _InteractionFuncList;

	public ReadOnlyInt32List InteractionFuncList
	{
		get
		{
			if (_InteractionFuncList == null)
			{
				_InteractionFuncList = new ReadOnlyInt32List(mData.InteractionFuncList);
			}
			return _InteractionFuncList;
		}
	}

	public ReadOnlyRoleInteraction(RoleInteraction data)
	{
		mData = data;
	}

	public ReadOnlyRoleInteraction Clone()
	{
		return new ReadOnlyRoleInteraction(mData.Clone());
	}

	public RoleInteraction ForceGetRef()
	{
		return mData;
	}

	public RoleInteraction CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleInteraction>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("InteractionFuncList=[\n");
		for (int i = 0; i < InteractionFuncList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", InteractionFuncList[i]);
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
