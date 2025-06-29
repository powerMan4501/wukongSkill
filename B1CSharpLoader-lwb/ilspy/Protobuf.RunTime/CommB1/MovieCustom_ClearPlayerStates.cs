using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_ClearPlayerStates : IMessage<MovieCustom_ClearPlayerStates>, IMessage, IEquatable<MovieCustom_ClearPlayerStates>, IDeepCloneable<MovieCustom_ClearPlayerStates>
{
	private static readonly MessageParser<MovieCustom_ClearPlayerStates> _parser = new MessageParser<MovieCustom_ClearPlayerStates>(() => new MovieCustom_ClearPlayerStates());

	private UnknownFieldSet _unknownFields;

	private bool isStopJump_;

	public static MessageParser<MovieCustom_ClearPlayerStates> Parser => _parser;

	public bool IsStopJump
	{
		get
		{
			return isStopJump_;
		}
		set
		{
			isStopJump_ = value;
		}
	}

	public MovieCustom_ClearPlayerStates()
	{
	}

	public MovieCustom_ClearPlayerStates(MovieCustom_ClearPlayerStates other)
		: this()
	{
		isStopJump_ = other.isStopJump_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_ClearPlayerStates Clone()
	{
		return new MovieCustom_ClearPlayerStates(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_ClearPlayerStates);
	}

	public bool Equals(MovieCustom_ClearPlayerStates other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsStopJump != other.IsStopJump)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsStopJump)
		{
			num ^= IsStopJump.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsStopJump)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsStopJump);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsStopJump)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_ClearPlayerStates other)
	{
		if (other != null)
		{
			if (other.IsStopJump)
			{
				IsStopJump = other.IsStopJump;
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
				IsStopJump = input.ReadBool();
			}
		}
	}
}
