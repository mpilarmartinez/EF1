﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC1.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){
    }

} 

