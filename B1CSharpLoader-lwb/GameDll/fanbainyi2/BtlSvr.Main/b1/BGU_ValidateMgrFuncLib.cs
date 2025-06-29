using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGU_ValidateMgrFuncLib")]
public class BGU_ValidateMgrFuncLib : UBlueprintFunctionLibrary
{
	private static bool ImArtDev_IsValid;

	private static IntPtr ImArtDev_FunctionAddress;

	private static int ImArtDev_ParamsSize;

	private static bool ImArtDev_Actor_IsValid;

	private static int ImArtDev_Actor_Offset;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGU_ValidateMgrFuncLib:ImArtDev")]
	public static void ImArtDev(AActor Actor)
	{
		BGW_ValiDateMgr.Get(Actor.World).SwitchForArtDev = true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_ValidateMgrFuncLib:ImArtDev")]
	private static void ImArtDev__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ImArtDev_Actor_Offset));
		ImArtDev(actor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGU_ValidateMgrFuncLib");
		ImArtDev_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImArtDev");
		ImArtDev_ParamsSize = NativeReflection.GetFunctionParamsSize(ImArtDev_FunctionAddress);
		ImArtDev_Actor_Offset = NativeReflection.GetPropertyOffset(ImArtDev_FunctionAddress, "Actor");
		ImArtDev_Actor_IsValid = NativeReflection.ValidatePropertyClass(ImArtDev_FunctionAddress, "Actor", Classes.FObjectProperty);
		ImArtDev_IsValid = ImArtDev_FunctionAddress != IntPtr.Zero && ImArtDev_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_ValidateMgrFuncLib:ImArtDev", ImArtDev_IsValid);
	}

	static BGU_ValidateMgrFuncLib()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_ValidateMgrFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_ValidateMgrFuncLib));
	}
}
