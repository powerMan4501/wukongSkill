using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetStringLibrary", "Engine", UnrealModuleType.Engine)]
public class UStringLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TrimTrailing_IsValid;

	private static IntPtr TrimTrailing_FunctionAddress;

	private static int TrimTrailing_ParamsSize;

	private static bool TrimTrailing_SourceString_IsValid;

	private static FFieldAddress TrimTrailing_SourceString_PropertyAddress;

	private static int TrimTrailing_SourceString_Offset;

	private static bool TrimTrailing_ReturnValue_IsValid;

	private static FFieldAddress TrimTrailing_ReturnValue_PropertyAddress;

	private static int TrimTrailing_ReturnValue_Offset;

	private static bool Trim_IsValid;

	private static IntPtr Trim_FunctionAddress;

	private static int Trim_ParamsSize;

	private static bool Trim_SourceString_IsValid;

	private static FFieldAddress Trim_SourceString_PropertyAddress;

	private static int Trim_SourceString_Offset;

	private static bool Trim_ReturnValue_IsValid;

	private static FFieldAddress Trim_ReturnValue_PropertyAddress;

	private static int Trim_ReturnValue_Offset;

	private static bool ToUpper_IsValid;

	private static IntPtr ToUpper_FunctionAddress;

	private static int ToUpper_ParamsSize;

	private static bool ToUpper_SourceString_IsValid;

	private static FFieldAddress ToUpper_SourceString_PropertyAddress;

	private static int ToUpper_SourceString_Offset;

	private static bool ToUpper_ReturnValue_IsValid;

	private static FFieldAddress ToUpper_ReturnValue_PropertyAddress;

	private static int ToUpper_ReturnValue_Offset;

	private static bool ToLower_IsValid;

	private static IntPtr ToLower_FunctionAddress;

	private static int ToLower_ParamsSize;

	private static bool ToLower_SourceString_IsValid;

	private static FFieldAddress ToLower_SourceString_PropertyAddress;

	private static int ToLower_SourceString_Offset;

	private static bool ToLower_ReturnValue_IsValid;

	private static FFieldAddress ToLower_ReturnValue_PropertyAddress;

	private static int ToLower_ReturnValue_Offset;

	private static bool TimeSecondsToString_IsValid;

	private static IntPtr TimeSecondsToString_FunctionAddress;

	private static int TimeSecondsToString_ParamsSize;

	private static bool TimeSecondsToString_InSeconds_IsValid;

	private static FFieldAddress TimeSecondsToString_InSeconds_PropertyAddress;

	private static int TimeSecondsToString_InSeconds_Offset;

	private static bool TimeSecondsToString_ReturnValue_IsValid;

	private static FFieldAddress TimeSecondsToString_ReturnValue_PropertyAddress;

	private static int TimeSecondsToString_ReturnValue_Offset;

	private static bool StartsWith_IsValid;

	private static IntPtr StartsWith_FunctionAddress;

	private static int StartsWith_ParamsSize;

	private static bool StartsWith_SourceString_IsValid;

	private static FFieldAddress StartsWith_SourceString_PropertyAddress;

	private static int StartsWith_SourceString_Offset;

	private static bool StartsWith_InPrefix_IsValid;

	private static FFieldAddress StartsWith_InPrefix_PropertyAddress;

	private static int StartsWith_InPrefix_Offset;

	private static bool StartsWith_SearchCase_IsValid;

	private static FFieldAddress StartsWith_SearchCase_PropertyAddress;

	private static int StartsWith_SearchCase_Offset;

	private static bool StartsWith_ReturnValue_IsValid;

	private static FFieldAddress StartsWith_ReturnValue_PropertyAddress;

	private static int StartsWith_ReturnValue_Offset;

	private static bool Split_IsValid;

	private static IntPtr Split_FunctionAddress;

	private static int Split_ParamsSize;

	private static bool Split_SourceString_IsValid;

	private static FFieldAddress Split_SourceString_PropertyAddress;

	private static int Split_SourceString_Offset;

	private static bool Split_InStr_IsValid;

	private static FFieldAddress Split_InStr_PropertyAddress;

	private static int Split_InStr_Offset;

	private static bool Split_LeftS_IsValid;

	private static FFieldAddress Split_LeftS_PropertyAddress;

	private static int Split_LeftS_Offset;

	private static bool Split_RightS_IsValid;

	private static FFieldAddress Split_RightS_PropertyAddress;

	private static int Split_RightS_Offset;

	private static bool Split_SearchCase_IsValid;

	private static FFieldAddress Split_SearchCase_PropertyAddress;

	private static int Split_SearchCase_Offset;

	private static bool Split_SearchDir_IsValid;

	private static FFieldAddress Split_SearchDir_PropertyAddress;

	private static int Split_SearchDir_Offset;

	private static bool Split_ReturnValue_IsValid;

	private static FFieldAddress Split_ReturnValue_PropertyAddress;

	private static int Split_ReturnValue_Offset;

	private static bool RightPad_IsValid;

	private static IntPtr RightPad_FunctionAddress;

	private static int RightPad_ParamsSize;

	private static bool RightPad_SourceString_IsValid;

	private static FFieldAddress RightPad_SourceString_PropertyAddress;

	private static int RightPad_SourceString_Offset;

	private static bool RightPad_ChCount_IsValid;

	private static FFieldAddress RightPad_ChCount_PropertyAddress;

	private static int RightPad_ChCount_Offset;

	private static bool RightPad_ReturnValue_IsValid;

	private static FFieldAddress RightPad_ReturnValue_PropertyAddress;

	private static int RightPad_ReturnValue_Offset;

	private static bool RightChop_IsValid;

	private static IntPtr RightChop_FunctionAddress;

	private static int RightChop_ParamsSize;

	private static bool RightChop_SourceString_IsValid;

	private static FFieldAddress RightChop_SourceString_PropertyAddress;

	private static int RightChop_SourceString_Offset;

	private static bool RightChop_Count_IsValid;

	private static FFieldAddress RightChop_Count_PropertyAddress;

	private static int RightChop_Count_Offset;

	private static bool RightChop_ReturnValue_IsValid;

	private static FFieldAddress RightChop_ReturnValue_PropertyAddress;

	private static int RightChop_ReturnValue_Offset;

	private static bool Right_IsValid;

	private static IntPtr Right_FunctionAddress;

	private static int Right_ParamsSize;

	private static bool Right_SourceString_IsValid;

	private static FFieldAddress Right_SourceString_PropertyAddress;

	private static int Right_SourceString_Offset;

	private static bool Right_Count_IsValid;

	private static FFieldAddress Right_Count_PropertyAddress;

	private static int Right_Count_Offset;

	private static bool Right_ReturnValue_IsValid;

	private static FFieldAddress Right_ReturnValue_PropertyAddress;

	private static int Right_ReturnValue_Offset;

	private static bool Reverse_IsValid;

	private static IntPtr Reverse_FunctionAddress;

	private static int Reverse_ParamsSize;

	private static bool Reverse_SourceString_IsValid;

	private static FFieldAddress Reverse_SourceString_PropertyAddress;

	private static int Reverse_SourceString_Offset;

	private static bool Reverse_ReturnValue_IsValid;

	private static FFieldAddress Reverse_ReturnValue_PropertyAddress;

	private static int Reverse_ReturnValue_Offset;

	private static bool ReplaceInline_IsValid;

	private static IntPtr ReplaceInline_FunctionAddress;

	private static int ReplaceInline_ParamsSize;

	private static bool ReplaceInline_SourceString_IsValid;

	private static FFieldAddress ReplaceInline_SourceString_PropertyAddress;

	private static int ReplaceInline_SourceString_Offset;

	private static bool ReplaceInline_SearchText_IsValid;

	private static FFieldAddress ReplaceInline_SearchText_PropertyAddress;

	private static int ReplaceInline_SearchText_Offset;

	private static bool ReplaceInline_ReplacementText_IsValid;

	private static FFieldAddress ReplaceInline_ReplacementText_PropertyAddress;

	private static int ReplaceInline_ReplacementText_Offset;

	private static bool ReplaceInline_SearchCase_IsValid;

	private static FFieldAddress ReplaceInline_SearchCase_PropertyAddress;

	private static int ReplaceInline_SearchCase_Offset;

	private static bool ReplaceInline_ReturnValue_IsValid;

	private static FFieldAddress ReplaceInline_ReturnValue_PropertyAddress;

	private static int ReplaceInline_ReturnValue_Offset;

	private static bool Replace_IsValid;

	private static IntPtr Replace_FunctionAddress;

	private static int Replace_ParamsSize;

	private static bool Replace_SourceString_IsValid;

	private static FFieldAddress Replace_SourceString_PropertyAddress;

	private static int Replace_SourceString_Offset;

	private static bool Replace_From_IsValid;

	private static FFieldAddress Replace_From_PropertyAddress;

	private static int Replace_From_Offset;

	private static bool Replace_To_IsValid;

	private static FFieldAddress Replace_To_PropertyAddress;

	private static int Replace_To_Offset;

	private static bool Replace_SearchCase_IsValid;

	private static FFieldAddress Replace_SearchCase_PropertyAddress;

	private static int Replace_SearchCase_Offset;

	private static bool Replace_ReturnValue_IsValid;

	private static FFieldAddress Replace_ReturnValue_PropertyAddress;

	private static int Replace_ReturnValue_Offset;

	private static bool ParseIntoArray_IsValid;

	private static IntPtr ParseIntoArray_FunctionAddress;

	private static int ParseIntoArray_ParamsSize;

	private static bool ParseIntoArray_SourceString_IsValid;

	private static FFieldAddress ParseIntoArray_SourceString_PropertyAddress;

	private static int ParseIntoArray_SourceString_Offset;

	private static bool ParseIntoArray_Delimiter_IsValid;

	private static FFieldAddress ParseIntoArray_Delimiter_PropertyAddress;

	private static int ParseIntoArray_Delimiter_Offset;

	private static bool ParseIntoArray_CullEmptyStrings_IsValid;

	private static FFieldAddress ParseIntoArray_CullEmptyStrings_PropertyAddress;

	private static int ParseIntoArray_CullEmptyStrings_Offset;

	private static bool ParseIntoArray_ReturnValue_IsValid;

	private static FFieldAddress ParseIntoArray_ReturnValue_PropertyAddress;

	private static int ParseIntoArray_ReturnValue_Offset;

	private static bool NotEqual_StrStr_IsValid;

	private static IntPtr NotEqual_StrStr_FunctionAddress;

	private static int NotEqual_StrStr_ParamsSize;

	private static bool NotEqual_StrStr_A_IsValid;

	private static FFieldAddress NotEqual_StrStr_A_PropertyAddress;

	private static int NotEqual_StrStr_A_Offset;

	private static bool NotEqual_StrStr_B_IsValid;

	private static FFieldAddress NotEqual_StrStr_B_PropertyAddress;

	private static int NotEqual_StrStr_B_Offset;

	private static bool NotEqual_StrStr_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_StrStr_ReturnValue_PropertyAddress;

	private static int NotEqual_StrStr_ReturnValue_Offset;

	private static bool NotEqual_StriStri_IsValid;

	private static IntPtr NotEqual_StriStri_FunctionAddress;

	private static int NotEqual_StriStri_ParamsSize;

	private static bool NotEqual_StriStri_A_IsValid;

	private static FFieldAddress NotEqual_StriStri_A_PropertyAddress;

	private static int NotEqual_StriStri_A_Offset;

	private static bool NotEqual_StriStri_B_IsValid;

	private static FFieldAddress NotEqual_StriStri_B_PropertyAddress;

	private static int NotEqual_StriStri_B_Offset;

	private static bool NotEqual_StriStri_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_StriStri_ReturnValue_PropertyAddress;

	private static int NotEqual_StriStri_ReturnValue_Offset;

	private static bool Mid_IsValid;

	private static IntPtr Mid_FunctionAddress;

	private static int Mid_ParamsSize;

	private static bool Mid_SourceString_IsValid;

	private static FFieldAddress Mid_SourceString_PropertyAddress;

	private static int Mid_SourceString_Offset;

	private static bool Mid_Start_IsValid;

	private static FFieldAddress Mid_Start_PropertyAddress;

	private static int Mid_Start_Offset;

	private static bool Mid_Count_IsValid;

	private static FFieldAddress Mid_Count_PropertyAddress;

	private static int Mid_Count_Offset;

	private static bool Mid_ReturnValue_IsValid;

	private static FFieldAddress Mid_ReturnValue_PropertyAddress;

	private static int Mid_ReturnValue_Offset;

	private static bool MatchesWildcard_IsValid;

	private static IntPtr MatchesWildcard_FunctionAddress;

	private static int MatchesWildcard_ParamsSize;

	private static bool MatchesWildcard_SourceString_IsValid;

	private static FFieldAddress MatchesWildcard_SourceString_PropertyAddress;

	private static int MatchesWildcard_SourceString_Offset;

	private static bool MatchesWildcard_Wildcard_IsValid;

	private static FFieldAddress MatchesWildcard_Wildcard_PropertyAddress;

	private static int MatchesWildcard_Wildcard_Offset;

	private static bool MatchesWildcard_SearchCase_IsValid;

	private static FFieldAddress MatchesWildcard_SearchCase_PropertyAddress;

	private static int MatchesWildcard_SearchCase_Offset;

	private static bool MatchesWildcard_ReturnValue_IsValid;

	private static FFieldAddress MatchesWildcard_ReturnValue_PropertyAddress;

	private static int MatchesWildcard_ReturnValue_Offset;

	private static bool Len_IsValid;

	private static IntPtr Len_FunctionAddress;

	private static int Len_ParamsSize;

	private static bool Len_S_IsValid;

	private static FFieldAddress Len_S_PropertyAddress;

	private static int Len_S_Offset;

	private static bool Len_ReturnValue_IsValid;

	private static FFieldAddress Len_ReturnValue_PropertyAddress;

	private static int Len_ReturnValue_Offset;

	private static bool LeftPad_IsValid;

	private static IntPtr LeftPad_FunctionAddress;

	private static int LeftPad_ParamsSize;

	private static bool LeftPad_SourceString_IsValid;

	private static FFieldAddress LeftPad_SourceString_PropertyAddress;

	private static int LeftPad_SourceString_Offset;

	private static bool LeftPad_ChCount_IsValid;

	private static FFieldAddress LeftPad_ChCount_PropertyAddress;

	private static int LeftPad_ChCount_Offset;

	private static bool LeftPad_ReturnValue_IsValid;

	private static FFieldAddress LeftPad_ReturnValue_PropertyAddress;

	private static int LeftPad_ReturnValue_Offset;

	private static bool LeftChop_IsValid;

	private static IntPtr LeftChop_FunctionAddress;

	private static int LeftChop_ParamsSize;

	private static bool LeftChop_SourceString_IsValid;

	private static FFieldAddress LeftChop_SourceString_PropertyAddress;

	private static int LeftChop_SourceString_Offset;

	private static bool LeftChop_Count_IsValid;

	private static FFieldAddress LeftChop_Count_PropertyAddress;

	private static int LeftChop_Count_Offset;

	private static bool LeftChop_ReturnValue_IsValid;

	private static FFieldAddress LeftChop_ReturnValue_PropertyAddress;

	private static int LeftChop_ReturnValue_Offset;

	private static bool Left_IsValid;

	private static IntPtr Left_FunctionAddress;

	private static int Left_ParamsSize;

	private static bool Left_SourceString_IsValid;

	private static FFieldAddress Left_SourceString_PropertyAddress;

	private static int Left_SourceString_Offset;

	private static bool Left_Count_IsValid;

	private static FFieldAddress Left_Count_PropertyAddress;

	private static int Left_Count_Offset;

	private static bool Left_ReturnValue_IsValid;

	private static FFieldAddress Left_ReturnValue_PropertyAddress;

	private static int Left_ReturnValue_Offset;

	private static bool JoinStringArray_IsValid;

	private static IntPtr JoinStringArray_FunctionAddress;

	private static int JoinStringArray_ParamsSize;

	private static bool JoinStringArray_SourceArray_IsValid;

	private static FFieldAddress JoinStringArray_SourceArray_PropertyAddress;

	private static int JoinStringArray_SourceArray_Offset;

	private static bool JoinStringArray_Separator_IsValid;

	private static FFieldAddress JoinStringArray_Separator_PropertyAddress;

	private static int JoinStringArray_Separator_Offset;

	private static bool JoinStringArray_ReturnValue_IsValid;

	private static FFieldAddress JoinStringArray_ReturnValue_PropertyAddress;

	private static int JoinStringArray_ReturnValue_Offset;

	private static bool IsNumeric_IsValid;

	private static IntPtr IsNumeric_FunctionAddress;

	private static int IsNumeric_ParamsSize;

	private static bool IsNumeric_SourceString_IsValid;

	private static FFieldAddress IsNumeric_SourceString_PropertyAddress;

	private static int IsNumeric_SourceString_Offset;

	private static bool IsNumeric_ReturnValue_IsValid;

	private static FFieldAddress IsNumeric_ReturnValue_PropertyAddress;

	private static int IsNumeric_ReturnValue_Offset;

	private static bool IsEmpty_IsValid;

	private static IntPtr IsEmpty_FunctionAddress;

	private static int IsEmpty_ParamsSize;

	private static bool IsEmpty_InString_IsValid;

	private static FFieldAddress IsEmpty_InString_PropertyAddress;

	private static int IsEmpty_InString_Offset;

	private static bool IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress IsEmpty_ReturnValue_PropertyAddress;

	private static int IsEmpty_ReturnValue_Offset;

	private static bool GetSubstring_IsValid;

	private static IntPtr GetSubstring_FunctionAddress;

	private static int GetSubstring_ParamsSize;

	private static bool GetSubstring_SourceString_IsValid;

	private static FFieldAddress GetSubstring_SourceString_PropertyAddress;

	private static int GetSubstring_SourceString_Offset;

	private static bool GetSubstring_StartIndex_IsValid;

	private static FFieldAddress GetSubstring_StartIndex_PropertyAddress;

	private static int GetSubstring_StartIndex_Offset;

	private static bool GetSubstring_Length_IsValid;

	private static FFieldAddress GetSubstring_Length_PropertyAddress;

	private static int GetSubstring_Length_Offset;

	private static bool GetSubstring_ReturnValue_IsValid;

	private static FFieldAddress GetSubstring_ReturnValue_PropertyAddress;

	private static int GetSubstring_ReturnValue_Offset;

	private static bool GetCharacterAsNumber_IsValid;

	private static IntPtr GetCharacterAsNumber_FunctionAddress;

	private static int GetCharacterAsNumber_ParamsSize;

	private static bool GetCharacterAsNumber_SourceString_IsValid;

	private static FFieldAddress GetCharacterAsNumber_SourceString_PropertyAddress;

	private static int GetCharacterAsNumber_SourceString_Offset;

	private static bool GetCharacterAsNumber_Index_IsValid;

	private static FFieldAddress GetCharacterAsNumber_Index_PropertyAddress;

	private static int GetCharacterAsNumber_Index_Offset;

	private static bool GetCharacterAsNumber_ReturnValue_IsValid;

	private static FFieldAddress GetCharacterAsNumber_ReturnValue_PropertyAddress;

	private static int GetCharacterAsNumber_ReturnValue_Offset;

	private static bool GetCharacterArrayFromString_IsValid;

	private static IntPtr GetCharacterArrayFromString_FunctionAddress;

	private static int GetCharacterArrayFromString_ParamsSize;

	private static bool GetCharacterArrayFromString_SourceString_IsValid;

	private static FFieldAddress GetCharacterArrayFromString_SourceString_PropertyAddress;

	private static int GetCharacterArrayFromString_SourceString_Offset;

	private static bool GetCharacterArrayFromString_ReturnValue_IsValid;

	private static FFieldAddress GetCharacterArrayFromString_ReturnValue_PropertyAddress;

	private static int GetCharacterArrayFromString_ReturnValue_Offset;

	private static bool FindSubstring_IsValid;

	private static IntPtr FindSubstring_FunctionAddress;

	private static int FindSubstring_ParamsSize;

	private static bool FindSubstring_SearchIn_IsValid;

	private static FFieldAddress FindSubstring_SearchIn_PropertyAddress;

	private static int FindSubstring_SearchIn_Offset;

	private static bool FindSubstring_Substring_IsValid;

	private static FFieldAddress FindSubstring_Substring_PropertyAddress;

	private static int FindSubstring_Substring_Offset;

	private static bool FindSubstring_bUseCase_IsValid;

	private static FFieldAddress FindSubstring_bUseCase_PropertyAddress;

	private static int FindSubstring_bUseCase_Offset;

	private static bool FindSubstring_bSearchFromEnd_IsValid;

	private static FFieldAddress FindSubstring_bSearchFromEnd_PropertyAddress;

	private static int FindSubstring_bSearchFromEnd_Offset;

	private static bool FindSubstring_StartPosition_IsValid;

	private static FFieldAddress FindSubstring_StartPosition_PropertyAddress;

	private static int FindSubstring_StartPosition_Offset;

	private static bool FindSubstring_ReturnValue_IsValid;

	private static FFieldAddress FindSubstring_ReturnValue_PropertyAddress;

	private static int FindSubstring_ReturnValue_Offset;

	private static bool EqualEqual_StrStr_IsValid;

	private static IntPtr EqualEqual_StrStr_FunctionAddress;

	private static int EqualEqual_StrStr_ParamsSize;

	private static bool EqualEqual_StrStr_A_IsValid;

	private static FFieldAddress EqualEqual_StrStr_A_PropertyAddress;

	private static int EqualEqual_StrStr_A_Offset;

	private static bool EqualEqual_StrStr_B_IsValid;

	private static FFieldAddress EqualEqual_StrStr_B_PropertyAddress;

	private static int EqualEqual_StrStr_B_Offset;

	private static bool EqualEqual_StrStr_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_StrStr_ReturnValue_PropertyAddress;

	private static int EqualEqual_StrStr_ReturnValue_Offset;

	private static bool EqualEqual_StriStri_IsValid;

	private static IntPtr EqualEqual_StriStri_FunctionAddress;

	private static int EqualEqual_StriStri_ParamsSize;

	private static bool EqualEqual_StriStri_A_IsValid;

	private static FFieldAddress EqualEqual_StriStri_A_PropertyAddress;

	private static int EqualEqual_StriStri_A_Offset;

	private static bool EqualEqual_StriStri_B_IsValid;

	private static FFieldAddress EqualEqual_StriStri_B_PropertyAddress;

	private static int EqualEqual_StriStri_B_Offset;

	private static bool EqualEqual_StriStri_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_StriStri_ReturnValue_PropertyAddress;

	private static int EqualEqual_StriStri_ReturnValue_Offset;

	private static bool EndsWith_IsValid;

	private static IntPtr EndsWith_FunctionAddress;

	private static int EndsWith_ParamsSize;

	private static bool EndsWith_SourceString_IsValid;

	private static FFieldAddress EndsWith_SourceString_PropertyAddress;

	private static int EndsWith_SourceString_Offset;

	private static bool EndsWith_InSuffix_IsValid;

	private static FFieldAddress EndsWith_InSuffix_PropertyAddress;

	private static int EndsWith_InSuffix_Offset;

	private static bool EndsWith_SearchCase_IsValid;

	private static FFieldAddress EndsWith_SearchCase_PropertyAddress;

	private static int EndsWith_SearchCase_Offset;

	private static bool EndsWith_ReturnValue_IsValid;

	private static FFieldAddress EndsWith_ReturnValue_PropertyAddress;

	private static int EndsWith_ReturnValue_Offset;

	private static bool CullArray_IsValid;

	private static IntPtr CullArray_FunctionAddress;

	private static int CullArray_ParamsSize;

	private static bool CullArray_SourceString_IsValid;

	private static FFieldAddress CullArray_SourceString_PropertyAddress;

	private static int CullArray_SourceString_Offset;

	private static bool CullArray_InArray_IsValid;

	private static FFieldAddress CullArray_InArray_PropertyAddress;

	private static int CullArray_InArray_Offset;

	private static bool CullArray_ReturnValue_IsValid;

	private static FFieldAddress CullArray_ReturnValue_PropertyAddress;

	private static int CullArray_ReturnValue_Offset;

	private static bool Conv_VectorToString_IsValid;

	private static IntPtr Conv_VectorToString_FunctionAddress;

	private static int Conv_VectorToString_ParamsSize;

	private static bool Conv_VectorToString_InVec_IsValid;

	private static FFieldAddress Conv_VectorToString_InVec_PropertyAddress;

	private static int Conv_VectorToString_InVec_Offset;

	private static bool Conv_VectorToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_VectorToString_ReturnValue_PropertyAddress;

	private static int Conv_VectorToString_ReturnValue_Offset;

	private static bool Conv_Vector3fToString_IsValid;

	private static IntPtr Conv_Vector3fToString_FunctionAddress;

	private static int Conv_Vector3fToString_ParamsSize;

	private static bool Conv_Vector3fToString_InVec_IsValid;

	private static FFieldAddress Conv_Vector3fToString_InVec_PropertyAddress;

	private static int Conv_Vector3fToString_InVec_Offset;

	private static bool Conv_Vector3fToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_Vector3fToString_ReturnValue_PropertyAddress;

	private static int Conv_Vector3fToString_ReturnValue_Offset;

	private static bool Conv_Vector2dToString_IsValid;

	private static IntPtr Conv_Vector2dToString_FunctionAddress;

	private static int Conv_Vector2dToString_ParamsSize;

	private static bool Conv_Vector2dToString_InVec_IsValid;

	private static FFieldAddress Conv_Vector2dToString_InVec_PropertyAddress;

	private static int Conv_Vector2dToString_InVec_Offset;

	private static bool Conv_Vector2dToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_Vector2dToString_ReturnValue_PropertyAddress;

	private static int Conv_Vector2dToString_ReturnValue_Offset;

	private static bool Conv_TransformToString_IsValid;

	private static IntPtr Conv_TransformToString_FunctionAddress;

	private static int Conv_TransformToString_ParamsSize;

	private static bool Conv_TransformToString_InTrans_IsValid;

	private static FFieldAddress Conv_TransformToString_InTrans_PropertyAddress;

	private static int Conv_TransformToString_InTrans_Offset;

	private static bool Conv_TransformToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_TransformToString_ReturnValue_PropertyAddress;

	private static int Conv_TransformToString_ReturnValue_Offset;

	private static bool Conv_StringToVector3f_IsValid;

	private static IntPtr Conv_StringToVector3f_FunctionAddress;

	private static int Conv_StringToVector3f_ParamsSize;

	private static bool Conv_StringToVector3f_InString_IsValid;

	private static FFieldAddress Conv_StringToVector3f_InString_PropertyAddress;

	private static int Conv_StringToVector3f_InString_Offset;

	private static bool Conv_StringToVector3f_OutConvertedVector_IsValid;

	private static FFieldAddress Conv_StringToVector3f_OutConvertedVector_PropertyAddress;

	private static int Conv_StringToVector3f_OutConvertedVector_Offset;

	private static bool Conv_StringToVector3f_OutIsValid_IsValid;

	private static FFieldAddress Conv_StringToVector3f_OutIsValid_PropertyAddress;

	private static int Conv_StringToVector3f_OutIsValid_Offset;

	private static bool Conv_StringToVector2D_IsValid;

	private static IntPtr Conv_StringToVector2D_FunctionAddress;

	private static int Conv_StringToVector2D_ParamsSize;

	private static bool Conv_StringToVector2D_InString_IsValid;

	private static FFieldAddress Conv_StringToVector2D_InString_PropertyAddress;

	private static int Conv_StringToVector2D_InString_Offset;

	private static bool Conv_StringToVector2D_OutConvertedVector2D_IsValid;

	private static FFieldAddress Conv_StringToVector2D_OutConvertedVector2D_PropertyAddress;

	private static int Conv_StringToVector2D_OutConvertedVector2D_Offset;

	private static bool Conv_StringToVector2D_OutIsValid_IsValid;

	private static FFieldAddress Conv_StringToVector2D_OutIsValid_PropertyAddress;

	private static int Conv_StringToVector2D_OutIsValid_Offset;

	private static bool Conv_StringToVector_IsValid;

	private static IntPtr Conv_StringToVector_FunctionAddress;

	private static int Conv_StringToVector_ParamsSize;

	private static bool Conv_StringToVector_InString_IsValid;

	private static FFieldAddress Conv_StringToVector_InString_PropertyAddress;

	private static int Conv_StringToVector_InString_Offset;

	private static bool Conv_StringToVector_OutConvertedVector_IsValid;

	private static FFieldAddress Conv_StringToVector_OutConvertedVector_PropertyAddress;

	private static int Conv_StringToVector_OutConvertedVector_Offset;

	private static bool Conv_StringToVector_OutIsValid_IsValid;

	private static FFieldAddress Conv_StringToVector_OutIsValid_PropertyAddress;

	private static int Conv_StringToVector_OutIsValid_Offset;

	private static bool Conv_StringToRotator_IsValid;

	private static IntPtr Conv_StringToRotator_FunctionAddress;

	private static int Conv_StringToRotator_ParamsSize;

	private static bool Conv_StringToRotator_InString_IsValid;

	private static FFieldAddress Conv_StringToRotator_InString_PropertyAddress;

	private static int Conv_StringToRotator_InString_Offset;

	private static bool Conv_StringToRotator_OutConvertedRotator_IsValid;

	private static FFieldAddress Conv_StringToRotator_OutConvertedRotator_PropertyAddress;

	private static int Conv_StringToRotator_OutConvertedRotator_Offset;

	private static bool Conv_StringToRotator_OutIsValid_IsValid;

	private static FFieldAddress Conv_StringToRotator_OutIsValid_PropertyAddress;

	private static int Conv_StringToRotator_OutIsValid_Offset;

	private static bool Conv_StringToName_IsValid;

	private static IntPtr Conv_StringToName_FunctionAddress;

	private static int Conv_StringToName_ParamsSize;

	private static bool Conv_StringToName_InString_IsValid;

	private static FFieldAddress Conv_StringToName_InString_PropertyAddress;

	private static int Conv_StringToName_InString_Offset;

	private static bool Conv_StringToName_ReturnValue_IsValid;

	private static FFieldAddress Conv_StringToName_ReturnValue_PropertyAddress;

	private static int Conv_StringToName_ReturnValue_Offset;

	private static bool Conv_StringToInt_IsValid;

	private static IntPtr Conv_StringToInt_FunctionAddress;

	private static int Conv_StringToInt_ParamsSize;

	private static bool Conv_StringToInt_InString_IsValid;

	private static FFieldAddress Conv_StringToInt_InString_PropertyAddress;

	private static int Conv_StringToInt_InString_Offset;

	private static bool Conv_StringToInt_ReturnValue_IsValid;

	private static FFieldAddress Conv_StringToInt_ReturnValue_PropertyAddress;

	private static int Conv_StringToInt_ReturnValue_Offset;

	private static bool Conv_StringToDouble_IsValid;

	private static IntPtr Conv_StringToDouble_FunctionAddress;

	private static int Conv_StringToDouble_ParamsSize;

	private static bool Conv_StringToDouble_InString_IsValid;

	private static FFieldAddress Conv_StringToDouble_InString_PropertyAddress;

	private static int Conv_StringToDouble_InString_Offset;

	private static bool Conv_StringToDouble_ReturnValue_IsValid;

	private static FFieldAddress Conv_StringToDouble_ReturnValue_PropertyAddress;

	private static int Conv_StringToDouble_ReturnValue_Offset;

	private static bool Conv_StringToColor_IsValid;

	private static IntPtr Conv_StringToColor_FunctionAddress;

	private static int Conv_StringToColor_ParamsSize;

	private static bool Conv_StringToColor_InString_IsValid;

	private static FFieldAddress Conv_StringToColor_InString_PropertyAddress;

	private static int Conv_StringToColor_InString_Offset;

	private static bool Conv_StringToColor_OutConvertedColor_IsValid;

	private static FFieldAddress Conv_StringToColor_OutConvertedColor_PropertyAddress;

	private static int Conv_StringToColor_OutConvertedColor_Offset;

	private static bool Conv_StringToColor_OutIsValid_IsValid;

	private static FFieldAddress Conv_StringToColor_OutIsValid_PropertyAddress;

	private static int Conv_StringToColor_OutIsValid_Offset;

	private static bool Conv_RotatorToString_IsValid;

	private static IntPtr Conv_RotatorToString_FunctionAddress;

	private static int Conv_RotatorToString_ParamsSize;

	private static bool Conv_RotatorToString_InRot_IsValid;

	private static FFieldAddress Conv_RotatorToString_InRot_PropertyAddress;

	private static int Conv_RotatorToString_InRot_Offset;

	private static bool Conv_RotatorToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_RotatorToString_ReturnValue_PropertyAddress;

	private static int Conv_RotatorToString_ReturnValue_Offset;

	private static bool Conv_ObjectToString_IsValid;

	private static IntPtr Conv_ObjectToString_FunctionAddress;

	private static int Conv_ObjectToString_ParamsSize;

	private static bool Conv_ObjectToString_InObj_IsValid;

	private static FFieldAddress Conv_ObjectToString_InObj_PropertyAddress;

	private static int Conv_ObjectToString_InObj_Offset;

	private static bool Conv_ObjectToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_ObjectToString_ReturnValue_PropertyAddress;

	private static int Conv_ObjectToString_ReturnValue_Offset;

	private static bool Conv_NameToString_IsValid;

	private static IntPtr Conv_NameToString_FunctionAddress;

	private static int Conv_NameToString_ParamsSize;

	private static bool Conv_NameToString_InName_IsValid;

	private static FFieldAddress Conv_NameToString_InName_PropertyAddress;

	private static int Conv_NameToString_InName_Offset;

	private static bool Conv_NameToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_NameToString_ReturnValue_PropertyAddress;

	private static int Conv_NameToString_ReturnValue_Offset;

	private static bool Conv_MatrixToString_IsValid;

	private static IntPtr Conv_MatrixToString_FunctionAddress;

	private static int Conv_MatrixToString_ParamsSize;

	private static bool Conv_MatrixToString_InMatrix_IsValid;

	private static FFieldAddress Conv_MatrixToString_InMatrix_PropertyAddress;

	private static int Conv_MatrixToString_InMatrix_Offset;

	private static bool Conv_MatrixToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_MatrixToString_ReturnValue_PropertyAddress;

	private static int Conv_MatrixToString_ReturnValue_Offset;

	private static bool Conv_IntVectorToString_IsValid;

	private static IntPtr Conv_IntVectorToString_FunctionAddress;

	private static int Conv_IntVectorToString_ParamsSize;

	private static bool Conv_IntVectorToString_InIntVec_IsValid;

	private static FFieldAddress Conv_IntVectorToString_InIntVec_PropertyAddress;

	private static int Conv_IntVectorToString_InIntVec_Offset;

	private static bool Conv_IntVectorToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_IntVectorToString_ReturnValue_PropertyAddress;

	private static int Conv_IntVectorToString_ReturnValue_Offset;

	private static bool Conv_IntToString_IsValid;

	private static IntPtr Conv_IntToString_FunctionAddress;

	private static int Conv_IntToString_ParamsSize;

	private static bool Conv_IntToString_InInt_IsValid;

	private static FFieldAddress Conv_IntToString_InInt_PropertyAddress;

	private static int Conv_IntToString_InInt_Offset;

	private static bool Conv_IntToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_IntToString_ReturnValue_PropertyAddress;

	private static int Conv_IntToString_ReturnValue_Offset;

	private static bool Conv_IntPointToString_IsValid;

	private static IntPtr Conv_IntPointToString_FunctionAddress;

	private static int Conv_IntPointToString_ParamsSize;

	private static bool Conv_IntPointToString_InIntPoint_IsValid;

	private static FFieldAddress Conv_IntPointToString_InIntPoint_PropertyAddress;

	private static int Conv_IntPointToString_InIntPoint_Offset;

	private static bool Conv_IntPointToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_IntPointToString_ReturnValue_PropertyAddress;

	private static int Conv_IntPointToString_ReturnValue_Offset;

	private static bool Conv_Int64ToString_IsValid;

	private static IntPtr Conv_Int64ToString_FunctionAddress;

	private static int Conv_Int64ToString_ParamsSize;

	private static bool Conv_Int64ToString_InInt_IsValid;

	private static FFieldAddress Conv_Int64ToString_InInt_PropertyAddress;

	private static int Conv_Int64ToString_InInt_Offset;

	private static bool Conv_Int64ToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_Int64ToString_ReturnValue_PropertyAddress;

	private static int Conv_Int64ToString_ReturnValue_Offset;

	private static bool Conv_DoubleToString_IsValid;

	private static IntPtr Conv_DoubleToString_FunctionAddress;

	private static int Conv_DoubleToString_ParamsSize;

	private static bool Conv_DoubleToString_InDouble_IsValid;

	private static FFieldAddress Conv_DoubleToString_InDouble_PropertyAddress;

	private static int Conv_DoubleToString_InDouble_Offset;

	private static bool Conv_DoubleToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_DoubleToString_ReturnValue_PropertyAddress;

	private static int Conv_DoubleToString_ReturnValue_Offset;

	private static bool Conv_ColorToString_IsValid;

	private static IntPtr Conv_ColorToString_FunctionAddress;

	private static int Conv_ColorToString_ParamsSize;

	private static bool Conv_ColorToString_InColor_IsValid;

	private static FFieldAddress Conv_ColorToString_InColor_PropertyAddress;

	private static int Conv_ColorToString_InColor_Offset;

	private static bool Conv_ColorToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_ColorToString_ReturnValue_PropertyAddress;

	private static int Conv_ColorToString_ReturnValue_Offset;

	private static bool Conv_ByteToString_IsValid;

	private static IntPtr Conv_ByteToString_FunctionAddress;

	private static int Conv_ByteToString_ParamsSize;

	private static bool Conv_ByteToString_InByte_IsValid;

	private static FFieldAddress Conv_ByteToString_InByte_PropertyAddress;

	private static int Conv_ByteToString_InByte_Offset;

	private static bool Conv_ByteToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_ByteToString_ReturnValue_PropertyAddress;

	private static int Conv_ByteToString_ReturnValue_Offset;

	private static bool Conv_BoolToString_IsValid;

	private static IntPtr Conv_BoolToString_FunctionAddress;

	private static int Conv_BoolToString_ParamsSize;

	private static bool Conv_BoolToString_InBool_IsValid;

	private static FFieldAddress Conv_BoolToString_InBool_PropertyAddress;

	private static int Conv_BoolToString_InBool_Offset;

	private static bool Conv_BoolToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_BoolToString_ReturnValue_PropertyAddress;

	private static int Conv_BoolToString_ReturnValue_Offset;

	private static bool Contains_IsValid;

	private static IntPtr Contains_FunctionAddress;

	private static int Contains_ParamsSize;

	private static bool Contains_SearchIn_IsValid;

	private static FFieldAddress Contains_SearchIn_PropertyAddress;

	private static int Contains_SearchIn_Offset;

	private static bool Contains_Substring_IsValid;

	private static FFieldAddress Contains_Substring_PropertyAddress;

	private static int Contains_Substring_Offset;

	private static bool Contains_bUseCase_IsValid;

	private static FFieldAddress Contains_bUseCase_PropertyAddress;

	private static int Contains_bUseCase_Offset;

	private static bool Contains_bSearchFromEnd_IsValid;

	private static FFieldAddress Contains_bSearchFromEnd_PropertyAddress;

	private static int Contains_bSearchFromEnd_Offset;

	private static bool Contains_ReturnValue_IsValid;

	private static FFieldAddress Contains_ReturnValue_PropertyAddress;

	private static int Contains_ReturnValue_Offset;

	private static bool Concat_StrStr_IsValid;

	private static IntPtr Concat_StrStr_FunctionAddress;

	private static int Concat_StrStr_ParamsSize;

	private static bool Concat_StrStr_A_IsValid;

	private static FFieldAddress Concat_StrStr_A_PropertyAddress;

	private static int Concat_StrStr_A_Offset;

	private static bool Concat_StrStr_B_IsValid;

	private static FFieldAddress Concat_StrStr_B_PropertyAddress;

	private static int Concat_StrStr_B_Offset;

	private static bool Concat_StrStr_ReturnValue_IsValid;

	private static FFieldAddress Concat_StrStr_ReturnValue_PropertyAddress;

	private static int Concat_StrStr_ReturnValue_Offset;

	private static bool BuildString_Vector2d_IsValid;

	private static IntPtr BuildString_Vector2d_FunctionAddress;

	private static int BuildString_Vector2d_ParamsSize;

	private static bool BuildString_Vector2d_AppendTo_IsValid;

	private static FFieldAddress BuildString_Vector2d_AppendTo_PropertyAddress;

	private static int BuildString_Vector2d_AppendTo_Offset;

	private static bool BuildString_Vector2d_Prefix_IsValid;

	private static FFieldAddress BuildString_Vector2d_Prefix_PropertyAddress;

	private static int BuildString_Vector2d_Prefix_Offset;

	private static bool BuildString_Vector2d_InVector2d_IsValid;

	private static FFieldAddress BuildString_Vector2d_InVector2d_PropertyAddress;

	private static int BuildString_Vector2d_InVector2d_Offset;

	private static bool BuildString_Vector2d_Suffix_IsValid;

	private static FFieldAddress BuildString_Vector2d_Suffix_PropertyAddress;

	private static int BuildString_Vector2d_Suffix_Offset;

	private static bool BuildString_Vector2d_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Vector2d_ReturnValue_PropertyAddress;

	private static int BuildString_Vector2d_ReturnValue_Offset;

	private static bool BuildString_Vector_IsValid;

	private static IntPtr BuildString_Vector_FunctionAddress;

	private static int BuildString_Vector_ParamsSize;

	private static bool BuildString_Vector_AppendTo_IsValid;

	private static FFieldAddress BuildString_Vector_AppendTo_PropertyAddress;

	private static int BuildString_Vector_AppendTo_Offset;

	private static bool BuildString_Vector_Prefix_IsValid;

	private static FFieldAddress BuildString_Vector_Prefix_PropertyAddress;

	private static int BuildString_Vector_Prefix_Offset;

	private static bool BuildString_Vector_InVector_IsValid;

	private static FFieldAddress BuildString_Vector_InVector_PropertyAddress;

	private static int BuildString_Vector_InVector_Offset;

	private static bool BuildString_Vector_Suffix_IsValid;

	private static FFieldAddress BuildString_Vector_Suffix_PropertyAddress;

	private static int BuildString_Vector_Suffix_Offset;

	private static bool BuildString_Vector_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Vector_ReturnValue_PropertyAddress;

	private static int BuildString_Vector_ReturnValue_Offset;

	private static bool BuildString_Rotator_IsValid;

	private static IntPtr BuildString_Rotator_FunctionAddress;

	private static int BuildString_Rotator_ParamsSize;

	private static bool BuildString_Rotator_AppendTo_IsValid;

	private static FFieldAddress BuildString_Rotator_AppendTo_PropertyAddress;

	private static int BuildString_Rotator_AppendTo_Offset;

	private static bool BuildString_Rotator_Prefix_IsValid;

	private static FFieldAddress BuildString_Rotator_Prefix_PropertyAddress;

	private static int BuildString_Rotator_Prefix_Offset;

	private static bool BuildString_Rotator_InRot_IsValid;

	private static FFieldAddress BuildString_Rotator_InRot_PropertyAddress;

	private static int BuildString_Rotator_InRot_Offset;

	private static bool BuildString_Rotator_Suffix_IsValid;

	private static FFieldAddress BuildString_Rotator_Suffix_PropertyAddress;

	private static int BuildString_Rotator_Suffix_Offset;

	private static bool BuildString_Rotator_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Rotator_ReturnValue_PropertyAddress;

	private static int BuildString_Rotator_ReturnValue_Offset;

	private static bool BuildString_Object_IsValid;

	private static IntPtr BuildString_Object_FunctionAddress;

	private static int BuildString_Object_ParamsSize;

	private static bool BuildString_Object_AppendTo_IsValid;

	private static FFieldAddress BuildString_Object_AppendTo_PropertyAddress;

	private static int BuildString_Object_AppendTo_Offset;

	private static bool BuildString_Object_Prefix_IsValid;

	private static FFieldAddress BuildString_Object_Prefix_PropertyAddress;

	private static int BuildString_Object_Prefix_Offset;

	private static bool BuildString_Object_InObj_IsValid;

	private static FFieldAddress BuildString_Object_InObj_PropertyAddress;

	private static int BuildString_Object_InObj_Offset;

	private static bool BuildString_Object_Suffix_IsValid;

	private static FFieldAddress BuildString_Object_Suffix_PropertyAddress;

	private static int BuildString_Object_Suffix_Offset;

	private static bool BuildString_Object_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Object_ReturnValue_PropertyAddress;

	private static int BuildString_Object_ReturnValue_Offset;

	private static bool BuildString_Name_IsValid;

	private static IntPtr BuildString_Name_FunctionAddress;

	private static int BuildString_Name_ParamsSize;

	private static bool BuildString_Name_AppendTo_IsValid;

	private static FFieldAddress BuildString_Name_AppendTo_PropertyAddress;

	private static int BuildString_Name_AppendTo_Offset;

	private static bool BuildString_Name_Prefix_IsValid;

	private static FFieldAddress BuildString_Name_Prefix_PropertyAddress;

	private static int BuildString_Name_Prefix_Offset;

	private static bool BuildString_Name_InName_IsValid;

	private static FFieldAddress BuildString_Name_InName_PropertyAddress;

	private static int BuildString_Name_InName_Offset;

	private static bool BuildString_Name_Suffix_IsValid;

	private static FFieldAddress BuildString_Name_Suffix_PropertyAddress;

	private static int BuildString_Name_Suffix_Offset;

	private static bool BuildString_Name_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Name_ReturnValue_PropertyAddress;

	private static int BuildString_Name_ReturnValue_Offset;

	private static bool BuildString_IntVector_IsValid;

	private static IntPtr BuildString_IntVector_FunctionAddress;

	private static int BuildString_IntVector_ParamsSize;

	private static bool BuildString_IntVector_AppendTo_IsValid;

	private static FFieldAddress BuildString_IntVector_AppendTo_PropertyAddress;

	private static int BuildString_IntVector_AppendTo_Offset;

	private static bool BuildString_IntVector_Prefix_IsValid;

	private static FFieldAddress BuildString_IntVector_Prefix_PropertyAddress;

	private static int BuildString_IntVector_Prefix_Offset;

	private static bool BuildString_IntVector_InIntVector_IsValid;

	private static FFieldAddress BuildString_IntVector_InIntVector_PropertyAddress;

	private static int BuildString_IntVector_InIntVector_Offset;

	private static bool BuildString_IntVector_Suffix_IsValid;

	private static FFieldAddress BuildString_IntVector_Suffix_PropertyAddress;

	private static int BuildString_IntVector_Suffix_Offset;

	private static bool BuildString_IntVector_ReturnValue_IsValid;

	private static FFieldAddress BuildString_IntVector_ReturnValue_PropertyAddress;

	private static int BuildString_IntVector_ReturnValue_Offset;

	private static bool BuildString_Int_IsValid;

	private static IntPtr BuildString_Int_FunctionAddress;

	private static int BuildString_Int_ParamsSize;

	private static bool BuildString_Int_AppendTo_IsValid;

	private static FFieldAddress BuildString_Int_AppendTo_PropertyAddress;

	private static int BuildString_Int_AppendTo_Offset;

	private static bool BuildString_Int_Prefix_IsValid;

	private static FFieldAddress BuildString_Int_Prefix_PropertyAddress;

	private static int BuildString_Int_Prefix_Offset;

	private static bool BuildString_Int_InInt_IsValid;

	private static FFieldAddress BuildString_Int_InInt_PropertyAddress;

	private static int BuildString_Int_InInt_Offset;

	private static bool BuildString_Int_Suffix_IsValid;

	private static FFieldAddress BuildString_Int_Suffix_PropertyAddress;

	private static int BuildString_Int_Suffix_Offset;

	private static bool BuildString_Int_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Int_ReturnValue_PropertyAddress;

	private static int BuildString_Int_ReturnValue_Offset;

	private static bool BuildString_Double_IsValid;

	private static IntPtr BuildString_Double_FunctionAddress;

	private static int BuildString_Double_ParamsSize;

	private static bool BuildString_Double_AppendTo_IsValid;

	private static FFieldAddress BuildString_Double_AppendTo_PropertyAddress;

	private static int BuildString_Double_AppendTo_Offset;

	private static bool BuildString_Double_Prefix_IsValid;

	private static FFieldAddress BuildString_Double_Prefix_PropertyAddress;

	private static int BuildString_Double_Prefix_Offset;

	private static bool BuildString_Double_InDouble_IsValid;

	private static FFieldAddress BuildString_Double_InDouble_PropertyAddress;

	private static int BuildString_Double_InDouble_Offset;

	private static bool BuildString_Double_Suffix_IsValid;

	private static FFieldAddress BuildString_Double_Suffix_PropertyAddress;

	private static int BuildString_Double_Suffix_Offset;

	private static bool BuildString_Double_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Double_ReturnValue_PropertyAddress;

	private static int BuildString_Double_ReturnValue_Offset;

	private static bool BuildString_Color_IsValid;

	private static IntPtr BuildString_Color_FunctionAddress;

	private static int BuildString_Color_ParamsSize;

	private static bool BuildString_Color_AppendTo_IsValid;

	private static FFieldAddress BuildString_Color_AppendTo_PropertyAddress;

	private static int BuildString_Color_AppendTo_Offset;

	private static bool BuildString_Color_Prefix_IsValid;

	private static FFieldAddress BuildString_Color_Prefix_PropertyAddress;

	private static int BuildString_Color_Prefix_Offset;

	private static bool BuildString_Color_InColor_IsValid;

	private static FFieldAddress BuildString_Color_InColor_PropertyAddress;

	private static int BuildString_Color_InColor_Offset;

	private static bool BuildString_Color_Suffix_IsValid;

	private static FFieldAddress BuildString_Color_Suffix_PropertyAddress;

	private static int BuildString_Color_Suffix_Offset;

	private static bool BuildString_Color_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Color_ReturnValue_PropertyAddress;

	private static int BuildString_Color_ReturnValue_Offset;

	private static bool BuildString_Bool_IsValid;

	private static IntPtr BuildString_Bool_FunctionAddress;

	private static int BuildString_Bool_ParamsSize;

	private static bool BuildString_Bool_AppendTo_IsValid;

	private static FFieldAddress BuildString_Bool_AppendTo_PropertyAddress;

	private static int BuildString_Bool_AppendTo_Offset;

	private static bool BuildString_Bool_Prefix_IsValid;

	private static FFieldAddress BuildString_Bool_Prefix_PropertyAddress;

	private static int BuildString_Bool_Prefix_Offset;

	private static bool BuildString_Bool_InBool_IsValid;

	private static FFieldAddress BuildString_Bool_InBool_PropertyAddress;

	private static int BuildString_Bool_InBool_Offset;

	private static bool BuildString_Bool_Suffix_IsValid;

	private static FFieldAddress BuildString_Bool_Suffix_PropertyAddress;

	private static int BuildString_Bool_Suffix_Offset;

	private static bool BuildString_Bool_ReturnValue_IsValid;

	private static FFieldAddress BuildString_Bool_ReturnValue_PropertyAddress;

	private static int BuildString_Bool_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:TrimTrailing")]
	public unsafe static string TrimTrailing(string SourceString)
	{
		if (!TrimTrailing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:TrimTrailing");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TrimTrailing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TrimTrailing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TrimTrailing_SourceString_Offset), 0, TrimTrailing_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TrimTrailing_FunctionAddress, intPtr, TrimTrailing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TrimTrailing_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, TrimTrailing_ReturnValue_Offset), 0, TrimTrailing_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(TrimTrailing_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Trim")]
	public unsafe static string Trim(string SourceString)
	{
		if (!Trim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Trim");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Trim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Trim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Trim_SourceString_Offset), 0, Trim_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Trim_FunctionAddress, intPtr, Trim_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Trim_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Trim_ReturnValue_Offset), 0, Trim_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Trim_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:ToUpper")]
	public unsafe static string ToUpper(string SourceString)
	{
		if (!ToUpper_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:ToUpper");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToUpper_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToUpper_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ToUpper_SourceString_Offset), 0, ToUpper_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToUpper_FunctionAddress, intPtr, ToUpper_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ToUpper_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ToUpper_ReturnValue_Offset), 0, ToUpper_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ToUpper_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:ToLower")]
	public unsafe static string ToLower(string SourceString)
	{
		if (!ToLower_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:ToLower");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToLower_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToLower_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ToLower_SourceString_Offset), 0, ToLower_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToLower_FunctionAddress, intPtr, ToLower_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ToLower_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ToLower_ReturnValue_Offset), 0, ToLower_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ToLower_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:TimeSecondsToString")]
	public unsafe static string TimeSecondsToString(float InSeconds)
	{
		if (!TimeSecondsToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:TimeSecondsToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TimeSecondsToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TimeSecondsToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TimeSecondsToString_InSeconds_Offset), 0, TimeSecondsToString_InSeconds_PropertyAddress.Address, InSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TimeSecondsToString_FunctionAddress, intPtr, TimeSecondsToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, TimeSecondsToString_ReturnValue_Offset), 0, TimeSecondsToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(TimeSecondsToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:StartsWith")]
	public unsafe static bool StartsWith(string SourceString, string InPrefix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
	{
		if (!StartsWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:StartsWith");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartsWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartsWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartsWith_SourceString_Offset), 0, StartsWith_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartsWith_InPrefix_Offset), 0, StartsWith_InPrefix_PropertyAddress.Address, InPrefix);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, StartsWith_SearchCase_Offset), 0, StartsWith_SearchCase_PropertyAddress.Address, SearchCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartsWith_FunctionAddress, intPtr, StartsWith_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartsWith_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartsWith_InPrefix_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartsWith_ReturnValue_Offset), 0, StartsWith_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Split")]
	public unsafe static bool Split(string SourceString, string InStr, out string LeftS, out string RightS, ESearchCase SearchCase = ESearchCase.IgnoreCase, ESearchDir SearchDir = ESearchDir.FromStart)
	{
		if (!Split_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Split");
			LeftS = FStringMarshaler.DefaultString;
			RightS = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Split_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Split_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Split_SourceString_Offset), 0, Split_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Split_InStr_Offset), 0, Split_InStr_PropertyAddress.Address, InStr);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, Split_SearchCase_Offset), 0, Split_SearchCase_PropertyAddress.Address, SearchCase);
		EnumMarshaler<ESearchDir>.ToNative(IntPtr.Add(intPtr, Split_SearchDir_Offset), 0, Split_SearchDir_PropertyAddress.Address, SearchDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Split_FunctionAddress, intPtr, Split_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Split_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Split_InStr_PropertyAddress.Address, intPtr);
		LeftS = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Split_LeftS_Offset), 0, Split_LeftS_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Split_LeftS_PropertyAddress.Address, intPtr);
		RightS = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Split_RightS_Offset), 0, Split_RightS_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Split_RightS_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Split_ReturnValue_Offset), 0, Split_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:RightPad")]
	public unsafe static string RightPad(string SourceString, int ChCount)
	{
		if (!RightPad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:RightPad");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RightPad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RightPad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RightPad_SourceString_Offset), 0, RightPad_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RightPad_ChCount_Offset), 0, RightPad_ChCount_PropertyAddress.Address, ChCount);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RightPad_FunctionAddress, intPtr, RightPad_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RightPad_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RightPad_ReturnValue_Offset), 0, RightPad_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RightPad_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:RightChop")]
	public unsafe static string RightChop(string SourceString, int Count)
	{
		if (!RightChop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:RightChop");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RightChop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RightChop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RightChop_SourceString_Offset), 0, RightChop_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RightChop_Count_Offset), 0, RightChop_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RightChop_FunctionAddress, intPtr, RightChop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RightChop_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, RightChop_ReturnValue_Offset), 0, RightChop_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RightChop_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Right")]
	public unsafe static string Right(string SourceString, int Count)
	{
		if (!Right_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Right");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Right_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Right_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Right_SourceString_Offset), 0, Right_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Right_Count_Offset), 0, Right_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Right_FunctionAddress, intPtr, Right_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Right_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Right_ReturnValue_Offset), 0, Right_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Right_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Reverse")]
	public unsafe static string Reverse(string SourceString)
	{
		if (!Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Reverse");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reverse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Reverse_SourceString_Offset), 0, Reverse_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Reverse_FunctionAddress, intPtr, Reverse_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Reverse_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Reverse_ReturnValue_Offset), 0, Reverse_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Reverse_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:ReplaceInline")]
	public unsafe static int ReplaceInline(ref string SourceString, string SearchText, string ReplacementText, ESearchCase SearchCase = ESearchCase.IgnoreCase)
	{
		if (!ReplaceInline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:ReplaceInline");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceInline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceInline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceInline_SourceString_Offset), 0, ReplaceInline_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceInline_SearchText_Offset), 0, ReplaceInline_SearchText_PropertyAddress.Address, SearchText);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceInline_ReplacementText_Offset), 0, ReplaceInline_ReplacementText_PropertyAddress.Address, ReplacementText);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, ReplaceInline_SearchCase_Offset), 0, ReplaceInline_SearchCase_PropertyAddress.Address, SearchCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceInline_FunctionAddress, intPtr, ReplaceInline_ParamsSize);
		SourceString = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ReplaceInline_SourceString_Offset), 0, ReplaceInline_SourceString_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReplaceInline_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ReplaceInline_SearchText_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ReplaceInline_ReplacementText_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ReplaceInline_ReturnValue_Offset), 0, ReplaceInline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Replace")]
	public unsafe static string Replace(string SourceString, string From, string To, ESearchCase SearchCase = ESearchCase.IgnoreCase)
	{
		if (!Replace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Replace");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Replace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Replace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Replace_SourceString_Offset), 0, Replace_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Replace_From_Offset), 0, Replace_From_PropertyAddress.Address, From);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Replace_To_Offset), 0, Replace_To_PropertyAddress.Address, To);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, Replace_SearchCase_Offset), 0, Replace_SearchCase_PropertyAddress.Address, SearchCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Replace_FunctionAddress, intPtr, Replace_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Replace_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Replace_From_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Replace_To_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Replace_ReturnValue_Offset), 0, Replace_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Replace_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:ParseIntoArray")]
	public unsafe static List<string> ParseIntoArray(string SourceString, string Delimiter = " ", bool CullEmptyStrings = true)
	{
		if (!ParseIntoArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:ParseIntoArray");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ParseIntoArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ParseIntoArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ParseIntoArray_SourceString_Offset), 0, ParseIntoArray_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ParseIntoArray_Delimiter_Offset), 0, ParseIntoArray_Delimiter_PropertyAddress.Address, Delimiter);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ParseIntoArray_CullEmptyStrings_Offset), 0, ParseIntoArray_CullEmptyStrings_PropertyAddress.Address, CullEmptyStrings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ParseIntoArray_FunctionAddress, intPtr, ParseIntoArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ParseIntoArray_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ParseIntoArray_Delimiter_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, ParseIntoArray_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ParseIntoArray_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ParseIntoArray_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:NotEqual_StrStr")]
	public unsafe static bool NotEqual_StrStr(string A, string B)
	{
		if (!NotEqual_StrStr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:NotEqual_StrStr");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_StrStr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_StrStr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_StrStr_A_Offset), 0, NotEqual_StrStr_A_PropertyAddress.Address, A);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_StrStr_B_Offset), 0, NotEqual_StrStr_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_StrStr_FunctionAddress, intPtr, NotEqual_StrStr_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotEqual_StrStr_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NotEqual_StrStr_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_StrStr_ReturnValue_Offset), 0, NotEqual_StrStr_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:NotEqual_StriStri")]
	public unsafe static bool NotEqual_StriStri(string A, string B)
	{
		if (!NotEqual_StriStri_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:NotEqual_StriStri");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_StriStri_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_StriStri_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_StriStri_A_Offset), 0, NotEqual_StriStri_A_PropertyAddress.Address, A);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NotEqual_StriStri_B_Offset), 0, NotEqual_StriStri_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_StriStri_FunctionAddress, intPtr, NotEqual_StriStri_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotEqual_StriStri_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NotEqual_StriStri_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_StriStri_ReturnValue_Offset), 0, NotEqual_StriStri_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Mid")]
	public unsafe static string Mid(string SourceString, int Start, int Count)
	{
		if (!Mid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Mid");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Mid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Mid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Mid_SourceString_Offset), 0, Mid_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Mid_Start_Offset), 0, Mid_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Mid_Count_Offset), 0, Mid_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Mid_FunctionAddress, intPtr, Mid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Mid_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Mid_ReturnValue_Offset), 0, Mid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Mid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:MatchesWildcard")]
	public unsafe static bool MatchesWildcard(string SourceString, string Wildcard, ESearchCase SearchCase = ESearchCase.IgnoreCase)
	{
		if (!MatchesWildcard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:MatchesWildcard");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchesWildcard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchesWildcard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MatchesWildcard_SourceString_Offset), 0, MatchesWildcard_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MatchesWildcard_Wildcard_Offset), 0, MatchesWildcard_Wildcard_PropertyAddress.Address, Wildcard);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, MatchesWildcard_SearchCase_Offset), 0, MatchesWildcard_SearchCase_PropertyAddress.Address, SearchCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MatchesWildcard_FunctionAddress, intPtr, MatchesWildcard_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MatchesWildcard_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MatchesWildcard_Wildcard_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MatchesWildcard_ReturnValue_Offset), 0, MatchesWildcard_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Len")]
	public unsafe static int Len(string S)
	{
		if (!Len_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Len");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Len_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Len_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Len_S_Offset), 0, Len_S_PropertyAddress.Address, S);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Len_FunctionAddress, intPtr, Len_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Len_S_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Len_ReturnValue_Offset), 0, Len_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:LeftPad")]
	public unsafe static string LeftPad(string SourceString, int ChCount)
	{
		if (!LeftPad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:LeftPad");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LeftPad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LeftPad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LeftPad_SourceString_Offset), 0, LeftPad_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LeftPad_ChCount_Offset), 0, LeftPad_ChCount_PropertyAddress.Address, ChCount);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LeftPad_FunctionAddress, intPtr, LeftPad_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LeftPad_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LeftPad_ReturnValue_Offset), 0, LeftPad_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LeftPad_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:LeftChop")]
	public unsafe static string LeftChop(string SourceString, int Count)
	{
		if (!LeftChop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:LeftChop");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LeftChop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LeftChop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LeftChop_SourceString_Offset), 0, LeftChop_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LeftChop_Count_Offset), 0, LeftChop_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LeftChop_FunctionAddress, intPtr, LeftChop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LeftChop_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LeftChop_ReturnValue_Offset), 0, LeftChop_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LeftChop_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Left")]
	public unsafe static string Left(string SourceString, int Count)
	{
		if (!Left_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Left");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Left_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Left_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Left_SourceString_Offset), 0, Left_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Left_Count_Offset), 0, Left_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Left_FunctionAddress, intPtr, Left_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Left_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Left_ReturnValue_Offset), 0, Left_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Left_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:JoinStringArray")]
	public unsafe static string JoinStringArray(List<string> SourceArray, string Separator = " ")
	{
		if (!JoinStringArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:JoinStringArray");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JoinStringArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JoinStringArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, JoinStringArray_SourceArray_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, JoinStringArray_SourceArray_Offset), SourceArray);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, JoinStringArray_Separator_Offset), 0, JoinStringArray_Separator_PropertyAddress.Address, Separator);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, JoinStringArray_FunctionAddress, intPtr, JoinStringArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(JoinStringArray_SourceArray_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(JoinStringArray_Separator_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, JoinStringArray_ReturnValue_Offset), 0, JoinStringArray_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(JoinStringArray_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:IsNumeric")]
	public unsafe static bool IsNumeric(string SourceString)
	{
		if (!IsNumeric_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:IsNumeric");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNumeric_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNumeric_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsNumeric_SourceString_Offset), 0, IsNumeric_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNumeric_FunctionAddress, intPtr, IsNumeric_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsNumeric_SourceString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNumeric_ReturnValue_Offset), 0, IsNumeric_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:IsEmpty")]
	public unsafe static bool IsEmpty(string InString)
	{
		if (!IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsEmpty_InString_Offset), 0, IsEmpty_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsEmpty_FunctionAddress, intPtr, IsEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsEmpty_InString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEmpty_ReturnValue_Offset), 0, IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:GetSubstring")]
	public unsafe static string GetSubstring(string SourceString, int StartIndex = 0, int Length = 1)
	{
		if (!GetSubstring_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:GetSubstring");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubstring_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubstring_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSubstring_SourceString_Offset), 0, GetSubstring_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSubstring_StartIndex_Offset), 0, GetSubstring_StartIndex_PropertyAddress.Address, StartIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSubstring_Length_Offset), 0, GetSubstring_Length_PropertyAddress.Address, Length);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSubstring_FunctionAddress, intPtr, GetSubstring_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSubstring_SourceString_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSubstring_ReturnValue_Offset), 0, GetSubstring_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSubstring_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:GetCharacterAsNumber")]
	public unsafe static int GetCharacterAsNumber(string SourceString, int Index = 0)
	{
		if (!GetCharacterAsNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:GetCharacterAsNumber");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCharacterAsNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCharacterAsNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetCharacterAsNumber_SourceString_Offset), 0, GetCharacterAsNumber_SourceString_PropertyAddress.Address, SourceString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetCharacterAsNumber_Index_Offset), 0, GetCharacterAsNumber_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCharacterAsNumber_FunctionAddress, intPtr, GetCharacterAsNumber_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCharacterAsNumber_SourceString_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCharacterAsNumber_ReturnValue_Offset), 0, GetCharacterAsNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:GetCharacterArrayFromString")]
	public unsafe static List<string> GetCharacterArrayFromString(string SourceString)
	{
		if (!GetCharacterArrayFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:GetCharacterArrayFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCharacterArrayFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCharacterArrayFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetCharacterArrayFromString_SourceString_Offset), 0, GetCharacterArrayFromString_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCharacterArrayFromString_FunctionAddress, intPtr, GetCharacterArrayFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCharacterArrayFromString_SourceString_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetCharacterArrayFromString_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetCharacterArrayFromString_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCharacterArrayFromString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:FindSubstring")]
	public unsafe static int FindSubstring(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false, int StartPosition = -1)
	{
		if (!FindSubstring_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:FindSubstring");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSubstring_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSubstring_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindSubstring_SearchIn_Offset), 0, FindSubstring_SearchIn_PropertyAddress.Address, SearchIn);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindSubstring_Substring_Offset), 0, FindSubstring_Substring_PropertyAddress.Address, Substring);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindSubstring_bUseCase_Offset), 0, FindSubstring_bUseCase_PropertyAddress.Address, bUseCase);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindSubstring_bSearchFromEnd_Offset), 0, FindSubstring_bSearchFromEnd_PropertyAddress.Address, bSearchFromEnd);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindSubstring_StartPosition_Offset), 0, FindSubstring_StartPosition_PropertyAddress.Address, StartPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindSubstring_FunctionAddress, intPtr, FindSubstring_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindSubstring_SearchIn_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindSubstring_Substring_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindSubstring_ReturnValue_Offset), 0, FindSubstring_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:EqualEqual_StrStr")]
	public unsafe static bool EqualEqual_StrStr(string A, string B)
	{
		if (!EqualEqual_StrStr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:EqualEqual_StrStr");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_StrStr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_StrStr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_StrStr_A_Offset), 0, EqualEqual_StrStr_A_PropertyAddress.Address, A);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_StrStr_B_Offset), 0, EqualEqual_StrStr_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_StrStr_FunctionAddress, intPtr, EqualEqual_StrStr_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_StrStr_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_StrStr_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_StrStr_ReturnValue_Offset), 0, EqualEqual_StrStr_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:EqualEqual_StriStri")]
	public unsafe static bool EqualEqual_StriStri(string A, string B)
	{
		if (!EqualEqual_StriStri_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:EqualEqual_StriStri");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_StriStri_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_StriStri_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_StriStri_A_Offset), 0, EqualEqual_StriStri_A_PropertyAddress.Address, A);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EqualEqual_StriStri_B_Offset), 0, EqualEqual_StriStri_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_StriStri_FunctionAddress, intPtr, EqualEqual_StriStri_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_StriStri_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_StriStri_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_StriStri_ReturnValue_Offset), 0, EqualEqual_StriStri_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:EndsWith")]
	public unsafe static bool EndsWith(string SourceString, string InSuffix, ESearchCase SearchCase = ESearchCase.IgnoreCase)
	{
		if (!EndsWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:EndsWith");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndsWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndsWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EndsWith_SourceString_Offset), 0, EndsWith_SourceString_PropertyAddress.Address, SourceString);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EndsWith_InSuffix_Offset), 0, EndsWith_InSuffix_PropertyAddress.Address, InSuffix);
		EnumMarshaler<ESearchCase>.ToNative(IntPtr.Add(intPtr, EndsWith_SearchCase_Offset), 0, EndsWith_SearchCase_PropertyAddress.Address, SearchCase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndsWith_FunctionAddress, intPtr, EndsWith_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EndsWith_SourceString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EndsWith_InSuffix_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EndsWith_ReturnValue_Offset), 0, EndsWith_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:CullArray")]
	public unsafe static int CullArray(string SourceString, out List<string> InArray)
	{
		if (!CullArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:CullArray");
			InArray = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CullArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CullArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CullArray_SourceString_Offset), 0, CullArray_SourceString_PropertyAddress.Address, SourceString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CullArray_FunctionAddress, intPtr, CullArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CullArray_SourceString_PropertyAddress.Address, intPtr);
		InArray = new TArrayCopyMarshaler<string>(1, CullArray_InArray_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, CullArray_InArray_Offset));
		NativeReflection.DestroyValue_InContainer(CullArray_InArray_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CullArray_ReturnValue_Offset), 0, CullArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_VectorToString")]
	public unsafe static string Conv_VectorToString(FVector InVec)
	{
		if (!Conv_VectorToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_VectorToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_VectorToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_VectorToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Conv_VectorToString_InVec_Offset), 0, Conv_VectorToString_InVec_PropertyAddress.Address, InVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_VectorToString_FunctionAddress, intPtr, Conv_VectorToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_VectorToString_ReturnValue_Offset), 0, Conv_VectorToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_VectorToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_Vector3fToString")]
	public unsafe static string Conv_Vector3fToString(FVector3f InVec)
	{
		if (!Conv_Vector3fToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_Vector3fToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_Vector3fToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_Vector3fToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FVector3f.ToNative(IntPtr.Add(intPtr, Conv_Vector3fToString_InVec_Offset), 0, Conv_Vector3fToString_InVec_PropertyAddress.Address, InVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_Vector3fToString_FunctionAddress, intPtr, Conv_Vector3fToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_Vector3fToString_ReturnValue_Offset), 0, Conv_Vector3fToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_Vector3fToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_Vector2dToString")]
	public unsafe static string Conv_Vector2dToString(FVector2D InVec)
	{
		if (!Conv_Vector2dToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_Vector2dToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_Vector2dToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_Vector2dToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Conv_Vector2dToString_InVec_Offset), 0, Conv_Vector2dToString_InVec_PropertyAddress.Address, InVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_Vector2dToString_FunctionAddress, intPtr, Conv_Vector2dToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_Vector2dToString_ReturnValue_Offset), 0, Conv_Vector2dToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_Vector2dToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_TransformToString")]
	public unsafe static string Conv_TransformToString(FTransform InTrans)
	{
		if (!Conv_TransformToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_TransformToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_TransformToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_TransformToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_TransformToString_InTrans_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Conv_TransformToString_InTrans_Offset), 0, Conv_TransformToString_InTrans_PropertyAddress.Address, InTrans);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_TransformToString_FunctionAddress, intPtr, Conv_TransformToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_TransformToString_ReturnValue_Offset), 0, Conv_TransformToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_TransformToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToVector3f")]
	public unsafe static void Conv_StringToVector3f(string InString, out FVector3f OutConvertedVector, out bool OutIsValid)
	{
		if (!Conv_StringToVector3f_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToVector3f");
			OutConvertedVector = default(FVector3f);
			OutIsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToVector3f_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToVector3f_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToVector3f_InString_Offset), 0, Conv_StringToVector3f_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToVector3f_FunctionAddress, intPtr, Conv_StringToVector3f_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToVector3f_InString_PropertyAddress.Address, intPtr);
		OutConvertedVector = FVector3f.FromNative(IntPtr.Add(intPtr, Conv_StringToVector3f_OutConvertedVector_Offset), 0, Conv_StringToVector3f_OutConvertedVector_PropertyAddress.Address);
		OutIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToVector3f_OutIsValid_Offset), 0, Conv_StringToVector3f_OutIsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToVector2D")]
	public unsafe static void Conv_StringToVector2D(string InString, out FVector2D OutConvertedVector2D, out bool OutIsValid)
	{
		if (!Conv_StringToVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToVector2D");
			OutConvertedVector2D = default(FVector2D);
			OutIsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToVector2D_InString_Offset), 0, Conv_StringToVector2D_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToVector2D_FunctionAddress, intPtr, Conv_StringToVector2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToVector2D_InString_PropertyAddress.Address, intPtr);
		OutConvertedVector2D = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, Conv_StringToVector2D_OutConvertedVector2D_Offset), 0, Conv_StringToVector2D_OutConvertedVector2D_PropertyAddress.Address);
		OutIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToVector2D_OutIsValid_Offset), 0, Conv_StringToVector2D_OutIsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToVector")]
	public unsafe static void Conv_StringToVector(string InString, out FVector OutConvertedVector, out bool OutIsValid)
	{
		if (!Conv_StringToVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToVector");
			OutConvertedVector = default(FVector);
			OutIsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToVector_InString_Offset), 0, Conv_StringToVector_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToVector_FunctionAddress, intPtr, Conv_StringToVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToVector_InString_PropertyAddress.Address, intPtr);
		OutConvertedVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Conv_StringToVector_OutConvertedVector_Offset), 0, Conv_StringToVector_OutConvertedVector_PropertyAddress.Address);
		OutIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToVector_OutIsValid_Offset), 0, Conv_StringToVector_OutIsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToRotator")]
	public unsafe static void Conv_StringToRotator(string InString, out FRotator OutConvertedRotator, out bool OutIsValid)
	{
		if (!Conv_StringToRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToRotator");
			OutConvertedRotator = default(FRotator);
			OutIsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToRotator_InString_Offset), 0, Conv_StringToRotator_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToRotator_FunctionAddress, intPtr, Conv_StringToRotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToRotator_InString_PropertyAddress.Address, intPtr);
		OutConvertedRotator = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, Conv_StringToRotator_OutConvertedRotator_Offset), 0, Conv_StringToRotator_OutConvertedRotator_PropertyAddress.Address);
		OutIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToRotator_OutIsValid_Offset), 0, Conv_StringToRotator_OutIsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToName")]
	public unsafe static FName Conv_StringToName(string InString)
	{
		if (!Conv_StringToName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToName_InString_Offset), 0, Conv_StringToName_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToName_FunctionAddress, intPtr, Conv_StringToName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToName_InString_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, Conv_StringToName_ReturnValue_Offset), 0, Conv_StringToName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToInt")]
	public unsafe static int Conv_StringToInt(string InString)
	{
		if (!Conv_StringToInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToInt_InString_Offset), 0, Conv_StringToInt_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToInt_FunctionAddress, intPtr, Conv_StringToInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToInt_InString_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Conv_StringToInt_ReturnValue_Offset), 0, Conv_StringToInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToDouble")]
	public unsafe static double Conv_StringToDouble(string InString)
	{
		if (!Conv_StringToDouble_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToDouble");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToDouble_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToDouble_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToDouble_InString_Offset), 0, Conv_StringToDouble_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToDouble_FunctionAddress, intPtr, Conv_StringToDouble_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToDouble_InString_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, Conv_StringToDouble_ReturnValue_Offset), 0, Conv_StringToDouble_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_StringToColor")]
	public unsafe static void Conv_StringToColor(string InString, out FLinearColor OutConvertedColor, out bool OutIsValid)
	{
		if (!Conv_StringToColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_StringToColor");
			OutConvertedColor = default(FLinearColor);
			OutIsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_StringToColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_StringToColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Conv_StringToColor_InString_Offset), 0, Conv_StringToColor_InString_PropertyAddress.Address, InString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_StringToColor_FunctionAddress, intPtr, Conv_StringToColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_StringToColor_InString_PropertyAddress.Address, intPtr);
		OutConvertedColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, Conv_StringToColor_OutConvertedColor_Offset), 0, Conv_StringToColor_OutConvertedColor_PropertyAddress.Address);
		OutIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Conv_StringToColor_OutIsValid_Offset), 0, Conv_StringToColor_OutIsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_RotatorToString")]
	public unsafe static string Conv_RotatorToString(FRotator InRot)
	{
		if (!Conv_RotatorToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_RotatorToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_RotatorToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_RotatorToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Conv_RotatorToString_InRot_Offset), 0, Conv_RotatorToString_InRot_PropertyAddress.Address, InRot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_RotatorToString_FunctionAddress, intPtr, Conv_RotatorToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_RotatorToString_ReturnValue_Offset), 0, Conv_RotatorToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_RotatorToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_ObjectToString")]
	public unsafe static string Conv_ObjectToString(UObject InObj)
	{
		if (!Conv_ObjectToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_ObjectToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ObjectToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ObjectToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Conv_ObjectToString_InObj_Offset), 0, Conv_ObjectToString_InObj_PropertyAddress.Address, InObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ObjectToString_FunctionAddress, intPtr, Conv_ObjectToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ObjectToString_ReturnValue_Offset), 0, Conv_ObjectToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_ObjectToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_NameToString")]
	public unsafe static string Conv_NameToString(FName InName)
	{
		if (!Conv_NameToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_NameToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_NameToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_NameToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Conv_NameToString_InName_Offset), 0, Conv_NameToString_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_NameToString_FunctionAddress, intPtr, Conv_NameToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_NameToString_ReturnValue_Offset), 0, Conv_NameToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_NameToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_MatrixToString")]
	public unsafe static string Conv_MatrixToString(FMatrix InMatrix)
	{
		if (!Conv_MatrixToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_MatrixToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_MatrixToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_MatrixToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, Conv_MatrixToString_InMatrix_Offset), 0, Conv_MatrixToString_InMatrix_PropertyAddress.Address, InMatrix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_MatrixToString_FunctionAddress, intPtr, Conv_MatrixToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_MatrixToString_ReturnValue_Offset), 0, Conv_MatrixToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_MatrixToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_IntVectorToString")]
	public unsafe static string Conv_IntVectorToString(FIntVector InIntVec)
	{
		if (!Conv_IntVectorToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_IntVectorToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_IntVectorToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_IntVectorToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, Conv_IntVectorToString_InIntVec_Offset), 0, Conv_IntVectorToString_InIntVec_PropertyAddress.Address, InIntVec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_IntVectorToString_FunctionAddress, intPtr, Conv_IntVectorToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_IntVectorToString_ReturnValue_Offset), 0, Conv_IntVectorToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_IntVectorToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_IntToString")]
	public unsafe static string Conv_IntToString(int InInt)
	{
		if (!Conv_IntToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_IntToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_IntToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_IntToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Conv_IntToString_InInt_Offset), 0, Conv_IntToString_InInt_PropertyAddress.Address, InInt);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_IntToString_FunctionAddress, intPtr, Conv_IntToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_IntToString_ReturnValue_Offset), 0, Conv_IntToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_IntToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_IntPointToString")]
	public unsafe static string Conv_IntPointToString(FIntPoint InIntPoint)
	{
		if (!Conv_IntPointToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_IntPointToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_IntPointToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_IntPointToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, Conv_IntPointToString_InIntPoint_Offset), 0, Conv_IntPointToString_InIntPoint_PropertyAddress.Address, InIntPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_IntPointToString_FunctionAddress, intPtr, Conv_IntPointToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_IntPointToString_ReturnValue_Offset), 0, Conv_IntPointToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_IntPointToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_Int64ToString")]
	public unsafe static string Conv_Int64ToString(long InInt)
	{
		if (!Conv_Int64ToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_Int64ToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_Int64ToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_Int64ToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, Conv_Int64ToString_InInt_Offset), 0, Conv_Int64ToString_InInt_PropertyAddress.Address, InInt);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_Int64ToString_FunctionAddress, intPtr, Conv_Int64ToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_Int64ToString_ReturnValue_Offset), 0, Conv_Int64ToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_Int64ToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_DoubleToString")]
	public unsafe static string Conv_DoubleToString(double InDouble)
	{
		if (!Conv_DoubleToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_DoubleToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_DoubleToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_DoubleToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, Conv_DoubleToString_InDouble_Offset), 0, Conv_DoubleToString_InDouble_PropertyAddress.Address, InDouble);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_DoubleToString_FunctionAddress, intPtr, Conv_DoubleToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_DoubleToString_ReturnValue_Offset), 0, Conv_DoubleToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_DoubleToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_ColorToString")]
	public unsafe static string Conv_ColorToString(FLinearColor InColor)
	{
		if (!Conv_ColorToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_ColorToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ColorToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ColorToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, Conv_ColorToString_InColor_Offset), 0, Conv_ColorToString_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ColorToString_FunctionAddress, intPtr, Conv_ColorToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ColorToString_ReturnValue_Offset), 0, Conv_ColorToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_ColorToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_ByteToString")]
	public unsafe static string Conv_ByteToString(byte InByte)
	{
		if (!Conv_ByteToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_ByteToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_ByteToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_ByteToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, Conv_ByteToString_InByte_Offset), 0, Conv_ByteToString_InByte_PropertyAddress.Address, InByte);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_ByteToString_FunctionAddress, intPtr, Conv_ByteToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_ByteToString_ReturnValue_Offset), 0, Conv_ByteToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_ByteToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Conv_BoolToString")]
	public unsafe static string Conv_BoolToString(bool InBool)
	{
		if (!Conv_BoolToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Conv_BoolToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_BoolToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_BoolToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_BoolToString_InBool_Offset), 0, Conv_BoolToString_InBool_PropertyAddress.Address, InBool);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_BoolToString_FunctionAddress, intPtr, Conv_BoolToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_BoolToString_ReturnValue_Offset), 0, Conv_BoolToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_BoolToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Contains")]
	public unsafe static bool Contains(string SearchIn, string Substring, bool bUseCase = false, bool bSearchFromEnd = false)
	{
		if (!Contains_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Contains");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Contains_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Contains_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Contains_SearchIn_Offset), 0, Contains_SearchIn_PropertyAddress.Address, SearchIn);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Contains_Substring_Offset), 0, Contains_Substring_PropertyAddress.Address, Substring);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Contains_bUseCase_Offset), 0, Contains_bUseCase_PropertyAddress.Address, bUseCase);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Contains_bSearchFromEnd_Offset), 0, Contains_bSearchFromEnd_PropertyAddress.Address, bSearchFromEnd);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Contains_FunctionAddress, intPtr, Contains_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Contains_SearchIn_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Contains_Substring_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Contains_ReturnValue_Offset), 0, Contains_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:Concat_StrStr")]
	public unsafe static string Concat_StrStr(string A, string B)
	{
		if (!Concat_StrStr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:Concat_StrStr");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Concat_StrStr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Concat_StrStr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Concat_StrStr_A_Offset), 0, Concat_StrStr_A_PropertyAddress.Address, A);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Concat_StrStr_B_Offset), 0, Concat_StrStr_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Concat_StrStr_FunctionAddress, intPtr, Concat_StrStr_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Concat_StrStr_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Concat_StrStr_B_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Concat_StrStr_ReturnValue_Offset), 0, Concat_StrStr_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Concat_StrStr_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Vector2d")]
	public unsafe static string BuildString_Vector2d(string AppendTo, string Prefix, FVector2D InVector2d, string Suffix)
	{
		if (!BuildString_Vector2d_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Vector2d");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Vector2d_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Vector2d_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector2d_AppendTo_Offset), 0, BuildString_Vector2d_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector2d_Prefix_Offset), 0, BuildString_Vector2d_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, BuildString_Vector2d_InVector2d_Offset), 0, BuildString_Vector2d_InVector2d_PropertyAddress.Address, InVector2d);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector2d_Suffix_Offset), 0, BuildString_Vector2d_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Vector2d_FunctionAddress, intPtr, BuildString_Vector2d_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector2d_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector2d_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector2d_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Vector2d_ReturnValue_Offset), 0, BuildString_Vector2d_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector2d_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Vector")]
	public unsafe static string BuildString_Vector(string AppendTo, string Prefix, FVector InVector, string Suffix)
	{
		if (!BuildString_Vector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Vector");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Vector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Vector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector_AppendTo_Offset), 0, BuildString_Vector_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector_Prefix_Offset), 0, BuildString_Vector_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BuildString_Vector_InVector_Offset), 0, BuildString_Vector_InVector_PropertyAddress.Address, InVector);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Vector_Suffix_Offset), 0, BuildString_Vector_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Vector_FunctionAddress, intPtr, BuildString_Vector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Vector_ReturnValue_Offset), 0, BuildString_Vector_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Vector_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Rotator")]
	public unsafe static string BuildString_Rotator(string AppendTo, string Prefix, FRotator InRot, string Suffix)
	{
		if (!BuildString_Rotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Rotator");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Rotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Rotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Rotator_AppendTo_Offset), 0, BuildString_Rotator_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Rotator_Prefix_Offset), 0, BuildString_Rotator_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, BuildString_Rotator_InRot_Offset), 0, BuildString_Rotator_InRot_PropertyAddress.Address, InRot);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Rotator_Suffix_Offset), 0, BuildString_Rotator_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Rotator_FunctionAddress, intPtr, BuildString_Rotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Rotator_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Rotator_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Rotator_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Rotator_ReturnValue_Offset), 0, BuildString_Rotator_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Rotator_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Object")]
	public unsafe static string BuildString_Object(string AppendTo, string Prefix, UObject InObj, string Suffix)
	{
		if (!BuildString_Object_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Object");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Object_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Object_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Object_AppendTo_Offset), 0, BuildString_Object_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Object_Prefix_Offset), 0, BuildString_Object_Prefix_PropertyAddress.Address, Prefix);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BuildString_Object_InObj_Offset), 0, BuildString_Object_InObj_PropertyAddress.Address, InObj);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Object_Suffix_Offset), 0, BuildString_Object_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Object_FunctionAddress, intPtr, BuildString_Object_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Object_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Object_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Object_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Object_ReturnValue_Offset), 0, BuildString_Object_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Object_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Name")]
	public unsafe static string BuildString_Name(string AppendTo, string Prefix, FName InName, string Suffix)
	{
		if (!BuildString_Name_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Name");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Name_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Name_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Name_AppendTo_Offset), 0, BuildString_Name_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Name_Prefix_Offset), 0, BuildString_Name_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BuildString_Name_InName_Offset), 0, BuildString_Name_InName_PropertyAddress.Address, InName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Name_Suffix_Offset), 0, BuildString_Name_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Name_FunctionAddress, intPtr, BuildString_Name_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Name_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Name_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Name_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Name_ReturnValue_Offset), 0, BuildString_Name_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Name_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_IntVector")]
	public unsafe static string BuildString_IntVector(string AppendTo, string Prefix, FIntVector InIntVector, string Suffix)
	{
		if (!BuildString_IntVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_IntVector");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_IntVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_IntVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_IntVector_AppendTo_Offset), 0, BuildString_IntVector_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_IntVector_Prefix_Offset), 0, BuildString_IntVector_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, BuildString_IntVector_InIntVector_Offset), 0, BuildString_IntVector_InIntVector_PropertyAddress.Address, InIntVector);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_IntVector_Suffix_Offset), 0, BuildString_IntVector_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_IntVector_FunctionAddress, intPtr, BuildString_IntVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_IntVector_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_IntVector_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_IntVector_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_IntVector_ReturnValue_Offset), 0, BuildString_IntVector_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_IntVector_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Int")]
	public unsafe static string BuildString_Int(string AppendTo, string Prefix, int InInt, string Suffix)
	{
		if (!BuildString_Int_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Int");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Int_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Int_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Int_AppendTo_Offset), 0, BuildString_Int_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Int_Prefix_Offset), 0, BuildString_Int_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BuildString_Int_InInt_Offset), 0, BuildString_Int_InInt_PropertyAddress.Address, InInt);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Int_Suffix_Offset), 0, BuildString_Int_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Int_FunctionAddress, intPtr, BuildString_Int_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Int_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Int_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Int_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Int_ReturnValue_Offset), 0, BuildString_Int_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Int_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Double")]
	public unsafe static string BuildString_Double(string AppendTo, string Prefix, double InDouble, string Suffix)
	{
		if (!BuildString_Double_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Double");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Double_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Double_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Double_AppendTo_Offset), 0, BuildString_Double_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Double_Prefix_Offset), 0, BuildString_Double_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, BuildString_Double_InDouble_Offset), 0, BuildString_Double_InDouble_PropertyAddress.Address, InDouble);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Double_Suffix_Offset), 0, BuildString_Double_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Double_FunctionAddress, intPtr, BuildString_Double_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Double_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Double_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Double_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Double_ReturnValue_Offset), 0, BuildString_Double_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Double_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Color")]
	public unsafe static string BuildString_Color(string AppendTo, string Prefix, FLinearColor InColor, string Suffix)
	{
		if (!BuildString_Color_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Color");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Color_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Color_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Color_AppendTo_Offset), 0, BuildString_Color_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Color_Prefix_Offset), 0, BuildString_Color_Prefix_PropertyAddress.Address, Prefix);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, BuildString_Color_InColor_Offset), 0, BuildString_Color_InColor_PropertyAddress.Address, InColor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Color_Suffix_Offset), 0, BuildString_Color_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Color_FunctionAddress, intPtr, BuildString_Color_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Color_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Color_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Color_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Color_ReturnValue_Offset), 0, BuildString_Color_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Color_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetStringLibrary:BuildString_Bool")]
	public unsafe static string BuildString_Bool(string AppendTo, string Prefix, bool InBool, string Suffix)
	{
		if (!BuildString_Bool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetStringLibrary:BuildString_Bool");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildString_Bool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildString_Bool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Bool_AppendTo_Offset), 0, BuildString_Bool_AppendTo_PropertyAddress.Address, AppendTo);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Bool_Prefix_Offset), 0, BuildString_Bool_Prefix_PropertyAddress.Address, Prefix);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Bool_InBool_Offset), 0, BuildString_Bool_InBool_PropertyAddress.Address, InBool);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildString_Bool_Suffix_Offset), 0, BuildString_Bool_Suffix_PropertyAddress.Address, Suffix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildString_Bool_FunctionAddress, intPtr, BuildString_Bool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildString_Bool_AppendTo_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Bool_Prefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildString_Bool_Suffix_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildString_Bool_ReturnValue_Offset), 0, BuildString_Bool_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildString_Bool_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UStringLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStringLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStringLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetStringLibrary");
		TrimTrailing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TrimTrailing");
		TrimTrailing_ParamsSize = NativeReflection.GetFunctionParamsSize(TrimTrailing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TrimTrailing_SourceString_PropertyAddress, TrimTrailing_FunctionAddress, "SourceString");
		TrimTrailing_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(TrimTrailing_FunctionAddress, "SourceString");
		TrimTrailing_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(TrimTrailing_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TrimTrailing_ReturnValue_PropertyAddress, TrimTrailing_FunctionAddress, "ReturnValue");
		TrimTrailing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TrimTrailing_FunctionAddress, "ReturnValue");
		TrimTrailing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TrimTrailing_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		TrimTrailing_IsValid = TrimTrailing_FunctionAddress != IntPtr.Zero && TrimTrailing_SourceString_IsValid && TrimTrailing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:TrimTrailing", TrimTrailing_IsValid);
		Trim_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Trim");
		Trim_ParamsSize = NativeReflection.GetFunctionParamsSize(Trim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Trim_SourceString_PropertyAddress, Trim_FunctionAddress, "SourceString");
		Trim_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Trim_FunctionAddress, "SourceString");
		Trim_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Trim_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Trim_ReturnValue_PropertyAddress, Trim_FunctionAddress, "ReturnValue");
		Trim_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Trim_FunctionAddress, "ReturnValue");
		Trim_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Trim_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Trim_IsValid = Trim_FunctionAddress != IntPtr.Zero && Trim_SourceString_IsValid && Trim_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Trim", Trim_IsValid);
		ToUpper_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToUpper");
		ToUpper_ParamsSize = NativeReflection.GetFunctionParamsSize(ToUpper_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToUpper_SourceString_PropertyAddress, ToUpper_FunctionAddress, "SourceString");
		ToUpper_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(ToUpper_FunctionAddress, "SourceString");
		ToUpper_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(ToUpper_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ToUpper_ReturnValue_PropertyAddress, ToUpper_FunctionAddress, "ReturnValue");
		ToUpper_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToUpper_FunctionAddress, "ReturnValue");
		ToUpper_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToUpper_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ToUpper_IsValid = ToUpper_FunctionAddress != IntPtr.Zero && ToUpper_SourceString_IsValid && ToUpper_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:ToUpper", ToUpper_IsValid);
		ToLower_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToLower");
		ToLower_ParamsSize = NativeReflection.GetFunctionParamsSize(ToLower_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToLower_SourceString_PropertyAddress, ToLower_FunctionAddress, "SourceString");
		ToLower_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(ToLower_FunctionAddress, "SourceString");
		ToLower_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(ToLower_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ToLower_ReturnValue_PropertyAddress, ToLower_FunctionAddress, "ReturnValue");
		ToLower_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToLower_FunctionAddress, "ReturnValue");
		ToLower_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToLower_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ToLower_IsValid = ToLower_FunctionAddress != IntPtr.Zero && ToLower_SourceString_IsValid && ToLower_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:ToLower", ToLower_IsValid);
		TimeSecondsToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TimeSecondsToString");
		TimeSecondsToString_ParamsSize = NativeReflection.GetFunctionParamsSize(TimeSecondsToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TimeSecondsToString_InSeconds_PropertyAddress, TimeSecondsToString_FunctionAddress, "InSeconds");
		TimeSecondsToString_InSeconds_Offset = NativeReflectionCached.GetPropertyOffset(TimeSecondsToString_FunctionAddress, "InSeconds");
		TimeSecondsToString_InSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(TimeSecondsToString_FunctionAddress, "InSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TimeSecondsToString_ReturnValue_PropertyAddress, TimeSecondsToString_FunctionAddress, "ReturnValue");
		TimeSecondsToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TimeSecondsToString_FunctionAddress, "ReturnValue");
		TimeSecondsToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TimeSecondsToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		TimeSecondsToString_IsValid = TimeSecondsToString_FunctionAddress != IntPtr.Zero && TimeSecondsToString_InSeconds_IsValid && TimeSecondsToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:TimeSecondsToString", TimeSecondsToString_IsValid);
		StartsWith_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartsWith");
		StartsWith_ParamsSize = NativeReflection.GetFunctionParamsSize(StartsWith_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartsWith_SourceString_PropertyAddress, StartsWith_FunctionAddress, "SourceString");
		StartsWith_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(StartsWith_FunctionAddress, "SourceString");
		StartsWith_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(StartsWith_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartsWith_InPrefix_PropertyAddress, StartsWith_FunctionAddress, "InPrefix");
		StartsWith_InPrefix_Offset = NativeReflectionCached.GetPropertyOffset(StartsWith_FunctionAddress, "InPrefix");
		StartsWith_InPrefix_IsValid = NativeReflectionCached.ValidatePropertyClass(StartsWith_FunctionAddress, "InPrefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartsWith_SearchCase_PropertyAddress, StartsWith_FunctionAddress, "SearchCase");
		StartsWith_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(StartsWith_FunctionAddress, "SearchCase");
		StartsWith_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(StartsWith_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref StartsWith_ReturnValue_PropertyAddress, StartsWith_FunctionAddress, "ReturnValue");
		StartsWith_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartsWith_FunctionAddress, "ReturnValue");
		StartsWith_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartsWith_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartsWith_IsValid = StartsWith_FunctionAddress != IntPtr.Zero && StartsWith_SourceString_IsValid && StartsWith_InPrefix_IsValid && StartsWith_SearchCase_IsValid && StartsWith_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:StartsWith", StartsWith_IsValid);
		Split_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Split");
		Split_ParamsSize = NativeReflection.GetFunctionParamsSize(Split_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Split_SourceString_PropertyAddress, Split_FunctionAddress, "SourceString");
		Split_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "SourceString");
		Split_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_InStr_PropertyAddress, Split_FunctionAddress, "InStr");
		Split_InStr_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "InStr");
		Split_InStr_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "InStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_LeftS_PropertyAddress, Split_FunctionAddress, "LeftS");
		Split_LeftS_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "LeftS");
		Split_LeftS_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "LeftS", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_RightS_PropertyAddress, Split_FunctionAddress, "RightS");
		Split_RightS_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "RightS");
		Split_RightS_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "RightS", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_SearchCase_PropertyAddress, Split_FunctionAddress, "SearchCase");
		Split_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "SearchCase");
		Split_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_SearchDir_PropertyAddress, Split_FunctionAddress, "SearchDir");
		Split_SearchDir_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "SearchDir");
		Split_SearchDir_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "SearchDir", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Split_ReturnValue_PropertyAddress, Split_FunctionAddress, "ReturnValue");
		Split_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Split_FunctionAddress, "ReturnValue");
		Split_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Split_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Split_IsValid = Split_FunctionAddress != IntPtr.Zero && Split_SourceString_IsValid && Split_InStr_IsValid && Split_LeftS_IsValid && Split_RightS_IsValid && Split_SearchCase_IsValid && Split_SearchDir_IsValid && Split_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Split", Split_IsValid);
		RightPad_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RightPad");
		RightPad_ParamsSize = NativeReflection.GetFunctionParamsSize(RightPad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RightPad_SourceString_PropertyAddress, RightPad_FunctionAddress, "SourceString");
		RightPad_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(RightPad_FunctionAddress, "SourceString");
		RightPad_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(RightPad_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RightPad_ChCount_PropertyAddress, RightPad_FunctionAddress, "ChCount");
		RightPad_ChCount_Offset = NativeReflectionCached.GetPropertyOffset(RightPad_FunctionAddress, "ChCount");
		RightPad_ChCount_IsValid = NativeReflectionCached.ValidatePropertyClass(RightPad_FunctionAddress, "ChCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RightPad_ReturnValue_PropertyAddress, RightPad_FunctionAddress, "ReturnValue");
		RightPad_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RightPad_FunctionAddress, "ReturnValue");
		RightPad_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RightPad_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RightPad_IsValid = RightPad_FunctionAddress != IntPtr.Zero && RightPad_SourceString_IsValid && RightPad_ChCount_IsValid && RightPad_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:RightPad", RightPad_IsValid);
		RightChop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RightChop");
		RightChop_ParamsSize = NativeReflection.GetFunctionParamsSize(RightChop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RightChop_SourceString_PropertyAddress, RightChop_FunctionAddress, "SourceString");
		RightChop_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(RightChop_FunctionAddress, "SourceString");
		RightChop_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(RightChop_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RightChop_Count_PropertyAddress, RightChop_FunctionAddress, "Count");
		RightChop_Count_Offset = NativeReflectionCached.GetPropertyOffset(RightChop_FunctionAddress, "Count");
		RightChop_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(RightChop_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RightChop_ReturnValue_PropertyAddress, RightChop_FunctionAddress, "ReturnValue");
		RightChop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RightChop_FunctionAddress, "ReturnValue");
		RightChop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RightChop_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		RightChop_IsValid = RightChop_FunctionAddress != IntPtr.Zero && RightChop_SourceString_IsValid && RightChop_Count_IsValid && RightChop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:RightChop", RightChop_IsValid);
		Right_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Right");
		Right_ParamsSize = NativeReflection.GetFunctionParamsSize(Right_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Right_SourceString_PropertyAddress, Right_FunctionAddress, "SourceString");
		Right_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Right_FunctionAddress, "SourceString");
		Right_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Right_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Right_Count_PropertyAddress, Right_FunctionAddress, "Count");
		Right_Count_Offset = NativeReflectionCached.GetPropertyOffset(Right_FunctionAddress, "Count");
		Right_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(Right_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Right_ReturnValue_PropertyAddress, Right_FunctionAddress, "ReturnValue");
		Right_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Right_FunctionAddress, "ReturnValue");
		Right_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Right_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Right_IsValid = Right_FunctionAddress != IntPtr.Zero && Right_SourceString_IsValid && Right_Count_IsValid && Right_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Right", Right_IsValid);
		Reverse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Reverse");
		Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Reverse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Reverse_SourceString_PropertyAddress, Reverse_FunctionAddress, "SourceString");
		Reverse_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Reverse_FunctionAddress, "SourceString");
		Reverse_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Reverse_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Reverse_ReturnValue_PropertyAddress, Reverse_FunctionAddress, "ReturnValue");
		Reverse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Reverse_FunctionAddress, "ReturnValue");
		Reverse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Reverse_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Reverse_IsValid = Reverse_FunctionAddress != IntPtr.Zero && Reverse_SourceString_IsValid && Reverse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Reverse", Reverse_IsValid);
		ReplaceInline_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceInline");
		ReplaceInline_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceInline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInline_SourceString_PropertyAddress, ReplaceInline_FunctionAddress, "SourceString");
		ReplaceInline_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInline_FunctionAddress, "SourceString");
		ReplaceInline_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInline_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInline_SearchText_PropertyAddress, ReplaceInline_FunctionAddress, "SearchText");
		ReplaceInline_SearchText_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInline_FunctionAddress, "SearchText");
		ReplaceInline_SearchText_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInline_FunctionAddress, "SearchText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInline_ReplacementText_PropertyAddress, ReplaceInline_FunctionAddress, "ReplacementText");
		ReplaceInline_ReplacementText_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInline_FunctionAddress, "ReplacementText");
		ReplaceInline_ReplacementText_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInline_FunctionAddress, "ReplacementText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInline_SearchCase_PropertyAddress, ReplaceInline_FunctionAddress, "SearchCase");
		ReplaceInline_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInline_FunctionAddress, "SearchCase");
		ReplaceInline_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInline_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInline_ReturnValue_PropertyAddress, ReplaceInline_FunctionAddress, "ReturnValue");
		ReplaceInline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInline_FunctionAddress, "ReturnValue");
		ReplaceInline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInline_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ReplaceInline_IsValid = ReplaceInline_FunctionAddress != IntPtr.Zero && ReplaceInline_SourceString_IsValid && ReplaceInline_SearchText_IsValid && ReplaceInline_ReplacementText_IsValid && ReplaceInline_SearchCase_IsValid && ReplaceInline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:ReplaceInline", ReplaceInline_IsValid);
		Replace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Replace");
		Replace_ParamsSize = NativeReflection.GetFunctionParamsSize(Replace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Replace_SourceString_PropertyAddress, Replace_FunctionAddress, "SourceString");
		Replace_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "SourceString");
		Replace_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_From_PropertyAddress, Replace_FunctionAddress, "From");
		Replace_From_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "From");
		Replace_From_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "From", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_To_PropertyAddress, Replace_FunctionAddress, "To");
		Replace_To_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "To");
		Replace_To_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "To", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_SearchCase_PropertyAddress, Replace_FunctionAddress, "SearchCase");
		Replace_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "SearchCase");
		Replace_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_ReturnValue_PropertyAddress, Replace_FunctionAddress, "ReturnValue");
		Replace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "ReturnValue");
		Replace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Replace_IsValid = Replace_FunctionAddress != IntPtr.Zero && Replace_SourceString_IsValid && Replace_From_IsValid && Replace_To_IsValid && Replace_SearchCase_IsValid && Replace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Replace", Replace_IsValid);
		ParseIntoArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ParseIntoArray");
		ParseIntoArray_ParamsSize = NativeReflection.GetFunctionParamsSize(ParseIntoArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ParseIntoArray_SourceString_PropertyAddress, ParseIntoArray_FunctionAddress, "SourceString");
		ParseIntoArray_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(ParseIntoArray_FunctionAddress, "SourceString");
		ParseIntoArray_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(ParseIntoArray_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ParseIntoArray_Delimiter_PropertyAddress, ParseIntoArray_FunctionAddress, "Delimiter");
		ParseIntoArray_Delimiter_Offset = NativeReflectionCached.GetPropertyOffset(ParseIntoArray_FunctionAddress, "Delimiter");
		ParseIntoArray_Delimiter_IsValid = NativeReflectionCached.ValidatePropertyClass(ParseIntoArray_FunctionAddress, "Delimiter", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ParseIntoArray_CullEmptyStrings_PropertyAddress, ParseIntoArray_FunctionAddress, "CullEmptyStrings");
		ParseIntoArray_CullEmptyStrings_Offset = NativeReflectionCached.GetPropertyOffset(ParseIntoArray_FunctionAddress, "CullEmptyStrings");
		ParseIntoArray_CullEmptyStrings_IsValid = NativeReflectionCached.ValidatePropertyClass(ParseIntoArray_FunctionAddress, "CullEmptyStrings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ParseIntoArray_ReturnValue_PropertyAddress, ParseIntoArray_FunctionAddress, "ReturnValue");
		ParseIntoArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ParseIntoArray_FunctionAddress, "ReturnValue");
		ParseIntoArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ParseIntoArray_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ParseIntoArray_IsValid = ParseIntoArray_FunctionAddress != IntPtr.Zero && ParseIntoArray_SourceString_IsValid && ParseIntoArray_Delimiter_IsValid && ParseIntoArray_CullEmptyStrings_IsValid && ParseIntoArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:ParseIntoArray", ParseIntoArray_IsValid);
		NotEqual_StrStr_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_StrStr");
		NotEqual_StrStr_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_StrStr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StrStr_A_PropertyAddress, NotEqual_StrStr_FunctionAddress, "A");
		NotEqual_StrStr_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StrStr_FunctionAddress, "A");
		NotEqual_StrStr_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StrStr_FunctionAddress, "A", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StrStr_B_PropertyAddress, NotEqual_StrStr_FunctionAddress, "B");
		NotEqual_StrStr_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StrStr_FunctionAddress, "B");
		NotEqual_StrStr_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StrStr_FunctionAddress, "B", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StrStr_ReturnValue_PropertyAddress, NotEqual_StrStr_FunctionAddress, "ReturnValue");
		NotEqual_StrStr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StrStr_FunctionAddress, "ReturnValue");
		NotEqual_StrStr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StrStr_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_StrStr_IsValid = NotEqual_StrStr_FunctionAddress != IntPtr.Zero && NotEqual_StrStr_A_IsValid && NotEqual_StrStr_B_IsValid && NotEqual_StrStr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:NotEqual_StrStr", NotEqual_StrStr_IsValid);
		NotEqual_StriStri_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_StriStri");
		NotEqual_StriStri_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_StriStri_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StriStri_A_PropertyAddress, NotEqual_StriStri_FunctionAddress, "A");
		NotEqual_StriStri_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StriStri_FunctionAddress, "A");
		NotEqual_StriStri_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StriStri_FunctionAddress, "A", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StriStri_B_PropertyAddress, NotEqual_StriStri_FunctionAddress, "B");
		NotEqual_StriStri_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StriStri_FunctionAddress, "B");
		NotEqual_StriStri_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StriStri_FunctionAddress, "B", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_StriStri_ReturnValue_PropertyAddress, NotEqual_StriStri_FunctionAddress, "ReturnValue");
		NotEqual_StriStri_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_StriStri_FunctionAddress, "ReturnValue");
		NotEqual_StriStri_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_StriStri_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_StriStri_IsValid = NotEqual_StriStri_FunctionAddress != IntPtr.Zero && NotEqual_StriStri_A_IsValid && NotEqual_StriStri_B_IsValid && NotEqual_StriStri_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:NotEqual_StriStri", NotEqual_StriStri_IsValid);
		Mid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Mid");
		Mid_ParamsSize = NativeReflection.GetFunctionParamsSize(Mid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Mid_SourceString_PropertyAddress, Mid_FunctionAddress, "SourceString");
		Mid_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Mid_FunctionAddress, "SourceString");
		Mid_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Mid_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Mid_Start_PropertyAddress, Mid_FunctionAddress, "Start");
		Mid_Start_Offset = NativeReflectionCached.GetPropertyOffset(Mid_FunctionAddress, "Start");
		Mid_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(Mid_FunctionAddress, "Start", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Mid_Count_PropertyAddress, Mid_FunctionAddress, "Count");
		Mid_Count_Offset = NativeReflectionCached.GetPropertyOffset(Mid_FunctionAddress, "Count");
		Mid_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(Mid_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Mid_ReturnValue_PropertyAddress, Mid_FunctionAddress, "ReturnValue");
		Mid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Mid_FunctionAddress, "ReturnValue");
		Mid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Mid_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Mid_IsValid = Mid_FunctionAddress != IntPtr.Zero && Mid_SourceString_IsValid && Mid_Start_IsValid && Mid_Count_IsValid && Mid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Mid", Mid_IsValid);
		MatchesWildcard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MatchesWildcard");
		MatchesWildcard_ParamsSize = NativeReflection.GetFunctionParamsSize(MatchesWildcard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MatchesWildcard_SourceString_PropertyAddress, MatchesWildcard_FunctionAddress, "SourceString");
		MatchesWildcard_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(MatchesWildcard_FunctionAddress, "SourceString");
		MatchesWildcard_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesWildcard_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesWildcard_Wildcard_PropertyAddress, MatchesWildcard_FunctionAddress, "Wildcard");
		MatchesWildcard_Wildcard_Offset = NativeReflectionCached.GetPropertyOffset(MatchesWildcard_FunctionAddress, "Wildcard");
		MatchesWildcard_Wildcard_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesWildcard_FunctionAddress, "Wildcard", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesWildcard_SearchCase_PropertyAddress, MatchesWildcard_FunctionAddress, "SearchCase");
		MatchesWildcard_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(MatchesWildcard_FunctionAddress, "SearchCase");
		MatchesWildcard_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesWildcard_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesWildcard_ReturnValue_PropertyAddress, MatchesWildcard_FunctionAddress, "ReturnValue");
		MatchesWildcard_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MatchesWildcard_FunctionAddress, "ReturnValue");
		MatchesWildcard_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesWildcard_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MatchesWildcard_IsValid = MatchesWildcard_FunctionAddress != IntPtr.Zero && MatchesWildcard_SourceString_IsValid && MatchesWildcard_Wildcard_IsValid && MatchesWildcard_SearchCase_IsValid && MatchesWildcard_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:MatchesWildcard", MatchesWildcard_IsValid);
		Len_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Len");
		Len_ParamsSize = NativeReflection.GetFunctionParamsSize(Len_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Len_S_PropertyAddress, Len_FunctionAddress, "S");
		Len_S_Offset = NativeReflectionCached.GetPropertyOffset(Len_FunctionAddress, "S");
		Len_S_IsValid = NativeReflectionCached.ValidatePropertyClass(Len_FunctionAddress, "S", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Len_ReturnValue_PropertyAddress, Len_FunctionAddress, "ReturnValue");
		Len_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Len_FunctionAddress, "ReturnValue");
		Len_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Len_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Len_IsValid = Len_FunctionAddress != IntPtr.Zero && Len_S_IsValid && Len_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Len", Len_IsValid);
		LeftPad_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LeftPad");
		LeftPad_ParamsSize = NativeReflection.GetFunctionParamsSize(LeftPad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LeftPad_SourceString_PropertyAddress, LeftPad_FunctionAddress, "SourceString");
		LeftPad_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(LeftPad_FunctionAddress, "SourceString");
		LeftPad_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftPad_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LeftPad_ChCount_PropertyAddress, LeftPad_FunctionAddress, "ChCount");
		LeftPad_ChCount_Offset = NativeReflectionCached.GetPropertyOffset(LeftPad_FunctionAddress, "ChCount");
		LeftPad_ChCount_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftPad_FunctionAddress, "ChCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LeftPad_ReturnValue_PropertyAddress, LeftPad_FunctionAddress, "ReturnValue");
		LeftPad_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LeftPad_FunctionAddress, "ReturnValue");
		LeftPad_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftPad_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		LeftPad_IsValid = LeftPad_FunctionAddress != IntPtr.Zero && LeftPad_SourceString_IsValid && LeftPad_ChCount_IsValid && LeftPad_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:LeftPad", LeftPad_IsValid);
		LeftChop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LeftChop");
		LeftChop_ParamsSize = NativeReflection.GetFunctionParamsSize(LeftChop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LeftChop_SourceString_PropertyAddress, LeftChop_FunctionAddress, "SourceString");
		LeftChop_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(LeftChop_FunctionAddress, "SourceString");
		LeftChop_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftChop_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LeftChop_Count_PropertyAddress, LeftChop_FunctionAddress, "Count");
		LeftChop_Count_Offset = NativeReflectionCached.GetPropertyOffset(LeftChop_FunctionAddress, "Count");
		LeftChop_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftChop_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LeftChop_ReturnValue_PropertyAddress, LeftChop_FunctionAddress, "ReturnValue");
		LeftChop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LeftChop_FunctionAddress, "ReturnValue");
		LeftChop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LeftChop_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		LeftChop_IsValid = LeftChop_FunctionAddress != IntPtr.Zero && LeftChop_SourceString_IsValid && LeftChop_Count_IsValid && LeftChop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:LeftChop", LeftChop_IsValid);
		Left_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Left");
		Left_ParamsSize = NativeReflection.GetFunctionParamsSize(Left_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Left_SourceString_PropertyAddress, Left_FunctionAddress, "SourceString");
		Left_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(Left_FunctionAddress, "SourceString");
		Left_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(Left_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Left_Count_PropertyAddress, Left_FunctionAddress, "Count");
		Left_Count_Offset = NativeReflectionCached.GetPropertyOffset(Left_FunctionAddress, "Count");
		Left_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(Left_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Left_ReturnValue_PropertyAddress, Left_FunctionAddress, "ReturnValue");
		Left_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Left_FunctionAddress, "ReturnValue");
		Left_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Left_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Left_IsValid = Left_FunctionAddress != IntPtr.Zero && Left_SourceString_IsValid && Left_Count_IsValid && Left_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Left", Left_IsValid);
		JoinStringArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "JoinStringArray");
		JoinStringArray_ParamsSize = NativeReflection.GetFunctionParamsSize(JoinStringArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JoinStringArray_SourceArray_PropertyAddress, JoinStringArray_FunctionAddress, "SourceArray");
		JoinStringArray_SourceArray_Offset = NativeReflectionCached.GetPropertyOffset(JoinStringArray_FunctionAddress, "SourceArray");
		JoinStringArray_SourceArray_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStringArray_FunctionAddress, "SourceArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinStringArray_Separator_PropertyAddress, JoinStringArray_FunctionAddress, "Separator");
		JoinStringArray_Separator_Offset = NativeReflectionCached.GetPropertyOffset(JoinStringArray_FunctionAddress, "Separator");
		JoinStringArray_Separator_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStringArray_FunctionAddress, "Separator", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinStringArray_ReturnValue_PropertyAddress, JoinStringArray_FunctionAddress, "ReturnValue");
		JoinStringArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JoinStringArray_FunctionAddress, "ReturnValue");
		JoinStringArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinStringArray_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		JoinStringArray_IsValid = JoinStringArray_FunctionAddress != IntPtr.Zero && JoinStringArray_SourceArray_IsValid && JoinStringArray_Separator_IsValid && JoinStringArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:JoinStringArray", JoinStringArray_IsValid);
		IsNumeric_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNumeric");
		IsNumeric_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNumeric_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNumeric_SourceString_PropertyAddress, IsNumeric_FunctionAddress, "SourceString");
		IsNumeric_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(IsNumeric_FunctionAddress, "SourceString");
		IsNumeric_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNumeric_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNumeric_ReturnValue_PropertyAddress, IsNumeric_FunctionAddress, "ReturnValue");
		IsNumeric_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNumeric_FunctionAddress, "ReturnValue");
		IsNumeric_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNumeric_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNumeric_IsValid = IsNumeric_FunctionAddress != IntPtr.Zero && IsNumeric_SourceString_IsValid && IsNumeric_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:IsNumeric", IsNumeric_IsValid);
		IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEmpty");
		IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEmpty_InString_PropertyAddress, IsEmpty_FunctionAddress, "InString");
		IsEmpty_InString_Offset = NativeReflectionCached.GetPropertyOffset(IsEmpty_FunctionAddress, "InString");
		IsEmpty_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEmpty_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEmpty_ReturnValue_PropertyAddress, IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEmpty_IsValid = IsEmpty_FunctionAddress != IntPtr.Zero && IsEmpty_InString_IsValid && IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:IsEmpty", IsEmpty_IsValid);
		GetSubstring_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubstring");
		GetSubstring_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubstring_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubstring_SourceString_PropertyAddress, GetSubstring_FunctionAddress, "SourceString");
		GetSubstring_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(GetSubstring_FunctionAddress, "SourceString");
		GetSubstring_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubstring_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubstring_StartIndex_PropertyAddress, GetSubstring_FunctionAddress, "StartIndex");
		GetSubstring_StartIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSubstring_FunctionAddress, "StartIndex");
		GetSubstring_StartIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubstring_FunctionAddress, "StartIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubstring_Length_PropertyAddress, GetSubstring_FunctionAddress, "Length");
		GetSubstring_Length_Offset = NativeReflectionCached.GetPropertyOffset(GetSubstring_FunctionAddress, "Length");
		GetSubstring_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubstring_FunctionAddress, "Length", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubstring_ReturnValue_PropertyAddress, GetSubstring_FunctionAddress, "ReturnValue");
		GetSubstring_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubstring_FunctionAddress, "ReturnValue");
		GetSubstring_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubstring_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSubstring_IsValid = GetSubstring_FunctionAddress != IntPtr.Zero && GetSubstring_SourceString_IsValid && GetSubstring_StartIndex_IsValid && GetSubstring_Length_IsValid && GetSubstring_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:GetSubstring", GetSubstring_IsValid);
		GetCharacterAsNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCharacterAsNumber");
		GetCharacterAsNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCharacterAsNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterAsNumber_SourceString_PropertyAddress, GetCharacterAsNumber_FunctionAddress, "SourceString");
		GetCharacterAsNumber_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterAsNumber_FunctionAddress, "SourceString");
		GetCharacterAsNumber_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterAsNumber_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterAsNumber_Index_PropertyAddress, GetCharacterAsNumber_FunctionAddress, "Index");
		GetCharacterAsNumber_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterAsNumber_FunctionAddress, "Index");
		GetCharacterAsNumber_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterAsNumber_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterAsNumber_ReturnValue_PropertyAddress, GetCharacterAsNumber_FunctionAddress, "ReturnValue");
		GetCharacterAsNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterAsNumber_FunctionAddress, "ReturnValue");
		GetCharacterAsNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterAsNumber_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCharacterAsNumber_IsValid = GetCharacterAsNumber_FunctionAddress != IntPtr.Zero && GetCharacterAsNumber_SourceString_IsValid && GetCharacterAsNumber_Index_IsValid && GetCharacterAsNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:GetCharacterAsNumber", GetCharacterAsNumber_IsValid);
		GetCharacterArrayFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCharacterArrayFromString");
		GetCharacterArrayFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCharacterArrayFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterArrayFromString_SourceString_PropertyAddress, GetCharacterArrayFromString_FunctionAddress, "SourceString");
		GetCharacterArrayFromString_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterArrayFromString_FunctionAddress, "SourceString");
		GetCharacterArrayFromString_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterArrayFromString_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCharacterArrayFromString_ReturnValue_PropertyAddress, GetCharacterArrayFromString_FunctionAddress, "ReturnValue");
		GetCharacterArrayFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCharacterArrayFromString_FunctionAddress, "ReturnValue");
		GetCharacterArrayFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCharacterArrayFromString_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCharacterArrayFromString_IsValid = GetCharacterArrayFromString_FunctionAddress != IntPtr.Zero && GetCharacterArrayFromString_SourceString_IsValid && GetCharacterArrayFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:GetCharacterArrayFromString", GetCharacterArrayFromString_IsValid);
		FindSubstring_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindSubstring");
		FindSubstring_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSubstring_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_SearchIn_PropertyAddress, FindSubstring_FunctionAddress, "SearchIn");
		FindSubstring_SearchIn_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "SearchIn");
		FindSubstring_SearchIn_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "SearchIn", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_Substring_PropertyAddress, FindSubstring_FunctionAddress, "Substring");
		FindSubstring_Substring_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "Substring");
		FindSubstring_Substring_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "Substring", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_bUseCase_PropertyAddress, FindSubstring_FunctionAddress, "bUseCase");
		FindSubstring_bUseCase_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "bUseCase");
		FindSubstring_bUseCase_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "bUseCase", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_bSearchFromEnd_PropertyAddress, FindSubstring_FunctionAddress, "bSearchFromEnd");
		FindSubstring_bSearchFromEnd_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "bSearchFromEnd");
		FindSubstring_bSearchFromEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "bSearchFromEnd", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_StartPosition_PropertyAddress, FindSubstring_FunctionAddress, "StartPosition");
		FindSubstring_StartPosition_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "StartPosition");
		FindSubstring_StartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "StartPosition", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSubstring_ReturnValue_PropertyAddress, FindSubstring_FunctionAddress, "ReturnValue");
		FindSubstring_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSubstring_FunctionAddress, "ReturnValue");
		FindSubstring_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSubstring_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindSubstring_IsValid = FindSubstring_FunctionAddress != IntPtr.Zero && FindSubstring_SearchIn_IsValid && FindSubstring_Substring_IsValid && FindSubstring_bUseCase_IsValid && FindSubstring_bSearchFromEnd_IsValid && FindSubstring_StartPosition_IsValid && FindSubstring_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:FindSubstring", FindSubstring_IsValid);
		EqualEqual_StrStr_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_StrStr");
		EqualEqual_StrStr_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_StrStr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StrStr_A_PropertyAddress, EqualEqual_StrStr_FunctionAddress, "A");
		EqualEqual_StrStr_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StrStr_FunctionAddress, "A");
		EqualEqual_StrStr_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StrStr_FunctionAddress, "A", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StrStr_B_PropertyAddress, EqualEqual_StrStr_FunctionAddress, "B");
		EqualEqual_StrStr_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StrStr_FunctionAddress, "B");
		EqualEqual_StrStr_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StrStr_FunctionAddress, "B", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StrStr_ReturnValue_PropertyAddress, EqualEqual_StrStr_FunctionAddress, "ReturnValue");
		EqualEqual_StrStr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StrStr_FunctionAddress, "ReturnValue");
		EqualEqual_StrStr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StrStr_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_StrStr_IsValid = EqualEqual_StrStr_FunctionAddress != IntPtr.Zero && EqualEqual_StrStr_A_IsValid && EqualEqual_StrStr_B_IsValid && EqualEqual_StrStr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:EqualEqual_StrStr", EqualEqual_StrStr_IsValid);
		EqualEqual_StriStri_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_StriStri");
		EqualEqual_StriStri_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_StriStri_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StriStri_A_PropertyAddress, EqualEqual_StriStri_FunctionAddress, "A");
		EqualEqual_StriStri_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StriStri_FunctionAddress, "A");
		EqualEqual_StriStri_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StriStri_FunctionAddress, "A", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StriStri_B_PropertyAddress, EqualEqual_StriStri_FunctionAddress, "B");
		EqualEqual_StriStri_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StriStri_FunctionAddress, "B");
		EqualEqual_StriStri_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StriStri_FunctionAddress, "B", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_StriStri_ReturnValue_PropertyAddress, EqualEqual_StriStri_FunctionAddress, "ReturnValue");
		EqualEqual_StriStri_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_StriStri_FunctionAddress, "ReturnValue");
		EqualEqual_StriStri_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_StriStri_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_StriStri_IsValid = EqualEqual_StriStri_FunctionAddress != IntPtr.Zero && EqualEqual_StriStri_A_IsValid && EqualEqual_StriStri_B_IsValid && EqualEqual_StriStri_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:EqualEqual_StriStri", EqualEqual_StriStri_IsValid);
		EndsWith_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndsWith");
		EndsWith_ParamsSize = NativeReflection.GetFunctionParamsSize(EndsWith_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndsWith_SourceString_PropertyAddress, EndsWith_FunctionAddress, "SourceString");
		EndsWith_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(EndsWith_FunctionAddress, "SourceString");
		EndsWith_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(EndsWith_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EndsWith_InSuffix_PropertyAddress, EndsWith_FunctionAddress, "InSuffix");
		EndsWith_InSuffix_Offset = NativeReflectionCached.GetPropertyOffset(EndsWith_FunctionAddress, "InSuffix");
		EndsWith_InSuffix_IsValid = NativeReflectionCached.ValidatePropertyClass(EndsWith_FunctionAddress, "InSuffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EndsWith_SearchCase_PropertyAddress, EndsWith_FunctionAddress, "SearchCase");
		EndsWith_SearchCase_Offset = NativeReflectionCached.GetPropertyOffset(EndsWith_FunctionAddress, "SearchCase");
		EndsWith_SearchCase_IsValid = NativeReflectionCached.ValidatePropertyClass(EndsWith_FunctionAddress, "SearchCase", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EndsWith_ReturnValue_PropertyAddress, EndsWith_FunctionAddress, "ReturnValue");
		EndsWith_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EndsWith_FunctionAddress, "ReturnValue");
		EndsWith_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EndsWith_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EndsWith_IsValid = EndsWith_FunctionAddress != IntPtr.Zero && EndsWith_SourceString_IsValid && EndsWith_InSuffix_IsValid && EndsWith_SearchCase_IsValid && EndsWith_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:EndsWith", EndsWith_IsValid);
		CullArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CullArray");
		CullArray_ParamsSize = NativeReflection.GetFunctionParamsSize(CullArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CullArray_SourceString_PropertyAddress, CullArray_FunctionAddress, "SourceString");
		CullArray_SourceString_Offset = NativeReflectionCached.GetPropertyOffset(CullArray_FunctionAddress, "SourceString");
		CullArray_SourceString_IsValid = NativeReflectionCached.ValidatePropertyClass(CullArray_FunctionAddress, "SourceString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CullArray_InArray_PropertyAddress, CullArray_FunctionAddress, "InArray");
		CullArray_InArray_Offset = NativeReflectionCached.GetPropertyOffset(CullArray_FunctionAddress, "InArray");
		CullArray_InArray_IsValid = NativeReflectionCached.ValidatePropertyClass(CullArray_FunctionAddress, "InArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CullArray_ReturnValue_PropertyAddress, CullArray_FunctionAddress, "ReturnValue");
		CullArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CullArray_FunctionAddress, "ReturnValue");
		CullArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CullArray_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CullArray_IsValid = CullArray_FunctionAddress != IntPtr.Zero && CullArray_SourceString_IsValid && CullArray_InArray_IsValid && CullArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:CullArray", CullArray_IsValid);
		Conv_VectorToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_VectorToString");
		Conv_VectorToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_VectorToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_VectorToString_InVec_PropertyAddress, Conv_VectorToString_FunctionAddress, "InVec");
		Conv_VectorToString_InVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_VectorToString_FunctionAddress, "InVec");
		Conv_VectorToString_InVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_VectorToString_FunctionAddress, "InVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_VectorToString_ReturnValue_PropertyAddress, Conv_VectorToString_FunctionAddress, "ReturnValue");
		Conv_VectorToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_VectorToString_FunctionAddress, "ReturnValue");
		Conv_VectorToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_VectorToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_VectorToString_IsValid = Conv_VectorToString_FunctionAddress != IntPtr.Zero && Conv_VectorToString_InVec_IsValid && Conv_VectorToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_VectorToString", Conv_VectorToString_IsValid);
		Conv_Vector3fToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_Vector3fToString");
		Conv_Vector3fToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_Vector3fToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector3fToString_InVec_PropertyAddress, Conv_Vector3fToString_FunctionAddress, "InVec");
		Conv_Vector3fToString_InVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector3fToString_FunctionAddress, "InVec");
		Conv_Vector3fToString_InVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector3fToString_FunctionAddress, "InVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector3fToString_ReturnValue_PropertyAddress, Conv_Vector3fToString_FunctionAddress, "ReturnValue");
		Conv_Vector3fToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector3fToString_FunctionAddress, "ReturnValue");
		Conv_Vector3fToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector3fToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_Vector3fToString_IsValid = Conv_Vector3fToString_FunctionAddress != IntPtr.Zero && Conv_Vector3fToString_InVec_IsValid && Conv_Vector3fToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_Vector3fToString", Conv_Vector3fToString_IsValid);
		Conv_Vector2dToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_Vector2dToString");
		Conv_Vector2dToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_Vector2dToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector2dToString_InVec_PropertyAddress, Conv_Vector2dToString_FunctionAddress, "InVec");
		Conv_Vector2dToString_InVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector2dToString_FunctionAddress, "InVec");
		Conv_Vector2dToString_InVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector2dToString_FunctionAddress, "InVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_Vector2dToString_ReturnValue_PropertyAddress, Conv_Vector2dToString_FunctionAddress, "ReturnValue");
		Conv_Vector2dToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Vector2dToString_FunctionAddress, "ReturnValue");
		Conv_Vector2dToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Vector2dToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_Vector2dToString_IsValid = Conv_Vector2dToString_FunctionAddress != IntPtr.Zero && Conv_Vector2dToString_InVec_IsValid && Conv_Vector2dToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_Vector2dToString", Conv_Vector2dToString_IsValid);
		Conv_TransformToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_TransformToString");
		Conv_TransformToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_TransformToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_TransformToString_InTrans_PropertyAddress, Conv_TransformToString_FunctionAddress, "InTrans");
		Conv_TransformToString_InTrans_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TransformToString_FunctionAddress, "InTrans");
		Conv_TransformToString_InTrans_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TransformToString_FunctionAddress, "InTrans", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_TransformToString_ReturnValue_PropertyAddress, Conv_TransformToString_FunctionAddress, "ReturnValue");
		Conv_TransformToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TransformToString_FunctionAddress, "ReturnValue");
		Conv_TransformToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TransformToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_TransformToString_IsValid = Conv_TransformToString_FunctionAddress != IntPtr.Zero && Conv_TransformToString_InTrans_IsValid && Conv_TransformToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_TransformToString", Conv_TransformToString_IsValid);
		Conv_StringToVector3f_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToVector3f");
		Conv_StringToVector3f_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToVector3f_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector3f_InString_PropertyAddress, Conv_StringToVector3f_FunctionAddress, "InString");
		Conv_StringToVector3f_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector3f_FunctionAddress, "InString");
		Conv_StringToVector3f_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector3f_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector3f_OutConvertedVector_PropertyAddress, Conv_StringToVector3f_FunctionAddress, "OutConvertedVector");
		Conv_StringToVector3f_OutConvertedVector_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector3f_FunctionAddress, "OutConvertedVector");
		Conv_StringToVector3f_OutConvertedVector_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector3f_FunctionAddress, "OutConvertedVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector3f_OutIsValid_PropertyAddress, Conv_StringToVector3f_FunctionAddress, "OutIsValid");
		Conv_StringToVector3f_OutIsValid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector3f_FunctionAddress, "OutIsValid");
		Conv_StringToVector3f_OutIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector3f_FunctionAddress, "OutIsValid", Classes.FBoolProperty);
		Conv_StringToVector3f_IsValid = Conv_StringToVector3f_FunctionAddress != IntPtr.Zero && Conv_StringToVector3f_InString_IsValid && Conv_StringToVector3f_OutConvertedVector_IsValid && Conv_StringToVector3f_OutIsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToVector3f", Conv_StringToVector3f_IsValid);
		Conv_StringToVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToVector2D");
		Conv_StringToVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector2D_InString_PropertyAddress, Conv_StringToVector2D_FunctionAddress, "InString");
		Conv_StringToVector2D_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector2D_FunctionAddress, "InString");
		Conv_StringToVector2D_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector2D_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector2D_OutConvertedVector2D_PropertyAddress, Conv_StringToVector2D_FunctionAddress, "OutConvertedVector2D");
		Conv_StringToVector2D_OutConvertedVector2D_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector2D_FunctionAddress, "OutConvertedVector2D");
		Conv_StringToVector2D_OutConvertedVector2D_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector2D_FunctionAddress, "OutConvertedVector2D", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector2D_OutIsValid_PropertyAddress, Conv_StringToVector2D_FunctionAddress, "OutIsValid");
		Conv_StringToVector2D_OutIsValid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector2D_FunctionAddress, "OutIsValid");
		Conv_StringToVector2D_OutIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector2D_FunctionAddress, "OutIsValid", Classes.FBoolProperty);
		Conv_StringToVector2D_IsValid = Conv_StringToVector2D_FunctionAddress != IntPtr.Zero && Conv_StringToVector2D_InString_IsValid && Conv_StringToVector2D_OutConvertedVector2D_IsValid && Conv_StringToVector2D_OutIsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToVector2D", Conv_StringToVector2D_IsValid);
		Conv_StringToVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToVector");
		Conv_StringToVector_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector_InString_PropertyAddress, Conv_StringToVector_FunctionAddress, "InString");
		Conv_StringToVector_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector_FunctionAddress, "InString");
		Conv_StringToVector_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector_OutConvertedVector_PropertyAddress, Conv_StringToVector_FunctionAddress, "OutConvertedVector");
		Conv_StringToVector_OutConvertedVector_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector_FunctionAddress, "OutConvertedVector");
		Conv_StringToVector_OutConvertedVector_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector_FunctionAddress, "OutConvertedVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToVector_OutIsValid_PropertyAddress, Conv_StringToVector_FunctionAddress, "OutIsValid");
		Conv_StringToVector_OutIsValid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToVector_FunctionAddress, "OutIsValid");
		Conv_StringToVector_OutIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToVector_FunctionAddress, "OutIsValid", Classes.FBoolProperty);
		Conv_StringToVector_IsValid = Conv_StringToVector_FunctionAddress != IntPtr.Zero && Conv_StringToVector_InString_IsValid && Conv_StringToVector_OutConvertedVector_IsValid && Conv_StringToVector_OutIsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToVector", Conv_StringToVector_IsValid);
		Conv_StringToRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToRotator");
		Conv_StringToRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToRotator_InString_PropertyAddress, Conv_StringToRotator_FunctionAddress, "InString");
		Conv_StringToRotator_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToRotator_FunctionAddress, "InString");
		Conv_StringToRotator_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToRotator_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToRotator_OutConvertedRotator_PropertyAddress, Conv_StringToRotator_FunctionAddress, "OutConvertedRotator");
		Conv_StringToRotator_OutConvertedRotator_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToRotator_FunctionAddress, "OutConvertedRotator");
		Conv_StringToRotator_OutConvertedRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToRotator_FunctionAddress, "OutConvertedRotator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToRotator_OutIsValid_PropertyAddress, Conv_StringToRotator_FunctionAddress, "OutIsValid");
		Conv_StringToRotator_OutIsValid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToRotator_FunctionAddress, "OutIsValid");
		Conv_StringToRotator_OutIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToRotator_FunctionAddress, "OutIsValid", Classes.FBoolProperty);
		Conv_StringToRotator_IsValid = Conv_StringToRotator_FunctionAddress != IntPtr.Zero && Conv_StringToRotator_InString_IsValid && Conv_StringToRotator_OutConvertedRotator_IsValid && Conv_StringToRotator_OutIsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToRotator", Conv_StringToRotator_IsValid);
		Conv_StringToName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToName");
		Conv_StringToName_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToName_InString_PropertyAddress, Conv_StringToName_FunctionAddress, "InString");
		Conv_StringToName_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToName_FunctionAddress, "InString");
		Conv_StringToName_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToName_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToName_ReturnValue_PropertyAddress, Conv_StringToName_FunctionAddress, "ReturnValue");
		Conv_StringToName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToName_FunctionAddress, "ReturnValue");
		Conv_StringToName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		Conv_StringToName_IsValid = Conv_StringToName_FunctionAddress != IntPtr.Zero && Conv_StringToName_InString_IsValid && Conv_StringToName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToName", Conv_StringToName_IsValid);
		Conv_StringToInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToInt");
		Conv_StringToInt_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToInt_InString_PropertyAddress, Conv_StringToInt_FunctionAddress, "InString");
		Conv_StringToInt_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToInt_FunctionAddress, "InString");
		Conv_StringToInt_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToInt_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToInt_ReturnValue_PropertyAddress, Conv_StringToInt_FunctionAddress, "ReturnValue");
		Conv_StringToInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToInt_FunctionAddress, "ReturnValue");
		Conv_StringToInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Conv_StringToInt_IsValid = Conv_StringToInt_FunctionAddress != IntPtr.Zero && Conv_StringToInt_InString_IsValid && Conv_StringToInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToInt", Conv_StringToInt_IsValid);
		Conv_StringToDouble_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToDouble");
		Conv_StringToDouble_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToDouble_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToDouble_InString_PropertyAddress, Conv_StringToDouble_FunctionAddress, "InString");
		Conv_StringToDouble_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToDouble_FunctionAddress, "InString");
		Conv_StringToDouble_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToDouble_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToDouble_ReturnValue_PropertyAddress, Conv_StringToDouble_FunctionAddress, "ReturnValue");
		Conv_StringToDouble_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToDouble_FunctionAddress, "ReturnValue");
		Conv_StringToDouble_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToDouble_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		Conv_StringToDouble_IsValid = Conv_StringToDouble_FunctionAddress != IntPtr.Zero && Conv_StringToDouble_InString_IsValid && Conv_StringToDouble_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToDouble", Conv_StringToDouble_IsValid);
		Conv_StringToColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_StringToColor");
		Conv_StringToColor_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_StringToColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToColor_InString_PropertyAddress, Conv_StringToColor_FunctionAddress, "InString");
		Conv_StringToColor_InString_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToColor_FunctionAddress, "InString");
		Conv_StringToColor_InString_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToColor_FunctionAddress, "InString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToColor_OutConvertedColor_PropertyAddress, Conv_StringToColor_FunctionAddress, "OutConvertedColor");
		Conv_StringToColor_OutConvertedColor_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToColor_FunctionAddress, "OutConvertedColor");
		Conv_StringToColor_OutConvertedColor_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToColor_FunctionAddress, "OutConvertedColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_StringToColor_OutIsValid_PropertyAddress, Conv_StringToColor_FunctionAddress, "OutIsValid");
		Conv_StringToColor_OutIsValid_Offset = NativeReflectionCached.GetPropertyOffset(Conv_StringToColor_FunctionAddress, "OutIsValid");
		Conv_StringToColor_OutIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_StringToColor_FunctionAddress, "OutIsValid", Classes.FBoolProperty);
		Conv_StringToColor_IsValid = Conv_StringToColor_FunctionAddress != IntPtr.Zero && Conv_StringToColor_InString_IsValid && Conv_StringToColor_OutConvertedColor_IsValid && Conv_StringToColor_OutIsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_StringToColor", Conv_StringToColor_IsValid);
		Conv_RotatorToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_RotatorToString");
		Conv_RotatorToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_RotatorToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_RotatorToString_InRot_PropertyAddress, Conv_RotatorToString_FunctionAddress, "InRot");
		Conv_RotatorToString_InRot_Offset = NativeReflectionCached.GetPropertyOffset(Conv_RotatorToString_FunctionAddress, "InRot");
		Conv_RotatorToString_InRot_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_RotatorToString_FunctionAddress, "InRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_RotatorToString_ReturnValue_PropertyAddress, Conv_RotatorToString_FunctionAddress, "ReturnValue");
		Conv_RotatorToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_RotatorToString_FunctionAddress, "ReturnValue");
		Conv_RotatorToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_RotatorToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_RotatorToString_IsValid = Conv_RotatorToString_FunctionAddress != IntPtr.Zero && Conv_RotatorToString_InRot_IsValid && Conv_RotatorToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_RotatorToString", Conv_RotatorToString_IsValid);
		Conv_ObjectToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ObjectToString");
		Conv_ObjectToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ObjectToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ObjectToString_InObj_PropertyAddress, Conv_ObjectToString_FunctionAddress, "InObj");
		Conv_ObjectToString_InObj_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ObjectToString_FunctionAddress, "InObj");
		Conv_ObjectToString_InObj_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ObjectToString_FunctionAddress, "InObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ObjectToString_ReturnValue_PropertyAddress, Conv_ObjectToString_FunctionAddress, "ReturnValue");
		Conv_ObjectToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ObjectToString_FunctionAddress, "ReturnValue");
		Conv_ObjectToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ObjectToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_ObjectToString_IsValid = Conv_ObjectToString_FunctionAddress != IntPtr.Zero && Conv_ObjectToString_InObj_IsValid && Conv_ObjectToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_ObjectToString", Conv_ObjectToString_IsValid);
		Conv_NameToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_NameToString");
		Conv_NameToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_NameToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_NameToString_InName_PropertyAddress, Conv_NameToString_FunctionAddress, "InName");
		Conv_NameToString_InName_Offset = NativeReflectionCached.GetPropertyOffset(Conv_NameToString_FunctionAddress, "InName");
		Conv_NameToString_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_NameToString_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_NameToString_ReturnValue_PropertyAddress, Conv_NameToString_FunctionAddress, "ReturnValue");
		Conv_NameToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_NameToString_FunctionAddress, "ReturnValue");
		Conv_NameToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_NameToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_NameToString_IsValid = Conv_NameToString_FunctionAddress != IntPtr.Zero && Conv_NameToString_InName_IsValid && Conv_NameToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_NameToString", Conv_NameToString_IsValid);
		Conv_MatrixToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_MatrixToString");
		Conv_MatrixToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_MatrixToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_MatrixToString_InMatrix_PropertyAddress, Conv_MatrixToString_FunctionAddress, "InMatrix");
		Conv_MatrixToString_InMatrix_Offset = NativeReflectionCached.GetPropertyOffset(Conv_MatrixToString_FunctionAddress, "InMatrix");
		Conv_MatrixToString_InMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_MatrixToString_FunctionAddress, "InMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_MatrixToString_ReturnValue_PropertyAddress, Conv_MatrixToString_FunctionAddress, "ReturnValue");
		Conv_MatrixToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_MatrixToString_FunctionAddress, "ReturnValue");
		Conv_MatrixToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_MatrixToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_MatrixToString_IsValid = Conv_MatrixToString_FunctionAddress != IntPtr.Zero && Conv_MatrixToString_InMatrix_IsValid && Conv_MatrixToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_MatrixToString", Conv_MatrixToString_IsValid);
		Conv_IntVectorToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_IntVectorToString");
		Conv_IntVectorToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_IntVectorToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntVectorToString_InIntVec_PropertyAddress, Conv_IntVectorToString_FunctionAddress, "InIntVec");
		Conv_IntVectorToString_InIntVec_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntVectorToString_FunctionAddress, "InIntVec");
		Conv_IntVectorToString_InIntVec_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntVectorToString_FunctionAddress, "InIntVec", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntVectorToString_ReturnValue_PropertyAddress, Conv_IntVectorToString_FunctionAddress, "ReturnValue");
		Conv_IntVectorToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntVectorToString_FunctionAddress, "ReturnValue");
		Conv_IntVectorToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntVectorToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_IntVectorToString_IsValid = Conv_IntVectorToString_FunctionAddress != IntPtr.Zero && Conv_IntVectorToString_InIntVec_IsValid && Conv_IntVectorToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_IntVectorToString", Conv_IntVectorToString_IsValid);
		Conv_IntToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_IntToString");
		Conv_IntToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_IntToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToString_InInt_PropertyAddress, Conv_IntToString_FunctionAddress, "InInt");
		Conv_IntToString_InInt_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToString_FunctionAddress, "InInt");
		Conv_IntToString_InInt_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToString_FunctionAddress, "InInt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntToString_ReturnValue_PropertyAddress, Conv_IntToString_FunctionAddress, "ReturnValue");
		Conv_IntToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntToString_FunctionAddress, "ReturnValue");
		Conv_IntToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_IntToString_IsValid = Conv_IntToString_FunctionAddress != IntPtr.Zero && Conv_IntToString_InInt_IsValid && Conv_IntToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_IntToString", Conv_IntToString_IsValid);
		Conv_IntPointToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_IntPointToString");
		Conv_IntPointToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_IntPointToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntPointToString_InIntPoint_PropertyAddress, Conv_IntPointToString_FunctionAddress, "InIntPoint");
		Conv_IntPointToString_InIntPoint_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntPointToString_FunctionAddress, "InIntPoint");
		Conv_IntPointToString_InIntPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntPointToString_FunctionAddress, "InIntPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_IntPointToString_ReturnValue_PropertyAddress, Conv_IntPointToString_FunctionAddress, "ReturnValue");
		Conv_IntPointToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_IntPointToString_FunctionAddress, "ReturnValue");
		Conv_IntPointToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_IntPointToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_IntPointToString_IsValid = Conv_IntPointToString_FunctionAddress != IntPtr.Zero && Conv_IntPointToString_InIntPoint_IsValid && Conv_IntPointToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_IntPointToString", Conv_IntPointToString_IsValid);
		Conv_Int64ToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_Int64ToString");
		Conv_Int64ToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_Int64ToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToString_InInt_PropertyAddress, Conv_Int64ToString_FunctionAddress, "InInt");
		Conv_Int64ToString_InInt_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToString_FunctionAddress, "InInt");
		Conv_Int64ToString_InInt_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToString_FunctionAddress, "InInt", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref Conv_Int64ToString_ReturnValue_PropertyAddress, Conv_Int64ToString_FunctionAddress, "ReturnValue");
		Conv_Int64ToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_Int64ToString_FunctionAddress, "ReturnValue");
		Conv_Int64ToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_Int64ToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_Int64ToString_IsValid = Conv_Int64ToString_FunctionAddress != IntPtr.Zero && Conv_Int64ToString_InInt_IsValid && Conv_Int64ToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_Int64ToString", Conv_Int64ToString_IsValid);
		Conv_DoubleToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_DoubleToString");
		Conv_DoubleToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_DoubleToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToString_InDouble_PropertyAddress, Conv_DoubleToString_FunctionAddress, "InDouble");
		Conv_DoubleToString_InDouble_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToString_FunctionAddress, "InDouble");
		Conv_DoubleToString_InDouble_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToString_FunctionAddress, "InDouble", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_DoubleToString_ReturnValue_PropertyAddress, Conv_DoubleToString_FunctionAddress, "ReturnValue");
		Conv_DoubleToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_DoubleToString_FunctionAddress, "ReturnValue");
		Conv_DoubleToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_DoubleToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_DoubleToString_IsValid = Conv_DoubleToString_FunctionAddress != IntPtr.Zero && Conv_DoubleToString_InDouble_IsValid && Conv_DoubleToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_DoubleToString", Conv_DoubleToString_IsValid);
		Conv_ColorToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ColorToString");
		Conv_ColorToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ColorToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ColorToString_InColor_PropertyAddress, Conv_ColorToString_FunctionAddress, "InColor");
		Conv_ColorToString_InColor_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ColorToString_FunctionAddress, "InColor");
		Conv_ColorToString_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ColorToString_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ColorToString_ReturnValue_PropertyAddress, Conv_ColorToString_FunctionAddress, "ReturnValue");
		Conv_ColorToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ColorToString_FunctionAddress, "ReturnValue");
		Conv_ColorToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ColorToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_ColorToString_IsValid = Conv_ColorToString_FunctionAddress != IntPtr.Zero && Conv_ColorToString_InColor_IsValid && Conv_ColorToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_ColorToString", Conv_ColorToString_IsValid);
		Conv_ByteToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_ByteToString");
		Conv_ByteToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_ByteToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_ByteToString_InByte_PropertyAddress, Conv_ByteToString_FunctionAddress, "InByte");
		Conv_ByteToString_InByte_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ByteToString_FunctionAddress, "InByte");
		Conv_ByteToString_InByte_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ByteToString_FunctionAddress, "InByte", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_ByteToString_ReturnValue_PropertyAddress, Conv_ByteToString_FunctionAddress, "ReturnValue");
		Conv_ByteToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_ByteToString_FunctionAddress, "ReturnValue");
		Conv_ByteToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_ByteToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_ByteToString_IsValid = Conv_ByteToString_FunctionAddress != IntPtr.Zero && Conv_ByteToString_InByte_IsValid && Conv_ByteToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_ByteToString", Conv_ByteToString_IsValid);
		Conv_BoolToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_BoolToString");
		Conv_BoolToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_BoolToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_BoolToString_InBool_PropertyAddress, Conv_BoolToString_FunctionAddress, "InBool");
		Conv_BoolToString_InBool_Offset = NativeReflectionCached.GetPropertyOffset(Conv_BoolToString_FunctionAddress, "InBool");
		Conv_BoolToString_InBool_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_BoolToString_FunctionAddress, "InBool", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_BoolToString_ReturnValue_PropertyAddress, Conv_BoolToString_FunctionAddress, "ReturnValue");
		Conv_BoolToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_BoolToString_FunctionAddress, "ReturnValue");
		Conv_BoolToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_BoolToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_BoolToString_IsValid = Conv_BoolToString_FunctionAddress != IntPtr.Zero && Conv_BoolToString_InBool_IsValid && Conv_BoolToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Conv_BoolToString", Conv_BoolToString_IsValid);
		Contains_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Contains");
		Contains_ParamsSize = NativeReflection.GetFunctionParamsSize(Contains_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Contains_SearchIn_PropertyAddress, Contains_FunctionAddress, "SearchIn");
		Contains_SearchIn_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "SearchIn");
		Contains_SearchIn_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "SearchIn", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Contains_Substring_PropertyAddress, Contains_FunctionAddress, "Substring");
		Contains_Substring_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "Substring");
		Contains_Substring_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "Substring", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Contains_bUseCase_PropertyAddress, Contains_FunctionAddress, "bUseCase");
		Contains_bUseCase_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "bUseCase");
		Contains_bUseCase_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "bUseCase", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Contains_bSearchFromEnd_PropertyAddress, Contains_FunctionAddress, "bSearchFromEnd");
		Contains_bSearchFromEnd_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "bSearchFromEnd");
		Contains_bSearchFromEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "bSearchFromEnd", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Contains_ReturnValue_PropertyAddress, Contains_FunctionAddress, "ReturnValue");
		Contains_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "ReturnValue");
		Contains_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Contains_IsValid = Contains_FunctionAddress != IntPtr.Zero && Contains_SearchIn_IsValid && Contains_Substring_IsValid && Contains_bUseCase_IsValid && Contains_bSearchFromEnd_IsValid && Contains_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Contains", Contains_IsValid);
		Concat_StrStr_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Concat_StrStr");
		Concat_StrStr_ParamsSize = NativeReflection.GetFunctionParamsSize(Concat_StrStr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Concat_StrStr_A_PropertyAddress, Concat_StrStr_FunctionAddress, "A");
		Concat_StrStr_A_Offset = NativeReflectionCached.GetPropertyOffset(Concat_StrStr_FunctionAddress, "A");
		Concat_StrStr_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Concat_StrStr_FunctionAddress, "A", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Concat_StrStr_B_PropertyAddress, Concat_StrStr_FunctionAddress, "B");
		Concat_StrStr_B_Offset = NativeReflectionCached.GetPropertyOffset(Concat_StrStr_FunctionAddress, "B");
		Concat_StrStr_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Concat_StrStr_FunctionAddress, "B", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Concat_StrStr_ReturnValue_PropertyAddress, Concat_StrStr_FunctionAddress, "ReturnValue");
		Concat_StrStr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Concat_StrStr_FunctionAddress, "ReturnValue");
		Concat_StrStr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Concat_StrStr_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Concat_StrStr_IsValid = Concat_StrStr_FunctionAddress != IntPtr.Zero && Concat_StrStr_A_IsValid && Concat_StrStr_B_IsValid && Concat_StrStr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:Concat_StrStr", Concat_StrStr_IsValid);
		BuildString_Vector2d_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Vector2d");
		BuildString_Vector2d_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Vector2d_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector2d_AppendTo_PropertyAddress, BuildString_Vector2d_FunctionAddress, "AppendTo");
		BuildString_Vector2d_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector2d_FunctionAddress, "AppendTo");
		BuildString_Vector2d_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector2d_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector2d_Prefix_PropertyAddress, BuildString_Vector2d_FunctionAddress, "Prefix");
		BuildString_Vector2d_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector2d_FunctionAddress, "Prefix");
		BuildString_Vector2d_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector2d_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector2d_InVector2d_PropertyAddress, BuildString_Vector2d_FunctionAddress, "InVector2d");
		BuildString_Vector2d_InVector2d_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector2d_FunctionAddress, "InVector2d");
		BuildString_Vector2d_InVector2d_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector2d_FunctionAddress, "InVector2d", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector2d_Suffix_PropertyAddress, BuildString_Vector2d_FunctionAddress, "Suffix");
		BuildString_Vector2d_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector2d_FunctionAddress, "Suffix");
		BuildString_Vector2d_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector2d_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector2d_ReturnValue_PropertyAddress, BuildString_Vector2d_FunctionAddress, "ReturnValue");
		BuildString_Vector2d_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector2d_FunctionAddress, "ReturnValue");
		BuildString_Vector2d_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector2d_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Vector2d_IsValid = BuildString_Vector2d_FunctionAddress != IntPtr.Zero && BuildString_Vector2d_AppendTo_IsValid && BuildString_Vector2d_Prefix_IsValid && BuildString_Vector2d_InVector2d_IsValid && BuildString_Vector2d_Suffix_IsValid && BuildString_Vector2d_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Vector2d", BuildString_Vector2d_IsValid);
		BuildString_Vector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Vector");
		BuildString_Vector_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Vector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector_AppendTo_PropertyAddress, BuildString_Vector_FunctionAddress, "AppendTo");
		BuildString_Vector_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector_FunctionAddress, "AppendTo");
		BuildString_Vector_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector_Prefix_PropertyAddress, BuildString_Vector_FunctionAddress, "Prefix");
		BuildString_Vector_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector_FunctionAddress, "Prefix");
		BuildString_Vector_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector_InVector_PropertyAddress, BuildString_Vector_FunctionAddress, "InVector");
		BuildString_Vector_InVector_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector_FunctionAddress, "InVector");
		BuildString_Vector_InVector_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector_FunctionAddress, "InVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector_Suffix_PropertyAddress, BuildString_Vector_FunctionAddress, "Suffix");
		BuildString_Vector_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector_FunctionAddress, "Suffix");
		BuildString_Vector_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Vector_ReturnValue_PropertyAddress, BuildString_Vector_FunctionAddress, "ReturnValue");
		BuildString_Vector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Vector_FunctionAddress, "ReturnValue");
		BuildString_Vector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Vector_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Vector_IsValid = BuildString_Vector_FunctionAddress != IntPtr.Zero && BuildString_Vector_AppendTo_IsValid && BuildString_Vector_Prefix_IsValid && BuildString_Vector_InVector_IsValid && BuildString_Vector_Suffix_IsValid && BuildString_Vector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Vector", BuildString_Vector_IsValid);
		BuildString_Rotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Rotator");
		BuildString_Rotator_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Rotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Rotator_AppendTo_PropertyAddress, BuildString_Rotator_FunctionAddress, "AppendTo");
		BuildString_Rotator_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Rotator_FunctionAddress, "AppendTo");
		BuildString_Rotator_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Rotator_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Rotator_Prefix_PropertyAddress, BuildString_Rotator_FunctionAddress, "Prefix");
		BuildString_Rotator_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Rotator_FunctionAddress, "Prefix");
		BuildString_Rotator_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Rotator_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Rotator_InRot_PropertyAddress, BuildString_Rotator_FunctionAddress, "InRot");
		BuildString_Rotator_InRot_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Rotator_FunctionAddress, "InRot");
		BuildString_Rotator_InRot_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Rotator_FunctionAddress, "InRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Rotator_Suffix_PropertyAddress, BuildString_Rotator_FunctionAddress, "Suffix");
		BuildString_Rotator_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Rotator_FunctionAddress, "Suffix");
		BuildString_Rotator_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Rotator_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Rotator_ReturnValue_PropertyAddress, BuildString_Rotator_FunctionAddress, "ReturnValue");
		BuildString_Rotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Rotator_FunctionAddress, "ReturnValue");
		BuildString_Rotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Rotator_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Rotator_IsValid = BuildString_Rotator_FunctionAddress != IntPtr.Zero && BuildString_Rotator_AppendTo_IsValid && BuildString_Rotator_Prefix_IsValid && BuildString_Rotator_InRot_IsValid && BuildString_Rotator_Suffix_IsValid && BuildString_Rotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Rotator", BuildString_Rotator_IsValid);
		BuildString_Object_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Object");
		BuildString_Object_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Object_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Object_AppendTo_PropertyAddress, BuildString_Object_FunctionAddress, "AppendTo");
		BuildString_Object_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Object_FunctionAddress, "AppendTo");
		BuildString_Object_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Object_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Object_Prefix_PropertyAddress, BuildString_Object_FunctionAddress, "Prefix");
		BuildString_Object_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Object_FunctionAddress, "Prefix");
		BuildString_Object_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Object_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Object_InObj_PropertyAddress, BuildString_Object_FunctionAddress, "InObj");
		BuildString_Object_InObj_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Object_FunctionAddress, "InObj");
		BuildString_Object_InObj_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Object_FunctionAddress, "InObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Object_Suffix_PropertyAddress, BuildString_Object_FunctionAddress, "Suffix");
		BuildString_Object_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Object_FunctionAddress, "Suffix");
		BuildString_Object_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Object_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Object_ReturnValue_PropertyAddress, BuildString_Object_FunctionAddress, "ReturnValue");
		BuildString_Object_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Object_FunctionAddress, "ReturnValue");
		BuildString_Object_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Object_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Object_IsValid = BuildString_Object_FunctionAddress != IntPtr.Zero && BuildString_Object_AppendTo_IsValid && BuildString_Object_Prefix_IsValid && BuildString_Object_InObj_IsValid && BuildString_Object_Suffix_IsValid && BuildString_Object_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Object", BuildString_Object_IsValid);
		BuildString_Name_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Name");
		BuildString_Name_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Name_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Name_AppendTo_PropertyAddress, BuildString_Name_FunctionAddress, "AppendTo");
		BuildString_Name_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Name_FunctionAddress, "AppendTo");
		BuildString_Name_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Name_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Name_Prefix_PropertyAddress, BuildString_Name_FunctionAddress, "Prefix");
		BuildString_Name_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Name_FunctionAddress, "Prefix");
		BuildString_Name_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Name_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Name_InName_PropertyAddress, BuildString_Name_FunctionAddress, "InName");
		BuildString_Name_InName_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Name_FunctionAddress, "InName");
		BuildString_Name_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Name_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Name_Suffix_PropertyAddress, BuildString_Name_FunctionAddress, "Suffix");
		BuildString_Name_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Name_FunctionAddress, "Suffix");
		BuildString_Name_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Name_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Name_ReturnValue_PropertyAddress, BuildString_Name_FunctionAddress, "ReturnValue");
		BuildString_Name_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Name_FunctionAddress, "ReturnValue");
		BuildString_Name_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Name_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Name_IsValid = BuildString_Name_FunctionAddress != IntPtr.Zero && BuildString_Name_AppendTo_IsValid && BuildString_Name_Prefix_IsValid && BuildString_Name_InName_IsValid && BuildString_Name_Suffix_IsValid && BuildString_Name_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Name", BuildString_Name_IsValid);
		BuildString_IntVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_IntVector");
		BuildString_IntVector_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_IntVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_IntVector_AppendTo_PropertyAddress, BuildString_IntVector_FunctionAddress, "AppendTo");
		BuildString_IntVector_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_IntVector_FunctionAddress, "AppendTo");
		BuildString_IntVector_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_IntVector_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_IntVector_Prefix_PropertyAddress, BuildString_IntVector_FunctionAddress, "Prefix");
		BuildString_IntVector_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_IntVector_FunctionAddress, "Prefix");
		BuildString_IntVector_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_IntVector_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_IntVector_InIntVector_PropertyAddress, BuildString_IntVector_FunctionAddress, "InIntVector");
		BuildString_IntVector_InIntVector_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_IntVector_FunctionAddress, "InIntVector");
		BuildString_IntVector_InIntVector_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_IntVector_FunctionAddress, "InIntVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_IntVector_Suffix_PropertyAddress, BuildString_IntVector_FunctionAddress, "Suffix");
		BuildString_IntVector_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_IntVector_FunctionAddress, "Suffix");
		BuildString_IntVector_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_IntVector_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_IntVector_ReturnValue_PropertyAddress, BuildString_IntVector_FunctionAddress, "ReturnValue");
		BuildString_IntVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_IntVector_FunctionAddress, "ReturnValue");
		BuildString_IntVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_IntVector_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_IntVector_IsValid = BuildString_IntVector_FunctionAddress != IntPtr.Zero && BuildString_IntVector_AppendTo_IsValid && BuildString_IntVector_Prefix_IsValid && BuildString_IntVector_InIntVector_IsValid && BuildString_IntVector_Suffix_IsValid && BuildString_IntVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_IntVector", BuildString_IntVector_IsValid);
		BuildString_Int_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Int");
		BuildString_Int_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Int_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Int_AppendTo_PropertyAddress, BuildString_Int_FunctionAddress, "AppendTo");
		BuildString_Int_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Int_FunctionAddress, "AppendTo");
		BuildString_Int_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Int_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Int_Prefix_PropertyAddress, BuildString_Int_FunctionAddress, "Prefix");
		BuildString_Int_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Int_FunctionAddress, "Prefix");
		BuildString_Int_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Int_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Int_InInt_PropertyAddress, BuildString_Int_FunctionAddress, "InInt");
		BuildString_Int_InInt_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Int_FunctionAddress, "InInt");
		BuildString_Int_InInt_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Int_FunctionAddress, "InInt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Int_Suffix_PropertyAddress, BuildString_Int_FunctionAddress, "Suffix");
		BuildString_Int_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Int_FunctionAddress, "Suffix");
		BuildString_Int_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Int_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Int_ReturnValue_PropertyAddress, BuildString_Int_FunctionAddress, "ReturnValue");
		BuildString_Int_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Int_FunctionAddress, "ReturnValue");
		BuildString_Int_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Int_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Int_IsValid = BuildString_Int_FunctionAddress != IntPtr.Zero && BuildString_Int_AppendTo_IsValid && BuildString_Int_Prefix_IsValid && BuildString_Int_InInt_IsValid && BuildString_Int_Suffix_IsValid && BuildString_Int_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Int", BuildString_Int_IsValid);
		BuildString_Double_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Double");
		BuildString_Double_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Double_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Double_AppendTo_PropertyAddress, BuildString_Double_FunctionAddress, "AppendTo");
		BuildString_Double_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Double_FunctionAddress, "AppendTo");
		BuildString_Double_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Double_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Double_Prefix_PropertyAddress, BuildString_Double_FunctionAddress, "Prefix");
		BuildString_Double_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Double_FunctionAddress, "Prefix");
		BuildString_Double_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Double_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Double_InDouble_PropertyAddress, BuildString_Double_FunctionAddress, "InDouble");
		BuildString_Double_InDouble_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Double_FunctionAddress, "InDouble");
		BuildString_Double_InDouble_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Double_FunctionAddress, "InDouble", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Double_Suffix_PropertyAddress, BuildString_Double_FunctionAddress, "Suffix");
		BuildString_Double_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Double_FunctionAddress, "Suffix");
		BuildString_Double_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Double_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Double_ReturnValue_PropertyAddress, BuildString_Double_FunctionAddress, "ReturnValue");
		BuildString_Double_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Double_FunctionAddress, "ReturnValue");
		BuildString_Double_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Double_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Double_IsValid = BuildString_Double_FunctionAddress != IntPtr.Zero && BuildString_Double_AppendTo_IsValid && BuildString_Double_Prefix_IsValid && BuildString_Double_InDouble_IsValid && BuildString_Double_Suffix_IsValid && BuildString_Double_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Double", BuildString_Double_IsValid);
		BuildString_Color_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Color");
		BuildString_Color_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Color_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Color_AppendTo_PropertyAddress, BuildString_Color_FunctionAddress, "AppendTo");
		BuildString_Color_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Color_FunctionAddress, "AppendTo");
		BuildString_Color_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Color_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Color_Prefix_PropertyAddress, BuildString_Color_FunctionAddress, "Prefix");
		BuildString_Color_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Color_FunctionAddress, "Prefix");
		BuildString_Color_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Color_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Color_InColor_PropertyAddress, BuildString_Color_FunctionAddress, "InColor");
		BuildString_Color_InColor_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Color_FunctionAddress, "InColor");
		BuildString_Color_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Color_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Color_Suffix_PropertyAddress, BuildString_Color_FunctionAddress, "Suffix");
		BuildString_Color_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Color_FunctionAddress, "Suffix");
		BuildString_Color_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Color_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Color_ReturnValue_PropertyAddress, BuildString_Color_FunctionAddress, "ReturnValue");
		BuildString_Color_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Color_FunctionAddress, "ReturnValue");
		BuildString_Color_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Color_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Color_IsValid = BuildString_Color_FunctionAddress != IntPtr.Zero && BuildString_Color_AppendTo_IsValid && BuildString_Color_Prefix_IsValid && BuildString_Color_InColor_IsValid && BuildString_Color_Suffix_IsValid && BuildString_Color_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Color", BuildString_Color_IsValid);
		BuildString_Bool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildString_Bool");
		BuildString_Bool_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildString_Bool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Bool_AppendTo_PropertyAddress, BuildString_Bool_FunctionAddress, "AppendTo");
		BuildString_Bool_AppendTo_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Bool_FunctionAddress, "AppendTo");
		BuildString_Bool_AppendTo_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Bool_FunctionAddress, "AppendTo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Bool_Prefix_PropertyAddress, BuildString_Bool_FunctionAddress, "Prefix");
		BuildString_Bool_Prefix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Bool_FunctionAddress, "Prefix");
		BuildString_Bool_Prefix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Bool_FunctionAddress, "Prefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Bool_InBool_PropertyAddress, BuildString_Bool_FunctionAddress, "InBool");
		BuildString_Bool_InBool_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Bool_FunctionAddress, "InBool");
		BuildString_Bool_InBool_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Bool_FunctionAddress, "InBool", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Bool_Suffix_PropertyAddress, BuildString_Bool_FunctionAddress, "Suffix");
		BuildString_Bool_Suffix_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Bool_FunctionAddress, "Suffix");
		BuildString_Bool_Suffix_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Bool_FunctionAddress, "Suffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildString_Bool_ReturnValue_PropertyAddress, BuildString_Bool_FunctionAddress, "ReturnValue");
		BuildString_Bool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildString_Bool_FunctionAddress, "ReturnValue");
		BuildString_Bool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildString_Bool_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		BuildString_Bool_IsValid = BuildString_Bool_FunctionAddress != IntPtr.Zero && BuildString_Bool_AppendTo_IsValid && BuildString_Bool_Prefix_IsValid && BuildString_Bool_InBool_IsValid && BuildString_Bool_Suffix_IsValid && BuildString_Bool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetStringLibrary:BuildString_Bool", BuildString_Bool_IsValid);
	}
}
