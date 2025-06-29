using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EAudioOutputTypeTupleWrapper : IMessage<EAudioOutputTypeTupleWrapper>, IMessage, IEquatable<EAudioOutputTypeTupleWrapper>, IDeepCloneable<EAudioOutputTypeTupleWrapper>
{
	private static readonly MessageParser<EAudioOutputTypeTupleWrapper> _parser = new MessageParser<EAudioOutputTypeTupleWrapper>(() => new EAudioOutputTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAudioOutputType item1_;

	private EAudioOutputType item2_;

	public static MessageParser<EAudioOutputTypeTupleWrapper> Parser => _parser;

	public EAudioOutputType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public EAudioOutputType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public EAudioOutputTypeTupleWrapper()
	{
	}

	public EAudioOutputTypeTupleWrapper(EAudioOutputTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAudioOutputTypeTupleWrapper Clone()
	{
		return new EAudioOutputTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAudioOutputTypeTupleWrapper);
	}

	public bool Equals(EAudioOutputTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != EAudioOutputType.Earphone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAudioOutputType.Earphone)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != EAudioOutputType.Earphone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAudioOutputType.Earphone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != EAudioOutputType.Earphone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAudioOutputType.Earphone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAudioOutputTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAudioOutputType.Earphone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAudioOutputType.Earphone)
			{
				Item2 = other.Item2;
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
				Item1 = (EAudioOutputType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAudioOutputType)input.ReadEnum();
				break;
			}
		}
	}
}
