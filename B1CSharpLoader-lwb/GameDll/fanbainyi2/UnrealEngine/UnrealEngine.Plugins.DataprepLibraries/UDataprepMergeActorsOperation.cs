using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepMergeActorsOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepMergeActorsOperation : UDataprepEditingOperation
{
	private static bool PivotPointAtZero_IsValid;

	private static FFieldAddress PivotPointAtZero_PropertyAddress;

	private static int PivotPointAtZero_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepMergeActorsOperation:bPivotPointAtZero")]
	public bool PivotPointAtZero
	{
		get
		{
			CheckDestroyed();
			if (!PivotPointAtZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepMergeActorsOperation:bPivotPointAtZero");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PivotPointAtZero_Offset), 0, PivotPointAtZero_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PivotPointAtZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepMergeActorsOperation:bPivotPointAtZero");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PivotPointAtZero_Offset), 0, PivotPointAtZero_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepMergeActorsOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepMergeActorsOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepMergeActorsOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepMergeActorsOperation");
		NativeReflectionCached.GetPropertyRef(ref PivotPointAtZero_PropertyAddress, unrealStruct, "bPivotPointAtZero");
		PivotPointAtZero_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPivotPointAtZero");
		PivotPointAtZero_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPivotPointAtZero", Classes.FBoolProperty);
	}
}
