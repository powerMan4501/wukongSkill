using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class EquipMantra : IMessage<EquipMantra>, IMessage, IEquatable<EquipMantra>, IDeepCloneable<EquipMantra>
{
	private static readonly MessageParser<EquipMantra> _parser = new MessageParser<EquipMantra>(() => new EquipMantra());

	private UnknownFieldSet _unknownFields;

	private int pos_;

	private int mantraId_;

	public static MessageParser<EquipMantra> Parser => _parser;

	public int Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	public int MantraId
	{
		get
		{
			return mantraId_;
		}
		set
		{
			mantraId_ = value;
		}
	}

	public EquipMantra()
	{
	}

	public EquipMantra(EquipMantra other)
		: this()
	{
		pos_ = other.pos_;
		mantraId_ = other.mantraId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipMantra Clone()
	{
		return new EquipMantra(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipMantra);
	}

	public bool Equals(EquipMantra other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (MantraId != other.MantraId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (MantraId != 0)
		{
			num ^= MantraId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Pos);
		}
		if (MantraId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MantraId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Pos);
		}
		if (MantraId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MantraId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipMantra other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.MantraId != 0)
			{
				MantraId = other.MantraId;
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
				Pos = input.ReadInt32();
				break;
			case 16u:
				MantraId = input.ReadInt32();
				break;
			}
		}
	}
}
