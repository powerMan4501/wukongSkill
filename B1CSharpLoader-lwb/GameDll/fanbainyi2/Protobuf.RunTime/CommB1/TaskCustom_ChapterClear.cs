using System;
using Google.Protobuf;

namespace CommB1;

public sealed class TaskCustom_ChapterClear : IMessage<TaskCustom_ChapterClear>, IMessage, IEquatable<TaskCustom_ChapterClear>, IDeepCloneable<TaskCustom_ChapterClear>
{
	private static readonly MessageParser<TaskCustom_ChapterClear> _parser = new MessageParser<TaskCustom_ChapterClear>(() => new TaskCustom_ChapterClear());

	private UnknownFieldSet _unknownFields;

	private int chapterId_;

	public static MessageParser<TaskCustom_ChapterClear> Parser => _parser;

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public TaskCustom_ChapterClear()
	{
	}

	public TaskCustom_ChapterClear(TaskCustom_ChapterClear other)
		: this()
	{
		chapterId_ = other.chapterId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskCustom_ChapterClear Clone()
	{
		return new TaskCustom_ChapterClear(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskCustom_ChapterClear);
	}

	public bool Equals(TaskCustom_ChapterClear other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ChapterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChapterId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskCustom_ChapterClear other)
	{
		if (other != null)
		{
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
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
				ChapterId = input.ReadInt32();
			}
		}
	}
}
