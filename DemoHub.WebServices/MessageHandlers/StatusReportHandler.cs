using System;
using System.Collections.Generic;
using DemoHub.Persistence.Models;
using CalastoneServiceReference;
using System.Data.SqlTypes;
using DemoHub.Common;

namespace DemoHub.WebServices.MessageHandlers
{
    public class StatusReportHandler
    {
        #region Version 04
        public static Document6 ReceivedV04(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {
            try
            {
                Document6 document = new Document6();
                OrderInstructionStatusReportV04 ordrInstrStsRpt = new OrderInstructionStatusReportV04();

                MessageIdentification16 msgId = new MessageIdentification16
                {
                    Id = "SRR" + tblDTransactionRequest.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                ordrInstrStsRpt.MsgId = msgId;

                References61Choice refs = new References61Choice
                {
                    Items = new AdditionalReference86[1]
                };
                refs.Items[0] = new AdditionalReference86() { Ref = tblDTransactionRequest.SMessageId };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRpt.Ref = refs;

                Status24Choice stsRpt = new Status24Choice();
                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    List<IndividualOrderStatusAndReason7> items = new List<IndividualOrderStatusAndReason7>();
                    OrderStatus5Choice ordrStatus = new OrderStatus5Choice
                    {
                        Items = new object[1]
                    };
                    ordrStatus.Items[0] = OrderStatus4Code.RECE;
                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                else if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    List<SwitchOrderStatusAndReason2> items = new List<SwitchOrderStatusAndReason2>();
                    OrderStatus4Choice ordrStatus = new OrderStatus4Choice
                    {
                        Items = new object[1]
                    };
                    ordrStatus.Items[0] = OrderStatus4Code.RECE;
                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                document.OrdrInstrStsRpt = ordrInstrStsRpt;
                return document;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Document6 BusinessAcceptV04(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {
            try
            {
                Document6 document = new Document6();
                OrderInstructionStatusReportV04 ordrInstrStsRpt = new OrderInstructionStatusReportV04();

                MessageIdentification16 msgId = new MessageIdentification16
                {
                    Id = "SRA" + tblDTransactionRequest.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                ordrInstrStsRpt.MsgId = msgId;

                References61Choice refs = new References61Choice
                {
                    Items = new AdditionalReference86[1]
                };
                refs.Items[0] = new AdditionalReference86()
                {
                    Ref = tblDTransactionRequest.SMessageId
                };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRpt.Ref = refs;

                Status24Choice stsRpt = new Status24Choice();
                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    List<IndividualOrderStatusAndReason7> items = new List<IndividualOrderStatusAndReason7>();
                    OrderStatus5Choice ordrStatus = new OrderStatus5Choice
                    {
                        Items = new object[1]
                    };
                    ordrStatus.Items[0] = OrderStatus4Code.PACK;

                    ExpectedExecutionDetails4 newDtls = new ExpectedExecutionDetails4();
                    if (tblDTransactionRequest.DtExpectedEffectivateDate != null)
                    {
                        newDtls.XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        };
                    }
                    if (tblDTransactionRequest.DtExpectedSettlementDate != null)
                    {
                        newDtls.XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value;
                    }

                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    List<SwitchOrderStatusAndReason2> items = new List<SwitchOrderStatusAndReason2>();
                    OrderStatus4Choice ordrStatus = new OrderStatus4Choice
                    {
                        Items = new object[1]
                    };
                    ordrStatus.Items[0] = OrderStatus4Code.PACK;

                    ExpectedExecutionDetails2 newDtls = new ExpectedExecutionDetails2();
                    if (tblDTransactionRequest.DtExpectedEffectivateDate != null)
                    {
                        newDtls.XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        };
                    }
                    if (tblDTransactionRequest.DtExpectedSettlementDate != null)
                    {
                        newDtls.XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value;
                    }

                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                document.OrdrInstrStsRpt = ordrInstrStsRpt;
                return document;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Document6 BusinessRejectedBuilderV4(TblDCalastoneTransactionRequest tblDTransactionRequest, int? rejectCode, string addtionalRejectInfo)
        {
            try
            {
                Document6 document = new Document6();
                OrderInstructionStatusReportV04 ordrInstrStsRpt = new OrderInstructionStatusReportV04();

                MessageIdentification16 msgId = new MessageIdentification16
                {
                    Id = "REJ" + tblDTransactionRequest.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                ordrInstrStsRpt.MsgId = msgId;

                References61Choice refs = new References61Choice
                {
                    Items = new AdditionalReference86[1]
                };
                refs.Items[0] = new AdditionalReference86()
                {
                    Ref = tblDTransactionRequest.SMessageId
                };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRpt.Ref = refs;

                Status24Choice stsRpt = new Status24Choice();
                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    List<IndividualOrderStatusAndReason7> items = new List<IndividualOrderStatusAndReason7>();
                    OrderStatus5Choice ordrStatus = new OrderStatus5Choice
                    {
                        Items = new object[1]
                    };

                    RejectedStatus9 rjctd = new RejectedStatus9();
                    RejectedReason20Choice rsn = new RejectedReason20Choice();
                    if (rejectCode != null)
                    {
                        rsn.Item = Enum.Parse(typeof(RejectedStatusReason11Code), Enum.GetName(typeof(RejectedStatusReason11Code), rejectCode));
                    }
                    else
                    {
                        rsn.Item = new GenericIdentification16()
                        {
                            Id = tblDTransactionRequest.SFundId
                        };
                    }
                    rjctd.Rsn = rsn;
                    if (!string.IsNullOrEmpty(addtionalRejectInfo) && !string.IsNullOrWhiteSpace(addtionalRejectInfo))
                    {
                        rjctd.AddtlInf = addtionalRejectInfo;
                    }
                    ordrStatus.Items[0] = rjctd;

                    ExpectedExecutionDetails4 newDtls = new ExpectedExecutionDetails4
                    {
                        XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        },
                        XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value
                    };

                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    List<SwitchOrderStatusAndReason2> items = new List<SwitchOrderStatusAndReason2>();
                    OrderStatus4Choice ordrStatus = new OrderStatus4Choice
                    {
                        Items = new object[1]
                    };

                    RejectedStatus9 rjctd = new RejectedStatus9();
                    RejectedReason20Choice rsn = new RejectedReason20Choice();
                    if (rejectCode != null)
                    {
                        rsn.Item = Enum.Parse(typeof(RejectedStatusReason11Code), Enum.GetName(typeof(RejectedStatusReason11Code), rejectCode));
                    }
                    else
                    {
                        rsn.Item = new GenericIdentification16()
                        {
                            Id = tblDTransactionRequest.SFundId
                        };
                    }
                    rjctd.Rsn = rsn;
                    if (!string.IsNullOrEmpty(addtionalRejectInfo) && !string.IsNullOrWhiteSpace(addtionalRejectInfo))
                    {
                        rjctd.AddtlInf = addtionalRejectInfo;
                    }
                    ordrStatus.Items[0] = rjctd;

                    ExpectedExecutionDetails2 newDtls = new ExpectedExecutionDetails2
                    {
                        XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        },
                        XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value
                    };

                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                document.OrdrInstrStsRpt = ordrInstrStsRpt;
                return document;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Document6 BusinessInRepairBuilderV04(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {


            //try
            //{
            //    var doc = new Document6();


            //    var ordrInstrStsRptV04 = new OrderInstructionStatusReportV04();

            //    var msgId = new MessageIdentification16();
            //    msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
            //    msgId.CreDtTm = DateTime.UtcNow;
            //    ordrInstrStsRptV04.MsgId = msgId;

            //    var refs = new References61Choice();
            //    refs.Items = new AdditionalReference86[1];
            //    refs.Items[0] = new AdditionalReference86() { Ref = tblDTransaction.SMessageId };
            //    ordrInstrStsRptV04.Ref = refs;

            //    var stsRpt = new Status24Choice();

            //    var repairDetails = new InRepairStatusReason4Choice();
            //    repairDetails.Items = new object[1];

            //    var repairStatusReason = new InRepairStatusReason4();
            //    repairStatusReason.Rsn = new InRepairStatusReason5Choice() { Item = new GenericIdentification16() { Id = tblDTransaction.SFundId } };

            //    if (tblDTransaction.FkTransactionType == 1 || tblDTransaction.FkTransactionType == 2)
            //    {
            //        var items = new List<IndividualOrderStatusAndReason7>();
            //        var ordrStatus = new OrderStatus5Choice();
            //        ordrStatus.Items = new string[1];

            //        ordrStatus.Items[0] = repairDetails; //repair reason
            //        items.Add(new IndividualOrderStatusAndReason7()
            //        {
            //            OrdrRef = tblDTransaction.SOrderReference,
            //            DealRef = CalastoneMessageIdGenerator.NewDealReference(),
            //            OrdrSts = ordrStatus,
            //        });
            //        stsRpt.Items = items.ToArray();

            //        ordrInstrStsRptV04.StsRpt = stsRpt;
            //    }
            //    if (tblDTransaction.FkTransactionType == 3)
            //    {
            //        var items = new List<SwitchOrderStatusAndReason2>();
            //        var ordrStatus = new OrderStatus4Choice();
            //        ordrStatus.Items = new string[1];
            //        ordrStatus.Items[0] = repairDetails; //repair
            //        items.Add(new SwitchOrderStatusAndReason2()
            //        {
            //            OrdrRef = tblDTransaction.SOrderReference,
            //            DealRef = CalastoneMessageIdGenerator.NewDealReference(),
            //            OrdrSts = ordrStatus,
            //        });
            //        stsRpt.Items = items.ToArray();
            //        ordrInstrStsRptV04.StsRpt = stsRpt;
            //    }


            //    doc.OrdrInstrStsRpt = ordrInstrStsRptV04;
            //    //var result = XmlHelper.SerializeToXmlString(doc);
            //    return doc;
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}

            try
            {
                Document6 document = new Document6();
                OrderInstructionStatusReportV04 ordrInstrStsRpt = new OrderInstructionStatusReportV04();

                MessageIdentification16 msgId = new MessageIdentification16
                {
                    Id = "REP" + tblDTransactionRequest.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                ordrInstrStsRpt.MsgId = msgId;

                References61Choice refs = new References61Choice
                {
                    Items = new AdditionalReference86[1]
                };
                refs.Items[0] = new AdditionalReference86()
                {
                    Ref = tblDTransactionRequest.SMessageId
                };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRpt.Ref = refs;

                Status24Choice stsRpt = new Status24Choice();
                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    List<IndividualOrderStatusAndReason7> items = new List<IndividualOrderStatusAndReason7>();
                    OrderStatus5Choice ordrStatus = new OrderStatus5Choice
                    {
                        Items = new object[1]
                    };

                    InRepairStatusReason4Choice inRpr = new InRepairStatusReason4Choice()
                    {
                        Items = new object[1]
                    };

                    InRepairStatusReason4 rsnDtls = new InRepairStatusReason4();
                    rsnDtls.Rsn = new InRepairStatusReason5Choice()
                    {
                        Item = new GenericIdentification16()
                        {
                            Id = tblDTransactionRequest.SFundId
                        }
                    };
                    inRpr.Items[0] = rsnDtls;
                    ordrStatus.Items[0] = inRpr;

                    ExpectedExecutionDetails4 newDtls = new ExpectedExecutionDetails4
                    {
                        XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        },
                        XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value
                    };

                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    List<SwitchOrderStatusAndReason2> items = new List<SwitchOrderStatusAndReason2>();
                    OrderStatus4Choice ordrStatus = new OrderStatus4Choice
                    {
                        Items = new object[1]
                    };

                    InRepairStatusReason4Choice inRpr = new InRepairStatusReason4Choice()
                    {
                        Items = new object[1]
                    };

                    InRepairStatusReason4 rsnDtls = new InRepairStatusReason4();
                    rsnDtls.Rsn = new InRepairStatusReason5Choice()
                    {
                        Item = new GenericIdentification16()
                        {
                            Id = tblDTransactionRequest.SFundId
                        }
                    };
                    inRpr.Items[0] = rsnDtls;

                    ordrStatus.Items[0] = inRpr;

                    ExpectedExecutionDetails2 newDtls = new ExpectedExecutionDetails2
                    {
                        XpctdTradDtTm = new DateAndDateTimeChoice6()
                        {
                            Item = tblDTransactionRequest.DtExpectedEffectivateDate ?? SqlDateTime.MinValue.Value
                        },
                        XpctdCshSttlmDt = tblDTransactionRequest.DtExpectedSettlementDate ?? SqlDateTime.MinValue.Value
                    };

                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = "Deal" + tblDTransactionRequest.SOrderReference,
                        OrdrSts = ordrStatus,
                        NewDtls = newDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRpt.StsRpt = stsRpt;
                }
                document.OrdrInstrStsRpt = ordrInstrStsRpt;
                return document;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Version 03
        public static Document19 OrderReceivedBuilderV3(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {


            try
            {
                var doc = new Document19();


                var ordrInstrStsRptV03 = new OrderInstructionStatusReportV03();

                var msgId = new MessageIdentification117();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV03.MsgId = msgId;

                var additionalRef = new List<AdditionalReference37>();
                additionalRef.Add(new AdditionalReference37() { Ref = tblDTransactionRequest.SMessageId });
                ordrInstrStsRptV03.Items = additionalRef.ToArray();


                var sts = new OrderStatus5Choice();
                sts.Items = new object[1];
                sts.Items[0] = OrderStatus4Code.PACK;

                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {

                    ordrInstrStsRptV03.ItemsElementName = new ItemsChoiceType1[1] { ItemsChoiceType1.RltdRef };

                    var orderStatus = new List<IndividualOrderStatusAndReason2>();
                    var item = new IndividualOrderStatusAndReason2();
                    item.Items = new object[1];
                    item.Items[0] = OrderStatus4Code1.RECE;
                    item.OrdrRef = tblDTransactionRequest.SOrderReference;
                    item.DealRef = CalastoneMessageIdGenerator.NewDealReference();
                    orderStatus.Add(item);
                    ordrInstrStsRptV03.Items1 = orderStatus.ToArray();
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    var switchOrderStatus = new List<SwitchOrderStatusAndReason1>();
                    switchOrderStatus.Add(new SwitchOrderStatusAndReason1() { OrdrRef = tblDTransactionRequest.SOrderReference, DealRef = CalastoneMessageIdGenerator.NewDealReference() });
                    ordrInstrStsRptV03.Items1 = switchOrderStatus.ToArray();
                    ordrInstrStsRptV03.ItemsElementName = new ItemsChoiceType1[1] { ItemsChoiceType1.OthrRef };

                    var orderStatus = new List<SwitchOrderStatusAndReason1>();
                    var item = new SwitchOrderStatusAndReason1();
                    item.OrdrRef = tblDTransactionRequest.SOrderReference;
                    item.DealRef = CalastoneMessageIdGenerator.NewDealReference();
                    item.Items = new object[1];
                    item.Items[0] = OrderStatus4Code1.RECE;

                    orderStatus.Add(item);
                    ordrInstrStsRptV03.Items1 = orderStatus.ToArray();
                }


                doc.OrdrInstrStsRptV03 = ordrInstrStsRptV03;

                return doc;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
