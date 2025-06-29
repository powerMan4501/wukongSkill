using System.Text;

namespace CommB1;

public class ReadOnlyRoleDataAwolNotify
{
	private RoleDataAwolNotify mData;

	private ReadOnlyAwolMsgPlayerNotifyList _Notifies;

	public ReadOnlyAwolMsgPlayerNotifyList Notifies
	{
		get
		{
			if (_Notifies == null)
			{
				_Notifies = new ReadOnlyAwolMsgPlayerNotifyList(mData.Notifies);
			}
			return _Notifies;
		}
	}

	public ReadOnlyRoleDataAwolNotify(RoleDataAwolNotify data)
	{
		mData = data;
	}

	public ReadOnlyRoleDataAwolNotify Clone()
	{
		return new ReadOnlyRoleDataAwolNotify(mData.Clone());
	}

	public RoleDataAwolNotify ForceGetRef()
	{
		return mData;
	}

	public RoleDataAwolNotify CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleDataAwolNotify>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Notifies=[\n");
		for (int i = 0; i < Notifies.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Notifies[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
