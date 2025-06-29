using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetTextLibrary", "Engine", UnrealModuleType.Engine)]
public class UTextLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TextTrimTrailing_IsValid;

	private static IntPtr TextTrimTrailing_FunctionAddress;

	private static int TextTrimTrailing_ParamsSize;

	private static bool TextTrimTrailing_InText_IsValid;

	private static FFieldAddress TextTrimTrailing_InText_PropertyAddress;

	private static int TextTrimTrailing_InText_Offset;

	private static bool TextTrimTrailing_ReturnValue_IsValid;

	private static FFieldAddress TextTrimTrailing_ReturnValue_PropertyAddress;

	private static int TextTrimTrailing_ReturnValue_Offset;

	private static bool TextTrimPrecedingAndTrailing_IsValid;

	private static IntPtr TextTrimPrecedingAndTrailing_FunctionAddress;

	private static int TextTrimPrecedingAndTrailing_ParamsSize;

	private static bool TextTrimPrecedingAndTrailing_InText_IsValid;

	private static FFieldAddress TextTrimPrecedingAndTrailing_InText_PropertyAddress;

	private static int TextTrimPrecedingAndTrailing_InText_Offset;

	private static bool TextTrimPrecedingAndTrailing_ReturnValue_IsValid;

	private static FFieldAddress TextTrimPrecedingAndTrailing_ReturnValue_PropertyAddress;

	private static int TextTrimPrecedingAndTrailing_ReturnValue_Offset;

	private static bool TextTrimPreceding_IsValid;

	private static IntPtr TextTrimPreceding_FunctionAddress;

	private static int TextTrimPreceding_ParamsSize;

	private static bool TextTrimPreceding_InText_IsValid;

	private static FFieldAddress TextTrimPreceding_InText_PropertyAddress;

	private static int TextTrimPreceding_InText_Offset;

	private static bool TextTrimPreceding_ReturnValue_IsValid;

	private static FFieldAddress TextTrimPreceding_ReturnValue_PropertyAddress;

	private static int TextTrimPreceding_ReturnValue_Offset;

	private static bool TextToUpper_IsValid;

	private static IntPtr TextToUpper_FunctionAddress;

	private static int TextToUpper_ParamsSize;

	private static bool TextToUpper_InText_IsValid;

	private static FFieldAddress TextToUpper_InText_PropertyAddress;

	private static int TextToUpper_InText_Offset;

	private static bool TextToUpper_ReturnValue_IsValid;

	private static FFieldAddress TextToUpper_ReturnValue_PropertyAddress;

	private static int TextToUpper_ReturnValue_Offset;

	private static bool TextToLower_IsValid;

	private static IntPtr TextToLower_FunctionAddress;

	private static int TextToLower_ParamsSize;

	private static bool TextToLower_InText_IsValid;

	private static FFieldAddress TextToLower_InText_PropertyAddress;

	private static int TextToLower_InText_Offset;

	private static bool TextToLower_ReturnValue_IsValid;

	private static FFieldAddress TextToLower_ReturnValue_PropertyAddress;

	private static int TextToLower_ReturnValue_Offset;

	private static bool TextIsTransient_IsValid;

	private static IntPtr TextIsTransient_FunctionAddress;

	private static int TextIsTransient_ParamsSize;

	private static bool TextIsTransient_InText_IsValid;

	private static FFieldAddress TextIsTransient_InText_PropertyAddress;

	private static int TextIsTransient_InText_Offset;

	private static bool TextIsTransient_ReturnValue_IsValid;

	private static FFieldAddress TextIsTransient_ReturnValue_PropertyAddress;

	private static int TextIsTransient_ReturnValue_Offset;

	private static bool TextIsFromStringTable_IsValid;

	private static IntPtr TextIsFromStringTable_FunctionAddress;

	private static int TextIsFromStringTable_ParamsSize;

	private static bool TextIsFromStringTable_Text_IsValid;

	private static FFieldAddress TextIsFromStringTable_Text_PropertyAddress;

	private static int TextIsFromStringTable_Text_Offset;

	private static bool TextIsFromStringTable_ReturnValue_IsValid;

	private static FFieldAddress TextIsFromStringTable_ReturnValue_PropertyAddress;

	private static int TextIsFromStringTable_ReturnValue_Offset;

	private static bool TextIsEmpty_IsValid;

	private static IntPtr TextIsEmpty_FunctionAddress;

	private static int TextIsEmpty_ParamsSize;

	private static bool TextIsEmpty_InText_IsValid;

	private static FFieldAddress TextIsEmpty_InText_PropertyAddress;

	private static int TextIsEmpty_InText_Offset;

	private static bool TextIsEmpty_ReturnValue_IsValid;

	private static FFieldAddress TextIsEmpty_ReturnValue_PropertyAddress;

	private static int TextIsEmpty_ReturnValue_Offset;

	private static bool TextIsCultureInvariant_IsValid;

	private static IntPtr TextIsCultureInvariant_FunctionAddress;

	private static int TextIsCultureInvariant_ParamsSize;

	private static bool TextIsCultureInvariant_InText_IsValid;

	private static FFieldAddress TextIsCultureInvariant_InText_PropertyAddress;

	private static int TextIsCultureInvariant_InText_Offset;

	private static bool TextIsCultureInvariant_ReturnValue_IsValid;

	private static FFieldAddress TextIsCultureInvariant_ReturnValue_PropertyAddress;

	private static int TextIsCultureInvariant_ReturnValue_Offset;

	private static bool TextFromStringTable_IsValid;

	private static IntPtr TextFromStringTable_FunctionAddress;

	private static int TextFromStringTable_ParamsSize;

	private static bool TextFromStringTable_TableId_IsValid;

	private static FFieldAddress TextFromStringTable_TableId_PropertyAddress;

	private static int TextFromStringTable_TableId_Offset;

	private static bool TextFromStringTable_Key_IsValid;

	private static FFieldAddress TextFromStringTable_Key_PropertyAddress;

	private static int TextFromStringTable_Key_Offset;

	private static bool TextFromStringTable_ReturnValue_IsValid;

	private static FFieldAddress TextFromStringTable_ReturnValue_PropertyAddress;

	private static int TextFromStringTable_ReturnValue_Offset;

	private static bool StringTableIdAndKeyFromText_IsValid;

	private static IntPtr StringTableIdAndKeyFromText_FunctionAddress;

	private static int StringTableIdAndKeyFromText_ParamsSize;

	private static bool StringTableIdAndKeyFromText_Text_IsValid;

	private static FFieldAddress StringTableIdAndKeyFromText_Text_PropertyAddress;

	private static int StringTableIdAndKeyFromText_Text_Offset;

	private static bool StringTableIdAndKeyFromText_OutTableId_IsValid;

	private static FFieldAddress StringTableIdAndKeyFromText_OutTableId_PropertyAddress;

	private static int StringTableIdAndKeyFromText_OutTableId_Offset;

	private static bool StringTableIdAndKeyFromText_OutKey_IsValid;

	private static FFieldAddress StringTableIdAndKeyFromText_OutKey_PropertyAddress;

	private static int StringTableIdAndKeyFromText_OutKey_Offset;

	private static bool StringTableIdAndKeyFromText_ReturnValue_IsValid;

	private static FFieldAddress StringTableIdAndKeyFromText_ReturnValue_PropertyAddress;

	private static int StringTableIdAndKeyFromText_ReturnValue_Offset;

	private static bool PolyglotDataToText_IsValid;

	private static IntPtr PolyglotDataToText_FunctionAddress;

	private static int PolyglotDataToText_ParamsSize;

	private static bool PolyglotDataToText_PolyglotData_IsValid;

	private static FFieldAddress PolyglotDataToText_PolyglotData_PropertyAddress;

	private static int PolyglotDataToText_PolyglotData_Offset;

	private static bool PolyglotDataToText_ReturnValue_IsValid;

	private static FFieldAddress PolyglotDataToText_ReturnValue_PropertyAddress;

	private static int PolyglotDataToText_ReturnValue_Offset;

	private static bool NotEqual_TextText_IsValid;

	private static IntPtr NotEqual_TextText_FunctionAddress;

	private static int NotEqual_TextText_ParamsSize;

	private static bool NotEqual_TextText_A_IsValid;

	private static FFieldAddress NotEqual_TextText_A_PropertyAddress;

	private static int NotEqual_TextText_A_Offset;

	private static bool NotEqual_TextText_B_IsValid;

	private static FFieldAddress NotEqual_TextText_B_PropertyAddress;

	private static int NotEqual_TextText_B_Offset;

	private static bool NotEqual_TextText_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_TextText_ReturnValue_PropertyAddress;

	private static int NotEqual_TextText_ReturnValue_Offset;

	private static bool NotEqual_IgnoreCase_TextText_IsValid;

	private static IntPtr NotEqual_IgnoreCase_TextText_FunctionAddress;

	private static int NotEqual_IgnoreCase_TextText_ParamsSize;

	private static bool NotEqual_IgnoreCase_TextText_A_IsValid;

	private static FFieldAddress NotEqual_IgnoreCase_TextText_A_PropertyAddress;

	private static int NotEqual_IgnoreCase_TextText_A_Offset;

	private static bool NotEqual_IgnoreCase_TextText_B_IsValid;

	private static FFieldAddress NotEqual_IgnoreCase_TextText_B_PropertyAddress;

	private static int NotEqual_IgnoreCase_TextText_B_Offset;

	private static bool NotEqual_IgnoreCase_TextText_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress;

	private static int NotEqual_IgnoreCase_TextText_ReturnValue_Offset;

	private static bool IsPolyglotDataValid_IsValid;

	private static IntPtr IsPolyglotDataValid_FunctionAddress;

	private static int IsPolyglotDataValid_ParamsSize;

	private static bool IsPolyglotDataValid_PolyglotData_IsValid;

	private static FFieldAddress IsPolyglotDataValid_PolyglotData_PropertyAddress;

	private static int IsPolyglotDataValid_PolyglotData_Offset;

	private static bool IsPolyglotDataValid_IsValid_IsValid;

	private static FFieldAddress IsPolyglotDataValid_IsValid_PropertyAddress;

	private static int IsPolyglotDataValid_IsValid_Offset;

	private static bool IsPolyglotDataValid_ErrorMessage_IsValid;

	private static FFieldAddress IsPolyglotDataValid_ErrorMessage_PropertyAddress;

	private static int IsPolyglotDataValid_ErrorMessage_Offset;

	private static bool GetEmptyText_IsValid;

	private static IntPtr GetEmptyText_FunctionAddress;

	private static int GetEmptyText_ParamsSize;

	private static bool GetEmptyText_ReturnValue_IsValid;

	private static FFieldAddress GetEmptyText_ReturnValue_PropertyAddress;

	private static int GetEmptyText_ReturnValue_Offset;

	private static bool FindTextInLocalizationTable_IsValid;

	private static IntPtr FindTextInLocalizationTable_FunctionAddress;

	private static int FindTextInLocalizationTable_ParamsSize;

	private static bool FindTextInLocalizationTable_Namespace_IsValid;

	private static FFieldAddress FindTextInLocalizationTable_Namespace_PropertyAddress;

	private static int FindTextInLocalizationTable_Namespace_Offset;

	private static bool FindTextInLocalizationTable_Key_IsValid;

	private static FFieldAddress FindTextInLocalizationTable_Key_PropertyAddress;

	private static int FindTextInLocalizationTable_Key_Offset;

	private static bool FindTextInLocalizationTable_OutText_IsValid;

	private static FFieldAddress FindTextInLocalizationTable_OutText_PropertyAddress;

	private static int FindTextInLocalizationTable_OutText_Offset;

	private static bool FindTextInLocalizationTable_ReturnValue_IsValid;

	private static FFieldAddress FindTextInLocalizationTable_ReturnValue_PropertyAddress;

	private static int FindTextInLocalizationTable_ReturnValue_Offset;

	private static bool EqualEqual_TextText_IsValid;

	private static IntPtr EqualEqual_TextText_FunctionAddress;

	private static int EqualEqual_TextText_ParamsSize;

	private static bool EqualEqual_TextText_A_IsValid;

	private static FFieldAddress EqualEqual_TextText_A_PropertyAddress;

	private static int EqualEqual_TextText_A_Offset;

	private static bool EqualEqual_TextText_B_IsValid;

	private static FFieldAddress EqualEqual_TextText_B_PropertyAddress;

	private static int EqualEqual_TextText_B_Offset;

	private static bool EqualEqual_TextText_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_TextText_ReturnValue_PropertyAddress;

	private static int EqualEqual_TextText_ReturnValue_Offset;

	private static bool EqualEqual_IgnoreCase_TextText_IsValid;

	private static IntPtr EqualEqual_IgnoreCase_TextText_FunctionAddress;

	private static int EqualEqual_IgnoreCase_TextText_ParamsSize;

	private static bool EqualEqual_IgnoreCase_TextText_A_IsValid;

	private static FFieldAddress EqualEqual_IgnoreCase_TextText_A_PropertyAddress;

	private static int EqualEqual_IgnoreCase_TextText_A_Offset;

	private static bool EqualEqual_IgnoreCase_TextText_B_IsValid;

	private static FFieldAddress EqualEqual_IgnoreCase_TextText_B_PropertyAddress;

	private static int EqualEqual_IgnoreCase_TextText_B_Offset;

	private static bool EqualEqual_IgnoreCase_TextText_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress;

	private static int EqualEqual_IgnoreCase_TextText_ReturnValue_Offset;

	private static bool Conv_VectorToText_IsValid;

	private static IntPtr Conv_VectorToText_FunctionAddress;

	private static int Conv_VectorToText_ParamsSize;

	private static bool Conv_VectorToText_InVec_IsValid;

	private static FFieldAddress Conv_VectorToText_InVec_PropertyAddress;

	private static int Conv_VectorToText_InVec_Offset;

	private static bool Conv_VectorToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_VectorToText_ReturnValue_PropertyAddress;

	private static int Conv_VectorToText_ReturnValue_Offset;

	private static bool Conv_Vector2dToText_IsValid;

	private static IntPtr Conv_Vector2dToText_FunctionAddress;

	private static int Conv_Vector2dToText_ParamsSize;

	private static bool Conv_Vector2dToText_InVec_IsValid;

	private static FFieldAddress Conv_Vector2dToText_InVec_PropertyAddress;

	private static int Conv_Vector2dToText_InVec_Offset;

	private static bool Conv_Vector2dToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_Vector2dToText_ReturnValue_PropertyAddress;

	private static int Conv_Vector2dToText_ReturnValue_Offset;

	private static bool Conv_TransformToText_IsValid;

	private static IntPtr Conv_TransformToText_FunctionAddress;

	private static int Conv_TransformToText_ParamsSize;

	private static bool Conv_TransformToText_InTrans_IsValid;

	private static FFieldAddress Conv_TransformToText_InTrans_PropertyAddress;

	private static int Conv_TransformToText_InTrans_Offset;

	private static bool Conv_TransformToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_TransformToText_ReturnValue_PropertyAddress;

	private static int Conv_TransformToText_ReturnValue_Offset;

	private static bool Conv_TextToString_IsValid;

	private static IntPtr Conv_TextToString_FunctionAddress;

	private static int Conv_TextToString_ParamsSize;

	private static bool Conv_TextToString_InText_IsValid;

	private static FFieldAddress Conv_TextToString_InText_PropertyAddress;

	private static int Conv_TextToString_InText_Offset;

	private static bool Conv_TextToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_TextToString_ReturnValue_PropertyAddress;

	private static int Conv_TextToString_ReturnValue_Offset;

	private static bool Conv_StringToText_IsValid;

	private static IntPtr Conv_StringToText_FunctionAddress;

	private static int Conv_StringToText_ParamsSize;

	private static bool Conv_StringToText_InString_IsValid;

	private static FFieldAddress Conv_StringToText_InString_PropertyAddress;

	private static int Conv_StringToText_InString_Offset;

	private static bool Conv_StringToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_StringToText_ReturnValue_PropertyAddress;

	private static int Conv_StringToText_ReturnValue_Offset;

	private static bool Conv_RotatorToText_IsValid;

	private static IntPtr Conv_RotatorToText_FunctionAddress;

	private static int Conv_RotatorToText_ParamsSize;

	private static bool Conv_RotatorToText_InRot_IsValid;

	private static FFieldAddress Conv_RotatorToText_InRot_PropertyAddress;

	private static int Conv_RotatorToText_InRot_Offset;

	private static bool Conv_RotatorToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_RotatorToText_ReturnValue_PropertyAddress;

	private static int Conv_RotatorToText_ReturnValue_Offset;

	private static bool Conv_ObjectToText_IsValid;

	private static IntPtr Conv_ObjectToText_FunctionAddress;

	private static int Conv_ObjectToText_ParamsSize;

	private static bool Conv_ObjectToText_InObj_IsValid;

	private static FFieldAddress Conv_ObjectToText_InObj_PropertyAddress;

	private static int Conv_ObjectToText_InObj_Offset;

	private static bool Conv_ObjectToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_ObjectToText_ReturnValue_PropertyAddress;

	private static int Conv_ObjectToText_ReturnValue_Offset;

	private static bool Conv_NameToText_IsValid;

	private static IntPtr Conv_NameToText_FunctionAddress;

	private static int Conv_NameToText_ParamsSize;

	private static bool Conv_NameToText_InName_IsValid;

	private static FFieldAddress Conv_NameToText_InName_PropertyAddress;

	private static int Conv_NameToText_InName_Offset;

	private static bool Conv_NameToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_NameToText_ReturnValue_PropertyAddress;

	private static int Conv_NameToText_ReturnValue_Offset;

	private static bool Conv_IntToText_IsValid;

	private static IntPtr Conv_IntToText_FunctionAddress;

	private static int Conv_IntToText_ParamsSize;

	private static bool Conv_IntToText_Value_IsValid;

	private static FFieldAddress Conv_IntToText_Value_PropertyAddress;

	private static int Conv_IntToText_Value_Offset;

	private static bool Conv_IntToText_bAlwaysSign_IsValid;

	private static FFieldAddress Conv_IntToText_bAlwaysSign_PropertyAddress;

	private static int Conv_IntToText_bAlwaysSign_Offset;

	private static bool Conv_IntToText_bUseGrouping_IsValid;

	private static FFieldAddress Conv_IntToText_bUseGrouping_PropertyAddress;

	private static int Conv_IntToText_bUseGrouping_Offset;

	private static bool Conv_IntToText_MinimumIntegralDigits_IsValid;

	private static FFieldAddress Conv_IntToText_MinimumIntegralDigits_PropertyAddress;

	private static int Conv_IntToText_MinimumIntegralDigits_Offset;

	private static bool Conv_IntToText_MaximumIntegralDigits_IsValid;

	private static FFieldAddress Conv_IntToText_MaximumIntegralDigits_PropertyAddress;

	private static int Conv_IntToText_MaximumIntegralDigits_Offset;

	private static bool Conv_IntToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_IntToText_ReturnValue_PropertyAddress;

	private static int Conv_IntToText_ReturnValue_Offset;

	private static bool Conv_Int64ToText_IsValid;

	private static IntPtr Conv_Int64ToText_FunctionAddress;

	private static int Conv_Int64ToText_ParamsSize;

	private static bool Conv_Int64ToText_Value_IsValid;

	private static FFieldAddress Conv_Int64ToText_Value_PropertyAddress;

	private static int Conv_Int64ToText_Value_Offset;

	private static bool Conv_Int64ToText_bAlwaysSign_IsValid;

	private static FFieldAddress Conv_Int64ToText_bAlwaysSign_PropertyAddress;

	private static int Conv_Int64ToText_bAlwaysSign_Offset;

	private static bool Conv_Int64ToText_bUseGrouping_IsValid;

	private static FFieldAddress Conv_Int64ToText_bUseGrouping_PropertyAddress;

	private static int Conv_Int64ToText_bUseGrouping_Offset;

	private static bool Conv_Int64ToText_MinimumIntegralDigits_IsValid;

	private static FFieldAddress Conv_Int64ToText_MinimumIntegralDigits_PropertyAddress;

	private static int Conv_Int64ToText_MinimumIntegralDigits_Offset;

	private static bool Conv_Int64ToText_MaximumIntegralDigits_IsValid;

	private static FFieldAddress Conv_Int64ToText_MaximumIntegralDigits_PropertyAddress;

	private static int Conv_Int64ToText_MaximumIntegralDigits_Offset;

	private static bool Conv_Int64ToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_Int64ToText_ReturnValue_PropertyAddress;

	private static int Conv_Int64ToText_ReturnValue_Offset;

	private static bool Conv_FloatToText_IsValid;

	private static IntPtr Conv_FloatToText_FunctionAddress;

	private static int Conv_FloatToText_ParamsSize;

	private static bool Conv_FloatToText_Value_IsValid;

	private static FFieldAddress Conv_FloatToText_Value_PropertyAddress;

	private static int Conv_FloatToText_Value_Offset;

	private static bool Conv_FloatToText_RoundingMode_IsValid;

	private static FFieldAddress Conv_FloatToText_RoundingMode_PropertyAddress;

	private static int Conv_FloatToText_RoundingMode_Offset;

	private static bool Conv_FloatToText_bAlwaysSign_IsValid;

	private static FFieldAddress Conv_FloatToText_bAlwaysSign_PropertyAddress;

	private static int Conv_FloatToText_bAlwaysSign_Offset;

	private static bool Conv_FloatToText_bUseGrouping_IsValid;

	private static FFieldAddress Conv_FloatToText_bUseGrouping_PropertyAddress;

	private static int Conv_FloatToText_bUseGrouping_Offset;

	private static bool Conv_FloatToText_MinimumIntegralDigits_IsValid;

	private static FFieldAddress Conv_FloatToText_MinimumIntegralDigits_PropertyAddress;

	private static int Conv_FloatToText_MinimumIntegralDigits_Offset;

	private static bool Conv_FloatToText_MaximumIntegralDigits_IsValid;

	private static FFieldAddress Conv_FloatToText_MaximumIntegralDigits_PropertyAddress;

	private static int Conv_FloatToText_MaximumIntegralDigits_Offset;

	private static bool Conv_FloatToText_MinimumFractionalDigits_IsValid;

	private static FFieldAddress Conv_FloatToText_MinimumFractionalDigits_PropertyAddress;

	private static int Conv_FloatToText_MinimumFractionalDigits_Offset;

	private static bool Conv_FloatToText_MaximumFractionalDigits_IsValid;

	private static FFieldAddress Conv_FloatToText_MaximumFractionalDigits_PropertyAddress;

	private static int Conv_FloatToText_MaximumFractionalDigits_Offset;

	private static bool Conv_FloatToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FloatToText_ReturnValue_PropertyAddress;

	private static int Conv_FloatToText_ReturnValue_Offset;

	private static bool Conv_DoubleToText_IsValid;

	private static IntPtr Conv_DoubleToText_FunctionAddress;

	private static int Conv_DoubleToText_ParamsSize;

	private static bool Conv_DoubleToText_InDouble_IsValid;

	private static FFieldAddress Conv_DoubleToText_InDouble_PropertyAddress;

	private static int Conv_DoubleToText_InDouble_Offset;

	private static bool Conv_DoubleToText_RoundingMode_IsValid;

	private static FFieldAddress Conv_DoubleToText_RoundingMode_PropertyAddress;

	private static int Conv_DoubleToText_RoundingMode_Offset;

	private static bool Conv_DoubleToText_bAlwaysSign_IsValid;

	private static FFieldAddress Conv_DoubleToText_bAlwaysSign_PropertyAddress;

	private static int Conv_DoubleToText_bAlwaysSign_Offset;

	private static bool Conv_DoubleToText_bUseGrouping_IsValid;

	private static FFieldAddress Conv_DoubleToText_bUseGrouping_PropertyAddress;

	private static int Conv_DoubleToText_bUseGrouping_Offset;

	private static bool Conv_DoubleToText_MinimumIntegralDigits_IsValid;

	private static FFieldAddress Conv_DoubleToText_MinimumIntegralDigits_PropertyAddress;

	private static int Conv_DoubleToText_MinimumIntegralDigits_Offset;

	private static bool Conv_DoubleToText_MaximumIntegralDigits_IsValid;

	private static FFieldAddress Conv_DoubleToText_MaximumIntegralDigits_PropertyAddress;

	private static int Conv_DoubleToText_MaximumIntegralDigits_Offset;

	private static bool Conv_DoubleToText_MinimumFractionalDigits_IsValid;

	private static FFieldAddress Conv_DoubleToText_MinimumFractionalDigits_PropertyAddress;

	private static int Conv_DoubleToText_MinimumFractionalDigits_Offset;

	private static bool Conv_DoubleToText_MaximumFractionalDigits_IsValid;

	private static FFieldAddress Conv_DoubleToText_MaximumFractionalDigits_PropertyAddress;

	private static int Conv_DoubleToText_MaximumFractionalDigits_Offset;

	private static bool Conv_DoubleToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_DoubleToText_ReturnValue_PropertyAddress;

	private static int Conv_DoubleToText_ReturnValue_Offset;

	private static bool Conv_ColorToText_IsValid;

	private static IntPtr Conv_ColorToText_FunctionAddress;

	private static int Conv_ColorToText_ParamsSize;

	private static bool Conv_ColorToText_InColor_IsValid;

	private static FFieldAddress Conv_ColorToText_InColor_PropertyAddress;

	private static int Conv_ColorToText_InColor_Offset;

	private static bool Conv_ColorToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_ColorToText_ReturnValue_PropertyAddress;

	private static int Conv_ColorToText_ReturnValue_Offset;

	private static bool Conv_ByteToText_IsValid;

	private static IntPtr Conv_ByteToText_FunctionAddress;

	private static int Conv_ByteToText_ParamsSize;

	private static bool Conv_ByteToText_Value_IsValid;

	private static FFieldAddress Conv_ByteToText_Value_PropertyAddress;

	private static int Conv_ByteToText_Value_Offset;

	private static bool Conv_ByteToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_ByteToText_ReturnValue_PropertyAddress;

	private static int Conv_ByteToText_ReturnValue_Offset;

	private static bool Conv_BoolToText_IsValid;

	private static IntPtr Conv_BoolToText_FunctionAddress;

	private static int Conv_BoolToText_ParamsSize;

	private static bool Conv_BoolToText_InBool_IsValid;

	private static FFieldAddress Conv_BoolToText_InBool_PropertyAddress;

	private static int Conv_BoolToText_InBool_Offset;

	private static bool Conv_BoolToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_BoolToText_ReturnValue_PropertyAddress;

	private static int Conv_BoolToText_ReturnValue_Offset;

	private static bool AsTimeZoneTime_DateTime_IsValid;

	private static IntPtr AsTimeZoneTime_DateTime_FunctionAddress;

	private static int AsTimeZoneTime_DateTime_ParamsSize;

	private static bool AsTimeZoneTime_DateTime_InDateTime_IsValid;

	private static FFieldAddress AsTimeZoneTime_DateTime_InDateTime_PropertyAddress;

	private static int AsTimeZoneTime_DateTime_InDateTime_Offset;

	private static bool AsTimeZoneTime_DateTime_InTimeZone_IsValid;

	private static FFieldAddress AsTimeZoneTime_DateTime_InTimeZone_PropertyAddress;

	private static int AsTimeZoneTime_DateTime_InTimeZone_Offset;

	private static bool AsTimeZoneTime_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsTimeZoneTime_DateTime_ReturnValue_PropertyAddress;

	private static int AsTimeZoneTime_DateTime_ReturnValue_Offset;

	private static bool AsTimeZoneDateTime_DateTime_IsValid;

	private static IntPtr AsTimeZoneDateTime_DateTime_FunctionAddress;

	private static int AsTimeZoneDateTime_DateTime_ParamsSize;

	private static bool AsTimeZoneDateTime_DateTime_InDateTime_IsValid;

	private static FFieldAddress AsTimeZoneDateTime_DateTime_InDateTime_PropertyAddress;

	private static int AsTimeZoneDateTime_DateTime_InDateTime_Offset;

	private static bool AsTimeZoneDateTime_DateTime_InTimeZone_IsValid;

	private static FFieldAddress AsTimeZoneDateTime_DateTime_InTimeZone_PropertyAddress;

	private static int AsTimeZoneDateTime_DateTime_InTimeZone_Offset;

	private static bool AsTimeZoneDateTime_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsTimeZoneDateTime_DateTime_ReturnValue_PropertyAddress;

	private static int AsTimeZoneDateTime_DateTime_ReturnValue_Offset;

	private static bool AsTimeZoneDate_DateTime_IsValid;

	private static IntPtr AsTimeZoneDate_DateTime_FunctionAddress;

	private static int AsTimeZoneDate_DateTime_ParamsSize;

	private static bool AsTimeZoneDate_DateTime_InDateTime_IsValid;

	private static FFieldAddress AsTimeZoneDate_DateTime_InDateTime_PropertyAddress;

	private static int AsTimeZoneDate_DateTime_InDateTime_Offset;

	private static bool AsTimeZoneDate_DateTime_InTimeZone_IsValid;

	private static FFieldAddress AsTimeZoneDate_DateTime_InTimeZone_PropertyAddress;

	private static int AsTimeZoneDate_DateTime_InTimeZone_Offset;

	private static bool AsTimeZoneDate_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsTimeZoneDate_DateTime_ReturnValue_PropertyAddress;

	private static int AsTimeZoneDate_DateTime_ReturnValue_Offset;

	private static bool AsTimespan_Timespan_IsValid;

	private static IntPtr AsTimespan_Timespan_FunctionAddress;

	private static int AsTimespan_Timespan_ParamsSize;

	private static bool AsTimespan_Timespan_InTimespan_IsValid;

	private static FFieldAddress AsTimespan_Timespan_InTimespan_PropertyAddress;

	private static int AsTimespan_Timespan_InTimespan_Offset;

	private static bool AsTimespan_Timespan_ReturnValue_IsValid;

	private static FFieldAddress AsTimespan_Timespan_ReturnValue_PropertyAddress;

	private static int AsTimespan_Timespan_ReturnValue_Offset;

	private static bool AsTime_DateTime_IsValid;

	private static IntPtr AsTime_DateTime_FunctionAddress;

	private static int AsTime_DateTime_ParamsSize;

	private static bool AsTime_DateTime_In_IsValid;

	private static FFieldAddress AsTime_DateTime_In_PropertyAddress;

	private static int AsTime_DateTime_In_Offset;

	private static bool AsTime_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsTime_DateTime_ReturnValue_PropertyAddress;

	private static int AsTime_DateTime_ReturnValue_Offset;

	private static bool AsPercent_Float_IsValid;

	private static IntPtr AsPercent_Float_FunctionAddress;

	private static int AsPercent_Float_ParamsSize;

	private static bool AsPercent_Float_Value_IsValid;

	private static FFieldAddress AsPercent_Float_Value_PropertyAddress;

	private static int AsPercent_Float_Value_Offset;

	private static bool AsPercent_Float_RoundingMode_IsValid;

	private static FFieldAddress AsPercent_Float_RoundingMode_PropertyAddress;

	private static int AsPercent_Float_RoundingMode_Offset;

	private static bool AsPercent_Float_bAlwaysSign_IsValid;

	private static FFieldAddress AsPercent_Float_bAlwaysSign_PropertyAddress;

	private static int AsPercent_Float_bAlwaysSign_Offset;

	private static bool AsPercent_Float_bUseGrouping_IsValid;

	private static FFieldAddress AsPercent_Float_bUseGrouping_PropertyAddress;

	private static int AsPercent_Float_bUseGrouping_Offset;

	private static bool AsPercent_Float_MinimumIntegralDigits_IsValid;

	private static FFieldAddress AsPercent_Float_MinimumIntegralDigits_PropertyAddress;

	private static int AsPercent_Float_MinimumIntegralDigits_Offset;

	private static bool AsPercent_Float_MaximumIntegralDigits_IsValid;

	private static FFieldAddress AsPercent_Float_MaximumIntegralDigits_PropertyAddress;

	private static int AsPercent_Float_MaximumIntegralDigits_Offset;

	private static bool AsPercent_Float_MinimumFractionalDigits_IsValid;

	private static FFieldAddress AsPercent_Float_MinimumFractionalDigits_PropertyAddress;

	private static int AsPercent_Float_MinimumFractionalDigits_Offset;

	private static bool AsPercent_Float_MaximumFractionalDigits_IsValid;

	private static FFieldAddress AsPercent_Float_MaximumFractionalDigits_PropertyAddress;

	private static int AsPercent_Float_MaximumFractionalDigits_Offset;

	private static bool AsPercent_Float_ReturnValue_IsValid;

	private static FFieldAddress AsPercent_Float_ReturnValue_PropertyAddress;

	private static int AsPercent_Float_ReturnValue_Offset;

	private static bool AsDateTime_DateTime_IsValid;

	private static IntPtr AsDateTime_DateTime_FunctionAddress;

	private static int AsDateTime_DateTime_ParamsSize;

	private static bool AsDateTime_DateTime_In_IsValid;

	private static FFieldAddress AsDateTime_DateTime_In_PropertyAddress;

	private static int AsDateTime_DateTime_In_Offset;

	private static bool AsDateTime_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsDateTime_DateTime_ReturnValue_PropertyAddress;

	private static int AsDateTime_DateTime_ReturnValue_Offset;

	private static bool AsDate_DateTime_IsValid;

	private static IntPtr AsDate_DateTime_FunctionAddress;

	private static int AsDate_DateTime_ParamsSize;

	private static bool AsDate_DateTime_InDateTime_IsValid;

	private static FFieldAddress AsDate_DateTime_InDateTime_PropertyAddress;

	private static int AsDate_DateTime_InDateTime_Offset;

	private static bool AsDate_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AsDate_DateTime_ReturnValue_PropertyAddress;

	private static int AsDate_DateTime_ReturnValue_Offset;

	private static bool AsCurrencyBase_IsValid;

	private static IntPtr AsCurrencyBase_FunctionAddress;

	private static int AsCurrencyBase_ParamsSize;

	private static bool AsCurrencyBase_BaseValue_IsValid;

	private static FFieldAddress AsCurrencyBase_BaseValue_PropertyAddress;

	private static int AsCurrencyBase_BaseValue_Offset;

	private static bool AsCurrencyBase_CurrencyCode_IsValid;

	private static FFieldAddress AsCurrencyBase_CurrencyCode_PropertyAddress;

	private static int AsCurrencyBase_CurrencyCode_Offset;

	private static bool AsCurrencyBase_ReturnValue_IsValid;

	private static FFieldAddress AsCurrencyBase_ReturnValue_PropertyAddress;

	private static int AsCurrencyBase_ReturnValue_Offset;

	private static bool AsCurrency_Integer_IsValid;

	private static IntPtr AsCurrency_Integer_FunctionAddress;

	private static int AsCurrency_Integer_ParamsSize;

	private static bool AsCurrency_Integer_Value_IsValid;

	private static FFieldAddress AsCurrency_Integer_Value_PropertyAddress;

	private static int AsCurrency_Integer_Value_Offset;

	private static bool AsCurrency_Integer_RoundingMode_IsValid;

	private static FFieldAddress AsCurrency_Integer_RoundingMode_PropertyAddress;

	private static int AsCurrency_Integer_RoundingMode_Offset;

	private static bool AsCurrency_Integer_bAlwaysSign_IsValid;

	private static FFieldAddress AsCurrency_Integer_bAlwaysSign_PropertyAddress;

	private static int AsCurrency_Integer_bAlwaysSign_Offset;

	private static bool AsCurrency_Integer_bUseGrouping_IsValid;

	private static FFieldAddress AsCurrency_Integer_bUseGrouping_PropertyAddress;

	private static int AsCurrency_Integer_bUseGrouping_Offset;

	private static bool AsCurrency_Integer_MinimumIntegralDigits_IsValid;

	private static FFieldAddress AsCurrency_Integer_MinimumIntegralDigits_PropertyAddress;

	private static int AsCurrency_Integer_MinimumIntegralDigits_Offset;

	private static bool AsCurrency_Integer_MaximumIntegralDigits_IsValid;

	private static FFieldAddress AsCurrency_Integer_MaximumIntegralDigits_PropertyAddress;

	private static int AsCurrency_Integer_MaximumIntegralDigits_Offset;

	private static bool AsCurrency_Integer_MinimumFractionalDigits_IsValid;

	private static FFieldAddress AsCurrency_Integer_MinimumFractionalDigits_PropertyAddress;

	private static int AsCurrency_Integer_MinimumFractionalDigits_Offset;

	private static bool AsCurrency_Integer_MaximumFractionalDigits_IsValid;

	private static FFieldAddress AsCurrency_Integer_MaximumFractionalDigits_PropertyAddress;

	private static int AsCurrency_Integer_MaximumFractionalDigits_Offset;

	private static bool AsCurrency_Integer_CurrencyCode_IsValid;

	private static FFieldAddress AsCurrency_Integer_CurrencyCode_PropertyAddress;

	private static int AsCurrency_Integer_CurrencyCode_Offset;

	private static bool AsCurrency_Integer_ReturnValue_IsValid;

	private static FFieldAddress AsCurrency_Integer_ReturnValue_PropertyAddress;

	private static int AsCurrency_Integer_ReturnValue_Offset;

	private static bool AsCurrency_Float_IsValid;

	private static IntPtr AsCurrency_Float_FunctionAddress;

	private static int AsCurrency_Float_ParamsSize;

	private static bool AsCurrency_Float_Value_IsValid;

	private static FFieldAddress AsCurrency_Float_Value_PropertyAddress;

	private static int AsCurrency_Float_Value_Offset;

	private static bool AsCurrency_Float_RoundingMode_IsValid;

	private static FFieldAddress AsCurrency_Float_RoundingMode_PropertyAddress;

	private static int AsCurrency_Float_RoundingMode_Offset;

	private static bool AsCurrency_Float_bAlwaysSign_IsValid;

	private static FFieldAddress AsCurrency_Float_bAlwaysSign_PropertyAddress;

	private static int AsCurrency_Float_bAlwaysSign_Offset;

	private static bool AsCurrency_Float_bUseGrouping_IsValid;

	private static FFieldAddress AsCurrency_Float_bUseGrouping_PropertyAddress;

	private static int AsCurrency_Float_bUseGrouping_Offset;

	private static bool AsCurrency_Float_MinimumIntegralDigits_IsValid;

	private static FFieldAddress AsCurrency_Float_MinimumIntegralDigits_PropertyAddress;

	private static int AsCurrency_Float_MinimumIntegralDigits_Offset;

	private static bool AsCurrency_Float_MaximumIntegralDigits_IsValid;

	private static FFieldAddress AsCurrency_Float_MaximumIntegralDigits_PropertyAddress;

	private static int AsCurrency_Float_MaximumIntegralDigits_Offset;

	private static bool AsCurrency_Float_MinimumFractionalDigits_IsValid;

	private static FFieldAddress AsCurrency_Float_MinimumFractionalDigits_PropertyAddress;

	private static int AsCurrency_Float_MinimumFractionalDigits_Offset;

	private static bool AsCurrency_Float_MaximumFractionalDigits_IsValid;

	private static FFieldAddress AsCurrency_Float_MaximumFractionalDigits_PropertyAddress;

	private static int AsCurrency_Float_MaximumFractionalDigits_Offset;

	private static bool AsCurrency_Float_CurrencyCode_IsValid;

	private static FFieldAddress AsCurrency_Float_CurrencyCode_PropertyAddress;

	private static int AsCurrency_Float_CurrencyCode_Offset;

	private static bool AsCurrency_Float_ReturnValue_IsValid;

	private static FFieldAddress AsCurrency_Float_ReturnValue_PropertyAddress;

	private static int AsCurrency_Float_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextTrimTrailing")]
	public unsafe static string TextTrimTrailing(FText InText)
	{
		if (!TextTrimTrailing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextTrimTrailing");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextTrimTrailing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextTrimTrailing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextTrimTrailing_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextTrimTrailing_InText_Offset), 0, TextTrimTrailing_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextTrimTrailing_FunctionAddress, intPtr, TextTrimTrailing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextTrimTrailing_InText_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextTrimTrailing_ReturnValue_Offset), 0, TextTrimTrailing_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextTrimTrailing_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextTrimPrecedingAndTrailing")]
	public unsafe static string TextTrimPrecedingAndTrailing(FText InText)
	{
		if (!TextTrimPrecedingAndTrailing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextTrimPrecedingAndTrailing");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextTrimPrecedingAndTrailing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextTrimPrecedingAndTrailing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextTrimPrecedingAndTrailing_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextTrimPrecedingAndTrailing_InText_Offset), 0, TextTrimPrecedingAndTrailing_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextTrimPrecedingAndTrailing_FunctionAddress, intPtr, TextTrimPrecedingAndTrailing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextTrimPrecedingAndTrailing_InText_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextTrimPrecedingAndTrailing_ReturnValue_Offset), 0, TextTrimPrecedingAndTrailing_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextTrimPrecedingAndTrailing_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextTrimPreceding")]
	public unsafe static string TextTrimPreceding(FText InText)
	{
		if (!TextTrimPreceding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextTrimPreceding");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextTrimPreceding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextTrimPreceding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextTrimPreceding_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextTrimPreceding_InText_Offset), 0, TextTrimPreceding_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextTrimPreceding_FunctionAddress, intPtr, TextTrimPreceding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextTrimPreceding_InText_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextTrimPreceding_ReturnValue_Offset), 0, TextTrimPreceding_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextTrimPreceding_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextToUpper")]
	public unsafe static string TextToUpper(FText InText)
	{
		if (!TextToUpper_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextToUpper");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextToUpper_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextToUpper_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextToUpper_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextToUpper_InText_Offset), 0, TextToUpper_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextToUpper_FunctionAddress, intPtr, TextToUpper_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextToUpper_InText_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextToUpper_ReturnValue_Offset), 0, TextToUpper_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextToUpper_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextToLower")]
	public unsafe static string TextToLower(FText InText)
	{
		if (!TextToLower_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextToLower");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextToLower_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextToLower_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextToLower_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextToLower_InText_Offset), 0, TextToLower_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextToLower_FunctionAddress, intPtr, TextToLower_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextToLower_InText_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextToLower_ReturnValue_Offset), 0, TextToLower_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextToLower_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextIsTransient")]
	public unsafe static bool TextIsTransient(FText InText)
	{
		if (!TextIsTransient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextIsTransient");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextIsTransient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextIsTransient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextIsTransient_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextIsTransient_InText_Offset), 0, TextIsTransient_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextIsTransient_FunctionAddress, intPtr, TextIsTransient_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextIsTransient_InText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TextIsTransient_ReturnValue_Offset), 0, TextIsTransient_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextIsFromStringTable")]
	public unsafe static bool TextIsFromStringTable(FText Text)
	{
		if (!TextIsFromStringTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextIsFromStringTable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextIsFromStringTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextIsFromStringTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextIsFromStringTable_Text_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextIsFromStringTable_Text_Offset), 0, TextIsFromStringTable_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextIsFromStringTable_FunctionAddress, intPtr, TextIsFromStringTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextIsFromStringTable_Text_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TextIsFromStringTable_ReturnValue_Offset), 0, TextIsFromStringTable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextIsEmpty")]
	public unsafe static bool TextIsEmpty(FText InText)
	{
		if (!TextIsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextIsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextIsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextIsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextIsEmpty_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextIsEmpty_InText_Offset), 0, TextIsEmpty_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextIsEmpty_FunctionAddress, intPtr, TextIsEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextIsEmpty_InText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TextIsEmpty_ReturnValue_Offset), 0, TextIsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextIsCultureInvariant")]
	public unsafe static bool TextIsCultureInvariant(FText InText)
	{
		if (!TextIsCultureInvariant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextIsCultureInvariant");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextIsCultureInvariant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextIsCultureInvariant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TextIsCultureInvariant_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, TextIsCultureInvariant_InText_Offset), 0, TextIsCultureInvariant_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextIsCultureInvariant_FunctionAddress, intPtr, TextIsCultureInvariant_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextIsCultureInvariant_InText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TextIsCultureInvariant_ReturnValue_Offset), 0, TextIsCultureInvariant_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:TextFromStringTable")]
	public unsafe static string TextFromStringTable(FName TableId, string Key)
	{
		if (!TextFromStringTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:TextFromStringTable");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TextFromStringTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TextFromStringTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, TextFromStringTable_TableId_Offset), 0, TextFromStringTable_TableId_PropertyAddress.Address, TableId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TextFromStringTable_Key_Offset), 0, TextFromStringTable_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TextFromStringTable_FunctionAddress, intPtr, TextFromStringTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TextFromStringTable_Key_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, TextFromStringTable_ReturnValue_Offset), 0, TextFromStringTable_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(TextFromStringTable_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:StringTableIdAndKeyFromText")]
	public unsafe static bool StringTableIdAndKeyFromText(FText Text, out FName OutTableId, out string OutKey)
	{
		if (!StringTableIdAndKeyFromText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:StringTableIdAndKeyFromText");
			OutTableId = default(FName);
			OutKey = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StringTableIdAndKeyFromText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StringTableIdAndKeyFromText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StringTableIdAndKeyFromText_Text_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, StringTableIdAndKeyFromText_Text_Offset), 0, StringTableIdAndKeyFromText_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StringTableIdAndKeyFromText_FunctionAddress, intPtr, StringTableIdAndKeyFromText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StringTableIdAndKeyFromText_Text_PropertyAddress.Address, intPtr);
		OutTableId = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, StringTableIdAndKeyFromText_OutTableId_Offset), 0, StringTableIdAndKeyFromText_OutTableId_PropertyAddress.Address);
		OutKey = FStringMarshaler.FromNative(IntPtr.Add(intPtr, StringTableIdAndKeyFromText_OutKey_Offset), 0, StringTableIdAndKeyFromText_OutKey_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(StringTableIdAndKeyFromText_OutKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StringTableIdAndKeyFromText_ReturnValue_Offset), 0, StringTableIdAndKeyFromText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:PolyglotDataToText")]
	public unsafe static string PolyglotDataToText(FPolyglotTextData PolyglotData)
	{
		if (!PolyglotDataToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:PolyglotDataToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PolyglotDataToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PolyglotDataToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PolyglotDataToText_PolyglotData_PropertyAddress.Address, intPtr);
		FPolyglotTextData.ToNative(IntPtr.Add(intPtr, PolyglotDataToText_PolyglotData_Offset), 0, PolyglotDataToText_PolyglotData_PropertyAddress.Address, PolyglotData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PolyglotDataToText_FunctionAddress, intPtr, PolyglotDataToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PolyglotDataToText_PolyglotData_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, PolyglotDataToText_ReturnValue_Offset), 0, PolyglotDataToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(PolyglotDataToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:NotEqual_TextText")]
	public unsafe static bool NotEqual_TextText(FText A, FText B)
	{
		if (!NotEqual_TextText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:NotEqual_TextText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_TextText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_TextText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotEqual_TextText_A_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_TextText_A_Offset), 0, NotEqual_TextText_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(NotEqual_TextText_B_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_TextText_B_Offset), 0, NotEqual_TextText_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_TextText_FunctionAddress, intPtr, NotEqual_TextText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotEqual_TextText_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NotEqual_TextText_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_TextText_ReturnValue_Offset), 0, NotEqual_TextText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:NotEqual_IgnoreCase_TextText")]
	public unsafe static bool NotEqual_IgnoreCase_TextText(FText A, FText B)
	{
		if (!NotEqual_IgnoreCase_TextText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:NotEqual_IgnoreCase_TextText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_IgnoreCase_TextText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_IgnoreCase_TextText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotEqual_IgnoreCase_TextText_A_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_IgnoreCase_TextText_A_Offset), 0, NotEqual_IgnoreCase_TextText_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(NotEqual_IgnoreCase_TextText_B_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_IgnoreCase_TextText_B_Offset), 0, NotEqual_IgnoreCase_TextText_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_IgnoreCase_TextText_FunctionAddress, intPtr, NotEqual_IgnoreCase_TextText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotEqual_IgnoreCase_TextText_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NotEqual_IgnoreCase_TextText_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_IgnoreCase_TextText_ReturnValue_Offset), 0, NotEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:IsPolyglotDataValid")]
	public unsafe static void IsPolyglotDataValid(FPolyglotTextData PolyglotData, out bool IsValid, out FText ErrorMessage)
	{
		if (!IsPolyglotDataValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:IsPolyglotDataValid");
			IsValid = false;
			ErrorMessage = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPolyglotDataValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPolyglotDataValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsPolyglotDataValid_PolyglotData_PropertyAddress.Address, intPtr);
		FPolyglotTextData.ToNative(IntPtr.Add(intPtr, IsPolyglotDataValid_PolyglotData_Offset), 0, IsPolyglotDataValid_PolyglotData_PropertyAddress.Address, PolyglotData);
		NativeReflection.InitializeValue_InContainer(IsPolyglotDataValid_ErrorMessage_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPolyglotDataValid_FunctionAddress, intPtr, IsPolyglotDataValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPolyglotDataValid_PolyglotData_PropertyAddress.Address, intPtr);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPolyglotDataValid_IsValid_Offset), 0, IsPolyglotDataValid_IsValid_PropertyAddress.Address);
		ErrorMessage = FTextMarshaler.FromNative(IntPtr.Add(intPtr, IsPolyglotDataValid_ErrorMessage_Offset), 0, IsPolyglotDataValid_ErrorMessage_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IsPolyglotDataValid_ErrorMessage_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:GetEmptyText")]
	public unsafe static string GetEmptyText()
	{
		if (!GetEmptyText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:GetEmptyText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEmptyText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEmptyText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEmptyText_FunctionAddress, intPtr, GetEmptyText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetEmptyText_ReturnValue_Offset), 0, GetEmptyText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetEmptyText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:FindTextInLocalizationTable")]
	public unsafe static bool FindTextInLocalizationTable(string Namespace, string Key, out FText OutText)
	{
		if (!FindTextInLocalizationTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:FindTextInLocalizationTable");
			OutText = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTextInLocalizationTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTextInLocalizationTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindTextInLocalizationTable_Namespace_Offset), 0, FindTextInLocalizationTable_Namespace_PropertyAddress.Address, Namespace);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindTextInLocalizationTable_Key_Offset), 0, FindTextInLocalizationTable_Key_PropertyAddress.Address, Key);
		NativeReflection.InitializeValue_InContainer(FindTextInLocalizationTable_OutText_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindTextInLocalizationTable_FunctionAddress, intPtr, FindTextInLocalizationTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindTextInLocalizationTable_Namespace_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindTextInLocalizationTable_Key_PropertyAddress.Address, intPtr);
		OutText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, FindTextInLocalizationTable_OutText_Offset), 0, FindTextInLocalizationTable_OutText_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindTextInLocalizationTable_OutText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindTextInLocalizationTable_ReturnValue_Offset), 0, FindTextInLocalizationTable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:EqualEqual_TextText")]
	public unsafe static bool EqualEqual_TextText(FText A, FText B)
	{
		if (!EqualEqual_TextText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:EqualEqual_TextText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_TextText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_TextText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_TextText_A_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_TextText_A_Offset), 0, EqualEqual_TextText_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_TextText_B_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_TextText_B_Offset), 0, EqualEqual_TextText_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_TextText_FunctionAddress, intPtr, EqualEqual_TextText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_TextText_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_TextText_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_TextText_ReturnValue_Offset), 0, EqualEqual_TextText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:EqualEqual_IgnoreCase_TextText")]
	public unsafe static bool EqualEqual_IgnoreCase_TextText(FText A, FText B)
	{
		if (!EqualEqual_IgnoreCase_TextText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:EqualEqual_IgnoreCase_TextText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_IgnoreCase_TextText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_IgnoreCase_TextText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_IgnoreCase_TextText_A_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_IgnoreCase_TextText_A_Offset), 0, EqualEqual_IgnoreCase_TextText_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_IgnoreCase_TextText_B_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_IgnoreCase_TextText_B_Offset), 0, EqualEqual_IgnoreCase_TextText_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_IgnoreCase_TextText_FunctionAddress, intPtr, EqualEqual_IgnoreCase_TextText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_IgnoreCase_TextText_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_IgnoreCase_TextText_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_IgnoreCase_TextText_ReturnValue_Offset), 0, EqualEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_VectorToText")]
	public unsafe static string Conv_VectorToText(FVector InVec)
	{
		if (!Conv_VectorToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_VectorToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_VectorToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_VectorToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Conv_VectorToText_InVec_Offset), 0, Conv_VectorToText_InVec_PropertyAddress.Address, InVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_VectorToText_FunctionAddress, intPtr, Conv_VectorToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_VectorToText_ReturnValue_Offset), 0, Conv_VectorToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_VectorToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_Vector2dToText")]
	public unsafe static string Conv_Vector2dToText(FVector2D InVec)
	{
		if (!Conv_Vector2dToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_Vector2dToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_Vector2dToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_Vector2dToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Conv_Vector2dToText_InVec_Offset), 0, Conv_Vector2dToText_InVec_PropertyAddress.Address, InVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_Vector2dToText_FunctionAddress, intPtr, Conv_Vector2dToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_Vector2dToText_ReturnValue_Offset), 0, Conv_Vector2dToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_Vector2dToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_TransformToText")]
	public unsafe static string Conv_TransformToText(FTransform InTrans)
	{
		if (!Conv_TransformToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_TransformToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_TransformToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_TransformToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_TransformToText_InTrans_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Conv_TransformToText_InTrans_Offset), 0, Conv_TransformToText_InTrans_PropertyAddress.Address, InTrans);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_TransformToText_FunctionAddress, intPtr, Conv_TransformToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_TransformToText_ReturnValue_Offset), 0, Conv_TransformToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_TransformToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_TextToString")]
	public unsafe static string Conv_TextToString(FText InText)
	{
		if (!Conv_TextToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_TextToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_TextToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_TextToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_TextToString_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, Conv_TextToString_InText_Offset), 0, Conv_TextToString_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_TextToString_FunctionAddress, intPtr, Conv_TextToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_TextToString_InText_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_TextToString_ReturnValue_Offset), 0, Conv_TextToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_TextToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_StringToText")]
	public unsafe static string Conv_StringToText(string InString)
	{
		if (!Conv_StringToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_StringToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToText_InString_Offset), 0, Conv_StringToText_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToText_FunctionAddress, intPtr, Conv_StringToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToText_InString_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToText_ReturnValue_Offset), 0, Conv_StringToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_StringToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_RotatorToText")]
	public unsafe static string Conv_RotatorToText(FRotator InRot)
	{
		if (!Conv_RotatorToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_RotatorToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_RotatorToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_RotatorToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Conv_RotatorToText_InRot_Offset), 0, Conv_RotatorToText_InRot_PropertyAddress.Address, InRot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_RotatorToText_FunctionAddress, intPtr, Conv_RotatorToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_RotatorToText_ReturnValue_Offset), 0, Conv_RotatorToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_RotatorToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_ObjectToText")]
	public unsafe static string Conv_ObjectToText(UObject InObj)
	{
		if (!Conv_ObjectToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_ObjectToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ObjectToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ObjectToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Conv_ObjectToText_InObj_Offset), 0, Conv_ObjectToText_InObj_PropertyAddress.Address, InObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ObjectToText_FunctionAddress, intPtr, Conv_ObjectToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ObjectToText_ReturnValue_Offset), 0, Conv_ObjectToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_ObjectToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_NameToText")]
	public unsafe static string Conv_NameToText(FName InName)
	{
		if (!Conv_NameToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_NameToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_NameToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_NameToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Conv_NameToText_InName_Offset), 0, Conv_NameToText_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_NameToText_FunctionAddress, intPtr, Conv_NameToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_NameToText_ReturnValue_Offset), 0, Conv_NameToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_NameToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_IntToText")]
	public unsafe static string Conv_IntToText(int Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
	{
		if (!Conv_IntToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_IntToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_IntToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_IntToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_IntToText_Value_Offset), 0, Conv_IntToText_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_IntToText_bAlwaysSign_Offset), 0, Conv_IntToText_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_IntToText_bUseGrouping_Offset), 0, Conv_IntToText_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_IntToText_MinimumIntegralDigits_Offset), 0, Conv_IntToText_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_IntToText_MaximumIntegralDigits_Offset), 0, Conv_IntToText_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_IntToText_FunctionAddress, intPtr, Conv_IntToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_IntToText_ReturnValue_Offset), 0, Conv_IntToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_IntToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_Int64ToText")]
	public unsafe static string Conv_Int64ToText(long Value, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324)
	{
		if (!Conv_Int64ToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_Int64ToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_Int64ToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_Int64ToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, Conv_Int64ToText_Value_Offset), 0, Conv_Int64ToText_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_Int64ToText_bAlwaysSign_Offset), 0, Conv_Int64ToText_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_Int64ToText_bUseGrouping_Offset), 0, Conv_Int64ToText_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_Int64ToText_MinimumIntegralDigits_Offset), 0, Conv_Int64ToText_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_Int64ToText_MaximumIntegralDigits_Offset), 0, Conv_Int64ToText_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_Int64ToText_FunctionAddress, intPtr, Conv_Int64ToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_Int64ToText_ReturnValue_Offset), 0, Conv_Int64ToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_Int64ToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_FloatToText")]
	public unsafe static string Conv_FloatToText(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
	{
		if (!Conv_FloatToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_FloatToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FloatToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FloatToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_Value_Offset), 0, Conv_FloatToText_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERoundingMode>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_RoundingMode_Offset), 0, Conv_FloatToText_RoundingMode_PropertyAddress.Address, RoundingMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_bAlwaysSign_Offset), 0, Conv_FloatToText_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_bUseGrouping_Offset), 0, Conv_FloatToText_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_MinimumIntegralDigits_Offset), 0, Conv_FloatToText_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_MaximumIntegralDigits_Offset), 0, Conv_FloatToText_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_MinimumFractionalDigits_Offset), 0, Conv_FloatToText_MinimumFractionalDigits_PropertyAddress.Address, MinimumFractionalDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_FloatToText_MaximumFractionalDigits_Offset), 0, Conv_FloatToText_MaximumFractionalDigits_PropertyAddress.Address, MaximumFractionalDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FloatToText_FunctionAddress, intPtr, Conv_FloatToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FloatToText_ReturnValue_Offset), 0, Conv_FloatToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FloatToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_DoubleToText")]
	public unsafe static string Conv_DoubleToText(double InDouble, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
	{
		if (!Conv_DoubleToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_DoubleToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_DoubleToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_DoubleToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_InDouble_Offset), 0, Conv_DoubleToText_InDouble_PropertyAddress.Address, InDouble);
		EnumMarshaler<ERoundingMode>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_RoundingMode_Offset), 0, Conv_DoubleToText_RoundingMode_PropertyAddress.Address, RoundingMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_bAlwaysSign_Offset), 0, Conv_DoubleToText_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_bUseGrouping_Offset), 0, Conv_DoubleToText_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_MinimumIntegralDigits_Offset), 0, Conv_DoubleToText_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_MaximumIntegralDigits_Offset), 0, Conv_DoubleToText_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_MinimumFractionalDigits_Offset), 0, Conv_DoubleToText_MinimumFractionalDigits_PropertyAddress.Address, MinimumFractionalDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToText_MaximumFractionalDigits_Offset), 0, Conv_DoubleToText_MaximumFractionalDigits_PropertyAddress.Address, MaximumFractionalDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_DoubleToText_FunctionAddress, intPtr, Conv_DoubleToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_DoubleToText_ReturnValue_Offset), 0, Conv_DoubleToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_DoubleToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_ColorToText")]
	public unsafe static string Conv_ColorToText(FLinearColor InColor)
	{
		if (!Conv_ColorToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_ColorToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ColorToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ColorToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, Conv_ColorToText_InColor_Offset), 0, Conv_ColorToText_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ColorToText_FunctionAddress, intPtr, Conv_ColorToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ColorToText_ReturnValue_Offset), 0, Conv_ColorToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_ColorToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_ByteToText")]
	public unsafe static string Conv_ByteToText(byte Value)
	{
		if (!Conv_ByteToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_ByteToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ByteToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ByteToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, Conv_ByteToText_Value_Offset), 0, Conv_ByteToText_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ByteToText_FunctionAddress, intPtr, Conv_ByteToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ByteToText_ReturnValue_Offset), 0, Conv_ByteToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_ByteToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:Conv_BoolToText")]
	public unsafe static string Conv_BoolToText(bool InBool)
	{
		if (!Conv_BoolToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:Conv_BoolToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_BoolToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_BoolToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_BoolToText_InBool_Offset), 0, Conv_BoolToText_InBool_PropertyAddress.Address, InBool);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_BoolToText_FunctionAddress, intPtr, Conv_BoolToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_BoolToText_ReturnValue_Offset), 0, Conv_BoolToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_BoolToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsTimeZoneTime_DateTime")]
	public unsafe static string AsTimeZoneTime_DateTime(FDateTime InDateTime, string InTimeZone)
	{
		if (!AsTimeZoneTime_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsTimeZoneTime_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsTimeZoneTime_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsTimeZoneTime_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsTimeZoneTime_DateTime_InDateTime_Offset), 0, AsTimeZoneTime_DateTime_InDateTime_PropertyAddress.Address, InDateTime);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsTimeZoneTime_DateTime_InTimeZone_Offset), 0, AsTimeZoneTime_DateTime_InTimeZone_PropertyAddress.Address, InTimeZone);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsTimeZoneTime_DateTime_FunctionAddress, intPtr, AsTimeZoneTime_DateTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsTimeZoneTime_DateTime_InTimeZone_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsTimeZoneTime_DateTime_ReturnValue_Offset), 0, AsTimeZoneTime_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsTimeZoneTime_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsTimeZoneDateTime_DateTime")]
	public unsafe static string AsTimeZoneDateTime_DateTime(FDateTime InDateTime, string InTimeZone)
	{
		if (!AsTimeZoneDateTime_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsTimeZoneDateTime_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsTimeZoneDateTime_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsTimeZoneDateTime_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsTimeZoneDateTime_DateTime_InDateTime_Offset), 0, AsTimeZoneDateTime_DateTime_InDateTime_PropertyAddress.Address, InDateTime);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsTimeZoneDateTime_DateTime_InTimeZone_Offset), 0, AsTimeZoneDateTime_DateTime_InTimeZone_PropertyAddress.Address, InTimeZone);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsTimeZoneDateTime_DateTime_FunctionAddress, intPtr, AsTimeZoneDateTime_DateTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsTimeZoneDateTime_DateTime_InTimeZone_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsTimeZoneDateTime_DateTime_ReturnValue_Offset), 0, AsTimeZoneDateTime_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsTimeZoneDateTime_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsTimeZoneDate_DateTime")]
	public unsafe static string AsTimeZoneDate_DateTime(FDateTime InDateTime, string InTimeZone)
	{
		if (!AsTimeZoneDate_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsTimeZoneDate_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsTimeZoneDate_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsTimeZoneDate_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsTimeZoneDate_DateTime_InDateTime_Offset), 0, AsTimeZoneDate_DateTime_InDateTime_PropertyAddress.Address, InDateTime);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsTimeZoneDate_DateTime_InTimeZone_Offset), 0, AsTimeZoneDate_DateTime_InTimeZone_PropertyAddress.Address, InTimeZone);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsTimeZoneDate_DateTime_FunctionAddress, intPtr, AsTimeZoneDate_DateTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsTimeZoneDate_DateTime_InTimeZone_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsTimeZoneDate_DateTime_ReturnValue_Offset), 0, AsTimeZoneDate_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsTimeZoneDate_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsTimespan_Timespan")]
	public unsafe static string AsTimespan_Timespan(FTimespan InTimespan)
	{
		if (!AsTimespan_Timespan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsTimespan_Timespan");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsTimespan_Timespan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsTimespan_Timespan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimespan.ToNative(IntPtr.Add(intPtr, AsTimespan_Timespan_InTimespan_Offset), 0, AsTimespan_Timespan_InTimespan_PropertyAddress.Address, InTimespan);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsTimespan_Timespan_FunctionAddress, intPtr, AsTimespan_Timespan_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsTimespan_Timespan_ReturnValue_Offset), 0, AsTimespan_Timespan_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsTimespan_Timespan_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsTime_DateTime")]
	public unsafe static string AsTime_DateTime(FDateTime In)
	{
		if (!AsTime_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsTime_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsTime_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsTime_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsTime_DateTime_In_Offset), 0, AsTime_DateTime_In_PropertyAddress.Address, In);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsTime_DateTime_FunctionAddress, intPtr, AsTime_DateTime_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsTime_DateTime_ReturnValue_Offset), 0, AsTime_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsTime_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsPercent_Float")]
	public unsafe static string AsPercent_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3)
	{
		if (!AsPercent_Float_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsPercent_Float");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsPercent_Float_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsPercent_Float_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_Value_Offset), 0, AsPercent_Float_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERoundingMode>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_RoundingMode_Offset), 0, AsPercent_Float_RoundingMode_PropertyAddress.Address, RoundingMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsPercent_Float_bAlwaysSign_Offset), 0, AsPercent_Float_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsPercent_Float_bUseGrouping_Offset), 0, AsPercent_Float_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_MinimumIntegralDigits_Offset), 0, AsPercent_Float_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_MaximumIntegralDigits_Offset), 0, AsPercent_Float_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_MinimumFractionalDigits_Offset), 0, AsPercent_Float_MinimumFractionalDigits_PropertyAddress.Address, MinimumFractionalDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsPercent_Float_MaximumFractionalDigits_Offset), 0, AsPercent_Float_MaximumFractionalDigits_PropertyAddress.Address, MaximumFractionalDigits);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsPercent_Float_FunctionAddress, intPtr, AsPercent_Float_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsPercent_Float_ReturnValue_Offset), 0, AsPercent_Float_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsPercent_Float_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsDateTime_DateTime")]
	public unsafe static string AsDateTime_DateTime(FDateTime In)
	{
		if (!AsDateTime_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsDateTime_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsDateTime_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsDateTime_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsDateTime_DateTime_In_Offset), 0, AsDateTime_DateTime_In_PropertyAddress.Address, In);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsDateTime_DateTime_FunctionAddress, intPtr, AsDateTime_DateTime_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsDateTime_DateTime_ReturnValue_Offset), 0, AsDateTime_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsDateTime_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsDate_DateTime")]
	public unsafe static string AsDate_DateTime(FDateTime InDateTime)
	{
		if (!AsDate_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsDate_DateTime");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsDate_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsDate_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AsDate_DateTime_InDateTime_Offset), 0, AsDate_DateTime_InDateTime_PropertyAddress.Address, InDateTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsDate_DateTime_FunctionAddress, intPtr, AsDate_DateTime_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsDate_DateTime_ReturnValue_Offset), 0, AsDate_DateTime_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsDate_DateTime_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsCurrencyBase")]
	public unsafe static string AsCurrencyBase(int BaseValue, string CurrencyCode)
	{
		if (!AsCurrencyBase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsCurrencyBase");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsCurrencyBase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsCurrencyBase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrencyBase_BaseValue_Offset), 0, AsCurrencyBase_BaseValue_PropertyAddress.Address, BaseValue);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrencyBase_CurrencyCode_Offset), 0, AsCurrencyBase_CurrencyCode_PropertyAddress.Address, CurrencyCode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsCurrencyBase_FunctionAddress, intPtr, AsCurrencyBase_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsCurrencyBase_CurrencyCode_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsCurrencyBase_ReturnValue_Offset), 0, AsCurrencyBase_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsCurrencyBase_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsCurrency_Integer")]
	public unsafe static string AsCurrency_Integer(int Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, string CurrencyCode = null)
	{
		if (!AsCurrency_Integer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsCurrency_Integer");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsCurrency_Integer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsCurrency_Integer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_Value_Offset), 0, AsCurrency_Integer_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERoundingMode>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_RoundingMode_Offset), 0, AsCurrency_Integer_RoundingMode_PropertyAddress.Address, RoundingMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_bAlwaysSign_Offset), 0, AsCurrency_Integer_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_bUseGrouping_Offset), 0, AsCurrency_Integer_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_MinimumIntegralDigits_Offset), 0, AsCurrency_Integer_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_MaximumIntegralDigits_Offset), 0, AsCurrency_Integer_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_MinimumFractionalDigits_Offset), 0, AsCurrency_Integer_MinimumFractionalDigits_PropertyAddress.Address, MinimumFractionalDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_MaximumFractionalDigits_Offset), 0, AsCurrency_Integer_MaximumFractionalDigits_PropertyAddress.Address, MaximumFractionalDigits);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Integer_CurrencyCode_Offset), 0, AsCurrency_Integer_CurrencyCode_PropertyAddress.Address, CurrencyCode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsCurrency_Integer_FunctionAddress, intPtr, AsCurrency_Integer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsCurrency_Integer_CurrencyCode_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsCurrency_Integer_ReturnValue_Offset), 0, AsCurrency_Integer_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsCurrency_Integer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetTextLibrary:AsCurrency_Float")]
	public unsafe static string AsCurrency_Float(float Value, ERoundingMode RoundingMode, bool bAlwaysSign = false, bool bUseGrouping = true, int MinimumIntegralDigits = 1, int MaximumIntegralDigits = 324, int MinimumFractionalDigits = 0, int MaximumFractionalDigits = 3, string CurrencyCode = null)
	{
		if (!AsCurrency_Float_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetTextLibrary:AsCurrency_Float");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsCurrency_Float_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsCurrency_Float_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_Value_Offset), 0, AsCurrency_Float_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERoundingMode>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_RoundingMode_Offset), 0, AsCurrency_Float_RoundingMode_PropertyAddress.Address, RoundingMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_bAlwaysSign_Offset), 0, AsCurrency_Float_bAlwaysSign_PropertyAddress.Address, bAlwaysSign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_bUseGrouping_Offset), 0, AsCurrency_Float_bUseGrouping_PropertyAddress.Address, bUseGrouping);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_MinimumIntegralDigits_Offset), 0, AsCurrency_Float_MinimumIntegralDigits_PropertyAddress.Address, MinimumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_MaximumIntegralDigits_Offset), 0, AsCurrency_Float_MaximumIntegralDigits_PropertyAddress.Address, MaximumIntegralDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_MinimumFractionalDigits_Offset), 0, AsCurrency_Float_MinimumFractionalDigits_PropertyAddress.Address, MinimumFractionalDigits);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_MaximumFractionalDigits_Offset), 0, AsCurrency_Float_MaximumFractionalDigits_PropertyAddress.Address, MaximumFractionalDigits);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsCurrency_Float_CurrencyCode_Offset), 0, AsCurrency_Float_CurrencyCode_PropertyAddress.Address, CurrencyCode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsCurrency_Float_FunctionAddress, intPtr, AsCurrency_Float_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsCurrency_Float_CurrencyCode_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, AsCurrency_Float_ReturnValue_Offset), 0, AsCurrency_Float_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(AsCurrency_Float_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UTextLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetTextLibrary");
		TextTrimTrailing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextTrimTrailing");
		TextTrimTrailing_ParamsSize = NativeReflection.GetFunctionParamsSize(TextTrimTrailing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextTrimTrailing_InText_PropertyAddress, TextTrimTrailing_FunctionAddress, "InText");
		TextTrimTrailing_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimTrailing_FunctionAddress, "InText");
		TextTrimTrailing_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimTrailing_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextTrimTrailing_ReturnValue_PropertyAddress, TextTrimTrailing_FunctionAddress, "ReturnValue");
		TextTrimTrailing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimTrailing_FunctionAddress, "ReturnValue");
		TextTrimTrailing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimTrailing_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextTrimTrailing_IsValid = TextTrimTrailing_FunctionAddress != IntPtr.Zero && TextTrimTrailing_InText_IsValid && TextTrimTrailing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextTrimTrailing", TextTrimTrailing_IsValid);
		TextTrimPrecedingAndTrailing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextTrimPrecedingAndTrailing");
		TextTrimPrecedingAndTrailing_ParamsSize = NativeReflection.GetFunctionParamsSize(TextTrimPrecedingAndTrailing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextTrimPrecedingAndTrailing_InText_PropertyAddress, TextTrimPrecedingAndTrailing_FunctionAddress, "InText");
		TextTrimPrecedingAndTrailing_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimPrecedingAndTrailing_FunctionAddress, "InText");
		TextTrimPrecedingAndTrailing_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimPrecedingAndTrailing_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextTrimPrecedingAndTrailing_ReturnValue_PropertyAddress, TextTrimPrecedingAndTrailing_FunctionAddress, "ReturnValue");
		TextTrimPrecedingAndTrailing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimPrecedingAndTrailing_FunctionAddress, "ReturnValue");
		TextTrimPrecedingAndTrailing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimPrecedingAndTrailing_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextTrimPrecedingAndTrailing_IsValid = TextTrimPrecedingAndTrailing_FunctionAddress != IntPtr.Zero && TextTrimPrecedingAndTrailing_InText_IsValid && TextTrimPrecedingAndTrailing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextTrimPrecedingAndTrailing", TextTrimPrecedingAndTrailing_IsValid);
		TextTrimPreceding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextTrimPreceding");
		TextTrimPreceding_ParamsSize = NativeReflection.GetFunctionParamsSize(TextTrimPreceding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextTrimPreceding_InText_PropertyAddress, TextTrimPreceding_FunctionAddress, "InText");
		TextTrimPreceding_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimPreceding_FunctionAddress, "InText");
		TextTrimPreceding_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimPreceding_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextTrimPreceding_ReturnValue_PropertyAddress, TextTrimPreceding_FunctionAddress, "ReturnValue");
		TextTrimPreceding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextTrimPreceding_FunctionAddress, "ReturnValue");
		TextTrimPreceding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextTrimPreceding_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextTrimPreceding_IsValid = TextTrimPreceding_FunctionAddress != IntPtr.Zero && TextTrimPreceding_InText_IsValid && TextTrimPreceding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextTrimPreceding", TextTrimPreceding_IsValid);
		TextToUpper_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextToUpper");
		TextToUpper_ParamsSize = NativeReflection.GetFunctionParamsSize(TextToUpper_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextToUpper_InText_PropertyAddress, TextToUpper_FunctionAddress, "InText");
		TextToUpper_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextToUpper_FunctionAddress, "InText");
		TextToUpper_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextToUpper_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextToUpper_ReturnValue_PropertyAddress, TextToUpper_FunctionAddress, "ReturnValue");
		TextToUpper_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextToUpper_FunctionAddress, "ReturnValue");
		TextToUpper_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextToUpper_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextToUpper_IsValid = TextToUpper_FunctionAddress != IntPtr.Zero && TextToUpper_InText_IsValid && TextToUpper_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextToUpper", TextToUpper_IsValid);
		TextToLower_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextToLower");
		TextToLower_ParamsSize = NativeReflection.GetFunctionParamsSize(TextToLower_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextToLower_InText_PropertyAddress, TextToLower_FunctionAddress, "InText");
		TextToLower_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextToLower_FunctionAddress, "InText");
		TextToLower_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextToLower_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextToLower_ReturnValue_PropertyAddress, TextToLower_FunctionAddress, "ReturnValue");
		TextToLower_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextToLower_FunctionAddress, "ReturnValue");
		TextToLower_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextToLower_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextToLower_IsValid = TextToLower_FunctionAddress != IntPtr.Zero && TextToLower_InText_IsValid && TextToLower_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextToLower", TextToLower_IsValid);
		TextIsTransient_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextIsTransient");
		TextIsTransient_ParamsSize = NativeReflection.GetFunctionParamsSize(TextIsTransient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextIsTransient_InText_PropertyAddress, TextIsTransient_FunctionAddress, "InText");
		TextIsTransient_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextIsTransient_FunctionAddress, "InText");
		TextIsTransient_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsTransient_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextIsTransient_ReturnValue_PropertyAddress, TextIsTransient_FunctionAddress, "ReturnValue");
		TextIsTransient_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextIsTransient_FunctionAddress, "ReturnValue");
		TextIsTransient_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsTransient_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TextIsTransient_IsValid = TextIsTransient_FunctionAddress != IntPtr.Zero && TextIsTransient_InText_IsValid && TextIsTransient_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextIsTransient", TextIsTransient_IsValid);
		TextIsFromStringTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextIsFromStringTable");
		TextIsFromStringTable_ParamsSize = NativeReflection.GetFunctionParamsSize(TextIsFromStringTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextIsFromStringTable_Text_PropertyAddress, TextIsFromStringTable_FunctionAddress, "Text");
		TextIsFromStringTable_Text_Offset = NativeReflectionCached.GetPropertyOffset(TextIsFromStringTable_FunctionAddress, "Text");
		TextIsFromStringTable_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsFromStringTable_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextIsFromStringTable_ReturnValue_PropertyAddress, TextIsFromStringTable_FunctionAddress, "ReturnValue");
		TextIsFromStringTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextIsFromStringTable_FunctionAddress, "ReturnValue");
		TextIsFromStringTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsFromStringTable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TextIsFromStringTable_IsValid = TextIsFromStringTable_FunctionAddress != IntPtr.Zero && TextIsFromStringTable_Text_IsValid && TextIsFromStringTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextIsFromStringTable", TextIsFromStringTable_IsValid);
		TextIsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextIsEmpty");
		TextIsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(TextIsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextIsEmpty_InText_PropertyAddress, TextIsEmpty_FunctionAddress, "InText");
		TextIsEmpty_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextIsEmpty_FunctionAddress, "InText");
		TextIsEmpty_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsEmpty_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextIsEmpty_ReturnValue_PropertyAddress, TextIsEmpty_FunctionAddress, "ReturnValue");
		TextIsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextIsEmpty_FunctionAddress, "ReturnValue");
		TextIsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TextIsEmpty_IsValid = TextIsEmpty_FunctionAddress != IntPtr.Zero && TextIsEmpty_InText_IsValid && TextIsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextIsEmpty", TextIsEmpty_IsValid);
		TextIsCultureInvariant_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextIsCultureInvariant");
		TextIsCultureInvariant_ParamsSize = NativeReflection.GetFunctionParamsSize(TextIsCultureInvariant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextIsCultureInvariant_InText_PropertyAddress, TextIsCultureInvariant_FunctionAddress, "InText");
		TextIsCultureInvariant_InText_Offset = NativeReflectionCached.GetPropertyOffset(TextIsCultureInvariant_FunctionAddress, "InText");
		TextIsCultureInvariant_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsCultureInvariant_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref TextIsCultureInvariant_ReturnValue_PropertyAddress, TextIsCultureInvariant_FunctionAddress, "ReturnValue");
		TextIsCultureInvariant_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextIsCultureInvariant_FunctionAddress, "ReturnValue");
		TextIsCultureInvariant_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextIsCultureInvariant_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TextIsCultureInvariant_IsValid = TextIsCultureInvariant_FunctionAddress != IntPtr.Zero && TextIsCultureInvariant_InText_IsValid && TextIsCultureInvariant_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextIsCultureInvariant", TextIsCultureInvariant_IsValid);
		TextFromStringTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TextFromStringTable");
		TextFromStringTable_ParamsSize = NativeReflection.GetFunctionParamsSize(TextFromStringTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TextFromStringTable_TableId_PropertyAddress, TextFromStringTable_FunctionAddress, "TableId");
		TextFromStringTable_TableId_Offset = NativeReflectionCached.GetPropertyOffset(TextFromStringTable_FunctionAddress, "TableId");
		TextFromStringTable_TableId_IsValid = NativeReflectionCached.ValidatePropertyClass(TextFromStringTable_FunctionAddress, "TableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TextFromStringTable_Key_PropertyAddress, TextFromStringTable_FunctionAddress, "Key");
		TextFromStringTable_Key_Offset = NativeReflectionCached.GetPropertyOffset(TextFromStringTable_FunctionAddress, "Key");
		TextFromStringTable_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(TextFromStringTable_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TextFromStringTable_ReturnValue_PropertyAddress, TextFromStringTable_FunctionAddress, "ReturnValue");
		TextFromStringTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TextFromStringTable_FunctionAddress, "ReturnValue");
		TextFromStringTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TextFromStringTable_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		TextFromStringTable_IsValid = TextFromStringTable_FunctionAddress != IntPtr.Zero && TextFromStringTable_TableId_IsValid && TextFromStringTable_Key_IsValid && TextFromStringTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:TextFromStringTable", TextFromStringTable_IsValid);
		StringTableIdAndKeyFromText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StringTableIdAndKeyFromText");
		StringTableIdAndKeyFromText_ParamsSize = NativeReflection.GetFunctionParamsSize(StringTableIdAndKeyFromText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StringTableIdAndKeyFromText_Text_PropertyAddress, StringTableIdAndKeyFromText_FunctionAddress, "Text");
		StringTableIdAndKeyFromText_Text_Offset = NativeReflectionCached.GetPropertyOffset(StringTableIdAndKeyFromText_FunctionAddress, "Text");
		StringTableIdAndKeyFromText_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(StringTableIdAndKeyFromText_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref StringTableIdAndKeyFromText_OutTableId_PropertyAddress, StringTableIdAndKeyFromText_FunctionAddress, "OutTableId");
		StringTableIdAndKeyFromText_OutTableId_Offset = NativeReflectionCached.GetPropertyOffset(StringTableIdAndKeyFromText_FunctionAddress, "OutTableId");
		StringTableIdAndKeyFromText_OutTableId_IsValid = NativeReflectionCached.ValidatePropertyClass(StringTableIdAndKeyFromText_FunctionAddress, "OutTableId", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref StringTableIdAndKeyFromText_OutKey_PropertyAddress, StringTableIdAndKeyFromText_FunctionAddress, "OutKey");
		StringTableIdAndKeyFromText_OutKey_Offset = NativeReflectionCached.GetPropertyOffset(StringTableIdAndKeyFromText_FunctionAddress, "OutKey");
		StringTableIdAndKeyFromText_OutKey_IsValid = NativeReflectionCached.ValidatePropertyClass(StringTableIdAndKeyFromText_FunctionAddress, "OutKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StringTableIdAndKeyFromText_ReturnValue_PropertyAddress, StringTableIdAndKeyFromText_FunctionAddress, "ReturnValue");
		StringTableIdAndKeyFromText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StringTableIdAndKeyFromText_FunctionAddress, "ReturnValue");
		StringTableIdAndKeyFromText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StringTableIdAndKeyFromText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StringTableIdAndKeyFromText_IsValid = StringTableIdAndKeyFromText_FunctionAddress != IntPtr.Zero && StringTableIdAndKeyFromText_Text_IsValid && StringTableIdAndKeyFromText_OutTableId_IsValid && StringTableIdAndKeyFromText_OutKey_IsValid && StringTableIdAndKeyFromText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:StringTableIdAndKeyFromText", StringTableIdAndKeyFromText_IsValid);
		PolyglotDataToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PolyglotDataToText");
		PolyglotDataToText_ParamsSize = NativeReflection.GetFunctionParamsSize(PolyglotDataToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PolyglotDataToText_PolyglotData_PropertyAddress, PolyglotDataToText_FunctionAddress, "PolyglotData");
		PolyglotDataToText_PolyglotData_Offset = NativeReflectionCached.GetPropertyOffset(PolyglotDataToText_FunctionAddress, "PolyglotData");
		PolyglotDataToText_PolyglotData_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyglotDataToText_FunctionAddress, "PolyglotData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyglotDataToText_ReturnValue_PropertyAddress, PolyglotDataToText_FunctionAddress, "ReturnValue");
		PolyglotDataToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PolyglotDataToText_FunctionAddress, "ReturnValue");
		PolyglotDataToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyglotDataToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		PolyglotDataToText_IsValid = PolyglotDataToText_FunctionAddress != IntPtr.Zero && PolyglotDataToText_PolyglotData_IsValid && PolyglotDataToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:PolyglotDataToText", PolyglotDataToText_IsValid);
		NotEqual_TextText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_TextText");
		NotEqual_TextText_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_TextText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_TextText_A_PropertyAddress, NotEqual_TextText_FunctionAddress, "A");
		NotEqual_TextText_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_TextText_FunctionAddress, "A");
		NotEqual_TextText_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_TextText_FunctionAddress, "A", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_TextText_B_PropertyAddress, NotEqual_TextText_FunctionAddress, "B");
		NotEqual_TextText_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_TextText_FunctionAddress, "B");
		NotEqual_TextText_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_TextText_FunctionAddress, "B", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_TextText_ReturnValue_PropertyAddress, NotEqual_TextText_FunctionAddress, "ReturnValue");
		NotEqual_TextText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_TextText_FunctionAddress, "ReturnValue");
		NotEqual_TextText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_TextText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_TextText_IsValid = NotEqual_TextText_FunctionAddress != IntPtr.Zero && NotEqual_TextText_A_IsValid && NotEqual_TextText_B_IsValid && NotEqual_TextText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:NotEqual_TextText", NotEqual_TextText_IsValid);
		NotEqual_IgnoreCase_TextText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_IgnoreCase_TextText");
		NotEqual_IgnoreCase_TextText_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_IgnoreCase_TextText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_IgnoreCase_TextText_A_PropertyAddress, NotEqual_IgnoreCase_TextText_FunctionAddress, "A");
		NotEqual_IgnoreCase_TextText_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_IgnoreCase_TextText_FunctionAddress, "A");
		NotEqual_IgnoreCase_TextText_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_IgnoreCase_TextText_FunctionAddress, "A", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_IgnoreCase_TextText_B_PropertyAddress, NotEqual_IgnoreCase_TextText_FunctionAddress, "B");
		NotEqual_IgnoreCase_TextText_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_IgnoreCase_TextText_FunctionAddress, "B");
		NotEqual_IgnoreCase_TextText_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_IgnoreCase_TextText_FunctionAddress, "B", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress, NotEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue");
		NotEqual_IgnoreCase_TextText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue");
		NotEqual_IgnoreCase_TextText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_IgnoreCase_TextText_IsValid = NotEqual_IgnoreCase_TextText_FunctionAddress != IntPtr.Zero && NotEqual_IgnoreCase_TextText_A_IsValid && NotEqual_IgnoreCase_TextText_B_IsValid && NotEqual_IgnoreCase_TextText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:NotEqual_IgnoreCase_TextText", NotEqual_IgnoreCase_TextText_IsValid);
		IsPolyglotDataValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPolyglotDataValid");
		IsPolyglotDataValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPolyglotDataValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPolyglotDataValid_PolyglotData_PropertyAddress, IsPolyglotDataValid_FunctionAddress, "PolyglotData");
		IsPolyglotDataValid_PolyglotData_Offset = NativeReflectionCached.GetPropertyOffset(IsPolyglotDataValid_FunctionAddress, "PolyglotData");
		IsPolyglotDataValid_PolyglotData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolyglotDataValid_FunctionAddress, "PolyglotData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPolyglotDataValid_IsValid_PropertyAddress, IsPolyglotDataValid_FunctionAddress, "IsValid");
		IsPolyglotDataValid_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(IsPolyglotDataValid_FunctionAddress, "IsValid");
		IsPolyglotDataValid_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolyglotDataValid_FunctionAddress, "IsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPolyglotDataValid_ErrorMessage_PropertyAddress, IsPolyglotDataValid_FunctionAddress, "ErrorMessage");
		IsPolyglotDataValid_ErrorMessage_Offset = NativeReflectionCached.GetPropertyOffset(IsPolyglotDataValid_FunctionAddress, "ErrorMessage");
		IsPolyglotDataValid_ErrorMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolyglotDataValid_FunctionAddress, "ErrorMessage", Classes.FTextProperty);
		IsPolyglotDataValid_IsValid = IsPolyglotDataValid_FunctionAddress != IntPtr.Zero && IsPolyglotDataValid_PolyglotData_IsValid && IsPolyglotDataValid_IsValid_IsValid && IsPolyglotDataValid_ErrorMessage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:IsPolyglotDataValid", IsPolyglotDataValid_IsValid);
		GetEmptyText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEmptyText");
		GetEmptyText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEmptyText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEmptyText_ReturnValue_PropertyAddress, GetEmptyText_FunctionAddress, "ReturnValue");
		GetEmptyText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEmptyText_FunctionAddress, "ReturnValue");
		GetEmptyText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEmptyText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetEmptyText_IsValid = GetEmptyText_FunctionAddress != IntPtr.Zero && GetEmptyText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:GetEmptyText", GetEmptyText_IsValid);
		FindTextInLocalizationTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindTextInLocalizationTable");
		FindTextInLocalizationTable_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTextInLocalizationTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTextInLocalizationTable_Namespace_PropertyAddress, FindTextInLocalizationTable_FunctionAddress, "Namespace");
		FindTextInLocalizationTable_Namespace_Offset = NativeReflectionCached.GetPropertyOffset(FindTextInLocalizationTable_FunctionAddress, "Namespace");
		FindTextInLocalizationTable_Namespace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTextInLocalizationTable_FunctionAddress, "Namespace", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTextInLocalizationTable_Key_PropertyAddress, FindTextInLocalizationTable_FunctionAddress, "Key");
		FindTextInLocalizationTable_Key_Offset = NativeReflectionCached.GetPropertyOffset(FindTextInLocalizationTable_FunctionAddress, "Key");
		FindTextInLocalizationTable_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTextInLocalizationTable_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTextInLocalizationTable_OutText_PropertyAddress, FindTextInLocalizationTable_FunctionAddress, "OutText");
		FindTextInLocalizationTable_OutText_Offset = NativeReflectionCached.GetPropertyOffset(FindTextInLocalizationTable_FunctionAddress, "OutText");
		FindTextInLocalizationTable_OutText_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTextInLocalizationTable_FunctionAddress, "OutText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTextInLocalizationTable_ReturnValue_PropertyAddress, FindTextInLocalizationTable_FunctionAddress, "ReturnValue");
		FindTextInLocalizationTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTextInLocalizationTable_FunctionAddress, "ReturnValue");
		FindTextInLocalizationTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTextInLocalizationTable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindTextInLocalizationTable_IsValid = FindTextInLocalizationTable_FunctionAddress != IntPtr.Zero && FindTextInLocalizationTable_Namespace_IsValid && FindTextInLocalizationTable_Key_IsValid && FindTextInLocalizationTable_OutText_IsValid && FindTextInLocalizationTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:FindTextInLocalizationTable", FindTextInLocalizationTable_IsValid);
		EqualEqual_TextText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_TextText");
		EqualEqual_TextText_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_TextText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_TextText_A_PropertyAddress, EqualEqual_TextText_FunctionAddress, "A");
		EqualEqual_TextText_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_TextText_FunctionAddress, "A");
		EqualEqual_TextText_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_TextText_FunctionAddress, "A", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_TextText_B_PropertyAddress, EqualEqual_TextText_FunctionAddress, "B");
		EqualEqual_TextText_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_TextText_FunctionAddress, "B");
		EqualEqual_TextText_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_TextText_FunctionAddress, "B", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_TextText_ReturnValue_PropertyAddress, EqualEqual_TextText_FunctionAddress, "ReturnValue");
		EqualEqual_TextText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_TextText_FunctionAddress, "ReturnValue");
		EqualEqual_TextText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_TextText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_TextText_IsValid = EqualEqual_TextText_FunctionAddress != IntPtr.Zero && EqualEqual_TextText_A_IsValid && EqualEqual_TextText_B_IsValid && EqualEqual_TextText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:EqualEqual_TextText", EqualEqual_TextText_IsValid);
		EqualEqual_IgnoreCase_TextText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_IgnoreCase_TextText");
		EqualEqual_IgnoreCase_TextText_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_IgnoreCase_TextText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_IgnoreCase_TextText_A_PropertyAddress, EqualEqual_IgnoreCase_TextText_FunctionAddress, "A");
		EqualEqual_IgnoreCase_TextText_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_IgnoreCase_TextText_FunctionAddress, "A");
		EqualEqual_IgnoreCase_TextText_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_IgnoreCase_TextText_FunctionAddress, "A", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_IgnoreCase_TextText_B_PropertyAddress, EqualEqual_IgnoreCase_TextText_FunctionAddress, "B");
		EqualEqual_IgnoreCase_TextText_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_IgnoreCase_TextText_FunctionAddress, "B");
		EqualEqual_IgnoreCase_TextText_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_IgnoreCase_TextText_FunctionAddress, "B", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_IgnoreCase_TextText_ReturnValue_PropertyAddress, EqualEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue");
		EqualEqual_IgnoreCase_TextText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue");
		EqualEqual_IgnoreCase_TextText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_IgnoreCase_TextText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_IgnoreCase_TextText_IsValid = EqualEqual_IgnoreCase_TextText_FunctionAddress != IntPtr.Zero && EqualEqual_IgnoreCase_TextText_A_IsValid && EqualEqual_IgnoreCase_TextText_B_IsValid && EqualEqual_IgnoreCase_TextText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:EqualEqual_IgnoreCase_TextText", EqualEqual_IgnoreCase_TextText_IsValid);
		Conv_VectorToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_VectorToText");
		Conv_VectorToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_VectorToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_VectorToText_InVec_PropertyAddress, Conv_VectorToText_FunctionAddress, "InVec");
		Conv_VectorToText_InVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_VectorToText_FunctionAddress, "InVec");
		Conv_VectorToText_InVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_VectorToText_FunctionAddress, "InVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_VectorToText_ReturnValue_PropertyAddress, Conv_VectorToText_FunctionAddress, "ReturnValue");
		Conv_VectorToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_VectorToText_FunctionAddress, "ReturnValue");
		Conv_VectorToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_VectorToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_VectorToText_IsValid = Conv_VectorToText_FunctionAddress != IntPtr.Zero && Conv_VectorToText_InVec_IsValid && Conv_VectorToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_VectorToText", Conv_VectorToText_IsValid);
		Conv_Vector2dToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_Vector2dToText");
		Conv_Vector2dToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_Vector2dToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector2dToText_InVec_PropertyAddress, Conv_Vector2dToText_FunctionAddress, "InVec");
		Conv_Vector2dToText_InVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector2dToText_FunctionAddress, "InVec");
		Conv_Vector2dToText_InVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector2dToText_FunctionAddress, "InVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector2dToText_ReturnValue_PropertyAddress, Conv_Vector2dToText_FunctionAddress, "ReturnValue");
		Conv_Vector2dToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector2dToText_FunctionAddress, "ReturnValue");
		Conv_Vector2dToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector2dToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_Vector2dToText_IsValid = Conv_Vector2dToText_FunctionAddress != IntPtr.Zero && Conv_Vector2dToText_InVec_IsValid && Conv_Vector2dToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_Vector2dToText", Conv_Vector2dToText_IsValid);
		Conv_TransformToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_TransformToText");
		Conv_TransformToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_TransformToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_TransformToText_InTrans_PropertyAddress, Conv_TransformToText_FunctionAddress, "InTrans");
		Conv_TransformToText_InTrans_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TransformToText_FunctionAddress, "InTrans");
		Conv_TransformToText_InTrans_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TransformToText_FunctionAddress, "InTrans", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_TransformToText_ReturnValue_PropertyAddress, Conv_TransformToText_FunctionAddress, "ReturnValue");
		Conv_TransformToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TransformToText_FunctionAddress, "ReturnValue");
		Conv_TransformToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TransformToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_TransformToText_IsValid = Conv_TransformToText_FunctionAddress != IntPtr.Zero && Conv_TransformToText_InTrans_IsValid && Conv_TransformToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_TransformToText", Conv_TransformToText_IsValid);
		Conv_TextToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_TextToString");
		Conv_TextToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_TextToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_TextToString_InText_PropertyAddress, Conv_TextToString_FunctionAddress, "InText");
		Conv_TextToString_InText_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TextToString_FunctionAddress, "InText");
		Conv_TextToString_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TextToString_FunctionAddress, "InText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_TextToString_ReturnValue_PropertyAddress, Conv_TextToString_FunctionAddress, "ReturnValue");
		Conv_TextToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TextToString_FunctionAddress, "ReturnValue");
		Conv_TextToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TextToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_TextToString_IsValid = Conv_TextToString_FunctionAddress != IntPtr.Zero && Conv_TextToString_InText_IsValid && Conv_TextToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_TextToString", Conv_TextToString_IsValid);
		Conv_StringToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToText");
		Conv_StringToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToText_InString_PropertyAddress, Conv_StringToText_FunctionAddress, "InString");
		Conv_StringToText_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToText_FunctionAddress, "InString");
		Conv_StringToText_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToText_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToText_ReturnValue_PropertyAddress, Conv_StringToText_FunctionAddress, "ReturnValue");
		Conv_StringToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToText_FunctionAddress, "ReturnValue");
		Conv_StringToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_StringToText_IsValid = Conv_StringToText_FunctionAddress != IntPtr.Zero && Conv_StringToText_InString_IsValid && Conv_StringToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_StringToText", Conv_StringToText_IsValid);
		Conv_RotatorToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_RotatorToText");
		Conv_RotatorToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_RotatorToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_RotatorToText_InRot_PropertyAddress, Conv_RotatorToText_FunctionAddress, "InRot");
		Conv_RotatorToText_InRot_Offset = NativeReflectionCached.GetPropertyOffset(Conv_RotatorToText_FunctionAddress, "InRot");
		Conv_RotatorToText_InRot_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_RotatorToText_FunctionAddress, "InRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_RotatorToText_ReturnValue_PropertyAddress, Conv_RotatorToText_FunctionAddress, "ReturnValue");
		Conv_RotatorToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_RotatorToText_FunctionAddress, "ReturnValue");
		Conv_RotatorToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_RotatorToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_RotatorToText_IsValid = Conv_RotatorToText_FunctionAddress != IntPtr.Zero && Conv_RotatorToText_InRot_IsValid && Conv_RotatorToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_RotatorToText", Conv_RotatorToText_IsValid);
		Conv_ObjectToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ObjectToText");
		Conv_ObjectToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ObjectToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ObjectToText_InObj_PropertyAddress, Conv_ObjectToText_FunctionAddress, "InObj");
		Conv_ObjectToText_InObj_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ObjectToText_FunctionAddress, "InObj");
		Conv_ObjectToText_InObj_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ObjectToText_FunctionAddress, "InObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ObjectToText_ReturnValue_PropertyAddress, Conv_ObjectToText_FunctionAddress, "ReturnValue");
		Conv_ObjectToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ObjectToText_FunctionAddress, "ReturnValue");
		Conv_ObjectToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ObjectToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_ObjectToText_IsValid = Conv_ObjectToText_FunctionAddress != IntPtr.Zero && Conv_ObjectToText_InObj_IsValid && Conv_ObjectToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_ObjectToText", Conv_ObjectToText_IsValid);
		Conv_NameToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_NameToText");
		Conv_NameToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_NameToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_NameToText_InName_PropertyAddress, Conv_NameToText_FunctionAddress, "InName");
		Conv_NameToText_InName_Offset = NativeReflectionCached.GetPropertyOffset(Conv_NameToText_FunctionAddress, "InName");
		Conv_NameToText_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_NameToText_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_NameToText_ReturnValue_PropertyAddress, Conv_NameToText_FunctionAddress, "ReturnValue");
		Conv_NameToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_NameToText_FunctionAddress, "ReturnValue");
		Conv_NameToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_NameToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_NameToText_IsValid = Conv_NameToText_FunctionAddress != IntPtr.Zero && Conv_NameToText_InName_IsValid && Conv_NameToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_NameToText", Conv_NameToText_IsValid);
		Conv_IntToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_IntToText");
		Conv_IntToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_IntToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_Value_PropertyAddress, Conv_IntToText_FunctionAddress, "Value");
		Conv_IntToText_Value_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "Value");
		Conv_IntToText_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_bAlwaysSign_PropertyAddress, Conv_IntToText_FunctionAddress, "bAlwaysSign");
		Conv_IntToText_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "bAlwaysSign");
		Conv_IntToText_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_bUseGrouping_PropertyAddress, Conv_IntToText_FunctionAddress, "bUseGrouping");
		Conv_IntToText_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "bUseGrouping");
		Conv_IntToText_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_MinimumIntegralDigits_PropertyAddress, Conv_IntToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_IntToText_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_IntToText_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_MaximumIntegralDigits_PropertyAddress, Conv_IntToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_IntToText_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_IntToText_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToText_ReturnValue_PropertyAddress, Conv_IntToText_FunctionAddress, "ReturnValue");
		Conv_IntToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToText_FunctionAddress, "ReturnValue");
		Conv_IntToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_IntToText_IsValid = Conv_IntToText_FunctionAddress != IntPtr.Zero && Conv_IntToText_Value_IsValid && Conv_IntToText_bAlwaysSign_IsValid && Conv_IntToText_bUseGrouping_IsValid && Conv_IntToText_MinimumIntegralDigits_IsValid && Conv_IntToText_MaximumIntegralDigits_IsValid && Conv_IntToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_IntToText", Conv_IntToText_IsValid);
		Conv_Int64ToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_Int64ToText");
		Conv_Int64ToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_Int64ToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_Value_PropertyAddress, Conv_Int64ToText_FunctionAddress, "Value");
		Conv_Int64ToText_Value_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "Value");
		Conv_Int64ToText_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "Value", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_bAlwaysSign_PropertyAddress, Conv_Int64ToText_FunctionAddress, "bAlwaysSign");
		Conv_Int64ToText_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "bAlwaysSign");
		Conv_Int64ToText_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_bUseGrouping_PropertyAddress, Conv_Int64ToText_FunctionAddress, "bUseGrouping");
		Conv_Int64ToText_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "bUseGrouping");
		Conv_Int64ToText_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_MinimumIntegralDigits_PropertyAddress, Conv_Int64ToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_Int64ToText_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_Int64ToText_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_MaximumIntegralDigits_PropertyAddress, Conv_Int64ToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_Int64ToText_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_Int64ToText_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToText_ReturnValue_PropertyAddress, Conv_Int64ToText_FunctionAddress, "ReturnValue");
		Conv_Int64ToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToText_FunctionAddress, "ReturnValue");
		Conv_Int64ToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_Int64ToText_IsValid = Conv_Int64ToText_FunctionAddress != IntPtr.Zero && Conv_Int64ToText_Value_IsValid && Conv_Int64ToText_bAlwaysSign_IsValid && Conv_Int64ToText_bUseGrouping_IsValid && Conv_Int64ToText_MinimumIntegralDigits_IsValid && Conv_Int64ToText_MaximumIntegralDigits_IsValid && Conv_Int64ToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_Int64ToText", Conv_Int64ToText_IsValid);
		Conv_FloatToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FloatToText");
		Conv_FloatToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FloatToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_Value_PropertyAddress, Conv_FloatToText_FunctionAddress, "Value");
		Conv_FloatToText_Value_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "Value");
		Conv_FloatToText_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_RoundingMode_PropertyAddress, Conv_FloatToText_FunctionAddress, "RoundingMode");
		Conv_FloatToText_RoundingMode_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "RoundingMode");
		Conv_FloatToText_RoundingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "RoundingMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_bAlwaysSign_PropertyAddress, Conv_FloatToText_FunctionAddress, "bAlwaysSign");
		Conv_FloatToText_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "bAlwaysSign");
		Conv_FloatToText_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_bUseGrouping_PropertyAddress, Conv_FloatToText_FunctionAddress, "bUseGrouping");
		Conv_FloatToText_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "bUseGrouping");
		Conv_FloatToText_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_MinimumIntegralDigits_PropertyAddress, Conv_FloatToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_FloatToText_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_FloatToText_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_MaximumIntegralDigits_PropertyAddress, Conv_FloatToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_FloatToText_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_FloatToText_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_MinimumFractionalDigits_PropertyAddress, Conv_FloatToText_FunctionAddress, "MinimumFractionalDigits");
		Conv_FloatToText_MinimumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "MinimumFractionalDigits");
		Conv_FloatToText_MinimumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "MinimumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_MaximumFractionalDigits_PropertyAddress, Conv_FloatToText_FunctionAddress, "MaximumFractionalDigits");
		Conv_FloatToText_MaximumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "MaximumFractionalDigits");
		Conv_FloatToText_MaximumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "MaximumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FloatToText_ReturnValue_PropertyAddress, Conv_FloatToText_FunctionAddress, "ReturnValue");
		Conv_FloatToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FloatToText_FunctionAddress, "ReturnValue");
		Conv_FloatToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FloatToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FloatToText_IsValid = Conv_FloatToText_FunctionAddress != IntPtr.Zero && Conv_FloatToText_Value_IsValid && Conv_FloatToText_RoundingMode_IsValid && Conv_FloatToText_bAlwaysSign_IsValid && Conv_FloatToText_bUseGrouping_IsValid && Conv_FloatToText_MinimumIntegralDigits_IsValid && Conv_FloatToText_MaximumIntegralDigits_IsValid && Conv_FloatToText_MinimumFractionalDigits_IsValid && Conv_FloatToText_MaximumFractionalDigits_IsValid && Conv_FloatToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_FloatToText", Conv_FloatToText_IsValid);
		Conv_DoubleToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_DoubleToText");
		Conv_DoubleToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_DoubleToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_InDouble_PropertyAddress, Conv_DoubleToText_FunctionAddress, "InDouble");
		Conv_DoubleToText_InDouble_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "InDouble");
		Conv_DoubleToText_InDouble_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "InDouble", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_RoundingMode_PropertyAddress, Conv_DoubleToText_FunctionAddress, "RoundingMode");
		Conv_DoubleToText_RoundingMode_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "RoundingMode");
		Conv_DoubleToText_RoundingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "RoundingMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_bAlwaysSign_PropertyAddress, Conv_DoubleToText_FunctionAddress, "bAlwaysSign");
		Conv_DoubleToText_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "bAlwaysSign");
		Conv_DoubleToText_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_bUseGrouping_PropertyAddress, Conv_DoubleToText_FunctionAddress, "bUseGrouping");
		Conv_DoubleToText_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "bUseGrouping");
		Conv_DoubleToText_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_MinimumIntegralDigits_PropertyAddress, Conv_DoubleToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_DoubleToText_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "MinimumIntegralDigits");
		Conv_DoubleToText_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_MaximumIntegralDigits_PropertyAddress, Conv_DoubleToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_DoubleToText_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "MaximumIntegralDigits");
		Conv_DoubleToText_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_MinimumFractionalDigits_PropertyAddress, Conv_DoubleToText_FunctionAddress, "MinimumFractionalDigits");
		Conv_DoubleToText_MinimumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "MinimumFractionalDigits");
		Conv_DoubleToText_MinimumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "MinimumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_MaximumFractionalDigits_PropertyAddress, Conv_DoubleToText_FunctionAddress, "MaximumFractionalDigits");
		Conv_DoubleToText_MaximumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "MaximumFractionalDigits");
		Conv_DoubleToText_MaximumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "MaximumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToText_ReturnValue_PropertyAddress, Conv_DoubleToText_FunctionAddress, "ReturnValue");
		Conv_DoubleToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToText_FunctionAddress, "ReturnValue");
		Conv_DoubleToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_DoubleToText_IsValid = Conv_DoubleToText_FunctionAddress != IntPtr.Zero && Conv_DoubleToText_InDouble_IsValid && Conv_DoubleToText_RoundingMode_IsValid && Conv_DoubleToText_bAlwaysSign_IsValid && Conv_DoubleToText_bUseGrouping_IsValid && Conv_DoubleToText_MinimumIntegralDigits_IsValid && Conv_DoubleToText_MaximumIntegralDigits_IsValid && Conv_DoubleToText_MinimumFractionalDigits_IsValid && Conv_DoubleToText_MaximumFractionalDigits_IsValid && Conv_DoubleToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_DoubleToText", Conv_DoubleToText_IsValid);
		Conv_ColorToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ColorToText");
		Conv_ColorToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ColorToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ColorToText_InColor_PropertyAddress, Conv_ColorToText_FunctionAddress, "InColor");
		Conv_ColorToText_InColor_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ColorToText_FunctionAddress, "InColor");
		Conv_ColorToText_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ColorToText_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ColorToText_ReturnValue_PropertyAddress, Conv_ColorToText_FunctionAddress, "ReturnValue");
		Conv_ColorToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ColorToText_FunctionAddress, "ReturnValue");
		Conv_ColorToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ColorToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_ColorToText_IsValid = Conv_ColorToText_FunctionAddress != IntPtr.Zero && Conv_ColorToText_InColor_IsValid && Conv_ColorToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_ColorToText", Conv_ColorToText_IsValid);
		Conv_ByteToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ByteToText");
		Conv_ByteToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ByteToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ByteToText_Value_PropertyAddress, Conv_ByteToText_FunctionAddress, "Value");
		Conv_ByteToText_Value_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ByteToText_FunctionAddress, "Value");
		Conv_ByteToText_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ByteToText_FunctionAddress, "Value", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ByteToText_ReturnValue_PropertyAddress, Conv_ByteToText_FunctionAddress, "ReturnValue");
		Conv_ByteToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ByteToText_FunctionAddress, "ReturnValue");
		Conv_ByteToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ByteToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_ByteToText_IsValid = Conv_ByteToText_FunctionAddress != IntPtr.Zero && Conv_ByteToText_Value_IsValid && Conv_ByteToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_ByteToText", Conv_ByteToText_IsValid);
		Conv_BoolToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_BoolToText");
		Conv_BoolToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_BoolToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_BoolToText_InBool_PropertyAddress, Conv_BoolToText_FunctionAddress, "InBool");
		Conv_BoolToText_InBool_Offset = NativeReflectionCached.GetPropertyOffset(Conv_BoolToText_FunctionAddress, "InBool");
		Conv_BoolToText_InBool_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_BoolToText_FunctionAddress, "InBool", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_BoolToText_ReturnValue_PropertyAddress, Conv_BoolToText_FunctionAddress, "ReturnValue");
		Conv_BoolToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_BoolToText_FunctionAddress, "ReturnValue");
		Conv_BoolToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_BoolToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_BoolToText_IsValid = Conv_BoolToText_FunctionAddress != IntPtr.Zero && Conv_BoolToText_InBool_IsValid && Conv_BoolToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:Conv_BoolToText", Conv_BoolToText_IsValid);
		AsTimeZoneTime_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsTimeZoneTime_DateTime");
		AsTimeZoneTime_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsTimeZoneTime_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneTime_DateTime_InDateTime_PropertyAddress, AsTimeZoneTime_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneTime_DateTime_InDateTime_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneTime_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneTime_DateTime_InDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneTime_DateTime_FunctionAddress, "InDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneTime_DateTime_InTimeZone_PropertyAddress, AsTimeZoneTime_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneTime_DateTime_InTimeZone_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneTime_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneTime_DateTime_InTimeZone_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneTime_DateTime_FunctionAddress, "InTimeZone", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneTime_DateTime_ReturnValue_PropertyAddress, AsTimeZoneTime_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneTime_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneTime_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneTime_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneTime_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsTimeZoneTime_DateTime_IsValid = AsTimeZoneTime_DateTime_FunctionAddress != IntPtr.Zero && AsTimeZoneTime_DateTime_InDateTime_IsValid && AsTimeZoneTime_DateTime_InTimeZone_IsValid && AsTimeZoneTime_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsTimeZoneTime_DateTime", AsTimeZoneTime_DateTime_IsValid);
		AsTimeZoneDateTime_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsTimeZoneDateTime_DateTime");
		AsTimeZoneDateTime_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsTimeZoneDateTime_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDateTime_DateTime_InDateTime_PropertyAddress, AsTimeZoneDateTime_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneDateTime_DateTime_InDateTime_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDateTime_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneDateTime_DateTime_InDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDateTime_DateTime_FunctionAddress, "InDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDateTime_DateTime_InTimeZone_PropertyAddress, AsTimeZoneDateTime_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneDateTime_DateTime_InTimeZone_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDateTime_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneDateTime_DateTime_InTimeZone_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDateTime_DateTime_FunctionAddress, "InTimeZone", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDateTime_DateTime_ReturnValue_PropertyAddress, AsTimeZoneDateTime_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneDateTime_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDateTime_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneDateTime_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDateTime_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsTimeZoneDateTime_DateTime_IsValid = AsTimeZoneDateTime_DateTime_FunctionAddress != IntPtr.Zero && AsTimeZoneDateTime_DateTime_InDateTime_IsValid && AsTimeZoneDateTime_DateTime_InTimeZone_IsValid && AsTimeZoneDateTime_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsTimeZoneDateTime_DateTime", AsTimeZoneDateTime_DateTime_IsValid);
		AsTimeZoneDate_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsTimeZoneDate_DateTime");
		AsTimeZoneDate_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsTimeZoneDate_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDate_DateTime_InDateTime_PropertyAddress, AsTimeZoneDate_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneDate_DateTime_InDateTime_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDate_DateTime_FunctionAddress, "InDateTime");
		AsTimeZoneDate_DateTime_InDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDate_DateTime_FunctionAddress, "InDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDate_DateTime_InTimeZone_PropertyAddress, AsTimeZoneDate_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneDate_DateTime_InTimeZone_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDate_DateTime_FunctionAddress, "InTimeZone");
		AsTimeZoneDate_DateTime_InTimeZone_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDate_DateTime_FunctionAddress, "InTimeZone", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimeZoneDate_DateTime_ReturnValue_PropertyAddress, AsTimeZoneDate_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneDate_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsTimeZoneDate_DateTime_FunctionAddress, "ReturnValue");
		AsTimeZoneDate_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimeZoneDate_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsTimeZoneDate_DateTime_IsValid = AsTimeZoneDate_DateTime_FunctionAddress != IntPtr.Zero && AsTimeZoneDate_DateTime_InDateTime_IsValid && AsTimeZoneDate_DateTime_InTimeZone_IsValid && AsTimeZoneDate_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsTimeZoneDate_DateTime", AsTimeZoneDate_DateTime_IsValid);
		AsTimespan_Timespan_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsTimespan_Timespan");
		AsTimespan_Timespan_ParamsSize = NativeReflection.GetFunctionParamsSize(AsTimespan_Timespan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsTimespan_Timespan_InTimespan_PropertyAddress, AsTimespan_Timespan_FunctionAddress, "InTimespan");
		AsTimespan_Timespan_InTimespan_Offset = NativeReflectionCached.GetPropertyOffset(AsTimespan_Timespan_FunctionAddress, "InTimespan");
		AsTimespan_Timespan_InTimespan_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimespan_Timespan_FunctionAddress, "InTimespan", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTimespan_Timespan_ReturnValue_PropertyAddress, AsTimespan_Timespan_FunctionAddress, "ReturnValue");
		AsTimespan_Timespan_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsTimespan_Timespan_FunctionAddress, "ReturnValue");
		AsTimespan_Timespan_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTimespan_Timespan_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsTimespan_Timespan_IsValid = AsTimespan_Timespan_FunctionAddress != IntPtr.Zero && AsTimespan_Timespan_InTimespan_IsValid && AsTimespan_Timespan_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsTimespan_Timespan", AsTimespan_Timespan_IsValid);
		AsTime_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsTime_DateTime");
		AsTime_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsTime_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsTime_DateTime_In_PropertyAddress, AsTime_DateTime_FunctionAddress, "In");
		AsTime_DateTime_In_Offset = NativeReflectionCached.GetPropertyOffset(AsTime_DateTime_FunctionAddress, "In");
		AsTime_DateTime_In_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTime_DateTime_FunctionAddress, "In", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsTime_DateTime_ReturnValue_PropertyAddress, AsTime_DateTime_FunctionAddress, "ReturnValue");
		AsTime_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsTime_DateTime_FunctionAddress, "ReturnValue");
		AsTime_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsTime_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsTime_DateTime_IsValid = AsTime_DateTime_FunctionAddress != IntPtr.Zero && AsTime_DateTime_In_IsValid && AsTime_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsTime_DateTime", AsTime_DateTime_IsValid);
		AsPercent_Float_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsPercent_Float");
		AsPercent_Float_ParamsSize = NativeReflection.GetFunctionParamsSize(AsPercent_Float_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_Value_PropertyAddress, AsPercent_Float_FunctionAddress, "Value");
		AsPercent_Float_Value_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "Value");
		AsPercent_Float_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_RoundingMode_PropertyAddress, AsPercent_Float_FunctionAddress, "RoundingMode");
		AsPercent_Float_RoundingMode_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "RoundingMode");
		AsPercent_Float_RoundingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "RoundingMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_bAlwaysSign_PropertyAddress, AsPercent_Float_FunctionAddress, "bAlwaysSign");
		AsPercent_Float_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "bAlwaysSign");
		AsPercent_Float_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_bUseGrouping_PropertyAddress, AsPercent_Float_FunctionAddress, "bUseGrouping");
		AsPercent_Float_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "bUseGrouping");
		AsPercent_Float_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_MinimumIntegralDigits_PropertyAddress, AsPercent_Float_FunctionAddress, "MinimumIntegralDigits");
		AsPercent_Float_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "MinimumIntegralDigits");
		AsPercent_Float_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_MaximumIntegralDigits_PropertyAddress, AsPercent_Float_FunctionAddress, "MaximumIntegralDigits");
		AsPercent_Float_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "MaximumIntegralDigits");
		AsPercent_Float_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_MinimumFractionalDigits_PropertyAddress, AsPercent_Float_FunctionAddress, "MinimumFractionalDigits");
		AsPercent_Float_MinimumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "MinimumFractionalDigits");
		AsPercent_Float_MinimumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "MinimumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_MaximumFractionalDigits_PropertyAddress, AsPercent_Float_FunctionAddress, "MaximumFractionalDigits");
		AsPercent_Float_MaximumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "MaximumFractionalDigits");
		AsPercent_Float_MaximumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "MaximumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsPercent_Float_ReturnValue_PropertyAddress, AsPercent_Float_FunctionAddress, "ReturnValue");
		AsPercent_Float_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsPercent_Float_FunctionAddress, "ReturnValue");
		AsPercent_Float_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsPercent_Float_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsPercent_Float_IsValid = AsPercent_Float_FunctionAddress != IntPtr.Zero && AsPercent_Float_Value_IsValid && AsPercent_Float_RoundingMode_IsValid && AsPercent_Float_bAlwaysSign_IsValid && AsPercent_Float_bUseGrouping_IsValid && AsPercent_Float_MinimumIntegralDigits_IsValid && AsPercent_Float_MaximumIntegralDigits_IsValid && AsPercent_Float_MinimumFractionalDigits_IsValid && AsPercent_Float_MaximumFractionalDigits_IsValid && AsPercent_Float_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsPercent_Float", AsPercent_Float_IsValid);
		AsDateTime_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsDateTime_DateTime");
		AsDateTime_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsDateTime_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsDateTime_DateTime_In_PropertyAddress, AsDateTime_DateTime_FunctionAddress, "In");
		AsDateTime_DateTime_In_Offset = NativeReflectionCached.GetPropertyOffset(AsDateTime_DateTime_FunctionAddress, "In");
		AsDateTime_DateTime_In_IsValid = NativeReflectionCached.ValidatePropertyClass(AsDateTime_DateTime_FunctionAddress, "In", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsDateTime_DateTime_ReturnValue_PropertyAddress, AsDateTime_DateTime_FunctionAddress, "ReturnValue");
		AsDateTime_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsDateTime_DateTime_FunctionAddress, "ReturnValue");
		AsDateTime_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsDateTime_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsDateTime_DateTime_IsValid = AsDateTime_DateTime_FunctionAddress != IntPtr.Zero && AsDateTime_DateTime_In_IsValid && AsDateTime_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsDateTime_DateTime", AsDateTime_DateTime_IsValid);
		AsDate_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsDate_DateTime");
		AsDate_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AsDate_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsDate_DateTime_InDateTime_PropertyAddress, AsDate_DateTime_FunctionAddress, "InDateTime");
		AsDate_DateTime_InDateTime_Offset = NativeReflectionCached.GetPropertyOffset(AsDate_DateTime_FunctionAddress, "InDateTime");
		AsDate_DateTime_InDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AsDate_DateTime_FunctionAddress, "InDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AsDate_DateTime_ReturnValue_PropertyAddress, AsDate_DateTime_FunctionAddress, "ReturnValue");
		AsDate_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsDate_DateTime_FunctionAddress, "ReturnValue");
		AsDate_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsDate_DateTime_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsDate_DateTime_IsValid = AsDate_DateTime_FunctionAddress != IntPtr.Zero && AsDate_DateTime_InDateTime_IsValid && AsDate_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsDate_DateTime", AsDate_DateTime_IsValid);
		AsCurrencyBase_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsCurrencyBase");
		AsCurrencyBase_ParamsSize = NativeReflection.GetFunctionParamsSize(AsCurrencyBase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsCurrencyBase_BaseValue_PropertyAddress, AsCurrencyBase_FunctionAddress, "BaseValue");
		AsCurrencyBase_BaseValue_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrencyBase_FunctionAddress, "BaseValue");
		AsCurrencyBase_BaseValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrencyBase_FunctionAddress, "BaseValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrencyBase_CurrencyCode_PropertyAddress, AsCurrencyBase_FunctionAddress, "CurrencyCode");
		AsCurrencyBase_CurrencyCode_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrencyBase_FunctionAddress, "CurrencyCode");
		AsCurrencyBase_CurrencyCode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrencyBase_FunctionAddress, "CurrencyCode", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrencyBase_ReturnValue_PropertyAddress, AsCurrencyBase_FunctionAddress, "ReturnValue");
		AsCurrencyBase_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrencyBase_FunctionAddress, "ReturnValue");
		AsCurrencyBase_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrencyBase_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsCurrencyBase_IsValid = AsCurrencyBase_FunctionAddress != IntPtr.Zero && AsCurrencyBase_BaseValue_IsValid && AsCurrencyBase_CurrencyCode_IsValid && AsCurrencyBase_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsCurrencyBase", AsCurrencyBase_IsValid);
		AsCurrency_Integer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsCurrency_Integer");
		AsCurrency_Integer_ParamsSize = NativeReflection.GetFunctionParamsSize(AsCurrency_Integer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_Value_PropertyAddress, AsCurrency_Integer_FunctionAddress, "Value");
		AsCurrency_Integer_Value_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "Value");
		AsCurrency_Integer_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_RoundingMode_PropertyAddress, AsCurrency_Integer_FunctionAddress, "RoundingMode");
		AsCurrency_Integer_RoundingMode_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "RoundingMode");
		AsCurrency_Integer_RoundingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "RoundingMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_bAlwaysSign_PropertyAddress, AsCurrency_Integer_FunctionAddress, "bAlwaysSign");
		AsCurrency_Integer_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "bAlwaysSign");
		AsCurrency_Integer_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_bUseGrouping_PropertyAddress, AsCurrency_Integer_FunctionAddress, "bUseGrouping");
		AsCurrency_Integer_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "bUseGrouping");
		AsCurrency_Integer_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_MinimumIntegralDigits_PropertyAddress, AsCurrency_Integer_FunctionAddress, "MinimumIntegralDigits");
		AsCurrency_Integer_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "MinimumIntegralDigits");
		AsCurrency_Integer_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_MaximumIntegralDigits_PropertyAddress, AsCurrency_Integer_FunctionAddress, "MaximumIntegralDigits");
		AsCurrency_Integer_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "MaximumIntegralDigits");
		AsCurrency_Integer_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_MinimumFractionalDigits_PropertyAddress, AsCurrency_Integer_FunctionAddress, "MinimumFractionalDigits");
		AsCurrency_Integer_MinimumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "MinimumFractionalDigits");
		AsCurrency_Integer_MinimumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "MinimumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_MaximumFractionalDigits_PropertyAddress, AsCurrency_Integer_FunctionAddress, "MaximumFractionalDigits");
		AsCurrency_Integer_MaximumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "MaximumFractionalDigits");
		AsCurrency_Integer_MaximumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "MaximumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_CurrencyCode_PropertyAddress, AsCurrency_Integer_FunctionAddress, "CurrencyCode");
		AsCurrency_Integer_CurrencyCode_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "CurrencyCode");
		AsCurrency_Integer_CurrencyCode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "CurrencyCode", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Integer_ReturnValue_PropertyAddress, AsCurrency_Integer_FunctionAddress, "ReturnValue");
		AsCurrency_Integer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Integer_FunctionAddress, "ReturnValue");
		AsCurrency_Integer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Integer_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsCurrency_Integer_IsValid = AsCurrency_Integer_FunctionAddress != IntPtr.Zero && AsCurrency_Integer_Value_IsValid && AsCurrency_Integer_RoundingMode_IsValid && AsCurrency_Integer_bAlwaysSign_IsValid && AsCurrency_Integer_bUseGrouping_IsValid && AsCurrency_Integer_MinimumIntegralDigits_IsValid && AsCurrency_Integer_MaximumIntegralDigits_IsValid && AsCurrency_Integer_MinimumFractionalDigits_IsValid && AsCurrency_Integer_MaximumFractionalDigits_IsValid && AsCurrency_Integer_CurrencyCode_IsValid && AsCurrency_Integer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsCurrency_Integer", AsCurrency_Integer_IsValid);
		AsCurrency_Float_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsCurrency_Float");
		AsCurrency_Float_ParamsSize = NativeReflection.GetFunctionParamsSize(AsCurrency_Float_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_Value_PropertyAddress, AsCurrency_Float_FunctionAddress, "Value");
		AsCurrency_Float_Value_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "Value");
		AsCurrency_Float_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_RoundingMode_PropertyAddress, AsCurrency_Float_FunctionAddress, "RoundingMode");
		AsCurrency_Float_RoundingMode_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "RoundingMode");
		AsCurrency_Float_RoundingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "RoundingMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_bAlwaysSign_PropertyAddress, AsCurrency_Float_FunctionAddress, "bAlwaysSign");
		AsCurrency_Float_bAlwaysSign_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "bAlwaysSign");
		AsCurrency_Float_bAlwaysSign_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "bAlwaysSign", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_bUseGrouping_PropertyAddress, AsCurrency_Float_FunctionAddress, "bUseGrouping");
		AsCurrency_Float_bUseGrouping_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "bUseGrouping");
		AsCurrency_Float_bUseGrouping_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "bUseGrouping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_MinimumIntegralDigits_PropertyAddress, AsCurrency_Float_FunctionAddress, "MinimumIntegralDigits");
		AsCurrency_Float_MinimumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "MinimumIntegralDigits");
		AsCurrency_Float_MinimumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "MinimumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_MaximumIntegralDigits_PropertyAddress, AsCurrency_Float_FunctionAddress, "MaximumIntegralDigits");
		AsCurrency_Float_MaximumIntegralDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "MaximumIntegralDigits");
		AsCurrency_Float_MaximumIntegralDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "MaximumIntegralDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_MinimumFractionalDigits_PropertyAddress, AsCurrency_Float_FunctionAddress, "MinimumFractionalDigits");
		AsCurrency_Float_MinimumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "MinimumFractionalDigits");
		AsCurrency_Float_MinimumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "MinimumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_MaximumFractionalDigits_PropertyAddress, AsCurrency_Float_FunctionAddress, "MaximumFractionalDigits");
		AsCurrency_Float_MaximumFractionalDigits_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "MaximumFractionalDigits");
		AsCurrency_Float_MaximumFractionalDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "MaximumFractionalDigits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_CurrencyCode_PropertyAddress, AsCurrency_Float_FunctionAddress, "CurrencyCode");
		AsCurrency_Float_CurrencyCode_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "CurrencyCode");
		AsCurrency_Float_CurrencyCode_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "CurrencyCode", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsCurrency_Float_ReturnValue_PropertyAddress, AsCurrency_Float_FunctionAddress, "ReturnValue");
		AsCurrency_Float_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsCurrency_Float_FunctionAddress, "ReturnValue");
		AsCurrency_Float_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsCurrency_Float_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		AsCurrency_Float_IsValid = AsCurrency_Float_FunctionAddress != IntPtr.Zero && AsCurrency_Float_Value_IsValid && AsCurrency_Float_RoundingMode_IsValid && AsCurrency_Float_bAlwaysSign_IsValid && AsCurrency_Float_bUseGrouping_IsValid && AsCurrency_Float_MinimumIntegralDigits_IsValid && AsCurrency_Float_MaximumIntegralDigits_IsValid && AsCurrency_Float_MinimumFractionalDigits_IsValid && AsCurrency_Float_MaximumFractionalDigits_IsValid && AsCurrency_Float_CurrencyCode_IsValid && AsCurrency_Float_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetTextLibrary:AsCurrency_Float", AsCurrency_Float_IsValid);
	}
}
