using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class EquipSeriesDesc : IMessage<EquipSeriesDesc>, IMessage, IEquatable<EquipSeriesDesc>, IDeepCloneable<EquipSeriesDesc>
{
	private static readonly MessageParser<EquipSeriesDesc> _parser = new MessageParser<EquipSeriesDesc>(() => new EquipSeriesDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<int> _repeated_equipIdList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> equipIdList_ = new RepeatedField<int>();

	public static MessageParser<EquipSeriesDesc> Parser => _parser;

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

	public RepeatedField<int> EquipIdList => equipIdList_;

	public EquipSeriesDesc()
	{
	}

	public EquipSeriesDesc(EquipSeriesDesc other)
		: this()
	{
		id_ = other.id_;
		equipIdList_ = other.equipIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipSeriesDesc Clone()
	{
		return new EquipSeriesDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipSeriesDesc);
	}

	public bool Equals(EquipSeriesDesc other)
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
		if (!equipIdList_.Equals(other.equipIdList_))
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
		num ^= equipIdList_.GetHashCode();
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
		equipIdList_.WriteTo(output, _repeated_equipIdList_codec);
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
		num += equipIdList_.CalculateSize(_repeated_equipIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipSeriesDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			equipIdList_.Add(other.equipIdList_);
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
			case 16u:
			case 18u:
				equipIdList_.AddEntriesFrom(input, _repeated_equipIdList_codec);
				break;
			}
		}
	}
}
