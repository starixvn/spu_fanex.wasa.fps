using System;
using System.Collections.Generic;
using System.Linq;

namespace Fanex.WASA.FPS.Evidence.Model
{
    public class TrustEvidence
    {
        private static readonly char[] SPLITCHARS = { ';', ',' };

        public List<string> Codes
        {
            get
            {
                if (string.IsNullOrWhiteSpace(EviCodeIds))
                {
                    return new List<string>();
                }

                return EviCodeIds.Split(SPLITCHARS, StringSplitOptions.RemoveEmptyEntries).Select(s => s).ToList();
            }
        }

        public bool Enable { get; set; }

        public List<int> GroupIds
        {
            get
            {
                if (string.IsNullOrWhiteSpace(EviGroupIds))
                {
                    return new List<int>();
                }

                return EviGroupIds.Split(SPLITCHARS, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            }
        }

        public int SubscriberId { get; set; }

        public string? EviCodeIds { get; set; }

        public string? EviGroupIds { get; set; }
    }
}
