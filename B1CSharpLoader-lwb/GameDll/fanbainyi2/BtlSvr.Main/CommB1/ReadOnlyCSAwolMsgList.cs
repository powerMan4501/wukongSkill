using System.Text;

namespace CommB1;

public class ReadOnlyCSAwolMsgList
{
	private CSAwolMsgList mData;

	private ReadOnlyAwolMsgPlayerMailList _Mails;

	private ReadOnlyAwolMsgPlayerChatList _Chats;

	private ReadOnlyAwolMsgPlayerNotifyList _Notifys;

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

	public ReadOnlyAwolMsgPlayerChatList Chats
	{
		get
		{
			if (_Chats == null)
			{
				_Chats = new ReadOnlyAwolMsgPlayerChatList(mData.Chats);
			}
			return _Chats;
		}
	}

	public ReadOnlyAwolMsgPlayerNotifyList Notifys
	{
		get
		{
			if (_Notifys == null)
			{
				_Notifys = new ReadOnlyAwolMsgPlayerNotifyList(mData.Notifys);
			}
			return _Notifys;
		}
	}

	public ReadOnlyCSAwolMsgList(CSAwolMsgList data)
	{
		mData = data;
	}

	public ReadOnlyCSAwolMsgList Clone()
	{
		return new ReadOnlyCSAwolMsgList(mData.Clone());
	}

	public CSAwolMsgList ForceGetRef()
	{
		return mData;
	}

	public CSAwolMsgList CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCSAwolMsgList>{\n");
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
		builder.Append("Chats=[\n");
		for (int j = 0; j < Chats.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Chats[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Notifys=[\n");
		for (int k = 0; k < Notifys.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Notifys[k].DumpAsString(builder, indent, cur_indent + indent + indent);
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
