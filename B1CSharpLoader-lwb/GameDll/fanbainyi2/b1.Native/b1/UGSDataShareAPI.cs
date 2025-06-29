using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GSDataShare.GSDataShareAPI", "GSDataShare", UnrealModuleType.Game)]
public class UGSDataShareAPI : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BPReloadData_IsValid;

	private static IntPtr BPReloadData_FunctionAddress;

	private static int BPReloadData_ParamsSize;

	private static bool BPReloadData_ReturnValue_IsValid;

	private static FFieldAddress BPReloadData_ReturnValue_PropertyAddress;

	private static int BPReloadData_ReturnValue_Offset;

	private static bool BPInitLoadData_IsValid;

	private static IntPtr BPInitLoadData_FunctionAddress;

	private static int BPInitLoadData_ParamsSize;

	private static bool BPInitLoadData_ReturnValue_IsValid;

	private static FFieldAddress BPInitLoadData_ReturnValue_PropertyAddress;

	private static int BPInitLoadData_ReturnValue_Offset;

	private static bool BPCheckDataValid_IsValid;

	private static IntPtr BPCheckDataValid_FunctionAddress;

	private static int BPCheckDataValid_ParamsSize;

	private static bool BPCheckDataValid_ReturnValue_IsValid;

	private static FFieldAddress BPCheckDataValid_ReturnValue_PropertyAddress;

	private static int BPCheckDataValid_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSDataShare.GSDataShareAPI:BPReloadData")]
	public unsafe static int BPReloadData()
	{
		if (!BPReloadData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDataShare.GSDataShareAPI:BPReloadData");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPReloadData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPReloadData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BPReloadData_FunctionAddress, intPtr, BPReloadData_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BPReloadData_ReturnValue_Offset), 0, BPReloadData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSDataShare.GSDataShareAPI:BPInitLoadData")]
	public unsafe static int BPInitLoadData()
	{
		if (!BPInitLoadData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDataShare.GSDataShareAPI:BPInitLoadData");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPInitLoadData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPInitLoadData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BPInitLoadData_FunctionAddress, intPtr, BPInitLoadData_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BPInitLoadData_ReturnValue_Offset), 0, BPInitLoadData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSDataShare.GSDataShareAPI:BPCheckDataValid")]
	public unsafe static int BPCheckDataValid()
	{
		if (!BPCheckDataValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDataShare.GSDataShareAPI:BPCheckDataValid");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPCheckDataValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPCheckDataValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BPCheckDataValid_FunctionAddress, intPtr, BPCheckDataValid_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BPCheckDataValid_ReturnValue_Offset), 0, BPCheckDataValid_ReturnValue_PropertyAddress.Address);
	}

	static UGSDataShareAPI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSDataShareAPI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSDataShareAPI));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSDataShare.GSDataShareAPI");
		BPReloadData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BPReloadData");
		BPReloadData_ParamsSize = NativeReflection.GetFunctionParamsSize(BPReloadData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BPReloadData_ReturnValue_PropertyAddress, BPReloadData_FunctionAddress, "ReturnValue");
		BPReloadData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BPReloadData_FunctionAddress, "ReturnValue");
		BPReloadData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BPReloadData_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BPReloadData_IsValid = BPReloadData_FunctionAddress != IntPtr.Zero && BPReloadData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDataShare.GSDataShareAPI:BPReloadData", BPReloadData_IsValid);
		BPInitLoadData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BPInitLoadData");
		BPInitLoadData_ParamsSize = NativeReflection.GetFunctionParamsSize(BPInitLoadData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BPInitLoadData_ReturnValue_PropertyAddress, BPInitLoadData_FunctionAddress, "ReturnValue");
		BPInitLoadData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BPInitLoadData_FunctionAddress, "ReturnValue");
		BPInitLoadData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BPInitLoadData_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BPInitLoadData_IsValid = BPInitLoadData_FunctionAddress != IntPtr.Zero && BPInitLoadData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDataShare.GSDataShareAPI:BPInitLoadData", BPInitLoadData_IsValid);
		BPCheckDataValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BPCheckDataValid");
		BPCheckDataValid_ParamsSize = NativeReflection.GetFunctionParamsSize(BPCheckDataValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BPCheckDataValid_ReturnValue_PropertyAddress, BPCheckDataValid_FunctionAddress, "ReturnValue");
		BPCheckDataValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BPCheckDataValid_FunctionAddress, "ReturnValue");
		BPCheckDataValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BPCheckDataValid_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BPCheckDataValid_IsValid = BPCheckDataValid_FunctionAddress != IntPtr.Zero && BPCheckDataValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDataShare.GSDataShareAPI:BPCheckDataValid", BPCheckDataValid_IsValid);
	}
}
