using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionCustomSettingSyncWrapper : IMessage<SessionCustomSettingSyncWrapper>, IMessage, IEquatable<SessionCustomSettingSyncWrapper>, IDeepCloneable<SessionCustomSettingSyncWrapper>
{
	private static readonly MessageParser<SessionCustomSettingSyncWrapper> _parser = new MessageParser<SessionCustomSettingSyncWrapper>(() => new SessionCustomSettingSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private StringSyncWrapper key_;

	private StringSyncWrapper value_;

	public static MessageParser<SessionCustomSettingSyncWrapper> Parser => _parser;

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

	public StringSyncWrapper Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	public StringSyncWrapper Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public SessionCustomSettingSyncWrapper()
	{
	}

	public SessionCustomSettingSyncWrapper(SessionCustomSettingSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		key_ = ((other.key_ != null) ? other.key_.Clone() : null);
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionCustomSettingSyncWrapper Clone()
	{
		return new SessionCustomSettingSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionCustomSettingSyncWrapper);
	}

	public bool Equals(SessionCustomSettingSyncWrapper other)
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
		if (!object.Equals(Key, other.Key))
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
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
		if (key_ != null)
		{
			num ^= Key.GetHashCode();
		}
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
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
		if (key_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Key);
		}
		if (value_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Value);
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
		if (key_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Key);
		}
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionCustomSettingSyncWrapper other)
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
		if (other.key_ != null)
		{
			if (key_ == null)
			{
				Key = new StringSyncWrapper();
			}
			Key.MergeFrom(other.Key);
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new StringSyncWrapper();
			}
			Value.MergeFrom(other.Value);
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
				if (key_ == null)
				{
					Key = new StringSyncWrapper();
				}
				input.ReadMessage(Key);
				break;
			case 34u:
				if (value_ == null)
				{
					Value = new StringSyncWrapper();
				}
				input.ReadMessage(Value);
				break;
			}
		}
	}
}
