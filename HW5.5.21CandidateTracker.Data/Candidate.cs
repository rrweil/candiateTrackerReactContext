﻿using System;

namespace HW5._5._21CandidateTracker.Data
{
    public class Candidate
    {
        public int Id { get; set;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public Status Status { get; set; }
    }
}
