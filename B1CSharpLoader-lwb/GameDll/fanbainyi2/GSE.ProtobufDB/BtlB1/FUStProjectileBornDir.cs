using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileBornDir : IMessage<FUStProjectileBornDir>, IMessage, IEquatable<FUStProjectileBornDir>, IDeepCloneable<FUStProjectileBornDir>
{
	private static readonly MessageParser<FUStProjectileBornDir> _parser = new MessageParser<FUStProjectileBornDir>(() => new FUStProjectileBornDir());

	private UnknownFieldSet _unknownFields;

	private int bornDirType_;

	private static readonly FieldCodec<float> _repeated_hitPointNormalDir_codec = FieldCodec.ForFloat(18u);

	private readonly RepeatedField<float> hitPointNormalDir_ = new RepeatedField<float>();

	public static MessageParser<FUStProjectileBornDir> Parser => _parser;

	public int BornDirType
	{
		get
		{
			return bornDirType_;
		}
		set
		{
			bornDirType_ = value;
		}
	}

	public RepeatedField<float> HitPointNormalDir => hitPointNormalDir_;

	public FUStProjectileBornDir()
	{
	}

	public FUStProjectileBornDir(FUStProjectileBornDir other)
		: this()
	{
		bornDirType_ = other.bornDirType_;
		hitPointNormalDir_ = other.hitPointNormalDir_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileBornDir Clone()
	{
		return new FUStProjectileBornDir(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileBornDir);
	}

	public bool Equals(FUStProjectileBornDir other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BornDirType != other.BornDirType)
		{
			return false;
		}
		if (!hitPointNormalDir_.Equals(other.hitPointNormalDir_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BornDirType != 0)
		{
			num ^= BornDirType.GetHashCode();
		}
		num ^= hitPointNormalDir_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BornDirType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BornDirType);
		}
		hitPointNormalDir_.WriteTo(output, _repeated_hitPointNormalDir_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BornDirType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BornDirType);
		}
		num += hitPointNormalDir_.CalculateSize(_repeated_hitPointNormalDir_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileBornDir other)
	{
		if (other != null)
		{
			if (other.BornDirType != 0)
			{
				BornDirType = other.BornDirType;
			}
			hitPointNormalDir_.Add(other.hitPointNormalDir_);
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
				BornDirType = input.ReadInt32();
				break;
			case 18u:
			case 21u:
				hitPointNormalDir_.AddEntriesFrom(input, _repeated_hitPointNormalDir_codec);
				break;
			}
		}
	}
}
