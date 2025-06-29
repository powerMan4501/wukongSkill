using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStDialogueIDMappingDesc : IMessage<FUStDialogueIDMappingDesc>, IMessage, IEquatable<FUStDialogueIDMappingDesc>, IDeepCloneable<FUStDialogueIDMappingDesc>
{
	private static readonly MessageParser<FUStDialogueIDMappingDesc> _parser = new MessageParser<FUStDialogueIDMappingDesc>(() => new FUStDialogueIDMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int newID_;

	public static MessageParser<FUStDialogueIDMappingDesc> Parser => _parser;

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

	public int NewID
	{
		get
		{
			return newID_;
		}
		set
		{
			newID_ = value;
		}
	}

	public FUStDialogueIDMappingDesc()
	{
	}

	public FUStDialogueIDMappingDesc(FUStDialogueIDMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		newID_ = other.newID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDialogueIDMappingDesc Clone()
	{
		return new FUStDialogueIDMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDialogueIDMappingDesc);
	}

	public bool Equals(FUStDialogueIDMappingDesc other)
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
		if (NewID != other.NewID)
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
		if (NewID != 0)
		{
			num ^= NewID.GetHashCode();
		}
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
		if (NewID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(NewID);
		}
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
		if (NewID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDialogueIDMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.NewID != 0)
			{
				NewID = other.NewID;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				NewID = input.ReadInt32();
				break;
			}
		}
	}
}
