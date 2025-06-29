using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPigsyStoryIAndRLibraryDesc : IMessage<FUStPigsyStoryIAndRLibraryDesc>, IMessage, IEquatable<FUStPigsyStoryIAndRLibraryDesc>, IDeepCloneable<FUStPigsyStoryIAndRLibraryDesc>
{
	private static readonly MessageParser<FUStPigsyStoryIAndRLibraryDesc> _parser = new MessageParser<FUStPigsyStoryIAndRLibraryDesc>(() => new FUStPigsyStoryIAndRLibraryDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EPigsyStoryIAndRType iAndRType_;

	private static readonly FieldCodec<int> _repeated_aiConversationIDs_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> aiConversationIDs_ = new RepeatedField<int>();

	public static MessageParser<FUStPigsyStoryIAndRLibraryDesc> Parser => _parser;

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

	public EPigsyStoryIAndRType IAndRType
	{
		get
		{
			return iAndRType_;
		}
		set
		{
			iAndRType_ = value;
		}
	}

	public RepeatedField<int> AiConversationIDs => aiConversationIDs_;

	public FUStPigsyStoryIAndRLibraryDesc()
	{
	}

	public FUStPigsyStoryIAndRLibraryDesc(FUStPigsyStoryIAndRLibraryDesc other)
		: this()
	{
		iD_ = other.iD_;
		iAndRType_ = other.iAndRType_;
		aiConversationIDs_ = other.aiConversationIDs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPigsyStoryIAndRLibraryDesc Clone()
	{
		return new FUStPigsyStoryIAndRLibraryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPigsyStoryIAndRLibraryDesc);
	}

	public bool Equals(FUStPigsyStoryIAndRLibraryDesc other)
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
		if (IAndRType != other.IAndRType)
		{
			return false;
		}
		if (!aiConversationIDs_.Equals(other.aiConversationIDs_))
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
		if (IAndRType != EPigsyStoryIAndRType.None)
		{
			num ^= IAndRType.GetHashCode();
		}
		num ^= aiConversationIDs_.GetHashCode();
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
		if (IAndRType != EPigsyStoryIAndRType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IAndRType);
		}
		aiConversationIDs_.WriteTo(output, _repeated_aiConversationIDs_codec);
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
		if (IAndRType != EPigsyStoryIAndRType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IAndRType);
		}
		num += aiConversationIDs_.CalculateSize(_repeated_aiConversationIDs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPigsyStoryIAndRLibraryDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IAndRType != EPigsyStoryIAndRType.None)
			{
				IAndRType = other.IAndRType;
			}
			aiConversationIDs_.Add(other.aiConversationIDs_);
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
				IAndRType = (EPigsyStoryIAndRType)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				aiConversationIDs_.AddEntriesFrom(input, _repeated_aiConversationIDs_codec);
				break;
			}
		}
	}
}
