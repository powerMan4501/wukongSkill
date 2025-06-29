using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

public static class UPCGDataFunctionLibrary_CsExtensions
{
	public static List<UPCGData> GetTypedInputsByTag(this FPCGDataCollection InCollection, string InTag, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		return UPCGDataFunctionLibrary.GetTypedInputsByTag(InCollection, InTag, out OutTaggedData, InDataTypeClass);
	}

	public static List<UPCGData> GetTypedInputsByPinLabel(this FPCGDataCollection InCollection, FName InPinLabel, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		return UPCGDataFunctionLibrary.GetTypedInputsByPinLabel(InCollection, InPinLabel, out OutTaggedData, InDataTypeClass);
	}

	public static List<UPCGData> GetTypedInputsByPin(this FPCGDataCollection InCollection, FPCGPinProperties InPin, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		return UPCGDataFunctionLibrary.GetTypedInputsByPin(InCollection, InPin, out OutTaggedData, InDataTypeClass);
	}

	public static List<UPCGData> GetTypedInputs(this FPCGDataCollection InCollection, out List<FPCGTaggedData> OutTaggedData, TSubclassOf<UPCGData> InDataTypeClass)
	{
		return UPCGDataFunctionLibrary.GetTypedInputs(InCollection, out OutTaggedData, InDataTypeClass);
	}

	public static void AddToCollection(this ref FPCGDataCollection InCollection, UPCGData InData, FName InPinLabel, List<string> InTags)
	{
		UPCGDataFunctionLibrary.AddToCollection(ref InCollection, InData, InPinLabel, InTags);
	}
}
