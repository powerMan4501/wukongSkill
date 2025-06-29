using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig")]
public class BGWDataAsset_TakePhotoSystemConfig : UBGWDataAsset
{
	private static bool IsKeepLocalMove_IsValid;

	private static int IsKeepLocalMove_Offset;

	private static FFieldAddress IsKeepLocalMove_PropertyAddress;

	private static bool CameraMoveableDistance_IsValid;

	private static int CameraMoveableDistance_Offset;

	private static bool CameraMoveableHeight_IsValid;

	private static int CameraMoveableHeight_Offset;

	private static bool MoveAccelerationFactor_IsValid;

	private static int MoveAccelerationFactor_Offset;

	private static bool MoveSpeedFactor_IsValid;

	private static int MoveSpeedFactor_Offset;

	private static bool MouseFixedResistance_IsValid;

	private static int MouseFixedResistance_Offset;

	private static bool IsTurnImmediately_IsValid;

	private static int IsTurnImmediately_Offset;

	private static FFieldAddress IsTurnImmediately_PropertyAddress;

	private static bool MouseYawRotationFactor_IsValid;

	private static int MouseYawRotationFactor_Offset;

	private static bool MousePitchRotationFactor_IsValid;

	private static int MousePitchRotationFactor_Offset;

	private static bool RotateSpeed_LR_IsValid;

	private static int RotateSpeed_LR_Offset;

	private static bool RotateSpeed_UD_IsValid;

	private static int RotateSpeed_UD_Offset;

	private static bool PhysicsAssetCheckRange_IsValid;

	private static int PhysicsAssetCheckRange_Offset;

	private static bool FilterList_IsValid;

	private static int FilterList_Offset;

	private static FFieldAddress FilterList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTPModeFilterInfo> FilterList_Marshaler;

	private static bool StickerImageList_IsValid;

	private static int StickerImageList_Offset;

	private static FFieldAddress StickerImageList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTPModeStickerImage> StickerImageList_Marshaler;

	private static bool FrameList_IsValid;

	private static int FrameList_Offset;

	private static FFieldAddress FrameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTPModeFrame> FrameList_Marshaler;

	private static bool ConfigTabTextureInfo_IsValid;

	private static int ConfigTabTextureInfo_Offset;

	private static FFieldAddress ConfigTabTextureInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<UTexture2D> ConfigTabTextureInfo_Marshaler;

	private static bool EnterEnhancedTime_IsValid;

	private static int EnterEnhancedTime_Offset;

	private static bool ShortcutInputAction_IsValid;

	private static int ShortcutInputAction_Offset;

	private static bool InvalidTransformingResIDList_IsValid;

	private static int InvalidTransformingResIDList_Offset;

	private static FFieldAddress InvalidTransformingResIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> InvalidTransformingResIDList_Marshaler;

	private static bool TakePhotoActor_BP_IsValid;

	private static int TakePhotoActor_BP_Offset;

	[Category("相机移动")]
	[DisplayName("是否完全以自身轴运动")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsKeepLocalMove")]
	public bool IsKeepLocalMove
	{
		get
		{
			CheckDestroyed();
			if (!IsKeepLocalMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsKeepLocalMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsKeepLocalMove_Offset), 0, IsKeepLocalMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsKeepLocalMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsKeepLocalMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsKeepLocalMove_Offset), 0, IsKeepLocalMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("相机可移动距离")]
	[Category("相机移动")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableDistance")]
	public float CameraMoveableDistance
	{
		get
		{
			CheckDestroyed();
			if (!CameraMoveableDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraMoveableDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraMoveableDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraMoveableDistance_Offset), value);
			}
		}
	}

	[Category("相机移动")]
	[DisplayName("相机可移动高度")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableHeight")]
	public float CameraMoveableHeight
	{
		get
		{
			CheckDestroyed();
			if (!CameraMoveableHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraMoveableHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraMoveableHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:CameraMoveableHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraMoveableHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移动加速度因子")]
	[Category("相机移动")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveAccelerationFactor")]
	public FVector MoveAccelerationFactor
	{
		get
		{
			CheckDestroyed();
			if (!MoveAccelerationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveAccelerationFactor");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MoveAccelerationFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveAccelerationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveAccelerationFactor");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MoveAccelerationFactor_Offset), value);
			}
		}
	}

	[DisplayName("移动速度因子")]
	[BlueprintReadWrite]
	[Category("相机移动")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveSpeedFactor")]
	public FVector MoveSpeedFactor
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeedFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveSpeedFactor");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, MoveSpeedFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeedFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MoveSpeedFactor");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, MoveSpeedFactor_Offset), value);
			}
		}
	}

	[DisplayName("停止移动阻力")]
	[UProperty]
	[EditAnywhere]
	[Category("相机移动")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseFixedResistance")]
	public float MouseFixedResistance
	{
		get
		{
			CheckDestroyed();
			if (!MouseFixedResistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseFixedResistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseFixedResistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseFixedResistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseFixedResistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseFixedResistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否开启立即转向")]
	[Category("相机移动")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsTurnImmediately")]
	public bool IsTurnImmediately
	{
		get
		{
			CheckDestroyed();
			if (!IsTurnImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsTurnImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTurnImmediately_Offset), 0, IsTurnImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTurnImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:IsTurnImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTurnImmediately_Offset), 0, IsTurnImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("鼠标水平旋转因子")]
	[Category("相机移动")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseYawRotationFactor")]
	public float MouseYawRotationFactor
	{
		get
		{
			CheckDestroyed();
			if (!MouseYawRotationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseYawRotationFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseYawRotationFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseYawRotationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MouseYawRotationFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseYawRotationFactor_Offset), value);
			}
		}
	}

	[Category("相机移动")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("鼠标垂直旋转因子")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MousePitchRotationFactor")]
	public float MousePitchRotationFactor
	{
		get
		{
			CheckDestroyed();
			if (!MousePitchRotationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MousePitchRotationFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MousePitchRotationFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MousePitchRotationFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:MousePitchRotationFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MousePitchRotationFactor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("水平旋转因子")]
	[Category("相机移动")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_LR")]
	public float RotateSpeed_LR
	{
		get
		{
			CheckDestroyed();
			if (!RotateSpeed_LR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_LR");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateSpeed_LR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateSpeed_LR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_LR");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateSpeed_LR_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("垂直旋转因子")]
	[Category("相机移动")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_UD")]
	public float RotateSpeed_UD
	{
		get
		{
			CheckDestroyed();
			if (!RotateSpeed_UD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_UD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateSpeed_UD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateSpeed_UD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:RotateSpeed_UD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateSpeed_UD_Offset), value);
			}
		}
	}

	[Category("相机移动")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("PA限定距离")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:PhysicsAssetCheckRange")]
	public float PhysicsAssetCheckRange
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAssetCheckRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:PhysicsAssetCheckRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicsAssetCheckRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAssetCheckRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:PhysicsAssetCheckRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicsAssetCheckRange_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("UI")]
	[DisplayName("滤镜")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:FilterList")]
	public TArrayReadWrite<FTPModeFilterInfo> FilterList
	{
		get
		{
			CheckDestroyed();
			if (!FilterList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:FilterList");
				return null;
			}
			if (FilterList_Marshaler == null)
			{
				FilterList_Marshaler = new TArrayReadWriteMarshaler<FTPModeFilterInfo>(1, FilterList_PropertyAddress, CachedMarshalingDelegates<FTPModeFilterInfo, FTPModeFilterInfo>.FromNative, CachedMarshalingDelegates<FTPModeFilterInfo, FTPModeFilterInfo>.ToNative);
			}
			return FilterList_Marshaler.FromNative(IntPtr.Add(base.Address, FilterList_Offset));
		}
	}

	[BlueprintReadWrite]
	[DisplayName("贴纸")]
	[Category("UI")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:StickerImageList")]
	public TArrayReadWrite<FTPModeStickerImage> StickerImageList
	{
		get
		{
			CheckDestroyed();
			if (!StickerImageList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:StickerImageList");
				return null;
			}
			if (StickerImageList_Marshaler == null)
			{
				StickerImageList_Marshaler = new TArrayReadWriteMarshaler<FTPModeStickerImage>(1, StickerImageList_PropertyAddress, CachedMarshalingDelegates<FTPModeStickerImage, FTPModeStickerImage>.FromNative, CachedMarshalingDelegates<FTPModeStickerImage, FTPModeStickerImage>.ToNative);
			}
			return StickerImageList_Marshaler.FromNative(IntPtr.Add(base.Address, StickerImageList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("边框")]
	[Category("UI")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:FrameList")]
	public TArrayReadWrite<FTPModeFrame> FrameList
	{
		get
		{
			CheckDestroyed();
			if (!FrameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:FrameList");
				return null;
			}
			if (FrameList_Marshaler == null)
			{
				FrameList_Marshaler = new TArrayReadWriteMarshaler<FTPModeFrame>(1, FrameList_PropertyAddress, CachedMarshalingDelegates<FTPModeFrame, FTPModeFrame>.FromNative, CachedMarshalingDelegates<FTPModeFrame, FTPModeFrame>.ToNative);
			}
			return FrameList_Marshaler.FromNative(IntPtr.Add(base.Address, FrameList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Tab贴图")]
	[Category("UI")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:ConfigTabTextureInfo")]
	public TArrayReadWrite<UTexture2D> ConfigTabTextureInfo
	{
		get
		{
			CheckDestroyed();
			if (!ConfigTabTextureInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:ConfigTabTextureInfo");
				return null;
			}
			if (ConfigTabTextureInfo_Marshaler == null)
			{
				ConfigTabTextureInfo_Marshaler = new TArrayReadWriteMarshaler<UTexture2D>(1, ConfigTabTextureInfo_PropertyAddress, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.FromNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.ToNative);
			}
			return ConfigTabTextureInfo_Marshaler.FromNative(IntPtr.Add(base.Address, ConfigTabTextureInfo_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("UI")]
	[DisplayName("进入Enhanced状态时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:EnterEnhancedTime")]
	public float EnterEnhancedTime
	{
		get
		{
			CheckDestroyed();
			if (!EnterEnhancedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:EnterEnhancedTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EnterEnhancedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnterEnhancedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:EnterEnhancedTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EnterEnhancedTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("快捷键IA")]
	[Category("UI")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:ShortcutInputAction")]
	public UInputAction ShortcutInputAction
	{
		get
		{
			CheckDestroyed();
			if (!ShortcutInputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:ShortcutInputAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, ShortcutInputAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShortcutInputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:ShortcutInputAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, ShortcutInputAction_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("禁止变身ResID")]
	[Category("系统配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:InvalidTransformingResIDList")]
	public TArrayReadWrite<int> InvalidTransformingResIDList
	{
		get
		{
			CheckDestroyed();
			if (!InvalidTransformingResIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:InvalidTransformingResIDList");
				return null;
			}
			if (InvalidTransformingResIDList_Marshaler == null)
			{
				InvalidTransformingResIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, InvalidTransformingResIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return InvalidTransformingResIDList_Marshaler.FromNative(IntPtr.Add(base.Address, InvalidTransformingResIDList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("相机Actor蓝图")]
	[Category("系统配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:TakePhotoActor_BP")]
	public TSubclassOf<BGUTakePhotoActor> TakePhotoActor_BP
	{
		get
		{
			CheckDestroyed();
			if (!TakePhotoActor_BP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:TakePhotoActor_BP");
				return default(TSubclassOf<BGUTakePhotoActor>);
			}
			return TSubclassOfMarshaler<BGUTakePhotoActor>.FromNative(IntPtr.Add(base.Address, TakePhotoActor_BP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TakePhotoActor_BP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig:TakePhotoActor_BP");
			}
			else
			{
				TSubclassOfMarshaler<BGUTakePhotoActor>.ToNative(IntPtr.Add(base.Address, TakePhotoActor_BP_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TakePhotoSystemConfig");
		NativeReflection.GetPropertyRef(ref IsKeepLocalMove_PropertyAddress, unrealStruct, "IsKeepLocalMove");
		IsKeepLocalMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsKeepLocalMove");
		IsKeepLocalMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsKeepLocalMove", Classes.FBoolProperty);
		CameraMoveableDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraMoveableDistance");
		CameraMoveableDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraMoveableDistance", Classes.FFloatProperty);
		CameraMoveableHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraMoveableHeight");
		CameraMoveableHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraMoveableHeight", Classes.FFloatProperty);
		MoveAccelerationFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAccelerationFactor");
		MoveAccelerationFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAccelerationFactor", Classes.FStructProperty);
		MoveSpeedFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeedFactor");
		MoveSpeedFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeedFactor", Classes.FStructProperty);
		MouseFixedResistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MouseFixedResistance");
		MouseFixedResistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MouseFixedResistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsTurnImmediately_PropertyAddress, unrealStruct, "IsTurnImmediately");
		IsTurnImmediately_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsTurnImmediately");
		IsTurnImmediately_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsTurnImmediately", Classes.FBoolProperty);
		MouseYawRotationFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MouseYawRotationFactor");
		MouseYawRotationFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MouseYawRotationFactor", Classes.FFloatProperty);
		MousePitchRotationFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MousePitchRotationFactor");
		MousePitchRotationFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MousePitchRotationFactor", Classes.FFloatProperty);
		RotateSpeed_LR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotateSpeed_LR");
		RotateSpeed_LR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotateSpeed_LR", Classes.FFloatProperty);
		RotateSpeed_UD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotateSpeed_UD");
		RotateSpeed_UD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotateSpeed_UD", Classes.FFloatProperty);
		PhysicsAssetCheckRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysicsAssetCheckRange");
		PhysicsAssetCheckRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysicsAssetCheckRange", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FilterList_PropertyAddress, unrealStruct, "FilterList");
		FilterList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FilterList");
		FilterList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FilterList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref StickerImageList_PropertyAddress, unrealStruct, "StickerImageList");
		StickerImageList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StickerImageList");
		StickerImageList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StickerImageList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FrameList_PropertyAddress, unrealStruct, "FrameList");
		FrameList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FrameList");
		FrameList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FrameList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConfigTabTextureInfo_PropertyAddress, unrealStruct, "ConfigTabTextureInfo");
		ConfigTabTextureInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigTabTextureInfo");
		ConfigTabTextureInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigTabTextureInfo", Classes.FArrayProperty);
		EnterEnhancedTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnterEnhancedTime");
		EnterEnhancedTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnterEnhancedTime", Classes.FFloatProperty);
		ShortcutInputAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShortcutInputAction");
		ShortcutInputAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShortcutInputAction", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref InvalidTransformingResIDList_PropertyAddress, unrealStruct, "InvalidTransformingResIDList");
		InvalidTransformingResIDList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InvalidTransformingResIDList");
		InvalidTransformingResIDList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InvalidTransformingResIDList", Classes.FArrayProperty);
		TakePhotoActor_BP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TakePhotoActor_BP");
		TakePhotoActor_BP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TakePhotoActor_BP", Classes.FClassProperty);
	}

	static BGWDataAsset_TakePhotoSystemConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TakePhotoSystemConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TakePhotoSystemConfig));
	}
}
