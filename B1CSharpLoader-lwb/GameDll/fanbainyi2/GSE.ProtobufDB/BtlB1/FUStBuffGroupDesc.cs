using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBuffGroupDesc : IMessage<FUStBuffGroupDesc>, IMessage, IEquatable<FUStBuffGroupDesc>, IDeepCloneable<FUStBuffGroupDesc>
{
	private static readonly MessageParser<FUStBuffGroupDesc> _parser = new MessageParser<FUStBuffGroupDesc>(() => new FUStBuffGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	public static MessageParser<FUStBuffGroupDesc> Parser => _parser;

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

	public RepeatedField<int> BuffIDList => buffIDList_;

	public FUStBuffGroupDesc()
	{
	}

	public FUStBuffGroupDesc(FUStBuffGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffIDList_ = other.buffIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffGroupDesc Clone()
	{
		return new FUStBuffGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffGroupDesc);
	}

	public bool Equals(FUStBuffGroupDesc other)
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
		if (!buffIDList_.Equals(other.buffIDList_))
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
		num ^= buffIDList_.GetHashCode();
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
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
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
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			buffIDList_.Add(other.buffIDList_);
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
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			}
		}
	}
}
