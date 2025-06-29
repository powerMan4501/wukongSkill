using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPhysicalHitBoneRuleDesc : IMessage<FUStPhysicalHitBoneRuleDesc>, IMessage, IEquatable<FUStPhysicalHitBoneRuleDesc>, IDeepCloneable<FUStPhysicalHitBoneRuleDesc>
{
	private static readonly MessageParser<FUStPhysicalHitBoneRuleDesc> _parser = new MessageParser<FUStPhysicalHitBoneRuleDesc>(() => new FUStPhysicalHitBoneRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<string> _repeated_boneName_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> boneName_ = new RepeatedField<string>();

	public static MessageParser<FUStPhysicalHitBoneRuleDesc> Parser => _parser;

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

	public RepeatedField<string> BoneName => boneName_;

	public FUStPhysicalHitBoneRuleDesc()
	{
	}

	public FUStPhysicalHitBoneRuleDesc(FUStPhysicalHitBoneRuleDesc other)
		: this()
	{
		iD_ = other.iD_;
		boneName_ = other.boneName_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPhysicalHitBoneRuleDesc Clone()
	{
		return new FUStPhysicalHitBoneRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPhysicalHitBoneRuleDesc);
	}

	public bool Equals(FUStPhysicalHitBoneRuleDesc other)
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
		if (!boneName_.Equals(other.boneName_))
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
		num ^= boneName_.GetHashCode();
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
		boneName_.WriteTo(output, _repeated_boneName_codec);
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
		num += boneName_.CalculateSize(_repeated_boneName_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPhysicalHitBoneRuleDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			boneName_.Add(other.boneName_);
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
			case 18u:
				boneName_.AddEntriesFrom(input, _repeated_boneName_codec);
				break;
			}
		}
	}
}
