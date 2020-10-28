using System;

namespace CREDIT_CARD
{
    [Serializable]
    public class Setting
    {
        public string name;
        public int minLen;
        public int maxLen;
        public string[] firstNumbers;
    }
}