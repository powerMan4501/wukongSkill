using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp", "UnrealExtent", UnrealModuleType.Game)]
public class UHitPhysicalAnimComp : UPhysicalAnimationComponent
{
	private static bool PhysicalAnimationData_IsValid;

	private static int PhysicalAnimationData_Offset;

	private static bool WeightCurve_IsValid;

	private static int WeightCurve_Offset;

	private static bool HitSegmentation_IsValid;

	private static int HitSegmentation_Offset;

	private static bool CurveWeightAtTime_IsValid;

	private static int CurveWeightAtTime_Offset;

	private static bool TimeSum_IsValid;

	private static int TimeSum_Offset;

	private static bool HitBoneNames_IsValid;

	private static FFieldAddress HitBoneNames_PropertyAddress;

	private static int HitBoneNames_Offset;

	private TArrayReadOnlyMarshaler<FName> HitBoneNames_MarshalerCached;

	private static bool ForceVector_IsValid;

	private static int ForceVector_Offset;

	private static bool ForceStrength_IsValid;

	private static int ForceStrength_Offset;

	private static bool InitiazliePhysicalAnimation_IsValid;

	private static IntPtr InitiazliePhysicalAnimation_FunctionAddress;

	private static int InitiazliePhysicalAnimation_ParamsSize;

	private static bool BeHit_IsValid;

	private static IntPtr BeHit_FunctionAddress;

	private static int BeHit_ParamsSize;

	private static bool BeHit_BoneList_IsValid;

	private static FFieldAddress BeHit_BoneList_PropertyAddress;

	private static int BeHit_BoneList_Offset;

	private static bool BeHit_InForceVector_IsValid;

	private static FFieldAddress BeHit_InForceVector_PropertyAddress;

	private static int BeHit_InForceVector_Offset;

	private static bool BeHit_InForceStrength_IsValid;

	private static FFieldAddress BeHit_InForceStrength_PropertyAddress;

	private static int BeHit_InForceStrength_Offset;

	private static bool BeHit_ReturnValue_IsValid;

	private static FFieldAddress BeHit_ReturnValue_PropertyAddress;

	private static int BeHit_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:PhysicalAnimationData")]
	public FPhysicalAnimationData PhysicalAnimationData
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalAnimationData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:PhysicalAnimationData");
				return default(FPhysicalAnimationData);
			}
			return FPhysicalAnimationData.FromNative(IntPtr.Add(base.Address, PhysicalAnimationData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicalAnimationData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:PhysicalAnimationData");
			}
			else
			{
				FPhysicalAnimationData.ToNative(IntPtr.Add(base.Address, PhysicalAnimationData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:WeightCurve")]
	public UCurveFloat WeightCurve
	{
		get
		{
			CheckDestroyed();
			if (!WeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:WeightCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, WeightCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:WeightCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, WeightCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:HitSegmentation")]
	public int HitSegmentation
	{
		get
		{
			CheckDestroyed();
			if (!HitSegmentation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:HitSegmentation");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitSegmentation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitSegmentation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:HitSegmentation");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitSegmentation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:CurveWeightAtTime")]
	public float CurveWeightAtTime
	{
		get
		{
			CheckDestroyed();
			if (!CurveWeightAtTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:CurveWeightAtTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurveWeightAtTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveWeightAtTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:CurveWeightAtTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurveWeightAtTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:TimeSum")]
	public float TimeSum
	{
		get
		{
			CheckDestroyed();
			if (!TimeSum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:TimeSum");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeSum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeSum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:TimeSum");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeSum_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:HitBoneNames")]
	public TArrayReadOnly<FName> HitBoneNames
	{
		get
		{
			CheckDestroyed();
			if (!HitBoneNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:HitBoneNames");
				return null;
			}
			if (HitBoneNames_MarshalerCached == null)
			{
				HitBoneNames_MarshalerCached = new TArrayReadOnlyMarshaler<FName>(1, HitBoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return HitBoneNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, HitBoneNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:ForceVector")]
	public FVector ForceVector
	{
		get
		{
			CheckDestroyed();
			if (!ForceVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:ForceVector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ForceVector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:ForceVector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ForceVector_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:ForceStrength")]
	public float ForceStrength
	{
		get
		{
			CheckDestroyed();
			if (!ForceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:ForceStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForceStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:ForceStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForceStrength_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:InitiazliePhysicalAnimation")]
	public unsafe void InitiazliePhysicalAnimation()
	{
		CheckDestroyed();
		if (!InitiazliePhysicalAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:InitiazliePhysicalAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitiazliePhysicalAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitiazliePhysicalAnimation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitiazliePhysicalAnimation_FunctionAddress, argsSize: InitiazliePhysicalAnimation_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.HitPhysicalAnimComp:BeHit")]
	public unsafe bool BeHit(List<FName> BoneList, FVector InForceVector, float InForceStrength)
	{
		CheckDestroyed();
		if (!BeHit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HitPhysicalAnimComp:BeHit");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeHit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeHit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, BeHit_BoneList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, BeHit_BoneList_Offset), BoneList);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BeHit_InForceVector_Offset), 0, BeHit_InForceVector_PropertyAddress.Address, InForceVector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeHit_InForceStrength_Offset), 0, BeHit_InForceStrength_PropertyAddress.Address, InForceStrength);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeHit_FunctionAddress, intPtr, BeHit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BeHit_BoneList_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BeHit_ReturnValue_Offset), 0, BeHit_ReturnValue_PropertyAddress.Address);
	}

	static UHitPhysicalAnimComp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHitPhysicalAnimComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHitPhysicalAnimComp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.HitPhysicalAnimComp");
		PhysicalAnimationData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicalAnimationData");
		PhysicalAnimationData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicalAnimationData", Classes.FStructProperty);
		WeightCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightCurve");
		WeightCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightCurve", Classes.FObjectProperty);
		HitSegmentation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitSegmentation");
		HitSegmentation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitSegmentation", Classes.FIntProperty);
		CurveWeightAtTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveWeightAtTime");
		CurveWeightAtTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveWeightAtTime", Classes.FFloatProperty);
		TimeSum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeSum");
		TimeSum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeSum", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HitBoneNames_PropertyAddress, intPtr, "HitBoneNames");
		HitBoneNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitBoneNames");
		HitBoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitBoneNames", Classes.FArrayProperty);
		ForceVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceVector");
		ForceVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceVector", Classes.FStructProperty);
		ForceStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceStrength");
		ForceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceStrength", Classes.FFloatProperty);
		InitiazliePhysicalAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitiazliePhysicalAnimation");
		InitiazliePhysicalAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(InitiazliePhysicalAnimation_FunctionAddress);
		InitiazliePhysicalAnimation_IsValid = InitiazliePhysicalAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.HitPhysicalAnimComp:InitiazliePhysicalAnimation", InitiazliePhysicalAnimation_IsValid);
		BeHit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeHit");
		BeHit_ParamsSize = NativeReflection.GetFunctionParamsSize(BeHit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeHit_BoneList_PropertyAddress, BeHit_FunctionAddress, "BoneList");
		BeHit_BoneList_Offset = NativeReflectionCached.GetPropertyOffset(BeHit_FunctionAddress, "BoneList");
		BeHit_BoneList_IsValid = NativeReflectionCached.ValidatePropertyClass(BeHit_FunctionAddress, "BoneList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BeHit_InForceVector_PropertyAddress, BeHit_FunctionAddress, "InForceVector");
		BeHit_InForceVector_Offset = NativeReflectionCached.GetPropertyOffset(BeHit_FunctionAddress, "InForceVector");
		BeHit_InForceVector_IsValid = NativeReflectionCached.ValidatePropertyClass(BeHit_FunctionAddress, "InForceVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BeHit_InForceStrength_PropertyAddress, BeHit_FunctionAddress, "InForceStrength");
		BeHit_InForceStrength_Offset = NativeReflectionCached.GetPropertyOffset(BeHit_FunctionAddress, "InForceStrength");
		BeHit_InForceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(BeHit_FunctionAddress, "InForceStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BeHit_ReturnValue_PropertyAddress, BeHit_FunctionAddress, "ReturnValue");
		BeHit_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BeHit_FunctionAddress, "ReturnValue");
		BeHit_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BeHit_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BeHit_IsValid = BeHit_FunctionAddress != IntPtr.Zero && BeHit_BoneList_IsValid && BeHit_InForceVector_IsValid && BeHit_InForceStrength_IsValid && BeHit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.HitPhysicalAnimComp:BeHit", BeHit_IsValid);
	}
}
