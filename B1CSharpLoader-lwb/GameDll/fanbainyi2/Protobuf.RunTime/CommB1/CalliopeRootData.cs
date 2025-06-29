using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeRootData : IMessage<CalliopeRootData>, IMessage, IEquatable<CalliopeRootData>, IDeepCloneable<CalliopeRootData>
{
	private static readonly MessageParser<CalliopeRootData> _parser = new MessageParser<CalliopeRootData>(() => new CalliopeRootData());

	private UnknownFieldSet _unknownFields;

	private uint versionId_;

	private CalliopeGraphData graph_;

	private string time_ = "";

	public static MessageParser<CalliopeRootData> Parser => _parser;

	public uint VersionId
	{
		get
		{
			return versionId_;
		}
		set
		{
			versionId_ = value;
		}
	}

	public CalliopeGraphData Graph
	{
		get
		{
			return graph_;
		}
		set
		{
			graph_ = value;
		}
	}

	public string Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeRootData()
	{
	}

	public CalliopeRootData(CalliopeRootData other)
		: this()
	{
		versionId_ = other.versionId_;
		graph_ = ((other.graph_ != null) ? other.graph_.Clone() : null);
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeRootData Clone()
	{
		return new CalliopeRootData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeRootData);
	}

	public bool Equals(CalliopeRootData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VersionId != other.VersionId)
		{
			return false;
		}
		if (!object.Equals(Graph, other.Graph))
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (VersionId != 0)
		{
			num ^= VersionId.GetHashCode();
		}
		if (graph_ != null)
		{
			num ^= Graph.GetHashCode();
		}
		if (Time.Length != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (VersionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(VersionId);
		}
		if (graph_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Graph);
		}
		if (Time.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Time);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (VersionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VersionId);
		}
		if (graph_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Graph);
		}
		if (Time.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeRootData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.VersionId != 0)
		{
			VersionId = other.VersionId;
		}
		if (other.graph_ != null)
		{
			if (graph_ == null)
			{
				Graph = new CalliopeGraphData();
			}
			Graph.MergeFrom(other.Graph);
		}
		if (other.Time.Length != 0)
		{
			Time = other.Time;
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
				VersionId = input.ReadUInt32();
				break;
			case 18u:
				if (graph_ == null)
				{
					Graph = new CalliopeGraphData();
				}
				input.ReadMessage(Graph);
				break;
			case 26u:
				Time = input.ReadString();
				break;
			}
		}
	}
}
