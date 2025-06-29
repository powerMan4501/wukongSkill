using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class PartyInfo : IMessage<PartyInfo>, IMessage, IEquatable<PartyInfo>, IDeepCloneable<PartyInfo>
{
	private static readonly MessageParser<PartyInfo> _parser = new MessageParser<PartyInfo>(() => new PartyInfo());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private string partySessionId_ = "";

	private uint curPlayerNum_;

	private uint maxPlayerNum_;

	private string ownerName_ = "";

	private int ownerLevel_;

	private bool hasPasswd_;

	private PartyAdvertiseType advertiseType_;

	private int taskType_;

	private static readonly FieldCodec<MemberInfo> _repeated_memberInfo_codec = FieldCodec.ForMessage(82u, CommB1.MemberInfo.Parser);

	private readonly RepeatedField<MemberInfo> memberInfo_ = new RepeatedField<MemberInfo>();

	private PartyHelpParam helpParam_;

	public static MessageParser<PartyInfo> Parser => _parser;

	public ulong PartyId
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

	public string PartySessionId
	{
		get
		{
			return partySessionId_;
		}
		set
		{
			partySessionId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint CurPlayerNum
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

	public uint MaxPlayerNum
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

	public string OwnerName
	{
		get
		{
			return ownerName_;
		}
		set
		{
			ownerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int OwnerLevel
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

	public bool HasPasswd
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

	public PartyAdvertiseType AdvertiseType
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

	public int TaskType
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

	public RepeatedField<MemberInfo> MemberInfo => memberInfo_;

	public PartyHelpParam HelpParam
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

	public PartyInfo()
	{
	}

	public PartyInfo(PartyInfo other)
		: this()
	{
		partyId_ = other.partyId_;
		partySessionId_ = other.partySessionId_;
		curPlayerNum_ = other.curPlayerNum_;
		maxPlayerNum_ = other.maxPlayerNum_;
		ownerName_ = other.ownerName_;
		ownerLevel_ = other.ownerLevel_;
		hasPasswd_ = other.hasPasswd_;
		advertiseType_ = other.advertiseType_;
		taskType_ = other.taskType_;
		memberInfo_ = other.memberInfo_.Clone();
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyInfo Clone()
	{
		return new PartyInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyInfo);
	}

	public bool Equals(PartyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PartyId != other.PartyId)
		{
			return false;
		}
		if (PartySessionId != other.PartySessionId)
		{
			return false;
		}
		if (CurPlayerNum != other.CurPlayerNum)
		{
			return false;
		}
		if (MaxPlayerNum != other.MaxPlayerNum)
		{
			return false;
		}
		if (OwnerName != other.OwnerName)
		{
			return false;
		}
		if (OwnerLevel != other.OwnerLevel)
		{
			return false;
		}
		if (HasPasswd != other.HasPasswd)
		{
			return false;
		}
		if (AdvertiseType != other.AdvertiseType)
		{
			return false;
		}
		if (TaskType != other.TaskType)
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
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (PartySessionId.Length != 0)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (CurPlayerNum != 0)
		{
			num ^= CurPlayerNum.GetHashCode();
		}
		if (MaxPlayerNum != 0)
		{
			num ^= MaxPlayerNum.GetHashCode();
		}
		if (OwnerName.Length != 0)
		{
			num ^= OwnerName.GetHashCode();
		}
		if (OwnerLevel != 0)
		{
			num ^= OwnerLevel.GetHashCode();
		}
		if (HasPasswd)
		{
			num ^= HasPasswd.GetHashCode();
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (TaskType != 0)
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
		if (PartyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PartyId);
		}
		if (PartySessionId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PartySessionId);
		}
		if (CurPlayerNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CurPlayerNum);
		}
		if (MaxPlayerNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MaxPlayerNum);
		}
		if (OwnerName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(OwnerName);
		}
		if (OwnerLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(OwnerLevel);
		}
		if (HasPasswd)
		{
			output.WriteRawTag(56);
			output.WriteBool(HasPasswd);
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)AdvertiseType);
		}
		if (TaskType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(TaskType);
		}
		memberInfo_.WriteTo(output, _repeated_memberInfo_codec);
		if (helpParam_ != null)
		{
			output.WriteRawTag(90);
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
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (PartySessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartySessionId);
		}
		if (CurPlayerNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPlayerNum);
		}
		if (MaxPlayerNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxPlayerNum);
		}
		if (OwnerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OwnerName);
		}
		if (OwnerLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwnerLevel);
		}
		if (HasPasswd)
		{
			num += 2;
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (TaskType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskType);
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

	public void MergeFrom(PartyInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.PartySessionId.Length != 0)
		{
			PartySessionId = other.PartySessionId;
		}
		if (other.CurPlayerNum != 0)
		{
			CurPlayerNum = other.CurPlayerNum;
		}
		if (other.MaxPlayerNum != 0)
		{
			MaxPlayerNum = other.MaxPlayerNum;
		}
		if (other.OwnerName.Length != 0)
		{
			OwnerName = other.OwnerName;
		}
		if (other.OwnerLevel != 0)
		{
			OwnerLevel = other.OwnerLevel;
		}
		if (other.HasPasswd)
		{
			HasPasswd = other.HasPasswd;
		}
		if (other.AdvertiseType != PartyAdvertiseType.Public)
		{
			AdvertiseType = other.AdvertiseType;
		}
		if (other.TaskType != 0)
		{
			TaskType = other.TaskType;
		}
		memberInfo_.Add(other.memberInfo_);
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParam();
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
				PartyId = input.ReadUInt64();
				break;
			case 18u:
				PartySessionId = input.ReadString();
				break;
			case 24u:
				CurPlayerNum = input.ReadUInt32();
				break;
			case 32u:
				MaxPlayerNum = input.ReadUInt32();
				break;
			case 42u:
				OwnerName = input.ReadString();
				break;
			case 48u:
				OwnerLevel = input.ReadInt32();
				break;
			case 56u:
				HasPasswd = input.ReadBool();
				break;
			case 64u:
				AdvertiseType = (PartyAdvertiseType)input.ReadEnum();
				break;
			case 72u:
				TaskType = input.ReadInt32();
				break;
			case 82u:
				memberInfo_.AddEntriesFrom(input, _repeated_memberInfo_codec);
				break;
			case 90u:
				if (helpParam_ == null)
				{
					HelpParam = new PartyHelpParam();
				}
				input.ReadMessage(HelpParam);
				break;
			}
		}
	}
}
