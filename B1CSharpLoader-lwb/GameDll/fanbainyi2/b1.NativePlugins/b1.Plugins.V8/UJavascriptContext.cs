using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/V8.JavascriptContext", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptContext : UObject
{
	private static bool Paths_IsValid;

	private static FFieldAddress Paths_PropertyAddress;

	private static int Paths_Offset;

	private TArrayReadWriteMarshaler<string> Paths_MarshalerCached;

	private static bool WriteDTS_IsValid;

	private static IntPtr WriteDTS_FunctionAddress;

	private static int WriteDTS_ParamsSize;

	private static bool WriteDTS_Target_IsValid;

	private static FFieldAddress WriteDTS_Target_PropertyAddress;

	private static int WriteDTS_Target_Offset;

	private static bool WriteDTS_bIncludingTooltip_IsValid;

	private static FFieldAddress WriteDTS_bIncludingTooltip_PropertyAddress;

	private static int WriteDTS_bIncludingTooltip_Offset;

	private static bool WriteDTS_ReturnValue_IsValid;

	private static FFieldAddress WriteDTS_ReturnValue_PropertyAddress;

	private static int WriteDTS_ReturnValue_Offset;

	private static bool WriteAliases_IsValid;

	private static IntPtr WriteAliases_FunctionAddress;

	private static int WriteAliases_ParamsSize;

	private static bool WriteAliases_Target_IsValid;

	private static FFieldAddress WriteAliases_Target_PropertyAddress;

	private static int WriteAliases_Target_Offset;

	private static bool WriteAliases_ReturnValue_IsValid;

	private static FFieldAddress WriteAliases_ReturnValue_PropertyAddress;

	private static int WriteAliases_ReturnValue_Offset;

	private static bool UnregisterConsoleCommand_IsValid;

	private static IntPtr UnregisterConsoleCommand_FunctionAddress;

	private static int UnregisterConsoleCommand_ParamsSize;

	private static bool UnregisterConsoleCommand_Command_IsValid;

	private static FFieldAddress UnregisterConsoleCommand_Command_PropertyAddress;

	private static int UnregisterConsoleCommand_Command_Offset;

	private static bool SetContextId_IsValid;

	private static IntPtr SetContextId_FunctionAddress;

	private static int SetContextId_ParamsSize;

	private static bool SetContextId_Name_IsValid;

	private static FFieldAddress SetContextId_Name_PropertyAddress;

	private static int SetContextId_Name_Offset;

	private static bool RunScript_IsValid;

	private static IntPtr RunScript_FunctionAddress;

	private static int RunScript_ParamsSize;

	private static bool RunScript_Script_IsValid;

	private static FFieldAddress RunScript_Script_PropertyAddress;

	private static int RunScript_Script_Offset;

	private static bool RunScript_bOutput_IsValid;

	private static FFieldAddress RunScript_bOutput_PropertyAddress;

	private static int RunScript_bOutput_Offset;

	private static bool RunScript_ReturnValue_IsValid;

	private static FFieldAddress RunScript_ReturnValue_PropertyAddress;

	private static int RunScript_ReturnValue_Offset;

	private static bool RunFile_IsValid;

	private static IntPtr RunFile_FunctionAddress;

	private static int RunFile_ParamsSize;

	private static bool RunFile_Filename_IsValid;

	private static FFieldAddress RunFile_Filename_PropertyAddress;

	private static int RunFile_Filename_Offset;

	private static bool RequestV8GarbageCollection_IsValid;

	private static IntPtr RequestV8GarbageCollection_FunctionAddress;

	private static int RequestV8GarbageCollection_ParamsSize;

	private static bool RegisterConsoleCommand_IsValid;

	private static IntPtr RegisterConsoleCommand_FunctionAddress;

	private static int RegisterConsoleCommand_ParamsSize;

	private static bool RegisterConsoleCommand_Command_IsValid;

	private static FFieldAddress RegisterConsoleCommand_Command_PropertyAddress;

	private static int RegisterConsoleCommand_Command_Offset;

	private static bool RegisterConsoleCommand_Help_IsValid;

	private static FFieldAddress RegisterConsoleCommand_Help_PropertyAddress;

	private static int RegisterConsoleCommand_Help_Offset;

	private static bool RegisterConsoleCommand_Function_IsValid;

	private static FFieldAddress RegisterConsoleCommand_Function_PropertyAddress;

	private static int RegisterConsoleCommand_Function_Offset;

	private static bool ReadScriptFile_IsValid;

	private static IntPtr ReadScriptFile_FunctionAddress;

	private static int ReadScriptFile_ParamsSize;

	private static bool ReadScriptFile_Filename_IsValid;

	private static FFieldAddress ReadScriptFile_Filename_PropertyAddress;

	private static int ReadScriptFile_Filename_Offset;

	private static bool ReadScriptFile_ReturnValue_IsValid;

	private static FFieldAddress ReadScriptFile_ReturnValue_PropertyAddress;

	private static int ReadScriptFile_ReturnValue_Offset;

	private static bool IsDebugContext_IsValid;

	private static IntPtr IsDebugContext_FunctionAddress;

	private static int IsDebugContext_ParamsSize;

	private static bool IsDebugContext_ReturnValue_IsValid;

	private static FFieldAddress IsDebugContext_ReturnValue_PropertyAddress;

	private static int IsDebugContext_ReturnValue_Offset;

	private static bool GetScriptFileFullPath_IsValid;

	private static IntPtr GetScriptFileFullPath_FunctionAddress;

	private static int GetScriptFileFullPath_ParamsSize;

	private static bool GetScriptFileFullPath_Filename_IsValid;

	private static FFieldAddress GetScriptFileFullPath_Filename_PropertyAddress;

	private static int GetScriptFileFullPath_Filename_Offset;

	private static bool GetScriptFileFullPath_ReturnValue_IsValid;

	private static FFieldAddress GetScriptFileFullPath_ReturnValue_PropertyAddress;

	private static int GetScriptFileFullPath_ReturnValue_Offset;

	private static bool FindPathFile_IsValid;

	private static IntPtr FindPathFile_FunctionAddress;

	private static int FindPathFile_ParamsSize;

	private static bool FindPathFile_TargetRootPath_IsValid;

	private static FFieldAddress FindPathFile_TargetRootPath_PropertyAddress;

	private static int FindPathFile_TargetRootPath_Offset;

	private static bool FindPathFile_TargetFileName_IsValid;

	private static FFieldAddress FindPathFile_TargetFileName_PropertyAddress;

	private static int FindPathFile_TargetFileName_Offset;

	private static bool FindPathFile_OutFiles_IsValid;

	private static FFieldAddress FindPathFile_OutFiles_PropertyAddress;

	private static int FindPathFile_OutFiles_Offset;

	private static bool Expose_IsValid;

	private static IntPtr Expose_FunctionAddress;

	private static int Expose_ParamsSize;

	private static bool Expose_Name_IsValid;

	private static FFieldAddress Expose_Name_PropertyAddress;

	private static int Expose_Name_Offset;

	private static bool Expose_Object_IsValid;

	private static FFieldAddress Expose_Object_PropertyAddress;

	private static int Expose_Object_Offset;

	private static bool DestroyInspector_IsValid;

	private static IntPtr DestroyInspector_FunctionAddress;

	private static int DestroyInspector_ParamsSize;

	private static bool CreateInspector_IsValid;

	private static IntPtr CreateInspector_FunctionAddress;

	private static int CreateInspector_ParamsSize;

	private static bool CreateInspector_Port_IsValid;

	private static FFieldAddress CreateInspector_Port_PropertyAddress;

	private static int CreateInspector_Port_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/V8.JavascriptContext:Paths")]
	public TArrayReadWrite<string> Paths
	{
		get
		{
			CheckDestroyed();
			if (!Paths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptContext:Paths");
				return null;
			}
			if (Paths_MarshalerCached == null)
			{
				Paths_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, Paths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Paths_MarshalerCached.FromNative(IntPtr.Add(base.Address, Paths_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:WriteDTS")]
	public unsafe bool WriteDTS(string Target, bool bIncludingTooltip)
	{
		CheckDestroyed();
		if (!WriteDTS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:WriteDTS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteDTS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteDTS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteDTS_Target_Offset), 0, WriteDTS_Target_PropertyAddress.Address, Target);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WriteDTS_bIncludingTooltip_Offset), 0, WriteDTS_bIncludingTooltip_PropertyAddress.Address, bIncludingTooltip);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteDTS_FunctionAddress, intPtr, WriteDTS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteDTS_Target_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteDTS_ReturnValue_Offset), 0, WriteDTS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:WriteAliases")]
	public unsafe bool WriteAliases(string Target)
	{
		CheckDestroyed();
		if (!WriteAliases_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:WriteAliases");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteAliases_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteAliases_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteAliases_Target_Offset), 0, WriteAliases_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteAliases_FunctionAddress, intPtr, WriteAliases_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteAliases_Target_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteAliases_ReturnValue_Offset), 0, WriteAliases_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:UnregisterConsoleCommand")]
	public unsafe void UnregisterConsoleCommand(string Command)
	{
		CheckDestroyed();
		if (!UnregisterConsoleCommand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:UnregisterConsoleCommand");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterConsoleCommand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterConsoleCommand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UnregisterConsoleCommand_Command_Offset), 0, UnregisterConsoleCommand_Command_PropertyAddress.Address, Command);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterConsoleCommand_FunctionAddress, intPtr, UnregisterConsoleCommand_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnregisterConsoleCommand_Command_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:SetContextId")]
	public unsafe void SetContextId(string Name)
	{
		CheckDestroyed();
		if (!SetContextId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:SetContextId");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContextId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContextId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetContextId_Name_Offset), 0, SetContextId_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetContextId_FunctionAddress, intPtr, SetContextId_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetContextId_Name_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:RunScript")]
	public unsafe string RunScript(string Script, bool bOutput = true)
	{
		CheckDestroyed();
		if (!RunScript_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:RunScript");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunScript_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunScript_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunScript_Script_Offset), 0, RunScript_Script_PropertyAddress.Address, Script);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RunScript_bOutput_Offset), 0, RunScript_bOutput_PropertyAddress.Address, bOutput);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunScript_FunctionAddress, intPtr, RunScript_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunScript_Script_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RunScript_ReturnValue_Offset), 0, RunScript_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RunScript_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:RunFile")]
	public unsafe void RunFile(string Filename)
	{
		CheckDestroyed();
		if (!RunFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:RunFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunFile_Filename_Offset), 0, RunFile_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunFile_FunctionAddress, intPtr, RunFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunFile_Filename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:RequestV8GarbageCollection")]
	public unsafe void RequestV8GarbageCollection()
	{
		CheckDestroyed();
		if (!RequestV8GarbageCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:RequestV8GarbageCollection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestV8GarbageCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestV8GarbageCollection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestV8GarbageCollection_FunctionAddress, argsSize: RequestV8GarbageCollection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:RegisterConsoleCommand")]
	public unsafe void RegisterConsoleCommand(string Command, string Help, FJavascriptFunction Function)
	{
		CheckDestroyed();
		if (!RegisterConsoleCommand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:RegisterConsoleCommand");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterConsoleCommand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterConsoleCommand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RegisterConsoleCommand_Command_Offset), 0, RegisterConsoleCommand_Command_PropertyAddress.Address, Command);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RegisterConsoleCommand_Help_Offset), 0, RegisterConsoleCommand_Help_PropertyAddress.Address, Help);
		NativeReflection.InitializeValue_InContainer(RegisterConsoleCommand_Function_PropertyAddress.Address, intPtr);
		FJavascriptFunction.ToNative(IntPtr.Add(intPtr, RegisterConsoleCommand_Function_Offset), 0, RegisterConsoleCommand_Function_PropertyAddress.Address, Function);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterConsoleCommand_FunctionAddress, intPtr, RegisterConsoleCommand_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterConsoleCommand_Command_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RegisterConsoleCommand_Help_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RegisterConsoleCommand_Function_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:ReadScriptFile")]
	public unsafe string ReadScriptFile(string Filename)
	{
		CheckDestroyed();
		if (!ReadScriptFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:ReadScriptFile");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadScriptFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadScriptFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReadScriptFile_Filename_Offset), 0, ReadScriptFile_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadScriptFile_FunctionAddress, intPtr, ReadScriptFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReadScriptFile_Filename_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ReadScriptFile_ReturnValue_Offset), 0, ReadScriptFile_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReadScriptFile_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/V8.JavascriptContext:IsDebugContext")]
	public unsafe bool IsDebugContext()
	{
		CheckDestroyed();
		if (!IsDebugContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:IsDebugContext");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDebugContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDebugContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDebugContext_FunctionAddress, intPtr, IsDebugContext_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDebugContext_ReturnValue_Offset), 0, IsDebugContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:GetScriptFileFullPath")]
	public unsafe string GetScriptFileFullPath(string Filename)
	{
		CheckDestroyed();
		if (!GetScriptFileFullPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:GetScriptFileFullPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScriptFileFullPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScriptFileFullPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetScriptFileFullPath_Filename_Offset), 0, GetScriptFileFullPath_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScriptFileFullPath_FunctionAddress, intPtr, GetScriptFileFullPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetScriptFileFullPath_Filename_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetScriptFileFullPath_ReturnValue_Offset), 0, GetScriptFileFullPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetScriptFileFullPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/V8.JavascriptContext:FindPathFile")]
	public unsafe void FindPathFile(string TargetRootPath, string TargetFileName, out List<string> OutFiles)
	{
		CheckDestroyed();
		if (!FindPathFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:FindPathFile");
			OutFiles = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPathFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPathFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPathFile_TargetRootPath_Offset), 0, FindPathFile_TargetRootPath_PropertyAddress.Address, TargetRootPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPathFile_TargetFileName_Offset), 0, FindPathFile_TargetFileName_PropertyAddress.Address, TargetFileName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPathFile_FunctionAddress, intPtr, FindPathFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPathFile_TargetRootPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindPathFile_TargetFileName_PropertyAddress.Address, intPtr);
		OutFiles = new TArrayCopyMarshaler<string>(1, FindPathFile_OutFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FindPathFile_OutFiles_Offset));
		NativeReflection.DestroyValue_InContainer(FindPathFile_OutFiles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:Expose")]
	public unsafe void Expose(string Name, UObject Object)
	{
		CheckDestroyed();
		if (!Expose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:Expose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Expose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Expose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Expose_Name_Offset), 0, Expose_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Expose_Object_Offset), 0, Expose_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, Expose_FunctionAddress, intPtr, Expose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Expose_Name_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:DestroyInspector")]
	public unsafe void DestroyInspector()
	{
		CheckDestroyed();
		if (!DestroyInspector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:DestroyInspector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyInspector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyInspector_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DestroyInspector_FunctionAddress, argsSize: DestroyInspector_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptContext:CreateInspector")]
	public unsafe void CreateInspector(int Port = 9229)
	{
		CheckDestroyed();
		if (!CreateInspector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptContext:CreateInspector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInspector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInspector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateInspector_Port_Offset), 0, CreateInspector_Port_PropertyAddress.Address, Port);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateInspector_FunctionAddress, intPtr, CreateInspector_ParamsSize);
	}

	static UJavascriptContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/V8.JavascriptContext");
		NativeReflectionCached.GetPropertyRef(ref Paths_PropertyAddress, intPtr, "Paths");
		Paths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Paths");
		Paths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Paths", Classes.FArrayProperty);
		WriteDTS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WriteDTS");
		WriteDTS_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteDTS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteDTS_Target_PropertyAddress, WriteDTS_FunctionAddress, "Target");
		WriteDTS_Target_Offset = NativeReflectionCached.GetPropertyOffset(WriteDTS_FunctionAddress, "Target");
		WriteDTS_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteDTS_FunctionAddress, "Target", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteDTS_bIncludingTooltip_PropertyAddress, WriteDTS_FunctionAddress, "bIncludingTooltip");
		WriteDTS_bIncludingTooltip_Offset = NativeReflectionCached.GetPropertyOffset(WriteDTS_FunctionAddress, "bIncludingTooltip");
		WriteDTS_bIncludingTooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteDTS_FunctionAddress, "bIncludingTooltip", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteDTS_ReturnValue_PropertyAddress, WriteDTS_FunctionAddress, "ReturnValue");
		WriteDTS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteDTS_FunctionAddress, "ReturnValue");
		WriteDTS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteDTS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteDTS_IsValid = WriteDTS_FunctionAddress != IntPtr.Zero && WriteDTS_Target_IsValid && WriteDTS_bIncludingTooltip_IsValid && WriteDTS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:WriteDTS", WriteDTS_IsValid);
		WriteAliases_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WriteAliases");
		WriteAliases_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteAliases_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteAliases_Target_PropertyAddress, WriteAliases_FunctionAddress, "Target");
		WriteAliases_Target_Offset = NativeReflectionCached.GetPropertyOffset(WriteAliases_FunctionAddress, "Target");
		WriteAliases_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteAliases_FunctionAddress, "Target", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteAliases_ReturnValue_PropertyAddress, WriteAliases_FunctionAddress, "ReturnValue");
		WriteAliases_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteAliases_FunctionAddress, "ReturnValue");
		WriteAliases_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteAliases_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteAliases_IsValid = WriteAliases_FunctionAddress != IntPtr.Zero && WriteAliases_Target_IsValid && WriteAliases_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:WriteAliases", WriteAliases_IsValid);
		UnregisterConsoleCommand_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterConsoleCommand");
		UnregisterConsoleCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterConsoleCommand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterConsoleCommand_Command_PropertyAddress, UnregisterConsoleCommand_FunctionAddress, "Command");
		UnregisterConsoleCommand_Command_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterConsoleCommand_FunctionAddress, "Command");
		UnregisterConsoleCommand_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterConsoleCommand_FunctionAddress, "Command", Classes.FStrProperty);
		UnregisterConsoleCommand_IsValid = UnregisterConsoleCommand_FunctionAddress != IntPtr.Zero && UnregisterConsoleCommand_Command_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:UnregisterConsoleCommand", UnregisterConsoleCommand_IsValid);
		SetContextId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetContextId");
		SetContextId_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContextId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContextId_Name_PropertyAddress, SetContextId_FunctionAddress, "Name");
		SetContextId_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetContextId_FunctionAddress, "Name");
		SetContextId_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContextId_FunctionAddress, "Name", Classes.FStrProperty);
		SetContextId_IsValid = SetContextId_FunctionAddress != IntPtr.Zero && SetContextId_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:SetContextId", SetContextId_IsValid);
		RunScript_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunScript");
		RunScript_ParamsSize = NativeReflection.GetFunctionParamsSize(RunScript_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunScript_Script_PropertyAddress, RunScript_FunctionAddress, "Script");
		RunScript_Script_Offset = NativeReflectionCached.GetPropertyOffset(RunScript_FunctionAddress, "Script");
		RunScript_Script_IsValid = NativeReflectionCached.ValidatePropertyClass(RunScript_FunctionAddress, "Script", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RunScript_bOutput_PropertyAddress, RunScript_FunctionAddress, "bOutput");
		RunScript_bOutput_Offset = NativeReflectionCached.GetPropertyOffset(RunScript_FunctionAddress, "bOutput");
		RunScript_bOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(RunScript_FunctionAddress, "bOutput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RunScript_ReturnValue_PropertyAddress, RunScript_FunctionAddress, "ReturnValue");
		RunScript_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunScript_FunctionAddress, "ReturnValue");
		RunScript_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunScript_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RunScript_IsValid = RunScript_FunctionAddress != IntPtr.Zero && RunScript_Script_IsValid && RunScript_bOutput_IsValid && RunScript_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:RunScript", RunScript_IsValid);
		RunFile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunFile");
		RunFile_ParamsSize = NativeReflection.GetFunctionParamsSize(RunFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunFile_Filename_PropertyAddress, RunFile_FunctionAddress, "Filename");
		RunFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(RunFile_FunctionAddress, "Filename");
		RunFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(RunFile_FunctionAddress, "Filename", Classes.FStrProperty);
		RunFile_IsValid = RunFile_FunctionAddress != IntPtr.Zero && RunFile_Filename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:RunFile", RunFile_IsValid);
		RequestV8GarbageCollection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestV8GarbageCollection");
		RequestV8GarbageCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestV8GarbageCollection_FunctionAddress);
		RequestV8GarbageCollection_IsValid = RequestV8GarbageCollection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:RequestV8GarbageCollection", RequestV8GarbageCollection_IsValid);
		RegisterConsoleCommand_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterConsoleCommand");
		RegisterConsoleCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterConsoleCommand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterConsoleCommand_Command_PropertyAddress, RegisterConsoleCommand_FunctionAddress, "Command");
		RegisterConsoleCommand_Command_Offset = NativeReflectionCached.GetPropertyOffset(RegisterConsoleCommand_FunctionAddress, "Command");
		RegisterConsoleCommand_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterConsoleCommand_FunctionAddress, "Command", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterConsoleCommand_Help_PropertyAddress, RegisterConsoleCommand_FunctionAddress, "Help");
		RegisterConsoleCommand_Help_Offset = NativeReflectionCached.GetPropertyOffset(RegisterConsoleCommand_FunctionAddress, "Help");
		RegisterConsoleCommand_Help_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterConsoleCommand_FunctionAddress, "Help", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterConsoleCommand_Function_PropertyAddress, RegisterConsoleCommand_FunctionAddress, "Function");
		RegisterConsoleCommand_Function_Offset = NativeReflectionCached.GetPropertyOffset(RegisterConsoleCommand_FunctionAddress, "Function");
		RegisterConsoleCommand_Function_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterConsoleCommand_FunctionAddress, "Function", Classes.FStructProperty);
		RegisterConsoleCommand_IsValid = RegisterConsoleCommand_FunctionAddress != IntPtr.Zero && RegisterConsoleCommand_Command_IsValid && RegisterConsoleCommand_Help_IsValid && RegisterConsoleCommand_Function_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:RegisterConsoleCommand", RegisterConsoleCommand_IsValid);
		ReadScriptFile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReadScriptFile");
		ReadScriptFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadScriptFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadScriptFile_Filename_PropertyAddress, ReadScriptFile_FunctionAddress, "Filename");
		ReadScriptFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(ReadScriptFile_FunctionAddress, "Filename");
		ReadScriptFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadScriptFile_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadScriptFile_ReturnValue_PropertyAddress, ReadScriptFile_FunctionAddress, "ReturnValue");
		ReadScriptFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadScriptFile_FunctionAddress, "ReturnValue");
		ReadScriptFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadScriptFile_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ReadScriptFile_IsValid = ReadScriptFile_FunctionAddress != IntPtr.Zero && ReadScriptFile_Filename_IsValid && ReadScriptFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:ReadScriptFile", ReadScriptFile_IsValid);
		IsDebugContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDebugContext");
		IsDebugContext_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDebugContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDebugContext_ReturnValue_PropertyAddress, IsDebugContext_FunctionAddress, "ReturnValue");
		IsDebugContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDebugContext_FunctionAddress, "ReturnValue");
		IsDebugContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDebugContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDebugContext_IsValid = IsDebugContext_FunctionAddress != IntPtr.Zero && IsDebugContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:IsDebugContext", IsDebugContext_IsValid);
		GetScriptFileFullPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScriptFileFullPath");
		GetScriptFileFullPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScriptFileFullPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScriptFileFullPath_Filename_PropertyAddress, GetScriptFileFullPath_FunctionAddress, "Filename");
		GetScriptFileFullPath_Filename_Offset = NativeReflectionCached.GetPropertyOffset(GetScriptFileFullPath_FunctionAddress, "Filename");
		GetScriptFileFullPath_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScriptFileFullPath_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScriptFileFullPath_ReturnValue_PropertyAddress, GetScriptFileFullPath_FunctionAddress, "ReturnValue");
		GetScriptFileFullPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScriptFileFullPath_FunctionAddress, "ReturnValue");
		GetScriptFileFullPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScriptFileFullPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetScriptFileFullPath_IsValid = GetScriptFileFullPath_FunctionAddress != IntPtr.Zero && GetScriptFileFullPath_Filename_IsValid && GetScriptFileFullPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:GetScriptFileFullPath", GetScriptFileFullPath_IsValid);
		FindPathFile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindPathFile");
		FindPathFile_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPathFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPathFile_TargetRootPath_PropertyAddress, FindPathFile_FunctionAddress, "TargetRootPath");
		FindPathFile_TargetRootPath_Offset = NativeReflectionCached.GetPropertyOffset(FindPathFile_FunctionAddress, "TargetRootPath");
		FindPathFile_TargetRootPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathFile_FunctionAddress, "TargetRootPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathFile_TargetFileName_PropertyAddress, FindPathFile_FunctionAddress, "TargetFileName");
		FindPathFile_TargetFileName_Offset = NativeReflectionCached.GetPropertyOffset(FindPathFile_FunctionAddress, "TargetFileName");
		FindPathFile_TargetFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathFile_FunctionAddress, "TargetFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathFile_OutFiles_PropertyAddress, FindPathFile_FunctionAddress, "OutFiles");
		FindPathFile_OutFiles_Offset = NativeReflectionCached.GetPropertyOffset(FindPathFile_FunctionAddress, "OutFiles");
		FindPathFile_OutFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathFile_FunctionAddress, "OutFiles", Classes.FArrayProperty);
		FindPathFile_IsValid = FindPathFile_FunctionAddress != IntPtr.Zero && FindPathFile_TargetRootPath_IsValid && FindPathFile_TargetFileName_IsValid && FindPathFile_OutFiles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:FindPathFile", FindPathFile_IsValid);
		Expose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Expose");
		Expose_ParamsSize = NativeReflection.GetFunctionParamsSize(Expose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Expose_Name_PropertyAddress, Expose_FunctionAddress, "Name");
		Expose_Name_Offset = NativeReflectionCached.GetPropertyOffset(Expose_FunctionAddress, "Name");
		Expose_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Expose_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Expose_Object_PropertyAddress, Expose_FunctionAddress, "Object");
		Expose_Object_Offset = NativeReflectionCached.GetPropertyOffset(Expose_FunctionAddress, "Object");
		Expose_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(Expose_FunctionAddress, "Object", Classes.FObjectProperty);
		Expose_IsValid = Expose_FunctionAddress != IntPtr.Zero && Expose_Name_IsValid && Expose_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:Expose", Expose_IsValid);
		DestroyInspector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyInspector");
		DestroyInspector_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyInspector_FunctionAddress);
		DestroyInspector_IsValid = DestroyInspector_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:DestroyInspector", DestroyInspector_IsValid);
		CreateInspector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateInspector");
		CreateInspector_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInspector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInspector_Port_PropertyAddress, CreateInspector_FunctionAddress, "Port");
		CreateInspector_Port_Offset = NativeReflectionCached.GetPropertyOffset(CreateInspector_FunctionAddress, "Port");
		CreateInspector_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInspector_FunctionAddress, "Port", Classes.FIntProperty);
		CreateInspector_IsValid = CreateInspector_FunctionAddress != IntPtr.Zero && CreateInspector_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptContext:CreateInspector", CreateInspector_IsValid);
	}
}
