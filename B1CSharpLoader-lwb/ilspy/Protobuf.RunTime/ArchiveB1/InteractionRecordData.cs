using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class InteractionRecordData : IMessage<InteractionRecordData>, IMessage, IEquatable<InteractionRecordData>, IDeepCloneable<InteractionRecordData>
{
	private static readonly MessageParser<InteractionRecordData> _parser = new MessageParser<InteractionRecordData>(() => new InteractionRecordData());

	private UnknownFieldSet _unknownFields;

	private int interactGroupId_;

	private int interactStep_;

	public static MessageParser<InteractionRecordData> Parser => _parser;

	public int InteractGroupId
	{
		get
		{
			return interactGroupId_;
		}
		set
		{
			interactGroupId_ = value;
		}
	}

	public int InteractStep
	{
		get
		{
			return interactStep_;
		}
		set
		{
			interactStep_ = value;
		}
	}

	public InteractionRecordData()
	{
	}

	public InteractionRecordData(InteractionRecordData other)
		: this()
	{
		interactGroupId_ = other.interactGroupId_;
		interactStep_ = other.interactStep_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InteractionRecordData Clone()
	{
		return new InteractionRecordData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InteractionRecordData);
	}

	public bool Equals(InteractionRecordData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractGroupId != other.InteractGroupId)
		{
			return false;
		}
		if (InteractStep != other.InteractStep)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (InteractGroupId != 0)
		{
			num ^= InteractGroupId.GetHashCode();
		}
		if (InteractStep != 0)
		{
			num ^= InteractStep.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (InteractGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(InteractGroupId);
		}
		if (InteractStep != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(InteractStep);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (InteractGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractGroupId);
		}
		if (InteractStep != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractStep);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InteractionRecordData other)
	{
		if (other != null)
		{
			if (other.InteractGroupId != 0)
			{
				InteractGroupId = other.InteractGroupId;
			}
			if (other.InteractStep != 0)
			{
				InteractStep = other.InteractStep;
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
				InteractGroupId = input.ReadInt32();
				break;
			case 16u:
				InteractStep = input.ReadInt32();
				break;
			}
		}
	}
}
