using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEliteBuffConfigDesc : IMessage<FUStEliteBuffConfigDesc>, IMessage, IEquatable<FUStEliteBuffConfigDesc>, IDeepCloneable<FUStEliteBuffConfigDesc>
{
	private static readonly MessageParser<FUStEliteBuffConfigDesc> _parser = new MessageParser<FUStEliteBuffConfigDesc>(() => new FUStEliteBuffConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_buffID_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> buffID_ = new RepeatedField<int>();

	public static MessageParser<FUStEliteBuffConfigDesc> Parser => _parser;

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

	public RepeatedField<int> BuffID => buffID_;

	public FUStEliteBuffConfigDesc()
	{
	}

	public FUStEliteBuffConfigDesc(FUStEliteBuffConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffID_ = other.buffID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEliteBuffConfigDesc Clone()
	{
		return new FUStEliteBuffConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEliteBuffConfigDesc);
	}

	public bool Equals(FUStEliteBuffConfigDesc other)
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
		if (!buffID_.Equals(other.buffID_))
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
		num ^= buffID_.GetHashCode();
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
		buffID_.WriteTo(output, _repeated_buffID_codec);
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
		num += buffID_.CalculateSize(_repeated_buffID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEliteBuffConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			buffID_.Add(other.buffID_);
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
				buffID_.AddEntriesFrom(input, _repeated_buffID_codec);
				break;
			}
		}
	}
}
