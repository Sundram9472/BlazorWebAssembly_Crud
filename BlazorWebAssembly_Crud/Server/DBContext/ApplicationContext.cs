﻿using BlazorWebAssembly_Crud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssembly_Crud.Server.DBContext
{
    public class ApplicationContext:DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
        public DbSet<Employee> Employees_sk { get; set; }
    }
}
