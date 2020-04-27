using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkFlow.Infra.Data.Migrations
{
    public partial class my : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlows_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatorNumber = table.Column<int>(nullable: false),
                    OperatorTypeId = table.Column<int>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operators_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operators_OperatorTypes_OperatorTypeId",
                        column: x => x.OperatorTypeId,
                        principalTable: "OperatorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StepOrder = table.Column<int>(nullable: false),
                    IsFinalStep = table.Column<bool>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_WorkFlows_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "WorkFlows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstanceNumber = table.Column<int>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    WorkFlowId = table.Column<int>(nullable: false),
                    CurrentStepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instances_Steps_CurrentStepId",
                        column: x => x.CurrentStepId,
                        principalTable: "Steps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instances_WorkFlows_WorkFlowId",
                        column: x => x.WorkFlowId,
                        principalTable: "WorkFlows",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StepActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StepActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StepActions_Steps_StepId",
                        column: x => x.StepId,
                        principalTable: "Steps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstaneActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UserNumber = table.Column<int>(nullable: false),
                    InstanceId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    StepId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstaneActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstaneActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InstaneActions_Instances_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InstaneActions_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InstaneActions_Steps_StepId",
                        column: x => x.StepId,
                        principalTable: "Steps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActionOperators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MustApproveToMoveNext = table.Column<int>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    StepActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionOperators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionOperators_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActionOperators_StepActions_StepActionId",
                        column: x => x.StepActionId,
                        principalTable: "StepActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionOperators_OperatorId",
                table: "ActionOperators",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionOperators_StepActionId",
                table: "ActionOperators",
                column: "StepActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_CurrentStepId",
                table: "Instances",
                column: "CurrentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_WorkFlowId",
                table: "Instances",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_InstaneActions_ActionId",
                table: "InstaneActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstaneActions_InstanceId",
                table: "InstaneActions",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_InstaneActions_OperatorId",
                table: "InstaneActions",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstaneActions_StepId",
                table: "InstaneActions",
                column: "StepId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_ApplicationId",
                table: "Operators",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_OperatorTypeId",
                table: "Operators",
                column: "OperatorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StepActions_ActionId",
                table: "StepActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_StepActions_StepId",
                table: "StepActions",
                column: "StepId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_WorkFlowId",
                table: "Steps",
                column: "WorkFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_ApplicationId",
                table: "WorkFlows",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionOperators");

            migrationBuilder.DropTable(
                name: "InstaneActions");

            migrationBuilder.DropTable(
                name: "StepActions");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "OperatorTypes");

            migrationBuilder.DropTable(
                name: "WorkFlows");

            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
