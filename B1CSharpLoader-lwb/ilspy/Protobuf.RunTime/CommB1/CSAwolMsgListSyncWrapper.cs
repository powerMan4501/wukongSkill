using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CSAwolMsgListSyncWrapper : IMessage<CSAwolMsgListSyncWrapper>, IMessage, IEquatable<CSAwolMsgListSyncWrapper>, IDeepCloneable<CSAwolMsgListSyncWrapper>
{
	private static readonly MessageParser<CSAwolMsgListSyncWrapper> _parser = new MessageParser<CSAwolMsgListSyncWrapper>(() => new CSAwolMsgListSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<AwolMsgPlayerMailSyncWrapper> _repeated_mails_codec = FieldCodec.ForMessage(26u, AwolMsgPlayerMailSyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgPlayerMailSyncWrapper> mails_ = new RepeatedField<AwolMsgPlayerMailSyncWrapper>();

	private static readonly FieldCodec<AwolMsgPlayerChatSyncWrapper> _repeated_chats_codec = FieldCodec.ForMessage(34u, AwolMsgPlayerChatSyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgPlayerChatSyncWrapper> chats_ = new RepeatedField<AwolMsgPlayerChatSyncWrapper>();

	private static readonly FieldCodec<AwolMsgPlayerNotifySyncWrapper> _repeated_notifys_codec = FieldCodec.ForMessage(42u, AwolMsgPlayerNotifySyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgPlayerNotifySyncWrapper> notifys_ = new RepeatedField<AwolMsgPlayerNotifySyncWrapper>();

	public static MessageParser<CSAwolMsgListSyncWrapper> Parser => _parser;

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

	public RepeatedField<AwolMsgPlayerChatSyncWrapper> Chats => chats_;

	public RepeatedField<AwolMsgPlayerNotifySyncWrapper> Notifys => notifys_;

	public CSAwolMsgListSyncWrapper()
	{
	}

	public CSAwolMsgListSyncWrapper(CSAwolMsgListSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		mails_ = other.mails_.Clone();
		chats_ = other.chats_.Clone();
		notifys_ = other.notifys_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSAwolMsgListSyncWrapper Clone()
	{
		return new CSAwolMsgListSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSAwolMsgListSyncWrapper);
	}

	public bool Equals(CSAwolMsgListSyncWrapper other)
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
		if (!chats_.Equals(other.chats_))
		{
			return false;
		}
		if (!notifys_.Equals(other.notifys_))
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
		num ^= chats_.GetHashCode();
		num ^= notifys_.GetHashCode();
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
		chats_.WriteTo(output, _repeated_chats_codec);
		notifys_.WriteTo(output, _repeated_notifys_codec);
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
		num += chats_.CalculateSize(_repeated_chats_codec);
		num += notifys_.CalculateSize(_repeated_notifys_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSAwolMsgListSyncWrapper other)
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
			chats_.Add(other.chats_);
			notifys_.Add(other.notifys_);
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
				chats_.AddEntriesFrom(input, _repeated_chats_codec);
				break;
			case 42u:
				notifys_.AddEntriesFrom(input, _repeated_notifys_codec);
				break;
			}
		}
	}
}
