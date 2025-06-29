using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptProcess", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptProcess : UObject
{
	private static IntPtr classAddress;

	private static bool WriteToPipe_IsValid;

	private static IntPtr WriteToPipe_FunctionAddress;

	private static int WriteToPipe_ParamsSize;

	private static bool WriteToPipe_Message_IsValid;

	private static FFieldAddress WriteToPipe_Message_PropertyAddress;

	private static int WriteToPipe_Message_Offset;

	private static bool WriteToPipe_OutWritten_IsValid;

	private static FFieldAddress WriteToPipe_OutWritten_PropertyAddress;

	private static int WriteToPipe_OutWritten_Offset;

	private static bool WriteToPipe_ReturnValue_IsValid;

	private static FFieldAddress WriteToPipe_ReturnValue_PropertyAddress;

	private static int WriteToPipe_ReturnValue_Offset;

	private static bool Wait_IsValid;

	private static IntPtr Wait_FunctionAddress;

	private static int Wait_ParamsSize;

	private static bool Terminate_IsValid;

	private static IntPtr Terminate_FunctionAddress;

	private static int Terminate_ParamsSize;

	private static bool Terminate_KillTree_IsValid;

	private static FFieldAddress Terminate_KillTree_PropertyAddress;

	private static int Terminate_KillTree_Offset;

	private static bool Sleep_IsValid;

	private static IntPtr Sleep_FunctionAddress;

	private static int Sleep_ParamsSize;

	private static bool Sleep_Seconds_IsValid;

	private static FFieldAddress Sleep_Seconds_PropertyAddress;

	private static int Sleep_Seconds_Offset;

	private static bool SimulateKeypress_IsValid;

	private static IntPtr SimulateKeypress_FunctionAddress;

	private static int SimulateKeypress_ParamsSize;

	private static bool SimulateKeypress_KeyEvent_IsValid;

	private static FFieldAddress SimulateKeypress_KeyEvent_PropertyAddress;

	private static int SimulateKeypress_KeyEvent_Offset;

	private static bool SetEnvironmentVar_IsValid;

	private static IntPtr SetEnvironmentVar_FunctionAddress;

	private static int SetEnvironmentVar_ParamsSize;

	private static bool SetEnvironmentVar_VarName_IsValid;

	private static FFieldAddress SetEnvironmentVar_VarName_PropertyAddress;

	private static int SetEnvironmentVar_VarName_Offset;

	private static bool SetEnvironmentVar_VarValue_IsValid;

	private static FFieldAddress SetEnvironmentVar_VarValue_PropertyAddress;

	private static int SetEnvironmentVar_VarValue_Offset;

	private static bool ReadFromPipe_IsValid;

	private static IntPtr ReadFromPipe_FunctionAddress;

	private static int ReadFromPipe_ParamsSize;

	private static bool ReadFromPipe_ReturnValue_IsValid;

	private static FFieldAddress ReadFromPipe_ReturnValue_PropertyAddress;

	private static int ReadFromPipe_ReturnValue_Offset;

	private static bool ReadArrayFromPipe_IsValid;

	private static IntPtr ReadArrayFromPipe_FunctionAddress;

	private static int ReadArrayFromPipe_ParamsSize;

	private static bool ReadArrayFromPipe_Array_IsValid;

	private static FFieldAddress ReadArrayFromPipe_Array_PropertyAddress;

	private static int ReadArrayFromPipe_Array_Offset;

	private static bool ReadArrayFromPipe_ReturnValue_IsValid;

	private static FFieldAddress ReadArrayFromPipe_ReturnValue_PropertyAddress;

	private static int ReadArrayFromPipe_ReturnValue_Offset;

	private static bool Open_PID_IsValid;

	private static IntPtr Open_PID_FunctionAddress;

	private static int Open_PID_ParamsSize;

	private static bool Open_PID_ProcessId_IsValid;

	private static FFieldAddress Open_PID_ProcessId_PropertyAddress;

	private static int Open_PID_ProcessId_Offset;

	private static bool Open_PID_ReturnValue_IsValid;

	private static FFieldAddress Open_PID_ReturnValue_PropertyAddress;

	private static int Open_PID_ReturnValue_Offset;

	private static bool Open_IsValid;

	private static IntPtr Open_FunctionAddress;

	private static int Open_ParamsSize;

	private static bool Open_ProcName_IsValid;

	private static FFieldAddress Open_ProcName_PropertyAddress;

	private static int Open_ProcName_Offset;

	private static bool Open_ReturnValue_IsValid;

	private static FFieldAddress Open_ReturnValue_PropertyAddress;

	private static int Open_ReturnValue_Offset;

	private static bool LaunchURL_IsValid;

	private static IntPtr LaunchURL_FunctionAddress;

	private static int LaunchURL_ParamsSize;

	private static bool LaunchURL_URL_IsValid;

	private static FFieldAddress LaunchURL_URL_PropertyAddress;

	private static int LaunchURL_URL_Offset;

	private static bool LaunchURL_Parms_IsValid;

	private static FFieldAddress LaunchURL_Parms_PropertyAddress;

	private static int LaunchURL_Parms_Offset;

	private static bool LaunchURL_Error_IsValid;

	private static FFieldAddress LaunchURL_Error_PropertyAddress;

	private static int LaunchURL_Error_Offset;

	private static bool IsRunning_IsValid;

	private static IntPtr IsRunning_FunctionAddress;

	private static int IsRunning_ParamsSize;

	private static bool IsRunning_ReturnValue_IsValid;

	private static FFieldAddress IsRunning_ReturnValue_PropertyAddress;

	private static int IsRunning_ReturnValue_Offset;

	private static bool IsApplicationRunning_PID_IsValid;

	private static IntPtr IsApplicationRunning_PID_FunctionAddress;

	private static int IsApplicationRunning_PID_ParamsSize;

	private static bool IsApplicationRunning_PID_ProcessId_IsValid;

	private static FFieldAddress IsApplicationRunning_PID_ProcessId_PropertyAddress;

	private static int IsApplicationRunning_PID_ProcessId_Offset;

	private static bool IsApplicationRunning_PID_ReturnValue_IsValid;

	private static FFieldAddress IsApplicationRunning_PID_ReturnValue_PropertyAddress;

	private static int IsApplicationRunning_PID_ReturnValue_Offset;

	private static bool IsApplicationRunning_IsValid;

	private static IntPtr IsApplicationRunning_FunctionAddress;

	private static int IsApplicationRunning_ParamsSize;

	private static bool IsApplicationRunning_ProcName_IsValid;

	private static FFieldAddress IsApplicationRunning_ProcName_PropertyAddress;

	private static int IsApplicationRunning_ProcName_Offset;

	private static bool IsApplicationRunning_ReturnValue_IsValid;

	private static FFieldAddress IsApplicationRunning_ReturnValue_PropertyAddress;

	private static int IsApplicationRunning_ReturnValue_Offset;

	private static bool GetString_IsValid;

	private static IntPtr GetString_FunctionAddress;

	private static int GetString_ParamsSize;

	private static bool GetString_Key_IsValid;

	private static FFieldAddress GetString_Key_PropertyAddress;

	private static int GetString_Key_Offset;

	private static bool GetString_bFlag_IsValid;

	private static FFieldAddress GetString_bFlag_PropertyAddress;

	private static int GetString_bFlag_Offset;

	private static bool GetString_ReturnValue_IsValid;

	private static FFieldAddress GetString_ReturnValue_PropertyAddress;

	private static int GetString_ReturnValue_Offset;

	private static bool GetReturnCode_IsValid;

	private static IntPtr GetReturnCode_FunctionAddress;

	private static int GetReturnCode_ParamsSize;

	private static bool GetReturnCode_ReturnCode_IsValid;

	private static FFieldAddress GetReturnCode_ReturnCode_PropertyAddress;

	private static int GetReturnCode_ReturnCode_Offset;

	private static bool GetReturnCode_ReturnValue_IsValid;

	private static FFieldAddress GetReturnCode_ReturnValue_PropertyAddress;

	private static int GetReturnCode_ReturnValue_Offset;

	private static bool GetEnvironmentVar_IsValid;

	private static IntPtr GetEnvironmentVar_FunctionAddress;

	private static int GetEnvironmentVar_ParamsSize;

	private static bool GetEnvironmentVar_VarName_IsValid;

	private static FFieldAddress GetEnvironmentVar_VarName_PropertyAddress;

	private static int GetEnvironmentVar_VarName_Offset;

	private static bool GetEnvironmentVar_ReturnValue_IsValid;

	private static FFieldAddress GetEnvironmentVar_ReturnValue_PropertyAddress;

	private static int GetEnvironmentVar_ReturnValue_Offset;

	private static bool GetCurrentProcessId_IsValid;

	private static IntPtr GetCurrentProcessId_FunctionAddress;

	private static int GetCurrentProcessId_ParamsSize;

	private static bool GetCurrentProcessId_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentProcessId_ReturnValue_PropertyAddress;

	private static int GetCurrentProcessId_ReturnValue_Offset;

	private static bool GetApplicationName_IsValid;

	private static IntPtr GetApplicationName_FunctionAddress;

	private static int GetApplicationName_ParamsSize;

	private static bool GetApplicationName_ProcessId_IsValid;

	private static FFieldAddress GetApplicationName_ProcessId_PropertyAddress;

	private static int GetApplicationName_ProcessId_Offset;

	private static bool GetApplicationName_ReturnValue_IsValid;

	private static FFieldAddress GetApplicationName_ReturnValue_PropertyAddress;

	private static int GetApplicationName_ReturnValue_Offset;

	private static bool Create_IsValid;

	private static IntPtr Create_FunctionAddress;

	private static int Create_ParamsSize;

	private static bool Create_URL_IsValid;

	private static FFieldAddress Create_URL_PropertyAddress;

	private static int Create_URL_Offset;

	private static bool Create_Parms_IsValid;

	private static FFieldAddress Create_Parms_PropertyAddress;

	private static int Create_Parms_Offset;

	private static bool Create_bLaunchDetached_IsValid;

	private static FFieldAddress Create_bLaunchDetached_PropertyAddress;

	private static int Create_bLaunchDetached_Offset;

	private static bool Create_bLaunchHidden_IsValid;

	private static FFieldAddress Create_bLaunchHidden_PropertyAddress;

	private static int Create_bLaunchHidden_Offset;

	private static bool Create_bLaunchReallyHidden_IsValid;

	private static FFieldAddress Create_bLaunchReallyHidden_PropertyAddress;

	private static int Create_bLaunchReallyHidden_Offset;

	private static bool Create_PriorityModifier_IsValid;

	private static FFieldAddress Create_PriorityModifier_PropertyAddress;

	private static int Create_PriorityModifier_Offset;

	private static bool Create_OptionalWorkingDirectory_IsValid;

	private static FFieldAddress Create_OptionalWorkingDirectory_PropertyAddress;

	private static int Create_OptionalWorkingDirectory_Offset;

	private static bool Create_bUsePipe_IsValid;

	private static FFieldAddress Create_bUsePipe_PropertyAddress;

	private static int Create_bUsePipe_Offset;

	private static bool Create_ReturnValue_IsValid;

	private static FFieldAddress Create_ReturnValue_PropertyAddress;

	private static int Create_ReturnValue_Offset;

	private static bool Close_IsValid;

	private static IntPtr Close_FunctionAddress;

	private static int Close_ParamsSize;

	private static bool CanLaunchURL_IsValid;

	private static IntPtr CanLaunchURL_FunctionAddress;

	private static int CanLaunchURL_ParamsSize;

	private static bool CanLaunchURL_URL_IsValid;

	private static FFieldAddress CanLaunchURL_URL_PropertyAddress;

	private static int CanLaunchURL_URL_Offset;

	private static bool CanLaunchURL_ReturnValue_IsValid;

	private static FFieldAddress CanLaunchURL_ReturnValue_PropertyAddress;

	private static int CanLaunchURL_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/V8.JavascriptProcess:WriteToPipe")]
	public unsafe bool WriteToPipe(string Message, out string OutWritten)
	{
		CheckDestroyed();
		if (!WriteToPipe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:WriteToPipe");
			OutWritten = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteToPipe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteToPipe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteToPipe_Message_Offset), 0, WriteToPipe_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteToPipe_FunctionAddress, intPtr, WriteToPipe_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteToPipe_Message_PropertyAddress.Address, intPtr);
		OutWritten = FStringMarshaler.FromNative(IntPtr.Add(intPtr, WriteToPipe_OutWritten_Offset), 0, WriteToPipe_OutWritten_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(WriteToPipe_OutWritten_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteToPipe_ReturnValue_Offset), 0, WriteToPipe_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Wait")]
	public unsafe void Wait()
	{
		CheckDestroyed();
		if (!Wait_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Wait");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Wait_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Wait_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Wait_FunctionAddress, argsSize: Wait_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Terminate")]
	public unsafe void Terminate(bool KillTree = false)
	{
		CheckDestroyed();
		if (!Terminate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Terminate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Terminate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Terminate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Terminate_KillTree_Offset), 0, Terminate_KillTree_PropertyAddress.Address, KillTree);
		NativeReflection.InvokeFunctionOptimized(base.Address, Terminate_FunctionAddress, intPtr, Terminate_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Sleep")]
	public unsafe static void Sleep(float Seconds)
	{
		if (!Sleep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Sleep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sleep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sleep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Sleep_Seconds_Offset), 0, Sleep_Seconds_PropertyAddress.Address, Seconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Sleep_FunctionAddress, intPtr, Sleep_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:SimulateKeypress")]
	public unsafe static void SimulateKeypress(int KeyEvent)
	{
		if (!SimulateKeypress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:SimulateKeypress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SimulateKeypress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SimulateKeypress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SimulateKeypress_KeyEvent_Offset), 0, SimulateKeypress_KeyEvent_PropertyAddress.Address, KeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SimulateKeypress_FunctionAddress, intPtr, SimulateKeypress_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:SetEnvironmentVar")]
	public unsafe static void SetEnvironmentVar(string VarName, string VarValue)
	{
		if (!SetEnvironmentVar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:SetEnvironmentVar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnvironmentVar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnvironmentVar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEnvironmentVar_VarName_Offset), 0, SetEnvironmentVar_VarName_PropertyAddress.Address, VarName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEnvironmentVar_VarValue_Offset), 0, SetEnvironmentVar_VarValue_PropertyAddress.Address, VarValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEnvironmentVar_FunctionAddress, intPtr, SetEnvironmentVar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEnvironmentVar_VarName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetEnvironmentVar_VarValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProcess:ReadFromPipe")]
	public unsafe string ReadFromPipe()
	{
		CheckDestroyed();
		if (!ReadFromPipe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:ReadFromPipe");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadFromPipe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadFromPipe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadFromPipe_FunctionAddress, intPtr, ReadFromPipe_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ReadFromPipe_ReturnValue_Offset), 0, ReadFromPipe_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReadFromPipe_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/V8.JavascriptProcess:ReadArrayFromPipe")]
	public unsafe bool ReadArrayFromPipe(out List<byte> Array)
	{
		CheckDestroyed();
		if (!ReadArrayFromPipe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:ReadArrayFromPipe");
			Array = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadArrayFromPipe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadArrayFromPipe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadArrayFromPipe_FunctionAddress, intPtr, ReadArrayFromPipe_ParamsSize);
		Array = new TArrayCopyMarshaler<byte>(1, ReadArrayFromPipe_Array_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadArrayFromPipe_Array_Offset));
		NativeReflection.DestroyValue_InContainer(ReadArrayFromPipe_Array_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadArrayFromPipe_ReturnValue_Offset), 0, ReadArrayFromPipe_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Open_PID")]
	public unsafe static UJavascriptProcess Open_PID(int ProcessId)
	{
		if (!Open_PID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Open_PID");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Open_PID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Open_PID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Open_PID_ProcessId_Offset), 0, Open_PID_ProcessId_PropertyAddress.Address, ProcessId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Open_PID_FunctionAddress, intPtr, Open_PID_ParamsSize);
		return UObjectMarshaler<UJavascriptProcess>.FromNative(IntPtr.Add(intPtr, Open_PID_ReturnValue_Offset), 0, Open_PID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Open")]
	public unsafe static UJavascriptProcess Open(string ProcName)
	{
		if (!Open_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Open");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Open_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Open_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Open_ProcName_Offset), 0, Open_ProcName_PropertyAddress.Address, ProcName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Open_FunctionAddress, intPtr, Open_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Open_ProcName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UJavascriptProcess>.FromNative(IntPtr.Add(intPtr, Open_ReturnValue_Offset), 0, Open_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptProcess:LaunchURL")]
	public unsafe static void LaunchURL(string URL, string Parms, out string Error)
	{
		if (!LaunchURL_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:LaunchURL");
			Error = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LaunchURL_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LaunchURL_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LaunchURL_URL_Offset), 0, LaunchURL_URL_PropertyAddress.Address, URL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LaunchURL_Parms_Offset), 0, LaunchURL_Parms_PropertyAddress.Address, Parms);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LaunchURL_FunctionAddress, intPtr, LaunchURL_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LaunchURL_URL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(LaunchURL_Parms_PropertyAddress.Address, intPtr);
		Error = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LaunchURL_Error_Offset), 0, LaunchURL_Error_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LaunchURL_Error_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProcess:IsRunning")]
	public unsafe bool IsRunning()
	{
		CheckDestroyed();
		if (!IsRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:IsRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRunning_FunctionAddress, intPtr, IsRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRunning_ReturnValue_Offset), 0, IsRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:IsApplicationRunning_PID")]
	public unsafe static bool IsApplicationRunning_PID(int ProcessId)
	{
		if (!IsApplicationRunning_PID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:IsApplicationRunning_PID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsApplicationRunning_PID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsApplicationRunning_PID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsApplicationRunning_PID_ProcessId_Offset), 0, IsApplicationRunning_PID_ProcessId_PropertyAddress.Address, ProcessId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsApplicationRunning_PID_FunctionAddress, intPtr, IsApplicationRunning_PID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsApplicationRunning_PID_ReturnValue_Offset), 0, IsApplicationRunning_PID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:IsApplicationRunning")]
	public unsafe static bool IsApplicationRunning(string ProcName)
	{
		if (!IsApplicationRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:IsApplicationRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsApplicationRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsApplicationRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsApplicationRunning_ProcName_Offset), 0, IsApplicationRunning_ProcName_PropertyAddress.Address, ProcName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsApplicationRunning_FunctionAddress, intPtr, IsApplicationRunning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsApplicationRunning_ProcName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsApplicationRunning_ReturnValue_Offset), 0, IsApplicationRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:GetString")]
	public unsafe static string GetString(string Key, bool bFlag)
	{
		if (!GetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:GetString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetString_Key_Offset), 0, GetString_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetString_bFlag_Offset), 0, GetString_bFlag_PropertyAddress.Address, bFlag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetString_FunctionAddress, intPtr, GetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetString_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetString_ReturnValue_Offset), 0, GetString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/V8.JavascriptProcess:GetReturnCode")]
	public unsafe bool GetReturnCode(out int ReturnCode)
	{
		CheckDestroyed();
		if (!GetReturnCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:GetReturnCode");
			ReturnCode = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReturnCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReturnCode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReturnCode_FunctionAddress, intPtr, GetReturnCode_ParamsSize);
		ReturnCode = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetReturnCode_ReturnCode_Offset), 0, GetReturnCode_ReturnCode_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetReturnCode_ReturnValue_Offset), 0, GetReturnCode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:GetEnvironmentVar")]
	public unsafe static string GetEnvironmentVar(string VarName)
	{
		if (!GetEnvironmentVar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:GetEnvironmentVar");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnvironmentVar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnvironmentVar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetEnvironmentVar_VarName_Offset), 0, GetEnvironmentVar_VarName_PropertyAddress.Address, VarName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEnvironmentVar_FunctionAddress, intPtr, GetEnvironmentVar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetEnvironmentVar_VarName_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetEnvironmentVar_ReturnValue_Offset), 0, GetEnvironmentVar_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetEnvironmentVar_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:GetCurrentProcessId")]
	public unsafe static int GetCurrentProcessId()
	{
		if (!GetCurrentProcessId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:GetCurrentProcessId");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentProcessId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentProcessId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentProcessId_FunctionAddress, intPtr, GetCurrentProcessId_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentProcessId_ReturnValue_Offset), 0, GetCurrentProcessId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:GetApplicationName")]
	public unsafe static string GetApplicationName(int ProcessId)
	{
		if (!GetApplicationName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:GetApplicationName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetApplicationName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetApplicationName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetApplicationName_ProcessId_Offset), 0, GetApplicationName_ProcessId_PropertyAddress.Address, ProcessId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetApplicationName_FunctionAddress, intPtr, GetApplicationName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetApplicationName_ReturnValue_Offset), 0, GetApplicationName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetApplicationName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Create")]
	public unsafe static UJavascriptProcess Create(string URL, string Parms, bool bLaunchDetached, bool bLaunchHidden, bool bLaunchReallyHidden, int PriorityModifier, string OptionalWorkingDirectory, bool bUsePipe)
	{
		if (!Create_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Create");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Create_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Create_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Create_URL_Offset), 0, Create_URL_PropertyAddress.Address, URL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Create_Parms_Offset), 0, Create_Parms_PropertyAddress.Address, Parms);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bLaunchDetached_Offset), 0, Create_bLaunchDetached_PropertyAddress.Address, bLaunchDetached);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bLaunchHidden_Offset), 0, Create_bLaunchHidden_PropertyAddress.Address, bLaunchHidden);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bLaunchReallyHidden_Offset), 0, Create_bLaunchReallyHidden_PropertyAddress.Address, bLaunchReallyHidden);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Create_PriorityModifier_Offset), 0, Create_PriorityModifier_PropertyAddress.Address, PriorityModifier);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Create_OptionalWorkingDirectory_Offset), 0, Create_OptionalWorkingDirectory_PropertyAddress.Address, OptionalWorkingDirectory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bUsePipe_Offset), 0, Create_bUsePipe_PropertyAddress.Address, bUsePipe);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Create_FunctionAddress, intPtr, Create_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Create_URL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Create_Parms_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Create_OptionalWorkingDirectory_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UJavascriptProcess>.FromNative(IntPtr.Add(intPtr, Create_ReturnValue_Offset), 0, Create_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptProcess:Close")]
	public unsafe void Close()
	{
		CheckDestroyed();
		if (!Close_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:Close");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Close_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Close_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Close_FunctionAddress, argsSize: Close_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/V8.JavascriptProcess:CanLaunchURL")]
	public unsafe static bool CanLaunchURL(string URL)
	{
		if (!CanLaunchURL_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptProcess:CanLaunchURL");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanLaunchURL_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanLaunchURL_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CanLaunchURL_URL_Offset), 0, CanLaunchURL_URL_PropertyAddress.Address, URL);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanLaunchURL_FunctionAddress, intPtr, CanLaunchURL_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanLaunchURL_URL_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanLaunchURL_ReturnValue_Offset), 0, CanLaunchURL_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptProcess()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptProcess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptProcess));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/V8.JavascriptProcess");
		WriteToPipe_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteToPipe");
		WriteToPipe_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteToPipe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteToPipe_Message_PropertyAddress, WriteToPipe_FunctionAddress, "Message");
		WriteToPipe_Message_Offset = NativeReflectionCached.GetPropertyOffset(WriteToPipe_FunctionAddress, "Message");
		WriteToPipe_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToPipe_FunctionAddress, "Message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToPipe_OutWritten_PropertyAddress, WriteToPipe_FunctionAddress, "OutWritten");
		WriteToPipe_OutWritten_Offset = NativeReflectionCached.GetPropertyOffset(WriteToPipe_FunctionAddress, "OutWritten");
		WriteToPipe_OutWritten_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToPipe_FunctionAddress, "OutWritten", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToPipe_ReturnValue_PropertyAddress, WriteToPipe_FunctionAddress, "ReturnValue");
		WriteToPipe_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteToPipe_FunctionAddress, "ReturnValue");
		WriteToPipe_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToPipe_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteToPipe_IsValid = WriteToPipe_FunctionAddress != IntPtr.Zero && WriteToPipe_Message_IsValid && WriteToPipe_OutWritten_IsValid && WriteToPipe_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:WriteToPipe", WriteToPipe_IsValid);
		Wait_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Wait");
		Wait_ParamsSize = NativeReflection.GetFunctionParamsSize(Wait_FunctionAddress);
		Wait_IsValid = Wait_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Wait", Wait_IsValid);
		Terminate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Terminate");
		Terminate_ParamsSize = NativeReflection.GetFunctionParamsSize(Terminate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Terminate_KillTree_PropertyAddress, Terminate_FunctionAddress, "KillTree");
		Terminate_KillTree_Offset = NativeReflectionCached.GetPropertyOffset(Terminate_FunctionAddress, "KillTree");
		Terminate_KillTree_IsValid = NativeReflectionCached.ValidatePropertyClass(Terminate_FunctionAddress, "KillTree", Classes.FBoolProperty);
		Terminate_IsValid = Terminate_FunctionAddress != IntPtr.Zero && Terminate_KillTree_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Terminate", Terminate_IsValid);
		Sleep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Sleep");
		Sleep_ParamsSize = NativeReflection.GetFunctionParamsSize(Sleep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sleep_Seconds_PropertyAddress, Sleep_FunctionAddress, "Seconds");
		Sleep_Seconds_Offset = NativeReflectionCached.GetPropertyOffset(Sleep_FunctionAddress, "Seconds");
		Sleep_Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(Sleep_FunctionAddress, "Seconds", Classes.FFloatProperty);
		Sleep_IsValid = Sleep_FunctionAddress != IntPtr.Zero && Sleep_Seconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Sleep", Sleep_IsValid);
		SimulateKeypress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SimulateKeypress");
		SimulateKeypress_ParamsSize = NativeReflection.GetFunctionParamsSize(SimulateKeypress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SimulateKeypress_KeyEvent_PropertyAddress, SimulateKeypress_FunctionAddress, "KeyEvent");
		SimulateKeypress_KeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(SimulateKeypress_FunctionAddress, "KeyEvent");
		SimulateKeypress_KeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(SimulateKeypress_FunctionAddress, "KeyEvent", Classes.FIntProperty);
		SimulateKeypress_IsValid = SimulateKeypress_FunctionAddress != IntPtr.Zero && SimulateKeypress_KeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:SimulateKeypress", SimulateKeypress_IsValid);
		SetEnvironmentVar_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEnvironmentVar");
		SetEnvironmentVar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnvironmentVar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnvironmentVar_VarName_PropertyAddress, SetEnvironmentVar_FunctionAddress, "VarName");
		SetEnvironmentVar_VarName_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvironmentVar_FunctionAddress, "VarName");
		SetEnvironmentVar_VarName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvironmentVar_FunctionAddress, "VarName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnvironmentVar_VarValue_PropertyAddress, SetEnvironmentVar_FunctionAddress, "VarValue");
		SetEnvironmentVar_VarValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvironmentVar_FunctionAddress, "VarValue");
		SetEnvironmentVar_VarValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvironmentVar_FunctionAddress, "VarValue", Classes.FStrProperty);
		SetEnvironmentVar_IsValid = SetEnvironmentVar_FunctionAddress != IntPtr.Zero && SetEnvironmentVar_VarName_IsValid && SetEnvironmentVar_VarValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:SetEnvironmentVar", SetEnvironmentVar_IsValid);
		ReadFromPipe_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadFromPipe");
		ReadFromPipe_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadFromPipe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadFromPipe_ReturnValue_PropertyAddress, ReadFromPipe_FunctionAddress, "ReturnValue");
		ReadFromPipe_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadFromPipe_FunctionAddress, "ReturnValue");
		ReadFromPipe_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFromPipe_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ReadFromPipe_IsValid = ReadFromPipe_FunctionAddress != IntPtr.Zero && ReadFromPipe_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:ReadFromPipe", ReadFromPipe_IsValid);
		ReadArrayFromPipe_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadArrayFromPipe");
		ReadArrayFromPipe_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadArrayFromPipe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadArrayFromPipe_Array_PropertyAddress, ReadArrayFromPipe_FunctionAddress, "Array");
		ReadArrayFromPipe_Array_Offset = NativeReflectionCached.GetPropertyOffset(ReadArrayFromPipe_FunctionAddress, "Array");
		ReadArrayFromPipe_Array_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadArrayFromPipe_FunctionAddress, "Array", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadArrayFromPipe_ReturnValue_PropertyAddress, ReadArrayFromPipe_FunctionAddress, "ReturnValue");
		ReadArrayFromPipe_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadArrayFromPipe_FunctionAddress, "ReturnValue");
		ReadArrayFromPipe_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadArrayFromPipe_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadArrayFromPipe_IsValid = ReadArrayFromPipe_FunctionAddress != IntPtr.Zero && ReadArrayFromPipe_Array_IsValid && ReadArrayFromPipe_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:ReadArrayFromPipe", ReadArrayFromPipe_IsValid);
		Open_PID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Open_PID");
		Open_PID_ParamsSize = NativeReflection.GetFunctionParamsSize(Open_PID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Open_PID_ProcessId_PropertyAddress, Open_PID_FunctionAddress, "ProcessId");
		Open_PID_ProcessId_Offset = NativeReflectionCached.GetPropertyOffset(Open_PID_FunctionAddress, "ProcessId");
		Open_PID_ProcessId_IsValid = NativeReflectionCached.ValidatePropertyClass(Open_PID_FunctionAddress, "ProcessId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Open_PID_ReturnValue_PropertyAddress, Open_PID_FunctionAddress, "ReturnValue");
		Open_PID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Open_PID_FunctionAddress, "ReturnValue");
		Open_PID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Open_PID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Open_PID_IsValid = Open_PID_FunctionAddress != IntPtr.Zero && Open_PID_ProcessId_IsValid && Open_PID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Open_PID", Open_PID_IsValid);
		Open_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Open");
		Open_ParamsSize = NativeReflection.GetFunctionParamsSize(Open_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Open_ProcName_PropertyAddress, Open_FunctionAddress, "ProcName");
		Open_ProcName_Offset = NativeReflectionCached.GetPropertyOffset(Open_FunctionAddress, "ProcName");
		Open_ProcName_IsValid = NativeReflectionCached.ValidatePropertyClass(Open_FunctionAddress, "ProcName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Open_ReturnValue_PropertyAddress, Open_FunctionAddress, "ReturnValue");
		Open_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Open_FunctionAddress, "ReturnValue");
		Open_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Open_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Open_IsValid = Open_FunctionAddress != IntPtr.Zero && Open_ProcName_IsValid && Open_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Open", Open_IsValid);
		LaunchURL_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LaunchURL");
		LaunchURL_ParamsSize = NativeReflection.GetFunctionParamsSize(LaunchURL_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LaunchURL_URL_PropertyAddress, LaunchURL_FunctionAddress, "URL");
		LaunchURL_URL_Offset = NativeReflectionCached.GetPropertyOffset(LaunchURL_FunctionAddress, "URL");
		LaunchURL_URL_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchURL_FunctionAddress, "URL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LaunchURL_Parms_PropertyAddress, LaunchURL_FunctionAddress, "Parms");
		LaunchURL_Parms_Offset = NativeReflectionCached.GetPropertyOffset(LaunchURL_FunctionAddress, "Parms");
		LaunchURL_Parms_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchURL_FunctionAddress, "Parms", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LaunchURL_Error_PropertyAddress, LaunchURL_FunctionAddress, "Error");
		LaunchURL_Error_Offset = NativeReflectionCached.GetPropertyOffset(LaunchURL_FunctionAddress, "Error");
		LaunchURL_Error_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchURL_FunctionAddress, "Error", Classes.FStrProperty);
		LaunchURL_IsValid = LaunchURL_FunctionAddress != IntPtr.Zero && LaunchURL_URL_IsValid && LaunchURL_Parms_IsValid && LaunchURL_Error_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:LaunchURL", LaunchURL_IsValid);
		IsRunning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRunning");
		IsRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRunning_ReturnValue_PropertyAddress, IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRunning_IsValid = IsRunning_FunctionAddress != IntPtr.Zero && IsRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:IsRunning", IsRunning_IsValid);
		IsApplicationRunning_PID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsApplicationRunning_PID");
		IsApplicationRunning_PID_ParamsSize = NativeReflection.GetFunctionParamsSize(IsApplicationRunning_PID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsApplicationRunning_PID_ProcessId_PropertyAddress, IsApplicationRunning_PID_FunctionAddress, "ProcessId");
		IsApplicationRunning_PID_ProcessId_Offset = NativeReflectionCached.GetPropertyOffset(IsApplicationRunning_PID_FunctionAddress, "ProcessId");
		IsApplicationRunning_PID_ProcessId_IsValid = NativeReflectionCached.ValidatePropertyClass(IsApplicationRunning_PID_FunctionAddress, "ProcessId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsApplicationRunning_PID_ReturnValue_PropertyAddress, IsApplicationRunning_PID_FunctionAddress, "ReturnValue");
		IsApplicationRunning_PID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsApplicationRunning_PID_FunctionAddress, "ReturnValue");
		IsApplicationRunning_PID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsApplicationRunning_PID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsApplicationRunning_PID_IsValid = IsApplicationRunning_PID_FunctionAddress != IntPtr.Zero && IsApplicationRunning_PID_ProcessId_IsValid && IsApplicationRunning_PID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:IsApplicationRunning_PID", IsApplicationRunning_PID_IsValid);
		IsApplicationRunning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsApplicationRunning");
		IsApplicationRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsApplicationRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsApplicationRunning_ProcName_PropertyAddress, IsApplicationRunning_FunctionAddress, "ProcName");
		IsApplicationRunning_ProcName_Offset = NativeReflectionCached.GetPropertyOffset(IsApplicationRunning_FunctionAddress, "ProcName");
		IsApplicationRunning_ProcName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsApplicationRunning_FunctionAddress, "ProcName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsApplicationRunning_ReturnValue_PropertyAddress, IsApplicationRunning_FunctionAddress, "ReturnValue");
		IsApplicationRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsApplicationRunning_FunctionAddress, "ReturnValue");
		IsApplicationRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsApplicationRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsApplicationRunning_IsValid = IsApplicationRunning_FunctionAddress != IntPtr.Zero && IsApplicationRunning_ProcName_IsValid && IsApplicationRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:IsApplicationRunning", IsApplicationRunning_IsValid);
		GetString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetString");
		GetString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetString_Key_PropertyAddress, GetString_FunctionAddress, "Key");
		GetString_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "Key");
		GetString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_bFlag_PropertyAddress, GetString_FunctionAddress, "bFlag");
		GetString_bFlag_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "bFlag");
		GetString_bFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "bFlag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_ReturnValue_PropertyAddress, GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetString_IsValid = GetString_FunctionAddress != IntPtr.Zero && GetString_Key_IsValid && GetString_bFlag_IsValid && GetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:GetString", GetString_IsValid);
		GetReturnCode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReturnCode");
		GetReturnCode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReturnCode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReturnCode_ReturnCode_PropertyAddress, GetReturnCode_FunctionAddress, "ReturnCode");
		GetReturnCode_ReturnCode_Offset = NativeReflectionCached.GetPropertyOffset(GetReturnCode_FunctionAddress, "ReturnCode");
		GetReturnCode_ReturnCode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReturnCode_FunctionAddress, "ReturnCode", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReturnCode_ReturnValue_PropertyAddress, GetReturnCode_FunctionAddress, "ReturnValue");
		GetReturnCode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReturnCode_FunctionAddress, "ReturnValue");
		GetReturnCode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReturnCode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetReturnCode_IsValid = GetReturnCode_FunctionAddress != IntPtr.Zero && GetReturnCode_ReturnCode_IsValid && GetReturnCode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:GetReturnCode", GetReturnCode_IsValid);
		GetEnvironmentVar_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEnvironmentVar");
		GetEnvironmentVar_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnvironmentVar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnvironmentVar_VarName_PropertyAddress, GetEnvironmentVar_FunctionAddress, "VarName");
		GetEnvironmentVar_VarName_Offset = NativeReflectionCached.GetPropertyOffset(GetEnvironmentVar_FunctionAddress, "VarName");
		GetEnvironmentVar_VarName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnvironmentVar_FunctionAddress, "VarName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEnvironmentVar_ReturnValue_PropertyAddress, GetEnvironmentVar_FunctionAddress, "ReturnValue");
		GetEnvironmentVar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnvironmentVar_FunctionAddress, "ReturnValue");
		GetEnvironmentVar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnvironmentVar_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetEnvironmentVar_IsValid = GetEnvironmentVar_FunctionAddress != IntPtr.Zero && GetEnvironmentVar_VarName_IsValid && GetEnvironmentVar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:GetEnvironmentVar", GetEnvironmentVar_IsValid);
		GetCurrentProcessId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentProcessId");
		GetCurrentProcessId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentProcessId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentProcessId_ReturnValue_PropertyAddress, GetCurrentProcessId_FunctionAddress, "ReturnValue");
		GetCurrentProcessId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentProcessId_FunctionAddress, "ReturnValue");
		GetCurrentProcessId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentProcessId_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentProcessId_IsValid = GetCurrentProcessId_FunctionAddress != IntPtr.Zero && GetCurrentProcessId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:GetCurrentProcessId", GetCurrentProcessId_IsValid);
		GetApplicationName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetApplicationName");
		GetApplicationName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetApplicationName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetApplicationName_ProcessId_PropertyAddress, GetApplicationName_FunctionAddress, "ProcessId");
		GetApplicationName_ProcessId_Offset = NativeReflectionCached.GetPropertyOffset(GetApplicationName_FunctionAddress, "ProcessId");
		GetApplicationName_ProcessId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetApplicationName_FunctionAddress, "ProcessId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetApplicationName_ReturnValue_PropertyAddress, GetApplicationName_FunctionAddress, "ReturnValue");
		GetApplicationName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetApplicationName_FunctionAddress, "ReturnValue");
		GetApplicationName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetApplicationName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetApplicationName_IsValid = GetApplicationName_FunctionAddress != IntPtr.Zero && GetApplicationName_ProcessId_IsValid && GetApplicationName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:GetApplicationName", GetApplicationName_IsValid);
		Create_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Create");
		Create_ParamsSize = NativeReflection.GetFunctionParamsSize(Create_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Create_URL_PropertyAddress, Create_FunctionAddress, "URL");
		Create_URL_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "URL");
		Create_URL_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "URL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_Parms_PropertyAddress, Create_FunctionAddress, "Parms");
		Create_Parms_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "Parms");
		Create_Parms_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "Parms", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bLaunchDetached_PropertyAddress, Create_FunctionAddress, "bLaunchDetached");
		Create_bLaunchDetached_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bLaunchDetached");
		Create_bLaunchDetached_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bLaunchDetached", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bLaunchHidden_PropertyAddress, Create_FunctionAddress, "bLaunchHidden");
		Create_bLaunchHidden_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bLaunchHidden");
		Create_bLaunchHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bLaunchHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bLaunchReallyHidden_PropertyAddress, Create_FunctionAddress, "bLaunchReallyHidden");
		Create_bLaunchReallyHidden_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bLaunchReallyHidden");
		Create_bLaunchReallyHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bLaunchReallyHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_PriorityModifier_PropertyAddress, Create_FunctionAddress, "PriorityModifier");
		Create_PriorityModifier_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "PriorityModifier");
		Create_PriorityModifier_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "PriorityModifier", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_OptionalWorkingDirectory_PropertyAddress, Create_FunctionAddress, "OptionalWorkingDirectory");
		Create_OptionalWorkingDirectory_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "OptionalWorkingDirectory");
		Create_OptionalWorkingDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "OptionalWorkingDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bUsePipe_PropertyAddress, Create_FunctionAddress, "bUsePipe");
		Create_bUsePipe_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bUsePipe");
		Create_bUsePipe_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bUsePipe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_ReturnValue_PropertyAddress, Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Create_IsValid = Create_FunctionAddress != IntPtr.Zero && Create_URL_IsValid && Create_Parms_IsValid && Create_bLaunchDetached_IsValid && Create_bLaunchHidden_IsValid && Create_bLaunchReallyHidden_IsValid && Create_PriorityModifier_IsValid && Create_OptionalWorkingDirectory_IsValid && Create_bUsePipe_IsValid && Create_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Create", Create_IsValid);
		Close_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Close");
		Close_ParamsSize = NativeReflection.GetFunctionParamsSize(Close_FunctionAddress);
		Close_IsValid = Close_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:Close", Close_IsValid);
		CanLaunchURL_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanLaunchURL");
		CanLaunchURL_ParamsSize = NativeReflection.GetFunctionParamsSize(CanLaunchURL_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanLaunchURL_URL_PropertyAddress, CanLaunchURL_FunctionAddress, "URL");
		CanLaunchURL_URL_Offset = NativeReflectionCached.GetPropertyOffset(CanLaunchURL_FunctionAddress, "URL");
		CanLaunchURL_URL_IsValid = NativeReflectionCached.ValidatePropertyClass(CanLaunchURL_FunctionAddress, "URL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CanLaunchURL_ReturnValue_PropertyAddress, CanLaunchURL_FunctionAddress, "ReturnValue");
		CanLaunchURL_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanLaunchURL_FunctionAddress, "ReturnValue");
		CanLaunchURL_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanLaunchURL_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanLaunchURL_IsValid = CanLaunchURL_FunctionAddress != IntPtr.Zero && CanLaunchURL_URL_IsValid && CanLaunchURL_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptProcess:CanLaunchURL", CanLaunchURL_IsValid);
	}
}
