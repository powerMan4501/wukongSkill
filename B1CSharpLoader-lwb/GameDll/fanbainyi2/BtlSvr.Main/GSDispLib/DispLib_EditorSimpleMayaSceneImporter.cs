using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter")]
public class DispLib_EditorSimpleMayaSceneImporter : ABGUPlacedEditorUtilityBase
{
	private static bool TextFilePath_IsValid;

	private static int TextFilePath_Offset;

	private static bool TranslateScale_IsValid;

	private static int TranslateScale_Offset;

	private static bool QuatScale_IsValid;

	private static int QuatScale_Offset;

	private static bool ScaleScale_IsValid;

	private static int ScaleScale_Offset;

	private static bool SourceAssetLib_IsValid;

	private static int SourceAssetLib_Offset;

	private static FFieldAddress SourceAssetLib_PropertyAddress;

	private TArrayReadWriteMarshaler<SourceAsset> SourceAssetLib_Marshaler;

	private static bool SourceMaterialLib_IsValid;

	private static int SourceMaterialLib_Offset;

	private static FFieldAddress SourceMaterialLib_PropertyAddress;

	private TArrayReadWriteMarshaler<MayaShadingEngineToUnrealMaterial> SourceMaterialLib_Marshaler;

	private static bool LogEulerToQuat_IsValid;

	private static IntPtr LogEulerToQuat_FunctionAddress;

	private static int LogEulerToQuat_ParamsSize;

	private static bool DoRebuildScene_IsValid;

	private static IntPtr DoRebuildScene_FunctionAddress;

	private static int DoRebuildScene_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Text File Path")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TextFilePath")]
	public FName TextFilePath
	{
		get
		{
			CheckDestroyed();
			if (!TextFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TextFilePath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TextFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TextFilePath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TextFilePath_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TranslateScale")]
	public FVector TranslateScale
	{
		get
		{
			CheckDestroyed();
			if (!TranslateScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TranslateScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, TranslateScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslateScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:TranslateScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, TranslateScale_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:QuatScale")]
	public FVector4 QuatScale
	{
		get
		{
			CheckDestroyed();
			if (!QuatScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:QuatScale");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, QuatScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuatScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:QuatScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, QuatScale_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:ScaleScale")]
	public FVector ScaleScale
	{
		get
		{
			CheckDestroyed();
			if (!ScaleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:ScaleScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ScaleScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:ScaleScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ScaleScale_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Source Asset Lib")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:SourceAssetLib")]
	public TArrayReadWrite<SourceAsset> SourceAssetLib
	{
		get
		{
			CheckDestroyed();
			if (!SourceAssetLib_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:SourceAssetLib");
				return null;
			}
			if (SourceAssetLib_Marshaler == null)
			{
				SourceAssetLib_Marshaler = new TArrayReadWriteMarshaler<SourceAsset>(1, SourceAssetLib_PropertyAddress, CachedMarshalingDelegates<SourceAsset, SourceAsset>.FromNative, CachedMarshalingDelegates<SourceAsset, SourceAsset>.ToNative);
			}
			return SourceAssetLib_Marshaler.FromNative(IntPtr.Add(base.Address, SourceAssetLib_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Source Material Lib")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:SourceMaterialLib")]
	public TArrayReadWrite<MayaShadingEngineToUnrealMaterial> SourceMaterialLib
	{
		get
		{
			CheckDestroyed();
			if (!SourceMaterialLib_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:SourceMaterialLib");
				return null;
			}
			if (SourceMaterialLib_Marshaler == null)
			{
				SourceMaterialLib_Marshaler = new TArrayReadWriteMarshaler<MayaShadingEngineToUnrealMaterial>(1, SourceMaterialLib_PropertyAddress, CachedMarshalingDelegates<MayaShadingEngineToUnrealMaterial, MayaShadingEngineToUnrealMaterial>.FromNative, CachedMarshalingDelegates<MayaShadingEngineToUnrealMaterial, MayaShadingEngineToUnrealMaterial>.ToNative);
			}
			return SourceMaterialLib_Marshaler.FromNative(IntPtr.Add(base.Address, SourceMaterialLib_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	private float GetElurValue(float value)
	{
		if (Math.Abs(value) > 90f)
		{
			if (value > 0f)
			{
				return 180f - value;
			}
			return value + 180f;
		}
		return value;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:LogEulerToQuat")]
	public void LogEulerToQuat()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:DoRebuildScene")]
	public void DoRebuildScene()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:LogEulerToQuat")]
	private static void LogEulerToQuat__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorSimpleMayaSceneImporter dispLib_EditorSimpleMayaSceneImporter = GCHelper.Find<DispLib_EditorSimpleMayaSceneImporter>(obj);
		dispLib_EditorSimpleMayaSceneImporter.LogEulerToQuat();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:DoRebuildScene")]
	private static void DoRebuildScene__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorSimpleMayaSceneImporter dispLib_EditorSimpleMayaSceneImporter = GCHelper.Find<DispLib_EditorSimpleMayaSceneImporter>(obj);
		dispLib_EditorSimpleMayaSceneImporter.DoRebuildScene();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter");
		TextFilePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextFilePath");
		TextFilePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextFilePath", Classes.FNameProperty);
		TranslateScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "TranslateScale");
		TranslateScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TranslateScale", Classes.FStructProperty);
		QuatScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "QuatScale");
		QuatScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QuatScale", Classes.FStructProperty);
		ScaleScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleScale");
		ScaleScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleScale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SourceAssetLib_PropertyAddress, intPtr, "SourceAssetLib");
		SourceAssetLib_Offset = NativeReflection.GetPropertyOffset(intPtr, "SourceAssetLib");
		SourceAssetLib_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SourceAssetLib", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SourceMaterialLib_PropertyAddress, intPtr, "SourceMaterialLib");
		SourceMaterialLib_Offset = NativeReflection.GetPropertyOffset(intPtr, "SourceMaterialLib");
		SourceMaterialLib_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SourceMaterialLib", Classes.FArrayProperty);
		LogEulerToQuat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogEulerToQuat");
		LogEulerToQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(LogEulerToQuat_FunctionAddress);
		LogEulerToQuat_IsValid = LogEulerToQuat_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:LogEulerToQuat", LogEulerToQuat_IsValid);
		DoRebuildScene_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoRebuildScene");
		DoRebuildScene_ParamsSize = NativeReflection.GetFunctionParamsSize(DoRebuildScene_FunctionAddress);
		DoRebuildScene_IsValid = DoRebuildScene_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorSimpleMayaSceneImporter:DoRebuildScene", DoRebuildScene_IsValid);
	}

	static DispLib_EditorSimpleMayaSceneImporter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorSimpleMayaSceneImporter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorSimpleMayaSceneImporter));
	}
}
