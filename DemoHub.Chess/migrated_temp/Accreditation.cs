using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
//using CalastoneServiceReference;
//using DemoHub.Common;
//using DemoHub.Infrastructure.MessageEngine;
//using Microsoft.EntityFrameworkCore;
//using DemoHub.WebServices.MessageHandlers;
//using Amazon.SQS.Model;
using DemoHub.Common.Enums;
using static DemoHub.Common.Enums.ChessEnums;

namespace DemoHub.Chess.migrated_temp
{
    public static class Accreditation
    {
        //public static Tuple<string, string, bool>[] SendMessages(string msg, ChessEnums.MessageType tp)
        //{
        //    var result = Enum.GetName(typeof(ChessEnums.MessageType), tp) switch
        //    {
        //        "defaultType" => DefaultMethod(msg, null),
        //        _ => throw new ArgumentException($"{tp} is an invalid message type.")
        //    };

        //    return result;
        //}

        //public static Tuple<string, string, bool>[] ReceiveMessages(string msg, ChessEnums.MessageType tp)
        //{
        //    var result = Enum.GetName(typeof(ChessEnums.MessageType), tp) switch
        //    {
        //        "defaultType" => DefaultMethod(msg, null),
        //        _ => throw new ArgumentException($"{tp} is an invalid message type.")
        //    };

        //    return result;
        //}

        public static Tuple<string, string, bool>[] DefaultMethod(string msg, List<Tuple<int, bool>> abc)
        {
            //Tuple<string, string, bool>[] a = new Tuple<string, string, bool>[256];
            //abc.ForEach(i => a[i.Item1 - 1] = new Tuple<string, string, bool>(Enum.GetName(typeof(MessageField), i.Item1),
            //    SetFieldValue(msg, Enum.GetName(typeof(MessageField), i.Item1)), i.Item2));

            //a[64] = new Tuple<string, string, bool>(null, "1000000000000000", true);
            //a[128] = new Tuple<string, string, bool>(null, "1000000000000000", true);
            //a[192] = new Tuple<string, string, bool>(null, "0000000B01085840", true);
            return null;
        }
    }
}
