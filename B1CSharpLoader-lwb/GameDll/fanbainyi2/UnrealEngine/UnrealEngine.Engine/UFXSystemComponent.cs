using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.FXSystemComponent", "Engine", UnrealModuleType.Engine)]
public class UFXSystemComponent : UPrimitiveComponent
{
	private static bool SetVectorParameter_IsValid;

	private static IntPtr SetVectorParameter_FunctionAddress;

	private static int SetVectorParameter_ParamsSize;

	private static bool SetVectorParameter_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameter_ParameterName_PropertyAddress;

	private static int SetVectorParameter_ParameterName_Offset;

	private static bool SetVectorParameter_Param_IsValid;

	private static FFieldAddress SetVectorParameter_Param_PropertyAddress;

	private static int SetVectorParameter_Param_Offset;

	private static bool SetUseAutoManageAttachment_IsValid;

	private static IntPtr SetUseAutoManageAttachment_FunctionAddress;

	private static int SetUseAutoManageAttachment_ParamsSize;

	private static bool SetUseAutoManageAttachment_bAutoManage_IsValid;

	private static FFieldAddress SetUseAutoManageAttachment_bAutoManage_PropertyAddress;

	private static int SetUseAutoManageAttachment_bAutoManage_Offset;

	private static bool SetIntParameter_IsValid;

	private static IntPtr SetIntParameter_FunctionAddress;

	private static int SetIntParameter_ParamsSize;

	private static bool SetIntParameter_ParameterName_IsValid;

	private static FFieldAddress SetIntParameter_ParameterName_PropertyAddress;

	private static int SetIntParameter_ParameterName_Offset;

	private static bool SetIntParameter_Param_IsValid;

	private static FFieldAddress SetIntParameter_Param_PropertyAddress;

	private static int SetIntParameter_Param_Offset;

	private static bool SetFloatParameter_IsValid;

	private static IntPtr SetFloatParameter_FunctionAddress;

	private static int SetFloatParameter_ParamsSize;

	private static bool SetFloatParameter_ParameterName_IsValid;

	private static FFieldAddress SetFloatParameter_ParameterName_PropertyAddress;

	private static int SetFloatParameter_ParameterName_Offset;

	private static bool SetFloatParameter_Param_IsValid;

	private static FFieldAddress SetFloatParameter_Param_PropertyAddress;

	private static int SetFloatParameter_Param_Offset;

	private static bool SetEmitterEnable_IsValid;

	private static IntPtr SetEmitterEnable_FunctionAddress;

	private static int SetEmitterEnable_ParamsSize;

	private static bool SetEmitterEnable_EmitterName_IsValid;

	private static FFieldAddress SetEmitterEnable_EmitterName_PropertyAddress;

	private static int SetEmitterEnable_EmitterName_Offset;

	private static bool SetEmitterEnable_bNewEnableState_IsValid;

	private static FFieldAddress SetEmitterEnable_bNewEnableState_PropertyAddress;

	private static int SetEmitterEnable_bNewEnableState_Offset;

	private static bool SetColorParameter_IsValid;

	private static IntPtr SetColorParameter_FunctionAddress;

	private static int SetColorParameter_ParamsSize;

	private static bool SetColorParameter_ParameterName_IsValid;

	private static FFieldAddress SetColorParameter_ParameterName_PropertyAddress;

	private static int SetColorParameter_ParameterName_Offset;

	private static bool SetColorParameter_Param_IsValid;

	private static FFieldAddress SetColorParameter_Param_PropertyAddress;

	private static int SetColorParameter_Param_Offset;

	private static bool SetBoolParameter_IsValid;

	private static IntPtr SetBoolParameter_FunctionAddress;

	private static int SetBoolParameter_ParamsSize;

	private static bool SetBoolParameter_ParameterName_IsValid;

	private static FFieldAddress SetBoolParameter_ParameterName_PropertyAddress;

	private static int SetBoolParameter_ParameterName_Offset;

	private static bool SetBoolParameter_Param_IsValid;

	private static FFieldAddress SetBoolParameter_Param_PropertyAddress;

	private static int SetBoolParameter_Param_Offset;

	private static bool SetAutoAttachmentParameters_IsValid;

	private static IntPtr SetAutoAttachmentParameters_FunctionAddress;

	private static int SetAutoAttachmentParameters_ParamsSize;

	private static bool SetAutoAttachmentParameters_Parent_IsValid;

	private static FFieldAddress SetAutoAttachmentParameters_Parent_PropertyAddress;

	private static int SetAutoAttachmentParameters_Parent_Offset;

	private static bool SetAutoAttachmentParameters_SocketName_IsValid;

	private static FFieldAddress SetAutoAttachmentParameters_SocketName_PropertyAddress;

	private static int SetAutoAttachmentParameters_SocketName_Offset;

	private static bool SetAutoAttachmentParameters_LocationRule_IsValid;

	private static FFieldAddress SetAutoAttachmentParameters_LocationRule_PropertyAddress;

	private static int SetAutoAttachmentParameters_LocationRule_Offset;

	private static bool SetAutoAttachmentParameters_RotationRule_IsValid;

	private static FFieldAddress SetAutoAttachmentParameters_RotationRule_PropertyAddress;

	private static int SetAutoAttachmentParameters_RotationRule_Offset;

	private static bool SetAutoAttachmentParameters_ScaleRule_IsValid;

	private static FFieldAddress SetAutoAttachmentParameters_ScaleRule_PropertyAddress;

	private static int SetAutoAttachmentParameters_ScaleRule_Offset;

	private static bool SetActorParameter_IsValid;

	private static IntPtr SetActorParameter_FunctionAddress;

	private static int SetActorParameter_ParamsSize;

	private static bool SetActorParameter_ParameterName_IsValid;

	private static FFieldAddress SetActorParameter_ParameterName_PropertyAddress;

	private static int SetActorParameter_ParameterName_Offset;

	private static bool SetActorParameter_Param_IsValid;

	private static FFieldAddress SetActorParameter_Param_PropertyAddress;

	private static int SetActorParameter_Param_Offset;

	private static bool ReleaseToPool_IsValid;

	private static IntPtr ReleaseToPool_FunctionAddress;

	private static int ReleaseToPool_ParamsSize;

	private static bool GetFXSystemAsset_IsValid;

	private static IntPtr GetFXSystemAsset_FunctionAddress;

	private static int GetFXSystemAsset_ParamsSize;

	private static bool GetFXSystemAsset_ReturnValue_IsValid;

	private static FFieldAddress GetFXSystemAsset_ReturnValue_PropertyAddress;

	private static int GetFXSystemAsset_ReturnValue_Offset;

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetVectorParameter")]
	public unsafe void SetVectorParameter(FName ParameterName, FVector Param)
	{
		CheckDestroyed();
		if (!SetVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetVectorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_ParameterName_Offset), 0, SetVectorParameter_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorParameter_Param_Offset), 0, SetVectorParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameter_FunctionAddress, intPtr, SetVectorParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetUseAutoManageAttachment")]
	public unsafe void SetUseAutoManageAttachment(bool bAutoManage)
	{
		CheckDestroyed();
		if (!SetUseAutoManageAttachment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetUseAutoManageAttachment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseAutoManageAttachment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseAutoManageAttachment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseAutoManageAttachment_bAutoManage_Offset), 0, SetUseAutoManageAttachment_bAutoManage_PropertyAddress.Address, bAutoManage);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseAutoManageAttachment_FunctionAddress, intPtr, SetUseAutoManageAttachment_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetIntParameter")]
	public unsafe void SetIntParameter(FName ParameterName, int Param)
	{
		CheckDestroyed();
		if (!SetIntParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetIntParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIntParameter_ParameterName_Offset), 0, SetIntParameter_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetIntParameter_Param_Offset), 0, SetIntParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntParameter_FunctionAddress, intPtr, SetIntParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetFloatParameter")]
	public unsafe void SetFloatParameter(FName ParameterName, float Param)
	{
		CheckDestroyed();
		if (!SetFloatParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetFloatParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_ParameterName_Offset), 0, SetFloatParameter_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_Param_Offset), 0, SetFloatParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatParameter_FunctionAddress, intPtr, SetFloatParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetEmitterEnable")]
	public unsafe void SetEmitterEnable(FName EmitterName, bool bNewEnableState)
	{
		CheckDestroyed();
		if (!SetEmitterEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetEmitterEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEmitterEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEmitterEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetEmitterEnable_EmitterName_Offset), 0, SetEmitterEnable_EmitterName_PropertyAddress.Address, EmitterName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEmitterEnable_bNewEnableState_Offset), 0, SetEmitterEnable_bNewEnableState_PropertyAddress.Address, bNewEnableState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEmitterEnable_FunctionAddress, intPtr, SetEmitterEnable_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetColorParameter")]
	public unsafe void SetColorParameter(FName ParameterName, FLinearColor Param)
	{
		CheckDestroyed();
		if (!SetColorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetColorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetColorParameter_ParameterName_Offset), 0, SetColorParameter_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorParameter_Param_Offset), 0, SetColorParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorParameter_FunctionAddress, intPtr, SetColorParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetBoolParameter")]
	public unsafe void SetBoolParameter(FName ParameterName, bool Param)
	{
		CheckDestroyed();
		if (!SetBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetBoolParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolParameter_ParameterName_Offset), 0, SetBoolParameter_ParameterName_PropertyAddress.Address, ParameterName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_Param_Offset), 0, SetBoolParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolParameter_FunctionAddress, intPtr, SetBoolParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetAutoAttachmentParameters")]
	public unsafe void SetAutoAttachmentParameters(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule)
	{
		CheckDestroyed();
		if (!SetAutoAttachmentParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetAutoAttachmentParameters");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoAttachmentParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoAttachmentParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetAutoAttachmentParameters_Parent_Offset), 0, SetAutoAttachmentParameters_Parent_PropertyAddress.Address, Parent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAutoAttachmentParameters_SocketName_Offset), 0, SetAutoAttachmentParameters_SocketName_PropertyAddress.Address, SocketName);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, SetAutoAttachmentParameters_LocationRule_Offset), 0, SetAutoAttachmentParameters_LocationRule_PropertyAddress.Address, LocationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, SetAutoAttachmentParameters_RotationRule_Offset), 0, SetAutoAttachmentParameters_RotationRule_PropertyAddress.Address, RotationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, SetAutoAttachmentParameters_ScaleRule_Offset), 0, SetAutoAttachmentParameters_ScaleRule_PropertyAddress.Address, ScaleRule);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoAttachmentParameters_FunctionAddress, intPtr, SetAutoAttachmentParameters_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:SetActorParameter")]
	public unsafe void SetActorParameter(FName ParameterName, AActor Param)
	{
		CheckDestroyed();
		if (!SetActorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:SetActorParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetActorParameter_ParameterName_Offset), 0, SetActorParameter_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorParameter_Param_Offset), 0, SetActorParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorParameter_FunctionAddress, intPtr, SetActorParameter_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:ReleaseToPool")]
	public unsafe void ReleaseToPool()
	{
		CheckDestroyed();
		if (!ReleaseToPool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:ReleaseToPool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseToPool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseToPool_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReleaseToPool_FunctionAddress, argsSize: ReleaseToPool_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.FXSystemComponent:GetFXSystemAsset")]
	public unsafe UFXSystemAsset GetFXSystemAsset()
	{
		CheckDestroyed();
		if (!GetFXSystemAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.FXSystemComponent:GetFXSystemAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFXSystemAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFXSystemAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFXSystemAsset_FunctionAddress, intPtr, GetFXSystemAsset_ParamsSize);
		return UObjectMarshaler<UFXSystemAsset>.FromNative(IntPtr.Add(intPtr, GetFXSystemAsset_ReturnValue_Offset), 0, GetFXSystemAsset_ReturnValue_PropertyAddress.Address);
	}

	static UFXSystemComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFXSystemComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFXSystemComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.FXSystemComponent");
		SetVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVectorParameter");
		SetVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_ParameterName_PropertyAddress, SetVectorParameter_FunctionAddress, "ParameterName");
		SetVectorParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "ParameterName");
		SetVectorParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameter_Param_PropertyAddress, SetVectorParameter_FunctionAddress, "Param");
		SetVectorParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameter_FunctionAddress, "Param");
		SetVectorParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameter_FunctionAddress, "Param", Classes.FStructProperty);
		SetVectorParameter_IsValid = SetVectorParameter_FunctionAddress != IntPtr.Zero && SetVectorParameter_ParameterName_IsValid && SetVectorParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetVectorParameter", SetVectorParameter_IsValid);
		SetUseAutoManageAttachment_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetUseAutoManageAttachment");
		SetUseAutoManageAttachment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseAutoManageAttachment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseAutoManageAttachment_bAutoManage_PropertyAddress, SetUseAutoManageAttachment_FunctionAddress, "bAutoManage");
		SetUseAutoManageAttachment_bAutoManage_Offset = NativeReflectionCached.GetPropertyOffset(SetUseAutoManageAttachment_FunctionAddress, "bAutoManage");
		SetUseAutoManageAttachment_bAutoManage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseAutoManageAttachment_FunctionAddress, "bAutoManage", Classes.FBoolProperty);
		SetUseAutoManageAttachment_IsValid = SetUseAutoManageAttachment_FunctionAddress != IntPtr.Zero && SetUseAutoManageAttachment_bAutoManage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetUseAutoManageAttachment", SetUseAutoManageAttachment_IsValid);
		SetIntParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIntParameter");
		SetIntParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_ParameterName_PropertyAddress, SetIntParameter_FunctionAddress, "ParameterName");
		SetIntParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "ParameterName");
		SetIntParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_Param_PropertyAddress, SetIntParameter_FunctionAddress, "Param");
		SetIntParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_FunctionAddress, "Param");
		SetIntParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_FunctionAddress, "Param", Classes.FIntProperty);
		SetIntParameter_IsValid = SetIntParameter_FunctionAddress != IntPtr.Zero && SetIntParameter_ParameterName_IsValid && SetIntParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetIntParameter", SetIntParameter_IsValid);
		SetFloatParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFloatParameter");
		SetFloatParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_ParameterName_PropertyAddress, SetFloatParameter_FunctionAddress, "ParameterName");
		SetFloatParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "ParameterName");
		SetFloatParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_Param_PropertyAddress, SetFloatParameter_FunctionAddress, "Param");
		SetFloatParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_FunctionAddress, "Param");
		SetFloatParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_FunctionAddress, "Param", Classes.FFloatProperty);
		SetFloatParameter_IsValid = SetFloatParameter_FunctionAddress != IntPtr.Zero && SetFloatParameter_ParameterName_IsValid && SetFloatParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetFloatParameter", SetFloatParameter_IsValid);
		SetEmitterEnable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEmitterEnable");
		SetEmitterEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEmitterEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEmitterEnable_EmitterName_PropertyAddress, SetEmitterEnable_FunctionAddress, "EmitterName");
		SetEmitterEnable_EmitterName_Offset = NativeReflectionCached.GetPropertyOffset(SetEmitterEnable_FunctionAddress, "EmitterName");
		SetEmitterEnable_EmitterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEmitterEnable_FunctionAddress, "EmitterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEmitterEnable_bNewEnableState_PropertyAddress, SetEmitterEnable_FunctionAddress, "bNewEnableState");
		SetEmitterEnable_bNewEnableState_Offset = NativeReflectionCached.GetPropertyOffset(SetEmitterEnable_FunctionAddress, "bNewEnableState");
		SetEmitterEnable_bNewEnableState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEmitterEnable_FunctionAddress, "bNewEnableState", Classes.FBoolProperty);
		SetEmitterEnable_IsValid = SetEmitterEnable_FunctionAddress != IntPtr.Zero && SetEmitterEnable_EmitterName_IsValid && SetEmitterEnable_bNewEnableState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetEmitterEnable", SetEmitterEnable_IsValid);
		SetColorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetColorParameter");
		SetColorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorParameter_ParameterName_PropertyAddress, SetColorParameter_FunctionAddress, "ParameterName");
		SetColorParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetColorParameter_FunctionAddress, "ParameterName");
		SetColorParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorParameter_Param_PropertyAddress, SetColorParameter_FunctionAddress, "Param");
		SetColorParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetColorParameter_FunctionAddress, "Param");
		SetColorParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorParameter_FunctionAddress, "Param", Classes.FStructProperty);
		SetColorParameter_IsValid = SetColorParameter_FunctionAddress != IntPtr.Zero && SetColorParameter_ParameterName_IsValid && SetColorParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetColorParameter", SetColorParameter_IsValid);
		SetBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoolParameter");
		SetBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_ParameterName_PropertyAddress, SetBoolParameter_FunctionAddress, "ParameterName");
		SetBoolParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "ParameterName");
		SetBoolParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_Param_PropertyAddress, SetBoolParameter_FunctionAddress, "Param");
		SetBoolParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_FunctionAddress, "Param");
		SetBoolParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_FunctionAddress, "Param", Classes.FBoolProperty);
		SetBoolParameter_IsValid = SetBoolParameter_FunctionAddress != IntPtr.Zero && SetBoolParameter_ParameterName_IsValid && SetBoolParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetBoolParameter", SetBoolParameter_IsValid);
		SetAutoAttachmentParameters_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAutoAttachmentParameters");
		SetAutoAttachmentParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoAttachmentParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoAttachmentParameters_Parent_PropertyAddress, SetAutoAttachmentParameters_FunctionAddress, "Parent");
		SetAutoAttachmentParameters_Parent_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoAttachmentParameters_FunctionAddress, "Parent");
		SetAutoAttachmentParameters_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoAttachmentParameters_FunctionAddress, "Parent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAutoAttachmentParameters_SocketName_PropertyAddress, SetAutoAttachmentParameters_FunctionAddress, "SocketName");
		SetAutoAttachmentParameters_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoAttachmentParameters_FunctionAddress, "SocketName");
		SetAutoAttachmentParameters_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoAttachmentParameters_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAutoAttachmentParameters_LocationRule_PropertyAddress, SetAutoAttachmentParameters_FunctionAddress, "LocationRule");
		SetAutoAttachmentParameters_LocationRule_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoAttachmentParameters_FunctionAddress, "LocationRule");
		SetAutoAttachmentParameters_LocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoAttachmentParameters_FunctionAddress, "LocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAutoAttachmentParameters_RotationRule_PropertyAddress, SetAutoAttachmentParameters_FunctionAddress, "RotationRule");
		SetAutoAttachmentParameters_RotationRule_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoAttachmentParameters_FunctionAddress, "RotationRule");
		SetAutoAttachmentParameters_RotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoAttachmentParameters_FunctionAddress, "RotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAutoAttachmentParameters_ScaleRule_PropertyAddress, SetAutoAttachmentParameters_FunctionAddress, "ScaleRule");
		SetAutoAttachmentParameters_ScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoAttachmentParameters_FunctionAddress, "ScaleRule");
		SetAutoAttachmentParameters_ScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoAttachmentParameters_FunctionAddress, "ScaleRule", Classes.FEnumProperty);
		SetAutoAttachmentParameters_IsValid = SetAutoAttachmentParameters_FunctionAddress != IntPtr.Zero && SetAutoAttachmentParameters_Parent_IsValid && SetAutoAttachmentParameters_SocketName_IsValid && SetAutoAttachmentParameters_LocationRule_IsValid && SetAutoAttachmentParameters_RotationRule_IsValid && SetAutoAttachmentParameters_ScaleRule_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetAutoAttachmentParameters", SetAutoAttachmentParameters_IsValid);
		SetActorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActorParameter");
		SetActorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorParameter_ParameterName_PropertyAddress, SetActorParameter_FunctionAddress, "ParameterName");
		SetActorParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetActorParameter_FunctionAddress, "ParameterName");
		SetActorParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorParameter_Param_PropertyAddress, SetActorParameter_FunctionAddress, "Param");
		SetActorParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetActorParameter_FunctionAddress, "Param");
		SetActorParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorParameter_FunctionAddress, "Param", Classes.FObjectProperty);
		SetActorParameter_IsValid = SetActorParameter_FunctionAddress != IntPtr.Zero && SetActorParameter_ParameterName_IsValid && SetActorParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:SetActorParameter", SetActorParameter_IsValid);
		ReleaseToPool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReleaseToPool");
		ReleaseToPool_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseToPool_FunctionAddress);
		ReleaseToPool_IsValid = ReleaseToPool_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:ReleaseToPool", ReleaseToPool_IsValid);
		GetFXSystemAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFXSystemAsset");
		GetFXSystemAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFXSystemAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFXSystemAsset_ReturnValue_PropertyAddress, GetFXSystemAsset_FunctionAddress, "ReturnValue");
		GetFXSystemAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFXSystemAsset_FunctionAddress, "ReturnValue");
		GetFXSystemAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFXSystemAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFXSystemAsset_IsValid = GetFXSystemAsset_FunctionAddress != IntPtr.Zero && GetFXSystemAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.FXSystemComponent:GetFXSystemAsset", GetFXSystemAsset_IsValid);
	}
}
