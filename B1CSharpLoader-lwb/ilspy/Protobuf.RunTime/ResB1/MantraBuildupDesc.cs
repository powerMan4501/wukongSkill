using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class MantraBuildupDesc : IMessage<MantraBuildupDesc>, IMessage, IEquatable<MantraBuildupDesc>, IDeepCloneable<MantraBuildupDesc>
{
	private static readonly MessageParser<MantraBuildupDesc> _parser = new MessageParser<MantraBuildupDesc>(() => new MantraBuildupDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<int> _repeated_mantraConfigList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> mantraConfigList_ = new RepeatedField<int>();

	public static MessageParser<MantraBuildupDesc> Parser => _parser;

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

	public RepeatedField<int> MantraConfigList => mantraConfigList_;

	public MantraBuildupDesc()
	{
	}

	public MantraBuildupDesc(MantraBuildupDesc other)
		: this()
	{
		id_ = other.id_;
		mantraConfigList_ = other.mantraConfigList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MantraBuildupDesc Clone()
	{
		return new MantraBuildupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MantraBuildupDesc);
	}

	public bool Equals(MantraBuildupDesc other)
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
		if (!mantraConfigList_.Equals(other.mantraConfigList_))
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
		num ^= mantraConfigList_.GetHashCode();
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
		mantraConfigList_.WriteTo(output, _repeated_mantraConfigList_codec);
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
		num += mantraConfigList_.CalculateSize(_repeated_mantraConfigList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MantraBuildupDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			mantraConfigList_.Add(other.mantraConfigList_);
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
				mantraConfigList_.AddEntriesFrom(input, _repeated_mantraConfigList_codec);
				break;
			}
		}
	}
}
