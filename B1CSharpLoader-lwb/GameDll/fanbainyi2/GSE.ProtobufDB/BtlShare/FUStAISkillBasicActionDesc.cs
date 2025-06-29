using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAISkillBasicActionDesc : IMessage<FUStAISkillBasicActionDesc>, IMessage, IEquatable<FUStAISkillBasicActionDesc>, IDeepCloneable<FUStAISkillBasicActionDesc>
{
	private static readonly MessageParser<FUStAISkillBasicActionDesc> _parser = new MessageParser<FUStAISkillBasicActionDesc>(() => new FUStAISkillBasicActionDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isMappedSkill_;

	private static readonly FieldCodec<FUStBasicAction> _repeated_basicActions_codec = FieldCodec.ForMessage(26u, FUStBasicAction.Parser);

	private readonly RepeatedField<FUStBasicAction> basicActions_ = new RepeatedField<FUStBasicAction>();

	public static MessageParser<FUStAISkillBasicActionDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EGSYesNo IsMappedSkill
	{
		get
		{
			return isMappedSkill_;
		}
		set
		{
			isMappedSkill_ = value;
		}
	}

	public RepeatedField<FUStBasicAction> BasicActions => basicActions_;

	public FUStAISkillBasicActionDesc()
	{
	}

	public FUStAISkillBasicActionDesc(FUStAISkillBasicActionDesc other)
		: this()
	{
		iD_ = other.iD_;
		isMappedSkill_ = other.isMappedSkill_;
		basicActions_ = other.basicActions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAISkillBasicActionDesc Clone()
	{
		return new FUStAISkillBasicActionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAISkillBasicActionDesc);
	}

	public bool Equals(FUStAISkillBasicActionDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (IsMappedSkill != other.IsMappedSkill)
		{
			return false;
		}
		if (!basicActions_.Equals(other.basicActions_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (IsMappedSkill != EGSYesNo.No)
		{
			num ^= IsMappedSkill.GetHashCode();
		}
		num ^= basicActions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (IsMappedSkill != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsMappedSkill);
		}
		basicActions_.WriteTo(output, _repeated_basicActions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (IsMappedSkill != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsMappedSkill);
		}
		num += basicActions_.CalculateSize(_repeated_basicActions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAISkillBasicActionDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsMappedSkill != EGSYesNo.No)
			{
				IsMappedSkill = other.IsMappedSkill;
			}
			basicActions_.Add(other.basicActions_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				IsMappedSkill = (EGSYesNo)input.ReadEnum();
				break;
			case 26u:
				basicActions_.AddEntriesFrom(input, _repeated_basicActions_codec);
				break;
			}
		}
	}
}
