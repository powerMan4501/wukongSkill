using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public class UUpgradeNiagaraScriptResults : UObject
{
	private static bool CancelledByPythonError_IsValid;

	private static FFieldAddress CancelledByPythonError_PropertyAddress;

	private static int CancelledByPythonError_Offset;

	private static bool OldInputs_IsValid;

	private static FFieldAddress OldInputs_PropertyAddress;

	private static int OldInputs_Offset;

	private TArrayReadWriteMarshaler<UNiagaraPythonScriptModuleInput> OldInputs_MarshalerCached;

	private static bool NewInputs_IsValid;

	private static FFieldAddress NewInputs_PropertyAddress;

	private static int NewInputs_Offset;

	private TArrayReadWriteMarshaler<UNiagaraPythonScriptModuleInput> NewInputs_MarshalerCached;

	private static bool SetVec4Input_IsValid;

	private static IntPtr SetVec4Input_FunctionAddress;

	private static int SetVec4Input_ParamsSize;

	private static bool SetVec4Input_InputName_IsValid;

	private static FFieldAddress SetVec4Input_InputName_PropertyAddress;

	private static int SetVec4Input_InputName_Offset;

	private static bool SetVec4Input_Value_IsValid;

	private static FFieldAddress SetVec4Input_Value_PropertyAddress;

	private static int SetVec4Input_Value_Offset;

	private static bool SetVec3Input_IsValid;

	private static IntPtr SetVec3Input_FunctionAddress;

	private static int SetVec3Input_ParamsSize;

	private static bool SetVec3Input_InputName_IsValid;

	private static FFieldAddress SetVec3Input_InputName_PropertyAddress;

	private static int SetVec3Input_InputName_Offset;

	private static bool SetVec3Input_Value_IsValid;

	private static FFieldAddress SetVec3Input_Value_PropertyAddress;

	private static int SetVec3Input_Value_Offset;

	private static bool SetVec2Input_IsValid;

	private static IntPtr SetVec2Input_FunctionAddress;

	private static int SetVec2Input_ParamsSize;

	private static bool SetVec2Input_InputName_IsValid;

	private static FFieldAddress SetVec2Input_InputName_PropertyAddress;

	private static int SetVec2Input_InputName_Offset;

	private static bool SetVec2Input_Value_IsValid;

	private static FFieldAddress SetVec2Input_Value_PropertyAddress;

	private static int SetVec2Input_Value_Offset;

	private static bool SetQuatInput_IsValid;

	private static IntPtr SetQuatInput_FunctionAddress;

	private static int SetQuatInput_ParamsSize;

	private static bool SetQuatInput_InputName_IsValid;

	private static FFieldAddress SetQuatInput_InputName_PropertyAddress;

	private static int SetQuatInput_InputName_Offset;

	private static bool SetQuatInput_Value_IsValid;

	private static FFieldAddress SetQuatInput_Value_PropertyAddress;

	private static int SetQuatInput_Value_Offset;

	private static bool SetIntInput_IsValid;

	private static IntPtr SetIntInput_FunctionAddress;

	private static int SetIntInput_ParamsSize;

	private static bool SetIntInput_InputName_IsValid;

	private static FFieldAddress SetIntInput_InputName_PropertyAddress;

	private static int SetIntInput_InputName_Offset;

	private static bool SetIntInput_Value_IsValid;

	private static FFieldAddress SetIntInput_Value_PropertyAddress;

	private static int SetIntInput_Value_Offset;

	private static bool SetFloatInput_IsValid;

	private static IntPtr SetFloatInput_FunctionAddress;

	private static int SetFloatInput_ParamsSize;

	private static bool SetFloatInput_InputName_IsValid;

	private static FFieldAddress SetFloatInput_InputName_PropertyAddress;

	private static int SetFloatInput_InputName_Offset;

	private static bool SetFloatInput_Value_IsValid;

	private static FFieldAddress SetFloatInput_Value_PropertyAddress;

	private static int SetFloatInput_Value_Offset;

	private static bool SetEnumInput_IsValid;

	private static IntPtr SetEnumInput_FunctionAddress;

	private static int SetEnumInput_ParamsSize;

	private static bool SetEnumInput_InputName_IsValid;

	private static FFieldAddress SetEnumInput_InputName_PropertyAddress;

	private static int SetEnumInput_InputName_Offset;

	private static bool SetEnumInput_Value_IsValid;

	private static FFieldAddress SetEnumInput_Value_PropertyAddress;

	private static int SetEnumInput_Value_Offset;

	private static bool SetColorInput_IsValid;

	private static IntPtr SetColorInput_FunctionAddress;

	private static int SetColorInput_ParamsSize;

	private static bool SetColorInput_InputName_IsValid;

	private static FFieldAddress SetColorInput_InputName_PropertyAddress;

	private static int SetColorInput_InputName_Offset;

	private static bool SetColorInput_Value_IsValid;

	private static FFieldAddress SetColorInput_Value_PropertyAddress;

	private static int SetColorInput_Value_Offset;

	private static bool SetBoolInput_IsValid;

	private static IntPtr SetBoolInput_FunctionAddress;

	private static int SetBoolInput_ParamsSize;

	private static bool SetBoolInput_InputName_IsValid;

	private static FFieldAddress SetBoolInput_InputName_PropertyAddress;

	private static int SetBoolInput_InputName_Offset;

	private static bool SetBoolInput_Value_IsValid;

	private static FFieldAddress SetBoolInput_Value_PropertyAddress;

	private static int SetBoolInput_Value_Offset;

	private static bool GetOldInput_IsValid;

	private static IntPtr GetOldInput_FunctionAddress;

	private static int GetOldInput_ParamsSize;

	private static bool GetOldInput_InputName_IsValid;

	private static FFieldAddress GetOldInput_InputName_PropertyAddress;

	private static int GetOldInput_InputName_Offset;

	private static bool GetOldInput_ReturnValue_IsValid;

	private static FFieldAddress GetOldInput_ReturnValue_PropertyAddress;

	private static int GetOldInput_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:bCancelledByPythonError")]
	public bool CancelledByPythonError
	{
		get
		{
			CheckDestroyed();
			if (!CancelledByPythonError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:bCancelledByPythonError");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CancelledByPythonError_Offset), 0, CancelledByPythonError_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CancelledByPythonError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:bCancelledByPythonError");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CancelledByPythonError_Offset), 0, CancelledByPythonError_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:OldInputs")]
	public TArrayReadWrite<UNiagaraPythonScriptModuleInput> OldInputs
	{
		get
		{
			CheckDestroyed();
			if (!OldInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:OldInputs");
				return null;
			}
			if (OldInputs_MarshalerCached == null)
			{
				OldInputs_MarshalerCached = new TArrayReadWriteMarshaler<UNiagaraPythonScriptModuleInput>(1, OldInputs_PropertyAddress, CachedMarshalingDelegates<UNiagaraPythonScriptModuleInput, UObjectMarshaler<UNiagaraPythonScriptModuleInput>>.FromNative, CachedMarshalingDelegates<UNiagaraPythonScriptModuleInput, UObjectMarshaler<UNiagaraPythonScriptModuleInput>>.ToNative);
			}
			return OldInputs_MarshalerCached.FromNative(IntPtr.Add(base.Address, OldInputs_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:NewInputs")]
	public TArrayReadWrite<UNiagaraPythonScriptModuleInput> NewInputs
	{
		get
		{
			CheckDestroyed();
			if (!NewInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:NewInputs");
				return null;
			}
			if (NewInputs_MarshalerCached == null)
			{
				NewInputs_MarshalerCached = new TArrayReadWriteMarshaler<UNiagaraPythonScriptModuleInput>(1, NewInputs_PropertyAddress, CachedMarshalingDelegates<UNiagaraPythonScriptModuleInput, UObjectMarshaler<UNiagaraPythonScriptModuleInput>>.FromNative, CachedMarshalingDelegates<UNiagaraPythonScriptModuleInput, UObjectMarshaler<UNiagaraPythonScriptModuleInput>>.ToNative);
			}
			return NewInputs_MarshalerCached.FromNative(IntPtr.Add(base.Address, NewInputs_Offset));
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec4Input")]
	public unsafe void SetVec4Input(string InputName, FVector4 Value)
	{
		CheckDestroyed();
		if (!SetVec4Input_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec4Input");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVec4Input_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVec4Input_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVec4Input_InputName_Offset), 0, SetVec4Input_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVec4Input_Value_Offset), 0, SetVec4Input_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVec4Input_FunctionAddress, intPtr, SetVec4Input_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVec4Input_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec3Input")]
	public unsafe void SetVec3Input(string InputName, FVector Value)
	{
		CheckDestroyed();
		if (!SetVec3Input_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec3Input");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVec3Input_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVec3Input_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVec3Input_InputName_Offset), 0, SetVec3Input_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVec3Input_Value_Offset), 0, SetVec3Input_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVec3Input_FunctionAddress, intPtr, SetVec3Input_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVec3Input_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec2Input")]
	public unsafe void SetVec2Input(string InputName, FVector2D Value)
	{
		CheckDestroyed();
		if (!SetVec2Input_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec2Input");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVec2Input_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVec2Input_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVec2Input_InputName_Offset), 0, SetVec2Input_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVec2Input_Value_Offset), 0, SetVec2Input_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVec2Input_FunctionAddress, intPtr, SetVec2Input_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVec2Input_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetQuatInput")]
	public unsafe void SetQuatInput(string InputName, FQuat Value)
	{
		CheckDestroyed();
		if (!SetQuatInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetQuatInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQuatInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQuatInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetQuatInput_InputName_Offset), 0, SetQuatInput_InputName_PropertyAddress.Address, InputName);
		NativeReflection.InitializeValue_InContainer(SetQuatInput_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetQuatInput_Value_Offset), 0, SetQuatInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetQuatInput_FunctionAddress, intPtr, SetQuatInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetQuatInput_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetIntInput")]
	public unsafe void SetIntInput(string InputName, int Value)
	{
		CheckDestroyed();
		if (!SetIntInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetIntInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetIntInput_InputName_Offset), 0, SetIntInput_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetIntInput_Value_Offset), 0, SetIntInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntInput_FunctionAddress, intPtr, SetIntInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetIntInput_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetFloatInput")]
	public unsafe void SetFloatInput(string InputName, float Value)
	{
		CheckDestroyed();
		if (!SetFloatInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetFloatInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFloatInput_InputName_Offset), 0, SetFloatInput_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatInput_Value_Offset), 0, SetFloatInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatInput_FunctionAddress, intPtr, SetFloatInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFloatInput_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetEnumInput")]
	public unsafe void SetEnumInput(string InputName, string Value)
	{
		CheckDestroyed();
		if (!SetEnumInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetEnumInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnumInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnumInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEnumInput_InputName_Offset), 0, SetEnumInput_InputName_PropertyAddress.Address, InputName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEnumInput_Value_Offset), 0, SetEnumInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnumInput_FunctionAddress, intPtr, SetEnumInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEnumInput_InputName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetEnumInput_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetColorInput")]
	public unsafe void SetColorInput(string InputName, FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetColorInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetColorInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetColorInput_InputName_Offset), 0, SetColorInput_InputName_PropertyAddress.Address, InputName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorInput_Value_Offset), 0, SetColorInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorInput_FunctionAddress, intPtr, SetColorInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetColorInput_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetBoolInput")]
	public unsafe void SetBoolInput(string InputName, bool Value)
	{
		CheckDestroyed();
		if (!SetBoolInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetBoolInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolInput_InputName_Offset), 0, SetBoolInput_InputName_PropertyAddress.Address, InputName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolInput_Value_Offset), 0, SetBoolInput_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolInput_FunctionAddress, intPtr, SetBoolInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBoolInput_InputName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:GetOldInput")]
	public unsafe UNiagaraPythonScriptModuleInput GetOldInput(string InputName)
	{
		CheckDestroyed();
		if (!GetOldInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:GetOldInput");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOldInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOldInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetOldInput_InputName_Offset), 0, GetOldInput_InputName_PropertyAddress.Address, InputName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOldInput_FunctionAddress, intPtr, GetOldInput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOldInput_InputName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UNiagaraPythonScriptModuleInput>.FromNative(IntPtr.Add(intPtr, GetOldInput_ReturnValue_Offset), 0, GetOldInput_ReturnValue_PropertyAddress.Address);
	}

	static UUpgradeNiagaraScriptResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUpgradeNiagaraScriptResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUpgradeNiagaraScriptResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NiagaraEditor.UpgradeNiagaraScriptResults");
		NativeReflectionCached.GetPropertyRef(ref CancelledByPythonError_PropertyAddress, intPtr, "bCancelledByPythonError");
		CancelledByPythonError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCancelledByPythonError");
		CancelledByPythonError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCancelledByPythonError", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OldInputs_PropertyAddress, intPtr, "OldInputs");
		OldInputs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OldInputs");
		OldInputs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OldInputs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref NewInputs_PropertyAddress, intPtr, "NewInputs");
		NewInputs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewInputs");
		NewInputs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewInputs", Classes.FArrayProperty);
		SetVec4Input_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVec4Input");
		SetVec4Input_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVec4Input_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVec4Input_InputName_PropertyAddress, SetVec4Input_FunctionAddress, "InputName");
		SetVec4Input_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetVec4Input_FunctionAddress, "InputName");
		SetVec4Input_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec4Input_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVec4Input_Value_PropertyAddress, SetVec4Input_FunctionAddress, "Value");
		SetVec4Input_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVec4Input_FunctionAddress, "Value");
		SetVec4Input_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec4Input_FunctionAddress, "Value", Classes.FStructProperty);
		SetVec4Input_IsValid = SetVec4Input_FunctionAddress != IntPtr.Zero && SetVec4Input_InputName_IsValid && SetVec4Input_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec4Input", SetVec4Input_IsValid);
		SetVec3Input_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVec3Input");
		SetVec3Input_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVec3Input_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVec3Input_InputName_PropertyAddress, SetVec3Input_FunctionAddress, "InputName");
		SetVec3Input_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetVec3Input_FunctionAddress, "InputName");
		SetVec3Input_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec3Input_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVec3Input_Value_PropertyAddress, SetVec3Input_FunctionAddress, "Value");
		SetVec3Input_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVec3Input_FunctionAddress, "Value");
		SetVec3Input_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec3Input_FunctionAddress, "Value", Classes.FStructProperty);
		SetVec3Input_IsValid = SetVec3Input_FunctionAddress != IntPtr.Zero && SetVec3Input_InputName_IsValid && SetVec3Input_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec3Input", SetVec3Input_IsValid);
		SetVec2Input_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVec2Input");
		SetVec2Input_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVec2Input_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVec2Input_InputName_PropertyAddress, SetVec2Input_FunctionAddress, "InputName");
		SetVec2Input_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetVec2Input_FunctionAddress, "InputName");
		SetVec2Input_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec2Input_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVec2Input_Value_PropertyAddress, SetVec2Input_FunctionAddress, "Value");
		SetVec2Input_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVec2Input_FunctionAddress, "Value");
		SetVec2Input_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVec2Input_FunctionAddress, "Value", Classes.FStructProperty);
		SetVec2Input_IsValid = SetVec2Input_FunctionAddress != IntPtr.Zero && SetVec2Input_InputName_IsValid && SetVec2Input_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetVec2Input", SetVec2Input_IsValid);
		SetQuatInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetQuatInput");
		SetQuatInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQuatInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQuatInput_InputName_PropertyAddress, SetQuatInput_FunctionAddress, "InputName");
		SetQuatInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatInput_FunctionAddress, "InputName");
		SetQuatInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatInput_Value_PropertyAddress, SetQuatInput_FunctionAddress, "Value");
		SetQuatInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatInput_FunctionAddress, "Value");
		SetQuatInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatInput_FunctionAddress, "Value", Classes.FStructProperty);
		SetQuatInput_IsValid = SetQuatInput_FunctionAddress != IntPtr.Zero && SetQuatInput_InputName_IsValid && SetQuatInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetQuatInput", SetQuatInput_IsValid);
		SetIntInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntInput");
		SetIntInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntInput_InputName_PropertyAddress, SetIntInput_FunctionAddress, "InputName");
		SetIntInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntInput_FunctionAddress, "InputName");
		SetIntInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntInput_Value_PropertyAddress, SetIntInput_FunctionAddress, "Value");
		SetIntInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetIntInput_FunctionAddress, "Value");
		SetIntInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntInput_FunctionAddress, "Value", Classes.FIntProperty);
		SetIntInput_IsValid = SetIntInput_FunctionAddress != IntPtr.Zero && SetIntInput_InputName_IsValid && SetIntInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetIntInput", SetIntInput_IsValid);
		SetFloatInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFloatInput");
		SetFloatInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatInput_InputName_PropertyAddress, SetFloatInput_FunctionAddress, "InputName");
		SetFloatInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatInput_FunctionAddress, "InputName");
		SetFloatInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatInput_Value_PropertyAddress, SetFloatInput_FunctionAddress, "Value");
		SetFloatInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatInput_FunctionAddress, "Value");
		SetFloatInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatInput_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFloatInput_IsValid = SetFloatInput_FunctionAddress != IntPtr.Zero && SetFloatInput_InputName_IsValid && SetFloatInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetFloatInput", SetFloatInput_IsValid);
		SetEnumInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnumInput");
		SetEnumInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnumInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnumInput_InputName_PropertyAddress, SetEnumInput_FunctionAddress, "InputName");
		SetEnumInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumInput_FunctionAddress, "InputName");
		SetEnumInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnumInput_Value_PropertyAddress, SetEnumInput_FunctionAddress, "Value");
		SetEnumInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetEnumInput_FunctionAddress, "Value");
		SetEnumInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnumInput_FunctionAddress, "Value", Classes.FStrProperty);
		SetEnumInput_IsValid = SetEnumInput_FunctionAddress != IntPtr.Zero && SetEnumInput_InputName_IsValid && SetEnumInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetEnumInput", SetEnumInput_IsValid);
		SetColorInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColorInput");
		SetColorInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorInput_InputName_PropertyAddress, SetColorInput_FunctionAddress, "InputName");
		SetColorInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetColorInput_FunctionAddress, "InputName");
		SetColorInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorInput_Value_PropertyAddress, SetColorInput_FunctionAddress, "Value");
		SetColorInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetColorInput_FunctionAddress, "Value");
		SetColorInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorInput_FunctionAddress, "Value", Classes.FStructProperty);
		SetColorInput_IsValid = SetColorInput_FunctionAddress != IntPtr.Zero && SetColorInput_InputName_IsValid && SetColorInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetColorInput", SetColorInput_IsValid);
		SetBoolInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoolInput");
		SetBoolInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolInput_InputName_PropertyAddress, SetBoolInput_FunctionAddress, "InputName");
		SetBoolInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolInput_FunctionAddress, "InputName");
		SetBoolInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolInput_Value_PropertyAddress, SetBoolInput_FunctionAddress, "Value");
		SetBoolInput_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolInput_FunctionAddress, "Value");
		SetBoolInput_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolInput_FunctionAddress, "Value", Classes.FBoolProperty);
		SetBoolInput_IsValid = SetBoolInput_FunctionAddress != IntPtr.Zero && SetBoolInput_InputName_IsValid && SetBoolInput_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:SetBoolInput", SetBoolInput_IsValid);
		GetOldInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOldInput");
		GetOldInput_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOldInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOldInput_InputName_PropertyAddress, GetOldInput_FunctionAddress, "InputName");
		GetOldInput_InputName_Offset = NativeReflectionCached.GetPropertyOffset(GetOldInput_FunctionAddress, "InputName");
		GetOldInput_InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOldInput_FunctionAddress, "InputName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOldInput_ReturnValue_PropertyAddress, GetOldInput_FunctionAddress, "ReturnValue");
		GetOldInput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOldInput_FunctionAddress, "ReturnValue");
		GetOldInput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOldInput_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOldInput_IsValid = GetOldInput_FunctionAddress != IntPtr.Zero && GetOldInput_InputName_IsValid && GetOldInput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.UpgradeNiagaraScriptResults:GetOldInput", GetOldInput_IsValid);
	}
}
