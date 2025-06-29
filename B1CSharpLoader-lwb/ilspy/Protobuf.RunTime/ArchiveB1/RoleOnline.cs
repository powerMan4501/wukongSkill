using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleOnline : IMessage<RoleOnline>, IMessage, IEquatable<RoleOnline>, IDeepCloneable<RoleOnline>
{
	private static readonly MessageParser<RoleOnline> _parser = new MessageParser<RoleOnline>(() => new RoleOnline());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_mapFragmentList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> mapFragmentList_ = new RepeatedField<int>();

	public static MessageParser<RoleOnline> Parser => _parser;

	public RepeatedField<int> MapFragmentList => mapFragmentList_;

	public RoleOnline()
	{
	}

	public RoleOnline(RoleOnline other)
		: this()
	{
		mapFragmentList_ = other.mapFragmentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleOnline Clone()
	{
		return new RoleOnline(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleOnline);
	}

	public bool Equals(RoleOnline other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mapFragmentList_.Equals(other.mapFragmentList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= mapFragmentList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		mapFragmentList_.WriteTo(output, _repeated_mapFragmentList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += mapFragmentList_.CalculateSize(_repeated_mapFragmentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleOnline other)
	{
		if (other != null)
		{
			mapFragmentList_.Add(other.mapFragmentList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				mapFragmentList_.AddEntriesFrom(input, _repeated_mapFragmentList_codec);
			}
		}
	}
}
