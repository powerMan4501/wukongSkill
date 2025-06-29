using System;
using Google.Protobuf;

namespace CommB1;

public sealed class DBShareMsg : IMessage<DBShareMsg>, IMessage, IEquatable<DBShareMsg>, IDeepCloneable<DBShareMsg>
{
	private static readonly MessageParser<DBShareMsg> _parser = new MessageParser<DBShareMsg>(() => new DBShareMsg());

	private UnknownFieldSet _unknownFields;

	private ulong actorId_;

	private ShareMsgType msgType_;

	private PlayerState playerState_;

	private PlayerBrief playerBrief_;

	public static MessageParser<DBShareMsg> Parser => _parser;

	public ulong ActorId
	{
		get
		{
			return actorId_;
		}
		set
		{
			actorId_ = value;
		}
	}

	public ShareMsgType MsgType
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

	public PlayerState PlayerState
	{
		get
		{
			return playerState_;
		}
		set
		{
			playerState_ = value;
		}
	}

	public PlayerBrief PlayerBrief
	{
		get
		{
			return playerBrief_;
		}
		set
		{
			playerBrief_ = value;
		}
	}

	public DBShareMsg()
	{
	}

	public DBShareMsg(DBShareMsg other)
		: this()
	{
		actorId_ = other.actorId_;
		msgType_ = other.msgType_;
		playerState_ = ((other.playerState_ != null) ? other.playerState_.Clone() : null);
		playerBrief_ = ((other.playerBrief_ != null) ? other.playerBrief_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DBShareMsg Clone()
	{
		return new DBShareMsg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DBShareMsg);
	}

	public bool Equals(DBShareMsg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ActorId != other.ActorId)
		{
			return false;
		}
		if (MsgType != other.MsgType)
		{
			return false;
		}
		if (!object.Equals(PlayerState, other.PlayerState))
		{
			return false;
		}
		if (!object.Equals(PlayerBrief, other.PlayerBrief))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ActorId != 0L)
		{
			num ^= ActorId.GetHashCode();
		}
		if (MsgType != ShareMsgType.None)
		{
			num ^= MsgType.GetHashCode();
		}
		if (playerState_ != null)
		{
			num ^= PlayerState.GetHashCode();
		}
		if (playerBrief_ != null)
		{
			num ^= PlayerBrief.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ActorId != 0L)
		{
			output.WriteRawTag(9);
			output.WriteFixed64(ActorId);
		}
		if (MsgType != ShareMsgType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MsgType);
		}
		if (playerState_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PlayerState);
		}
		if (playerBrief_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerBrief);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ActorId != 0L)
		{
			num += 9;
		}
		if (MsgType != ShareMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MsgType);
		}
		if (playerState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerState);
		}
		if (playerBrief_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerBrief);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DBShareMsg other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ActorId != 0L)
		{
			ActorId = other.ActorId;
		}
		if (other.MsgType != ShareMsgType.None)
		{
			MsgType = other.MsgType;
		}
		if (other.playerState_ != null)
		{
			if (playerState_ == null)
			{
				PlayerState = new PlayerState();
			}
			PlayerState.MergeFrom(other.PlayerState);
		}
		if (other.playerBrief_ != null)
		{
			if (playerBrief_ == null)
			{
				PlayerBrief = new PlayerBrief();
			}
			PlayerBrief.MergeFrom(other.PlayerBrief);
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
			case 9u:
				ActorId = input.ReadFixed64();
				break;
			case 16u:
				MsgType = (ShareMsgType)input.ReadEnum();
				break;
			case 26u:
				if (playerState_ == null)
				{
					PlayerState = new PlayerState();
				}
				input.ReadMessage(PlayerState);
				break;
			case 34u:
				if (playerBrief_ == null)
				{
					PlayerBrief = new PlayerBrief();
				}
				input.ReadMessage(PlayerBrief);
				break;
			}
		}
	}
}
