using System;

namespace TennisAustraliaAssignment.Models
{
    //error model
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
