namespace DemoHub.Common.Enums
{
    /// <Summary>
    /// Represents a collection of Calastone enumaration values.
    /// </Summary>
    public class CalastoneEnums
    {
        /// <Summary>
        /// Represents a fund Id type: ISIN, SEDOL or APIR.
        /// </Summary>
        #region Fund ID Type
        public enum FundIDType
        {
            /// <Summary>
            /// Default
            /// </Summary>
            UKWN,

            /// <Summary>
            /// International Securities Identification Number
            /// </Summary>
            ISIN,

            /// <Summary>
            /// Stock Exchange Daily Official List
            /// </Summary>
            SEDOL,

            /// <Summary>
            /// Asia Pacific Investment Register
            /// </Summary>
            APIR
        }
        #endregion Fund ID Type

        /// <Summary>
        /// Represents a transaction type.
        /// </Summary>
        #region Transaction Type
        public enum TransactionType
        {
            /// <Summary>
            /// Default
            /// </Summary>
            Unsupported,

            /// <Summary>
            /// Additional Application Order/Order Confirmation
            /// </Summary>
            Subscription,

            /// <Summary>
            /// Redemption Order/Order Confirmation
            /// </Summary>
            Redemption,

            /// <Summary>
            /// Switch out Order/Order Confirmation
            /// </Summary>
            SwitchRedemption,

            /// <Summary>
            /// Switch in Order/Order Confirmation
            /// </Summary>
            SwitchSubscription
        }
        #endregion Transaction Type

        /// <Summary>
        /// Represents a transaction request's or a transaction's status.
        /// </Summary>
        #region Transaction Status
        public enum TransactionStatus
        {
            /// <Summary>
            /// Request is received from Calastone
            /// </Summary>
            Received = 1,

            /// <Summary>
            /// Request is sent to TAURUS
            /// </Summary>
            SentToRegistry = 2,

            /// <Summary>
            /// Request is being processing in TAURUS
            /// </Summary>
            ProcessingInRegistry = 3,

            /// <Summary>
            /// Request is accepted for further processing
            /// </Summary>
            BusinessAccepted = 4,

            /// <Summary>
            /// Order request is rejected
            /// </Summary>
            BusinessRejected = 5,

            /// <Summary>
            /// Order is in repair
            /// </Summary>
            InRepair = 6,

            /// <Summary>
            /// Order is cancelled by registry or user
            /// </Summary>
            Cancelled = 7,

            /// <Summary>
            /// Request is valid
            /// </Summary>
            Validated = 8,

            /// <Summary>
            /// Transaction is ready to be sent to Calastone
            /// </Summary>
            ReadyToBeConfirmed = 9,

            /// <Summary>
            /// Order confirmation is sent to Calastone
            /// </Summary>
            SentToCTN = 10
        }
        #endregion Transaction Status

        /// <Summary>
        /// Represents a calastone order's status.
        /// </Summary>
        #region Order status
        public enum OrderStatus
        {
            /// <Summary>
            /// Accepted
            /// </Summary>
            PACK = 1,

            /// <Summary>
            /// Already Executed
            /// </Summary>
            COSE = 2,

            /// <Summary>
            /// Sent To Next Party
            /// </Summary>
            STNP = 3,

            /// <Summary>
            /// Received
            /// </Summary>
            RECE = 4,

            /// <Summary>
            /// Settled
            /// </Summary>
            SETT = 5,

            /// <Summary>
            /// Communication Problem Next Party
            /// </Summary>
            CPNP = 6,

            /// <Summary>
            /// Confirmation Amendment
            /// </Summary>
            CNFC = 7,

            /// <Summary>
            /// Done For Day
            /// </Summary>
            DONE = 8,

            /// <Summary>
            /// Partially Done
            /// </Summary>
            DONF = 9,

            /// <Summary>
            /// Open
            /// </Summary>
            OPOD = 10,

            /// <Summary>
            /// Invalid Agent Confirmation
            /// </Summary>
            IACO = 11
        }
        #endregion Order status

        /// <Summary>
        /// Represents a UK tax group unit.
        /// </Summary>
        #region Group Unit
        public enum GroupUnit
        {
            /// <Summary>
            /// UK Tax Group 1 Unit
            /// </Summary>
            GRP1 = 1,

            /// <Summary>
            /// UK Tax Group 2 Unit
            /// </Summary>
            GRP2 = 2,
        }
        #endregion Group Unit

        /// <Summary>
        /// Represents a rounding code.
        /// </Summary>
        #region Rounding
        public enum Rounding
        {
            /// <Summary>
            /// Round up to the nearest whole number
            /// </Summary>
            RDUP = 1,

            /// <Summary>
            /// Round down to the nearest whole number
            /// </Summary>
            RDWN = 2,
        }
        #endregion Rounding

        /// <Summary>
        /// Represents a unit price type.
        /// </Summary>
        #region Price Type
        public enum PriceType
        {
            /// <Summary>
            /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), ie, the selling price of the units for the investor.
            /// </Summary>
            BIDE = 1,

            /// <Summary>
            /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), ie, the buying price of the units for an investor.
            /// </Summary>
            OFFR = 2,

            /// <Summary>
            /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
            /// </Summary>
            NAVL = 3,

            /// <Summary>
            /// Price is the calculated creation of price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
            /// </Summary>
            CREA = 4,

            /// <Summary>
            /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of units on any one-day. The actual selling or bid price is usually higher.
            /// </Summary>
            CANC = 5,

            /// <Summary>
            /// Price is the average price between the bid and offer prices.
            /// </Summary>
            INTE = 6,

            /// <Summary>
            /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
            /// </Summary>
            SWNG = 7,

            /// <Summary>
            /// Price is the average price between the bid and offer prices.
            /// </Summary>
            MIDD = 8,

            /// <Summary>
            /// Price is the price used when reinvesting units after distribution.
            /// </Summary>
            RINV = 9,

            /// <Summary>
            /// Price is the price used when transferring units between products.
            /// </Summary>
            SWIC = 10,

            /// <Summary>
            /// Price is the net oncome of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
            /// </Summary>
            DDVR = 11,

            /// <Summary>
            /// True offer price.
            /// </Summary>
            ACTU = 12
        }
        #endregion Price Type

        /// <Summary>
        /// Represents a business reject reason code.
        /// </Summary>
        #region Business reject reason
        public enum RejectedReasonCode
        {
            /// <Summary>
            /// Investment account is blocked due to a corporate action.
            /// </Summary>
            BLCA = 1,

            /// <Summary>
            /// Investment account is blocked due to a transfer out of investment funds.
            /// </Summary>
            BLTR = 2,

            /// <Summary>
            /// Investment account is blocked until certain legal proceedings are completed, eg, legal documents from the successor, legal proceedings due to bankruptcy.
            /// </Summary>
            DOCC = 3,

            /// <Summary>
            /// Instruction was received after the Receiver's deadline.
            /// </Summary>
            ADEA = 4,

            /// <Summary>
            /// Assets are illiquid.
            /// </Summary>
            ILLI = 5,

            /// <Summary>
            /// Amount of subscription is below the minimum initial investment amount.
            /// </Summary>
            BMIN = 6,

            /// <Summary>
            /// Amount is below the minimum redemption amount.
            /// </Summary>
            BMRA = 7,

            /// <Summary>
            /// Holding will be below the minimum retained value.
            /// </Summary>
            BMRV = 8,

            /// <Summary>
            /// Instruction has been received after the cut-off time.
            /// </Summary>
            CUTO = 9,

            /// <Summary>
            /// Delivering agent is not recognised or is invalid.
            /// </Summary>
            ICAG = 10,

            /// <Summary>
            /// Direct debit account identification is not recognised or is invalid.
            /// </Summary>
            IDDB = 11,

            /// <Summary>
            /// Order reference is a duplicate of a previously received order.
            /// </Summary>
            ORRF = 12,

            /// <Summary>
            /// Unrecognised or invalid fee or commission.
            /// </Summary>
            FEEE = 13,

            /// <Summary>
            /// Identification of the security is not recognised or is invalid.
            /// </Summary>
            DSEC = 14,

            /// <Summary>
            /// Identification of the security and the security name are not the same.
            /// </Summary>
            IDNA = 15,

            /// <Summary>
            /// Financial instrument quantity is invalid.
            /// </Summary>
            DQUA = 16,

            /// <Summary>
            /// Fund is closed and will not take in any more investments.
            /// </Summary>
            CLOS = 17,

            /// <Summary>
            /// Instructing party is not allowed to instruct for this investment account.
            /// </Summary>
            IPAC = 18,

            /// <Summary>
            /// Insufficient capacity.
            /// </Summary>
            INSU = 19,

            /// <Summary>
            /// Intermediary is not recognised or is invalid.
            /// </Summary>
            INTE = 20,

            /// <Summary>
            /// Cash account is not recognised or invalid.
            /// </Summary>
            CASH = 21,

            /// <Summary>
            /// Credit transfer details are incorrect.
            /// </Summary>
            ICTR = 22,

            /// <Summary>
            /// Order type is invalid.
            /// </Summary>
            IOTP = 23,

            /// <Summary>
            /// Form of the security is wrong, eg, the form of security is registered not bearer or vice versa.
            /// </Summary>
            DFOR = 24,

            /// <Summary>
            /// Unrecognised or invalid settlement amount.
            /// </Summary>
            DMON = 25,

            /// <Summary>
            /// Investment account identification is not recognised or is invalid.
            /// </Summary>
            SAFE = 26,

            /// <Summary>
            /// Lock-up period is in place.
            /// </Summary>
            LOCK = 27,

            /// <Summary>
            /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
            /// </Summary>
            NRGM = 28,

            /// <Summary>
            /// Instruction is not compliant with the service level agreement.
            /// </Summary>
            NSLA = 29,

            /// <Summary>
            /// There is not enough cash in the account to process the instruction.
            /// </Summary>
            MONY = 30,

            /// <Summary>
            /// There are not enough securities in the account to process the instruction.
            /// </Summary>
            SECU = 31,

            /// <Summary>
            /// Payment card details are incorrect.
            /// </Summary>
            IPAY = 32,

            /// <Summary>
            /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
            /// </Summary>
            PRCT = 33,

            /// <Summary>
            /// Order contains physical delivery details but the fund can not be physically delivered.
            /// </Summary>
            DLVY = 34,

            /// <Summary>
            /// Physical Settlement Impossible.
            /// </Summary>
            PHYS = 35,

            /// <Summary>
            /// Unrecognised or invalid Place of Trade.
            /// </Summary>
            PLCE = 36,

            /// <Summary>
            /// Receiving agent is not recognised or is invalid.
            /// </Summary>
            IVAG = 37,

            /// <Summary>
            /// Impossible to use RTGS System.
            /// </Summary>
            RTGS = 38,

            /// <Summary>
            /// Safekeeping place is not recognised or is invalid.
            /// </Summary>
            ISAF = 39,

            /// <Summary>
            /// Unrecognised or invalid Settlement Amount Currency.
            /// </Summary>
            NCRR = 40,

            /// <Summary>
            /// Cash settlement date is not recognised or is invalid.
            /// </Summary>
            DDAT = 41,

            /// <Summary>
            /// Place of settlement is not recognised or is invalid.
            /// </Summary>
            DEPT = 42,

            /// <Summary>
            /// Unrecognised or invalid Settlement Transaction.
            /// </Summary>
            SETR = 43,

            /// <Summary>
            /// Unrecognised or invalid subscriber or redeemer.
            /// </Summary>
            IEXE = 44,

            /// <Summary>
            /// Quantity of units or amount of money in the order is too high for a subscription.
            /// </Summary>
            SHIG = 45,

            /// <Summary>
            /// Instruction was received after market deadline.
            /// </Summary>
            LATE = 46,

            /// <Summary>
            /// Quantity of units or amount of money in the order is too low for a subscription.
            /// </Summary>
            SLOW = 47,

            /// <Summary>
            /// Unrecognised or invalid Requested Future Trade Date.
            /// </Summary>
            DTRD = 48,

            /// <Summary>
            /// Percentage of commission waiving exceeds the commission percentage or commission amount.
            /// </Summary>
            UWAI = 49,

            /// <Summary>
            /// Deal currency is not supported.
            /// </Summary>
            UDCY = 50,

            /// <Summary>
            /// Net asset value currency is not supported.
            /// </Summary>
            UNAV = 51,

            /// <Summary>
            /// Payment method, eg, cheque or payment card, is not accepted.
            /// </Summary>
            UPAY = 52,

            /// <Summary>
            /// Settlement currency requested is not supported.
            /// </Summary>
            URSC = 53,

            /// <Summary>
            /// Linked reference is not known.
            /// </Summary>
            ULNK = 54,

            /// <Summary>
            /// Settlement currency requested is not supported.
            /// </Summary>
            UNSC = 55,

            /// <Summary>
            /// Order contains funds that have different valuation points.
            /// </Summary>
            POIN = 56
        }
        #endregion Business reject reason

        /// <Summary>
        /// Represents a currency that Calastone supports.
        /// </Summary>
        #region Currency
        public enum Currency
        {
            /// <Summary>
            /// United Kingdom Pound
            /// </Summary>
            GBP = 48,

            /// <Summary>
            /// Japan Yen
            /// </Summary>
            JPY = 72,

            /// <Summary>
            /// Switzerland Franc
            /// </Summary>
            CHF = 29,

            /// <Summary>
            /// Romania New Leu
            /// </Summary>
            RON = 116,

            /// <Summary>
            /// Sweden Krona
            /// </Summary>
            SEK = 124,

            /// <Summary>
            /// Hong Kong Dollar
            /// </Summary>
            HKD = 57,

            /// <Summary>
            /// South Africa Rand
            /// </Summary>
            ZAR = 160,

            /// <Summary>
            /// Poland Zloty
            /// </Summary>
            PLN = 113,

            /// <Summary>
            /// Czech Republic Koruna
            /// </Summary>
            CZK = 37,

            /// <Summary>
            /// Canada Dollar
            /// </Summary>
            CAD = 27,

            /// <Summary>
            /// Euro Member Countries
            /// </Summary>
            EUR = 45,

            /// <Summary>
            /// New Zealand Dollar
            /// </Summary>
            NZD = 2,

            /// <Summary>
            /// Singapore Dollar
            /// </Summary>
            SGD = 125,

            /// <Summary>
            /// Australia Dollar
            /// </Summary>
            AUD = 1,

            /// <Summary>
            /// Denmark Krone
            /// </Summary>
            DKK = 39,

            /// <Summary>
            /// Norway Krone
            /// </Summary>
            NOK = 105,

            /// <Summary>
            /// United States Dollar
            /// </Summary>
            USD = 147,

            /// <Summary>
            /// China Yuan Renminbi
            /// </Summary>
            CNY = 31,

            /// <Summary>
            /// Thailand Baht
            /// </Summary>
            THB = 135
        }
        #endregion Currency
    }
}