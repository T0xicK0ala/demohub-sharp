using System;

namespace DemoHub.Common
{
    public static class MessageDeduplicationIdGenerator
    {
        public static string New(string name)
        {
            return $"{name}-{Guid.NewGuid().ToString()}";
        }
    }
}
