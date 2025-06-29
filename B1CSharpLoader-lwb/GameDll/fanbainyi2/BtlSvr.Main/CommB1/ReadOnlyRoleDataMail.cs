using System.Text;

namespace CommB1;

public class ReadOnlyRoleDataMail
{
	private RoleDataMail mData;

	private ReadOnlyAwolMsgPlayerMailList _Mails;

	private ReadOnlyUint64List _ReceivedServerMail;

	public ReadOnlyAwolMsgPlayerMailList Mails
	{
		get
		{
			if (_Mails == null)
			{
				_Mails = new ReadOnlyAwolMsgPlayerMailList(mData.Mails);
			}
			return _Mails;
		}
	}

	public ReadOnlyUint64List ReceivedServerMail
	{
		get
		{
			if (_ReceivedServerMail == null)
			{
				_ReceivedServerMail = new ReadOnlyUint64List(mData.ReceivedServerMail);
			}
			return _ReceivedServerMail;
		}
	}

	public ReadOnlyRoleDataMail(RoleDataMail data)
	{
		mData = data;
	}

	public ReadOnlyRoleDataMail Clone()
	{
		return new ReadOnlyRoleDataMail(mData.Clone());
	}

	public RoleDataMail ForceGetRef()
	{
		return mData;
	}

	public RoleDataMail CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleDataMail>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Mails=[\n");
		for (int i = 0; i < Mails.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Mails[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ReceivedServerMail=[\n");
		for (int j = 0; j < ReceivedServerMail.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ReceivedServerMail[j]);
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
