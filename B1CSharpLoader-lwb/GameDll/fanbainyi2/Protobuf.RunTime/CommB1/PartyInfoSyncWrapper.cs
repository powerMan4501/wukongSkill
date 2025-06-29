using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class PartyInfoSyncWrapper : IMessage<PartyInfoSyncWrapper>, IMessage, IEquatable<PartyInfoSyncWrapper>, IDeepCloneable<PartyInfoSyncWrapper>
{
	private static readonly MessageParser<PartyInfoSyncWrapper> _parser = new MessageParser<PartyInfoSyncWrapper>(() => new PartyInfoSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper partyId_;

	private StringSyncWrapper partySessionId_;

	private Uint32SyncWrapper curPlayerNum_;

	private Uint32SyncWrapper maxPlayerNum_;

	private StringSyncWrapper ownerName_;

	private Int32SyncWrapper ownerLevel_;

	private BoolSyncWrapper hasPasswd_;

	private PartyAdvertiseTypeSyncWrapper advertiseType_;

	private Int32SyncWrapper taskType_;

	private static readonly FieldCodec<MemberInfoSyncWrapper> _repeated_memberInfo_codec = FieldCodec.ForMessage(98u, MemberInfoSyncWrapper.Parser);

	private readonly RepeatedField<MemberInfoSyncWrapper> memberInfo_ = new RepeatedField<MemberInfoSyncWrapper>();

	private PartyHelpParamSyncWrapper helpParam_;

	public static MessageParser<PartyInfoSyncWrapper> Parser => _parser;

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

	public Uint32SyncWrapper CurPlayerNum
	{
		get
		{
			return curPlayerNum_;
		}
		set
		{
			curPlayerNum_ = value;
		}
	}

	public Uint32SyncWrapper MaxPlayerNum
	{
		get
		{
			return maxPlayerNum_;
		}
		set
		{
			maxPlayerNum_ = value;
		}
	}

	public StringSyncWrapper OwnerName
	{
		get
		{
			return ownerName_;
		}
		set
		{
			ownerName_ = value;
		}
	}

	public Int32SyncWrapper OwnerLevel
	{
		get
		{
			return ownerLevel_;
		}
		set
		{
			ownerLevel_ = value;
		}
	}

	public BoolSyncWrapper HasPasswd
	{
		get
		{
			return hasPasswd_;
		}
		set
		{
			hasPasswd_ = value;
		}
	}

	public PartyAdvertiseTypeSyncWrapper AdvertiseType
	{
		get
		{
			return advertiseType_;
		}
		set
		{
			advertiseType_ = value;
		}
	}

	public Int32SyncWrapper TaskType
	{
		get
		{
			return taskType_;
		}
		set
		{
			taskType_ = value;
		}
	}

	public RepeatedField<MemberInfoSyncWrapper> MemberInfo => memberInfo_;

	public PartyHelpParamSyncWrapper HelpParam
	{
		get
		{
			return helpParam_;
		}
		set
		{
			helpParam_ = value;
		}
	}

	public PartyInfoSyncWrapper()
	{
	}

	public PartyInfoSyncWrapper(PartyInfoSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		partyId_ = ((other.partyId_ != null) ? other.partyId_.Clone() : null);
		partySessionId_ = ((other.partySessionId_ != null) ? other.partySessionId_.Clone() : null);
		curPlayerNum_ = ((other.curPlayerNum_ != null) ? other.curPlayerNum_.Clone() : null);
		maxPlayerNum_ = ((other.maxPlayerNum_ != null) ? other.maxPlayerNum_.Clone() : null);
		ownerName_ = ((other.ownerName_ != null) ? other.ownerName_.Clone() : null);
		ownerLevel_ = ((other.ownerLevel_ != null) ? other.ownerLevel_.Clone() : null);
		hasPasswd_ = ((other.hasPasswd_ != null) ? other.hasPasswd_.Clone() : null);
		advertiseType_ = ((other.advertiseType_ != null) ? other.advertiseType_.Clone() : null);
		taskType_ = ((other.taskType_ != null) ? other.taskType_.Clone() : null);
		memberInfo_ = other.memberInfo_.Clone();
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyInfoSyncWrapper Clone()
	{
		return new PartyInfoSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyInfoSyncWrapper);
	}

	public bool Equals(PartyInfoSyncWrapper other)
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
		if (!object.Equals(PartySessionId, other.PartySessionId))
		{
			return false;
		}
		if (!object.Equals(CurPlayerNum, other.CurPlayerNum))
		{
			return false;
		}
		if (!object.Equals(MaxPlayerNum, other.MaxPlayerNum))
		{
			return false;
		}
		if (!object.Equals(OwnerName, other.OwnerName))
		{
			return false;
		}
		if (!object.Equals(OwnerLevel, other.OwnerLevel))
		{
			return false;
		}
		if (!object.Equals(HasPasswd, other.HasPasswd))
		{
			return false;
		}
		if (!object.Equals(AdvertiseType, other.AdvertiseType))
		{
			return false;
		}
		if (!object.Equals(TaskType, other.TaskType))
		{
			return false;
		}
		if (!memberInfo_.Equals(other.memberInfo_))
		{
			return false;
		}
		if (!object.Equals(HelpParam, other.HelpParam))
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
		if (partySessionId_ != null)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (curPlayerNum_ != null)
		{
			num ^= CurPlayerNum.GetHashCode();
		}
		if (maxPlayerNum_ != null)
		{
			num ^= MaxPlayerNum.GetHashCode();
		}
		if (ownerName_ != null)
		{
			num ^= OwnerName.GetHashCode();
		}
		if (ownerLevel_ != null)
		{
			num ^= OwnerLevel.GetHashCode();
		}
		if (hasPasswd_ != null)
		{
			num ^= HasPasswd.GetHashCode();
		}
		if (advertiseType_ != null)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (taskType_ != null)
		{
			num ^= TaskType.GetHashCode();
		}
		num ^= memberInfo_.GetHashCode();
		if (helpParam_ != null)
		{
			num ^= HelpParam.GetHashCode();
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
		if (partySessionId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PartySessionId);
		}
		if (curPlayerNum_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CurPlayerNum);
		}
		if (maxPlayerNum_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MaxPlayerNum);
		}
		if (ownerName_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(OwnerName);
		}
		if (ownerLevel_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OwnerLevel);
		}
		if (hasPasswd_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HasPasswd);
		}
		if (advertiseType_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(AdvertiseType);
		}
		if (taskType_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(TaskType);
		}
		memberInfo_.WriteTo(output, _repeated_memberInfo_codec);
		if (helpParam_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(HelpParam);
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
		if (partySessionId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PartySessionId);
		}
		if (curPlayerNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurPlayerNum);
		}
		if (maxPlayerNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxPlayerNum);
		}
		if (ownerName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OwnerName);
		}
		if (ownerLevel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OwnerLevel);
		}
		if (hasPasswd_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HasPasswd);
		}
		if (advertiseType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AdvertiseType);
		}
		if (taskType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskType);
		}
		num += memberInfo_.CalculateSize(_repeated_memberInfo_codec);
		if (helpParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HelpParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyInfoSyncWrapper other)
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
		if (other.partySessionId_ != null)
		{
			if (partySessionId_ == null)
			{
				PartySessionId = new StringSyncWrapper();
			}
			PartySessionId.MergeFrom(other.PartySessionId);
		}
		if (other.curPlayerNum_ != null)
		{
			if (curPlayerNum_ == null)
			{
				CurPlayerNum = new Uint32SyncWrapper();
			}
			CurPlayerNum.MergeFrom(other.CurPlayerNum);
		}
		if (other.maxPlayerNum_ != null)
		{
			if (maxPlayerNum_ == null)
			{
				MaxPlayerNum = new Uint32SyncWrapper();
			}
			MaxPlayerNum.MergeFrom(other.MaxPlayerNum);
		}
		if (other.ownerName_ != null)
		{
			if (ownerName_ == null)
			{
				OwnerName = new StringSyncWrapper();
			}
			OwnerName.MergeFrom(other.OwnerName);
		}
		if (other.ownerLevel_ != null)
		{
			if (ownerLevel_ == null)
			{
				OwnerLevel = new Int32SyncWrapper();
			}
			OwnerLevel.MergeFrom(other.OwnerLevel);
		}
		if (other.hasPasswd_ != null)
		{
			if (hasPasswd_ == null)
			{
				HasPasswd = new BoolSyncWrapper();
			}
			HasPasswd.MergeFrom(other.HasPasswd);
		}
		if (other.advertiseType_ != null)
		{
			if (advertiseType_ == null)
			{
				AdvertiseType = new PartyAdvertiseTypeSyncWrapper();
			}
			AdvertiseType.MergeFrom(other.AdvertiseType);
		}
		if (other.taskType_ != null)
		{
			if (taskType_ == null)
			{
				TaskType = new Int32SyncWrapper();
			}
			TaskType.MergeFrom(other.TaskType);
		}
		memberInfo_.Add(other.memberInfo_);
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParamSyncWrapper();
			}
			HelpParam.MergeFrom(other.HelpParam);
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
				if (partySessionId_ == null)
				{
					PartySessionId = new StringSyncWrapper();
				}
				input.ReadMessage(PartySessionId);
				break;
			case 42u:
				if (curPlayerNum_ == null)
				{
					CurPlayerNum = new Uint32SyncWrapper();
				}
				input.ReadMessage(CurPlayerNum);
				break;
			case 50u:
				if (maxPlayerNum_ == null)
				{
					MaxPlayerNum = new Uint32SyncWrapper();
				}
				input.ReadMessage(MaxPlayerNum);
				break;
			case 58u:
				if (ownerName_ == null)
				{
					OwnerName = new StringSyncWrapper();
				}
				input.ReadMessage(OwnerName);
				break;
			case 66u:
				if (ownerLevel_ == null)
				{
					OwnerLevel = new Int32SyncWrapper();
				}
				input.ReadMessage(OwnerLevel);
				break;
			case 74u:
				if (hasPasswd_ == null)
				{
					HasPasswd = new BoolSyncWrapper();
				}
				input.ReadMessage(HasPasswd);
				break;
			case 82u:
				if (advertiseType_ == null)
				{
					AdvertiseType = new PartyAdvertiseTypeSyncWrapper();
				}
				input.ReadMessage(AdvertiseType);
				break;
			case 90u:
				if (taskType_ == null)
				{
					TaskType = new Int32SyncWrapper();
				}
				input.ReadMessage(TaskType);
				break;
			case 98u:
				memberInfo_.AddEntriesFrom(input, _repeated_memberInfo_codec);
				break;
			case 106u:
				if (helpParam_ == null)
				{
					HelpParam = new PartyHelpParamSyncWrapper();
				}
				input.ReadMessage(HelpParam);
				break;
			}
		}
	}
}
