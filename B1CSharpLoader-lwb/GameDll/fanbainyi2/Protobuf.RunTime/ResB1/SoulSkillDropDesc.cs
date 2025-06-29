using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SoulSkillDropDesc : IMessage<SoulSkillDropDesc>, IMessage, IEquatable<SoulSkillDropDesc>, IDeepCloneable<SoulSkillDropDesc>
{
	private static readonly MessageParser<SoulSkillDropDesc> _parser = new MessageParser<SoulSkillDropDesc>(() => new SoulSkillDropDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int soulSkillId_;

	private string bpPath_ = "";

	private int dropRate_;

	private int safeDropStartTimes_;

	private int safeDropMaxTimes_;

	public static MessageParser<SoulSkillDropDesc> Parser => _parser;

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

	public int SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public string BpPath
	{
		get
		{
			return bpPath_;
		}
		set
		{
			bpPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DropRate
	{
		get
		{
			return dropRate_;
		}
		set
		{
			dropRate_ = value;
		}
	}

	public int SafeDropStartTimes
	{
		get
		{
			return safeDropStartTimes_;
		}
		set
		{
			safeDropStartTimes_ = value;
		}
	}

	public int SafeDropMaxTimes
	{
		get
		{
			return safeDropMaxTimes_;
		}
		set
		{
			safeDropMaxTimes_ = value;
		}
	}

	public SoulSkillDropDesc()
	{
	}

	public SoulSkillDropDesc(SoulSkillDropDesc other)
		: this()
	{
		id_ = other.id_;
		soulSkillId_ = other.soulSkillId_;
		bpPath_ = other.bpPath_;
		dropRate_ = other.dropRate_;
		safeDropStartTimes_ = other.safeDropStartTimes_;
		safeDropMaxTimes_ = other.safeDropMaxTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoulSkillDropDesc Clone()
	{
		return new SoulSkillDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoulSkillDropDesc);
	}

	public bool Equals(SoulSkillDropDesc other)
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
		if (SoulSkillId != other.SoulSkillId)
		{
			return false;
		}
		if (BpPath != other.BpPath)
		{
			return false;
		}
		if (DropRate != other.DropRate)
		{
			return false;
		}
		if (SafeDropStartTimes != other.SafeDropStartTimes)
		{
			return false;
		}
		if (SafeDropMaxTimes != other.SafeDropMaxTimes)
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
		if (SoulSkillId != 0)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (BpPath.Length != 0)
		{
			num ^= BpPath.GetHashCode();
		}
		if (DropRate != 0)
		{
			num ^= DropRate.GetHashCode();
		}
		if (SafeDropStartTimes != 0)
		{
			num ^= SafeDropStartTimes.GetHashCode();
		}
		if (SafeDropMaxTimes != 0)
		{
			num ^= SafeDropMaxTimes.GetHashCode();
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
		if (SoulSkillId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SoulSkillId);
		}
		if (BpPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BpPath);
		}
		if (DropRate != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DropRate);
		}
		if (SafeDropStartTimes != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SafeDropStartTimes);
		}
		if (SafeDropMaxTimes != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SafeDropMaxTimes);
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
		if (SoulSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillId);
		}
		if (BpPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BpPath);
		}
		if (DropRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropRate);
		}
		if (SafeDropStartTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SafeDropStartTimes);
		}
		if (SafeDropMaxTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SafeDropMaxTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoulSkillDropDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SoulSkillId != 0)
			{
				SoulSkillId = other.SoulSkillId;
			}
			if (other.BpPath.Length != 0)
			{
				BpPath = other.BpPath;
			}
			if (other.DropRate != 0)
			{
				DropRate = other.DropRate;
			}
			if (other.SafeDropStartTimes != 0)
			{
				SafeDropStartTimes = other.SafeDropStartTimes;
			}
			if (other.SafeDropMaxTimes != 0)
			{
				SafeDropMaxTimes = other.SafeDropMaxTimes;
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
				SoulSkillId = input.ReadInt32();
				break;
			case 26u:
				BpPath = input.ReadString();
				break;
			case 32u:
				DropRate = input.ReadInt32();
				break;
			case 40u:
				SafeDropStartTimes = input.ReadInt32();
				break;
			case 48u:
				SafeDropMaxTimes = input.ReadInt32();
				break;
			}
		}
	}
}
