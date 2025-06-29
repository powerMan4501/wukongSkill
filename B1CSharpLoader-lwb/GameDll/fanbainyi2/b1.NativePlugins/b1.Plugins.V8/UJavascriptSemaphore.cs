using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptSemaphore", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptSemaphore : UObject
{
	private static IntPtr classAddress;

	private static bool Unlock_IsValid;

	private static IntPtr Unlock_FunctionAddress;

	private static int Unlock_ParamsSize;

	private static bool TryLock_IsValid;

	private static IntPtr TryLock_FunctionAddress;

	private static int TryLock_ParamsSize;

	private static bool TryLock_NanosecondsToWait_IsValid;

	private static FFieldAddress TryLock_NanosecondsToWait_PropertyAddress;

	private static int TryLock_NanosecondsToWait_Offset;

	private static bool TryLock_ReturnValue_IsValid;

	private static FFieldAddress TryLock_ReturnValue_PropertyAddress;

	private static int TryLock_ReturnValue_Offset;

	private static bool Lock_IsValid;

	private static IntPtr Lock_FunctionAddress;

	private static int Lock_ParamsSize;

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

	private static bool Create_MaxLocks_IsValid;

	private static FFieldAddress Create_MaxLocks_PropertyAddress;

	private static int Create_MaxLocks_Offset;

	private static bool Create_ReturnValue_IsValid;

	private static FFieldAddress Create_ReturnValue_PropertyAddress;

	private static int Create_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptSemaphore:Unlock")]
	public unsafe void Unlock()
	{
		CheckDestroyed();
		if (!Unlock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSemaphore:Unlock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unlock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unlock_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Unlock_FunctionAddress, argsSize: Unlock_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptSemaphore:TryLock")]
	public unsafe bool TryLock(int NanosecondsToWait)
	{
		CheckDestroyed();
		if (!TryLock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSemaphore:TryLock");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryLock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryLock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TryLock_NanosecondsToWait_Offset), 0, TryLock_NanosecondsToWait_PropertyAddress.Address, NanosecondsToWait);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryLock_FunctionAddress, intPtr, TryLock_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryLock_ReturnValue_Offset), 0, TryLock_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptSemaphore:Lock")]
	public unsafe void Lock()
	{
		CheckDestroyed();
		if (!Lock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSemaphore:Lock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Lock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Lock_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Lock_FunctionAddress, argsSize: Lock_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptSemaphore:Dispose")]
	public unsafe void Dispose()
	{
		CheckDestroyed();
		if (!Dispose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSemaphore:Dispose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Dispose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Dispose_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Dispose_FunctionAddress, argsSize: Dispose_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/V8.JavascriptSemaphore:Create")]
	public unsafe static UJavascriptSemaphore Create(FName Name, bool bCreate, int MaxLocks)
	{
		if (!Create_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptSemaphore:Create");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Create_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Create_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Create_Name_Offset), 0, Create_Name_PropertyAddress.Address, Name);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Create_bCreate_Offset), 0, Create_bCreate_PropertyAddress.Address, bCreate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Create_MaxLocks_Offset), 0, Create_MaxLocks_PropertyAddress.Address, MaxLocks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Create_FunctionAddress, intPtr, Create_ParamsSize);
		return UObjectMarshaler<UJavascriptSemaphore>.FromNative(IntPtr.Add(intPtr, Create_ReturnValue_Offset), 0, Create_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptSemaphore()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptSemaphore)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptSemaphore));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/V8.JavascriptSemaphore");
		Unlock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Unlock");
		Unlock_ParamsSize = NativeReflection.GetFunctionParamsSize(Unlock_FunctionAddress);
		Unlock_IsValid = Unlock_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSemaphore:Unlock", Unlock_IsValid);
		TryLock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryLock");
		TryLock_ParamsSize = NativeReflection.GetFunctionParamsSize(TryLock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryLock_NanosecondsToWait_PropertyAddress, TryLock_FunctionAddress, "NanosecondsToWait");
		TryLock_NanosecondsToWait_Offset = NativeReflectionCached.GetPropertyOffset(TryLock_FunctionAddress, "NanosecondsToWait");
		TryLock_NanosecondsToWait_IsValid = NativeReflectionCached.ValidatePropertyClass(TryLock_FunctionAddress, "NanosecondsToWait", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TryLock_ReturnValue_PropertyAddress, TryLock_FunctionAddress, "ReturnValue");
		TryLock_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryLock_FunctionAddress, "ReturnValue");
		TryLock_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryLock_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryLock_IsValid = TryLock_FunctionAddress != IntPtr.Zero && TryLock_NanosecondsToWait_IsValid && TryLock_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSemaphore:TryLock", TryLock_IsValid);
		Lock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Lock");
		Lock_ParamsSize = NativeReflection.GetFunctionParamsSize(Lock_FunctionAddress);
		Lock_IsValid = Lock_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSemaphore:Lock", Lock_IsValid);
		Dispose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Dispose");
		Dispose_ParamsSize = NativeReflection.GetFunctionParamsSize(Dispose_FunctionAddress);
		Dispose_IsValid = Dispose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSemaphore:Dispose", Dispose_IsValid);
		Create_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Create");
		Create_ParamsSize = NativeReflection.GetFunctionParamsSize(Create_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Create_Name_PropertyAddress, Create_FunctionAddress, "Name");
		Create_Name_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "Name");
		Create_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_bCreate_PropertyAddress, Create_FunctionAddress, "bCreate");
		Create_bCreate_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "bCreate");
		Create_bCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "bCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_MaxLocks_PropertyAddress, Create_FunctionAddress, "MaxLocks");
		Create_MaxLocks_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "MaxLocks");
		Create_MaxLocks_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "MaxLocks", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_ReturnValue_PropertyAddress, Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Create_IsValid = Create_FunctionAddress != IntPtr.Zero && Create_Name_IsValid && Create_bCreate_IsValid && Create_MaxLocks_IsValid && Create_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptSemaphore:Create", Create_IsValid);
	}
}
