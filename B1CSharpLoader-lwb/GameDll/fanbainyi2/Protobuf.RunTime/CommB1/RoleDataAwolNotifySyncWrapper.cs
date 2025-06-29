using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoleDataAwolNotifySyncWrapper : IMessage<RoleDataAwolNotifySyncWrapper>, IMessage, IEquatable<RoleDataAwolNotifySyncWrapper>, IDeepCloneable<RoleDataAwolNotifySyncWrapper>
{
	private static readonly MessageParser<RoleDataAwolNotifySyncWrapper> _parser = new MessageParser<RoleDataAwolNotifySyncWrapper>(() => new RoleDataAwolNotifySyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<AwolMsgPlayerNotifySyncWrapper> _repeated_notifies_codec = FieldCodec.ForMessage(26u, AwolMsgPlayerNotifySyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgPlayerNotifySyncWrapper> notifies_ = new RepeatedField<AwolMsgPlayerNotifySyncWrapper>();

	public static MessageParser<RoleDataAwolNotifySyncWrapper> Parser => _parser;

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

	public RepeatedField<AwolMsgPlayerNotifySyncWrapper> Notifies => notifies_;

	public RoleDataAwolNotifySyncWrapper()
	{
	}

	public RoleDataAwolNotifySyncWrapper(RoleDataAwolNotifySyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		notifies_ = other.notifies_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataAwolNotifySyncWrapper Clone()
	{
		return new RoleDataAwolNotifySyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataAwolNotifySyncWrapper);
	}

	public bool Equals(RoleDataAwolNotifySyncWrapper other)
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
		if (!notifies_.Equals(other.notifies_))
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
		num ^= notifies_.GetHashCode();
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
		notifies_.WriteTo(output, _repeated_notifies_codec);
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
		num += notifies_.CalculateSize(_repeated_notifies_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataAwolNotifySyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			notifies_.Add(other.notifies_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				notifies_.AddEntriesFrom(input, _repeated_notifies_codec);
				break;
			}
		}
	}
}
