using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWGamePlayTraceObject", "b1", UnrealModuleType.Game)]
public class UBGWGamePlayTraceObject : UObject
{
	private static bool TraceStart_IsValid;

	private static IntPtr TraceStart_FunctionAddress;

	private static int TraceStart_ParamsSize;

	private static bool TraceStart_TraceTaskName_IsValid;

	private static FFieldAddress TraceStart_TraceTaskName_PropertyAddress;

	private static int TraceStart_TraceTaskName_Offset;

	private static bool TraceEnd_IsValid;

	private static IntPtr TraceEnd_FunctionAddress;

	private static int TraceEnd_ParamsSize;

	private static bool StopFetchTick_IsValid;

	private static IntPtr StopFetchTick_FunctionAddress;

	private static int StopFetchTick_ParamsSize;

	private static bool StartFetchTick_IsValid;

	private static IntPtr StartFetchTick_FunctionAddress;

	private static int StartFetchTick_ParamsSize;

	private static bool RecordFrameRate_Stop_IsValid;

	private static IntPtr RecordFrameRate_Stop_FunctionAddress;

	private static int RecordFrameRate_Stop_ParamsSize;

	private static bool RecordFrameRate_Stop_ReturnValue_IsValid;

	private static FFieldAddress RecordFrameRate_Stop_ReturnValue_PropertyAddress;

	private static int RecordFrameRate_Stop_ReturnValue_Offset;

	private static bool RecordFrameRate_Start_IsValid;

	private static IntPtr RecordFrameRate_Start_FunctionAddress;

	private static int RecordFrameRate_Start_ParamsSize;

	private static bool OnTick_IsValid;

	private static IntPtr OnTick_FunctionAddress;

	private static int OnTick_ParamsSize;

	private static bool OnTick_DeltaTime_IsValid;

	private static FFieldAddress OnTick_DeltaTime_PropertyAddress;

	private static int OnTick_DeltaTime_Offset;

	private static bool OnShutdown_IsValid;

	private static IntPtr OnShutdown_FunctionAddress;

	private static int OnShutdown_ParamsSize;

	private static bool OnInit_IsValid;

	private static IntPtr OnInit_FunctionAddress;

	private static int OnInit_ParamsSize;

	private static bool GetEnableTraceing_IsValid;

	private static IntPtr GetEnableTraceing_FunctionAddress;

	private static int GetEnableTraceing_ParamsSize;

	private static bool GetEnableTraceing_ReturnValue_IsValid;

	private static FFieldAddress GetEnableTraceing_ReturnValue_PropertyAddress;

	private static int GetEnableTraceing_ReturnValue_Offset;

	private static bool CanShutdown_IsValid;

	private static IntPtr CanShutdown_FunctionAddress;

	private static int CanShutdown_ParamsSize;

	private static bool CanShutdown_ReturnValue_IsValid;

	private static FFieldAddress CanShutdown_ReturnValue_PropertyAddress;

	private static int CanShutdown_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:TraceStart")]
	public unsafe void TraceStart(string TraceTaskName)
	{
		CheckDestroyed();
		if (!TraceStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:TraceStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TraceStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TraceStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TraceStart_TraceTaskName_Offset), 0, TraceStart_TraceTaskName_PropertyAddress.Address, TraceTaskName);
		NativeReflection.InvokeFunctionOptimized(base.Address, TraceStart_FunctionAddress, intPtr, TraceStart_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TraceStart_TraceTaskName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:TraceEnd")]
	public unsafe void TraceEnd()
	{
		CheckDestroyed();
		if (!TraceEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:TraceEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TraceEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TraceEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: TraceEnd_FunctionAddress, argsSize: TraceEnd_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:StopFetchTick")]
	public unsafe void StopFetchTick()
	{
		CheckDestroyed();
		if (!StopFetchTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:StopFetchTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopFetchTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopFetchTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopFetchTick_FunctionAddress, argsSize: StopFetchTick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:StartFetchTick")]
	public unsafe void StartFetchTick()
	{
		CheckDestroyed();
		if (!StartFetchTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:StartFetchTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartFetchTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartFetchTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartFetchTick_FunctionAddress, argsSize: StartFetchTick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Stop")]
	public unsafe string RecordFrameRate_Stop()
	{
		CheckDestroyed();
		if (!RecordFrameRate_Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Stop");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordFrameRate_Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordFrameRate_Stop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordFrameRate_Stop_FunctionAddress, intPtr, RecordFrameRate_Stop_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RecordFrameRate_Stop_ReturnValue_Offset), 0, RecordFrameRate_Stop_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RecordFrameRate_Stop_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Start")]
	public unsafe void RecordFrameRate_Start()
	{
		CheckDestroyed();
		if (!RecordFrameRate_Start_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Start");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordFrameRate_Start_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordFrameRate_Start_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecordFrameRate_Start_FunctionAddress, argsSize: RecordFrameRate_Start_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:OnTick")]
	public unsafe void OnTick(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:OnTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTick_DeltaTime_Offset), 0, OnTick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTick_FunctionAddress, intPtr, OnTick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:OnShutdown")]
	public unsafe void OnShutdown()
	{
		CheckDestroyed();
		if (!OnShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:OnShutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnShutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnShutdown_FunctionAddress, argsSize: OnShutdown_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:OnInit")]
	public unsafe void OnInit()
	{
		CheckDestroyed();
		if (!OnInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:OnInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnInit_FunctionAddress, argsSize: OnInit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:GetEnableTraceing")]
	public unsafe bool GetEnableTraceing()
	{
		CheckDestroyed();
		if (!GetEnableTraceing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:GetEnableTraceing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnableTraceing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnableTraceing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnableTraceing_FunctionAddress, intPtr, GetEnableTraceing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEnableTraceing_ReturnValue_Offset), 0, GetEnableTraceing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGamePlayTraceObject:CanShutdown")]
	public unsafe bool CanShutdown()
	{
		CheckDestroyed();
		if (!CanShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGamePlayTraceObject:CanShutdown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanShutdown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanShutdown_FunctionAddress, intPtr, CanShutdown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanShutdown_ReturnValue_Offset), 0, CanShutdown_ReturnValue_PropertyAddress.Address);
	}

	static UBGWGamePlayTraceObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWGamePlayTraceObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWGamePlayTraceObject));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWGamePlayTraceObject");
		TraceStart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TraceStart");
		TraceStart_ParamsSize = NativeReflection.GetFunctionParamsSize(TraceStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TraceStart_TraceTaskName_PropertyAddress, TraceStart_FunctionAddress, "TraceTaskName");
		TraceStart_TraceTaskName_Offset = NativeReflectionCached.GetPropertyOffset(TraceStart_FunctionAddress, "TraceTaskName");
		TraceStart_TraceTaskName_IsValid = NativeReflectionCached.ValidatePropertyClass(TraceStart_FunctionAddress, "TraceTaskName", Classes.FStrProperty);
		TraceStart_IsValid = TraceStart_FunctionAddress != IntPtr.Zero && TraceStart_TraceTaskName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:TraceStart", TraceStart_IsValid);
		TraceEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TraceEnd");
		TraceEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(TraceEnd_FunctionAddress);
		TraceEnd_IsValid = TraceEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:TraceEnd", TraceEnd_IsValid);
		StopFetchTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopFetchTick");
		StopFetchTick_ParamsSize = NativeReflection.GetFunctionParamsSize(StopFetchTick_FunctionAddress);
		StopFetchTick_IsValid = StopFetchTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:StopFetchTick", StopFetchTick_IsValid);
		StartFetchTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartFetchTick");
		StartFetchTick_ParamsSize = NativeReflection.GetFunctionParamsSize(StartFetchTick_FunctionAddress);
		StartFetchTick_IsValid = StartFetchTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:StartFetchTick", StartFetchTick_IsValid);
		RecordFrameRate_Stop_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecordFrameRate_Stop");
		RecordFrameRate_Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordFrameRate_Stop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordFrameRate_Stop_ReturnValue_PropertyAddress, RecordFrameRate_Stop_FunctionAddress, "ReturnValue");
		RecordFrameRate_Stop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RecordFrameRate_Stop_FunctionAddress, "ReturnValue");
		RecordFrameRate_Stop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordFrameRate_Stop_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RecordFrameRate_Stop_IsValid = RecordFrameRate_Stop_FunctionAddress != IntPtr.Zero && RecordFrameRate_Stop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Stop", RecordFrameRate_Stop_IsValid);
		RecordFrameRate_Start_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecordFrameRate_Start");
		RecordFrameRate_Start_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordFrameRate_Start_FunctionAddress);
		RecordFrameRate_Start_IsValid = RecordFrameRate_Start_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:RecordFrameRate_Start", RecordFrameRate_Start_IsValid);
		OnTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnTick");
		OnTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTick_DeltaTime_PropertyAddress, OnTick_FunctionAddress, "DeltaTime");
		OnTick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(OnTick_FunctionAddress, "DeltaTime");
		OnTick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTick_IsValid = OnTick_FunctionAddress != IntPtr.Zero && OnTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:OnTick", OnTick_IsValid);
		OnShutdown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnShutdown");
		OnShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnShutdown_FunctionAddress);
		OnShutdown_IsValid = OnShutdown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:OnShutdown", OnShutdown_IsValid);
		OnInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInit");
		OnInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInit_FunctionAddress);
		OnInit_IsValid = OnInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:OnInit", OnInit_IsValid);
		GetEnableTraceing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEnableTraceing");
		GetEnableTraceing_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnableTraceing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnableTraceing_ReturnValue_PropertyAddress, GetEnableTraceing_FunctionAddress, "ReturnValue");
		GetEnableTraceing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnableTraceing_FunctionAddress, "ReturnValue");
		GetEnableTraceing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnableTraceing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEnableTraceing_IsValid = GetEnableTraceing_FunctionAddress != IntPtr.Zero && GetEnableTraceing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:GetEnableTraceing", GetEnableTraceing_IsValid);
		CanShutdown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanShutdown");
		CanShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(CanShutdown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanShutdown_ReturnValue_PropertyAddress, CanShutdown_FunctionAddress, "ReturnValue");
		CanShutdown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanShutdown_FunctionAddress, "ReturnValue");
		CanShutdown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanShutdown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanShutdown_IsValid = CanShutdown_FunctionAddress != IntPtr.Zero && CanShutdown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGamePlayTraceObject:CanShutdown", CanShutdown_IsValid);
	}
}
