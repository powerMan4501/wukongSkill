using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NavigationSystem.NavigationTestingActor", "NavigationSystem", UnrealModuleType.Engine)]
public class ANavigationTestingActor : AActor, INavAgentInterface, IInterface, INavPathObserverInterface
{
	private static bool ProjectedLocation_IsValid;

	private static int ProjectedLocation_Offset;

	private static bool ProjectedLocationValid_IsValid;

	private static FFieldAddress ProjectedLocationValid_PropertyAddress;

	private static int ProjectedLocationValid_Offset;

	private static bool PathExist_IsValid;

	private static FFieldAddress PathExist_PropertyAddress;

	private static int PathExist_Offset;

	private static bool PathIsPartial_IsValid;

	private static FFieldAddress PathIsPartial_PropertyAddress;

	private static int PathIsPartial_Offset;

	private static bool PathSearchOutOfNodes_IsValid;

	private static FFieldAddress PathSearchOutOfNodes_PropertyAddress;

	private static int PathSearchOutOfNodes_Offset;

	private static bool PathfindingTime_IsValid;

	private static int PathfindingTime_Offset;

	private static bool PathCost_IsValid;

	private static int PathCost_Offset;

	private static bool PathfindingSteps_IsValid;

	private static int PathfindingSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:ProjectedLocation")]
	public FVector ProjectedLocation
	{
		get
		{
			CheckDestroyed();
			if (!ProjectedLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:ProjectedLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ProjectedLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectedLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:ProjectedLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ProjectedLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160663573uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:bProjectedLocationValid")]
	public bool ProjectedLocationValid
	{
		get
		{
			CheckDestroyed();
			if (!ProjectedLocationValid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bProjectedLocationValid");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProjectedLocationValid_Offset), 0, ProjectedLocationValid_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectedLocationValid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bProjectedLocationValid");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProjectedLocationValid_Offset), 0, ProjectedLocationValid_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160671765uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:bPathExist")]
	public bool PathExist
	{
		get
		{
			CheckDestroyed();
			if (!PathExist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathExist");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PathExist_Offset), 0, PathExist_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PathExist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathExist");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PathExist_Offset), 0, PathExist_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160671765uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:bPathIsPartial")]
	public bool PathIsPartial
	{
		get
		{
			CheckDestroyed();
			if (!PathIsPartial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathIsPartial");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PathIsPartial_Offset), 0, PathIsPartial_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PathIsPartial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathIsPartial");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PathIsPartial_Offset), 0, PathIsPartial_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160671765uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:bPathSearchOutOfNodes")]
	public bool PathSearchOutOfNodes
	{
		get
		{
			CheckDestroyed();
			if (!PathSearchOutOfNodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathSearchOutOfNodes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PathSearchOutOfNodes_Offset), 0, PathSearchOutOfNodes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PathSearchOutOfNodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:bPathSearchOutOfNodes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PathSearchOutOfNodes_Offset), 0, PathSearchOutOfNodes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:PathfindingTime")]
	public float PathfindingTime
	{
		get
		{
			CheckDestroyed();
			if (!PathfindingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathfindingTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PathfindingTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PathfindingTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathfindingTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PathfindingTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:PathCost")]
	public float PathCost
	{
		get
		{
			CheckDestroyed();
			if (!PathCost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathCost");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PathCost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PathCost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathCost");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PathCost_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationTestingActor:PathfindingSteps")]
	public int PathfindingSteps
	{
		get
		{
			CheckDestroyed();
			if (!PathfindingSteps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathfindingSteps");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PathfindingSteps_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PathfindingSteps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationTestingActor:PathfindingSteps");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PathfindingSteps_Offset), value);
			}
		}
	}

	static ANavigationTestingActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANavigationTestingActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANavigationTestingActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/NavigationSystem.NavigationTestingActor");
		ProjectedLocation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProjectedLocation");
		ProjectedLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProjectedLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectedLocationValid_PropertyAddress, unrealStruct, "bProjectedLocationValid");
		ProjectedLocationValid_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bProjectedLocationValid");
		ProjectedLocationValid_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bProjectedLocationValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PathExist_PropertyAddress, unrealStruct, "bPathExist");
		PathExist_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPathExist");
		PathExist_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPathExist", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PathIsPartial_PropertyAddress, unrealStruct, "bPathIsPartial");
		PathIsPartial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPathIsPartial");
		PathIsPartial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPathIsPartial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PathSearchOutOfNodes_PropertyAddress, unrealStruct, "bPathSearchOutOfNodes");
		PathSearchOutOfNodes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPathSearchOutOfNodes");
		PathSearchOutOfNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPathSearchOutOfNodes", Classes.FBoolProperty);
		PathfindingTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PathfindingTime");
		PathfindingTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PathfindingTime", Classes.FFloatProperty);
		PathCost_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PathCost");
		PathCost_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PathCost", Classes.FFloatProperty);
		PathfindingSteps_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PathfindingSteps");
		PathfindingSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PathfindingSteps", Classes.FIntProperty);
	}
}
