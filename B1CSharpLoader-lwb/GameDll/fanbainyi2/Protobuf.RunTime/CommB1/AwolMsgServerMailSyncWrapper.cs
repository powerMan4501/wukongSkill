using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class AwolMsgServerMailSyncWrapper : IMessage<AwolMsgServerMailSyncWrapper>, IMessage, IEquatable<AwolMsgServerMailSyncWrapper>, IDeepCloneable<AwolMsgServerMailSyncWrapper>
{
	private static readonly MessageParser<AwolMsgServerMailSyncWrapper> _parser = new MessageParser<AwolMsgServerMailSyncWrapper>(() => new AwolMsgServerMailSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MailBaseSyncWrapper base_;

	private static readonly FieldCodec<ServerMailContentSyncWrapper> _repeated_contents_codec = FieldCodec.ForMessage(34u, ServerMailContentSyncWrapper.Parser);

	private readonly RepeatedField<ServerMailContentSyncWrapper> contents_ = new RepeatedField<ServerMailContentSyncWrapper>();

	public static MessageParser<AwolMsgServerMailSyncWrapper> Parser => _parser;

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

	public MailBaseSyncWrapper Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public RepeatedField<ServerMailContentSyncWrapper> Contents => contents_;

	public AwolMsgServerMailSyncWrapper()
	{
	}

	public AwolMsgServerMailSyncWrapper(AwolMsgServerMailSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		contents_ = other.contents_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgServerMailSyncWrapper Clone()
	{
		return new AwolMsgServerMailSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgServerMailSyncWrapper);
	}

	public bool Equals(AwolMsgServerMailSyncWrapper other)
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
		if (!object.Equals(Base, other.Base))
		{
			return false;
		}
		if (!contents_.Equals(other.contents_))
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
		if (base_ != null)
		{
			num ^= Base.GetHashCode();
		}
		num ^= contents_.GetHashCode();
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
		if (base_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Base);
		}
		contents_.WriteTo(output, _repeated_contents_codec);
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
		if (base_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Base);
		}
		num += contents_.CalculateSize(_repeated_contents_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgServerMailSyncWrapper other)
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
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new MailBaseSyncWrapper();
			}
			Base.MergeFrom(other.Base);
		}
		contents_.Add(other.contents_);
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
				if (base_ == null)
				{
					Base = new MailBaseSyncWrapper();
				}
				input.ReadMessage(Base);
				break;
			case 34u:
				contents_.AddEntriesFrom(input, _repeated_contents_codec);
				break;
			}
		}
	}
}
