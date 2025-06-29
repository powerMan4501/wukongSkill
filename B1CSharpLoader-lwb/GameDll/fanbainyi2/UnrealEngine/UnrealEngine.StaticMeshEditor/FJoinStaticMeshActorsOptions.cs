using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions", "StaticMeshEditor", UnrealModuleType.Engine)]
public struct FJoinStaticMeshActorsOptions
{
	private static bool DestroySourceActors_IsValid;

	private static FFieldAddress DestroySourceActors_PropertyAddress;

	private static int DestroySourceActors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bDestroySourceActors")]
	public bool DestroySourceActors;

	private static bool NewActorLabel_IsValid;

	private static int NewActorLabel_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:NewActorLabel")]
	public string NewActorLabel;

	private static bool RenameComponentsFromSource_IsValid;

	private static FFieldAddress RenameComponentsFromSource_PropertyAddress;

	private static int RenameComponentsFromSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bRenameComponentsFromSource")]
	public bool RenameComponentsFromSource;

	private static bool FJoinStaticMeshActorsOptions_IsValid;

	private static int FJoinStaticMeshActorsOptions_StructSize;

	public FJoinStaticMeshActorsOptions Copy()
	{
		return this;
	}

	public static FJoinStaticMeshActorsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FJoinStaticMeshActorsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJoinStaticMeshActorsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJoinStaticMeshActorsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJoinStaticMeshActorsOptions(nativeBuffer + arrayIndex * FJoinStaticMeshActorsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJoinStaticMeshActorsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJoinStaticMeshActorsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJoinStaticMeshActorsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address, DestroySourceActors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset), NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address, RenameComponentsFromSource);
	}

	public FJoinStaticMeshActorsOptions(IntPtr nativeStruct)
	{
		if (!FJoinStaticMeshActorsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions");
			DestroySourceActors = false;
			NewActorLabel = FStringMarshaler.DefaultString;
			RenameComponentsFromSource = false;
		}
		else
		{
			DestroySourceActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address);
			NewActorLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset));
			RenameComponentsFromSource = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address);
		}
	}

	static FJoinStaticMeshActorsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJoinStaticMeshActorsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJoinStaticMeshActorsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions");
		FJoinStaticMeshActorsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DestroySourceActors_PropertyAddress, intPtr, "bDestroySourceActors");
		DestroySourceActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDestroySourceActors");
		DestroySourceActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDestroySourceActors", Classes.FBoolProperty);
		NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewActorLabel");
		NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameComponentsFromSource_PropertyAddress, intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenameComponentsFromSource", Classes.FBoolProperty);
		FJoinStaticMeshActorsOptions_IsValid = intPtr != IntPtr.Zero && DestroySourceActors_IsValid && NewActorLabel_IsValid && RenameComponentsFromSource_IsValid;
		NativeReflection.LogStructIsValid("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions", FJoinStaticMeshActorsOptions_IsValid);
	}
}
