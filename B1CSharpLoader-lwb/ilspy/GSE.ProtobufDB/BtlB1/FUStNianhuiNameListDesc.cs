using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStNianhuiNameListDesc : IMessage<FUStNianhuiNameListDesc>, IMessage, IEquatable<FUStNianhuiNameListDesc>, IDeepCloneable<FUStNianhuiNameListDesc>
{
	private static readonly MessageParser<FUStNianhuiNameListDesc> _parser = new MessageParser<FUStNianhuiNameListDesc>(() => new FUStNianhuiNameListDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string nameEn_ = "";

	private string nameCn_ = "";

	private string texture_ = "";

	public static MessageParser<FUStNianhuiNameListDesc> Parser => _parser;

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

	public string NameEn
	{
		get
		{
			return nameEn_;
		}
		set
		{
			nameEn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NameCn
	{
		get
		{
			return nameCn_;
		}
		set
		{
			nameCn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Texture
	{
		get
		{
			return texture_;
		}
		set
		{
			texture_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStNianhuiNameListDesc()
	{
	}

	public FUStNianhuiNameListDesc(FUStNianhuiNameListDesc other)
		: this()
	{
		iD_ = other.iD_;
		nameEn_ = other.nameEn_;
		nameCn_ = other.nameCn_;
		texture_ = other.texture_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStNianhuiNameListDesc Clone()
	{
		return new FUStNianhuiNameListDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStNianhuiNameListDesc);
	}

	public bool Equals(FUStNianhuiNameListDesc other)
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
		if (NameEn != other.NameEn)
		{
			return false;
		}
		if (NameCn != other.NameCn)
		{
			return false;
		}
		if (Texture != other.Texture)
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
		if (NameEn.Length != 0)
		{
			num ^= NameEn.GetHashCode();
		}
		if (NameCn.Length != 0)
		{
			num ^= NameCn.GetHashCode();
		}
		if (Texture.Length != 0)
		{
			num ^= Texture.GetHashCode();
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
		if (NameEn.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NameEn);
		}
		if (NameCn.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NameCn);
		}
		if (Texture.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Texture);
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
		if (NameEn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NameEn);
		}
		if (NameCn.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NameCn);
		}
		if (Texture.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Texture);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStNianhuiNameListDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.NameEn.Length != 0)
			{
				NameEn = other.NameEn;
			}
			if (other.NameCn.Length != 0)
			{
				NameCn = other.NameCn;
			}
			if (other.Texture.Length != 0)
			{
				Texture = other.Texture;
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
				NameEn = input.ReadString();
				break;
			case 26u:
				NameCn = input.ReadString();
				break;
			case 34u:
				Texture = input.ReadString();
				break;
			}
		}
	}
}
