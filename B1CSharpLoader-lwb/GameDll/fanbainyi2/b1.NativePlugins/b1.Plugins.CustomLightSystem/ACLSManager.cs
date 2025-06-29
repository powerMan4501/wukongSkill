using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSManager", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSManager : AActor
{
	private static IntPtr classAddress;

	private static bool EnableManager_IsValid;

	private static FFieldAddress EnableManager_PropertyAddress;

	private static int EnableManager_Offset;

	private static bool EnableDebugLog_IsValid;

	private static FFieldAddress EnableDebugLog_PropertyAddress;

	private static int EnableDebugLog_Offset;

	private static bool ActorLightAttenuationMaxRange_IsValid;

	private static int ActorLightAttenuationMaxRange_Offset;

	private static bool ActorLightAttenuationMinRange_IsValid;

	private static int ActorLightAttenuationMinRange_Offset;

	private static bool VolumeManagerID_IsValid;

	private static int VolumeManagerID_Offset;

	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool MarkDirtyDeltaPercentage_IsValid;

	private static int MarkDirtyDeltaPercentage_Offset;

	private static bool EnableSkyLightCapture_IsValid;

	private static FFieldAddress EnableSkyLightCapture_PropertyAddress;

	private static int EnableSkyLightCapture_Offset;

	private static bool EnableRayTrace_IsValid;

	private static FFieldAddress EnableRayTrace_PropertyAddress;

	private static int EnableRayTrace_Offset;

	private static bool RayTraceQuality_IsValid;

	private static int RayTraceQuality_Offset;

	private static bool PlayerLightAttenuation_IsValid;

	private static int PlayerLightAttenuation_Offset;

	private static bool ActorLightAttenuation_IsValid;

	private static int ActorLightAttenuation_Offset;

	private static bool UpdateAndGetWatchData_IsValid;

	private static IntPtr UpdateAndGetWatchData_FunctionAddress;

	private static int UpdateAndGetWatchData_ParamsSize;

	private static bool UpdateAndGetWatchData_ReturnValue_IsValid;

	private static FFieldAddress UpdateAndGetWatchData_ReturnValue_PropertyAddress;

	private static int UpdateAndGetWatchData_ReturnValue_Offset;

	private static bool SetPlayerLightAttenuation_IsValid;

	private static IntPtr SetPlayerLightAttenuation_FunctionAddress;

	private static int SetPlayerLightAttenuation_ParamsSize;

	private static bool SetPlayerLightAttenuation_InPlayerLightAttenuation_IsValid;

	private static FFieldAddress SetPlayerLightAttenuation_InPlayerLightAttenuation_PropertyAddress;

	private static int SetPlayerLightAttenuation_InPlayerLightAttenuation_Offset;

	private static bool SetEnableManager_IsValid;

	private static IntPtr SetEnableManager_FunctionAddress;

	private static int SetEnableManager_ParamsSize;

	private static bool SetEnableManager_bInEnableManager_IsValid;

	private static FFieldAddress SetEnableManager_bInEnableManager_PropertyAddress;

	private static int SetEnableManager_bInEnableManager_Offset;

	private static bool SetActorLightAttenuation_IsValid;

	private static IntPtr SetActorLightAttenuation_FunctionAddress;

	private static int SetActorLightAttenuation_ParamsSize;

	private static bool SetActorLightAttenuation_InActorLightAttenuation_IsValid;

	private static FFieldAddress SetActorLightAttenuation_InActorLightAttenuation_PropertyAddress;

	private static int SetActorLightAttenuation_InActorLightAttenuation_Offset;

	private static bool RemoveAllDynamicLevel_IsValid;

	private static IntPtr RemoveAllDynamicLevel_FunctionAddress;

	private static int RemoveAllDynamicLevel_ParamsSize;

	private static bool RefreshClsVolumes_IsValid;

	private static IntPtr RefreshClsVolumes_FunctionAddress;

	private static int RefreshClsVolumes_ParamsSize;

	private static bool DisableAllLights_IsValid;

	private static IntPtr DisableAllLights_FunctionAddress;

	private static int DisableAllLights_ParamsSize;

	private static bool ConvertFromLightToCls_IsValid;

	private static IntPtr ConvertFromLightToCls_FunctionAddress;

	private static int ConvertFromLightToCls_ParamsSize;

	private static bool AllVolumeStoreData_IsValid;

	private static IntPtr AllVolumeStoreData_FunctionAddress;

	private static int AllVolumeStoreData_ParamsSize;

	private static bool AllVolumesCopyClsData_IsValid;

	private static IntPtr AllVolumesCopyClsData_FunctionAddress;

	private static int AllVolumesCopyClsData_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:bEnableManager")]
	public bool EnableManager
	{
		get
		{
			CheckDestroyed();
			if (!EnableManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableManager");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableManager_Offset), 0, EnableManager_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableManager");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableManager_Offset), 0, EnableManager_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:bEnableDebugLog")]
	public bool EnableDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebugLog_Offset), 0, EnableDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebugLog_Offset), 0, EnableDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMaxRange")]
	public float ActorLightAttenuationMaxRange
	{
		get
		{
			CheckDestroyed();
			if (!ActorLightAttenuationMaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMaxRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActorLightAttenuationMaxRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorLightAttenuationMaxRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMaxRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActorLightAttenuationMaxRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMinRange")]
	public float ActorLightAttenuationMinRange
	{
		get
		{
			CheckDestroyed();
			if (!ActorLightAttenuationMinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMinRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActorLightAttenuationMinRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorLightAttenuationMinRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuationMinRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActorLightAttenuationMinRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:VolumeManagerID")]
	public int VolumeManagerID
	{
		get
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:VolumeManagerID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VolumeManagerID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeManagerID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:VolumeManagerID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VolumeManagerID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:MarkDirtyDeltaPercentage")]
	public float MarkDirtyDeltaPercentage
	{
		get
		{
			CheckDestroyed();
			if (!MarkDirtyDeltaPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:MarkDirtyDeltaPercentage");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MarkDirtyDeltaPercentage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MarkDirtyDeltaPercentage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:MarkDirtyDeltaPercentage");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MarkDirtyDeltaPercentage_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:bEnableSkyLightCapture")]
	public bool EnableSkyLightCapture
	{
		get
		{
			CheckDestroyed();
			if (!EnableSkyLightCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableSkyLightCapture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSkyLightCapture_Offset), 0, EnableSkyLightCapture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSkyLightCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableSkyLightCapture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSkyLightCapture_Offset), 0, EnableSkyLightCapture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:bEnableRayTrace")]
	public bool EnableRayTrace
	{
		get
		{
			CheckDestroyed();
			if (!EnableRayTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableRayTrace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRayTrace_Offset), 0, EnableRayTrace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRayTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:bEnableRayTrace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRayTrace_Offset), 0, EnableRayTrace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:RayTraceQuality")]
	public byte RayTraceQuality
	{
		get
		{
			CheckDestroyed();
			if (!RayTraceQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:RayTraceQuality");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, RayTraceQuality_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayTraceQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:RayTraceQuality");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, RayTraceQuality_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:PlayerLightAttenuation")]
	public float PlayerLightAttenuation
	{
		get
		{
			CheckDestroyed();
			if (!PlayerLightAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:PlayerLightAttenuation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlayerLightAttenuation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerLightAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:PlayerLightAttenuation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlayerLightAttenuation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:ActorLightAttenuation")]
	public float ActorLightAttenuation
	{
		get
		{
			CheckDestroyed();
			if (!ActorLightAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActorLightAttenuation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorLightAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSManager:ActorLightAttenuation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActorLightAttenuation_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:UpdateAndGetWatchData")]
	public unsafe FCLSWatchData UpdateAndGetWatchData()
	{
		CheckDestroyed();
		if (!UpdateAndGetWatchData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:UpdateAndGetWatchData");
			return default(FCLSWatchData);
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAndGetWatchData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAndGetWatchData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateAndGetWatchData_FunctionAddress, intPtr, UpdateAndGetWatchData_ParamsSize);
		FCLSWatchData result = FCLSWatchData.FromNative(IntPtr.Add(intPtr, UpdateAndGetWatchData_ReturnValue_Offset), 0, UpdateAndGetWatchData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(UpdateAndGetWatchData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:SetPlayerLightAttenuation")]
	public unsafe void SetPlayerLightAttenuation(float InPlayerLightAttenuation)
	{
		CheckDestroyed();
		if (!SetPlayerLightAttenuation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:SetPlayerLightAttenuation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayerLightAttenuation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayerLightAttenuation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayerLightAttenuation_InPlayerLightAttenuation_Offset), 0, SetPlayerLightAttenuation_InPlayerLightAttenuation_PropertyAddress.Address, InPlayerLightAttenuation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayerLightAttenuation_FunctionAddress, intPtr, SetPlayerLightAttenuation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:SetEnableManager")]
	public unsafe void SetEnableManager(bool bInEnableManager)
	{
		CheckDestroyed();
		if (!SetEnableManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:SetEnableManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableManager_bInEnableManager_Offset), 0, SetEnableManager_bInEnableManager_PropertyAddress.Address, bInEnableManager);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableManager_FunctionAddress, intPtr, SetEnableManager_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:SetActorLightAttenuation")]
	public unsafe void SetActorLightAttenuation(float InActorLightAttenuation)
	{
		CheckDestroyed();
		if (!SetActorLightAttenuation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:SetActorLightAttenuation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLightAttenuation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLightAttenuation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetActorLightAttenuation_InActorLightAttenuation_Offset), 0, SetActorLightAttenuation_InActorLightAttenuation_PropertyAddress.Address, InActorLightAttenuation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorLightAttenuation_FunctionAddress, intPtr, SetActorLightAttenuation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:RemoveAllDynamicLevel")]
	public unsafe static void RemoveAllDynamicLevel()
	{
		if (!RemoveAllDynamicLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:RemoveAllDynamicLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllDynamicLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllDynamicLevel_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RemoveAllDynamicLevel_FunctionAddress, argsSize: RemoveAllDynamicLevel_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:RefreshClsVolumes")]
	public unsafe void RefreshClsVolumes()
	{
		CheckDestroyed();
		if (!RefreshClsVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:RefreshClsVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshClsVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshClsVolumes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshClsVolumes_FunctionAddress, argsSize: RefreshClsVolumes_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:DisableAllLights")]
	public unsafe void DisableAllLights()
	{
		CheckDestroyed();
		if (!DisableAllLights_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:DisableAllLights");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableAllLights_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableAllLights_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableAllLights_FunctionAddress, argsSize: DisableAllLights_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:ConvertFromLightToCls")]
	public unsafe void ConvertFromLightToCls()
	{
		CheckDestroyed();
		if (!ConvertFromLightToCls_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:ConvertFromLightToCls");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertFromLightToCls_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertFromLightToCls_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConvertFromLightToCls_FunctionAddress, argsSize: ConvertFromLightToCls_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:AllVolumeStoreData")]
	public unsafe void AllVolumeStoreData()
	{
		CheckDestroyed();
		if (!AllVolumeStoreData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:AllVolumeStoreData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllVolumeStoreData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllVolumeStoreData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: AllVolumeStoreData_FunctionAddress, argsSize: AllVolumeStoreData_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSManager:AllVolumesCopyClsData")]
	public unsafe void AllVolumesCopyClsData()
	{
		CheckDestroyed();
		if (!AllVolumesCopyClsData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSManager:AllVolumesCopyClsData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllVolumesCopyClsData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllVolumesCopyClsData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: AllVolumesCopyClsData_FunctionAddress, argsSize: AllVolumesCopyClsData_ParamsSize);
	}

	static ACLSManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/CustomLightSystem.CLSManager");
		NativeReflectionCached.GetPropertyRef(ref EnableManager_PropertyAddress, classAddress, "bEnableManager");
		EnableManager_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bEnableManager");
		EnableManager_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bEnableManager", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDebugLog_PropertyAddress, classAddress, "bEnableDebugLog");
		EnableDebugLog_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bEnableDebugLog");
		EnableDebugLog_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bEnableDebugLog", Classes.FBoolProperty);
		ActorLightAttenuationMaxRange_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ActorLightAttenuationMaxRange");
		ActorLightAttenuationMaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ActorLightAttenuationMaxRange", Classes.FFloatProperty);
		ActorLightAttenuationMinRange_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ActorLightAttenuationMinRange");
		ActorLightAttenuationMinRange_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ActorLightAttenuationMinRange", Classes.FFloatProperty);
		VolumeManagerID_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "VolumeManagerID");
		VolumeManagerID_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "VolumeManagerID", Classes.FIntProperty);
		MPC_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "MPC");
		MPC_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "MPC", Classes.FObjectProperty);
		MarkDirtyDeltaPercentage_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "MarkDirtyDeltaPercentage");
		MarkDirtyDeltaPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "MarkDirtyDeltaPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSkyLightCapture_PropertyAddress, classAddress, "bEnableSkyLightCapture");
		EnableSkyLightCapture_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bEnableSkyLightCapture");
		EnableSkyLightCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bEnableSkyLightCapture", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRayTrace_PropertyAddress, classAddress, "bEnableRayTrace");
		EnableRayTrace_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bEnableRayTrace");
		EnableRayTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bEnableRayTrace", Classes.FBoolProperty);
		RayTraceQuality_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "RayTraceQuality");
		RayTraceQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "RayTraceQuality", Classes.FByteProperty);
		PlayerLightAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "PlayerLightAttenuation");
		PlayerLightAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "PlayerLightAttenuation", Classes.FFloatProperty);
		ActorLightAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ActorLightAttenuation");
		ActorLightAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ActorLightAttenuation", Classes.FFloatProperty);
		UpdateAndGetWatchData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateAndGetWatchData");
		UpdateAndGetWatchData_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAndGetWatchData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAndGetWatchData_ReturnValue_PropertyAddress, UpdateAndGetWatchData_FunctionAddress, "ReturnValue");
		UpdateAndGetWatchData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAndGetWatchData_FunctionAddress, "ReturnValue");
		UpdateAndGetWatchData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAndGetWatchData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		UpdateAndGetWatchData_IsValid = UpdateAndGetWatchData_FunctionAddress != IntPtr.Zero && UpdateAndGetWatchData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:UpdateAndGetWatchData", UpdateAndGetWatchData_IsValid);
		SetPlayerLightAttenuation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlayerLightAttenuation");
		SetPlayerLightAttenuation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayerLightAttenuation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayerLightAttenuation_InPlayerLightAttenuation_PropertyAddress, SetPlayerLightAttenuation_FunctionAddress, "InPlayerLightAttenuation");
		SetPlayerLightAttenuation_InPlayerLightAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayerLightAttenuation_FunctionAddress, "InPlayerLightAttenuation");
		SetPlayerLightAttenuation_InPlayerLightAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayerLightAttenuation_FunctionAddress, "InPlayerLightAttenuation", Classes.FFloatProperty);
		SetPlayerLightAttenuation_IsValid = SetPlayerLightAttenuation_FunctionAddress != IntPtr.Zero && SetPlayerLightAttenuation_InPlayerLightAttenuation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:SetPlayerLightAttenuation", SetPlayerLightAttenuation_IsValid);
		SetEnableManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEnableManager");
		SetEnableManager_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableManager_bInEnableManager_PropertyAddress, SetEnableManager_FunctionAddress, "bInEnableManager");
		SetEnableManager_bInEnableManager_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableManager_FunctionAddress, "bInEnableManager");
		SetEnableManager_bInEnableManager_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableManager_FunctionAddress, "bInEnableManager", Classes.FBoolProperty);
		SetEnableManager_IsValid = SetEnableManager_FunctionAddress != IntPtr.Zero && SetEnableManager_bInEnableManager_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:SetEnableManager", SetEnableManager_IsValid);
		SetActorLightAttenuation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLightAttenuation");
		SetActorLightAttenuation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLightAttenuation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLightAttenuation_InActorLightAttenuation_PropertyAddress, SetActorLightAttenuation_FunctionAddress, "InActorLightAttenuation");
		SetActorLightAttenuation_InActorLightAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLightAttenuation_FunctionAddress, "InActorLightAttenuation");
		SetActorLightAttenuation_InActorLightAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLightAttenuation_FunctionAddress, "InActorLightAttenuation", Classes.FFloatProperty);
		SetActorLightAttenuation_IsValid = SetActorLightAttenuation_FunctionAddress != IntPtr.Zero && SetActorLightAttenuation_InActorLightAttenuation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:SetActorLightAttenuation", SetActorLightAttenuation_IsValid);
		RemoveAllDynamicLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllDynamicLevel");
		RemoveAllDynamicLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllDynamicLevel_FunctionAddress);
		RemoveAllDynamicLevel_IsValid = RemoveAllDynamicLevel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:RemoveAllDynamicLevel", RemoveAllDynamicLevel_IsValid);
		RefreshClsVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshClsVolumes");
		RefreshClsVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshClsVolumes_FunctionAddress);
		RefreshClsVolumes_IsValid = RefreshClsVolumes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:RefreshClsVolumes", RefreshClsVolumes_IsValid);
		DisableAllLights_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableAllLights");
		DisableAllLights_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAllLights_FunctionAddress);
		DisableAllLights_IsValid = DisableAllLights_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:DisableAllLights", DisableAllLights_IsValid);
		ConvertFromLightToCls_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertFromLightToCls");
		ConvertFromLightToCls_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertFromLightToCls_FunctionAddress);
		ConvertFromLightToCls_IsValid = ConvertFromLightToCls_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:ConvertFromLightToCls", ConvertFromLightToCls_IsValid);
		AllVolumeStoreData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AllVolumeStoreData");
		AllVolumeStoreData_ParamsSize = NativeReflection.GetFunctionParamsSize(AllVolumeStoreData_FunctionAddress);
		AllVolumeStoreData_IsValid = AllVolumeStoreData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:AllVolumeStoreData", AllVolumeStoreData_IsValid);
		AllVolumesCopyClsData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AllVolumesCopyClsData");
		AllVolumesCopyClsData_ParamsSize = NativeReflection.GetFunctionParamsSize(AllVolumesCopyClsData_FunctionAddress);
		AllVolumesCopyClsData_IsValid = AllVolumesCopyClsData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSManager:AllVolumesCopyClsData", AllVolumesCopyClsData_IsValid);
	}
}
