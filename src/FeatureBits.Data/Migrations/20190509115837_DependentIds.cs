﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FeatureBitsData.Migrations
{
    public partial class DependentIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DependentIds",
                table: "FeatureBitDefinitions",
                nullable: true,
                maxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DependentIds",
                table: "FeatureBitDefinitions");
        }
    }
}
