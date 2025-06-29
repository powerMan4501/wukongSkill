using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DArchivesMonsterData : IMessage<FUStB2DArchivesMonsterData>, IMessage, IEquatable<FUStB2DArchivesMonsterData>, IDeepCloneable<FUStB2DArchivesMonsterData>
{
	private static readonly MessageParser<FUStB2DArchivesMonsterData> _parser = new MessageParser<FUStB2DArchivesMonsterData>(() => new FUStB2DArchivesMonsterData());

	private UnknownFieldSet _unknownFields;

	private float monsterid_;

	private float hp_;

	public static MessageParser<FUStB2DArchivesMonsterData> Parser => _parser;

	public float Monsterid
	{
		get
		{
			return monsterid_;
		}
		set
		{
			monsterid_ = value;
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

	public FUStB2DArchivesMonsterData()
	{
	}

	public FUStB2DArchivesMonsterData(FUStB2DArchivesMonsterData other)
		: this()
	{
		monsterid_ = other.monsterid_;
		hp_ = other.hp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DArchivesMonsterData Clone()
	{
		return new FUStB2DArchivesMonsterData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DArchivesMonsterData);
	}

	public bool Equals(FUStB2DArchivesMonsterData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Monsterid, other.Monsterid))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Hp, other.Hp))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Monsterid != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Monsterid);
		}
		if (Hp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Hp);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Monsterid != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(Monsterid);
		}
		if (Hp != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Hp);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Monsterid != 0f)
		{
			num += 5;
		}
		if (Hp != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DArchivesMonsterData other)
	{
		if (other != null)
		{
			if (other.Monsterid != 0f)
			{
				Monsterid = other.Monsterid;
			}
			if (other.Hp != 0f)
			{
				Hp = other.Hp;
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
				Monsterid = input.ReadFloat();
				break;
			case 21u:
				Hp = input.ReadFloat();
				break;
			}
		}
	}
}
