using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/V8.JavascriptIsolate", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptIsolate : UObject
{
	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_bIsEditor_IsValid;

	private static FFieldAddress Init_bIsEditor_PropertyAddress;

	private static int Init_bIsEditor_Offset;

	private static bool GetHeapStatistics_IsValid;

	private static IntPtr GetHeapStatistics_FunctionAddress;

	private static int GetHeapStatistics_ParamsSize;

	private static bool GetHeapStatistics_Statistics_IsValid;

	private static FFieldAddress GetHeapStatistics_Statistics_PropertyAddress;

	private static int GetHeapStatistics_Statistics_Offset;

	private static bool CreateContext_IsValid;

	private static IntPtr CreateContext_FunctionAddress;

	private static int CreateContext_ParamsSize;

	private static bool CreateContext_ReturnValue_IsValid;

	private static FFieldAddress CreateContext_ReturnValue_PropertyAddress;

	private static int CreateContext_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptIsolate:Init")]
	public unsafe void Init(bool bIsEditor)
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptIsolate:Init");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Init_bIsEditor_Offset), 0, Init_bIsEditor_PropertyAddress.Address, bIsEditor);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/V8.JavascriptIsolate:GetHeapStatistics")]
	public unsafe void GetHeapStatistics(out FJavascriptHeapStatistics Statistics)
	{
		CheckDestroyed();
		if (!GetHeapStatistics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptIsolate:GetHeapStatistics");
			Statistics = default(FJavascriptHeapStatistics);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeapStatistics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeapStatistics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHeapStatistics_FunctionAddress, intPtr, GetHeapStatistics_ParamsSize);
		Statistics = FJavascriptHeapStatistics.FromNative(IntPtr.Add(intPtr, GetHeapStatistics_Statistics_Offset), 0, GetHeapStatistics_Statistics_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptIsolate:CreateContext")]
	public unsafe UJavascriptContext CreateContext()
	{
		CheckDestroyed();
		if (!CreateContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptIsolate:CreateContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateContext_FunctionAddress, intPtr, CreateContext_ParamsSize);
		return UObjectMarshaler<UJavascriptContext>.FromNative(IntPtr.Add(intPtr, CreateContext_ReturnValue_Offset), 0, CreateContext_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptIsolate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptIsolate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptIsolate));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/V8.JavascriptIsolate");
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_bIsEditor_PropertyAddress, Init_FunctionAddress, "bIsEditor");
		Init_bIsEditor_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "bIsEditor");
		Init_bIsEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "bIsEditor", Classes.FBoolProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_bIsEditor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptIsolate:Init", Init_IsValid);
		GetHeapStatistics_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHeapStatistics");
		GetHeapStatistics_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeapStatistics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeapStatistics_Statistics_PropertyAddress, GetHeapStatistics_FunctionAddress, "Statistics");
		GetHeapStatistics_Statistics_Offset = NativeReflectionCached.GetPropertyOffset(GetHeapStatistics_FunctionAddress, "Statistics");
		GetHeapStatistics_Statistics_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeapStatistics_FunctionAddress, "Statistics", Classes.FStructProperty);
		GetHeapStatistics_IsValid = GetHeapStatistics_FunctionAddress != IntPtr.Zero && GetHeapStatistics_Statistics_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptIsolate:GetHeapStatistics", GetHeapStatistics_IsValid);
		CreateContext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateContext");
		CreateContext_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateContext_ReturnValue_PropertyAddress, CreateContext_FunctionAddress, "ReturnValue");
		CreateContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateContext_FunctionAddress, "ReturnValue");
		CreateContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateContext_IsValid = CreateContext_FunctionAddress != IntPtr.Zero && CreateContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptIsolate:CreateContext", CreateContext_IsValid);
	}
}
