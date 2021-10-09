
using DemoHub.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Infrastructure.CHESS
{
    public class MessageProducer
    {
        /*
         * business logic explanation
         * use Payment Facility Detail as an example, code: 230-01
         * 
         * Fields
         * Bit position                  Field name                              Format                   M/O
         * ------------                  ----------                              ------                   ---
         * 16                            HIN                                     10 numeric               O
         * 19                            PID                                     5  numeric               M
         * 21                            Processing Timestamp                    22 character             M
         * 29                            Payment Facility Id                     6  numeric               M
         * 56                            Default Payment Facility Indicator      1  character             M
         * 62                            Origin Transaction Id                   16 character             M
         * 
         * 
         * Each field is a class (C# type) or a user defined data type (SQL Server type)
         * 
         * use array to load each field in
         * 
         * 
         */



        //static string Message(ChessEnums.MessageType tp) => tp switch
        //{
        //    DemandSingleEntryCHESStoCHESSTransferRequest => 
        //};


        byte[] array64 = new byte[64];
        byte[] array128 = new byte[128];
        byte[] array192 = new byte[192];
        byte[] array256 = new byte[256];



    }
}
