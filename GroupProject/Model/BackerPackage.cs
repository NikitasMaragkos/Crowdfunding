﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdfunding.Model
{

    public class BackerPackage
    {
        public int Id { get; set; }
        public Backer Backer { get; set; }
        public FundingPackage FundingPackage{ get; set; }

    }
}