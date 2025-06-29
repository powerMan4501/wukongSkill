using System;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Plugins.SequencerScripting;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigSequencerBindingProxy", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigSequencerBindingProxy
{
	private static bool Proxy_IsValid;

	private static int Proxy_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigSequencerBindingProxy:Proxy")]
	public FSequencerBindingProxy Proxy;

	private static bool ControlRig_IsValid;

	private static int ControlRig_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigSequencerBindingProxy:ControlRig")]
	public UControlRig ControlRig;

	private static bool Track_IsValid;

	private static int Track_Offset;

	[UProperty(Flags = (PropFlags)7881369141641756uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigSequencerBindingProxy:Track")]
	public UMovieSceneControlRigParameterTrack Track;

	private static bool FControlRigSequencerBindingProxy_IsValid;

	private static int FControlRigSequencerBindingProxy_StructSize;

	public FControlRigSequencerBindingProxy Copy()
	{
		return this;
	}

	public static FControlRigSequencerBindingProxy FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigSequencerBindingProxy(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigSequencerBindingProxy value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigSequencerBindingProxy FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigSequencerBindingProxy(nativeBuffer + arrayIndex * FControlRigSequencerBindingProxy_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigSequencerBindingProxy value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigSequencerBindingProxy_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigSequencerBindingProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigSequencerBindingProxy");
			return;
		}
		FSequencerBindingProxy.ToNative(IntPtr.Add(nativeStruct, Proxy_Offset), Proxy);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(nativeStruct, ControlRig_Offset), ControlRig);
		UObjectMarshaler<UMovieSceneControlRigParameterTrack>.ToNative(IntPtr.Add(nativeStruct, Track_Offset), Track);
	}

	public FControlRigSequencerBindingProxy(IntPtr nativeStruct)
	{
		if (!FControlRigSequencerBindingProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigSequencerBindingProxy");
			Proxy = default(FSequencerBindingProxy);
			ControlRig = null;
			Track = null;
		}
		else
		{
			Proxy = FSequencerBindingProxy.FromNative(IntPtr.Add(nativeStruct, Proxy_Offset));
			ControlRig = UObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(nativeStruct, ControlRig_Offset));
			Track = UObjectMarshaler<UMovieSceneControlRigParameterTrack>.FromNative(IntPtr.Add(nativeStruct, Track_Offset));
		}
	}

	static FControlRigSequencerBindingProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigSequencerBindingProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigSequencerBindingProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigSequencerBindingProxy");
		FControlRigSequencerBindingProxy_StructSize = NativeReflection.GetStructSize(intPtr);
		Proxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Proxy");
		Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Proxy", Classes.FStructProperty);
		ControlRig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlRig");
		ControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlRig", Classes.FObjectProperty);
		Track_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Track");
		Track_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Track", Classes.FObjectProperty);
		FControlRigSequencerBindingProxy_IsValid = intPtr != IntPtr.Zero && Proxy_IsValid && ControlRig_IsValid && Track_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigSequencerBindingProxy", FControlRigSequencerBindingProxy_IsValid);
	}
}
