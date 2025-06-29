using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraParameterCollectionInstance : UObject
{
	private static bool SetVectorParameter_IsValid;

	private static IntPtr SetVectorParameter_FunctionAddress;

	private static int SetVectorParameter_ParamsSize;

	private static bool SetVectorParameter_InVariableName_IsValid;

	private static FFieldAddress SetVectorParameter_InVariableName_PropertyAddress;

	private static int SetVectorParameter_InVariableName_Offset;

	private static bool SetVectorParameter_InValue_IsValid;

	private static FFieldAddress SetVectorParameter_InValue_PropertyAddress;

	private static int SetVectorParameter_InValue_Offset;

	private static bool SetVector4Parameter_IsValid;

	private static IntPtr SetVector4Parameter_FunctionAddress;

	private static int SetVector4Parameter_ParamsSize;

	private static bool SetVector4Parameter_InVariableName_IsValid;

	private static FFieldAddress SetVector4Parameter_InVariableName_PropertyAddress;

	private static int SetVector4Parameter_InVariableName_Offset;

	private static bool SetVector4Parameter_InValue_IsValid;

	private static FFieldAddress SetVector4Parameter_InValue_PropertyAddress;

	private static int SetVector4Parameter_InValue_Offset;

	private static bool SetVector2DParameter_IsValid;

	private static IntPtr SetVector2DParameter_FunctionAddress;

	private static int SetVector2DParameter_ParamsSize;

	private static bool SetVector2DParameter_InVariableName_IsValid;

	private static FFieldAddress SetVector2DParameter_InVariableName_PropertyAddress;

	private static int SetVector2DParameter_InVariableName_Offset;

	private static bool SetVector2DParameter_InValue_IsValid;

	private static FFieldAddress SetVector2DParameter_InValue_PropertyAddress;

	private static int SetVector2DParameter_InValue_Offset;

	private static bool SetQuatParameter_IsValid;

	private static IntPtr SetQuatParameter_FunctionAddress;

	private static int SetQuatParameter_ParamsSize;

	private static bool SetQuatParameter_InVariableName_IsValid;

	private static FFieldAddress SetQuatParameter_InVariableName_PropertyAddress;

	private static int SetQuatParameter_InVariableName_Offset;

	private static bool SetQuatParameter_InValue_IsValid;

	private static FFieldAddress SetQuatParameter_InValue_PropertyAddress;

	private static int SetQuatParameter_InValue_Offset;

	private static bool SetIntParameter_IsValid;

	private static IntPtr SetIntParameter_FunctionAddress;

	private static int SetIntParameter_ParamsSize;

	private static bool SetIntParameter_InVariableName_IsValid;

	private static FFieldAddress SetIntParameter_InVariableName_PropertyAddress;

	private static int SetIntParameter_InVariableName_Offset;

	private static bool SetIntParameter_InValue_IsValid;

	private static FFieldAddress SetIntParameter_InValue_PropertyAddress;

	private static int SetIntParameter_InValue_Offset;

	private static bool SetFloatParameter_IsValid;

	private static IntPtr SetFloatParameter_FunctionAddress;

	private static int SetFloatParameter_ParamsSize;

	private static bool SetFloatParameter_InVariableName_IsValid;

	private static FFieldAddress SetFloatParameter_InVariableName_PropertyAddress;

	private static int SetFloatParameter_InVariableName_Offset;

	private static bool SetFloatParameter_InValue_IsValid;

	private static FFieldAddress SetFloatParameter_InValue_PropertyAddress;

	private static int SetFloatParameter_InValue_Offset;

	private static bool SetColorParameter_IsValid;

	private static IntPtr SetColorParameter_FunctionAddress;

	private static int SetColorParameter_ParamsSize;

	private static bool SetColorParameter_InVariableName_IsValid;

	private static FFieldAddress SetColorParameter_InVariableName_PropertyAddress;

	private static int SetColorParameter_InVariableName_Offset;

	private static bool SetColorParameter_InValue_IsValid;

	private static FFieldAddress SetColorParameter_InValue_PropertyAddress;

	private static int SetColorParameter_InValue_Offset;

	private static bool SetBoolParameter_IsValid;

	private static IntPtr SetBoolParameter_FunctionAddress;

	private static int SetBoolParameter_ParamsSize;

	private static bool SetBoolParameter_InVariableName_IsValid;

	private static FFieldAddress SetBoolParameter_InVariableName_PropertyAddress;

	private static int SetBoolParameter_InVariableName_Offset;

	private static bool SetBoolParameter_InValue_IsValid;

	private static FFieldAddress SetBoolParameter_InValue_PropertyAddress;

	private static int SetBoolParameter_InValue_Offset;

	private static bool GetVectorParameter_IsValid;

	private static IntPtr GetVectorParameter_FunctionAddress;

	private static int GetVectorParameter_ParamsSize;

	private static bool GetVectorParameter_InVariableName_IsValid;

	private static FFieldAddress GetVectorParameter_InVariableName_PropertyAddress;

	private static int GetVectorParameter_InVariableName_Offset;

	private static bool GetVectorParameter_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameter_ReturnValue_PropertyAddress;

	private static int GetVectorParameter_ReturnValue_Offset;

	private static bool GetVector4Parameter_IsValid;

	private static IntPtr GetVector4Parameter_FunctionAddress;

	private static int GetVector4Parameter_ParamsSize;

	private static bool GetVector4Parameter_InVariableName_IsValid;

	private static FFieldAddress GetVector4Parameter_InVariableName_PropertyAddress;

	private static int GetVector4Parameter_InVariableName_Offset;

	private static bool GetVector4Parameter_ReturnValue_IsValid;

	private static FFieldAddress GetVector4Parameter_ReturnValue_PropertyAddress;

	private static int GetVector4Parameter_ReturnValue_Offset;

	private static bool GetVector2DParameter_IsValid;

	private static IntPtr GetVector2DParameter_FunctionAddress;

	private static int GetVector2DParameter_ParamsSize;

	private static bool GetVector2DParameter_InVariableName_IsValid;

	private static FFieldAddress GetVector2DParameter_InVariableName_PropertyAddress;

	private static int GetVector2DParameter_InVariableName_Offset;

	private static bool GetVector2DParameter_ReturnValue_IsValid;

	private static FFieldAddress GetVector2DParameter_ReturnValue_PropertyAddress;

	private static int GetVector2DParameter_ReturnValue_Offset;

	private static bool GetQuatParameter_IsValid;

	private static IntPtr GetQuatParameter_FunctionAddress;

	private static int GetQuatParameter_ParamsSize;

	private static bool GetQuatParameter_InVariableName_IsValid;

	private static FFieldAddress GetQuatParameter_InVariableName_PropertyAddress;

	private static int GetQuatParameter_InVariableName_Offset;

	private static bool GetQuatParameter_ReturnValue_IsValid;

	private static FFieldAddress GetQuatParameter_ReturnValue_PropertyAddress;

	private static int GetQuatParameter_ReturnValue_Offset;

	private static bool GetIntParameter_IsValid;

	private static IntPtr GetIntParameter_FunctionAddress;

	private static int GetIntParameter_ParamsSize;

	private static bool GetIntParameter_InVariableName_IsValid;

	private static FFieldAddress GetIntParameter_InVariableName_PropertyAddress;

	private static int GetIntParameter_InVariableName_Offset;

	private static bool GetIntParameter_ReturnValue_IsValid;

	private static FFieldAddress GetIntParameter_ReturnValue_PropertyAddress;

	private static int GetIntParameter_ReturnValue_Offset;

	private static bool GetFloatParameter_IsValid;

	private static IntPtr GetFloatParameter_FunctionAddress;

	private static int GetFloatParameter_ParamsSize;

	private static bool GetFloatParameter_InVariableName_IsValid;

	private static FFieldAddress GetFloatParameter_InVariableName_PropertyAddress;

	private static int GetFloatParameter_InVariableName_Offset;

	private static bool GetFloatParameter_ReturnValue_IsValid;

	private static FFieldAddress GetFloatParameter_ReturnValue_PropertyAddress;

	private static int GetFloatParameter_ReturnValue_Offset;

	private static bool GetColorParameter_IsValid;

	private static IntPtr GetColorParameter_FunctionAddress;

	private static int GetColorParameter_ParamsSize;

	private static bool GetColorParameter_InVariableName_IsValid;

	private static FFieldAddress GetColorParameter_InVariableName_PropertyAddress;

	private static int GetColorParameter_InVariableName_Offset;

	private static bool GetColorParameter_ReturnValue_IsValid;

	private static FFieldAddress GetColorParameter_ReturnValue_PropertyAddress;

	private static int GetColorParameter_ReturnValue_Offset;

	private static bool GetBoolParameter_IsValid;

	private static IntPtr GetBoolParameter_FunctionAddress;

	private static int GetBoolParameter_ParamsSize;

	private static bool GetBoolParameter_InVariableName_IsValid;

	private static FFieldAddress GetBoolParameter_InVariableName_PropertyAddress;

	private static int GetBoolParameter_InVariableName_Offset;

	private static bool GetBoolParameter_ReturnValue_IsValid;

	private static FFieldAddress GetBoolParameter_ReturnValue_PropertyAddress;

	private static int GetBoolParameter_ReturnValue_Offset;

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetVectorParameter")]
	public unsafe void SetVectorParameter(string InVariableName, FVector InValue)
	{
		CheckDestroyed();
		if (!SetVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetVectorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVectorParameter_InVariableName_Offset), 0, SetVectorParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_InValue_Offset), 0, SetVectorParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameter_FunctionAddress, intPtr, SetVectorParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVectorParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector4Parameter")]
	public unsafe void SetVector4Parameter(string InVariableName, FVector4 InValue)
	{
		CheckDestroyed();
		if (!SetVector4Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector4Parameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector4Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector4Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector4Parameter_InVariableName_Offset), 0, SetVector4Parameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVector4Parameter_InValue_Offset), 0, SetVector4Parameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVector4Parameter_FunctionAddress, intPtr, SetVector4Parameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVector4Parameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector2DParameter")]
	public unsafe void SetVector2DParameter(string InVariableName, FVector2D InValue)
	{
		CheckDestroyed();
		if (!SetVector2DParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector2DParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVector2DParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVector2DParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVector2DParameter_InVariableName_Offset), 0, SetVector2DParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVector2DParameter_InValue_Offset), 0, SetVector2DParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVector2DParameter_FunctionAddress, intPtr, SetVector2DParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVector2DParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetQuatParameter")]
	public unsafe void SetQuatParameter(string InVariableName, FQuat InValue)
	{
		CheckDestroyed();
		if (!SetQuatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetQuatParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQuatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQuatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetQuatParameter_InVariableName_Offset), 0, SetQuatParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InitializeValue_InContainer(SetQuatParameter_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetQuatParameter_InValue_Offset), 0, SetQuatParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetQuatParameter_FunctionAddress, intPtr, SetQuatParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetQuatParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetIntParameter")]
	public unsafe void SetIntParameter(string InVariableName, int InValue)
	{
		CheckDestroyed();
		if (!SetIntParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetIntParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetIntParameter_InVariableName_Offset), 0, SetIntParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetIntParameter_InValue_Offset), 0, SetIntParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntParameter_FunctionAddress, intPtr, SetIntParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetIntParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetFloatParameter")]
	public unsafe void SetFloatParameter(string InVariableName, float InValue)
	{
		CheckDestroyed();
		if (!SetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetFloatParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFloatParameter_InVariableName_Offset), 0, SetFloatParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_InValue_Offset), 0, SetFloatParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatParameter_FunctionAddress, intPtr, SetFloatParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFloatParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetColorParameter")]
	public unsafe void SetColorParameter(string InVariableName, FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetColorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetColorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetColorParameter_InVariableName_Offset), 0, SetColorParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorParameter_InValue_Offset), 0, SetColorParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorParameter_FunctionAddress, intPtr, SetColorParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetColorParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:SetBoolParameter")]
	public unsafe void SetBoolParameter(string InVariableName, bool InValue)
	{
		CheckDestroyed();
		if (!SetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:SetBoolParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_InVariableName_Offset), 0, SetBoolParameter_InVariableName_PropertyAddress.Address, InVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_InValue_Offset), 0, SetBoolParameter_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolParameter_FunctionAddress, intPtr, SetBoolParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBoolParameter_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetVectorParameter")]
	public unsafe FVector GetVectorParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetVectorParameter");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVectorParameter_InVariableName_Offset), 0, GetVectorParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameter_FunctionAddress, intPtr, GetVectorParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVectorParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorParameter_ReturnValue_Offset), 0, GetVectorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector4Parameter")]
	public unsafe FVector4 GetVector4Parameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetVector4Parameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector4Parameter");
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector4Parameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector4Parameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector4Parameter_InVariableName_Offset), 0, GetVector4Parameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVector4Parameter_FunctionAddress, intPtr, GetVector4Parameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVector4Parameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetVector4Parameter_ReturnValue_Offset), 0, GetVector4Parameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector2DParameter")]
	public unsafe FVector2D GetVector2DParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetVector2DParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector2DParameter");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector2DParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector2DParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVector2DParameter_InVariableName_Offset), 0, GetVector2DParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVector2DParameter_FunctionAddress, intPtr, GetVector2DParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVector2DParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector2DParameter_ReturnValue_Offset), 0, GetVector2DParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetQuatParameter")]
	public unsafe FQuat GetQuatParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetQuatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetQuatParameter");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetQuatParameter_InVariableName_Offset), 0, GetQuatParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQuatParameter_FunctionAddress, intPtr, GetQuatParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetQuatParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, GetQuatParameter_ReturnValue_Offset), 0, GetQuatParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetIntParameter")]
	public unsafe int GetIntParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetIntParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetIntParameter");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIntParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIntParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetIntParameter_InVariableName_Offset), 0, GetIntParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIntParameter_FunctionAddress, intPtr, GetIntParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIntParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIntParameter_ReturnValue_Offset), 0, GetIntParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetFloatParameter")]
	public unsafe float GetFloatParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetFloatParameter");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFloatParameter_InVariableName_Offset), 0, GetFloatParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloatParameter_FunctionAddress, intPtr, GetFloatParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFloatParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatParameter_ReturnValue_Offset), 0, GetFloatParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetColorParameter")]
	public unsafe FLinearColor GetColorParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetColorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetColorParameter");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetColorParameter_InVariableName_Offset), 0, GetColorParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetColorParameter_FunctionAddress, intPtr, GetColorParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetColorParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetColorParameter_ReturnValue_Offset), 0, GetColorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraParameterCollectionInstance:GetBoolParameter")]
	public unsafe bool GetBoolParameter(string InVariableName)
	{
		CheckDestroyed();
		if (!GetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraParameterCollectionInstance:GetBoolParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetBoolParameter_InVariableName_Offset), 0, GetBoolParameter_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoolParameter_FunctionAddress, intPtr, GetBoolParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoolParameter_InVariableName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBoolParameter_ReturnValue_Offset), 0, GetBoolParameter_ReturnValue_PropertyAddress.Address);
	}

	static UNiagaraParameterCollectionInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraParameterCollectionInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraParameterCollectionInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraParameterCollectionInstance");
		SetVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVectorParameter");
		SetVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_InVariableName_PropertyAddress, SetVectorParameter_FunctionAddress, "InVariableName");
		SetVectorParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "InVariableName");
		SetVectorParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_InValue_PropertyAddress, SetVectorParameter_FunctionAddress, "InValue");
		SetVectorParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "InValue");
		SetVectorParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVectorParameter_IsValid = SetVectorParameter_FunctionAddress != IntPtr.Zero && SetVectorParameter_InVariableName_IsValid && SetVectorParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetVectorParameter", SetVectorParameter_IsValid);
		SetVector4Parameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVector4Parameter");
		SetVector4Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector4Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Parameter_InVariableName_PropertyAddress, SetVector4Parameter_FunctionAddress, "InVariableName");
		SetVector4Parameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Parameter_FunctionAddress, "InVariableName");
		SetVector4Parameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Parameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector4Parameter_InValue_PropertyAddress, SetVector4Parameter_FunctionAddress, "InValue");
		SetVector4Parameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVector4Parameter_FunctionAddress, "InValue");
		SetVector4Parameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector4Parameter_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVector4Parameter_IsValid = SetVector4Parameter_FunctionAddress != IntPtr.Zero && SetVector4Parameter_InVariableName_IsValid && SetVector4Parameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector4Parameter", SetVector4Parameter_IsValid);
		SetVector2DParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVector2DParameter");
		SetVector2DParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVector2DParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVector2DParameter_InVariableName_PropertyAddress, SetVector2DParameter_FunctionAddress, "InVariableName");
		SetVector2DParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2DParameter_FunctionAddress, "InVariableName");
		SetVector2DParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2DParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVector2DParameter_InValue_PropertyAddress, SetVector2DParameter_FunctionAddress, "InValue");
		SetVector2DParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVector2DParameter_FunctionAddress, "InValue");
		SetVector2DParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVector2DParameter_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVector2DParameter_IsValid = SetVector2DParameter_FunctionAddress != IntPtr.Zero && SetVector2DParameter_InVariableName_IsValid && SetVector2DParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetVector2DParameter", SetVector2DParameter_IsValid);
		SetQuatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetQuatParameter");
		SetQuatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQuatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQuatParameter_InVariableName_PropertyAddress, SetQuatParameter_FunctionAddress, "InVariableName");
		SetQuatParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatParameter_FunctionAddress, "InVariableName");
		SetQuatParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetQuatParameter_InValue_PropertyAddress, SetQuatParameter_FunctionAddress, "InValue");
		SetQuatParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetQuatParameter_FunctionAddress, "InValue");
		SetQuatParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuatParameter_FunctionAddress, "InValue", Classes.FStructProperty);
		SetQuatParameter_IsValid = SetQuatParameter_FunctionAddress != IntPtr.Zero && SetQuatParameter_InVariableName_IsValid && SetQuatParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetQuatParameter", SetQuatParameter_IsValid);
		SetIntParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIntParameter");
		SetIntParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_InVariableName_PropertyAddress, SetIntParameter_FunctionAddress, "InVariableName");
		SetIntParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "InVariableName");
		SetIntParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_InValue_PropertyAddress, SetIntParameter_FunctionAddress, "InValue");
		SetIntParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "InValue");
		SetIntParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "InValue", Classes.FIntProperty);
		SetIntParameter_IsValid = SetIntParameter_FunctionAddress != IntPtr.Zero && SetIntParameter_InVariableName_IsValid && SetIntParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetIntParameter", SetIntParameter_IsValid);
		SetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFloatParameter");
		SetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_InVariableName_PropertyAddress, SetFloatParameter_FunctionAddress, "InVariableName");
		SetFloatParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "InVariableName");
		SetFloatParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_InValue_PropertyAddress, SetFloatParameter_FunctionAddress, "InValue");
		SetFloatParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "InValue");
		SetFloatParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetFloatParameter_IsValid = SetFloatParameter_FunctionAddress != IntPtr.Zero && SetFloatParameter_InVariableName_IsValid && SetFloatParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetFloatParameter", SetFloatParameter_IsValid);
		SetColorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetColorParameter");
		SetColorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorParameter_InVariableName_PropertyAddress, SetColorParameter_FunctionAddress, "InVariableName");
		SetColorParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetColorParameter_FunctionAddress, "InVariableName");
		SetColorParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorParameter_InValue_PropertyAddress, SetColorParameter_FunctionAddress, "InValue");
		SetColorParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetColorParameter_FunctionAddress, "InValue");
		SetColorParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorParameter_FunctionAddress, "InValue", Classes.FStructProperty);
		SetColorParameter_IsValid = SetColorParameter_FunctionAddress != IntPtr.Zero && SetColorParameter_InVariableName_IsValid && SetColorParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetColorParameter", SetColorParameter_IsValid);
		SetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoolParameter");
		SetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_InVariableName_PropertyAddress, SetBoolParameter_FunctionAddress, "InVariableName");
		SetBoolParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "InVariableName");
		SetBoolParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_InValue_PropertyAddress, SetBoolParameter_FunctionAddress, "InValue");
		SetBoolParameter_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "InValue");
		SetBoolParameter_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetBoolParameter_IsValid = SetBoolParameter_FunctionAddress != IntPtr.Zero && SetBoolParameter_InVariableName_IsValid && SetBoolParameter_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:SetBoolParameter", SetBoolParameter_IsValid);
		GetVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVectorParameter");
		GetVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameter_InVariableName_PropertyAddress, GetVectorParameter_FunctionAddress, "InVariableName");
		GetVectorParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameter_FunctionAddress, "InVariableName");
		GetVectorParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameter_ReturnValue_PropertyAddress, GetVectorParameter_FunctionAddress, "ReturnValue");
		GetVectorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameter_FunctionAddress, "ReturnValue");
		GetVectorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameter_IsValid = GetVectorParameter_FunctionAddress != IntPtr.Zero && GetVectorParameter_InVariableName_IsValid && GetVectorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetVectorParameter", GetVectorParameter_IsValid);
		GetVector4Parameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVector4Parameter");
		GetVector4Parameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector4Parameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Parameter_InVariableName_PropertyAddress, GetVector4Parameter_FunctionAddress, "InVariableName");
		GetVector4Parameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Parameter_FunctionAddress, "InVariableName");
		GetVector4Parameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Parameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector4Parameter_ReturnValue_PropertyAddress, GetVector4Parameter_FunctionAddress, "ReturnValue");
		GetVector4Parameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector4Parameter_FunctionAddress, "ReturnValue");
		GetVector4Parameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector4Parameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector4Parameter_IsValid = GetVector4Parameter_FunctionAddress != IntPtr.Zero && GetVector4Parameter_InVariableName_IsValid && GetVector4Parameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector4Parameter", GetVector4Parameter_IsValid);
		GetVector2DParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVector2DParameter");
		GetVector2DParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector2DParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector2DParameter_InVariableName_PropertyAddress, GetVector2DParameter_FunctionAddress, "InVariableName");
		GetVector2DParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2DParameter_FunctionAddress, "InVariableName");
		GetVector2DParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2DParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2DParameter_ReturnValue_PropertyAddress, GetVector2DParameter_FunctionAddress, "ReturnValue");
		GetVector2DParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2DParameter_FunctionAddress, "ReturnValue");
		GetVector2DParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2DParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector2DParameter_IsValid = GetVector2DParameter_FunctionAddress != IntPtr.Zero && GetVector2DParameter_InVariableName_IsValid && GetVector2DParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetVector2DParameter", GetVector2DParameter_IsValid);
		GetQuatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetQuatParameter");
		GetQuatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuatParameter_InVariableName_PropertyAddress, GetQuatParameter_FunctionAddress, "InVariableName");
		GetQuatParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatParameter_FunctionAddress, "InVariableName");
		GetQuatParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQuatParameter_ReturnValue_PropertyAddress, GetQuatParameter_FunctionAddress, "ReturnValue");
		GetQuatParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuatParameter_FunctionAddress, "ReturnValue");
		GetQuatParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuatParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetQuatParameter_IsValid = GetQuatParameter_FunctionAddress != IntPtr.Zero && GetQuatParameter_InVariableName_IsValid && GetQuatParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetQuatParameter", GetQuatParameter_IsValid);
		GetIntParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIntParameter");
		GetIntParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIntParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIntParameter_InVariableName_PropertyAddress, GetIntParameter_FunctionAddress, "InVariableName");
		GetIntParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetIntParameter_FunctionAddress, "InVariableName");
		GetIntParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIntParameter_ReturnValue_PropertyAddress, GetIntParameter_FunctionAddress, "ReturnValue");
		GetIntParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIntParameter_FunctionAddress, "ReturnValue");
		GetIntParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntParameter_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIntParameter_IsValid = GetIntParameter_FunctionAddress != IntPtr.Zero && GetIntParameter_InVariableName_IsValid && GetIntParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetIntParameter", GetIntParameter_IsValid);
		GetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFloatParameter");
		GetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatParameter_InVariableName_PropertyAddress, GetFloatParameter_FunctionAddress, "InVariableName");
		GetFloatParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatParameter_FunctionAddress, "InVariableName");
		GetFloatParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatParameter_ReturnValue_PropertyAddress, GetFloatParameter_FunctionAddress, "ReturnValue");
		GetFloatParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatParameter_FunctionAddress, "ReturnValue");
		GetFloatParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatParameter_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatParameter_IsValid = GetFloatParameter_FunctionAddress != IntPtr.Zero && GetFloatParameter_InVariableName_IsValid && GetFloatParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetFloatParameter", GetFloatParameter_IsValid);
		GetColorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetColorParameter");
		GetColorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColorParameter_InVariableName_PropertyAddress, GetColorParameter_FunctionAddress, "InVariableName");
		GetColorParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetColorParameter_FunctionAddress, "InVariableName");
		GetColorParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorParameter_ReturnValue_PropertyAddress, GetColorParameter_FunctionAddress, "ReturnValue");
		GetColorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColorParameter_FunctionAddress, "ReturnValue");
		GetColorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColorParameter_IsValid = GetColorParameter_FunctionAddress != IntPtr.Zero && GetColorParameter_InVariableName_IsValid && GetColorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetColorParameter", GetColorParameter_IsValid);
		GetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoolParameter");
		GetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoolParameter_InVariableName_PropertyAddress, GetBoolParameter_FunctionAddress, "InVariableName");
		GetBoolParameter_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolParameter_FunctionAddress, "InVariableName");
		GetBoolParameter_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolParameter_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoolParameter_ReturnValue_PropertyAddress, GetBoolParameter_FunctionAddress, "ReturnValue");
		GetBoolParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoolParameter_FunctionAddress, "ReturnValue");
		GetBoolParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoolParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBoolParameter_IsValid = GetBoolParameter_FunctionAddress != IntPtr.Zero && GetBoolParameter_InVariableName_IsValid && GetBoolParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraParameterCollectionInstance:GetBoolParameter", GetBoolParameter_IsValid);
	}
}
