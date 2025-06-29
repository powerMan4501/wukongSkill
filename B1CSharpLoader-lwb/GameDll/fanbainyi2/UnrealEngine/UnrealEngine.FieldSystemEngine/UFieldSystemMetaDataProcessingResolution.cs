using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData
{
	private static bool ResolutionType_IsValid;

	private static FFieldAddress ResolutionType_PropertyAddress;

	private static int ResolutionType_Offset;

	private static bool SetMetaDataaProcessingResolutionType_IsValid;

	private static IntPtr SetMetaDataaProcessingResolutionType_FunctionAddress;

	private static int SetMetaDataaProcessingResolutionType_ParamsSize;

	private static bool SetMetaDataaProcessingResolutionType_ResolutionType_IsValid;

	private static FFieldAddress SetMetaDataaProcessingResolutionType_ResolutionType_PropertyAddress;

	private static int SetMetaDataaProcessingResolutionType_ResolutionType_Offset;

	private static bool SetMetaDataaProcessingResolutionType_ReturnValue_IsValid;

	private static FFieldAddress SetMetaDataaProcessingResolutionType_ReturnValue_PropertyAddress;

	private static int SetMetaDataaProcessingResolutionType_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:ResolutionType")]
	public EFieldResolutionType ResolutionType
	{
		get
		{
			CheckDestroyed();
			if (!ResolutionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:ResolutionType");
				return EFieldResolutionType.Field_Resolution_Minimal;
			}
			return EnumMarshaler<EFieldResolutionType>.FromNative(IntPtr.Add(base.Address, ResolutionType_Offset), 0, ResolutionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResolutionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:ResolutionType");
			}
			else
			{
				EnumMarshaler<EFieldResolutionType>.ToNative(IntPtr.Add(base.Address, ResolutionType_Offset), 0, ResolutionType_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:SetMetaDataaProcessingResolutionType")]
	public unsafe UFieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(EFieldResolutionType ResolutionType)
	{
		CheckDestroyed();
		if (!SetMetaDataaProcessingResolutionType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:SetMetaDataaProcessingResolutionType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMetaDataaProcessingResolutionType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMetaDataaProcessingResolutionType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFieldResolutionType>.ToNative(IntPtr.Add(intPtr, SetMetaDataaProcessingResolutionType_ResolutionType_Offset), 0, SetMetaDataaProcessingResolutionType_ResolutionType_PropertyAddress.Address, ResolutionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMetaDataaProcessingResolutionType_FunctionAddress, intPtr, SetMetaDataaProcessingResolutionType_ParamsSize);
		return UObjectMarshaler<UFieldSystemMetaDataProcessingResolution>.FromNative(IntPtr.Add(intPtr, SetMetaDataaProcessingResolutionType_ReturnValue_Offset), 0, SetMetaDataaProcessingResolutionType_ReturnValue_PropertyAddress.Address);
	}

	static UFieldSystemMetaDataProcessingResolution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFieldSystemMetaDataProcessingResolution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFieldSystemMetaDataProcessingResolution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution");
		NativeReflectionCached.GetPropertyRef(ref ResolutionType_PropertyAddress, intPtr, "ResolutionType");
		ResolutionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResolutionType");
		ResolutionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResolutionType", Classes.FByteProperty);
		SetMetaDataaProcessingResolutionType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMetaDataaProcessingResolutionType");
		SetMetaDataaProcessingResolutionType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMetaDataaProcessingResolutionType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataaProcessingResolutionType_ResolutionType_PropertyAddress, SetMetaDataaProcessingResolutionType_FunctionAddress, "ResolutionType");
		SetMetaDataaProcessingResolutionType_ResolutionType_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataaProcessingResolutionType_FunctionAddress, "ResolutionType");
		SetMetaDataaProcessingResolutionType_ResolutionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataaProcessingResolutionType_FunctionAddress, "ResolutionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetaDataaProcessingResolutionType_ReturnValue_PropertyAddress, SetMetaDataaProcessingResolutionType_FunctionAddress, "ReturnValue");
		SetMetaDataaProcessingResolutionType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMetaDataaProcessingResolutionType_FunctionAddress, "ReturnValue");
		SetMetaDataaProcessingResolutionType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetaDataaProcessingResolutionType_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMetaDataaProcessingResolutionType_IsValid = SetMetaDataaProcessingResolutionType_FunctionAddress != IntPtr.Zero && SetMetaDataaProcessingResolutionType_ResolutionType_IsValid && SetMetaDataaProcessingResolutionType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:SetMetaDataaProcessingResolutionType", SetMetaDataaProcessingResolutionType_IsValid);
	}
}
