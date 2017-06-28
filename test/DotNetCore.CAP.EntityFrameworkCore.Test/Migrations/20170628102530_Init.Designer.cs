﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotNetCore.CAP.EntityFrameworkCore.Test;

namespace DotNetCore.CAP.EntityFrameworkCore.Test.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20170628102530_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCore.CAP.Infrastructure.CapReceivedMessage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<string>("Content");

                    b.Property<string>("KeyName");

                    b.Property<DateTime>("LastRun");

                    b.Property<int>("Retries");

                    b.Property<string>("StateName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CapReceivedMessages");
                });

            modelBuilder.Entity("DotNetCore.CAP.Infrastructure.CapSentMessage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<string>("Content");

                    b.Property<string>("KeyName");

                    b.Property<DateTime>("LastRun");

                    b.Property<int>("Retries");

                    b.Property<string>("StateName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CapSentMessages");
                });
        }
    }
}
