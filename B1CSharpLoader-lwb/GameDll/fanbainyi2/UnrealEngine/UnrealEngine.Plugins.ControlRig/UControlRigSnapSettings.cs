using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)810549412uL, Config = "EditorPerProjectUserSettings")]
[UMetaPath("/Script/ControlRig.ControlRigSnapSettings", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UControlRigSnapSettings : UObject
{
	private static bool KeepOffset_IsValid;

	private static FFieldAddress KeepOffset_PropertyAddress;

	private static int KeepOffset_Offset;

	private static bool SnapPosition_IsValid;

	private static FFieldAddress SnapPosition_PropertyAddress;

	private static int SnapPosition_Offset;

	private static bool SnapRotation_IsValid;

	private static FFieldAddress SnapRotation_PropertyAddress;

	private static int SnapRotation_Offset;

	private static bool SnapScale_IsValid;

	private static FFieldAddress SnapScale_PropertyAddress;

	private static int SnapScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/ControlRig.ControlRigSnapSettings:bKeepOffset")]
	public bool KeepOffset
	{
		get
		{
			CheckDestroyed();
			if (!KeepOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bKeepOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepOffset_Offset), 0, KeepOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bKeepOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepOffset_Offset), 0, KeepOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/ControlRig.ControlRigSnapSettings:bSnapPosition")]
	public bool SnapPosition
	{
		get
		{
			CheckDestroyed();
			if (!SnapPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapPosition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapPosition_Offset), 0, SnapPosition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapPosition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapPosition_Offset), 0, SnapPosition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/ControlRig.ControlRigSnapSettings:bSnapRotation")]
	public bool SnapRotation
	{
		get
		{
			CheckDestroyed();
			if (!SnapRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapRotation_Offset), 0, SnapRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapRotation_Offset), 0, SnapRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/ControlRig.ControlRigSnapSettings:bSnapScale")]
	public bool SnapScale
	{
		get
		{
			CheckDestroyed();
			if (!SnapScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapScale_Offset), 0, SnapScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigSnapSettings:bSnapScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapScale_Offset), 0, SnapScale_PropertyAddress.Address, value);
			}
		}
	}

	static UControlRigSnapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigSnapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigSnapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ControlRig.ControlRigSnapSettings");
		NativeReflectionCached.GetPropertyRef(ref KeepOffset_PropertyAddress, unrealStruct, "bKeepOffset");
		KeepOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepOffset");
		KeepOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapPosition_PropertyAddress, unrealStruct, "bSnapPosition");
		SnapPosition_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSnapPosition");
		SnapPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSnapPosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapRotation_PropertyAddress, unrealStruct, "bSnapRotation");
		SnapRotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSnapRotation");
		SnapRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSnapRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapScale_PropertyAddress, unrealStruct, "bSnapScale");
		SnapScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bSnapScale");
		SnapScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bSnapScale", Classes.FBoolProperty);
	}
}
