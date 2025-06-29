using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class AKMarkerInfo : IMessage<AKMarkerInfo>, IMessage, IEquatable<AKMarkerInfo>, IDeepCloneable<AKMarkerInfo>
{
	private static readonly MessageParser<AKMarkerInfo> _parser = new MessageParser<AKMarkerInfo>(() => new AKMarkerInfo());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	private float timeStamp_;

	public static MessageParser<AKMarkerInfo> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float TimeStamp
	{
		get
		{
			return timeStamp_;
		}
		set
		{
			timeStamp_ = value;
		}
	}

	public AKMarkerInfo()
	{
	}

	public AKMarkerInfo(AKMarkerInfo other)
		: this()
	{
		name_ = other.name_;
		timeStamp_ = other.timeStamp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AKMarkerInfo Clone()
	{
		return new AKMarkerInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AKMarkerInfo);
	}

	public bool Equals(AKMarkerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TimeStamp, other.TimeStamp))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (TimeStamp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TimeStamp);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (TimeStamp != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(TimeStamp);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (TimeStamp != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AKMarkerInfo other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.TimeStamp != 0f)
			{
				TimeStamp = other.TimeStamp;
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
				Name = input.ReadString();
				break;
			case 21u:
				TimeStamp = input.ReadFloat();
				break;
			}
		}
	}
}
