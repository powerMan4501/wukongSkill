using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DAutoPathDesc : IMessage<FUStB2DAutoPathDesc>, IMessage, IEquatable<FUStB2DAutoPathDesc>, IDeepCloneable<FUStB2DAutoPathDesc>
{
	private static readonly MessageParser<FUStB2DAutoPathDesc> _parser = new MessageParser<FUStB2DAutoPathDesc>(() => new FUStB2DAutoPathDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int level_;

	private static readonly FieldCodec<AutoPathPos> _repeated_autoPos_codec = FieldCodec.ForMessage(26u, AutoPathPos.Parser);

	private readonly RepeatedField<AutoPathPos> autoPos_ = new RepeatedField<AutoPathPos>();

	public static MessageParser<FUStB2DAutoPathDesc> Parser => _parser;

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

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public RepeatedField<AutoPathPos> AutoPos => autoPos_;

	public FUStB2DAutoPathDesc()
	{
	}

	public FUStB2DAutoPathDesc(FUStB2DAutoPathDesc other)
		: this()
	{
		id_ = other.id_;
		level_ = other.level_;
		autoPos_ = other.autoPos_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DAutoPathDesc Clone()
	{
		return new FUStB2DAutoPathDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DAutoPathDesc);
	}

	public bool Equals(FUStB2DAutoPathDesc other)
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
		if (Level != other.Level)
		{
			return false;
		}
		if (!autoPos_.Equals(other.autoPos_))
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= autoPos_.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Level);
		}
		autoPos_.WriteTo(output, _repeated_autoPos_codec);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		num += autoPos_.CalculateSize(_repeated_autoPos_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DAutoPathDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			autoPos_.Add(other.autoPos_);
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
				Level = input.ReadInt32();
				break;
			case 26u:
				autoPos_.AddEntriesFrom(input, _repeated_autoPos_codec);
				break;
			}
		}
	}
}
