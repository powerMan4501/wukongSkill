using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSBaseVolume : AVolume
{
	private static bool VolumeProcessParameters_IsValid;

	private static int VolumeProcessParameters_Offset;

	private static bool MaterialParametersCollectionProperty_IsValid;

	private static int MaterialParametersCollectionProperty_Offset;

	private static bool MasterVolume_IsValid;

	private static int MasterVolume_Offset;

	private static bool DirectionalLight_IsValid;

	private static int DirectionalLight_Offset;

	private static bool SkyLight_IsValid;

	private static int SkyLight_Offset;

	private static bool AtmosphericFog_IsValid;

	private static int AtmosphericFog_Offset;

	private static bool ExponentialHeightFog_IsValid;

	private static int ExponentialHeightFog_Offset;

	private static bool PlayerLightProperty_IsValid;

	private static int PlayerLightProperty_Offset;

	private static bool VolumeManagerID_IsValid;

	private static int VolumeManagerID_Offset;

	private static bool LengthOfBuffSpace_IsValid;

	private static int LengthOfBuffSpace_Offset;

	private static bool SortWeight_IsValid;

	private static int SortWeight_Offset;

	private static bool SpeedAlpha_IsValid;

	private static int SpeedAlpha_Offset;

	private static bool PlayerLightSpeedAlpha_IsValid;

	private static int PlayerLightSpeedAlpha_Offset;

	private static bool UseCustomBlendOutSpeed_IsValid;

	private static FFieldAddress UseCustomBlendOutSpeed_PropertyAddress;

	private static int UseCustomBlendOutSpeed_Offset;

	private static bool CustomBlendOutSpeedAlpha_IsValid;

	private static int CustomBlendOutSpeedAlpha_Offset;

	private static bool Level_IsValid;

	private static int Level_Offset;

	private static bool UseSceneLight_IsValid;

	private static FFieldAddress UseSceneLight_PropertyAddress;

	private static int UseSceneLight_Offset;

	private static bool DisableDirectionalLight_IsValid;

	private static FFieldAddress DisableDirectionalLight_PropertyAddress;

	private static int DisableDirectionalLight_Offset;

	private static bool DisableSkyLight_IsValid;

	private static FFieldAddress DisableSkyLight_PropertyAddress;

	private static int DisableSkyLight_Offset;

	private static bool DisableAtmospheric_IsValid;

	private static FFieldAddress DisableAtmospheric_PropertyAddress;

	private static int DisableAtmospheric_Offset;

	private static bool DisableHeightFog_IsValid;

	private static FFieldAddress DisableHeightFog_PropertyAddress;

	private static int DisableHeightFog_Offset;

	private static bool ForceEnableAnyWhere_IsValid;

	private static FFieldAddress ForceEnableAnyWhere_PropertyAddress;

	private static int ForceEnableAnyWhere_Offset;

	private static bool UpdateVolumeManagerWithEditor_IsValid;

	private static IntPtr UpdateVolumeManagerWithEditor_FunctionAddress;

	private static int UpdateVolumeManagerWithEditor_ParamsSize;

	private static bool StoreClsData_IsValid;

	private static IntPtr StoreClsData_FunctionAddress;

	private static int StoreClsData_ParamsSize;

	private static bool SetForceEnableAnyWhere_IsValid;

	private static IntPtr SetForceEnableAnyWhere_FunctionAddress;

	private static int SetForceEnableAnyWhere_ParamsSize;

	private static bool SetForceEnableAnyWhere_bInForceEnableAnyWhere_IsValid;

	private static FFieldAddress SetForceEnableAnyWhere_bInForceEnableAnyWhere_PropertyAddress;

	private static int SetForceEnableAnyWhere_bInForceEnableAnyWhere_Offset;

	private static bool SetDynamicLevel_IsValid;

	private static IntPtr SetDynamicLevel_FunctionAddress;

	private static int SetDynamicLevel_ParamsSize;

	private static bool SetDynamicLevel_InDynamicLevel_IsValid;

	private static FFieldAddress SetDynamicLevel_InDynamicLevel_PropertyAddress;

	private static int SetDynamicLevel_InDynamicLevel_Offset;

	private static bool CopyCLsDataFromMaster_IsValid;

	private static IntPtr CopyCLsDataFromMaster_FunctionAddress;

	private static int CopyCLsDataFromMaster_ParamsSize;

	private static bool CopyClsData2LightComponents_IsValid;

	private static IntPtr CopyClsData2LightComponents_FunctionAddress;

	private static int CopyClsData2LightComponents_ParamsSize;

	private static bool CheckReferenceActors_IsValid;

	private static IntPtr CheckReferenceActors_FunctionAddress;

	private static int CheckReferenceActors_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:VolumeProcessParameters")]
	public FCLSVolumeProcessParameters VolumeProcessParameters
	{
		get
		{
			CheckDestroyed();
			if (!VolumeProcessParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:VolumeProcessParameters");
				return default(FCLSVolumeProcessParameters);
			}
			return FCLSVolumeProcessParameters.FromNative(IntPtr.Add(base.Address, VolumeProcessParameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeProcessParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:VolumeProcessParameters");
			}
			else
			{
				FCLSVolumeProcessParameters.ToNative(IntPtr.Add(base.Address, VolumeProcessParameters_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:MaterialParametersCollectionProperty")]
	public FCLSMaterialParametersCollectionProperty MaterialParametersCollectionProperty
	{
		get
		{
			CheckDestroyed();
			if (!MaterialParametersCollectionProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:MaterialParametersCollectionProperty");
				return default(FCLSMaterialParametersCollectionProperty);
			}
			return FCLSMaterialParametersCollectionProperty.FromNative(IntPtr.Add(base.Address, MaterialParametersCollectionProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialParametersCollectionProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:MaterialParametersCollectionProperty");
			}
			else
			{
				FCLSMaterialParametersCollectionProperty.ToNative(IntPtr.Add(base.Address, MaterialParametersCollectionProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:MasterVolume")]
	public TWeakObject<ACLSBaseVolume> MasterVolume
	{
		get
		{
			CheckDestroyed();
			if (!MasterVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:MasterVolume");
				return default(TWeakObject<ACLSBaseVolume>);
			}
			return TWeakObjectMarshaler<ACLSBaseVolume>.FromNative(IntPtr.Add(base.Address, MasterVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MasterVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:MasterVolume");
			}
			else
			{
				TWeakObjectMarshaler<ACLSBaseVolume>.ToNative(IntPtr.Add(base.Address, MasterVolume_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:DirectionalLight")]
	public ADirectionalLight DirectionalLight
	{
		get
		{
			CheckDestroyed();
			if (!DirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:DirectionalLight");
				return null;
			}
			return UObjectMarshaler<ADirectionalLight>.FromNative(IntPtr.Add(base.Address, DirectionalLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:DirectionalLight");
			}
			else
			{
				UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(base.Address, DirectionalLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:SkyLight")]
	public ASkyLight SkyLight
	{
		get
		{
			CheckDestroyed();
			if (!SkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SkyLight");
				return null;
			}
			return UObjectMarshaler<ASkyLight>.FromNative(IntPtr.Add(base.Address, SkyLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SkyLight");
			}
			else
			{
				UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(base.Address, SkyLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:AtmosphericFog")]
	public ASkyAtmosphere AtmosphericFog
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphericFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:AtmosphericFog");
				return null;
			}
			return UObjectMarshaler<ASkyAtmosphere>.FromNative(IntPtr.Add(base.Address, AtmosphericFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphericFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:AtmosphericFog");
			}
			else
			{
				UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(base.Address, AtmosphericFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:ExponentialHeightFog")]
	public AExponentialHeightFog ExponentialHeightFog
	{
		get
		{
			CheckDestroyed();
			if (!ExponentialHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:ExponentialHeightFog");
				return null;
			}
			return UObjectMarshaler<AExponentialHeightFog>.FromNative(IntPtr.Add(base.Address, ExponentialHeightFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExponentialHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:ExponentialHeightFog");
			}
			else
			{
				UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(base.Address, ExponentialHeightFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358341uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightProperty")]
	public FCLSPlayerLightProperty PlayerLightProperty
	{
		get
		{
			CheckDestroyed();
			if (!PlayerLightProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightProperty");
				return default(FCLSPlayerLightProperty);
			}
			return FCLSPlayerLightProperty.FromNative(IntPtr.Add(base.Address, PlayerLightProperty_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerLightProperty_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightProperty");
			}
			else
			{
				FCLSPlayerLightProperty.ToNative(IntPtr.Add(base.Address, PlayerLightProperty_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:VolumeManagerID")]
	public int VolumeManagerID
	{
		get
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:VolumeManagerID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VolumeManagerID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:VolumeManagerID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VolumeManagerID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:LengthOfBuffSpace")]
	public float LengthOfBuffSpace
	{
		get
		{
			CheckDestroyed();
			if (!LengthOfBuffSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:LengthOfBuffSpace");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LengthOfBuffSpace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LengthOfBuffSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:LengthOfBuffSpace");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LengthOfBuffSpace_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:SortWeight")]
	public float SortWeight
	{
		get
		{
			CheckDestroyed();
			if (!SortWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SortWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SortWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SortWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SortWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SortWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:SpeedAlpha")]
	public float SpeedAlpha
	{
		get
		{
			CheckDestroyed();
			if (!SpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SpeedAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:SpeedAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedAlpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightSpeedAlpha")]
	public float PlayerLightSpeedAlpha
	{
		get
		{
			CheckDestroyed();
			if (!PlayerLightSpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightSpeedAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayerLightSpeedAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerLightSpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:PlayerLightSpeedAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayerLightSpeedAlpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bUseCustomBlendOutSpeed")]
	public bool UseCustomBlendOutSpeed
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomBlendOutSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bUseCustomBlendOutSpeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomBlendOutSpeed_Offset), 0, UseCustomBlendOutSpeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomBlendOutSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bUseCustomBlendOutSpeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomBlendOutSpeed_Offset), 0, UseCustomBlendOutSpeed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:CustomBlendOutSpeedAlpha")]
	public float CustomBlendOutSpeedAlpha
	{
		get
		{
			CheckDestroyed();
			if (!CustomBlendOutSpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:CustomBlendOutSpeedAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CustomBlendOutSpeedAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomBlendOutSpeedAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:CustomBlendOutSpeedAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CustomBlendOutSpeedAlpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:Level")]
	public int Level
	{
		get
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:Level");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Level_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:Level");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Level_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bUseSceneLight")]
	public bool UseSceneLight
	{
		get
		{
			CheckDestroyed();
			if (!UseSceneLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bUseSceneLight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSceneLight_Offset), 0, UseSceneLight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSceneLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bUseSceneLight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSceneLight_Offset), 0, UseSceneLight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bDisableDirectionalLight")]
	public bool DisableDirectionalLight
	{
		get
		{
			CheckDestroyed();
			if (!DisableDirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableDirectionalLight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableDirectionalLight_Offset), 0, DisableDirectionalLight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableDirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableDirectionalLight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableDirectionalLight_Offset), 0, DisableDirectionalLight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bDisableSkyLight")]
	public bool DisableSkyLight
	{
		get
		{
			CheckDestroyed();
			if (!DisableSkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableSkyLight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableSkyLight_Offset), 0, DisableSkyLight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableSkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableSkyLight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableSkyLight_Offset), 0, DisableSkyLight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bDisableAtmospheric")]
	public bool DisableAtmospheric
	{
		get
		{
			CheckDestroyed();
			if (!DisableAtmospheric_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableAtmospheric");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableAtmospheric_Offset), 0, DisableAtmospheric_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableAtmospheric_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableAtmospheric");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableAtmospheric_Offset), 0, DisableAtmospheric_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bDisableHeightFog")]
	public bool DisableHeightFog
	{
		get
		{
			CheckDestroyed();
			if (!DisableHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableHeightFog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableHeightFog_Offset), 0, DisableHeightFog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bDisableHeightFog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableHeightFog_Offset), 0, DisableHeightFog_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:bForceEnableAnyWhere")]
	public bool ForceEnableAnyWhere
	{
		get
		{
			CheckDestroyed();
			if (!ForceEnableAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bForceEnableAnyWhere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceEnableAnyWhere_Offset), 0, ForceEnableAnyWhere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceEnableAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSBaseVolume:bForceEnableAnyWhere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceEnableAnyWhere_Offset), 0, ForceEnableAnyWhere_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:UpdateVolumeManagerWithEditor")]
	public unsafe void UpdateVolumeManagerWithEditor()
	{
		CheckDestroyed();
		if (!UpdateVolumeManagerWithEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:UpdateVolumeManagerWithEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateVolumeManagerWithEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateVolumeManagerWithEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateVolumeManagerWithEditor_FunctionAddress, argsSize: UpdateVolumeManagerWithEditor_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:StoreClsData")]
	public unsafe void StoreClsData()
	{
		CheckDestroyed();
		if (!StoreClsData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:StoreClsData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StoreClsData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StoreClsData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StoreClsData_FunctionAddress, argsSize: StoreClsData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:SetForceEnableAnyWhere")]
	public unsafe void SetForceEnableAnyWhere(bool bInForceEnableAnyWhere)
	{
		CheckDestroyed();
		if (!SetForceEnableAnyWhere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:SetForceEnableAnyWhere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceEnableAnyWhere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceEnableAnyWhere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceEnableAnyWhere_bInForceEnableAnyWhere_Offset), 0, SetForceEnableAnyWhere_bInForceEnableAnyWhere_PropertyAddress.Address, bInForceEnableAnyWhere);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceEnableAnyWhere_FunctionAddress, intPtr, SetForceEnableAnyWhere_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:SetDynamicLevel")]
	public unsafe void SetDynamicLevel(int InDynamicLevel)
	{
		CheckDestroyed();
		if (!SetDynamicLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:SetDynamicLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDynamicLevel_InDynamicLevel_Offset), 0, SetDynamicLevel_InDynamicLevel_PropertyAddress.Address, InDynamicLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicLevel_FunctionAddress, intPtr, SetDynamicLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:CopyCLsDataFromMaster")]
	public unsafe void CopyCLsDataFromMaster()
	{
		CheckDestroyed();
		if (!CopyCLsDataFromMaster_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:CopyCLsDataFromMaster");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyCLsDataFromMaster_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyCLsDataFromMaster_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CopyCLsDataFromMaster_FunctionAddress, argsSize: CopyCLsDataFromMaster_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:CopyClsData2LightComponents")]
	public unsafe void CopyClsData2LightComponents()
	{
		CheckDestroyed();
		if (!CopyClsData2LightComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:CopyClsData2LightComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyClsData2LightComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyClsData2LightComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CopyClsData2LightComponents_FunctionAddress, argsSize: CopyClsData2LightComponents_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSBaseVolume:CheckReferenceActors")]
	public unsafe void CheckReferenceActors()
	{
		CheckDestroyed();
		if (!CheckReferenceActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSBaseVolume:CheckReferenceActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckReferenceActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckReferenceActors_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CheckReferenceActors_FunctionAddress, argsSize: CheckReferenceActors_ParamsSize);
	}

	static ACLSBaseVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSBaseVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSBaseVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSBaseVolume");
		VolumeProcessParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeProcessParameters");
		VolumeProcessParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeProcessParameters", Classes.FStructProperty);
		MaterialParametersCollectionProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialParametersCollectionProperty");
		MaterialParametersCollectionProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialParametersCollectionProperty", Classes.FStructProperty);
		MasterVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MasterVolume");
		MasterVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MasterVolume", Classes.FWeakObjectProperty);
		DirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalLight");
		DirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalLight", Classes.FObjectProperty);
		SkyLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLight");
		SkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLight", Classes.FObjectProperty);
		AtmosphericFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtmosphericFog");
		AtmosphericFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtmosphericFog", Classes.FObjectProperty);
		ExponentialHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExponentialHeightFog");
		ExponentialHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExponentialHeightFog", Classes.FObjectProperty);
		PlayerLightProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerLightProperty");
		PlayerLightProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerLightProperty", Classes.FStructProperty);
		VolumeManagerID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeManagerID");
		VolumeManagerID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeManagerID", Classes.FIntProperty);
		LengthOfBuffSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LengthOfBuffSpace");
		LengthOfBuffSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LengthOfBuffSpace", Classes.FFloatProperty);
		SortWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortWeight");
		SortWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortWeight", Classes.FFloatProperty);
		SpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedAlpha");
		SpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedAlpha", Classes.FFloatProperty);
		PlayerLightSpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerLightSpeedAlpha");
		PlayerLightSpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerLightSpeedAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomBlendOutSpeed_PropertyAddress, intPtr, "bUseCustomBlendOutSpeed");
		UseCustomBlendOutSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCustomBlendOutSpeed");
		UseCustomBlendOutSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCustomBlendOutSpeed", Classes.FBoolProperty);
		CustomBlendOutSpeedAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomBlendOutSpeedAlpha");
		CustomBlendOutSpeedAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomBlendOutSpeedAlpha", Classes.FFloatProperty);
		Level_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Level");
		Level_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Level", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSceneLight_PropertyAddress, intPtr, "bUseSceneLight");
		UseSceneLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSceneLight");
		UseSceneLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSceneLight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableDirectionalLight_PropertyAddress, intPtr, "bDisableDirectionalLight");
		DisableDirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableDirectionalLight");
		DisableDirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableDirectionalLight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableSkyLight_PropertyAddress, intPtr, "bDisableSkyLight");
		DisableSkyLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableSkyLight");
		DisableSkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableSkyLight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableAtmospheric_PropertyAddress, intPtr, "bDisableAtmospheric");
		DisableAtmospheric_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableAtmospheric");
		DisableAtmospheric_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableAtmospheric", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableHeightFog_PropertyAddress, intPtr, "bDisableHeightFog");
		DisableHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableHeightFog");
		DisableHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableHeightFog", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceEnableAnyWhere_PropertyAddress, intPtr, "bForceEnableAnyWhere");
		ForceEnableAnyWhere_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceEnableAnyWhere");
		ForceEnableAnyWhere_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceEnableAnyWhere", Classes.FBoolProperty);
		UpdateVolumeManagerWithEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateVolumeManagerWithEditor");
		UpdateVolumeManagerWithEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateVolumeManagerWithEditor_FunctionAddress);
		UpdateVolumeManagerWithEditor_IsValid = UpdateVolumeManagerWithEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:UpdateVolumeManagerWithEditor", UpdateVolumeManagerWithEditor_IsValid);
		StoreClsData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StoreClsData");
		StoreClsData_ParamsSize = NativeReflection.GetFunctionParamsSize(StoreClsData_FunctionAddress);
		StoreClsData_IsValid = StoreClsData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:StoreClsData", StoreClsData_IsValid);
		SetForceEnableAnyWhere_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceEnableAnyWhere");
		SetForceEnableAnyWhere_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceEnableAnyWhere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceEnableAnyWhere_bInForceEnableAnyWhere_PropertyAddress, SetForceEnableAnyWhere_FunctionAddress, "bInForceEnableAnyWhere");
		SetForceEnableAnyWhere_bInForceEnableAnyWhere_Offset = NativeReflectionCached.GetPropertyOffset(SetForceEnableAnyWhere_FunctionAddress, "bInForceEnableAnyWhere");
		SetForceEnableAnyWhere_bInForceEnableAnyWhere_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceEnableAnyWhere_FunctionAddress, "bInForceEnableAnyWhere", Classes.FBoolProperty);
		SetForceEnableAnyWhere_IsValid = SetForceEnableAnyWhere_FunctionAddress != IntPtr.Zero && SetForceEnableAnyWhere_bInForceEnableAnyWhere_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:SetForceEnableAnyWhere", SetForceEnableAnyWhere_IsValid);
		SetDynamicLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicLevel");
		SetDynamicLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicLevel_InDynamicLevel_PropertyAddress, SetDynamicLevel_FunctionAddress, "InDynamicLevel");
		SetDynamicLevel_InDynamicLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicLevel_FunctionAddress, "InDynamicLevel");
		SetDynamicLevel_InDynamicLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicLevel_FunctionAddress, "InDynamicLevel", Classes.FIntProperty);
		SetDynamicLevel_IsValid = SetDynamicLevel_FunctionAddress != IntPtr.Zero && SetDynamicLevel_InDynamicLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:SetDynamicLevel", SetDynamicLevel_IsValid);
		CopyCLsDataFromMaster_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyCLsDataFromMaster");
		CopyCLsDataFromMaster_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyCLsDataFromMaster_FunctionAddress);
		CopyCLsDataFromMaster_IsValid = CopyCLsDataFromMaster_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:CopyCLsDataFromMaster", CopyCLsDataFromMaster_IsValid);
		CopyClsData2LightComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyClsData2LightComponents");
		CopyClsData2LightComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyClsData2LightComponents_FunctionAddress);
		CopyClsData2LightComponents_IsValid = CopyClsData2LightComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:CopyClsData2LightComponents", CopyClsData2LightComponents_IsValid);
		CheckReferenceActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckReferenceActors");
		CheckReferenceActors_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckReferenceActors_FunctionAddress);
		CheckReferenceActors_IsValid = CheckReferenceActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSBaseVolume:CheckReferenceActors", CheckReferenceActors_IsValid);
	}
}
