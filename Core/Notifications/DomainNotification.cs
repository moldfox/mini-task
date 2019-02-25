﻿using Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Notifications
{
    /// <summary>
    /// contain Notification rasied
    /// </summary>
   public class DomainNotification : Event
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }
    }
}
