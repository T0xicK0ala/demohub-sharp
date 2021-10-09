namespace DemoHub.Common.Enums
{
    /// <summary>
    /// Represents a collection of Demo Hub enumaration values.
    /// </Summary>
    public class HubEnums
    {
        /// <summary>
        /// Represents a transaction request's resource.
        /// </Summary>
        #region Transaction request resource
        public enum TransactionRequestResource
        {
            Unkwown,
            /// <summary>
            /// TAURUS
            /// </Summary>
            TAURUS,
            /// <summary>
            /// Calastone Transaction Network
            /// </Summary>
            Calastone,
            /// <summary>
            /// Clearing House Electronic Sub-Register System
            /// </Summary>
            CHESS,
            /// <summary>
            /// Xplan
            /// </Summary>
            Xplan,
            /// <summary>
            /// MoneyTree
            /// </Summary>
            MoneyTree
        }
        #endregion Transaction request resource

        /// <summary>
        /// Represents a HTTP method.
        /// </Summary>
        #region HTTP method
        public enum HTTPMethod
        {
            /// <summary>
            /// HTTP Get
            /// </Summary>
            Get = 1,

            /// <summary>
            /// HTTP Post
            /// </Summary>
            Post = 2,

            /// <summary>
            /// HTTP Put
            /// </Summary>
            Put = 3
        }
        #endregion HTTP method
    }
}