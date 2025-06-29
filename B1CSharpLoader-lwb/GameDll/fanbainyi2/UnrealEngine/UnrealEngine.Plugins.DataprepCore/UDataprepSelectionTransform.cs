using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepSelectionTransform : UDataprepParameterizableObject
{
	private static bool OnExecution_IsValid;

	private IntPtr OnExecution_InstanceFunctionAddress;

	private static IntPtr OnExecution_FunctionAddress;

	private static int OnExecution_ParamsSize;

	private static bool OnExecution_InObjects_IsValid;

	private static FFieldAddress OnExecution_InObjects_PropertyAddress;

	private static int OnExecution_InObjects_Offset;

	private static bool OnExecution_OutObjects_IsValid;

	private static FFieldAddress OnExecution_OutObjects_PropertyAddress;

	private static int OnExecution_OutObjects_Offset;

	private static bool GetTooltip_IsValid;

	private IntPtr GetTooltip_InstanceFunctionAddress;

	private static IntPtr GetTooltip_FunctionAddress;

	private static int GetTooltip_ParamsSize;

	private static bool GetTooltip_ReturnValue_IsValid;

	private static FFieldAddress GetTooltip_ReturnValue_PropertyAddress;

	private static int GetTooltip_ReturnValue_Offset;

	private static bool GetDisplayTransformName_IsValid;

	private IntPtr GetDisplayTransformName_InstanceFunctionAddress;

	private static IntPtr GetDisplayTransformName_FunctionAddress;

	private static int GetDisplayTransformName_ParamsSize;

	private static bool GetDisplayTransformName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayTransformName_ReturnValue_PropertyAddress;

	private static int GetDisplayTransformName_ReturnValue_Offset;

	private static bool GetCategory_IsValid;

	private IntPtr GetCategory_InstanceFunctionAddress;

	private static IntPtr GetCategory_FunctionAddress;

	private static int GetCategory_ParamsSize;

	private static bool GetCategory_ReturnValue_IsValid;

	private static FFieldAddress GetCategory_ReturnValue_PropertyAddress;

	private static int GetCategory_ReturnValue_Offset;

	private static bool GetAdditionalKeyword_IsValid;

	private IntPtr GetAdditionalKeyword_InstanceFunctionAddress;

	private static IntPtr GetAdditionalKeyword_FunctionAddress;

	private static int GetAdditionalKeyword_ParamsSize;

	private static bool GetAdditionalKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetAdditionalKeyword_ReturnValue_PropertyAddress;

	private static int GetAdditionalKeyword_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_InObjects_IsValid;

	private static FFieldAddress Execute_InObjects_PropertyAddress;

	private static int Execute_InObjects_Offset;

	private static bool Execute_OutObjects_IsValid;

	private static FFieldAddress Execute_OutObjects_PropertyAddress;

	private static int Execute_OutObjects_Offset;

	[UFunction(Flags = 138939392u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:OnExecution")]
	protected unsafe void OnExecution(List<UObject> InObjects, out List<UObject> OutObjects)
	{
		CheckDestroyed();
		if (!OnExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:OnExecution");
			OutObjects = null;
			return;
		}
		if (OnExecution_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnExecution_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnExecution");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, OnExecution_InObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OnExecution_InObjects_Offset), InObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExecution_InstanceFunctionAddress, intPtr, OnExecution_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExecution_InObjects_PropertyAddress.Address, intPtr);
		OutObjects = new TArrayCopyMarshaler<UObject>(1, OnExecution_OutObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, OnExecution_OutObjects_Offset));
		NativeReflection.DestroyValue_InContainer(OnExecution_OutObjects_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnExecution_Implementation(List<UObject> InObjects, out List<UObject> OutObjects)
	{
		CheckDestroyed();
		if (!OnExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:OnExecution");
			OutObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, OnExecution_InObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OnExecution_InObjects_Offset), InObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExecution_FunctionAddress, intPtr, OnExecution_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExecution_InObjects_PropertyAddress.Address, intPtr);
		OutObjects = new TArrayCopyMarshaler<UObject>(1, OnExecution_OutObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, OnExecution_OutObjects_Offset));
		NativeReflection.DestroyValue_InContainer(OnExecution_OutObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:GetTooltip")]
	public unsafe string GetTooltip()
	{
		CheckDestroyed();
		if (!GetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetTooltip");
			return FStringMarshaler.DefaultString;
		}
		if (GetTooltip_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTooltip_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTooltip");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltip_InstanceFunctionAddress, intPtr, GetTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltip_ReturnValue_Offset), 0, GetTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetTooltip_Implementation()
	{
		CheckDestroyed();
		if (!GetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetTooltip");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltip_FunctionAddress, intPtr, GetTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltip_ReturnValue_Offset), 0, GetTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:GetDisplayTransformName")]
	public unsafe string GetDisplayTransformName()
	{
		CheckDestroyed();
		if (!GetDisplayTransformName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetDisplayTransformName");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayTransformName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayTransformName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayTransformName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayTransformName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayTransformName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayTransformName_InstanceFunctionAddress, intPtr, GetDisplayTransformName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayTransformName_ReturnValue_Offset), 0, GetDisplayTransformName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayTransformName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDisplayTransformName_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayTransformName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetDisplayTransformName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayTransformName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayTransformName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayTransformName_FunctionAddress, intPtr, GetDisplayTransformName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayTransformName_ReturnValue_Offset), 0, GetDisplayTransformName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayTransformName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:GetCategory")]
	public unsafe string GetCategory()
	{
		CheckDestroyed();
		if (!GetCategory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetCategory");
			return FStringMarshaler.DefaultString;
		}
		if (GetCategory_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCategory_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCategory");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategory_InstanceFunctionAddress, intPtr, GetCategory_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCategory_ReturnValue_Offset), 0, GetCategory_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetCategory_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetCategory_Implementation()
	{
		CheckDestroyed();
		if (!GetCategory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetCategory");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategory_FunctionAddress, intPtr, GetCategory_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCategory_ReturnValue_Offset), 0, GetCategory_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetCategory_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:GetAdditionalKeyword")]
	public unsafe string GetAdditionalKeyword()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetAdditionalKeyword");
			return FStringMarshaler.DefaultString;
		}
		if (GetAdditionalKeyword_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAdditionalKeyword_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAdditionalKeyword");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditionalKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditionalKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAdditionalKeyword_InstanceFunctionAddress, intPtr, GetAdditionalKeyword_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAdditionalKeyword_ReturnValue_Offset), 0, GetAdditionalKeyword_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAdditionalKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetAdditionalKeyword_Implementation()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:GetAdditionalKeyword");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditionalKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditionalKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAdditionalKeyword_FunctionAddress, intPtr, GetAdditionalKeyword_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAdditionalKeyword_ReturnValue_Offset), 0, GetAdditionalKeyword_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAdditionalKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepSelectionTransform:Execute")]
	public unsafe void Execute(List<UObject> InObjects, out List<UObject> OutObjects)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepSelectionTransform:Execute");
			OutObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, Execute_InObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, Execute_InObjects_Offset), InObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_InObjects_PropertyAddress.Address, intPtr);
		OutObjects = new TArrayCopyMarshaler<UObject>(1, Execute_OutObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, Execute_OutObjects_Offset));
		NativeReflection.DestroyValue_InContainer(Execute_OutObjects_PropertyAddress.Address, intPtr);
	}

	static UDataprepSelectionTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSelectionTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSelectionTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepSelectionTransform");
		OnExecution_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnExecution");
		OnExecution_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExecution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExecution_InObjects_PropertyAddress, OnExecution_FunctionAddress, "InObjects");
		OnExecution_InObjects_Offset = NativeReflectionCached.GetPropertyOffset(OnExecution_FunctionAddress, "InObjects");
		OnExecution_InObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecution_FunctionAddress, "InObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExecution_OutObjects_PropertyAddress, OnExecution_FunctionAddress, "OutObjects");
		OnExecution_OutObjects_Offset = NativeReflectionCached.GetPropertyOffset(OnExecution_FunctionAddress, "OutObjects");
		OnExecution_OutObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecution_FunctionAddress, "OutObjects", Classes.FArrayProperty);
		OnExecution_IsValid = OnExecution_FunctionAddress != IntPtr.Zero && OnExecution_InObjects_IsValid && OnExecution_OutObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:OnExecution", OnExecution_IsValid);
		GetTooltip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTooltip");
		GetTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTooltip_ReturnValue_PropertyAddress, GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTooltip_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTooltip_IsValid = GetTooltip_FunctionAddress != IntPtr.Zero && GetTooltip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:GetTooltip", GetTooltip_IsValid);
		GetDisplayTransformName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayTransformName");
		GetDisplayTransformName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTransformName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayTransformName_ReturnValue_PropertyAddress, GetDisplayTransformName_FunctionAddress, "ReturnValue");
		GetDisplayTransformName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayTransformName_FunctionAddress, "ReturnValue");
		GetDisplayTransformName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayTransformName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayTransformName_IsValid = GetDisplayTransformName_FunctionAddress != IntPtr.Zero && GetDisplayTransformName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:GetDisplayTransformName", GetDisplayTransformName_IsValid);
		GetCategory_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCategory");
		GetCategory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCategory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCategory_ReturnValue_PropertyAddress, GetCategory_FunctionAddress, "ReturnValue");
		GetCategory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCategory_FunctionAddress, "ReturnValue");
		GetCategory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCategory_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetCategory_IsValid = GetCategory_FunctionAddress != IntPtr.Zero && GetCategory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:GetCategory", GetCategory_IsValid);
		GetAdditionalKeyword_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAdditionalKeyword");
		GetAdditionalKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditionalKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditionalKeyword_ReturnValue_PropertyAddress, GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditionalKeyword_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAdditionalKeyword_IsValid = GetAdditionalKeyword_FunctionAddress != IntPtr.Zero && GetAdditionalKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:GetAdditionalKeyword", GetAdditionalKeyword_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_InObjects_PropertyAddress, Execute_FunctionAddress, "InObjects");
		Execute_InObjects_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InObjects");
		Execute_InObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Execute_OutObjects_PropertyAddress, Execute_FunctionAddress, "OutObjects");
		Execute_OutObjects_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "OutObjects");
		Execute_OutObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "OutObjects", Classes.FArrayProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_InObjects_IsValid && Execute_OutObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepSelectionTransform:Execute", Execute_IsValid);
	}
}
