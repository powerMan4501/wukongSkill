using System.Text;

namespace CommB1;

public class ReadOnlyCSAwolMsgOne
{
	private CSAwolMsgOne mData;

	private ReadOnlyAwolMsgPlayerMail _PlayerMail;

	private ReadOnlyAwolMsgServerMail _ServerMail;

	private ReadOnlyAwolMsgPlayerChat _Chat;

	private ReadOnlyAwolMsgPlayerCommand _Command;

	private ReadOnlyAwolMsgPlayerNotify _Notify;

	public AwolMsgType MsgType => mData.MsgType;

	public ReadOnlyAwolMsgPlayerMail PlayerMail
	{
		get
		{
			if (_PlayerMail == null && mData.PlayerMail != null)
			{
				_PlayerMail = new ReadOnlyAwolMsgPlayerMail(mData.PlayerMail);
			}
			return _PlayerMail;
		}
	}

	public ReadOnlyAwolMsgServerMail ServerMail
	{
		get
		{
			if (_ServerMail == null && mData.ServerMail != null)
			{
				_ServerMail = new ReadOnlyAwolMsgServerMail(mData.ServerMail);
			}
			return _ServerMail;
		}
	}

	public ReadOnlyAwolMsgPlayerChat Chat
	{
		get
		{
			if (_Chat == null && mData.Chat != null)
			{
				_Chat = new ReadOnlyAwolMsgPlayerChat(mData.Chat);
			}
			return _Chat;
		}
	}

	public ReadOnlyAwolMsgPlayerCommand Command
	{
		get
		{
			if (_Command == null && mData.Command != null)
			{
				_Command = new ReadOnlyAwolMsgPlayerCommand(mData.Command);
			}
			return _Command;
		}
	}

	public ReadOnlyAwolMsgPlayerNotify Notify
	{
		get
		{
			if (_Notify == null && mData.Notify != null)
			{
				_Notify = new ReadOnlyAwolMsgPlayerNotify(mData.Notify);
			}
			return _Notify;
		}
	}

	public ReadOnlyCSAwolMsgOne(CSAwolMsgOne data)
	{
		mData = data;
	}

	public ReadOnlyCSAwolMsgOne Clone()
	{
		return new ReadOnlyCSAwolMsgOne(mData.Clone());
	}

	public CSAwolMsgOne ForceGetRef()
	{
		return mData;
	}

	public CSAwolMsgOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCSAwolMsgOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MsgType={0},\n", MsgType);
		if (PlayerMail != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("PlayerMail=");
			PlayerMail.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("PlayerMail=null,\n");
		}
		if (ServerMail != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("ServerMail=");
			ServerMail.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("ServerMail=null,\n");
		}
		if (Chat != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Chat=");
			Chat.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Chat=null,\n");
		}
		if (Command != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Command=");
			Command.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Command=null,\n");
		}
		if (Notify != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Notify=");
			Notify.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Notify=null,\n");
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
