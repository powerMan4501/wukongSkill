using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DArchivesHeroData : IMessage<FUStB2DArchivesHeroData>, IMessage, IEquatable<FUStB2DArchivesHeroData>, IDeepCloneable<FUStB2DArchivesHeroData>
{
	private static readonly MessageParser<FUStB2DArchivesHeroData> _parser = new MessageParser<FUStB2DArchivesHeroData>(() => new FUStB2DArchivesHeroData());

	private UnknownFieldSet _unknownFields;

	private float posid_;

	private float hp_;

	private float posX_;

	private float posY_;

	public static MessageParser<FUStB2DArchivesHeroData> Parser => _parser;

	public float Posid
	{
		get
		{
			return posid_;
		}
		set
		{
			posid_ = value;
		}
	}

	public float Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	public float PosX
	{
		get
		{
			return posX_;
		}
		set
		{
			posX_ = value;
		}
	}

	public float PosY
	{
		get
		{
			return posY_;
		}
		set
		{
			posY_ = value;
		}
	}

	public FUStB2DArchivesHeroData()
	{
	}

	public FUStB2DArchivesHeroData(FUStB2DArchivesHeroData other)
		: this()
	{
		posid_ = other.posid_;
		hp_ = other.hp_;
		posX_ = other.posX_;
		posY_ = other.posY_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DArchivesHeroData Clone()
	{
		return new FUStB2DArchivesHeroData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DArchivesHeroData);
	}

	public bool Equals(FUStB2DArchivesHeroData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Posid, other.Posid))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Hp, other.Hp))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Posid != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Posid);
		}
		if (Hp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Hp);
		}
		if (PosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
		}
		if (PosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Posid != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(Posid);
		}
		if (Hp != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Hp);
		}
		if (PosX != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PosX);
		}
		if (PosY != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(PosY);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Posid != 0f)
		{
			num += 5;
		}
		if (Hp != 0f)
		{
			num += 5;
		}
		if (PosX != 0f)
		{
			num += 5;
		}
		if (PosY != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DArchivesHeroData other)
	{
		if (other != null)
		{
			if (other.Posid != 0f)
			{
				Posid = other.Posid;
			}
			if (other.Hp != 0f)
			{
				Hp = other.Hp;
			}
			if (other.PosX != 0f)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				PosY = other.PosY;
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
			case 13u:
				Posid = input.ReadFloat();
				break;
			case 21u:
				Hp = input.ReadFloat();
				break;
			case 29u:
				PosX = input.ReadFloat();
				break;
			case 37u:
				PosY = input.ReadFloat();
				break;
			}
		}
	}
}
