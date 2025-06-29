using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_AiConversation : IMessage<QuestCustom_AiConversation>, IMessage, IEquatable<QuestCustom_AiConversation>, IDeepCloneable<QuestCustom_AiConversation>
{
	private static readonly MessageParser<QuestCustom_AiConversation> _parser = new MessageParser<QuestCustom_AiConversation>(() => new QuestCustom_AiConversation());

	private UnknownFieldSet _unknownFields;

	private string casterGuid_ = "";

	private static readonly FieldCodec<int> _repeated_contentIds_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> contentIds_ = new RepeatedField<int>();

	private bool usePlayerAsCaster_;

	public static MessageParser<QuestCustom_AiConversation> Parser => _parser;

	public string CasterGuid
	{
		get
		{
			return casterGuid_;
		}
		set
		{
			casterGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> ContentIds => contentIds_;

	public bool UsePlayerAsCaster
	{
		get
		{
			return usePlayerAsCaster_;
		}
		set
		{
			usePlayerAsCaster_ = value;
		}
	}

	public QuestCustom_AiConversation()
	{
	}

	public QuestCustom_AiConversation(QuestCustom_AiConversation other)
		: this()
	{
		casterGuid_ = other.casterGuid_;
		contentIds_ = other.contentIds_.Clone();
		usePlayerAsCaster_ = other.usePlayerAsCaster_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_AiConversation Clone()
	{
		return new QuestCustom_AiConversation(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_AiConversation);
	}

	public bool Equals(QuestCustom_AiConversation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CasterGuid != other.CasterGuid)
		{
			return false;
		}
		if (!contentIds_.Equals(other.contentIds_))
		{
			return false;
		}
		if (UsePlayerAsCaster != other.UsePlayerAsCaster)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CasterGuid.Length != 0)
		{
			num ^= CasterGuid.GetHashCode();
		}
		num ^= contentIds_.GetHashCode();
		if (UsePlayerAsCaster)
		{
			num ^= UsePlayerAsCaster.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CasterGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CasterGuid);
		}
		contentIds_.WriteTo(output, _repeated_contentIds_codec);
		if (UsePlayerAsCaster)
		{
			output.WriteRawTag(24);
			output.WriteBool(UsePlayerAsCaster);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CasterGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CasterGuid);
		}
		num += contentIds_.CalculateSize(_repeated_contentIds_codec);
		if (UsePlayerAsCaster)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_AiConversation other)
	{
		if (other != null)
		{
			if (other.CasterGuid.Length != 0)
			{
				CasterGuid = other.CasterGuid;
			}
			contentIds_.Add(other.contentIds_);
			if (other.UsePlayerAsCaster)
			{
				UsePlayerAsCaster = other.UsePlayerAsCaster;
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
				CasterGuid = input.ReadString();
				break;
			case 16u:
			case 18u:
				contentIds_.AddEntriesFrom(input, _repeated_contentIds_codec);
				break;
			case 24u:
				UsePlayerAsCaster = input.ReadBool();
				break;
			}
		}
	}
}
