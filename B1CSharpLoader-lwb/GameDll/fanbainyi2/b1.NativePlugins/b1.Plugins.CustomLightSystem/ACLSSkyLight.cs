using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSSkyLight", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSSkyLight : AActor
{
	private static bool SkyLightComponent_IsValid;

	private static int SkyLightComponent_Offset;

	private static bool TagComponent_IsValid;

	private static int TagComponent_Offset;

	private static bool RecaptureSky_IsValid;

	private static IntPtr RecaptureSky_FunctionAddress;

	private static int RecaptureSky_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSSkyLight:SkyLightComponent")]
	public USkyLightComponent SkyLightComponent
	{
		get
		{
			CheckDestroyed();
			if (!SkyLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSkyLight:SkyLightComponent");
				return null;
			}
			return UObjectMarshaler<USkyLightComponent>.FromNative(IntPtr.Add(base.Address, SkyLightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSkyLight:SkyLightComponent");
			}
			else
			{
				UObjectMarshaler<USkyLightComponent>.ToNative(IntPtr.Add(base.Address, SkyLightComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSSkyLight:TagComponent")]
	public UCLSTagComponent TagComponent
	{
		get
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSkyLight:TagComponent");
				return null;
			}
			return UObjectMarshaler<UCLSTagComponent>.FromNative(IntPtr.Add(base.Address, TagComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSSkyLight:TagComponent");
			}
			else
			{
				UObjectMarshaler<UCLSTagComponent>.ToNative(IntPtr.Add(base.Address, TagComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/CustomLightSystem.CLSSkyLight:RecaptureSky")]
	public unsafe void RecaptureSky()
	{
		CheckDestroyed();
		if (!RecaptureSky_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSSkyLight:RecaptureSky");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecaptureSky_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecaptureSky_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecaptureSky_FunctionAddress, argsSize: RecaptureSky_ParamsSize);
	}

	static ACLSSkyLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSSkyLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSSkyLight));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CustomLightSystem.CLSSkyLight");
		SkyLightComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightComponent");
		SkyLightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightComponent", Classes.FObjectProperty);
		TagComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TagComponent");
		TagComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TagComponent", Classes.FObjectProperty);
		RecaptureSky_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecaptureSky");
		RecaptureSky_ParamsSize = NativeReflection.GetFunctionParamsSize(RecaptureSky_FunctionAddress);
		RecaptureSky_IsValid = RecaptureSky_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSSkyLight:RecaptureSky", RecaptureSky_IsValid);
	}
}
