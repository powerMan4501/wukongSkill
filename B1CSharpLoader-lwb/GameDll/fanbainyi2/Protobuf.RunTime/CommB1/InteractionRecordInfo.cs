using System;
using Google.Protobuf;

namespace CommB1;

public sealed class InteractionRecordInfo : IMessage<InteractionRecordInfo>, IMessage, IEquatable<InteractionRecordInfo>, IDeepCloneable<InteractionRecordInfo>
{
	private static readonly MessageParser<InteractionRecordInfo> _parser = new MessageParser<InteractionRecordInfo>(() => new InteractionRecordInfo());

	private UnknownFieldSet _unknownFields;

	private int interactionGroupId_;

	private int interactionStep_;

	public static MessageParser<InteractionRecordInfo> Parser => _parser;

	public int InteractionGroupId
	{
		get
		{
			return interactionGroupId_;
		}
		set
		{
			interactionGroupId_ = value;
		}
	}

	public int InteractionStep
	{
		get
		{
			return interactionStep_;
		}
		set
		{
			interactionStep_ = value;
		}
	}

	public InteractionRecordInfo()
	{
	}

	public InteractionRecordInfo(InteractionRecordInfo other)
		: this()
	{
		interactionGroupId_ = other.interactionGroupId_;
		interactionStep_ = other.interactionStep_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InteractionRecordInfo Clone()
	{
		return new InteractionRecordInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InteractionRecordInfo);
	}

	public bool Equals(InteractionRecordInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractionGroupId != other.InteractionGroupId)
		{
			return false;
		}
		if (InteractionStep != other.InteractionStep)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (InteractionGroupId != 0)
		{
			num ^= InteractionGroupId.GetHashCode();
		}
		if (InteractionStep != 0)
		{
			num ^= InteractionStep.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (InteractionGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(InteractionGroupId);
		}
		if (InteractionStep != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteractionStep);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (InteractionGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractionGroupId);
		}
		if (InteractionStep != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractionStep);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InteractionRecordInfo other)
	{
		if (other != null)
		{
			if (other.InteractionGroupId != 0)
			{
				InteractionGroupId = other.InteractionGroupId;
			}
			if (other.InteractionStep != 0)
			{
				InteractionStep = other.InteractionStep;
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
				InteractionGroupId = input.ReadInt32();
				break;
			case 16u:
				InteractionStep = input.ReadInt32();
				break;
			}
		}
	}
}
