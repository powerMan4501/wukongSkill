using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAiConversationGroupDesc : IMessage<FUStAiConversationGroupDesc>, IMessage, IEquatable<FUStAiConversationGroupDesc>, IDeepCloneable<FUStAiConversationGroupDesc>
{
	private static readonly MessageParser<FUStAiConversationGroupDesc> _parser = new MessageParser<FUStAiConversationGroupDesc>(() => new FUStAiConversationGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_aiConversationIDList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> aiConversationIDList_ = new RepeatedField<int>();

	public static MessageParser<FUStAiConversationGroupDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public RepeatedField<int> AiConversationIDList => aiConversationIDList_;

	public FUStAiConversationGroupDesc()
	{
	}

	public FUStAiConversationGroupDesc(FUStAiConversationGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		aiConversationIDList_ = other.aiConversationIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAiConversationGroupDesc Clone()
	{
		return new FUStAiConversationGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAiConversationGroupDesc);
	}

	public bool Equals(FUStAiConversationGroupDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!aiConversationIDList_.Equals(other.aiConversationIDList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		num ^= aiConversationIDList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		aiConversationIDList_.WriteTo(output, _repeated_aiConversationIDList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		num += aiConversationIDList_.CalculateSize(_repeated_aiConversationIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAiConversationGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			aiConversationIDList_.Add(other.aiConversationIDList_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				aiConversationIDList_.AddEntriesFrom(input, _repeated_aiConversationIDList_codec);
				break;
			}
		}
	}
}
