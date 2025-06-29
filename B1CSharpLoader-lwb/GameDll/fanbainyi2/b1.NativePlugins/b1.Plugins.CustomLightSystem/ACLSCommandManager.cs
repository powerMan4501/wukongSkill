using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSCommandManager", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSCommandManager : AActor
{
	private static bool LightManager_IsValid;

	private static int LightManager_Offset;

	private static bool VolumeManager_IsValid;

	private static int VolumeManager_Offset;

	private static bool CommandManagerID_IsValid;

	private static int CommandManagerID_Offset;

	private static bool SwitchLightsAndFogs_IsValid;

	private static IntPtr SwitchLightsAndFogs_FunctionAddress;

	private static int SwitchLightsAndFogs_ParamsSize;

	private static bool SwitchLightsAndFogs_InTargetDirectionalLight_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetDirectionalLight_Offset;

	private static bool SwitchLightsAndFogs_InTargetSkyLight_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetSkyLight_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetSkyLight_Offset;

	private static bool SwitchLightsAndFogs_InTargetAtmosphericFog_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetAtmosphericFog_Offset;

	private static bool SwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetExponentialHeightFog_Offset;

	private static bool SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset;

	private static bool SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress;

	private static int SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset;

	private static bool SwitchLightsAndFogs_InTargetVolumePercentage_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress;

	private static int SwitchLightsAndFogs_InTargetVolumePercentage_Offset;

	private static bool SwitchLightsAndFogs_ForceUpdate_IsValid;

	private static FFieldAddress SwitchLightsAndFogs_ForceUpdate_PropertyAddress;

	private static int SwitchLightsAndFogs_ForceUpdate_Offset;

	private static bool SafelySwitchLightsAndFogs_IsValid;

	private static IntPtr SafelySwitchLightsAndFogs_FunctionAddress;

	private static int SafelySwitchLightsAndFogs_ParamsSize;

	private static bool SafelySwitchLightsAndFogs_InTargetDirectionalLight_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetDirectionalLight_Offset;

	private static bool SafelySwitchLightsAndFogs_InTargetSkyLight_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetSkyLight_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetSkyLight_Offset;

	private static bool SafelySwitchLightsAndFogs_InTargetAtmosphericFog_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetAtmosphericFog_Offset;

	private static bool SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_Offset;

	private static bool SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset;

	private static bool SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset;

	private static bool SafelySwitchLightsAndFogs_InTargetVolumePercentage_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_InTargetVolumePercentage_Offset;

	private static bool SafelySwitchLightsAndFogs_ForceUpdate_IsValid;

	private static FFieldAddress SafelySwitchLightsAndFogs_ForceUpdate_PropertyAddress;

	private static int SafelySwitchLightsAndFogs_ForceUpdate_Offset;

	private static bool ReactiveAnotherManager_IsValid;

	private static IntPtr ReactiveAnotherManager_FunctionAddress;

	private static int ReactiveAnotherManager_ParamsSize;

	private static bool InterruptAnotherManager_IsValid;

	private static IntPtr InterruptAnotherManager_FunctionAddress;

	private static int InterruptAnotherManager_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:LightManager")]
	public ACLSLightManager LightManager
	{
		get
		{
			CheckDestroyed();
			if (!LightManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:LightManager");
				return null;
			}
			return UObjectMarshaler<ACLSLightManager>.FromNative(IntPtr.Add(base.Address, LightManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:LightManager");
			}
			else
			{
				UObjectMarshaler<ACLSLightManager>.ToNative(IntPtr.Add(base.Address, LightManager_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:VolumeManager")]
	public ACLSVolumeManager VolumeManager
	{
		get
		{
			CheckDestroyed();
			if (!VolumeManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:VolumeManager");
				return null;
			}
			return UObjectMarshaler<ACLSVolumeManager>.FromNative(IntPtr.Add(base.Address, VolumeManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:VolumeManager");
			}
			else
			{
				UObjectMarshaler<ACLSVolumeManager>.ToNative(IntPtr.Add(base.Address, VolumeManager_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:CommandManagerID")]
	public int CommandManagerID
	{
		get
		{
			CheckDestroyed();
			if (!CommandManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:CommandManagerID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CommandManagerID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommandManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSCommandManager:CommandManagerID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CommandManagerID_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:SwitchLightsAndFogs")]
	public unsafe void SwitchLightsAndFogs(ADirectionalLight InTargetDirectionalLight, ASkyLight InTargetSkyLight, ASkyAtmosphere InTargetAtmosphericFog, AExponentialHeightFog InTargetExponentialHeightFog, FCLSMaterialParametersCollectionProperty InTargetCLSVolumeMPCProperty, FCLSMaterialParametersCollectionProperty InOriginalCLSVolumeMPCProperty, float InTargetVolumePercentage, bool ForceUpdate = false)
	{
		CheckDestroyed();
		if (!SwitchLightsAndFogs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSCommandManager:SwitchLightsAndFogs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchLightsAndFogs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchLightsAndFogs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetDirectionalLight_Offset), 0, SwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress.Address, InTargetDirectionalLight);
		UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetSkyLight_Offset), 0, SwitchLightsAndFogs_InTargetSkyLight_PropertyAddress.Address, InTargetSkyLight);
		UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetAtmosphericFog_Offset), 0, SwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress.Address, InTargetAtmosphericFog);
		UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetExponentialHeightFog_Offset), 0, SwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress.Address, InTargetExponentialHeightFog);
		NativeReflection.InitializeValue_InContainer(SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		FCLSMaterialParametersCollectionProperty.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset), 0, SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, InTargetCLSVolumeMPCProperty);
		NativeReflection.InitializeValue_InContainer(SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		FCLSMaterialParametersCollectionProperty.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset), 0, SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, InOriginalCLSVolumeMPCProperty);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_InTargetVolumePercentage_Offset), 0, SwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress.Address, InTargetVolumePercentage);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchLightsAndFogs_ForceUpdate_Offset), 0, SwitchLightsAndFogs_ForceUpdate_PropertyAddress.Address, ForceUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchLightsAndFogs_FunctionAddress, intPtr, SwitchLightsAndFogs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:SafelySwitchLightsAndFogs")]
	public unsafe void SafelySwitchLightsAndFogs(ADirectionalLight InTargetDirectionalLight, ASkyLight InTargetSkyLight, ASkyAtmosphere InTargetAtmosphericFog, AExponentialHeightFog InTargetExponentialHeightFog, FCLSMaterialParametersCollectionProperty InTargetCLSVolumeMPCProperty, FCLSMaterialParametersCollectionProperty InOriginalCLSVolumeMPCProperty, float InTargetVolumePercentage, bool ForceUpdate = false)
	{
		CheckDestroyed();
		if (!SafelySwitchLightsAndFogs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSCommandManager:SafelySwitchLightsAndFogs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SafelySwitchLightsAndFogs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SafelySwitchLightsAndFogs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetDirectionalLight_Offset), 0, SafelySwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress.Address, InTargetDirectionalLight);
		UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetSkyLight_Offset), 0, SafelySwitchLightsAndFogs_InTargetSkyLight_PropertyAddress.Address, InTargetSkyLight);
		UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetAtmosphericFog_Offset), 0, SafelySwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress.Address, InTargetAtmosphericFog);
		UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_Offset), 0, SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress.Address, InTargetExponentialHeightFog);
		NativeReflection.InitializeValue_InContainer(SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		FCLSMaterialParametersCollectionProperty.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset), 0, SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, InTargetCLSVolumeMPCProperty);
		NativeReflection.InitializeValue_InContainer(SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		FCLSMaterialParametersCollectionProperty.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset), 0, SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, InOriginalCLSVolumeMPCProperty);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_InTargetVolumePercentage_Offset), 0, SafelySwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress.Address, InTargetVolumePercentage);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SafelySwitchLightsAndFogs_ForceUpdate_Offset), 0, SafelySwitchLightsAndFogs_ForceUpdate_PropertyAddress.Address, ForceUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SafelySwitchLightsAndFogs_FunctionAddress, intPtr, SafelySwitchLightsAndFogs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:ReactiveAnotherManager")]
	public unsafe void ReactiveAnotherManager()
	{
		CheckDestroyed();
		if (!ReactiveAnotherManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSCommandManager:ReactiveAnotherManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReactiveAnotherManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReactiveAnotherManager_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReactiveAnotherManager_FunctionAddress, argsSize: ReactiveAnotherManager_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSCommandManager:InterruptAnotherManager")]
	public unsafe void InterruptAnotherManager()
	{
		CheckDestroyed();
		if (!InterruptAnotherManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSCommandManager:InterruptAnotherManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InterruptAnotherManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InterruptAnotherManager_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InterruptAnotherManager_FunctionAddress, argsSize: InterruptAnotherManager_ParamsSize);
	}

	static ACLSCommandManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSCommandManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSCommandManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSCommandManager");
		LightManager_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightManager");
		LightManager_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightManager", Classes.FObjectProperty);
		VolumeManager_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeManager");
		VolumeManager_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeManager", Classes.FObjectProperty);
		CommandManagerID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CommandManagerID");
		CommandManagerID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CommandManagerID", Classes.FIntProperty);
		SwitchLightsAndFogs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchLightsAndFogs");
		SwitchLightsAndFogs_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchLightsAndFogs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight");
		SwitchLightsAndFogs_InTargetDirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight");
		SwitchLightsAndFogs_InTargetDirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetSkyLight_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight");
		SwitchLightsAndFogs_InTargetSkyLight_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight");
		SwitchLightsAndFogs_InTargetSkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog");
		SwitchLightsAndFogs_InTargetAtmosphericFog_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog");
		SwitchLightsAndFogs_InTargetAtmosphericFog_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog");
		SwitchLightsAndFogs_InTargetExponentialHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog");
		SwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty");
		SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty");
		SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty");
		SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty");
		SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage");
		SwitchLightsAndFogs_InTargetVolumePercentage_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage");
		SwitchLightsAndFogs_InTargetVolumePercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchLightsAndFogs_ForceUpdate_PropertyAddress, SwitchLightsAndFogs_FunctionAddress, "ForceUpdate");
		SwitchLightsAndFogs_ForceUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLightsAndFogs_FunctionAddress, "ForceUpdate");
		SwitchLightsAndFogs_ForceUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLightsAndFogs_FunctionAddress, "ForceUpdate", Classes.FBoolProperty);
		SwitchLightsAndFogs_IsValid = SwitchLightsAndFogs_FunctionAddress != IntPtr.Zero && SwitchLightsAndFogs_InTargetDirectionalLight_IsValid && SwitchLightsAndFogs_InTargetSkyLight_IsValid && SwitchLightsAndFogs_InTargetAtmosphericFog_IsValid && SwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid && SwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid && SwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid && SwitchLightsAndFogs_InTargetVolumePercentage_IsValid && SwitchLightsAndFogs_ForceUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSCommandManager:SwitchLightsAndFogs", SwitchLightsAndFogs_IsValid);
		SafelySwitchLightsAndFogs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SafelySwitchLightsAndFogs");
		SafelySwitchLightsAndFogs_ParamsSize = NativeReflection.GetFunctionParamsSize(SafelySwitchLightsAndFogs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetDirectionalLight_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight");
		SafelySwitchLightsAndFogs_InTargetDirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight");
		SafelySwitchLightsAndFogs_InTargetDirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetDirectionalLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetSkyLight_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight");
		SafelySwitchLightsAndFogs_InTargetSkyLight_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight");
		SafelySwitchLightsAndFogs_InTargetSkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetSkyLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetAtmosphericFog_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog");
		SafelySwitchLightsAndFogs_InTargetAtmosphericFog_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog");
		SafelySwitchLightsAndFogs_InTargetAtmosphericFog_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetAtmosphericFog", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog");
		SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog");
		SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetExponentialHeightFog", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty");
		SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty");
		SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetCLSVolumeMPCProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty");
		SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty");
		SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InOriginalCLSVolumeMPCProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_InTargetVolumePercentage_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage");
		SafelySwitchLightsAndFogs_InTargetVolumePercentage_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage");
		SafelySwitchLightsAndFogs_InTargetVolumePercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "InTargetVolumePercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SafelySwitchLightsAndFogs_ForceUpdate_PropertyAddress, SafelySwitchLightsAndFogs_FunctionAddress, "ForceUpdate");
		SafelySwitchLightsAndFogs_ForceUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SafelySwitchLightsAndFogs_FunctionAddress, "ForceUpdate");
		SafelySwitchLightsAndFogs_ForceUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SafelySwitchLightsAndFogs_FunctionAddress, "ForceUpdate", Classes.FBoolProperty);
		SafelySwitchLightsAndFogs_IsValid = SafelySwitchLightsAndFogs_FunctionAddress != IntPtr.Zero && SafelySwitchLightsAndFogs_InTargetDirectionalLight_IsValid && SafelySwitchLightsAndFogs_InTargetSkyLight_IsValid && SafelySwitchLightsAndFogs_InTargetAtmosphericFog_IsValid && SafelySwitchLightsAndFogs_InTargetExponentialHeightFog_IsValid && SafelySwitchLightsAndFogs_InTargetCLSVolumeMPCProperty_IsValid && SafelySwitchLightsAndFogs_InOriginalCLSVolumeMPCProperty_IsValid && SafelySwitchLightsAndFogs_InTargetVolumePercentage_IsValid && SafelySwitchLightsAndFogs_ForceUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSCommandManager:SafelySwitchLightsAndFogs", SafelySwitchLightsAndFogs_IsValid);
		ReactiveAnotherManager_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReactiveAnotherManager");
		ReactiveAnotherManager_ParamsSize = NativeReflection.GetFunctionParamsSize(ReactiveAnotherManager_FunctionAddress);
		ReactiveAnotherManager_IsValid = ReactiveAnotherManager_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSCommandManager:ReactiveAnotherManager", ReactiveAnotherManager_IsValid);
		InterruptAnotherManager_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InterruptAnotherManager");
		InterruptAnotherManager_ParamsSize = NativeReflection.GetFunctionParamsSize(InterruptAnotherManager_FunctionAddress);
		InterruptAnotherManager_IsValid = InterruptAnotherManager_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSCommandManager:InterruptAnotherManager", InterruptAnotherManager_IsValid);
	}
}
