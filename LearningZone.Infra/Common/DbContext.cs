﻿using LearningZone.Core.Common;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace LearningZone.Infra.Common
{
    public class DbContext : IDbContext
    {
        private DbConnection _Connection;
        private readonly IConfiguration _configuration;
        public DbContext (IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new OracleConnection(_configuration["ConnectionStrings:DefaultConnection"]);
                    _Connection.Open();

                }
                else if (_Connection.State != ConnectionState.Open)
                {
                    _Connection.Open();
                }
                return _Connection;
            }
        }
    }
}
