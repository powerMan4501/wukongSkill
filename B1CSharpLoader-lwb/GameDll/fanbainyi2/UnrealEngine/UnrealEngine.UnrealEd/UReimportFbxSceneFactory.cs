using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.ReimportFbxSceneFactory", "UnrealEd", UnrealModuleType.Engine)]
public class UReimportFbxSceneFactory : UFbxSceneImportFactory
{
	private static bool ScriptReimportHelper_IsValid;

	private static IntPtr ScriptReimportHelper_FunctionAddress;

	private static int ScriptReimportHelper_ParamsSize;

	private static bool ScriptReimportHelper_Obj_IsValid;

	private static FFieldAddress ScriptReimportHelper_Obj_PropertyAddress;

	private static int ScriptReimportHelper_Obj_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealEd.ReimportFbxSceneFactory:ScriptReimportHelper")]
	public unsafe void ScriptReimportHelper(UObject Obj)
	{
		CheckDestroyed();
		if (!ScriptReimportHelper_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealEd.ReimportFbxSceneFactory:ScriptReimportHelper");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptReimportHelper_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptReimportHelper_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScriptReimportHelper_Obj_Offset), 0, ScriptReimportHelper_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptReimportHelper_FunctionAddress, intPtr, ScriptReimportHelper_ParamsSize);
	}

	static UReimportFbxSceneFactory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UReimportFbxSceneFactory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UReimportFbxSceneFactory));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealEd.ReimportFbxSceneFactory");
		ScriptReimportHelper_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptReimportHelper");
		ScriptReimportHelper_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptReimportHelper_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptReimportHelper_Obj_PropertyAddress, ScriptReimportHelper_FunctionAddress, "Obj");
		ScriptReimportHelper_Obj_Offset = NativeReflectionCached.GetPropertyOffset(ScriptReimportHelper_FunctionAddress, "Obj");
		ScriptReimportHelper_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptReimportHelper_FunctionAddress, "Obj", Classes.FObjectProperty);
		ScriptReimportHelper_IsValid = ScriptReimportHelper_FunctionAddress != IntPtr.Zero && ScriptReimportHelper_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealEd.ReimportFbxSceneFactory:ScriptReimportHelper", ScriptReimportHelper_IsValid);
	}
}
