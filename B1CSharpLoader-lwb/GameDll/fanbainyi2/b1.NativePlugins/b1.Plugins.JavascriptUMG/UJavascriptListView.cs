using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptListView", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptListView : UJavascriptTreeView
{
	private static bool RequestListRefresh_IsValid;

	private static IntPtr RequestListRefresh_FunctionAddress;

	private static int RequestListRefresh_ParamsSize;

	private static bool OnClick_IsValid;

	private IntPtr OnClick_InstanceFunctionAddress;

	private static IntPtr OnClick_FunctionAddress;

	private static int OnClick_ParamsSize;

	private static bool OnClick_Object_IsValid;

	private static FFieldAddress OnClick_Object_PropertyAddress;

	private static int OnClick_Object_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptListView:RequestListRefresh")]
	public unsafe void RequestListRefresh()
	{
		CheckDestroyed();
		if (!RequestListRefresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptListView:RequestListRefresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestListRefresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestListRefresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestListRefresh_FunctionAddress, argsSize: RequestListRefresh_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptListView:OnClick")]
	public unsafe void OnClick(UObject Object)
	{
		CheckDestroyed();
		if (!OnClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptListView:OnClick");
			return;
		}
		if (OnClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnClick_Object_Offset), 0, OnClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnClick_InstanceFunctionAddress, intPtr, OnClick_ParamsSize);
	}

	protected unsafe virtual void OnClick_Implementation(UObject Object)
	{
		CheckDestroyed();
		if (!OnClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptListView:OnClick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnClick_Object_Offset), 0, OnClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnClick_FunctionAddress, intPtr, OnClick_ParamsSize);
	}

	static UJavascriptListView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptListView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptListView));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptListView");
		RequestListRefresh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestListRefresh");
		RequestListRefresh_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestListRefresh_FunctionAddress);
		RequestListRefresh_IsValid = RequestListRefresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptListView:RequestListRefresh", RequestListRefresh_IsValid);
		OnClick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClick");
		OnClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnClick_Object_PropertyAddress, OnClick_FunctionAddress, "Object");
		OnClick_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnClick_FunctionAddress, "Object");
		OnClick_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnClick_FunctionAddress, "Object", Classes.FObjectProperty);
		OnClick_IsValid = OnClick_FunctionAddress != IntPtr.Zero && OnClick_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptListView:OnClick", OnClick_IsValid);
	}
}
