using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGU_AIMover", "b1", UnrealModuleType.Game)]
public class UBGU_AIMover : UObject
{
	private static bool FBUE_OnMoveComplete_IsValid;

	private static int FBUE_OnMoveComplete_Offset;

	private FBUE_OnMoveComplete FBUE_OnMoveComplete_DelegateCached;

	private static bool ResetRequest_IsValid;

	private static IntPtr ResetRequest_FunctionAddress;

	private static int ResetRequest_ParamsSize;

	private static bool MoveTo_IsValid;

	private static IntPtr MoveTo_FunctionAddress;

	private static int MoveTo_ParamsSize;

	private static bool MoveTo_Request_IsValid;

	private static FFieldAddress MoveTo_Request_PropertyAddress;

	private static int MoveTo_Request_Offset;

	private static bool IsRequestValid_IsValid;

	private static IntPtr IsRequestValid_FunctionAddress;

	private static int IsRequestValid_ParamsSize;

	private static bool IsRequestValid_ReturnValue_IsValid;

	private static FFieldAddress IsRequestValid_ReturnValue_PropertyAddress;

	private static int IsRequestValid_ReturnValue_Offset;

	private static bool IsOutOfRange_IsValid;

	private static IntPtr IsOutOfRange_FunctionAddress;

	private static int IsOutOfRange_ParamsSize;

	private static bool IsOutOfRange_ReturnValue_IsValid;

	private static FFieldAddress IsOutOfRange_ReturnValue_PropertyAddress;

	private static int IsOutOfRange_ReturnValue_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_OwnerAICtrl_IsValid;

	private static FFieldAddress Init_OwnerAICtrl_PropertyAddress;

	private static int Init_OwnerAICtrl_Offset;

	private static bool GetRequestID_IsValid;

	private static IntPtr GetRequestID_FunctionAddress;

	private static int GetRequestID_ParamsSize;

	private static bool GetRequestID_ReturnValue_IsValid;

	private static FFieldAddress GetRequestID_ReturnValue_PropertyAddress;

	private static int GetRequestID_ReturnValue_Offset;

	private static bool GetPathFollowingComponent_IsValid;

	private static IntPtr GetPathFollowingComponent_FunctionAddress;

	private static int GetPathFollowingComponent_ParamsSize;

	private static bool GetPathFollowingComponent_ReturnValue_IsValid;

	private static FFieldAddress GetPathFollowingComponent_ReturnValue_PropertyAddress;

	private static int GetPathFollowingComponent_ReturnValue_Offset;

	private static bool GetMoveStatus_IsValid;

	private static IntPtr GetMoveStatus_FunctionAddress;

	private static int GetMoveStatus_ParamsSize;

	private static bool GetMoveStatus_ReturnValue_IsValid;

	private static FFieldAddress GetMoveStatus_ReturnValue_PropertyAddress;

	private static int GetMoveStatus_ReturnValue_Offset;

	private static bool AbortMove_IsValid;

	private static IntPtr AbortMove_FunctionAddress;

	private static int AbortMove_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGU_AIMover:FBUE_OnMoveComplete")]
	public FBUE_OnMoveComplete FBUE_OnMoveComplete
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_OnMoveComplete_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGU_AIMover:FBUE_OnMoveComplete");
				return new FBUE_OnMoveComplete();
			}
			if (FBUE_OnMoveComplete_DelegateCached == null)
			{
				FBUE_OnMoveComplete_DelegateCached = new FBUE_OnMoveComplete();
				FBUE_OnMoveComplete_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_OnMoveComplete_Offset));
			}
			return FBUE_OnMoveComplete_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGU_AIMover:ResetRequest")]
	public unsafe void ResetRequest()
	{
		CheckDestroyed();
		if (!ResetRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:ResetRequest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetRequest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetRequest_FunctionAddress, argsSize: ResetRequest_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGU_AIMover:MoveTo")]
	public unsafe void MoveTo(FBGU_AIMoverRequest Request)
	{
		CheckDestroyed();
		if (!MoveTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:MoveTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MoveTo_Request_PropertyAddress.Address, intPtr);
		FBGU_AIMoverRequest.ToNative(IntPtr.Add(intPtr, MoveTo_Request_Offset), 0, MoveTo_Request_PropertyAddress.Address, Request);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveTo_FunctionAddress, intPtr, MoveTo_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGU_AIMover:IsRequestValid")]
	public unsafe bool IsRequestValid()
	{
		CheckDestroyed();
		if (!IsRequestValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:IsRequestValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRequestValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRequestValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRequestValid_FunctionAddress, intPtr, IsRequestValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRequestValid_ReturnValue_Offset), 0, IsRequestValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGU_AIMover:IsOutOfRange")]
	public unsafe bool IsOutOfRange()
	{
		CheckDestroyed();
		if (!IsOutOfRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:IsOutOfRange");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOutOfRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOutOfRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOutOfRange_FunctionAddress, intPtr, IsOutOfRange_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOutOfRange_ReturnValue_Offset), 0, IsOutOfRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGU_AIMover:Init")]
	public unsafe void Init(AController OwnerAICtrl)
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:Init");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, Init_OwnerAICtrl_Offset), 0, Init_OwnerAICtrl_PropertyAddress.Address, OwnerAICtrl);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BGU_AIMover:GetRequestID")]
	public unsafe int GetRequestID()
	{
		CheckDestroyed();
		if (!GetRequestID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:GetRequestID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRequestID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRequestID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRequestID_FunctionAddress, intPtr, GetRequestID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRequestID_ReturnValue_Offset), 0, GetRequestID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGU_AIMover:GetPathFollowingComponent")]
	public unsafe UPathFollowingComponent GetPathFollowingComponent()
	{
		CheckDestroyed();
		if (!GetPathFollowingComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:GetPathFollowingComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathFollowingComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathFollowingComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPathFollowingComponent_FunctionAddress, intPtr, GetPathFollowingComponent_ParamsSize);
		return UObjectMarshaler<UPathFollowingComponent>.FromNative(IntPtr.Add(intPtr, GetPathFollowingComponent_ReturnValue_Offset), 0, GetPathFollowingComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGU_AIMover:GetMoveStatus")]
	public unsafe EPathFollowingStatus GetMoveStatus()
	{
		CheckDestroyed();
		if (!GetMoveStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:GetMoveStatus");
			return EPathFollowingStatus.Idle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMoveStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMoveStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMoveStatus_FunctionAddress, intPtr, GetMoveStatus_ParamsSize);
		return EnumMarshaler<EPathFollowingStatus>.FromNative(IntPtr.Add(intPtr, GetMoveStatus_ReturnValue_Offset), 0, GetMoveStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGU_AIMover:AbortMove")]
	public unsafe void AbortMove()
	{
		CheckDestroyed();
		if (!AbortMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGU_AIMover:AbortMove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbortMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbortMove_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: AbortMove_FunctionAddress, argsSize: AbortMove_ParamsSize);
	}

	static UBGU_AIMover()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGU_AIMover)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGU_AIMover));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGU_AIMover");
		FBUE_OnMoveComplete_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FBUE_OnMoveComplete");
		FBUE_OnMoveComplete_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FBUE_OnMoveComplete", Classes.FMulticastDelegateProperty);
		ResetRequest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetRequest");
		ResetRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetRequest_FunctionAddress);
		ResetRequest_IsValid = ResetRequest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:ResetRequest", ResetRequest_IsValid);
		MoveTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveTo");
		MoveTo_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveTo_Request_PropertyAddress, MoveTo_FunctionAddress, "Request");
		MoveTo_Request_Offset = NativeReflectionCached.GetPropertyOffset(MoveTo_FunctionAddress, "Request");
		MoveTo_Request_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveTo_FunctionAddress, "Request", Classes.FStructProperty);
		MoveTo_IsValid = MoveTo_FunctionAddress != IntPtr.Zero && MoveTo_Request_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:MoveTo", MoveTo_IsValid);
		IsRequestValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsRequestValid");
		IsRequestValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRequestValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRequestValid_ReturnValue_PropertyAddress, IsRequestValid_FunctionAddress, "ReturnValue");
		IsRequestValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRequestValid_FunctionAddress, "ReturnValue");
		IsRequestValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRequestValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRequestValid_IsValid = IsRequestValid_FunctionAddress != IntPtr.Zero && IsRequestValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:IsRequestValid", IsRequestValid_IsValid);
		IsOutOfRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOutOfRange");
		IsOutOfRange_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOutOfRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOutOfRange_ReturnValue_PropertyAddress, IsOutOfRange_FunctionAddress, "ReturnValue");
		IsOutOfRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOutOfRange_FunctionAddress, "ReturnValue");
		IsOutOfRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOutOfRange_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOutOfRange_IsValid = IsOutOfRange_FunctionAddress != IntPtr.Zero && IsOutOfRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:IsOutOfRange", IsOutOfRange_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_OwnerAICtrl_PropertyAddress, Init_FunctionAddress, "OwnerAICtrl");
		Init_OwnerAICtrl_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "OwnerAICtrl");
		Init_OwnerAICtrl_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "OwnerAICtrl", Classes.FObjectProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_OwnerAICtrl_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:Init", Init_IsValid);
		GetRequestID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRequestID");
		GetRequestID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRequestID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRequestID_ReturnValue_PropertyAddress, GetRequestID_FunctionAddress, "ReturnValue");
		GetRequestID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRequestID_FunctionAddress, "ReturnValue");
		GetRequestID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRequestID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRequestID_IsValid = GetRequestID_FunctionAddress != IntPtr.Zero && GetRequestID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:GetRequestID", GetRequestID_IsValid);
		GetPathFollowingComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPathFollowingComponent");
		GetPathFollowingComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathFollowingComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathFollowingComponent_ReturnValue_PropertyAddress, GetPathFollowingComponent_FunctionAddress, "ReturnValue");
		GetPathFollowingComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathFollowingComponent_FunctionAddress, "ReturnValue");
		GetPathFollowingComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathFollowingComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPathFollowingComponent_IsValid = GetPathFollowingComponent_FunctionAddress != IntPtr.Zero && GetPathFollowingComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:GetPathFollowingComponent", GetPathFollowingComponent_IsValid);
		GetMoveStatus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMoveStatus");
		GetMoveStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMoveStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMoveStatus_ReturnValue_PropertyAddress, GetMoveStatus_FunctionAddress, "ReturnValue");
		GetMoveStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMoveStatus_FunctionAddress, "ReturnValue");
		GetMoveStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMoveStatus_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetMoveStatus_IsValid = GetMoveStatus_FunctionAddress != IntPtr.Zero && GetMoveStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:GetMoveStatus", GetMoveStatus_IsValid);
		AbortMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AbortMove");
		AbortMove_ParamsSize = NativeReflection.GetFunctionParamsSize(AbortMove_FunctionAddress);
		AbortMove_IsValid = AbortMove_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGU_AIMover:AbortMove", AbortMove_IsValid);
	}
}
