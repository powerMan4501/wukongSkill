using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_ManagedNPCUnit : IMessage<CalliopeCustom_ManagedNPCUnit>, IMessage, IEquatable<CalliopeCustom_ManagedNPCUnit>, IDeepCloneable<CalliopeCustom_ManagedNPCUnit>
{
	private static readonly MessageParser<CalliopeCustom_ManagedNPCUnit> _parser = new MessageParser<CalliopeCustom_ManagedNPCUnit>(() => new CalliopeCustom_ManagedNPCUnit());

	private UnknownFieldSet _unknownFields;

	private string npcGuid_ = "";

	private ManagedNPCUnitParam teamIdValue_;

	private ManagedSmartParam teamIdParamValue_;

	private ManagedNPCUnitParam idleAmIdxValue_;

	private ManagedSmartParam idleAmIdxParamValue_;

	private ManagedNPCUnitParam leisureAnimIndexValue_;

	private ManagedSmartParam leisureAnimIndexParamValue_;

	private ManagedNPCUnitParam interactGroupIdValue_;

	private ManagedSmartParam interactGroupIdParamValue_;

	private ManagedNPCUnitParam showStateValue_;

	private static readonly FieldCodec<ManagedNPCUnitBuffParam> _repeated_buffInfoList_codec = FieldCodec.ForMessage(90u, ManagedNPCUnitBuffParam.Parser);

	private readonly RepeatedField<ManagedNPCUnitBuffParam> buffInfoList_ = new RepeatedField<ManagedNPCUnitBuffParam>();

	private static readonly FieldCodec<string> _repeated_npcInstanceGuid_codec = FieldCodec.ForString(98u);

	private readonly RepeatedField<string> npcInstanceGuid_ = new RepeatedField<string>();

	private ManagedNPCUnitActiveInstanceParam activeInstanceValue_;

	public static MessageParser<CalliopeCustom_ManagedNPCUnit> Parser => _parser;

	public string NpcGuid
	{
		get
		{
			return npcGuid_;
		}
		set
		{
			npcGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ManagedNPCUnitParam TeamIdValue
	{
		get
		{
			return teamIdValue_;
		}
		set
		{
			teamIdValue_ = value;
		}
	}

	public ManagedSmartParam TeamIdParamValue
	{
		get
		{
			return teamIdParamValue_;
		}
		set
		{
			teamIdParamValue_ = value;
		}
	}

	public ManagedNPCUnitParam IdleAmIdxValue
	{
		get
		{
			return idleAmIdxValue_;
		}
		set
		{
			idleAmIdxValue_ = value;
		}
	}

	public ManagedSmartParam IdleAmIdxParamValue
	{
		get
		{
			return idleAmIdxParamValue_;
		}
		set
		{
			idleAmIdxParamValue_ = value;
		}
	}

	public ManagedNPCUnitParam LeisureAnimIndexValue
	{
		get
		{
			return leisureAnimIndexValue_;
		}
		set
		{
			leisureAnimIndexValue_ = value;
		}
	}

	public ManagedSmartParam LeisureAnimIndexParamValue
	{
		get
		{
			return leisureAnimIndexParamValue_;
		}
		set
		{
			leisureAnimIndexParamValue_ = value;
		}
	}

	public ManagedNPCUnitParam InteractGroupIdValue
	{
		get
		{
			return interactGroupIdValue_;
		}
		set
		{
			interactGroupIdValue_ = value;
		}
	}

	public ManagedSmartParam InteractGroupIdParamValue
	{
		get
		{
			return interactGroupIdParamValue_;
		}
		set
		{
			interactGroupIdParamValue_ = value;
		}
	}

	public ManagedNPCUnitParam ShowStateValue
	{
		get
		{
			return showStateValue_;
		}
		set
		{
			showStateValue_ = value;
		}
	}

	public RepeatedField<ManagedNPCUnitBuffParam> BuffInfoList => buffInfoList_;

	public RepeatedField<string> NpcInstanceGuid => npcInstanceGuid_;

	public ManagedNPCUnitActiveInstanceParam ActiveInstanceValue
	{
		get
		{
			return activeInstanceValue_;
		}
		set
		{
			activeInstanceValue_ = value;
		}
	}

	public CalliopeCustom_ManagedNPCUnit()
	{
	}

	public CalliopeCustom_ManagedNPCUnit(CalliopeCustom_ManagedNPCUnit other)
		: this()
	{
		npcGuid_ = other.npcGuid_;
		teamIdValue_ = ((other.teamIdValue_ != null) ? other.teamIdValue_.Clone() : null);
		teamIdParamValue_ = ((other.teamIdParamValue_ != null) ? other.teamIdParamValue_.Clone() : null);
		idleAmIdxValue_ = ((other.idleAmIdxValue_ != null) ? other.idleAmIdxValue_.Clone() : null);
		idleAmIdxParamValue_ = ((other.idleAmIdxParamValue_ != null) ? other.idleAmIdxParamValue_.Clone() : null);
		leisureAnimIndexValue_ = ((other.leisureAnimIndexValue_ != null) ? other.leisureAnimIndexValue_.Clone() : null);
		leisureAnimIndexParamValue_ = ((other.leisureAnimIndexParamValue_ != null) ? other.leisureAnimIndexParamValue_.Clone() : null);
		interactGroupIdValue_ = ((other.interactGroupIdValue_ != null) ? other.interactGroupIdValue_.Clone() : null);
		interactGroupIdParamValue_ = ((other.interactGroupIdParamValue_ != null) ? other.interactGroupIdParamValue_.Clone() : null);
		showStateValue_ = ((other.showStateValue_ != null) ? other.showStateValue_.Clone() : null);
		buffInfoList_ = other.buffInfoList_.Clone();
		npcInstanceGuid_ = other.npcInstanceGuid_.Clone();
		activeInstanceValue_ = ((other.activeInstanceValue_ != null) ? other.activeInstanceValue_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ManagedNPCUnit Clone()
	{
		return new CalliopeCustom_ManagedNPCUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ManagedNPCUnit);
	}

	public bool Equals(CalliopeCustom_ManagedNPCUnit other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NpcGuid != other.NpcGuid)
		{
			return false;
		}
		if (!object.Equals(TeamIdValue, other.TeamIdValue))
		{
			return false;
		}
		if (!object.Equals(TeamIdParamValue, other.TeamIdParamValue))
		{
			return false;
		}
		if (!object.Equals(IdleAmIdxValue, other.IdleAmIdxValue))
		{
			return false;
		}
		if (!object.Equals(IdleAmIdxParamValue, other.IdleAmIdxParamValue))
		{
			return false;
		}
		if (!object.Equals(LeisureAnimIndexValue, other.LeisureAnimIndexValue))
		{
			return false;
		}
		if (!object.Equals(LeisureAnimIndexParamValue, other.LeisureAnimIndexParamValue))
		{
			return false;
		}
		if (!object.Equals(InteractGroupIdValue, other.InteractGroupIdValue))
		{
			return false;
		}
		if (!object.Equals(InteractGroupIdParamValue, other.InteractGroupIdParamValue))
		{
			return false;
		}
		if (!object.Equals(ShowStateValue, other.ShowStateValue))
		{
			return false;
		}
		if (!buffInfoList_.Equals(other.buffInfoList_))
		{
			return false;
		}
		if (!npcInstanceGuid_.Equals(other.npcInstanceGuid_))
		{
			return false;
		}
		if (!object.Equals(ActiveInstanceValue, other.ActiveInstanceValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NpcGuid.Length != 0)
		{
			num ^= NpcGuid.GetHashCode();
		}
		if (teamIdValue_ != null)
		{
			num ^= TeamIdValue.GetHashCode();
		}
		if (teamIdParamValue_ != null)
		{
			num ^= TeamIdParamValue.GetHashCode();
		}
		if (idleAmIdxValue_ != null)
		{
			num ^= IdleAmIdxValue.GetHashCode();
		}
		if (idleAmIdxParamValue_ != null)
		{
			num ^= IdleAmIdxParamValue.GetHashCode();
		}
		if (leisureAnimIndexValue_ != null)
		{
			num ^= LeisureAnimIndexValue.GetHashCode();
		}
		if (leisureAnimIndexParamValue_ != null)
		{
			num ^= LeisureAnimIndexParamValue.GetHashCode();
		}
		if (interactGroupIdValue_ != null)
		{
			num ^= InteractGroupIdValue.GetHashCode();
		}
		if (interactGroupIdParamValue_ != null)
		{
			num ^= InteractGroupIdParamValue.GetHashCode();
		}
		if (showStateValue_ != null)
		{
			num ^= ShowStateValue.GetHashCode();
		}
		num ^= buffInfoList_.GetHashCode();
		num ^= npcInstanceGuid_.GetHashCode();
		if (activeInstanceValue_ != null)
		{
			num ^= ActiveInstanceValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NpcGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(NpcGuid);
		}
		if (teamIdValue_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TeamIdValue);
		}
		if (teamIdParamValue_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TeamIdParamValue);
		}
		if (idleAmIdxValue_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IdleAmIdxValue);
		}
		if (idleAmIdxParamValue_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IdleAmIdxParamValue);
		}
		if (leisureAnimIndexValue_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LeisureAnimIndexValue);
		}
		if (leisureAnimIndexParamValue_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LeisureAnimIndexParamValue);
		}
		if (interactGroupIdValue_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(InteractGroupIdValue);
		}
		if (interactGroupIdParamValue_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(InteractGroupIdParamValue);
		}
		if (showStateValue_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ShowStateValue);
		}
		buffInfoList_.WriteTo(output, _repeated_buffInfoList_codec);
		npcInstanceGuid_.WriteTo(output, _repeated_npcInstanceGuid_codec);
		if (activeInstanceValue_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ActiveInstanceValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NpcGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NpcGuid);
		}
		if (teamIdValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TeamIdValue);
		}
		if (teamIdParamValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TeamIdParamValue);
		}
		if (idleAmIdxValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IdleAmIdxValue);
		}
		if (idleAmIdxParamValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IdleAmIdxParamValue);
		}
		if (leisureAnimIndexValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LeisureAnimIndexValue);
		}
		if (leisureAnimIndexParamValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LeisureAnimIndexParamValue);
		}
		if (interactGroupIdValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(InteractGroupIdValue);
		}
		if (interactGroupIdParamValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(InteractGroupIdParamValue);
		}
		if (showStateValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowStateValue);
		}
		num += buffInfoList_.CalculateSize(_repeated_buffInfoList_codec);
		num += npcInstanceGuid_.CalculateSize(_repeated_npcInstanceGuid_codec);
		if (activeInstanceValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ActiveInstanceValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ManagedNPCUnit other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NpcGuid.Length != 0)
		{
			NpcGuid = other.NpcGuid;
		}
		if (other.teamIdValue_ != null)
		{
			if (teamIdValue_ == null)
			{
				TeamIdValue = new ManagedNPCUnitParam();
			}
			TeamIdValue.MergeFrom(other.TeamIdValue);
		}
		if (other.teamIdParamValue_ != null)
		{
			if (teamIdParamValue_ == null)
			{
				TeamIdParamValue = new ManagedSmartParam();
			}
			TeamIdParamValue.MergeFrom(other.TeamIdParamValue);
		}
		if (other.idleAmIdxValue_ != null)
		{
			if (idleAmIdxValue_ == null)
			{
				IdleAmIdxValue = new ManagedNPCUnitParam();
			}
			IdleAmIdxValue.MergeFrom(other.IdleAmIdxValue);
		}
		if (other.idleAmIdxParamValue_ != null)
		{
			if (idleAmIdxParamValue_ == null)
			{
				IdleAmIdxParamValue = new ManagedSmartParam();
			}
			IdleAmIdxParamValue.MergeFrom(other.IdleAmIdxParamValue);
		}
		if (other.leisureAnimIndexValue_ != null)
		{
			if (leisureAnimIndexValue_ == null)
			{
				LeisureAnimIndexValue = new ManagedNPCUnitParam();
			}
			LeisureAnimIndexValue.MergeFrom(other.LeisureAnimIndexValue);
		}
		if (other.leisureAnimIndexParamValue_ != null)
		{
			if (leisureAnimIndexParamValue_ == null)
			{
				LeisureAnimIndexParamValue = new ManagedSmartParam();
			}
			LeisureAnimIndexParamValue.MergeFrom(other.LeisureAnimIndexParamValue);
		}
		if (other.interactGroupIdValue_ != null)
		{
			if (interactGroupIdValue_ == null)
			{
				InteractGroupIdValue = new ManagedNPCUnitParam();
			}
			InteractGroupIdValue.MergeFrom(other.InteractGroupIdValue);
		}
		if (other.interactGroupIdParamValue_ != null)
		{
			if (interactGroupIdParamValue_ == null)
			{
				InteractGroupIdParamValue = new ManagedSmartParam();
			}
			InteractGroupIdParamValue.MergeFrom(other.InteractGroupIdParamValue);
		}
		if (other.showStateValue_ != null)
		{
			if (showStateValue_ == null)
			{
				ShowStateValue = new ManagedNPCUnitParam();
			}
			ShowStateValue.MergeFrom(other.ShowStateValue);
		}
		buffInfoList_.Add(other.buffInfoList_);
		npcInstanceGuid_.Add(other.npcInstanceGuid_);
		if (other.activeInstanceValue_ != null)
		{
			if (activeInstanceValue_ == null)
			{
				ActiveInstanceValue = new ManagedNPCUnitActiveInstanceParam();
			}
			ActiveInstanceValue.MergeFrom(other.ActiveInstanceValue);
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
			case 10u:
				NpcGuid = input.ReadString();
				break;
			case 18u:
				if (teamIdValue_ == null)
				{
					TeamIdValue = new ManagedNPCUnitParam();
				}
				input.ReadMessage(TeamIdValue);
				break;
			case 26u:
				if (teamIdParamValue_ == null)
				{
					TeamIdParamValue = new ManagedSmartParam();
				}
				input.ReadMessage(TeamIdParamValue);
				break;
			case 34u:
				if (idleAmIdxValue_ == null)
				{
					IdleAmIdxValue = new ManagedNPCUnitParam();
				}
				input.ReadMessage(IdleAmIdxValue);
				break;
			case 42u:
				if (idleAmIdxParamValue_ == null)
				{
					IdleAmIdxParamValue = new ManagedSmartParam();
				}
				input.ReadMessage(IdleAmIdxParamValue);
				break;
			case 50u:
				if (leisureAnimIndexValue_ == null)
				{
					LeisureAnimIndexValue = new ManagedNPCUnitParam();
				}
				input.ReadMessage(LeisureAnimIndexValue);
				break;
			case 58u:
				if (leisureAnimIndexParamValue_ == null)
				{
					LeisureAnimIndexParamValue = new ManagedSmartParam();
				}
				input.ReadMessage(LeisureAnimIndexParamValue);
				break;
			case 66u:
				if (interactGroupIdValue_ == null)
				{
					InteractGroupIdValue = new ManagedNPCUnitParam();
				}
				input.ReadMessage(InteractGroupIdValue);
				break;
			case 74u:
				if (interactGroupIdParamValue_ == null)
				{
					InteractGroupIdParamValue = new ManagedSmartParam();
				}
				input.ReadMessage(InteractGroupIdParamValue);
				break;
			case 82u:
				if (showStateValue_ == null)
				{
					ShowStateValue = new ManagedNPCUnitParam();
				}
				input.ReadMessage(ShowStateValue);
				break;
			case 90u:
				buffInfoList_.AddEntriesFrom(input, _repeated_buffInfoList_codec);
				break;
			case 98u:
				npcInstanceGuid_.AddEntriesFrom(input, _repeated_npcInstanceGuid_codec);
				break;
			case 106u:
				if (activeInstanceValue_ == null)
				{
					ActiveInstanceValue = new ManagedNPCUnitActiveInstanceParam();
				}
				input.ReadMessage(ActiveInstanceValue);
				break;
			}
		}
	}
}
