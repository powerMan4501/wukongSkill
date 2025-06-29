using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitTransStageDesc : IMessage<FUStUnitTransStageDesc>, IMessage, IEquatable<FUStUnitTransStageDesc>, IDeepCloneable<FUStUnitTransStageDesc>
{
	private static readonly MessageParser<FUStUnitTransStageDesc> _parser = new MessageParser<FUStUnitTransStageDesc>(() => new FUStUnitTransStageDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_unitResID_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> unitResID_ = new RepeatedField<int>();

	public static MessageParser<FUStUnitTransStageDesc> Parser => _parser;

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

	public RepeatedField<int> UnitResID => unitResID_;

	public FUStUnitTransStageDesc()
	{
	}

	public FUStUnitTransStageDesc(FUStUnitTransStageDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitTransStageDesc Clone()
	{
		return new FUStUnitTransStageDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitTransStageDesc);
	}

	public bool Equals(FUStUnitTransStageDesc other)
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
		if (!unitResID_.Equals(other.unitResID_))
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
		num ^= unitResID_.GetHashCode();
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
		unitResID_.WriteTo(output, _repeated_unitResID_codec);
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
		num += unitResID_.CalculateSize(_repeated_unitResID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitTransStageDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			unitResID_.Add(other.unitResID_);
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
			case 18u:
				unitResID_.AddEntriesFrom(input, _repeated_unitResID_codec);
				break;
			}
		}
	}
}
