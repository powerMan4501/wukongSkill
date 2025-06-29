using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkComponent : UAkGameObject
{
	private static bool OcclusionCollisionChannel_IsValid;

	private static FFieldAddress OcclusionCollisionChannel_PropertyAddress;

	private static int OcclusionCollisionChannel_Offset;

	private static bool EnableSpotReflectors_IsValid;

	private static FFieldAddress EnableSpotReflectors_PropertyAddress;

	private static int EnableSpotReflectors_Offset;

	private static bool DisableUpdateSpatialAudioRoom_IsValid;

	private static FFieldAddress DisableUpdateSpatialAudioRoom_PropertyAddress;

	private static int DisableUpdateSpatialAudioRoom_Offset;

	private static bool outerRadius_IsValid;

	private static int outerRadius_Offset;

	private static bool innerRadius_IsValid;

	private static int innerRadius_Offset;

	private static bool OnAkCompAutoDestroyed_IsValid;

	private static int OnAkCompAutoDestroyed_Offset;

	private FOnAkCompAutoDestroyed OnAkCompAutoDestroyed_DelegateCached;

	private static bool DrawFirstOrderReflections_IsValid;

	private static FFieldAddress DrawFirstOrderReflections_PropertyAddress;

	private static int DrawFirstOrderReflections_Offset;

	private static bool DrawSecondOrderReflections_IsValid;

	private static FFieldAddress DrawSecondOrderReflections_PropertyAddress;

	private static int DrawSecondOrderReflections_Offset;

	private static bool DrawHigherOrderReflections_IsValid;

	private static FFieldAddress DrawHigherOrderReflections_PropertyAddress;

	private static int DrawHigherOrderReflections_Offset;

	private static bool DrawDiffraction_IsValid;

	private static FFieldAddress DrawDiffraction_PropertyAddress;

	private static int DrawDiffraction_Offset;

	private static bool AttenuationScalingFactor_IsValid;

	private static int AttenuationScalingFactor_Offset;

	private static bool OcclusionRefreshInterval_IsValid;

	private static int OcclusionRefreshInterval_Offset;

	private static bool UseReverbVolumes_IsValid;

	private static FFieldAddress UseReverbVolumes_PropertyAddress;

	private static int UseReverbVolumes_Offset;

	private static bool SetSwitch_IsValid;

	private static IntPtr SetSwitch_FunctionAddress;

	private static int SetSwitch_ParamsSize;

	private static bool SetSwitch_SwitchValue_IsValid;

	private static FFieldAddress SetSwitch_SwitchValue_PropertyAddress;

	private static int SetSwitch_SwitchValue_Offset;

	private static bool SetSwitch_SwitchGroup_IsValid;

	private static FFieldAddress SetSwitch_SwitchGroup_PropertyAddress;

	private static int SetSwitch_SwitchGroup_Offset;

	private static bool SetSwitch_SwitchState_IsValid;

	private static FFieldAddress SetSwitch_SwitchState_PropertyAddress;

	private static int SetSwitch_SwitchState_Offset;

	private static bool SetStopWhenOwnerDestroyed_IsValid;

	private static IntPtr SetStopWhenOwnerDestroyed_FunctionAddress;

	private static int SetStopWhenOwnerDestroyed_ParamsSize;

	private static bool SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_IsValid;

	private static FFieldAddress SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_PropertyAddress;

	private static int SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_Offset;

	private static bool SetOutputBusVolume_IsValid;

	private static IntPtr SetOutputBusVolume_FunctionAddress;

	private static int SetOutputBusVolume_ParamsSize;

	private static bool SetOutputBusVolume_BusVolume_IsValid;

	private static FFieldAddress SetOutputBusVolume_BusVolume_PropertyAddress;

	private static int SetOutputBusVolume_BusVolume_Offset;

	private static bool SetListeners_IsValid;

	private static IntPtr SetListeners_FunctionAddress;

	private static int SetListeners_ParamsSize;

	private static bool SetListeners_Listeners_IsValid;

	private static FFieldAddress SetListeners_Listeners_PropertyAddress;

	private static int SetListeners_Listeners_Offset;

	private static bool SetGameObjectRadius_IsValid;

	private static IntPtr SetGameObjectRadius_FunctionAddress;

	private static int SetGameObjectRadius_ParamsSize;

	private static bool SetGameObjectRadius_in_outerRadius_IsValid;

	private static FFieldAddress SetGameObjectRadius_in_outerRadius_PropertyAddress;

	private static int SetGameObjectRadius_in_outerRadius_Offset;

	private static bool SetGameObjectRadius_in_innerRadius_IsValid;

	private static FFieldAddress SetGameObjectRadius_in_innerRadius_PropertyAddress;

	private static int SetGameObjectRadius_in_innerRadius_Offset;

	private static bool SetEnableSpotReflectors_IsValid;

	private static IntPtr SetEnableSpotReflectors_FunctionAddress;

	private static int SetEnableSpotReflectors_ParamsSize;

	private static bool SetEnableSpotReflectors_in_enable_IsValid;

	private static FFieldAddress SetEnableSpotReflectors_in_enable_PropertyAddress;

	private static int SetEnableSpotReflectors_in_enable_Offset;

	private static bool SetEarlyReflectionsVolume_IsValid;

	private static IntPtr SetEarlyReflectionsVolume_FunctionAddress;

	private static int SetEarlyReflectionsVolume_ParamsSize;

	private static bool SetEarlyReflectionsVolume_SendVolume_IsValid;

	private static FFieldAddress SetEarlyReflectionsVolume_SendVolume_PropertyAddress;

	private static int SetEarlyReflectionsVolume_SendVolume_Offset;

	private static bool SetEarlyReflectionsAuxBus_IsValid;

	private static IntPtr SetEarlyReflectionsAuxBus_FunctionAddress;

	private static int SetEarlyReflectionsAuxBus_ParamsSize;

	private static bool SetEarlyReflectionsAuxBus_AuxBusName_IsValid;

	private static FFieldAddress SetEarlyReflectionsAuxBus_AuxBusName_PropertyAddress;

	private static int SetEarlyReflectionsAuxBus_AuxBusName_Offset;

	private static bool SetAutoDestroyCS_IsValid;

	private static IntPtr SetAutoDestroyCS_FunctionAddress;

	private static int SetAutoDestroyCS_ParamsSize;

	private static bool SetAutoDestroyCS__bAutoDestory_IsValid;

	private static FFieldAddress SetAutoDestroyCS__bAutoDestory_PropertyAddress;

	private static int SetAutoDestroyCS__bAutoDestory_Offset;

	private static bool SetAttenuationScalingFactor_IsValid;

	private static IntPtr SetAttenuationScalingFactor_FunctionAddress;

	private static int SetAttenuationScalingFactor_ParamsSize;

	private static bool SetAttenuationScalingFactor_Value_IsValid;

	private static FFieldAddress SetAttenuationScalingFactor_Value_PropertyAddress;

	private static int SetAttenuationScalingFactor_Value_Offset;

	private static bool PostTrigger_IsValid;

	private static IntPtr PostTrigger_FunctionAddress;

	private static int PostTrigger_ParamsSize;

	private static bool PostTrigger_TriggerValue_IsValid;

	private static FFieldAddress PostTrigger_TriggerValue_PropertyAddress;

	private static int PostTrigger_TriggerValue_Offset;

	private static bool PostTrigger_Trigger_IsValid;

	private static FFieldAddress PostTrigger_Trigger_PropertyAddress;

	private static int PostTrigger_Trigger_Offset;

	private static bool PostAssociatedAkEventAndWaitForEnd_IsValid;

	private static IntPtr PostAssociatedAkEventAndWaitForEnd_FunctionAddress;

	private static int PostAssociatedAkEventAndWaitForEnd_ParamsSize;

	private static bool PostAssociatedAkEventAndWaitForEnd_LatentInfo_IsValid;

	private static FFieldAddress PostAssociatedAkEventAndWaitForEnd_LatentInfo_PropertyAddress;

	private static int PostAssociatedAkEventAndWaitForEnd_LatentInfo_Offset;

	private static bool PostAssociatedAkEventAndWaitForEnd_ReturnValue_IsValid;

	private static FFieldAddress PostAssociatedAkEventAndWaitForEnd_ReturnValue_PropertyAddress;

	private static int PostAssociatedAkEventAndWaitForEnd_ReturnValue_Offset;

	private static bool PostAkEventAndWaitForEnd_IsValid;

	private static IntPtr PostAkEventAndWaitForEnd_FunctionAddress;

	private static int PostAkEventAndWaitForEnd_ParamsSize;

	private static bool PostAkEventAndWaitForEnd_AkEvent_IsValid;

	private static FFieldAddress PostAkEventAndWaitForEnd_AkEvent_PropertyAddress;

	private static int PostAkEventAndWaitForEnd_AkEvent_Offset;

	private static bool PostAkEventAndWaitForEnd_in_EventName_IsValid;

	private static FFieldAddress PostAkEventAndWaitForEnd_in_EventName_PropertyAddress;

	private static int PostAkEventAndWaitForEnd_in_EventName_Offset;

	private static bool PostAkEventAndWaitForEnd_LatentInfo_IsValid;

	private static FFieldAddress PostAkEventAndWaitForEnd_LatentInfo_PropertyAddress;

	private static int PostAkEventAndWaitForEnd_LatentInfo_Offset;

	private static bool PostAkEventAndWaitForEnd_ReturnValue_IsValid;

	private static FFieldAddress PostAkEventAndWaitForEnd_ReturnValue_PropertyAddress;

	private static int PostAkEventAndWaitForEnd_ReturnValue_Offset;

	private static bool HasActiveEventsCS_IsValid;

	private static IntPtr HasActiveEventsCS_FunctionAddress;

	private static int HasActiveEventsCS_ParamsSize;

	private static bool HasActiveEventsCS_ReturnValue_IsValid;

	private static FFieldAddress HasActiveEventsCS_ReturnValue_PropertyAddress;

	private static int HasActiveEventsCS_ReturnValue_Offset;

	private static bool GetOcclusionCollisionChannel_IsValid;

	private static IntPtr GetOcclusionCollisionChannel_FunctionAddress;

	private static int GetOcclusionCollisionChannel_ParamsSize;

	private static bool GetOcclusionCollisionChannel_ReturnValue_IsValid;

	private static FFieldAddress GetOcclusionCollisionChannel_ReturnValue_PropertyAddress;

	private static int GetOcclusionCollisionChannel_ReturnValue_Offset;

	private static bool GetAttenuationRadius_IsValid;

	private static IntPtr GetAttenuationRadius_FunctionAddress;

	private static int GetAttenuationRadius_ParamsSize;

	private static bool GetAttenuationRadius_ReturnValue_IsValid;

	private static FFieldAddress GetAttenuationRadius_ReturnValue_PropertyAddress;

	private static int GetAttenuationRadius_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:OcclusionCollisionChannel")]
	public EAkCollisionChannel OcclusionCollisionChannel
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionCollisionChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:OcclusionCollisionChannel");
				return EAkCollisionChannel.EAKCC_WorldStatic;
			}
			return EnumMarshaler<EAkCollisionChannel>.FromNative(IntPtr.Add(base.Address, OcclusionCollisionChannel_Offset), 0, OcclusionCollisionChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionCollisionChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:OcclusionCollisionChannel");
			}
			else
			{
				EnumMarshaler<EAkCollisionChannel>.ToNative(IntPtr.Add(base.Address, OcclusionCollisionChannel_Offset), 0, OcclusionCollisionChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:EnableSpotReflectors")]
	public bool EnableSpotReflectors
	{
		get
		{
			CheckDestroyed();
			if (!EnableSpotReflectors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:EnableSpotReflectors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSpotReflectors_Offset), 0, EnableSpotReflectors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSpotReflectors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:EnableSpotReflectors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSpotReflectors_Offset), 0, EnableSpotReflectors_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:bDisableUpdateSpatialAudioRoom")]
	public bool DisableUpdateSpatialAudioRoom
	{
		get
		{
			CheckDestroyed();
			if (!DisableUpdateSpatialAudioRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:bDisableUpdateSpatialAudioRoom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableUpdateSpatialAudioRoom_Offset), 0, DisableUpdateSpatialAudioRoom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableUpdateSpatialAudioRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:bDisableUpdateSpatialAudioRoom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableUpdateSpatialAudioRoom_Offset), 0, DisableUpdateSpatialAudioRoom_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:outerRadius")]
	public float outerRadius
	{
		get
		{
			CheckDestroyed();
			if (!outerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:outerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, outerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!outerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:outerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, outerRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:innerRadius")]
	public float innerRadius
	{
		get
		{
			CheckDestroyed();
			if (!innerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:innerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, innerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!innerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:innerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, innerRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:OnAkCompAutoDestroyed")]
	public FOnAkCompAutoDestroyed OnAkCompAutoDestroyed
	{
		get
		{
			CheckDestroyed();
			if (!OnAkCompAutoDestroyed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:OnAkCompAutoDestroyed");
				return new FOnAkCompAutoDestroyed();
			}
			if (OnAkCompAutoDestroyed_DelegateCached == null)
			{
				OnAkCompAutoDestroyed_DelegateCached = new FOnAkCompAutoDestroyed();
				OnAkCompAutoDestroyed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAkCompAutoDestroyed_Offset));
			}
			return OnAkCompAutoDestroyed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:DrawFirstOrderReflections")]
	public bool DrawFirstOrderReflections
	{
		get
		{
			CheckDestroyed();
			if (!DrawFirstOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawFirstOrderReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawFirstOrderReflections_Offset), 0, DrawFirstOrderReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawFirstOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawFirstOrderReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawFirstOrderReflections_Offset), 0, DrawFirstOrderReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:DrawSecondOrderReflections")]
	public bool DrawSecondOrderReflections
	{
		get
		{
			CheckDestroyed();
			if (!DrawSecondOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawSecondOrderReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawSecondOrderReflections_Offset), 0, DrawSecondOrderReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawSecondOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawSecondOrderReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawSecondOrderReflections_Offset), 0, DrawSecondOrderReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:DrawHigherOrderReflections")]
	public bool DrawHigherOrderReflections
	{
		get
		{
			CheckDestroyed();
			if (!DrawHigherOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawHigherOrderReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawHigherOrderReflections_Offset), 0, DrawHigherOrderReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawHigherOrderReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawHigherOrderReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawHigherOrderReflections_Offset), 0, DrawHigherOrderReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:DrawDiffraction")]
	public bool DrawDiffraction
	{
		get
		{
			CheckDestroyed();
			if (!DrawDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawDiffraction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDiffraction_Offset), 0, DrawDiffraction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:DrawDiffraction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDiffraction_Offset), 0, DrawDiffraction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:AttenuationScalingFactor")]
	public float AttenuationScalingFactor
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationScalingFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:AttenuationScalingFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttenuationScalingFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationScalingFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:AttenuationScalingFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttenuationScalingFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:OcclusionRefreshInterval")]
	public float OcclusionRefreshInterval
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:OcclusionRefreshInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OcclusionRefreshInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionRefreshInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:OcclusionRefreshInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OcclusionRefreshInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkComponent:bUseReverbVolumes")]
	public bool UseReverbVolumes
	{
		get
		{
			CheckDestroyed();
			if (!UseReverbVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:bUseReverbVolumes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseReverbVolumes_Offset), 0, UseReverbVolumes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseReverbVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkComponent:bUseReverbVolumes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseReverbVolumes_Offset), 0, UseReverbVolumes_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetSwitch")]
	public unsafe void SetSwitch(UAkSwitchValue SwitchValue, string SwitchGroup, string SwitchState)
	{
		CheckDestroyed();
		if (!SetSwitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetSwitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSwitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSwitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkSwitchValue>.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchValue_Offset), 0, SetSwitch_SwitchValue_PropertyAddress.Address, SwitchValue);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchGroup_Offset), 0, SetSwitch_SwitchGroup_PropertyAddress.Address, SwitchGroup);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchState_Offset), 0, SetSwitch_SwitchState_PropertyAddress.Address, SwitchState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSwitch_FunctionAddress, intPtr, SetSwitch_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSwitch_SwitchGroup_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetSwitch_SwitchState_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetStopWhenOwnerDestroyed")]
	public unsafe void SetStopWhenOwnerDestroyed(bool bStopWhenOwnerDestroyed)
	{
		CheckDestroyed();
		if (!SetStopWhenOwnerDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetStopWhenOwnerDestroyed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStopWhenOwnerDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStopWhenOwnerDestroyed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_Offset), 0, SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_PropertyAddress.Address, bStopWhenOwnerDestroyed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStopWhenOwnerDestroyed_FunctionAddress, intPtr, SetStopWhenOwnerDestroyed_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetOutputBusVolume")]
	public unsafe void SetOutputBusVolume(float BusVolume)
	{
		CheckDestroyed();
		if (!SetOutputBusVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetOutputBusVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputBusVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputBusVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOutputBusVolume_BusVolume_Offset), 0, SetOutputBusVolume_BusVolume_PropertyAddress.Address, BusVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOutputBusVolume_FunctionAddress, intPtr, SetOutputBusVolume_ParamsSize);
	}

	[UFunction(Flags = 71435273u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetListeners")]
	public unsafe void SetListeners(List<UAkComponent> Listeners)
	{
		CheckDestroyed();
		if (!SetListeners_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetListeners");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetListeners_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetListeners_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAkComponent>(1, SetListeners_Listeners_PropertyAddress, CachedMarshalingDelegates<UAkComponent, UObjectMarshaler<UAkComponent>>.FromNative, CachedMarshalingDelegates<UAkComponent, UObjectMarshaler<UAkComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, SetListeners_Listeners_Offset), Listeners);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetListeners_FunctionAddress, intPtr, SetListeners_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetListeners_Listeners_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetGameObjectRadius")]
	public unsafe void SetGameObjectRadius(float in_outerRadius, float in_innerRadius)
	{
		CheckDestroyed();
		if (!SetGameObjectRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetGameObjectRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGameObjectRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGameObjectRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGameObjectRadius_in_outerRadius_Offset), 0, SetGameObjectRadius_in_outerRadius_PropertyAddress.Address, in_outerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGameObjectRadius_in_innerRadius_Offset), 0, SetGameObjectRadius_in_innerRadius_PropertyAddress.Address, in_innerRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGameObjectRadius_FunctionAddress, intPtr, SetGameObjectRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetEnableSpotReflectors")]
	public unsafe void SetEnableSpotReflectors(bool in_enable)
	{
		CheckDestroyed();
		if (!SetEnableSpotReflectors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetEnableSpotReflectors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableSpotReflectors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableSpotReflectors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableSpotReflectors_in_enable_Offset), 0, SetEnableSpotReflectors_in_enable_PropertyAddress.Address, in_enable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableSpotReflectors_FunctionAddress, intPtr, SetEnableSpotReflectors_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetEarlyReflectionsVolume")]
	public unsafe void SetEarlyReflectionsVolume(float SendVolume)
	{
		CheckDestroyed();
		if (!SetEarlyReflectionsVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetEarlyReflectionsVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEarlyReflectionsVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEarlyReflectionsVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEarlyReflectionsVolume_SendVolume_Offset), 0, SetEarlyReflectionsVolume_SendVolume_PropertyAddress.Address, SendVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEarlyReflectionsVolume_FunctionAddress, intPtr, SetEarlyReflectionsVolume_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetEarlyReflectionsAuxBus")]
	public unsafe void SetEarlyReflectionsAuxBus(string AuxBusName)
	{
		CheckDestroyed();
		if (!SetEarlyReflectionsAuxBus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetEarlyReflectionsAuxBus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEarlyReflectionsAuxBus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEarlyReflectionsAuxBus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEarlyReflectionsAuxBus_AuxBusName_Offset), 0, SetEarlyReflectionsAuxBus_AuxBusName_PropertyAddress.Address, AuxBusName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEarlyReflectionsAuxBus_FunctionAddress, intPtr, SetEarlyReflectionsAuxBus_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEarlyReflectionsAuxBus_AuxBusName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetAutoDestroyCS")]
	public unsafe void SetAutoDestroyCS(bool _bAutoDestory)
	{
		CheckDestroyed();
		if (!SetAutoDestroyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetAutoDestroyCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoDestroyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoDestroyCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoDestroyCS__bAutoDestory_Offset), 0, SetAutoDestroyCS__bAutoDestory_PropertyAddress.Address, _bAutoDestory);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoDestroyCS_FunctionAddress, intPtr, SetAutoDestroyCS_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:SetAttenuationScalingFactor")]
	public unsafe void SetAttenuationScalingFactor(float Value)
	{
		CheckDestroyed();
		if (!SetAttenuationScalingFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:SetAttenuationScalingFactor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttenuationScalingFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttenuationScalingFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAttenuationScalingFactor_Value_Offset), 0, SetAttenuationScalingFactor_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttenuationScalingFactor_FunctionAddress, intPtr, SetAttenuationScalingFactor_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkComponent:PostTrigger")]
	public unsafe void PostTrigger(UAkTrigger TriggerValue, string Trigger)
	{
		CheckDestroyed();
		if (!PostTrigger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:PostTrigger");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostTrigger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostTrigger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkTrigger>.ToNative(IntPtr.Add(intPtr, PostTrigger_TriggerValue_Offset), 0, PostTrigger_TriggerValue_PropertyAddress.Address, TriggerValue);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostTrigger_Trigger_Offset), 0, PostTrigger_Trigger_PropertyAddress.Address, Trigger);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostTrigger_FunctionAddress, intPtr, PostTrigger_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostTrigger_Trigger_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:PostAssociatedAkEventAndWaitForEnd")]
	public unsafe int PostAssociatedAkEventAndWaitForEnd(FLatentActionInfo LatentInfo)
	{
		CheckDestroyed();
		if (!PostAssociatedAkEventAndWaitForEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:PostAssociatedAkEventAndWaitForEnd");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAssociatedAkEventAndWaitForEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAssociatedAkEventAndWaitForEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PostAssociatedAkEventAndWaitForEnd_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEventAndWaitForEnd_LatentInfo_Offset), 0, PostAssociatedAkEventAndWaitForEnd_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAssociatedAkEventAndWaitForEnd_FunctionAddress, intPtr, PostAssociatedAkEventAndWaitForEnd_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAssociatedAkEventAndWaitForEnd_ReturnValue_Offset), 0, PostAssociatedAkEventAndWaitForEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:PostAkEventAndWaitForEnd")]
	public unsafe int PostAkEventAndWaitForEnd(UAkAudioEvent AkEvent, string in_EventName, FLatentActionInfo LatentInfo)
	{
		CheckDestroyed();
		if (!PostAkEventAndWaitForEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:PostAkEventAndWaitForEnd");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAkEventAndWaitForEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAkEventAndWaitForEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostAkEventAndWaitForEnd_AkEvent_Offset), 0, PostAkEventAndWaitForEnd_AkEvent_PropertyAddress.Address, AkEvent);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostAkEventAndWaitForEnd_in_EventName_Offset), 0, PostAkEventAndWaitForEnd_in_EventName_PropertyAddress.Address, in_EventName);
		NativeReflection.InitializeValue_InContainer(PostAkEventAndWaitForEnd_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostAkEventAndWaitForEnd_LatentInfo_Offset), 0, PostAkEventAndWaitForEnd_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAkEventAndWaitForEnd_FunctionAddress, intPtr, PostAkEventAndWaitForEnd_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostAkEventAndWaitForEnd_in_EventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAkEventAndWaitForEnd_ReturnValue_Offset), 0, PostAkEventAndWaitForEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:HasActiveEventsCS")]
	public unsafe bool HasActiveEventsCS()
	{
		CheckDestroyed();
		if (!HasActiveEventsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:HasActiveEventsCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasActiveEventsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasActiveEventsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasActiveEventsCS_FunctionAddress, intPtr, HasActiveEventsCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasActiveEventsCS_ReturnValue_Offset), 0, HasActiveEventsCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkComponent:GetOcclusionCollisionChannel")]
	public unsafe ECollisionChannel GetOcclusionCollisionChannel()
	{
		CheckDestroyed();
		if (!GetOcclusionCollisionChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:GetOcclusionCollisionChannel");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOcclusionCollisionChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOcclusionCollisionChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOcclusionCollisionChannel_FunctionAddress, intPtr, GetOcclusionCollisionChannel_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, GetOcclusionCollisionChannel_ReturnValue_Offset), 0, GetOcclusionCollisionChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/AkAudio.AkComponent:GetAttenuationRadius")]
	public unsafe float GetAttenuationRadius()
	{
		CheckDestroyed();
		if (!GetAttenuationRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkComponent:GetAttenuationRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttenuationRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttenuationRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttenuationRadius_FunctionAddress, intPtr, GetAttenuationRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAttenuationRadius_ReturnValue_Offset), 0, GetAttenuationRadius_ReturnValue_PropertyAddress.Address);
	}

	static UAkComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkComponent");
		NativeReflectionCached.GetPropertyRef(ref OcclusionCollisionChannel_PropertyAddress, intPtr, "OcclusionCollisionChannel");
		OcclusionCollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionCollisionChannel");
		OcclusionCollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionCollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSpotReflectors_PropertyAddress, intPtr, "EnableSpotReflectors");
		EnableSpotReflectors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableSpotReflectors");
		EnableSpotReflectors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableSpotReflectors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableUpdateSpatialAudioRoom_PropertyAddress, intPtr, "bDisableUpdateSpatialAudioRoom");
		DisableUpdateSpatialAudioRoom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableUpdateSpatialAudioRoom");
		DisableUpdateSpatialAudioRoom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableUpdateSpatialAudioRoom", Classes.FBoolProperty);
		outerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "outerRadius");
		outerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "outerRadius", Classes.FFloatProperty);
		innerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "innerRadius");
		innerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "innerRadius", Classes.FFloatProperty);
		OnAkCompAutoDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAkCompAutoDestroyed");
		OnAkCompAutoDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAkCompAutoDestroyed", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawFirstOrderReflections_PropertyAddress, intPtr, "DrawFirstOrderReflections");
		DrawFirstOrderReflections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawFirstOrderReflections");
		DrawFirstOrderReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawFirstOrderReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSecondOrderReflections_PropertyAddress, intPtr, "DrawSecondOrderReflections");
		DrawSecondOrderReflections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawSecondOrderReflections");
		DrawSecondOrderReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawSecondOrderReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawHigherOrderReflections_PropertyAddress, intPtr, "DrawHigherOrderReflections");
		DrawHigherOrderReflections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawHigherOrderReflections");
		DrawHigherOrderReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawHigherOrderReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDiffraction_PropertyAddress, intPtr, "DrawDiffraction");
		DrawDiffraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawDiffraction");
		DrawDiffraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawDiffraction", Classes.FBoolProperty);
		AttenuationScalingFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationScalingFactor");
		AttenuationScalingFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationScalingFactor", Classes.FFloatProperty);
		OcclusionRefreshInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionRefreshInterval");
		OcclusionRefreshInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionRefreshInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseReverbVolumes_PropertyAddress, intPtr, "bUseReverbVolumes");
		UseReverbVolumes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseReverbVolumes");
		UseReverbVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseReverbVolumes", Classes.FBoolProperty);
		SetSwitch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSwitch");
		SetSwitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSwitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchValue_PropertyAddress, SetSwitch_FunctionAddress, "SwitchValue");
		SetSwitch_SwitchValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchValue");
		SetSwitch_SwitchValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchGroup_PropertyAddress, SetSwitch_FunctionAddress, "SwitchGroup");
		SetSwitch_SwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchGroup");
		SetSwitch_SwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchGroup", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchState_PropertyAddress, SetSwitch_FunctionAddress, "SwitchState");
		SetSwitch_SwitchState_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchState");
		SetSwitch_SwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchState", Classes.FStrProperty);
		SetSwitch_IsValid = SetSwitch_FunctionAddress != IntPtr.Zero && SetSwitch_SwitchValue_IsValid && SetSwitch_SwitchGroup_IsValid && SetSwitch_SwitchState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetSwitch", SetSwitch_IsValid);
		SetStopWhenOwnerDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStopWhenOwnerDestroyed");
		SetStopWhenOwnerDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStopWhenOwnerDestroyed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_PropertyAddress, SetStopWhenOwnerDestroyed_FunctionAddress, "bStopWhenOwnerDestroyed");
		SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(SetStopWhenOwnerDestroyed_FunctionAddress, "bStopWhenOwnerDestroyed");
		SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStopWhenOwnerDestroyed_FunctionAddress, "bStopWhenOwnerDestroyed", Classes.FBoolProperty);
		SetStopWhenOwnerDestroyed_IsValid = SetStopWhenOwnerDestroyed_FunctionAddress != IntPtr.Zero && SetStopWhenOwnerDestroyed_bStopWhenOwnerDestroyed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetStopWhenOwnerDestroyed", SetStopWhenOwnerDestroyed_IsValid);
		SetOutputBusVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOutputBusVolume");
		SetOutputBusVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputBusVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputBusVolume_BusVolume_PropertyAddress, SetOutputBusVolume_FunctionAddress, "BusVolume");
		SetOutputBusVolume_BusVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputBusVolume_FunctionAddress, "BusVolume");
		SetOutputBusVolume_BusVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputBusVolume_FunctionAddress, "BusVolume", Classes.FFloatProperty);
		SetOutputBusVolume_IsValid = SetOutputBusVolume_FunctionAddress != IntPtr.Zero && SetOutputBusVolume_BusVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetOutputBusVolume", SetOutputBusVolume_IsValid);
		SetListeners_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetListeners");
		SetListeners_ParamsSize = NativeReflection.GetFunctionParamsSize(SetListeners_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetListeners_Listeners_PropertyAddress, SetListeners_FunctionAddress, "Listeners");
		SetListeners_Listeners_Offset = NativeReflectionCached.GetPropertyOffset(SetListeners_FunctionAddress, "Listeners");
		SetListeners_Listeners_IsValid = NativeReflectionCached.ValidatePropertyClass(SetListeners_FunctionAddress, "Listeners", Classes.FArrayProperty);
		SetListeners_IsValid = SetListeners_FunctionAddress != IntPtr.Zero && SetListeners_Listeners_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetListeners", SetListeners_IsValid);
		SetGameObjectRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGameObjectRadius");
		SetGameObjectRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGameObjectRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGameObjectRadius_in_outerRadius_PropertyAddress, SetGameObjectRadius_FunctionAddress, "in_outerRadius");
		SetGameObjectRadius_in_outerRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetGameObjectRadius_FunctionAddress, "in_outerRadius");
		SetGameObjectRadius_in_outerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameObjectRadius_FunctionAddress, "in_outerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGameObjectRadius_in_innerRadius_PropertyAddress, SetGameObjectRadius_FunctionAddress, "in_innerRadius");
		SetGameObjectRadius_in_innerRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetGameObjectRadius_FunctionAddress, "in_innerRadius");
		SetGameObjectRadius_in_innerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameObjectRadius_FunctionAddress, "in_innerRadius", Classes.FFloatProperty);
		SetGameObjectRadius_IsValid = SetGameObjectRadius_FunctionAddress != IntPtr.Zero && SetGameObjectRadius_in_outerRadius_IsValid && SetGameObjectRadius_in_innerRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetGameObjectRadius", SetGameObjectRadius_IsValid);
		SetEnableSpotReflectors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableSpotReflectors");
		SetEnableSpotReflectors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableSpotReflectors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableSpotReflectors_in_enable_PropertyAddress, SetEnableSpotReflectors_FunctionAddress, "in_enable");
		SetEnableSpotReflectors_in_enable_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableSpotReflectors_FunctionAddress, "in_enable");
		SetEnableSpotReflectors_in_enable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableSpotReflectors_FunctionAddress, "in_enable", Classes.FBoolProperty);
		SetEnableSpotReflectors_IsValid = SetEnableSpotReflectors_FunctionAddress != IntPtr.Zero && SetEnableSpotReflectors_in_enable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetEnableSpotReflectors", SetEnableSpotReflectors_IsValid);
		SetEarlyReflectionsVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEarlyReflectionsVolume");
		SetEarlyReflectionsVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEarlyReflectionsVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEarlyReflectionsVolume_SendVolume_PropertyAddress, SetEarlyReflectionsVolume_FunctionAddress, "SendVolume");
		SetEarlyReflectionsVolume_SendVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetEarlyReflectionsVolume_FunctionAddress, "SendVolume");
		SetEarlyReflectionsVolume_SendVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEarlyReflectionsVolume_FunctionAddress, "SendVolume", Classes.FFloatProperty);
		SetEarlyReflectionsVolume_IsValid = SetEarlyReflectionsVolume_FunctionAddress != IntPtr.Zero && SetEarlyReflectionsVolume_SendVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetEarlyReflectionsVolume", SetEarlyReflectionsVolume_IsValid);
		SetEarlyReflectionsAuxBus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEarlyReflectionsAuxBus");
		SetEarlyReflectionsAuxBus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEarlyReflectionsAuxBus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEarlyReflectionsAuxBus_AuxBusName_PropertyAddress, SetEarlyReflectionsAuxBus_FunctionAddress, "AuxBusName");
		SetEarlyReflectionsAuxBus_AuxBusName_Offset = NativeReflectionCached.GetPropertyOffset(SetEarlyReflectionsAuxBus_FunctionAddress, "AuxBusName");
		SetEarlyReflectionsAuxBus_AuxBusName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEarlyReflectionsAuxBus_FunctionAddress, "AuxBusName", Classes.FStrProperty);
		SetEarlyReflectionsAuxBus_IsValid = SetEarlyReflectionsAuxBus_FunctionAddress != IntPtr.Zero && SetEarlyReflectionsAuxBus_AuxBusName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetEarlyReflectionsAuxBus", SetEarlyReflectionsAuxBus_IsValid);
		SetAutoDestroyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoDestroyCS");
		SetAutoDestroyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoDestroyCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoDestroyCS__bAutoDestory_PropertyAddress, SetAutoDestroyCS_FunctionAddress, "_bAutoDestory");
		SetAutoDestroyCS__bAutoDestory_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoDestroyCS_FunctionAddress, "_bAutoDestory");
		SetAutoDestroyCS__bAutoDestory_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoDestroyCS_FunctionAddress, "_bAutoDestory", Classes.FBoolProperty);
		SetAutoDestroyCS_IsValid = SetAutoDestroyCS_FunctionAddress != IntPtr.Zero && SetAutoDestroyCS__bAutoDestory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetAutoDestroyCS", SetAutoDestroyCS_IsValid);
		SetAttenuationScalingFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAttenuationScalingFactor");
		SetAttenuationScalingFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttenuationScalingFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttenuationScalingFactor_Value_PropertyAddress, SetAttenuationScalingFactor_FunctionAddress, "Value");
		SetAttenuationScalingFactor_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetAttenuationScalingFactor_FunctionAddress, "Value");
		SetAttenuationScalingFactor_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttenuationScalingFactor_FunctionAddress, "Value", Classes.FFloatProperty);
		SetAttenuationScalingFactor_IsValid = SetAttenuationScalingFactor_FunctionAddress != IntPtr.Zero && SetAttenuationScalingFactor_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:SetAttenuationScalingFactor", SetAttenuationScalingFactor_IsValid);
		PostTrigger_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostTrigger");
		PostTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(PostTrigger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostTrigger_TriggerValue_PropertyAddress, PostTrigger_FunctionAddress, "TriggerValue");
		PostTrigger_TriggerValue_Offset = NativeReflectionCached.GetPropertyOffset(PostTrigger_FunctionAddress, "TriggerValue");
		PostTrigger_TriggerValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostTrigger_FunctionAddress, "TriggerValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostTrigger_Trigger_PropertyAddress, PostTrigger_FunctionAddress, "Trigger");
		PostTrigger_Trigger_Offset = NativeReflectionCached.GetPropertyOffset(PostTrigger_FunctionAddress, "Trigger");
		PostTrigger_Trigger_IsValid = NativeReflectionCached.ValidatePropertyClass(PostTrigger_FunctionAddress, "Trigger", Classes.FStrProperty);
		PostTrigger_IsValid = PostTrigger_FunctionAddress != IntPtr.Zero && PostTrigger_TriggerValue_IsValid && PostTrigger_Trigger_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:PostTrigger", PostTrigger_IsValid);
		PostAssociatedAkEventAndWaitForEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAssociatedAkEventAndWaitForEnd");
		PostAssociatedAkEventAndWaitForEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAssociatedAkEventAndWaitForEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAndWaitForEnd_LatentInfo_PropertyAddress, PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "LatentInfo");
		PostAssociatedAkEventAndWaitForEnd_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "LatentInfo");
		PostAssociatedAkEventAndWaitForEnd_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAndWaitForEnd_ReturnValue_PropertyAddress, PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "ReturnValue");
		PostAssociatedAkEventAndWaitForEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "ReturnValue");
		PostAssociatedAkEventAndWaitForEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAndWaitForEnd_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAssociatedAkEventAndWaitForEnd_IsValid = PostAssociatedAkEventAndWaitForEnd_FunctionAddress != IntPtr.Zero && PostAssociatedAkEventAndWaitForEnd_LatentInfo_IsValid && PostAssociatedAkEventAndWaitForEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:PostAssociatedAkEventAndWaitForEnd", PostAssociatedAkEventAndWaitForEnd_IsValid);
		PostAkEventAndWaitForEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAkEventAndWaitForEnd");
		PostAkEventAndWaitForEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAkEventAndWaitForEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAndWaitForEnd_AkEvent_PropertyAddress, PostAkEventAndWaitForEnd_FunctionAddress, "AkEvent");
		PostAkEventAndWaitForEnd_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAndWaitForEnd_FunctionAddress, "AkEvent");
		PostAkEventAndWaitForEnd_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAndWaitForEnd_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAndWaitForEnd_in_EventName_PropertyAddress, PostAkEventAndWaitForEnd_FunctionAddress, "in_EventName");
		PostAkEventAndWaitForEnd_in_EventName_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAndWaitForEnd_FunctionAddress, "in_EventName");
		PostAkEventAndWaitForEnd_in_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAndWaitForEnd_FunctionAddress, "in_EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAndWaitForEnd_LatentInfo_PropertyAddress, PostAkEventAndWaitForEnd_FunctionAddress, "LatentInfo");
		PostAkEventAndWaitForEnd_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAndWaitForEnd_FunctionAddress, "LatentInfo");
		PostAkEventAndWaitForEnd_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAndWaitForEnd_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAndWaitForEnd_ReturnValue_PropertyAddress, PostAkEventAndWaitForEnd_FunctionAddress, "ReturnValue");
		PostAkEventAndWaitForEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAndWaitForEnd_FunctionAddress, "ReturnValue");
		PostAkEventAndWaitForEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAndWaitForEnd_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAkEventAndWaitForEnd_IsValid = PostAkEventAndWaitForEnd_FunctionAddress != IntPtr.Zero && PostAkEventAndWaitForEnd_AkEvent_IsValid && PostAkEventAndWaitForEnd_in_EventName_IsValid && PostAkEventAndWaitForEnd_LatentInfo_IsValid && PostAkEventAndWaitForEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:PostAkEventAndWaitForEnd", PostAkEventAndWaitForEnd_IsValid);
		HasActiveEventsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasActiveEventsCS");
		HasActiveEventsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HasActiveEventsCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasActiveEventsCS_ReturnValue_PropertyAddress, HasActiveEventsCS_FunctionAddress, "ReturnValue");
		HasActiveEventsCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasActiveEventsCS_FunctionAddress, "ReturnValue");
		HasActiveEventsCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasActiveEventsCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasActiveEventsCS_IsValid = HasActiveEventsCS_FunctionAddress != IntPtr.Zero && HasActiveEventsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:HasActiveEventsCS", HasActiveEventsCS_IsValid);
		GetOcclusionCollisionChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOcclusionCollisionChannel");
		GetOcclusionCollisionChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOcclusionCollisionChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOcclusionCollisionChannel_ReturnValue_PropertyAddress, GetOcclusionCollisionChannel_FunctionAddress, "ReturnValue");
		GetOcclusionCollisionChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOcclusionCollisionChannel_FunctionAddress, "ReturnValue");
		GetOcclusionCollisionChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOcclusionCollisionChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetOcclusionCollisionChannel_IsValid = GetOcclusionCollisionChannel_FunctionAddress != IntPtr.Zero && GetOcclusionCollisionChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:GetOcclusionCollisionChannel", GetOcclusionCollisionChannel_IsValid);
		GetAttenuationRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttenuationRadius");
		GetAttenuationRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttenuationRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationRadius_ReturnValue_PropertyAddress, GetAttenuationRadius_FunctionAddress, "ReturnValue");
		GetAttenuationRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationRadius_FunctionAddress, "ReturnValue");
		GetAttenuationRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAttenuationRadius_IsValid = GetAttenuationRadius_FunctionAddress != IntPtr.Zero && GetAttenuationRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkComponent:GetAttenuationRadius", GetAttenuationRadius_IsValid);
	}
}
