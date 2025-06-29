using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[UMetaPath("/Script/AIModule.PawnAction", "AIModule", UnrealModuleType.Engine)]
public class UPawnAction : UObject
{
	private static IntPtr classAddress;

	private static bool AllowNewSameClassInstance_IsValid;

	private static FFieldAddress AllowNewSameClassInstance_PropertyAddress;

	private static int AllowNewSameClassInstance_Offset;

	private static bool ReplaceActiveSameClassInstance_IsValid;

	private static FFieldAddress ReplaceActiveSameClassInstance_PropertyAddress;

	private static int ReplaceActiveSameClassInstance_Offset;

	private static bool ShouldPauseMovement_IsValid;

	private static FFieldAddress ShouldPauseMovement_PropertyAddress;

	private static int ShouldPauseMovement_Offset;

	private static bool AlwaysNotifyOnFinished_IsValid;

	private static FFieldAddress AlwaysNotifyOnFinished_PropertyAddress;

	private static int AlwaysNotifyOnFinished_Offset;

	private static bool GetActionPriority_IsValid;

	private static IntPtr GetActionPriority_FunctionAddress;

	private static int GetActionPriority_ParamsSize;

	private static bool GetActionPriority_ReturnValue_IsValid;

	private static FFieldAddress GetActionPriority_ReturnValue_PropertyAddress;

	private static int GetActionPriority_ReturnValue_Offset;

	private static bool Finish_IsValid;

	private static IntPtr Finish_FunctionAddress;

	private static int Finish_ParamsSize;

	private static bool Finish_WithResult_IsValid;

	private static FFieldAddress Finish_WithResult_PropertyAddress;

	private static int Finish_WithResult_Offset;

	private static bool CreateActionInstance_IsValid;

	private static IntPtr CreateActionInstance_FunctionAddress;

	private static int CreateActionInstance_ParamsSize;

	private static bool CreateActionInstance_WorldContextObject_IsValid;

	private static FFieldAddress CreateActionInstance_WorldContextObject_PropertyAddress;

	private static int CreateActionInstance_WorldContextObject_Offset;

	private static bool CreateActionInstance_ActionClass_IsValid;

	private static FFieldAddress CreateActionInstance_ActionClass_PropertyAddress;

	private static int CreateActionInstance_ActionClass_Offset;

	private static bool CreateActionInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateActionInstance_ReturnValue_PropertyAddress;

	private static int CreateActionInstance_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267863880990741uL)]
	[UMetaPath("/Script/AIModule.PawnAction:bAllowNewSameClassInstance")]
	protected bool AllowNewSameClassInstance
	{
		get
		{
			CheckDestroyed();
			if (!AllowNewSameClassInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bAllowNewSameClassInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowNewSameClassInstance_Offset), 0, AllowNewSameClassInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowNewSameClassInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bAllowNewSameClassInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowNewSameClassInstance_Offset), 0, AllowNewSameClassInstance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880990725uL)]
	[UMetaPath("/Script/AIModule.PawnAction:bReplaceActiveSameClassInstance")]
	protected bool ReplaceActiveSameClassInstance
	{
		get
		{
			CheckDestroyed();
			if (!ReplaceActiveSameClassInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bReplaceActiveSameClassInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplaceActiveSameClassInstance_Offset), 0, ReplaceActiveSameClassInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplaceActiveSameClassInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bReplaceActiveSameClassInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplaceActiveSameClassInstance_Offset), 0, ReplaceActiveSameClassInstance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880990725uL)]
	[UMetaPath("/Script/AIModule.PawnAction:bShouldPauseMovement")]
	protected bool ShouldPauseMovement
	{
		get
		{
			CheckDestroyed();
			if (!ShouldPauseMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bShouldPauseMovement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldPauseMovement_Offset), 0, ShouldPauseMovement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldPauseMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bShouldPauseMovement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldPauseMovement_Offset), 0, ShouldPauseMovement_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272261927501829uL)]
	[UMetaPath("/Script/AIModule.PawnAction:bAlwaysNotifyOnFinished")]
	protected bool AlwaysNotifyOnFinished
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysNotifyOnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bAlwaysNotifyOnFinished");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysNotifyOnFinished_Offset), 0, AlwaysNotifyOnFinished_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysNotifyOnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.PawnAction:bAlwaysNotifyOnFinished");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysNotifyOnFinished_Offset), 0, AlwaysNotifyOnFinished_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AIModule.PawnAction:GetActionPriority")]
	public unsafe EAIRequestPriority GetActionPriority()
	{
		CheckDestroyed();
		if (!GetActionPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction:GetActionPriority");
			return EAIRequestPriority.SoftScript;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActionPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActionPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActionPriority_FunctionAddress, intPtr, GetActionPriority_ParamsSize);
		return EnumMarshaler<EAIRequestPriority>.FromNative(IntPtr.Add(intPtr, GetActionPriority_ReturnValue_Offset), 0, GetActionPriority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/AIModule.PawnAction:Finish")]
	protected unsafe void Finish(EPawnActionResult WithResult)
	{
		CheckDestroyed();
		if (!Finish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction:Finish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Finish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Finish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPawnActionResult>.ToNative(IntPtr.Add(intPtr, Finish_WithResult_Offset), 0, Finish_WithResult_PropertyAddress.Address, WithResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, Finish_FunctionAddress, intPtr, Finish_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AIModule.PawnAction:CreateActionInstance")]
	public unsafe static UPawnAction CreateActionInstance(UObject WorldContextObject, TSubclassOf<UPawnAction> ActionClass)
	{
		if (!CreateActionInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction:CreateActionInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateActionInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateActionInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateActionInstance_WorldContextObject_Offset), 0, CreateActionInstance_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<UPawnAction>.ToNative(IntPtr.Add(intPtr, CreateActionInstance_ActionClass_Offset), 0, CreateActionInstance_ActionClass_PropertyAddress.Address, ActionClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateActionInstance_FunctionAddress, intPtr, CreateActionInstance_ParamsSize);
		return UObjectMarshaler<UPawnAction>.FromNative(IntPtr.Add(intPtr, CreateActionInstance_ReturnValue_Offset), 0, CreateActionInstance_ReturnValue_PropertyAddress.Address);
	}

	static UPawnAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnAction));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AIModule.PawnAction");
		NativeReflectionCached.GetPropertyRef(ref AllowNewSameClassInstance_PropertyAddress, classAddress, "bAllowNewSameClassInstance");
		AllowNewSameClassInstance_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bAllowNewSameClassInstance");
		AllowNewSameClassInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bAllowNewSameClassInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceActiveSameClassInstance_PropertyAddress, classAddress, "bReplaceActiveSameClassInstance");
		ReplaceActiveSameClassInstance_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bReplaceActiveSameClassInstance");
		ReplaceActiveSameClassInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bReplaceActiveSameClassInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldPauseMovement_PropertyAddress, classAddress, "bShouldPauseMovement");
		ShouldPauseMovement_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bShouldPauseMovement");
		ShouldPauseMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bShouldPauseMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysNotifyOnFinished_PropertyAddress, classAddress, "bAlwaysNotifyOnFinished");
		AlwaysNotifyOnFinished_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bAlwaysNotifyOnFinished");
		AlwaysNotifyOnFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bAlwaysNotifyOnFinished", Classes.FBoolProperty);
		GetActionPriority_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActionPriority");
		GetActionPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActionPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActionPriority_ReturnValue_PropertyAddress, GetActionPriority_FunctionAddress, "ReturnValue");
		GetActionPriority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActionPriority_FunctionAddress, "ReturnValue");
		GetActionPriority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionPriority_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetActionPriority_IsValid = GetActionPriority_FunctionAddress != IntPtr.Zero && GetActionPriority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction:GetActionPriority", GetActionPriority_IsValid);
		Finish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Finish");
		Finish_ParamsSize = NativeReflection.GetFunctionParamsSize(Finish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Finish_WithResult_PropertyAddress, Finish_FunctionAddress, "WithResult");
		Finish_WithResult_Offset = NativeReflectionCached.GetPropertyOffset(Finish_FunctionAddress, "WithResult");
		Finish_WithResult_IsValid = NativeReflectionCached.ValidatePropertyClass(Finish_FunctionAddress, "WithResult", Classes.FByteProperty);
		Finish_IsValid = Finish_FunctionAddress != IntPtr.Zero && Finish_WithResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction:Finish", Finish_IsValid);
		CreateActionInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateActionInstance");
		CreateActionInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateActionInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateActionInstance_WorldContextObject_PropertyAddress, CreateActionInstance_FunctionAddress, "WorldContextObject");
		CreateActionInstance_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateActionInstance_FunctionAddress, "WorldContextObject");
		CreateActionInstance_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActionInstance_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateActionInstance_ActionClass_PropertyAddress, CreateActionInstance_FunctionAddress, "ActionClass");
		CreateActionInstance_ActionClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateActionInstance_FunctionAddress, "ActionClass");
		CreateActionInstance_ActionClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActionInstance_FunctionAddress, "ActionClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateActionInstance_ReturnValue_PropertyAddress, CreateActionInstance_FunctionAddress, "ReturnValue");
		CreateActionInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateActionInstance_FunctionAddress, "ReturnValue");
		CreateActionInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateActionInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateActionInstance_IsValid = CreateActionInstance_FunctionAddress != IntPtr.Zero && CreateActionInstance_WorldContextObject_IsValid && CreateActionInstance_ActionClass_IsValid && CreateActionInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction:CreateActionInstance", CreateActionInstance_IsValid);
	}
}
