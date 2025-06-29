using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSVolumeManager : AActor
{
	private static bool LightManager_IsValid;

	private static int LightManager_Offset;

	private static bool VolumeManagerID_IsValid;

	private static int VolumeManagerID_Offset;

	private static bool IsSwitchActive_IsValid;

	private static FFieldAddress IsSwitchActive_PropertyAddress;

	private static int IsSwitchActive_Offset;

	private static bool IsCheckWARP_IsValid;

	private static FFieldAddress IsCheckWARP_PropertyAddress;

	private static int IsCheckWARP_Offset;

	private static bool WARPDistance_IsValid;

	private static int WARPDistance_Offset;

	private static bool IsDebug_IsValid;

	private static FFieldAddress IsDebug_PropertyAddress;

	private static int IsDebug_Offset;

	private static bool IsForcePPV_IsValid;

	private static FFieldAddress IsForcePPV_PropertyAddress;

	private static int IsForcePPV_Offset;

	private static bool ValidDirectionalLight_IsValid;

	private static int ValidDirectionalLight_Offset;

	private static bool ValidSkyLight_IsValid;

	private static int ValidSkyLight_Offset;

	private static bool ValidAtmosphericFog_IsValid;

	private static int ValidAtmosphericFog_Offset;

	private static bool ValidExponentialHeightFog_IsValid;

	private static int ValidExponentialHeightFog_Offset;

	private static bool ValidCLSBaseVolume_IsValid;

	private static int ValidCLSBaseVolume_Offset;

	private static bool SetUniqueValidAtRuntime_IsValid;

	private static IntPtr SetUniqueValidAtRuntime_FunctionAddress;

	private static int SetUniqueValidAtRuntime_ParamsSize;

	private static bool SetLightManagerActive_IsValid;

	private static IntPtr SetLightManagerActive_FunctionAddress;

	private static int SetLightManagerActive_ParamsSize;

	private static bool SetLightManagerActive_NewActive_IsValid;

	private static FFieldAddress SetLightManagerActive_NewActive_PropertyAddress;

	private static int SetLightManagerActive_NewActive_Offset;

	private static bool GetValidVolumeByWeight_IsValid;

	private static IntPtr GetValidVolumeByWeight_FunctionAddress;

	private static int GetValidVolumeByWeight_ParamsSize;

	private static bool GetValidVolumeByWeight_Position_IsValid;

	private static FFieldAddress GetValidVolumeByWeight_Position_PropertyAddress;

	private static int GetValidVolumeByWeight_Position_Offset;

	private static bool GetValidVolumeByWeight_ReturnValue_IsValid;

	private static FFieldAddress GetValidVolumeByWeight_ReturnValue_PropertyAddress;

	private static int GetValidVolumeByWeight_ReturnValue_Offset;

	private static bool GetCurrentVolume_IsValid;

	private static IntPtr GetCurrentVolume_FunctionAddress;

	private static int GetCurrentVolume_ParamsSize;

	private static bool GetCurrentVolume_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentVolume_ReturnValue_PropertyAddress;

	private static int GetCurrentVolume_ReturnValue_Offset;

	private static bool EditorSwitchToValidLightAndFog_IsValid;

	private static IntPtr EditorSwitchToValidLightAndFog_FunctionAddress;

	private static int EditorSwitchToValidLightAndFog_ParamsSize;

	private static bool EditorSetAllPointLightQualityLower_IsValid;

	private static IntPtr EditorSetAllPointLightQualityLower_FunctionAddress;

	private static int EditorSetAllPointLightQualityLower_ParamsSize;

	private static bool EditorSetAllDirectionalLightQualityLower_IsValid;

	private static IntPtr EditorSetAllDirectionalLightQualityLower_FunctionAddress;

	private static int EditorSetAllDirectionalLightQualityLower_ParamsSize;

	private static bool DisableOtherVolumeManager_IsValid;

	private static IntPtr DisableOtherVolumeManager_FunctionAddress;

	private static int DisableOtherVolumeManager_ParamsSize;

	private static bool DisableAllVolume_IsValid;

	private static IntPtr DisableAllVolume_FunctionAddress;

	private static int DisableAllVolume_ParamsSize;

	private static bool DebugCurrentVolume_IsValid;

	private static IntPtr DebugCurrentVolume_FunctionAddress;

	private static int DebugCurrentVolume_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:LightManager")]
	public ACLSLightManager LightManager
	{
		get
		{
			CheckDestroyed();
			if (!LightManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:LightManager");
				return null;
			}
			return UObjectMarshaler<ACLSLightManager>.FromNative(IntPtr.Add(base.Address, LightManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:LightManager");
			}
			else
			{
				UObjectMarshaler<ACLSLightManager>.ToNative(IntPtr.Add(base.Address, LightManager_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:VolumeManagerID")]
	public int VolumeManagerID
	{
		get
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:VolumeManagerID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VolumeManagerID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:VolumeManagerID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VolumeManagerID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:bIsSwitchActive")]
	public bool IsSwitchActive
	{
		get
		{
			CheckDestroyed();
			if (!IsSwitchActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsSwitchActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSwitchActive_Offset), 0, IsSwitchActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSwitchActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsSwitchActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSwitchActive_Offset), 0, IsSwitchActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:bIsCheckWARP")]
	public bool IsCheckWARP
	{
		get
		{
			CheckDestroyed();
			if (!IsCheckWARP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsCheckWARP");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCheckWARP_Offset), 0, IsCheckWARP_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCheckWARP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsCheckWARP");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCheckWARP_Offset), 0, IsCheckWARP_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:WARPDistance")]
	public float WARPDistance
	{
		get
		{
			CheckDestroyed();
			if (!WARPDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:WARPDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WARPDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WARPDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:WARPDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WARPDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:bIsDebug")]
	public bool IsDebug
	{
		get
		{
			CheckDestroyed();
			if (!IsDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebug_Offset), 0, IsDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebug_Offset), 0, IsDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:bIsForcePPV")]
	public bool IsForcePPV
	{
		get
		{
			CheckDestroyed();
			if (!IsForcePPV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsForcePPV");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsForcePPV_Offset), 0, IsForcePPV_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsForcePPV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:bIsForcePPV");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsForcePPV_Offset), 0, IsForcePPV_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:ValidDirectionalLight")]
	public ADirectionalLight ValidDirectionalLight
	{
		get
		{
			CheckDestroyed();
			if (!ValidDirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidDirectionalLight");
				return null;
			}
			return UObjectMarshaler<ADirectionalLight>.FromNative(IntPtr.Add(base.Address, ValidDirectionalLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidDirectionalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidDirectionalLight");
			}
			else
			{
				UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(base.Address, ValidDirectionalLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:ValidSkyLight")]
	public ASkyLight ValidSkyLight
	{
		get
		{
			CheckDestroyed();
			if (!ValidSkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidSkyLight");
				return null;
			}
			return UObjectMarshaler<ASkyLight>.FromNative(IntPtr.Add(base.Address, ValidSkyLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidSkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidSkyLight");
			}
			else
			{
				UObjectMarshaler<ASkyLight>.ToNative(IntPtr.Add(base.Address, ValidSkyLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:ValidAtmosphericFog")]
	public ASkyAtmosphere ValidAtmosphericFog
	{
		get
		{
			CheckDestroyed();
			if (!ValidAtmosphericFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidAtmosphericFog");
				return null;
			}
			return UObjectMarshaler<ASkyAtmosphere>.FromNative(IntPtr.Add(base.Address, ValidAtmosphericFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidAtmosphericFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidAtmosphericFog");
			}
			else
			{
				UObjectMarshaler<ASkyAtmosphere>.ToNative(IntPtr.Add(base.Address, ValidAtmosphericFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:ValidExponentialHeightFog")]
	public AExponentialHeightFog ValidExponentialHeightFog
	{
		get
		{
			CheckDestroyed();
			if (!ValidExponentialHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidExponentialHeightFog");
				return null;
			}
			return UObjectMarshaler<AExponentialHeightFog>.FromNative(IntPtr.Add(base.Address, ValidExponentialHeightFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidExponentialHeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidExponentialHeightFog");
			}
			else
			{
				UObjectMarshaler<AExponentialHeightFog>.ToNative(IntPtr.Add(base.Address, ValidExponentialHeightFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:ValidCLSBaseVolume")]
	public ACLSBaseVolume ValidCLSBaseVolume
	{
		get
		{
			CheckDestroyed();
			if (!ValidCLSBaseVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidCLSBaseVolume");
				return null;
			}
			return UObjectMarshaler<ACLSBaseVolume>.FromNative(IntPtr.Add(base.Address, ValidCLSBaseVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ValidCLSBaseVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSVolumeManager:ValidCLSBaseVolume");
			}
			else
			{
				UObjectMarshaler<ACLSBaseVolume>.ToNative(IntPtr.Add(base.Address, ValidCLSBaseVolume_Offset), value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:SetUniqueValidAtRuntime")]
	public unsafe void SetUniqueValidAtRuntime()
	{
		CheckDestroyed();
		if (!SetUniqueValidAtRuntime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:SetUniqueValidAtRuntime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUniqueValidAtRuntime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUniqueValidAtRuntime_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetUniqueValidAtRuntime_FunctionAddress, argsSize: SetUniqueValidAtRuntime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:SetLightManagerActive")]
	public unsafe void SetLightManagerActive(bool NewActive)
	{
		CheckDestroyed();
		if (!SetLightManagerActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:SetLightManagerActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightManagerActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightManagerActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightManagerActive_NewActive_Offset), 0, SetLightManagerActive_NewActive_PropertyAddress.Address, NewActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightManagerActive_FunctionAddress, intPtr, SetLightManagerActive_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:GetValidVolumeByWeight")]
	public unsafe Dictionary<ACLSBaseVolume, float> GetValidVolumeByWeight(FVector Position)
	{
		CheckDestroyed();
		if (!GetValidVolumeByWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:GetValidVolumeByWeight");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValidVolumeByWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValidVolumeByWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetValidVolumeByWeight_Position_Offset), 0, GetValidVolumeByWeight_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValidVolumeByWeight_FunctionAddress, intPtr, GetValidVolumeByWeight_ParamsSize);
		Dictionary<ACLSBaseVolume, float> result = new TMapCopyMarshaler<ACLSBaseVolume, float>(1, GetValidVolumeByWeight_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ACLSBaseVolume, UObjectMarshaler<ACLSBaseVolume>>.FromNative, CachedMarshalingDelegates<ACLSBaseVolume, UObjectMarshaler<ACLSBaseVolume>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetValidVolumeByWeight_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetValidVolumeByWeight_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:GetCurrentVolume")]
	public unsafe ACLSBaseVolume GetCurrentVolume()
	{
		CheckDestroyed();
		if (!GetCurrentVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:GetCurrentVolume");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentVolume_FunctionAddress, intPtr, GetCurrentVolume_ParamsSize);
		return UObjectMarshaler<ACLSBaseVolume>.FromNative(IntPtr.Add(intPtr, GetCurrentVolume_ReturnValue_Offset), 0, GetCurrentVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:EditorSwitchToValidLightAndFog")]
	public unsafe void EditorSwitchToValidLightAndFog()
	{
		CheckDestroyed();
		if (!EditorSwitchToValidLightAndFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:EditorSwitchToValidLightAndFog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorSwitchToValidLightAndFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorSwitchToValidLightAndFog_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorSwitchToValidLightAndFog_FunctionAddress, argsSize: EditorSwitchToValidLightAndFog_ParamsSize);
	}

	[UFunction(Flags = 1677853697u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllPointLightQualityLower")]
	public unsafe void EditorSetAllPointLightQualityLower()
	{
		CheckDestroyed();
		if (!EditorSetAllPointLightQualityLower_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllPointLightQualityLower");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorSetAllPointLightQualityLower_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorSetAllPointLightQualityLower_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorSetAllPointLightQualityLower_FunctionAddress, argsSize: EditorSetAllPointLightQualityLower_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllDirectionalLightQualityLower")]
	public unsafe void EditorSetAllDirectionalLightQualityLower()
	{
		CheckDestroyed();
		if (!EditorSetAllDirectionalLightQualityLower_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllDirectionalLightQualityLower");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorSetAllDirectionalLightQualityLower_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorSetAllDirectionalLightQualityLower_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EditorSetAllDirectionalLightQualityLower_FunctionAddress, argsSize: EditorSetAllDirectionalLightQualityLower_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:DisableOtherVolumeManager")]
	public unsafe void DisableOtherVolumeManager()
	{
		CheckDestroyed();
		if (!DisableOtherVolumeManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:DisableOtherVolumeManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableOtherVolumeManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableOtherVolumeManager_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableOtherVolumeManager_FunctionAddress, argsSize: DisableOtherVolumeManager_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:DisableAllVolume")]
	public unsafe void DisableAllVolume()
	{
		CheckDestroyed();
		if (!DisableAllVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:DisableAllVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableAllVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableAllVolume_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableAllVolume_FunctionAddress, argsSize: DisableAllVolume_ParamsSize);
	}

	[UFunction(Flags = 1677853697u)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeManager:DebugCurrentVolume")]
	public unsafe void DebugCurrentVolume()
	{
		CheckDestroyed();
		if (!DebugCurrentVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSVolumeManager:DebugCurrentVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DebugCurrentVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DebugCurrentVolume_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DebugCurrentVolume_FunctionAddress, argsSize: DebugCurrentVolume_ParamsSize);
	}

	static ACLSVolumeManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSVolumeManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSVolumeManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSVolumeManager");
		LightManager_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightManager");
		LightManager_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightManager", Classes.FObjectProperty);
		VolumeManagerID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeManagerID");
		VolumeManagerID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeManagerID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSwitchActive_PropertyAddress, intPtr, "bIsSwitchActive");
		IsSwitchActive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSwitchActive");
		IsSwitchActive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSwitchActive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCheckWARP_PropertyAddress, intPtr, "bIsCheckWARP");
		IsCheckWARP_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCheckWARP");
		IsCheckWARP_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCheckWARP", Classes.FBoolProperty);
		WARPDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WARPDistance");
		WARPDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WARPDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDebug_PropertyAddress, intPtr, "bIsDebug");
		IsDebug_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDebug");
		IsDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsForcePPV_PropertyAddress, intPtr, "bIsForcePPV");
		IsForcePPV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsForcePPV");
		IsForcePPV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsForcePPV", Classes.FBoolProperty);
		ValidDirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidDirectionalLight");
		ValidDirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidDirectionalLight", Classes.FObjectProperty);
		ValidSkyLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidSkyLight");
		ValidSkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidSkyLight", Classes.FObjectProperty);
		ValidAtmosphericFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidAtmosphericFog");
		ValidAtmosphericFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidAtmosphericFog", Classes.FObjectProperty);
		ValidExponentialHeightFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidExponentialHeightFog");
		ValidExponentialHeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidExponentialHeightFog", Classes.FObjectProperty);
		ValidCLSBaseVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidCLSBaseVolume");
		ValidCLSBaseVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidCLSBaseVolume", Classes.FObjectProperty);
		SetUniqueValidAtRuntime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUniqueValidAtRuntime");
		SetUniqueValidAtRuntime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUniqueValidAtRuntime_FunctionAddress);
		SetUniqueValidAtRuntime_IsValid = SetUniqueValidAtRuntime_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:SetUniqueValidAtRuntime", SetUniqueValidAtRuntime_IsValid);
		SetLightManagerActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightManagerActive");
		SetLightManagerActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightManagerActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightManagerActive_NewActive_PropertyAddress, SetLightManagerActive_FunctionAddress, "NewActive");
		SetLightManagerActive_NewActive_Offset = NativeReflectionCached.GetPropertyOffset(SetLightManagerActive_FunctionAddress, "NewActive");
		SetLightManagerActive_NewActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightManagerActive_FunctionAddress, "NewActive", Classes.FBoolProperty);
		SetLightManagerActive_IsValid = SetLightManagerActive_FunctionAddress != IntPtr.Zero && SetLightManagerActive_NewActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:SetLightManagerActive", SetLightManagerActive_IsValid);
		GetValidVolumeByWeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValidVolumeByWeight");
		GetValidVolumeByWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValidVolumeByWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValidVolumeByWeight_Position_PropertyAddress, GetValidVolumeByWeight_FunctionAddress, "Position");
		GetValidVolumeByWeight_Position_Offset = NativeReflectionCached.GetPropertyOffset(GetValidVolumeByWeight_FunctionAddress, "Position");
		GetValidVolumeByWeight_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidVolumeByWeight_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValidVolumeByWeight_ReturnValue_PropertyAddress, GetValidVolumeByWeight_FunctionAddress, "ReturnValue");
		GetValidVolumeByWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValidVolumeByWeight_FunctionAddress, "ReturnValue");
		GetValidVolumeByWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidVolumeByWeight_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetValidVolumeByWeight_IsValid = GetValidVolumeByWeight_FunctionAddress != IntPtr.Zero && GetValidVolumeByWeight_Position_IsValid && GetValidVolumeByWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:GetValidVolumeByWeight", GetValidVolumeByWeight_IsValid);
		GetCurrentVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentVolume");
		GetCurrentVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentVolume_ReturnValue_PropertyAddress, GetCurrentVolume_FunctionAddress, "ReturnValue");
		GetCurrentVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentVolume_FunctionAddress, "ReturnValue");
		GetCurrentVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentVolume_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentVolume_IsValid = GetCurrentVolume_FunctionAddress != IntPtr.Zero && GetCurrentVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:GetCurrentVolume", GetCurrentVolume_IsValid);
		EditorSwitchToValidLightAndFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorSwitchToValidLightAndFog");
		EditorSwitchToValidLightAndFog_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorSwitchToValidLightAndFog_FunctionAddress);
		EditorSwitchToValidLightAndFog_IsValid = EditorSwitchToValidLightAndFog_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:EditorSwitchToValidLightAndFog", EditorSwitchToValidLightAndFog_IsValid);
		EditorSetAllPointLightQualityLower_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorSetAllPointLightQualityLower");
		EditorSetAllPointLightQualityLower_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorSetAllPointLightQualityLower_FunctionAddress);
		EditorSetAllPointLightQualityLower_IsValid = EditorSetAllPointLightQualityLower_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllPointLightQualityLower", EditorSetAllPointLightQualityLower_IsValid);
		EditorSetAllDirectionalLightQualityLower_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorSetAllDirectionalLightQualityLower");
		EditorSetAllDirectionalLightQualityLower_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorSetAllDirectionalLightQualityLower_FunctionAddress);
		EditorSetAllDirectionalLightQualityLower_IsValid = EditorSetAllDirectionalLightQualityLower_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:EditorSetAllDirectionalLightQualityLower", EditorSetAllDirectionalLightQualityLower_IsValid);
		DisableOtherVolumeManager_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableOtherVolumeManager");
		DisableOtherVolumeManager_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableOtherVolumeManager_FunctionAddress);
		DisableOtherVolumeManager_IsValid = DisableOtherVolumeManager_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:DisableOtherVolumeManager", DisableOtherVolumeManager_IsValid);
		DisableAllVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableAllVolume");
		DisableAllVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAllVolume_FunctionAddress);
		DisableAllVolume_IsValid = DisableAllVolume_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:DisableAllVolume", DisableAllVolume_IsValid);
		DebugCurrentVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DebugCurrentVolume");
		DebugCurrentVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(DebugCurrentVolume_FunctionAddress);
		DebugCurrentVolume_IsValid = DebugCurrentVolume_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSVolumeManager:DebugCurrentVolume", DebugCurrentVolume_IsValid);
	}
}
