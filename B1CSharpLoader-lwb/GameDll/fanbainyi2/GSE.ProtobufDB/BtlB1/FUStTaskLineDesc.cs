using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStTaskLineDesc : IMessage<FUStTaskLineDesc>, IMessage, IEquatable<FUStTaskLineDesc>, IDeepCloneable<FUStTaskLineDesc>
{
	private static readonly MessageParser<FUStTaskLineDesc> _parser = new MessageParser<FUStTaskLineDesc>(() => new FUStTaskLineDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string taskGraphAssetPath_ = "";

	private int beginTaskStageID_;

	private static readonly FieldCodec<int> _repeated_endTaskStageIDList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> endTaskStageIDList_ = new RepeatedField<int>();

	private string guard_ = "";

	public static MessageParser<FUStTaskLineDesc> Parser => _parser;

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

	public string TaskGraphAssetPath
	{
		get
		{
			return taskGraphAssetPath_;
		}
		set
		{
			taskGraphAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BeginTaskStageID
	{
		get
		{
			return beginTaskStageID_;
		}
		set
		{
			beginTaskStageID_ = value;
		}
	}

	public RepeatedField<int> EndTaskStageIDList => endTaskStageIDList_;

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStTaskLineDesc()
	{
	}

	public FUStTaskLineDesc(FUStTaskLineDesc other)
		: this()
	{
		iD_ = other.iD_;
		taskGraphAssetPath_ = other.taskGraphAssetPath_;
		beginTaskStageID_ = other.beginTaskStageID_;
		endTaskStageIDList_ = other.endTaskStageIDList_.Clone();
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTaskLineDesc Clone()
	{
		return new FUStTaskLineDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTaskLineDesc);
	}

	public bool Equals(FUStTaskLineDesc other)
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
		if (TaskGraphAssetPath != other.TaskGraphAssetPath)
		{
			return false;
		}
		if (BeginTaskStageID != other.BeginTaskStageID)
		{
			return false;
		}
		if (!endTaskStageIDList_.Equals(other.endTaskStageIDList_))
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (TaskGraphAssetPath.Length != 0)
		{
			num ^= TaskGraphAssetPath.GetHashCode();
		}
		if (BeginTaskStageID != 0)
		{
			num ^= BeginTaskStageID.GetHashCode();
		}
		num ^= endTaskStageIDList_.GetHashCode();
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
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
		if (TaskGraphAssetPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TaskGraphAssetPath);
		}
		if (BeginTaskStageID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BeginTaskStageID);
		}
		endTaskStageIDList_.WriteTo(output, _repeated_endTaskStageIDList_codec);
		if (Guard.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Guard);
		}
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
		if (TaskGraphAssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TaskGraphAssetPath);
		}
		if (BeginTaskStageID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeginTaskStageID);
		}
		num += endTaskStageIDList_.CalculateSize(_repeated_endTaskStageIDList_codec);
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTaskLineDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TaskGraphAssetPath.Length != 0)
			{
				TaskGraphAssetPath = other.TaskGraphAssetPath;
			}
			if (other.BeginTaskStageID != 0)
			{
				BeginTaskStageID = other.BeginTaskStageID;
			}
			endTaskStageIDList_.Add(other.endTaskStageIDList_);
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				TaskGraphAssetPath = input.ReadString();
				break;
			case 24u:
				BeginTaskStageID = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				endTaskStageIDList_.AddEntriesFrom(input, _repeated_endTaskStageIDList_codec);
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
