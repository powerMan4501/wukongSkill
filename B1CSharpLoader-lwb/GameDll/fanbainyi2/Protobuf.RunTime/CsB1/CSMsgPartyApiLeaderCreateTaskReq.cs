using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiLeaderCreateTaskReq : IMessage<CSMsgPartyApiLeaderCreateTaskReq>, IMessage, IEquatable<CSMsgPartyApiLeaderCreateTaskReq>, IDeepCloneable<CSMsgPartyApiLeaderCreateTaskReq>
{
	private static readonly MessageParser<CSMsgPartyApiLeaderCreateTaskReq> _parser = new MessageParser<CSMsgPartyApiLeaderCreateTaskReq>(() => new CSMsgPartyApiLeaderCreateTaskReq());

	private UnknownFieldSet _unknownFields;

	private PartyTaskParam taskParam_;

	public static MessageParser<CSMsgPartyApiLeaderCreateTaskReq> Parser => _parser;

	public PartyTaskParam TaskParam
	{
		get
		{
			return taskParam_;
		}
		set
		{
			taskParam_ = value;
		}
	}

	public CSMsgPartyApiLeaderCreateTaskReq()
	{
	}

	public CSMsgPartyApiLeaderCreateTaskReq(CSMsgPartyApiLeaderCreateTaskReq other)
		: this()
	{
		taskParam_ = ((other.taskParam_ != null) ? other.taskParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiLeaderCreateTaskReq Clone()
	{
		return new CSMsgPartyApiLeaderCreateTaskReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiLeaderCreateTaskReq);
	}

	public bool Equals(CSMsgPartyApiLeaderCreateTaskReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TaskParam, other.TaskParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (taskParam_ != null)
		{
			num ^= TaskParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (taskParam_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(TaskParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (taskParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiLeaderCreateTaskReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.taskParam_ != null)
		{
			if (taskParam_ == null)
			{
				TaskParam = new PartyTaskParam();
			}
			TaskParam.MergeFrom(other.TaskParam);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (taskParam_ == null)
			{
				TaskParam = new PartyTaskParam();
			}
			input.ReadMessage(TaskParam);
		}
	}
}
