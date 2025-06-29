using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessStateCustom_NotifyActor : IMessage<ProcessStateCustom_NotifyActor>, IMessage, IEquatable<ProcessStateCustom_NotifyActor>, IDeepCloneable<ProcessStateCustom_NotifyActor>
{
	private static readonly MessageParser<ProcessStateCustom_NotifyActor> _parser = new MessageParser<ProcessStateCustom_NotifyActor>(() => new ProcessStateCustom_NotifyActor());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private static readonly FieldCodec<string> _repeated_notifyTagStrings_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> notifyTagStrings_ = new RepeatedField<string>();

	public static MessageParser<ProcessStateCustom_NotifyActor> Parser => _parser;

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

	public ProcessStateCustom_NotifyActor()
	{
	}

	public ProcessStateCustom_NotifyActor(ProcessStateCustom_NotifyActor other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		notifyTagStrings_ = other.notifyTagStrings_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_NotifyActor Clone()
	{
		return new ProcessStateCustom_NotifyActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_NotifyActor);
	}

	public bool Equals(ProcessStateCustom_NotifyActor other)
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

	public void MergeFrom(ProcessStateCustom_NotifyActor other)
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
