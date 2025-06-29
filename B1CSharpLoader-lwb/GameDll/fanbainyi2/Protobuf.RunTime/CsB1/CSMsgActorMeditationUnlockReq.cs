using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorMeditationUnlockReq : IMessage<CSMsgActorMeditationUnlockReq>, IMessage, IEquatable<CSMsgActorMeditationUnlockReq>, IDeepCloneable<CSMsgActorMeditationUnlockReq>
{
	private static readonly MessageParser<CSMsgActorMeditationUnlockReq> _parser = new MessageParser<CSMsgActorMeditationUnlockReq>(() => new CSMsgActorMeditationUnlockReq());

	private UnknownFieldSet _unknownFields;

	private int meditationPointId_;

	public static MessageParser<CSMsgActorMeditationUnlockReq> Parser => _parser;

	public int MeditationPointId
	{
		get
		{
			return meditationPointId_;
		}
		set
		{
			meditationPointId_ = value;
		}
	}

	public CSMsgActorMeditationUnlockReq()
	{
	}

	public CSMsgActorMeditationUnlockReq(CSMsgActorMeditationUnlockReq other)
		: this()
	{
		meditationPointId_ = other.meditationPointId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorMeditationUnlockReq Clone()
	{
		return new CSMsgActorMeditationUnlockReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorMeditationUnlockReq);
	}

	public bool Equals(CSMsgActorMeditationUnlockReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MeditationPointId != other.MeditationPointId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MeditationPointId != 0)
		{
			num ^= MeditationPointId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MeditationPointId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MeditationPointId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MeditationPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MeditationPointId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorMeditationUnlockReq other)
	{
		if (other != null)
		{
			if (other.MeditationPointId != 0)
			{
				MeditationPointId = other.MeditationPointId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MeditationPointId = input.ReadInt32();
			}
		}
	}
}
