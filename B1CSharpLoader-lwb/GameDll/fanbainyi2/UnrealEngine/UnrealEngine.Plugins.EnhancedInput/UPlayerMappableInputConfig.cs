using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UPlayerMappableInputConfig : UPrimaryDataAsset
{
	private static bool ConfigName_IsValid;

	private static int ConfigName_Offset;

	private static bool ConfigDisplayName_IsValid;

	private static int ConfigDisplayName_Offset;

	private FText ConfigDisplayName_TextCached;

	private static bool IsDeprecated_IsValid;

	private static FFieldAddress IsDeprecated_PropertyAddress;

	private static int IsDeprecated_Offset;

	private static bool Metadata_IsValid;

	private static int Metadata_Offset;

	private static bool Contexts_IsValid;

	private static FFieldAddress Contexts_PropertyAddress;

	private static int Contexts_Offset;

	private TMapReadOnlyMarshaler<UInputMappingContext, int> Contexts_MarshalerCached;

	private static bool ResetToDefault_IsValid;

	private static IntPtr ResetToDefault_FunctionAddress;

	private static int ResetToDefault_ParamsSize;

	private static bool IsDeprecated_A14518FD_IsValid;

	private static IntPtr IsDeprecated_A14518FD_FunctionAddress;

	private static int IsDeprecated_A14518FD_ParamsSize;

	private static bool IsDeprecated_A14518FD_ReturnValue_IsValid;

	private static FFieldAddress IsDeprecated_A14518FD_ReturnValue_PropertyAddress;

	private static int IsDeprecated_A14518FD_ReturnValue_Offset;

	private static bool GetPlayerMappableKeys_IsValid;

	private static IntPtr GetPlayerMappableKeys_FunctionAddress;

	private static int GetPlayerMappableKeys_ParamsSize;

	private static bool GetPlayerMappableKeys_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerMappableKeys_ReturnValue_PropertyAddress;

	private static int GetPlayerMappableKeys_ReturnValue_Offset;

	private static bool GetMetadata_IsValid;

	private static IntPtr GetMetadata_FunctionAddress;

	private static int GetMetadata_ParamsSize;

	private static bool GetMetadata_ReturnValue_IsValid;

	private static FFieldAddress GetMetadata_ReturnValue_PropertyAddress;

	private static int GetMetadata_ReturnValue_Offset;

	private static bool GetMappingContexts_IsValid;

	private static IntPtr GetMappingContexts_FunctionAddress;

	private static int GetMappingContexts_ParamsSize;

	private static bool GetMappingContexts_ReturnValue_IsValid;

	private static FFieldAddress GetMappingContexts_ReturnValue_PropertyAddress;

	private static int GetMappingContexts_ReturnValue_Offset;

	private static bool GetMappingByName_IsValid;

	private static IntPtr GetMappingByName_FunctionAddress;

	private static int GetMappingByName_ParamsSize;

	private static bool GetMappingByName_MappingName_IsValid;

	private static FFieldAddress GetMappingByName_MappingName_PropertyAddress;

	private static int GetMappingByName_MappingName_Offset;

	private static bool GetMappingByName_ReturnValue_IsValid;

	private static FFieldAddress GetMappingByName_ReturnValue_PropertyAddress;

	private static int GetMappingByName_ReturnValue_Offset;

	private static bool GetKeysBoundToAction_IsValid;

	private static IntPtr GetKeysBoundToAction_FunctionAddress;

	private static int GetKeysBoundToAction_ParamsSize;

	private static bool GetKeysBoundToAction_InAction_IsValid;

	private static FFieldAddress GetKeysBoundToAction_InAction_PropertyAddress;

	private static int GetKeysBoundToAction_InAction_Offset;

	private static bool GetKeysBoundToAction_ReturnValue_IsValid;

	private static FFieldAddress GetKeysBoundToAction_ReturnValue_PropertyAddress;

	private static int GetKeysBoundToAction_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	private static bool GetConfigName_IsValid;

	private static IntPtr GetConfigName_FunctionAddress;

	private static int GetConfigName_ParamsSize;

	private static bool GetConfigName_ReturnValue_IsValid;

	private static FFieldAddress GetConfigName_ReturnValue_PropertyAddress;

	private static int GetConfigName_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigName")]
	protected FName ConfigName
	{
		get
		{
			CheckDestroyed();
			if (!ConfigName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ConfigName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ConfigName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763221uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigDisplayName")]
	protected FText ConfigDisplayName
	{
		get
		{
			CheckDestroyed();
			if (!ConfigDisplayName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigDisplayName");
				return null;
			}
			if (ConfigDisplayName_TextCached == null)
			{
				ConfigDisplayName_TextCached = new FText(IntPtr.Add(base.Address, ConfigDisplayName_Offset), createReference: false);
			}
			return ConfigDisplayName_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ConfigDisplayName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:ConfigDisplayName");
				return;
			}
			if (ConfigDisplayName_TextCached == null)
			{
				ConfigDisplayName_TextCached = new FText(IntPtr.Add(base.Address, ConfigDisplayName_Offset), createReference: false);
			}
			ConfigDisplayName_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:bIsDeprecated")]
	protected bool IsDeprecated
	{
		get
		{
			CheckDestroyed();
			if (!IsDeprecated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:bIsDeprecated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDeprecated_Offset), 0, IsDeprecated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDeprecated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:bIsDeprecated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDeprecated_Offset), 0, IsDeprecated_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:Metadata")]
	protected UObject Metadata
	{
		get
		{
			CheckDestroyed();
			if (!Metadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:Metadata");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Metadata_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Metadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:Metadata");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Metadata_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763221uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:Contexts")]
	protected TMapReadOnly<UInputMappingContext, int> Contexts
	{
		get
		{
			CheckDestroyed();
			if (!Contexts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:Contexts");
				return null;
			}
			if (Contexts_MarshalerCached == null)
			{
				Contexts_MarshalerCached = new TMapReadOnlyMarshaler<UInputMappingContext, int>(1, Contexts_PropertyAddress, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.FromNative, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return Contexts_MarshalerCached.FromNative(IntPtr.Add(base.Address, Contexts_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:ResetToDefault")]
	public unsafe void ResetToDefault()
	{
		CheckDestroyed();
		if (!ResetToDefault_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:ResetToDefault");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetToDefault_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetToDefault_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetToDefault_FunctionAddress, argsSize: ResetToDefault_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:IsDeprecated")]
	public unsafe bool IsDeprecated_A14518FD()
	{
		CheckDestroyed();
		if (!IsDeprecated_A14518FD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:IsDeprecated");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDeprecated_A14518FD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDeprecated_A14518FD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDeprecated_A14518FD_FunctionAddress, intPtr, IsDeprecated_A14518FD_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDeprecated_A14518FD_ReturnValue_Offset), 0, IsDeprecated_A14518FD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetPlayerMappableKeys")]
	public unsafe List<FEnhancedActionKeyMapping> GetPlayerMappableKeys()
	{
		CheckDestroyed();
		if (!GetPlayerMappableKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetPlayerMappableKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerMappableKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerMappableKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerMappableKeys_FunctionAddress, intPtr, GetPlayerMappableKeys_ParamsSize);
		List<FEnhancedActionKeyMapping> result = new TArrayCopyMarshaler<FEnhancedActionKeyMapping>(1, GetPlayerMappableKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.FromNative, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.ToNative).FromNative(IntPtr.Add(intPtr, GetPlayerMappableKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPlayerMappableKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetMetadata")]
	public unsafe UObject GetMetadata()
	{
		CheckDestroyed();
		if (!GetMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetMetadata");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMetadata_FunctionAddress, intPtr, GetMetadata_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetMetadata_ReturnValue_Offset), 0, GetMetadata_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingContexts")]
	public unsafe Dictionary<UInputMappingContext, int> GetMappingContexts()
	{
		CheckDestroyed();
		if (!GetMappingContexts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingContexts");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMappingContexts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMappingContexts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMappingContexts_FunctionAddress, intPtr, GetMappingContexts_ParamsSize);
		Dictionary<UInputMappingContext, int> result = new TMapCopyMarshaler<UInputMappingContext, int>(1, GetMappingContexts_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.FromNative, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMappingContexts_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMappingContexts_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingByName")]
	public unsafe FEnhancedActionKeyMapping GetMappingByName(FName MappingName)
	{
		CheckDestroyed();
		if (!GetMappingByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingByName");
			return default(FEnhancedActionKeyMapping);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMappingByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMappingByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMappingByName_MappingName_Offset), 0, GetMappingByName_MappingName_PropertyAddress.Address, MappingName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMappingByName_FunctionAddress, intPtr, GetMappingByName_ParamsSize);
		FEnhancedActionKeyMapping result = FEnhancedActionKeyMapping.FromNative(IntPtr.Add(intPtr, GetMappingByName_ReturnValue_Offset), 0, GetMappingByName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMappingByName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetKeysBoundToAction")]
	public unsafe List<FEnhancedActionKeyMapping> GetKeysBoundToAction(UInputAction InAction)
	{
		CheckDestroyed();
		if (!GetKeysBoundToAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetKeysBoundToAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeysBoundToAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeysBoundToAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, GetKeysBoundToAction_InAction_Offset), 0, GetKeysBoundToAction_InAction_PropertyAddress.Address, InAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKeysBoundToAction_FunctionAddress, intPtr, GetKeysBoundToAction_ParamsSize);
		List<FEnhancedActionKeyMapping> result = new TArrayCopyMarshaler<FEnhancedActionKeyMapping>(1, GetKeysBoundToAction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.FromNative, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.ToNative).FromNative(IntPtr.Add(intPtr, GetKeysBoundToAction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetKeysBoundToAction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetDisplayName")]
	public unsafe string GetDisplayName()
	{
		CheckDestroyed();
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableInputConfig:GetConfigName")]
	public unsafe FName GetConfigName()
	{
		CheckDestroyed();
		if (!GetConfigName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.PlayerMappableInputConfig:GetConfigName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConfigName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConfigName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConfigName_FunctionAddress, intPtr, GetConfigName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetConfigName_ReturnValue_Offset), 0, GetConfigName_ReturnValue_PropertyAddress.Address);
	}

	static UPlayerMappableInputConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlayerMappableInputConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlayerMappableInputConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/EnhancedInput.PlayerMappableInputConfig");
		ConfigName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigName");
		ConfigName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigName", Classes.FNameProperty);
		ConfigDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigDisplayName");
		ConfigDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigDisplayName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDeprecated_PropertyAddress, intPtr, "bIsDeprecated");
		IsDeprecated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDeprecated");
		IsDeprecated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDeprecated", Classes.FBoolProperty);
		Metadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Metadata");
		Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Contexts_PropertyAddress, intPtr, "Contexts");
		Contexts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Contexts");
		Contexts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Contexts", Classes.FMapProperty);
		ResetToDefault_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetToDefault");
		ResetToDefault_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetToDefault_FunctionAddress);
		ResetToDefault_IsValid = ResetToDefault_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:ResetToDefault", ResetToDefault_IsValid);
		IsDeprecated_A14518FD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDeprecated");
		IsDeprecated_A14518FD_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDeprecated_A14518FD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDeprecated_A14518FD_ReturnValue_PropertyAddress, IsDeprecated_A14518FD_FunctionAddress, "ReturnValue");
		IsDeprecated_A14518FD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDeprecated_A14518FD_FunctionAddress, "ReturnValue");
		IsDeprecated_A14518FD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDeprecated_A14518FD_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDeprecated_A14518FD_IsValid = IsDeprecated_A14518FD_FunctionAddress != IntPtr.Zero && IsDeprecated_A14518FD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:IsDeprecated", IsDeprecated_A14518FD_IsValid);
		GetPlayerMappableKeys_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerMappableKeys");
		GetPlayerMappableKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerMappableKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerMappableKeys_ReturnValue_PropertyAddress, GetPlayerMappableKeys_FunctionAddress, "ReturnValue");
		GetPlayerMappableKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerMappableKeys_FunctionAddress, "ReturnValue");
		GetPlayerMappableKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerMappableKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPlayerMappableKeys_IsValid = GetPlayerMappableKeys_FunctionAddress != IntPtr.Zero && GetPlayerMappableKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetPlayerMappableKeys", GetPlayerMappableKeys_IsValid);
		GetMetadata_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMetadata");
		GetMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetadata_ReturnValue_PropertyAddress, GetMetadata_FunctionAddress, "ReturnValue");
		GetMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadata_FunctionAddress, "ReturnValue");
		GetMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadata_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMetadata_IsValid = GetMetadata_FunctionAddress != IntPtr.Zero && GetMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetMetadata", GetMetadata_IsValid);
		GetMappingContexts_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMappingContexts");
		GetMappingContexts_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMappingContexts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMappingContexts_ReturnValue_PropertyAddress, GetMappingContexts_FunctionAddress, "ReturnValue");
		GetMappingContexts_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingContexts_FunctionAddress, "ReturnValue");
		GetMappingContexts_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingContexts_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetMappingContexts_IsValid = GetMappingContexts_FunctionAddress != IntPtr.Zero && GetMappingContexts_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingContexts", GetMappingContexts_IsValid);
		GetMappingByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMappingByName");
		GetMappingByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMappingByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMappingByName_MappingName_PropertyAddress, GetMappingByName_FunctionAddress, "MappingName");
		GetMappingByName_MappingName_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingByName_FunctionAddress, "MappingName");
		GetMappingByName_MappingName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingByName_FunctionAddress, "MappingName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMappingByName_ReturnValue_PropertyAddress, GetMappingByName_FunctionAddress, "ReturnValue");
		GetMappingByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingByName_FunctionAddress, "ReturnValue");
		GetMappingByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMappingByName_IsValid = GetMappingByName_FunctionAddress != IntPtr.Zero && GetMappingByName_MappingName_IsValid && GetMappingByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetMappingByName", GetMappingByName_IsValid);
		GetKeysBoundToAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetKeysBoundToAction");
		GetKeysBoundToAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeysBoundToAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeysBoundToAction_InAction_PropertyAddress, GetKeysBoundToAction_FunctionAddress, "InAction");
		GetKeysBoundToAction_InAction_Offset = NativeReflectionCached.GetPropertyOffset(GetKeysBoundToAction_FunctionAddress, "InAction");
		GetKeysBoundToAction_InAction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeysBoundToAction_FunctionAddress, "InAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeysBoundToAction_ReturnValue_PropertyAddress, GetKeysBoundToAction_FunctionAddress, "ReturnValue");
		GetKeysBoundToAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeysBoundToAction_FunctionAddress, "ReturnValue");
		GetKeysBoundToAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeysBoundToAction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeysBoundToAction_IsValid = GetKeysBoundToAction_FunctionAddress != IntPtr.Zero && GetKeysBoundToAction_InAction_IsValid && GetKeysBoundToAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetKeysBoundToAction", GetKeysBoundToAction_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetDisplayName", GetDisplayName_IsValid);
		GetConfigName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConfigName");
		GetConfigName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConfigName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConfigName_ReturnValue_PropertyAddress, GetConfigName_FunctionAddress, "ReturnValue");
		GetConfigName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConfigName_FunctionAddress, "ReturnValue");
		GetConfigName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConfigName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetConfigName_IsValid = GetConfigName_FunctionAddress != IntPtr.Zero && GetConfigName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.PlayerMappableInputConfig:GetConfigName", GetConfigName_IsValid);
	}
}
