using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[UStruct(Flags = 24577)]
[BlueprintType]
[UMetaPath("/Script/Engine.WalkableSlopeOverride", "Engine", UnrealModuleType.Engine)]
public struct FWalkableSlopeOverride
{
	private static bool WalkableSlopeBehavior_IsValid;

	private static FFieldAddress WalkableSlopeBehavior_PropertyAddress;

	private static int WalkableSlopeBehavior_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WalkableSlopeOverride:WalkableSlopeBehavior")]
	public EWalkableSlopeBehavior WalkableSlopeBehavior;

	private static bool WalkableSlopeAngle_IsValid;

	private static int WalkableSlopeAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WalkableSlopeOverride:WalkableSlopeAngle")]
	public float WalkableSlopeAngle;

	private static int FWalkableSlopeOverride_StructSize;

	public FWalkableSlopeOverride Copy()
	{
		return this;
	}

	static FWalkableSlopeOverride()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWalkableSlopeOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWalkableSlopeOverride));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/Engine.WalkableSlopeOverride");
		FWalkableSlopeOverride_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflectionCached.GetPropertyRef(ref WalkableSlopeBehavior_PropertyAddress, unrealStruct, "WalkableSlopeBehavior");
		WalkableSlopeBehavior_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WalkableSlopeBehavior");
		WalkableSlopeBehavior_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WalkableSlopeBehavior", Classes.FByteProperty);
		WalkableSlopeAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WalkableSlopeAngle");
		WalkableSlopeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WalkableSlopeAngle", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FWalkableSlopeOverride));
	}
}
