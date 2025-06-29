using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPhantomRushSkillConfigDesc : IMessage<FUStPhantomRushSkillConfigDesc>, IMessage, IEquatable<FUStPhantomRushSkillConfigDesc>, IDeepCloneable<FUStPhantomRushSkillConfigDesc>
{
	private static readonly MessageParser<FUStPhantomRushSkillConfigDesc> _parser = new MessageParser<FUStPhantomRushSkillConfigDesc>(() => new FUStPhantomRushSkillConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float phantomRushDuration_;

	private int phantomRushSkillID_;

	private int phantomRushSummonID_;

	private string phantomRushRelatedSkillConfigPath_ = "";

	private static readonly FieldCodec<int> _repeated_phantomRushEndTriggerEffectIDList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> phantomRushEndTriggerEffectIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_phantomRushBeginAddBuffIDList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> phantomRushBeginAddBuffIDList_ = new RepeatedField<int>();

	public static MessageParser<FUStPhantomRushSkillConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public float PhantomRushDuration
	{
		get
		{
			return phantomRushDuration_;
		}
		set
		{
			phantomRushDuration_ = value;
		}
	}

	public int PhantomRushSkillID
	{
		get
		{
			return phantomRushSkillID_;
		}
		set
		{
			phantomRushSkillID_ = value;
		}
	}

	public int PhantomRushSummonID
	{
		get
		{
			return phantomRushSummonID_;
		}
		set
		{
			phantomRushSummonID_ = value;
		}
	}

	public string PhantomRushRelatedSkillConfigPath
	{
		get
		{
			return phantomRushRelatedSkillConfigPath_;
		}
		set
		{
			phantomRushRelatedSkillConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> PhantomRushEndTriggerEffectIDList => phantomRushEndTriggerEffectIDList_;

	public RepeatedField<int> PhantomRushBeginAddBuffIDList => phantomRushBeginAddBuffIDList_;

	public FUStPhantomRushSkillConfigDesc()
	{
	}

	public FUStPhantomRushSkillConfigDesc(FUStPhantomRushSkillConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		phantomRushDuration_ = other.phantomRushDuration_;
		phantomRushSkillID_ = other.phantomRushSkillID_;
		phantomRushSummonID_ = other.phantomRushSummonID_;
		phantomRushRelatedSkillConfigPath_ = other.phantomRushRelatedSkillConfigPath_;
		phantomRushEndTriggerEffectIDList_ = other.phantomRushEndTriggerEffectIDList_.Clone();
		phantomRushBeginAddBuffIDList_ = other.phantomRushBeginAddBuffIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPhantomRushSkillConfigDesc Clone()
	{
		return new FUStPhantomRushSkillConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPhantomRushSkillConfigDesc);
	}

	public bool Equals(FUStPhantomRushSkillConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PhantomRushDuration, other.PhantomRushDuration))
		{
			return false;
		}
		if (PhantomRushSkillID != other.PhantomRushSkillID)
		{
			return false;
		}
		if (PhantomRushSummonID != other.PhantomRushSummonID)
		{
			return false;
		}
		if (PhantomRushRelatedSkillConfigPath != other.PhantomRushRelatedSkillConfigPath)
		{
			return false;
		}
		if (!phantomRushEndTriggerEffectIDList_.Equals(other.phantomRushEndTriggerEffectIDList_))
		{
			return false;
		}
		if (!phantomRushBeginAddBuffIDList_.Equals(other.phantomRushBeginAddBuffIDList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (PhantomRushDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PhantomRushDuration);
		}
		if (PhantomRushSkillID != 0)
		{
			num ^= PhantomRushSkillID.GetHashCode();
		}
		if (PhantomRushSummonID != 0)
		{
			num ^= PhantomRushSummonID.GetHashCode();
		}
		if (PhantomRushRelatedSkillConfigPath.Length != 0)
		{
			num ^= PhantomRushRelatedSkillConfigPath.GetHashCode();
		}
		num ^= phantomRushEndTriggerEffectIDList_.GetHashCode();
		num ^= phantomRushBeginAddBuffIDList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (PhantomRushDuration != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PhantomRushDuration);
		}
		if (PhantomRushSkillID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PhantomRushSkillID);
		}
		if (PhantomRushSummonID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PhantomRushSummonID);
		}
		if (PhantomRushRelatedSkillConfigPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PhantomRushRelatedSkillConfigPath);
		}
		phantomRushEndTriggerEffectIDList_.WriteTo(output, _repeated_phantomRushEndTriggerEffectIDList_codec);
		phantomRushBeginAddBuffIDList_.WriteTo(output, _repeated_phantomRushBeginAddBuffIDList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (PhantomRushDuration != 0f)
		{
			num += 5;
		}
		if (PhantomRushSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PhantomRushSkillID);
		}
		if (PhantomRushSummonID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PhantomRushSummonID);
		}
		if (PhantomRushRelatedSkillConfigPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PhantomRushRelatedSkillConfigPath);
		}
		num += phantomRushEndTriggerEffectIDList_.CalculateSize(_repeated_phantomRushEndTriggerEffectIDList_codec);
		num += phantomRushBeginAddBuffIDList_.CalculateSize(_repeated_phantomRushBeginAddBuffIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPhantomRushSkillConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.PhantomRushDuration != 0f)
			{
				PhantomRushDuration = other.PhantomRushDuration;
			}
			if (other.PhantomRushSkillID != 0)
			{
				PhantomRushSkillID = other.PhantomRushSkillID;
			}
			if (other.PhantomRushSummonID != 0)
			{
				PhantomRushSummonID = other.PhantomRushSummonID;
			}
			if (other.PhantomRushRelatedSkillConfigPath.Length != 0)
			{
				PhantomRushRelatedSkillConfigPath = other.PhantomRushRelatedSkillConfigPath;
			}
			phantomRushEndTriggerEffectIDList_.Add(other.phantomRushEndTriggerEffectIDList_);
			phantomRushBeginAddBuffIDList_.Add(other.phantomRushBeginAddBuffIDList_);
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
				ID = input.ReadInt32();
				break;
			case 21u:
				PhantomRushDuration = input.ReadFloat();
				break;
			case 24u:
				PhantomRushSkillID = input.ReadInt32();
				break;
			case 32u:
				PhantomRushSummonID = input.ReadInt32();
				break;
			case 42u:
				PhantomRushRelatedSkillConfigPath = input.ReadString();
				break;
			case 48u:
			case 50u:
				phantomRushEndTriggerEffectIDList_.AddEntriesFrom(input, _repeated_phantomRushEndTriggerEffectIDList_codec);
				break;
			case 56u:
			case 58u:
				phantomRushBeginAddBuffIDList_.AddEntriesFrom(input, _repeated_phantomRushBeginAddBuffIDList_codec);
				break;
			}
		}
	}
}
