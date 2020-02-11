﻿// <copyright file="20191126172117_ValueObjects.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Infrastructure.EntityFrameworkDataAccess.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ValueObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 11, 26, 17, 21, 17, 192, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 11, 26, 17, 21, 17, 192, DateTimeKind.Utc).AddTicks(2670));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(6780));
        }
    }
}
