using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class RoleDataMailSyncWrapper : IMessage<RoleDataMailSyncWrapper>, IMessage, IEquatable<RoleDataMailSyncWrapper>, IDeepCloneable<RoleDataMailSyncWrapper>
{
	private static readonly MessageParser<RoleDataMailSyncWrapper> _parser = new MessageParser<RoleDataMailSyncWrapper>(() => new RoleDataMailSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<AwolMsgPlayerMailSyncWrapper> _repeated_mails_codec = FieldCodec.ForMessage(26u, AwolMsgPlayerMailSyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgPlayerMailSyncWrapper> mails_ = new RepeatedField<AwolMsgPlayerMailSyncWrapper>();

	private static readonly FieldCodec<Uint64SyncWrapper> _repeated_receivedServerMail_codec = FieldCodec.ForMessage(34u, Uint64SyncWrapper.Parser);

	private readonly RepeatedField<Uint64SyncWrapper> receivedServerMail_ = new RepeatedField<Uint64SyncWrapper>();

	public static MessageParser<RoleDataMailSyncWrapper> Parser => _parser;

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

	public RepeatedField<AwolMsgPlayerMailSyncWrapper> Mails => mails_;

	public RepeatedField<Uint64SyncWrapper> ReceivedServerMail => receivedServerMail_;

	public RoleDataMailSyncWrapper()
	{
	}

	public RoleDataMailSyncWrapper(RoleDataMailSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		mails_ = other.mails_.Clone();
		receivedServerMail_ = other.receivedServerMail_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataMailSyncWrapper Clone()
	{
		return new RoleDataMailSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataMailSyncWrapper);
	}

	public bool Equals(RoleDataMailSyncWrapper other)
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
		if (!mails_.Equals(other.mails_))
		{
			return false;
		}
		if (!receivedServerMail_.Equals(other.receivedServerMail_))
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
		num ^= mails_.GetHashCode();
		num ^= receivedServerMail_.GetHashCode();
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
		mails_.WriteTo(output, _repeated_mails_codec);
		receivedServerMail_.WriteTo(output, _repeated_receivedServerMail_codec);
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
		num += mails_.CalculateSize(_repeated_mails_codec);
		num += receivedServerMail_.CalculateSize(_repeated_receivedServerMail_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataMailSyncWrapper other)
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
			mails_.Add(other.mails_);
			receivedServerMail_.Add(other.receivedServerMail_);
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
				mails_.AddEntriesFrom(input, _repeated_mails_codec);
				break;
			case 34u:
				receivedServerMail_.AddEntriesFrom(input, _repeated_receivedServerMail_codec);
				break;
			}
		}
	}
}
