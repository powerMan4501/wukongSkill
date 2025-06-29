using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.DataprepIsClassOfFetcher", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepIsClassOfFetcher : UDataprepBoolFetcher
{
	private static bool Class_IsValid;

	private static int Class_Offset;

	private static bool ShouldIncludeChildClass_IsValid;

	private static FFieldAddress ShouldIncludeChildClass_PropertyAddress;

	private static int ShouldIncludeChildClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141119493uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepIsClassOfFetcher:Class")]
	public TSubclassOf<UObject> Class
	{
		get
		{
			CheckDestroyed();
			if (!Class_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepIsClassOfFetcher:Class");
				return default(TSubclassOf<UObject>);
			}
			return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Class_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Class_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepIsClassOfFetcher:Class");
			}
			else
			{
				TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Class_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepIsClassOfFetcher:bShouldIncludeChildClass")]
	public bool ShouldIncludeChildClass
	{
		get
		{
			CheckDestroyed();
			if (!ShouldIncludeChildClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepIsClassOfFetcher:bShouldIncludeChildClass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldIncludeChildClass_Offset), 0, ShouldIncludeChildClass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldIncludeChildClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepIsClassOfFetcher:bShouldIncludeChildClass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldIncludeChildClass_Offset), 0, ShouldIncludeChildClass_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepIsClassOfFetcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepIsClassOfFetcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepIsClassOfFetcher));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepIsClassOfFetcher");
		Class_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Class");
		Class_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldIncludeChildClass_PropertyAddress, unrealStruct, "bShouldIncludeChildClass");
		ShouldIncludeChildClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShouldIncludeChildClass");
		ShouldIncludeChildClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShouldIncludeChildClass", Classes.FBoolProperty);
	}
}
