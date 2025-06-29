using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineAchievement", "b1", UnrealModuleType.Game)]
public class UBGWOnlineAchievement : UBGWOnlineInterface
{
	private static bool WriteAchievement_IsValid;

	private static IntPtr WriteAchievement_FunctionAddress;

	private static int WriteAchievement_ParamsSize;

	private static bool WriteAchievement_writeObjKey_IsValid;

	private static FFieldAddress WriteAchievement_writeObjKey_PropertyAddress;

	private static int WriteAchievement_writeObjKey_Offset;

	private static bool WriteAchievement_writeObjValue_IsValid;

	private static FFieldAddress WriteAchievement_writeObjValue_PropertyAddress;

	private static int WriteAchievement_writeObjValue_Offset;

	private static bool UpdateStat_IsValid;

	private static IntPtr UpdateStat_FunctionAddress;

	private static int UpdateStat_ParamsSize;

	private static bool UpdateStat_statName_IsValid;

	private static FFieldAddress UpdateStat_statName_PropertyAddress;

	private static int UpdateStat_statName_Offset;

	private static bool UpdateStat_statValue_IsValid;

	private static FFieldAddress UpdateStat_statValue_PropertyAddress;

	private static int UpdateStat_statValue_Offset;

	private static bool ReadAchievements_IsValid;

	private static IntPtr ReadAchievements_FunctionAddress;

	private static int ReadAchievements_ParamsSize;

	private static bool OnStatUpdatedCompleteCS_IsValid;

	private IntPtr OnStatUpdatedCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnStatUpdatedCompleteCS_FunctionAddress;

	private static int OnStatUpdatedCompleteCS_ParamsSize;

	private static bool OnStatUpdatedCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnStatUpdatedCompleteCS_bWasSuccessful_Offset;

	private static bool OnQueryAchievementsCompleteCS_IsValid;

	private IntPtr OnQueryAchievementsCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnQueryAchievementsCompleteCS_FunctionAddress;

	private static int OnQueryAchievementsCompleteCS_ParamsSize;

	private static bool OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnQueryAchievementsCompleteCS_bWasSuccessful_Offset;

	private static bool OnAchievementsWrittenCompleteCS_IsValid;

	private IntPtr OnAchievementsWrittenCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnAchievementsWrittenCompleteCS_FunctionAddress;

	private static int OnAchievementsWrittenCompleteCS_ParamsSize;

	private static bool OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool GetAllAchievements_IsValid;

	private static IntPtr GetAllAchievements_FunctionAddress;

	private static int GetAllAchievements_ParamsSize;

	private static bool GetAllAchievements_outAchievements_IsValid;

	private static FFieldAddress GetAllAchievements_outAchievements_PropertyAddress;

	private static int GetAllAchievements_outAchievements_Offset;

	private static bool GetAllAchievements_ReturnValue_IsValid;

	private static FFieldAddress GetAllAchievements_ReturnValue_PropertyAddress;

	private static int GetAllAchievements_ReturnValue_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:WriteAchievement")]
	public unsafe void WriteAchievement(string writeObjKey, double writeObjValue)
	{
		CheckDestroyed();
		if (!WriteAchievement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:WriteAchievement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteAchievement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteAchievement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteAchievement_writeObjKey_Offset), 0, WriteAchievement_writeObjKey_PropertyAddress.Address, writeObjKey);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, WriteAchievement_writeObjValue_Offset), 0, WriteAchievement_writeObjValue_PropertyAddress.Address, writeObjValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteAchievement_FunctionAddress, intPtr, WriteAchievement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteAchievement_writeObjKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:UpdateStat")]
	public unsafe void UpdateStat(string statName, int statValue)
	{
		CheckDestroyed();
		if (!UpdateStat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:UpdateStat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateStat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateStat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateStat_statName_Offset), 0, UpdateStat_statName_PropertyAddress.Address, statName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateStat_statValue_Offset), 0, UpdateStat_statValue_PropertyAddress.Address, statValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateStat_FunctionAddress, intPtr, UpdateStat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateStat_statName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:ReadAchievements")]
	public unsafe void ReadAchievements()
	{
		CheckDestroyed();
		if (!ReadAchievements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:ReadAchievements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadAchievements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadAchievements_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReadAchievements_FunctionAddress, argsSize: ReadAchievements_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:OnStatUpdatedCompleteCS")]
	protected unsafe void OnStatUpdatedCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStatUpdatedCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnStatUpdatedCompleteCS");
			return;
		}
		if (OnStatUpdatedCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnStatUpdatedCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnStatUpdatedCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStatUpdatedCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStatUpdatedCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStatUpdatedCompleteCS_bWasSuccessful_Offset), 0, OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStatUpdatedCompleteCS_InstanceFunctionAddress, intPtr, OnStatUpdatedCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnStatUpdatedCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStatUpdatedCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnStatUpdatedCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStatUpdatedCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStatUpdatedCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStatUpdatedCompleteCS_bWasSuccessful_Offset), 0, OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStatUpdatedCompleteCS_FunctionAddress, intPtr, OnStatUpdatedCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:OnQueryAchievementsCompleteCS")]
	protected unsafe void OnQueryAchievementsCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnQueryAchievementsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnQueryAchievementsCompleteCS");
			return;
		}
		if (OnQueryAchievementsCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnQueryAchievementsCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnQueryAchievementsCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnQueryAchievementsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQueryAchievementsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryAchievementsCompleteCS_bWasSuccessful_Offset), 0, OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnQueryAchievementsCompleteCS_InstanceFunctionAddress, intPtr, OnQueryAchievementsCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnQueryAchievementsCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnQueryAchievementsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnQueryAchievementsCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnQueryAchievementsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQueryAchievementsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryAchievementsCompleteCS_bWasSuccessful_Offset), 0, OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnQueryAchievementsCompleteCS_FunctionAddress, intPtr, OnQueryAchievementsCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:OnAchievementsWrittenCompleteCS")]
	protected unsafe void OnAchievementsWrittenCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnAchievementsWrittenCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnAchievementsWrittenCompleteCS");
			return;
		}
		if (OnAchievementsWrittenCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAchievementsWrittenCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAchievementsWrittenCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAchievementsWrittenCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAchievementsWrittenCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset), 0, OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAchievementsWrittenCompleteCS_InstanceFunctionAddress, intPtr, OnAchievementsWrittenCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnAchievementsWrittenCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnAchievementsWrittenCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:OnAchievementsWrittenCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAchievementsWrittenCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAchievementsWrittenCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset), 0, OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAchievementsWrittenCompleteCS_FunctionAddress, intPtr, OnAchievementsWrittenCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:Init");
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

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:GetAllAchievements")]
	protected unsafe bool GetAllAchievements(out List<FBGWOnlineAchievementTag> outAchievements)
	{
		CheckDestroyed();
		if (!GetAllAchievements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:GetAllAchievements");
			outAchievements = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAchievements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAchievements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllAchievements_FunctionAddress, intPtr, GetAllAchievements_ParamsSize);
		outAchievements = new TArrayCopyMarshaler<FBGWOnlineAchievementTag>(1, GetAllAchievements_outAchievements_PropertyAddress, CachedMarshalingDelegates<FBGWOnlineAchievementTag, FBGWOnlineAchievementTag>.FromNative, CachedMarshalingDelegates<FBGWOnlineAchievementTag, FBGWOnlineAchievementTag>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAchievements_outAchievements_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAchievements_outAchievements_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllAchievements_ReturnValue_Offset), 0, GetAllAchievements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineAchievement:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineAchievement:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWOnlineAchievement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineAchievement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineAchievement));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlineAchievement");
		WriteAchievement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteAchievement");
		WriteAchievement_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteAchievement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteAchievement_writeObjKey_PropertyAddress, WriteAchievement_FunctionAddress, "writeObjKey");
		WriteAchievement_writeObjKey_Offset = NativeReflectionCached.GetPropertyOffset(WriteAchievement_FunctionAddress, "writeObjKey");
		WriteAchievement_writeObjKey_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteAchievement_FunctionAddress, "writeObjKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteAchievement_writeObjValue_PropertyAddress, WriteAchievement_FunctionAddress, "writeObjValue");
		WriteAchievement_writeObjValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteAchievement_FunctionAddress, "writeObjValue");
		WriteAchievement_writeObjValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteAchievement_FunctionAddress, "writeObjValue", Classes.FDoubleProperty);
		WriteAchievement_IsValid = WriteAchievement_FunctionAddress != IntPtr.Zero && WriteAchievement_writeObjKey_IsValid && WriteAchievement_writeObjValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:WriteAchievement", WriteAchievement_IsValid);
		UpdateStat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateStat");
		UpdateStat_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateStat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateStat_statName_PropertyAddress, UpdateStat_FunctionAddress, "statName");
		UpdateStat_statName_Offset = NativeReflectionCached.GetPropertyOffset(UpdateStat_FunctionAddress, "statName");
		UpdateStat_statName_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateStat_FunctionAddress, "statName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateStat_statValue_PropertyAddress, UpdateStat_FunctionAddress, "statValue");
		UpdateStat_statValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateStat_FunctionAddress, "statValue");
		UpdateStat_statValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateStat_FunctionAddress, "statValue", Classes.FIntProperty);
		UpdateStat_IsValid = UpdateStat_FunctionAddress != IntPtr.Zero && UpdateStat_statName_IsValid && UpdateStat_statValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:UpdateStat", UpdateStat_IsValid);
		ReadAchievements_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadAchievements");
		ReadAchievements_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadAchievements_FunctionAddress);
		ReadAchievements_IsValid = ReadAchievements_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:ReadAchievements", ReadAchievements_IsValid);
		OnStatUpdatedCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStatUpdatedCompleteCS");
		OnStatUpdatedCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStatUpdatedCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress, OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStatUpdatedCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStatUpdatedCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnStatUpdatedCompleteCS_IsValid = OnStatUpdatedCompleteCS_FunctionAddress != IntPtr.Zero && OnStatUpdatedCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:OnStatUpdatedCompleteCS", OnStatUpdatedCompleteCS_IsValid);
		OnQueryAchievementsCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnQueryAchievementsCompleteCS");
		OnQueryAchievementsCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQueryAchievementsCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress, OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryAchievementsCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnQueryAchievementsCompleteCS_IsValid = OnQueryAchievementsCompleteCS_FunctionAddress != IntPtr.Zero && OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:OnQueryAchievementsCompleteCS", OnQueryAchievementsCompleteCS_IsValid);
		OnAchievementsWrittenCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAchievementsWrittenCompleteCS");
		OnAchievementsWrittenCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAchievementsWrittenCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress, OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful");
		OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful");
		OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnAchievementsWrittenCompleteCS_IsValid = OnAchievementsWrittenCompleteCS_FunctionAddress != IntPtr.Zero && OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:OnAchievementsWrittenCompleteCS", OnAchievementsWrittenCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:Init", Init_IsValid);
		GetAllAchievements_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllAchievements");
		GetAllAchievements_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAchievements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAchievements_outAchievements_PropertyAddress, GetAllAchievements_FunctionAddress, "outAchievements");
		GetAllAchievements_outAchievements_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAchievements_FunctionAddress, "outAchievements");
		GetAllAchievements_outAchievements_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAchievements_FunctionAddress, "outAchievements", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAchievements_ReturnValue_PropertyAddress, GetAllAchievements_FunctionAddress, "ReturnValue");
		GetAllAchievements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAchievements_FunctionAddress, "ReturnValue");
		GetAllAchievements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAchievements_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllAchievements_IsValid = GetAllAchievements_FunctionAddress != IntPtr.Zero && GetAllAchievements_outAchievements_IsValid && GetAllAchievements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:GetAllAchievements", GetAllAchievements_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineAchievement:Destroy", Destroy_IsValid);
	}
}
