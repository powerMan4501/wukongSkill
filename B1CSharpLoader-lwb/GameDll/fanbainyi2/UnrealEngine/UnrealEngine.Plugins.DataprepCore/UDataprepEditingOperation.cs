using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepCore.DataprepEditingOperation", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepEditingOperation : UDataprepOperation
{
	private static bool RemoveObjects_IsValid;

	private static IntPtr RemoveObjects_FunctionAddress;

	private static int RemoveObjects_ParamsSize;

	private static bool RemoveObjects_Objects_IsValid;

	private static FFieldAddress RemoveObjects_Objects_PropertyAddress;

	private static int RemoveObjects_Objects_Offset;

	private static bool RemoveObjects_bLocalContext_IsValid;

	private static FFieldAddress RemoveObjects_bLocalContext_PropertyAddress;

	private static int RemoveObjects_bLocalContext_Offset;

	private static bool RemoveObject_IsValid;

	private static IntPtr RemoveObject_FunctionAddress;

	private static int RemoveObject_ParamsSize;

	private static bool RemoveObject_Object_IsValid;

	private static FFieldAddress RemoveObject_Object_PropertyAddress;

	private static int RemoveObject_Object_Offset;

	private static bool RemoveObject_bLocalContext_IsValid;

	private static FFieldAddress RemoveObject_bLocalContext_PropertyAddress;

	private static int RemoveObject_bLocalContext_Offset;

	private static bool DeleteObjects_IsValid;

	private static IntPtr DeleteObjects_FunctionAddress;

	private static int DeleteObjects_ParamsSize;

	private static bool DeleteObjects_Objects_IsValid;

	private static FFieldAddress DeleteObjects_Objects_PropertyAddress;

	private static int DeleteObjects_Objects_Offset;

	private static bool DeleteObject_IsValid;

	private static IntPtr DeleteObject_FunctionAddress;

	private static int DeleteObject_ParamsSize;

	private static bool DeleteObject_Objects_IsValid;

	private static FFieldAddress DeleteObject_Objects_PropertyAddress;

	private static int DeleteObject_Objects_Offset;

	private static bool CreateAsset_IsValid;

	private static IntPtr CreateAsset_FunctionAddress;

	private static int CreateAsset_ParamsSize;

	private static bool CreateAsset_AssetClass_IsValid;

	private static FFieldAddress CreateAsset_AssetClass_PropertyAddress;

	private static int CreateAsset_AssetClass_Offset;

	private static bool CreateAsset_AssetName_IsValid;

	private static FFieldAddress CreateAsset_AssetName_PropertyAddress;

	private static int CreateAsset_AssetName_Offset;

	private static bool CreateAsset_ReturnValue_IsValid;

	private static FFieldAddress CreateAsset_ReturnValue_PropertyAddress;

	private static int CreateAsset_ReturnValue_Offset;

	private static bool CreateActor_IsValid;

	private static IntPtr CreateActor_FunctionAddress;

	private static int CreateActor_ParamsSize;

	private static bool CreateActor_ActorClass_IsValid;

	private static FFieldAddress CreateActor_ActorClass_PropertyAddress;

	private static int CreateActor_ActorClass_Offset;

	private static bool CreateActor_ActorName_IsValid;

	private static FFieldAddress CreateActor_ActorName_PropertyAddress;

	private static int CreateActor_ActorName_Offset;

	private static bool CreateActor_ReturnValue_IsValid;

	private static FFieldAddress CreateActor_ReturnValue_PropertyAddress;

	private static int CreateActor_ReturnValue_Offset;

	private static bool AddAsset_IsValid;

	private static IntPtr AddAsset_FunctionAddress;

	private static int AddAsset_ParamsSize;

	private static bool AddAsset_Asset_IsValid;

	private static FFieldAddress AddAsset_Asset_PropertyAddress;

	private static int AddAsset_Asset_Offset;

	private static bool AddAsset_AssetName_IsValid;

	private static FFieldAddress AddAsset_AssetName_PropertyAddress;

	private static int AddAsset_AssetName_Offset;

	private static bool AddAsset_ReturnValue_IsValid;

	private static FFieldAddress AddAsset_ReturnValue_PropertyAddress;

	private static int AddAsset_ReturnValue_Offset;

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:RemoveObjects")]
	protected unsafe void RemoveObjects(List<UObject> Objects, bool bLocalContext = false)
	{
		CheckDestroyed();
		if (!RemoveObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:RemoveObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, RemoveObjects_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveObjects_Objects_Offset), Objects);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveObjects_bLocalContext_Offset), 0, RemoveObjects_bLocalContext_PropertyAddress.Address, bLocalContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveObjects_FunctionAddress, intPtr, RemoveObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveObjects_Objects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:RemoveObject")]
	protected unsafe void RemoveObject(UObject Object, bool bLocalContext = false)
	{
		CheckDestroyed();
		if (!RemoveObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:RemoveObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveObject_Object_Offset), 0, RemoveObject_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveObject_bLocalContext_Offset), 0, RemoveObject_bLocalContext_PropertyAddress.Address, bLocalContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveObject_FunctionAddress, intPtr, RemoveObject_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:DeleteObjects")]
	protected unsafe void DeleteObjects(List<UObject> Objects)
	{
		CheckDestroyed();
		if (!DeleteObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:DeleteObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, DeleteObjects_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteObjects_Objects_Offset), Objects);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteObjects_FunctionAddress, intPtr, DeleteObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteObjects_Objects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:DeleteObject")]
	protected unsafe void DeleteObject(UObject Objects)
	{
		CheckDestroyed();
		if (!DeleteObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:DeleteObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DeleteObject_Objects_Offset), 0, DeleteObject_Objects_PropertyAddress.Address, Objects);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteObject_FunctionAddress, intPtr, DeleteObject_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:CreateAsset")]
	protected unsafe UObject CreateAsset(TSubclassOf<UObject> AssetClass, string AssetName)
	{
		CheckDestroyed();
		if (!CreateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:CreateAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateAsset_AssetClass_Offset), 0, CreateAsset_AssetClass_PropertyAddress.Address, AssetClass);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAsset_AssetName_Offset), 0, CreateAsset_AssetName_PropertyAddress.Address, AssetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateAsset_FunctionAddress, intPtr, CreateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAsset_AssetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CreateAsset_ReturnValue_Offset), 0, CreateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:CreateActor")]
	protected unsafe AActor CreateActor(TSubclassOf<UObject> ActorClass, string ActorName)
	{
		CheckDestroyed();
		if (!CreateActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:CreateActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateActor_ActorClass_Offset), 0, CreateActor_ActorClass_PropertyAddress.Address, ActorClass);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateActor_ActorName_Offset), 0, CreateActor_ActorName_PropertyAddress.Address, ActorName);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateActor_FunctionAddress, intPtr, CreateActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateActor_ActorName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, CreateActor_ReturnValue_Offset), 0, CreateActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepEditingOperation:AddAsset")]
	protected unsafe UObject AddAsset(UObject Asset, string AssetName)
	{
		CheckDestroyed();
		if (!AddAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepEditingOperation:AddAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddAsset_Asset_Offset), 0, AddAsset_Asset_PropertyAddress.Address, Asset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddAsset_AssetName_Offset), 0, AddAsset_AssetName_PropertyAddress.Address, AssetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAsset_FunctionAddress, intPtr, AddAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAsset_AssetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, AddAsset_ReturnValue_Offset), 0, AddAsset_ReturnValue_PropertyAddress.Address);
	}

	static UDataprepEditingOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepEditingOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepEditingOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepEditingOperation");
		RemoveObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveObjects");
		RemoveObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveObjects_Objects_PropertyAddress, RemoveObjects_FunctionAddress, "Objects");
		RemoveObjects_Objects_Offset = NativeReflectionCached.GetPropertyOffset(RemoveObjects_FunctionAddress, "Objects");
		RemoveObjects_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveObjects_FunctionAddress, "Objects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveObjects_bLocalContext_PropertyAddress, RemoveObjects_FunctionAddress, "bLocalContext");
		RemoveObjects_bLocalContext_Offset = NativeReflectionCached.GetPropertyOffset(RemoveObjects_FunctionAddress, "bLocalContext");
		RemoveObjects_bLocalContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveObjects_FunctionAddress, "bLocalContext", Classes.FBoolProperty);
		RemoveObjects_IsValid = RemoveObjects_FunctionAddress != IntPtr.Zero && RemoveObjects_Objects_IsValid && RemoveObjects_bLocalContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:RemoveObjects", RemoveObjects_IsValid);
		RemoveObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveObject");
		RemoveObject_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveObject_Object_PropertyAddress, RemoveObject_FunctionAddress, "Object");
		RemoveObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(RemoveObject_FunctionAddress, "Object");
		RemoveObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveObject_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveObject_bLocalContext_PropertyAddress, RemoveObject_FunctionAddress, "bLocalContext");
		RemoveObject_bLocalContext_Offset = NativeReflectionCached.GetPropertyOffset(RemoveObject_FunctionAddress, "bLocalContext");
		RemoveObject_bLocalContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveObject_FunctionAddress, "bLocalContext", Classes.FBoolProperty);
		RemoveObject_IsValid = RemoveObject_FunctionAddress != IntPtr.Zero && RemoveObject_Object_IsValid && RemoveObject_bLocalContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:RemoveObject", RemoveObject_IsValid);
		DeleteObjects_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteObjects");
		DeleteObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteObjects_Objects_PropertyAddress, DeleteObjects_FunctionAddress, "Objects");
		DeleteObjects_Objects_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObjects_FunctionAddress, "Objects");
		DeleteObjects_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObjects_FunctionAddress, "Objects", Classes.FArrayProperty);
		DeleteObjects_IsValid = DeleteObjects_FunctionAddress != IntPtr.Zero && DeleteObjects_Objects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:DeleteObjects", DeleteObjects_IsValid);
		DeleteObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteObject");
		DeleteObject_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteObject_Objects_PropertyAddress, DeleteObject_FunctionAddress, "Objects");
		DeleteObject_Objects_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObject_FunctionAddress, "Objects");
		DeleteObject_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObject_FunctionAddress, "Objects", Classes.FObjectProperty);
		DeleteObject_IsValid = DeleteObject_FunctionAddress != IntPtr.Zero && DeleteObject_Objects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:DeleteObject", DeleteObject_IsValid);
		CreateAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateAsset");
		CreateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_AssetClass_PropertyAddress, CreateAsset_FunctionAddress, "AssetClass");
		CreateAsset_AssetClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "AssetClass");
		CreateAsset_AssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "AssetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_AssetName_PropertyAddress, CreateAsset_FunctionAddress, "AssetName");
		CreateAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "AssetName");
		CreateAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_ReturnValue_PropertyAddress, CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAsset_IsValid = CreateAsset_FunctionAddress != IntPtr.Zero && CreateAsset_AssetClass_IsValid && CreateAsset_AssetName_IsValid && CreateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:CreateAsset", CreateAsset_IsValid);
		CreateActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateActor");
		CreateActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateActor_ActorClass_PropertyAddress, CreateActor_FunctionAddress, "ActorClass");
		CreateActor_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateActor_FunctionAddress, "ActorClass");
		CreateActor_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActor_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateActor_ActorName_PropertyAddress, CreateActor_FunctionAddress, "ActorName");
		CreateActor_ActorName_Offset = NativeReflectionCached.GetPropertyOffset(CreateActor_FunctionAddress, "ActorName");
		CreateActor_ActorName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActor_FunctionAddress, "ActorName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateActor_ReturnValue_PropertyAddress, CreateActor_FunctionAddress, "ReturnValue");
		CreateActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateActor_FunctionAddress, "ReturnValue");
		CreateActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateActor_IsValid = CreateActor_FunctionAddress != IntPtr.Zero && CreateActor_ActorClass_IsValid && CreateActor_ActorName_IsValid && CreateActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:CreateActor", CreateActor_IsValid);
		AddAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddAsset");
		AddAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAsset_Asset_PropertyAddress, AddAsset_FunctionAddress, "Asset");
		AddAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(AddAsset_FunctionAddress, "Asset");
		AddAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAsset_AssetName_PropertyAddress, AddAsset_FunctionAddress, "AssetName");
		AddAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(AddAsset_FunctionAddress, "AssetName");
		AddAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAsset_ReturnValue_PropertyAddress, AddAsset_FunctionAddress, "ReturnValue");
		AddAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAsset_FunctionAddress, "ReturnValue");
		AddAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddAsset_IsValid = AddAsset_FunctionAddress != IntPtr.Zero && AddAsset_Asset_IsValid && AddAsset_AssetName_IsValid && AddAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepEditingOperation:AddAsset", AddAsset_IsValid);
	}
}
