using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class PS5Activity : IMessage<PS5Activity>, IMessage, IEquatable<PS5Activity>, IDeepCloneable<PS5Activity>
{
	private static readonly MessageParser<PS5Activity> _parser = new MessageParser<PS5Activity>(() => new PS5Activity());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<int> _repeated_taskIdList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> taskIdList_ = new RepeatedField<int>();

	public static MessageParser<PS5Activity> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public RepeatedField<int> TaskIdList => taskIdList_;

	public PS5Activity()
	{
	}

	public PS5Activity(PS5Activity other)
		: this()
	{
		id_ = other.id_;
		taskIdList_ = other.taskIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS5Activity Clone()
	{
		return new PS5Activity(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS5Activity);
	}

	public bool Equals(PS5Activity other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!taskIdList_.Equals(other.taskIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= taskIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		taskIdList_.WriteTo(output, _repeated_taskIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += taskIdList_.CalculateSize(_repeated_taskIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS5Activity other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			taskIdList_.Add(other.taskIdList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				taskIdList_.AddEntriesFrom(input, _repeated_taskIdList_codec);
				break;
			}
		}
	}
}
