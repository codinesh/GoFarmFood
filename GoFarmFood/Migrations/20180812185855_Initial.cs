using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoFarmFood.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    CompleteAddress = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false),
                    CardId = table.Column<Guid>(nullable: false),
                    CardDetails = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressId = table.Column<Guid>(nullable: false),
                    Proximity = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressId = table.Column<Guid>(nullable: false),
                    Proximity = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farmers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Riders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressId = table.Column<Guid>(nullable: false),
                    Proximity = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Riders_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ConsumerId = table.Column<Guid>(nullable: false),
                    FarmerId = table.Column<Guid>(nullable: false),
                    ProductItemId = table.Column<Guid>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PaymentInformationId = table.Column<Guid>(nullable: true),
                    RiderId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Farmers_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentInformation_PaymentInformationId",
                        column: x => x.PaymentInformationId,
                        principalTable: "PaymentInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Riders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreferredFarmer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ConsumerId = table.Column<Guid>(nullable: false),
                    FarmerId = table.Column<Guid>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    RiderId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredFarmer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreferredFarmer_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferredFarmer_Riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Riders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvailableItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FarmerId = table.Column<Guid>(nullable: false),
                    ProductItemId = table.Column<Guid>(nullable: false),
                    CapacityPerDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableItems_Farmers_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableItems_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressId = table.Column<Guid>(nullable: false),
                    ProductItemId = table.Column<Guid>(nullable: false),
                    PricePerUnit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OrderId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_FarmerId",
                table: "AvailableItems",
                column: "FarmerId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_ProductItemId",
                table: "AvailableItems",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_AddressId",
                table: "Consumers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Farmers_AddressId",
                table: "Farmers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FarmerId",
                table: "Orders",
                column: "FarmerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentInformationId",
                table: "Orders",
                column: "PaymentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RiderId",
                table: "Orders",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredFarmer_ConsumerId",
                table: "PreferredFarmer",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredFarmer_RiderId",
                table: "PreferredFarmer",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductItemId",
                table: "ProductPrice",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Riders_AddressId",
                table: "Riders",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableItems");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "PreferredFarmer");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Farmers");

            migrationBuilder.DropTable(
                name: "PaymentInformation");

            migrationBuilder.DropTable(
                name: "Riders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
