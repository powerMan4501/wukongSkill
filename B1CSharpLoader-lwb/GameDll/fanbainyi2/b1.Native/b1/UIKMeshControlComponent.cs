using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent", "UnrealExtent", UnrealModuleType.Game)]
public class UIKMeshControlComponent : UActorComponent
{
	private static bool IsTraceDebug_IsValid;

	private static FFieldAddress IsTraceDebug_PropertyAddress;

	private static int IsTraceDebug_Offset;

	private static bool IsIKActive_IsValid;

	private static FFieldAddress IsIKActive_PropertyAddress;

	private static int IsIKActive_Offset;

	private static bool IKFootLeftBoneName_IsValid;

	private static int IKFootLeftBoneName_Offset;

	private static bool IKFootRightoneName_IsValid;

	private static int IKFootRightoneName_Offset;

	private static bool MaxCheckSpeed_IsValid;

	private static int MaxCheckSpeed_Offset;

	private static bool TraceDepth_IsValid;

	private static int TraceDepth_Offset;

	private static bool OffsetLerpAlpha_IsValid;

	private static int OffsetLerpAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:bIsTraceDebug")]
	public bool IsTraceDebug
	{
		get
		{
			CheckDestroyed();
			if (!IsTraceDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:bIsTraceDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTraceDebug_Offset), 0, IsTraceDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTraceDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:bIsTraceDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTraceDebug_Offset), 0, IsTraceDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:bIsIKActive")]
	public bool IsIKActive
	{
		get
		{
			CheckDestroyed();
			if (!IsIKActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:bIsIKActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsIKActive_Offset), 0, IsIKActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsIKActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:bIsIKActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsIKActive_Offset), 0, IsIKActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:IKFootLeftBoneName")]
	public FName IKFootLeftBoneName
	{
		get
		{
			CheckDestroyed();
			if (!IKFootLeftBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:IKFootLeftBoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, IKFootLeftBoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKFootLeftBoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:IKFootLeftBoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, IKFootLeftBoneName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:IKFootRightoneName")]
	public FName IKFootRightoneName
	{
		get
		{
			CheckDestroyed();
			if (!IKFootRightoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:IKFootRightoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, IKFootRightoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKFootRightoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:IKFootRightoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, IKFootRightoneName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:MaxCheckSpeed")]
	public float MaxCheckSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxCheckSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:MaxCheckSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxCheckSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCheckSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:MaxCheckSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxCheckSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:TraceDepth")]
	public float TraceDepth
	{
		get
		{
			CheckDestroyed();
			if (!TraceDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:TraceDepth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:TraceDepth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDepth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.IKMeshControlComponent:OffsetLerpAlpha")]
	public float OffsetLerpAlpha
	{
		get
		{
			CheckDestroyed();
			if (!OffsetLerpAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:OffsetLerpAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OffsetLerpAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetLerpAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.IKMeshControlComponent:OffsetLerpAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OffsetLerpAlpha_Offset), value);
			}
		}
	}

	static UIKMeshControlComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UIKMeshControlComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UIKMeshControlComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.IKMeshControlComponent");
		NativeReflectionCached.GetPropertyRef(ref IsTraceDebug_PropertyAddress, unrealStruct, "bIsTraceDebug");
		IsTraceDebug_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsTraceDebug");
		IsTraceDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsTraceDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIKActive_PropertyAddress, unrealStruct, "bIsIKActive");
		IsIKActive_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsIKActive");
		IsIKActive_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsIKActive", Classes.FBoolProperty);
		IKFootLeftBoneName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IKFootLeftBoneName");
		IKFootLeftBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IKFootLeftBoneName", Classes.FNameProperty);
		IKFootRightoneName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IKFootRightoneName");
		IKFootRightoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IKFootRightoneName", Classes.FNameProperty);
		MaxCheckSpeed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxCheckSpeed");
		MaxCheckSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxCheckSpeed", Classes.FFloatProperty);
		TraceDepth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TraceDepth");
		TraceDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TraceDepth", Classes.FFloatProperty);
		OffsetLerpAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OffsetLerpAlpha");
		OffsetLerpAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OffsetLerpAlpha", Classes.FFloatProperty);
	}
}
