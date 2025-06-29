using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleCollection : IMessage<RoleCollection>, IMessage, IEquatable<RoleCollection>, IDeepCloneable<RoleCollection>
{
	private static readonly MessageParser<RoleCollection> _parser = new MessageParser<RoleCollection>(() => new RoleCollection());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MonsterCollection> _repeated_monsterCollectionList_codec = FieldCodec.ForMessage(10u, MonsterCollection.Parser);

	private readonly RepeatedField<MonsterCollection> monsterCollectionList_ = new RepeatedField<MonsterCollection>();

	public static MessageParser<RoleCollection> Parser => _parser;

	public RepeatedField<MonsterCollection> MonsterCollectionList => monsterCollectionList_;

	public RoleCollection()
	{
	}

	public RoleCollection(RoleCollection other)
		: this()
	{
		monsterCollectionList_ = other.monsterCollectionList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleCollection Clone()
	{
		return new RoleCollection(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleCollection);
	}

	public bool Equals(RoleCollection other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!monsterCollectionList_.Equals(other.monsterCollectionList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= monsterCollectionList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		monsterCollectionList_.WriteTo(output, _repeated_monsterCollectionList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += monsterCollectionList_.CalculateSize(_repeated_monsterCollectionList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleCollection other)
	{
		if (other != null)
		{
			monsterCollectionList_.Add(other.monsterCollectionList_);
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
				monsterCollectionList_.AddEntriesFrom(input, _repeated_monsterCollectionList_codec);
			}
		}
	}
}
