using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DSkillLevelMapDesc : IMessage<FUStB2DSkillLevelMapDesc>, IMessage, IEquatable<FUStB2DSkillLevelMapDesc>, IDeepCloneable<FUStB2DSkillLevelMapDesc>
{
	private static readonly MessageParser<FUStB2DSkillLevelMapDesc> _parser = new MessageParser<FUStB2DSkillLevelMapDesc>(() => new FUStB2DSkillLevelMapDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<int> _repeated_skillsId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> skillsId_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_skillsLevel_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> skillsLevel_ = new RepeatedField<int>();

	public static MessageParser<FUStB2DSkillLevelMapDesc> Parser => _parser;

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

	public RepeatedField<int> SkillsId => skillsId_;

	public RepeatedField<int> SkillsLevel => skillsLevel_;

	public FUStB2DSkillLevelMapDesc()
	{
	}

	public FUStB2DSkillLevelMapDesc(FUStB2DSkillLevelMapDesc other)
		: this()
	{
		id_ = other.id_;
		skillsId_ = other.skillsId_.Clone();
		skillsLevel_ = other.skillsLevel_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillLevelMapDesc Clone()
	{
		return new FUStB2DSkillLevelMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillLevelMapDesc);
	}

	public bool Equals(FUStB2DSkillLevelMapDesc other)
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
		if (!skillsId_.Equals(other.skillsId_))
		{
			return false;
		}
		if (!skillsLevel_.Equals(other.skillsLevel_))
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
		num ^= skillsId_.GetHashCode();
		num ^= skillsLevel_.GetHashCode();
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
		skillsId_.WriteTo(output, _repeated_skillsId_codec);
		skillsLevel_.WriteTo(output, _repeated_skillsLevel_codec);
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
		num += skillsId_.CalculateSize(_repeated_skillsId_codec);
		num += skillsLevel_.CalculateSize(_repeated_skillsLevel_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillLevelMapDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			skillsId_.Add(other.skillsId_);
			skillsLevel_.Add(other.skillsLevel_);
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
			case 18u:
				skillsId_.AddEntriesFrom(input, _repeated_skillsId_codec);
				break;
			case 24u:
			case 26u:
				skillsLevel_.AddEntriesFrom(input, _repeated_skillsLevel_codec);
				break;
			}
		}
	}
}
