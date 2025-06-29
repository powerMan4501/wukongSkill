using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PostAkEvent : IMessage<QuestCustom_PostAkEvent>, IMessage, IEquatable<QuestCustom_PostAkEvent>, IDeepCloneable<QuestCustom_PostAkEvent>
{
	private static readonly MessageParser<QuestCustom_PostAkEvent> _parser = new MessageParser<QuestCustom_PostAkEvent>(() => new QuestCustom_PostAkEvent());

	private UnknownFieldSet _unknownFields;

	private string akEventPath_ = "";

	public static MessageParser<QuestCustom_PostAkEvent> Parser => _parser;

	public string AkEventPath
	{
		get
		{
			return akEventPath_;
		}
		set
		{
			akEventPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_PostAkEvent()
	{
	}

	public QuestCustom_PostAkEvent(QuestCustom_PostAkEvent other)
		: this()
	{
		akEventPath_ = other.akEventPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PostAkEvent Clone()
	{
		return new QuestCustom_PostAkEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PostAkEvent);
	}

	public bool Equals(QuestCustom_PostAkEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AkEventPath != other.AkEventPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AkEventPath.Length != 0)
		{
			num ^= AkEventPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AkEventPath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AkEventPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AkEventPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AkEventPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PostAkEvent other)
	{
		if (other != null)
		{
			if (other.AkEventPath.Length != 0)
			{
				AkEventPath = other.AkEventPath;
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
				AkEventPath = input.ReadString();
			}
		}
	}
}
