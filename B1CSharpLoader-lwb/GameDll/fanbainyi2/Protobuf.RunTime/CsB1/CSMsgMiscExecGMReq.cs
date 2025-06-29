using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgMiscExecGMReq : IMessage<CSMsgMiscExecGMReq>, IMessage, IEquatable<CSMsgMiscExecGMReq>, IDeepCloneable<CSMsgMiscExecGMReq>
{
	private static readonly MessageParser<CSMsgMiscExecGMReq> _parser = new MessageParser<CSMsgMiscExecGMReq>(() => new CSMsgMiscExecGMReq());

	private UnknownFieldSet _unknownFields;

	private ExecGmType gmType_;

	private static readonly FieldCodec<string> _repeated_gmCmd_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> gmCmd_ = new RepeatedField<string>();

	private RoleDataCS snapshootRoleData_;

	public static MessageParser<CSMsgMiscExecGMReq> Parser => _parser;

	public ExecGmType GmType
	{
		get
		{
			return gmType_;
		}
		set
		{
			gmType_ = value;
		}
	}

	public RepeatedField<string> GmCmd => gmCmd_;

	public RoleDataCS SnapshootRoleData
	{
		get
		{
			return snapshootRoleData_;
		}
		set
		{
			snapshootRoleData_ = value;
		}
	}

	public CSMsgMiscExecGMReq()
	{
	}

	public CSMsgMiscExecGMReq(CSMsgMiscExecGMReq other)
		: this()
	{
		gmType_ = other.gmType_;
		gmCmd_ = other.gmCmd_.Clone();
		snapshootRoleData_ = ((other.snapshootRoleData_ != null) ? other.snapshootRoleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscExecGMReq Clone()
	{
		return new CSMsgMiscExecGMReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscExecGMReq);
	}

	public bool Equals(CSMsgMiscExecGMReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GmType != other.GmType)
		{
			return false;
		}
		if (!gmCmd_.Equals(other.gmCmd_))
		{
			return false;
		}
		if (!object.Equals(SnapshootRoleData, other.SnapshootRoleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GmType != ExecGmType.Cmd)
		{
			num ^= GmType.GetHashCode();
		}
		num ^= gmCmd_.GetHashCode();
		if (snapshootRoleData_ != null)
		{
			num ^= SnapshootRoleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GmType != ExecGmType.Cmd)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)GmType);
		}
		gmCmd_.WriteTo(output, _repeated_gmCmd_codec);
		if (snapshootRoleData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SnapshootRoleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GmType != ExecGmType.Cmd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GmType);
		}
		num += gmCmd_.CalculateSize(_repeated_gmCmd_codec);
		if (snapshootRoleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SnapshootRoleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscExecGMReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GmType != ExecGmType.Cmd)
		{
			GmType = other.GmType;
		}
		gmCmd_.Add(other.gmCmd_);
		if (other.snapshootRoleData_ != null)
		{
			if (snapshootRoleData_ == null)
			{
				SnapshootRoleData = new RoleDataCS();
			}
			SnapshootRoleData.MergeFrom(other.SnapshootRoleData);
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
				GmType = (ExecGmType)input.ReadEnum();
				break;
			case 18u:
				gmCmd_.AddEntriesFrom(input, _repeated_gmCmd_codec);
				break;
			case 26u:
				if (snapshootRoleData_ == null)
				{
					SnapshootRoleData = new RoleDataCS();
				}
				input.ReadMessage(SnapshootRoleData);
				break;
			}
		}
	}
}
