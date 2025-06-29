using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DSkillMapDesc : IMessage<FUStB2DSkillMapDesc>, IMessage, IEquatable<FUStB2DSkillMapDesc>, IDeepCloneable<FUStB2DSkillMapDesc>
{
	private static readonly MessageParser<FUStB2DSkillMapDesc> _parser = new MessageParser<FUStB2DSkillMapDesc>(() => new FUStB2DSkillMapDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<FUStB2DSBMapCond> _repeated_mapCond_codec = FieldCodec.ForMessage(18u, FUStB2DSBMapCond.Parser);

	private readonly RepeatedField<FUStB2DSBMapCond> mapCond_ = new RepeatedField<FUStB2DSBMapCond>();

	public static MessageParser<FUStB2DSkillMapDesc> Parser => _parser;

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

	public RepeatedField<FUStB2DSBMapCond> MapCond => mapCond_;

	public FUStB2DSkillMapDesc()
	{
	}

	public FUStB2DSkillMapDesc(FUStB2DSkillMapDesc other)
		: this()
	{
		id_ = other.id_;
		mapCond_ = other.mapCond_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillMapDesc Clone()
	{
		return new FUStB2DSkillMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillMapDesc);
	}

	public bool Equals(FUStB2DSkillMapDesc other)
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
		if (!mapCond_.Equals(other.mapCond_))
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
		num ^= mapCond_.GetHashCode();
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
		mapCond_.WriteTo(output, _repeated_mapCond_codec);
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
		num += mapCond_.CalculateSize(_repeated_mapCond_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillMapDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			mapCond_.Add(other.mapCond_);
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
				mapCond_.AddEntriesFrom(input, _repeated_mapCond_codec);
				break;
			}
		}
	}
}
