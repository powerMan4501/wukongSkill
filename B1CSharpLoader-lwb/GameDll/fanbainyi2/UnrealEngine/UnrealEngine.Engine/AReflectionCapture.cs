using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413733uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.ReflectionCapture", "Engine", UnrealModuleType.Engine)]
public class AReflectionCapture : AActor
{
	private static bool CaptureComponent_IsValid;

	private static int CaptureComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.ReflectionCapture:CaptureComponent")]
	public UReflectionCaptureComponent CaptureComponent
	{
		get
		{
			CheckDestroyed();
			if (!CaptureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCapture:CaptureComponent");
				return null;
			}
			return UObjectMarshaler<UReflectionCaptureComponent>.FromNative(IntPtr.Add(base.Address, CaptureComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCapture:CaptureComponent");
			}
			else
			{
				UObjectMarshaler<UReflectionCaptureComponent>.ToNative(IntPtr.Add(base.Address, CaptureComponent_Offset), value);
			}
		}
	}

	static AReflectionCapture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AReflectionCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AReflectionCapture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ReflectionCapture");
		CaptureComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CaptureComponent");
		CaptureComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CaptureComponent", Classes.FObjectProperty);
	}
}
