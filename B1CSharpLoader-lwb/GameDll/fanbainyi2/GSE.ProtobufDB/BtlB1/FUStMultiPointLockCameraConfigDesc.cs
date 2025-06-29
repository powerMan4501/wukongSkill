using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStMultiPointLockCameraConfigDesc : IMessage<FUStMultiPointLockCameraConfigDesc>, IMessage, IEquatable<FUStMultiPointLockCameraConfigDesc>, IDeepCloneable<FUStMultiPointLockCameraConfigDesc>
{
	private static readonly MessageParser<FUStMultiPointLockCameraConfigDesc> _parser = new MessageParser<FUStMultiPointLockCameraConfigDesc>(() => new FUStMultiPointLockCameraConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int lockGroupID_;

	private string lockSocket_ = "";

	private int cameraID_;

	private string pelvisSocket_ = "";

	private string rootSocket_ = "";

	private string soulFocusSocket_ = "";

	private string soulFocusZSocket_ = "";

	public static MessageParser<FUStMultiPointLockCameraConfigDesc> Parser => _parser;

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

	public int LockGroupID
	{
		get
		{
			return lockGroupID_;
		}
		set
		{
			lockGroupID_ = value;
		}
	}

	public string LockSocket
	{
		get
		{
			return lockSocket_;
		}
		set
		{
			lockSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CameraID
	{
		get
		{
			return cameraID_;
		}
		set
		{
			cameraID_ = value;
		}
	}

	public string PelvisSocket
	{
		get
		{
			return pelvisSocket_;
		}
		set
		{
			pelvisSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RootSocket
	{
		get
		{
			return rootSocket_;
		}
		set
		{
			rootSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SoulFocusSocket
	{
		get
		{
			return soulFocusSocket_;
		}
		set
		{
			soulFocusSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SoulFocusZSocket
	{
		get
		{
			return soulFocusZSocket_;
		}
		set
		{
			soulFocusZSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStMultiPointLockCameraConfigDesc()
	{
	}

	public FUStMultiPointLockCameraConfigDesc(FUStMultiPointLockCameraConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		lockGroupID_ = other.lockGroupID_;
		lockSocket_ = other.lockSocket_;
		cameraID_ = other.cameraID_;
		pelvisSocket_ = other.pelvisSocket_;
		rootSocket_ = other.rootSocket_;
		soulFocusSocket_ = other.soulFocusSocket_;
		soulFocusZSocket_ = other.soulFocusZSocket_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMultiPointLockCameraConfigDesc Clone()
	{
		return new FUStMultiPointLockCameraConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMultiPointLockCameraConfigDesc);
	}

	public bool Equals(FUStMultiPointLockCameraConfigDesc other)
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
		if (LockGroupID != other.LockGroupID)
		{
			return false;
		}
		if (LockSocket != other.LockSocket)
		{
			return false;
		}
		if (CameraID != other.CameraID)
		{
			return false;
		}
		if (PelvisSocket != other.PelvisSocket)
		{
			return false;
		}
		if (RootSocket != other.RootSocket)
		{
			return false;
		}
		if (SoulFocusSocket != other.SoulFocusSocket)
		{
			return false;
		}
		if (SoulFocusZSocket != other.SoulFocusZSocket)
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
		if (LockGroupID != 0)
		{
			num ^= LockGroupID.GetHashCode();
		}
		if (LockSocket.Length != 0)
		{
			num ^= LockSocket.GetHashCode();
		}
		if (CameraID != 0)
		{
			num ^= CameraID.GetHashCode();
		}
		if (PelvisSocket.Length != 0)
		{
			num ^= PelvisSocket.GetHashCode();
		}
		if (RootSocket.Length != 0)
		{
			num ^= RootSocket.GetHashCode();
		}
		if (SoulFocusSocket.Length != 0)
		{
			num ^= SoulFocusSocket.GetHashCode();
		}
		if (SoulFocusZSocket.Length != 0)
		{
			num ^= SoulFocusZSocket.GetHashCode();
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
		if (LockGroupID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LockGroupID);
		}
		if (LockSocket.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(LockSocket);
		}
		if (CameraID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CameraID);
		}
		if (PelvisSocket.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PelvisSocket);
		}
		if (RootSocket.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(RootSocket);
		}
		if (SoulFocusSocket.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SoulFocusSocket);
		}
		if (SoulFocusZSocket.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(SoulFocusZSocket);
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
		if (LockGroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockGroupID);
		}
		if (LockSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LockSocket);
		}
		if (CameraID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraID);
		}
		if (PelvisSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PelvisSocket);
		}
		if (RootSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RootSocket);
		}
		if (SoulFocusSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SoulFocusSocket);
		}
		if (SoulFocusZSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SoulFocusZSocket);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMultiPointLockCameraConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.LockGroupID != 0)
			{
				LockGroupID = other.LockGroupID;
			}
			if (other.LockSocket.Length != 0)
			{
				LockSocket = other.LockSocket;
			}
			if (other.CameraID != 0)
			{
				CameraID = other.CameraID;
			}
			if (other.PelvisSocket.Length != 0)
			{
				PelvisSocket = other.PelvisSocket;
			}
			if (other.RootSocket.Length != 0)
			{
				RootSocket = other.RootSocket;
			}
			if (other.SoulFocusSocket.Length != 0)
			{
				SoulFocusSocket = other.SoulFocusSocket;
			}
			if (other.SoulFocusZSocket.Length != 0)
			{
				SoulFocusZSocket = other.SoulFocusZSocket;
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
			case 16u:
				LockGroupID = input.ReadInt32();
				break;
			case 26u:
				LockSocket = input.ReadString();
				break;
			case 32u:
				CameraID = input.ReadInt32();
				break;
			case 42u:
				PelvisSocket = input.ReadString();
				break;
			case 50u:
				RootSocket = input.ReadString();
				break;
			case 58u:
				SoulFocusSocket = input.ReadString();
				break;
			case 66u:
				SoulFocusZSocket = input.ReadString();
				break;
			}
		}
	}
}
