﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDDEastAnglia.Models
{
    public class SessionDisplayModel
    {
        public string SessionAbstract { get; set; }
        public int SessionId { get; set; }
        public string SessionTitle { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerUserName { get; set; }
    }
}