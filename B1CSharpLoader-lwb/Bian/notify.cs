
using UnrealEngine.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using b1;
using BtlShare;
using CSharpModBase;
using BtlB1;
using Google.Protobuf.Collections;
using b1.Protobuf.DataAPI;
using UnrealEngine.Runtime;



namespace bian;

public static class NotifyUtils
{
    public static void getNotifyToJson(UAnimMontage Montage)
    {
        try
        {
            if (Montage == null || Montage?.PathName == null)
            {
                return;
            }

            TSubclassOf<UAnimNotify> notifyClass = UClass.GetClass<b1.BANS_GSAddBuffByID>();

            if (notifyClass == null)
            {
                return;
            }
        }
        catch (Exception ex)
        {
            // 记录异常信息
            System.Console.WriteLine($"Error in getNotifyToJson: {ex.Message}");
            return;
        }
    }

}
