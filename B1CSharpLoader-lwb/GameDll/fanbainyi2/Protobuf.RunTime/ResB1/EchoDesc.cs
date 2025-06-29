using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EchoDesc : IMessage<EchoDesc>, IMessage, IEquatable<EchoDesc>, IDeepCloneable<EchoDesc>
{
	private static readonly MessageParser<EchoDesc> _parser = new MessageParser<EchoDesc>(() => new EchoDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string echoName_ = "";

	private int aiConversationId_;

	private int levelId_;

	private int localizationTag_;

	public static MessageParser<EchoDesc> Parser => _parser;

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

	public string EchoName
	{
		get
		{
			return echoName_;
		}
		set
		{
			echoName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AiConversationId
	{
		get
		{
			return aiConversationId_;
		}
		set
		{
			aiConversationId_ = value;
		}
	}

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public EchoDesc()
	{
	}

	public EchoDesc(EchoDesc other)
		: this()
	{
		id_ = other.id_;
		echoName_ = other.echoName_;
		aiConversationId_ = other.aiConversationId_;
		levelId_ = other.levelId_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EchoDesc Clone()
	{
		return new EchoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EchoDesc);
	}

	public bool Equals(EchoDesc other)
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
		if (EchoName != other.EchoName)
		{
			return false;
		}
		if (AiConversationId != other.AiConversationId)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (EchoName.Length != 0)
		{
			num ^= EchoName.GetHashCode();
		}
		if (AiConversationId != 0)
		{
			num ^= AiConversationId.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
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
		if (EchoName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EchoName);
		}
		if (AiConversationId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AiConversationId);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelId);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LocalizationTag);
		}
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
		if (EchoName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EchoName);
		}
		if (AiConversationId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AiConversationId);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EchoDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.EchoName.Length != 0)
			{
				EchoName = other.EchoName;
			}
			if (other.AiConversationId != 0)
			{
				AiConversationId = other.AiConversationId;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 18u:
				EchoName = input.ReadString();
				break;
			case 24u:
				AiConversationId = input.ReadInt32();
				break;
			case 32u:
				LevelId = input.ReadInt32();
				break;
			case 40u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
