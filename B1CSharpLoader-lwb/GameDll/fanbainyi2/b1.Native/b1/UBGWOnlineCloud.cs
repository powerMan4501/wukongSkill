using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineCloud", "b1", UnrealModuleType.Game)]
public class UBGWOnlineCloud : UBGWOnlineInterface
{
	private static bool WriteUserFile_IsValid;

	private static IntPtr WriteUserFile_FunctionAddress;

	private static int WriteUserFile_ParamsSize;

	private static bool WriteUserFile_FileName_IsValid;

	private static FFieldAddress WriteUserFile_FileName_PropertyAddress;

	private static int WriteUserFile_FileName_Offset;

	private static bool WriteUserFile_userData_IsValid;

	private static FFieldAddress WriteUserFile_userData_PropertyAddress;

	private static int WriteUserFile_userData_Offset;

	private static bool ReadUserFile_IsValid;

	private static IntPtr ReadUserFile_FunctionAddress;

	private static int ReadUserFile_ParamsSize;

	private static bool ReadUserFile_FileName_IsValid;

	private static FFieldAddress ReadUserFile_FileName_PropertyAddress;

	private static int ReadUserFile_FileName_Offset;

	private static bool ReadUserFile_ReturnValue_IsValid;

	private static FFieldAddress ReadUserFile_ReturnValue_PropertyAddress;

	private static int ReadUserFile_ReturnValue_Offset;

	private static bool ReadAllUserFiles_IsValid;

	private static IntPtr ReadAllUserFiles_FunctionAddress;

	private static int ReadAllUserFiles_ParamsSize;

	private static bool ReadAllUserFiles_ReturnValue_IsValid;

	private static FFieldAddress ReadAllUserFiles_ReturnValue_PropertyAddress;

	private static int ReadAllUserFiles_ReturnValue_Offset;

	private static bool OnWriteUserCloudFileCompleteCS_IsValid;

	private IntPtr OnWriteUserCloudFileCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnWriteUserCloudFileCompleteCS_FunctionAddress;

	private static int OnWriteUserCloudFileCompleteCS_ParamsSize;

	private static bool OnWriteUserCloudFileCompleteCS_FileName_IsValid;

	private static FFieldAddress OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress;

	private static int OnWriteUserCloudFileCompleteCS_FileName_Offset;

	private static bool OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset;

	private static bool OnReadUserFilesCompleteCS_IsValid;

	private IntPtr OnReadUserFilesCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnReadUserFilesCompleteCS_FunctionAddress;

	private static int OnReadUserFilesCompleteCS_ParamsSize;

	private static bool OnReadUserFilesCompleteCS_FileName_IsValid;

	private static FFieldAddress OnReadUserFilesCompleteCS_FileName_PropertyAddress;

	private static int OnReadUserFilesCompleteCS_FileName_Offset;

	private static bool OnReadUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnReadUserFilesCompleteCS_bWasSuccessful_Offset;

	private static bool OnEnumerateUserFilesCompleteCS_IsValid;

	private IntPtr OnEnumerateUserFilesCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnEnumerateUserFilesCompleteCS_FunctionAddress;

	private static int OnEnumerateUserFilesCompleteCS_ParamsSize;

	private static bool OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset;

	private static bool OnDeleteUserFilesCompleteCS_IsValid;

	private IntPtr OnDeleteUserFilesCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnDeleteUserFilesCompleteCS_FunctionAddress;

	private static int OnDeleteUserFilesCompleteCS_ParamsSize;

	private static bool OnDeleteUserFilesCompleteCS_FileName_IsValid;

	private static FFieldAddress OnDeleteUserFilesCompleteCS_FileName_PropertyAddress;

	private static int OnDeleteUserFilesCompleteCS_FileName_Offset;

	private static bool OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool EnumerateUserFiles_IsValid;

	private static IntPtr EnumerateUserFiles_FunctionAddress;

	private static int EnumerateUserFiles_ParamsSize;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	private static bool DeleteUserFile_IsValid;

	private static IntPtr DeleteUserFile_FunctionAddress;

	private static int DeleteUserFile_ParamsSize;

	private static bool DeleteUserFile_fileName_IsValid;

	private static FFieldAddress DeleteUserFile_fileName_PropertyAddress;

	private static int DeleteUserFile_fileName_Offset;

	private static bool DeleteUserFile_bCloudDelete_IsValid;

	private static FFieldAddress DeleteUserFile_bCloudDelete_PropertyAddress;

	private static int DeleteUserFile_bCloudDelete_Offset;

	private static bool DeleteUserFile_bLocalDelete_IsValid;

	private static FFieldAddress DeleteUserFile_bLocalDelete_PropertyAddress;

	private static int DeleteUserFile_bLocalDelete_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:WriteUserFile")]
	public unsafe void WriteUserFile(string FileName, List<byte> userData)
	{
		CheckDestroyed();
		if (!WriteUserFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:WriteUserFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteUserFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteUserFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteUserFile_FileName_Offset), 0, WriteUserFile_FileName_PropertyAddress.Address, FileName);
		new TArrayCopyMarshaler<byte>(1, WriteUserFile_userData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, WriteUserFile_userData_Offset), userData);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteUserFile_FunctionAddress, intPtr, WriteUserFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteUserFile_FileName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(WriteUserFile_userData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:ReadUserFile")]
	public unsafe bool ReadUserFile(string FileName)
	{
		CheckDestroyed();
		if (!ReadUserFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:ReadUserFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadUserFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadUserFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReadUserFile_FileName_Offset), 0, ReadUserFile_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadUserFile_FunctionAddress, intPtr, ReadUserFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReadUserFile_FileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadUserFile_ReturnValue_Offset), 0, ReadUserFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:ReadAllUserFiles")]
	public unsafe bool ReadAllUserFiles()
	{
		CheckDestroyed();
		if (!ReadAllUserFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:ReadAllUserFiles");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadAllUserFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadAllUserFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadAllUserFiles_FunctionAddress, intPtr, ReadAllUserFiles_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadAllUserFiles_ReturnValue_Offset), 0, ReadAllUserFiles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:OnWriteUserCloudFileCompleteCS")]
	protected unsafe void OnWriteUserCloudFileCompleteCS(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnWriteUserCloudFileCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnWriteUserCloudFileCompleteCS");
			return;
		}
		if (OnWriteUserCloudFileCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWriteUserCloudFileCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWriteUserCloudFileCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWriteUserCloudFileCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWriteUserCloudFileCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnWriteUserCloudFileCompleteCS_FileName_Offset), 0, OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset), 0, OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWriteUserCloudFileCompleteCS_InstanceFunctionAddress, intPtr, OnWriteUserCloudFileCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnWriteUserCloudFileCompleteCS_Implementation(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnWriteUserCloudFileCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnWriteUserCloudFileCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWriteUserCloudFileCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWriteUserCloudFileCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnWriteUserCloudFileCompleteCS_FileName_Offset), 0, OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset), 0, OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWriteUserCloudFileCompleteCS_FunctionAddress, intPtr, OnWriteUserCloudFileCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:OnReadUserFilesCompleteCS")]
	protected unsafe void OnReadUserFilesCompleteCS(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnReadUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnReadUserFilesCompleteCS");
			return;
		}
		if (OnReadUserFilesCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReadUserFilesCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReadUserFilesCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReadUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReadUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnReadUserFilesCompleteCS_FileName_Offset), 0, OnReadUserFilesCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReadUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReadUserFilesCompleteCS_InstanceFunctionAddress, intPtr, OnReadUserFilesCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnReadUserFilesCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnReadUserFilesCompleteCS_Implementation(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnReadUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnReadUserFilesCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReadUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReadUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnReadUserFilesCompleteCS_FileName_Offset), 0, OnReadUserFilesCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReadUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReadUserFilesCompleteCS_FunctionAddress, intPtr, OnReadUserFilesCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnReadUserFilesCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:OnEnumerateUserFilesCompleteCS")]
	protected unsafe void OnEnumerateUserFilesCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnEnumerateUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnEnumerateUserFilesCompleteCS");
			return;
		}
		if (OnEnumerateUserFilesCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEnumerateUserFilesCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnumerateUserFilesCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEnumerateUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEnumerateUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEnumerateUserFilesCompleteCS_InstanceFunctionAddress, intPtr, OnEnumerateUserFilesCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnEnumerateUserFilesCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnEnumerateUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnEnumerateUserFilesCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEnumerateUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEnumerateUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEnumerateUserFilesCompleteCS_FunctionAddress, intPtr, OnEnumerateUserFilesCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:OnDeleteUserFilesCompleteCS")]
	protected unsafe void OnDeleteUserFilesCompleteCS(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnDeleteUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnDeleteUserFilesCompleteCS");
			return;
		}
		if (OnDeleteUserFilesCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDeleteUserFilesCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDeleteUserFilesCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDeleteUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDeleteUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnDeleteUserFilesCompleteCS_FileName_Offset), 0, OnDeleteUserFilesCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDeleteUserFilesCompleteCS_InstanceFunctionAddress, intPtr, OnDeleteUserFilesCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDeleteUserFilesCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnDeleteUserFilesCompleteCS_Implementation(string FileName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnDeleteUserFilesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:OnDeleteUserFilesCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDeleteUserFilesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDeleteUserFilesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnDeleteUserFilesCompleteCS_FileName_Offset), 0, OnDeleteUserFilesCompleteCS_FileName_PropertyAddress.Address, FileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDeleteUserFilesCompleteCS_FunctionAddress, intPtr, OnDeleteUserFilesCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDeleteUserFilesCompleteCS_FileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:Init");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Init_ReturnValue_Offset), 0, Init_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:EnumerateUserFiles")]
	public unsafe void EnumerateUserFiles()
	{
		CheckDestroyed();
		if (!EnumerateUserFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:EnumerateUserFiles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnumerateUserFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnumerateUserFiles_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnumerateUserFiles_FunctionAddress, argsSize: EnumerateUserFiles_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineCloud:DeleteUserFile")]
	public unsafe void DeleteUserFile(string fileName, bool bCloudDelete, bool bLocalDelete)
	{
		CheckDestroyed();
		if (!DeleteUserFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineCloud:DeleteUserFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteUserFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteUserFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteUserFile_fileName_Offset), 0, DeleteUserFile_fileName_PropertyAddress.Address, fileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteUserFile_bCloudDelete_Offset), 0, DeleteUserFile_bCloudDelete_PropertyAddress.Address, bCloudDelete);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteUserFile_bLocalDelete_Offset), 0, DeleteUserFile_bLocalDelete_PropertyAddress.Address, bLocalDelete);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteUserFile_FunctionAddress, intPtr, DeleteUserFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteUserFile_fileName_PropertyAddress.Address, intPtr);
	}

	static UBGWOnlineCloud()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineCloud)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineCloud));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlineCloud");
		WriteUserFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteUserFile");
		WriteUserFile_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteUserFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteUserFile_FileName_PropertyAddress, WriteUserFile_FunctionAddress, "FileName");
		WriteUserFile_FileName_Offset = NativeReflectionCached.GetPropertyOffset(WriteUserFile_FunctionAddress, "FileName");
		WriteUserFile_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteUserFile_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteUserFile_userData_PropertyAddress, WriteUserFile_FunctionAddress, "userData");
		WriteUserFile_userData_Offset = NativeReflectionCached.GetPropertyOffset(WriteUserFile_FunctionAddress, "userData");
		WriteUserFile_userData_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteUserFile_FunctionAddress, "userData", Classes.FArrayProperty);
		WriteUserFile_IsValid = WriteUserFile_FunctionAddress != IntPtr.Zero && WriteUserFile_FileName_IsValid && WriteUserFile_userData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:WriteUserFile", WriteUserFile_IsValid);
		ReadUserFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadUserFile");
		ReadUserFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadUserFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadUserFile_FileName_PropertyAddress, ReadUserFile_FunctionAddress, "FileName");
		ReadUserFile_FileName_Offset = NativeReflectionCached.GetPropertyOffset(ReadUserFile_FunctionAddress, "FileName");
		ReadUserFile_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadUserFile_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadUserFile_ReturnValue_PropertyAddress, ReadUserFile_FunctionAddress, "ReturnValue");
		ReadUserFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadUserFile_FunctionAddress, "ReturnValue");
		ReadUserFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadUserFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadUserFile_IsValid = ReadUserFile_FunctionAddress != IntPtr.Zero && ReadUserFile_FileName_IsValid && ReadUserFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:ReadUserFile", ReadUserFile_IsValid);
		ReadAllUserFiles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadAllUserFiles");
		ReadAllUserFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadAllUserFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadAllUserFiles_ReturnValue_PropertyAddress, ReadAllUserFiles_FunctionAddress, "ReturnValue");
		ReadAllUserFiles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadAllUserFiles_FunctionAddress, "ReturnValue");
		ReadAllUserFiles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadAllUserFiles_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadAllUserFiles_IsValid = ReadAllUserFiles_FunctionAddress != IntPtr.Zero && ReadAllUserFiles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:ReadAllUserFiles", ReadAllUserFiles_IsValid);
		OnWriteUserCloudFileCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWriteUserCloudFileCompleteCS");
		OnWriteUserCloudFileCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWriteUserCloudFileCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWriteUserCloudFileCompleteCS_FileName_PropertyAddress, OnWriteUserCloudFileCompleteCS_FunctionAddress, "FileName");
		OnWriteUserCloudFileCompleteCS_FileName_Offset = NativeReflectionCached.GetPropertyOffset(OnWriteUserCloudFileCompleteCS_FunctionAddress, "FileName");
		OnWriteUserCloudFileCompleteCS_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWriteUserCloudFileCompleteCS_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress, OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful");
		OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful");
		OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnWriteUserCloudFileCompleteCS_IsValid = OnWriteUserCloudFileCompleteCS_FunctionAddress != IntPtr.Zero && OnWriteUserCloudFileCompleteCS_FileName_IsValid && OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:OnWriteUserCloudFileCompleteCS", OnWriteUserCloudFileCompleteCS_IsValid);
		OnReadUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReadUserFilesCompleteCS");
		OnReadUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReadUserFilesCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReadUserFilesCompleteCS_FileName_PropertyAddress, OnReadUserFilesCompleteCS_FunctionAddress, "FileName");
		OnReadUserFilesCompleteCS_FileName_Offset = NativeReflectionCached.GetPropertyOffset(OnReadUserFilesCompleteCS_FunctionAddress, "FileName");
		OnReadUserFilesCompleteCS_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReadUserFilesCompleteCS_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnReadUserFilesCompleteCS_IsValid = OnReadUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnReadUserFilesCompleteCS_FileName_IsValid && OnReadUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:OnReadUserFilesCompleteCS", OnReadUserFilesCompleteCS_IsValid);
		OnEnumerateUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEnumerateUserFilesCompleteCS");
		OnEnumerateUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnumerateUserFilesCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnEnumerateUserFilesCompleteCS_IsValid = OnEnumerateUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:OnEnumerateUserFilesCompleteCS", OnEnumerateUserFilesCompleteCS_IsValid);
		OnDeleteUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDeleteUserFilesCompleteCS");
		OnDeleteUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDeleteUserFilesCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDeleteUserFilesCompleteCS_FileName_PropertyAddress, OnDeleteUserFilesCompleteCS_FunctionAddress, "FileName");
		OnDeleteUserFilesCompleteCS_FileName_Offset = NativeReflectionCached.GetPropertyOffset(OnDeleteUserFilesCompleteCS_FunctionAddress, "FileName");
		OnDeleteUserFilesCompleteCS_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDeleteUserFilesCompleteCS_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnDeleteUserFilesCompleteCS_IsValid = OnDeleteUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnDeleteUserFilesCompleteCS_FileName_IsValid && OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:OnDeleteUserFilesCompleteCS", OnDeleteUserFilesCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:Init", Init_IsValid);
		EnumerateUserFiles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnumerateUserFiles");
		EnumerateUserFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(EnumerateUserFiles_FunctionAddress);
		EnumerateUserFiles_IsValid = EnumerateUserFiles_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:EnumerateUserFiles", EnumerateUserFiles_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:Destroy", Destroy_IsValid);
		DeleteUserFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteUserFile");
		DeleteUserFile_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteUserFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteUserFile_fileName_PropertyAddress, DeleteUserFile_FunctionAddress, "fileName");
		DeleteUserFile_fileName_Offset = NativeReflectionCached.GetPropertyOffset(DeleteUserFile_FunctionAddress, "fileName");
		DeleteUserFile_fileName_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteUserFile_FunctionAddress, "fileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteUserFile_bCloudDelete_PropertyAddress, DeleteUserFile_FunctionAddress, "bCloudDelete");
		DeleteUserFile_bCloudDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteUserFile_FunctionAddress, "bCloudDelete");
		DeleteUserFile_bCloudDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteUserFile_FunctionAddress, "bCloudDelete", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteUserFile_bLocalDelete_PropertyAddress, DeleteUserFile_FunctionAddress, "bLocalDelete");
		DeleteUserFile_bLocalDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteUserFile_FunctionAddress, "bLocalDelete");
		DeleteUserFile_bLocalDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteUserFile_FunctionAddress, "bLocalDelete", Classes.FBoolProperty);
		DeleteUserFile_IsValid = DeleteUserFile_FunctionAddress != IntPtr.Zero && DeleteUserFile_fileName_IsValid && DeleteUserFile_bCloudDelete_IsValid && DeleteUserFile_bLocalDelete_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineCloud:DeleteUserFile", DeleteUserFile_IsValid);
	}
}
