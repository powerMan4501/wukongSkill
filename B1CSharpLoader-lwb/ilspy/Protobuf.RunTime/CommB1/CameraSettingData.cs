using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CameraSettingData : IMessage<CameraSettingData>, IMessage, IEquatable<CameraSettingData>, IDeepCloneable<CameraSettingData>
{
	private static readonly MessageParser<CameraSettingData> _parser = new MessageParser<CameraSettingData>(() => new CameraSettingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int horRotateSpeed_;

	private int verRotateSpeed_;

	private int reverseHorControl_;

	private int reverseVerControl_;

	private int mouseHorRotateSpeed_;

	private int mouseVerRotateSpeed_;

	private int mouseReverseHorControl_;

	private int mouseReverseVerControl_;

	public static MessageParser<CameraSettingData> Parser => _parser;

	public int HorRotateSpeed
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return horRotateSpeed_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			horRotateSpeed_ = value;
		}
	}

	public bool HasHorRotateSpeed => (_hasBits0 & 1) != 0;

	public int VerRotateSpeed
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return verRotateSpeed_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			verRotateSpeed_ = value;
		}
	}

	public bool HasVerRotateSpeed => (_hasBits0 & 2) != 0;

	public int ReverseHorControl
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return reverseHorControl_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			reverseHorControl_ = value;
		}
	}

	public bool HasReverseHorControl => (_hasBits0 & 4) != 0;

	public int ReverseVerControl
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return reverseVerControl_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			reverseVerControl_ = value;
		}
	}

	public bool HasReverseVerControl => (_hasBits0 & 8) != 0;

	public int MouseHorRotateSpeed
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return mouseHorRotateSpeed_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			mouseHorRotateSpeed_ = value;
		}
	}

	public bool HasMouseHorRotateSpeed => (_hasBits0 & 0x10) != 0;

	public int MouseVerRotateSpeed
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return mouseVerRotateSpeed_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 32;
			mouseVerRotateSpeed_ = value;
		}
	}

	public bool HasMouseVerRotateSpeed => (_hasBits0 & 0x20) != 0;

	public int MouseReverseHorControl
	{
		get
		{
			if ((_hasBits0 & 0x40) != 0)
			{
				return mouseReverseHorControl_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 64;
			mouseReverseHorControl_ = value;
		}
	}

	public bool HasMouseReverseHorControl => (_hasBits0 & 0x40) != 0;

	public int MouseReverseVerControl
	{
		get
		{
			if ((_hasBits0 & 0x80) != 0)
			{
				return mouseReverseVerControl_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 128;
			mouseReverseVerControl_ = value;
		}
	}

	public bool HasMouseReverseVerControl => (_hasBits0 & 0x80) != 0;

	public CameraSettingData()
	{
	}

	public CameraSettingData(CameraSettingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		horRotateSpeed_ = other.horRotateSpeed_;
		verRotateSpeed_ = other.verRotateSpeed_;
		reverseHorControl_ = other.reverseHorControl_;
		reverseVerControl_ = other.reverseVerControl_;
		mouseHorRotateSpeed_ = other.mouseHorRotateSpeed_;
		mouseVerRotateSpeed_ = other.mouseVerRotateSpeed_;
		mouseReverseHorControl_ = other.mouseReverseHorControl_;
		mouseReverseVerControl_ = other.mouseReverseVerControl_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CameraSettingData Clone()
	{
		return new CameraSettingData(this);
	}

	public void ClearHorRotateSpeed()
	{
		_hasBits0 &= -2;
	}

	public void ClearVerRotateSpeed()
	{
		_hasBits0 &= -3;
	}

	public void ClearReverseHorControl()
	{
		_hasBits0 &= -5;
	}

	public void ClearReverseVerControl()
	{
		_hasBits0 &= -9;
	}

	public void ClearMouseHorRotateSpeed()
	{
		_hasBits0 &= -17;
	}

	public void ClearMouseVerRotateSpeed()
	{
		_hasBits0 &= -33;
	}

	public void ClearMouseReverseHorControl()
	{
		_hasBits0 &= -65;
	}

	public void ClearMouseReverseVerControl()
	{
		_hasBits0 &= -129;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CameraSettingData);
	}

	public bool Equals(CameraSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HorRotateSpeed != other.HorRotateSpeed)
		{
			return false;
		}
		if (VerRotateSpeed != other.VerRotateSpeed)
		{
			return false;
		}
		if (ReverseHorControl != other.ReverseHorControl)
		{
			return false;
		}
		if (ReverseVerControl != other.ReverseVerControl)
		{
			return false;
		}
		if (MouseHorRotateSpeed != other.MouseHorRotateSpeed)
		{
			return false;
		}
		if (MouseVerRotateSpeed != other.MouseVerRotateSpeed)
		{
			return false;
		}
		if (MouseReverseHorControl != other.MouseReverseHorControl)
		{
			return false;
		}
		if (MouseReverseVerControl != other.MouseReverseVerControl)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasHorRotateSpeed)
		{
			num ^= HorRotateSpeed.GetHashCode();
		}
		if (HasVerRotateSpeed)
		{
			num ^= VerRotateSpeed.GetHashCode();
		}
		if (HasReverseHorControl)
		{
			num ^= ReverseHorControl.GetHashCode();
		}
		if (HasReverseVerControl)
		{
			num ^= ReverseVerControl.GetHashCode();
		}
		if (HasMouseHorRotateSpeed)
		{
			num ^= MouseHorRotateSpeed.GetHashCode();
		}
		if (HasMouseVerRotateSpeed)
		{
			num ^= MouseVerRotateSpeed.GetHashCode();
		}
		if (HasMouseReverseHorControl)
		{
			num ^= MouseReverseHorControl.GetHashCode();
		}
		if (HasMouseReverseVerControl)
		{
			num ^= MouseReverseVerControl.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasHorRotateSpeed)
		{
			output.WriteRawTag(8);
			output.WriteInt32(HorRotateSpeed);
		}
		if (HasVerRotateSpeed)
		{
			output.WriteRawTag(16);
			output.WriteInt32(VerRotateSpeed);
		}
		if (HasReverseHorControl)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ReverseHorControl);
		}
		if (HasReverseVerControl)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ReverseVerControl);
		}
		if (HasMouseHorRotateSpeed)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MouseHorRotateSpeed);
		}
		if (HasMouseVerRotateSpeed)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MouseVerRotateSpeed);
		}
		if (HasMouseReverseHorControl)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MouseReverseHorControl);
		}
		if (HasMouseReverseVerControl)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MouseReverseVerControl);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasHorRotateSpeed)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HorRotateSpeed);
		}
		if (HasVerRotateSpeed)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VerRotateSpeed);
		}
		if (HasReverseHorControl)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReverseHorControl);
		}
		if (HasReverseVerControl)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReverseVerControl);
		}
		if (HasMouseHorRotateSpeed)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MouseHorRotateSpeed);
		}
		if (HasMouseVerRotateSpeed)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MouseVerRotateSpeed);
		}
		if (HasMouseReverseHorControl)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MouseReverseHorControl);
		}
		if (HasMouseReverseVerControl)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MouseReverseVerControl);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CameraSettingData other)
	{
		if (other != null)
		{
			if (other.HasHorRotateSpeed)
			{
				HorRotateSpeed = other.HorRotateSpeed;
			}
			if (other.HasVerRotateSpeed)
			{
				VerRotateSpeed = other.VerRotateSpeed;
			}
			if (other.HasReverseHorControl)
			{
				ReverseHorControl = other.ReverseHorControl;
			}
			if (other.HasReverseVerControl)
			{
				ReverseVerControl = other.ReverseVerControl;
			}
			if (other.HasMouseHorRotateSpeed)
			{
				MouseHorRotateSpeed = other.MouseHorRotateSpeed;
			}
			if (other.HasMouseVerRotateSpeed)
			{
				MouseVerRotateSpeed = other.MouseVerRotateSpeed;
			}
			if (other.HasMouseReverseHorControl)
			{
				MouseReverseHorControl = other.MouseReverseHorControl;
			}
			if (other.HasMouseReverseVerControl)
			{
				MouseReverseVerControl = other.MouseReverseVerControl;
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
				HorRotateSpeed = input.ReadInt32();
				break;
			case 16u:
				VerRotateSpeed = input.ReadInt32();
				break;
			case 24u:
				ReverseHorControl = input.ReadInt32();
				break;
			case 32u:
				ReverseVerControl = input.ReadInt32();
				break;
			case 40u:
				MouseHorRotateSpeed = input.ReadInt32();
				break;
			case 48u:
				MouseVerRotateSpeed = input.ReadInt32();
				break;
			case 56u:
				MouseReverseHorControl = input.ReadInt32();
				break;
			case 64u:
				MouseReverseVerControl = input.ReadInt32();
				break;
			}
		}
	}
}
