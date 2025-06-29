using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_OnNotifyFromActor : IMessage<QuestCustom_OnNotifyFromActor>, IMessage, IEquatable<QuestCustom_OnNotifyFromActor>, IDeepCloneable<QuestCustom_OnNotifyFromActor>
{
	private static readonly MessageParser<QuestCustom_OnNotifyFromActor> _parser = new MessageParser<QuestCustom_OnNotifyFromActor>(() => new QuestCustom_OnNotifyFromActor());

	private UnknownFieldSet _unknownFields;

	private string observeActorGuid_ = "";

	private string observeActorClass_ = "";

	private int successLimit_;

	private static readonly FieldCodec<string> _repeated_notifyTags_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> notifyTags_ = new RepeatedField<string>();

	private bool isRetroactive_;

	public static MessageParser<QuestCustom_OnNotifyFromActor> Parser => _parser;

	public string ObserveActorGuid
	{
		get
		{
			return observeActorGuid_;
		}
		set
		{
			observeActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ObserveActorClass
	{
		get
		{
			return observeActorClass_;
		}
		set
		{
			observeActorClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SuccessLimit
	{
		get
		{
			return successLimit_;
		}
		set
		{
			successLimit_ = value;
		}
	}

	public RepeatedField<string> NotifyTags => notifyTags_;

	public bool IsRetroactive
	{
		get
		{
			return isRetroactive_;
		}
		set
		{
			isRetroactive_ = value;
		}
	}

	public QuestCustom_OnNotifyFromActor()
	{
	}

	public QuestCustom_OnNotifyFromActor(QuestCustom_OnNotifyFromActor other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_;
		observeActorClass_ = other.observeActorClass_;
		successLimit_ = other.successLimit_;
		notifyTags_ = other.notifyTags_.Clone();
		isRetroactive_ = other.isRetroactive_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_OnNotifyFromActor Clone()
	{
		return new QuestCustom_OnNotifyFromActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_OnNotifyFromActor);
	}

	public bool Equals(QuestCustom_OnNotifyFromActor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObserveActorGuid != other.ObserveActorGuid)
		{
			return false;
		}
		if (ObserveActorClass != other.ObserveActorClass)
		{
			return false;
		}
		if (SuccessLimit != other.SuccessLimit)
		{
			return false;
		}
		if (!notifyTags_.Equals(other.notifyTags_))
		{
			return false;
		}
		if (IsRetroactive != other.IsRetroactive)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObserveActorGuid.Length != 0)
		{
			num ^= ObserveActorGuid.GetHashCode();
		}
		if (ObserveActorClass.Length != 0)
		{
			num ^= ObserveActorClass.GetHashCode();
		}
		if (SuccessLimit != 0)
		{
			num ^= SuccessLimit.GetHashCode();
		}
		num ^= notifyTags_.GetHashCode();
		if (IsRetroactive)
		{
			num ^= IsRetroactive.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObserveActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ObserveActorGuid);
		}
		if (ObserveActorClass.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ObserveActorClass);
		}
		if (SuccessLimit != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SuccessLimit);
		}
		notifyTags_.WriteTo(output, _repeated_notifyTags_codec);
		if (IsRetroactive)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsRetroactive);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObserveActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObserveActorGuid);
		}
		if (ObserveActorClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObserveActorClass);
		}
		if (SuccessLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessLimit);
		}
		num += notifyTags_.CalculateSize(_repeated_notifyTags_codec);
		if (IsRetroactive)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_OnNotifyFromActor other)
	{
		if (other != null)
		{
			if (other.ObserveActorGuid.Length != 0)
			{
				ObserveActorGuid = other.ObserveActorGuid;
			}
			if (other.ObserveActorClass.Length != 0)
			{
				ObserveActorClass = other.ObserveActorClass;
			}
			if (other.SuccessLimit != 0)
			{
				SuccessLimit = other.SuccessLimit;
			}
			notifyTags_.Add(other.notifyTags_);
			if (other.IsRetroactive)
			{
				IsRetroactive = other.IsRetroactive;
			}
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
				ObserveActorGuid = input.ReadString();
				break;
			case 18u:
				ObserveActorClass = input.ReadString();
				break;
			case 24u:
				SuccessLimit = input.ReadInt32();
				break;
			case 34u:
				notifyTags_.AddEntriesFrom(input, _repeated_notifyTags_codec);
				break;
			case 40u:
				IsRetroactive = input.ReadBool();
				break;
			}
		}
	}
}
