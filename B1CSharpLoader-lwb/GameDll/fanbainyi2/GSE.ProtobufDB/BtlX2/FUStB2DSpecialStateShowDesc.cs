using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DSpecialStateShowDesc : IMessage<FUStB2DSpecialStateShowDesc>, IMessage, IEquatable<FUStB2DSpecialStateShowDesc>, IDeepCloneable<FUStB2DSpecialStateShowDesc>
{
	private static readonly MessageParser<FUStB2DSpecialStateShowDesc> _parser = new MessageParser<FUStB2DSpecialStateShowDesc>(() => new FUStB2DSpecialStateShowDesc());

	private UnknownFieldSet _unknownFields;

	private EB2DSpecialState id_;

	private int isShow_;

	private int weights_;

	public static MessageParser<FUStB2DSpecialStateShowDesc> Parser => _parser;

	public EB2DSpecialState Id
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

	public int IsShow
	{
		get
		{
			return isShow_;
		}
		set
		{
			isShow_ = value;
		}
	}

	public int Weights
	{
		get
		{
			return weights_;
		}
		set
		{
			weights_ = value;
		}
	}

	public FUStB2DSpecialStateShowDesc()
	{
	}

	public FUStB2DSpecialStateShowDesc(FUStB2DSpecialStateShowDesc other)
		: this()
	{
		id_ = other.id_;
		isShow_ = other.isShow_;
		weights_ = other.weights_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSpecialStateShowDesc Clone()
	{
		return new FUStB2DSpecialStateShowDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSpecialStateShowDesc);
	}

	public bool Equals(FUStB2DSpecialStateShowDesc other)
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
		if (IsShow != other.IsShow)
		{
			return false;
		}
		if (Weights != other.Weights)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != EB2DSpecialState.Default)
		{
			num ^= Id.GetHashCode();
		}
		if (IsShow != 0)
		{
			num ^= IsShow.GetHashCode();
		}
		if (Weights != 0)
		{
			num ^= Weights.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != EB2DSpecialState.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Id);
		}
		if (IsShow != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IsShow);
		}
		if (Weights != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Weights);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != EB2DSpecialState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Id);
		}
		if (IsShow != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsShow);
		}
		if (Weights != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Weights);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSpecialStateShowDesc other)
	{
		if (other != null)
		{
			if (other.Id != EB2DSpecialState.Default)
			{
				Id = other.Id;
			}
			if (other.IsShow != 0)
			{
				IsShow = other.IsShow;
			}
			if (other.Weights != 0)
			{
				Weights = other.Weights;
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
				Id = (EB2DSpecialState)input.ReadEnum();
				break;
			case 16u:
				IsShow = input.ReadInt32();
				break;
			case 24u:
				Weights = input.ReadInt32();
				break;
			}
		}
	}
}
