using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataIteration", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UFieldSystemMetaDataIteration : UFieldSystemMetaData
{
	private static bool Iterations_IsValid;

	private static int Iterations_Offset;

	private static bool SetMetaDataIteration_IsValid;

	private static IntPtr SetMetaDataIteration_FunctionAddress;

	private static int SetMetaDataIteration_ParamsSize;

	private static bool SetMetaDataIteration_Iterations_IsValid;

	private static FFieldAddress SetMetaDataIteration_Iterations_PropertyAddress;

	private static int SetMetaDataIteration_Iterations_Offset;

	private static bool SetMetaDataIteration_ReturnValue_IsValid;

	private static FFieldAddress SetMetaDataIteration_ReturnValue_PropertyAddress;

	private static int SetMetaDataIteration_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:Iterations")]
	public int Iterations
	{
		get
		{
			CheckDestroyed();
			if (!Iterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:Iterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Iterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Iterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:Iterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Iterations_Offset), value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:SetMetaDataIteration")]
	public unsafe UFieldSystemMetaDataIteration SetMetaDataIteration(int Iterations)
	{
		CheckDestroyed();
		if (!SetMetaDataIteration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:SetMetaDataIteration");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMetaDataIteration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMetaDataIteration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMetaDataIteration_Iterations_Offset), 0, SetMetaDataIteration_Iterations_PropertyAddress.Address, Iterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMetaDataIteration_FunctionAddress, intPtr, SetMetaDataIteration_ParamsSize);
		return UObjectMarshaler<UFieldSystemMetaDataIteration>.FromNative(IntPtr.Add(intPtr, SetMetaDataIteration_ReturnValue_Offset), 0, SetMetaDataIteration_ReturnValue_PropertyAddress.Address);
	}

	static UFieldSystemMetaDataIteration()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFieldSystemMetaDataIteration)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFieldSystemMetaDataIteration));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.FieldSystemMetaDataIteration");
		Iterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Iterations");
		Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Iterations", Classes.FIntProperty);
		SetMetaDataIteration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMetaDataIteration");
		SetMetaDataIteration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMetaDataIteration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataIteration_Iterations_PropertyAddress, SetMetaDataIteration_FunctionAddress, "Iterations");
		SetMetaDataIteration_Iterations_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataIteration_FunctionAddress, "Iterations");
		SetMetaDataIteration_Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataIteration_FunctionAddress, "Iterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataIteration_ReturnValue_PropertyAddress, SetMetaDataIteration_FunctionAddress, "ReturnValue");
		SetMetaDataIteration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataIteration_FunctionAddress, "ReturnValue");
		SetMetaDataIteration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataIteration_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMetaDataIteration_IsValid = SetMetaDataIteration_FunctionAddress != IntPtr.Zero && SetMetaDataIteration_Iterations_IsValid && SetMetaDataIteration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemMetaDataIteration:SetMetaDataIteration", SetMetaDataIteration_IsValid);
	}
}
