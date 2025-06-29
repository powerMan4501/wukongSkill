using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class MailBaseSyncWrapper : IMessage<MailBaseSyncWrapper>, IMessage, IEquatable<MailBaseSyncWrapper>, IDeepCloneable<MailBaseSyncWrapper>
{
	private static readonly MessageParser<MailBaseSyncWrapper> _parser = new MessageParser<MailBaseSyncWrapper>(() => new MailBaseSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint32SyncWrapper id_;

	private MailTypeSyncWrapper mailType_;

	private MailStateSyncWrapper state_;

	private MailOptionSyncWrapper option_;

	private static readonly FieldCodec<RoleItemSyncWrapper> _repeated_attachements_codec = FieldCodec.ForMessage(58u, RoleItemSyncWrapper.Parser);

	private readonly RepeatedField<RoleItemSyncWrapper> attachements_ = new RepeatedField<RoleItemSyncWrapper>();

	private MailExtSyncWrapper ext_;

	public static MessageParser<MailBaseSyncWrapper> Parser => _parser;

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

	public Uint32SyncWrapper Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public MailTypeSyncWrapper MailType
	{
		get
		{
			return mailType_;
		}
		set
		{
			mailType_ = value;
		}
	}

	public MailStateSyncWrapper State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public MailOptionSyncWrapper Option
	{
		get
		{
			return option_;
		}
		set
		{
			option_ = value;
		}
	}

	public RepeatedField<RoleItemSyncWrapper> Attachements => attachements_;

	public MailExtSyncWrapper Ext
	{
		get
		{
			return ext_;
		}
		set
		{
			ext_ = value;
		}
	}

	public MailBaseSyncWrapper()
	{
	}

	public MailBaseSyncWrapper(MailBaseSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		mailType_ = ((other.mailType_ != null) ? other.mailType_.Clone() : null);
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		option_ = ((other.option_ != null) ? other.option_.Clone() : null);
		attachements_ = other.attachements_.Clone();
		ext_ = ((other.ext_ != null) ? other.ext_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailBaseSyncWrapper Clone()
	{
		return new MailBaseSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailBaseSyncWrapper);
	}

	public bool Equals(MailBaseSyncWrapper other)
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
		if (!object.Equals(Id, other.Id))
		{
			return false;
		}
		if (!object.Equals(MailType, other.MailType))
		{
			return false;
		}
		if (!object.Equals(State, other.State))
		{
			return false;
		}
		if (!object.Equals(Option, other.Option))
		{
			return false;
		}
		if (!attachements_.Equals(other.attachements_))
		{
			return false;
		}
		if (!object.Equals(Ext, other.Ext))
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
		if (id_ != null)
		{
			num ^= Id.GetHashCode();
		}
		if (mailType_ != null)
		{
			num ^= MailType.GetHashCode();
		}
		if (state_ != null)
		{
			num ^= State.GetHashCode();
		}
		if (option_ != null)
		{
			num ^= Option.GetHashCode();
		}
		num ^= attachements_.GetHashCode();
		if (ext_ != null)
		{
			num ^= Ext.GetHashCode();
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
		if (id_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Id);
		}
		if (mailType_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MailType);
		}
		if (state_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(State);
		}
		if (option_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Option);
		}
		attachements_.WriteTo(output, _repeated_attachements_codec);
		if (ext_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Ext);
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
		if (id_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Id);
		}
		if (mailType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MailType);
		}
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (option_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Option);
		}
		num += attachements_.CalculateSize(_repeated_attachements_codec);
		if (ext_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ext);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailBaseSyncWrapper other)
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
		if (other.id_ != null)
		{
			if (id_ == null)
			{
				Id = new Uint32SyncWrapper();
			}
			Id.MergeFrom(other.Id);
		}
		if (other.mailType_ != null)
		{
			if (mailType_ == null)
			{
				MailType = new MailTypeSyncWrapper();
			}
			MailType.MergeFrom(other.MailType);
		}
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new MailStateSyncWrapper();
			}
			State.MergeFrom(other.State);
		}
		if (other.option_ != null)
		{
			if (option_ == null)
			{
				Option = new MailOptionSyncWrapper();
			}
			Option.MergeFrom(other.Option);
		}
		attachements_.Add(other.attachements_);
		if (other.ext_ != null)
		{
			if (ext_ == null)
			{
				Ext = new MailExtSyncWrapper();
			}
			Ext.MergeFrom(other.Ext);
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
				if (id_ == null)
				{
					Id = new Uint32SyncWrapper();
				}
				input.ReadMessage(Id);
				break;
			case 34u:
				if (mailType_ == null)
				{
					MailType = new MailTypeSyncWrapper();
				}
				input.ReadMessage(MailType);
				break;
			case 42u:
				if (state_ == null)
				{
					State = new MailStateSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			case 50u:
				if (option_ == null)
				{
					Option = new MailOptionSyncWrapper();
				}
				input.ReadMessage(Option);
				break;
			case 58u:
				attachements_.AddEntriesFrom(input, _repeated_attachements_codec);
				break;
			case 66u:
				if (ext_ == null)
				{
					Ext = new MailExtSyncWrapper();
				}
				input.ReadMessage(Ext);
				break;
			}
		}
	}
}
