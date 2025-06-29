using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAbnormalStateUIBlackListDesc : IMessage<FUStAbnormalStateUIBlackListDesc>, IMessage, IEquatable<FUStAbnormalStateUIBlackListDesc>, IDeepCloneable<FUStAbnormalStateUIBlackListDesc>
{
	private static readonly MessageParser<FUStAbnormalStateUIBlackListDesc> _parser = new MessageParser<FUStAbnormalStateUIBlackListDesc>(() => new FUStAbnormalStateUIBlackListDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_abnormalStateTypes_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> abnormalStateTypes_ = new RepeatedField<int>();

	public static MessageParser<FUStAbnormalStateUIBlackListDesc> Parser => _parser;

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

	public RepeatedField<int> AbnormalStateTypes => abnormalStateTypes_;

	public FUStAbnormalStateUIBlackListDesc()
	{
	}

	public FUStAbnormalStateUIBlackListDesc(FUStAbnormalStateUIBlackListDesc other)
		: this()
	{
		iD_ = other.iD_;
		abnormalStateTypes_ = other.abnormalStateTypes_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAbnormalStateUIBlackListDesc Clone()
	{
		return new FUStAbnormalStateUIBlackListDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAbnormalStateUIBlackListDesc);
	}

	public bool Equals(FUStAbnormalStateUIBlackListDesc other)
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
		if (!abnormalStateTypes_.Equals(other.abnormalStateTypes_))
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
		num ^= abnormalStateTypes_.GetHashCode();
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
		abnormalStateTypes_.WriteTo(output, _repeated_abnormalStateTypes_codec);
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
		num += abnormalStateTypes_.CalculateSize(_repeated_abnormalStateTypes_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAbnormalStateUIBlackListDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			abnormalStateTypes_.Add(other.abnormalStateTypes_);
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
				abnormalStateTypes_.AddEntriesFrom(input, _repeated_abnormalStateTypes_codec);
				break;
			}
		}
	}
}
