using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ArchiveSnapshootData : IMessage<ArchiveSnapshootData>, IMessage, IEquatable<ArchiveSnapshootData>, IDeepCloneable<ArchiveSnapshootData>
{
	private static readonly MessageParser<ArchiveSnapshootData> _parser = new MessageParser<ArchiveSnapshootData>(() => new ArchiveSnapshootData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ArchiveSnapshootOne> _repeated_snapshootList_codec = FieldCodec.ForMessage(10u, ArchiveSnapshootOne.Parser);

	private readonly RepeatedField<ArchiveSnapshootOne> snapshootList_ = new RepeatedField<ArchiveSnapshootOne>();

	public static MessageParser<ArchiveSnapshootData> Parser => _parser;

	public RepeatedField<ArchiveSnapshootOne> SnapshootList => snapshootList_;

	public ArchiveSnapshootData()
	{
	}

	public ArchiveSnapshootData(ArchiveSnapshootData other)
		: this()
	{
		snapshootList_ = other.snapshootList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveSnapshootData Clone()
	{
		return new ArchiveSnapshootData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveSnapshootData);
	}

	public bool Equals(ArchiveSnapshootData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!snapshootList_.Equals(other.snapshootList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= snapshootList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		snapshootList_.WriteTo(output, _repeated_snapshootList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += snapshootList_.CalculateSize(_repeated_snapshootList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveSnapshootData other)
	{
		if (other != null)
		{
			snapshootList_.Add(other.snapshootList_);
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
				snapshootList_.AddEntriesFrom(input, _repeated_snapshootList_codec);
			}
		}
	}
}
