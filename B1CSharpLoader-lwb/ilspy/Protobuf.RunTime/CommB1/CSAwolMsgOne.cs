using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CSAwolMsgOne : IMessage<CSAwolMsgOne>, IMessage, IEquatable<CSAwolMsgOne>, IDeepCloneable<CSAwolMsgOne>
{
	private static readonly MessageParser<CSAwolMsgOne> _parser = new MessageParser<CSAwolMsgOne>(() => new CSAwolMsgOne());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private AwolMsgPlayerMail playerMail_;

	private AwolMsgServerMail serverMail_;

	private AwolMsgPlayerChat chat_;

	private AwolMsgPlayerCommand command_;

	private AwolMsgPlayerNotify notify_;

	public static MessageParser<CSAwolMsgOne> Parser => _parser;

	public AwolMsgType MsgType
	{
		get
		{
			return msgType_;
		}
		set
		{
			msgType_ = value;
		}
	}

	public AwolMsgPlayerMail PlayerMail
	{
		get
		{
			return playerMail_;
		}
		set
		{
			playerMail_ = value;
		}
	}

	public AwolMsgServerMail ServerMail
	{
		get
		{
			return serverMail_;
		}
		set
		{
			serverMail_ = value;
		}
	}

	public AwolMsgPlayerChat Chat
	{
		get
		{
			return chat_;
		}
		set
		{
			chat_ = value;
		}
	}

	public AwolMsgPlayerCommand Command
	{
		get
		{
			return command_;
		}
		set
		{
			command_ = value;
		}
	}

	public AwolMsgPlayerNotify Notify
	{
		get
		{
			return notify_;
		}
		set
		{
			notify_ = value;
		}
	}

	public CSAwolMsgOne()
	{
	}

	public CSAwolMsgOne(CSAwolMsgOne other)
		: this()
	{
		msgType_ = other.msgType_;
		playerMail_ = ((other.playerMail_ != null) ? other.playerMail_.Clone() : null);
		serverMail_ = ((other.serverMail_ != null) ? other.serverMail_.Clone() : null);
		chat_ = ((other.chat_ != null) ? other.chat_.Clone() : null);
		command_ = ((other.command_ != null) ? other.command_.Clone() : null);
		notify_ = ((other.notify_ != null) ? other.notify_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSAwolMsgOne Clone()
	{
		return new CSAwolMsgOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSAwolMsgOne);
	}

	public bool Equals(CSAwolMsgOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MsgType != other.MsgType)
		{
			return false;
		}
		if (!object.Equals(PlayerMail, other.PlayerMail))
		{
			return false;
		}
		if (!object.Equals(ServerMail, other.ServerMail))
		{
			return false;
		}
		if (!object.Equals(Chat, other.Chat))
		{
			return false;
		}
		if (!object.Equals(Command, other.Command))
		{
			return false;
		}
		if (!object.Equals(Notify, other.Notify))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MsgType != AwolMsgType.None)
		{
			num ^= MsgType.GetHashCode();
		}
		if (playerMail_ != null)
		{
			num ^= PlayerMail.GetHashCode();
		}
		if (serverMail_ != null)
		{
			num ^= ServerMail.GetHashCode();
		}
		if (chat_ != null)
		{
			num ^= Chat.GetHashCode();
		}
		if (command_ != null)
		{
			num ^= Command.GetHashCode();
		}
		if (notify_ != null)
		{
			num ^= Notify.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MsgType != AwolMsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MsgType);
		}
		if (playerMail_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PlayerMail);
		}
		if (serverMail_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ServerMail);
		}
		if (chat_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Chat);
		}
		if (command_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Command);
		}
		if (notify_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Notify);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MsgType != AwolMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MsgType);
		}
		if (playerMail_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerMail);
		}
		if (serverMail_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ServerMail);
		}
		if (chat_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Chat);
		}
		if (command_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Command);
		}
		if (notify_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Notify);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSAwolMsgOne other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MsgType != AwolMsgType.None)
		{
			MsgType = other.MsgType;
		}
		if (other.playerMail_ != null)
		{
			if (playerMail_ == null)
			{
				PlayerMail = new AwolMsgPlayerMail();
			}
			PlayerMail.MergeFrom(other.PlayerMail);
		}
		if (other.serverMail_ != null)
		{
			if (serverMail_ == null)
			{
				ServerMail = new AwolMsgServerMail();
			}
			ServerMail.MergeFrom(other.ServerMail);
		}
		if (other.chat_ != null)
		{
			if (chat_ == null)
			{
				Chat = new AwolMsgPlayerChat();
			}
			Chat.MergeFrom(other.Chat);
		}
		if (other.command_ != null)
		{
			if (command_ == null)
			{
				Command = new AwolMsgPlayerCommand();
			}
			Command.MergeFrom(other.Command);
		}
		if (other.notify_ != null)
		{
			if (notify_ == null)
			{
				Notify = new AwolMsgPlayerNotify();
			}
			Notify.MergeFrom(other.Notify);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				MsgType = (AwolMsgType)input.ReadEnum();
				break;
			case 18u:
				if (playerMail_ == null)
				{
					PlayerMail = new AwolMsgPlayerMail();
				}
				input.ReadMessage(PlayerMail);
				break;
			case 26u:
				if (serverMail_ == null)
				{
					ServerMail = new AwolMsgServerMail();
				}
				input.ReadMessage(ServerMail);
				break;
			case 34u:
				if (chat_ == null)
				{
					Chat = new AwolMsgPlayerChat();
				}
				input.ReadMessage(Chat);
				break;
			case 42u:
				if (command_ == null)
				{
					Command = new AwolMsgPlayerCommand();
				}
				input.ReadMessage(Command);
				break;
			case 50u:
				if (notify_ == null)
				{
					Notify = new AwolMsgPlayerNotify();
				}
				input.ReadMessage(Notify);
				break;
			}
		}
	}
}
