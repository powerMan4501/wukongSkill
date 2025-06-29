using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeNodeCustomDataV1 : IMessage<CalliopeNodeCustomDataV1>, IMessage, IEquatable<CalliopeNodeCustomDataV1>, IDeepCloneable<CalliopeNodeCustomDataV1>
{
	private static readonly MessageParser<CalliopeNodeCustomDataV1> _parser = new MessageParser<CalliopeNodeCustomDataV1>(() => new CalliopeNodeCustomDataV1());

	private UnknownFieldSet _unknownFields;

	private string graphIdentifier_ = "";

	private ByteString customData_ = ByteString.Empty;

	public static MessageParser<CalliopeNodeCustomDataV1> Parser => _parser;

	public string GraphIdentifier
	{
		get
		{
			return graphIdentifier_;
		}
		set
		{
			graphIdentifier_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteString CustomData
	{
		get
		{
			return customData_;
		}
		set
		{
			customData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeNodeCustomDataV1()
	{
	}

	public CalliopeNodeCustomDataV1(CalliopeNodeCustomDataV1 other)
		: this()
	{
		graphIdentifier_ = other.graphIdentifier_;
		customData_ = other.customData_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeNodeCustomDataV1 Clone()
	{
		return new CalliopeNodeCustomDataV1(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeNodeCustomDataV1);
	}

	public bool Equals(CalliopeNodeCustomDataV1 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GraphIdentifier != other.GraphIdentifier)
		{
			return false;
		}
		if (CustomData != other.CustomData)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GraphIdentifier.Length != 0)
		{
			num ^= GraphIdentifier.GetHashCode();
		}
		if (CustomData.Length != 0)
		{
			num ^= CustomData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GraphIdentifier.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(GraphIdentifier);
		}
		if (CustomData.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(CustomData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GraphIdentifier.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GraphIdentifier);
		}
		if (CustomData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(CustomData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeNodeCustomDataV1 other)
	{
		if (other != null)
		{
			if (other.GraphIdentifier.Length != 0)
			{
				GraphIdentifier = other.GraphIdentifier;
			}
			if (other.CustomData.Length != 0)
			{
				CustomData = other.CustomData;
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
			case 10u:
				GraphIdentifier = input.ReadString();
				break;
			case 18u:
				CustomData = input.ReadBytes();
				break;
			}
		}
	}
}
