using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_ManagedSceneObj : IMessage<CalliopeCustom_ManagedSceneObj>, IMessage, IEquatable<CalliopeCustom_ManagedSceneObj>, IDeepCloneable<CalliopeCustom_ManagedSceneObj>
{
	private static readonly MessageParser<CalliopeCustom_ManagedSceneObj> _parser = new MessageParser<CalliopeCustom_ManagedSceneObj>(() => new CalliopeCustom_ManagedSceneObj());

	private UnknownFieldSet _unknownFields;

	private ManagedSceneObjType objType_;

	private string objGuid_ = "";

	private int defaultState_;

	private int managePolice_;

	public static MessageParser<CalliopeCustom_ManagedSceneObj> Parser => _parser;

	public ManagedSceneObjType ObjType
	{
		get
		{
			return objType_;
		}
		set
		{
			objType_ = value;
		}
	}

	public string ObjGuid
	{
		get
		{
			return objGuid_;
		}
		set
		{
			objGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DefaultState
	{
		get
		{
			return defaultState_;
		}
		set
		{
			defaultState_ = value;
		}
	}

	public int ManagePolice
	{
		get
		{
			return managePolice_;
		}
		set
		{
			managePolice_ = value;
		}
	}

	public CalliopeCustom_ManagedSceneObj()
	{
	}

	public CalliopeCustom_ManagedSceneObj(CalliopeCustom_ManagedSceneObj other)
		: this()
	{
		objType_ = other.objType_;
		objGuid_ = other.objGuid_;
		defaultState_ = other.defaultState_;
		managePolice_ = other.managePolice_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ManagedSceneObj Clone()
	{
		return new CalliopeCustom_ManagedSceneObj(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ManagedSceneObj);
	}

	public bool Equals(CalliopeCustom_ManagedSceneObj other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObjType != other.ObjType)
		{
			return false;
		}
		if (ObjGuid != other.ObjGuid)
		{
			return false;
		}
		if (DefaultState != other.DefaultState)
		{
			return false;
		}
		if (ManagePolice != other.ManagePolice)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObjType != ManagedSceneObjType.None)
		{
			num ^= ObjType.GetHashCode();
		}
		if (ObjGuid.Length != 0)
		{
			num ^= ObjGuid.GetHashCode();
		}
		if (DefaultState != 0)
		{
			num ^= DefaultState.GetHashCode();
		}
		if (ManagePolice != 0)
		{
			num ^= ManagePolice.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObjType != ManagedSceneObjType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ObjType);
		}
		if (ObjGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ObjGuid);
		}
		if (DefaultState != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DefaultState);
		}
		if (ManagePolice != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ManagePolice);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObjType != ManagedSceneObjType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ObjType);
		}
		if (ObjGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObjGuid);
		}
		if (DefaultState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultState);
		}
		if (ManagePolice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ManagePolice);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ManagedSceneObj other)
	{
		if (other != null)
		{
			if (other.ObjType != ManagedSceneObjType.None)
			{
				ObjType = other.ObjType;
			}
			if (other.ObjGuid.Length != 0)
			{
				ObjGuid = other.ObjGuid;
			}
			if (other.DefaultState != 0)
			{
				DefaultState = other.DefaultState;
			}
			if (other.ManagePolice != 0)
			{
				ManagePolice = other.ManagePolice;
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
				ObjType = (ManagedSceneObjType)input.ReadEnum();
				break;
			case 18u:
				ObjGuid = input.ReadString();
				break;
			case 24u:
				DefaultState = input.ReadInt32();
				break;
			case 32u:
				ManagePolice = input.ReadInt32();
				break;
			}
		}
	}
}
