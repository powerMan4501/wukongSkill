using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSeqAudioJumpLengthDesc : IMessage<FUStSeqAudioJumpLengthDesc>, IMessage, IEquatable<FUStSeqAudioJumpLengthDesc>, IDeepCloneable<FUStSeqAudioJumpLengthDesc>
{
	private static readonly MessageParser<FUStSeqAudioJumpLengthDesc> _parser = new MessageParser<FUStSeqAudioJumpLengthDesc>(() => new FUStSeqAudioJumpLengthDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string eventName_ = "";

	private int jumpLength_;

	public static MessageParser<FUStSeqAudioJumpLengthDesc> Parser => _parser;

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

	public string EventName
	{
		get
		{
			return eventName_;
		}
		set
		{
			eventName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int JumpLength
	{
		get
		{
			return jumpLength_;
		}
		set
		{
			jumpLength_ = value;
		}
	}

	public FUStSeqAudioJumpLengthDesc()
	{
	}

	public FUStSeqAudioJumpLengthDesc(FUStSeqAudioJumpLengthDesc other)
		: this()
	{
		iD_ = other.iD_;
		eventName_ = other.eventName_;
		jumpLength_ = other.jumpLength_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSeqAudioJumpLengthDesc Clone()
	{
		return new FUStSeqAudioJumpLengthDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSeqAudioJumpLengthDesc);
	}

	public bool Equals(FUStSeqAudioJumpLengthDesc other)
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
		if (EventName != other.EventName)
		{
			return false;
		}
		if (JumpLength != other.JumpLength)
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
		if (EventName.Length != 0)
		{
			num ^= EventName.GetHashCode();
		}
		if (JumpLength != 0)
		{
			num ^= JumpLength.GetHashCode();
		}
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
		if (EventName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EventName);
		}
		if (JumpLength != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(JumpLength);
		}
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
		if (EventName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventName);
		}
		if (JumpLength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JumpLength);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSeqAudioJumpLengthDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.EventName.Length != 0)
			{
				EventName = other.EventName;
			}
			if (other.JumpLength != 0)
			{
				JumpLength = other.JumpLength;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				EventName = input.ReadString();
				break;
			case 24u:
				JumpLength = input.ReadInt32();
				break;
			}
		}
	}
}
