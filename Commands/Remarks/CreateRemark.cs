﻿using System;
using System.Collections.Generic;
using Collectively.Messages.Commands.Remarks.Models;
using Collectively.Messages.Commands;

namespace Collectively.Messages.Commands.Remarks
{
    public class CreateRemark : IAuthenticatedCommand
    {
        public Guid RemarkId { get; set; }
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Category { get; set; }
        public RemarkFile Photo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public IList<string> Tags { get; set; }
        public IList<SocialMedia> SocialMedia { get; set; }
    }
}