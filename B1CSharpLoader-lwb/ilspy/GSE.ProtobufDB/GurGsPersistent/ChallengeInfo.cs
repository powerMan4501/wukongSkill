using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ChallengeInfo : IMessage<ChallengeInfo>, IMessage, IEquatable<ChallengeInfo>, IDeepCloneable<ChallengeInfo>
{
	private static readonly MessageParser<ChallengeInfo> _parser = new MessageParser<ChallengeInfo>(() => new ChallengeInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<ChallengeInfo> Parser => _parser;

	public ChallengeInfo()
	{
	}

	public ChallengeInfo(ChallengeInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChallengeInfo Clone()
	{
		return new ChallengeInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChallengeInfo);
	}

	public bool Equals(ChallengeInfo other)
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

	public void MergeFrom(ChallengeInfo other)
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
