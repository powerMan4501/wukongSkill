using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.ActorCompContainer", "b1", UnrealModuleType.Game)]
public class UActorCompContainer : UActorComponent
{
	private static bool SetTeamID_IsValid;

	private static IntPtr SetTeamID_FunctionAddress;

	private static int SetTeamID_ParamsSize;

	private static bool SetTeamID_ID_IsValid;

	private static FFieldAddress SetTeamID_ID_PropertyAddress;

	private static int SetTeamID_ID_Offset;

	private static bool FillEventCollection_IsValid;

	private static IntPtr FillEventCollection_FunctionAddress;

	private static int FillEventCollection_ParamsSize;

	private static bool FillEventCollection_DataObj_IsValid;

	private static FFieldAddress FillEventCollection_DataObj_PropertyAddress;

	private static int FillEventCollection_DataObj_Offset;

	private static bool FillDataContainer_IsValid;

	private static IntPtr FillDataContainer_FunctionAddress;

	private static int FillDataContainer_ParamsSize;

	private static bool FillDataContainer_DataObj_IsValid;

	private static FFieldAddress FillDataContainer_DataObj_PropertyAddress;

	private static int FillDataContainer_DataObj_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.ActorCompContainer:SetTeamID")]
	public unsafe void SetTeamID(int ID)
	{
		CheckDestroyed();
		if (!SetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorCompContainer:SetTeamID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTeamID_ID_Offset), 0, SetTeamID_ID_PropertyAddress.Address, ID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTeamID_FunctionAddress, intPtr, SetTeamID_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.ActorCompContainer:FillEventCollection")]
	public unsafe void FillEventCollection(UObject DataObj)
	{
		CheckDestroyed();
		if (!FillEventCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorCompContainer:FillEventCollection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillEventCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillEventCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FillEventCollection_DataObj_Offset), 0, FillEventCollection_DataObj_PropertyAddress.Address, DataObj);
		NativeReflection.InvokeFunctionOptimized(base.Address, FillEventCollection_FunctionAddress, intPtr, FillEventCollection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.ActorCompContainer:FillDataContainer")]
	public unsafe void FillDataContainer(UActorDataContainer DataObj)
	{
		CheckDestroyed();
		if (!FillDataContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorCompContainer:FillDataContainer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillDataContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillDataContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(intPtr, FillDataContainer_DataObj_Offset), 0, FillDataContainer_DataObj_PropertyAddress.Address, DataObj);
		NativeReflection.InvokeFunctionOptimized(base.Address, FillDataContainer_FunctionAddress, intPtr, FillDataContainer_ParamsSize);
	}

	static UActorCompContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UActorCompContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorCompContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.ActorCompContainer");
		SetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTeamID");
		SetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTeamID_ID_PropertyAddress, SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_Offset = NativeReflectionCached.GetPropertyOffset(SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTeamID_FunctionAddress, "ID", Classes.FIntProperty);
		SetTeamID_IsValid = SetTeamID_FunctionAddress != IntPtr.Zero && SetTeamID_ID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorCompContainer:SetTeamID", SetTeamID_IsValid);
		FillEventCollection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FillEventCollection");
		FillEventCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(FillEventCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillEventCollection_DataObj_PropertyAddress, FillEventCollection_FunctionAddress, "DataObj");
		FillEventCollection_DataObj_Offset = NativeReflectionCached.GetPropertyOffset(FillEventCollection_FunctionAddress, "DataObj");
		FillEventCollection_DataObj_IsValid = NativeReflectionCached.ValidatePropertyClass(FillEventCollection_FunctionAddress, "DataObj", Classes.FObjectProperty);
		FillEventCollection_IsValid = FillEventCollection_FunctionAddress != IntPtr.Zero && FillEventCollection_DataObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorCompContainer:FillEventCollection", FillEventCollection_IsValid);
		FillDataContainer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FillDataContainer");
		FillDataContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(FillDataContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillDataContainer_DataObj_PropertyAddress, FillDataContainer_FunctionAddress, "DataObj");
		FillDataContainer_DataObj_Offset = NativeReflectionCached.GetPropertyOffset(FillDataContainer_FunctionAddress, "DataObj");
		FillDataContainer_DataObj_IsValid = NativeReflectionCached.ValidatePropertyClass(FillDataContainer_FunctionAddress, "DataObj", Classes.FObjectProperty);
		FillDataContainer_IsValid = FillDataContainer_FunctionAddress != IntPtr.Zero && FillDataContainer_DataObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorCompContainer:FillDataContainer", FillDataContainer_IsValid);
	}
}
