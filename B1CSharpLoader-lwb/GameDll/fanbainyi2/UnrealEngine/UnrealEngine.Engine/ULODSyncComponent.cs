using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.LODSyncComponent", "Engine", UnrealModuleType.Engine)]
public class ULODSyncComponent : UActorComponent
{
	private static bool NumLODs_IsValid;

	private static int NumLODs_Offset;

	private static bool ForcedLOD_IsValid;

	private static int ForcedLOD_Offset;

	private static bool MinLOD_IsValid;

	private static int MinLOD_Offset;

	private static bool ComponentsToSync_IsValid;

	private static FFieldAddress ComponentsToSync_PropertyAddress;

	private static int ComponentsToSync_Offset;

	private TArrayReadWriteMarshaler<FComponentSync> ComponentsToSync_MarshalerCached;

	private static bool CustomLODMapping_IsValid;

	private static FFieldAddress CustomLODMapping_PropertyAddress;

	private static int CustomLODMapping_Offset;

	private TMapReadWriteMarshaler<FName, FLODMappingData> CustomLODMapping_MarshalerCached;

	private static bool GetLODSyncDebugText_IsValid;

	private static IntPtr GetLODSyncDebugText_FunctionAddress;

	private static int GetLODSyncDebugText_ParamsSize;

	private static bool GetLODSyncDebugText_ReturnValue_IsValid;

	private static FFieldAddress GetLODSyncDebugText_ReturnValue_PropertyAddress;

	private static int GetLODSyncDebugText_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LODSyncComponent:NumLODs")]
	public int NumLODs
	{
		get
		{
			CheckDestroyed();
			if (!NumLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:NumLODs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumLODs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumLODs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:NumLODs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumLODs_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.LODSyncComponent:ForcedLOD")]
	public int ForcedLOD
	{
		get
		{
			CheckDestroyed();
			if (!ForcedLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:ForcedLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForcedLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForcedLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:ForcedLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForcedLOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LODSyncComponent:MinLOD")]
	public int MinLOD
	{
		get
		{
			CheckDestroyed();
			if (!MinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:MinLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:MinLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinLOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.LODSyncComponent:ComponentsToSync")]
	public TArrayReadWrite<FComponentSync> ComponentsToSync
	{
		get
		{
			CheckDestroyed();
			if (!ComponentsToSync_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:ComponentsToSync");
				return null;
			}
			if (ComponentsToSync_MarshalerCached == null)
			{
				ComponentsToSync_MarshalerCached = new TArrayReadWriteMarshaler<FComponentSync>(1, ComponentsToSync_PropertyAddress, CachedMarshalingDelegates<FComponentSync, FComponentSync>.FromNative, CachedMarshalingDelegates<FComponentSync, FComponentSync>.ToNative);
			}
			return ComponentsToSync_MarshalerCached.FromNative(IntPtr.Add(base.Address, ComponentsToSync_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.LODSyncComponent:CustomLODMapping")]
	public TMapReadWrite<FName, FLODMappingData> CustomLODMapping
	{
		get
		{
			CheckDestroyed();
			if (!CustomLODMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LODSyncComponent:CustomLODMapping");
				return null;
			}
			if (CustomLODMapping_MarshalerCached == null)
			{
				CustomLODMapping_MarshalerCached = new TMapReadWriteMarshaler<FName, FLODMappingData>(1, CustomLODMapping_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLODMappingData, FLODMappingData>.FromNative, CachedMarshalingDelegates<FLODMappingData, FLODMappingData>.ToNative);
			}
			return CustomLODMapping_MarshalerCached.FromNative(IntPtr.Add(base.Address, CustomLODMapping_Offset));
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.LODSyncComponent:GetLODSyncDebugText")]
	public unsafe string GetLODSyncDebugText()
	{
		CheckDestroyed();
		if (!GetLODSyncDebugText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LODSyncComponent:GetLODSyncDebugText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODSyncDebugText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODSyncDebugText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLODSyncDebugText_FunctionAddress, intPtr, GetLODSyncDebugText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLODSyncDebugText_ReturnValue_Offset), 0, GetLODSyncDebugText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLODSyncDebugText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static ULODSyncComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULODSyncComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULODSyncComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.LODSyncComponent");
		NumLODs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumLODs");
		NumLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumLODs", Classes.FIntProperty);
		ForcedLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForcedLOD");
		ForcedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForcedLOD", Classes.FIntProperty);
		MinLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLOD");
		MinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentsToSync_PropertyAddress, intPtr, "ComponentsToSync");
		ComponentsToSync_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentsToSync");
		ComponentsToSync_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentsToSync", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomLODMapping_PropertyAddress, intPtr, "CustomLODMapping");
		CustomLODMapping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomLODMapping");
		CustomLODMapping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomLODMapping", Classes.FMapProperty);
		GetLODSyncDebugText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLODSyncDebugText");
		GetLODSyncDebugText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODSyncDebugText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODSyncDebugText_ReturnValue_PropertyAddress, GetLODSyncDebugText_FunctionAddress, "ReturnValue");
		GetLODSyncDebugText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODSyncDebugText_FunctionAddress, "ReturnValue");
		GetLODSyncDebugText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODSyncDebugText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLODSyncDebugText_IsValid = GetLODSyncDebugText_FunctionAddress != IntPtr.Zero && GetLODSyncDebugText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LODSyncComponent:GetLODSyncDebugText", GetLODSyncDebugText_IsValid);
	}
}
