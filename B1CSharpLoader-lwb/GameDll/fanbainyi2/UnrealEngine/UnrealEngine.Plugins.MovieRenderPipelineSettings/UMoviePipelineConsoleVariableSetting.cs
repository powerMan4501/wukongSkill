using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineSettings;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting", "MovieRenderPipelineSettings", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineConsoleVariableSetting : UMoviePipelineSetting
{
	private static bool ConsoleVariables_IsValid;

	private static FFieldAddress ConsoleVariables_PropertyAddress;

	private static int ConsoleVariables_Offset;

	private TMapReadWriteMarshaler<string, float> ConsoleVariables_MarshalerCached;

	private static bool StartConsoleCommands_IsValid;

	private static FFieldAddress StartConsoleCommands_PropertyAddress;

	private static int StartConsoleCommands_Offset;

	private TArrayReadWriteMarshaler<string> StartConsoleCommands_MarshalerCached;

	private static bool EndConsoleCommands_IsValid;

	private static FFieldAddress EndConsoleCommands_PropertyAddress;

	private static int EndConsoleCommands_Offset;

	private TArrayReadWriteMarshaler<string> EndConsoleCommands_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:ConsoleVariables")]
	public TMapReadWrite<string, float> ConsoleVariables
	{
		get
		{
			CheckDestroyed();
			if (!ConsoleVariables_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:ConsoleVariables");
				return null;
			}
			if (ConsoleVariables_MarshalerCached == null)
			{
				ConsoleVariables_MarshalerCached = new TMapReadWriteMarshaler<string, float>(1, ConsoleVariables_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return ConsoleVariables_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConsoleVariables_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:StartConsoleCommands")]
	public TArrayReadWrite<string> StartConsoleCommands
	{
		get
		{
			CheckDestroyed();
			if (!StartConsoleCommands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:StartConsoleCommands");
				return null;
			}
			if (StartConsoleCommands_MarshalerCached == null)
			{
				StartConsoleCommands_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, StartConsoleCommands_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return StartConsoleCommands_MarshalerCached.FromNative(IntPtr.Add(base.Address, StartConsoleCommands_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:EndConsoleCommands")]
	public TArrayReadWrite<string> EndConsoleCommands
	{
		get
		{
			CheckDestroyed();
			if (!EndConsoleCommands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting:EndConsoleCommands");
				return null;
			}
			if (EndConsoleCommands_MarshalerCached == null)
			{
				EndConsoleCommands_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, EndConsoleCommands_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return EndConsoleCommands_MarshalerCached.FromNative(IntPtr.Add(base.Address, EndConsoleCommands_Offset));
		}
	}

	static UMoviePipelineConsoleVariableSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineConsoleVariableSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineConsoleVariableSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineSettings.MoviePipelineConsoleVariableSetting");
		NativeReflectionCached.GetPropertyRef(ref ConsoleVariables_PropertyAddress, unrealStruct, "ConsoleVariables");
		ConsoleVariables_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConsoleVariables");
		ConsoleVariables_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConsoleVariables", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref StartConsoleCommands_PropertyAddress, unrealStruct, "StartConsoleCommands");
		StartConsoleCommands_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartConsoleCommands");
		StartConsoleCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartConsoleCommands", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EndConsoleCommands_PropertyAddress, unrealStruct, "EndConsoleCommands");
		EndConsoleCommands_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EndConsoleCommands");
		EndConsoleCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EndConsoleCommands", Classes.FArrayProperty);
	}
}
