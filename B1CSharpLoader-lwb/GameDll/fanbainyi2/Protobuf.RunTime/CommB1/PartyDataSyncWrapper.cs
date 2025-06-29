using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class PartyDataSyncWrapper : IMessage<PartyDataSyncWrapper>, IMessage, IEquatable<PartyDataSyncWrapper>, IDeepCloneable<PartyDataSyncWrapper>
{
	private static readonly MessageParser<PartyDataSyncWrapper> _parser = new MessageParser<PartyDataSyncWrapper>(() => new PartyDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper partyId_;

	private StringSyncWrapper partyIdStr_;

	private StringSyncWrapper partySessionId_;

	private PartySettingSyncWrapper setting_;

	private Uint64SyncWrapper owner_;

	private static readonly FieldCodec<PartyMemberSyncWrapper> _repeated_members_codec = FieldCodec.ForMessage(66u, PartyMemberSyncWrapper.Parser);

	private readonly RepeatedField<PartyMemberSyncWrapper> members_ = new RepeatedField<PartyMemberSyncWrapper>();

	private PartyTaskSyncWrapper task_;

	public static MessageParser<PartyDataSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper PartyId
	{
		get
		{
			return partyId_;
		}
		set
		{
			partyId_ = value;
		}
	}

	public StringSyncWrapper PartyIdStr
	{
		get
		{
			return partyIdStr_;
		}
		set
		{
			partyIdStr_ = value;
		}
	}

	public StringSyncWrapper PartySessionId
	{
		get
		{
			return partySessionId_;
		}
		set
		{
			partySessionId_ = value;
		}
	}

	public PartySettingSyncWrapper Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public Uint64SyncWrapper Owner
	{
		get
		{
			return owner_;
		}
		set
		{
			owner_ = value;
		}
	}

	public RepeatedField<PartyMemberSyncWrapper> Members => members_;

	public PartyTaskSyncWrapper Task
	{
		get
		{
			return task_;
		}
		set
		{
			task_ = value;
		}
	}

	public PartyDataSyncWrapper()
	{
	}

	public PartyDataSyncWrapper(PartyDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		partyId_ = ((other.partyId_ != null) ? other.partyId_.Clone() : null);
		partyIdStr_ = ((other.partyIdStr_ != null) ? other.partyIdStr_.Clone() : null);
		partySessionId_ = ((other.partySessionId_ != null) ? other.partySessionId_.Clone() : null);
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		owner_ = ((other.owner_ != null) ? other.owner_.Clone() : null);
		members_ = other.members_.Clone();
		task_ = ((other.task_ != null) ? other.task_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyDataSyncWrapper Clone()
	{
		return new PartyDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyDataSyncWrapper);
	}

	public bool Equals(PartyDataSyncWrapper other)
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
		if (!object.Equals(PartyId, other.PartyId))
		{
			return false;
		}
		if (!object.Equals(PartyIdStr, other.PartyIdStr))
		{
			return false;
		}
		if (!object.Equals(PartySessionId, other.PartySessionId))
		{
			return false;
		}
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		if (!object.Equals(Owner, other.Owner))
		{
			return false;
		}
		if (!members_.Equals(other.members_))
		{
			return false;
		}
		if (!object.Equals(Task, other.Task))
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
		if (partyId_ != null)
		{
			num ^= PartyId.GetHashCode();
		}
		if (partyIdStr_ != null)
		{
			num ^= PartyIdStr.GetHashCode();
		}
		if (partySessionId_ != null)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (owner_ != null)
		{
			num ^= Owner.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (task_ != null)
		{
			num ^= Task.GetHashCode();
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
		if (partyId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PartyId);
		}
		if (partyIdStr_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PartyIdStr);
		}
		if (partySessionId_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PartySessionId);
		}
		if (setting_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Setting);
		}
		if (owner_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Owner);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (task_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Task);
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
		if (partyId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PartyId);
		}
		if (partyIdStr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PartyIdStr);
		}
		if (partySessionId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PartySessionId);
		}
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (owner_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Owner);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (task_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Task);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyDataSyncWrapper other)
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
		if (other.partyId_ != null)
		{
			if (partyId_ == null)
			{
				PartyId = new Uint64SyncWrapper();
			}
			PartyId.MergeFrom(other.PartyId);
		}
		if (other.partyIdStr_ != null)
		{
			if (partyIdStr_ == null)
			{
				PartyIdStr = new StringSyncWrapper();
			}
			PartyIdStr.MergeFrom(other.PartyIdStr);
		}
		if (other.partySessionId_ != null)
		{
			if (partySessionId_ == null)
			{
				PartySessionId = new StringSyncWrapper();
			}
			PartySessionId.MergeFrom(other.PartySessionId);
		}
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new PartySettingSyncWrapper();
			}
			Setting.MergeFrom(other.Setting);
		}
		if (other.owner_ != null)
		{
			if (owner_ == null)
			{
				Owner = new Uint64SyncWrapper();
			}
			Owner.MergeFrom(other.Owner);
		}
		members_.Add(other.members_);
		if (other.task_ != null)
		{
			if (task_ == null)
			{
				Task = new PartyTaskSyncWrapper();
			}
			Task.MergeFrom(other.Task);
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
				if (partyId_ == null)
				{
					PartyId = new Uint64SyncWrapper();
				}
				input.ReadMessage(PartyId);
				break;
			case 34u:
				if (partyIdStr_ == null)
				{
					PartyIdStr = new StringSyncWrapper();
				}
				input.ReadMessage(PartyIdStr);
				break;
			case 42u:
				if (partySessionId_ == null)
				{
					PartySessionId = new StringSyncWrapper();
				}
				input.ReadMessage(PartySessionId);
				break;
			case 50u:
				if (setting_ == null)
				{
					Setting = new PartySettingSyncWrapper();
				}
				input.ReadMessage(Setting);
				break;
			case 58u:
				if (owner_ == null)
				{
					Owner = new Uint64SyncWrapper();
				}
				input.ReadMessage(Owner);
				break;
			case 66u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			case 74u:
				if (task_ == null)
				{
					Task = new PartyTaskSyncWrapper();
				}
				input.ReadMessage(Task);
				break;
			}
		}
	}
}
