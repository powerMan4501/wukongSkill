using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class PsmArchiveNodeData : IMessage<PsmArchiveNodeData>, IMessage, IEquatable<PsmArchiveNodeData>, IDeepCloneable<PsmArchiveNodeData>
{
	private static readonly MessageParser<PsmArchiveNodeData> _parser = new MessageParser<PsmArchiveNodeData>(() => new PsmArchiveNodeData());

	private UnknownFieldSet _unknownFields;

	private string uniqueId_ = "";

	private ActivationState activationState_;

	private string stateTag_ = "";

	public static MessageParser<PsmArchiveNodeData> Parser => _parser;

	public string UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ActivationState ActivationState
	{
		get
		{
			return activationState_;
		}
		set
		{
			activationState_ = value;
		}
	}

	public string StateTag
	{
		get
		{
			return stateTag_;
		}
		set
		{
			stateTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PsmArchiveNodeData()
	{
	}

	public PsmArchiveNodeData(PsmArchiveNodeData other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		activationState_ = other.activationState_;
		stateTag_ = other.stateTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PsmArchiveNodeData Clone()
	{
		return new PsmArchiveNodeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PsmArchiveNodeData);
	}

	public bool Equals(PsmArchiveNodeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (ActivationState != other.ActivationState)
		{
			return false;
		}
		if (StateTag != other.StateTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UniqueId.Length != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num ^= ActivationState.GetHashCode();
		}
		if (StateTag.Length != 0)
		{
			num ^= StateTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UniqueId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(UniqueId);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ActivationState);
		}
		if (StateTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(StateTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UniqueId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UniqueId);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ActivationState);
		}
		if (StateTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StateTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PsmArchiveNodeData other)
	{
		if (other != null)
		{
			if (other.UniqueId.Length != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.ActivationState != ActivationState.NeverActivated)
			{
				ActivationState = other.ActivationState;
			}
			if (other.StateTag.Length != 0)
			{
				StateTag = other.StateTag;
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
			case 10u:
				UniqueId = input.ReadString();
				break;
			case 16u:
				ActivationState = (ActivationState)input.ReadEnum();
				break;
			case 26u:
				StateTag = input.ReadString();
				break;
			}
		}
	}
}
