using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_GiveBackControlRightForMonster : IMessage<MovieCustom_GiveBackControlRightForMonster>, IMessage, IEquatable<MovieCustom_GiveBackControlRightForMonster>, IDeepCloneable<MovieCustom_GiveBackControlRightForMonster>
{
	private static readonly MessageParser<MovieCustom_GiveBackControlRightForMonster> _parser = new MessageParser<MovieCustom_GiveBackControlRightForMonster>(() => new MovieCustom_GiveBackControlRightForMonster());

	private UnknownFieldSet _unknownFields;

	private string monsterGuid_ = "";

	public static MessageParser<MovieCustom_GiveBackControlRightForMonster> Parser => _parser;

	public string MonsterGuid
	{
		get
		{
			return monsterGuid_;
		}
		set
		{
			monsterGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieCustom_GiveBackControlRightForMonster()
	{
	}

	public MovieCustom_GiveBackControlRightForMonster(MovieCustom_GiveBackControlRightForMonster other)
		: this()
	{
		monsterGuid_ = other.monsterGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_GiveBackControlRightForMonster Clone()
	{
		return new MovieCustom_GiveBackControlRightForMonster(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_GiveBackControlRightForMonster);
	}

	public bool Equals(MovieCustom_GiveBackControlRightForMonster other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterGuid != other.MonsterGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MonsterGuid.Length != 0)
		{
			num ^= MonsterGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MonsterGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MonsterGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MonsterGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MonsterGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_GiveBackControlRightForMonster other)
	{
		if (other != null)
		{
			if (other.MonsterGuid.Length != 0)
			{
				MonsterGuid = other.MonsterGuid;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MonsterGuid = input.ReadString();
			}
		}
	}
}
