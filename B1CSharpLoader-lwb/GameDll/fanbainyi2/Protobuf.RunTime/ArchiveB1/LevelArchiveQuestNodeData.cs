using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveQuestNodeData : IMessage<LevelArchiveQuestNodeData>, IMessage, IEquatable<LevelArchiveQuestNodeData>, IDeepCloneable<LevelArchiveQuestNodeData>
{
	private static readonly MessageParser<LevelArchiveQuestNodeData> _parser = new MessageParser<LevelArchiveQuestNodeData>(() => new LevelArchiveQuestNodeData());

	private UnknownFieldSet _unknownFields;

	private bool isDataValid_;

	private string uniqueId_ = "";

	private ActivationState activationState_;

	private ByteString customData_ = ByteString.Empty;

	private string parentGuid_ = "";

	private static readonly FieldCodec<string> _repeated_observeActorGuid_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> observeActorGuid_ = new RepeatedField<string>();

	private string nodeTemplateName_ = "";

	private string nodeGraphName_ = "";

	public static MessageParser<LevelArchiveQuestNodeData> Parser => _parser;

	public bool IsDataValid
	{
		get
		{
			return isDataValid_;
		}
		set
		{
			isDataValid_ = value;
		}
	}

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

	public ByteString CustomData
	{
		get
		{
			return customData_;
		}
		set
		{
			customData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ParentGuid
	{
		get
		{
			return parentGuid_;
		}
		set
		{
			parentGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> ObserveActorGuid => observeActorGuid_;

	public string NodeTemplateName
	{
		get
		{
			return nodeTemplateName_;
		}
		set
		{
			nodeTemplateName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NodeGraphName
	{
		get
		{
			return nodeGraphName_;
		}
		set
		{
			nodeGraphName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LevelArchiveQuestNodeData()
	{
	}

	public LevelArchiveQuestNodeData(LevelArchiveQuestNodeData other)
		: this()
	{
		isDataValid_ = other.isDataValid_;
		uniqueId_ = other.uniqueId_;
		activationState_ = other.activationState_;
		customData_ = other.customData_;
		parentGuid_ = other.parentGuid_;
		observeActorGuid_ = other.observeActorGuid_.Clone();
		nodeTemplateName_ = other.nodeTemplateName_;
		nodeGraphName_ = other.nodeGraphName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveQuestNodeData Clone()
	{
		return new LevelArchiveQuestNodeData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveQuestNodeData);
	}

	public bool Equals(LevelArchiveQuestNodeData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsDataValid != other.IsDataValid)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (ActivationState != other.ActivationState)
		{
			return false;
		}
		if (CustomData != other.CustomData)
		{
			return false;
		}
		if (ParentGuid != other.ParentGuid)
		{
			return false;
		}
		if (!observeActorGuid_.Equals(other.observeActorGuid_))
		{
			return false;
		}
		if (NodeTemplateName != other.NodeTemplateName)
		{
			return false;
		}
		if (NodeGraphName != other.NodeGraphName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsDataValid)
		{
			num ^= IsDataValid.GetHashCode();
		}
		if (UniqueId.Length != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num ^= ActivationState.GetHashCode();
		}
		if (CustomData.Length != 0)
		{
			num ^= CustomData.GetHashCode();
		}
		if (ParentGuid.Length != 0)
		{
			num ^= ParentGuid.GetHashCode();
		}
		num ^= observeActorGuid_.GetHashCode();
		if (NodeTemplateName.Length != 0)
		{
			num ^= NodeTemplateName.GetHashCode();
		}
		if (NodeGraphName.Length != 0)
		{
			num ^= NodeGraphName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsDataValid)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsDataValid);
		}
		if (UniqueId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UniqueId);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ActivationState);
		}
		if (CustomData.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(CustomData);
		}
		if (ParentGuid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ParentGuid);
		}
		observeActorGuid_.WriteTo(output, _repeated_observeActorGuid_codec);
		if (NodeTemplateName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(NodeTemplateName);
		}
		if (NodeGraphName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(NodeGraphName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsDataValid)
		{
			num += 2;
		}
		if (UniqueId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UniqueId);
		}
		if (ActivationState != ActivationState.NeverActivated)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ActivationState);
		}
		if (CustomData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(CustomData);
		}
		if (ParentGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ParentGuid);
		}
		num += observeActorGuid_.CalculateSize(_repeated_observeActorGuid_codec);
		if (NodeTemplateName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NodeTemplateName);
		}
		if (NodeGraphName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NodeGraphName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveQuestNodeData other)
	{
		if (other != null)
		{
			if (other.IsDataValid)
			{
				IsDataValid = other.IsDataValid;
			}
			if (other.UniqueId.Length != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.ActivationState != ActivationState.NeverActivated)
			{
				ActivationState = other.ActivationState;
			}
			if (other.CustomData.Length != 0)
			{
				CustomData = other.CustomData;
			}
			if (other.ParentGuid.Length != 0)
			{
				ParentGuid = other.ParentGuid;
			}
			observeActorGuid_.Add(other.observeActorGuid_);
			if (other.NodeTemplateName.Length != 0)
			{
				NodeTemplateName = other.NodeTemplateName;
			}
			if (other.NodeGraphName.Length != 0)
			{
				NodeGraphName = other.NodeGraphName;
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
				IsDataValid = input.ReadBool();
				break;
			case 18u:
				UniqueId = input.ReadString();
				break;
			case 24u:
				ActivationState = (ActivationState)input.ReadEnum();
				break;
			case 34u:
				CustomData = input.ReadBytes();
				break;
			case 42u:
				ParentGuid = input.ReadString();
				break;
			case 50u:
				observeActorGuid_.AddEntriesFrom(input, _repeated_observeActorGuid_codec);
				break;
			case 58u:
				NodeTemplateName = input.ReadString();
				break;
			case 66u:
				NodeGraphName = input.ReadString();
				break;
			}
		}
	}
}
