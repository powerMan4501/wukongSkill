using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class PartyData : IMessage<PartyData>, IMessage, IEquatable<PartyData>, IDeepCloneable<PartyData>
{
	private static readonly MessageParser<PartyData> _parser = new MessageParser<PartyData>(() => new PartyData());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private string partyIdStr_ = "";

	private string partySessionId_ = "";

	private PartySetting setting_;

	private ulong owner_;

	private static readonly FieldCodec<PartyMember> _repeated_members_codec = FieldCodec.ForMessage(50u, PartyMember.Parser);

	private readonly RepeatedField<PartyMember> members_ = new RepeatedField<PartyMember>();

	private PartyTask task_;

	public static MessageParser<PartyData> Parser => _parser;

	public ulong PartyId
	{
		get
		{
			return partyId_;
		}
		set
		{
			partyId_ = value;
		}
	}

	public string PartyIdStr
	{
		get
		{
			return partyIdStr_;
		}
		set
		{
			partyIdStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PartySessionId
	{
		get
		{
			return partySessionId_;
		}
		set
		{
			partySessionId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PartySetting Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public ulong Owner
	{
		get
		{
			return owner_;
		}
		set
		{
			owner_ = value;
		}
	}

	public RepeatedField<PartyMember> Members => members_;

	public PartyTask Task
	{
		get
		{
			return task_;
		}
		set
		{
			task_ = value;
		}
	}

	public PartyData()
	{
	}

	public PartyData(PartyData other)
		: this()
	{
		partyId_ = other.partyId_;
		partyIdStr_ = other.partyIdStr_;
		partySessionId_ = other.partySessionId_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		owner_ = other.owner_;
		members_ = other.members_.Clone();
		task_ = ((other.task_ != null) ? other.task_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyData Clone()
	{
		return new PartyData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyData);
	}

	public bool Equals(PartyData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PartyId != other.PartyId)
		{
			return false;
		}
		if (PartyIdStr != other.PartyIdStr)
		{
			return false;
		}
		if (PartySessionId != other.PartySessionId)
		{
			return false;
		}
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		if (Owner != other.Owner)
		{
			return false;
		}
		if (!members_.Equals(other.members_))
		{
			return false;
		}
		if (!object.Equals(Task, other.Task))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (PartyIdStr.Length != 0)
		{
			num ^= PartyIdStr.GetHashCode();
		}
		if (PartySessionId.Length != 0)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (Owner != 0L)
		{
			num ^= Owner.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (task_ != null)
		{
			num ^= Task.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PartyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PartyId);
		}
		if (PartyIdStr.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PartyIdStr);
		}
		if (PartySessionId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PartySessionId);
		}
		if (setting_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Setting);
		}
		if (Owner != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(Owner);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (task_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Task);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (PartyIdStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartyIdStr);
		}
		if (PartySessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartySessionId);
		}
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (Owner != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Owner);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (task_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Task);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.PartyIdStr.Length != 0)
		{
			PartyIdStr = other.PartyIdStr;
		}
		if (other.PartySessionId.Length != 0)
		{
			PartySessionId = other.PartySessionId;
		}
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new PartySetting();
			}
			Setting.MergeFrom(other.Setting);
		}
		if (other.Owner != 0L)
		{
			Owner = other.Owner;
		}
		members_.Add(other.members_);
		if (other.task_ != null)
		{
			if (task_ == null)
			{
				Task = new PartyTask();
			}
			Task.MergeFrom(other.Task);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				PartyId = input.ReadUInt64();
				break;
			case 18u:
				PartyIdStr = input.ReadString();
				break;
			case 26u:
				PartySessionId = input.ReadString();
				break;
			case 34u:
				if (setting_ == null)
				{
					Setting = new PartySetting();
				}
				input.ReadMessage(Setting);
				break;
			case 40u:
				Owner = input.ReadUInt64();
				break;
			case 50u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			case 58u:
				if (task_ == null)
				{
					Task = new PartyTask();
				}
				input.ReadMessage(Task);
				break;
			}
		}
	}
}
