using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCreateSplineSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCreateSplineSettings : UPCGSettings
{
	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool ClosedLoop_IsValid;

	private static FFieldAddress ClosedLoop_PropertyAddress;

	private static int ClosedLoop_Offset;

	private static bool Linear_IsValid;

	private static FFieldAddress Linear_PropertyAddress;

	private static int Linear_Offset;

	private static bool ApplyCustomTangents_IsValid;

	private static FFieldAddress ApplyCustomTangents_PropertyAddress;

	private static int ApplyCustomTangents_Offset;

	private static bool ArriveTangentAttribute_IsValid;

	private static int ArriveTangentAttribute_Offset;

	private static bool LeaveTangentAttribute_IsValid;

	private static int LeaveTangentAttribute_Offset;

	private static bool AttachOptions_IsValid;

	private static FFieldAddress AttachOptions_PropertyAddress;

	private static int AttachOptions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:Mode")]
	public EPCGCreateSplineMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:Mode");
				return EPCGCreateSplineMode.CreateDataOnly;
			}
			return EnumMarshaler<EPCGCreateSplineMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGCreateSplineMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:bClosedLoop")]
	public bool ClosedLoop
	{
		get
		{
			CheckDestroyed();
			if (!ClosedLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bClosedLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClosedLoop_Offset), 0, ClosedLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClosedLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bClosedLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClosedLoop_Offset), 0, ClosedLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:bLinear")]
	public bool Linear
	{
		get
		{
			CheckDestroyed();
			if (!Linear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bLinear");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Linear_Offset), 0, Linear_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Linear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bLinear");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Linear_Offset), 0, Linear_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:bApplyCustomTangents")]
	public bool ApplyCustomTangents
	{
		get
		{
			CheckDestroyed();
			if (!ApplyCustomTangents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bApplyCustomTangents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyCustomTangents_Offset), 0, ApplyCustomTangents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyCustomTangents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:bApplyCustomTangents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyCustomTangents_Offset), 0, ApplyCustomTangents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:ArriveTangentAttribute")]
	public FName ArriveTangentAttribute
	{
		get
		{
			CheckDestroyed();
			if (!ArriveTangentAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:ArriveTangentAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ArriveTangentAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArriveTangentAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:ArriveTangentAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ArriveTangentAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:LeaveTangentAttribute")]
	public FName LeaveTangentAttribute
	{
		get
		{
			CheckDestroyed();
			if (!LeaveTangentAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:LeaveTangentAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LeaveTangentAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeaveTangentAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:LeaveTangentAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LeaveTangentAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGCreateSplineSettings:AttachOptions")]
	public EPCGAttachOptions AttachOptions
	{
		get
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:AttachOptions");
				return EPCGAttachOptions.NotAttached;
			}
			return EnumMarshaler<EPCGAttachOptions>.FromNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCreateSplineSettings:AttachOptions");
			}
			else
			{
				EnumMarshaler<EPCGAttachOptions>.ToNative(IntPtr.Add(base.Address, AttachOptions_Offset), 0, AttachOptions_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGCreateSplineSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCreateSplineSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCreateSplineSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCreateSplineSettings");
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ClosedLoop_PropertyAddress, unrealStruct, "bClosedLoop");
		ClosedLoop_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bClosedLoop");
		ClosedLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bClosedLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Linear_PropertyAddress, unrealStruct, "bLinear");
		Linear_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLinear");
		Linear_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLinear", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyCustomTangents_PropertyAddress, unrealStruct, "bApplyCustomTangents");
		ApplyCustomTangents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bApplyCustomTangents");
		ApplyCustomTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bApplyCustomTangents", Classes.FBoolProperty);
		ArriveTangentAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ArriveTangentAttribute");
		ArriveTangentAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ArriveTangentAttribute", Classes.FNameProperty);
		LeaveTangentAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LeaveTangentAttribute");
		LeaveTangentAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LeaveTangentAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachOptions_PropertyAddress, unrealStruct, "AttachOptions");
		AttachOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachOptions");
		AttachOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachOptions", Classes.FEnumProperty);
	}
}
