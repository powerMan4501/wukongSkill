using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class LegacyTalent : IMessage<LegacyTalent>, IMessage, IEquatable<LegacyTalent>, IDeepCloneable<LegacyTalent>
{
	private static readonly MessageParser<LegacyTalent> _parser = new MessageParser<LegacyTalent>(() => new LegacyTalent());

	private UnknownFieldSet _unknownFields;

	private int talentId_;

	private bool isActive_;

	public static MessageParser<LegacyTalent> Parser => _parser;

	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return isActive_;
		}
		set
		{
			isActive_ = value;
		}
	}

	public LegacyTalent()
	{
	}

	public LegacyTalent(LegacyTalent other)
		: this()
	{
		talentId_ = other.talentId_;
		isActive_ = other.isActive_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LegacyTalent Clone()
	{
		return new LegacyTalent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LegacyTalent);
	}

	public bool Equals(LegacyTalent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TalentId != other.TalentId)
		{
			return false;
		}
		if (IsActive != other.IsActive)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (IsActive)
		{
			num ^= IsActive.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TalentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TalentId);
		}
		if (IsActive)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsActive);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TalentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (IsActive)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LegacyTalent other)
	{
		if (other != null)
		{
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
			}
			if (other.IsActive)
			{
				IsActive = other.IsActive;
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
				TalentId = input.ReadInt32();
				break;
			case 16u:
				IsActive = input.ReadBool();
				break;
			}
		}
	}
}
