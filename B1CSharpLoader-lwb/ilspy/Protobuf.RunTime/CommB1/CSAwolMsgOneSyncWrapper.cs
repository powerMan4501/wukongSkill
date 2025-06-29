using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CSAwolMsgOneSyncWrapper : IMessage<CSAwolMsgOneSyncWrapper>, IMessage, IEquatable<CSAwolMsgOneSyncWrapper>, IDeepCloneable<CSAwolMsgOneSyncWrapper>
{
	private static readonly MessageParser<CSAwolMsgOneSyncWrapper> _parser = new MessageParser<CSAwolMsgOneSyncWrapper>(() => new CSAwolMsgOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private AwolMsgTypeSyncWrapper msgType_;

	private AwolMsgPlayerMailSyncWrapper playerMail_;

	private AwolMsgServerMailSyncWrapper serverMail_;

	private AwolMsgPlayerChatSyncWrapper chat_;

	private AwolMsgPlayerCommandSyncWrapper command_;

	private AwolMsgPlayerNotifySyncWrapper notify_;

	public static MessageParser<CSAwolMsgOneSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public AwolMsgTypeSyncWrapper MsgType
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

	public AwolMsgPlayerMailSyncWrapper PlayerMail
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

	public AwolMsgServerMailSyncWrapper ServerMail
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

	public AwolMsgPlayerChatSyncWrapper Chat
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

	public AwolMsgPlayerCommandSyncWrapper Command
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

	public AwolMsgPlayerNotifySyncWrapper Notify
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

	public CSAwolMsgOneSyncWrapper()
	{
	}

	public CSAwolMsgOneSyncWrapper(CSAwolMsgOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		msgType_ = ((other.msgType_ != null) ? other.msgType_.Clone() : null);
		playerMail_ = ((other.playerMail_ != null) ? other.playerMail_.Clone() : null);
		serverMail_ = ((other.serverMail_ != null) ? other.serverMail_.Clone() : null);
		chat_ = ((other.chat_ != null) ? other.chat_.Clone() : null);
		command_ = ((other.command_ != null) ? other.command_.Clone() : null);
		notify_ = ((other.notify_ != null) ? other.notify_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSAwolMsgOneSyncWrapper Clone()
	{
		return new CSAwolMsgOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSAwolMsgOneSyncWrapper);
	}

	public bool Equals(CSAwolMsgOneSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(MsgType, other.MsgType))
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
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (msgType_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (msgType_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MsgType);
		}
		if (playerMail_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerMail);
		}
		if (serverMail_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ServerMail);
		}
		if (chat_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Chat);
		}
		if (command_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Command);
		}
		if (notify_ != null)
		{
			output.WriteRawTag(66);
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
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (msgType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MsgType);
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

	public void MergeFrom(CSAwolMsgOneSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.msgType_ != null)
		{
			if (msgType_ == null)
			{
				MsgType = new AwolMsgTypeSyncWrapper();
			}
			MsgType.MergeFrom(other.MsgType);
		}
		if (other.playerMail_ != null)
		{
			if (playerMail_ == null)
			{
				PlayerMail = new AwolMsgPlayerMailSyncWrapper();
			}
			PlayerMail.MergeFrom(other.PlayerMail);
		}
		if (other.serverMail_ != null)
		{
			if (serverMail_ == null)
			{
				ServerMail = new AwolMsgServerMailSyncWrapper();
			}
			ServerMail.MergeFrom(other.ServerMail);
		}
		if (other.chat_ != null)
		{
			if (chat_ == null)
			{
				Chat = new AwolMsgPlayerChatSyncWrapper();
			}
			Chat.MergeFrom(other.Chat);
		}
		if (other.command_ != null)
		{
			if (command_ == null)
			{
				Command = new AwolMsgPlayerCommandSyncWrapper();
			}
			Command.MergeFrom(other.Command);
		}
		if (other.notify_ != null)
		{
			if (notify_ == null)
			{
				Notify = new AwolMsgPlayerNotifySyncWrapper();
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (msgType_ == null)
				{
					MsgType = new AwolMsgTypeSyncWrapper();
				}
				input.ReadMessage(MsgType);
				break;
			case 34u:
				if (playerMail_ == null)
				{
					PlayerMail = new AwolMsgPlayerMailSyncWrapper();
				}
				input.ReadMessage(PlayerMail);
				break;
			case 42u:
				if (serverMail_ == null)
				{
					ServerMail = new AwolMsgServerMailSyncWrapper();
				}
				input.ReadMessage(ServerMail);
				break;
			case 50u:
				if (chat_ == null)
				{
					Chat = new AwolMsgPlayerChatSyncWrapper();
				}
				input.ReadMessage(Chat);
				break;
			case 58u:
				if (command_ == null)
				{
					Command = new AwolMsgPlayerCommandSyncWrapper();
				}
				input.ReadMessage(Command);
				break;
			case 66u:
				if (notify_ == null)
				{
					Notify = new AwolMsgPlayerNotifySyncWrapper();
				}
				input.ReadMessage(Notify);
				break;
			}
		}
	}
}
