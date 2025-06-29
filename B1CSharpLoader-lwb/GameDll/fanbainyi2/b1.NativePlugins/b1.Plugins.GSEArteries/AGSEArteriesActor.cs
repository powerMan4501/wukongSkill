using System;
using System.Runtime.CompilerServices;
using b1.Plugins.Arteries;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEArteries.GSEArteriesActor", "GSEArteries", UnrealModuleType.GamePlugin)]
public class AGSEArteriesActor : AArteriesActor
{
	private static bool EnableCollision_IsValid;

	private static FFieldAddress EnableCollision_PropertyAddress;

	private static int EnableCollision_Offset;

	private static bool MobilityMode_IsValid;

	private static FFieldAddress MobilityMode_PropertyAddress;

	private static int MobilityMode_Offset;

	private static bool InteractType_IsValid;

	private static FFieldAddress InteractType_PropertyAddress;

	private static int InteractType_Offset;

	private static bool GSEArteriesSplineComp_IsValid;

	private static int GSEArteriesSplineComp_Offset;

	private static bool UpdateMobility_IsValid;

	private static IntPtr UpdateMobility_FunctionAddress;

	private static int UpdateMobility_ParamsSize;

	private static bool UpdateInteractComp_IsValid;

	private static IntPtr UpdateInteractComp_FunctionAddress;

	private static int UpdateInteractComp_ParamsSize;

	private static bool UpdateHISMCollision_IsValid;

	private static IntPtr UpdateHISMCollision_FunctionAddress;

	private static int UpdateHISMCollision_ParamsSize;

	private static bool SetSplineUnitLength_IsValid;

	private static IntPtr SetSplineUnitLength_FunctionAddress;

	private static int SetSplineUnitLength_ParamsSize;

	private static bool SetSplineUnitLength_Length_IsValid;

	private static FFieldAddress SetSplineUnitLength_Length_PropertyAddress;

	private static int SetSplineUnitLength_Length_Offset;

	private static bool CloseSplineAndBuild_IsValid;

	private static IntPtr CloseSplineAndBuild_FunctionAddress;

	private static int CloseSplineAndBuild_ParamsSize;

	private static bool CloseSplineAndBuild_CloseDistance_IsValid;

	private static FFieldAddress CloseSplineAndBuild_CloseDistance_PropertyAddress;

	private static int CloseSplineAndBuild_CloseDistance_Offset;

	private static bool CloseSplineAndBuild_ReturnValue_IsValid;

	private static FFieldAddress CloseSplineAndBuild_ReturnValue_PropertyAddress;

	private static int CloseSplineAndBuild_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:bEnableCollision")]
	public bool EnableCollision
	{
		get
		{
			CheckDestroyed();
			if (!EnableCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:bEnableCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:bEnableCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:MobilityMode")]
	public EComponentMobility MobilityMode
	{
		get
		{
			CheckDestroyed();
			if (!MobilityMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:MobilityMode");
				return EComponentMobility.Static;
			}
			return EnumMarshaler<EComponentMobility>.FromNative(IntPtr.Add(base.Address, MobilityMode_Offset), 0, MobilityMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MobilityMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:MobilityMode");
			}
			else
			{
				EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(base.Address, MobilityMode_Offset), 0, MobilityMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:InteractType")]
	protected EGSArteriesIteractType InteractType
	{
		get
		{
			CheckDestroyed();
			if (!InteractType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:InteractType");
				return EGSArteriesIteractType.Spline;
			}
			return EnumMarshaler<EGSArteriesIteractType>.FromNative(IntPtr.Add(base.Address, InteractType_Offset), 0, InteractType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InteractType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:InteractType");
			}
			else
			{
				EnumMarshaler<EGSArteriesIteractType>.ToNative(IntPtr.Add(base.Address, InteractType_Offset), 0, InteractType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955191837uL)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:GSEArteriesSplineComp")]
	protected UGSEArteriesSplineComponent GSEArteriesSplineComp
	{
		get
		{
			CheckDestroyed();
			if (!GSEArteriesSplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:GSEArteriesSplineComp");
				return null;
			}
			return UObjectMarshaler<UGSEArteriesSplineComponent>.FromNative(IntPtr.Add(base.Address, GSEArteriesSplineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSEArteriesSplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEArteries.GSEArteriesActor:GSEArteriesSplineComp");
			}
			else
			{
				UObjectMarshaler<UGSEArteriesSplineComponent>.ToNative(IntPtr.Add(base.Address, GSEArteriesSplineComp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:UpdateMobility")]
	public unsafe void UpdateMobility()
	{
		CheckDestroyed();
		if (!UpdateMobility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesActor:UpdateMobility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateMobility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateMobility_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateMobility_FunctionAddress, argsSize: UpdateMobility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:UpdateInteractComp")]
	public unsafe void UpdateInteractComp()
	{
		CheckDestroyed();
		if (!UpdateInteractComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesActor:UpdateInteractComp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateInteractComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateInteractComp_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateInteractComp_FunctionAddress, argsSize: UpdateInteractComp_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:UpdateHISMCollision")]
	public unsafe void UpdateHISMCollision()
	{
		CheckDestroyed();
		if (!UpdateHISMCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesActor:UpdateHISMCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateHISMCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateHISMCollision_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateHISMCollision_FunctionAddress, argsSize: UpdateHISMCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:SetSplineUnitLength")]
	public unsafe void SetSplineUnitLength(float Length)
	{
		CheckDestroyed();
		if (!SetSplineUnitLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesActor:SetSplineUnitLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineUnitLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineUnitLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSplineUnitLength_Length_Offset), 0, SetSplineUnitLength_Length_PropertyAddress.Address, Length);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplineUnitLength_FunctionAddress, intPtr, SetSplineUnitLength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesActor:CloseSplineAndBuild")]
	public unsafe bool CloseSplineAndBuild(float CloseDistance)
	{
		CheckDestroyed();
		if (!CloseSplineAndBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesActor:CloseSplineAndBuild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseSplineAndBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseSplineAndBuild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CloseSplineAndBuild_CloseDistance_Offset), 0, CloseSplineAndBuild_CloseDistance_PropertyAddress.Address, CloseDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseSplineAndBuild_FunctionAddress, intPtr, CloseSplineAndBuild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CloseSplineAndBuild_ReturnValue_Offset), 0, CloseSplineAndBuild_ReturnValue_PropertyAddress.Address);
	}

	static AGSEArteriesActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEArteriesActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEArteriesActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSEArteries.GSEArteriesActor");
		NativeReflectionCached.GetPropertyRef(ref EnableCollision_PropertyAddress, intPtr, "bEnableCollision");
		EnableCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCollision");
		EnableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MobilityMode_PropertyAddress, intPtr, "MobilityMode");
		MobilityMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MobilityMode");
		MobilityMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MobilityMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InteractType_PropertyAddress, intPtr, "InteractType");
		InteractType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractType");
		InteractType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractType", Classes.FEnumProperty);
		GSEArteriesSplineComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSEArteriesSplineComp");
		GSEArteriesSplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSEArteriesSplineComp", Classes.FObjectProperty);
		UpdateMobility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateMobility");
		UpdateMobility_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMobility_FunctionAddress);
		UpdateMobility_IsValid = UpdateMobility_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesActor:UpdateMobility", UpdateMobility_IsValid);
		UpdateInteractComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateInteractComp");
		UpdateInteractComp_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateInteractComp_FunctionAddress);
		UpdateInteractComp_IsValid = UpdateInteractComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesActor:UpdateInteractComp", UpdateInteractComp_IsValid);
		UpdateHISMCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateHISMCollision");
		UpdateHISMCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateHISMCollision_FunctionAddress);
		UpdateHISMCollision_IsValid = UpdateHISMCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesActor:UpdateHISMCollision", UpdateHISMCollision_IsValid);
		SetSplineUnitLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplineUnitLength");
		SetSplineUnitLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineUnitLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineUnitLength_Length_PropertyAddress, SetSplineUnitLength_FunctionAddress, "Length");
		SetSplineUnitLength_Length_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineUnitLength_FunctionAddress, "Length");
		SetSplineUnitLength_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineUnitLength_FunctionAddress, "Length", Classes.FFloatProperty);
		SetSplineUnitLength_IsValid = SetSplineUnitLength_FunctionAddress != IntPtr.Zero && SetSplineUnitLength_Length_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesActor:SetSplineUnitLength", SetSplineUnitLength_IsValid);
		CloseSplineAndBuild_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CloseSplineAndBuild");
		CloseSplineAndBuild_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseSplineAndBuild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseSplineAndBuild_CloseDistance_PropertyAddress, CloseSplineAndBuild_FunctionAddress, "CloseDistance");
		CloseSplineAndBuild_CloseDistance_Offset = NativeReflectionCached.GetPropertyOffset(CloseSplineAndBuild_FunctionAddress, "CloseDistance");
		CloseSplineAndBuild_CloseDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseSplineAndBuild_FunctionAddress, "CloseDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseSplineAndBuild_ReturnValue_PropertyAddress, CloseSplineAndBuild_FunctionAddress, "ReturnValue");
		CloseSplineAndBuild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseSplineAndBuild_FunctionAddress, "ReturnValue");
		CloseSplineAndBuild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseSplineAndBuild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CloseSplineAndBuild_IsValid = CloseSplineAndBuild_FunctionAddress != IntPtr.Zero && CloseSplineAndBuild_CloseDistance_IsValid && CloseSplineAndBuild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesActor:CloseSplineAndBuild", CloseSplineAndBuild_IsValid);
	}
}
