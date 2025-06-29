using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class EquipAttrDesc : IMessage<EquipAttrDesc>, IMessage, IEquatable<EquipAttrDesc>, IDeepCloneable<EquipAttrDesc>
{
	private static readonly MessageParser<EquipAttrDesc> _parser = new MessageParser<EquipAttrDesc>(() => new EquipAttrDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<EffectAttrCfg> _repeated_attr_codec = FieldCodec.ForMessage(18u, EffectAttrCfg.Parser);

	private readonly RepeatedField<EffectAttrCfg> attr_ = new RepeatedField<EffectAttrCfg>();

	public static MessageParser<EquipAttrDesc> Parser => _parser;

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

	public RepeatedField<EffectAttrCfg> Attr => attr_;

	public EquipAttrDesc()
	{
	}

	public EquipAttrDesc(EquipAttrDesc other)
		: this()
	{
		id_ = other.id_;
		attr_ = other.attr_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipAttrDesc Clone()
	{
		return new EquipAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipAttrDesc);
	}

	public bool Equals(EquipAttrDesc other)
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
		if (!attr_.Equals(other.attr_))
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
		num ^= attr_.GetHashCode();
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
		attr_.WriteTo(output, _repeated_attr_codec);
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
		num += attr_.CalculateSize(_repeated_attr_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipAttrDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			attr_.Add(other.attr_);
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
				attr_.AddEntriesFrom(input, _repeated_attr_codec);
				break;
			}
		}
	}
}
