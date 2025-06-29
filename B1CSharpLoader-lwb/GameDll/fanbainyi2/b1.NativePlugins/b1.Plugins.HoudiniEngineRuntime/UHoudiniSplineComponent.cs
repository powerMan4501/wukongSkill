using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public class UHoudiniSplineComponent : USceneComponent, IHoudiniEngineCopyPropertiesInterface, IInterface
{
	private static bool HoudiniSplineName_IsValid;

	private static int HoudiniSplineName_Offset;

	private static bool Closed_IsValid;

	private static FFieldAddress Closed_PropertyAddress;

	private static int Closed_Offset;

	private static bool Reversed_IsValid;

	private static FFieldAddress Reversed_PropertyAddress;

	private static int Reversed_Offset;

	private static bool CurveOrder_IsValid;

	private static int CurveOrder_Offset;

	private static bool IsHoudiniSplineVisible_IsValid;

	private static FFieldAddress IsHoudiniSplineVisible_PropertyAddress;

	private static int IsHoudiniSplineVisible_Offset;

	private static bool CurveType_IsValid;

	private static FFieldAddress CurveType_PropertyAddress;

	private static int CurveType_Offset;

	private static bool CurveMethod_IsValid;

	private static FFieldAddress CurveMethod_PropertyAddress;

	private static int CurveMethod_Offset;

	private static bool CurveBreakpointParameterization_IsValid;

	private static FFieldAddress CurveBreakpointParameterization_PropertyAddress;

	private static int CurveBreakpointParameterization_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:HoudiniSplineName")]
	public string HoudiniSplineName
	{
		get
		{
			CheckDestroyed();
			if (!HoudiniSplineName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:HoudiniSplineName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, HoudiniSplineName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoudiniSplineName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:HoudiniSplineName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, HoudiniSplineName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bClosed")]
	public bool Closed
	{
		get
		{
			CheckDestroyed();
			if (!Closed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bClosed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Closed_Offset), 0, Closed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Closed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bClosed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Closed_Offset), 0, Closed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bReversed")]
	public bool Reversed
	{
		get
		{
			CheckDestroyed();
			if (!Reversed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bReversed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Reversed_Offset), 0, Reversed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Reversed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bReversed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Reversed_Offset), 0, Reversed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveOrder")]
	public int CurveOrder
	{
		get
		{
			CheckDestroyed();
			if (!CurveOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveOrder");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurveOrder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveOrder");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurveOrder_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bIsHoudiniSplineVisible")]
	public bool IsHoudiniSplineVisible
	{
		get
		{
			CheckDestroyed();
			if (!IsHoudiniSplineVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bIsHoudiniSplineVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsHoudiniSplineVisible_Offset), 0, IsHoudiniSplineVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsHoudiniSplineVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:bIsHoudiniSplineVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsHoudiniSplineVisible_Offset), 0, IsHoudiniSplineVisible_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveType")]
	public EHoudiniCurveType CurveType
	{
		get
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveType");
				return EHoudiniCurveType.Polygon;
			}
			return EnumMarshaler<EHoudiniCurveType>.FromNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveType");
			}
			else
			{
				EnumMarshaler<EHoudiniCurveType>.ToNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveMethod")]
	public EHoudiniCurveMethod CurveMethod
	{
		get
		{
			CheckDestroyed();
			if (!CurveMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveMethod");
				return EHoudiniCurveMethod.CVs;
			}
			return EnumMarshaler<EHoudiniCurveMethod>.FromNative(IntPtr.Add(base.Address, CurveMethod_Offset), 0, CurveMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurveMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveMethod");
			}
			else
			{
				EnumMarshaler<EHoudiniCurveMethod>.ToNative(IntPtr.Add(base.Address, CurveMethod_Offset), 0, CurveMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveBreakpointParameterization")]
	public EHoudiniCurveBreakpointParameterization CurveBreakpointParameterization
	{
		get
		{
			CheckDestroyed();
			if (!CurveBreakpointParameterization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveBreakpointParameterization");
				return EHoudiniCurveBreakpointParameterization.Uniform;
			}
			return EnumMarshaler<EHoudiniCurveBreakpointParameterization>.FromNative(IntPtr.Add(base.Address, CurveBreakpointParameterization_Offset), 0, CurveBreakpointParameterization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurveBreakpointParameterization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniSplineComponent:CurveBreakpointParameterization");
			}
			else
			{
				EnumMarshaler<EHoudiniCurveBreakpointParameterization>.ToNative(IntPtr.Add(base.Address, CurveBreakpointParameterization_Offset), 0, CurveBreakpointParameterization_PropertyAddress.Address, value);
			}
		}
	}

	static UHoudiniSplineComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHoudiniSplineComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHoudiniSplineComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HoudiniEngineRuntime.HoudiniSplineComponent");
		HoudiniSplineName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoudiniSplineName");
		HoudiniSplineName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoudiniSplineName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Closed_PropertyAddress, unrealStruct, "bClosed");
		Closed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bClosed");
		Closed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bClosed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Reversed_PropertyAddress, unrealStruct, "bReversed");
		Reversed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReversed");
		Reversed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReversed", Classes.FBoolProperty);
		CurveOrder_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveOrder");
		CurveOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHoudiniSplineVisible_PropertyAddress, unrealStruct, "bIsHoudiniSplineVisible");
		IsHoudiniSplineVisible_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsHoudiniSplineVisible");
		IsHoudiniSplineVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsHoudiniSplineVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveType_PropertyAddress, unrealStruct, "CurveType");
		CurveType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveType");
		CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveMethod_PropertyAddress, unrealStruct, "CurveMethod");
		CurveMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveMethod");
		CurveMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveBreakpointParameterization_PropertyAddress, unrealStruct, "CurveBreakpointParameterization");
		CurveBreakpointParameterization_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveBreakpointParameterization");
		CurveBreakpointParameterization_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveBreakpointParameterization", Classes.FEnumProperty);
	}
}
