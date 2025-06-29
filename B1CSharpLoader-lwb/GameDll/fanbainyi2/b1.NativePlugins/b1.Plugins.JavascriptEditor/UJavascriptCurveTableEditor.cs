using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptCurveTableEditor", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptCurveTableEditor : UWidget
{
	private static bool SetObject_IsValid;

	private static IntPtr SetObject_FunctionAddress;

	private static int SetObject_ParamsSize;

	private static bool SetObject_Object_IsValid;

	private static FFieldAddress SetObject_Object_PropertyAddress;

	private static int SetObject_Object_Offset;

	private static bool SetObject_bForceRefresh_IsValid;

	private static FFieldAddress SetObject_bForceRefresh_PropertyAddress;

	private static int SetObject_bForceRefresh_Offset;

	private static bool Destruct_IsValid;

	private IntPtr Destruct_InstanceFunctionAddress;

	private static IntPtr Destruct_FunctionAddress;

	private static int Destruct_ParamsSize;

	private static bool Construct_IsValid;

	private IntPtr Construct_InstanceFunctionAddress;

	private static IntPtr Construct_FunctionAddress;

	private static int Construct_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptCurveTableEditor:SetObject")]
	public unsafe void SetObject(UCurveTable Object, bool bForceRefresh)
	{
		CheckDestroyed();
		if (!SetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptCurveTableEditor:SetObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveTable>.ToNative(IntPtr.Add(intPtr, SetObject_Object_Offset), 0, SetObject_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetObject_bForceRefresh_Offset), 0, SetObject_bForceRefresh_PropertyAddress.Address, bForceRefresh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObject_FunctionAddress, intPtr, SetObject_ParamsSize);
	}

	[UFunction(Flags = 671221768u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptCurveTableEditor:Destruct")]
	public unsafe void Destruct()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptCurveTableEditor:Destruct");
			return;
		}
		if (Destruct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Destruct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Destruct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_InstanceFunctionAddress, argsSize: Destruct_ParamsSize);
	}

	protected unsafe virtual void Destruct_Implementation()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptCurveTableEditor:Destruct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_FunctionAddress, argsSize: Destruct_ParamsSize);
	}

	[UFunction(Flags = 671221768u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptCurveTableEditor:Construct")]
	public unsafe void Construct()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptCurveTableEditor:Construct");
			return;
		}
		if (Construct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Construct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Construct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_InstanceFunctionAddress, argsSize: Construct_ParamsSize);
	}

	protected unsafe virtual void Construct_Implementation()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptCurveTableEditor:Construct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_FunctionAddress, argsSize: Construct_ParamsSize);
	}

	static UJavascriptCurveTableEditor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptCurveTableEditor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptCurveTableEditor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptCurveTableEditor");
		SetObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetObject");
		SetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObject_Object_PropertyAddress, SetObject_FunctionAddress, "Object");
		SetObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetObject_FunctionAddress, "Object");
		SetObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObject_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObject_bForceRefresh_PropertyAddress, SetObject_FunctionAddress, "bForceRefresh");
		SetObject_bForceRefresh_Offset = NativeReflectionCached.GetPropertyOffset(SetObject_FunctionAddress, "bForceRefresh");
		SetObject_bForceRefresh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObject_FunctionAddress, "bForceRefresh", Classes.FBoolProperty);
		SetObject_IsValid = SetObject_FunctionAddress != IntPtr.Zero && SetObject_Object_IsValid && SetObject_bForceRefresh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptCurveTableEditor:SetObject", SetObject_IsValid);
		Destruct_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destruct");
		Destruct_ParamsSize = NativeReflection.GetFunctionParamsSize(Destruct_FunctionAddress);
		Destruct_IsValid = Destruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptCurveTableEditor:Destruct", Destruct_IsValid);
		Construct_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Construct");
		Construct_ParamsSize = NativeReflection.GetFunctionParamsSize(Construct_FunctionAddress);
		Construct_IsValid = Construct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptCurveTableEditor:Construct", Construct_IsValid);
	}
}
