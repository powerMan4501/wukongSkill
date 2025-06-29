using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class AlchemyNpcCommunicationStatus : IMessage<AlchemyNpcCommunicationStatus>, IMessage, IEquatable<AlchemyNpcCommunicationStatus>, IDeepCloneable<AlchemyNpcCommunicationStatus>
{
	private static readonly MessageParser<AlchemyNpcCommunicationStatus> _parser = new MessageParser<AlchemyNpcCommunicationStatus>(() => new AlchemyNpcCommunicationStatus());

	private UnknownFieldSet _unknownFields;

	private float lastCommunicationTime_;

	private bool canGetAward_;

	public static MessageParser<AlchemyNpcCommunicationStatus> Parser => _parser;

	public float LastCommunicationTime
	{
		get
		{
			return lastCommunicationTime_;
		}
		set
		{
			lastCommunicationTime_ = value;
		}
	}

	public bool CanGetAward
	{
		get
		{
			return canGetAward_;
		}
		set
		{
			canGetAward_ = value;
		}
	}

	public AlchemyNpcCommunicationStatus()
	{
	}

	public AlchemyNpcCommunicationStatus(AlchemyNpcCommunicationStatus other)
		: this()
	{
		lastCommunicationTime_ = other.lastCommunicationTime_;
		canGetAward_ = other.canGetAward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AlchemyNpcCommunicationStatus Clone()
	{
		return new AlchemyNpcCommunicationStatus(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AlchemyNpcCommunicationStatus);
	}

	public bool Equals(AlchemyNpcCommunicationStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastCommunicationTime, other.LastCommunicationTime))
		{
			return false;
		}
		if (CanGetAward != other.CanGetAward)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LastCommunicationTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastCommunicationTime);
		}
		if (CanGetAward)
		{
			num ^= CanGetAward.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LastCommunicationTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(LastCommunicationTime);
		}
		if (CanGetAward)
		{
			output.WriteRawTag(16);
			output.WriteBool(CanGetAward);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LastCommunicationTime != 0f)
		{
			num += 5;
		}
		if (CanGetAward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AlchemyNpcCommunicationStatus other)
	{
		if (other != null)
		{
			if (other.LastCommunicationTime != 0f)
			{
				LastCommunicationTime = other.LastCommunicationTime;
			}
			if (other.CanGetAward)
			{
				CanGetAward = other.CanGetAward;
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
			case 13u:
				LastCommunicationTime = input.ReadFloat();
				break;
			case 16u:
				CanGetAward = input.ReadBool();
				break;
			}
		}
	}
}
