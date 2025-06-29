using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPigsyStoryLibraryDesc : IMessage<FUStPigsyStoryLibraryDesc>, IMessage, IEquatable<FUStPigsyStoryLibraryDesc>, IDeepCloneable<FUStPigsyStoryLibraryDesc>
{
	private static readonly MessageParser<FUStPigsyStoryLibraryDesc> _parser = new MessageParser<FUStPigsyStoryLibraryDesc>(() => new FUStPigsyStoryLibraryDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int levelID_;

	private int specificAreaID_;

	private static readonly FieldCodec<int> _repeated_startAiConversationIDs_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> startAiConversationIDs_ = new RepeatedField<int>();

	public static MessageParser<FUStPigsyStoryLibraryDesc> Parser => _parser;

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

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public int SpecificAreaID
	{
		get
		{
			return specificAreaID_;
		}
		set
		{
			specificAreaID_ = value;
		}
	}

	public RepeatedField<int> StartAiConversationIDs => startAiConversationIDs_;

	public FUStPigsyStoryLibraryDesc()
	{
	}

	public FUStPigsyStoryLibraryDesc(FUStPigsyStoryLibraryDesc other)
		: this()
	{
		iD_ = other.iD_;
		levelID_ = other.levelID_;
		specificAreaID_ = other.specificAreaID_;
		startAiConversationIDs_ = other.startAiConversationIDs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPigsyStoryLibraryDesc Clone()
	{
		return new FUStPigsyStoryLibraryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPigsyStoryLibraryDesc);
	}

	public bool Equals(FUStPigsyStoryLibraryDesc other)
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
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (SpecificAreaID != other.SpecificAreaID)
		{
			return false;
		}
		if (!startAiConversationIDs_.Equals(other.startAiConversationIDs_))
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
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (SpecificAreaID != 0)
		{
			num ^= SpecificAreaID.GetHashCode();
		}
		num ^= startAiConversationIDs_.GetHashCode();
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
		if (LevelID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelID);
		}
		if (SpecificAreaID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SpecificAreaID);
		}
		startAiConversationIDs_.WriteTo(output, _repeated_startAiConversationIDs_codec);
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
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (SpecificAreaID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpecificAreaID);
		}
		num += startAiConversationIDs_.CalculateSize(_repeated_startAiConversationIDs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPigsyStoryLibraryDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.SpecificAreaID != 0)
			{
				SpecificAreaID = other.SpecificAreaID;
			}
			startAiConversationIDs_.Add(other.startAiConversationIDs_);
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
				LevelID = input.ReadInt32();
				break;
			case 24u:
				SpecificAreaID = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				startAiConversationIDs_.AddEntriesFrom(input, _repeated_startAiConversationIDs_codec);
				break;
			}
		}
	}
}
