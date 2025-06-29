using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStRichTextIconDesc : IMessage<FUStRichTextIconDesc>, IMessage, IEquatable<FUStRichTextIconDesc>, IDeepCloneable<FUStRichTextIconDesc>
{
	private static readonly MessageParser<FUStRichTextIconDesc> _parser = new MessageParser<FUStRichTextIconDesc>(() => new FUStRichTextIconDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string name_ = "";

	private float sizeX_;

	private float sizeY_;

	private string resourceObject_ = "";

	public static MessageParser<FUStRichTextIconDesc> Parser => _parser;

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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float SizeX
	{
		get
		{
			return sizeX_;
		}
		set
		{
			sizeX_ = value;
		}
	}

	public float SizeY
	{
		get
		{
			return sizeY_;
		}
		set
		{
			sizeY_ = value;
		}
	}

	public string ResourceObject
	{
		get
		{
			return resourceObject_;
		}
		set
		{
			resourceObject_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStRichTextIconDesc()
	{
	}

	public FUStRichTextIconDesc(FUStRichTextIconDesc other)
		: this()
	{
		iD_ = other.iD_;
		name_ = other.name_;
		sizeX_ = other.sizeX_;
		sizeY_ = other.sizeY_;
		resourceObject_ = other.resourceObject_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRichTextIconDesc Clone()
	{
		return new FUStRichTextIconDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRichTextIconDesc);
	}

	public bool Equals(FUStRichTextIconDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SizeX, other.SizeX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SizeY, other.SizeY))
		{
			return false;
		}
		if (ResourceObject != other.ResourceObject)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (SizeX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SizeX);
		}
		if (SizeY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SizeY);
		}
		if (ResourceObject.Length != 0)
		{
			num ^= ResourceObject.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (SizeX != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(SizeX);
		}
		if (SizeY != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(SizeY);
		}
		if (ResourceObject.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ResourceObject);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (SizeX != 0f)
		{
			num += 5;
		}
		if (SizeY != 0f)
		{
			num += 5;
		}
		if (ResourceObject.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResourceObject);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRichTextIconDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.SizeX != 0f)
			{
				SizeX = other.SizeX;
			}
			if (other.SizeY != 0f)
			{
				SizeY = other.SizeY;
			}
			if (other.ResourceObject.Length != 0)
			{
				ResourceObject = other.ResourceObject;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 29u:
				SizeX = input.ReadFloat();
				break;
			case 37u:
				SizeY = input.ReadFloat();
				break;
			case 42u:
				ResourceObject = input.ReadString();
				break;
			}
		}
	}
}
