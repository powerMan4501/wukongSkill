using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBulletAffectArea : IMessage<FUStBulletAffectArea>, IMessage, IEquatable<FUStBulletAffectArea>, IDeepCloneable<FUStBulletAffectArea>
{
	private static readonly MessageParser<FUStBulletAffectArea> _parser = new MessageParser<FUStBulletAffectArea>(() => new FUStBulletAffectArea());

	private UnknownFieldSet _unknownFields;

	private EBulletAreaType areaType_;

	private static readonly FieldCodec<float> _repeated_areaFloatParams_codec = FieldCodec.ForFloat(18u);

	private readonly RepeatedField<float> areaFloatParams_ = new RepeatedField<float>();

	public static MessageParser<FUStBulletAffectArea> Parser => _parser;

	public EBulletAreaType AreaType
	{
		get
		{
			return areaType_;
		}
		set
		{
			areaType_ = value;
		}
	}

	public RepeatedField<float> AreaFloatParams => areaFloatParams_;

	public FUStBulletAffectArea()
	{
	}

	public FUStBulletAffectArea(FUStBulletAffectArea other)
		: this()
	{
		areaType_ = other.areaType_;
		areaFloatParams_ = other.areaFloatParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBulletAffectArea Clone()
	{
		return new FUStBulletAffectArea(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBulletAffectArea);
	}

	public bool Equals(FUStBulletAffectArea other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaType != other.AreaType)
		{
			return false;
		}
		if (!areaFloatParams_.Equals(other.areaFloatParams_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AreaType != EBulletAreaType.None)
		{
			num ^= AreaType.GetHashCode();
		}
		num ^= areaFloatParams_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AreaType != EBulletAreaType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)AreaType);
		}
		areaFloatParams_.WriteTo(output, _repeated_areaFloatParams_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AreaType != EBulletAreaType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AreaType);
		}
		num += areaFloatParams_.CalculateSize(_repeated_areaFloatParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBulletAffectArea other)
	{
		if (other != null)
		{
			if (other.AreaType != EBulletAreaType.None)
			{
				AreaType = other.AreaType;
			}
			areaFloatParams_.Add(other.areaFloatParams_);
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
				AreaType = (EBulletAreaType)input.ReadEnum();
				break;
			case 18u:
			case 21u:
				areaFloatParams_.AddEntriesFrom(input, _repeated_areaFloatParams_codec);
				break;
			}
		}
	}
}
