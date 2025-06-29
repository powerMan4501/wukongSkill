using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTestBase", "FunctionalTesting", UnrealModuleType.Engine)]
public class AScreenshotFunctionalTestBase : AFunctionalTest
{
	private static bool Notes_IsValid;

	private static int Notes_Offset;

	private static bool ScreenshotCamera_IsValid;

	private static int ScreenshotCamera_Offset;

	private static bool ScreenshotOptions_IsValid;

	private static int ScreenshotOptions_Offset;

	[UProperty(Flags = (PropFlags)11267795161448981uL)]
	[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:Notes")]
	protected string Notes
	{
		get
		{
			CheckDestroyed();
			if (!Notes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:Notes");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Notes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Notes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:Notes");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Notes_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862034461uL)]
	[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotCamera")]
	protected UCameraComponent ScreenshotCamera
	{
		get
		{
			CheckDestroyed();
			if (!ScreenshotCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotCamera");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, ScreenshotCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScreenshotCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotCamera");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, ScreenshotCamera_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9018263090495509uL)]
	[UMetaPath("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotOptions")]
	protected FAutomationScreenshotOptions ScreenshotOptions
	{
		get
		{
			CheckDestroyed();
			if (!ScreenshotOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotOptions");
				return default(FAutomationScreenshotOptions);
			}
			return FAutomationScreenshotOptions.FromNative(IntPtr.Add(base.Address, ScreenshotOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScreenshotOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.ScreenshotFunctionalTestBase:ScreenshotOptions");
			}
			else
			{
				FAutomationScreenshotOptions.ToNative(IntPtr.Add(base.Address, ScreenshotOptions_Offset), value);
			}
		}
	}

	static AScreenshotFunctionalTestBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AScreenshotFunctionalTestBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AScreenshotFunctionalTestBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FunctionalTesting.ScreenshotFunctionalTestBase");
		Notes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Notes");
		Notes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Notes", Classes.FStrProperty);
		ScreenshotCamera_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScreenshotCamera");
		ScreenshotCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScreenshotCamera", Classes.FObjectProperty);
		ScreenshotOptions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ScreenshotOptions");
		ScreenshotOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ScreenshotOptions", Classes.FStructProperty);
	}
}
