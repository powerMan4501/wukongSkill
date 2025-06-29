using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_LevelSequenceConfig : IMessage<CalliopeCustom_LevelSequenceConfig>, IMessage, IEquatable<CalliopeCustom_LevelSequenceConfig>, IDeepCloneable<CalliopeCustom_LevelSequenceConfig>
{
	private static readonly MessageParser<CalliopeCustom_LevelSequenceConfig> _parser = new MessageParser<CalliopeCustom_LevelSequenceConfig>(() => new CalliopeCustom_LevelSequenceConfig());

	private UnknownFieldSet _unknownFields;

	private string sequencePath_ = "";

	private CalliopeCustom_Transform cameraStartTransform_;

	private string cameraTag_ = "";

	private string railTag_ = "";

	private string craneTag_ = "";

	public static MessageParser<CalliopeCustom_LevelSequenceConfig> Parser => _parser;

	public string SequencePath
	{
		get
		{
			return sequencePath_;
		}
		set
		{
			sequencePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_Transform CameraStartTransform
	{
		get
		{
			return cameraStartTransform_;
		}
		set
		{
			cameraStartTransform_ = value;
		}
	}

	public string CameraTag
	{
		get
		{
			return cameraTag_;
		}
		set
		{
			cameraTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RailTag
	{
		get
		{
			return railTag_;
		}
		set
		{
			railTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CraneTag
	{
		get
		{
			return craneTag_;
		}
		set
		{
			craneTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_LevelSequenceConfig()
	{
	}

	public CalliopeCustom_LevelSequenceConfig(CalliopeCustom_LevelSequenceConfig other)
		: this()
	{
		sequencePath_ = other.sequencePath_;
		cameraStartTransform_ = ((other.cameraStartTransform_ != null) ? other.cameraStartTransform_.Clone() : null);
		cameraTag_ = other.cameraTag_;
		railTag_ = other.railTag_;
		craneTag_ = other.craneTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_LevelSequenceConfig Clone()
	{
		return new CalliopeCustom_LevelSequenceConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_LevelSequenceConfig);
	}

	public bool Equals(CalliopeCustom_LevelSequenceConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SequencePath != other.SequencePath)
		{
			return false;
		}
		if (!object.Equals(CameraStartTransform, other.CameraStartTransform))
		{
			return false;
		}
		if (CameraTag != other.CameraTag)
		{
			return false;
		}
		if (RailTag != other.RailTag)
		{
			return false;
		}
		if (CraneTag != other.CraneTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SequencePath.Length != 0)
		{
			num ^= SequencePath.GetHashCode();
		}
		if (cameraStartTransform_ != null)
		{
			num ^= CameraStartTransform.GetHashCode();
		}
		if (CameraTag.Length != 0)
		{
			num ^= CameraTag.GetHashCode();
		}
		if (RailTag.Length != 0)
		{
			num ^= RailTag.GetHashCode();
		}
		if (CraneTag.Length != 0)
		{
			num ^= CraneTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SequencePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SequencePath);
		}
		if (cameraStartTransform_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CameraStartTransform);
		}
		if (CameraTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(CameraTag);
		}
		if (RailTag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(RailTag);
		}
		if (CraneTag.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(CraneTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SequencePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SequencePath);
		}
		if (cameraStartTransform_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CameraStartTransform);
		}
		if (CameraTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraTag);
		}
		if (RailTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RailTag);
		}
		if (CraneTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CraneTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_LevelSequenceConfig other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SequencePath.Length != 0)
		{
			SequencePath = other.SequencePath;
		}
		if (other.cameraStartTransform_ != null)
		{
			if (cameraStartTransform_ == null)
			{
				CameraStartTransform = new CalliopeCustom_Transform();
			}
			CameraStartTransform.MergeFrom(other.CameraStartTransform);
		}
		if (other.CameraTag.Length != 0)
		{
			CameraTag = other.CameraTag;
		}
		if (other.RailTag.Length != 0)
		{
			RailTag = other.RailTag;
		}
		if (other.CraneTag.Length != 0)
		{
			CraneTag = other.CraneTag;
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
				SequencePath = input.ReadString();
				break;
			case 18u:
				if (cameraStartTransform_ == null)
				{
					CameraStartTransform = new CalliopeCustom_Transform();
				}
				input.ReadMessage(CameraStartTransform);
				break;
			case 26u:
				CameraTag = input.ReadString();
				break;
			case 34u:
				RailTag = input.ReadString();
				break;
			case 42u:
				CraneTag = input.ReadString();
				break;
			}
		}
	}
}
