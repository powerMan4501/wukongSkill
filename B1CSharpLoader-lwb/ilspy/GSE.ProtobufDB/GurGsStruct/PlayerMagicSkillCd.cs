using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class PlayerMagicSkillCd : IMessage<PlayerMagicSkillCd>, IMessage, IEquatable<PlayerMagicSkillCd>, IDeepCloneable<PlayerMagicSkillCd>
{
	private static readonly MessageParser<PlayerMagicSkillCd> _parser = new MessageParser<PlayerMagicSkillCd>(() => new PlayerMagicSkillCd());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerMagicSkillCd> Parser => _parser;

	public PlayerMagicSkillCd()
	{
	}

	public PlayerMagicSkillCd(PlayerMagicSkillCd other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerMagicSkillCd Clone()
	{
		return new PlayerMagicSkillCd(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerMagicSkillCd);
	}

	public bool Equals(PlayerMagicSkillCd other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerMagicSkillCd other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
