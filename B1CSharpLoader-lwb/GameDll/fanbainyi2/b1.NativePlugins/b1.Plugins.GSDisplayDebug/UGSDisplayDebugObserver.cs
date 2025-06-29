using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSDisplayDebug;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSDisplayDebug.GSDisplayDebugObserver", "GSDisplayDebug", UnrealModuleType.GamePlugin)]
public class UGSDisplayDebugObserver : UObject
{
	private static IntPtr classAddress;

	private static bool Register_IsValid;

	private static IntPtr Register_FunctionAddress;

	private static int Register_ParamsSize;

	private static bool Register_Observer_IsValid;

	private static FFieldAddress Register_Observer_PropertyAddress;

	private static int Register_Observer_Offset;

	private static bool Register_IsRegister_IsValid;

	private static FFieldAddress Register_IsRegister_PropertyAddress;

	private static int Register_IsRegister_Offset;

	private static bool GetDisplayDebugNames_IsValid;

	private IntPtr GetDisplayDebugNames_InstanceFunctionAddress;

	private static IntPtr GetDisplayDebugNames_FunctionAddress;

	private static int GetDisplayDebugNames_ParamsSize;

	private static bool GetDisplayDebugNames_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayDebugNames_ReturnValue_PropertyAddress;

	private static int GetDisplayDebugNames_ReturnValue_Offset;

	private static bool FetchDebugInfo_IsValid;

	private IntPtr FetchDebugInfo_InstanceFunctionAddress;

	private static IntPtr FetchDebugInfo_FunctionAddress;

	private static int FetchDebugInfo_ParamsSize;

	private static bool FetchDebugInfo_Name_IsValid;

	private static FFieldAddress FetchDebugInfo_Name_PropertyAddress;

	private static int FetchDebugInfo_Name_Offset;

	private static bool FetchDebugInfo_DebugInfos_IsValid;

	private static FFieldAddress FetchDebugInfo_DebugInfos_PropertyAddress;

	private static int FetchDebugInfo_DebugInfos_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSDisplayDebug.GSDisplayDebugObserver:Register")]
	public unsafe static void Register(UGSDisplayDebugObserver Observer, bool IsRegister)
	{
		if (!Register_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDisplayDebug.GSDisplayDebugObserver:Register");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Register_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Register_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSDisplayDebugObserver>.ToNative(IntPtr.Add(intPtr, Register_Observer_Offset), 0, Register_Observer_PropertyAddress.Address, Observer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Register_IsRegister_Offset), 0, Register_IsRegister_PropertyAddress.Address, IsRegister);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Register_FunctionAddress, intPtr, Register_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSDisplayDebug.GSDisplayDebugObserver:GetDisplayDebugNames")]
	public unsafe List<FName> GetDisplayDebugNames()
	{
		CheckDestroyed();
		if (!GetDisplayDebugNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDisplayDebug.GSDisplayDebugObserver:GetDisplayDebugNames");
			return null;
		}
		if (GetDisplayDebugNames_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayDebugNames_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayDebugNames");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayDebugNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayDebugNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayDebugNames_InstanceFunctionAddress, intPtr, GetDisplayDebugNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetDisplayDebugNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDisplayDebugNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDisplayDebugNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FName> GetDisplayDebugNames_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayDebugNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDisplayDebug.GSDisplayDebugObserver:GetDisplayDebugNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayDebugNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayDebugNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayDebugNames_FunctionAddress, intPtr, GetDisplayDebugNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetDisplayDebugNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDisplayDebugNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDisplayDebugNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSDisplayDebug.GSDisplayDebugObserver:FetchDebugInfo")]
	public unsafe void FetchDebugInfo(FName Name, out List<FGSDebugInfo> DebugInfos)
	{
		CheckDestroyed();
		if (!FetchDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDisplayDebug.GSDisplayDebugObserver:FetchDebugInfo");
			DebugInfos = null;
			return;
		}
		if (FetchDebugInfo_InstanceFunctionAddress == IntPtr.Zero)
		{
			FetchDebugInfo_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "FetchDebugInfo");
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchDebugInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchDebugInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FetchDebugInfo_Name_Offset), 0, FetchDebugInfo_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchDebugInfo_InstanceFunctionAddress, intPtr, FetchDebugInfo_ParamsSize);
		DebugInfos = new TArrayCopyMarshaler<FGSDebugInfo>(1, FetchDebugInfo_DebugInfos_PropertyAddress, CachedMarshalingDelegates<FGSDebugInfo, FGSDebugInfo>.FromNative, CachedMarshalingDelegates<FGSDebugInfo, FGSDebugInfo>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugInfos_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugInfos_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void FetchDebugInfo_Implementation(FName Name, out List<FGSDebugInfo> DebugInfos)
	{
		CheckDestroyed();
		if (!FetchDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDisplayDebug.GSDisplayDebugObserver:FetchDebugInfo");
			DebugInfos = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchDebugInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchDebugInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FetchDebugInfo_Name_Offset), 0, FetchDebugInfo_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchDebugInfo_FunctionAddress, intPtr, FetchDebugInfo_ParamsSize);
		DebugInfos = new TArrayCopyMarshaler<FGSDebugInfo>(1, FetchDebugInfo_DebugInfos_PropertyAddress, CachedMarshalingDelegates<FGSDebugInfo, FGSDebugInfo>.FromNative, CachedMarshalingDelegates<FGSDebugInfo, FGSDebugInfo>.ToNative).FromNative(IntPtr.Add(intPtr, FetchDebugInfo_DebugInfos_Offset));
		NativeReflection.DestroyValue_InContainer(FetchDebugInfo_DebugInfos_PropertyAddress.Address, intPtr);
	}

	static UGSDisplayDebugObserver()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSDisplayDebugObserver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSDisplayDebugObserver));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSDisplayDebug.GSDisplayDebugObserver");
		Register_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Register");
		Register_ParamsSize = NativeReflection.GetFunctionParamsSize(Register_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Register_Observer_PropertyAddress, Register_FunctionAddress, "Observer");
		Register_Observer_Offset = NativeReflectionCached.GetPropertyOffset(Register_FunctionAddress, "Observer");
		Register_Observer_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_FunctionAddress, "Observer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Register_IsRegister_PropertyAddress, Register_FunctionAddress, "IsRegister");
		Register_IsRegister_Offset = NativeReflectionCached.GetPropertyOffset(Register_FunctionAddress, "IsRegister");
		Register_IsRegister_IsValid = NativeReflectionCached.ValidatePropertyClass(Register_FunctionAddress, "IsRegister", Classes.FBoolProperty);
		Register_IsValid = Register_FunctionAddress != IntPtr.Zero && Register_Observer_IsValid && Register_IsRegister_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDisplayDebug.GSDisplayDebugObserver:Register", Register_IsValid);
		GetDisplayDebugNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayDebugNames");
		GetDisplayDebugNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayDebugNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayDebugNames_ReturnValue_PropertyAddress, GetDisplayDebugNames_FunctionAddress, "ReturnValue");
		GetDisplayDebugNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayDebugNames_FunctionAddress, "ReturnValue");
		GetDisplayDebugNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayDebugNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDisplayDebugNames_IsValid = GetDisplayDebugNames_FunctionAddress != IntPtr.Zero && GetDisplayDebugNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDisplayDebug.GSDisplayDebugObserver:GetDisplayDebugNames", GetDisplayDebugNames_IsValid);
		FetchDebugInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FetchDebugInfo");
		FetchDebugInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchDebugInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FetchDebugInfo_Name_PropertyAddress, FetchDebugInfo_FunctionAddress, "Name");
		FetchDebugInfo_Name_Offset = NativeReflectionCached.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "Name");
		FetchDebugInfo_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FetchDebugInfo_DebugInfos_PropertyAddress, FetchDebugInfo_FunctionAddress, "DebugInfos");
		FetchDebugInfo_DebugInfos_Offset = NativeReflectionCached.GetPropertyOffset(FetchDebugInfo_FunctionAddress, "DebugInfos");
		FetchDebugInfo_DebugInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchDebugInfo_FunctionAddress, "DebugInfos", Classes.FArrayProperty);
		FetchDebugInfo_IsValid = FetchDebugInfo_FunctionAddress != IntPtr.Zero && FetchDebugInfo_Name_IsValid && FetchDebugInfo_DebugInfos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDisplayDebug.GSDisplayDebugObserver:FetchDebugInfo", FetchDebugInfo_IsValid);
	}
}
