using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeEdgeData : IMessage<CalliopeEdgeData>, IMessage, IEquatable<CalliopeEdgeData>, IDeepCloneable<CalliopeEdgeData>
{
	private static readonly MessageParser<CalliopeEdgeData> _parser = new MessageParser<CalliopeEdgeData>(() => new CalliopeEdgeData());

	private UnknownFieldSet _unknownFields;

	private int index_;

	private int fromNode_;

	private string fromPin_ = "";

	private int toNode_;

	private string toPin_ = "";

	public static MessageParser<CalliopeEdgeData> Parser => _parser;

	public int Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	public int FromNode
	{
		get
		{
			return fromNode_;
		}
		set
		{
			fromNode_ = value;
		}
	}

	public string FromPin
	{
		get
		{
			return fromPin_;
		}
		set
		{
			fromPin_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ToNode
	{
		get
		{
			return toNode_;
		}
		set
		{
			toNode_ = value;
		}
	}

	public string ToPin
	{
		get
		{
			return toPin_;
		}
		set
		{
			toPin_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeEdgeData()
	{
	}

	public CalliopeEdgeData(CalliopeEdgeData other)
		: this()
	{
		index_ = other.index_;
		fromNode_ = other.fromNode_;
		fromPin_ = other.fromPin_;
		toNode_ = other.toNode_;
		toPin_ = other.toPin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeEdgeData Clone()
	{
		return new CalliopeEdgeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeEdgeData);
	}

	public bool Equals(CalliopeEdgeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (FromNode != other.FromNode)
		{
			return false;
		}
		if (FromPin != other.FromPin)
		{
			return false;
		}
		if (ToNode != other.ToNode)
		{
			return false;
		}
		if (ToPin != other.ToPin)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (FromNode != 0)
		{
			num ^= FromNode.GetHashCode();
		}
		if (FromPin.Length != 0)
		{
			num ^= FromPin.GetHashCode();
		}
		if (ToNode != 0)
		{
			num ^= ToNode.GetHashCode();
		}
		if (ToPin.Length != 0)
		{
			num ^= ToPin.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Index != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Index);
		}
		if (FromNode != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FromNode);
		}
		if (FromPin.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FromPin);
		}
		if (ToNode != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ToNode);
		}
		if (ToPin.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ToPin);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Index);
		}
		if (FromNode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FromNode);
		}
		if (FromPin.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FromPin);
		}
		if (ToNode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ToNode);
		}
		if (ToPin.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ToPin);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeEdgeData other)
	{
		if (other != null)
		{
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.FromNode != 0)
			{
				FromNode = other.FromNode;
			}
			if (other.FromPin.Length != 0)
			{
				FromPin = other.FromPin;
			}
			if (other.ToNode != 0)
			{
				ToNode = other.ToNode;
			}
			if (other.ToPin.Length != 0)
			{
				ToPin = other.ToPin;
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
				Index = input.ReadInt32();
				break;
			case 16u:
				FromNode = input.ReadInt32();
				break;
			case 26u:
				FromPin = input.ReadString();
				break;
			case 32u:
				ToNode = input.ReadInt32();
				break;
			case 42u:
				ToPin = input.ReadString();
				break;
			}
		}
	}
}
