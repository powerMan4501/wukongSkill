using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAttrEffectDesc : IMessage<FUStAttrEffectDesc>, IMessage, IEquatable<FUStAttrEffectDesc>, IDeepCloneable<FUStAttrEffectDesc>
{
	private static readonly MessageParser<FUStAttrEffectDesc> _parser = new MessageParser<FUStAttrEffectDesc>(() => new FUStAttrEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<FUStAttrEffectConfig> _repeated_attrEffects_codec = FieldCodec.ForMessage(18u, FUStAttrEffectConfig.Parser);

	private readonly RepeatedField<FUStAttrEffectConfig> attrEffects_ = new RepeatedField<FUStAttrEffectConfig>();

	public static MessageParser<FUStAttrEffectDesc> Parser => _parser;

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

	public RepeatedField<FUStAttrEffectConfig> AttrEffects => attrEffects_;

	public FUStAttrEffectDesc()
	{
	}

	public FUStAttrEffectDesc(FUStAttrEffectDesc other)
		: this()
	{
		iD_ = other.iD_;
		attrEffects_ = other.attrEffects_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttrEffectDesc Clone()
	{
		return new FUStAttrEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttrEffectDesc);
	}

	public bool Equals(FUStAttrEffectDesc other)
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
		if (!attrEffects_.Equals(other.attrEffects_))
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
		num ^= attrEffects_.GetHashCode();
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
		attrEffects_.WriteTo(output, _repeated_attrEffects_codec);
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
		num += attrEffects_.CalculateSize(_repeated_attrEffects_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttrEffectDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			attrEffects_.Add(other.attrEffects_);
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
				attrEffects_.AddEntriesFrom(input, _repeated_attrEffects_codec);
				break;
			}
		}
	}
}
