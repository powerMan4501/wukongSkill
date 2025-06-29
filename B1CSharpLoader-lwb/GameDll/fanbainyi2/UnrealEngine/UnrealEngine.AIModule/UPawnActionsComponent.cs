using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.PawnActionsComponent", "AIModule", UnrealModuleType.Engine)]
public class UPawnActionsComponent : UActorComponent
{
	private static IntPtr classAddress;

	private static bool ControlledPawn_IsValid;

	private static int ControlledPawn_Offset;

	private static bool PushAction_IsValid;

	private static IntPtr PushAction_FunctionAddress;

	private static int PushAction_ParamsSize;

	private static bool PushAction_NewAction_IsValid;

	private static FFieldAddress PushAction_NewAction_PropertyAddress;

	private static int PushAction_NewAction_Offset;

	private static bool PushAction_Priority_IsValid;

	private static FFieldAddress PushAction_Priority_PropertyAddress;

	private static int PushAction_Priority_Offset;

	private static bool PushAction_Instigator_IsValid;

	private static FFieldAddress PushAction_Instigator_PropertyAddress;

	private static int PushAction_Instigator_Offset;

	private static bool PushAction_ReturnValue_IsValid;

	private static FFieldAddress PushAction_ReturnValue_PropertyAddress;

	private static int PushAction_ReturnValue_Offset;

	private static bool PerformAction_IsValid;

	private static IntPtr PerformAction_FunctionAddress;

	private static int PerformAction_ParamsSize;

	private static bool PerformAction_Pawn_IsValid;

	private static FFieldAddress PerformAction_Pawn_PropertyAddress;

	private static int PerformAction_Pawn_Offset;

	private static bool PerformAction_Action_IsValid;

	private static FFieldAddress PerformAction_Action_PropertyAddress;

	private static int PerformAction_Action_Offset;

	private static bool PerformAction_Priority_IsValid;

	private static FFieldAddress PerformAction_Priority_PropertyAddress;

	private static int PerformAction_Priority_Offset;

	private static bool PerformAction_ReturnValue_IsValid;

	private static FFieldAddress PerformAction_ReturnValue_PropertyAddress;

	private static int PerformAction_ReturnValue_Offset;

	private static bool ForceAbortAction_IsValid;

	private static IntPtr ForceAbortAction_FunctionAddress;

	private static int ForceAbortAction_ParamsSize;

	private static bool ForceAbortAction_ActionToAbort_IsValid;

	private static FFieldAddress ForceAbortAction_ActionToAbort_PropertyAddress;

	private static int ForceAbortAction_ActionToAbort_Offset;

	private static bool ForceAbortAction_ReturnValue_IsValid;

	private static FFieldAddress ForceAbortAction_ReturnValue_PropertyAddress;

	private static int ForceAbortAction_ReturnValue_Offset;

	private static bool AbortAction_IsValid;

	private static IntPtr AbortAction_FunctionAddress;

	private static int AbortAction_ParamsSize;

	private static bool AbortAction_ActionToAbort_IsValid;

	private static FFieldAddress AbortAction_ActionToAbort_PropertyAddress;

	private static int AbortAction_ActionToAbort_Offset;

	private static bool AbortAction_ReturnValue_IsValid;

	private static FFieldAddress AbortAction_ReturnValue_PropertyAddress;

	private static int AbortAction_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/AIModule.PawnActionsComponent:ControlledPawn")]
	protected APawn ControlledPawn
	{
		get
		{
			CheckDestroyed();
			if (!ControlledPawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnActionsComponent:ControlledPawn");
				return null;
			}
			return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(base.Address, ControlledPawn_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlledPawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnActionsComponent:ControlledPawn");
			}
			else
			{
				UObjectMarshaler<APawn>.ToNative(IntPtr.Add(base.Address, ControlledPawn_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_PushAction")]
	[UMetaPath("/Script/AIModule.PawnActionsComponent:K2_PushAction")]
	public unsafe bool PushAction(UPawnAction NewAction, EAIRequestPriority Priority, UObject Instigator)
	{
		CheckDestroyed();
		if (!PushAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnActionsComponent:K2_PushAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PushAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PushAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPawnAction>.ToNative(IntPtr.Add(intPtr, PushAction_NewAction_Offset), 0, PushAction_NewAction_PropertyAddress.Address, NewAction);
		EnumMarshaler<EAIRequestPriority>.ToNative(IntPtr.Add(intPtr, PushAction_Priority_Offset), 0, PushAction_Priority_PropertyAddress.Address, Priority);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PushAction_Instigator_Offset), 0, PushAction_Instigator_PropertyAddress.Address, Instigator);
		NativeReflection.InvokeFunctionOptimized(base.Address, PushAction_FunctionAddress, intPtr, PushAction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PushAction_ReturnValue_Offset), 0, PushAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u, OriginalName = "K2_PerformAction")]
	[UMetaPath("/Script/AIModule.PawnActionsComponent:K2_PerformAction")]
	public unsafe static bool PerformAction(APawn Pawn, UPawnAction Action, EAIRequestPriority Priority = EAIRequestPriority.HardScript)
	{
		if (!PerformAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnActionsComponent:K2_PerformAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, PerformAction_Pawn_Offset), 0, PerformAction_Pawn_PropertyAddress.Address, Pawn);
		UObjectMarshaler<UPawnAction>.ToNative(IntPtr.Add(intPtr, PerformAction_Action_Offset), 0, PerformAction_Action_PropertyAddress.Address, Action);
		EnumMarshaler<EAIRequestPriority>.ToNative(IntPtr.Add(intPtr, PerformAction_Priority_Offset), 0, PerformAction_Priority_PropertyAddress.Address, Priority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PerformAction_FunctionAddress, intPtr, PerformAction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PerformAction_ReturnValue_Offset), 0, PerformAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_ForceAbortAction")]
	[UMetaPath("/Script/AIModule.PawnActionsComponent:K2_ForceAbortAction")]
	public unsafe EPawnActionAbortState ForceAbortAction(UPawnAction ActionToAbort)
	{
		CheckDestroyed();
		if (!ForceAbortAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnActionsComponent:K2_ForceAbortAction");
			return EPawnActionAbortState.NeverStarted;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceAbortAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceAbortAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPawnAction>.ToNative(IntPtr.Add(intPtr, ForceAbortAction_ActionToAbort_Offset), 0, ForceAbortAction_ActionToAbort_PropertyAddress.Address, ActionToAbort);
		NativeReflection.InvokeFunctionOptimized(base.Address, ForceAbortAction_FunctionAddress, intPtr, ForceAbortAction_ParamsSize);
		return EnumMarshaler<EPawnActionAbortState>.FromNative(IntPtr.Add(intPtr, ForceAbortAction_ReturnValue_Offset), 0, ForceAbortAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AbortAction")]
	[UMetaPath("/Script/AIModule.PawnActionsComponent:K2_AbortAction")]
	public unsafe EPawnActionAbortState AbortAction(UPawnAction ActionToAbort)
	{
		CheckDestroyed();
		if (!AbortAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnActionsComponent:K2_AbortAction");
			return EPawnActionAbortState.NeverStarted;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbortAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbortAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPawnAction>.ToNative(IntPtr.Add(intPtr, AbortAction_ActionToAbort_Offset), 0, AbortAction_ActionToAbort_PropertyAddress.Address, ActionToAbort);
		NativeReflection.InvokeFunctionOptimized(base.Address, AbortAction_FunctionAddress, intPtr, AbortAction_ParamsSize);
		return EnumMarshaler<EPawnActionAbortState>.FromNative(IntPtr.Add(intPtr, AbortAction_ReturnValue_Offset), 0, AbortAction_ReturnValue_PropertyAddress.Address);
	}

	static UPawnActionsComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnActionsComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnActionsComponent));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AIModule.PawnActionsComponent");
		ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ControlledPawn");
		ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ControlledPawn", Classes.FObjectProperty);
		PushAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_PushAction");
		PushAction_ParamsSize = NativeReflection.GetFunctionParamsSize(PushAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PushAction_NewAction_PropertyAddress, PushAction_FunctionAddress, "NewAction");
		PushAction_NewAction_Offset = NativeReflectionCached.GetPropertyOffset(PushAction_FunctionAddress, "NewAction");
		PushAction_NewAction_IsValid = NativeReflectionCached.ValidatePropertyClass(PushAction_FunctionAddress, "NewAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PushAction_Priority_PropertyAddress, PushAction_FunctionAddress, "Priority");
		PushAction_Priority_Offset = NativeReflectionCached.GetPropertyOffset(PushAction_FunctionAddress, "Priority");
		PushAction_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(PushAction_FunctionAddress, "Priority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PushAction_Instigator_PropertyAddress, PushAction_FunctionAddress, "Instigator");
		PushAction_Instigator_Offset = NativeReflectionCached.GetPropertyOffset(PushAction_FunctionAddress, "Instigator");
		PushAction_Instigator_IsValid = NativeReflectionCached.ValidatePropertyClass(PushAction_FunctionAddress, "Instigator", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PushAction_ReturnValue_PropertyAddress, PushAction_FunctionAddress, "ReturnValue");
		PushAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PushAction_FunctionAddress, "ReturnValue");
		PushAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PushAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PushAction_IsValid = PushAction_FunctionAddress != IntPtr.Zero && PushAction_NewAction_IsValid && PushAction_Priority_IsValid && PushAction_Instigator_IsValid && PushAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnActionsComponent:K2_PushAction", PushAction_IsValid);
		PerformAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_PerformAction");
		PerformAction_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerformAction_Pawn_PropertyAddress, PerformAction_FunctionAddress, "Pawn");
		PerformAction_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(PerformAction_FunctionAddress, "Pawn");
		PerformAction_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformAction_FunctionAddress, "Pawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformAction_Action_PropertyAddress, PerformAction_FunctionAddress, "Action");
		PerformAction_Action_Offset = NativeReflectionCached.GetPropertyOffset(PerformAction_FunctionAddress, "Action");
		PerformAction_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformAction_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformAction_Priority_PropertyAddress, PerformAction_FunctionAddress, "Priority");
		PerformAction_Priority_Offset = NativeReflectionCached.GetPropertyOffset(PerformAction_FunctionAddress, "Priority");
		PerformAction_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformAction_FunctionAddress, "Priority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformAction_ReturnValue_PropertyAddress, PerformAction_FunctionAddress, "ReturnValue");
		PerformAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PerformAction_FunctionAddress, "ReturnValue");
		PerformAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PerformAction_IsValid = PerformAction_FunctionAddress != IntPtr.Zero && PerformAction_Pawn_IsValid && PerformAction_Action_IsValid && PerformAction_Priority_IsValid && PerformAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnActionsComponent:K2_PerformAction", PerformAction_IsValid);
		ForceAbortAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_ForceAbortAction");
		ForceAbortAction_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceAbortAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceAbortAction_ActionToAbort_PropertyAddress, ForceAbortAction_FunctionAddress, "ActionToAbort");
		ForceAbortAction_ActionToAbort_Offset = NativeReflectionCached.GetPropertyOffset(ForceAbortAction_FunctionAddress, "ActionToAbort");
		ForceAbortAction_ActionToAbort_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceAbortAction_FunctionAddress, "ActionToAbort", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceAbortAction_ReturnValue_PropertyAddress, ForceAbortAction_FunctionAddress, "ReturnValue");
		ForceAbortAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ForceAbortAction_FunctionAddress, "ReturnValue");
		ForceAbortAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceAbortAction_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ForceAbortAction_IsValid = ForceAbortAction_FunctionAddress != IntPtr.Zero && ForceAbortAction_ActionToAbort_IsValid && ForceAbortAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnActionsComponent:K2_ForceAbortAction", ForceAbortAction_IsValid);
		AbortAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_AbortAction");
		AbortAction_ParamsSize = NativeReflection.GetFunctionParamsSize(AbortAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AbortAction_ActionToAbort_PropertyAddress, AbortAction_FunctionAddress, "ActionToAbort");
		AbortAction_ActionToAbort_Offset = NativeReflectionCached.GetPropertyOffset(AbortAction_FunctionAddress, "ActionToAbort");
		AbortAction_ActionToAbort_IsValid = NativeReflectionCached.ValidatePropertyClass(AbortAction_FunctionAddress, "ActionToAbort", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AbortAction_ReturnValue_PropertyAddress, AbortAction_FunctionAddress, "ReturnValue");
		AbortAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AbortAction_FunctionAddress, "ReturnValue");
		AbortAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AbortAction_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		AbortAction_IsValid = AbortAction_FunctionAddress != IntPtr.Zero && AbortAction_ActionToAbort_IsValid && AbortAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnActionsComponent:K2_AbortAction", AbortAction_IsValid);
	}
}
