using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoomList : IMessage<RoomList>, IMessage, IEquatable<RoomList>, IDeepCloneable<RoomList>
{
	private static readonly MessageParser<RoomList> _parser = new MessageParser<RoomList>(() => new RoomList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<RoomData> _repeated_rooms_codec = FieldCodec.ForMessage(10u, RoomData.Parser);

	private readonly RepeatedField<RoomData> rooms_ = new RepeatedField<RoomData>();

	public static MessageParser<RoomList> Parser => _parser;

	public RepeatedField<RoomData> Rooms => rooms_;

	public RoomList()
	{
	}

	public RoomList(RoomList other)
		: this()
	{
		rooms_ = other.rooms_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoomList Clone()
	{
		return new RoomList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoomList);
	}

	public bool Equals(RoomList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!rooms_.Equals(other.rooms_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= rooms_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		rooms_.WriteTo(output, _repeated_rooms_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += rooms_.CalculateSize(_repeated_rooms_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoomList other)
	{
		if (other != null)
		{
			rooms_.Add(other.rooms_);
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
				rooms_.AddEntriesFrom(input, _repeated_rooms_codec);
			}
		}
	}
}
