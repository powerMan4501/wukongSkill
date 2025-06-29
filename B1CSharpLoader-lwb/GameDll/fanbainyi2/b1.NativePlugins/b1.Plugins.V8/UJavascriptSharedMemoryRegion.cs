using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptSharedMemoryRegion", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptSharedMemoryRegion : UJavascriptMemoryObject
{
	private static IntPtr classAddress;

	private static bool Dispose_IsValid;

	private static IntPtr Dispose_FunctionAddress;

	private static int Dispose_ParamsSize;

	private static bool Create_IsValid;

	private static IntPtr Create_FunctionAddress;

	private static int Create_ParamsSize;

	private static bool Create_Name_IsValid;

	private static FFieldAddress Create_Name_PropertyAddress;

	private static int Create_Name_Offset;

	private static bool Create_bCreate_IsValid;

	private static FFieldAddress Create_bCreate_PropertyAddress;

	private static int Create_bCreate_Offset;

	private static bool Create_bRead_IsValid;

	private static FFieldAddress Create_bRead_PropertyAddress;

	private static int Create_bRead_Offset;

	private static bool Create_bWrite_IsValid;

	private static FFieldAddress Create_bWrite_PropertyAddress;

	private static int Create_bWrite_Offset;

	private static bool Create_Size_IsValid;

	private static FFieldAddress Create_Size_PropertyAddress;

	private static int Create_Size_Offset;

	private static bool Create_ReturnValue_IsValid;

	private static FFieldAddress Create_ReturnValue_PropertyAddress;

	private static int Create_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptSharedMemoryRegion:Dispose")]
	public unsafe void Dispose()
	{
		CheckDestroyed();
		if (!Dispose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSharedMemoryRegion:Dispose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Dispose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Dispose_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Dispose_FunctionAddress, argsSize: Dispose_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptSharedMemoryRegion:Create")]
	public unsafe static UJavascriptSharedMemoryRegion Create(FName Name, bool bCreate, bool bRead, bool bWrite, int Size)
	{
		if (!Create_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSharedMemoryRegion:Create");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Create_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Create_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Create_Name_Offset), 0, Create_Name_PropertyAddress.Address, Name);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bCreate_Offset), 0, Create_bCreate_PropertyAddress.Address, bCreate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bRead_Offset), 0, Create_bRead_PropertyAddress.Address, bRead);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bWrite_Offset), 0, Create_bWrite_PropertyAddress.Address, bWrite);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Create_Size_Offset), 0, Create_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Create_FunctionAddress, intPtr, Create_ParamsSize);
		return UObjectMarshaler<UJavascriptSharedMemoryRegion>.FromNative(IntPtr.Add(intPtr, Create_ReturnValue_Offset), 0, Create_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptSharedMemoryRegion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptSharedMemoryRegion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptSharedMemoryRegion));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/V8.JavascriptSharedMemoryRegion");
		Dispose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Dispose");
		Dispose_ParamsSize = NativeReflection.GetFunctionParamsSize(Dispose_FunctionAddress);
		Dispose_IsValid = Dispose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSharedMemoryRegion:Dispose", Dispose_IsValid);
		Create_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Create");
		Create_ParamsSize = NativeReflection.GetFunctionParamsSize(Create_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Create_Name_PropertyAddress, Create_FunctionAddress, "Name");
		Create_Name_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "Name");
		Create_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bCreate_PropertyAddress, Create_FunctionAddress, "bCreate");
		Create_bCreate_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bCreate");
		Create_bCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bRead_PropertyAddress, Create_FunctionAddress, "bRead");
		Create_bRead_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bRead");
		Create_bRead_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bRead", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bWrite_PropertyAddress, Create_FunctionAddress, "bWrite");
		Create_bWrite_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bWrite");
		Create_bWrite_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bWrite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_Size_PropertyAddress, Create_FunctionAddress, "Size");
		Create_Size_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "Size");
		Create_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "Size", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_ReturnValue_PropertyAddress, Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Create_IsValid = Create_FunctionAddress != IntPtr.Zero && Create_Name_IsValid && Create_bCreate_IsValid && Create_bRead_IsValid && Create_bWrite_IsValid && Create_Size_IsValid && Create_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSharedMemoryRegion:Create", Create_IsValid);
	}
}
