using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static DemoHub.Chess.MessageHandlers.MessageFieldHandler;
//using static DemoHub.Chess.MessageHandlers.MessageFields;

namespace DemoHub.Chess.MessageHandlers
{
    public class MessageTypes
    {
        public static Tuple<string, string, bool>[] SetFields(List<Tuple<int, bool>> lfields)
        {
            Tuple<string, string, bool>[] msg = new Tuple<string, string, bool>[256];
            lfields.ForEach(i => msg[i.Item1 - 1] = new Tuple<string, string, bool>(
                Enum.GetName(typeof(MessageField), i.Item1),
                SetFieldValue(Enum.GetName(typeof(MessageField), i.Item1)),
                i.Item2));
            return msg;
        }

        public static Tuple<string, string, bool>[] GetFields(string m, List<Tuple<int, bool>> lfields)
        {
            Tuple<string, string, bool>[] msg = new Tuple<string, string, bool>[256];
            lfields.ForEach(i => msg[i.Item1 - 1] = new Tuple<string, string, bool>(
                Enum.GetName(typeof(MessageField), i.Item1),
                GetFieldValue(Enum.GetName(typeof(MessageField), i.Item1)),
                i.Item2));
            return msg;
        }

        public static string SetFieldValue(string fieldname)
        {
            PropertyInfo propertyInfo = typeof(MessageFields)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(i => i.Name == fieldname);
            propertyInfo.SetValue(null, "");
            return null;
        }

        public static string GetFieldValue(string fieldname)
        {
            PropertyInfo propertyInfo = typeof(MessageFields)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(i => i.Name == fieldname);
            propertyInfo.SetValue(null, "");
            return null;
        }

        public static Tuple<string, string, bool>[] AssembleMessage(MessageTypeHandler.MessageType tp)
        {
            var result = Enum.GetName(typeof(MessageTypeHandler.MessageType), tp) switch
            {
                "defaultType" => SetFields(null),

                // 001-02 to 399-01
                #region 001-02 to 399-01
                // 001-02 Demand Single Entry CHESS to CHESS Transfer Request
                // P to C
                // Prerequisites: None
                "DemandSingleEntryCHESStoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 003-02 Transferor Submitted Demand Transfer
                // P to C
                // Prerequisites: None
                "TransferorSubmittedDemandTransfer" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 005-03 Demand Dual Entry CHESS to CHESS Transfer Request
                // P to C
                // Prerequisites: None
                "DemandDualEntryCHESStoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false),
                    //Secondary Matching Flag
                }),

                // 007-03 Demand CHESS to Issuer Sponsored Transfer Request
                // P to C
                // Prerequisites: None
                "DemandCHESStoIssuerSponsoredTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 009-03 Demand CHESS to Certificated Transfer Request
                // P to C
                "DemandCHESStoCertificatedTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 011-02 CHESS to Issuer Sponsored Conversion Request
                // P to C
                "CHESStoIssuerSponsoredConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 013-02 CHESS to Certificated Conversion Request
                // P to C
                "CHESStoCertificatedConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 015-03 Issuer Sponsored to CHESS Transfer Request
                // P to C
                "IssuerSponsoredtoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.PIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 017-03 Issuer Sponsored to CHESS Conversion Request
                // P to C
                "IssuerSponsoredtoCHESSConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.PIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 019-02 Certificated to CHESS Conversion Request
                // P to C
                "CertificatedtoCHESSConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 021-02 Certificated to CHESS Transfer Request
                // P to C
                "CertificatedtoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.Balance, false),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.CertificateQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 023-01 ASX Clear Collateral Removal Request
                // P to C
                "ASXClearCollateralRemovalRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true)
                }),

                // 025-01 New Single Entry Transfer Request
                // P to C
                "NewSingleEntryTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessagesinSet, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false)
                }),

                // 027-03 Collateral Creation Request
                // P to C
                "CollateralCreationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.MarginLender, false),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.SpecificCover, false)
                }),

                // 029-03 Collateral Removal Request
                // P to C
                "CollateralRemovalRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true)
                }),

                // 031-01 Takeover Acceptance
                // P to C
                "TakeoverAcceptance" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.DistinctPortionIndicator, true)
                }),

                // 033 N/A
                // 035-01 Offeror Takeover Acceptance Rejection
                // N/A

                // 037-01 Demand Dual Entry CHESS to CHESS Transfer Cancellation Request
                // P to C
                "DemandDualEntryCHESStoCHESSTransferCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 039 N/A
                // 041 N/A
                // 043 N/A
                // 045 N/A
                // 047 N/A
                // 049 N/A
                // 051 N/A
                // 053 N/A
                // 055 N/A
                // 057 N/A
                // 059 N/A
                // 061 N/A
                // 063 N/A
                // 065 N/A
                // 067 N/A
                // 069 N/A
                // 071 N/A
                // 073 N/A
                // 075 N/A
                // 077 N/A
                // 079 N/A
                // 081 N/A
                // 083 N/A

                // 085-02 Takeover Acceptance Removal Request
                // P to C
                "TakeoverAcceptanceRemovalRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceRemovalReason, false)
                }),

                // 087 N/A
                // 089 N/A
                // 091 N/A

                // 093-01 Price Registration
                // P to C
                "PriceRegistration" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunType, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunDate, true),
                    new Tuple<int, bool>((int)MessageField.LastDateTraded, true),
                    new Tuple<int, bool>((int)MessageField.LastTradedTime, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.On_MarketVolume, true),
                    new Tuple<int, bool>((int)MessageField.Off_MarketVolume, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunTime, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.BidTime, true),
                    new Tuple<int, bool>((int)MessageField.AskTime, true),
                    new Tuple<int, bool>((int)MessageField.BidPrice, true),
                    new Tuple<int, bool>((int)MessageField.AskPrice, true),
                    new Tuple<int, bool>((int)MessageField.FirstTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.HighestTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.LowestTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.LastTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.On_MarketValue, true),
                    new Tuple<int, bool>((int)MessageField.Off_MarketValue, true)
                }),


                // 095 N/A

                // 097-02 Price Notification Registration
                // P to C
                "PriceNotificationRegistration" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunType, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunDate, true),
                    new Tuple<int, bool>((int)MessageField.LastDateTraded, true),
                    new Tuple<int, bool>((int)MessageField.LastTradedTime, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PriceRunTime, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.BidTime, true),
                    new Tuple<int, bool>((int)MessageField.AskTime, true),
                    new Tuple<int, bool>((int)MessageField.BidPrice, true),
                    new Tuple<int, bool>((int)MessageField.AskPrice, true),
                    new Tuple<int, bool>((int)MessageField.FirstTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.HighestTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.LowestTradePrice, true),
                    new Tuple<int, bool>((int)MessageField.LastTradePrice, true)
                }),

                // 099 N/A

                // 101-02 Dual Entry Settlement Notification
                // P to C
                "DualEntrySettlementNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TradeDate, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true), // or Payer PID
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true), // or Payee PID
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 103-01 CP Collateral Removal Authorisation
                // P/PISP to C
                "CPCollateralRemovalAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 105-02 Single Entry Settlement CHESS to CHESS Transfer Request
                // P/PISP to C
                "SingleEntrySettlementCHESStoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 107-01 Scheduled Settlement CHESS to CHESS Transfer Request
                // P/PISP to C
                "ScheduledSettlementCHESStoCHESSTransferRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.TrustAmount, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 109-01 CP Collateral Removal Rejection
                // P/PISP to C
                "CPCollateralRemovalRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 111 N/A
                // 113 N/A
                // 115 N/A
                // 117 N/A

                // 119-01 Single Entry Settlement CHESS to CHESS Transfer Cancellation Request
                // P/PISP to C
                "SingleEntrySettlementCHESStoCHESSTransferCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 121-02 Change Settlement Instruction Request
                // P/PISP to C
                "ChangeSettlementInstructionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.UpdateGuaranteedForeignIndicator, false)
                }),

                // 123-01 Change Settlement Instruction Cancellation Request
                // P/PISP to C
                "ChangeSettlementInstructionCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 125-01 Maintain Settlement Instruction Request
                // P/PISP to C
                "MaintainSettlementInstructionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false)
                }),

                // 127 N/A

                // 129-01 Dual Entry Settlement Cancellation Request
                // P/PISP to C
                "DualEntrySettlementCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 131-01 Dual Entry Settlement Instruction Cancellation Removal
                // P/PISP to C
                "DualEntrySettlementInstructionCancellationRemoval" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 133 N/A

                // 135-01 Dual Entry Settlement Notification Cancellation Request
                // P/PISP to C
                "DualEntrySettlementNotificationCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 137 N/A

                // 139-01 Isolate Counterparty Request
                // P/PISP to C
                "IsolateCounterpartyRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true)
                }),

                // 141 N/A
                // 143 N/A
                // 145 N/A
                // 147 N/A
                // 149 N/A
                // 151 N/A
                // 153 N/A
                // 155 N/A
                // 157 N/A
                // 159 N/A

                // 161-01 Trade Registration Request
                // P/PISP to C
                "TradeRegistrationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.TradeExecutionTime, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.MessageType, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, true),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BuyerId, true),
                    new Tuple<int, bool>((int)MessageField.SellerId, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.SerialTradeQualifier, true),
                    new Tuple<int, bool>((int)MessageField.TradeSerialNumber, true)
                }),

                // 163 N/A
                // 165 N/A
                // 167 N/A
                // 169 N/A
                // 171 N/A
                // 173 N/A
                // 175 N/A
                // 177 N/A
                // 179 N/A
                // 181 N/A
                // 183 N/A
                // 185 N/A
                // 187 N/A
                // 189 N/A
                // 191 N/A
                // 193 N/A

                // 195-01 Block Trade Request
                // P/PISP to C
                "BlockTradeRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 197-01 Unblock Trade Request
                // P/PISP to C
                "UnblockTradeRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 199 N/A

                // 201-04 New Registration Details
                // P/PISP to C
                "NewRegistrationDetails" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.EntrepotType, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, true),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false)
                }),

                // 203-04 Registration Details Update Request
                // P/PISP to C
                "RegistrationDetailsUpdateRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.DateofEvent, false),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ContactReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationNameUpdateReason1, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationNameUpdateReason2, false),
                    new Tuple<int, bool>((int)MessageField.HolderStatusChange, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.HolderLockReleaseReason, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.EmailCancellation, false)
                }),

                // 205 N/A
                // 207 N/A
                // 209 N/A
                // 211 N/A
                // 213 N/A
                // 215 N/A
                // 217 N/A
                // 219 N/A
                // 221 N/A
                // 223 N/A
                // 225 N/A
                // 227 N/A
                // 229 N/A
                // 231 N/A
                // 233 N/A
                // 235 N/A
                // 237 N/A
                // 239 N/A
                // 241 N/A
                // 243 N/A

                // 245-01 Change Controlling Participant Request
                // P to C
                "ChangeControllingParticipantRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true)
                }),

                // 247-01 Change Controlling Participant Cancellation Request
                // P to C
                "ChangeControllingParticipantCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 249 N/A

                // 251-01 Change Controlling Participant Authorisation
                // P to C
                "ChangeControllingParticipantAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                }),

                // 253-01 Change Controlling Participant Rejection
                // P to C
                "ChangeControllingParticipantRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true)
                }),

                // 255 N/A
                // 257 N/A
                // 259 N/A
                // 261 N/A
                // 263 N/A
                // 265 N/A
                // 267 N/A
                // 269 N/A

                // 271-01 Loan Application
                // P to C
                "LoanApplication" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true)
                }),

                // 273-01 Loan Application Cancellation Request
                // P to C
                "LoanApplicationCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 275-01 Loan Return Notification
                // P to C
                "LoanReturnNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.LoanTransactionId, true)
                }),

                // 277-01 Loan Return Cancellation Request
                // P to C
                "LoanReturnCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 279 N/A

                // 281-01 Bulk Loan Application
                // P to C
                "BulkLoanApplication" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.LoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 283 N/A
                // 285 N/A
                // 287 N/A
                // 289 N/A
                // 291 N/A
                // 293 N/A
                // 295 N/A
                // 297 N/A
                // 299 N/A
                // 301 N/A
                // 303 N/A
                // 305 N/A
                // 307 N/A
                // 309 N/A

                // 311-01 Participant Funds Obligation Acknowledgement
                // P to C
                "ParticipantFundsObligationAcknowledgement" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.BankReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 313-01 Participant Funds Obligation Rejection
                // P to C
                "ParticipantFundsObligationRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.BankReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 315 N/A
                // 317 N/A
                // 319 N/A
                // 321 N/A
                // 323 N/A
                // 325 N/A
                // 327 N/A
                // 329 N/A
                // 331 N/A

                // 333-01 Bank Funds Transfer Response
                // P to C
                "BankFundsTransferResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.BankReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 335 N/A
                // 337 N/A
                // 339 N/A

                // 341-01 Create Net Position Request
                // P to C
                "CreateNetPositionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapLimit, false),
                    new Tuple<int, bool>((int)MessageField.DebitCapActivityFlag, true)
                }),

                // 343-01 Create Net Position Authorisation
                // P to C
                "CreateNetPositionAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BIC, true)
                }),

                // 345-01 Create Net Position Rejection
                // P to C
                "CreateNetPositionRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedNetPositionReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 347 N/A
                // 349 N/A

                // 351-01 Create Cash Subrecord Request
                // P to C
                "CreateCashSubrecordRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordType, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapExclusionFlag, true)
                }),

                // 353-01 Create Cash Subrecord Authorisation
                // P to C
                "CreateCashSubrecordAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ESAStatus, true),
                    new Tuple<int, bool>((int)MessageField.CreditStatus, true),
                    new Tuple<int, bool>((int)MessageField.Pre_SettlementAdvice_ESALevel, true),
                    new Tuple<int, bool>((int)MessageField.Pre_SettlementAdvice_CreditLevel, true),
                    new Tuple<int, bool>((int)MessageField.Post_SettlementAdvice, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 355 N/A

                // 357-01 Create Cash Subrecord Rejection
                // P to C
                "CreateCashSubrecordRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.CreateCashSubrecordRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 359 N/A

                // 361-01 Zero Sum Notification
                // P to C
                "ZeroSumNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DvPDeclarationTimestamp, true)
                }),

                // 363 N/A
                // 365 N/A
                // 367 N/A
                // 369 N/A

                // 371-01 Change Net Position Attributes Request
                // P to C
                "ChangeNetPositionAttributesRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NetPositionActivityFlag, false),
                    new Tuple<int, bool>((int)MessageField.CurrentorNewDebitCapLimit, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapActivityFlag, false)
                }),

                // 373-01 Change Net Position Attributes Request
                // P to C
                "BankChangeCashSubrecordAttributesRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ESAStatus, false),
                    new Tuple<int, bool>((int)MessageField.CreditStatus, false),
                    new Tuple<int, bool>((int)MessageField.Pre_SettlementAdvice_ESALevel, false),
                    new Tuple<int, bool>((int)MessageField.Pre_SettlementAdvice_CreditLevel, false),
                    new Tuple<int, bool>((int)MessageField.Post_SettlementAdvice, false),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 375-01 Participant Change Cash Subrecord Attributes Request
                // P to C
                "ParticipantChangeCashSubrecordAttributesRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, false),
                    new Tuple<int, bool>((int)MessageField.DebitCapExclusionFlag, false)
                }),

                // 377-01 Participant Change Cash Subrecord Attributes Authorisation
                // P to C
                "ParticipantChangeCashSubrecordAttributesAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 379-01 Participant Change Cash Subrecord Attributes Rejection
                // P to C
                "ParticipantChangeCashSubrecordAttributesRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.ChangeCashSubrecordRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 381 N/A
                // 383 N/A
                // 385 N/A
                // 387 N/A
                // 389 N/A
                // 391 N/A
                // 393 N/A
                // 395 N/A
                // 397 N/A

                // 399-01 Settlement Cancellation Acknowledgement
                // P to C
                "SettlementCancellationAcknowledgement" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),
                #endregion 001-02 to 399-01

                // 401-01 to 800-02
                #region 401-01 to 800-02
                // 401-01 Registry to CHESS Conversion Authorisation
                // R to C
                "RegistrytoCHESSConversionAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 403-01 Registry to CHESS Conversion Rejection
                // R to C
                "RegistrytoCHESSConversionRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedMovementReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 405-01 Registry to CHESS Transfer Authorisation
                // R to C
                "RegistrytoCHESSTransferAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.MarkingNumber, false),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true)
                }),

                // 407-01 Registry to CHESS Transfer Rejection
                // R to C
                "RegistrytoCHESSTransferRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedMovementReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 409 N/A
                // 411 N/A
                // 413 N/A
                // 415 N/A
                // 417 N/A
                // 419 N/A

                // 421-01 Securities Transformation
                // R to C
                "SecuritiesTransformation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ReducingSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ReducingUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingUnitQuantity, true)
                }),

                // 423 N/A

                // 425-01 Holding Adjustment
                // R to C
                "HoldingAdjustment" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true)
                }),

                // 427 N/A
                // 429 N/A

                // 431-01 Takeover Transfer
                // R to C
                "TakeoverTransfer" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, true),
                    new Tuple<int, bool>((int)MessageField.DutyType, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false)
                }),

                // 433 N/A
                // 435 N/A
                // 437 N/A
                // 439 N/A

                // 441-01 Cancel Settlement Type Change Request
                // P to C
                "CancelSettlementTypeChangeRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 443 N/A
                // 445 N/A
                // 447 N/A
                // 449 N/A

                // 451-01 Participant to CHESS SRN Request
                // P to C
                "ParticipanttoCHESSSRNRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true)
                }),

                // 453-01 Registry to CHESS SRN Response
                // R to C
                "RegistryToCHESSSRNResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true)
                }),

                // 455-01 Registry to CHESS SRN Reject
                // R to C
                "RegistryToCHESSSRNReject" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 457-01 Participant to CHESS Holding Balance Request
                // R to C
                "ParticipanttoCHESSHoldingBalanceRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true)
                }),

                // 459-01 Registry to CHESS Holding Balance Response
                // R to C
                "RegistrytoCHESSHoldingBalanceResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalanceTimestamp, true)
                }),

                // 461-01 Registry to CHESS Holding Balance Reject
                // R to C
                "RegistrytoCHESSHoldingBalanceReject" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true)
                }),

                // 463 N/A
                // 465 N/A
                // 467 N/A
                // 469 N/A
                // 471 N/A
                // 473 N/A
                // 475 N/A
                // 477 N/A
                // 479 N/A

                // 481-01 RTGS Dual Entry Notification
                // R to C
                "RTGSDualEntryNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TradeDate, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false)
                }),

                // 483-01 RTGS Notification Cancellation Request
                // P to C
                "RTGSNotificationCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 485-01 RTGS Dual Entry Cancellation Request
                // P to C
                "RTGSDualEntryCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 487-01 RTGS Dual Entry Cancellation Removal
                // P to C
                "RTGSDualEntryCancellationRemoval" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 489-01 Change RTGS Instruction Request
                // P to C
                "ChangeRTGSInstructionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.UpdateGuaranteedForeignIndicator, false)
                }),

                // 491-01 Change RTGS Instruction Cancellation Request
                // P to C
                "ChangeRTGSInstructionCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 493-01 Maintain RTGS Instruction Request
                // P to C
                "MaintainRTGSInstructionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false)
                }),

                // 495-01 Authorise Scheduled RTGS Instruction
                // P to C
                "AuthoriseScheduledRTGSInstruction" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 497-01 Settlement Type Change Request
                // P to C
                "SettlementTypeChangeRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false),
                    new Tuple<int, bool>((int)MessageField.DestinationSettlementSystem, true)
                }),

                // 499 N/A
                // 501 N/A

                // 503-04 Reporting Request
                // P/PISP/R to C
                "ReportingRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCodeParameter, false),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.ReportingStartDate, false),
                    new Tuple<int, bool>((int)MessageField.ReportingEndDate, false),
                    new Tuple<int, bool>((int)MessageField.HINParameter, false),
                    new Tuple<int, bool>((int)MessageField.PIDParameter, false),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityParameter, false),
                    new Tuple<int, bool>((int)MessageField.SubpositionTypeParameter, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverCodeParameter, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.ReportingId, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingFrequency, true),
                    new Tuple<int, bool>((int)MessageField.ExDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.NumberOfDaysParameter, false),
                    new Tuple<int, bool>((int)MessageField.PositionTypeParameter, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingPoint, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingPeriod, false),
                    new Tuple<int, bool>((int)MessageField.StartDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.EndDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.AsAtDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.ReportingIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.TransactionClassParameter, false),
                    new Tuple<int, bool>((int)MessageField.AdditionalReportingParameter, false)
                }),

                // 505-01 Reporting Request Cancellation
                // P/PISP/R to C
                "ReportingRequestCancellation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 507 N/A
                // 509 N/A
                // 511 N/A
                // 513 N/A
                // 515 N/A
                // 517 N/A
                // 519 N/A
                // 521 N/A
                // 523 N/A
                // 525 N/A
                // 527 N/A
                // 529 N/A
                // 531 N/A

                // 533-02 Tax File Number / Australian Business Number Advice
                // P to C
                "TaxFileNumberOrAustralianBusinessNumberAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false)
                }),

                // 535 N/A
                // 537 N/A
                // 539 N/A
                // 541 N/A
                // 543 N/A
                // 545 N/A
                // 547 N/A
                // 549 N/A

                // 551-01 Aggregated Payment Request
                // P to C
                "AggregatedPaymentRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentSetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.PayerClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.PayerPaymentCategory, true),
                    new Tuple<int, bool>((int)MessageField.PayeeClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.PayeePaymentCategory, true)
                }),

                // 553-01 Payment Set Total Record
                // P to C
                "PaymentSetTotalRecord" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentSetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalPaymentRecords, true)
                }),

                // 555 N/A
                // 557 N/A
                // 559 N/A
                // 561 N/A
                // 563 N/A
                // 565 N/A
                // 567 N/A
                // 569 N/A
                // 571 N/A
                // 573 N/A
                // 575 N/A
                // 577 N/A
                // 579 N/A
                // 581 N/A
                // 583 N/A
                // 585 N/A
                // 587 N/A
                // 589 N/A
                // 591 N/A
                // 593 N/A
                // 595 N/A
                // 597 N/A
                // 599 N/A

                // 601-01 Collateral Release Request
                // P to C
                "CollateralReleaseRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false)
                }),

                // 603-01 Collateral Removal Authorisation
                // P to C
                "CollateralRemovalAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 605-02 Collateral Removal Rejection
                // P to C
                "CollateralRemovalRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 607-01 Accepted Collateral
                // P to C
                "AcceptedCollateral" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 609-02 Rejected Collateral
                // P to C
                "RejectedCollateral" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 611 N/A
                // 613 N/A
                // 615 N/A
                // 617 N/A
                // 619 N/A
                // 621 N/A
                // 623 N/A
                // 625 N/A
                // 627 N/A
                // 629 N/A
                // 631 N/A
                // 633 N/A
                // 635 N/A
                // 637 N/A
                // 639 N/A
                // 641 N/A
                // 643 N/A
                // 645 N/A
                // 647 N/A
                // 649 N/A

                // 651-01 ETC Trade Advice
                // P to C
                "ETCTradeAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.TradeTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.BuySellIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OrderReference, true),
                    new Tuple<int, bool>((int)MessageField.TradingBroker, true),
                    new Tuple<int, bool>((int)MessageField.CrossingIndicator, false),
                    new Tuple<int, bool>((int)MessageField.PrincipalIndicator, false),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false)
                }),

                // 653-02 ETC Trade Allocation Advice
                // P to C
                "ETCTradeAllocationAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.SettlementCounterpartyPID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationQuantity, true),
                    new Tuple<int, bool>((int)MessageField.AllocationTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationStatus, true),
                    new Tuple<int, bool>((int)MessageField.Brokerage, false)
                }),

                // 655-01 ETC Trade Rejection Advice
                // P to C
                "ETCTradeRejectionAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectionTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ETCRejectionReason, true)
                }),

                // 657-01 Contract Note Advice
                // P to C
                "ContractNoteAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.InitiatorNameandAddress, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.BuySellIndicator, true),
                    new Tuple<int, bool>((int)MessageField.CrossingIndicator, false),
                    new Tuple<int, bool>((int)MessageField.PrincipalIndicator, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteStatus, true),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.Brokerage, true),
                    new Tuple<int, bool>((int)MessageField.OtherAmount, false),
                    new Tuple<int, bool>((int)MessageField.RecipientName, true),
                    new Tuple<int, bool>((int)MessageField.MemberASXIndicator, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false),
                    new Tuple<int, bool>((int)MessageField.Remarks, false)
                }),

                // 659-01 Contract Note Rejection Advice
                // P to C
                "ContractNoteRejectionAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectionTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ETCRejectionReason, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteRejectionLevel, true)
                }),

                // 661-01 Allocation Cancellation Advice
                // P to C
                "AllocationCancellationAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationCancellationTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.AllocationCancellationLevel, true)
                }),

                // 663-01 ETC Settlement Advice
                // P to C
                "ETCSettlementAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.SettlementCounterpartyPID, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, true),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAdviceTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.Brokerage, true),
                    new Tuple<int, bool>((int)MessageField.Deliver_ReceiveUnitsIndicator, true)
                }),

                // 665-01 ETC Settlement Cancellation Advice
                // P to C
                "ETCSettlementCancellationAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementCancelTimestamp, false)
                }),

                // 667-01 ETC Trade Cancellation Advice
                // P to C
                "ETCTradeCancellationAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationTimestamp, false)
                }),

                // 669-01 ETC Contract Note Cancellation Advice
                // P to C
                "ETCContractNoteCancellationAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCTargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationTimestamp, false)
                }),

                // 671 N/A
                // 673 N/A
                // 675 N/A
                // 677 N/A
                // 679 N/A
                // 681 N/A
                // 683 N/A
                // 685 N/A
                // 687 N/A
                // 689 N/A

                // 691-01 Controlling PID and Holder Status Request
                // P to C
                "ControllingPIDandHolderStatusRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true)
                }),

                // 693 N/A
                // 695 N/A
                // 697 N/A
                // 699 N/A

                // 701-01 Takeover Acceptance Rejection
                // P to C
                "TakeoverAcceptanceRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, false)
                }),

                // 703-01 Takeover Acceptance Removal Authorisation
                // P to C
                "TakeoverAcceptanceRemovalAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 705-01 Takeover Acceptance Removal Rejection
                // P to C
                "TakeoverAcceptanceRemovalRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 707-01 Offeror Takeover Acceptance Removal
                // P to C
                "OfferorTakeoverAcceptanceRemoval" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceRemovalReason, false)
                }),

                // 709 N/A

                // 711-01 Offeror Takeover Acceptance
                // P to C
                "OfferorTakeoverAcceptance" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.DistinctPortionIndicator, false)
                }),

                // 713 N/A

                // 715-01 CHESS to Issuer Sponsored Fund Conversion Request
                // P to C
                "CHESStoIssuerSponsoredFundConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 718-02 Issuer Sponsored Fund to CHESS Conversion Request
                // P to C
                "IssuerSponsoredFundtoCHESSConversionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 721-01 Conversion Authorisation Issuer Sponsored Fund to CHESS
                // PISP/R to C
                "ConversionAuthorisationIssuerSponsoredFundtoCHESS" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 724-01 Conversion Rejection Issuer Sponsored Fund to CHESS
                // PISP to C
                "ConversionRejectionIssuerSponsoredFundtoCHESS" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedMovementReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 726-02 Application Request
                // P to C
                "ApplicationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.InitialApplication, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AML_CTFFlag, true),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    new Tuple<int, bool>((int)MessageField.ProductName, false),
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 729-02 Application Order/Payment Plan Application Response
                // PISP to C
                "ApplicationOrderOrPaymentPlanApplicationResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 732-02 Unit Adjustment
                // PISP to C
                "UnitAdjustment" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.FundReason, true),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.AdjustmentUnits, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 735-01 Foreign Tax Status
                // PISP to C
                "ForeignTaxStatus" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ForeignResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.AddressType, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LinkingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AddressDetails1, false),
                    // Superannuation Fund ABN
                    new Tuple<int, bool>((int)MessageField.AddressDetails2, false),
                    new Tuple<int, bool>((int)MessageField.AddressDetails3, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.AccountType, true),
                    new Tuple<int, bool>((int)MessageField.EntityType, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson1, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth1, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson2, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth2, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson3, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth3, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3C, false),
                    new Tuple<int, bool>((int)MessageField.AdditionalForeignParties, false)
                }),

                // 737-01 Investor Details
                // PISP to C
                "InvestorDetails" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.DRPPreference, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LinkingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorMobile, true),
                    new Tuple<int, bool>((int)MessageField.DateofBirth1, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth2, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth3, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, true),
                    new Tuple<int, bool>((int)MessageField.InvestorMobileContact, true),
                    new Tuple<int, bool>((int)MessageField.InvestorEmailAddress, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.InvestorEmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAFSLNumber, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorEmail, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupName, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorName, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorCode, true)
                }),

                // 739 N/A
                // 741 N/A
                // 743 N/A
                // 745 N/A
                // 747 N/A
                // 749 N/A
                // 751 N/A
                // 753 N/A
                // 755 N/A

                // 757-02 Holding Advice
                // P to C
                "HoldingAdvice" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.AccountCancellation, false)
                }),

                // 759-01 Holding Advice Acceptance
                // R to C
                "HoldingAdviceAcceptance" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 761-01 Holding Advice Rejection
                // R to C
                "HoldingAdviceRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedHoldingAdviceReason, true)
                }),

                // 763 N/A
                // 765 N/A
                // 767 N/A
                // 769 N/A
                // 771 N/A
                // 773 N/A
                // 775 N/A
                // 777 N/A
                // 779 N/A
                // 781 N/A
                // 783 N/A
                // 785 N/A
                // 787 N/A
                // 789 N/A
                // 791 N/A
                // 793 N/A
                // 795 N/A
                // 797 N/A
                // 799 N/A

                // 800-02 Redemption Request
                // P to C
                "RedemptionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.FullRedemption, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionRequestReason, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.ProductName, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),
                #endregion 401-01 to 800-02

                // 801-02 to 976-01
                #region 801-02 to 976-01
                // 802-01 Redemption Order Response
                // PISP to C
                "RedemptionOrderResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.HoldReason, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    new Tuple<int, bool>((int)MessageField.Income, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.PaymentDate, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                }),

                // 804-01 Funds Order Cancellation Request
                // P to C
                "FundOrderCancellationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 806-01 Switch Request
                // P to C
                "SwitchRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RedemptionFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FullSwitch, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.ApplicationProductName, false),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    new Tuple<int, bool>((int)MessageField.UnitsRedeemed, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionProductName, false),
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionAPIRCode, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationAPIRCode, false)
                }),

                // 808-01 Switch Order Response
                // PISP to C
                "SwitchOrderResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RedemptionFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationFundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.HoldReason, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionUnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    new Tuple<int, bool>((int)MessageField.Income, false),
                    new Tuple<int, bool>((int)MessageField.UnitsRedeemed, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionUnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionAPIRCode, false)
                }),

                // 810-01 Update Order
                // PISP to C
                "UpdateOrder" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.CancelReason, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.PaymentDate, false)
                }),

                // 813-01 Income Statement
                // R to C
                "IncomeStatement" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.GrossIncomeAmount, true),
                    new Tuple<int, bool>((int)MessageField.IncomeNotificationFlag, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.IncomeAmountperUnit, false),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    // Nett Amount
                    new Tuple<int, bool>((int)MessageField.UnitsParticipating, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.PaymentDate, true),
                    new Tuple<int, bool>((int)MessageField.RecordDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.TaxCreditAmount, false)
                }),

                // 815 N/A

                // 817-01 Distribution Re-investment Notification
                // PISP to C
                "DistributionReinvestmentNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.GrossDRPAmount, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, true),
                    new Tuple<int, bool>((int)MessageField.AdditionalUnits, true),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    new Tuple<int, bool>((int)MessageField.NettDRPAmount, false),
                    new Tuple<int, bool>((int)MessageField.UnitsParticipating, true),
                    new Tuple<int, bool>((int)MessageField.Fees, true),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, true),
                    new Tuple<int, bool>((int)MessageField.RecordDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 819 N/A
                // 821 N/A
                // 823 N/A
                // 825 N/A
                // 827 N/A
                // 829 N/A

                // 837-01 Participant to CHESS Fund Balance Request
                // PISP to C
                "ParticipanttoCHESSFundBalanceRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 839-01 Registry to CHESS Fund Balance Response
                // R to C
                "RegistrytoCHESSFundBalanceResponse" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    //Requesting PID
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalanceTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.FundHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 841-01 Registry to CHESS Fund Balance Rejection
                // R to C
                "RegistrytoCHESSFundBalanceRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    //Requesting PID
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 843 N/A

                // 845-01 Unit Reversal Notification
                // PISP to C
                "UnitReversalNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, true),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 847 N/A
                // 849 N/A
                // 851 N/A
                // 853 N/A
                // 855 N/A
                // 857 N/A
                // 859 N/A
                // 861 N/A

                // 863-01 Distribution Election Request
                // PISP to C
                "DistributionElectionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderDRPPreference, false),
                    new Tuple<int, bool>((int)MessageField.HolderRPPPreference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.RPPFrequency, false),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    // DRP Units Participating
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.RPPAmount, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 865-01 Distribution Election Registry Authorisation
                // R to C
                "DistributionElectionRegistryAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 867-01 Distribution Election Registry Rejection
                // R to C
                "DistributionElectionRegistryRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedRegistryReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 869-01 Income Statement Request
                // P to C
                "IncomeStatementRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementReportFrequency, false),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementReportType, false),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementCancellation, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 871-01 Margin Cover Creation Request
                // P to C
                "MarginCoverCreationRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 873-01 Margin Cover Creation Authorisation
                // P to C
                "MarginCoverCreationAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 875-01 Margin Cover Creation Rejection
                // P to C
                "MarginCoverCreationRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 877-01 Margin Cover Removal Request
                // P to C
                "MarginCoverRemovalRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 879-01 Margin Cover Removal Authorisation
                // P to C
                "MarginCoverRemovalAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 881-01 Income Statement Authorisation
                // R to C
                "IncomeStatementAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 883-01 ASX Clear Removal Margin Cover
                // P to C
                "ASXClearRemovalMarginCover" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 885-01 ASX Clear Margin Cover Removal Request
                // P to C
                "ASXClearMarginCoverRemovalRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false)
                }),

                // 887 N/A
                // 889 N/A
                // 891 N/A
                // 893 N/A
                // 895 N/A
                // 897 N/A
                // 899 N/A
                // 901 N/A
                // 903 N/A
                // 905 N/A

                // 907-01 Income Statement Rejection
                // R to C
                "IncomeStatementRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedRegistryReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 909-01 Excess Cash Standing Instruction Request
                // R to C
                "ExcessCashStandingInstructionRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ExcessCashStandingInstruction, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.RemoveExcessCashStandingInstruction, false)
                }),

                // 911-01 Daily Interest Earned Notification
                // R to C
                "DailyInterestEarnedNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.InterestAmount, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.Principal, true),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.InterestDescription, true),
                    new Tuple<int, bool>((int)MessageField.InterestRate, true)
                }),

                // 913-01 Excess Cash Standing Instruction Authorisation
                // R to C
                "ExcessCashStandingInstructionAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 915-01 Excess Cash Standing Instruction Rejection
                // R to C
                "ExcessCashStandingInstructionRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 917-01 Margin Settlement Notification
                // R to C
                "MarginSettlementNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.CashBalanceBoughtForward, true),
                    new Tuple<int, bool>((int)MessageField.MarginPaymentDate, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.CashPaymentWithdrawal, false),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.CashBalanceCarriedForward, true),
                    new Tuple<int, bool>((int)MessageField.InitialMargin, true),
                    new Tuple<int, bool>((int)MessageField.OtherMargin, true),
                    new Tuple<int, bool>((int)MessageField.UtilisedNon_CashCollateral, true),
                    new Tuple<int, bool>((int)MessageField.Excess_Shortage, true),
                    new Tuple<int, bool>((int)MessageField.ExcessCashStandingInstruction, false),
                    new Tuple<int, bool>((int)MessageField.ResultantCashBalance, false),
                    new Tuple<int, bool>((int)MessageField.ResultantExcess, false)
                }),

                // 919 N/A

                // 921-01 Margin Settlement Amount Change Request
                // R to C
                "MarginSettlementAmountChangeRequest" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 923-01 Margin Settlement Amount Change Authorisation
                // R to C
                "MarginSettlementAmountChangeAuthorisation" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.NewSettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.NewResultantExcess, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 925-01 Margin Settlement Amount Change Rejection
                // R to C
                "MarginSettlementAmountChangeRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 927-01 Collateral Statement Notification
                // R to C
                "CollateralStatementNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.ISIN, false),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.Account, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.Issuer, false),
                    new Tuple<int, bool>((int)MessageField.Reference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.FaceValue, false),
                    new Tuple<int, bool>((int)MessageField.MarketValue, true),
                    new Tuple<int, bool>((int)MessageField.Currency, false),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.ExpiryDate, false),
                    new Tuple<int, bool>((int)MessageField.CollateralType, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.Issue, false),
                    new Tuple<int, bool>((int)MessageField.HaircutRate, true),
                    new Tuple<int, bool>((int)MessageField.LodgementDate, false),
                    new Tuple<int, bool>((int)MessageField.Yield, false),
                    new Tuple<int, bool>((int)MessageField.CollateralValue, true),
                }),

                // 929-01 End Statement Notification
                // R to C
                "EndStatementNotification" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.StatementType, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalStatementCount, true),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true)
                }),

                // 931-01 Margin Cover Removal Rejection
                // R to C
                "MarginCoverRemovalRejection" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 933 N/A
                // 935 N/A
                // 937 N/A
                // 939 N/A
                // 941 N/A
                // 943 N/A
                // 945 N/A
                // 947 N/A
                // 949 N/A
                // 951 N/A
                // 953 N/A
                // 955 N/A

                // 959-01 Registry Income Statement Part B
                // R to C
                "RegistryIncomeStatementPartB" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.CapitalGainDiscount, false),
                    new Tuple<int, bool>((int)MessageField.CapitalGainOther, false),
                    new Tuple<int, bool>((int)MessageField.AnnualCapitalGainTotal, false),
                    new Tuple<int, bool>((int)MessageField.CGTConcession, false),
                    new Tuple<int, bool>((int)MessageField.TaxDeferred, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 961-01 Registry Income Statement Part C AI
                // R to C
                "RegistryIncomeStatementPartCAI" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountCash, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountTax, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsUnfrankedAmountCash, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsUnfrankedAmountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.AIInterestCash, false),
                    new Tuple<int, bool>((int)MessageField.AIInterestTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AIOtherIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.AIOtherIncomeTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AITrustDeductionsCash, false),
                    new Tuple<int, bool>((int)MessageField.AITrustDeductionsTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AINonPrimaryIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.AINonPrimaryIncomeTaxable, false)
                }),

                // 963-01 Registry Income Statement Part C CG
                // R to C
                "RegistryIncomeStatementPartCCG" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.CGDiscountCash, false),
                    new Tuple<int, bool>((int)MessageField.CGDiscountTax, false),
                    new Tuple<int, bool>((int)MessageField.CGDiscountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGTaxConcessionCash, false),
                    new Tuple<int, bool>((int)MessageField.CGTaxConcessionTaxable, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodCash, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodTax, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGDistributedCash, false),
                    new Tuple<int, bool>((int)MessageField.CGDistributedTax, false),
                    new Tuple<int, bool>((int)MessageField.CGTrustDeductionsTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGNet, false)
                }),

                // 965-01 Registry Income Statement Part C FI
                // R to C
                "RegistryIncomeStatementPartCFI" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeTax, false),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeTaxable, false),
                    // FI Cash Cash
                    // FI Cash Tax
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    //FI Cash Cash Sub-Total
                }),

                // 967-02 Registry Income Statement Part C NA
                // R to C
                "RegistryIncomeStatementPartCNA" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.NATaxExemptedAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.NATaxDeferredAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.NAGrossCash, false),
                    new Tuple<int, bool>((int)MessageField.NATaxFreeAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 969-01 Registry Income Statement Part C OD
                // R to C
                "RegistryIncomeStatementPartCOD" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.ODTFNAmountsWithheld, false),
                    new Tuple<int, bool>((int)MessageField.ODOtherExpenses, false),
                    new Tuple<int, bool>((int)MessageField.ODNetCash, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 971-01 End Registry Income Statement Set
                // R to C
                "EndRegistryIncomeStatementSet" => SetFields(new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true)
                }),

                // 973 N/A
                // 975 N/A
                #endregion 801-02 to 976-01
                _ => throw new ArgumentException($"{tp} is an invalid message type.")
            };

            return result;
        }

        public static Tuple<string, string, bool>[] DisassembleMessage(string msg, MessageTypeHandler.MessageType tp)
        {
            var result = Enum.GetName(typeof(MessageTypeHandler.MessageType), tp) switch
            {
                "defaultType" => GetFields(msg, null),

                // 002-02 to 399-01
                #region 002-02 to 399-01
                // 002-02 Effected Demand Single Entry CHESS to CHESS Transfer
                // C to P
                "EffectedDemandSingleEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 004-02 Effected Transferor Submitted Transfer
                // C to P
                "EffectedTransferorSubmittedTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 006-02 Effected Demand Dual Entry CHESS to CHESS Transfer
                // C to P
                "EffectedDemandDualEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, true)
                }),

                // 008-02 Effected CHESS to Registry Movement
                // C to P
                "EffectedCHESStoRegistryMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 010-03 Applied Transferor Submitted Transfer
                // C to P
                "AppliedTransferorSubmittedTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 012-03 Unmatched Demand Dual Entry CHESS to CHESS Transfer
                // C to P
                "UnmatchedDemandDualEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false),
                    // Secondary Matching Flag
                }),

                // 014 N/A

                // 016-02 Accepted Registry to CHESS Movement Request
                // C to P
                "AcceptedRegistrytoCHESSMovementRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 018-02 Effected Securities Transformation
                // C to P
                "EffectedSecuritiesTransformation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ReducingSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ReducingUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReducingHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true)
                }),

                // 020-01 ASX Clear Accepted Collateral
                // C to P
                "ASXClearAcceptedCollateral" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 022-03 Effected Holding Adjustment
                // C to P
                "EffectedHoldingAdjustment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true)
                }),

                // 024-01 Rejected Demand Dual Entry CHESS to CHESS Transfer
                // C to P
                "RejectedDemandDualEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedTransferReason, true)
                }),

                // 026 N/A

                // 028-01 Created Collateral
                // C to P
                "CreatedCollateral" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.MarginLender, false),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.SpecificCover, false)
                }),

                // 030-01 Reduced Collateral
                // C to P
                "ReducedCollateral" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMarginCover, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 032-01 Effected Takeover Acceptance
                // C to P
                "EffectedTakeoverAcceptance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 034-01 Effected Takeover Transfer
                // C to P
                "EffectedTakeoverTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                }),

                // 036-01 Offeror Takeover Acceptance Rejection
                // C to P
                "OfferorTakeoverAcceptanceRejection" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 038-01 Reversed Takeover Acceptance
                // C to P
                "ReversedTakeoverAcceptance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 040-01 Accepted Collateral Removal Request
                // C to P
                "AcceptedCollateralRemovalRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 042-05 Collateral Release
                // C to P
                "CollateralRelease" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransferorOptionsCover, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                }),

                // 044 N/A
                // 046 N/A

                // 048-01 Cancelled Demand Dual Entry Transfer Request
                // C to P
                "CancelledDemandDualEntryTransferRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 050-02 Effected Security Code Change
                // C to P
                "EffectedSecurityCodeChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RevisedSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true)
                }),

                // 052-03 Full Dual Entry CHESS to CHESS Transfer
                // C to P
                "FullDualEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingSupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringSupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.CancelledTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 054-04 Full CHESS to Certificated Transfer
                // C to P
                "FullCHESStoCertificatedTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false)
                }),

                // 056-03 Full Certificated to CHESS Transfer
                // C to P
                "FullCertificatedtoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.BalanceInstruction, false),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.CertificateQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 058-03 Full Certificated to CHESS Conversion
                // C to P
                "FullCertificatedtoCHESSConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 060-03 Full Issuer Sponsored to CHESS Transfer
                // C to P
                "FullIssuerSponsoredtoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 062-03 Full Issuer Sponsored to CHESS Conversion
                // C to P
                "FullIssuerSponsoredtoCHESSConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 064 N/A
                // 066 N/A

                // 068-04 Full CHESS to Issuer Sponsored Transfer
                // C to P
                "FullCHESStoIssuerSponsoredTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 070-03 Full CHESS to Certificated Conversion
                // C to P
                "FullCHESStoCertificatedConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 072-03 Full CHESS to Certificated Conversion
                // C to P
                "FullCHESStoIssuerSponsoredConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 074-03 Full Single Entry CHESS to CHESS Transfer
                // C to P
                "FullSingleEntryCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReducingHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.IncreasingHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 076-02 Rejected Registry to CHESS Movement
                // C to P
                "RejectedRegistrytoCHESSMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedMovementReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 078-02 Rejected Collateral Removal
                // C to P
                "RejectedCollateralRemoval" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 080-02 Rejected Registration Details Update
                // C to P/PISP
                "RejectedRegistrationDetailsUpdate" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedRegistrationUpdateReason, true)
                }),

                // 082-02 Adjusted Subposition
                // C to P/PISP
                "AdjustedSubposition" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.SubpositionType, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewSubpositionBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 084-01 Effected Participant Transaction
                // C to P/PISP
                "EffectedParticipantTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 086-01 Accepted Takeover Acceptance Removal Request
                // C to P/PISP
                "AcceptedTakeoverAcceptanceRemovalRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                }),

                // 088-01 Rejected Takeover Acceptance Removal Request
                // C to P/PISP
                "RejectedTakeoverAcceptanceRemovalRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                }),

                // 090-03 Full Transferor Submitted Demand Transfer
                // C to P
                "FullTransferorSubmittedDemandTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 092-01 Offeror Takeover Acceptance Removal Notification
                // C to P/PISP
                "OfferorTakeoverAcceptanceRemovalNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceRemovalReason, false)
                }),

                // 094 N/A

                // 096-01 Security Detail
                // C to P/PISP
                "SecurityDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.FirstListedDate, true),
                    new Tuple<int, bool>((int)MessageField.LastListedDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Exchange, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SubregisterStatus, true)
                }),

                // 098-01 Price Notification Acceptance
                // C to P/PISP
                "PriceNotificationAcceptance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 100-01 Trade Removal Notification
                // C to P/PISP
                "TradeRemovalNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RemovalReason, true)
                }),

                // 102-02 Unmatched Dual Entry Settlement Notification
                // C to P
                "UnmatchedDualEntrySettlementNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TradeDate, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true), // Payer PID
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true), // Payee PID
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 104-01 Collateral Removal Notification
                // C to P/PISP
                "CollateralRemovalNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RemovalDate, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Reason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true)
                }),

                // 106-01 Scheduled Single Entry Settlement CHESS to CHESS Transfer
                // C to P/PISP
                "ScheduledSingleEntrySettlementCHESStoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 108-01 Collateral Creation Acceptance Advice
                // C to P/PISP
                "CollateralCreationAcceptanceAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MarginLender, false),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 110-01 CP Collateral Removal Acceptance Advice
                // C to P/PISP
                "CPCollateralRemovalAcceptanceAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 112 N/A
                // 114 N/A

                // 116-02 Cancelled Settlement Instruction
                // C to P/PISP
                "CancelledSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 118-01 Cancelled Change Settlement Instruction Request
                // C to P/PISP
                "CancelledChangeSettlementInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 120-01 CP Collateral Removal Rejection Advice
                // C to P/PISP
                "CPCollateralRemovalRejectionAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 122-01 Unmatched Change Settlement Instruction Request
                // C to P/PISP
                "UnmatchedChangeSettlementInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 124-01 Rescheduled Settlement Instruction
                // C to P/PISP
                "RescheduledSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RescheduleReason, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 126-01 Updated Settlement Instruction
                // C to P/PISP
                "UpdatedSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 128-02 Adjusted Settlement Instruction
                // C to P
                "AdjustedSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.PreviousTransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RevisedStatus, false),
                    new Tuple<int, bool>((int)MessageField.PreviousStatus, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove1, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove2, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove3, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove4, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove5, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PreviousUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.RevisedUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentType, false),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdjustmentReason, true),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove1, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove2, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove3, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove4, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove5, false),
                    new Tuple<int, bool>((int)MessageField.RevisedTransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.PreviousGuaranteedForeignIndicator, false),
                    new Tuple<int, bool>((int)MessageField.RevisedGuaranteedForeignIndicator, false)
                }),

                // 130-02 Requested Settlement Instruction Change
                // C to P
                "RequestedSettlementInstructionChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdateGuaranteedForeignIndicator, false)
                }),

                // 132-01 Removed Dual Entry Settlement Instruction Cancellation Request
                // C to P/PISP
                "RemovedDualEntrySettlementInstructionCancellationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 134-01 Scheduled Net Broker Broker Obligation
                // C to P/PISP
                "ScheduledNetBrokerBrokerObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 136-01 Reinstated Broker Broker Trade
                // C to P/PISP
                "ReinstatedBrokerBrokerTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 138-01 Netted Broker Broker Trade
                // C to P/PISP
                "NettedBrokerBrokerTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 140-01 Cancelled Net Broker Broker Obligation
                // C to P/PISP
                "CancelledNetBrokerBrokerObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true)
                }),

                // 142-02 Accrued Settlement Instruction
                // C to P
                "AccruedSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ParentTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentType, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 144-01 Effected CP Transaction
                // C to P/PISP
                "EffectedCPTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 146-03 Effected Net Settlement Movement
                // C to P
                "EffectedNetSettlementMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 148-01 Projected Cum Entitlement Position
                // C to P/PISP
                "ProjectedCumEntitlementPosition" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Sign, true),
                    new Tuple<int, bool>((int)MessageField.ProjectedSecurityPosition, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ExDate, true)
                }),

                // 150-01 Projected Funds Obligation
                // C to P/PISP
                "ProjectedFundsObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProjectedFundsPosition, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SettlementStep, false)
                }),

                // 152-01 Projected Securities Position
                // C to P/PISP
                "ProjectedSecuritiesPosition" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Sign, true),
                    new Tuple<int, bool>((int)MessageField.ProjectedSecurityPosition, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 154-01 Cancelled Funds Obligation
                // C to P/PISP
                "CancelledFundsObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.AuthorisedAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 156-01 Settled Settlement Instruction
                // C to P/PISP
                "SettledSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SettledTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingNetMovementTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringNetMovementTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.NetFundsTransactionId, false)
                }),

                // 158-01 Participant Counterparty Balance
                // C to P/PISP
                "ParticipantCounterpartyBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true)
                }),

                // 160-01 Collateral Removal Rejection Advice
                // C to P/PISP
                "CollateralRemovalRejectionAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 162-01 Suspended Settlement Instruction
                // C to P/PISP
                "SuspendedSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SuspensionReason, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 164-03 Notified Broker Broker Trade
                // C to P/PISP
                "NotifiedBrokerBrokerTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TradeExecutionTime, true),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BuyerId, true),
                    new Tuple<int, bool>((int)MessageField.SellerId, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.TradeReason, true),
                    new Tuple<int, bool>((int)MessageField.NovationIndicator, true),
                    new Tuple<int, bool>((int)MessageField.BuyerOrderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.SellerOrderReferenceNumber, false)
                }),

                // 166-01 Suspended Settlement Instruction
                // C to P/PISP
                "ScheduledDualEntrySettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, true)
                }),

                // 168-01 CP Collateral Removal Authorisation Request
                // C to P/PISP
                "CPCollateralRemovalAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 170-01 Effected Net Funds Movement
                // C to P/PISP
                "EffectedNetFundsMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NetFundsTransactionId, true)
                }),

                // 172-02 Effected Registry to CHESS Conversion
                // C to P
                "EffectedRegistrytoCHESSConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 174-02 Effected Registry to CHESS Transfer
                // C to P
                "EffectedRegistrytoCHESSTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.MarkingNumber, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 176-01 Collateral Creation Rejection Advice
                // C to P/PISP
                "CollateralCreationRejectionAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MarginLender, false),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 178-01 Unmatched Dual Entry Settlement Instruction Cancellation Request
                // C to P/PISP
                "UnmatchedDualEntrySettlementInstructionCancellationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true)
                }),

                // 180-02 Full Settlement Instruction
                // C to P/PISP
                "FullSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.OutstandingSettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingSupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ParentTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OutstandingUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringSupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.StampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true)
                }),

                // 182-01 Collateral Removal to CP Notification
                // C to P/PISP
                "CollateralRemovaltoCPNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 184-01 Trade Registration Acceptance
                // C to P/PISP
                "TradeRegistrationAcceptance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 186-01 Net Trust Amount Movement
                // C to P/PISP
                "NetTrustAmountMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TrustAmount, true)
                }),

                // 188-02 Full Adjusted Settlement Instruction
                // C to P/PISP
                "FullAdjustedSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.PreviousTransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.PreviousDeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.PreviousReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RevisedStatus, false),
                    new Tuple<int, bool>((int)MessageField.PreviousStatus, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove1, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove2, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove3, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove4, false),
                    new Tuple<int, bool>((int)MessageField.PreviousOverrideBasisOfMove5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PreviousUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.RevisedUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.RevisedUnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RevisedDeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.PreviousStampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.RevisedStampingConsideration, false),
                    new Tuple<int, bool>((int)MessageField.PreviousDutyType, false),
                    new Tuple<int, bool>((int)MessageField.PreviousUnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.ExDate, false),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentType, false),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentNumber, false),
                    new Tuple<int, bool>((int)MessageField.Timestamp, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.MatchedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdjustmentHistoryStatus, true),
                    new Tuple<int, bool>((int)MessageField.AccrualNumber, false),
                    new Tuple<int, bool>((int)MessageField.AdjustmentReason, true),
                    new Tuple<int, bool>((int)MessageField.CancelledTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove1, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove2, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove3, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove4, false),
                    new Tuple<int, bool>((int)MessageField.RevisedOverrideBasisOfMove5, false),
                    new Tuple<int, bool>((int)MessageField.RevisedDutyType, false),
                    new Tuple<int, bool>((int)MessageField.PreviousDutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.RevisedDutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.RevisedReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.RevisedTransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.PreviousGuaranteedForeignIndicator, false),
                    new Tuple<int, bool>((int)MessageField.RevisedGuaranteedForeignIndicator, false)
                }),

                // 190-01 Predicted Partial Fail Advice
                // C to P/PISP
                "PredictedPartialFailAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.FailingUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 192-01 Part-Settled Settlement Instruction
                // C to P/PISP
                "Part_SettledSettlementInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Part_SettledTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PreviousUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.RevisedUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SettledTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingNetMovementTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringNetMovementTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.NetFundsTransactionId, false),
                }),

                // 194-01 Unmatched Dual Entry Request
                // C to P
                "UnmatchedDualEntryRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 196-01 Blocked Broker Broker Trade
                // C to P
                "BlockedBrokerBrokerTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BlockingTransactionId, true)
                }),

                // 198-01 Unblocked Broker Broker Trade
                // C to P
                "UnblockedBrokerBrokerTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnblockingTransactionId, true)
                }),

                // 200 N/A

                // 202-01 Accepted New Registration Details
                // C to P/PISP
                "AcceptedNewRegistrationDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 204-01 Locked CHESS Holding
                // C to P
                "LockedCHESSHolding" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 206-01 Unlocked CHESS Holding
                // C to P
                "UnlockedCHESSHolding" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 208 N/A
                // 210 N/A
                // 212 N/A
                // 214 N/A
                // 216 N/A

                // 218-01 Accepted Registration Details Update
                // C to P
                "AcceptedRegistrationDetailsUpdate" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 220-02 Authorised Registration Details
                // C to P
                "AuthorisedRegistrationDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.HolderType, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EntrepotType, false),
                    new Tuple<int, bool>((int)MessageField.HolderStatus, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetailsUpdateReason, true)
                }),

                // 222-04 Holder Detail
                // C to P/PISP
                "HolderDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.StatementRequired, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EntrepotType, false),
                    new Tuple<int, bool>((int)MessageField.AdviceReason, true),
                    new Tuple<int, bool>((int)MessageField.HolderStatus, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false)
                }),

                // 224-03 Holder History
                // C to P/PISP
                "HolderHistory" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.StatementRequired, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EntrepotType, false),
                    new Tuple<int, bool>((int)MessageField.Timestamp, true),
                    new Tuple<int, bool>((int)MessageField.ResponseTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HolderStatus, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false)
                }),

                // 226-01 User Detail
                // C to P/PISP
                "UserDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Contact, true),
                    new Tuple<int, bool>((int)MessageField.DefaultSettlementHIN, false),
                    new Tuple<int, bool>((int)MessageField.DefaultDemandHIN, false),
                    new Tuple<int, bool>((int)MessageField.UIC, true),
                    new Tuple<int, bool>((int)MessageField.MasterUIC, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DefaultAccumulationHIN, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantType, false),
                    new Tuple<int, bool>((int)MessageField.Name, true),
                    new Tuple<int, bool>((int)MessageField.Address, true),
                    new Tuple<int, bool>((int)MessageField.SecurityCodePreference, true),
                    new Tuple<int, bool>((int)MessageField.UserStatus, true),
                    new Tuple<int, bool>((int)MessageField.UserType, true)
                }),

                // 228-01 User History
                // C to P/PISP
                "UserHistory" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Contact, true),
                    new Tuple<int, bool>((int)MessageField.DefaultSettlementHIN, false),
                    new Tuple<int, bool>((int)MessageField.DefaultDemandHIN, false),
                    new Tuple<int, bool>((int)MessageField.UIC, true),
                    new Tuple<int, bool>((int)MessageField.MasterUIC, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DefaultAccumulationHIN, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantType, false),
                    new Tuple<int, bool>((int)MessageField.Timestamp, true),
                    new Tuple<int, bool>((int)MessageField.Name, true),
                    new Tuple<int, bool>((int)MessageField.Address, true),
                    new Tuple<int, bool>((int)MessageField.SecurityCodePreference, true),
                    new Tuple<int, bool>((int)MessageField.UserStatus, true),
                    new Tuple<int, bool>((int)MessageField.UserType, true)
                }),

                // 230-01 Payment Facility Detail
                // C to P/PISP
                "paymentFacilityDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.DefaultPaymentFacilityIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 232-01 Payment Facility History
                // C to P/PISP
                "PaymentFacilityHistory" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.DefaultPaymentFacilityIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityChangeReason, true),
                    new Tuple<int, bool>((int)MessageField.Timestamp, true),
                }),

                // 234-03 Reporting Request Detail
                // C to P/PISP
                "ReportingRequestDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCodeParameter, false),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.ReportingStartDate, false),
                    new Tuple<int, bool>((int)MessageField.ReportingEndDate, false),
                    new Tuple<int, bool>((int)MessageField.HINParameter, false),
                    new Tuple<int, bool>((int)MessageField.PIDParameter, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityParameter, false),
                    new Tuple<int, bool>((int)MessageField.SubpositionTypeParameter, false),
                    new Tuple<int, bool>((int)MessageField.TakeoverCodeParameter, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ReportingRequestStatus, true),
                    new Tuple<int, bool>((int)MessageField.ReportingId, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingFrequency, true),
                    new Tuple<int, bool>((int)MessageField.ExDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.NumberOfDaysParameter, false),
                    new Tuple<int, bool>((int)MessageField.PositionTypeParameter, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingPoint, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingPeriod, false),
                    new Tuple<int, bool>((int)MessageField.StartDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.EndDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.AsAtDateParameter, false),
                    new Tuple<int, bool>((int)MessageField.ReportingIdParameter, false),
                    new Tuple<int, bool>((int)MessageField.TransactionClassParameter, false),
                    new Tuple<int, bool>((int)MessageField.AdditionalReportingParameter, false)
                }),

                // 236 N/A
                // 238 N/A

                // 240-01 Created Payment Facility
                // C to P/PISP
                "CreatedPaymentFacility" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.BankUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DefaultPaymentFacilityIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 242-01 Applied Payment Facility Update
                // C to P/PISP
                "AppliedPaymentFacilityUpdate" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.BankUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityChangeReason, true)
                }),

                // 244-01 Cancelled Payment Facility
                // C to P/PISP
                "CancelledPaymentFacility" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 246-01 Accepted Change Controlling Participant Request
                // C to P
                "AcceptedChangeControllingParticipantRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 248-01 Change Controlling Participant Authorisation Request
                // C to P
                "ChangeControllingParticipantAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.RequestingParticipant, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 250-01 Cancelled Change Controlling Participant Request
                // C to P
                "CancelledChangeControllingParticipantRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true)
                }),

                // 252-01 Effected Controlling Participant Change
                // C to P
                "EffectedChangeControllingParticipant" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.OldControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.NewControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 254-01 Rejected Change Controlling Participant
                // N/A - See 256-01

                // 256-01 Rejected Change Controlling Participant (Reject)
                // C to P
                "AppliedChangeControllingParticipantReject" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true)
                }),

                // 258 N/A
                // 260 N/A
                // 262 N/A
                // 264 N/A
                // 266 N/A
                // 268 N/A
                // 270 N/A

                // 272-01 Accepted Loan Instruction
                // C to P
                "AcceptedLoanInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 274-01 Adjusted Loan
                // C to P
                "AdjustedLoan" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.PreviousLoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.RevisedLoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.RevisedSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PreviousUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.RevisedUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LoanTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentType, true),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentNumber, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AccrualNumber, true)
                }),

                // 276-02 Accrued Loan
                // C to P
                "AccruedLoan" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.LoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.ParentTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LoanTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DiaryAdjustmentType, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 278-01 Scheduled Loan Instruction
                // C to P
                "ScheduledLoanInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.LoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LoanTransactionId, true)
                }),

                // 280-01 Bulk Loan Application
                // C to P
                "BulkLoanApplication280" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.LoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 282-01 Rejected Loan Application
                // C to P
                "RejectedLoanApplication" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 284-01 Cancelled Loan Instruction
                // C to P
                "CancelledLoanInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true)
                }),

                // 286-01 Full Loan Instruction
                // C to P
                "FullLoanInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.LoanConsideration, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, false),
                    new Tuple<int, bool>((int)MessageField.ParentTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OutstandingUnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OutstandingLoanConsideration, false),
                    new Tuple<int, bool>((int)MessageField.LoanTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ApprovedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.ApprovedTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.CancelledTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.SLSLoanInstructionStatus, true)
                }),

                // 288 N/A
                // 290 N/A
                // 292 N/A
                // 294 N/A
                // 296 N/A
                // 298 N/A

                // 300-01 Participant Funds Notification
                // C to P
                "ParticipantFundsNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantName, true)
                }),

                // 302-01 Bank Funds Notification
                // C to P
                "BankFundsNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true)
                }),

                // 304 N/A
                // 306 N/A
                // 308 N/A

                // 310-01 Participant Funds Obligation
                // C to P
                "ParticipantFundsObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AuthorisationRequired, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.TrustAmount, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantName, true),
                    new Tuple<int, bool>((int)MessageField.AuthorisationReason, true)
                }),

                // 312-01 Bank Funds Obligation
                // C to P
                "BankFundsObligation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.AuthorisationReason, true)
                }),

                // 314 N/A
                // 316 N/A
                // 318 N/A
                // 320 N/A
                // 322 N/A
                // 324 N/A
                // 326 N/A
                // 328 N/A
                // 330 N/A

                // 332-01 Bank Funds Transfer Request
                // C to P
                "BankFundsTransferRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true)
                }),

                // 324 N/A
                // 326 N/A
                // 328 N/A

                // 340-01 Effected Create Net Position
                // C to P
                "EffectedCreateNetPosition" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 342-01 Create Net Position Record Authorisation Request
                // C to P
                "CreateNetPositionRecordAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapLimit, false),
                    new Tuple<int, bool>((int)MessageField.DebitCapActivityFlag, true)
                }),

                // 344-01 Accepted Create Net Position Response
                // C to P
                "Accepted Create Net Position Response" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 346-01 Applied Create Net Position Response
                // C to P
                "AppliedCreateNetPositionResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 348-01 Rejected Create Net Position
                // C to P
                "RejectedCreateNetPosition" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedNetPositionReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 350-01 Clearing Account Transfer Request
                // C to P
                "ClearingAccountTransferRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.BankUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.Name, true),
                    new Tuple<int, bool>((int)MessageField.SettlementStep, false)
                }),

                // 352-01 Create Cash Subrecord Authorisation Request
                // C to P
                "CreateCashSubrecordAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordType, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapExclusionFlag, true)
                }),

                // 354-01 Accepted Create Cash Subrecord Response
                // C to P
                "AcceptedCreateCashSubrecordResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 356-01 Effected Create Cash Subrecord
                // C to P
                "EffectedCreateCashSubrecord" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 358-01 Applied Create Cash Subrecord Response
                // C to P
                "AppliedCreateCashSubrecordResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 360-01 Rejected Create Cash Subrecord
                // C to P
                "RejectedCreateCashSubrecord" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.CreateCashSubrecordRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true)
                }),

                // 362-01 CHESS DvP Notification
                // C to P
                "CHESSDvPNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.DvPDeclarationTimestamp, true)
                }),

                // 364 N/A
                // 366 N/A
                // 368 N/A
                // 370 N/A

                // 372-01 Changed Net Position Attributes Notification
                // C to P
                "ChangedNetPositionAttributesNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NetPositionActivityFlag, false),
                    new Tuple<int, bool>((int)MessageField.CurrentorNewDebitCapLimit, true),
                    new Tuple<int, bool>((int)MessageField.DebitCapActivityFlag, false)
                }),

                // 374-01 Changed Net Position Attributes Confirmation
                // C to P
                "ChangedNetPositionAttributesConfirmation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 376-01 Bank Change Cash Subrecord Attributes Confirmation
                // C to P
                "BankChangeCashSubrecordAttributesConfirmation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 378-01 Accepted Participant Change Cash Subrecord Attributes
                // C to P
                "AcceptedParticipantChangeCashSubrecordAttributes" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 380-01 Participant Change Cash Subrecord Attributes Authorisation Request
                // C to P
                "ParticipantChangeCashSubrecordAttributesAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordType, false),
                    new Tuple<int, bool>((int)MessageField.DebitCapExclusionFlag, false)
                }),

                // 382-01 Effected Participant Change Cash Subrecord Attributes
                // C to P
                "EffectedParticipantChangeCashSubrecordAttributes" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 384-01 Applied Participant Change Cash Subrecord Attributes
                // C to P
                "AppliedParticipantChangeCashSubrecordAttributes" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 386-01 Rejected Participant Change Cash Subrecord Attributes
                // C to P
                "RejectedParticipantChangeCashSubrecordAttributes" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.ChangeCashSubrecordRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 388 N/A
                // 390 N/A
                // 392 N/A
                // 394 N/A
                // 396 N/A

                // 398-01 Settlement Cancellation Notification
                // C to P
                "SettlementCancellationNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true)
                }),
                #endregion 001-02 to 399-01

                // 401-01 to 800-02
                #region 401-01 to 800-02
                // 402-02 Certificated to CHESS Conversion Authorisation Request
                // C to R
                "CertificatedtoCHESSConversionAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 404-03 Issuer Sponsored to CHESS Conversion Authorisation Request
                // C to R
                "IssuerSponsoredtoCHESSConversionAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.PIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 406-02 Certificated to CHESS Transfer Authorisation Request
                // C to R
                "CertificatedtoCHESSTransferAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.BalanceInstruction, false),
                    new Tuple<int, bool>((int)MessageField.CertificateNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.CertificateQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 408-03 Issuer Sponsored to CHESS Transfer Authorisation Request
                // C to R
                "IssuerSponsoredtoCHESSTransferAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.PIN, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 410-01 Requested Settlement Type Change
                // C to R
                "RequestedSettlementTypeChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.DestinationSettlementSystem, true)
                }),

                // 412-03 CHESS to Certificated Conversion
                // C to R
                "CHESStoCertificatedConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 414-04 CHESS to Certificated Transfer
                // C to R
                "CHESStoCertificatedTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 416-03 CHESS to Issuer Sponsored Conversion
                // C to R
                "CHESStoIssuerSponsoredConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 418-04 CHESS to Issuer Sponsored Transfer
                // C to R
                "CHESStoIssuerSponsoredTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.LocationofRegister, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 420 N/A

                // 422-02 Applied Registry Transaction
                // C to R
                "AppliedRegistryTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 424 N/A

                // 426-02 Applied Registry Authorisation Response
                // C to R
                "AppliedRegistryAuthorisationResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 428 N/A

                // 430-02 Applied Code Change
                // C to R
                "AppliedCodeChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.RevisedSecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 432-02 Cancelled Offeror Initiated TKO Acceptance Request
                // C to R
                "CancelledOfferorInitiatedTKOAcceptanceRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 434 N/A
                // 436 N/A
                // 438 N/A
                // 440 N/A

                // 442-01 Cancelled Change RTGS Instruction Request
                // C to R
                "CancelledChangeRTGSInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 444-01 Unmatched Change Settlement Type Request
                // C to R
                "UnmatchedChangeSettlementTypeRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false),
                    new Tuple<int, bool>((int)MessageField.DestinationSettlementSystem, true)
                }),

                // 446-01 Updated RTGS Instruction
                // C to R
                "UpdatedRTGSInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 448-01 Adjusted Settlement Type
                // C to R
                "AdjustedSettlementType" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PreviousSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.RevisedSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.PreviousHIN, false),
                    new Tuple<int, bool>((int)MessageField.RevisedHIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId , true),
                    new Tuple<int, bool>((int)MessageField.Part_Settlement, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId , true),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false),
                    new Tuple<int, bool>((int)MessageField.PreviousDestinationSettlementSystem, false),
                    new Tuple<int, bool>((int)MessageField.RevisedDestinationSettlementSystem, false)
                }),

                // 450-01 Cancelled Request to Change Settlement Type
                // C to R
                "CancelledRequesttoChangeSettlementType" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MatchingTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.CancellationReason , true)
                }),

                // 452-01 CHESS to Participant SRN Request Acknowledgment
                // C to R
                "CHESStoParticipantSRNRequestAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 454-01 CHESS to Registry SRN Request
                // C to R
                "CHESSToRegistrySRNRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true)
                }),

                // 456-01 CHESS to Registry SRN Response Acknowledgment
                // C to R
                "CHESSToRegistrySRNResponseAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 458-01 CHESS to Participant SRN Response
                // C to R
                "CHESStoParticipantSRNResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 460-01 CHESS to Registry SRN Reject Acknowledgment
                // C to R
                "CHESSToRegistrySRNRejectAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 462-01 CHESS to Participant SRN Reject
                // C to R
                "CHESStoParticipantSRNReject" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 464-01 CHESS to Participant Holding Balance Request Acknowledgment
                // C to R
                "CHESStoParticipantHoldingBalanceRequestAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 466-01 CHESS to Registry Holding Balance Request
                // C to R
                "CHESStoRegistryHoldingBalanceRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true)
                }),

                // 468-01 CHESS to Registry Holding Balance Response Acknowledgment
                // C to R
                "CHESStoRegistryHoldingBalanceResponseAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 470-01 CHESS to Participant Holding Balance Response
                // C to R
                "CHESStoParticipantHoldingBalanceResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalanceTimestamp, true)
                }),

                // 472-01 CHESS to Registry Holding Balance Reject Acknowledgment
                // C to R
                "CHESStoRegistryHoldingBalanceRejectAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 474-01 CHESS to Participant Holding Balance Reject
                // C to R
                "CHESStoParticipantHoldingBalanceReject" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 476-01 Authorise RTGS Instruction Confirmation
                // C to R
                "AuthoriseRTGSInstructionConfirmation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 478-01 Unmatched Change RTGS Instruction Request
                // C to R
                "UnmatchedChangeRTGSInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true)
                }),

                // 480-01 Requested RTGS Instruction Change
                // C to R
                "RequestedRTGSInstructionChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SettlementInstructionStatus, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdatingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UpdateGuaranteedForeignIndicator, false)
                }),

                // 482-01 Unmatched RTGS Dual Entry Notification
                // C to R
                "UnmatchedRTGSDualEntryNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, false),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TradeDate, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.OverrideBasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false)
                }),

                // 484-01 Unmatched RTGS Dual Entry Request
                // C to R
                "UnmatchedRTGSDualEntryRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ScheduleTransactionforSettlement, false)
                }),

                // 486 N/A
                // 488 N/A

                // 490-01 Unmatched RTGS Instruction Cancellation Request
                // C to R
                "UnmatchedRTGSInstructionCancellationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true)
                }),

                // 492-01 Removed RTGS Instruction Cancellation Request
                // C to R
                "RemovedRTGSInstructionCancellationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationReason, true)
                }),

                // 494 N/A

                // 496-01 Checking RBA Funds Queue Advice
                // C to R
                "CheckingRBAFundsQueueAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 498 N/A

                // 500-01 RTGS Instruction Ready to Settle Advice
                // C to R
                "RTGSInstructionReadytoSettleAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 502-02 Holding Subposition Detail
                // C to R
                "HoldingSubpositionDetail" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SubpositionType, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, false),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdviceReason, true)
                }),

                // 504-01 Cum Entitlement Daily Balance
                // C to R
                "CumEntitlementDailyBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ExDate, true)
                }),

                // 506-01 Cum Entitlement Net Movement
                // C to R
                "CumEntitlementNetMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.NetOffs, true),
                    new Tuple<int, bool>((int)MessageField.NetOns, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.MovementfromRegistry, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MovementtoRegistry, true),
                    new Tuple<int, bool>((int)MessageField.ExDate, true)
                }),

                // 508-01 Holding Daily Balance
                // C to R
                "HoldingDailyBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 510-01 Holding Net Movement
                // C to R
                "HoldingNetMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.NetOffs, true),
                    new Tuple<int, bool>((int)MessageField.NetOns, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.MovementfromRegistry, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.MovementtoRegistry, true)
                }),

                // 512-04 Holding Registration Details
                // C to R
                "HoldingRegistrationDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetailsIndicator, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.HolderStatus, false),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.EmailCancellation, false)
                }),

                // 514-01 Aggregated Foreign to Foreign Allocations
                // C to User
                "AggregatedForeigntoForeignAllocations" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignNetOffs, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignNetOns, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedMovementfromRegistry, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedMovementtoRegistry, true)
                }),

                // 516-01 Rights Accepted
                // C to User
                "RightsAccepted" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 518-01 Rejected Transaction
                // C to User
                "RejectedTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 520-02 Cum Entitlement Balance
                // C to User
                "CumEntitlementBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EntitlementBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ExDate, true),
                    new Tuple<int, bool>((int)MessageField.AdviceReason, true)
                }),

                // 522-02 Holding Balance
                // C to User
                "HoldingBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TotalUnitBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdviceReason, true)
                }),

                // 524-01 Total Cum Entitlement Balance
                // C to User
                "TotalCumEntitlementBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ExDate, true)
                }),

                // 526-01 Accepted Reporting Request
                // C to User
                "AcceptedReportingRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 528-01 Archived Sub-Register
                // C to P
                "ArchivedSubRegister" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 530-01 Cancelled Reporting Request
                // C to P
                "CancelledReportingRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 532-01 Total Security Balance
                // C to P
                "TotalSecurityBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TotalUnitsOnSub_Register, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 534-02 Notified Tax File Number / Australian Business Number
                // C to R
                "NotifiedTaxFileNumberorAustralianBusinessNumber" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false)
                }),

                // 536-01 Accepted Tax File Number / Australian Business Number Advice
                // C to P
                "AcceptedTaxNumberOrAustralianBusinessNumberAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 538-01 End of Reporting
                // C to User
                "EndofReporting" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 540-01 Invalid Transaction
                // C to User
                "InvalidTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.InvalidReason, true),
                    new Tuple<int, bool>((int)MessageField.InvalidMessageHeader, true)
                }),

                // 542-01 CHESS Event Notification
                // C to P
                "CHESSEventNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CHESSEventType, true)
                }),

                // 544-01 Levy Notification
                // C to P
                "LevyNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.ShortfallValuation, false),
                    new Tuple<int, bool>((int)MessageField.LevyValue, true),
                    new Tuple<int, bool>((int)MessageField.CorporateActionTypeId, false),
                    new Tuple<int, bool>((int)MessageField.DispatchDate, false),
                    new Tuple<int, bool>((int)MessageField.TransactionDate, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, false),
                    new Tuple<int, bool>((int)MessageField.SecuritiesShortfall, false),
                    new Tuple<int, bool>((int)MessageField.NumberHoldersAffected, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.LevyType, true)
                }),

                // 546-01 Revised Holder Registration Details
                // C to P
                "RevisedHolderRegistrationDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 548-02 Reversed Levy Notification
                // C to P
                "ReversedLevyNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ReversedLevyValue, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LevyType, true)
                }),

                // 550-01 Scheduled Payment Instruction
                // C to P
                "ScheduledPaymentInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PayerPID, true),
                    new Tuple<int, bool>((int)MessageField.PayeePID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.PaymentType, true)
                }),

                // 552-01 Accepted Payment Set
                // C to P
                "AcceptedPaymentSet" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    // Payments to ASX Clear
                    // Payments from ASX Clear
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentSetTransactionId, true)
                }),

                // 554-01 Close Out Notification
                // C to P, R
                "CloseOutNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.OutstandingSettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.OriginalSettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OutstandingUnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false)
                }),

                // 556-01 Cancelled Payment Set Notification
                // C to P
                "CancelledPaymentSetNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentSetTransactionId, true)
                }),

                // 558 N/A

                // 560-01 Top Security Holder Report
                // C to P
                "TopSecurityHolderReport" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.OpeningBalanceDate, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalanceDate, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TotalMovementsOff, true),
                    new Tuple<int, bool>((int)MessageField.TotalMovementsOn, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OpeningBalance, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, true)
                }),

                // 562 N/A
                // 564 N/A
                // 566 N/A
                // 568 N/A
                // 570 N/A
                // 572 N/A
                // 574 N/A
                // 576 N/A
                // 578 N/A
                // 580 N/A
                // 582 N/A
                // 584 N/A
                // 586 N/A
                // 588 N/A
                // 590 N/A
                // 592 N/A
                // 594 N/A
                // 596 N/A
                // 598 N/A
                // 600 N/A

                // 602-02 Top Security Holder Report
                // C to P
                "EffectedASXClearTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 604 N/A
                // 606 N/A
                // 608 N/A

                // 610-04 Collateral Request
                // C to P
                "CollateralRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MarginLender, false),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.SpecificCover, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 612-04 Collateral Removal Authorisation Request
                // C to P
                "CollateralRemovalAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearAccount, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearingMember, true),
                    new Tuple<int, bool>((int)MessageField.ASXClearLodgementNumber, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 614-01 Cash Subrecord Details
                // C to P
                "CashSubrecordDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Amount, true),
                    new Tuple<int, bool>((int)MessageField.SettledTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, false)
                }),

                // 616-01 Cash Subrecord Total
                // C to P
                "CashSubrecordTotal" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, false),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Balance, true),
                    new Tuple<int, bool>((int)MessageField.CashSubrecordID, false)
                }),

                // 618 N/A
                // 620 N/A
                // 622 N/A
                // 624 N/A
                // 626 N/A
                // 628 N/A
                // 630 N/A
                // 632 N/A
                // 634 N/A
                // 636 N/A
                // 638 N/A
                // 640 N/A
                // 642 N/A
                // 644 N/A
                // 646 N/A
                // 648 N/A
                // 650 N/A

                // 652-01 ETC Trade
                // C to P, R
                "ETCTrade" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, false),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, false),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.TradeTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.BuySellIndicator, true),
                    new Tuple<int, bool>((int)MessageField.OrderReference, true),
                    new Tuple<int, bool>((int)MessageField.TradingBroker, true),
                    new Tuple<int, bool>((int)MessageField.CrossingIndicator, false),
                    new Tuple<int, bool>((int)MessageField.PrincipalIndicator, false),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false)
                }),

                // 654-01 ETC Trade Advice Acknowledgment
                // C to P, R
                "ETCTradeAdviceAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 656-02 ETC Trade Allocation
                // C to P, R
                "ETCTradeAllocation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.SettlementCounterpartyPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationStatus, true),
                    new Tuple<int, bool>((int)MessageField.Brokerage, false)
                }),

                // 658-01 ETC Trade Allocation Acknowledgment
                // C to P, R
                "ETCTradeAllocationAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 660-01 ETC Trade Rejection
                // C to P, R
                "ETCTradeRejection" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectionTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ETCRejectionReason, true)
                }),

                // 662-01 ETC Trade Rejection Acknowledgment
                // C to P, R
                "ETCTradeRejectionAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 664-01 Contract Note
                // C to P, R
                "ContractNote" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.InitiatorNameandAddress, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.BuySellIndicator, true),
                    new Tuple<int, bool>((int)MessageField.CrossingIndicator, false),
                    new Tuple<int, bool>((int)MessageField.PrincipalIndicator, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteStatus, true),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.Brokerage, true),
                    new Tuple<int, bool>((int)MessageField.OtherAmount, false),
                    new Tuple<int, bool>((int)MessageField.RecipientName, true),
                    new Tuple<int, bool>((int)MessageField.MemberASXIndicator, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, false),
                    new Tuple<int, bool>((int)MessageField.Remarks, false)
                }),

                // 666-01 Contract Note Advice Acknowledgment
                // C to P, R
                "ContractNoteAdviceAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 668-01 Contract Note Rejection
                // C to P, R
                "ContractNoteRejection" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectionTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ETCRejectionReason, true),
                    new Tuple<int, bool>((int)MessageField.ContractNoteRejectionLevel, true)
                }),

                // 670-01 Contract Note Rejection Acknowledgment
                // C to P, R
                "ContractNoteRejectionAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 672-01 Allocation Cancellation
                // C to P, R
                "AllocationCancellation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AllocationCancellationTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.AllocationCancellationLevel, true)
                }),

                // 674-01 Allocation Cancellation Acknowledgment
                // C to P, R
                "AllocationCancellationAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 676-01 ETC Settlement
                // C to P, R
                "ETCSettlement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.TransactionBasis, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementDate, false),
                    new Tuple<int, bool>((int)MessageField.TradeDate, true),
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.SettlementCounterpartyPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TradeAmount, true),
                    new Tuple<int, bool>((int)MessageField.DutyPayable, true),
                    new Tuple<int, bool>((int)MessageField.DutyType, false),
                    new Tuple<int, bool>((int)MessageField.SettlementAdviceTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode1, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode2, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode3, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode4, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode5, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode6, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode7, false),
                    new Tuple<int, bool>((int)MessageField.ConditionCode8, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfQuotation5, false),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.AccountId, true),
                    new Tuple<int, bool>((int)MessageField.SettlementMatchingDate, false),
                    new Tuple<int, bool>((int)MessageField.Brokerage, true),
                    new Tuple<int, bool>((int)MessageField.Deliver_ReceiveUnitsIndicator, true)
                }),

                // 678-01 ETC Settlement Advice Acknowledgment
                // C to P, R
                "ETCSettlementAdviceAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 680-01 ETC Settlement Cancellation
                // C to P, R
                "ETCSettlementCancellation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ETCSettlementCancelTimestamp, false)
                }),

                // 682-01 ETC Settlement Cancellation Acknowledgment
                // C to P, R
                "ETCSettlementCancellationAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 684-01 ETC Trade Cancellation
                // C to P, R
                "ETCTradeCancellation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationTimestamp, false)
                }),

                // 686-01 ETC Trade Cancellation Acknowledgment
                // C to P, R
                "ETCTradeCancellationAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 688-01 ETC Contract Note Cancellation
                // C to P, R
                "ETCContractNoteCancellation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ETCSourceUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.CancellationTimestamp, false)
                }),

                // 690-01 ETC Contract Note Cancellation Acknowledgment
                // C to P, R
                "ETCContractNoteCancellationAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 692-01 Controlling PID and Holder Status Response
                // C to P, R
                "ControllingPIDandHolderStatusResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPIDStatus, true),
                    new Tuple<int, bool>((int)MessageField.HolderStatus, true)
                }),

                // 694-01 Cancelled Transfer or Conversion Request
                // C to P, R
                "CancelledTransferorConversionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 696 N/A
                // 698 N/A
                // 700 N/A

                // 702-02 Takeover Acceptance Removal Authorisation Request
                // C to PISP or R
                "TakeoverAcceptanceRemovalAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverAcceptanceRemovalReason, false)
                }),

                // 704-02 Takeover Acceptance Notification
                // C to PISP or R
                "TakeoverAcceptanceNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantityAccepted, true),
                    new Tuple<int, bool>((int)MessageField.DistinctPortionIndicator, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 706-02 Effected Offeror Transaction
                // C to PISP or R
                "EffectedOfferorTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 708 N/A

                // 710-01 Rejected Offeror Takeover Acceptance
                // C to PISP or R
                "RejectedOfferorTakeoverAcceptance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TakeoverCode, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 712 N/A
                // 714 N/A

                // 716-01 CHESS Conversion Request to Issuer Sponsored Fund
                // C to PISP or R
                "CHESSConversionRequesttoIssuerSponsoredFund" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 717-01 Effected CHESS Conversion to Issuer Sponsored Fund
                // C to PISP or R
                "EffectedCHESSConversionRequesttoIssuerSponsoredFund" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.NewFundHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 719-02 Issuer Sponsored Fund to CHESS Conversion Authorisation Request
                // C to PISP
                "IssuerSponsoredFundtoCHESSConversionAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.BrokerNonBrokerIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 720-01 Accepted Participant Request
                // C to PISP
                "AcceptedParticipantRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 722-01 Fund Response
                // C to PISP/R
                "FundResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 723-01 Effected Conversion Issuer Sponsored Fund to CHESS
                // C to PISP/R
                "EffectedConversionIssuerSponsoredFundtoCHESS" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NewFundHoldingBalance, true)
                }),

                // 725-01 Rejected Conversion Issuer Sponsored Fund to CHESS
                // C to P
                "RejectedConversionIssuerSponsoredFundtoCHESS" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedMovementReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)

                }),

                // 727-01 Application Order Request
                // C to PISP
                "ApplicationOrderRequest_V01" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.InitialApplication, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.DRPPreference, false),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, false),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TaxResidence1, false),
                    new Tuple<int, bool>((int)MessageField.TaxResidence2, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth1, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth2, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth3, false),
                    new Tuple<int, bool>((int)MessageField.TaxResidence3, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.EmailAddress, false),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.EmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.AML_CTFFlag, true),
                    new Tuple<int, bool>((int)MessageField.FATCAQuestions, true),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAFSLNumber, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantAdvisorName, false),
                    new Tuple<int, bool>((int)MessageField.ParticipantAdvisorCode, false),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    new Tuple<int, bool>((int)MessageField.ProductName, false),
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantAdvisorEmail, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAdvisorEmail, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupName, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAdvisorName, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAdvisorCode, false)
                }),

                // 727-02 Application Order Request
                // C to PISP
                "ApplicationOrderRequest_V02" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.InitialApplication, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AML_CTFFlag, true),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    new Tuple<int, bool>((int)MessageField.ProductName, false),
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 728 N/A

                // 730-02 Effected Application Order/Payment Plan Application Response
                // C to P
                "EffectedApplicationOrderOrPaymentPlanApplicationResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 731-01 Scheduled Settlement Payment Instruction
                // C to P & PISP
                "ScheduledSettlementPaymentInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentHIN, true),
                    new Tuple<int, bool>((int)MessageField.PayingPID, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 733-02 Effected Fund Unit Adjustment
                // C to P
                "EffectedFundUnitAdjustment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.FundReason, true),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.AdjustmentUnits, true),
                    new Tuple<int, bool>((int)MessageField.NewFundHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 734 N/A

                // 736-01 Foreign Tax Status Details
                // C to P
                "ForeignTaxStatusDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ForeignResidencyIndicator, false),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.AddressType, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LinkingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AddressDetails1, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    // Superannuation Fund ABN
                    new Tuple<int, bool>((int)MessageField.AddressDetails2, false),
                    new Tuple<int, bool>((int)MessageField.AddressDetails3, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.AccountType, true),
                    new Tuple<int, bool>((int)MessageField.EntityType, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson1, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth1, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode1C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN1C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent1C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson2, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth2, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode2C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN2C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent2C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPerson3, false),
                    new Tuple<int, bool>((int)MessageField.ForeignPersonDateofBirth3, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignCountryCode3C, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3A, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3B, false),
                    new Tuple<int, bool>((int)MessageField.ForeignTIN3C, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3A, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3B, false),
                    new Tuple<int, bool>((int)MessageField.TINAbsent3C, false),
                    new Tuple<int, bool>((int)MessageField.AdditionalForeignParties, false)
                }),

                // 738-01 Participant Investor Details
                // C to P
                "ParticipantInvestorDetails" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.DRPPreference, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.LinkingTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorMobile, true),
                    new Tuple<int, bool>((int)MessageField.DateofBirth1, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth2, false),
                    new Tuple<int, bool>((int)MessageField.DateofBirth3, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, true),
                    new Tuple<int, bool>((int)MessageField.InvestorMobileContact, true),
                    new Tuple<int, bool>((int)MessageField.InvestorEmailAddress, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.InvestorEmailPurpose, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupAFSLNumber, false),
                    new Tuple<int, bool>((int)MessageField.AdvisorEmail, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.DealerGroupName, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorName, true),
                    new Tuple<int, bool>((int)MessageField.AdvisorCode, true)
                }),

                // 740-01 Cancelled Fund Request
                // C to P
                "CancelledFundRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 742 N/A
                // 744 N/A
                // 746 N/A
                // 748 N/A
                // 750 N/A

                // 752-01 Requesting Funds Approval
                // C to P
                "RequestingFundsApproval" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 754-01 RTGS Settlement Movement
                // C to P
                "RTGSSettlementMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.IncreaseorDecrease, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.NewHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.GuaranteedForeignIndicator, false),
                    new Tuple<int, bool>((int)MessageField.MovementType, true)
                }),

                // 756-01 RTGS Funds Movement
                // C to P
                "RTGSFundsMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CashAccountIdentifier, true),
                    new Tuple<int, bool>((int)MessageField.PaymentFacilityId, true),
                    new Tuple<int, bool>((int)MessageField.PayReceiveIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 758-01 Holding Advice Acknowledgement
                // C to P
                "HoldingAdviceAcknowledgment" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 760-02 Holding Advice Notification
                // C to R
                "HoldingAdviceNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TargetUIC, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.FICode, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.AccountCancellation, false)
                }),

                // 762-01 Effected Registry Transaction
                // C to R
                "EffectedRegistryTransaction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 764-01 Accepted Holding Advice
                // C to R
                "AcceptedHoldingAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 766-01 Rejected Holding Advice
                // C to P
                "RejectedHoldingAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedHoldingAdviceReason, true)
                }),

                // 768 N/A
                // 770 N/A
                // 772 N/A
                // 774 N/A
                // 776 N/A
                // 778 N/A
                // 780 N/A
                // 782 N/A
                // 784 N/A
                // 786 N/A
                // 788 N/A
                // 790 N/A
                // 792 N/A
                // 794 N/A
                // 796 N/A
                // 798 N/A
                #endregion 401-01 to 800-02

                // 801-02 to 976-01
                #region 801-02 to 976-01
                // 801-02 Redemption Order Request
                // C to PISP
                "RedemptionOrderRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.FullRedemption, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionRequestReason, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.ProductName, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 803-01 Effected Redemption Order Request
                // C to P
                "EffectedRedemptionOrderRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 805-01 Order Cancellation Request
                // C to PISP
                "OrderCancellationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OrderType, true)
                }),

                // 807-01 Switch Order Request
                // C to PISP
                "SwitchOrderRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RedemptionFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FullSwitch, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.ApplicationProductName, false),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    new Tuple<int, bool>((int)MessageField.UnitsRedeemed, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionProductName, false),
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionAPIRCode, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationAPIRCode, false)
                }),

                // 809-01 Effected Switch Order Request
                // C to P
                "EffectedSwitchOrderRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RedemptionFundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationFundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.HoldReason, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RedemptionUnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.NettorGross, true),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    new Tuple<int, bool>((int)MessageField.Income, false),
                    new Tuple<int, bool>((int)MessageField.UnitsRedeemed, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionUnitPricingDate, false),
                    new Tuple<int, bool>((int)MessageField.RedemptionAPIRCode, false),
                    new Tuple<int, bool>((int)MessageField.ApplicationAPIRCode, false)
                }),

                // 811-01 Effected Update Order
                // C to P
                "EffectedUpdateOrder" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.CancelReason, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RejectedOrderReason, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, false),
                    new Tuple<int, bool>((int)MessageField.PaymentDate, false)
                }),

                // 812-01 Reminder Notice
                // C to P & PISP
                "ReminderNotice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalReminderCount, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 814 N/A

                // 816-01 Income Statement Advice
                // C to P
                "IncomeStatementAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.GrossIncomeAmount, true),
                    new Tuple<int, bool>((int)MessageField.IncomeNotificationFlag, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.IncomeAmountperUnit, false),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    // Nett Amount
                    new Tuple<int, bool>((int)MessageField.UnitsParticipating, false),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.PaymentDate, true),
                    new Tuple<int, bool>((int)MessageField.RecordDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.TaxCreditAmount, false)
                }),

                // 818-01 Effected Distribution Re-investment Plan Advice
                // C to P
                "EffectedDistributionReinvestmentPlanAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.GrossDRPAmount, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, true),
                    new Tuple<int, bool>((int)MessageField.AdditionalUnits, true),
                    new Tuple<int, bool>((int)MessageField.TaxDeducted, false),
                    new Tuple<int, bool>((int)MessageField.NettDRPAmount, false),
                    new Tuple<int, bool>((int)MessageField.UnitsParticipating, true),
                    new Tuple<int, bool>((int)MessageField.Fees, false),
                    new Tuple<int, bool>((int)MessageField.UnitAllotmentDate, true),
                    new Tuple<int, bool>((int)MessageField.RecordDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 820 N/A

                // 822-01 Cancelled Funds Settlement Payment Instruction
                // C to P/PISP
                "CancelledFundsSettlementPaymentInstruction" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.FundAmount, true),
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentHIN, true),
                    new Tuple<int, bool>((int)MessageField.PayingPID, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 824-01 Change Settlement Date
                // C to P/PISP
                "ChangeSettlementDate" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementDate, true),
                    new Tuple<int, bool>((int)MessageField.PaymentHIN, true),
                    new Tuple<int, bool>((int)MessageField.PayingPID, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true)
                }),

                // 826 N/A
                // 828 N/A

                // 830-01 Holding Daily Fund Balance
                // C to P or PISP
                "HoldingDailyFundBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ClosingFundBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 831-01 Holding Net Fund Movement
                // C to R
                "HoldingNetFundMovement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.FundNetOffs, true),
                    new Tuple<int, bool>((int)MessageField.ClosingFundBalance, true),
                    new Tuple<int, bool>((int)MessageField.FundNetOns, true),
                    new Tuple<int, bool>((int)MessageField.FundMovementfromRegistry, true),
                    new Tuple<int, bool>((int)MessageField.FundMovementtoRegistry, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 832-01 Holding Fund Balance
                // C to P or R
                "HoldingFundBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AdviceReason, true),
                    new Tuple<int, bool>((int)MessageField.TotalFundUnitBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 833-01 Total Security Fund Balance
                // C to R
                "TotalSecurityFundBalance" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalFundUnitsonRegister, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 834-01 Full Issuer Sponsored Fund to CHESS Conversion
                // C to P or R
                "FullIssuerSponsoredFundtoCHESSConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.InitialTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.NewFundHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 835-01 Full CHESS to Issuer Sponsored Fund Conversion
                // C to P or R
                "FullCHESStoIssuerSponsoredFundConversion" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HoldingTransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.MovementReason, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.SupplementaryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingRegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_1, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_2, false),
                    new Tuple<int, bool>((int)MessageField.TFN_ABN_3, false),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.NewFundHoldingBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 836 N/A

                // 838-01 CHESS to Registry Fund Balance Request
                // C to R
                "CHESStoRegistryFundBalanceRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    //Requesting PID
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.VerificationName, true),
                    new Tuple<int, bool>((int)MessageField.SecurityholderReferenceNumber, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 840-01 CHESS to Participant Fund Balance Response
                // C to R
                "CHESStoParticipantFundBalanceResponse" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.HoldingBalanceTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.FundHoldingBalance, true)
                }),

                // 842-01 CHESS to Participant Fund Balance Reject
                // C to P
                "CHESStoParticipantFundBalanceReject" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.RegistryRejectReason, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 844-01 Top Security Fund Holder Report
                // C to R
                "TopSecurityFundHolderReport" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.OpeningBalanceDate, true),
                    new Tuple<int, bool>((int)MessageField.ClosingBalanceDate, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.HolderType, true),
                    new Tuple<int, bool>((int)MessageField.ControllingPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.ResidencyIndicator, true),
                    new Tuple<int, bool>((int)MessageField.TotalFundMovementsOff, true),
                    new Tuple<int, bool>((int)MessageField.ClosingFundBalance, true),
                    new Tuple<int, bool>((int)MessageField.TotalFundMovementsOn, true),
                    new Tuple<int, bool>((int)MessageField.OpeningFundBalance, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 846-01 Effected Unit Reversal Notification
                // C to P
                "EffectedUnitReversalNotification" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.FundCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, true),
                    new Tuple<int, bool>((int)MessageField.OrderReference, false),
                    new Tuple<int, bool>((int)MessageField.OrderType, true),
                    new Tuple<int, bool>((int)MessageField.NumberofUnits, true),
                    new Tuple<int, bool>((int)MessageField.UnitPricingDate, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 848 N/A
                // 850 N/A
                // 852 N/A
                // 854 N/A
                // 856 N/A
                // 858 N/A

                // 860-01 Rejected Registry Authorisation
                // C to P
                "RejectedRegistryAuthorisation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.RejectedRegistryReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 862 N/A

                // 864-01 Distribution Election Authorisation Request
                // C to R
                "DistributionElectionAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.HolderDRPPreference, false),
                    new Tuple<int, bool>((int)MessageField.HolderRPPPreference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.BSBNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountNumber, false),
                    new Tuple<int, bool>((int)MessageField.AccountName, false),
                    new Tuple<int, bool>((int)MessageField.AccountPurpose, false),
                    new Tuple<int, bool>((int)MessageField.RPPFrequency, false),
                    new Tuple<int, bool>((int)MessageField.CurrentPDSProvided, true),
                    // DRP Units Participating
                    new Tuple<int, bool>((int)MessageField.PDSIssueDate, true),
                    new Tuple<int, bool>((int)MessageField.RPPAmount, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 866-01 Accepted Distribution Election Request
                // C to P
                "AcceptedDistributionElectionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 868-01 Income Statement Authorisation Request
                // C to R
                "IncomeStatementAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementReportFrequency, false),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementReportType, false),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementCancellation, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 870-01 Accepted Margin Cover Creation Request
                // C to P
                "AcceptedMarginCoverCreationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMarginCover, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 872-01 Margin Cover Creation Authorisation Request
                // C to P
                "MarginCoverCreationAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.ParticipantReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.RegistrationDetails, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 874-01 Effected Margin Cover Release and Transfer
                // C to P
                "EffectedMarginCoverReleaseandTransfer" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.ReceivingHIN, false),
                    new Tuple<int, bool>((int)MessageField.DeliveringHIN, false),
                    new Tuple<int, bool>((int)MessageField.ReceivingPID, true),
                    new Tuple<int, bool>((int)MessageField.DeliveringPID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement1, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement2, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement3, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement4, false),
                    new Tuple<int, bool>((int)MessageField.BasisOfMovement5, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.TransferorHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransfereeHoldingBalance, false),
                    new Tuple<int, bool>((int)MessageField.TransferorMarginCover, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.UnderlyingReference, false),
                    new Tuple<int, bool>((int)MessageField.EffectedTimestamp, true)
                }),

                // 876-01 Accepted Income Statement Request
                // C to P
                "AcceptedMarginCoverCreation" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 878-01 Reduced Margin Cover
                // C to P
                "ReducedMarginCover" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, false),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMarginCover, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 880-01 Accepted Margin Cover Removal Request
                // C to P
                "AcceptedMarginCoverRemovalRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 882-01 Margin Cover Removal Authorisation Request
                // C to P
                "MarginCoverRemovalAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 884-01 Accepted Income Statement Request
                // C to P
                "AcceptedIncomeStatementRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RegistryReference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 886 N/A
                // 888 N/A
                // 890 N/A
                // 892 N/A
                // 894 N/A
                // 896 N/A
                // 898 N/A
                // 900 N/A
                // 902 N/A Internal CHESS message
                // 904 N/A
                // 906 N/A
                // 908 N/A
                // 910 N/A
                // 912 N/A
                // 914 N/A Internal CHESS message
                // 916 N/A
                // 918 N/A
                // 920 N/A
                // 922 N/A
                // 924 N/A
                // 926 N/A
                // 928 N/A
                // 930 N/A

                // 932-01 Excess Cash Standing Instruction Authorisation Request
                // C to P
                "ExcessCashStandingInstructionAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ExcessCashStandingInstruction, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.RemoveExcessCashStandingInstruction, false)
                }),

                // 934-01 Accepted Excess Cash Standing Instruction Request
                // C to P
                "AcceptedExcessCashStandingInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 936-01 Effected Excess Cash Standing Instruction Request
                // C to P
                "EffectedExcessCashStandingInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 938-01 Rejected Excess Cash Standing Instruction Request
                // C to P
                "RejectedExcessCashStandingInstructionRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 940-01 Daily Interest Earned Statement
                // C to P
                "DailyInterestEarnedStatement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.InterestAmount, true),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.Principal, true),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.InterestDescription, true),
                    new Tuple<int, bool>((int)MessageField.InterestRate, true)
                }),

                // 942-01 Margin Settlement Advice
                // C to P
                "MarginSettlementAdvice" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.CashBalanceBoughtForward, true),
                    new Tuple<int, bool>((int)MessageField.MarginPaymentDate, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.CashPaymentWithdrawal, false),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.CashBalanceCarriedForward, true),
                    new Tuple<int, bool>((int)MessageField.InitialMargin, true),
                    new Tuple<int, bool>((int)MessageField.OtherMargin, true),
                    new Tuple<int, bool>((int)MessageField.UtilisedNon_CashCollateral, true),
                    new Tuple<int, bool>((int)MessageField.Excess_Shortage, true),
                    new Tuple<int, bool>((int)MessageField.ExcessCashStandingInstruction, false),
                    new Tuple<int, bool>((int)MessageField.ResultantCashBalance, false),
                    new Tuple<int, bool>((int)MessageField.ResultantExcess, false)
                }),

                // 944-01 Margin Settlement Amount Change Authorisation Request
                // C to P
                "MarginSettlementAmountChangeAuthorisationRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true)
                }),

                // 946-01 Accepted Margin Settlement Amount Change Request
                // C to P
                "AcceptedMarginSettlementAmountChangeRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 948-01 Effected Margin Settlement Amount Change
                // C to P
                "EffectedMarginSettlementAmountChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.NewSettlementAmount, true),
                    new Tuple<int, bool>((int)MessageField.NewResultantExcess, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 950-01 Rejected Margin Settlement Amount Change
                // C to P
                "RejectedMarginSettlementAmountChange" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RejectedChangeReason, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 952-01 Collateral Statement
                // C to P
                "CollateralStatement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, false),
                    new Tuple<int, bool>((int)MessageField.ISIN, false),
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.Account, true),
                    new Tuple<int, bool>((int)MessageField.HIN, false),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.Issuer, false),
                    new Tuple<int, bool>((int)MessageField.Reference, false),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.UnitQuantity, false),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.Market, true),
                    new Tuple<int, bool>((int)MessageField.FaceValue, false),
                    new Tuple<int, bool>((int)MessageField.MarketValue, true),
                    new Tuple<int, bool>((int)MessageField.Currency, false),
                    new Tuple<int, bool>((int)MessageField.NotificationType, true),
                    new Tuple<int, bool>((int)MessageField.ExpiryDate, false),
                    new Tuple<int, bool>((int)MessageField.CollateralType, true),
                    new Tuple<int, bool>((int)MessageField.UnitPrice, false),
                    new Tuple<int, bool>((int)MessageField.Issue, false),
                    new Tuple<int, bool>((int)MessageField.HaircutRate, true),
                    new Tuple<int, bool>((int)MessageField.LodgementDate, false),
                    new Tuple<int, bool>((int)MessageField.Yield, false),
                    new Tuple<int, bool>((int)MessageField.CollateralValue, true)
                }),

                // 954-01 End Statement
                // C to P
                "EndStatement" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalStatementCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 956-01 Rejected Margin Cover Removal Request
                // C to P
                "RejectedMarginCoverRemovalRequest" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.CollateralRejectedReason, true),
                    new Tuple<int, bool>((int)MessageField.TargetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 957-02 Registry Income Statement Part A
                // C to P
                "RegistryIncomeStatementPartA" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.PID, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.NonPrimaryIncome, false),
                    // Trust Franked Distributions
                    new Tuple<int, bool>((int)MessageField.FrankingCredit, false),
                    new Tuple<int, bool>((int)MessageField.TFNWithholding, false),
                    new Tuple<int, bool>((int)MessageField.AnnualCapitalGain, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.NetCapitalGain, false),
                    new Tuple<int, bool>((int)MessageField.AssessableForeignIncome, false),
                    new Tuple<int, bool>((int)MessageField.OtherForeignIncome, false),
                    new Tuple<int, bool>((int)MessageField.ForeignIncomeTaxOffsets, false),
                    new Tuple<int, bool>((int)MessageField.NonPrimaryDistributionDeductions, false)
                }),

                // 958-01 Accepted Registry Income Statement Set
                // C to R
                "AcceptedRegistryIncomeStatementSet" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 960-01 Rejected Registry Income Statement Set
                // C to R
                "RejectedRegistryIncomeStatementSet" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.RejectedIncomeStatementSetReason, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true)
                }),

                // 962-01 Participant Income Statement Part A
                // C to P
                "ParticipantIncomeStatementPartA" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.NonPrimaryIncome, false),
                    // Trust Franked Distributions
                    new Tuple<int, bool>((int)MessageField.FrankingCredit, false),
                    new Tuple<int, bool>((int)MessageField.TFNWithholding, false),
                    new Tuple<int, bool>((int)MessageField.AnnualCapitalGain, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.NetCapitalGain, false),
                    new Tuple<int, bool>((int)MessageField.AssessableForeignIncome, false),
                    new Tuple<int, bool>((int)MessageField.OtherForeignIncome, false),
                    new Tuple<int, bool>((int)MessageField.ForeignIncomeTaxOffsets, false),
                    new Tuple<int, bool>((int)MessageField.NonPrimaryDistributionDeductions, false)
                }),

                // 964-01 Participant Income Statement Part B
                // C to P
                "ParticipantIncomeStatementPartB" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.CapitalGainDiscount, false),
                    new Tuple<int, bool>((int)MessageField.CapitalGainOther, false),
                    new Tuple<int, bool>((int)MessageField.AnnualCapitalGainTotal, false),
                    new Tuple<int, bool>((int)MessageField.CGTConcession, false),
                    new Tuple<int, bool>((int)MessageField.TaxDeferred, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 966-01 Participant Income Statement Part C AI
                // C to P
                "ParticipantIncomeStatementPartCAi" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountCash, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountTax, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsFrankedAmountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsUnfrankedAmountCash, false),
                    new Tuple<int, bool>((int)MessageField.AIDividendsUnfrankedAmountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.AIInterestCash, false),
                    new Tuple<int, bool>((int)MessageField.AIInterestTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AIOtherIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.AIOtherIncomeTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AITrustDeductionsCash, false),
                    new Tuple<int, bool>((int)MessageField.AITrustDeductionsTaxable, false),
                    new Tuple<int, bool>((int)MessageField.AINonPrimaryIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.AINonPrimaryIncomeTaxable, false)
                }),

                // 968-01 Participant Income Statement Part C CG
                // C to P
                "ParticipantIncomeStatementPartCCG" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.CGDiscountCash, false),
                    new Tuple<int, bool>((int)MessageField.CGDiscountTax, false),
                    new Tuple<int, bool>((int)MessageField.CGDiscountTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGTaxConcessionCash, false),
                    new Tuple<int, bool>((int)MessageField.CGTaxConcessionTaxable, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodCash, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodTax, false),
                    new Tuple<int, bool>((int)MessageField.CGOtherMethodTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGDistributedCash, false),
                    new Tuple<int, bool>((int)MessageField.CGDistributedTax, false),
                    new Tuple<int, bool>((int)MessageField.CGTrustDeductionsTaxable, false),
                    new Tuple<int, bool>((int)MessageField.CGNet, false)
                }),

                // 970-01 Participant Income Statement Part C FI
                // C to P
                "ParticipantIncomeStatementPartCFI" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeCash, false),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeTax, false),
                    new Tuple<int, bool>((int)MessageField.FIAssessableIncomeTaxable, false),
                    // FI Cash Cash
                    // FI Cash Tax
                    new Tuple<int, bool>((int)MessageField.APIRCode, false),
                    // FI Cash Cash Sub-Total
                }),

                // 972-01 Participant Income Statement Part C NA
                // C to P
                "ParticipantIncomeStatementPartCNA" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.NATaxExemptedAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.NATaxDeferredAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.NAGrossCash, false),
                    new Tuple<int, bool>((int)MessageField.NATaxFreeAmountsCash, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 974-01 Participant Income Statement Part C OD
                // C to P
                "ParticipantIncomeStatementPartCOD" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.SecurityCode, true),
                    new Tuple<int, bool>((int)MessageField.HIN, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.IncomeStatementStatus, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.OriginTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.AsAtDate, true),
                    new Tuple<int, bool>((int)MessageField.ODTFNAmountsWithheld, false),
                    new Tuple<int, bool>((int)MessageField.ODOtherExpenses, false),
                    new Tuple<int, bool>((int)MessageField.ODNetCash, false),
                    new Tuple<int, bool>((int)MessageField.APIRCode, false)
                }),

                // 976-01 End Participant Income Statement Set
                // C to P
                "EndParticipantIncomeStatementSet" => GetFields(msg, new List<Tuple<int, bool>>()
                {
                    new Tuple<int, bool>((int)MessageField.Date, true),
                    new Tuple<int, bool>((int)MessageField.ProcessingTimestamp, true),
                    new Tuple<int, bool>((int)MessageField.TransactionId, true),
                    new Tuple<int, bool>((int)MessageField.SetTransactionId, true),
                    new Tuple<int, bool>((int)MessageField.TotalMessageCount, true)
                }),
                #endregion 801-02 to 976-01

                _ => throw new ArgumentException($"{tp} is an invalid message type.")
            };

            return result;
        }
    }
}
