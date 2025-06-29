using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class GameSettingData : IMessage<GameSettingData>, IMessage, IEquatable<GameSettingData>, IDeepCloneable<GameSettingData>
{
	private static readonly MessageParser<GameSettingData> _parser = new MessageParser<GameSettingData>(() => new GameSettingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private YesNoType dmgNumShow_;

	private EHudShowType hudAutoShow_;

	private YesNoType lockSwitchTarget_;

	private YesNoType cameraShake_;

	private YesNoType skipAnimation_;

	private YesNoType subtitleShow_;

	private YesNoType subtitleRoleShow_;

	private ESubtitleFontSize subtitleFontSize_;

	private string culture_;

	private YesNoType manuallyToggleLoadingTips_;

	private ESubtitleColorClass subtitleColor_;

	private ESubtitleColorClass subtitleRoleColor_;

	private ESubtitleBGClass subtitleBg_;

	private YesNoType subtitleSoundDirection_;

	private YesNoType subtitleCc_;

	public static MessageParser<GameSettingData> Parser => _parser;

	public YesNoType DmgNumShow
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return dmgNumShow_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 1;
			dmgNumShow_ = value;
		}
	}

	public bool HasDmgNumShow => (_hasBits0 & 1) != 0;

	public EHudShowType HudAutoShow
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return hudAutoShow_;
			}
			return EHudShowType.AutoShow;
		}
		set
		{
			_hasBits0 |= 2;
			hudAutoShow_ = value;
		}
	}

	public bool HasHudAutoShow => (_hasBits0 & 2) != 0;

	public YesNoType LockSwitchTarget
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return lockSwitchTarget_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 4;
			lockSwitchTarget_ = value;
		}
	}

	public bool HasLockSwitchTarget => (_hasBits0 & 4) != 0;

	public YesNoType CameraShake
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return cameraShake_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 8;
			cameraShake_ = value;
		}
	}

	public bool HasCameraShake => (_hasBits0 & 8) != 0;

	public YesNoType SkipAnimation
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return skipAnimation_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 16;
			skipAnimation_ = value;
		}
	}

	public bool HasSkipAnimation => (_hasBits0 & 0x10) != 0;

	public YesNoType SubtitleShow
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return subtitleShow_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 32;
			subtitleShow_ = value;
		}
	}

	public bool HasSubtitleShow => (_hasBits0 & 0x20) != 0;

	public YesNoType SubtitleRoleShow
	{
		get
		{
			if ((_hasBits0 & 0x40) != 0)
			{
				return subtitleRoleShow_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 64;
			subtitleRoleShow_ = value;
		}
	}

	public bool HasSubtitleRoleShow => (_hasBits0 & 0x40) != 0;

	public ESubtitleFontSize SubtitleFontSize
	{
		get
		{
			if ((_hasBits0 & 0x80) != 0)
			{
				return subtitleFontSize_;
			}
			return ESubtitleFontSize.NormalSize;
		}
		set
		{
			_hasBits0 |= 128;
			subtitleFontSize_ = value;
		}
	}

	public bool HasSubtitleFontSize => (_hasBits0 & 0x80) != 0;

	public string Culture
	{
		get
		{
			return culture_ ?? "";
		}
		set
		{
			culture_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasCulture => culture_ != null;

	public YesNoType ManuallyToggleLoadingTips
	{
		get
		{
			if ((_hasBits0 & 0x100) != 0)
			{
				return manuallyToggleLoadingTips_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 256;
			manuallyToggleLoadingTips_ = value;
		}
	}

	public bool HasManuallyToggleLoadingTips => (_hasBits0 & 0x100) != 0;

	public ESubtitleColorClass SubtitleColor
	{
		get
		{
			if ((_hasBits0 & 0x200) != 0)
			{
				return subtitleColor_;
			}
			return ESubtitleColorClass.None;
		}
		set
		{
			_hasBits0 |= 512;
			subtitleColor_ = value;
		}
	}

	public bool HasSubtitleColor => (_hasBits0 & 0x200) != 0;

	public ESubtitleColorClass SubtitleRoleColor
	{
		get
		{
			if ((_hasBits0 & 0x400) != 0)
			{
				return subtitleRoleColor_;
			}
			return ESubtitleColorClass.None;
		}
		set
		{
			_hasBits0 |= 1024;
			subtitleRoleColor_ = value;
		}
	}

	public bool HasSubtitleRoleColor => (_hasBits0 & 0x400) != 0;

	public ESubtitleBGClass SubtitleBg
	{
		get
		{
			if ((_hasBits0 & 0x800) != 0)
			{
				return subtitleBg_;
			}
			return ESubtitleBGClass.None;
		}
		set
		{
			_hasBits0 |= 2048;
			subtitleBg_ = value;
		}
	}

	public bool HasSubtitleBg => (_hasBits0 & 0x800) != 0;

	public YesNoType SubtitleSoundDirection
	{
		get
		{
			if ((_hasBits0 & 0x1000) != 0)
			{
				return subtitleSoundDirection_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 4096;
			subtitleSoundDirection_ = value;
		}
	}

	public bool HasSubtitleSoundDirection => (_hasBits0 & 0x1000) != 0;

	public YesNoType SubtitleCc
	{
		get
		{
			if ((_hasBits0 & 0x2000) != 0)
			{
				return subtitleCc_;
			}
			return YesNoType.No;
		}
		set
		{
			_hasBits0 |= 8192;
			subtitleCc_ = value;
		}
	}

	public bool HasSubtitleCc => (_hasBits0 & 0x2000) != 0;

	public GameSettingData()
	{
	}

	public GameSettingData(GameSettingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		dmgNumShow_ = other.dmgNumShow_;
		hudAutoShow_ = other.hudAutoShow_;
		lockSwitchTarget_ = other.lockSwitchTarget_;
		cameraShake_ = other.cameraShake_;
		skipAnimation_ = other.skipAnimation_;
		subtitleShow_ = other.subtitleShow_;
		subtitleRoleShow_ = other.subtitleRoleShow_;
		subtitleFontSize_ = other.subtitleFontSize_;
		culture_ = other.culture_;
		manuallyToggleLoadingTips_ = other.manuallyToggleLoadingTips_;
		subtitleColor_ = other.subtitleColor_;
		subtitleRoleColor_ = other.subtitleRoleColor_;
		subtitleBg_ = other.subtitleBg_;
		subtitleSoundDirection_ = other.subtitleSoundDirection_;
		subtitleCc_ = other.subtitleCc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GameSettingData Clone()
	{
		return new GameSettingData(this);
	}

	public void ClearDmgNumShow()
	{
		_hasBits0 &= -2;
	}

	public void ClearHudAutoShow()
	{
		_hasBits0 &= -3;
	}

	public void ClearLockSwitchTarget()
	{
		_hasBits0 &= -5;
	}

	public void ClearCameraShake()
	{
		_hasBits0 &= -9;
	}

	public void ClearSkipAnimation()
	{
		_hasBits0 &= -17;
	}

	public void ClearSubtitleShow()
	{
		_hasBits0 &= -33;
	}

	public void ClearSubtitleRoleShow()
	{
		_hasBits0 &= -65;
	}

	public void ClearSubtitleFontSize()
	{
		_hasBits0 &= -129;
	}

	public void ClearCulture()
	{
		culture_ = null;
	}

	public void ClearManuallyToggleLoadingTips()
	{
		_hasBits0 &= -257;
	}

	public void ClearSubtitleColor()
	{
		_hasBits0 &= -513;
	}

	public void ClearSubtitleRoleColor()
	{
		_hasBits0 &= -1025;
	}

	public void ClearSubtitleBg()
	{
		_hasBits0 &= -2049;
	}

	public void ClearSubtitleSoundDirection()
	{
		_hasBits0 &= -4097;
	}

	public void ClearSubtitleCc()
	{
		_hasBits0 &= -8193;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GameSettingData);
	}

	public bool Equals(GameSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DmgNumShow != other.DmgNumShow)
		{
			return false;
		}
		if (HudAutoShow != other.HudAutoShow)
		{
			return false;
		}
		if (LockSwitchTarget != other.LockSwitchTarget)
		{
			return false;
		}
		if (CameraShake != other.CameraShake)
		{
			return false;
		}
		if (SkipAnimation != other.SkipAnimation)
		{
			return false;
		}
		if (SubtitleShow != other.SubtitleShow)
		{
			return false;
		}
		if (SubtitleRoleShow != other.SubtitleRoleShow)
		{
			return false;
		}
		if (SubtitleFontSize != other.SubtitleFontSize)
		{
			return false;
		}
		if (Culture != other.Culture)
		{
			return false;
		}
		if (ManuallyToggleLoadingTips != other.ManuallyToggleLoadingTips)
		{
			return false;
		}
		if (SubtitleColor != other.SubtitleColor)
		{
			return false;
		}
		if (SubtitleRoleColor != other.SubtitleRoleColor)
		{
			return false;
		}
		if (SubtitleBg != other.SubtitleBg)
		{
			return false;
		}
		if (SubtitleSoundDirection != other.SubtitleSoundDirection)
		{
			return false;
		}
		if (SubtitleCc != other.SubtitleCc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasDmgNumShow)
		{
			num ^= DmgNumShow.GetHashCode();
		}
		if (HasHudAutoShow)
		{
			num ^= HudAutoShow.GetHashCode();
		}
		if (HasLockSwitchTarget)
		{
			num ^= LockSwitchTarget.GetHashCode();
		}
		if (HasCameraShake)
		{
			num ^= CameraShake.GetHashCode();
		}
		if (HasSkipAnimation)
		{
			num ^= SkipAnimation.GetHashCode();
		}
		if (HasSubtitleShow)
		{
			num ^= SubtitleShow.GetHashCode();
		}
		if (HasSubtitleRoleShow)
		{
			num ^= SubtitleRoleShow.GetHashCode();
		}
		if (HasSubtitleFontSize)
		{
			num ^= SubtitleFontSize.GetHashCode();
		}
		if (HasCulture)
		{
			num ^= Culture.GetHashCode();
		}
		if (HasManuallyToggleLoadingTips)
		{
			num ^= ManuallyToggleLoadingTips.GetHashCode();
		}
		if (HasSubtitleColor)
		{
			num ^= SubtitleColor.GetHashCode();
		}
		if (HasSubtitleRoleColor)
		{
			num ^= SubtitleRoleColor.GetHashCode();
		}
		if (HasSubtitleBg)
		{
			num ^= SubtitleBg.GetHashCode();
		}
		if (HasSubtitleSoundDirection)
		{
			num ^= SubtitleSoundDirection.GetHashCode();
		}
		if (HasSubtitleCc)
		{
			num ^= SubtitleCc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasDmgNumShow)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)DmgNumShow);
		}
		if (HasHudAutoShow)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)HudAutoShow);
		}
		if (HasLockSwitchTarget)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LockSwitchTarget);
		}
		if (HasCameraShake)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)CameraShake);
		}
		if (HasSkipAnimation)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)SkipAnimation);
		}
		if (HasSubtitleShow)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)SubtitleShow);
		}
		if (HasSubtitleRoleShow)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)SubtitleRoleShow);
		}
		if (HasSubtitleFontSize)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)SubtitleFontSize);
		}
		if (HasCulture)
		{
			output.WriteRawTag(74);
			output.WriteString(Culture);
		}
		if (HasManuallyToggleLoadingTips)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)ManuallyToggleLoadingTips);
		}
		if (HasSubtitleColor)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)SubtitleColor);
		}
		if (HasSubtitleRoleColor)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)SubtitleRoleColor);
		}
		if (HasSubtitleBg)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)SubtitleBg);
		}
		if (HasSubtitleSoundDirection)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)SubtitleSoundDirection);
		}
		if (HasSubtitleCc)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)SubtitleCc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasDmgNumShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DmgNumShow);
		}
		if (HasHudAutoShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HudAutoShow);
		}
		if (HasLockSwitchTarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockSwitchTarget);
		}
		if (HasCameraShake)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CameraShake);
		}
		if (HasSkipAnimation)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkipAnimation);
		}
		if (HasSubtitleShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleShow);
		}
		if (HasSubtitleRoleShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleRoleShow);
		}
		if (HasSubtitleFontSize)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleFontSize);
		}
		if (HasCulture)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Culture);
		}
		if (HasManuallyToggleLoadingTips)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ManuallyToggleLoadingTips);
		}
		if (HasSubtitleColor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleColor);
		}
		if (HasSubtitleRoleColor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleRoleColor);
		}
		if (HasSubtitleBg)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleBg);
		}
		if (HasSubtitleSoundDirection)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleSoundDirection);
		}
		if (HasSubtitleCc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SubtitleCc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GameSettingData other)
	{
		if (other != null)
		{
			if (other.HasDmgNumShow)
			{
				DmgNumShow = other.DmgNumShow;
			}
			if (other.HasHudAutoShow)
			{
				HudAutoShow = other.HudAutoShow;
			}
			if (other.HasLockSwitchTarget)
			{
				LockSwitchTarget = other.LockSwitchTarget;
			}
			if (other.HasCameraShake)
			{
				CameraShake = other.CameraShake;
			}
			if (other.HasSkipAnimation)
			{
				SkipAnimation = other.SkipAnimation;
			}
			if (other.HasSubtitleShow)
			{
				SubtitleShow = other.SubtitleShow;
			}
			if (other.HasSubtitleRoleShow)
			{
				SubtitleRoleShow = other.SubtitleRoleShow;
			}
			if (other.HasSubtitleFontSize)
			{
				SubtitleFontSize = other.SubtitleFontSize;
			}
			if (other.HasCulture)
			{
				Culture = other.Culture;
			}
			if (other.HasManuallyToggleLoadingTips)
			{
				ManuallyToggleLoadingTips = other.ManuallyToggleLoadingTips;
			}
			if (other.HasSubtitleColor)
			{
				SubtitleColor = other.SubtitleColor;
			}
			if (other.HasSubtitleRoleColor)
			{
				SubtitleRoleColor = other.SubtitleRoleColor;
			}
			if (other.HasSubtitleBg)
			{
				SubtitleBg = other.SubtitleBg;
			}
			if (other.HasSubtitleSoundDirection)
			{
				SubtitleSoundDirection = other.SubtitleSoundDirection;
			}
			if (other.HasSubtitleCc)
			{
				SubtitleCc = other.SubtitleCc;
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
				DmgNumShow = (YesNoType)input.ReadEnum();
				break;
			case 16u:
				HudAutoShow = (EHudShowType)input.ReadEnum();
				break;
			case 24u:
				LockSwitchTarget = (YesNoType)input.ReadEnum();
				break;
			case 32u:
				CameraShake = (YesNoType)input.ReadEnum();
				break;
			case 40u:
				SkipAnimation = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				SubtitleShow = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				SubtitleRoleShow = (YesNoType)input.ReadEnum();
				break;
			case 64u:
				SubtitleFontSize = (ESubtitleFontSize)input.ReadEnum();
				break;
			case 74u:
				Culture = input.ReadString();
				break;
			case 80u:
				ManuallyToggleLoadingTips = (YesNoType)input.ReadEnum();
				break;
			case 88u:
				SubtitleColor = (ESubtitleColorClass)input.ReadEnum();
				break;
			case 96u:
				SubtitleRoleColor = (ESubtitleColorClass)input.ReadEnum();
				break;
			case 104u:
				SubtitleBg = (ESubtitleBGClass)input.ReadEnum();
				break;
			case 112u:
				SubtitleSoundDirection = (YesNoType)input.ReadEnum();
				break;
			case 120u:
				SubtitleCc = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
