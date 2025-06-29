using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptProfile", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptProfile : UObject
{
	private static IntPtr classAddress;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool Stop_Profiler_IsValid;

	private static FFieldAddress Stop_Profiler_PropertyAddress;

	private static int Stop_Profiler_Offset;

	private static bool Stop_Title_IsValid;

	private static FFieldAddress Stop_Title_PropertyAddress;

	private static int Stop_Title_Offset;

	private static bool Stop_ReturnValue_IsValid;

	private static FFieldAddress Stop_ReturnValue_PropertyAddress;

	private static int Stop_ReturnValue_Offset;

	private static bool Start_IsValid;

	private static IntPtr Start_FunctionAddress;

	private static int Start_ParamsSize;

	private static bool Start_Title_IsValid;

	private static FFieldAddress Start_Title_PropertyAddress;

	private static int Start_Title_Offset;

	private static bool Start_bRecordSamples_IsValid;

	private static FFieldAddress Start_bRecordSamples_PropertyAddress;

	private static int Start_bRecordSamples_Offset;

	private static bool Start_ReturnValue_IsValid;

	private static FFieldAddress Start_ReturnValue_PropertyAddress;

	private static int Start_ReturnValue_Offset;

	private static bool SetSamplingInterval_IsValid;

	private static IntPtr SetSamplingInterval_FunctionAddress;

	private static int SetSamplingInterval_ParamsSize;

	private static bool SetSamplingInterval_Profiler_IsValid;

	private static FFieldAddress SetSamplingInterval_Profiler_PropertyAddress;

	private static int SetSamplingInterval_Profiler_Offset;

	private static bool SetSamplingInterval_us_IsValid;

	private static FFieldAddress SetSamplingInterval_us_PropertyAddress;

	private static int SetSamplingInterval_us_Offset;

	private static bool SetIdle_IsValid;

	private static IntPtr SetIdle_FunctionAddress;

	private static int SetIdle_ParamsSize;

	private static bool SetIdle_Profiler_IsValid;

	private static FFieldAddress SetIdle_Profiler_PropertyAddress;

	private static int SetIdle_Profiler_Offset;

	private static bool SetIdle_is_idle_IsValid;

	private static FFieldAddress SetIdle_is_idle_PropertyAddress;

	private static int SetIdle_is_idle_Offset;

	private static bool GetTopDownRoot_IsValid;

	private static IntPtr GetTopDownRoot_FunctionAddress;

	private static int GetTopDownRoot_ParamsSize;

	private static bool GetTopDownRoot_ReturnValue_IsValid;

	private static FFieldAddress GetTopDownRoot_ReturnValue_PropertyAddress;

	private static int GetTopDownRoot_ReturnValue_Offset;

	private static bool GetSampleTimestamp_IsValid;

	private static IntPtr GetSampleTimestamp_FunctionAddress;

	private static int GetSampleTimestamp_ParamsSize;

	private static bool GetSampleTimestamp_index_IsValid;

	private static FFieldAddress GetSampleTimestamp_index_PropertyAddress;

	private static int GetSampleTimestamp_index_Offset;

	private static bool GetSampleTimestamp_ReturnValue_IsValid;

	private static FFieldAddress GetSampleTimestamp_ReturnValue_PropertyAddress;

	private static int GetSampleTimestamp_ReturnValue_Offset;

	private static bool GetSamplesCount_IsValid;

	private static IntPtr GetSamplesCount_FunctionAddress;

	private static int GetSamplesCount_ParamsSize;

	private static bool GetSamplesCount_ReturnValue_IsValid;

	private static FFieldAddress GetSamplesCount_ReturnValue_PropertyAddress;

	private static int GetSamplesCount_ReturnValue_Offset;

	private static bool GetSample_IsValid;

	private static IntPtr GetSample_FunctionAddress;

	private static int GetSample_ParamsSize;

	private static bool GetSample_index_IsValid;

	private static FFieldAddress GetSample_index_PropertyAddress;

	private static int GetSample_index_Offset;

	private static bool GetSample_ReturnValue_IsValid;

	private static FFieldAddress GetSample_ReturnValue_PropertyAddress;

	private static int GetSample_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptProfile:Stop")]
	public unsafe static UJavascriptProfile Stop(FJavascriptCpuProfiler Profiler, string Title)
	{
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:Stop");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Stop_Profiler_PropertyAddress.Address, intPtr);
		FJavascriptCpuProfiler.ToNative(IntPtr.Add(intPtr, Stop_Profiler_Offset), 0, Stop_Profiler_PropertyAddress.Address, Profiler);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Stop_Title_Offset), 0, Stop_Title_PropertyAddress.Address, Title);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Stop_FunctionAddress, intPtr, Stop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Stop_Title_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UJavascriptProfile>.FromNative(IntPtr.Add(intPtr, Stop_ReturnValue_Offset), 0, Stop_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProfile:Start")]
	public unsafe static FJavascriptCpuProfiler Start(string Title, bool bRecordSamples)
	{
		if (!Start_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:Start");
			return default(FJavascriptCpuProfiler);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Start_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Start_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Start_Title_Offset), 0, Start_Title_PropertyAddress.Address, Title);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Start_bRecordSamples_Offset), 0, Start_bRecordSamples_PropertyAddress.Address, bRecordSamples);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Start_FunctionAddress, intPtr, Start_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Start_Title_PropertyAddress.Address, intPtr);
		return FJavascriptCpuProfiler.FromNative(IntPtr.Add(intPtr, Start_ReturnValue_Offset), 0, Start_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptProfile:SetSamplingInterval")]
	public unsafe static void SetSamplingInterval(FJavascriptCpuProfiler Profiler, int us)
	{
		if (!SetSamplingInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:SetSamplingInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSamplingInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSamplingInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSamplingInterval_Profiler_PropertyAddress.Address, intPtr);
		FJavascriptCpuProfiler.ToNative(IntPtr.Add(intPtr, SetSamplingInterval_Profiler_Offset), 0, SetSamplingInterval_Profiler_PropertyAddress.Address, Profiler);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSamplingInterval_us_Offset), 0, SetSamplingInterval_us_PropertyAddress.Address, us);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSamplingInterval_FunctionAddress, intPtr, SetSamplingInterval_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptProfile:SetIdle")]
	public unsafe static void SetIdle(FJavascriptCpuProfiler Profiler, bool is_idle)
	{
		if (!SetIdle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:SetIdle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIdle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIdle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetIdle_Profiler_PropertyAddress.Address, intPtr);
		FJavascriptCpuProfiler.ToNative(IntPtr.Add(intPtr, SetIdle_Profiler_Offset), 0, SetIdle_Profiler_PropertyAddress.Address, Profiler);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIdle_is_idle_Offset), 0, SetIdle_is_idle_PropertyAddress.Address, is_idle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetIdle_FunctionAddress, intPtr, SetIdle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProfile:GetTopDownRoot")]
	public unsafe FJavascriptProfileNode GetTopDownRoot()
	{
		CheckDestroyed();
		if (!GetTopDownRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:GetTopDownRoot");
			return default(FJavascriptProfileNode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopDownRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopDownRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopDownRoot_FunctionAddress, intPtr, GetTopDownRoot_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptProfileNode>.FromNative(IntPtr.Add(intPtr, GetTopDownRoot_ReturnValue_Offset), 0, GetTopDownRoot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProfile:GetSampleTimestamp")]
	public unsafe float GetSampleTimestamp(int index)
	{
		CheckDestroyed();
		if (!GetSampleTimestamp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:GetSampleTimestamp");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSampleTimestamp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSampleTimestamp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSampleTimestamp_index_Offset), 0, GetSampleTimestamp_index_PropertyAddress.Address, index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSampleTimestamp_FunctionAddress, intPtr, GetSampleTimestamp_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSampleTimestamp_ReturnValue_Offset), 0, GetSampleTimestamp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProfile:GetSamplesCount")]
	public unsafe int GetSamplesCount()
	{
		CheckDestroyed();
		if (!GetSamplesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:GetSamplesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSamplesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSamplesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSamplesCount_FunctionAddress, intPtr, GetSamplesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSamplesCount_ReturnValue_Offset), 0, GetSamplesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProfile:GetSample")]
	public unsafe FJavascriptProfileNode GetSample(int index)
	{
		CheckDestroyed();
		if (!GetSample_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProfile:GetSample");
			return default(FJavascriptProfileNode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSample_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSample_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSample_index_Offset), 0, GetSample_index_PropertyAddress.Address, index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSample_FunctionAddress, intPtr, GetSample_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptProfileNode>.FromNative(IntPtr.Add(intPtr, GetSample_ReturnValue_Offset), 0, GetSample_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptProfile()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptProfile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptProfile));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/V8.JavascriptProfile");
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Stop_Profiler_PropertyAddress, Stop_FunctionAddress, "Profiler");
		Stop_Profiler_Offset = NativeReflectionCached.GetPropertyOffset(Stop_FunctionAddress, "Profiler");
		Stop_Profiler_IsValid = NativeReflectionCached.ValidatePropertyClass(Stop_FunctionAddress, "Profiler", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Stop_Title_PropertyAddress, Stop_FunctionAddress, "Title");
		Stop_Title_Offset = NativeReflectionCached.GetPropertyOffset(Stop_FunctionAddress, "Title");
		Stop_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(Stop_FunctionAddress, "Title", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Stop_ReturnValue_PropertyAddress, Stop_FunctionAddress, "ReturnValue");
		Stop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Stop_FunctionAddress, "ReturnValue");
		Stop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Stop_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero && Stop_Profiler_IsValid && Stop_Title_IsValid && Stop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:Stop", Stop_IsValid);
		Start_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Start");
		Start_ParamsSize = NativeReflection.GetFunctionParamsSize(Start_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Start_Title_PropertyAddress, Start_FunctionAddress, "Title");
		Start_Title_Offset = NativeReflectionCached.GetPropertyOffset(Start_FunctionAddress, "Title");
		Start_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(Start_FunctionAddress, "Title", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Start_bRecordSamples_PropertyAddress, Start_FunctionAddress, "bRecordSamples");
		Start_bRecordSamples_Offset = NativeReflectionCached.GetPropertyOffset(Start_FunctionAddress, "bRecordSamples");
		Start_bRecordSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(Start_FunctionAddress, "bRecordSamples", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Start_ReturnValue_PropertyAddress, Start_FunctionAddress, "ReturnValue");
		Start_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Start_FunctionAddress, "ReturnValue");
		Start_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Start_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Start_IsValid = Start_FunctionAddress != IntPtr.Zero && Start_Title_IsValid && Start_bRecordSamples_IsValid && Start_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:Start", Start_IsValid);
		SetSamplingInterval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSamplingInterval");
		SetSamplingInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSamplingInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSamplingInterval_Profiler_PropertyAddress, SetSamplingInterval_FunctionAddress, "Profiler");
		SetSamplingInterval_Profiler_Offset = NativeReflectionCached.GetPropertyOffset(SetSamplingInterval_FunctionAddress, "Profiler");
		SetSamplingInterval_Profiler_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSamplingInterval_FunctionAddress, "Profiler", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSamplingInterval_us_PropertyAddress, SetSamplingInterval_FunctionAddress, "us");
		SetSamplingInterval_us_Offset = NativeReflectionCached.GetPropertyOffset(SetSamplingInterval_FunctionAddress, "us");
		SetSamplingInterval_us_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSamplingInterval_FunctionAddress, "us", Classes.FIntProperty);
		SetSamplingInterval_IsValid = SetSamplingInterval_FunctionAddress != IntPtr.Zero && SetSamplingInterval_Profiler_IsValid && SetSamplingInterval_us_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:SetSamplingInterval", SetSamplingInterval_IsValid);
		SetIdle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIdle");
		SetIdle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIdle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIdle_Profiler_PropertyAddress, SetIdle_FunctionAddress, "Profiler");
		SetIdle_Profiler_Offset = NativeReflectionCached.GetPropertyOffset(SetIdle_FunctionAddress, "Profiler");
		SetIdle_Profiler_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIdle_FunctionAddress, "Profiler", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIdle_is_idle_PropertyAddress, SetIdle_FunctionAddress, "is_idle");
		SetIdle_is_idle_Offset = NativeReflectionCached.GetPropertyOffset(SetIdle_FunctionAddress, "is_idle");
		SetIdle_is_idle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIdle_FunctionAddress, "is_idle", Classes.FBoolProperty);
		SetIdle_IsValid = SetIdle_FunctionAddress != IntPtr.Zero && SetIdle_Profiler_IsValid && SetIdle_is_idle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:SetIdle", SetIdle_IsValid);
		GetTopDownRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTopDownRoot");
		GetTopDownRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopDownRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopDownRoot_ReturnValue_PropertyAddress, GetTopDownRoot_FunctionAddress, "ReturnValue");
		GetTopDownRoot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopDownRoot_FunctionAddress, "ReturnValue");
		GetTopDownRoot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopDownRoot_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTopDownRoot_IsValid = GetTopDownRoot_FunctionAddress != IntPtr.Zero && GetTopDownRoot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:GetTopDownRoot", GetTopDownRoot_IsValid);
		GetSampleTimestamp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSampleTimestamp");
		GetSampleTimestamp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSampleTimestamp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSampleTimestamp_index_PropertyAddress, GetSampleTimestamp_FunctionAddress, "index");
		GetSampleTimestamp_index_Offset = NativeReflectionCached.GetPropertyOffset(GetSampleTimestamp_FunctionAddress, "index");
		GetSampleTimestamp_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSampleTimestamp_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSampleTimestamp_ReturnValue_PropertyAddress, GetSampleTimestamp_FunctionAddress, "ReturnValue");
		GetSampleTimestamp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSampleTimestamp_FunctionAddress, "ReturnValue");
		GetSampleTimestamp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSampleTimestamp_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSampleTimestamp_IsValid = GetSampleTimestamp_FunctionAddress != IntPtr.Zero && GetSampleTimestamp_index_IsValid && GetSampleTimestamp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:GetSampleTimestamp", GetSampleTimestamp_IsValid);
		GetSamplesCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSamplesCount");
		GetSamplesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSamplesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSamplesCount_ReturnValue_PropertyAddress, GetSamplesCount_FunctionAddress, "ReturnValue");
		GetSamplesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSamplesCount_FunctionAddress, "ReturnValue");
		GetSamplesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSamplesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSamplesCount_IsValid = GetSamplesCount_FunctionAddress != IntPtr.Zero && GetSamplesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:GetSamplesCount", GetSamplesCount_IsValid);
		GetSample_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSample");
		GetSample_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSample_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSample_index_PropertyAddress, GetSample_FunctionAddress, "index");
		GetSample_index_Offset = NativeReflectionCached.GetPropertyOffset(GetSample_FunctionAddress, "index");
		GetSample_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSample_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSample_ReturnValue_PropertyAddress, GetSample_FunctionAddress, "ReturnValue");
		GetSample_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSample_FunctionAddress, "ReturnValue");
		GetSample_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSample_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSample_IsValid = GetSample_FunctionAddress != IntPtr.Zero && GetSample_index_IsValid && GetSample_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProfile:GetSample", GetSample_IsValid);
	}
}
