using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public sealed class ISmartActorGuidObjImpl : IInterfaceImpl, ISmartActorGuidObj, IInterface
{
	private static bool GetActorGuidOptions_IsValid;

	private IntPtr GetActorGuidOptions_InstanceFunctionAddress;

	private static IntPtr GetActorGuidOptions_FunctionAddress;

	private static int GetActorGuidOptions_ParamsSize;

	private static bool GetActorGuidOptions_PropertyName_IsValid;

	private static FFieldAddress GetActorGuidOptions_PropertyName_PropertyAddress;

	private static int GetActorGuidOptions_PropertyName_Offset;

	private static bool GetActorGuidOptions_OutOptions_IsValid;

	private static FFieldAddress GetActorGuidOptions_OutOptions_PropertyAddress;

	private static int GetActorGuidOptions_OutOptions_Offset;

	private static bool GetActorGuidOptions_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuidOptions_ReturnValue_PropertyAddress;

	private static int GetActorGuidOptions_ReturnValue_Offset;

	private static bool GetActorGuid_IsValid;

	private IntPtr GetActorGuid_InstanceFunctionAddress;

	private static IntPtr GetActorGuid_FunctionAddress;

	private static int GetActorGuid_ParamsSize;

	private static bool GetActorGuid_InActor_IsValid;

	private static FFieldAddress GetActorGuid_InActor_PropertyAddress;

	private static int GetActorGuid_InActor_Offset;

	private static bool GetActorGuid_OutActorGuid_IsValid;

	private static FFieldAddress GetActorGuid_OutActorGuid_PropertyAddress;

	private static int GetActorGuid_OutActorGuid_Offset;

	private static bool GetActorGuid_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuid_ReturnValue_PropertyAddress;

	private static int GetActorGuid_ReturnValue_Offset;

	private static bool CanManageStates_IsValid;

	private IntPtr CanManageStates_InstanceFunctionAddress;

	private static IntPtr CanManageStates_FunctionAddress;

	private static int CanManageStates_ParamsSize;

	private static bool CanManageStates_ReturnValue_IsValid;

	private static FFieldAddress CanManageStates_ReturnValue_PropertyAddress;

	private static int CanManageStates_ReturnValue_Offset;

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:GetActorGuidOptions")]
	public unsafe int GetActorGuidOptions(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		CheckDestroyed();
		if (!GetActorGuidOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SmartActorGuidObj:GetActorGuidOptions");
			OutOptions = null;
			return 0;
		}
		if (GetActorGuidOptions_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorGuidOptions_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuidOptions");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuidOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuidOptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorGuidOptions_PropertyName_Offset), 0, GetActorGuidOptions_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuidOptions_InstanceFunctionAddress, intPtr, GetActorGuidOptions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_PropertyName_PropertyAddress.Address, intPtr);
		OutOptions = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_OutOptions_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_OutOptions_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_ReturnValue_Offset), 0, GetActorGuidOptions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:GetActorGuid")]
	public unsafe bool GetActorGuid(AActor InActor, out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SmartActorGuidObj:GetActorGuid");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		if (GetActorGuid_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorGuid_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuid");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorGuid_InActor_Offset), 0, GetActorGuid_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuid_InstanceFunctionAddress, intPtr, GetActorGuid_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_OutActorGuid_Offset), 0, GetActorGuid_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/b1.SmartActorGuidObj:CanManageStates")]
	public unsafe bool CanManageStates()
	{
		CheckDestroyed();
		if (!CanManageStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.SmartActorGuidObj:CanManageStates");
			return false;
		}
		if (CanManageStates_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanManageStates_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanManageStates");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanManageStates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanManageStates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanManageStates_InstanceFunctionAddress, intPtr, CanManageStates_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetActorGuidOptions_InstanceFunctionAddress = IntPtr.Zero;
		GetActorGuid_InstanceFunctionAddress = IntPtr.Zero;
		CanManageStates_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ISmartActorGuidObjImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISmartActorGuidObjImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISmartActorGuidObjImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.SmartActorGuidObj");
		GetActorGuidOptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuidOptions");
		GetActorGuidOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidOptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidOptions_PropertyName_PropertyAddress, GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidOptions_OutOptions_PropertyAddress, GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "OutOptions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidOptions_ReturnValue_PropertyAddress, GetActorGuidOptions_FunctionAddress, "ReturnValue");
		GetActorGuidOptions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "ReturnValue");
		GetActorGuidOptions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActorGuidOptions_IsValid = GetActorGuidOptions_FunctionAddress != IntPtr.Zero && GetActorGuidOptions_PropertyName_IsValid && GetActorGuidOptions_OutOptions_IsValid && GetActorGuidOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.SmartActorGuidObj:GetActorGuidOptions", GetActorGuidOptions_IsValid);
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_InActor_PropertyAddress, GetActorGuid_FunctionAddress, "InActor");
		GetActorGuid_InActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "InActor");
		GetActorGuid_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_InActor_IsValid && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.SmartActorGuidObj:GetActorGuid", GetActorGuid_IsValid);
		CanManageStates_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanManageStates");
		CanManageStates_ParamsSize = NativeReflection.GetFunctionParamsSize(CanManageStates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanManageStates_ReturnValue_PropertyAddress, CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanManageStates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanManageStates_IsValid = CanManageStates_FunctionAddress != IntPtr.Zero && CanManageStates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.SmartActorGuidObj:CanManageStates", CanManageStates_IsValid);
	}
}
