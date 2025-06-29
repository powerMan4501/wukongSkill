using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_SetPlayerRebirthPoint : IMessage<QuestCustom_SetPlayerRebirthPoint>, IMessage, IEquatable<QuestCustom_SetPlayerRebirthPoint>, IDeepCloneable<QuestCustom_SetPlayerRebirthPoint>
{
	private static readonly MessageParser<QuestCustom_SetPlayerRebirthPoint> _parser = new MessageParser<QuestCustom_SetPlayerRebirthPoint>(() => new QuestCustom_SetPlayerRebirthPoint());

	private UnknownFieldSet _unknownFields;

	private int rebirthPointId_;

	public static MessageParser<QuestCustom_SetPlayerRebirthPoint> Parser => _parser;

	public int RebirthPointId
	{
		get
		{
			return rebirthPointId_;
		}
		set
		{
			rebirthPointId_ = value;
		}
	}

	public QuestCustom_SetPlayerRebirthPoint()
	{
	}

	public QuestCustom_SetPlayerRebirthPoint(QuestCustom_SetPlayerRebirthPoint other)
		: this()
	{
		rebirthPointId_ = other.rebirthPointId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SetPlayerRebirthPoint Clone()
	{
		return new QuestCustom_SetPlayerRebirthPoint(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SetPlayerRebirthPoint);
	}

	public bool Equals(QuestCustom_SetPlayerRebirthPoint other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RebirthPointId != other.RebirthPointId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RebirthPointId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SetPlayerRebirthPoint other)
	{
		if (other != null)
		{
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
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
				RebirthPointId = input.ReadInt32();
			}
		}
	}
}
