using System;
using System.Runtime.CompilerServices;
using b1.Plugins.V8;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptTileView", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptTileView : UTileView
{
	private static bool JavascriptContext_IsValid;

	private static int JavascriptContext_Offset;

	private static bool OnSelectionChanged_IsValid;

	private IntPtr OnSelectionChanged_InstanceFunctionAddress;

	private static IntPtr OnSelectionChanged_FunctionAddress;

	private static int OnSelectionChanged_ParamsSize;

	private static bool OnSelectionChanged_Object_IsValid;

	private static FFieldAddress OnSelectionChanged_Object_PropertyAddress;

	private static int OnSelectionChanged_Object_Offset;

	private static bool OnSelectionChanged_Type_IsValid;

	private static FFieldAddress OnSelectionChanged_Type_PropertyAddress;

	private static int OnSelectionChanged_Type_Offset;

	private static bool OnDoubleClick_IsValid;

	private IntPtr OnDoubleClick_InstanceFunctionAddress;

	private static IntPtr OnDoubleClick_FunctionAddress;

	private static int OnDoubleClick_ParamsSize;

	private static bool OnDoubleClick_Object_IsValid;

	private static FFieldAddress OnDoubleClick_Object_PropertyAddress;

	private static int OnDoubleClick_Object_Offset;

	private static bool OnClick_IsValid;

	private IntPtr OnClick_InstanceFunctionAddress;

	private static IntPtr OnClick_FunctionAddress;

	private static int OnClick_ParamsSize;

	private static bool OnClick_Object_IsValid;

	private static FFieldAddress OnClick_Object_PropertyAddress;

	private static int OnClick_Object_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTileView:JavascriptContext")]
	public UJavascriptContext JavascriptContext
	{
		get
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTileView:JavascriptContext");
				return null;
			}
			return UObjectMarshaler<UJavascriptContext>.FromNative(IntPtr.Add(base.Address, JavascriptContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptTileView:JavascriptContext");
			}
			else
			{
				UObjectMarshaler<UJavascriptContext>.ToNative(IntPtr.Add(base.Address, JavascriptContext_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTileView:OnSelectionChanged")]
	public unsafe void OnSelectionChanged(UObject Object, ESelectInfo Type)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnSelectionChanged");
			return;
		}
		if (OnSelectionChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSelectionChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSelectionChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Object_Offset), 0, OnSelectionChanged_Object_PropertyAddress.Address, Object);
		EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Type_Offset), 0, OnSelectionChanged_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_InstanceFunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	protected unsafe virtual void OnSelectionChanged_Implementation(UObject Object, ESelectInfo Type)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnSelectionChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Object_Offset), 0, OnSelectionChanged_Object_PropertyAddress.Address, Object);
		EnumMarshaler<ESelectInfo>.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_Type_Offset), 0, OnSelectionChanged_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_FunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTileView:OnDoubleClick")]
	public unsafe void OnDoubleClick(UObject Object)
	{
		CheckDestroyed();
		if (!OnDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnDoubleClick");
			return;
		}
		if (OnDoubleClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDoubleClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDoubleClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnDoubleClick_Object_Offset), 0, OnDoubleClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDoubleClick_InstanceFunctionAddress, intPtr, OnDoubleClick_ParamsSize);
	}

	protected unsafe virtual void OnDoubleClick_Implementation(UObject Object)
	{
		CheckDestroyed();
		if (!OnDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnDoubleClick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnDoubleClick_Object_Offset), 0, OnDoubleClick_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDoubleClick_FunctionAddress, intPtr, OnDoubleClick_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptTileView:OnClick")]
	public unsafe void OnClick(UObject Object)
	{
		CheckDestroyed();
		if (!OnClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnClick");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptTileView:OnClick");
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

	static UJavascriptTileView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptTileView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptTileView));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptTileView");
		JavascriptContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JavascriptContext");
		JavascriptContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JavascriptContext", Classes.FObjectProperty);
		OnSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSelectionChanged");
		OnSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSelectionChanged_Object_PropertyAddress, OnSelectionChanged_FunctionAddress, "Object");
		OnSelectionChanged_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "Object");
		OnSelectionChanged_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSelectionChanged_Type_PropertyAddress, OnSelectionChanged_FunctionAddress, "Type");
		OnSelectionChanged_Type_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "Type");
		OnSelectionChanged_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "Type", Classes.FByteProperty);
		OnSelectionChanged_IsValid = OnSelectionChanged_FunctionAddress != IntPtr.Zero && OnSelectionChanged_Object_IsValid && OnSelectionChanged_Type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTileView:OnSelectionChanged", OnSelectionChanged_IsValid);
		OnDoubleClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDoubleClick");
		OnDoubleClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDoubleClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDoubleClick_Object_PropertyAddress, OnDoubleClick_FunctionAddress, "Object");
		OnDoubleClick_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnDoubleClick_FunctionAddress, "Object");
		OnDoubleClick_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDoubleClick_FunctionAddress, "Object", Classes.FObjectProperty);
		OnDoubleClick_IsValid = OnDoubleClick_FunctionAddress != IntPtr.Zero && OnDoubleClick_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTileView:OnDoubleClick", OnDoubleClick_IsValid);
		OnClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClick");
		OnClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnClick_Object_PropertyAddress, OnClick_FunctionAddress, "Object");
		OnClick_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnClick_FunctionAddress, "Object");
		OnClick_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnClick_FunctionAddress, "Object", Classes.FObjectProperty);
		OnClick_IsValid = OnClick_FunctionAddress != IntPtr.Zero && OnClick_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptTileView:OnClick", OnClick_IsValid);
	}
}
