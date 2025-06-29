using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptUserObjectListEntry", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptUserObjectListEntry : UUserWidget
{
	private static bool OnListItemObjectSet_IsValid;

	private IntPtr OnListItemObjectSet_InstanceFunctionAddress;

	private static IntPtr OnListItemObjectSet_FunctionAddress;

	private static int OnListItemObjectSet_ParamsSize;

	private static bool OnListItemObjectSet_ListItemObject_IsValid;

	private static FFieldAddress OnListItemObjectSet_ListItemObject_PropertyAddress;

	private static int OnListItemObjectSet_ListItemObject_Offset;

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/UMG.UserObjectListEntry:OnListItemObjectSet")]
	public unsafe void OnListItemObjectSet(UObject ListItemObject)
	{
		CheckDestroyed();
		if (!OnListItemObjectSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserObjectListEntry:OnListItemObjectSet");
			return;
		}
		if (OnListItemObjectSet_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnListItemObjectSet_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnListItemObjectSet");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListItemObjectSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListItemObjectSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnListItemObjectSet_ListItemObject_Offset), 0, OnListItemObjectSet_ListItemObject_PropertyAddress.Address, ListItemObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListItemObjectSet_InstanceFunctionAddress, intPtr, OnListItemObjectSet_ParamsSize);
	}

	protected unsafe void OnListItemObjectSet_Implementation(UObject ListItemObject)
	{
		CheckDestroyed();
		if (!OnListItemObjectSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserObjectListEntry:OnListItemObjectSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListItemObjectSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListItemObjectSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnListItemObjectSet_ListItemObject_Offset), 0, OnListItemObjectSet_ListItemObject_PropertyAddress.Address, ListItemObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListItemObjectSet_FunctionAddress, intPtr, OnListItemObjectSet_ParamsSize);
	}

	static UJavascriptUserObjectListEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptUserObjectListEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptUserObjectListEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptUserObjectListEntry");
		OnListItemObjectSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnListItemObjectSet");
		OnListItemObjectSet_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListItemObjectSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListItemObjectSet_ListItemObject_PropertyAddress, OnListItemObjectSet_FunctionAddress, "ListItemObject");
		OnListItemObjectSet_ListItemObject_Offset = NativeReflectionCached.GetPropertyOffset(OnListItemObjectSet_FunctionAddress, "ListItemObject");
		OnListItemObjectSet_ListItemObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListItemObjectSet_FunctionAddress, "ListItemObject", Classes.FObjectProperty);
		OnListItemObjectSet_IsValid = OnListItemObjectSet_FunctionAddress != IntPtr.Zero && OnListItemObjectSet_ListItemObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserObjectListEntry:OnListItemObjectSet", OnListItemObjectSet_IsValid);
	}
}
