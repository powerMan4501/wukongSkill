using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.GSWaterCustomBrushManager", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class AGSWaterCustomBrushManager : AWaterBrushManager
{
	private static bool ExportVelocityAndHeightTexture_IsValid;

	private static IntPtr ExportVelocityAndHeightTexture_FunctionAddress;

	private static int ExportVelocityAndHeightTexture_ParamsSize;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.GSWaterCustomBrushManager:ExportVelocityAndHeightTexture")]
	public unsafe void ExportVelocityAndHeightTexture()
	{
		CheckDestroyed();
		if (!ExportVelocityAndHeightTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.GSWaterCustomBrushManager:ExportVelocityAndHeightTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportVelocityAndHeightTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportVelocityAndHeightTexture_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExportVelocityAndHeightTexture_FunctionAddress, argsSize: ExportVelocityAndHeightTexture_ParamsSize);
	}

	static AGSWaterCustomBrushManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSWaterCustomBrushManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSWaterCustomBrushManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/WaterEditor.GSWaterCustomBrushManager");
		ExportVelocityAndHeightTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportVelocityAndHeightTexture");
		ExportVelocityAndHeightTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportVelocityAndHeightTexture_FunctionAddress);
		ExportVelocityAndHeightTexture_IsValid = ExportVelocityAndHeightTexture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.GSWaterCustomBrushManager:ExportVelocityAndHeightTexture", ExportVelocityAndHeightTexture_IsValid);
	}
}
