using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;

namespace CommB1;

public sealed class UnitStatusInfo : IMessage<UnitStatusInfo>, IMessage, IEquatable<UnitStatusInfo>, IDeepCloneable<UnitStatusInfo>
{
	private static readonly MessageParser<UnitStatusInfo> _parser = new MessageParser<UnitStatusInfo>(() => new UnitStatusInfo());

	private UnknownFieldSet _unknownFields;

	private string unitGuid_ = "";

	private bool unitIsPlayer_;

	private static readonly FieldCodec<CalliopeCustom_DetectCondition> _repeated_conditions_codec = FieldCodec.ForMessage(26u, CalliopeCustom_DetectCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_DetectCondition> conditions_ = new RepeatedField<CalliopeCustom_DetectCondition>();

	public static MessageParser<UnitStatusInfo> Parser => _parser;

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool UnitIsPlayer
	{
		get
		{
			return unitIsPlayer_;
		}
		set
		{
			unitIsPlayer_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_DetectCondition> Conditions => conditions_;

	public UnitStatusInfo()
	{
	}

	public UnitStatusInfo(UnitStatusInfo other)
		: this()
	{
		unitGuid_ = other.unitGuid_;
		unitIsPlayer_ = other.unitIsPlayer_;
		conditions_ = other.conditions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitStatusInfo Clone()
	{
		return new UnitStatusInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitStatusInfo);
	}

	public bool Equals(UnitStatusInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (UnitIsPlayer != other.UnitIsPlayer)
		{
			return false;
		}
		if (!conditions_.Equals(other.conditions_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (UnitIsPlayer)
		{
			num ^= UnitIsPlayer.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UnitGuid);
		}
		if (UnitIsPlayer)
		{
			output.WriteRawTag(16);
			output.WriteBool(UnitIsPlayer);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (UnitIsPlayer)
		{
			num += 2;
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitStatusInfo other)
	{
		if (other != null)
		{
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.UnitIsPlayer)
			{
				UnitIsPlayer = other.UnitIsPlayer;
			}
			conditions_.Add(other.conditions_);
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
			case 10u:
				UnitGuid = input.ReadString();
				break;
			case 16u:
				UnitIsPlayer = input.ReadBool();
				break;
			case 26u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			}
		}
	}
}
