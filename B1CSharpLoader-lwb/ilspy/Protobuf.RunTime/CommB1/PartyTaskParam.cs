using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyTaskParam : IMessage<PartyTaskParam>, IMessage, IEquatable<PartyTaskParam>, IDeepCloneable<PartyTaskParam>
{
	private static readonly MessageParser<PartyTaskParam> _parser = new MessageParser<PartyTaskParam>(() => new PartyTaskParam());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	public static MessageParser<PartyTaskParam> Parser => _parser;

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public PartyTaskParam()
	{
	}

	public PartyTaskParam(PartyTaskParam other)
		: this()
	{
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTaskParam Clone()
	{
		return new PartyTaskParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTaskParam);
	}

	public bool Equals(PartyTaskParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyTaskParam other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
				LevelId = input.ReadInt32();
			}
		}
	}
}
