using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_NotifyActor : IMessage<QuestCustom_NotifyActor>, IMessage, IEquatable<QuestCustom_NotifyActor>, IDeepCloneable<QuestCustom_NotifyActor>
{
	private static readonly MessageParser<QuestCustom_NotifyActor> _parser = new MessageParser<QuestCustom_NotifyActor>(() => new QuestCustom_NotifyActor());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private static readonly FieldCodec<string> _repeated_notifyTagStrings_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> notifyTagStrings_ = new RepeatedField<string>();

	public static MessageParser<QuestCustom_NotifyActor> Parser => _parser;

	public string NotifyActorGuid
	{
		get
		{
			return notifyActorGuid_;
		}
		set
		{
			notifyActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> NotifyTagStrings => notifyTagStrings_;

	public QuestCustom_NotifyActor()
	{
	}

	public QuestCustom_NotifyActor(QuestCustom_NotifyActor other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		notifyTagStrings_ = other.notifyTagStrings_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_NotifyActor Clone()
	{
		return new QuestCustom_NotifyActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_NotifyActor);
	}

	public bool Equals(QuestCustom_NotifyActor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NotifyActorGuid != other.NotifyActorGuid)
		{
			return false;
		}
		if (!notifyTagStrings_.Equals(other.notifyTagStrings_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NotifyActorGuid.Length != 0)
		{
			num ^= NotifyActorGuid.GetHashCode();
		}
		num ^= notifyTagStrings_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NotifyActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(NotifyActorGuid);
		}
		notifyTagStrings_.WriteTo(output, _repeated_notifyTagStrings_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NotifyActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyActorGuid);
		}
		num += notifyTagStrings_.CalculateSize(_repeated_notifyTagStrings_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_NotifyActor other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			notifyTagStrings_.Add(other.notifyTagStrings_);
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
			case 10u:
				NotifyActorGuid = input.ReadString();
				break;
			case 18u:
				notifyTagStrings_.AddEntriesFrom(input, _repeated_notifyTagStrings_codec);
				break;
			}
		}
	}
}
