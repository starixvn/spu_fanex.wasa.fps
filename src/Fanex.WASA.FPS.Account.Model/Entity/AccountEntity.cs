using Fanex.WASA.FPS.Subcriber.Model.Entity;
using System;

namespace Fanex.WASA.FPS.Account.Model.Entity
{
    public class AccountEntity
    {
        private const string _NA = "N/A";

        private string? _username;

        public string UserName
        {
            get
            {
                return string.IsNullOrEmpty(_username) ? _NA : _username;
            }

            set
            {
                _username = value;
            }
        }

        public string? UserName2
        {
            get;
            set;
        }

        public int Id { get; set; }

        public SubscriberEntity? Subscriber { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
