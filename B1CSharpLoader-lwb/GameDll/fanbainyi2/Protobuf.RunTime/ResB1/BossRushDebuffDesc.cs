using System;
using Google.Protobuf;

namespace ResB1;

public sealed class BossRushDebuffDesc : IMessage<BossRushDebuffDesc>, IMessage, IEquatable<BossRushDebuffDesc>, IDeepCloneable<BossRushDebuffDesc>
{
	private static readonly MessageParser<BossRushDebuffDesc> _parser = new MessageParser<BossRushDebuffDesc>(() => new BossRushDebuffDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int debuffId_;

	private string debuffName_ = "";

	private string debuffDesc_ = "";

	private string debuffBriefDesc_ = "";

	private int debuffScore_;

	private int localizationTag_;

	public static MessageParser<BossRushDebuffDesc> Parser => _parser;

	public int Id
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

	public int DebuffId
	{
		get
		{
			return debuffId_;
		}
		set
		{
			debuffId_ = value;
		}
	}

	public string DebuffName
	{
		get
		{
			return debuffName_;
		}
		set
		{
			debuffName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DebuffDesc
	{
		get
		{
			return debuffDesc_;
		}
		set
		{
			debuffDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DebuffBriefDesc
	{
		get
		{
			return debuffBriefDesc_;
		}
		set
		{
			debuffBriefDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DebuffScore
	{
		get
		{
			return debuffScore_;
		}
		set
		{
			debuffScore_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public BossRushDebuffDesc()
	{
	}

	public BossRushDebuffDesc(BossRushDebuffDesc other)
		: this()
	{
		id_ = other.id_;
		debuffId_ = other.debuffId_;
		debuffName_ = other.debuffName_;
		debuffDesc_ = other.debuffDesc_;
		debuffBriefDesc_ = other.debuffBriefDesc_;
		debuffScore_ = other.debuffScore_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushDebuffDesc Clone()
	{
		return new BossRushDebuffDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushDebuffDesc);
	}

	public bool Equals(BossRushDebuffDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (DebuffId != other.DebuffId)
		{
			return false;
		}
		if (DebuffName != other.DebuffName)
		{
			return false;
		}
		if (DebuffDesc != other.DebuffDesc)
		{
			return false;
		}
		if (DebuffBriefDesc != other.DebuffBriefDesc)
		{
			return false;
		}
		if (DebuffScore != other.DebuffScore)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (DebuffId != 0)
		{
			num ^= DebuffId.GetHashCode();
		}
		if (DebuffName.Length != 0)
		{
			num ^= DebuffName.GetHashCode();
		}
		if (DebuffDesc.Length != 0)
		{
			num ^= DebuffDesc.GetHashCode();
		}
		if (DebuffBriefDesc.Length != 0)
		{
			num ^= DebuffBriefDesc.GetHashCode();
		}
		if (DebuffScore != 0)
		{
			num ^= DebuffScore.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (DebuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DebuffId);
		}
		if (DebuffName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DebuffName);
		}
		if (DebuffDesc.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DebuffDesc);
		}
		if (DebuffBriefDesc.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DebuffBriefDesc);
		}
		if (DebuffScore != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DebuffScore);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (DebuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DebuffId);
		}
		if (DebuffName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebuffName);
		}
		if (DebuffDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebuffDesc);
		}
		if (DebuffBriefDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebuffBriefDesc);
		}
		if (DebuffScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DebuffScore);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushDebuffDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DebuffId != 0)
			{
				DebuffId = other.DebuffId;
			}
			if (other.DebuffName.Length != 0)
			{
				DebuffName = other.DebuffName;
			}
			if (other.DebuffDesc.Length != 0)
			{
				DebuffDesc = other.DebuffDesc;
			}
			if (other.DebuffBriefDesc.Length != 0)
			{
				DebuffBriefDesc = other.DebuffBriefDesc;
			}
			if (other.DebuffScore != 0)
			{
				DebuffScore = other.DebuffScore;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
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
				Id = input.ReadInt32();
				break;
			case 16u:
				DebuffId = input.ReadInt32();
				break;
			case 26u:
				DebuffName = input.ReadString();
				break;
			case 34u:
				DebuffDesc = input.ReadString();
				break;
			case 42u:
				DebuffBriefDesc = input.ReadString();
				break;
			case 48u:
				DebuffScore = input.ReadInt32();
				break;
			case 56u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
