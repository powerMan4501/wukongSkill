using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBuffDispGroupDesc : IMessage<FUStBuffDispGroupDesc>, IMessage, IEquatable<FUStBuffDispGroupDesc>, IDeepCloneable<FUStBuffDispGroupDesc>
{
	private static readonly MessageParser<FUStBuffDispGroupDesc> _parser = new MessageParser<FUStBuffDispGroupDesc>(() => new FUStBuffDispGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int singleBuffDisp_;

	private int groupBuffDisp_;

	private static readonly FieldCodec<int> _repeated_buffList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> buffList_ = new RepeatedField<int>();

	public static MessageParser<FUStBuffDispGroupDesc> Parser => _parser;

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

	public int SingleBuffDisp
	{
		get
		{
			return singleBuffDisp_;
		}
		set
		{
			singleBuffDisp_ = value;
		}
	}

	public int GroupBuffDisp
	{
		get
		{
			return groupBuffDisp_;
		}
		set
		{
			groupBuffDisp_ = value;
		}
	}

	public RepeatedField<int> BuffList => buffList_;

	public FUStBuffDispGroupDesc()
	{
	}

	public FUStBuffDispGroupDesc(FUStBuffDispGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		singleBuffDisp_ = other.singleBuffDisp_;
		groupBuffDisp_ = other.groupBuffDisp_;
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffDispGroupDesc Clone()
	{
		return new FUStBuffDispGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffDispGroupDesc);
	}

	public bool Equals(FUStBuffDispGroupDesc other)
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
		if (SingleBuffDisp != other.SingleBuffDisp)
		{
			return false;
		}
		if (GroupBuffDisp != other.GroupBuffDisp)
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
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
		if (SingleBuffDisp != 0)
		{
			num ^= SingleBuffDisp.GetHashCode();
		}
		if (GroupBuffDisp != 0)
		{
			num ^= GroupBuffDisp.GetHashCode();
		}
		num ^= buffList_.GetHashCode();
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
		if (SingleBuffDisp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SingleBuffDisp);
		}
		if (GroupBuffDisp != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupBuffDisp);
		}
		buffList_.WriteTo(output, _repeated_buffList_codec);
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
		if (SingleBuffDisp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SingleBuffDisp);
		}
		if (GroupBuffDisp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupBuffDisp);
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffDispGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SingleBuffDisp != 0)
			{
				SingleBuffDisp = other.SingleBuffDisp;
			}
			if (other.GroupBuffDisp != 0)
			{
				GroupBuffDisp = other.GroupBuffDisp;
			}
			buffList_.Add(other.buffList_);
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
				SingleBuffDisp = input.ReadInt32();
				break;
			case 24u:
				GroupBuffDisp = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
				break;
			}
		}
	}
}
