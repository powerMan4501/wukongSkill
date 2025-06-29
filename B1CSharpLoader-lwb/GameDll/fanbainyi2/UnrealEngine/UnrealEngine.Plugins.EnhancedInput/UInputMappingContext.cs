using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputMappingContext", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputMappingContext : UDataAsset
{
	private static bool ContextDescription_IsValid;

	private static int ContextDescription_Offset;

	private FText ContextDescription_TextCached;

	private static bool Mappings_IsValid;

	private static FFieldAddress Mappings_PropertyAddress;

	private static int Mappings_Offset;

	private TArrayReadOnlyMarshaler<FEnhancedActionKeyMapping> Mappings_MarshalerCached;

	private static bool UnmapKey_IsValid;

	private static IntPtr UnmapKey_FunctionAddress;

	private static int UnmapKey_ParamsSize;

	private static bool UnmapKey_Action_IsValid;

	private static FFieldAddress UnmapKey_Action_PropertyAddress;

	private static int UnmapKey_Action_Offset;

	private static bool UnmapKey_Key_IsValid;

	private static FFieldAddress UnmapKey_Key_PropertyAddress;

	private static int UnmapKey_Key_Offset;

	private static bool UnmapAll_IsValid;

	private static IntPtr UnmapAll_FunctionAddress;

	private static int UnmapAll_ParamsSize;

	private static bool UnmapAction_IsValid;

	private static IntPtr UnmapAction_FunctionAddress;

	private static int UnmapAction_ParamsSize;

	private static bool UnmapAction_Action_IsValid;

	private static FFieldAddress UnmapAction_Action_PropertyAddress;

	private static int UnmapAction_Action_Offset;

	private static bool MapKey_IsValid;

	private static IntPtr MapKey_FunctionAddress;

	private static int MapKey_ParamsSize;

	private static bool MapKey_Action_IsValid;

	private static FFieldAddress MapKey_Action_PropertyAddress;

	private static int MapKey_Action_Offset;

	private static bool MapKey_ToKey_IsValid;

	private static FFieldAddress MapKey_ToKey_PropertyAddress;

	private static int MapKey_ToKey_Offset;

	private static bool MapKey_ReturnValue_IsValid;

	private static FFieldAddress MapKey_ReturnValue_PropertyAddress;

	private static int MapKey_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:ContextDescription")]
	public FText ContextDescription
	{
		get
		{
			CheckDestroyed();
			if (!ContextDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputMappingContext:ContextDescription");
				return null;
			}
			if (ContextDescription_TextCached == null)
			{
				ContextDescription_TextCached = new FText(IntPtr.Add(base.Address, ContextDescription_Offset), createReference: false);
			}
			return ContextDescription_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ContextDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputMappingContext:ContextDescription");
				return;
			}
			if (ContextDescription_TextCached == null)
			{
				ContextDescription_TextCached = new FText(IntPtr.Add(base.Address, ContextDescription_Offset), createReference: false);
			}
			ContextDescription_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)9016545103594005uL)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:Mappings")]
	protected TArrayReadOnly<FEnhancedActionKeyMapping> Mappings
	{
		get
		{
			CheckDestroyed();
			if (!Mappings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputMappingContext:Mappings");
				return null;
			}
			if (Mappings_MarshalerCached == null)
			{
				Mappings_MarshalerCached = new TArrayReadOnlyMarshaler<FEnhancedActionKeyMapping>(1, Mappings_PropertyAddress, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.FromNative, CachedMarshalingDelegates<FEnhancedActionKeyMapping, FEnhancedActionKeyMapping>.ToNative);
			}
			return Mappings_MarshalerCached.FromNative(IntPtr.Add(base.Address, Mappings_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:UnmapKey")]
	public unsafe void UnmapKey(UInputAction Action, FKey Key)
	{
		CheckDestroyed();
		if (!UnmapKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputMappingContext:UnmapKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnmapKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnmapKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, UnmapKey_Action_Offset), 0, UnmapKey_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(UnmapKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, UnmapKey_Key_Offset), 0, UnmapKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnmapKey_FunctionAddress, intPtr, UnmapKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnmapKey_Key_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:UnmapAll")]
	public unsafe void UnmapAll()
	{
		CheckDestroyed();
		if (!UnmapAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputMappingContext:UnmapAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnmapAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnmapAll_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnmapAll_FunctionAddress, argsSize: UnmapAll_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:UnmapAction")]
	public unsafe void UnmapAction(UInputAction Action)
	{
		CheckDestroyed();
		if (!UnmapAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputMappingContext:UnmapAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnmapAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnmapAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, UnmapAction_Action_Offset), 0, UnmapAction_Action_PropertyAddress.Address, Action);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnmapAction_FunctionAddress, intPtr, UnmapAction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/EnhancedInput.InputMappingContext:MapKey")]
	public unsafe FEnhancedActionKeyMapping MapKey(UInputAction Action, FKey ToKey)
	{
		CheckDestroyed();
		if (!MapKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputMappingContext:MapKey");
			return default(FEnhancedActionKeyMapping);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MapKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MapKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, MapKey_Action_Offset), 0, MapKey_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(MapKey_ToKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, MapKey_ToKey_Offset), 0, MapKey_ToKey_PropertyAddress.Address, ToKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, MapKey_FunctionAddress, intPtr, MapKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MapKey_ToKey_PropertyAddress.Address, intPtr);
		FEnhancedActionKeyMapping result = FEnhancedActionKeyMapping.FromNative(IntPtr.Add(intPtr, MapKey_ReturnValue_Offset), 0, MapKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MapKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UInputMappingContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputMappingContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputMappingContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/EnhancedInput.InputMappingContext");
		ContextDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContextDescription");
		ContextDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContextDescription", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref Mappings_PropertyAddress, intPtr, "Mappings");
		Mappings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mappings");
		Mappings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mappings", Classes.FArrayProperty);
		UnmapKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnmapKey");
		UnmapKey_ParamsSize = NativeReflection.GetFunctionParamsSize(UnmapKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnmapKey_Action_PropertyAddress, UnmapKey_FunctionAddress, "Action");
		UnmapKey_Action_Offset = NativeReflectionCached.GetPropertyOffset(UnmapKey_FunctionAddress, "Action");
		UnmapKey_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(UnmapKey_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnmapKey_Key_PropertyAddress, UnmapKey_FunctionAddress, "Key");
		UnmapKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(UnmapKey_FunctionAddress, "Key");
		UnmapKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(UnmapKey_FunctionAddress, "Key", Classes.FStructProperty);
		UnmapKey_IsValid = UnmapKey_FunctionAddress != IntPtr.Zero && UnmapKey_Action_IsValid && UnmapKey_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputMappingContext:UnmapKey", UnmapKey_IsValid);
		UnmapAll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnmapAll");
		UnmapAll_ParamsSize = NativeReflection.GetFunctionParamsSize(UnmapAll_FunctionAddress);
		UnmapAll_IsValid = UnmapAll_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputMappingContext:UnmapAll", UnmapAll_IsValid);
		UnmapAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnmapAction");
		UnmapAction_ParamsSize = NativeReflection.GetFunctionParamsSize(UnmapAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnmapAction_Action_PropertyAddress, UnmapAction_FunctionAddress, "Action");
		UnmapAction_Action_Offset = NativeReflectionCached.GetPropertyOffset(UnmapAction_FunctionAddress, "Action");
		UnmapAction_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(UnmapAction_FunctionAddress, "Action", Classes.FObjectProperty);
		UnmapAction_IsValid = UnmapAction_FunctionAddress != IntPtr.Zero && UnmapAction_Action_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputMappingContext:UnmapAction", UnmapAction_IsValid);
		MapKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MapKey");
		MapKey_ParamsSize = NativeReflection.GetFunctionParamsSize(MapKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MapKey_Action_PropertyAddress, MapKey_FunctionAddress, "Action");
		MapKey_Action_Offset = NativeReflectionCached.GetPropertyOffset(MapKey_FunctionAddress, "Action");
		MapKey_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(MapKey_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MapKey_ToKey_PropertyAddress, MapKey_FunctionAddress, "ToKey");
		MapKey_ToKey_Offset = NativeReflectionCached.GetPropertyOffset(MapKey_FunctionAddress, "ToKey");
		MapKey_ToKey_IsValid = NativeReflectionCached.ValidatePropertyClass(MapKey_FunctionAddress, "ToKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MapKey_ReturnValue_PropertyAddress, MapKey_FunctionAddress, "ReturnValue");
		MapKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MapKey_FunctionAddress, "ReturnValue");
		MapKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MapKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MapKey_IsValid = MapKey_FunctionAddress != IntPtr.Zero && MapKey_Action_IsValid && MapKey_ToKey_IsValid && MapKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputMappingContext:MapKey", MapKey_IsValid);
	}
}
