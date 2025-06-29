using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FAbnormalDispModifyInfo : IMessage<FAbnormalDispModifyInfo>, IMessage, IEquatable<FAbnormalDispModifyInfo>, IDeepCloneable<FAbnormalDispModifyInfo>
{
	private static readonly MessageParser<FAbnormalDispModifyInfo> _parser = new MessageParser<FAbnormalDispModifyInfo>(() => new FAbnormalDispModifyInfo());

	private UnknownFieldSet _unknownFields;

	private EAbnormalDispModifyType mTAccProcess_;

	private string dBCAccProcess_ = "";

	private EAbnormalDispModifyType mTFinalBegin_;

	private string dBCFinalBegin_ = "";

	private EAbnormalDispModifyType mTFinalLoop_;

	private string dBCFinalLoop_ = "";

	private EAbnormalDispModifyType mTHitExt_;

	private string dBCHitExt_ = "";

	private EAbnormalDispModifyType mTDeadKeep_;

	private string dBCDeadKeep_ = "";

	private EAbnormalDispModifyType mTDeadDisappear_;

	private string dBCDeadDisappear_ = "";

	public static MessageParser<FAbnormalDispModifyInfo> Parser => _parser;

	public EAbnormalDispModifyType MTAccProcess
	{
		get
		{
			return mTAccProcess_;
		}
		set
		{
			mTAccProcess_ = value;
		}
	}

	public string DBCAccProcess
	{
		get
		{
			return dBCAccProcess_;
		}
		set
		{
			dBCAccProcess_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTFinalBegin
	{
		get
		{
			return mTFinalBegin_;
		}
		set
		{
			mTFinalBegin_ = value;
		}
	}

	public string DBCFinalBegin
	{
		get
		{
			return dBCFinalBegin_;
		}
		set
		{
			dBCFinalBegin_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTFinalLoop
	{
		get
		{
			return mTFinalLoop_;
		}
		set
		{
			mTFinalLoop_ = value;
		}
	}

	public string DBCFinalLoop
	{
		get
		{
			return dBCFinalLoop_;
		}
		set
		{
			dBCFinalLoop_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTHitExt
	{
		get
		{
			return mTHitExt_;
		}
		set
		{
			mTHitExt_ = value;
		}
	}

	public string DBCHitExt
	{
		get
		{
			return dBCHitExt_;
		}
		set
		{
			dBCHitExt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTDeadKeep
	{
		get
		{
			return mTDeadKeep_;
		}
		set
		{
			mTDeadKeep_ = value;
		}
	}

	public string DBCDeadKeep
	{
		get
		{
			return dBCDeadKeep_;
		}
		set
		{
			dBCDeadKeep_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTDeadDisappear
	{
		get
		{
			return mTDeadDisappear_;
		}
		set
		{
			mTDeadDisappear_ = value;
		}
	}

	public string DBCDeadDisappear
	{
		get
		{
			return dBCDeadDisappear_;
		}
		set
		{
			dBCDeadDisappear_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FAbnormalDispModifyInfo()
	{
	}

	public FAbnormalDispModifyInfo(FAbnormalDispModifyInfo other)
		: this()
	{
		mTAccProcess_ = other.mTAccProcess_;
		dBCAccProcess_ = other.dBCAccProcess_;
		mTFinalBegin_ = other.mTFinalBegin_;
		dBCFinalBegin_ = other.dBCFinalBegin_;
		mTFinalLoop_ = other.mTFinalLoop_;
		dBCFinalLoop_ = other.dBCFinalLoop_;
		mTHitExt_ = other.mTHitExt_;
		dBCHitExt_ = other.dBCHitExt_;
		mTDeadKeep_ = other.mTDeadKeep_;
		dBCDeadKeep_ = other.dBCDeadKeep_;
		mTDeadDisappear_ = other.mTDeadDisappear_;
		dBCDeadDisappear_ = other.dBCDeadDisappear_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FAbnormalDispModifyInfo Clone()
	{
		return new FAbnormalDispModifyInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FAbnormalDispModifyInfo);
	}

	public bool Equals(FAbnormalDispModifyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MTAccProcess != other.MTAccProcess)
		{
			return false;
		}
		if (DBCAccProcess != other.DBCAccProcess)
		{
			return false;
		}
		if (MTFinalBegin != other.MTFinalBegin)
		{
			return false;
		}
		if (DBCFinalBegin != other.DBCFinalBegin)
		{
			return false;
		}
		if (MTFinalLoop != other.MTFinalLoop)
		{
			return false;
		}
		if (DBCFinalLoop != other.DBCFinalLoop)
		{
			return false;
		}
		if (MTHitExt != other.MTHitExt)
		{
			return false;
		}
		if (DBCHitExt != other.DBCHitExt)
		{
			return false;
		}
		if (MTDeadKeep != other.MTDeadKeep)
		{
			return false;
		}
		if (DBCDeadKeep != other.DBCDeadKeep)
		{
			return false;
		}
		if (MTDeadDisappear != other.MTDeadDisappear)
		{
			return false;
		}
		if (DBCDeadDisappear != other.DBCDeadDisappear)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MTAccProcess != EAbnormalDispModifyType.None)
		{
			num ^= MTAccProcess.GetHashCode();
		}
		if (DBCAccProcess.Length != 0)
		{
			num ^= DBCAccProcess.GetHashCode();
		}
		if (MTFinalBegin != EAbnormalDispModifyType.None)
		{
			num ^= MTFinalBegin.GetHashCode();
		}
		if (DBCFinalBegin.Length != 0)
		{
			num ^= DBCFinalBegin.GetHashCode();
		}
		if (MTFinalLoop != EAbnormalDispModifyType.None)
		{
			num ^= MTFinalLoop.GetHashCode();
		}
		if (DBCFinalLoop.Length != 0)
		{
			num ^= DBCFinalLoop.GetHashCode();
		}
		if (MTHitExt != EAbnormalDispModifyType.None)
		{
			num ^= MTHitExt.GetHashCode();
		}
		if (DBCHitExt.Length != 0)
		{
			num ^= DBCHitExt.GetHashCode();
		}
		if (MTDeadKeep != EAbnormalDispModifyType.None)
		{
			num ^= MTDeadKeep.GetHashCode();
		}
		if (DBCDeadKeep.Length != 0)
		{
			num ^= DBCDeadKeep.GetHashCode();
		}
		if (MTDeadDisappear != EAbnormalDispModifyType.None)
		{
			num ^= MTDeadDisappear.GetHashCode();
		}
		if (DBCDeadDisappear.Length != 0)
		{
			num ^= DBCDeadDisappear.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MTAccProcess != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MTAccProcess);
		}
		if (DBCAccProcess.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DBCAccProcess);
		}
		if (MTFinalBegin != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)MTFinalBegin);
		}
		if (DBCFinalBegin.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DBCFinalBegin);
		}
		if (MTFinalLoop != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)MTFinalLoop);
		}
		if (DBCFinalLoop.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DBCFinalLoop);
		}
		if (MTHitExt != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)MTHitExt);
		}
		if (DBCHitExt.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DBCHitExt);
		}
		if (MTDeadKeep != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MTDeadKeep);
		}
		if (DBCDeadKeep.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DBCDeadKeep);
		}
		if (MTDeadDisappear != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)MTDeadDisappear);
		}
		if (DBCDeadDisappear.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(DBCDeadDisappear);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MTAccProcess != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTAccProcess);
		}
		if (DBCAccProcess.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCAccProcess);
		}
		if (MTFinalBegin != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTFinalBegin);
		}
		if (DBCFinalBegin.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCFinalBegin);
		}
		if (MTFinalLoop != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTFinalLoop);
		}
		if (DBCFinalLoop.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCFinalLoop);
		}
		if (MTHitExt != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTHitExt);
		}
		if (DBCHitExt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCHitExt);
		}
		if (MTDeadKeep != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTDeadKeep);
		}
		if (DBCDeadKeep.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCDeadKeep);
		}
		if (MTDeadDisappear != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTDeadDisappear);
		}
		if (DBCDeadDisappear.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCDeadDisappear);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FAbnormalDispModifyInfo other)
	{
		if (other != null)
		{
			if (other.MTAccProcess != EAbnormalDispModifyType.None)
			{
				MTAccProcess = other.MTAccProcess;
			}
			if (other.DBCAccProcess.Length != 0)
			{
				DBCAccProcess = other.DBCAccProcess;
			}
			if (other.MTFinalBegin != EAbnormalDispModifyType.None)
			{
				MTFinalBegin = other.MTFinalBegin;
			}
			if (other.DBCFinalBegin.Length != 0)
			{
				DBCFinalBegin = other.DBCFinalBegin;
			}
			if (other.MTFinalLoop != EAbnormalDispModifyType.None)
			{
				MTFinalLoop = other.MTFinalLoop;
			}
			if (other.DBCFinalLoop.Length != 0)
			{
				DBCFinalLoop = other.DBCFinalLoop;
			}
			if (other.MTHitExt != EAbnormalDispModifyType.None)
			{
				MTHitExt = other.MTHitExt;
			}
			if (other.DBCHitExt.Length != 0)
			{
				DBCHitExt = other.DBCHitExt;
			}
			if (other.MTDeadKeep != EAbnormalDispModifyType.None)
			{
				MTDeadKeep = other.MTDeadKeep;
			}
			if (other.DBCDeadKeep.Length != 0)
			{
				DBCDeadKeep = other.DBCDeadKeep;
			}
			if (other.MTDeadDisappear != EAbnormalDispModifyType.None)
			{
				MTDeadDisappear = other.MTDeadDisappear;
			}
			if (other.DBCDeadDisappear.Length != 0)
			{
				DBCDeadDisappear = other.DBCDeadDisappear;
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
				MTAccProcess = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 18u:
				DBCAccProcess = input.ReadString();
				break;
			case 24u:
				MTFinalBegin = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 34u:
				DBCFinalBegin = input.ReadString();
				break;
			case 40u:
				MTFinalLoop = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 50u:
				DBCFinalLoop = input.ReadString();
				break;
			case 56u:
				MTHitExt = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 66u:
				DBCHitExt = input.ReadString();
				break;
			case 72u:
				MTDeadKeep = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 82u:
				DBCDeadKeep = input.ReadString();
				break;
			case 88u:
				MTDeadDisappear = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 98u:
				DBCDeadDisappear = input.ReadString();
				break;
			}
		}
	}
}
